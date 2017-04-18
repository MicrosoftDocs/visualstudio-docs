---
title: "Understanding Build Configurations"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 78107CFA-9308-4293-A92A-9B552A259E15
---

## Project Build Configurations 

Some options are part of a project configuration. Projects can have multiple configurations, and switching between them allows for different outputs at build time. For example, when using a Debug configuration, the output will include debugging symbols, which allows the debugger to resolve function name, parameters, or variables from a crash applications stack trace. Using a Debug configuration, however, leads to an inflated file size and so would not be ideal for an application intended for distribution.

Each platform will have specific configurations for its build. Xamarin.Android development will always have only a Release or Debug configuration. Xamarin.iOS has more configurations. There often options for Ad-Hoc or App store, depending on when a project was created. Newer projects will have only debug or release configurations, but these can be set for either a device or any installed simulator.

## Solution Configurations
Akin to Project configurations, Solution Configuration can be used to create custom configurations for an entire project. By using the **Configuration Mappings** tab under the **Build > Configurations** item, a developer can assign a target configuration for each solution item, as illustrated below.:

 ![](Images/projects-and-solutions-image3.png)

For more information, refer to the [Xamarin Studio Configuration Manager](https://www.youtube.com/watch?v=tjSdkqYh5Vg) video by James Montemagno.

# Run Configuration

In previous versions of Xamarin Studio, developer could select the option to set a project as a **Startup Project**, which is the project that is run/debugged when using the global run/debug command. This was indicated by the use of a bold typeface for the project’s name in the project pad.

This has changed in Xamarin Studio 6.1, and instead of setting a startup project, developers can set a _run configuration_. The run configurations are presented in a dropdown list in the toolbar, next to the build configuration selector as illustrated below:

 ![](Images/projects-and-solutions-image9.png)
 ![](Images/projects-and-solutions-image8.png)

A run configuration is basically a set of execution options with a name, and several configurations can be defined in a project for different purposes. Run configurations are defined at the project level, and a default will be created automatically for each executable project, although it is possible to add as many as needed. Certain project types can automatically generate additional run configurations. For example, watchOS projects may generate  _Glance and Notification configurations._ 
 

Configurations can be shared with other developers (in which case the configurations will be stored in the .csproj file) or kept locally (in which case they will be stored in a .user file).

##Android Run Configurations
 
Run configurations for Android projects allow you to specify which activity, service, or broadcast receiver to launch when running or debugging the project. You can pass intent extra data and set intent flags to be able to test your components under different launch conditions.

Activities other than the MainLauncher will need to have Exported=true added to the Activity attribute for debugging on a physical device, or have Intent filters defined.

## Examples of Data that Might Be Included in Run Configurations:

The list below provides some example of data that could be included in run configurations:

* Regular .NET project
    * Alternative startup app
    * Start arguments
    * Working directory
    * Environment variables
    * Mono runtime options (to be used only when running on Mono)
* Android project
    * Entry point (activity, service, receiver)
    * Intent arguments and data
* iOS project
    * Mode (Normal, Background Fetch)
* iOS extension project
    * Startup app: default or custom
* WatchKit project
    * Mode (Glance, Notification)
    * Notification payload