---
title: How to run code analysis manually for managed code
ms.date: 11/04/2019
ms.topic: how-to
helpviewer_keywords: 
  - code analysis, running
  - run code analysis
ms.assetid: 5086d228-f92e-4515-9708-c5b89b9e9a03
author: mavasani
ms.author: mikejo
manager: jillfra
ms.workload: 
  - dotnet
---
# How to: Run code analysis manually for managed code (requires Visual Studio 2019 version 16.5 or later)
By default, .NET Compiler Platform ("Roslyn") code analyzers analyze your C# or Visual Basic code as you type by doing live analysis, as well as during build. Hence, you would normally not require to manually trigger code analysis. However, there are some scenarios where you may want to manually trigger code analysis:

- By default, live code analysis executes analyzers only for open files in Visual Studio. However, you may be interested in viewing code analysis warnings for all files in a specific project or solution. If so, you would want to trigger code analysis once on a project or a solution. Alternatively, you can enable continuous live code analysis to execute on entire solution. For more information, see [How to: Configure live code analysis scope for managed code](./configure-live-code-analysis-scope-managed-code.md).
- You may prefer on-demand code analysis execution workflow over continuous live analysis or build-time analysis. If so, you can disable analyzer execution during live analysis and/or build. For information about disabling analysis, see [How to disable source code analysis](disable-code-analysis.md). Then you would want to manually trigger code analysis once on a project or a solution. 

### Run code analysis manually

1. In **Solution Explorer**, click the project.

2. On the **Analyze** menu, click **Run Code Analysis on** *Project Name*.

Code analysis will start executing in the background. You should see the message **Running code analysis for \<project>...** in the Visual Studio status bar towards the bottom-left corner. Once code analysis completes, the status message will change to **Code analysis completed for \<project>**. Error list will soon refresh with all code analysis diagnostics.
