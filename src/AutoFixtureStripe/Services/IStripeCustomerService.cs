using System.Threading;
using System.Threading.Tasks;
using AutoFixtureStripe.Models;
using Stripe;

namespace AutoFixtureStripe.Services
{
    public interface IStripeCustomerService
    {
        Task<Customer> CreateCustomer(
          CreateStripeCustomerRequest request,
          CancellationToken cancellationToken);
    }
}
