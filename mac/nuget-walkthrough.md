---
title: "Walkthrough: Including a NuGet in your project"
description: This document covers how to include a NuGet package in a Xamarin project. It walks through finding and downloading a package, as well as introducing the IDE integration features.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 5C800815-0B13-4B27-B017-95FCEF1A0EA2
---


# Overview

NuGet is the most popular package manager for .NET development. It is built in to Xamarin Studio 5 and Visual Studio. You can easily search for and add packages to your project to Xamarin.iOS and Xamarin.Android using either IDE.

In this article, we’ll look at how to include a NuGet package in a project and demonstrate the tool chain that makes the process seamless.


# Walkthrough

To demonstrate the NuGet functionality this article will walk-through the process of incorporating a package from *NuGet* into a Xamarin app. We’ll work with a project named `HelloNuget`, created from the Xamarin.iOS <kbd>Single View Application</kbd> template in Xamarin Studio or the <kbd>HelloWorld  Application</kbd> template in Visual Studio respectively. The steps to include a NuGet package are the same irrespective of the project template used.


<a name="NuGet_in_Xamarin_Studio" class="injected"></a>

# NuGet in Xamarin Studio

To demonstrate the NuGet package functionality we'll first walk through creating a new application and adding a package to it. Then we'll discuss the IDE features that help manage packages.

## Create a New Project

First, create a project named `HelloNuget` as shown below (we're using the iOS Single View Application template, but any iOS or Android application project type would work):

![](Images/nuget-walkthrough-NewProject.png)

<a name="Adding_a_Package" class="injected"></a>

## Adding a Package

With the project loaded in Xamarin Studio, right-click on the <span class="UIItem">Project</span> in the <span class="UIItem">Solution Pad</span> and select <span class="UIItem">Add Packages...</span>:

![](Images/nuget-walkthrough-AddPackageNew.png)

This launches the _Add Packages..._ window. When the window opens it will load a list of packages from the default package source: nuget.org. The initial results look like this:

![List NuGet Packages](Images/nuget-walkthrough-AddPackages1.png)

Use the search box in the top-right corner to find a specific package, for example `ModernHttpClient`. When you've found a package you wish to use, click the **Add Package** button to begin installation.

[Add ModernHttpClient NuGet Package](Images/nuget-walkthrough-AddPackages2.png)

Once the package has been download it will be added to your project. The solution will change in a few ways:

*   The **References** node will contain a **From Packages** section which can be expanded to see the assemblies that are part of a NuGet package.
*   A **Packages** node is added which lists each package you have downloaded. You can update or remove a package from this list (which will affect the project references as well).
*   A **packages.config** file will be added to the project. This XML file is used by the IDE to track which package version are referenced in this project. This file should not be hand-edited, but you should keep it in version control. Note that a project.json file can be used instead of a packages.config file. The project.json file is a new package file format introduced with NuGet 3 which supports transitive restore. More detailed information on project.json can be found in the [NuGet documentation](http://docs.nuget.org/consume/ProjectJson-Intro). The project.json file needs to be added manually and the project closed and re-opened before the project.json file is used in Xamarin Studio.

These changes are shown in the screenshot below:

![Project References](Images/nuget-walkthrough-References.png)

Once the NuGet package has been added and the project references updated you can program against the APIs as you would with any project reference. In this example using **ModernHttpClient** I can simply add the required `using` statements:

    using ModernHttpClient;
    using System.Net.Http;

and then include a few lines in the view controller's ViewWillAppear override to demonstrate that the package works:

    var httpClient = new HttpClient(new NSUrlSessionHandler());
    var response = await httpClient.GetAsync ("http://xamarin.com/");
    Console.WriteLine ("status: " + response.StatusCode);
    Console.WriteLine (await response.Content.ReadAsStringAsync ());

This code is shown as an example - it doesn't do much except output an HTML string to the Console - however it shows how easy it is to install and then use a NuGet package in your apps.

<a name="Package_Updates" class="injected"></a>

## Package Updates

Once one-or-more packages are added to a project, the <span class="UIItem">Packages</span> node will appear in the Solution pad. Right-click on <span class="UIItem">Packages</span> to access the context-sensitive menu:

![Packages menu](Images/nuget-walkthrough-PackagesMenu.png)

*   **Add Packages** - Opens the window to add more packages to the project.
*   **Update** - Checks the source server for each package and downloads any newer versions.
*   **Restore** - Downloads any missing packages (without updating existing packages to newer versions).

Update and Restore options are also available at the Solution level, and affect all the projects in the solution. Individual packages can also be right-clicked to access a context menu:

![Packages menu](Images/nuget-walkthrough-PackageMenu.png)

*   **Version Number** - The version number is a disabled menuitem - it is not selectable, just provided for informational purposes.
*   **Update** - Checks the source server and downloads a newer version (if it exists).
*   **Remove** - Removes the package from this project and removes the relevant assemblies from the project's References.




## Version Control

The NuGet documentation discusses [using NuGet without committing packages to source control](http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages). If you prefer not to store binaries and unused information in source control, you can configure the IDE to automatically restore packages from the server. This means that when a developer retrieves the project from source control for the first time, the IDE will automatically download and install the required packages.

![Automatically restore packages](Images/nuget-walkthrough-AutoRestore.png)

Refer to your particular source control documentation for details on how to exclude the `packages` directory from being tracked.

