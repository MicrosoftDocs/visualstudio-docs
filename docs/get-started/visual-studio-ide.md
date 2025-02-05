---
title: What is the Visual Studio IDE?
titleSuffix: ''
description: Explore the Visual Studio integrated development environment (IDE) that empowers you to develop, edit, debug, version control, and deploy your app.
ms.date: 06/18/2024
ms.subservice: general-ide
ms.topic: overview
ms.custom: vs-acquisition
f1_keywords:
- vs.startpage
- VS.StartPage.HowDoI
author: anandmeg
ms.author: meghaanand
manager: mijacobs
#customer intent: As a developer, I want to understand the features of the Visual Studio IDE so that I can decide which features are useful to me.
---
# What is Visual Studio?

Visual Studio is a powerful developer tool that you can use to complete the entire development cycle in one place. It's a comprehensive integrated development environment (IDE) that you can use to write, edit, debug, and build code. Then deploy your app. Visual Studio includes compilers, code completion tools, source control, extensions, and many other features to enhance every stage of the software development process.

:::image type="content" source="media/visual-studio-overview.png" alt-text="Diagram shows the software development cycle, with Visual Studio addressing each part of the process.":::

With the variety of features and languages support in Visual Studio, you can grow from writing your first "Hello World" program to developing and deploying apps. For example, build, debug, and test .NET and C++ apps, edit ASP.NET pages in the web designer view, develop cross-platform mobile and desktop apps with .NET, or build responsive Web UIs in C#.

::: moniker range="vs-2019"

To install Visual Studio, select the following button, and [choose the edition of Visual Studio](#choose-your-visual-studio-edition) to download.

 > [!div class="button"]
 > [Download Visual Studio](/visualstudio/releases/2019/release-notes/)

::: moniker-end

::: moniker range=">=vs-2022"

To install Visual Studio, select the following button, and [choose the edition of Visual Studio](#choose-your-visual-studio-edition) to download.

 > [!div class="button"]
 > [Download Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)

::: moniker-end

## Why use Visual Studio?

Visual Studio provides developers a feature rich development environment to develop high-quality code efficiently and collaboratively.

- Workload-based installer - install only what you need
- Powerful coding tools and features - everything you need to build your apps in one place
- Multiple language support - code in C++, C#, JavaScript, TypeScript, Python, and more
- Cross-platform development - build apps for any platform
- Version control integration - collaborate on code with team mates
- AI-assisted development - write code more efficiently with AI assistance

## Discover Visual Studio

Visual Studio supports different parts of the software development cycle.

### Develop your code

Visual Studio IDE provides many [features](../ide/writing-code-in-the-code-and-text-editor.md) that make it easier for you to write and manage your code with confidence. For example, code quickly and accurately with [AI-assisted development](../ide/ai-assisted-development-visual-studio.md) tools. These tools include [GitHub Copilot](../ide/visual-studio-github-copilot-extension.md) and [IntelliCode](../ide/intellicode-visual-studio.md). Make quick improvements to your code using light bulbs that suggest actions, or expand/collapse blocks of code using outlining. Organize and explore your code with the **Solution Explorer** that shows your code organized by files or the **Class View** that shows your code organized by classes.

Learn more about all the features in the IDE that help you organize and edit content:

- [Code editor](tutorial-editor.md)
- [Personalize](../ide/personalizing-the-visual-studio-ide.md) the IDE and the editor 
- [Organize code](tutorial-projects-solutions.md)
- [Tips and tricks](../ide/productivity-features.md)

### AI-assisted development

[GitHub Copilot](../ide/visual-studio-github-copilot-extension.md), [GitHub Copilot Chat](../ide/visual-studio-github-copilot-chat.md), and [IntelliCode](../ide/intellicode-visual-studio.md) assist developers in writing code faster and with greater accuracy, help develop a deeper understanding of the codebase, and help with other development tasks such as writing unit tests, [debugging](../debugger/debug-with-copilot.md), and profiling.

Learn more about [AI-assisted development](../ide/ai-assisted-development-visual-studio.md) in Visual Studio:

Get started with GitHub Copilot in Visual Studio:

- [Install and manage GitHub Copilot](../ide/visual-studio-github-copilot-install-and-states.md)
- [Use GitHub Copilot Completions in Visual Studio](../ide/visual-studio-github-copilot-extension.md)
- [Use GitHub Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio)
- [Debug with Copilot](../debugger/debug-with-copilot.md)

### Build your app

You can compile and build your applications to create builds immediately and test them in a debugger. You can run multi-processor builds for C++ and C# projects. Visual Studio also provides several options that you can configure when you build applications. You can create a custom build configuration in addition to the built-in configurations, hide certain warning messages, or increase build output information.

Learn more about how to [compile and build in Visual Studio](../ide/compiling-and-building-in-visual-studio.md):

- [Create build configurations for your project](../ide/understanding-build-configurations.md)
- [Build an application](../ide/walkthrough-building-an-application.md)

### Debug your code

Integrated debugging in Visual Studio enables you to debug, profile, and diagnose with ease. You step through your code and look at the values stored in variables, set watches on variables to see when values changes, examine the execution path of your code. Visual Studio offers other ways to debug your code while it runs.

Learn more about debugging effectively in Visual Studio:

- [Debug your app](..//debugger/debugger-feature-tour.md)
- [Debugging techniques and tools](../debugger/write-better-code-with-visual-studio.md)
- [Measure app performance](../profiling/beginners-guide-to-performance-profiling.md)
- [Debug with Copilot](../debugger/debug-with-copilot.md)
- [Tips and tricks](../debugger/debugger-tips-and-tricks.md)

### Test your code

You can write high-quality code with comprehensive testing tools in Visual Studio. Unit tests give developers and testers a quick way to find logic errors in code. You can analyze how much code you're testing and see instant results in a test suite. Know the impact of every change you make with advanced features that test code while you type.

Learn more about the testing tools available in Visual Studio:

- [Use testing tools in Visual Studio](../test/improve-code-quality.md)
- [Create and run unit tests](../test/getting-started-with-unit-testing.md)
- [Analyze code coverage](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)

### Version control

With the integrated Git features in Visual Studio, you can clone, create, or open your own repositories. The Git tool window has everything you need to commit and push changes, manage branches, and resolve merge conflicts. If you have a GitHub account, you can manage those repos directly within Visual Studio.

Learn more about version control in Visual Studio:

- [Version control with Git](../version-control/git-with-visual-studio.md)
- [Visual Studio and GitHub](https://visualstudio.microsoft.com/vs/github/)

### Collaborate with others

Visual Studio Live Share enables real-time collaborative development. With Live Share you can share your project with your peers, no matter the language or platform. Get to the bottom of an issue fast by allowing your team to connect, navigate, set break points, and type in your editor session.

Learn more about how to collaborate with Live Share:

- [Collaborate with Live Share](/visualstudio/liveshare/quickstart/share)
- [Common use cases](/visualstudio/liveshare/reference/use-cases)

### Deploy your app

By deploying an application, service, or component, you distribute it for installation on other computers, devices, or servers, or in the cloud. You can choose the appropriate method in Visual Studio for the type of deployment that you need. Share your apps and code by publishing to the web or Azure, or by deploying to a network share or a local folder.

Learn more about how to [deploy your app using Visual Studio](/visualstudio/deployment/):

- [Deploy your app from Visual Studio](../deployment/deploying-applications-services-and-components.md)
- [Deploy your app to a folder, a web server, Azure, or another destination](../deployment/deploying-applications-services-and-components-resources.md)

## Choose your Visual Studio edition

There are three editions of Visual Studio:

- [Community](https://visualstudio.microsoft.com/vs/community/) - free, fully featured IDE for students, open-source developers, and individual developers.
- [Professional](https://visualstudio.microsoft.com/vs/professional/) - a subscription based option for individual developers or small teams.
- [Enterprise](https://visualstudio.microsoft.com/vs/enterprise/) - a subscription based option for small to large business and enterprise organizations.

[Compare features across Visual Studio editions](https://visualstudio.microsoft.com/vs/compare/) and [acquire the Visual Studio edition](https://visualstudio.microsoft.com/vs/pricing/) that best fits your needs.

## Install Visual Studio

Select the following button to install Visual Studio, and choose the edition of Visual Studio.

::: moniker range="vs-2019"

 > [!div class="button"]
 > [Download Visual Studio](/visualstudio/releases/2019/release-notes/)

::: moniker-end

::: moniker range=">=vs-2022"

 > [!div class="button"]
 > [Download Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)

::: moniker-end

## Get started

Dive into coding with one of the following language-specific tutorials:

- [Create a simple C# console app](./csharp/tutorial-console.md)
- [Get started with Python](../python/tutorial-working-with-python-in-visual-studio-step-00-installation.md)
- [Create a simple VB console app](./visual-basic/tutorial-console.md)
- [Create a C++ console app](/cpp/get-started/tutorial-console-cpp)
- [Create a Node.js and Express app](../javascript/tutorial-nodejs.md)

## Related content

To develop any type of app, or learn a language, you work in the feature rich Visual Studio Integrated Development Environment (IDE). Explore Visual Studio further with one of these introductory articles:

- [Tour the IDE](../ide/quickstart-ide-orientation.md) to get familiar with the IDE features and to learn how to use it for basic tasks.
- Cover the basics in this Learn module: [Introduction to Visual Studio](/training/modules/visual-studio-intro/)
