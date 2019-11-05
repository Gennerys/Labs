﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
	public interface IBasketService
	{
		Task<int> GetBasketItemCountAsync(string userName);
		Task TransferBasketAsync(string anonymousId, string userName);
		Task AddItemToBasket(int basketId, int catalogItemId, decimal price, int quantity = 1);
		Task SetQuantities(int basketId, Dictionary<string, int> quantities);
		Task DeleteBasketAsync(int basketId);
	}
}