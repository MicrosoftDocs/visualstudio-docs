---
title: "Editor and Language Service Extensions"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK]"
ms.assetid: 5653bac9-724f-4948-a820-68ce6aa96365
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Editor and Language Service Extensions
You can extend most features of the Visual Studio code editor. The editor is based on the Windows Presentation Foundation (WPF) and is written in managed code. Although this design differs from the designs in earlier versions of Visual Studio, it provides most of the same features. To extend the editor, use the Managed Extensibility Framework (MEF).  
  
 The Visual Studio SDK provides adapters known as *shims* to support VSPackages that were written for earlier versions. Nevertheless, if you have an existing VSPackage, we recommend that you update it to the new technology to obtain better performance and reliability.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md)|Introduction to using the Editor item templates.|  
|[Extending the Editor and Language Services](../extensibility/extending-the-editor-and-language-services.md)|Links to documents that introduce the design and features of the core editor and show how to extend it.|  
|[Legacy Interfaces in the Editor](../extensibility/legacy-interfaces-in-the-editor.md)|Links to documents that explain how to access the core editor from existing code.|  
|[Creating Custom Editors and Designers](../extensibility/creating-custom-editors-and-designers.md)|Links to documents that explain how to create custom editors.|  
|[Legacy Language Service Extensibility](../extensibility/legacy-language-service-extensibility.md)|Links to documents that describe how to integrate programming languages into Visual Studio.|  
|[Managed Extensibility Framework (MEF)](../Topic/Managed%20Extensibility%20Framework%20\(MEF\).md)|Introduces the Managed Extensibility Framework (MEF).|  
|[Windows Presentation Foundation](../Topic/Windows%20Presentation%20Foundation.md)|Introduces the Windows Presentation Foundation (WPF).|