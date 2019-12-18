---
title: "Build Actions"
description: "This article describes the various build actions that can be used for C# projects"
author: heiligerdankgesang
ms.author: dominicn
ms.date: 05/06/2018
ms.assetid: 5399BCB1-E317-4C7B-87B1-C531E985DE6E
---
# Build actions

All files in a Visual Studio for Mac project have a build action. It controls what happens to the file during a build. This behavior can be set by right-clicking on any file and browsing to **Build Action**, as illustrated below:

![Selecting Compile build action from solution explorer](media/projects-and-solutions-image1.png)

Some of the common build actions for C# projects are:

* **None** - The file isn't part of the build in any way - it's included in the project for easy access from the IDE.
* **Compile** - The file will be passed to the C# compiler as a source file.
* **EmbeddedResource** - The file will be passed to the C# compiler as a resource to be embedded in the assembly. [Assembly.GetManifestResourceStream](/dotnet/api/system.reflection.assembly.getmanifestresourcestream), from the `System.Reflection` namespace, can then be used to read the file from the assembly.
* **Content** - For ASP.NET projects, these files will be included as part of the site when it's deployed. For Xamarin.iOS and Xamarin.Mac projects, they'll be included in the app bundle.

It's possible to select more than one file in the solution explorer, allowing you to set the build action to many files at once.

Also, there are build actions for specific projects. Xamarin.iOS projects have the **BundleResource** build action, which will add the file as part of the app bundle. Information on Xamarin.Android specific build actions can be found in the [build process](/xamarin/android/deploy-test/building-apps/build-process#Build_Actions) guide.

## See also

- [Build actions (Visual Studio on Windows)](/visualstudio/ide/build-actions)