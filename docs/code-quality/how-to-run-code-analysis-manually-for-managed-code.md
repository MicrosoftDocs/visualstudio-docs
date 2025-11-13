---
title: Run code analysis manually for .NET
description: Learn how to manually run code analysis in Visual Studio with Roslyn analyzers on C# and Visual Basic code.
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: code-analysis
ms.topic: how-to
helpviewer_keywords:
  - code analysis, running
  - run code analysis
ms.date: 03/25/2024
---

# Run code analysis manually for .NET

By default, .NET Compiler Platform (Roslyn) analyzers automatically analyze C# or Visual Basic code during a build and as you type (via live code analysis). Hence, you don't normally need to trigger code analysis manually. However, there are some scenarios where you might want to manually trigger code analysis:

- You want to view code analysis warnings for all files in a specific project or solution. By default, live code analysis executes analyzers only for the active document. However, you can opt to trigger code analysis once on the entire project or solution. Alternatively, you can enable continuous live code analysis to execute on the entire solution. For more information, see [Configure live code analysis for .NET](./configure-live-code-analysis-scope-managed-code.md).
- You prefer on-demand code analysis execution workflow over continuous live analysis or build-time analysis. If so, you can disable analyzer execution during live analysis and a build. Then you can manually trigger code analysis once on a project or solution. For information about disabling analysis, see [Disable source code analysis for .NET](disable-code-analysis.md).

> [!NOTE]
> Running code analysis manually requires Visual Studio 2019 version 16.5 or later.

## Run code analysis manually

To manually run a code analysis, follow these steps:

1. In **Solution Explorer**, select the project.

2. From the **Analyze** menu, select **Run Code Analysis** > **Run Code Analysis on [Project Name]**.

3. Alternatively, to run code analysis on the entire solution, select **Analyze** > **Run Code Analysis** > **On Solution**.

   Code analysis starts executing in the background. The message **Running code analysis for '\<project>'** appears in the Visual Studio status bar toward the bottom-left corner. After code analysis completes, the status message changes to **Code analysis completed for '\<project>'**. The error list refreshes with all the code analysis diagnostics.

## Related content

- [Disable source code analysis for .NET](disable-code-analysis.md)
- [Enable and disable binary code analysis for managed code](/previous-versions/visualstudio/visual-studio-2019/code-quality/how-to-enable-and-disable-automatic-code-analysis-for-managed-code)
