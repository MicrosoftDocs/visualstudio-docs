---
title: "Step out of C# code when native frames are missing from the call stack | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords:
  - "Call Stack window, missing native frames"
  - "code, managed code"
  - "native frames"
  - "stepping, out of managed code"
  - "managed code, stepping out of"
ms.assetid: 97cdd2a8-02a9-4a06-a5b1-c92b1e431979
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "cplusplus"
  - "dotnet"
---
# How to: Step out of Managed Code when Native Frames are Missing from the Call Stack Window

If your code has native frames that are invisible in the **Call Stack** window, stepping out of managed code can produce unexpected results. As a workaround, you can use a breakpoint instead of **Step Out**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## Step out of managed code when native frames are missing from the call stack display

1. In the native code, set a location breakpoint after the call to managed code.

2. On the **Debug** menu, choose **Continue**.

     When the managed call is completed, execution will stop at the breakpoint in native code.

## See also

- [How to: Use the Call Stack Window](../debugger/how-to-use-the-call-stack-window.md)