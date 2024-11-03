﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUI.Controllers
{
    public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly IIdentityService _identityService;


        public LoginController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;
            _identityService = identityService;
        }

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}

<<<<<<< HEAD
		//[HttpPost]
		//public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
		//{
		//	return View();
		//}
=======
		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
		{
			return View();
		}
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d

        [HttpPost]
        public async Task<IActionResult> Index(SignInDto signInDto)
        {
            await _identityService.SignIn(signInDto);
<<<<<<< HEAD
            return RedirectToAction("Index", "Default");
=======
            return RedirectToAction("Index", "User");
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
        }

	}
}
