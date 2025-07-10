---
title: Troubleshoot template discovery in Visual Studio
description: Learn how to enable diagnostic logging to troubleshoot deploying custom projects and templates in the Visual Studio SDK.
ms.date: 7/10/2025
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Troubleshooting template installation

If you run into problems deploying your project or item templates, you can enable diagnostic logging.

1. Create a pkgdef file in the *Common7\IDE\CommonExtensions* folder for your installation. For example, *C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\CommonExtensions\EnablePkgDefLogging.pkgdef*.

2. Add the following to the pkgdef file:

    ```
    [$RootKey$\VsTemplate]
    "EnableTemplateDiscoveryLog"=dword:00000001
    ```

3. Open a [Developer Command Prompt](../ide/reference/command-prompt-powershell.md) for your installation and run `devenv /updateConfiguration`.

4. Open Visual Studio and launch the **Create a new project** and **New Item** dialog boxes to initialize both template trees.

   The template log now appears in **%LOCALAPPDATA%\Microsoft\VisualStudio\16.0_[instanceid]\VsTemplateDiagnosticList.csv** (instanceid corresponds to the installation ID of your instance of Visual Studio). Each template tree initialization appends entries to this log.

The log file contains the following columns:

- **FullPathToTemplate**, which has the following values:

  - 1 for manifest-based deployment

  - 0 for disk-based deployment

- **TemplateFileName**

- Other template properties

> [!NOTE]
> To disable logging, either remove the pkgdef file, or change the value of `EnableTemplateDiscoveryLog` to `dword:00000000`, and then run `devenv /updateConfiguration` again.

## Related content

- [Creating custom project and item templates](creating-custom-project-and-item-templates.md)
- [Visual Studio troubleshooting](/troubleshoot/visualstudio/welcome-visual-studio/)
