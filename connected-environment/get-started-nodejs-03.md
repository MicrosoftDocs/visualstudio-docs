# Getting Started on Connected Environment with Node.js

Previous step: [Create a Kubernetes Development Environment in Azure](get-started-nodejs-02.md)

## Create a Node.js Web App
Download code from GitHub by navigating to https://github.com/johnsta/vsce-samples and select **Clone or Download** to download the GitHub repository to your local environment. The code for this guide is in `vsce-samples/nodejs/getting-started/webfrontend`.

[!INCLUDE[](common/vsce-init.md)]

[!INCLUDE[](common/ensure-env-created.md)]

[!INCLUDE[](common/build-and-run-in-k8s-cli.md)]

## Update a Content File
Connected Environment isn't just about getting code running in Kubernetes - it's about enabling you to quickly and iteratively see your code changes take effect in a Kubernetes environment in the cloud.

1. Locate the file `./public/index.html` and make an edit to the HTML. For example, change the page's background color to a shade of blue:

```html
<body style="background-color: #95B9C7; margin-left:10px; margin-right:10px;">
```

2. Save the file. Moments later, in the Terminal window you'll see a message saying the code was successfully synced in the Terminal window.
1. Go to your browser and refresh the page. You should see your color update.

What happened? Edits to content files, like HTML and CSS, don't require the Node.js process to restart, so an active `vsce up` command will automatically sync any modified content files directly into the running container in Azure, thereby providing a fast way to see your content edits.

## Update a Code File
Updating server-side code files requires a little more work, because a Node.js app needs to restart. The simplest method from the command-line is to stop and re-run `vsce up`.

1. In the terminal window, press `Ctrl+C` (to stop `vsce up`).
1. Open the code file named `server.js`, and edit service's hello message: 

```javascript
res.send('Hello from webfrontend running in Azure!');
```

3. Save the file.
1. Run  `vsce up` in the terminal window. 

This rebuilds the container image and redeploys the Helm chart. Reload the browser page to see your code changes take effect.


But there is an even *faster method* for developing code, which we'll explore in the next section. 
> [!div class="nextstepaction"]
> [Debugging a container in Kubernetes](get-started-nodejs-04.md)
