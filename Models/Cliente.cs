using System;
public class Cliente
{

    private int _IdCliente;
    private string _Nombre;
    private string _Contraseña;
    private string _Mail;
    private int _Telefono;
    private string _Direccion;
    
    public Cliente()
    {

    }
    public Cliente(int pidcliente, string pnombre, string pcontraseña , string pmail, string pdireccion, int ptelefono)
    {
        _IdCliente = pidcliente;
        _Nombre = pnombre;
        _Contraseña= pcontraseña;
        _Mail = pmail;
        _Direccion = pdireccion;
        _Telefono = ptelefono;
        
    }
    public int telefono
    {
        get{return _Telefono;}
        set{_Telefono=value;}
    }
    public string direccion
    {
        get{return _Direccion;}
        set{_Direccion = value;}
    }

    public int idcliente
    {
        get{return _IdCliente;}
        set{_IdCliente= value;}

    }
     public string contraseña
    {
        get{return _Contraseña;}
        set{_Contraseña=value;}

    }
     public string nombre
    {
        get{return _Nombre;}
        set{_Nombre=value;}

    }

    public string mail
    {
        get{return _Mail;}
        set{_Mail = value;}

    }

}