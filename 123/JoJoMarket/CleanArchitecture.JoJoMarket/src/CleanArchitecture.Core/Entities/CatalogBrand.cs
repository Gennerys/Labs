using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
	public class CatalogBrand : BaseEntity, IAggregateRoot
	{
		public string Brand { get; set; }
	}
}
