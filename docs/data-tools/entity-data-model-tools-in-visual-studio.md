---
title: Entity Framework Tools
description: Understand Entity Framework Tools in Visual Studio. Entity Framework Tools are designed to help you build Entity Framework (EF) applications.
ms.custom: SEO-VS-2020
ms.date: 11/01/2021
ms.topic: conceptual
ms.assetid: 1b06b573-84aa-4458-b3f5-e238df47bf45
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Entity Framework Tools in Visual Studio

Entity Framework is an object-relational mapping technology that enables .NET developers to work with relational data by using domain-specific objects. It eliminates the need for most of the data-access code that developers usually need to write. Entity Framework is the recommended object-relational mapping (ORM) modeling technology for new .NET applications.

Entity Framework Tools are designed to help you build Entity Framework (EF) applications. The complete documentation for Entity Framework is here: [Overview - EF 6](/ef/ef6/).

  > [!NOTE]
  > The Entity Framework Tools described on this page are used to generate *.edmx* files, which are not supported in EF Core. To generate an EF Core model from an existing database, see [Reverse Engineering - EF Core](/ef/core/managing-schemas/scaffolding). For more information on the differences between EF 6 and EF Core, see [Compare EF 6 and EF Core](/ef/efcore-and-ef6/).

With Entity Framework Tools, you can create a *conceptual model* from an existing database and then graphically visualize and edit your conceptual model. Or, you can graphically create a conceptual model first, and then generate a database that supports your model. In either case, you can automatically update your model when the underlying database changes and automatically generate object-layer code for your application. Database generation and object-layer code generation are customizable.

The Entity Framework tools are installed as part of the **Data storage and processing** workload in the Visual Studio Installer. You can also install them as an individual component under the **SDKs, libraries, and frameworks** category.

These are the specific tools that make up Entity Framework tools in Visual Studio:

- You can use the [!INCLUDE[vstecado](../data-tools/includes/vstecado_md.md)] **[!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Designer** (**Entity Designer**) to visually create and modify entities, associations, mappings, and inheritance relationships. The **Entity Designer** also generates [!INCLUDE[TLA#tla_cshrp](../data-tools/includes/tlasharptla_cshrp_md.md)] or [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] object-layer code.

- You can use the **[!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Wizard** to generate a conceptual model from an existing database and add database connection information to your application.

- You can use the **Create Database Wizard** to create a conceptual model first and then create a database that supports the model.

- You can use the **Update Model Wizard** to update your conceptual model, storage model, and mappings when changes have been made to the underlying database.

  > [!NOTE]
  > Starting with Visual Studio 2010, Entity Framework tools do not support [!INCLUDE[ss2k](../data-tools/includes/ss2k_md.md)].

The tools generate or modify an *.edmx* file. This *.edmx* file contains information that describes the conceptual model, the storage model, and the mappings between them. For more information, see [EDMX](/ef/ef6/).

[Entity Framework 6 Power Tools](https://marketplace.visualstudio.com/items?itemName=EntityFrameworkTeam.EntityFrameworkPowerToolsBeta4) help you build applications that use the Entity Data Model. The power tools can generate a conceptual model, validate an existing model, produce source-code files that contain object classes based on the conceptual model, and produce source-code files that contain views that the model generates. For detailed information, see [Pre-Generated Mapping Views](/ef/ef6/fundamentals/performance/pre-generated-views).

## Related topics

| Title | Description |
| - | - |
| [ADO.NET Entity Framework](/dotnet/framework/data/adonet/ef/index) | Describes how to use [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] Tools, which [!INCLUDE[adonet_ef](../data-tools/includes/adonet_ef_md.md)] provides, to create applications. |
| [Entity Data Model](/dotnet/framework/data/adonet/entity-data-model) | Provides links and information for working with data that is used by applications built on [!INCLUDE[adonet_ef](../data-tools/includes/adonet_ef_md.md)]. |
| [Entity Framework (EF) Documentation)](/ef/ef6/get-started) | Provides an index of videos, tutorials, and advanced documentation to help you make the most of Entity Framework. |

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
