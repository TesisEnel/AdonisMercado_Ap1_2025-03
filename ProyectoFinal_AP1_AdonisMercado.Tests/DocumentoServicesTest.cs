using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Moq;
using ProyectoFinal_AP1_AdonisMercado.DAL;
using ProyectoFinal_AP1_AdonisMercado.Models;
using ProyectoFinal_AP1_AdonisMercado.Services;
using Xunit;

namespace ProyectoFinal_AP1_AdonisMercado.Tests;

public class DocumentoServicesTest
{
    private static Contexto CreateInMemoryDb(string dbName)
    {
        var options = new DbContextOptionsBuilder<Contexto>()
            .UseInMemoryDatabase(dbName)
            .Options;

        return new Contexto(options);
    }

    private static DocumentoServices CreateService(
        string dbName,
        Mock<ICloudflareR2Service> r2Mock)
    {
        var dbFactoryMock = new Mock<IDbContextFactory<Contexto>>();

        dbFactoryMock
            .Setup(f => f.CreateDbContextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(() => CreateInMemoryDb(dbName));

        return new DocumentoServices(dbFactoryMock.Object, r2Mock.Object);
    }

    private static Mock<IBrowserFile> CreateFile(
        string nombre,
        long tamano,
        string tipoContenido)
    {
        var fileMock = new Mock<IBrowserFile>();
        fileMock.Setup(f => f.Name).Returns(nombre);
        fileMock.Setup(f => f.Size).Returns(tamano);
        fileMock.Setup(f => f.ContentType).Returns(tipoContenido);
        fileMock
            .Setup(f => f.OpenReadStream(It.IsAny<long>(), It.IsAny<CancellationToken>()))
            .Returns(new MemoryStream(new byte[] { 1 }));

        return fileMock;
    }

    [Fact]
    public async Task Guardar_ArchivoValido_GuardaDocumento()
    {
        var dbName = Guid.NewGuid().ToString();

        using (var seed = CreateInMemoryDb(dbName))
        {
            seed.Pedidos.Add(new Pedido
            {
                PedidoId = 1,
                Estado = "Pendiente"
            });
            await seed.SaveChangesAsync();
        }

        var r2Mock = new Mock<ICloudflareR2Service>();
        r2Mock
            .Setup(r => r.SubirArchivo(
                It.IsAny<IBrowserFile>(),
                It.IsAny<string>(),
                It.IsAny<string>()))
            .ReturnsAsync("https://cdn.test.com/documentos/test.pdf");

        var service = CreateService(dbName, r2Mock);
        var archivo = CreateFile("test.pdf", 100, "application/pdf");

        var resultado = await service.Guardar(archivo.Object, 1, "Factura");

        Assert.True(resultado);

        using var verify = CreateInMemoryDb(dbName);
        Assert.Equal(1, verify.Documentos.Count());
    }

    [Fact]
    public async Task Guardar_ArchivoMuyGrande_RetornaFalse()
    {
        var dbName = Guid.NewGuid().ToString();

        var r2Mock = new Mock<ICloudflareR2Service>();
        var service = CreateService(dbName, r2Mock);

        var archivo = CreateFile("big.pdf", 20 * 1024 * 1024, "application/pdf");

        var resultado = await service.Guardar(archivo.Object, 1, "Factura");

        Assert.False(resultado);

        r2Mock.Verify(
            r => r.SubirArchivo(
                It.IsAny<IBrowserFile>(),
                It.IsAny<string>(),
                It.IsAny<string>()),
            Times.Never);
    }

    [Fact]
    public async Task Guardar_ExtensionNoPermitida_RetornaFalse()
    {
        var dbName = Guid.NewGuid().ToString();

        var r2Mock = new Mock<ICloudflareR2Service>();
        var service = CreateService(dbName, r2Mock);

        var archivo = CreateFile("virus.exe", 100, "application/octet-stream");

        var resultado = await service.Guardar(archivo.Object, 1, "Factura");

        Assert.False(resultado);

        r2Mock.Verify(
            r => r.SubirArchivo(
                It.IsAny<IBrowserFile>(),
                It.IsAny<string>(),
                It.IsAny<string>()),
            Times.Never);
    }

    [Fact]
    public async Task ObtenerDocumentosPorPedido_RetornaLista()
    {
        var dbName = Guid.NewGuid().ToString();

        using (var seed = CreateInMemoryDb(dbName))
        {
            seed.Documentos.Add(new Documento { DocumentoId = 1, PedidoId = 1 });
            seed.Documentos.Add(new Documento { DocumentoId = 2, PedidoId = 1 });
            await seed.SaveChangesAsync();
        }

        var r2Mock = new Mock<ICloudflareR2Service>();
        var service = CreateService(dbName, r2Mock);

        var documentos = await service.ObtenerDocumentosPorPedido(1);

        Assert.Equal(2, documentos.Count);
    }

    [Fact]
    public async Task Eliminar_DocumentoExistente_EliminaCorrectamente()
    {
        var dbName = Guid.NewGuid().ToString();

        using (var seed = CreateInMemoryDb(dbName))
        {
            seed.Documentos.Add(new Documento
            {
                DocumentoId = 1,
                PedidoId = 1,
                RutaDocumento = "https://cdn.test.com/documentos/test.pdf"
            });
            await seed.SaveChangesAsync();
        }

        var r2Mock = new Mock<ICloudflareR2Service>();
        r2Mock
            .Setup(r => r.EliminarArchivo(It.IsAny<string>()))
            .ReturnsAsync(true);

        var service = CreateService(dbName, r2Mock);

        var resultado = await service.Eliminar(1);

        Assert.True(resultado);

        using var verify = CreateInMemoryDb(dbName);
        Assert.Empty(verify.Documentos);

        r2Mock.Verify(
            r => r.EliminarArchivo(It.IsAny<string>()),
            Times.Once);
    }
}
