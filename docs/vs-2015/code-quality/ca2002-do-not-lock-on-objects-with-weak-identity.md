---
title: "CA2002: Do not lock on objects with weak identity | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotLockOnObjectsWithWeakIdentity"
  - "CA2002"
helpviewer_keywords:
  - "CA2002"
  - "DoNotLockOnObjectsWithWeakIdentity"
ms.assetid: 16100b39-c6fc-452b-8fca-8b459a26c286
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2002: Do not lock on objects with weak identity
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotLockOnObjectsWithWeakIdentity|
|CheckId|CA2002|
|Category|Microsoft.Reliability|
|Breaking Change|Non-breaking|

## Cause
 A thread attempts to acquire a lock on an object that has a weak identity.

## Rule Description
 An object is said to have a weak identity when it can be directly accessed across application domain boundaries. A thread that tries to acquire a lock on an object that has a weak identity can be blocked by a second thread in a different application domain that has a lock on the same object. The following types have a weak identity and are flagged by the rule:

- <xref:System.MarshalByRefObject>

- <xref:System.ExecutionEngineException>

- <xref:System.OutOfMemoryException>

- <xref:System.StackOverflowException>

- <xref:System.String>

- <xref:System.Reflection.MemberInfo>

- <xref:System.Reflection.ParameterInfo>

- <xref:System.Threading.Thread>

## How to Fix Violations
 To fix a violation of this rule, use an object from a type that is not in the list in the Description section.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Related Rules
 [CA2213: Disposable fields should be disposed](../code-quality/ca2213-disposable-fields-should-be-disposed.md)

## Example
 The following example shows some object locks that violate the rule.

 [!code-csharp[FxCop.Reliability.LockWeakObjects#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Reliability.LockWeakObjects/cs/FxCop.Reliability.LockWeakObjects.cs#1)]
 [!code-vb[FxCop.Reliability.LockWeakObjects#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Reliability.LockWeakObjects/vb/FxCop.Reliability.LockWeakObjects.vb#1)]

## See Also
 <xref:System.Threading.Monitor>
 <xref:System.AppDomain>
 [lock Statement](https://msdn.microsoft.com/library/656da1a4-707e-4ef6-9c6e-6d13b646af42)
 [SyncLock Statement](https://msdn.microsoft.com/library/14501703-298f-4d43-b139-c4b6366af176)
