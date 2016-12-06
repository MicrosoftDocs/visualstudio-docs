---
title: "Extend dependency diagrams | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "dependency diagrams, creating extensions"
  - "layer models"
ms.assetid: 83fca301-b008-485a-87eb-218050e71451
caps.latest.revision: 39
author: "alexhomer1"
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Extend dependency diagrams
You can write code to create and update dependency diagrams, and to validate the structure of your program code against dependency diagrams in Visual Studio. You can add commands that appear in the shortcut (context) menu of the diagrams, customize drag-and-drop gestures, and access the layer model from text templates. You can package these extensions into a Visual Studio Integration Extension (VSIX) and distribute them to other Visual Studio users.  
  
 For more information about dependency diagrams, see:  
  
-   [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)  
  
-   [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)  
  
-   [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)  
  
-   [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)  
  
##  <a name="prereqs"></a> Requirements  
 You must have the following installed on the computer where you want to develop your layer extensions:  
  
-   Visual Studio  
  
-   [Visual Studio SDK](../extensibility/visual-studio-sdk.md)  
  
-   [Modeling SDK for Visual Studio 2015](http://www.microsoft.com/download/details.aspx?id=48148)  
  
 You must have a suitable version of Visual Studio installed on the computer where you want to run your layer extensions. For more information, see [Deploy a layer model extension](../modeling/deploy-a-layer-model-extension.md).  
  
 To see which versions of Visual Studio support dependency diagrams, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## In This Section  
 [Add commands and gestures to dependency diagrams](../modeling/add-commands-and-gestures-to-layer-diagrams.md)  
  
 [Add custom architecture validation to dependency diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md)  
  
 [Add custom properties to dependency diagrams](../modeling/add-custom-properties-to-layer-diagrams.md)  
  
 [Navigate and update layer models in program code](../modeling/navigate-and-update-layer-models-in-program-code.md)  
  
 [Deploy a layer model extension](../modeling/deploy-a-layer-model-extension.md)  
  
 [Troubleshoot extensions for dependency diagrams](../modeling/troubleshoot-extensions-for-layer-diagrams.md)  
  
## See Also  
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)   
 [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)   
 [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)   
 [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)   
 [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)   
