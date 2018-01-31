# Getting Started on Connected Environment with .NET Core

Previous step: [Call another container](get-started-netcore-05.md)

So far we've run our application's code as if we were the only developer working on the app. In this section, we'll learn how Connected Environment streamlines team development by making it easy to:
* Enable a team of developers to work in the same development environment.
* Supports each developer iterating on their code in isolation and without fear of breaking others.
* Easily test code end-to-end, prior to code commit, without having to create mocks or simulate dependencies.

## Challenges with Developing Microservices
Our sample application isn't very complex at the moment. But in real-world development, challenges soon emerge as more services are added and the development team grows.

Picture yourself working on a service that interacts with tens of other services.

1. It can become unrealistic to run everything locally for development. Your dev machine may simply not have enough resources to run the entire app; or maybe your app has endpoints that need to be publicly reachable (e.g. your app responds to a webhook from a SaaS app).
1. You can try to "just run" the services that you depend on, but this means you'd need know the full closure of dependencies (i.e. dependencies of dependencies). Or, it's simply a matter of not easily knowing how to run your dependencies because you didn't work on it.
1. Some developers resort to simulating, or mocking up, most of their service dependencies. This can help sometimes, but managing those mocks can soon take on its own development effort. Plus, this leads to your dev environment looking very different to production, and subtle bugs start creeping in.
1. It follows that doing any type of end-to-end testing becomes difficult. Integration testing can only realistically happen post-commit, which means we see problems later in the cycle.

## Work in a Shared Development Environment
With Connected Environment, you can easily set up a *shared* development environment in Azure. Each developer can focus on just their part of the application, and can iteratively develop *pre-commit code* in an environment that already contains all the other services and cloud resources that their scenarios depend on. Dependencies are always up to date, and developers are working in a way that mirrors production.

## Work in Your Own Space
As you develop code for your service, and before you're ready to check it in, code often won't be in a good state - you're still iteratively shaping it, testing it, and experimenting with solutions. Connected Environment provides the concept of a **space**, which allows you to work in isolation, and without the fear of breaking your team members.

Before you proceed, close any F5/debug sessions for both services, and then run `vsce up` in each of the service's root folder.

Now let's take a closer look at where the services are currently running. Run the `vsce list` command, and you'll see output similar to the following:

```
Name         Space     Chart              Ports   Updated     Access Points
-----------  --------  -----------------  ------  ----------  -------------------------
mywebapi     mainline  mywebapi-0.1.0     80/TCP  2m ago     http://localhost:64322
webfrontend  mainline  webfrontend-0.1.0  80/TCP  1m ago     https://webfrontend-contosodev.vsce.io
```

Both services should show they are running, and that they are in a space named `mainline`. Anyone who opens the public URL and navigates to the web app's About page will invoke the code path we previously wrote that runs through both services. Now suppose we want to continue developing `mywebapi` - how can we do this and not interrupt other developers who are using the dev environment? To do that, we'll set up our own space.

## Create a Space
To run our own version of `mywebapi` in a space other than `mainline`, we first create our own space:
``` 
vsce space create --name scott
```

In the example above, I've used my name for the new space so that it is easily identifiable to my peers that that's the space I'm working in, but you can call it anything you'd like and be flexible about what it means, like 'sprint4' or 'demo'. 

Run the `vsce space list` command to see a list of all the spaces in the dev environment. An asterisk (*) appears next to the currently selected space. In our case, the space named 'scott' was automatically selected when it was created. You can select another space at any time with the `vsce space select` command.

Now let's see it in action:
1. Go to the VS Code window for `mywebapi` and make a code edit to the `string Get(int id)` method, for example:
```csharp
[HttpGet("{id}")]
public string Get(int id)
{
    return "mywebapi now says something new";
}
```

2. Hit F5 (or type `vsce up` in the Terminal Window) to run the service. Doing this will automatically run it in our newly selected space `scott`. 
1. We can confirm this by running `vsce list` again. First, you'll notice an instance of `mywebapi` is now running in the `scott` space (the version running in the `mainline` is still running but it is not listed). Secondly, the access point URL for `webfrontend` is prefixed with the text "scott-". This URL is unique to the `scott` space, and signifies that requests sent to the "scott URL" will attempt to first route to services in the `scott` space, and will fall back to services in the `mainline` space.

```
Name         Space     Chart              Ports   Updated     Access Points
-----------  --------  -----------------  ------  ----------  -------------
mywebapi     scott     mywebapi-0.1.0     80/TCP  15s ago     http://localhost:61466
webfrontend  mainline  webfrontend-0.1.0  80/TCP  5h ago      https://scott-webfrontend-contosodev.vsce.io
```

![](media/space-routing.png)

This built-in capability of Connected Environment enables you easily test code end-to-end in a shared evironment without requiring each developer  to re-create the full stack of services in their space. Note that this routing requires propagation headers to be forwarded in your app code, as illustrated in the [Propagate Headers](get-started-netcore-05.md#propagate-headers) section.

## Test Code Running in the `Scott` Space
To test our new version of `mywebapi` in conjunction with `webfrontend`, open your browser to the public access point URL for webfrontend and navigate to the About page. You should see your new message displayed.

Now, remove the "scott-" part of the URL, and refresh the browser - you should see the old behavior (exhibited by the `mywebapi` version running in `mainline`).

> [!div class="nextstepaction"]
> [Next](get-started-netcore-07.md)




