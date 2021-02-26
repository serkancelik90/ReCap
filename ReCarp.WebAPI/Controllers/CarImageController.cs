using Core.Utilities.FileHelpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCap.Business.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCarp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;

        public CarImageController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _carImageService = carImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] CarImage carImage, IFormFile formFile)
        {
            var path = _webHostEnvironment.WebRootPath + "\\images";

            var imagePath = FileHelper.Add(formFile, path);

            carImage.ImagePath = imagePath;
            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _carImageService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
