---
title: "-ResetAddin (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "disable addin"
  - "addin state"
  - "reset addin"
ms.assetid: 9e339c8d-d768-4d86-8f45-2f479fc8255b
caps.latest.revision: 5
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# /ResetAddin (devenv.exe)
Removes commands and command UI associated with the specified Add-in.  
  
## Syntax  
  
```  
Devenv /ResetAddin AddIn  
```  
  
## Arguments  
 `AddIn`  
 Optional. The command name of the Add-in.  
  
## Remarks  
 By default, the command name of the add-in is equal to *\<AddInSolutionName>*.Connect*.\<AddInSolutionName>*, and appears in Connect.cs as the `commandName` parameter of the `Exec` method. You can also verify the command name by starting to type the name of the add-in into the Commands window in Visual Studio, and using Intellisense to fill in the rest.  
  
## Example  
 The following example starts Visual Studio and prevents the `MyAddin` add-in from running at startup.  
  
```  
Devenv.exe /ResetAddin MyAddin.Connect.MyAddin  
```  
  
## See Also  
 [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)   
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)