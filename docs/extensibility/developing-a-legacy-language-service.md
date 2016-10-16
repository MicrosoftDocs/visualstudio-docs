---
title: "Developing a Legacy Language Service"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.vsip.LangServWiz.langtoks"
  - "vs.vsip.LangServWiz.welcome"
  - "vs.vsip.LangServWiz.langSpec"
  - "vs.vsip.LangServWiz.langInfo"
  - "vs.vsip.LangServWiz.langServOpts"
helpviewer_keywords: 
  - "language services, developing"
ms.assetid: 6151ba88-c1c3-41de-a1cc-668f494d48d1
caps.latest.revision: 28
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
# Developing a Legacy Language Service
This section links to topics that help you create a legacy language service.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../extensibility/editor-and-language-service-extensions.md).  
  
> [!NOTE]
>  We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## In This Section  
 [Model of a Legacy Language Service](../extensibility/model-of-a-legacy-language-service.md)  
 Provides a model of a minimal language service for the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] core editor. You can use this model as a guide for creating your own language service.  
  
 [Legacy Language Service Interfaces](../extensibility/legacy-language-service-interfaces.md)  
 Discusses the objects required to implement a language service and provides a listing of additional objects that you can use to provide syntax highlighting, method data, and other features.  
  
 [Intercepting Legacy Language Service Commands](../extensibility/intercepting-legacy-language-service-commands.md)  
 Describes how to insert a command filter into your language service to intercept commands that the text view would otherwise handle.  
  
 [Registering a Legacy Language Service](../extensibility/registering-a-legacy-language-service2.md)  
 Provides information about how to register your language service by using [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
 [Language Service Support for Debugging](../extensibility/language-service-support-for-debugging.md)  
 Describes how a language service can provide features to support a debugger.  
  
 [Checklist: Creating a Legacy Language Service](../extensibility/checklist--creating-a-legacy-language-service.md)  
 Provides step-by-step instructions for creating and integrating a language service for the core editor.  
  
## Related Sections  
 [Syntax Coloring in a Legacy Language Service](../extensibility/syntax-coloring-in-a-legacy-language-service.md)  
 Discusses how to implement syntax highlighting in your language service.  
  
 [Statement Completion in a Legacy Language Service](../extensibility/statement-completion-in-a-legacy-language-service.md)  
 Discusses statement completion, the process by which a language service helps users finish a language keyword or element that they have started typing.  
  
 [Parameter Info in a Legacy Language Service](../extensibility/parameter-info-in-a-legacy-language-service1.md)  
 Describes how to provide method tips for overloaded functions and methods.  
  
 [How to: Provide Hidden Text Support in a Legacy Language Service](../extensibility/how-to--provide-hidden-text-support-in-a-legacy-language-service.md)  
 Explains the purpose of a hidden text region and provides instructions about how to implement a hidden text region.  
  
 [How to: Provide Expanded Outlining Support in a Legacy Language Service](../extensibility/how-to--provide-expanded-outlining-support-in-a-legacy-language-service.md)  
 Explains the two options that extend outlining support for your language beyond supporting the *Collapse to Definitions* command.