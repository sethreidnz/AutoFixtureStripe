using System;

namespace AutoFixtureStripe.Models
{
    public class CreateStripeCustomerRequest
    {

        // Customer details
        public Guid Id { get; }
        public string ContactEmail { get; set; }
        public string CompanyName { get; set; }
        public string Currency { get; set; }

        // Billing details
        public string Address { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountryCode { get; set; }
        public string AddressPostcode { get; set; }

        public CreateStripeCustomerRequest() { }
    }
}
