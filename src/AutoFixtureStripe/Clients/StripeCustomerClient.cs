using System.Threading;
using System.Threading.Tasks;
using Stripe;

namespace AutoFixtureStripe.Clients
{
    public class StripeCustomerClient : IStripeCustomerClient
    {
        private readonly CustomerService _stripeCustomerService;

        public StripeCustomerClient(IStripeClient stripeClient)
        {
            _stripeCustomerService = new CustomerService(stripeClient);
        }

        public async Task<Customer> CreateCustomer(
          CustomerCreateOptions options,
          RequestOptions requestOptions = null,
          CancellationToken cancellationToken = default)
        {
            return await _stripeCustomerService.CreateAsync(options, requestOptions, cancellationToken);
        }
    }
}