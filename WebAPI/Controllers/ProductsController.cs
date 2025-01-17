﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductsController : ControllerBase
	{
		IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{

			var result = _productService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult Get(int id)
		{

			var result = _productService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbycategory")]
		public IActionResult GetByCategory(int categoryId)
		{

			var result = _productService.GetAllByCategoryId(categoryId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Post(Product product)
		{
			var result = _productService.Add(product);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}



	}
}