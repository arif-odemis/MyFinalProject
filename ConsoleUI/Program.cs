using Business.Concrete;
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
			var result=productManager.GetProductDetails();

			if (result.Success == true)
			{
				foreach (var product in result.Data)
				{
					Console.WriteLine(product.ProductName + "/" + product.CategoryName);

				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}
			}
			
		}
	
}
