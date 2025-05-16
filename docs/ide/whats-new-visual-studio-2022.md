---
title: "What's new in Visual Studio 2022"
titleSuffix: ""
description: Discover new features in Visual Studio 2022, including answers to questions and AI consultations while you code with a subscription to GitHub Copilot.
ms.date: 5/13/2025
helpviewer_keywords:
  - "Visual Studio, what's new"
  - "what's new [Visual Studio]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice:

ms.topic: whats-new
---
# What's new in Visual Studio 2022

**Updated for the 17.14 release.** See [full release notes](/visualstudio/releases/2022/release-notes) | View [product roadmap](/visualstudio/productinfo/vs-roadmap/)

>[!div class="button"]
>[Download Visual Studio 2022](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)

With [Visual Studio 2022](https://visualstudio.microsoft.com/vs/), you'll always get the best-in-class tools and services available for any developer, any app, and any platform. Whether you're using Visual Studio for the first time or you've been using it for years, there's a lot to like in our newest version.

Want to see what's new in each updated release from within Visual Studio itself? Now you can! From the menu bar, select **Help** > **What's New** to view recent highlights.

:::image type="content" source="media/vs-2022/whats-new-visual-studio.png" alt-text="Screenshot of the in-product notification of what's new in each updated release of Visual Studio." lightbox="media/vs-2022/whats-new-visual-studio.png":::

> [!TIP]
> For more news + how-to's, check out our Visual Studio social media channels on [LinkedIn](https://www.linkedin.com/showcase/microsoft-visual-studio), [YouTube](https://www.youtube.com/visualstudio), [Facebook](https://www.facebook.com/visualstudio), [Twitch](https://www.twitch.tv/visualstudio), [X](https://x.com/VisualStudio), & [TikTok](https://www.tiktok.com/@visualstudio). And for the latest info on recent releases, current experiments, and what's in Preview, be sure to visit the Visual Studio [Blog](https://devblogs.microsoft.com/visualstudio/).

## AI-assisted development

With a subscription to GitHub Copilot, you can get answers to questions and consult with an AI while you code. Visual Studio 2022 version 17.4 and later include integration with [GitHub Copilot](../ide/visual-studio-github-copilot-extension.md), and version 17.6 and later also support GitHub Copilot Chat. See [AI-assisted development](../ide/ai-assisted-development-visual-studio.md).

In version 17.9 and later, try out [AI-generated commit messages](../version-control/git-make-commit.md#generate-commit-messages-with-github-copilot-chat).

## Performance improvements

Visual Studio 2022 is faster, more approachable, more lightweight, and is designed for both learners and those building industrial scale solutions. Plus, we continue to focus on performance with each iterative release. To learn more, see the [Visual Studio 2022 – 17.5 Performance Enhancements](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-5-performance-enhancements/) blog post.

### Visual Studio 2022 is 64-bit

Visual Studio 2022 on Windows is now a 64-bit application. This means you can open, edit, run, and debug even the biggest and most complex solutions without running out of memory. To learn more, see both the [Visual Studio 2022 vision](https://devblogs.microsoft.com/visualstudio/visual-studio-2022/) and [Visual Studio 2022 17.0 Preview](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-1-now-available/) blog posts.

### Find in Files is faster

In [Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/), we focused on improving the performance of several key features. For example, [Find in Files](find-in-files.md) is now as much as 3x faster when searching large solutions such as [Orchard Core](https://github.com/OrchardCMS/OrchardCore).

:::image type="content" source="media/vs-2022/find-files-faster.gif" alt-text="Animation of the Find in Files feature as it searches a large C# solution three times faster than the previous version of Visual Studio.":::

**New in [17.1](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-1-is-now-available/)**: With new indexed searching, Find in Files is even faster! For more information, see the [**Code search in Visual Studio 2022 is about to get much faster**](https://devblogs.microsoft.com/visualstudio/code-search-in-visual-studio-is-about-to-get-much-faster/) blog post.

**New in [17.8](https://devblogs.microsoft.com/visualstudio/visual-studio-17-8-now-available/)**: Save time with case-preserving search and replace. See [Replace in files - Preserve case](replace-in-files.md#preserve-case).

> [!TIP]
> To learn more about current and upcoming changes to the search experience in Visual Studio 2022, see the [Sneak Peek and Edit Your Code While You Search](https://devblogs.microsoft.com/visualstudio/sneak-peek-and-edit-your-code-while-you-search/) blog post.

### Git tooling is faster

**New in [17.8](https://devblogs.microsoft.com/visualstudio/visual-studio-17-8-now-available/)**, you can [create a pull request from the Visual Studio IDE](../version-control/git-create-pull-request.md). Also, try the new summary view for diffs, to make it easier to focus on what changed.

**New in [17.2](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-2-is-now-available/)**: We've integrated a relatively new Git feature called the [commit graph](https://devblogs.microsoft.com/devops/supercharging-the-git-commit-graph/), which helps to improve both the performance of your Git operations and the performance of Visual Studio itself. For the latest info, see the [Supercharge your Git experience in Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/supercharge-your-git-experience-in-vs/) blog post.

## Build modern apps

Visual Studio 2022 makes it quick and easy to build modern, cloud-based applications with Azure. See [Azure development with Visual Studio](../azure/overview.md). As well, our new version also has full support for .NET and its unified framework for web, client, and mobile apps for both Windows and Mac developers. And, Visual Studio 2022 includes robust support for the C++ workload with new productivity features, C++20 tooling, and [IntelliSense](using-intellisense.md).

> [!TIP]
> To learn more about **.NET 8**, the successor to [.NET 7](/dotnet/core/whats-new/dotnet-7/), see [What's new in .NET 8](/dotnet/core/whats-new/dotnet-8/overview).

### Better dev tools for C++ and .NET, and Hot Reload

[Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-2-is-out/) includes better cross-platform app development tools and the latest version of C++ build tools, to include C++20 support.

As well, we're updating **Hot Reload** so that you can edit either C++ or .NET projects while your application is running. For more information, see the [**Speed up your .NET and C++ development with Hot Reload in Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/speed-up-your-dotnet-and-cplusplus-development-with-hot-reload-in-visual-studio-2022/) blog post, and the [Write and debug running code with Hot Reload in Visual Studio with C#, C++, or Visual Basic](../debugger/hot-reload.md) Docs page.

### Updates for Blazor & Razor editors + Hot Reload for ASP.NET

[Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-4-is-now-available/) includes a big update for the Blazor and [Razor](https://devblogs.microsoft.com/visualstudio/introducing-the-new-razor-editor-in-visual-studio-2022/) editors, and new capabilities for **Hot Reload** in ASP.NET Core&mdash;including **Hot Reload** when you save a file or when you apply changes to CSS files live!

:::image type="content" source="media/vs-2022/hot-reload-blazor-css-live.gif" alt-text="Animation of Hot Reload in Razor and Blazor apps, and in CSS files live.":::

## Innovation at your fingertips

From real-time & asynchronous collaboration tools to improved insights and productivity tools that seamlessly integrate with your daily workflow, Visual Studio 2022 has this and more.

### Git multi-repo support and line-staging support

**New in [17.4](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-4/)**: If you've worked with projects hosted on different Git repositories, you might have used external tools or multiple instances of Visual Studio to connect to them. Now, you can work with a single solution that has projects in multiple repositories and contribute to them all from a single instance of Visual Studio. To learn more, see the [**Multi-repo support in Visual Studio**](https://devblogs.microsoft.com/visualstudio/multi-repo-support-in-visual-studio/) and [Multi-repository support released](https://devblogs.microsoft.com/visualstudio/multi-repository-support-released/) blog posts, along with the [Work with multiple repos](../version-control/git-multi-repository-support.md) page.

**New in [17.3](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-3-is-now-available/)**: We added line-staging support, also known as [interactive staging](https://git-scm.com/book/en/v2/Git-Tools-Interactive-Staging). Now, you can stage chunks of changes in your files right from the code editor, or split changes across different commits. For more information, see the [**Stage lines of code in Visual Studio**](../version-control/git-line-staging.md) page.

### IntelliCode improvements

* **Whole line completion**: In Visual Studio 2022, the [IntelliCode](/visualstudio/intellicode/) feature can now automatically complete code up to a whole line at a time. For details, see the [**Type less, code more with IntelliCode completions**](https://devblogs.microsoft.com/visualstudio/type-less-code-more-with-intellicode-completions/) blog post.

* **Quick Actions recommendations**: [IntelliCode](/visualstudio/intellicode/) can now spot when you’re performing a common task and recommend the right [Quick Action](quick-actions.md), completing it right as you’re typing. To learn more, see the [**Discover quick actions for common tasks as you type, with IntelliCode**](https://devblogs.microsoft.com/visualstudio/discover-quick-action-intellicode/) blog post.

## Designing for everyone

We’re refreshing the user interface to better keep you in your flow. Some of the changes include cosmetic touches that modernize the UI or reduce crowding.

### Look & feel

From new iconography to subtle color contrast ratio adjustments and a new [Cascadia Code](https://github.com/microsoft/cascadia-code#welcome) font, we're working to make Visual Studio 2022 more accessible for everyone. For all the details, see the [**We’ve upgraded the UI in Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/weve-upgraded-the-ui-in-visual-studio-2022/) blog post.

:::image type="content" source="media/vs-2022/icon-refresh.png" alt-text="Screenshot of the contrast between previous and refreshed icons in Visual Studio.":::

### Personalization

One of our key focus areas is to make Visual Studio more personalized and flexible so that you can make the IDE your own. For example, [Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-3-now-available/) offers you the ability to sync with your Windows theme. So, if you've enabled the "night light" feature there, Visual Studio uses it, too. For more info, see the [**Personalize your Visual Studio 2022**](https://devblogs.microsoft.com/visualstudio/personalize-your-visual-studio-2022/) blog post.

> [!TIP]
> To learn more about the latest tabs and docs updates in Visual Studio 2022, see the [**Improved doc management personalization**](https://devblogs.microsoft.com/visualstudio/doc-management-personalization/) blog post.

## What's next

Want to know more about what we're planning for Visual Studio 2022? See the [**Roadmap**](/visualstudio/productinfo/vs-roadmap/) page, the [**Preview**](/visualstudio/releases/2022/release-notes-preview/) release notes, and the Visual Studio [**Blog**](https://devblogs.microsoft.com/visualstudio/) for details.

## Give us feedback

Why send feedback to the Visual Studio team? Because we take customer feedback seriously. It drives much of what we do.

* If you want to make a suggestion about how we can improve Visual Studio, you can do so by using the [Suggest a Feature](suggest-a-feature.md) tool.

* If you experience an issue where Visual Studio stops responding, crashes, or other performance issues, you can easily share repro steps and supporting files with us by using the [Report a Problem](how-to-report-a-problem-with-visual-studio.md) tool.

## Related content

Review the following blog posts to learn more about the improvements we've made to Visual Studio 2022, to date:

* [Visual Studio 2022 17.14 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-v17-14-is-now-generally-available/)
* [Visual Studio 2022 17.13 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-v17-13-is-now-available/)
* [Visual Studio 2022 17.12 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-v17-12-with-dotnet-9/)
* [Visual Studio 2022 17.11 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-v17-11-your-feedback-in-action/)
* [Visual Studio 2022 17.10 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-10-now-available/)
* [Visual Studio 2022 17.9 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-9-now-available/)
* [Visual Studio 2022 17.8 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-17-8-now-available/)
* [Visual Studio 2022 17.7 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-7-now-available/)
* [Visual Studio 2022 17.6 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-6-now-available/)
* [Visual Studio 2022 17.5 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-5-released/)
* [Visual Studio 2022 17.4 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-4/)
* [Visual Studio 2022 17.3 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-3-is-now-available/)
* [Visual Studio 2022 17.2 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-2-is-now-available/)
* [Visual Studio 2022 17.1 is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-1-is-now-available/)
