﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ProductTest();
			//CategoryTest();
		}

		private static void CategoryTest()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var cateory in categoryManager.GetAll())
			{
				Console.WriteLine(cateory.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetProductDetails())
			{
				Console.WriteLine(product.ProductName+"/"+product.CategoryName);

			}
		}
	}
}
