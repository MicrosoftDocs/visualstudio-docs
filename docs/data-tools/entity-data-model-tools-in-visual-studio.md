---
title: "Entity Data Model Tools in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
ms.assetid: 1b06b573-84aa-4458-b3f5-e238df47bf45
caps.latest.revision: 21
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
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
# Entity Data Model Tools in Visual Studio
Entity Framework is an object-relational mapping technology that enables .NET developers to work with relational data by using domain-specific objects. It eliminates the need for most of the data-access code that developers usually need to write. Entity Framework is the recommended object-relational mapping (ORM) modeling technology for new .NET applications.  
  
 As of March 2016, the most current released version is [Entity Framework 6](https://msdn.microsoft.com/en-us/data/ef) . [Entity Framework 7](https://docs.efproject.net/en/latest/) is in pre-release.  
  
 [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools are designed to help you build [!INCLUDE[adonet_ef](../data-tools/includes/adonet_ef_md.md)] applications. The complete documentation for [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools is here: [Entity Framework](https://msdn.microsoft.com/en-us/data/jj590134).  
  
 With [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools, you can create a *conceptual model* from an existing database and then graphically visualize and edit your conceptual model. Or, you can graphically create a conceptual model first, and then generate a database that supports your model. In either case, you can automatically update your model when the underlying database changes and automatically generate object-layer code for your application. Database generation and object-layer code generation are customizable.  
  
 These are the specific tools that make up Entity Data Model Tools in Visual Studio 2015:  
  
-   You can use the [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] **[!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Designer** (**Entity Designer**) to visually create and modify entities, associations, mappings, and inheritance relationships. The **Entity Designer** also generates [!INCLUDE[TLA#tla_cshrp](../data-tools/includes/tlasharptla_cshrp_md.md)] or [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] object-layer code.  
  
-   You can use the **[!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Wizard** to generate a conceptual model from an existing database and add database connection information to your application.  
  
-   You can use the **Create Database Wizard** to create a conceptual model first and then create a database that supports the model.  
  
-   You can use the **Update Model Wizard** to update your conceptual model, storage model, and mappings when changes have been made to the underlying database.  
  
    > [!NOTE]
    >  Starting with Visual Studio 2010, [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools do not support [!INCLUDE[ss2k](../data-tools/includes/ss2k_md.md)].  
  
 The tools generate or modify an .edmx file. This file contains information that describes the conceptual model, the storage model, and the mappings between them. For more information, see  [EDMX](https://msdn.microsoft.com/en-us/data/jj650889.aspx).  
  
 Entity Framework Power Tools help you build applications that use the Entity Data Model. The tools can generate a conceptual model, validate an existing model, produce source-code files that contain object classes based on the conceptual model, and produce source-code files that contain views that the model generates. For detailed information, see [Pre-Generated Mapping Views](https://msdn.microsoft.com/en-us/data/dn469601.aspx).  
  
## Related topics  
  
|Title|Description|  
|-----------|-----------------|  
|[ADO.NET Entity Framework](../Topic/ADO.NET%20Entity%20Framework.md)|Describes how to use [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools, which [!INCLUDE[adonet_ef](../data-tools/includes/adonet_ef_md.md)] provides, to create applications.|  
|[Entity Data Model](../Topic/Entity%20Data%20Model.md)|Provides links and information for working with data that is used by applications built on [!INCLUDE[adonet_ef](../data-tools/includes/adonet_ef_md.md)].|  
|[Getting Started on Full .NET (Console, WinForms, WPF, etc.)](https://docs.efproject.net/en/latest/platforms/full-dotnet/getting-started.html)|Provides tutorials on how to create .NET desktop applications that use Entity Framework 7.|  
|[ASP.NET 5 Application to New Database](https://docs.efproject.net/en/latest/platforms/aspnetcore/new-db.html)|Describes how to create a new ASP.NET 5 application by using Entity Framework 7.|  
  
## See Also  
 [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)