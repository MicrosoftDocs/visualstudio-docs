---
title: "What's new in Visual Studio 2022"
titleSuffix: ""
description: "Learn about the new features in the preview release of Visual Studio 2022."
ms.date: 11/18/2021
helpviewer_keywords:
  - "Visual Studio, what's new"
  - "what's new [Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology:
ms.prod: visual-studio-dev17
ms.topic: conceptual
ms.workload:
  - "multiple"
---
# What's new in Visual Studio 2022

**Updated for the 17.0 GA (General Availability) release.** See [full release notes](/visualstudio/releases/2022/release-notes) | View [product roadmap](/visualstudio/productinfo/vs-roadmap/)

>[!div class="button"]
>[Download Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)

With [Visual Studio 2022](https://visualstudio.microsoft.com/vs/), you'll always get the best-in-class tools and services available for any developer, any app, and any platform. Whether you're using Visual Studio for the first time or you've been using it for years, there's a lot to like in our newest version!

> [!TIP]
> Check out the [**Visual Studio 2022 launch event**](https://www.youtube.com/watch?v=f8jXO946eDw) on our [YouTube channel](https://www.youtube.com/visualstudio). You can also catch it on our [Twitch channel](https://www.twitch.tv/visualstudio), too.

## Performance improvements

Visual Studio 2022 is faster, more approachable, more lightweight, and is designed for both learners and those building industrial scale solutions.

### Visual Studio 2022 is 64-bit

Visual Studio 2022 on Windows is now a 64-bit application. This means you can open, edit, run, and debug even the biggest and most complex solutions without running out of memory. To learn more, see both the [Visual Studio 2022 vision](https://devblogs.microsoft.com/visualstudio/visual-studio-2022/) and [Visual Studio 2022 Preview 1](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-1-now-available/) blog posts.

### Find in Files is faster

And, in [Visual Studio 2022 Preview 4](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/), we focused on improving the performance of several key features. For example, [Find in Files](find-in-files.md) is now as much as 3x faster when searching large solutions such as [Orchard Core](https://github.com/OrchardCMS/OrchardCore).

:::image type="content" source="media/vs-2022/find-files-faster.gif" alt-text="Animation of the Find in Files feature as it searches a large C# solution three times faster than the previous version of Visual Studio.":::

## Build modern apps

Visual Studio 2022 makes it quick and easy to build modern, cloud-based applications with Azure. As well, our new version also has full support for .NET 6 and its unified framework for web, client, and mobile apps for both Windows and Mac developers. And, Visual Studio 2022 includes robust support for the C++ workload with new productivity features, C++20 tooling, and IntelliSense.

### Better dev tools for C++ and .NET, and Hot Reload

[Visual Studio 2022 Preview 2](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-2-is-out/) includes better cross-platform app development tools and the latest version of C++ build tools, to include C++20 support.

As well, we're updating **Hot Reload** so that you can edit either C++ or .NET projects while your application is running. For more information, see the [**Speed up your .NET and C++ development with Hot Reload in Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/speed-up-your-dotnet-and-cplusplus-development-with-hot-reload-in-visual-studio-2022/) blog post, and the [Write and debug running code with Hot Reload in Visual Studio with C#, C++, or Visual Basic](../debugger/hot-reload.md) Docs page.

### Updates for Blazor & Razor editors + Hot Reload for ASP.NET

And, new in [Visual Studio 2022 Preview 4](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/), there’s a big update for the Blazor and Razor editors, and new capabilities for **Hot Reload** in ASP.NET Core&mdash;including **Hot Reload** when you save a file or when you apply changes to CSS files live!

:::image type="content" source="media/vs-2022/hot-reload-blazor-css-live.gif" alt-text="Animation of Hot Reload in Razor and Blazor apps, and in CSS files live.":::

## Innovation at your fingertips

From real-time & asynchronous collaboration tools to improved insights and productivity tools that seamlessly integrate with your daily workflow, Visual Studio 2022 has this  and more.

### Multi-repo support with Git in the IDE

If you've worked with projects hosted on different Git repositories, you might have used external tools or multiple instances of Visual Studio to connect to them. Starting with [Visual Studio 2022 Preview 3](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-3-now-available/), you can work with a single solution that has projects in multiple repositories and contribute to them all from a single instance of Visual Studio. To learn more, see the [**Multi-repo support in Visual Studio**](https://devblogs.microsoft.com/visualstudio/multi-repo-support-in-visual-studio/) blog post.

### IntelliCode improvements

* **Whole line completion**: In Visual Studio 2022, the [IntelliCode](/visualstudio/intellicode/) feature can now automatically complete code up to a whole line at a time. For details, see the [**Type less, code more with IntelliCode completions**](https://devblogs.microsoft.com/visualstudio/type-less-code-more-with-intellicode-completions/) blog post.

* **Quick Actions recommendations**: New in [Visual Studio 2022 Preview 4](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/), IntelliCode can now spot when you’re performing a common task and recommend the right [Quick Action](quick-actions.md), completing it right as you’re typing. To learn more, see the [**Discover quick actions for common tasks as you type, with IntelliCode**](https://devblogs.microsoft.com/visualstudio/discover-quick-action-intellicode/) blog post.

## Designing for everyone

We’re refreshing the user interface to better keep you in your flow. Some of the changes include cosmetic touches that modernize the UI or reduce crowding.

### Look & feel

From new iconography to subtle color contrast ratio adjustments and a new [Cascadia Code](https://github.com/microsoft/cascadia-code#welcome) font, we're working to make Visual Studio 2022 more accessible for everyone. For all the details, see the [**We’ve upgraded the UI in Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/weve-upgraded-the-ui-in-visual-studio-2022/) blog post.

:::image type="content" source="media/vs-2022/icon-refresh.png" alt-text="Screenshot of the contrast between previous and refreshed icons in Visual Studio.":::

### Personalization

One of our key focus areas is to make Visual Studio more personalized and flexible so that you can make the IDE your own. For example, [Visual Studio 2022 Preview 3](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-3-now-available/) offers you the ability to sync with your Windows theme. So, if you've enabled the "night light" feature there, Visual Studio uses it, too. For more info, see the [**Personalize your Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/personalize-your-visual-studio-2022/) blog post.

## What's next

Want to know more about what we're planning for Visual Studio 2022? See the [**Roadmap**](/visualstudio/productinfo/vs-roadmap/) page and the [**Visual Studio 2022 Preview**](/visualstudio/releases/2022/release-notes-preview/) release notes for details.

## Give us feedback

Why send feedback to the Visual Studio team? Because we take customer feedback seriously. It drives much of what we do.

* If you want to make a suggestion about how we can improve Visual Studio, you can do so by using the [Suggest a Feature](suggest-a-feature.md) tool.

* If you experience an issue where Visual Studio stops responding, crashes, or other performance issues, you can easily share repro steps and supporting files with us by using the [Report a Problem](how-to-report-a-problem-with-visual-studio.md) tool.

## See also

* [Visual Studio 2022 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-now-available/)
* [Launch: Visual Studio 2022 GA (General Availability)](https://devblogs.microsoft.com/visualstudio/join-us-november-8th-for-the-launch-of-visual-studio-2022/)
* [Visual Studio 2022 RC (Release Candidate)](https://devblogs.microsoft.com/visualstudio/join-us-november-8th-for-the-launch-of-visual-studio-2022/)
* [Visual Studio 2022 Preview 4](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/)
* [Visual Studio 2022 Preview 3](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-3-now-available/)
* [Visual Studio 2022 Preview 2](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-2-is-out/)
* [Visual Studio 2022 Preview 1](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-1-now-available/)
* [Visual Studio 2022 vision](https://devblogs.microsoft.com/visualstudio/visual-studio-2022/)