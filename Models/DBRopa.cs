    using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace TP09.Models;
public static class DBRopa

{
private static List<Articulo> _ListaArticulo = new List<Articulo>();
private static List<Tipos> _ListaTipos = new List<Tipos>();
private static List<Cliente> _ListaCliente = new List<Cliente>();


  private static string _connectionString = @"Data Source=localhost;Initial Catalog=BDRopa;Trusted_Connection=True;";
  

  public static List<Articulo> TraerArticulo()
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Articulo";
            _ListaArticulo = db.Query<Articulo>(sql).ToList(); 
        }
        return _ListaArticulo;
    }

 public static List<Articulo> BuscarArticulos(string txt)
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Articulo WHERE nombre like '%" +txt +"%'";
            _ListaArticulo = db.Query<Articulo>(sql).ToList(); 
        }
        return _ListaArticulo;
    }
    public static Articulo InfoArticulo(int IdArticulo)
    {
        Articulo ArticuloBuscado;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Articulo where IdArticulo = @pIdArticulo";
            ArticuloBuscado = db.QueryFirstOrDefault<Articulo>(sql, new {pIdArticulo = IdArticulo}); 
        }
        return ArticuloBuscado;
    }

    public static Cliente BuscarCliente(string Nombre, string Contraseña)
    {
        Cliente cliente = new Cliente();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Cliente WHERE Nombre = @pNombre and Contraseña = @pContraseña";
            cliente = db.QueryFirstOrDefault<Cliente>(sql, new {pNombre = Nombre, pContraseña = Contraseña }); 
        }
        return cliente;
       
        
    }

     public static int GuardarClientes(Cliente cliente)
    {
        int r = 0;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "Insert Into Cliente VALUES cliente";
            r = db.Execute(sql , new{Cliente= cliente}); 
        }
        return r;
    }

    
}