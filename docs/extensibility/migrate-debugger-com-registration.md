---
title: Migrate 64-bit debugger COM class registration
description: Learn how to register COM classes to msvsmon.exe for debugger extensions without writing to HKEY_CLASSES_ROOT. 
ms.custom: "kr2b-contr-experiment"
ms.date: "06/13/2022"
ms.topic: "how-to"
ms.assetid: 45cfcee6-7a68-4d4f-b3f6-e2d8a0fa066a
author: "gregg-miskelly"
ms.author: "greggm"
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
  - "greggm"
---
# Migrate 64-bit debugger COM class registration

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Some debugger extensions register COM classes in `HKEY_CLASSES_ROOT` by using `regasm`, `regsvr32`, or directly writing to the registry and are loaded into *msvsmon.exe*, the remote debugger. It's now possible to provide this registration to *msvsmon.exe* without needing to write to `HKEY_CLASSES_ROOT`. This approach affects legacy .NET debugger expression evaluators. It also affects debug engines that are configured to load in the *msvsmon.exe* process.

## msvsmon-comclass-def

To use this technique, add a **.msvsmon-comclass-def.json* file next to *msvsmon.exe*. The install directory is *\Common7\IDE\Remote Debugger\x64*.

Here's an example *msvsmon-comclass-def* file that registers one managed class and one native class:

File name: *MyCompany.MyExample.msvsmon-comclass-def.json*

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

## Next steps

Review [What's New in the Visual Studio 2017 SDK](what-s-new-in-the-visual-studio-2017-sdk.md)
