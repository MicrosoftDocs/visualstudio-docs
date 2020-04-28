---
title: "Debugging Mixed-Mode Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], mixed-mode"
  - "mixed-mode debugging, property evaluation"
  - "Call Stack window"
  - "mixed-mode debugging"
  - "Call Stack window, mixed-mode debugging"
  - "debugging managed code, mixed code"
  - "mixed-mode debugging, call stack"
ms.assetid: 60e34477-ae4e-48c7-9093-3e37f72e1bc3
caps.latest.revision: 22
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging Mixed-Mode Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A mixed-mode application is any application that combines native code (C++) with managed code (such as Visual Basic, Visual C#, or C++ that runs on the common language runtime). Debugging mixed-mode applications is largely transparent in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]; it is not too different from debugging a single-mode application. There are a few special considerations, however.  
  
## Enable C++ Edit and Continue in Mixed Mode Debugging  
  
- To use Edit and Continue for C++ in Visual Studio 2013, you have to revert to the legacy debugging engine. See [Switching to Managed Compatibility Mode in Visual Studio 2013](https://devblogs.microsoft.com/devops/switching-to-managed-compatibility-mode-in-visual-studio-2013/) on the  Microsoft Application Lifecycle Management blog.  
  
## Property Evaluation in Mixed-Mode Applications  
 In a mixed-mode application, the evaluation of properties by the debugger is an expensive operation. As a result, debugging operations such as stepping might appear slow. For more information, see [Stepping](https://msdn.microsoft.com/8791dac9-64d1-4bb9-b59e-8d59af1833f9). If you experience poor performance in mixed-mode debugging, you might want to turn off property evaluation in the debugger windows.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
#### To turn off property evaluation  
  
1. On the **Tools** menu, choose **Options**.  
  
2. In the **Options** dialog box, open the **Debugging** folder and select the **General** category.  
  
3. Clear the **Enable property evaluation and other implicit function calls** check box.  
  
   Because native call stacks and managed call stacks differ, the debugger cannot always provide the complete call stack for mixed code. When native code calls managed code, you may notice some discrepancies. For more information, see [Mixed Code and Missing Information in the Call Stack Window](../debugger/mixed-code-and-missing-information-in-the-call-stack-window.md).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)
