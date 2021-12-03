## What are we doing here?

Testing the built-in Visual Studio unit test generator with NUnit

## How?

- Install Test Generator NUnit Extension
- Right-click > add unit tests

## What results do we get?

Pros

- good for scaffolding
- assertion syntax flows much more easily than MSTest
- can still use MSTest basic feaatures if required

Cons

- inconvenient and confusing to install the extension
+ create unit test dialog suggests that it's built-in, but it isn't
- only picks up existing test project on add
- have to manually add a test per method
+ doesn't seem to be a way to add tests for all public members

Overall

- prefer the features, but the irritations with setup are an example of why developers don't seem to get into testing