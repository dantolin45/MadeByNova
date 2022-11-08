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

public static Cliente clienteLogueado = null;

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

     public static void GuardarClientes(string nombre, string contraseña, string mail)
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "Insert Into Cliente(Nombre, Contraseña,Mail) VALUES (@pnombre, @pcontraseña, @pmail)";
            db.Execute(sql , new{pnombre= nombre, pcontraseña = contraseña, pmail=mail }); 
        }
       
    }
    public static void AgregarCompra(int IdArticulo, string MedioDePago, string Direccion, string Email, int Telefono, string Nombre, int IdCliente)
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "Insert Into Compra (IdArticulo, MedioDePago, Direccion, Email, Telefono, Nombre, IdCliente) Values (@pIdArticulo, @pMedioDePago, @pDireccion, @pEmail, @pTelefono, @pNombre, 1)";
            db.Execute(sql, new {pIdArticulo = IdArticulo, pMedioDePago = MedioDePago, pDireccion = Direccion, pEmail = Email, pTelefono = Telefono, pNombre = Nombre, pIdCliente = 1});
        }
    }

     public static List<Articulo> ListarArticulos(int IdArticulo){
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "Select * From Articulo Where IdArticulo = @pIdArticulo";
            _ListaArticulo = db.Query<Articulo>(sql, new {pIdArticulo = IdArticulo}).ToList();
        }
        return _ListaArticulo;
    }
    
}