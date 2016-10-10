---
title: "Licenses processor error-warning: &lt;reason&gt;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: Licenses processor error/warning: &lt;reason&gt;
ms.assetid: 85750198-7bd3-4936-b1eb-954dcc3ff573
caps.latest.revision: 7
manager: douge
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
# Licenses processor error-warning: &lt;reason&gt;
An error or warning message is displayed if a tool returns an error or a warning while processing a .licx file. As part of the build process, the project system transforms the Licenses.licx file (if present) into a binary file understood by the .NET Framework license manager. This transformation is done using in-process tools.  
  
 The most likely cause of such an error or warning is a bad .licx file. A .licx file can become corrupt if the file has been edited outside of Visual Studio or within Visual Studio using a text editor.  
  
 These files are normally managed by the Windows Forms and Web Forms Designers.  
  
### To correct this error  
  
1.  Fix the format of the .licx file.  
  
     An error means that the binary file has not been generated, and that the build process will fail. Warnings are for informational purposes only.  
  
## See Also  
 [File Types and File Extensions in Visual Basic and Visual C#](assetId:///f793852c-da06-4d52-a826-65f635844772)