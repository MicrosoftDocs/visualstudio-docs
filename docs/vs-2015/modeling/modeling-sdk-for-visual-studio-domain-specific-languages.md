---
title: "Modeling SDK - Domain-Specific Languages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language Tools"
  - "Domain-Specific Language"
ms.assetid: 17a531e2-1964-4a9d-84fd-6fb1b4aee662
caps.latest.revision: 79
author: jillre
ms.author: jillfra
manager: jillfra
---
# Modeling SDK for Visual Studio - Domain-Specific Languages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using the Modeling SDK for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] (MSDK), you can create powerful model-based development tools that you can integrate into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. As an example, the UML tools are created using MSDK. In the same manner, you can create one or more model definitions and integrate them into a set of tools.

 At the heart of MSDK is the definition of a model that you create to represent concepts in your business area. You can surround the model with a variety of tools, such as a diagrammatic view, the ability to generate code and other artifacts, commands for transforming the model, and the ability to interact with code and other objects in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. As you develop the model, you can combine it with other models and tools to form a powerful toolset that is centered on your development.

 MSDK lets you develop a model quickly in the form of a domain-specific language (DSL). You begin by using a specialized editor to define a schema or abstract syntax together with a graphical notation. From this definition, VMSDK generates:

- A model implementation with a strongly-typed API that runs in a transaction-based store.

- A tree-based explorer.

- A graphical editor in which users can view the model or parts of it that you define.

- Serialization methods that save your models in readable XML.

- Facilities for generating program code and other artifacts using text templating.

  You can customize and extend all of these features. Your extensions are integrated in such a way that you can still update the DSL definition and re-generate the features without losing your extensions.

## Samples and the Latest Information
 [Download the Modeling SDK for Visual Studio 2015](https://www.microsoft.com/download/details.aspx?id=48148)

 [Samples](https://go.microsoft.com/fwlink/?LinkId=186128) for the Modeling SDK for Visual Studio.

 For guidance on advanced techniques and troubleshooting, visit [Visual Studio DSL & Modeling Tools Extensibility forum](https://go.microsoft.com/fwlink/?LinkID=186074).

## In This Section
 [Getting Started with Domain-Specific Languages](../modeling/getting-started-with-domain-specific-languages.md)

 [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md)

 [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)

 [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md)

 [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md)

 [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)

 [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)

 [Understanding the DSL Code](../modeling/understanding-the-dsl-code.md)

 [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md)

 [Deploying Domain-Specific Language Solutions](../modeling/deploying-domain-specific-language-solutions.md)

 [Creating a Windows Forms-Based Domain-Specific Language](../modeling/creating-a-windows-forms-based-domain-specific-language.md)

 [Creating a WPF-Based Domain-Specific Language](../modeling/creating-a-wpf-based-domain-specific-language.md)

 [How to: Extend the Domain-Specific Language Designer](../modeling/how-to-extend-the-domain-specific-language-designer.md)

 [Supported Visual Studio Editions for Visualization & Modeling SDK](../modeling/supported-visual-studio-editions-for-visualization-amp-modeling-sdk.md)

 [How to: Migrate a Domain-Specific Language to a New Version](../modeling/how-to-migrate-a-domain-specific-language-to-a-new-version.md)

 [API Reference for Modeling SDK for Visual Studio](../modeling/api-reference-for-modeling-sdk-for-visual-studio.md)
