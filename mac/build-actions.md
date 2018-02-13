---
title: Build Actions
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 5399BCB1-E317-4C7B-87B1-C531E985DE6E
---

# Build actions 

All files in a Visual Studio for Mac project have a build action which controls what happens to the file during a build. These can be set by right-clicking on any file and browsing to **Build Action**, as illustrated below:

![](media/projects-and-solutions-image1.png)

Some of the common build actions for C# projects are:

* **None** - The file is not part of the build in any way - it's just included in the project for easy access from the IDE.
* **Compile** - The file will be passed to the C# compiler as a source file.
* **EmbeddedResource** - The file will be passed to the C# compiler as a resource to be embedded in the assembly. The `System.Reflection` namespace can then be used to read the file from the assembly.
* **Content** - For ASP.NET projects, these files will be included as part of the site when it's deployed. For Xamarin.iOS and Xamarin.Mac projects, they'll be contained in the app bundle.

It is possible to select more than one file in the solution explorer, allowing you to set the build action to many files at once.

Also, there are build actions for specific projects. For example, Xamarin.iOS projects have the **BundleResource** build action, which will add the file as part of the app bundle. Information on Xamarin.Android specific build actions can be found in the [build process](https://developer.xamarin.com/guides/android/under_the_hood/build_process/#Build_Actions) guide on developer.xamarin.com.