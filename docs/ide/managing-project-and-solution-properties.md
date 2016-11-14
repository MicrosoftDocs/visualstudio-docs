---
title: "Managing Project and Solution Properties | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d727efc0-1096-4ede-84b6-31a65da22ac0
caps.latest.revision: 6
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
# Managing Project and Solution Properties
Projects have properties that govern many aspects of compilation, debugging, testing and deploying. Some properties are common among all project types, and some are unique to specific languages or platforms. You access project properties by right-clicking the project node in Solution Explorer and choosing Properties, or by typing properties into the **QuickLaunch** search box in the menu bar.  
  
 ![Project context menu](../ide/media/vs2015_proj_prop_menu.gif "vs2015_proj_prop_menu")  
  
 .NET projects also have a properties node in the project tree itself.  
  
 ![Properties node in Solution Explorer tree](../ide/media/vs2015_props_se.png "VS2015_Props_SE")  
  
> [!TIP]
>  Solutions have a few properties, and so do project items; these properties are accessed in the [Properties Window](../ide/reference/properties-window.md), not **Project Designer**.  
  
## Project Properties  
 Project Properties are organized into groups and each group has its own property page, and the pages might be different for different languages and project types.  
  
### C# and Visual Basic projects  
 In C# and Visual Basic projects, properties are exposed in the **Project Designer**. The following illustration shows the Build property page for a WPF project in C#:  
  
 ![Visual Studio Project Designer](../ide/media/vs2015_proppage_build.png "VS2015_PropPage_Build")  
  
 For information about each of the property pages in Project Designer, see [Project Properties Reference](../ide/reference/project-properties-reference.md).  
  
### C++ and JavaScript projects  
 C++ and JavaScript projects have a different user interface for managing project properties. This illustration shows a C++ project property page (JavaScript pages are similar):  
  
 ![Visual C&#43;&#43; project properties](../ide/media/vs2015_projprops_cpp.png "VS2015_ProjProps_cpp")  
  
 For information about C++ project properties, see [Working with Project Properties](/visual-cpp/ide/working-with-project-properties). For more information about JavaScript properties, see [Property Pages, JavaScript](../ide/reference/property-pages-javascript.md).  
  
## Solution Properties  
 To access properties on the solution, right click the solution node in **Solution Explorer** and choose **Properties**. In the dialog, you can set project configurations for Debug or Release builds, choose which projects(s) should be the startup project when F5 is pressed, and set code analysis options.  
  
## See Also  
 [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md)