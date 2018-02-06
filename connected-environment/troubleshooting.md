# Troubleshooting Guide

## Error 'upstream connect error or disconnect/reset before headers'
You may see this error when trying to access your service - for example, when you navigate to the service's URL in a browser. 

**Reason:** The container port is not available. There are several possible reasons: 
* The container is still in the process of being built and deployed. This can be the case if you run `vsce up` or start the debugger, and then try to access the container before it has successfully deployed.
* Port configuration is not consistent across your Dockerfile, Helm Chart, and any server code that opens up a port.

**Try:**
1. If the container is in the process of being built/deployed, you can wait a few seconds and try access the service again. 
1. Check your port configuration; the specified port numbers should be **identical** in all the assets below:
    * **Dockerfile:** Specified by the `EXPOSE` instruction.
    * **Helm Chart:** Specified by the `externalPort` and `internalPort` values for a service (often located in a `values.yml` file),
    * Any ports being opened up in application code, for example in Node.js: `var server = app.listen(80, function () {...}`


## Config file not found
You run `vsce up` and get the following error: `Config file not found: .../vsce.yaml`

**Reason:** `vsce up` needs to run from the root directory of the code you want to run, and the code folder needs to have been initialized to run with Connected Environment.

**Try:**
1. Change your current directory to the root folder containing your service code. 
1. If you do not have a vsce.yaml file in the code folder, run `vsce init` to generate Docker, Kubernetes, and VSCE assets.

## Error: 'The pipe program 'vsce' exited unexpectedly with code 126.'
Starting the VS Code debugger may sometimes result in this error. This is a bug.

**Try:**
1. Close and re-open VS Code.
2. Hit F5 again.


## Debugging error 'Configured debug type 'coreclr' is not supported'
Running the VS Code debugger reports the error: `Configured debug type 'coreclr' is not supported.`

**Reason:** You do not have the VS Code extension for Connected Environment installed on your development machine.

**Try:**
Install the [VS Code extension for Conneced Environment](get-started-netcore-01.md#kubernetes-debugging-with-vs-code).


## I don't see any Connected Environment instances in the Azure Portal

**Reason:** An Azure Portal experience for Connected Environment is not yet ready for preview.