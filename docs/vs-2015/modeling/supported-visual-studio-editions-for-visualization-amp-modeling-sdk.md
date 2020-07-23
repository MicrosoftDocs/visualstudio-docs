---
title: "Supported Visual Studio Editions for Visualization and Modeling SDK | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language Tools, supported Visual Studio editions"
ms.assetid: 7c313ba0-031d-45b8-8220-eead61754747
caps.latest.revision: 29
author: jillre
ms.author: jillfra
manager: jillfra
---
# Supported Visual Studio Editions for Visualization &amp; Modeling SDK
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The following are lists of the Visual Studio editions that are supported with [!INCLUDE[dsl](../includes/dsl-md.md)] in the authoring and deployment environments. For more information on these editions, see the Microsoft [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] [Developer Center](https://msdn.microsoft.com/vstudio/products/).

## Authoring Edition
 To define a DSL, you must have installed the following components:

|Product|Download link|
|-|-|
|[!INCLUDE[vsprvs](../includes/vsprvs-md.md)]|[https://www.visualstudio.com/](https://www.visualstudio.com/)|
|[!INCLUDE[vssdk_current_short](../includes/vssdk-current-short-md.md)]|[Visual Studio SDK](../extensibility/visual-studio-sdk.md)|
|Visual Studio Visualization and Modeling SDK|[Modeling SDK Download](https://www.microsoft.com/download/details.aspx?id=48148)|
## Deployment Editions
 [!INCLUDE[dsl](../includes/dsl-md.md)] supports the following configurations for deploying the domain-specific languages that you build:

- Visual Studio Enterprise

- Visual Studio Professional

- Visual Studio Shell (integrated mode) redistributable package redistributable package

- Visual Studio Shell (isolated mode) redistributable package redistributable package

> [!NOTE]
> To make a DSL able to run on a Shell product, you must set the **Supported VS Edition** field in the Extension Manifest. For more information, see [Deploying Domain-Specific Language Solutions](../modeling/deploying-domain-specific-language-solutions.md).

## See Also
 [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
