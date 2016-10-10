---
title: "-Edit (devenv.exe)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /Edit (devenv.exe)
ms.assetid: 02b3d6e7-a2b1-4d83-a747-aa8c2fb758b7
caps.latest.revision: 6
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# -Edit (devenv.exe)
Opens the specified file in an existing instance of Visual Studio.  
  
## Syntax  
  
```  
Devenv /edit [file1[ file2]]  
```  
  
## Arguments  
 `file1`  
 Optional. The file to open in an existing instance of Visual Studio. If no instance of Visual Studio exists, a new instance is created with a simplified window layout, and `file1` is opened in the new instance.  
  
 `file2`  
 Optional. One or more additional files to open in the existing instance of Visual Studio.  
  
## Remarks  
 If no file is specified and there is an existing instance of Visual Studio, the existing instance of Visual Studio receives focus. If no file is specified and there is no existing instance of Visual Studio, a new instance of Visual Studio is created with a simplified window layout.  
  
 If the existing instance of Visual Studio is in a modal state, for example, if the [Options dialog box](../VS_IDE/Options-Dialog-Box--Visual-Studio-.md) is open, the file will open in the existing instance when Visual Studio exits the modal state.  
  
## Example  
 This example opens the file `MyFile.cs` in an existing instance of Visual Studio or opens the file in a new instance of Visual Studio if one does not already exist.  
  
```  
devenv /edit MyFile.cs  
```  
  
## See Also  
 [Devenv Command Line Switches](../VS_IDE/Devenv-Command-Line-Switches.md)