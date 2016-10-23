---
title: "Modeling SDK for Visual Studio - Domain-Specific Languages"
ms.custom: na
ms.date: 10/05/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-techdebt
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 17a531e2-1964-4a9d-84fd-6fb1b4aee662
caps.latest.revision: 77
manager: kamrani
translation.priority.mt: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Modeling SDK for Visual Studio - Domain-Specific Languages
By using the Modeling SDK for Visual Studio (MSDK), you can create powerful model-based development tools that you can integrate into Visual Studio. As an example, the UML tools are created using MSDK. In the same manner, you can create one or more model definitions and integrate them into a set of tools.  
  
 At the heart of MSDK is the definition of a model that you create to represent concepts in your business area. You can surround the model with a variety of tools, such as a diagrammatic view, the ability to generate code and other artifacts, commands for transforming the model, and the ability to interact with code and other objects in Visual Studio. As you develop the model, you can combine it with other models and tools to form a powerful toolset that is centered on your development.  
  
 MSDK lets you develop a model quickly in the form of a domain-specific language (DSL). You begin by using a specialized editor to define a schema or abstract syntax together with a graphical notation. From this definition, VMSDK generates:  
  
-   A model implementation with a strongly-typed API that runs in a transaction-based store.  
  
-   A tree-based explorer.  
  
-   A graphical editor in which users can view the model or parts of it that you define.  
  
-   Serialization methods that save your models in readable XML.  
  
-   Facilities for generating program code and other artifacts using text templating.  
  
 You can customize and extend all of these features. Your extensions are integrated in such a way that you can still update the DSL definition and re-generate the features without losing your extensions.  
  
## Samples and the Latest Information  
 [Download the Modeling SDK for Visual Studio 2015](http://www.microsoft.com/download/details.aspx?id=48148)  
  
 [Samples](http://go.microsoft.com/fwlink/?LinkId=186128) for the Modeling SDK for Visual Studio.  
  
 For guidance on advanced techniques and troubleshooting, visit [Visual Studio DSL & Modeling Tools Extensibility forum](http://go.microsoft.com/fwlink/?LinkID=186074).  
  
## In This Section  
 [Getting Started with Domain-Specific Languages](../VS_IDE/Getting-Started-with-Domain-Specific-Languages.md)  
  
 [Understanding Models, Classes and Relationships](../VS_IDE/Understanding-Models--Classes-and-Relationships.md)  
  
 [How to Define a Domain-Specific Language](../VS_IDE/How-to-Define-a-Domain-Specific-Language.md)  
  
 [Customizing and Extending a Domain-Specific Language](../VS_IDE/Customizing-and-Extending-a-Domain-Specific-Language.md)  
  
 [Validation in a Domain-Specific Language](../VS_IDE/Validation-in-a-Domain-Specific-Language.md)  
  
 [Writing Code to Customise a Domain-Specific Language](../VS_IDE/Writing-Code-to-Customise-a-Domain-Specific-Language.md)  
  
 [Generating Code from a Domain-Specific Language](../VS_IDE/Generating-Code-from-a-Domain-Specific-Language.md)  
  
 [Understanding the DSL Code](../VS_IDE/Understanding-the-DSL-Code.md)  
  
 [Customizing File Storage and XML Serialization](../VS_IDE/Customizing-File-Storage-and-XML-Serialization.md)  
  
 [Deploying Domain-Specific Language Solutions](../VS_IDE/Deploying-Domain-Specific-Language-Solutions.md)  
  
 [Creating a Windows Forms-Based Domain-Specific Language](../VS_IDE/Creating-a-Windows-Forms-Based-Domain-Specific-Language.md)  
  
 [Creating a WPF-Based Domain-Specific Language](../VS_IDE/Creating-a-WPF-Based-Domain-Specific-Language.md)  
  
 [How to: Extend the Domain-Specific Language Designer](../VS_IDE/How-to--Extend-the-Domain-Specific-Language-Designer.md)  
  
 [Supported Visual Studio Editions for Visualization & Modeling SDK](../VS_IDE/Supported-Visual-Studio-Editions-for-Visualization---Modeling-SDK.md)  
  
 [How to: Migrate a Domain-Specific Language to a New Version](../VS_IDE/How-to--Migrate-a-Domain-Specific-Language-to-a-New-Version.md)  
  
 [API Reference for Modeling SDK for Visual Studio](../VS_IDE/API-Reference-for-Modeling-SDK-for-Visual-Studio.md)