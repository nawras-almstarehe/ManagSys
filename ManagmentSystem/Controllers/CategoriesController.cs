using ManagmentSystem.Core.Models;
using ManagmentSystem.Core.UnitOfWorks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentSystem.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                return Ok(await _unitOfWork.Categories.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(int Id)
        {
            try
            {
                if (!Id.Equals(null) && Id != 0)
                {
                    return Ok(await _unitOfWork.Categories.GetByIdAsync(Id));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody] Category category)
        {
            try
            {
                //return Ok(_unitOfWork.Categories.Add(new Category { Name = "NewCat" })); For added UnitOfWork
                var categoryObj = await _unitOfWork.Categories.Add(category);
                 _unitOfWork.Complete();
                return Ok(categoryObj);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            try
            {
                //return Ok(_unitOfWork.Categories.Add(new Category { Name = "NewCat" })); For added UnitOfWork
                var categoryObj = await _unitOfWork.Categories.Update(category);
                _unitOfWork.Complete();
                return Ok(categoryObj);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        [HttpDelete("DeleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                //return Ok(_unitOfWork.Categories.Add(new Category { Name = "NewCat" })); For added UnitOfWork
                _unitOfWork.Categories.Delete(id);
                _unitOfWork.Complete();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }


        //[HttpGet]
        //public IActionResult GetById()
        //{
        //    return Ok(_unitOfWork.Categories.GetById(1));
        //}

        //[HttpGet("GetByName")]
        //public IActionResult GetByName()
        //{
        //    return Ok(_unitOfWork.Categories.Find(x => x.Name == "New Cat"));
        //}

        //[HttpGet("GetByAnyData")]// Get data from category with data of table another when category table relation to that table
        //public IActionResult GetByAnyData()
        //{
        //    return Ok(_unitOfWork.Categories.FindByAnyData(x => x.Name == "New Cat" , new[] { "ProductCategory"}));
        //}

        //[HttpGet("GetAllWithDataReleation")]// Get data from category with data of table another when category table relation to that table
        //public IActionResult GetAllWithDataReleation()
        //{
        //    return Ok(_unitOfWork.Categories.FindAll(x => x.Name == "New Cat", new[] { "ProductCategory" }));
        //}

        //[HttpGet("GetOrdered")]
        //public IActionResult GetOrdered()
        //{
        //    return Ok(_unitOfWork.Categories.FindAll(x => x.Name == "New Cat", null, null, y => y.Id, "DESC"));
        //}


        //[HttpGet("GetAllSpicialMethod")]
        //public IActionResult GetAllSpicialMethod()
        //{
        //    return Ok(_unitOfWork.Categories.GetAllSpecialMethod());//// After add spicial method now I can call to spicial method
        //}
    }
}
