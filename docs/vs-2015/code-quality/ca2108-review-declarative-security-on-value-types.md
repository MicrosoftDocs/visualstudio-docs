---
title: "CA2108: Review declarative security on value types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ReviewDeclarativeSecurityOnValueTypes"
  - "CA2108"
helpviewer_keywords:
  - "ReviewDeclarativeSecurityOnValueTypes"
  - "CA2108"
ms.assetid: d62bffdd-3826-4d52-a708-1c646c5d48c2
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2108: Review declarative security on value types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewDeclarativeSecurityOnValueTypes|
|CheckId|CA2108|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause
 A public or protected value type is secured by a [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6) or [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d).

## Rule Description
 Value types are allocated and initialized by their default constructors before other constructors execute. If a value type is secured by a Demand or LinkDemand, and the caller does not have permissions that satisfy the security check, any constructor other than the default will fail, and a security exception will be thrown. The value type is not deallocated; it is left in the state set by its default constructor. Do not assume that a caller that passes an instance of the value type has permission to create or access the instance.

## How to Fix Violations
 You cannot fix a violation of this rule unless you remove the security check from the type, and use method level security checks in its place. Note that fixing the violation in this manner will not prevent callers with inadequate permissions from obtaining instances of the value type. You must ensure that an instance of the value type, in its default state, does not expose sensitive information, and cannot be used in a harmful manner.

## When to Suppress Warnings
 You can suppress a warning from this rule if any caller can obtain instances of the value type in its default state without posing a threat to security.

## Example
 The following example shows a library containing a value type that violates this rule. Note that the `StructureManager` type assumes that a caller that passes an instance of the value type has permission to create or access the instance.

 [!code-csharp[FxCop.Security.DemandOnValueType#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.DemandOnValueType/cs/FxCop.Security.DemandOnValueType.cs#1)]

## Example
 The following application demonstrates the library's weakness.

 [!code-csharp[FxCop.Security.TestDemandOnValueType#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TestDemandOnValueType/cs/FxCop.Security.TestDemandOnValueType.cs#1)]

 This example produces the following output.

 **Structure custom constructor: Request failed.**
**New values SecuredTypeStructure 100 100**
**New values SecuredTypeStructure 200 200**
## See Also
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
 [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6)
