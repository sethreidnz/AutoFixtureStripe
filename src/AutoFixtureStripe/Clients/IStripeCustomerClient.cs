using System.Threading;
using System.Threading.Tasks;
using Stripe;

namespace AutoFixtureStripe.Clients
{
    public interface IStripeCustomerClient
    {
        Task<Customer> CreateCustomer(
          CustomerCreateOptions options,
          RequestOptions requestOptions = null,
          CancellationToken cancellationToken = default);
    }
}