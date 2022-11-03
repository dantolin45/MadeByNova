using System;
public class DetalleCompra
{
     private int _IdDetalleCompra;
     private int _IdCompra;
     private int _IdArticulo; 
     private int _Cantidad;
     private int _Precio;
     
    public DetalleCompra()
    {

    }
    public DetalleCompra(int pIdDetalleCompra, int pIdCompra, int pIdArticulo, int pCantidad, int pPrecio)
    {
        _IdDetalleCompra = pIdDetalleCompra; _IdCompra = pIdCompra; _IdArticulo = pIdArticulo; _Cantidad = pCantidad; _Precio = pPrecio;
    }
 
    public int IdDetalleCompra
    {
        get{return _IdDetalleCompra;}
        set{_IdDetalleCompra = value;}
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
    public int Cantidad
    {
        get{return _Cantidad;}
        set{_Cantidad = value;}
    }
    public int Precio
    {
        get{return _Precio;}
        set{_Precio = value;}
    }  
    
}