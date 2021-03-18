---
title: Visual Studio with a codespace (Preview)
description: Learn about using Visual Studio IDE with GitHub Codespaces for Windows development.
ms.topic: how-to
ms.date: 09/21/2020
author: gregvanl
ms.author: gregvanl
manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# How to use Visual Studio with a codespace (Preview)

> [!Important] 
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We're focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. We encourage you to be involved in our [developer community forum](https://developercommunity.visualstudio.com/home) for Visual Studio for information on future previews and roadmap information. 

Visual Studio has great support for developing in GitHub Codespaces. You can create and connect to a codespace and have the full power of Visual Studio to work on your projects on a remote, hosted environment. Even though your source code and tools are in a codespace and your compilation and debugging is happening in the cloud, your development experience will feel as fast and friction-free as if you were working locally. You can work with a codespace from within Visual Studio 2019 Preview ([sign up for the limited public beta](https://github.com/features/codespaces/signup-vs)).

> [!NOTE]
> This article specifically describes using Visual Studio to connect to GitHub Codespaces. You can learn about connecting to a codespace with other clients in the [Visual Studio Code](https://docs.github.com/github/developing-online-with-codespaces/connecting-to-your-codespace-from-visual-studio-code) or [GitHub](https://docs.github.com/github/developing-online-with-codespaces/developing-in-a-codespace) documentation.

> [!NOTE]
> If you don't have [Visual Studio 2019 Preview](https://aka.ms/vspreview) installed already, you can download it from [visualstudio.microsoft.com](https://aka.ms/vspreview).

## Enable Connect to GitHub Codespaces

Connecting to GitHub Codespaces with the Visual Studio 2019 Preview is not enabled by default, so you will first need to enable the Preview Features option.

1. In Visual Studio 2019 Preview, use the **Tools** > **Options** menu item to open the Options dialog.

2. Under **Environment**, select **Preview Features** and check the **Connect to GitHub Codespaces** preview feature.

   ![Check the Connect to GitHub Codespaces preview feature](media/connect-to-github-codespaces-preview-feature.png)

3. You will need to restart Visual Studio for the feature to be available.

## Create a codespace

If you don't already have a codespace, you can create one from Visual Studio.

1. When you launch Visual Studio, the Start Window will show a **Connect to a codespace** button under "Get started".

   ![Visual Studio Start window with Connect to a codespace](media/visual-studio-start-window.png)

2. Select **Connect to a codespace** and you will be prompted to sign in to GitHub. You can also create a GitHub account, if you don't already have one.

   ![Visual Studio sign in to GitHub](media/visual-studio-sign-in-to-github.png)

   Once you select **Sign in to GitHub**, follow the online GitHub sign in workflow.

3. If you've never created a codespace, you will be prompted to create one.

   Under "Codespace details", you need to provide a **Repository URL**. GitHub Codespaces will clone the specified repository into your codespace when it is created.

   You can also modify the **Instance type** and **Suspend after** timeout via their dropdowns. Once you have set the codespace details, select the **Create and Connect** button.

   ![Visual Studio codespace details](media/visual-studio-codespace-details.png)

   GitHub Codespaces will begin preparing the codespace and open Visual Studio, once the codespace is ready.

   The codespace name will appear in the remote indicator in the menu bar.

   ![Visual Studio connected to eShopOnWeb repository codespace](media/visual-studio-eshoponweb-codespace.png)

4. Start using Visual Studio, just as you would working locally. Things to try:

   * Browse source code.
   * Select a solution file, and build the solution (**Ctrl+Shift+B**).
   * Set a breakpoint in a source file and press **F5** to launch the application in the debugger.
   * Make changes and commit them to your repository.   

> [!NOTE]
> At this time, you can not create GitHub Codespaces for Visual Studio through the GitHub [Codespaces portal](https://github.com/codespaces). You can only create them using Visual Studio.

## Connect to a codespace

After you've created your codespace, you can open your codespace directly from Visual Studio.

1. When you launch Visual Studio, the Start Window will show a **Connect to a Codespace** button under "Get started".

   ![Visual Studio Start window with Connect to a codespace](media/visual-studio-start-window.png)

   If you are already in Visual Studio, you can use the **File** > **Connect to a Codespace** menu item.

   ![Visual Studio File Connect to a codespace menu item](media/visual-studio-file-connect-to-codespace.png)

2. Select **Connect to a codespace**. You will be prompted to sign in to GitHub, if you haven't already.

3. You will then see all of your GitHub codespaces, along with their details presented in the right panel.

   ![Visual Studio displaying available GitHub codespaces and details](media/visual-studio-connect-codespace.png)

   Any codespaces that cloned an Azure DevOps repository will only be visible here in Visual Studio and not on GitHub's Codespaces page.

4. Choose a codespace and select the **Connect** button. If the codespace has been suspended, it will be restarted and Visual Studio will open connected to that codespace.

   The codespace name will appear in the remote indicator in the menu bar.

   ![Visual Studio connected to eShopOnWeb repository codespace](media/visual-studio-eshoponweb-codespace.png)

5. Start using Visual Studio, just as you would working locally. Things to try:

   * Browse source code.
   * Select a solution file, and build the solution (**Ctrl+Shift+B**).
   * Set a breakpoint in a source file and press **F5** to launch the application in the debugger.
   * Make changes and commit them to your repository.

<!-- TBD ## Suspend a codespace -->

<!-- TBD ## Disconnect from a codespace -->

## See also

* [What is GitHub Codespaces?](codespaces-overview.md)
* [How to customize a codespace](customize-codespaces.md)
* [Supported Visual Studio features](supported-features-codespaces.md)
