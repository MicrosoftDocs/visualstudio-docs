---
title: XAML Errors and Warnings
description: Learn about XAML errors and warnings in Visual Studio, including how errors are categorized, how to get error information, and how to find options for fixing them.
ms.custom: SEO-VS-2020
ms.date: 03/06/2018
ms.topic: error-reference
ms.assetid: 34eac8a0-7ec5-4c40-b97a-0126ed367931
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xaml-tools
ms.workload:
  - "multiple"
---
# XAML errors and warnings

When authoring XAML, Visual Studio analyzes the code as you type. A squiggle appears on a line of code when an error is detected. Hovering over the squiggle gives you more information about the error or warning. For some errors and warnings, a Quick Action lightbulb is displayed, and using the **Ctrl**+**.** keyboard shortcut displays the options to fix the issue.

## Error types

Behind the scenes, multiple tools analyze the XAML in parallel. XAML errors are categorized into one of the following three types, based on the tool that detected the error:

|**Error detected by**|**Error code format**|**Visual Studio Version**|
| - |-----------------| - |
|XAML Language Service (XAML editor)|XLSxxxx| All Versions |
|XAML Designer|XDGxxxx| All Versions | 
|XAML Edit & Continue|XECxxxx| Visual Studio 2019 version 16.1 or earlier |
|XAML Hot Reload | XHRxxxx | Visual Studio 2019 version 16.2 or later |

For more details on the rebranding of XAML Edit & Continue as XAML Hot Reload, see our [release notes](/visualstudio/releases/2019/release-notes-v16.2#wpfuwp-tooling)

> [!Note]
> Not all errors or warnings have a corresponding code. Such errors are usually XAML Designer errors.

## Suppress XAML Designer errors

Open the **Options** dialog by selecting **Tools > Options**, and then select **Text Editor > XAML > Miscellaneous**.

Uncheck the **Show errors detected by the XAML designer** check box.

![Suppress XAML Designer errors](media/suppress_xaml_designer_errors.png)