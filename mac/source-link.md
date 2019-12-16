---
title: "Debugging into NuGet Packages with Source Link"
description: "This article describes the Source Link feature in Visual Studio for Mac."
author: heiligerdankgesang
ms.author: dominicn
ms.date: 12/16/2019
ms.assetid: 4bcb8acf-db50-4bd8-a48e-86248f00c90b

---

# Debugging into NuGet Packages with Source Link

Source Link technology enables source code debugging of .NET assemblies from NuGet that ship .PDBs with links to source files. Source Link executes when developers create their NuGet package and embed source control metadata inside assemblies and the package. When Source Link is enabled in Visual Studio for Mac, the IDE will detect that source files are available for installed packages and offer to download them. This will allow you to step through the package code. Source Link also works with Mono BCL code, allowing you to step into .NET Framework code as well. Source Link provides source control metadata to create a great debugging experience.

## Enable Source Link

To enable Source Link in Visual Studio for Mac, browse to **Visual Studio > Preferences... > Projects > Debugger** and ensure the **Step into external code** checkbox is checked.

![](media/source-link1.png)

You can change the setting in **Download External Code** to suit your preferences:
* Ask: Visual Studio for Mac will prompt you to download the external code
* Always: Visual Studio for Mac will download the external code automatically
* Never: Visual Studio for Mac will not download the related external code

By default, **Ask** is selected. You'll receive the following prompt when when external code is found for a NuGet package:

![](media/source-link2.png)


## See also

- The [Source Link GitHub repository](https://github.com/dotnet/sourcelink/blob/master/README.md)
