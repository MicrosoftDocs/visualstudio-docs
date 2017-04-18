---
title: Projects, Solutions, and Configurations
description: This document provides an overview of Projects and Solutions in Xamarin Studio.
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

# Solution Options 

Solution options are similar to Project options but cover the scope of the entire Solutions. They provide a way to set author information, build settings, code formatting styles, and version control, and they allow for a way to assign the startup project in the Solution.  The Solution Options dialog can be accessed from the **Project > Solution Options** menu item, from the **Options** context menu item on the Solution in the Solution pad, or by double-clicking on the Solution in the Solution Pad:

 ![](Images/projects-and-solutions-image7.png)





