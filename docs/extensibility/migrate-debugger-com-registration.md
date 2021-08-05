---
title: "Migrate 64-bit debugger COM class registration| Microsoft Docs"
description: Learn how to register COM classes to msvsmon for debugger extensions without writing to HKEY_CLASSES_ROOT. 
ms.custom: SEO-VS-2020
ms.date: "11/10/2016"
ms.topic: "conceptual"
ms.assetid: 45cfcee6-7a68-4d4f-b3f6-e2d8a0fa066a
author: "gregg-miskelly"
ms.author: "greggm"
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
  - "greggm"
---
# Migrate 64-bit debugger COM class registration

For debugger extensions that register COM classes in HKEY_CLASSES_ROOT by using regasm, regsvr32, or directly writing to the registry and loaded into *msvsmon.exe* (the remote debugger), it's now possible to provide this registration to msvsmon without needing to write to HKEY_CLASSES_ROOT. This affects legacy .NET debugger expression evaluators or debug engines that are configured to load in the *msvsmon.exe* process.

## msvsmon-comclass-def

To use this technique, add a **.msvsmon-comclass-def.json* file next to msvsmon (InstallDir:* \Common7\IDE\Remote Debugger\x64*).

Here is an example msvsmon-comclass-def file that registers one managed, and one native class:

FileName: *MyCompany.MyExample.msvsmon-comclass-def.json*

```json
{
  "managedCOMClasses": [
    {
      "clsid": "{C9F48B25-36ED-4B22-8210-98BC5BE4D1E7}",
      "assemblyName": "MyCompany.MyAssembly",
      "className": "MyCompany.MyNamespace.MyClass"
    }
  ],
  "nativeCOMClasses": [
    {
      "clsid": "{42A476E9-8FA7-44D5-ADFE-216AD371EEC9}",
      "dllPath": "MyExample.dll"
    }
  ]
}
```
