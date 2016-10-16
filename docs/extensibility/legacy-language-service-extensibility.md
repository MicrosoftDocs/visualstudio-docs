---
title: "Legacy Language Service Extensibility"
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
  - "language services"
  - "Visual Studio, language services"
ms.assetid: 2700cd4d-5f68-43fc-b62f-dc80c3f3aa85
caps.latest.revision: 42
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
# Legacy Language Service Extensibility
A language service provides language-specific support for editing source code in the IDE.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../extensibility/editor-and-language-service-extensions.md).  
  
 This section discusses the structure and implementation of a legacy language service.  
  
## In This Section  
 [Migrating a Legacy Language Service](../extensibility/migrating-a-legacy-language-service.md)  
 Explains how to update a language service from Visual Studio 2008 to the latest version.  
  
 [Legacy Language Service Essentials](../extensibility/legacy-language-service-essentials.md)  
 Provides important information about how to develop language services to integrate a programming language into Visual Studio.  
  
 [Developing a Legacy Language Service](../extensibility/developing-a-legacy-language-service.md)  
 Provides links to topics that can help you create a language service.  
  
 [Syntax Coloring in a Legacy Language Service](../extensibility/syntax-coloring-in-a-legacy-language-service.md)  
 Provides information about supporting syntax highlighting in a language service.  
  
 [Implementing a Legacy Language Service](../extensibility/implementing-a-legacy-language-service1.md)  
 Provides information about how to use the managed package framework (MPF) to implement a full-featured language service in managed code.  
  
 [Supporting Symbol-Browsing Tools](../extensibility/supporting-symbol-browsing-tools.md)  
 Describes libraries and tools that enable you to browse tree views of symbols in the IDE.  
  
## Related Sections  
 [Editor and Language Service Extensions](../extensibility/editor-and-language-service-extensions.md)  
 Provides an overview of Visual Studio editors.  
  
 [Language Service Support for Debugging](../extensibility/language-service-support-for-debugging.md)  
 Provides information about and a link to the Visual Studio Debugging SDK, which contains the information that is required to create and customize debugger components used to debug programs.