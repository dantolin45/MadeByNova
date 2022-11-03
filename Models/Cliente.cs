using System;
public class Cliente
{

    private int _IdCliente;
    private string _Nombre;
    private string _Contraseña;
    private string _Mail;
    
    public Cliente()
    {

    }
    public Cliente(int pidcliente, string pnombre, string pcontraseña , string pmail)
    {
        _IdCliente = pidcliente;
        _Nombre = pnombre;
        _Contraseña= pcontraseña;
        _Mail = pmail;
        
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