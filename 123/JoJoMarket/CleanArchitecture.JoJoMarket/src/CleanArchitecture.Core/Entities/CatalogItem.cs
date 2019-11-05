﻿using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace CleanArchitecture.Core.Entities
{
	public class CatalogItem : BaseEntity, IAggregateRoot
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string PictureUri { get; set; }
		public int CatalogTypeId { get; set; }
		public CatalogType CatalogType { get; set; }
		public int CatalogBrandId { get; set; }
		public CatalogBrand CatalogBrand { get; set; }
	}
}