using System.Linq;
using System.Net.Http.Headers;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace AutoFixtureStripe.Tests
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(GetDefaultFixture)
        {
        }

        private static IFixture GetDefaultFixture()
        {
            var autoMoqCustomization = new AutoMoqCustomization();
            var fixture = new Fixture().Customize(autoMoqCustomization);

            fixture.Register<HttpResponseHeaders>(() => null);

            // register objects which should omit recursion
            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
              .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            return fixture;
        }
    }
}