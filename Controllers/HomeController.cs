using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09.Models;

namespace TP09.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Cliente()
    {

        return View();
    }
    public IActionResult Index()
    {
        ViewBag.Articulo = DBRopa.TraerArticulo();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public Articulo InfoArticulo(int idarticulo)
    {
        ViewBag.Articulo = DBRopa.InfoArticulo(idarticulo);
        return ViewBag.Articulo;
    }
    public IActionResult AgregarJugadores(int idarticulo)
    {
        ViewBag.InfoDetalleArticulo = DBRopa.InfoArticulo(idarticulo);
        ViewBag.InfoArticulo = DBRopa.ListarArticulos(idarticulo);
        return View("Index");    
    }

    
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult BusquedaArticulo (string txt)
    {
        ViewBag.Articulo = DBRopa.BuscarArticulos(txt);
        return View("Index");

    }
    [HttpPost]
    public IActionResult BuscarCliente (string nombre, string contraseña)
    {
        ViewBag.Cliente = DBRopa.BuscarCliente(nombre, contraseña);

        DBRopa.clienteLogueado =  ViewBag.Cliente;
        if(ViewBag.Cliente == null)
        {

            ViewBag.ErrorLog = "Username no encontrado";
        }
     
        ViewBag.Articulo = DBRopa.TraerArticulo();
        return View("Index");

    }
    
    public IActionResult ArticuloTocar(int idarticulo)
    {
        ViewBag.Articulotocar = DBRopa.InfoArticulo(idarticulo);
        return View("Articulo");

    }
    public IActionResult Compra(int idarticulo)
    {
        ViewBag.Articulo = idarticulo;
        ViewBag.DetalleArticulo = DBRopa.InfoArticulo(idarticulo);
        return View("Compra");

    }
     public IActionResult VerDetalleArticulos(int IdArticulo)
    {
        ViewBag.InfoDetalleArticulo = DBRopa.InfoArticulo(IdArticulo);
        return View("DetalleCompra");
    }
    [HttpPost]    
    public IActionResult GuardarCliente(string nombre, string contraseña, string mail)
    {
        DBRopa.GuardarClientes(nombre, contraseña, mail);
        DBRopa.clienteLogueado =  ViewBag.Cliente;
        return RedirectToAction("Index", "Home" );
    }
    
    [HttpPost]
    public IActionResult GuardarCompra(int IdArticulo, string MedioDePago, string Direccion, string Email, int Telefono, string Nombre, int IdCliente)
    {    
        DBRopa.AgregarCompra(IdArticulo, MedioDePago, Direccion, Email, Telefono, Nombre, IdCliente);
        
        ViewBag.InfoDetalleArticulo = DBRopa.InfoArticulo(IdArticulo);
        ViewBag.InfoArticulo = DBRopa.ListarArticulos(IdArticulo);
        int IdEq = IdArticulo;
        return RedirectToAction("Index", "Home", new{IdArticulo = IdEq});     
    }

}
