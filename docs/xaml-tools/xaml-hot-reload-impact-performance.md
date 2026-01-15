---
title: "XAML Hot Reload impact on performance diagnostics"
description: "XAML Hot Reload and its impact on performance diagnostics"
ms.date: 11/26/2025
ms.topic: article
helpviewer_keywords:
  - "xaml hot reload"
  - "performance profiling"
author: evgenyt
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
monikerRange: ">=vs-2022"
---
# XAML Hot Reload and its impact on performance diagnostic in Visual Studio

When you're investigating an application's performance, in other words, its CPU usage and memory consumption, we recommend that you disable [XAML Hot Reload](xaml-hot-reload.md).

:::moniker range="visualstudio"

Open the **Tools** > **Options** pane, expand the **All Settings** > **Debugging** > **XAML Hot Reload** section, and clear the **Enable XAML Hot Reload** checkbox.

:::moniker-end
:::moniker range="<=vs-2022"

Open the **Tools** > **Options** dialog and expand the **Debugging** > **XAML Hot Reload** section. Clear the **Enable XAML Hot Reload** checkbox, and then select **OK**.

:::moniker-end

XAML Hot Reload requires executing special code in a running application to collect more data. It's likely to execute user code and platform code that wouldn't have been executed otherwise. For example, WPF Hot Reload requires the use of the [VisualDiagnostics API](/dotnet/api/system.windows.diagnostics.visualdiagnostics.getxamlsourceinfo) to find info about an element's location in source *.xaml files. All of this extra code execution can affect collected performance data.

## Support options

Here are support resources that you might find useful:

- Ask a question or find an answer on the [Microsoft Q&A](/answers/tags/176/vs) page for Visual Studio.
- Report product issues to the engineering team via the [Report a problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
- Track product issues and engineering team responses in the [Visual Studio Developer Community](https://aka.ms/feedback/suggest?space=8).
