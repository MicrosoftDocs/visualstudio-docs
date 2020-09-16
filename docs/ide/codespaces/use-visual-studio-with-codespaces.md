---
title: Visual Studio with a codespace (Preview)
description: Learn about using Visual Studio IDE with GitHub Codespaces for Visual Studio.
ms.topic: how-to
ms.date: 09/21/2020
author: gregvanl
ms.author: gregvanl
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# How to use Visual Studio with a codespace (Preview)

Visual Studio has great support for developing in GitHub Codespaces for Visual Studio. You can create and connect to a codespace and have the full power of Visual Studio to work on your projects on a remote, hosted environment. Even though your source code and tools are in a codespace and your compilation and debugging is happening in the cloud, your development experience will feel as fast and friction-free as if you were working locally.

> [!NOTE]
> This article specifically describe using Visual Studio when connected to GitHub Codespaces for Visual Studio. You can learn about connecting with other clients to a codespace in the [Visual Studio Code](https://docs.github.com/github/developing-online-with-codespaces/connecting-to-your-codespace-from-visual-studio-code) or [in-browser editor](https://docs.github.com/en/github/developing-online-with-codespaces/developing-in-a-codespace) documentation.

> [!NOTE]
> If you don't have [Visual Studio 2019 Preview](https://aka.ms/vspreview) installed already, you can [download it from visualstudio.microsoft.com](https://aka.ms/vspreview).

## Creating a GitHub Codespaces for Visual Studio codespace

If you don't already have a GitHub codespace, you can create one from Visual Studio.

1. When you launch Visual Studio, the Start Window will show a **Connect to a codespace** button under "Get started".

   ![Visual Studio Start window with Connect to a codespace](media/visual-studio-start-window.png)

2. Select **Connect to a codespace** and you will be prompted to sign in to GitHub. You can also create a GitHub account, if you don't already have one.

   ![Visual Studio sign in to GitHub](media/visual-studio-sign-in-to-github.png)

   Once you select **Sign in to GitHub**, follow the online GitHub sign in workflow.

3. If you've never created a codespace, you will be prompted to create one.

   Under "Codespace details", you need to provide a **Repository URL**, which can be any valid GitHub or Azure DevOps repository URL. GitHub Codespaces will clone the specified repository into your codespace when it is created.

   You can also modify the **Instance Type** and **Suspend after** timeout via their dropdowns. Once you have set the codespace details, select the **Create and Connect** button.

   ![Visual Studio codespace details](media/visual-studio-codespace-details.png)

   GitHub Codespaces will begin preparing the codespace and open Visual Studio, once the codespace is ready.

   The codespace name will appear in the remote indicator in the menu bar.

   ![Visual Studio connected to eShopOnWeb repository codespace](media/visual-studio-eshoponweb-codespace.png)

4. Start using your codespace, just as you would working locally. Things to try:

   - Browse source code.
   - Select a solution file, and build the solution (**Ctrl+Shift+B**).
   - Set a breakpoint in a source file and press **F5** to launch the application in the debugger.
   - Make changes and commit them to your repository.   

<!-- TBD ### Create from github.com portal -->

## Connecting to a codespace

After you've created your codespace, you can open your codespace directly from Visual Studio.

1. When you launch Visual Studio, the Start Window will show a **Connect to a codespace** button under "Get started".

   ![Visual Studio Start window with Connect to a codespace](media/visual-studio-start-window.png)

   If you are already in Visual Studio, you can use the **File** > **Connect to a Codespace** menu item.

   ![Visual Studio File Connect to a codespace menu item](media/visual-studio-file-connect-to-codespace.png)

2. Select **Connect to a codespace**. You will be prompted to sign in to GitHub, if you haven't already.

3. You will then see all of your GitHub codespaces, along with their details presented in the right panel.

   ![Visual Studio displaying available GitHub codespaces and details](media/visual-studio-connect-codespace.png)

   Any codespaces cloning an Azure DevOps repository will only be visible here in Visual Studio and not on GitHub's Codespaces page.

4. Choose a codespace and select the **Connect** button. If the codespace has been suspended, it will be restarted and Visual Studio will open connected to that codespace.

   The codespace name will appear in the remote indicator in the menu bar.

   ![Visual Studio connected to eShopOnWeb repository codespace](media/visual-studio-eshoponweb-codespace.png)

5. Start using your codespace, just as you would working locally. Things to try:

   - Browse source code.
   - Select a solution file, and build the solution (**Ctrl+Shift+B**).
   - Set a breakpoint in a source file and press **F5** to launch the application in the debugger.
   - Make changes and commit them to your repository.

<!-- TBD ## Suspend a codespace -->

<!-- TBD ## Disconnect from a codespace -->

## Visual Studio features

Visual Studio provides a rich development experience when connecting to a codespace. You get the Visual Studio inner-loop tools you're familiar with to edit, debug, test, and version your source code as well as productivity features like project templates, rich code navigation, and IntelliSense. In the current GitHub Codespaces beta, some Visual Studio features may not have full support or may be initially missing. The following sections outline what you can expect with Visual Studio and the GitHub Codespaces beta and what you can look forward to in the future. This is **not meant to be an exhaustive list**, but to explain Visual Studio's general capabilities when connected to codespace.

> [!NOTE]
> If there is a feature you are missing while using codespaces with Visual Studio, please let us know by opening an issue on https://developercommunity.visualstudio.com/. This helps us prioritize the most wanted features.

> [!NOTE]
> The features described below are for Visual Studio and not the two other GitHub Codespaces clients, Visual Studio Code and the in-browser editor.

### Edit and navigation

You should notice little difference editing source code in a codespace as you get smart language features like IntelliSense, code navigation, and diagnostics and suggestions.

* Syntax highlighting and IntelliSense
* Code navigation
* Code formatting
* IntelliCode
* Test Explorer

Not yet available:

* CodeLens
* Code snippets

### Application types

Most application types and project configurations are supported but you will need to edit your project code directly without the help of visual designers.

* Project and item templates
* Project property pages
* Project file editing
* .NET Core and ASP.NET Core projects

Not yet available:

* UI designers - WinForms and WPF designers
* Visual Basic and F# projects
* .NET Framework targeted projects
* Docker Compose projects

### Debugging

Essential inner loop debugging workflow is supported including setting breakpoints, basic stepping into code, inspecting variables, and the local, autos, and watch windows. Some additional windows, customizations, and visualizers are not supported.

* Breakpoints
* Basic stepping - Automatic Step Over not yet supported
* Locals, autos, watch windows

Not yet available:

* UI customizations - Pinnable properties, Hide template parameters not supported
* Visualizers - C++ natvis partially supported
* Attach to process, JIT and dump debugging
* Edit and Continue
* Threading features - Freeze/thaw threads, Rename thread

### Features

Since you are working with the Visual Studio client connected to a remote environment, you get the same accessibility features as when working locally. Given the engineering required to connect to GitHub Codespaces, installing third-party extensions is not supported.

* Source Control - Full Git support through the Git window
* Accessibility - Same assisted technology compatibility as with local development
* Connected services - App Insights, KeyVault, Storage, SQL, Redis Cosmos, openAPI, gRPC

Not yet available:

* NuGet Package Manager UI - NuGet command line is supported.
* Live Unit Testing - support in progress.
* Microsoft Fakes, Code coverage, and IntelliTest
* Publishing - Publish to Azure through Git Actions is supported.
* Third-party Visual Studio extensions

<!-- TBD ### Specific limitations - do we need to include any specific limitations or workaround? -->

## See also

* [What is GitHub Codespaces?](codespaces-overview.md)
* [How to: Customize a codespace](customize-codespaces.md)
