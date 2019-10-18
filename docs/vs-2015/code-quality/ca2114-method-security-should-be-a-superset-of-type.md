---
title: "CA2114: Method security should be a superset of type | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MethodSecurityShouldBeASupersetOfType"
  - "CA2114"
helpviewer_keywords:
  - "CA2114"
  - "MethodSecurityShouldBeASupersetOfType"
ms.assetid: 663f7aa4-8be5-4bd5-be92-4e9444f07077
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2114: Method security should be a superset of type
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MethodSecurityShouldBeASupersetOfType|
|CheckId|CA2114|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A type has declarative security and one of its methods has declarative security for the same security action, and the security action is not [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d) or [Inheritance Demands](https://msdn.microsoft.com/28b9adbb-8f08-4f10-b856-dbf59eb932d9), and the permissions checked by the type are not a subset of the permissions checked by the method.

## Rule Description
 A method should not have both a method-level and type-level declarative security for the same action. The two checks are not combined; only the method-level demand is applied. For example, if a type demands permission `X`, and one of its methods demands permission `Y`, code does not have to have permission `X` to execute the method.

## How to Fix Violations
 Review your code to make sure that both actions are required. If both actions are required, make sure that the method-level action includes the security specified at the type level. For example, if your type demands permission `X`, and its method must also demand permission `Y`, the method should explicitly demand `X` and `Y`.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the method does not require the security specified by the type. However, this is not an ordinary scenario and might indicate a need for a careful design review.

## Example
 The following example uses environment permissions to demonstrate the dangers of violating this rule. In this example, the application code creates an instance of the secured type before denying the permission required by the type. In a real-world threat scenario, the application would require another way to obtain an instance of the object.

 In the following example, the library demands write permission for a type and read permission for a method.

 [!code-csharp[FxCop.Security.MethodLevelSecurity#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.MethodLevelSecurity/cs/FxCop.Security.MethodLevelSecurity.cs#1)]

## Example
 The following application code demonstrates the vulnerability of the library by calling the method even though it does not meet the type-level security requirement.

 [!code-csharp[FxCop.Security.TestMethodLevelSecurity#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TestMethodLevelSecurity/cs/FxCop.Security.TestMethodLevelSecurity.cs#1)]

 This example produces the following output.

 **[All permissions] Personal information: 6/16/1964 12:00:00 AM**
**[No write permission (demanded by type)] Personal information: 6/16/1964 12:00:00 AM**
**[No read permission (demanded by method)] Could not access personal information: Request failed.**
## See Also
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [Inheritance Demands](https://msdn.microsoft.com/28b9adbb-8f08-4f10-b856-dbf59eb932d9)
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
 [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6)
