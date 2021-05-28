# AutoFixtureStripe

This repo is to show an issue I have been having configuring AutoFixture to correctly create Stripe .net api response objects. I have isolated this to a single entity.

Obviously this could be a user error as I am not sure what is happening... But I have followed the guidance i found online about how to turn off the recursive behavior. However it appears to then just get stuck in an infinite loop or something and never finishes executing my tests.

## Reproducing my issue

You need the following installed:

- [Dotnet 3.1.x](https://dotnet.microsoft.com/download/dotnet/3.1)

Then you need to run the following to run the tests:

```bash
dotnet test src/AutoFixtureStripe.Tests
```

You should see you regular output, with one test file found. But it will never actually get to running the test.
