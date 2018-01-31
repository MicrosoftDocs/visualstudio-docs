# Getting Started on Connected Environment with .NET Core

Previous step: [Create a Dev Environment in Azure](get-started-netcore-visualstudio-03.md)

## Debug your App
Once the development environment is successfully created you can debug the application. Set a breakpoint in the code, for example on line 20 in the file **HomeController.cs** where the “Message” variable is set for the **About** page. Click **F5** to start debugging. Visual Studio will communicate with the development environment to build and deploy the application, and then open a browser with the web app running. Click on the “**About**” link at the top of the page to trigger the breakpoint.

## Next Steps
Make changes to the web app and do additional debugging. Connected Environment enables you to quickly and iteratively see your code changes take effect in a Kubernetes-based development environment in Azure!
Here are some other things you can try:
- Use **Ctrl+F5** instead of F5 to start the web app without debugging. A side effect of doing this is that the web app will stay deployed and running
- After using **Ctrl+F5**, open a browser and use the public endpoint to bring up the web app – the public endpoint is displayed in the Output window after successful deployment