---
title: "Managing References in a Project"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 4AD51385-B0A8-4BA7-B2D4-BF2BD167A142
---

Visual Studio for Mac provides three different means of adding additional references to your project:

![]()

These are:

* References
* NuGets
* Components

In addition Web References and native references can also be added to any project.

## Assembly References

Each framework within Xamarin ships with over a dozen assemblies. Not all of these packages are referenced in your project by default. 

To edit which packages that are referenced in your project, use the _Edit References_ dialog, which can be displayed by double-clicking on the References folder, or by select Edit References on its context menu actions:

![]()

For information on the assemblies available for each Xamarin framework, refer to the [Available Assemblies](https://developer.xamarin.com/guides/cross-platform/advanced/available-assemblies/) guide.

## NuGet

NuGet is the most popular package manager for .NET development. Visual Studio for Mac's NuGet support allows you to search for an add packages to your project. 

To do this, right-click on the **Package** folder in the Solution Pad, and select Add Packages.

More information on using a NuGet Package is provided in the [Including NuGet in your Project](~/nuget-walkthrough) guide.

## Web References

## Native References
