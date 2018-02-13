# Troubleshooting Guide

## Error 'upstream connect error or disconnect/reset before headers'
You may see this error when trying to access your service. For example, when you go to the service's URL in a browser. 

**Reason:** The container port is not available. These are the most common reasons: 
* The container is still in the process of being built and deployed. This can be the case if you run `vsce up` or start the debugger, and then try to access the container before it has successfully deployed.
* Port configuration is not consistent across your Dockerfile, Helm Chart, and any server code that opens up a port.

**Try:**
1. If the container is in the process of being built/deployed, you can wait 2-3 seconds and try accessing the service again. 
1. Check your port configuration. The specified port numbers should be **identical** in all the assets below:
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
Install the [VS Code extension for Connected Environment](get-started-netcore-01.md#get-kubernetes-debugging-for-vs-code).


## The Azure portal doesn't show Connected Environment instances

**Reason:** An Azure portal experience for Connected Environment is not yet ready for preview.


## The type or namespace name 'MyLibrary' could not be found

**Reason:** The build context is at the project/service level by default, therefore a library project you are using will not be found.

**Try:**
What needs to be done is:
1. Modify the vsce.yaml file to set the build context to the solution level.
2. Modify the Dockerfile and Dockerfile.develop files to refer to the csproj files correctly, relative to the new build context.
3. Place a .dockerignore file beside the .sln file and modify as needed.

You can find an example at https://github.com/sgreenmsft/buildcontextsample