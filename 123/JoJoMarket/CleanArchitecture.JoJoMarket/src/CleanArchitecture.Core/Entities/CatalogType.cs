using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
	public class CatalogType : BaseEntity, IAggregateRoot
	{
		public string Type { get; set; }
	}
}
