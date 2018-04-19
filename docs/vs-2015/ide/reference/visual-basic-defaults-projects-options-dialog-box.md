---
title: "Visual Basic Defaults, Projects, Options Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Projects.VBDefaults"
helpviewer_keywords: 
  - "Option Explicit statement, setting in the IDE"
  - "Option Compare statement, setting in the IDE"
  - "Option Strict statement, setting in the IDE"
ms.assetid: 2465cd9d-18b6-4c4a-b1ea-86dbab23fc79
caps.latest.revision: 23
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
---
# Visual Basic Defaults, Projects, Options Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [Visual Basic Defaults, Projects, Options Dialog Box](https://docs.microsoft.com/visualstudio/ide/reference/visual-basic-defaults-projects-options-dialog-box).  
  
  
Specifies the default settings for Visual Basic project options. When a new project is created, the specified option statements will be added to the project header in the Code Editor. The options apply to all Visual Basic projects.  
  
 To access this dialog box, on the **Tools** menu, click **Options**, expand the **Projects and Solutions** folder, and then click **VB Defaults**.  
  
 **Option Explicit**  
 Sets the compiler default so that explicit declarations of variables are required. By default, **Option Explicit** is set to **On**. For more information, see [/optionexplicit](../Topic/-optionexplicit.md).  
  
 **Option Strict**  
 Sets the compiler default so that explicit narrowing conversions are required and late binding is not allowed. By default, **Option Strict** is set to **Off**. For more information, see [/optionstrict](../Topic/-optionstrict.md).  
  
 **Option Compare**  
 Sets the compiler default for string comparisons: binary (case-sensitive) or text (case-insensitive.) By default, **Option Compare** is set to **Binary**. For more information, see [/optioncompare](../Topic/-optioncompare.md).  
  
 **Option Infer**  
 Sets the compiler default for local type inference. By default, **Option Infer** is set to **On** for newly created projects and to **Off** for migrated projects created in earlier versions of Visual Basic. For more information, see [/optioninfer](../Topic/-optioninfer.md).  
  
## See Also  
 [Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)



