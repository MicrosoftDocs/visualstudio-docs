---
title: "How to: Disable the Hosting Process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "hosting process, disabling"
  - "vshost.exe, disabling the hosting process"
ms.assetid: 9157488d-737f-454b-8d8d-36f99de38bb0
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Disable the Hosting Process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Calls to certain APIs can be affected when the hosting process is enabled. In these cases, it is necessary to disable the hosting process to return the correct results.

### To disable the hosting process

1. Open an executable project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Projects that do not produce executables (for example, class library or service projects) do not have this option.

2. On the **Project** menu, click **Properties**.

3. Click the **Debug** tab.

4. Clear the **Enable the Visual Studio hosting process** check box.

   When the hosting process is disabled, several debugging features are unavailable or experience decreased performance. For more information, see [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md).

   In general, when the hosting process is disabled:

- The time needed to begin debugging [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] applications increases.

- Design-time expression evaluation is unavailable.

- Partial trust debugging is unavailable.

## See Also
 [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md)
 [Hosting Process (vshost.exe)](../ide/hosting-process-vshost-exe.md)
 [Builds During Application Development](https://msdn.microsoft.com/c9497d62-3b7b-4449-88e8-cf27acc9efe6)
