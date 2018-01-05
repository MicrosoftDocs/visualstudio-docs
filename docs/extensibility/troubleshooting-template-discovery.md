---
title: "Troubleshoot template discovery in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-sdk
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Troubleshooting template installation

If you run into problems deploying your project or item templates, you can enable diagnostic logging.

1. Create a pkgdef file in the Common7\IDE\CommonExtensions folder for your installation (e.g. C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\EnablePkgDefLogging.pkgdef) with the following contents:

    ```
    [$RootKey$\VsTemplate]
    "EnableTemplateDiscoveryLog"=dword:00000001
    ```

1. Open a "Developer Command Prompt" for your installation by searching for it in Windows search, and run `devenv /updateConfiguration`.

1. Start Visual Studio and launch the New Project and New Item dialogs to initialize both template trees. The template log now appears in **%LOCALAPPDATA%\Microsoft\VisualStudio\15.0_[instanceid]\VsTemplateDiagnosticsList.csv** (instanceid corresponds to the installation ID of your instance of Visual Studio). Each template tree initialization appends entries to this log.

The log file contains the following columns:

- **FullPathToTemplate**, which has the following values:

    - 1 for manifest-based deployment

    - 0 for disk-based deployment

- **TemplateFileName**

- Other template properties

> [!NOTE]
> To disable logging, either remove the pkgdef file, or change the value of `EnableTemplateDiscoveryLog` to `dword:00000000`, and then run `devenv /updateConfiguration` again.

## See also

[Creating custom project and item templates](creating-custom-project-and-item-templates.md)