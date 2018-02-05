# Getting Started on Connected Environment with .NET Core and Visual Studio

Previous step: [Debug a Container in Kubernetes](get-started-netcore-visualstudio-04.md)

## Call another container
In this section we're going to create a second service, `mywebapi`, and have `webfrontend` call it. Each service will run in separate containers. We'll then debug across both containers.

![](media/multi-container.png)

## Download Sample Code for mywebapi
For the sake of time, let's download some sample code from a GitHub repository. Navigate to https://github.com/johnsta/vsce-samples and select **Clone or Download** to download the GitHub repository. The code for this section is in `vsce-samples/dotnetcore/getting-started/mywebapi`.

## Run mywebapi
1. Open the project `mywebapi` in a *separate Visual Studio window*.
1. Select **Connected Environment for AKS** from the launch settings dropdown as you did previously for the `webfrontend` project. Rather than create a new development environment this time, select the same one you already created. As before, leave the Space defaulted to `mainline` and click **OK**. In the Output window you may notice Visual Studio starts to "warm up" this new service in your development environment in order to speed things up when you start debugging,
1. Hit F5, and wait for the service to build and deploy. You'll know it's ready when the Visual Studio status bar turns orange
1. Take note of the endpoint URL displayed in the **Connected Environment for AKS** pane in the **Output** window, it will look something like http://localhost:\<portnumber\>. Again, it may seem like the container is running locally, but actually it is running in our development environment in Azure.
1. When `mywebapi` is ready, open your browser to the localhost address and append `/api/values` to the URL to invoke the default GET API for the `ValuesController`. 
1. If all the steps were successful, you should be able to see a response from the `mywebapi` service that looks like this.

    ![](images/WebAPIResponse.png)

## Make a Request from 'webfrontend' to 'mywebapi'
Let's now write code in `webfrontend` that makes a request to `mywebapi`. Switch to the Visual Studio window which has the `webfrontend` project. In the `HomeController.cs` file *replace* the code for the About method with the following:

 ```csharp
    public async Task<IActionResult> About()
    {
        ViewData["Message"] = "Hello from webfrontend";
        
        // Use HeaderPropagatingHttpClient instead of HttpClient so we can propagate
        // headers in the incoming request to any outgoing requests
        using (var client = new HeaderPropagatingHttpClient(this.Request))
            {
                // Call 'mywebapi', and display its response in the page
                var response = await client.GetAsync("http://mywebapi/api/values/1");
                ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
            }
    
        return View();
    }

```

Note how Kubernetes' DNS service discovery is employed to simply refer to the service as `http://mywebapi`. **Code in our development environment is running the same way it will run in production**.

The code example above also makes use of a `HeaderPropagatingHttpClient` class. This helper class is the file `HeaderPropagation.cs` that was added to your project when you configured it to use Connected Environment. `HeaderPropagatingHttpClient` is dervied from the well-known `HttpClient` class - the only functionality it adds to `HttpClient` is to propagate specific headers from an existing ASP .NET HttpRequest object into an outgoing HttpRequestMessage object. We'll see later how this facilitates a more productive development experience in team scenarios.

## Debug Across Multiple Services
1. At this point, `mywebapi` should still be running with the debugger attached. If it is not, hit F5 in the `mywebapi` project.
1. Set a breakpoint in the `Get(int id)` method in the `ValuesController.cs` file that handles `api/values/{id}` GET requests.
1. In the `webfrontend` project where we pasted the above code, set a breakpoint just before it sends a GET request to `mywebapi/api/values`.
1. Hit F5 in the `webfrontend` project. Visual Studio will again open a browser to the appropriate localhost port and the web app will be displayed.
1. Click on the “**About**” link at the top of the page to trigger the breakpoint in the `webfrontend` project. 
1. Hit F10 to proceed. The breakpoint in the `mywebapi` project will now be triggered.
1. Hit F5 to proceed and you will be back in the code in the `webfrontend` project.
1. Hitting F5 one more time will complete the request and return a page in the browser. In the web app, the About page will display a message concatenated by the two services: "Hello from webfrontend and Hello from mywebapi".

Well done! You now have a multi-container application where each container can be developed and deployed separately.

> [!div class="nextstepaction"]
> [Learn about team development](get-started-netcore-visualstudio-06.md)

