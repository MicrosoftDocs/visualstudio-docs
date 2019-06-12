---
title: "Sdk Element (MSBuild) | Microsoft Docs"
ms.date: "01/25/2018"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#Project"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "Sdk element [MSBuild]"
  - "<Sdk> element [MSBuild]"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Sdk element (MSBuild)
References an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project SDK.

 \<Project>
 \<Sdk>

## Syntax

```xml
<Sdk Name="My.Custom.Sdk"
     Version="1.0.0" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required attribute.<br /><br /> The name of the project SDK.|
|`Version`|Optional attribute.<br /><br /> The version of the project SDK|

### Child elements
 None.

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file. |

## See also
- [How to: Reference an MSBuild project SDK](../msbuild/how-to-use-project-sdk.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [MSBuild](../msbuild/msbuild.md)
