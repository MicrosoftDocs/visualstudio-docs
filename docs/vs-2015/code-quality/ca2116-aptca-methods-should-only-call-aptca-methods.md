---
title: "CA2116: APTCA methods should only call APTCA methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "AptcaMethodsShouldOnlyCallAptcaMethods"
  - "CA2116"
helpviewer_keywords:
  - "AptcaMethodsShouldOnlyCallAptcaMethods"
  - "CA2116"
ms.assetid: 8b91637e-891f-4dde-857b-bf8012270ec4
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2116: APTCA methods should only call APTCA methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|Item|Value|
|-|-|
|TypeName|AptcaMethodsShouldOnlyCallAptcaMethods|
|CheckId|CA2116|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A method in an assembly with the <xref:System.Security.AllowPartiallyTrustedCallersAttribute?displayProperty=fullName> attribute calls a method in an assembly that does not have the attribute.

## Rule Description
 By default, public or protected methods in assemblies with strong names are implicitly protected by a [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d) for full trust; only fully trusted callers can access a strong-named assembly. Strong-named assemblies marked with the <xref:System.Security.AllowPartiallyTrustedCallersAttribute> (APTCA) attribute do not have this protection. The attribute disables the link demand, making the assembly accessible to callers that do not have full trust, such as code executing from an intranet or the Internet.

 When the APTCA attribute is present on a fully trusted assembly, and the assembly executes code in another assembly that does not allow partially trusted callers, a security exploit is possible. If two methods `M1` and `M2` meet the following conditions, malicious callers can use the method `M1` to bypass the implicit full trust link demand that protects `M2`:

- `M1` is a public method declared in a fully trusted assembly that has the APTCA attribute.

- `M1` calls a method `M2` outside `M1`'s assembly.

- `M2`'s assembly does not have the APTCA attribute and, therefore, should not be executed by or on behalf of callers that are partially trusted.

  A partially trusted caller `X` can call method `M1`, causing `M1` to call `M2`. Because `M2` does not have the APTCA attribute, its immediate caller (`M1`) must satisfy a link demand for full trust; `M1` has full trust and therefore satisfies this check. The security risk is because `X` does not participate in satisfying the link demand that protects `M2` from untrusted callers. Therefore, methods with the APTCA attribute must not call methods that do not have the attribute.

## How to Fix Violations
 If the APCTA attribute is required, use a demand to protect the method that calls into the full trust assembly. The exact permissions you demand will depend on the functionality exposed by your method. If it is possible, protect the method with a demand for full trust to ensure that the underlying functionality is not exposed to partially trusted callers. If this is not possible, select a set of permissions that effectively protects the exposed functionality. For more information about demands, see [Demands](https://msdn.microsoft.com/e5283e28-2366-4519-b27d-ef5c1ddc1f48).

## When to Suppress Warnings
 To safely suppress a warning from this rule, you must ensure that the functionality exposed by your method does not directly or indirectly allow callers to access sensitive information, operations, or resources that can be used in a destructive manner.

## Example
 The following example uses two assemblies and a test application to illustrate the security vulnerability detected by this rule. The first assembly does not have the APTCA attribute and should not be accessible to partially trusted callers (represented by `M2` in the previous discussion).

 [!code-csharp[FxCop.Security.NoAptca#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.NoAptca/cs/FxCop.Security.NoAptca.cs#1)]

## Example
 The second assembly is fully trusted and allows partially trusted callers (represented by `M1` in the previous discussion).

 [!code-csharp[FxCop.Security.YesAptca#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.YesAptca/cs/FxCop.Security.YesAptca.cs#1)]

## Example
 The test application (represented by `X` in the previous discussion) is partially trusted.

 [!code-csharp[FxCop.Security.TestAptcaMethods#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.TestAptcaMethods/cs/FxCop.Security.TestAptcaMethods.cs#1)]

 This example produces the following output.

 **Demand for full trust:Request failed.**
**ClassRequiringFullTrust.DoWork was called.**
## Related Rules
 [CA2117: APTCA types should only extend APTCA base types](../code-quality/ca2117-aptca-types-should-only-extend-aptca-base-types.md)

## See Also
 [Secure Coding Guidelines](https://msdn.microsoft.com/library/4f882d94-262b-4494-b0a6-ba9ba1f5f177)
 [.NET Framework Assemblies Callable by Partially Trusted Code](https://msdn.microsoft.com/a417fcd4-d3ca-4884-a308-3a1a080eac8d)
 [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/dd66cd4c-b087-415f-9c3e-94e3a1835f74)
 [Demands](https://msdn.microsoft.com/e5283e28-2366-4519-b27d-ef5c1ddc1f48)
 [Link Demands](https://msdn.microsoft.com/library/a33fd5f9-2de9-4653-a4f0-d9df25082c4d)
 [Data and Modeling](https://msdn.microsoft.com/library/8c37635d-e2c1-4b64-a258-61d9e87405e6)
