---
title: Build cross-platform apps in Visual Studio
description: Build cross-platform applications for Android, iOS, Mac Catalyst, and Windows devices by using Visual Studio and target devices from a single code base.
titleSuffix: ""
ms.date: 02/21/2025
ms.subservice: mobile-development
ms.topic: article
author: therealjohn
ms.author: johmil
---

# Cross-platform app development in Visual Studio

You can build apps for Android, iOS, Mac Catalyst, and Windows devices by using Visual Studio. As you design your app, use tools in Visual Studio to easily add connected services such as Microsoft 365, Azure App Service, and Application Insights.

Build your apps by using C# an .NET, HTML and JavaScript, or C++. Share code, strings, images, and in some cases even the user interface.

If you want to build a game or immersive graphical app, install Visual Studio Tools for Unity (VSTU) and enjoy all of the powerful productivity features of Visual Studio with Unity, the popular cross-platform game/graphics engine and development environment for apps that run on iOS, Android, Windows, and other platforms.

## Build an app for Android, iOS, Mac Catalyst, and Windows (.NET)

With .NET Multi-platform App UI (.NET MAUI) you can target Android, iOS, Mac Catalyst, and Windows in the same solution, sharing code and even UI.

|**Learn more**|
|--------------------|
|[Install Visual Studio](https://visualstudio.microsoft.com/vs/community/) (VisualStudio.com)|
|Learn about .NET MAUI](https://dotnet.microsoft.com/apps/maui) (dotnet.microsoft.com)|
|[.NET MAUI app development documentation](/dotnet/maui/) |
|Learn about the [similarities between Swift and C#](https://aka.ms/scposter) (download.microsoft.com)|

### <a name="AndroidHTML"></a> Target Android, iOS, Mac Catalyst, and Windows from a single code base

.NET MAUI is a cross-platform framework for creating native mobile and desktop apps with C# and XAML. .NET MAUI is the evolution of Xamarin.Forms, extended from mobile to desktop scenarios, with UI controls rebuilt from the ground up for performance and extensibility. If you've previously used Xamarin.Forms to build cross-platform user interfaces, you'll notice many similarities with .NET MAUI. However, there are also some differences. Using .NET MAUI, you can create multi-platform apps using a single project, but you can add platform-specific source code and resources if necessary. One of the key aims of .NET MAUI is to enable you to implement as much of your app logic and UI layout as possible in a single code-base.

To get started, install Visual Studio, select the **.NET Multi-platform App UI development** option in the installer. If you already have Visual Studio installed, rerun the **Visual Studio Installer** and select the same **.NET Multi-platform App UI development** option. When you're done, project templates appear in the **New Project** dialog box. The easiest way to find .NET MAUI templates is to just search on "MAUI". For more information about installing .NET MAUI and building your first app, see [Installation](/dotnet/maui/get-started/installation?tabs=visual-studio) and [Build your first app](/dotnet/maui/get-started/first-app?tabs=vswin).

.NET MAUI exposes the native functionality of Android, iOS, Mac Catalyst, and Windows as .NET classes and methods. Your apps have full access to native APIs and native controls, and they're as responsive as apps written in the native platform languages.

After you create a project, you'll use all of the productivity features of Visual Studio. For example, you'll use IntelliSense to explore the native APIs of the mobile platforms, and hot reload to modify your managed source code while the app is running, without the need to manually pause or hit a breakpoint. When you're ready to run your app and see how it looks, you can use the Android SDK emulator and run Windows apps natively. You can also use tethered Android and Windows devices directly. For iOS projects, connect to a networked Mac and start the iOS emulator from Visual Studio, or connect to a tethered device.

.NET MAUI apps compile into native app packages:

- Android apps built using .NET MAUI compile from C# into an intermediate language (IL) which is then just-in-time (JIT) compiled to a native assembly when the app launches.
- iOS apps built using .NET MAUI are fully ahead-of-time (AOT) compiled from C# into native ARM assembly code.
- macOS apps built using .NET MAUI use Mac Catalyst, a solution from Apple that brings your iOS app built with UIKit to the desktop, and augments it with additional AppKit and platform APIs as required.
- Windows apps built using .NET MAUI use the Windows UI 3 (WinUI 3) library to create native apps that target the Windows desktop.

For more information about .NET MAUI, see [What is .NET MAUI?](/dotnet/maui/what-is-maui).

### <a name="WindowsHTML"></a> Target Windows 10 devices

 :::image type="content" source="../cross-platform/media/windowsdevices.png" alt-text="Screenshot of different types of Windows devices.":::

If you want to create a single app that targets the full breadth of Windows 10 devices, create a universal Windows app. You'll design the app by using a single project and your pages will render properly no matter what device is used to view them.

Start with a Universal Windows Platform (UWP) app project template. Design your pages visually, and then open them in a preview window to see how they appear for various types of devices. If you don't like how a page appears on a device, you can optimize the page to better fit the screen size, resolution, or various orientations such as landscape or portrait mode. You can do all of that by using intuitive tool windows and easily accessible menu options in Visual Studio. When you're ready to run your app, and step through your code, you'll find all of the device emulators and simulators for different types of devices together in one dropdown list that is located on the **Standard** toolbar.

|**Learn more**|
|--------------------|
|[Intro to the Universal Windows Platform](/windows/uwp/get-started/universal-application-platform-guide)|
|[Create your first app](/windows/uwp/get-started/your-first-app)|
|[Develop apps for the Universal Windows Platform (UWP)](../cross-platform/develop-apps-for-the-universal-windows-platform-uwp.md)|

<a name="CPP"></a>

## Build an app for Android, iOS, and Windows (C++)

:::image type="content" source="../cross-platform/media/cross_plat_cpp_intro_image.png" alt-text="Screenshot showing the use C&#43;&#43; to build for Android, iOS, and Windows.":::

First, install Visual Studio and the **Mobile Development with C++** workload. Then, you can build a native activity application for Android, or an app that targets Windows or iOS. You can target Android, iOS, and Windows in the same solution if you want, and then share code between them by using a cross-platform static or dynamic shared library.

If you need to build an app for Android that requires any sort of advanced graphics manipulation, such as a game, you can use C++ to do it. Start with the **Native Activity Application (Android)** project. This project has full support for the Clang toolchain.

 :::image type="content" source="../cross-platform/media/cross-plat_cpp_native.png" alt-text="Screenshot showing native activity project template.":::

When you're ready to run your app and see how it looks, use the Android Emulator. It's fast, reliable, and easy to install and configure.

You can also build an app that targets the full breadth of Windows 10 devices by using C++ and a Universal Windows Platform (UWP) app project template. Read more about this in the [Target Windows 10 devices](#WindowsHTML) section that appears earlier in this article.

You can share C++ code between Android, iOS, and Windows by creating a static or dynamic shared library.

 :::image type="content" source="../cross-platform/media/cross_plat_cpp_libraries.png" alt-text="Screenshot showing static and dynamic shared libraries.":::

You can consume that library in a Windows, iOS, or Android project, like the ones described earlier in this article. You can also consume it in an app that you build by using .NET MAUI, Java, or any language that lets you invoke functions in an unmanaged DLL.

As you write code in these libraries, you can use IntelliSense to explore the native APIs of the Android and Windows platforms. These library projects are fully integrated with the Visual Studio debugger so you can set breakpoints. Step through code, and find and fix issues by using all of the advanced features of the debugger.

|**Learn more**|
|--------------------|
|[Download Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) (VisualStudio.com)|
|[Install cross-platform mobile development with C++](/cpp/cross-platform/install-visual-cpp-for-cross-platform-mobile-development)|
|Learn more about [using C++ to target multiple platforms](https://visualstudio.microsoft.com/vs/cplusplus-mdd/) (VisualStudio.com)|
|[Install what you need, and then create a C++ native activity application for Android](/cpp/cross-platform/create-an-android-native-activity-app)|
|Learn more about [sharing C++ code with Android and Windows apps](https://visualstudio.microsoft.com/vs/cplusplus-mdd/) (VisualStudio.com)|
|[Cross-platform mobile development examples for C++](/cpp/cross-platform/cross-platform-mobile-development-examples)|

<a name="Unity"></a>

## Build a cross-platform game for Android, iOS, and Windows by using Visual Studio Tools for Unity

Visual Studio Tools for Unity (VSTU) is a free extension for Visual Studio that integrates Visual Studio's powerful code editing, productivity, and debugging tools with *Unity*, the popular cross-platform gaming/graphics engine and development environment for immersive apps that target Windows, iOS, Android, and other platforms including the web.

 :::image type="content" source="../cross-platform/media/vstu_overview.png" alt-text="Screenshot showing the overview of Visual Studio Tools for Unity and development environment.":::

With Visual Studio Tools for Unity (VSTU), you can use Visual Studio to write game and editor scripts in C# and then use its powerful debugger to find and fix errors. The latest release of VSTU brings support for Unity 2019.4 and includes syntax coloring for Unity's ShaderLab shader language, better synchronization with Unity, richer debugging, and improved code generation for the MonoBehavior wizard. VSTU also brings your Unity project files, console messages, and the ability to start your game into Visual Studio so you can spend less time switching to and from the Unity Editor while writing code.

|**Learn more**|
|--------------------|
|Learn more about [building Unity games with Visual Studio](https://visualstudio.microsoft.com/vs/features/game-development/#tab-4b0d0be8de5f65564ad)|
|[Read more about Visual Studio Tools for Unity](/visualstudio/gamedev/unity/get-started/visual-studio-tools-for-unity) |
|[Start using Visual Studio Tools for Unity](/visualstudio/gamedev/unity/get-started/getting-started-with-visual-studio-tools-for-unity) |
|[Read about the latest enhancements to the Visual Studio Tools for Unity 2.0 Preview](https://devblogs.microsoft.com/visualstudio/visual-studio-tools-for-unity-2-0-preview/) (Visual Studio blog)|
|[Watch a video introduction to the Visual Studio Tools for Unity 2.0 Preview](https://www.bing.com/videos/search?q=visual+studio+tools+for+unity&qs=n&form=QBVLPG&pq=visual+studio+tools+for+unity&sc=6-29&sp=-1&sk=#view=detail&mid=0A13177F0BC7463A24080A13177F0BC7463A2408&preserve-view=true) (Video)|
|Learn about [Unity](https://unity.com/) (Unity website)|

## Related content

- [Add Microsoft 365 APIs to a Visual Studio project](/office/developer-program/office-365-developer-program)
- [Azure App Service - Mobile Apps](https://azure.microsoft.com/services/app-service/mobile/)
- [Visual Studio App Center](/appcenter)
