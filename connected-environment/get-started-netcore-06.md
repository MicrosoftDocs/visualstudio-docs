# Get Started on Connected Environment with .NET Core

Previous step: [Call another container](get-started-netcore-05.md)

[!INCLUDE[](common/team-development-1.md)]

Let's see it in action:
1. Go to the VS Code window for `mywebapi` and make a code edit to the `string Get(int id)` method, for example:

```csharp
[HttpGet("{id}")]
public string Get(int id)
{
    return "mywebapi now says something new";
}
```

[!INCLUDE[](common/team-development-2.md)]

> [!div class="nextstepaction"]
> [Next](get-started-netcore-07.md)
