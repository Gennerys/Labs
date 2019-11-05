using CleanArchitecture.Core.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
	public interface IOrderService
	{
		Task CreateOrderAsync(int basketId, Address shippingAddress);
	}
}
