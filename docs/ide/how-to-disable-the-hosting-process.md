---
title: "How to: Disable the hosting process"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "hosting process, disabling"
  - "vshost.exe, disabling the hosting process"
ms.assetid: 9157488d-737f-454b-8d8d-36f99de38bb0
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Disable the hosting process

Calls to certain APIs can be affected when the hosting process is enabled. In these cases, it is necessary to disable the hosting process to return the correct results.

## To disable the hosting process

1.  Open an executable project in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Projects that do not produce executables (for example, class library or service projects) do not have this option.

2.  On the **Project** menu, click **Properties**.

3.  Click the **Debug** tab.

4.  Clear the **Enable the Visual Studio hosting process** check box.

 When the hosting process is disabled, several debugging features are unavailable or experience decreased performance. For more information, see [Debug and the hosting process](../debugger/debugging-and-the-hosting-process.md).

 In general, when the hosting process is disabled:

-   The time needed to begin debugging [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] applications increases.

-   Design-time expression evaluation is unavailable.

-   Partial trust debugging is unavailable.

## See also

- [Debug and the hosting process](../debugger/debugging-and-the-hosting-process.md)
- [Hosting process (vshost.exe)](../ide/hosting-process-vshost-exe.md)