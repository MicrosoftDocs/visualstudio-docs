# Getting Started on Connected Environment with Node.js

Previous step: [Create a Node.js container in Kubernetes](get-started-nodejs-03.md)

In this section, we'll use VS Code to directly debug our container running in Azure (be sure to have installed the [VS Code extension for Conneced Environment](get-started-nodejs-01.md#get-kubernetes-debugging-tools)). We'll also learn how to make our edit-run-test loop even faster. To do this, we need to configure our code project so VS Code will communicate with our development environment in Azure.

[!INCLUDE[](common/init-debug-assets-vscode.md)]

> [!Note]
> If you don't see any Connected Environment commands in the Command Palette, ensure you have [installed the VS Code extension for Connected Environment](get-started-nodejs-01.md#get-kubernetes-debugging-tools).

## Select the VSCE Debug Configuration
1. To open the Debug view, click on the Debug icon in the **Activity Bar** on the side of VS Code.
1. Select **Launch Program (VSCE)** as the active debug configuration.

<TODO: debug configuration screenshot for Node.js>
<!-- ![](media/debug-configuration.png) -->

## Debug the Container in Kubernetes
Hit **F5** to debug your code in Kubernetes!

As with the `up` command, code is synced to the development environment, and a container is built and deployed to Kubernetes. This time, of course, the debugger is attached to the remote container.

Set a breakpoint in a server-side code file, for example within the `app.get('/api'...` in the `server.js` source file. Refreshing the browser page, or pressing the 'Say It Again' button, causes the breakpoint to hit.

You have full access to debug information just like you would if the code was executing locally, such as the call stack, local variables, exception information, etc.

## Edit and Restart Debugger
With the debugger active, make a code edit; for example, modify the hello message again. 

```javascript
app.get('/api', function (req, res) {
    res.send('**** Hello from service A in AZURE ****');
});
```

Save the file, and in the **Debug actions pane**, click the **Refresh** button. 

![](media/debug-action-refresh.png)

Instead of rebuilding and redeploying a new container image each time code edits are made, which will often take considerable time, Connected Environment will incrementally recompile code within the existing container to provide a faster edit/debug loop.

Refresh the web app in the browser, navigate to the About page - you should see your custom message appear in the UI.

## Edit and Refresh Browser
<TODO: Switch to Attach profile, describe nodemon, etc. >

**Now you have a method for rapidly iterating on code and debugging directly in Kubernetes!** Next, we'll see how we can create and call a second container.

> [!div class="nextstepaction"]
> [Call a service running in a separate container](get-started-nodejs-05.md)

