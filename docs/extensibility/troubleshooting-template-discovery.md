---
title: Troubleshoot template discovery in Visual Studio | Microsoft Docs
description: Learn how to enable diagnostic logging to troubleshoot deploying custom projects and templates in the Visual Studio SDK.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: troubleshooting
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Troubleshooting template installation

If you run into problems deploying your project or item templates, you can enable diagnostic logging.

::: moniker range="vs-2017"

1. Create a pkgdef file in the *Common7\IDE\CommonExtensions* folder for your installation. For example, *C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\EnablePkgDefLogging.pkgdef*.

::: moniker-end

::: moniker range=">=vs-2019"

1. Create a pkgdef file in the *Common7\IDE\CommonExtensions* folder for your installation. For example, *C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\CommonExtensions\EnablePkgDefLogging.pkgdef*.

::: moniker-end

2. Add the following to the pkgdef file:

    ```
    [$RootKey$\VsTemplate]
    "EnableTemplateDiscoveryLog"=dword:00000001
    ```

3. Open a [Developer Command Prompt](../ide/reference/command-prompt-powershell.md) for your installation and run `devenv /updateConfiguration`.

::: moniker range="vs-2017"

4. Open Visual Studio and launch the New Project and New Item dialog boxes to initialize both template trees.

   The template log now appears in **%LOCALAPPDATA%\Microsoft\VisualStudio\15.0_[instanceid]\VsTemplateDiagnosticsList.csv** (instanceid corresponds to the installation ID of your instance of Visual Studio). Each template tree initialization appends entries to this log.

::: moniker-end

::: moniker range=">=vs-2019"

4. Open Visual Studio and launch the **Create a new project** and **New Item** dialog boxes to initialize both template trees.

   The template log now appears in **%LOCALAPPDATA%\Microsoft\VisualStudio\16.0_[instanceid]\VsTemplateDiagnosticsList.csv** (instanceid corresponds to the installation ID of your instance of Visual Studio). Each template tree initialization appends entries to this log.

::: moniker-end

The log file contains the following columns:

- **FullPathToTemplate**, which has the following values:

  - 1 for manifest-based deployment

  - 0 for disk-based deployment

- **TemplateFileName**

- Other template properties

> [!NOTE]
> To disable logging, either remove the pkgdef file, or change the value of `EnableTemplateDiscoveryLog` to `dword:00000000`, and then run `devenv /updateConfiguration` again.

## See also

- [Creating custom project and item templates](creating-custom-project-and-item-templates.md)
- [Visual Studio troubleshooting](/troubleshoot/visualstudio/welcome-visual-studio/)
