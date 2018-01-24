# Getting Started on Connected Environment with .NET Core

Previous step: [Debugging containers in Kubernetes](get-started-netcore-04.md)

In this section we're going to create a second service, `mywebapi`, and have `webfrontend` call it. Each service will run in separate containers. We'll then debug across both containers.

![](media/multi-container.png)

## Clone the Sample WebAPI Service
For the sake of time, we'll grab ready-to-go sample code for `mywebapi`.

```
git clone https://github.com/johnsta/mywebapi
```


## Run the WebAPI service
1. Open the folder `mywebapi` in a separate VS Code window.
1. Hit F5, and wait for the service to build and deploy.
1. Take note of the endpoint URL, it will look something like http://localhost:\<portnumber\>. It may seem like the container is running locally, but actually it is running in our development environment in Azure. The reason for the localhost address is because `mywebapi` has not defined any public endpoints and can only be accessed from within the Kubernetes instance. To facilitate interacting with the private service from your local machine, Connected Environment creates a temporary SSH tunnel.
1. When `mywebapi` is ready, open your browser to the localhost address. Append `/api/values` to the URL to access the default GET API for the `ValuesController`. 
1. If all the steps were successful, you should be able to see a response from the `mywebapi` service.

## Make a Request From 'webfrontend' to 'mywebapi'
Let's now write code in `webfrontend` that makes a request to `mywebapi`.
1. Switch to the VS Code window for `webfrontend`.
1. **TODO**: Write code in `webfrontend` that makes a POST request to `mywebapi`. Code will look something like:

```
using (var client = new HttpClient())
{
    string content = "newvalue";
    HeaderPropagation.PropagateHeaders(this.Request, content);
    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
    var response = await client.PostAsync("http://mywebapi/api/values", content);
    result = await response.Content.ReadAsStringAsync();
}
```

Note how Kubernetes' DNS service discovery is employed to simply refer to the service as `http://mywebapi`. **Code in our development environment is running the same way it will run in production**.

## Propagate Headers
Next let's add some helper code that propagates headers to downstream requests. We'll see later how this facilitates a more productive development experience in team scenarios.
1. Create a file named HeaderPropagation.cs in the `webfrontend` project.
1. Paste the following code:

```
using System;
using System.Diagnostics;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace webfrontend.Helpers
{
    public static class HeaderPropagation
    {
        private const string MetaHeader = "Context-Headers";

        public static void PropagateHeaders(HttpRequest incoming, HttpContent outgoing)
        {
            if (incoming.Headers.ContainsKey(MetaHeader))
            {
                foreach (var header in incoming.Headers[MetaHeader][0].Split(","))
                {
                    outgoing.Headers.Add(header, incoming.Headers[header][0]);
                }
            }
        }
    }
}
``` 

## Debug Across Multiple Services
1. At this point, `mywebapi` should still be running with the debugger attached. If it is not, hit F5 in the `mywebapi` project.
1. Set a breakpoint in `mywebapi` that handles the `api/values` POST.
1. In the `webfrontend` project, set a breakpoint just before it sends a POST request to `mywebapi/api/values`.
1. Hit F5 in the `webfrontend` project.
1. Invoke the web app, and step through code in both services.

Well done! You now have a multi-container application where each container can be developed and deployed separately.

> [!div class="nextstepaction"]
> [Learn about team development](get-started-netcore-06.md)

