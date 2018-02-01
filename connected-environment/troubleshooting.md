# Troubleshooting Guide

## Config file not found
You run `vsce up` and get the following error: `Config file not found: .../vsce.yaml`

**Reason:** `vsce up` needs to run from the root directory of the code you want to run, and the code folder needs to have been initialized to run with Connected Environment.

**Try:**
1. Change your current directory to the root folder containing your service code. 
1. If you do not have a vsce.yaml file in the code folder, run `vsce init` to generate Docker, Kubernetes, and VSCE assets.

## Debugging error 'Configured debug type 'coreclr' is not supported'
Running the VS Code debugger reports the error: `Configured debug type 'coreclr' is not supported.`

**Reason:** You do not have the VS Code extension for Connected Environment installed on your development machine.

**Try:**
Install the [VS Code extension for Conneced Environment](get-started-netcore-01.md#kubernetes-debugging-with-vs-code).

## Error 'upstream connect error or disconnect/reset before headers'
You may see this error when trying to access your service - for example, when you navigate to the service's URL in a browser. 

**Reason:** The container is in the process of being updated and is not yet ready.

**Try:**
Wait a few seconds, and try accessing the service again. If this doesn't seem to work, run `vsce up` (or hit F5) again.