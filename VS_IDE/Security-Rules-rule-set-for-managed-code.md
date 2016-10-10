---
title: "Security Rules rule set for managed code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 564aeac6-03fa-41b0-b655-88179f0ab01b
caps.latest.revision: 9
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Security Rules rule set for managed code
You should include the Microsoft Security Rules rule set to maximize the number of potential security issues that are reported.  
  
|Rule|Description|  
|----------|-----------------|  
|[CA2100](../VS_IDE/CA2100--Review-SQL-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|  
|[CA2102](../VS_IDE/CA2102--Catch-non-CLSCompliant-exceptions-in-general-handlers.md)|Catch non-CLSCompliant exceptions in general handlers|  
|[CA2103](../VS_IDE/CA2103--Review-imperative-security.md)|Review imperative security|  
|[CA2104](../VS_IDE/CA2104--Do-not-declare-read-only-mutable-reference-types.md)|Do not declare read only mutable reference types|  
|[CA2105](../VS_IDE/CA2105--Array-fields-should-not-be-read-only.md)|Array fields should not be read only|  
|[CA2106](../VS_IDE/CA2106--Secure-asserts.md)|Secure asserts|  
|[CA2107](../VS_IDE/CA2107--Review-deny-and-permit-only-usage.md)|Review deny and permit only usage|  
|[CA2108](../VS_IDE/CA2108--Review-declarative-security-on-value-types.md)|Review declarative security on value types|  
|[CA2109](../VS_IDE/CA2109--Review-visible-event-handlers.md)|Review visible event handlers|  
|[CA2111](../VS_IDE/CA2111--Pointers-should-not-be-visible.md)|Pointers should not be visible|  
|[CA2112](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md)|Secured types should not expose fields|  
|[CA2114](../VS_IDE/CA2114--Method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|  
|[CA2115](../VS_IDE/CA2115--Call-GC.KeepAlive-when-using-native-resources.md)|Call GC.KeepAlive when using native resources|  
|[CA2116](../VS_IDE/CA2116--APTCA-methods-should-only-call-APTCA-methods.md)|APTCA methods should only call APTCA methods|  
|[CA2117](../VS_IDE/CA2117--APTCA-types-should-only-extend-APTCA-base-types.md)|APTCA types should only extend APTCA base types|  
|[CA2118](../VS_IDE/CA2118--Review-SuppressUnmanagedCodeSecurityAttribute-usage.md)|Review SuppressUnmanagedCodeSecurityAttribute usage|  
|[CA2119](../VS_IDE/CA2119--Seal-methods-that-satisfy-private-interfaces.md)|Seal methods that satisfy private interfaces|  
|[CA2120](../VS_IDE/CA2120--Secure-serialization-constructors.md)|Secure serialization constructors|  
|[CA2121](../VS_IDE/CA2121--Static-constructors-should-be-private.md)|Static constructors should be private|  
|[CA2122](../VS_IDE/CA2122--Do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|  
|[CA2123](../VS_IDE/CA2123--Override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|  
|[CA2124](../VS_IDE/CA2124--Wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|  
|[CA2126](../VS_IDE/CA2126--Type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|  
|[CA2130](../VS_IDE/CA2130--Security-critical-constants-should-be-transparent.md)|Security critical constants should be transparent|  
|[CA2131](../VS_IDE/CA2131--Security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|  
|[CA2132](../VS_IDE/CA2132--Default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|  
|[CA2133](../VS_IDE/CA2133--Delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|  
|[CA2134](../VS_IDE/CA2134--Methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|  
|[CA2135](../VS_IDE/CA2135--Level-2-assemblies-should-not-contain-LinkDemands.md)|Level 2 assemblies should not contain LinkDemands|  
|[CA2136](../VS_IDE/CA2136--Members-should-not-have-conflicting-transparency-annotations.md)|Members should not have conflicting transparency annotations|  
|[CA2137](../VS_IDE/CA2137--Transparent-methods-must-contain-only-verifiable-IL.md)|Transparent methods must contain only verifiable IL|  
|[CA2138](../VS_IDE/CA2138--Transparent-methods-must-not-call-methods-with-the-SuppressUnmanagedCodeSecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|  
|[CA2139](../VS_IDE/CA2139--Transparent-methods-may-not-use-the-HandleProcessCorruptingExceptions-attribute.md)|Transparent methods may not use the HandleProcessCorruptingExceptions attribute|  
|[CA2140](../VS_IDE/CA2140--Transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|  
|[CA2141](../VS_IDE/CA2141-Transparent-methods-must-not-satisfy-LinkDemands.md)|Transparent methods must not satisfy LinkDemands|  
|[CA2142](../VS_IDE/CA2142--Transparent-code-should-not-be-protected-with-LinkDemands.md)|Transparent code should not be protected with LinkDemands|  
|[CA2143](../VS_IDE/CA2143--Transparent-methods-should-not-use-security-demands.md)|Transparent methods should not use security demands|  
|[CA2144](../VS_IDE/CA2144--Transparent-code-should-not-load-assemblies-from-byte-arrays.md)|Transparent code should not load assemblies from byte arrays|  
|[CA2145](../VS_IDE/CA2145--Transparent-methods-should-not-be-decorated-with-the-SuppressUnmanagedCodeSecurityAttribute.md)|Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute|  
|[CA2146](../VS_IDE/CA2146--Types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|  
|[CA2147](../VS_IDE/CA2147--Transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|  
|[CA2149](../VS_IDE/CA2149--Transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|  
|[CA2210](../VS_IDE/CA2210--Assemblies-should-have-valid-strong-names.md)|Assemblies should have valid strong names|