﻿namespace CheeseAndScrewdriversCSharp02
{
	public class Screwdriver : ICartItem
	{
		public Screwdriver(decimal salePrice)
		{
			SalePrice = salePrice;
		}

		public decimal SalePrice { get; }
	}
}