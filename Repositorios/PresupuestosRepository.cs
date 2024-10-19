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
        var query = $"INSERT INTO Presupuesto (idPresupuesto, NombreDestinatario) VALUES (@idPresupuesto, @NombreDestinatario)";
        using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
        {
            connection.Open();
            var command = new SqliteCommand(query, connection);

            command.Parameters.Add(new SqliteParameter("@idPresupuesto", presupuesto.IdPresupuesto));
            command.Parameters.Add(new SqliteParameter("@NombreDestinatario", presupuesto.NombreDestinatario));

            command.ExecuteNonQuery();

            connection.Close();
        }
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
        // var queryString = @"SELECT * FROM Presupuestos  LEFT JOIN PresupuestosDetalle USING(idPresupuesto) LEFT JOIN Productos USING(idProducto) ORDER BY idPresupuesto;";
        // List<Presupuesto> presupuestos = new();
        //     using (SqliteConnection connection = new SqliteConnection(cadenaConexion))
        //     {
        //         SqliteCommand command = new SqliteCommand(queryString, connection);
        //         connection.Open();
            
        //         using(SqliteDataReader reader = command.ExecuteReader())
        //         {
        //             while (reader.Read())
        //             {
        //                 var presupuesto = new Presupuesto();
        //                 presupuesto.IdPresupuesto = Convert.ToInt32(reader["idPresupuesto"]);
        //                 presupuesto.NombreDestinatario = reader["NombreDestinatario"].ToString();
        //                 presupuesto.idProducto = reader["idProducto"].ToString();
        //                 presupuesto.Detalle.Cantidad = Convert.ToInt32(reader["Cantidad"]);
        //                 presupuesto.Descripcion = reader["Descripcion"].ToString();
        //                 presupuestoDetalle.Precio = Convert.ToInt32(reader["Precio"]);
                        
        //                 var presupuestoDetalle = new PresupuestoDetalle();

        //                 // buscar un producto con id idProducto
        //                 presupuestoDetalle.Producto = ;

        //                 presupuesto.Detalle.Add(presupuestoDetalle);

        //                 presupuestos.Add(presupuesto);
        //             }
        //         }
        //         connection.Close();
        //     }
        //     return presupuestos;
    }

}