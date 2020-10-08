---
title: "Visual C++ for Cross-Platform Mobile Development | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-mobile
ms.topic: conceptual
dev_langs: 
  - "C++"
ms.assetid: 0bb872d6-981b-4c96-9143-fcec5336bf0d
caps.latest.revision: 12
author: corob-msft
ms.author: corob
manager: jillfra
---
# Visual C++ for Cross-Platform Mobile Development
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can build native C++ apps for iOS, Android and Windows devices, and share common code in libraries built for iOS, Android, and Windows, by using Visual C++ for Cross-Platform Mobile Development. This is an option available in Visual Studio 2015 that installs the SDKs and tools you need for cross-platform development of shared libraries and native apps. When it's installed, you can use Visual C++ to create code that runs on iOS and Android devices and platforms, in addition to Windows, Windows Phone, and Xbox.  
  
 Writing code for multiple platforms can be frustrating. The primary development languages and tools for iOS, Android, and Windows are different on each platform. However, all platforms support writing code in C++. This is the common denominator that you can use to enable reuse of core code across platforms. Native code written in C++ can be both more performant and resistant to reverse engineering. Code reuse can save both time and effort when creating apps for multiple platforms.  
  
 Development using Visual C++ for Cross-Platform Mobile Development has several advantages:  
  
1. **Easy installation.** The Visual Studio installer acquires and installs the required third-party tools and SDKs you need to build apps or libraries for Android and iOS. Configuration and setup is simple and mostly automatic.  
  
2. **A powerful and familiar build environment.** Create sharable cross-platform solutions and projects easily with Visual Studio templates. Manage properties for all projects using one common interface. Edit all your code in the Visual Studio editor, and take advantage of the built-in cross-platform IntelliSense for code completion and error highlighting.  
  
3. **A unified debugging experience.** Use the world-class debugging tools in Visual Studio to watch and step through C++ code on all platforms, including Android devices and emulators, iOS simulators and devices, and Windows or Windows Phone devices and emulators.  
  
## Get the tools  
 Visual C++ for Cross-Platform Mobile Development is an installable option that comes with Visual Studio 2015. For prerequisites and installation instructions, see [Install Visual C++ for Cross-Platform Mobile Development](../cross-platform/install-visual-cpp-for-cross-platform-mobile-development.md). To build code for iOS, you also need a Mac computer and an Apple iOS Developer Account. For more information, see [Install And Configure Tools to Build using iOS](../cross-platform/install-and-configure-tools-to-build-using-ios.md).  
  
## Come up to speed  
 If you're coming from Android or iOS development, we have some great material on how to get started. Visual Studio is an expressive and capable development environment. To learn how to use it, try [Getting started for Android developers](https://msdn.microsoft.com/library/windows/apps/dn275875.aspx) or [Getting started for iOS developers](https://msdn.microsoft.com/library/windows/apps/xaml/jj657966.aspx). These topics will introduce you to Visual Studio and the concepts you'll need to develop cross-platform apps for Windows and Windows Phone. To get started writing your first cross-platform app for iOS and Android, see [Build an OpenGL ES Application on Android and iOS](../cross-platform/build-an-opengl-es-application-on-android-and-ios.md).  
  
 Visual C++ for Cross-Platform Mobile Development includes several templates to help you get started on your apps:  
  
- OpenGLES 2 Application (Android, iOS, Windows Universal)  
  
     Creates a solution that includes a set of projects to build an Android Native Activity app, an iOS app, and a Universal Windows app, together with a shared C++ code library. These apps use platform-specific libraries created by using common C++ OpenGL ES code to draw the same spinning cube in each app. You must include the Universal Windows App Development Tools option when you install Visual Studio to use this template.  
  
- Native-Activity Application (Android)  
  
     Creates a complete C++ OpenGL app as an Android Native Activity project.  
  
- OpenGLES Application (Android, iOS)  
  
     Creates a solution with a set of projects to build both an Android Native Activity app and an iOS app. These apps use platform-specific libraries created by using common C++ OpenGL ES code to draw the same spinning cube in each app.  
  
- Shared Library (Android, iOS)  
  
     Creates a solution with projects to create an Android dynamic library (.so) file and an iOS static library (.a) file by using common C++ code in a shared project.  
  
- Basic Application (Android, Ant)  
  
     Creates an Android "Hello, World" app project that uses only Java source code and the Ant build system.  
  
- Basic Application (Android, Gradle)  
  
     Creates an Android "Hello, World" app project that uses only Java source code and the Gradle build system.  
  
- Basic Library (Android, Ant)  
  
     Creates an Android "Hello, World" library project that uses only Java source code and the Ant build system.  
  
- Basic Library (Android, Gradle)  
  
     Creates an Android "Hello, World" library project that uses only Java source code and the Gradle build system.  
  
- Dynamic Shared Library (Android)  
  
     Creates an Android dynamic library (.so) file by using C++ code.  
  
- OpenGLES 2 Application (iOS)  
  
     Creates a solution with a set of projects to build an OpenGL ES 2 iOS app. The app uses a library of C++ OpenGL ES code to draw the spinning cube in an iOS app. This app can be a good starting point for seeing how to import C++ libraries into your iOS app.  
  
- Static Library (Android)  
  
     Creates a project to build a static library for Android. You can only link one dynamic library in an Android app, but you can link any number of static libraries.  
  
- Static Library (iOS)  
  
     Creates a project to build a static library for iOS.  
  
- Makefile Project (Android)  
  
     Creates a project wrapper for your own Android makefile projects.  
  
## Try out sample code  
 Download samples that show how to create shared code libraries you can use in Windows, Android, and iOS apps, and how to create complete Native Activity apps for Android. To get started, see [Cross-Platform Mobile Development Examples](../cross-platform/cross-platform-mobile-development-examples.md).  
  
## In this section  
  
1. [Install Visual C++ for Cross-Platform Mobile Development](../cross-platform/install-visual-cpp-for-cross-platform-mobile-development.md)  
  
2. [Install And Configure Tools to Build using iOS](../cross-platform/install-and-configure-tools-to-build-using-ios.md)  
  
3. [Create an Android Native Activity App](../cross-platform/create-an-android-native-activity-app.md)  
  
4. [Build an OpenGL ES Application on Android and iOS](../cross-platform/build-an-opengl-es-application-on-android-and-ios.md)  
  
5. [Cross-Platform Mobile Development Examples](../cross-platform/cross-platform-mobile-development-examples.md)
