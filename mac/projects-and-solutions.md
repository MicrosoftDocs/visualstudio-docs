---
title: Projects, Solutions, and Configurations
description: This document provides an overview of Projects and Solutions in Xamarin Studio and explains what configurations are and how they relate to the build.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 8254505D-D96E-48BD-8A5E-CF6A917897EA
---

# Overview

Xamarin Studio provides a *Solution Pad* to display a tree view of the entire open solution that allows easy access to source code, resources, user interfaces, and assembly reference contained in individual Projects. The Solution Pad, by default, opens one solution at any one time. Each Solution can include many projects, and each project can contain many items.

# Using Projects and Solutions

Solutions can be created at any time by using a predetermined template. To do this browse to **File > New Solution**, select the required platform(s) and then the required template:

![](Images/projects-and-solutions-image0.png)

This will create a solution, which can contain one or many projects, depending on the type of template chosen.

The solution explorer can be navigated by using the context actions or the menu bar.

To add a new Project, right-click on the Solution name and select **Add > Add New Project** to display the New Project dialog:

 ![](Images/projects-and-solutions-image4.png)

This method of adding new projects can be used to take advantage of Xamarin's code-sharing capabilities. Adding a Shared Project or a Portable Library template to an existing Solution provides a way to contain any cross-platform logic that can be used within all other projects in a solution. For more information on building cross-platform applications, refer to the [relevant guide](/guides/cross-platform/application_fundamentals/building_cross_platform_applications/sharing_code_options/).


# Project Options 

Project options are specific to each project and affect how the project is written, built, and run. This is in contrast to Xamarin Studio Preferences, which set user-specific options; and Solution options, which set options for the entire solution. Project options are stored in the project (.csproj) file, so that other developers can build and run the project correctly. This allows many developers to work on the same document, without compromising the formatting of the file.

Project options in Xamarin Studio can be launched by double-clicking on the project name, or by right-clicking to open the context menu, and selecting **Options**:

 ![](Images/projects-and-solutions-image2.png)

Editable options include those to build, run, and set source code and version control options.

Project options are organized into five different categories which have the following capabilities:

* **General** – Project information such as Name, Description, and Default Namespace can be set here, along with the Location of the project.
* **Build** – This allows developers to set or change PCL profiles for Portable Class Libraries. It also allows for custom commands, configurations, compiler options to be set. The output path and assembly name can also be set here.
* **Run** – This allows you to create custom run configurations on a per-project basis.
* **Source Code** – This allows you to control the formatting of many different file types and naming conventions. You can also set the naming policies and default header styles here.
* **Version Control** – This allows you to edit the style of the commit message when using Version Control with your project.

Each project can also contain specific project options, depending on the platform. For example, a Xamarin.Android project, like the one illustrated below, will have options relating to the Android build – such as linker options; and the Application – such as permissions:

 ![](Images/projects-and-solutions-image5.png)

Xamarin.iOS will contain options related to bundle signing – such as the required provisioning profile to use; and relating to the IPA packaging options:

 ![](Images/projects-and-solutions-image6.png)


## Project Build Configurations 

Some options are part of a project configuration. Projects can have multiple configurations, and switching between them allows for different outputs at build time. For example, when using a Debug configuration, the output will include debugging symbols, which allows the debugger to resolve function name, parameters, or variables from a crash applications stack trace. Using a Debug configuration, however, leads to an inflated file size and so would not be ideal for an application intended for distribution.

Each platform will have specific configurations for its build. Xamarin.Android development will always have only a Release or Debug configuration. Xamarin.iOS has more configurations. There often options for Ad-Hoc or App store, depending on when a project was created. Newer projects will have only debug or release configurations, but these can be set for either a device or any installed simulator.


# Build Actions 

All files in a Xamarin Studio project have a build action which controls what happens to the file during a build. These can be set by right-clicking on any file and browsing to **Build Action**, as illustrated below:

![](Images/projects-and-solutions-image1.png)

Here are some of the common build actions for C# projects:

* **None** – The file is not part of the build in any way, it's just included in the project for easy access from the IDE.
* **Compile** – The file will be passed to the C# compiler as a source file.
* **EmbeddedResource** – The file will be passed to the C# compiler as a resource to be embedded in the assembly. The `System.Reflection` namespace can then be used to read the file from the assembly.
* **Content** – For ASP.NET projects, these files will be included as part of the site when it's deployed. For Xamarin.iOS and Xamarin.Mac projects, they'll be contained in the app bundle.

It is possible to select more than one file in the solution explorer, allowing you to set the build action to many files at once.

Also, there are build actions for specific projects. For example, Xamarin.iOS projects have the **BundeledResource** build action, which will add the file as part of the app bundle. Information on Xamarin.Android specific build actions, can be found in the [build process](/guides/android/under_the_hood/build_process/#Build_Actions) guide.

# Solution Options 

Solution options are similar to Project options but cover the scope of the entire Solutions. They provide a way to set author information, build settings, code formatting styles, and version control, and they allow for a way to assign the startup project in the Solution.  The Solution Options dialog can be accessed from the **Project > Solution Options** menu item, from the **Options** context menu item on the Solution in the Solution pad, or by double-clicking on the Solution in the Solution Pad:

 ![](Images/projects-and-solutions-image7.png)

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



