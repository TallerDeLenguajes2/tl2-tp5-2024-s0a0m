using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using tl2_tp5_2024_s0a0m.Models;

namespace tl2_tp5_2024_s0a0m.Repositorios;

public class PresupuestosRepository : IPresupuestosRepository
{
    private string cadenaConexion = "Data Source=DB/Tienda.db;Cache=Shared";
    public void AgregarProductoYCantidad(int id)
    {
        throw new NotImplementedException();
    }

    public void CrearPresupuesto(Presupuesto presupuesto)
    {
        throw new NotImplementedException();
    }

    public PresupuestoDetalle DetallePresupuesto(int id)
    {
        throw new NotImplementedException();
    }

    public void EliminarPresupuesto(int id)
    {
        throw new NotImplementedException();
    }

    public List<Presupuesto> ListarPresupuestos()
    {
        var queryString = @"SELECT * FROM Presupuestos;";
        List<Presupuesto> presupuestos = new();
            using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
            {
                SqliteCommand command = new SqliteCommand(queryString, connection);
                connection.Open();
            
                using(SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var presupuesto = new Presupuesto();
                        presupuesto.IdPresupuesto = Convert.ToInt32(reader["idPresupuesto"]);
                        presupuesto.NombreDestinatario = reader["NombreDestinatario"].ToString();
                        presupuesto. = Convert.ToInt32(reader["Precio"]);
                        presupuestos.Add(presupuesto);
                    }
                }
                connection.Close();
            }
            return productos;
    }
}