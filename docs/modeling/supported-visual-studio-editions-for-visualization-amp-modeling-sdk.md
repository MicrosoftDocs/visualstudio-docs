---
title: Supported Visual Studio Editions for Visualization and Modeling SDK
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language Tools, supported Visual Studio editions"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Supported Visual Studio Editions for Visualization & Modeling SDK

The following are lists of the Visual Studio editions that are supported with [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] in the authoring and deployment environments. For more information on these editions, see the Microsoft Visual Studio [Developer Center](https://visualstudio.microsoft.com/).

## Authoring Edition

To define a DSL, you must have installed the following components:

|||
|-|-|
|Visual Studio|[http://go.microsoft.com/fwlink/?LinkId=185579](https://visualstudio.microsoft.com/)|
|Visual Studio SDK|[http://go.microsoft.com/fwlink/?LinkId=185580](/azure/devops/integrate/index?view=azure-devops&viewFallbackFrom=vsts)|
|Visual Studio Visualization and Modeling SDK|[http://go.microsoft.com/fwlink/?LinkID=186128](https://code.msdn.microsoft.com/Visualization-and-Modeling-313535db)|

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

## Deployment Editions

[!INCLUDE[dsl](../modeling/includes/dsl_md.md)] supports the following configurations for deploying the domain-specific languages that you build:

- Visual Studio Enterprise

- Visual Studio Professional

- Visual Studio Shell (integrated mode) redistributable package redistributable package

- Visual Studio Shell (isolated mode) redistributable package redistributable package

> [!NOTE]
> To make a DSL able to run on a Shell product, you must set the **Supported VS Edition** field in the Extension Manifest. For more information, see [Deploying Domain-Specific Language Solutions](msi-and-vsix-deployment-of-a-dsl.md).

## See also

- [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)