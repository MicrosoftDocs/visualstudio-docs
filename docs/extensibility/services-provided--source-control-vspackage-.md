---
title: "Services Provided (Source Control VSPackage)"
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
  - "services, source control packages"
  - "source control packages, services"
ms.assetid: 9db07d70-87d2-4401-bc88-e3a49d81e9a2
caps.latest.revision: 15
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
# Services Provided (Source Control VSPackage)
Services are the primary mechanism through which functionality is shared among VSPackages and between the Visual Studio integrated development environment (IDE) and its installed VSPackages. For detailed description of services and their importance in the Visual Studio IDE, see[Using and Providing Services](../extensibility/using-and-providing-services.md).  
  
## The Source Control Service  
 Visual Studio provides two layers of services, IDE-level services and package-level services. The Visual Studio IDE natively provides IDE-level services. The source control package consumes some of these services. The source control package as a VSPackage shares its source control functionality by providing a private source control service of its own. The source control package encapsulates the set of source control-related interfaces implemented by it in the form of a contract that can be used by the Visual Studio IDE.  
  
## See Also  
 [Design Elements](../extensibility/source-control-vspackage-design-elements.md)