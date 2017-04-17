---
title: Visual Studio for Mac Tour
description: "Visual Studio for Mac provides an integrated development environment to build .NET applications on macOS, including ASP.NET Core websites and Xamarin projects for iOS, Android, Mac, and Xamarin.Forms."
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 7DC64A52-AA41-4F3A-A8A1-8A20BCD81CC7
---

# Visual Studio for Mac Tour

# Overview

Xamarin Studio is a modern, sophisticated IDE with many features for creating Xamarin.iOS, Xamarin.Mac, Xamarin.Android, and Xamarin.Forms applications. It includes a rich editor,
debugging, native platform integration with iOS, Mac and Android, and integrated source control to name just of few of its many features.

This guide surveys various sections of Xamarin Studio, providing a look at some of the features that make it a powerful tool for
creating applications.

# Contents

* [IDE Tour](#IDE_Tour)
    * [Welcome Screen](#Welcome_Screen)
    * [Solutions and Projects](#Solutions_and_Projects)
    * [Solutions Pad](#Solution_Pad)
    * [Assembly References](#Assembly_References)
    * [Components](#Components)
    * [NuGets](#NuGet)
    * [Project Options](#Project_Options)
* [Source Editor](#Source_Editor)
    * [Syntax Highlighting](#Syntax_Highlighting)
    * [Code Completion](#Code_Completion)
    * [Code Navigation](#Code_Navigation)
    * [Breadcrumb Menu](#Breadcrumb_Menu)
    * [Tooltips](#Tooltips)
    * [Indentation and Comments](#Indentation_and_Comments)
    * [Snippets](#Snippets)
* [Refactoring](#Refactoring)
* [Navigation and Search](#Navigation_and_Search)
    * [Global Search](#Global_Search)
    * [Assembly Browser](#Assembly_Browser)
        * [Assembly Search](#Assembly_Search)
* [Debugging](#Debugging)
* [Version Control Integration](#Version_Control_Integration)
    * [Differences, History, and Merging](#Differences_History_and_Merging)
* [Release Notes](#Release_Notes)
* [Summary](#Summary)


# IDE Tour

Xamarin Studio is organized into several sections for managing application files and settings, creating application code, and debugging.

 <a name="Welcome_Screen" class="injected"></a>
## Welcome Screen

When launched, Xamarin Studio displays a *Welcome Screen* as shown below:

[ ![](Images/ide-tour-image1.png)](Images/image1.png)

The Welcome Screen contains the following sections:

-  **Toolbar** &ndash; Provides shortcuts to the Xamarin Developer Center, Support and Forums, as well as quick access to your Xamarin Account.
-  **Solutions** &ndash; Provides quick access to recently opened solutions, as well as convenience buttons to open or create projects.
-  **Xamarin News** &ndash; News feed to stay up to date on the latest Xamarin information.
-  **Pre-Built Apps** &ndash; Complete applications to help bootstrap application development.
-  **Start Enterprise Trial** &ndash; Provides quick access to begin a [free 30 day trial of Xamarin Studio Enterprise](/guides/cross-platform/getting_started/beginning_a_xamarin_trial/).

## Solutions and Projects

The image below shows Xamarin Studio with an application loaded:

[ ![](Images/ide-tour-image0.png)](Images/image0.png)

The following sections provide an overview of the major areas in Xamarin Studio.

 <a name="Solution_Pad" class="injected"></a>


## Solution Pad

The Solution Pad organizes the project(s) in a solution, as shown below:

[ ![](Images/image2.png)](Images/image2.png)

This is where files for the source code, resources, user interface, and assembly references are organized into platform-specific Projects.

Right-clicking on an item in the Solution Pad allows access to the item’s context menu. The following screenshot shows the context menu for a C# source code file:

[ ![](Images/ide-tour-image3.png)](Images/image3.png)

For more information on using Projects, Solutions, and Configurations in Xamarin Studio, refer to the [Projects, Solutions, and Configurations](/guides/cross-platform/xamarin-studio/projects-and-solutions/) guide.

 <a name="Assembly_References_" class="injected"></a>

## Assembly References

Assembly references for each project are available under the **References** folder, shown below:

[ ![](Images/ide-tour-image4.png)](Images/image4.png)

Additional references can be added via the the **Edit References** dialog, which can be displayed by double-clicking on the References folder, or by select **Edit References** on its context menu actions:

[ ![](Images/ide-tour-image5.png)](Images/image5.png)

The list of selected assemblies is shown in the list on the right side of the dialog. Any assemblies selected
in the **Edit References** dialog are added to the project when the dialog’s OK button is selected.

## Components

Xamarin Components are a powerful feature that allows user interface components as well as libraries and themes to easily be added to a project. The Components store can be accessed by right-clicking on the **Components** folder and clicking on **Get More Components...**:

[ ![](Images/ide-tour-components.png)](Images/components.png)

A project can specify the directory Xamarin Components will be extracted to before being referenced by a project. This allows multiple solutions to use the same directory and prevents the assembly references from being modified when a project is opened within the context of a different solution.

For more information on using Components in Xamarin Studio see the [Including a Component in your project](/guides/cross-platform/application_fundamentals/components_walkthrough/) Walkthrough.

## NuGet

NuGet is the most popular package manager for .NET development. With Xamarin Studio's NuGet support you can easily search for and add packages to your project to application.

[ ![](Images/ide-tour-nuget.png)](Images/nuget.png)

Information on using a NuGet package in an application can be found in the [Including a NuGet in your project](/guides/cross-platform/application_fundamentals/nuget_walkthrough/)



 <a name="Editor" class="injected"></a>


# Source Editor

Xamarin Studio features a modern, sophisticated source code editor. The editor area features a
tabbed interface for editing source files as shown below:

[ ![](Images/ide-tour-image7.png)](Images/image7.png)

The editing experience includes various features, presented in the following sections.

 <a name="Syntax_Highlighting" class="injected"></a>



## Syntax Highlighting

Code in the editor is highlighted according to various language keywords and constructs,
as shown below where the keywords, types and string literals have different colors:



  ![](Images/ide-tour-image8.png)

 <a name="Code_Completion" class="injected"></a>


## Code Completion

Types are discoverable in a popup window while you type. This allows easy exploration of APIs.
The following screen shows the completion list:

 ![](Images/ide-tour-image9.png)

 <a name="Code_Navigation" class="injected"></a>


## Code Navigation

Xamarin Studio includes support for both finding declarations of any variable or type,
as well as any references where they are used. These are available from the editor’s context menu:

 ![](Images/ide-tour-image10.png)

Selecting **Go to declaration** navigates the editor to either the variable
declaration or to the type in the assembly browser. **Find references**
presents a list of all places in the project where the variable or type is used, as shown below:

 ![](Images/ide-tour-image11.png)

 <a name="Breadcrumb_Menu" class="injected"></a>


## Breadcrumb Menu

Just below the tabs is the breadcrumb menu, which allows exploration of the class structure contained within the selected file.

 ![](Images/ide-tour-image12.png)

 <a name="Tooltips" class="injected"></a>


## Tooltips

Rich, detailed tooltips are presented when hovering over various code elements within the editor.
These display information such as function signatures, summary descriptions and code template previews, as shown below:



 ![](Images/ide-tour-image13.png)


## Indentation and Comments

The editor includes support for automatic indention of code, which can be applied across an
entire file by selecting **Edit &gt; Format &gt; Format Document** from the main menu.

Additionally, indentation as well as comment toggling is available in the editor’s context menu:



  ![](Images/ide-tour-15.png)

 <a name="Snippets" class="injected"></a>


## Snippets

Xamarin Studio includes support for code templates, which allow common code constructs to be easily added.
The full list of snippets is available in the **Toolbox**:


 ![](Images/ide-tour-image16.png)

When typing in the editor, snippets appear in the code completion list,
where they can be selected to inject the associated code into the editor, as shown below for the snippet that injects an `enum`:


 ![](Images/ide-tour-image17.png)


# Refactoring

Xamarin Studio provides two useful ways to refactor your code: Context Actions, and Source Analysis. You can read more about them in the [Refactoring](/guides/cross-platform/xamarin-studio/refactoring/) guide.

The following screenshot shows the refactoring context menu that is displayed when right-clicking on a variable:

 ![](Images/ide-tour-image14.png)

### Source Analysis

Xamarin Studio is able to suggest changes to your code which either simplify or optimize the code. When the IDE finds such a change, a blue box will appear under the code that can potentially be changed. Placing the mouse on the line produces a pop up suggesting potential changes:

 ![](Images/ide-tour-codechange.png)

Selecting any option will change the code accordingly. If no change is required, click anywhere on the editor window or press the **Escape** key on the keyboard.

# Navigation and Search

## Global Search

Xamarin Studio includes unified search, located in the top-right corner of the IDE, which searches a solution’s types and files as well as available commands.

Matching results are grouped into the following sections:

-  **Top Result** &ndash; Shows the top matching result for the search string.
-  **Solution** &ndash; Shows a list of matching types within the solution.
-  **Files** &ndash; Shows a list of matching files for the search string.
-  **Commands** &ndash; Shows a list of available commands for the search string.


The following screenshot shows the result of searching for the string “app” in a solution:

![](Images/ide-tour-image18.png)

Selecting an item in the result list navigates to that item in the editor.

 <a name="Assembly_Browser" class="injected"></a>


## Assembly Browser

Xamarin Studio also includes an **Assembly Browser** for navigating types in any referenced assembly.
Double-clicking on an assembly from the Solution Pad loads it into the Assembly Browser.

For example, the following screenshot shows the `System` assembly loaded in the Assembly Browser:

![](Images/ide-tour-image19.png)

 <a name="Assembly_Search" class="injected"></a>


### Assembly Search

The Assembly Browser also supports search with auto-complete. For example, typing **CAD** in the search box displays the following types:

 ![](Images/ide-tour-image20.png)

The Assembly Browser is also integrated with the code editor, where selecting **Go to declaration**
on a type that exists in a referenced assembly will navigate to that type in the Assembly Browser. For example, the
following shows the Assembly Browser with the `UIWindow` loaded after it was selected in the code editor:

![](Images/ide-tour-image21.png)

 <a name="Debugger" class="injected"></a>


# Debugging

Xamarin Studio has a native debugger allowing debugging support for Xamarin.iOS, Xamarin.Mac and Xamarin.Android applications. Xamarin Studio uses the Mono Soft Debugger, which is implemented into the Mono runtime allowing Xamarin Studio to debug managed code across all platforms. For additional information on debugging, visit the [Debugging with Xamarin](/guides/cross-platform/xamarin-studio/debugging_with_xamarin/) guide.

The following image shows the debugger stopped at a breakpoint with the inline watch popup displayed when hovering over a variable:

 ![](Images/ide-tour-image22.png)

Xamarin Studio's debugger contains rich visualizers for special types such as strings, colors, URLs as well as the sizes, co-ordinates and bézier curves.

For more information on the debugger's data visualizations visit the [Data Visualizations](/guides/cross-platform/xamarin-studio/debugging_with_xamarin/data_visualizations/) guide.

 <a name="Source_Control_Integration" class="injected"></a>


# Version Control Integration

Xamarin Studio integrates with *Git* and *Subversion* source control systems. Projects under source control are denoted
with an annotation on their icons in the Solution Pad, as shown below:

 ![](Images/ide-tour-image23.png)

For a project under source control, the context menu of the item in the Solution Pad will have its **Version Control** menu enabled,
showing various commands, as shown below:

 ![](Images/ide-tour-image24.png)

Also, the main menu’s **Version Control** menu includes a variety of additional commands for working with source control:

 ![](Images/ide-tour-image25.png)

 <a name="Differences,_History_and_Merging" class="injected"></a>


## Differences, History and Merging

There are buttons at the bottom of the editor area that allow you to inspect differences in the selected file, change history, view individual code commits, view logs, and perform merges:

 ![](Images/ide-tour-image26a.png)

For example, the following screenshot shows the differences the source file and all the commits that have been made to that file:

 ![](Images/ide-tour-image26.png)

For more information on using version control in Xamarin Studio, refer to the [Version Control](/guides/cross-platform/xamarin-studio/version-control/) guide.

# Release Notes

The latest release notes for all installed Xamarin products can all be accessed via the Help menu bar item in Xamarin Studio. This will open a link in your browser:


![](Images/ide-tour-image32.png)

