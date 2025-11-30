using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_AP1_AdonisMercado.DAL;
using ProyectoFinal_AP1_AdonisMercado.Models;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace ProyectoFinal_AP1_AdonisMercado.Services;

public class DocumentoServices
{
    private readonly IDbContextFactory<Contexto> DbFactory;
    private readonly string uploadFolder;

    public DocumentoServices(IDbContextFactory<Contexto> dbContextFactory, IWebHostEnvironment env)
    {
        DbFactory = dbContextFactory;
        uploadFolder = Path.Combine(env.WebRootPath, "documento_pedido");

        if (!Directory.Exists(uploadFolder))
        {
            Directory.CreateDirectory(uploadFolder);
        }
    }

    public async Task<bool> Guardar(IBrowserFile archivo, int pedidoId, string tipoDocumento)
    {
        if (archivo == null)
        {
            return false;
        }

        const long maxSize = 10485760; // 10 MB
        if (archivo.Size > maxSize)
        {
            return false;
        }

        var extensiones = new[] { ".pdf", ".jpg", ".jpeg", ".png" };
        var extension = Path.GetExtension(archivo.Name).ToLowerInvariant();

        if (!extensiones.Contains(extension))
        {
            return false;
        }

        var nombreAlmacenado = $"{Guid.NewGuid()}{extension}";
        var rutaCompleta = Path.Combine(uploadFolder, nombreAlmacenado);

        await using var stream = new FileStream(rutaCompleta, FileMode.Create);
        await archivo.OpenReadStream(maxSize).CopyToAsync(stream);

        var documento = new Documento
        {
            TipoDocumento = tipoDocumento,
            FechaEmision = DateTime.Now,
            NombreOriginal = archivo.Name,
            NombreAlmacenado = nombreAlmacenado,
            RutaDocumento = $"/documento_pedido/{nombreAlmacenado}",
            PedidoId = pedidoId
        };

        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Documentos.Add(documento);
        await contexto.SaveChangesAsync();
        return true;
    }

    public async Task<List<Documento>> ObtenerDocumentosPorPedido(int pedidoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Documentos
            .Where(d => d.PedidoId == pedidoId)
            .OrderByDescending(d => d.FechaEmision)
            .ToListAsync();
    }

    public async Task<bool> Eliminar(int documentoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var documento = await contexto.Documentos.FindAsync(documentoId);

        if (documento == null)
        {
            return false;
        }

        var rutaCompleta = Path.Combine(uploadFolder, documento.NombreAlmacenado);
        if (File.Exists(rutaCompleta))
        {
            File.Delete(rutaCompleta);
        }

        contexto.Documentos.Remove(documento);
        return await contexto.SaveChangesAsync() > 0;
    }
}
