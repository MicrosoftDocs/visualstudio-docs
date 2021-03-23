---
title: enable-iis
description: devinit tool enable-iis.
ms.date: 11/20/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# enable-iis

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `enable-iis` tool is used to enable IIS features and install the [ASP.NET Core Module](/aspnet/core/host-and-deploy/aspnet-core-module) for ASP.NET development with IIS.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default-behavior) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                               |
|--------------------------------------------------|--------|----------|-------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                               |
| [**input**](#input)                              | string | No       | Not used.                                                                           |
| [**additionalOptions**](#additional-options)     | string | No       | Not used.                                                                           |

### Input

Not used.

### Additional options

Not used.

### Default behavior

The default behavior of the `enable-iis` tool is to enable IIS features: IIS-WebServer, IIS-WebServerRole, IIS-WebSockets, and IIS-WebAuthentication, and then install the latest version of the ASP.NET hosting bundle that includes the ASP.NET Core Module.

## Example usage
Below is an example of how to run `enable-iis` using a `.devinit.json`.

#### .devinit.json that will enable IIS development:
```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0.json",
    "run": [
        {
            "tool": "enable-iis"
        },
    ]
}
```