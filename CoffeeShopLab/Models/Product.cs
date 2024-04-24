﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CoffeeShopLab.Models
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Category { get; set; }
	}

}
