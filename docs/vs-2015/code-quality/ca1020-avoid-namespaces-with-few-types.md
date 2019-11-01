---
title: "CA1020: Avoid namespaces with few types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1020"
  - "AvoidNamespacesWithFewTypes"
helpviewer_keywords:
  - "CA1020"
  - "AvoidNamespacesWithFewTypes"
ms.assetid: 9cb272f6-a3ff-45af-b35d-70dea620b074
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1020: Avoid namespaces with few types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|AvoidNamespacesWithFewTypes|
|CheckId|CA1020|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A namespace other than the global namespace contains fewer than five types.

## Rule Description
 Make sure that each of your namespaces has a logical organization, and that a valid reason exists to put types in a sparsely populated namespace. Namespaces should contain types that are used together in most scenarios. When their applications are mutually exclusive, types should be located in separate namespaces. For example, the <xref:System.Web.UI> namespace contains types that are used in Web applications, and the <xref:System.Windows.Forms> namespace contains types that are used in [!INCLUDE[TLA#tla_mswin](../includes/tlasharptla-mswin-md.md)]-based applications. Even though both namespaces have types that control aspects of the user interface, these types are not designed for use in the same application. Therefore, they are located in separate namespaces. Careful namespace organization can also be helpful because it increases the discoverability of a feature. By examining the namespace hierarchy, library consumers should be able to locate the types that implement a feature.

> [!NOTE]
> Design-time types and permissions should not be merged into other namespaces to comply with this guideline. These types belong in their own namespaces below your main namespace, and the namespaces should end in `.Design` and `.Permissions`, respectively.

## How to Fix Violations
 To fix a violation of this rule, try to combine namespaces that contain just a few types into a single namespace.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the namespace does not contain types that are used with the types in your other namespaces.
