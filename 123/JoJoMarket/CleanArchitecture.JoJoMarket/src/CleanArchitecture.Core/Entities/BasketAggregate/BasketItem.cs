using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.BasketAggregate
{
	public class BasketItem : BaseEntity
	{
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }
		public int CatalogItemId { get; set; }
		public int BasketId { get; private set; }
	}
}
