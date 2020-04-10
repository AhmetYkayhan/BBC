﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBC.Services.Services.HomeService;
using BBC.Services.Services.HomeService.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController(
            IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<SliderOutputDto>), 200)]
        [Route("GetSliderImages")]
        public async Task<IActionResult> GetSliderImages()
        {
            var result = await _homeService.GetSliderImages();
            return Ok(result);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<TaRHomeOuputDto>), 200)]
        [Route("GetHomeContent")]
        public async Task<IActionResult> GetHomeContent(int page)
        {
            if (page <= 0)
                return BadRequest("Sayfa Sayısı 0 ve 0'dan küçük olamaz");

            var result = await _homeService.GetHomeContent(page);
            return Ok(result);
        }
    }
}