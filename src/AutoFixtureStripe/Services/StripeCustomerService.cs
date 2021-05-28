using System.Threading;
using System.Threading.Tasks;
using AutoFixtureStripe.Clients;
using AutoFixtureStripe.Models;
using Stripe;

namespace AutoFixtureStripe.Services
{
    public class StripeCustomerService : IStripeCustomerService
    {
        private readonly IStripeCustomerClient _stripeCustomerClient;

        public StripeCustomerService(IStripeCustomerClient stripeCustomerClient)
        {
            _stripeCustomerClient = stripeCustomerClient;
        }

        public async Task<Customer> CreateCustomer(
          CreateStripeCustomerRequest request,
          CancellationToken cancellationToken)
        {
            var createCustomerOptions = new CustomerCreateOptions
            {
                Address = request.Address != null
                  ? new AddressOptions
                  {
                      City = request.AddressCity,
                      Country = request.AddressCountryCode,
                      Line1 = request.Address,
                      PostalCode = request.AddressPostcode
                  }
                  : null,
                Email = request.ContactEmail,
                Name = request.CompanyName,
            };

            var requestOptions = new RequestOptions
            {
                IdempotencyKey = $"{request.Id}+customer"
            };

            return await _stripeCustomerClient.CreateCustomer(createCustomerOptions, requestOptions, cancellationToken);
        }
    }
}
