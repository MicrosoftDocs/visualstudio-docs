---
title: "How to: Substitute Parameters in a Template | Microsoft Docs"
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
  - "template parameters, substituting"
  - "Visual Studio templates, using parameters"
ms.assetid: a62924a7-4ba0-413d-b606-fdbe1fcf2807
caps.latest.revision: 14
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
# How to: Substitute Parameters in a Template
You may replace template parameters such as class names and namespaces when a file based on a template is created. For a complete list of template parameters, see [Template Parameters](../ide/template-parameters.md).  
  
## Procedure  
 You may replace parameters in the files of a template whenever a project based on that template is created. This procedure explains how to create a template that replaces the name of a namespace with the safe project name when a new project is created with the template.  
  
#### To use a parameter to replace namespace name with the project name  
  
1.  Insert the parameter in one or more of the code files in the template. For example:  
  
    ```  
    namespace $safeprojectname$  
    ```  
  
    > [!NOTE]
    >  Template parameters are written in the format $*parameter*$.  
  
2.  In the .vstemplate file for the template, locate the `ProjectItem` element that includes this file.  
  
3.  Set the `ReplaceParameters` attribute to `true` for the `ProjectItem` element. For example:  
  
    ```  
    <ProjectItem ReplaceParameters="true">Class1.cs</ProjectItem>  
    ```  
  
## See Also  
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
 [Template Parameters](../ide/template-parameters.md)   
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [ProjectItem Element (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)