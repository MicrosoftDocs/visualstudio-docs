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

## Creating a codespace

If you don't already have a GitHub codespace, you can create one from Visual Studio.

1. When you launch Visual Studio, the Start Window will show a **Connect to a codespace** button under "Get started".

   ![Visual Studio Start window with Connect to a codespace](media/visual-studio-start-window.png)

2. Select **Connect to a codespace** and you will be prompted to sign in to GitHub. You can also create a GitHub account, if you don't already have one.

   ![Visual Studio sign in to GitHub](media/visual-studio-sign-in-to-github.png)

   Once you select **Sign in to GitHub**, follow the online GitHub sign in workflow.

3. If you've never created a codespace, you will be prompted to create one.

   Under "Codespace details", you need to provide a **Repository URL**. GitHub Codespaces will clone the specified repository into your codespace when it is created.

   You can also modify the **Instance Type** and **Suspend after** timeout via their dropdowns. Once you have set the codespace details, select the **Create and Connect** button.

   ![Visual Studio codespace details](media/visual-studio-codespace-details.png)

   GitHub Codespaces will begin preparing the codespace and open Visual Studio, once the codespace is ready.

   The codespace name will appear in the remote indicator in the menu bar.

   ![Visual Studio connected to eShopOnWeb repository codespace](media/visual-studio-eshoponweb-codespace.png)

4. Start using Visual Studio, just as you would working locally. Things to try:

   - Browse source code.
   - Select a solution file, and build the solution (**Ctrl+Shift+B**).
   - Set a breakpoint in a source file and press **F5** to launch the application in the debugger.
   - Make changes and commit them to your repository.   

> [!NOTE]
> At this time, you can not create GitHub Codespaces for Visual Studio through the GitHub [Codespaces portal](https://github.com/codespaces). You can only create them using Visual Studio.

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

5. Start using Visual Studio, just as you would working locally. Things to try:

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

You should notice little difference editing source code in a codespace as you get smart language features like IntelliSense, code navigation, diagnostics, and suggestions.

* IntelliSense*
* Code navigation*
* Code formatting with Format Document
* Syntax highlighting
* Quick Info*
* HTML, CSS, razor editors* - Partial support.
* JavaScript editor*- Partial support.

Not yet available:

* IntelliSense* - not all filters are available. Completion for unimported types and intellisense in watch window not yet available.
* Code navigation* - Most commands supported, specifically Go To Base and Find in files with path specification not yet supported.
* Quick Info* - colorization in quick info is not supported.
* HTML, CSS, razor editors* - Diagnostics, intellisense completion, quick info, smart indent. Currently no support for semantic colorization, navigation commands, etc.
* JavaScript editor* - Script blocks (for example, JavaScript content in HTML files, CSHTML files, and similar) and semantic highlighting are not yet supported. Known issues with lightbulb features and linting.
* CodeLens
* Code snippets
* IntelliCode

### Application types and configuration

Most application types and project configurations are supported, but you will need to edit your project code directly without the help of visual designers. For more configuration guidance, see [customizing codespaces for windows-based development](customize-codespaces.md).

* Project and item templates
* .NET Core and ASP.NET Core projects
* C++ console apps - CMake and vcxproj supported
* C++ apps that target Linux - Mostly supported for non-GUI. Ability to install and provision WSL, platform-specific intellisense, and build.
* Project file editing - mostly supported. Missing some completion, syntax highlighting, and advanced editing features.
* GitHub accounts - Can be used to create and connect to Codespaces, and access resources available to the account on GitHub.
* Azure CLI - Does not share the signed-in Visual Studio identity or keychain accounts. Browser-based login is not supported but you can authenticate inside the integrated terminal using: `az login --use-device-code`.

Not yet available:

* UI designers - WinForms and WPF designers
* Visual Basic and F# projects
* .NET Framework targeted projects
* Docker Compose projects
* Project property pages
* Authentication options in ASP.NET Core templates
* Apps that require a GUI to install - Anything that can be installed with the terminal is supported (including the chocolatey installer), but the actual GUI won't be immediately available. Enabling full screen Live Share to access the GUIs is a current workaround. Administration consoles are not accessible. Apps that require a reboot to install aren't supported.
* Managed identities for Azure resources in Visual Studio
* Intranet resources (private network) - Currently, codespaces won't be able to connect to any resource that requires a VPN.
* Extensions - No extensions are supported when using Codespaces with Visual Studio.

### Debugging

Essential inner loop debugging workflow is supported including setting breakpoints, basic stepping into code, inspecting variables, and the local, autos, and watch windows. Some additional windows, customizations, and visualizers are not supported.

* Breakpoints*
* Basic stepping
* Locals, autos, watch windows* - Partial support.
* Symbol server, source server, and importing/exporting data tips are all partially supported.

Not yet available:

* Breakpoints* - Breakpoint labels, Data breakpoints, and Set breakpoint in Disassembly window is in progress. Importing and exporting breakpoints is partially supported.
* Locals, autos, watch windows*- some functionality such as statement completion in search box and search box navigation.
* UI customizations - Pinnable properties and hide template parameters not supported.
* Visualizers - C++ natvis partially supported. Dissassembly window, XAML Visual diagnostics, Custom .NET Visualizers, and Dataset Visualizers are not supported.
* Additional debugger windows - Processes windows partially supported. Parallel Stacks window - Tasks View, Diagnostics Hub, and Find source/symbol dialog are not supported.
* Some debugger workflows - Attach to process, Just in Time (JIT) debugger, Dump debugging, and IntelliTrace are not supported. C++ Just My Code stepping is partially supported.
* Edit and Continue - for both managed and native code is not supported.
* Threading features - Freeze/thaw threads, Rename thread, and show threads in source are not supported.
* Additional stepping features - Automatic Step over properties and operators (.NET Core) and Step into Specific are not supported. 

### Features

Since you are working with the Visual Studio client connected to a remote environment, you get the same accessibility features as when working locally.

* Source Control - Full Git support through the new [Git window](https://devblogs.microsoft.com/visualstudio/improved-git-experience-in-visual-studio-2019/).
* Accessibility - There is one known issue with assistive technology not being able to access the appcasting of a debugged app. Besides this, we don't believe there are any other compatibility issues that don't already exist in the local Visual Studio experience. Please let us know if you detect bugs by filing an issue on [developer community](https://developercommunity.visualstudio.com/).
* Publishing - Publish to Azure through GitHub Actions is supported.
* Connected services - App Insights, KeyVault, Storage, SQL, Redis, Cosmos, openAPI, and gRPC are partially supported.
* Test Explorer* - Mostly supported.

Not yet available:

* Test Explorer* - Some features such as default architecture selection, run tests in parallel, playlists, etc. Known issues with debugging a unit test, run settings, and some additional enterprise features. Profiling unit tests is not supported.
* NuGet Package Manager UI - NuGet command line is supported.
* Enterprise testing features - Live Unit Testing, Microsoft Fakes, Code coverage, and IntelliTest not supported.
* Advanced publishing scenarios - Selective publishing, FTP publishing, preview changes, quick publish tool bar, etc.
## See also

* [What is GitHub Codespaces?](codespaces-overview.md)
* [How to: Customize a codespace](customize-codespaces.md)
