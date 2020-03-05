---
title: "How to: Suppress Warnings by Using the Menu Item | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "warnings, suppressing"
  - "code analysis, suppressing warnings"
ms.assetid: 36bd1850-dcde-4ed0-9bc3-0b83df434362
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Suppress Warnings by Using the Menu Item
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

NOTE]
> In source suppression is not supported for web site projects.

 You can use the Code Analysis window to suppress code analysis warnings. Suppressing a warning is not the same as disabling it. When you suppress a warning, it applies only to a particular instance of the violation. Other violations of the same warning will still be reported in the Error List window.

 After you run code analysis, you might determine that one or more of the code analysis warnings that are displayed in the Code Analysis window are not applicable to your application. For example, you might determine that the code is correct as is. Or, it might be the case that some violations are low priority and will not be fixed in the current development cycle. Regardless of the reason, it’s frequently useful to indicate that the warning is non-applicable to let your team members know that the code was reviewed and that it was determined that the warning could be suppressed. In source suppression is useful because it lets you put a suppression close to where the warning is generated.

 You can choose whether the suppression will appear in the source code or in the global suppression file. Some suppressions must be placed in the global suppression file. If this is the case, the **In Source** option will be disabled.

### To suppress a warning by using menu item

1. On the **Analyze** menu, choose **Windows** and then choose **Code Analysis**.

2. In the **Code Analysis** window, select the warning suppress.

3. Choose Actions, then choose **Suppress Message(s)**, and then choose either **In Source** or **In Project Suppression File**.

     The specific warning is suppressed, and the warning appears in the Code Analysis window with a strikethrough.

> [!NOTE]
> Suppressions that do not have a target appear in the global suppression file.
