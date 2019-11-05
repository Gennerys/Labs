using Ardalis.GuardClauses;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.BuyerAggregate
{
	public class Buyer : BaseEntity, IAggregateRoot
	{
		public string IdentityGuid { get; private set; }

		private List<PaymentMethod> _paymentMethods = new List<PaymentMethod>();

		public IEnumerable<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();

		private Buyer()
		{
			// required by EF
		}

		public Buyer(string identity) : this()
		{
			Guard.Against.NullOrEmpty(identity, nameof(identity));
			IdentityGuid = identity;
		}
	}
}
