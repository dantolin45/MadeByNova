using System;
public class Compra
{
    private int _IdCompra;
     private int _IdArticulo; 
     private string _Direccion;
     private string _Email;
     private int _Telefono;
     private string _Nombre;
     private int _IdCliente;
     
    public Compra()
    {

    }
    public Compra(int pIdCompra, int pIdArticulo, string pDireccion, string pEmail, int pTelefono, string pNombre , int pIdCliente)
    {
        _IdCompra = pIdCompra; _IdArticulo = pIdArticulo; _Direccion = pDireccion; _Email = pEmail; _Telefono = pTelefono; _Nombre = pNombre; _IdCliente = pIdCliente;
    }
 
    public int IdCompra
    {
        get{return _IdCompra;}
        set{_IdCompra = value;}
    }  
    public int IdArticulo
    {
        get{return _IdArticulo;}
        set{_IdArticulo=value;}
    } 
    public string Direccion
    {
        get{return _Direccion;}
        set{_Direccion = value;}
    }
    public string Email
    {
        get{return _Email;}
        set{_Email = value;}
    }  
    public int Telefono
    {
        get{return _Telefono;}
        set{_Telefono = value;}
    }  
    public string Nombre
    {
        get{return _Nombre;}
        set{_Nombre = value;}
    } 
    public int IdCliente   
    {
        get{return _IdCliente;}
        set{_IdCliente =value;}
    }
}