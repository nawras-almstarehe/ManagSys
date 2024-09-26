using ManagmentSystem.Core.Interfaces;
using ManagmentSystem.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductesController : ControllerBase
    {
        private readonly IBaseRepository<Product> _productRepository;
        public ProductesController(IBaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        //[HttpGet]
        //public IActionResult GetById()
        //{
        //    return Ok(_productRepository.GetById(1));
        //}
    }
}
