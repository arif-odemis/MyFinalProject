﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün eklendi";
		public static string ProductNameInvalid = "Ürün ismi geçersiz";
		public static string MaintenanceTime = "sistem bakımda";
		public static string ProductsListed = "ürünler listelendi";
		public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
		public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
		public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
		public static string AuthorizationDenied = "Yetkiniz yok."; 
	}
}
