---
title: "Introduction to International Applications Based on the .NET Framework | Microsoft Docs"
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
  - "strings [Visual Studio], localizing"
  - "Web applications [.NET Framework], globalization"
  - "Windows Forms, globalization"
  - "localization [Visual Studio], culture setting"
  - "fallback resources"
  - "culture, setting"
  - "globalization [Visual Studio], culture setting"
  - "resources [Visual Studio], localization"
  - "localization [Visual Studio], .NET localization model"
  - "Assembly Resource file template"
  - "resources [Visual Studio], fallback system"
  - "international applications [Visual Studio], about international applications"
  - "globalization [Visual Studio], international applications"
  - "ASP.NET, globalization"
  - "resource files, fallback processes"
  - "user interface, culture setting"
ms.assetid: b0788993-e62d-4f68-8235-5f87b1d48525
caps.latest.revision: 11
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
# Introduction to International Applications Based on the .NET Framework
In [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], there are two parts to creating a world-ready application: globalization, the process of designing applications that can adapt to different cultures, and localization, the process of translating resources for a specific culture. For general information on designing applications for an international audience, see [Best Practices for Developing World-Ready Applications](../Topic/Best%20Practices%20for%20Developing%20World-Ready%20Applications.md).  
  
 The [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] localization model consists of a main assembly that contains both the application code and the fallback resources — strings, images, and other objects for the language in which the application is originally developed. Each localized application will have satellite assemblies, or assemblies which contain only the localized resources. Because the main assembly always contains the fallback resources, if a resource is not found in the localized satellite assembly, the <xref:System.Resources.ResourceManager> will attempt to load it in a hierarchical manner, eventually falling back to the resource in the main assembly. The resource fallback system is explained in greater detail in [Hierarchical Organization of Resources for Localization](../ide/hierarchical-organization-of-resources-for-localization.md).  
  
 One localization resource you should consider using is the glossary for all Microsoft localized products. This CSV file contains over 12,000 English terms plus the translations of the terms in up to 59 different languages. The glossary is available for download on the [Microsoft Terminology Translations](http://go.microsoft.com/fwlink/?LinkId=128146) Web page.  
  
 The project system for Windows Forms applications can generate resource files for both the fallback and each desired additional UI culture. The fallback resource file is built into the main assembly, and the culture-specific resource files are then built into satellite assemblies, one for each UI culture. When you build a project, the resource files are compiled from the Visual Studio XML format (.resx) to an intermediate binary format (.resources), which are then embedded in satellite assemblies.  
  
 The project system for both Windows Forms and Web Forms allows you to build resource files using an Assembly Resource File template, access the resources, and build your project. Satellite assemblies will be created along with the main assembly.  
  
 When a localized application executes, its appearance is determined by two culture values. (A *culture* is a set of user preference information related to the user's language, environment, and cultural conventions.) The UI culture setting determines which resources will be loaded. The UI culture is set as `UICulture` in Web.config files and page directives, and <xref:System.Globalization.CultureInfo.CurrentUICulture%2A> in Visual Basic or Visual C# code. The culture setting determines formatting of values such as dates, numbers, currency, and so on. The culture is set as `Culture` in Web.config files and page directives, <xref:System.Globalization.CultureInfo.CurrentCulture%2A> in Visual Basic or Visual C# code.  
  
## See Also  
 <xref:System.Globalization>   
 <xref:System.Resources>   
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)   
 [Security and Localized Satellite Assemblies](../ide/security-and-localized-satellite-assemblies.md)