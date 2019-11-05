---
title: "How to: Run Code Analysis Manually for Managed Code"
ms.date: 11/04/2019
ms.topic: "conceptual"
helpviewer_keywords:
  - "code analysis, running"
  - "run code analysis"
ms.assetid: 5086d228-f92e-4515-9708-c5b89b9e9a03
author: mavasani
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Run Code Analysis Manually for Managed Code
By default, .NET Compiler Platform ("Roslyn") code analyzers analyze your C# or Visual Basic code as you type by performing live analysis, as well as during build. This is the default and recommended behavior for all installed analyzers. Normally, you would not require to manually trigger code analysis. However, there are couple of scenarios where you may want to manually trigger code analysis:

1. By default, live code analysis executes analyzers only for open files in Visual Studio. However, you may be interested in viewing code analysis warnings from analyzers for all files in a specific project or solution. If so, you can either trigger code analysis once on a project or a solution by following the steps below or enable continuous [full solution analysis](how-to-enable-and-disable-full-solution-analysis-for-managed-code.md#toggle-full-solution-analysis).
2. If you prefer the on-demand code analysis execution workflow, you can disable analyzer execution during live analysis and/or build and manually trigger code analysis once on a project or a solution in Visual Studio. For information about disabling analysis from these analyzers, see [How to disable source code analysis](disable-code-analysis.md).  

### To run code analysis manually (requires Visual Studio 2019 version 16.5 or later)

1. In **Solution Explorer**, click the project.

2. On the **Analyze** menu, click **Run Code Analysis on** *Project Name*.

Code analysis will start executing in the background and you should see the message **Running code analysis for \<project>...** in the Visual Studio status bar towards the bottom left corner. Once code analysis completes, the status message will change to **Code analysis completed for \<project>**. Error list will soon refresh with all code analysis diagnostics.
