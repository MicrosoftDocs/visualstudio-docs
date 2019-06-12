---
title: "Resolve Ambiguity Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.Disambig"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Resolve Ambiguity dialog box"
  - "debugger, Resolve Ambiguity dialog box"
  - "debugging [C++], resolving ambiguity"
ms.assetid: d9f47455-a116-4c84-8bad-2dfbf4d77f74
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Resolve Ambiguity Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `Resolve Ambiguity` dialog box appears when the debugger cannot choose the location to display. For example, if you are using C++ templates, you can create multiple functions from a single function template. If the debugger stops at a source location in the template, and you choose `Go To Disassembly`, the debugger has multiple options. Each function created from the template has its own disassembly code, and the debugger does not know which code you want to view. The `Resolve Ambiguity` dialog box enables you to select the location you want from a list of all corresponding locations.  
  
 `Choose the specific location`  
 Lists all the locations corresponding to your command.  
  
 `Address`  
 Shows the memory addresses for each function.  
  
 `Function`  
 Shows the name of each function.  
  
 `Module`  
 Shows the module (EXE or DLL) containing the object code for the function.  
  
## See Also  
 [Expressions in the Debugger](../debugger/expressions-in-the-debugger.md)
