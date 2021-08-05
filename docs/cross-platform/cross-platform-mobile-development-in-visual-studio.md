---
title: "Cross-Platform Mobile Development in Visual Studio | Microsoft Docs"
description: In this article, learn how you can build apps for Android, iOS, and Windows devices by using Visual Studio.
titleSuffix: ""
ms.custom: SEO-VS-2020
ms.date: "10/17/2019"
ms.technology: vs-ide-mobile
ms.topic: "conceptual"
ms.assetid: 8202717a-e990-45cf-b092-438651ccb38a
author: conceptdev
ms.author: crdun
manager: crdun
ms.workload:
  - "multiple"
---
# Cross-platform mobile development in Visual Studio

You can build apps for Android, iOS, and Windows devices by using Visual Studio.  As you design your app, use tools in Visual Studio to easily add connected services such as Microsoft 365, Azure App Service, and Application Insights.

Build your apps by using C# and the .NET Framework, HTML and JavaScript, or C++. Share code, strings, images, and in some cases even the user interface.

If you want to build a game or immersive graphical app, install Visual Studio tools for Unity and enjoy all of the powerful productivity features of Visual Studio with Unity, the popular cross-platform game/graphics engine and development environment for apps that run on iOS, Android, Windows, and other platforms.

## Build an app for Android, iOS, and Windows (.NET Framework)

![Devices](../cross-platform/media/homedevices.png "HomeDevices")

With Visual Studio Tools for Xamarin, you can target Android, iOS, and Windows in the same solution, sharing code and even UI.

|**Learn more**|
|--------------------|
|[Install Visual Studio](https://visualstudio.microsoft.com/vs/community/) (VisualStudio.com)|
|[Learn about Xamarin in Visual Studio](https://visualstudio.microsoft.com/xamarin/) (VisualStudio.com)|
|[Xamarin mobile app development documentation](/xamarin/) |
|[DevOps with Xamarin apps](/xamarin/tools/ci/devops/) |
|[Learn about Universal Windows apps in Visual Studio](https://visualstudio.microsoft.com/vs/universal-windows-platform/) (VisualStudio.com)|
|[Learn about the similarities between Swift and C#](https://aka.ms/scposter) (download.microsoft.com)|

### <a name="AndroidHTML"></a> Target Android, iOS, and Windows from a single code base

 You can build native apps for Android, iOS, and Windows by using C# or F# (Visual Basic is not supported at this time).  To get started, install Visual Studio, select the **Mobile Development with .NET** option in the installer.

 If you already have Visual Studio installed, re-run the **Visual Studio Installer** and select the same **Mobile Development with .NET** option for Xamarin (as above).

 When you're done, project templates appear in the **New Project** dialog box. The easiest way to find Xamarin templates is to just search on "Xamarin."

 Xamarin exposes the native functionality of Android, iOS, and Windows as .NET classes and methods. This means your apps have full access to native APIs and native controls, and they're just as responsive as apps written in the native platform languages.

 After you create a project, you'll leverage all of the productivity features of Visual Studio. For example, you'll use a designer to create your pages, and use IntelliSense to explore the native API's of the mobile platforms. When you're ready to run your app and see how it looks, you can use the Android SDK emulator and run Windows apps natively. You can also use tethered Android and Windows devices directly. For iOS projects, connect to a networked Mac and start the iOS emulator from Visual Studio, or connect to a tethered device.

#### Design one set of pages that render across all devices by using Xamarin.Forms

 Depending on the complexity of your apps design, you might consider building it by using *Xamarin.Forms* templates in the **Mobile Apps** group of project templates. Xamarin.Forms is a UI toolkit that lets you create a single interface that you can share across Android, iOS, and Windows.  When you compile a Xamarin.Forms solution, you'll get an Android app, an iOS app, and a Windows app. For more details, see [Learn about mobile development with Xamarin](/xamarin/cross-platform/get-started/introduction-to-mobile-development/) and the [Xamarin.Forms documentation](/xamarin/xamarin-forms/).

#### <a name="ShareHTML"></a> Share code between Android, iOS, and Windows apps

 If you're not using Xamarin.Forms and choose to design for each platform individually, you can share most of your non-UI code between platform projects (Android, iOS, and Windows). This includes any business logic, cloud integration, database access, or any other code that targets the .NET Framework. The only code that you can't share is code that targets a specific platform.

 ![Share code between Windows, iOS, and Android UIs](../cross-platform/media/sharecode.png "ShareCode")

 You can share your code by using a shared project, a Portable Class Library project, or both. You might find that some code fits best in a shared project, and some code makes more sense inside a Portable Class Library project.

|**Learn more**|
|--------------------|
|[Sharing Code Options](/xamarin/cross-platform/app-fundamentals/code-sharing/) (Xamarin) |
|[Code sharing options with .NET](/dotnet/standard/cross-platform/) |

### <a name="WindowsHTML"></a> Target Windows 10 devices

 ![Windows Devices](../cross-platform/media/windowsdevices.png "Windows Devices")

 If you want to create a single app that targets the full breadth of Windows 10 devices, create a universal Windows app. You'll design the app by using a single project and your pages will render properly no matter what device is used to view them.

 Start with a Universal Windows Platform (UWP) app project template. Design your pages visually, and then open them in a preview window to see how they appear for various types of devices. If you don't like how a page appears on a device, you can optimize the page to better fit the screen size, resolution, or various orientations such as landscape or portrait mode. You can do all of that by using intuitive tool windows and easily accessible menu options in Visual Studio. When you're ready to run your app and step through your code, you'll find all of the device emulators and simulators for different types of devices together in one drop-down list that is located on the **Standard** toolbar.

|**Learn more**|
|--------------------|
|[Intro to the Universal Windows Platform](/windows/uwp/get-started/universal-application-platform-guide)|
|[Create your first app](/windows/uwp/get-started/your-first-app)|
|[Develop apps for the Universal Windows Platform (UWP)](../cross-platform/develop-apps-for-the-universal-windows-platform-uwp.md)|

::: moniker range="vs-2017"

## <a name="HTML"></a> Build an app for Android, iOS, and Windows (HTML/JavaScript)

 ![Windows, iOS, and Android devices](../cross-platform/media/homedevices.png "Windows, iOS, and Android devices")

 If you're a web developer, and you're familiar with HTML and JavaScript, you can target Windows, Android, and iOS by using Visual Studio Tools for Apache Cordova. These apps can target all three platforms and you can build them by using the skills and processes that you're most familiar with.

 Apache Cordova is a framework that includes a plug-in model. This plug-in model provides a single JavaScript API that you can use to access the native device capabilities of all three platforms (Android, iOS, and Windows).

 Because these APIs are cross-platform, you can share most of what you write between all three platforms. This reduces your development and maintenance costs. Also, there's no need to start from scratch. If you've created other types of web applications, you can share those files with your Cordova app without having to modify or redesign them in any way.

 ![Multi-device hybrid apps with JavaScript](../cross-platform/media/multidevicehybridapps.png "Multi-device hybrid apps with JavaScript")

 To get started, install Visual Studio and choose the **Mobile Development with Javascript** feature during setup. The Cordova tools automatically install all third-party software that's required to build your multi-platform app.

 After you've installed the extension, open Visual Studio and create a **Blank App (Apache Cordova)** project. Then, you can develop your app by using JavaScript or Typescript. You can also add plug-ins to extend the functionality of your app, and APIs from plug-ins appear in IntelliSense as you write code.

 When you're ready to run your app and step through your code, choose an emulator, such as the Apache Ripple emulator or Android Emulator, a browser, or a device that you've connected directly to your computer. Then, start your app. If you're developing your app on a Windows PC, you can even run it on that. All of these options are built into Visual Studio as part of the Visual Studio Tools for Apache Cordova.

 Project templates for creating Universal Windows Platform (UWP) apps are still available in Visual Studio so feel free to use them if you plan to target only Windows devices. If you decide to target Android and iOS later, you can always port your code to a Cordova project.

|**Learn more**|
|--------------------|
|[Install Visual Studio](https://visualstudio.microsoft.com/vs/community/) (VisualStudio.com)|
|[Get started with Visual Studio Tools for Apache Cordova](/previous-versions/visualstudio/cross-platform/tools-for-cordova/)|
|[Learn about the Visual Studio Emulator for Android](https://visualstudio.microsoft.com/vs/msft-android-emulator/) (VisualStudio.com)|

::: moniker-end

<a name="CPP"></a>

## Build an app for Android, iOS, and Windows (C++)

![Use C&#43;&#43; to build for Android, iOS, and Windows](../cross-platform/media/cross_plat_cpp_intro_image.png "Cross_Plat_CPP_Intro_Image")

 First, install Visual Studio and the **Mobile Development with C++** workload. Then, you can build a native activity application for Android, or an app that targets Windows or iOS. You can target Android, iOS, and Windows in the same solution if you want, and then share code between them by using a cross-platform static or dynamic shared library.

 If you need to build an app for Android that requires any sort of advanced graphics manipulation, such as a game, you can use C++ to do it. Start with the **Native Activity Application (Android)** project. This project has full support for the Clang toolchain.

 ![Native activity project template](../cross-platform/media/cross-plat_cpp_native.png "Native activity project template")

 When you're ready to run your app and see how it looks, use the Android Emulator. It's fast, reliable, and easy to install and configure.

 You can also build an app that targets the full breadth of Windows 10 devices by using C++ and a Universal Windows Platform (UWP) app project template. Read more about this in the [Target Windows 10 devices](#WindowsHTML) section that appears earlier in this topic.

 You can share C++ code between Android, iOS, and Windows by creating a static or dynamic shared library.

 ![Static and dynamic shared libraries](../cross-platform/media/cross_plat_cpp_libraries.png "Static and dynamic shared libraries")

 You can consume that library in a Windows, iOS, or Android project, like the ones described earlier in this section. You can also consume it in an app that you build by using Xamarin, Java, or any language that lets you invoke functions in an unmanaged DLL.

 As you write code in these libraries, you can use IntelliSense to explore the native APIs of the Android and Windows platforms. These library projects are fully integrated with the Visual Studio debugger so you can set breakpoints, step through code, and find and fix issues by using all of the advanced features of the debugger.

|**Learn more**|
|--------------------|
|[Download Visual Studio](https://visualstudio.microsoft.com/downloads/) (VisualStudio.com)|
|[Install cross-platform mobile development with C++](/cpp/cross-platform/install-visual-cpp-for-cross-platform-mobile-development)|
|[Learn more about using C++ to target multiple platforms](https://visualstudio.microsoft.com/vs/cplusplus-mdd/) (VisualStudio.com)|
|[Install what you need, and then create a C++ native activity application for Android](/cpp/cross-platform/create-an-android-native-activity-app)|
|[Learn more about sharing C++ code with Android and Windows apps](https://visualstudio.microsoft.com/vs/cplusplus-mdd/) (VisualStudio.com)|
|[Cross-platform mobile development examples for C++](/cpp/cross-platform/cross-platform-mobile-development-examples)|

<a name="Unity"></a>

## Build a cross-platform game for Android, iOS, and Windows by using Visual Studio tools for Unity

 Visual Studio Tools for Unity is a free extension for Visual Studio that integrates Visual Studio's powerful code editing, productivity, and debugging tools with *Unity*, the popular cross-platform gaming/graphics engine and development environment for immersive apps that target Windows, iOS, Android, and other platforms including the web.

 ![VSTU development environment](../cross-platform/media/vstu_overview.png "Visual Studio Tools for Unity overview")

 With Visual Studio Tools for Unity (VSTU), you can use Visual Studio to write game and editor scripts in C# and then use its powerful debugger to find and fix errors. The latest release of VSTU brings support for Unity 2018.1 and includes syntax coloring for Unity's ShaderLab shader language, better synchronization with Unity, richer debugging, and improved code generation for the MonoBehavior wizard. VSTU also brings your Unity project files, console messages, and the ability to start your game into Visual Studio so you can spend less time switching to and from the Unity Editor while writing code.

|**Learn more**|
|--------------------|
|[Learn more about building Unity games with Visual Studio](https://visualstudio.microsoft.com/vs/features/game-development/#tab-4b0d0be8de5f65564ad)|
|[Read more about Visual Studio Tools for Unity](/visualstudio/gamedev/unity/get-started/visual-studio-tools-for-unity) |
|[Start using Visual Studio Tools for Unity](/visualstudio/gamedev/unity/get-started/getting-started-with-visual-studio-tools-for-unity) |
|[Read about the latest enhancements to the Visual Studio Tools for Unity 2.0 Preview](https://devblogs.microsoft.com/visualstudio/visual-studio-tools-for-unity-2-0-preview/) (Visual Studio blog)|
|[Watch a video introduction to the Visual Studio Tools for Unity 2.0 Preview](https://www.bing.com/videos/search?q=visual+studio+tools+for+unity&qs=n&form=QBVLPG&pq=visual+studio+tools+for+unity&sc=6-29&sp=-1&sk=#view=detail&mid=0A13177F0BC7463A24080A13177F0BC7463A2408&preserve-view=true) (Video)|
|[Learn about Unity](https://unity.com/) (Unity website)|

## See also

- [Add Microsoft 365 APIs to a Visual Studio project](/office/developer-program/office-365-developer-program)
- [Azure App Services - Mobile Apps](https://azure.microsoft.com/services/app-service/mobile/)
- [Visual Studio App Center](/appcenter)
