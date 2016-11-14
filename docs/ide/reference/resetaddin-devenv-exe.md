---
title: "-ResetAddin (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
 [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3)   
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)