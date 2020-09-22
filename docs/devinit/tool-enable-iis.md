---
title: enable-iis
description: devinit tool enable-iis.
ms.date: 08/28/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# enable-iis

The `enable-iis` tool is used to enable IIS features and install the [ASP.NET Core Module](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/aspnet-core-module?view=aspnetcore-3.1) for ASP.NET development with IIS.

## Usage

If both the `input` and `additionalOptions` properties are omitted or empty, then the tool will follow the [default](#default) behavior detailed below.

| Name                                             | Type   | Required | Value                                                                               |
|--------------------------------------------------|--------|----------|-------------------------------------------------------------------------------------|
| **comments**                                     | string | No       | Optional comments property. Not used.                                               |
| [**input**](#Input)                              | string | No       | Not used.                                                                           |
| [**additionalOptions**](#Additional-Options)     | string | No       | Not used.                                                                           |

### Input

Not used.

### Additional Options

Not used.

### Default Behavior

The default behavior of the `enable-iis` tool is to enable IIS features: IIS-WebServer, IIS-WebServerRole, IIS-WebSockets, and IIS-WebAuthentication, and then install the latest version of the ASP.NET hosting bundle that includes the ASP.NET Core Module. 

## Example Usage

```json
{
    "$schema": "./devinit.schema-2.0.json",
    "run": [
        {
            "comments": "Example that will enable IIS features and install the latest ASP.NET hosting bundle.",
            "tool": "enable-iis"
        },
    ]
}
```
