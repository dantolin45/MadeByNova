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
    public IActionResult BuscarCliente (string nombre, string contraseña)
    {
        ViewBag.Cliente = DBRopa.BuscarCliente(nombre, contraseña);
        
        return View("Index");

    }
    
    public IActionResult GuardarCliente(Cliente cliente)
    {
        ViewBag.Cliente= DBRopa.GuardarClientes(cliente);
        return View("Index");
    }
    


}
