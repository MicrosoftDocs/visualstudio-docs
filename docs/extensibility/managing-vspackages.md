---
title: "Managing VSPackages | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "VSPackages, autoloading"
  - "VSPackages, delayed loading"
  - "delay loading"
  - "VSPackages, loading"
ms.assetid: 386e0ce5-4107-4164-b0cd-1cf43eb5e7cf
caps.latest.revision: 35
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
# Managing VSPackages
In most cases you don’t need to worry about managing VSPackages, since the project and item templates register and load the package automatically. However, in some circumstances you may need to learn a bit more in order to manage your package.  
  
## Using the experimental instance  
 To find out more about the experimental instance, see [The Experimental Instance](../extensibility/the-experimental-instance.md).  
  
## Registering and Unregistering VSPackages  
 To find out how to register and unregister VSPackages and other types of extension, see [Registering and Unregistering VSPackages](../extensibility/registering-and-unregistering-vspackages.md).  
  
## Loading a VSPackage  
 VSPackages can be set to autoload when a particular CMDUICONTEXT GUID is turned on. For more information, see [Loading VSPackages](../extensibility/loading-vspackages.md).  
  
## Using AsyncPackage to Load VSPackages in the Background  
 The AsyncPackage class enables package loading on a background thread for better UI responsiveness in Visual Studio. For more information, see [How to: Use AsyncPackage to Load VSPackages in the Background](../extensibility/how-to-use-asyncpackage-to-load-vspackages-in-the-background.md).  
  
## Rule-based UI Context for Extensions  
 Rules-based UI Contexts allows extension authors to define the precise conditions under which a UI Context is activated and associated VSPackages loaded. For more information, see [How to: Use Rule-based UI Context for Visual Studio Extensions](../extensibility/how-to-use-rule-based-ui-context-for-visual-studio-extensions.md).  
  
## Diagnosing extension performance  
Extensions can impact startup and solution load performance. Learn how Visual Studio extension impact is calculated and how it can be analyzed locally to test if an extension may be shown as a performance impacting extension. For more information, see [How to: Diagnose Extension Performance](how-to-diagnose-extension-performance.md). 
  
## Troubleshooting VSPackages  
 Find out the techniques for troubleshooting VSPackages that don’t load or are experiencing errors: [Troubleshooting VSPackages](../extensibility/troubleshooting-vspackages.md)  
  
## See Also  
 [VSPackages](../extensibility/internals/vspackages.md)