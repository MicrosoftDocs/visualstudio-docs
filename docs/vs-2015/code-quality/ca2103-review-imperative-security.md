---
title: "CA2103: Review imperative security | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2103"
  - "ReviewImperativeSecurity"
helpviewer_keywords:
  - "CA2103"
  - "ReviewImperativeSecurity"
ms.assetid: d24fde71-bdf6-46c0-8965-9a73dc33c1aa
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2103: Review imperative security
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewImperativeSecurity|
|CheckId|CA2103|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A method uses imperative security and might be constructing the permission by using state information or return values that can change as long as the demand is active.

## Rule Description
 Imperative security uses managed objects to specify permissions and security actions during code execution, compared to declarative security, which uses attributes to store permissions and actions in metadata. Imperative security is very flexible because you can set the state of a permission object and select security actions by using information that is not available until run time. Together with that flexibility comes the risk that the runtime information that you use to determine the state of a permission does not remain unchanged as long as the action is in effect.

 Use declarative security whenever possible. Declarative demands are easier to understand.

## How to Fix Violations
 Review the imperative security demands to make sure that the state of the permission does not rely on information that can change as long as the permission is being used.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the permission does not rely on changing data. However, it is better to change the imperative demand to its declarative equivalent.

## See Also
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6)
