using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
       

      
            ICarImageService _carImageService;

            public CarImagesController(ICarImageService carImageService)
            {
                _carImageService = carImageService;
            }

        [HttpPost("add")]
        public IActionResult Add(int carId,string path)
        {
            var result = _carImageService.Add(carId,@"");
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        //    [HttpPost("add")]
        //    public IActionResult Add(int carId, [FromForm] IFormFile file)
        //    {
        //        var result = _carImageService.Add(carId, file);
        //        if (!result.Success) return BadRequest(result);

        //        return Ok(result);
        //    }

        //    [HttpPost("update")]
        //    public IActionResult Update(int id, [FromForm] IFormFile file)
        //    {
        //        var result = _carImageService.Update(id, file);
        //        if (!result.Success) return BadRequest(result);

        //        return Ok(result);
        //    }

        //    [HttpPost("delete")]
        //    public IActionResult Delete(int id)
        //    {
        //        var result = _carImageService.Delete(id);
        //        if (!result.Success) return BadRequest(result);

        //        return Ok(result);
        //    }

        //    [HttpGet("getAllByCarId")]
        //    public IActionResult GetAllByCarId(int carId)
        //    {
        //        var result = _carImageService.GetAllByCarId(carId);
        //        if (!result.Success) return BadRequest(result);

        //        return Ok(result);
        //    }

        //    [HttpGet("getAll")]
        //    public IActionResult GetAll()
        //    {
        //        var result = _carImageService.GetAll();
        //        if (!result.Success) return BadRequest(result);

        //        return Ok(result);
        //    }
    }
}

