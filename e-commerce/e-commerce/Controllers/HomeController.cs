using e_commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Products.Business.Abstract;
using Products.Business.Concrete;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly AdminContext _context;
        public HomeController(ILogger<HomeController> logger, AdminContext context)
        {
            _logger = logger;
            _productService = new ProductManager();
            _context = context;
        }

        public IActionResult Login(String Email, String Password)
        {
            var p = _context.Admins.FirstOrDefault(x => x.Mail == Email && x.PW == Password);
            if (p == null)
            {
                return RedirectToAction(nameof(Index));
            }
            HttpContext.Session.SetInt32("id", p.Id);
            return RedirectToAction(nameof(Products));
        }  
        public IActionResult Create()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult AddProduct(Product product)
        {
            _productService.CreateProduct(product);

            return RedirectToAction(nameof(Create));
        }

        public IActionResult UpdateProduct(Product product)
        {
            
            _productService.UpdateProduct(product);
            return RedirectToAction(nameof(Create));

        }

        public IActionResult RemoveProduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Products));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
