---
title: "Compiling and Building in Visual Studio for Mac"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: FB253757-DB00-4889-A6BF-E44722E25BD1
---

# Compiling and Building in Visual Studio for Mac

Visual Studio for Mac can be used to basic explanation of compiling and building
advantages of compiling and building

## Choosing a Build method:

### Using the IDE

Using Visual Studio for Mac lets you to create and run builds instantly, while still giving you control over build functionality. Visual Studio for Mac uses MSBuild as the underlying build system.

All Projects and Solutions created in the IDE will have a default build configuration, which define the context for builds. These configurations can be edited or you can create your own. Creating or modifying these configurations will automatically update the project file, which is then used by MSBuild to build your project.  

For more information regarding how to build projects and solutions in the IDE, see the [Building and cleaning Projects and Solutions](../building-and-cleaning-projects-and-solutions) guide.

Visual Studio for Mac can also be used to do the following:

* Change the output path. This is edited in your Project's options:

    ![Change output path](media/compiling-and-building-image4.png)

* Change the verbosity of the build output:

    ![Change build verbosity](media/compiling-and-building-image5.png)

* Add Custom Commands before, during, or after Building or Cleaning:

    ![add custom commands](media/compiling-and-building-image6.png)

### Building from command line

You can use MSBuild Build Engine to build applications via the command line.

See the [MSBuild](https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild) content for more information on using MSBuild.

### Using VSTS

* [Build your Xamarin App](https://www.visualstudio.com/en-us/docs/build/apps/mobile/xamarin)
* [Continuous Integration with Xamarin](https://developer.xamarin.com/guides/cross-platform/ci/)