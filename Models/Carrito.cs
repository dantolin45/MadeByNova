using System;
public class Carrito
{
    private int _IdCarrito;
     private int _IdArticulo; 
     private int _Cantidad;
     private int _Total;
     
    public Carrito()
    {

    }
    public Carrito(int pIdCarrito, int pIdArticulo, int pCantidad, int pTotal)
    {
        _IdCarrito = pIdCarrito; _IdArticulo = pIdArticulo; _Cantidad = pCantidad;
    }
 
    public int IdCarrito
    {
        get{return _IdCarrito;}
        set{_IdCarrito = value;}
    }  
    public int IdArticulo
    {
        get{return _IdArticulo;}
        set{_IdArticulo=value;}
    } 
     public int Cantidad
    {
        get{return _Cantidad;}
        set{_Cantidad = value;}
    }  
}