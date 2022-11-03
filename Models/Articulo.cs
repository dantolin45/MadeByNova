using System;
public class Articulo
{
    private int _IdArticulo;
     private string _Nombre; 
     private string _ImagenArticulo;
     private int _IdTipo;
     private int _Precio;
     private string _Marca;
     private int _Talle;
     private string _Genero;
    private string _Origen;
    private string _Material;
    public Articulo()
    {

    }
    public Articulo(int pIdArticulo, string pNombre, string pImagenArticulo, int pIdTipo, int pPrecio, string pMarca, int pTalle, string pGenero, string pOrigen, string pMaterial)
    {
        _IdArticulo = pIdArticulo; _Nombre = pNombre; _ImagenArticulo = pImagenArticulo; _IdTipo = pIdTipo; _Precio = pPrecio; _Marca=pMarca; _Talle = pTalle; _Genero = pGenero; _Origen = pOrigen; _Material = pMaterial;
    }
    public int IdArticulo
    {
        get{return _IdArticulo;}
        set{_IdArticulo=value;}
    }
    public string Nombre
    {
        get{return _Nombre;}
        set{_Nombre = value;}
    }   
     public string ImagenArticulo
    {
        get{return _ImagenArticulo;}
        set{_ImagenArticulo = value;}
    }   
     public int IdTipo
    {
        get{return _IdTipo;}
        set{_IdTipo = value;}
    }   
     public int Precio
    {
        get{return _Precio;}
        set{_Precio = value;}
    }
    public string Marca
    {
        get{return _Marca;}
        set{_Marca = value;}
    }
    public int Talle
    {
        get{return _Talle;}
        set{_Talle = value;}
    }
    public string Genero
    {
        get{return _Genero;}
        set{_Genero = value;}
    }
    public string Origen
    {
        get{return _Origen;}
        set{_Origen = value;}
    }
    public string Material
    {
        get{return _Material;}
        set{_Material = value;}
    }  
}