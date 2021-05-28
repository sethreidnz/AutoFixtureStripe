using Xunit;
using AutoFixtureStripe.Services;
using Stripe;

namespace AutoFixtureStripe.Tests.Services
{
    public class StripeCustomerServiceTests
    {
        [Theory, AutoMoqData]
        public void IsIStripeCustomerInterface(StripeCustomerService sut)
        {
            Assert.IsAssignableFrom<IStripeCustomerService>(sut);
        }


        [Theory, AutoMoqData]
        public void CreateCustomer_CanCreateCustomer(StripeCustomerService sut, Customer customer)
        {
            Assert.NotNull(sut);
        }
    }
}
