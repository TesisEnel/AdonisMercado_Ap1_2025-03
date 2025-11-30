using Microsoft.EntityFrameworkCore;
using ProyectoFinal_AP1_AdonisMercado.DAL;
using ProyectoFinal_AP1_AdonisMercado.Models;
using System.Linq.Expressions;

namespace ProyectoFinal_AP1_AdonisMercado.Services;

public class VehiculoService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Existe(int vehiculoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Vehiculos
            .AnyAsync(v => v.VehiculoId == vehiculoId);
    }

    private async Task<bool> Insertar(Vehiculo vehiculo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Vehiculos.Add(vehiculo);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Vehiculo vehiculo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Vehiculos.Update(vehiculo);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Vehiculo vehiculo)
    {
        if (!await Existe(vehiculo.VehiculoId))
        {
            return await Insertar(vehiculo);
        }
        else
        {
            return await Modificar(vehiculo);
        }
    }

    public async Task<Vehiculo?> Buscar(int vehiculoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Vehiculos
            .Include(v => v.PedidoDetalles)
            .FirstOrDefaultAsync(v => v.VehiculoId == vehiculoId);
    }

    public async Task<List<Vehiculo>> ListarVehiculos(Expression<Func<Vehiculo, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Vehiculos
            .Include(v => v.PedidoDetalles)
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Deshabilitar(int vehiculoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var vehiculo = await contexto.Vehiculos
            .FirstOrDefaultAsync(v => v.VehiculoId == vehiculoId);

        if (vehiculo == null)
        {
            return false;
        }

        vehiculo.isActive = false;
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Habilitar(int vehiculoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var vehiculo = await contexto.Vehiculos
            .FirstOrDefaultAsync(v => v.VehiculoId == vehiculoId);

        if (vehiculo == null)
        {
            return false;
        }

        vehiculo.isActive = true;
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int vehiculoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var vehiculo = await contexto.Vehiculos
            .FirstOrDefaultAsync(p => p.VehiculoId == vehiculoId);

        if (vehiculo == null)
        {
            return false;
        }

        contexto.Vehiculos.Remove(vehiculo);
        return await contexto.SaveChangesAsync() > 0;
    }
}
