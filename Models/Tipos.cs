using System;
public class Tipos
{
    private int _IdTipo;
    private string _NombreTipo; 
     
    public Tipos()
    {

    }
    public Tipos(int pIdTipo, string pNombreTipo)
    {
        _IdTipo=pIdTipo; _NombreTipo=pNombreTipo;
    }
 
    public int IdTipo
    {
        get{return _IdTipo;}
        set{_IdTipo = value;}
    }  
    
    public string NombreTipo
    {
        get{return _NombreTipo;}
        set{_NombreTipo = value;}
    }
    
}