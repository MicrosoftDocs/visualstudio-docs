---
title: "Managed Recommended Rules rule set for managed code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1d1160f8-4e51-4e70-99cd-82ad10ee7b32
caps.latest.revision: 10
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
# Managed Recommended Rules rule set for managed code
You can use the Microsoft Managed Recommended Rules rule set to focus on the most critical problems in your managed code, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set that you create for your projects.  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1001](../VS_IDE/CA1001--Types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|  
|[CA1009](../VS_IDE/CA1009--Declare-event-handlers-correctly.md)|Declare event handlers correctly|  
|[CA1016](../VS_IDE/CA1016--Mark-assemblies-with-AssemblyVersionAttribute.md)|Mark assemblies with AssemblyVersionAttribute|  
|[CA1033](../VS_IDE/CA1033--Interface-methods-should-be-callable-by-child-types.md)|Interface methods should be callable by child types|  
|[CA1049](../VS_IDE/CA1049--Types-that-own-native-resources-should-be-disposable.md)|Types that own native resources should be disposable|  
|[CA1060](../VS_IDE/CA1060--Move-P-Invokes-to-NativeMethods-class.md)|Move P/Invokes to NativeMethods class|  
|[CA1061](../VS_IDE/CA1061--Do-not-hide-base-class-methods.md)|Do not hide base class methods|  
|[CA1063](../VS_IDE/CA1063--Implement-IDisposable-correctly.md)|Implement IDisposable correctly|  
|[CA1065](../VS_IDE/CA1065--Do-not-raise-exceptions-in-unexpected-locations.md)|Do not raise exceptions in unexpected locations|  
|[CA1301](../VS_IDE/CA1301--Avoid-duplicate-accelerators.md)|Avoid duplicate accelerators|  
|[CA1400](../VS_IDE/CA1400--P-Invoke-entry-points-should-exist.md)|P/Invoke entry points should exist|  
|[CA1401](../VS_IDE/CA1401--P-Invokes-should-not-be-visible.md)|P/Invokes should not be visible|  
|[CA1403](../VS_IDE/CA1403--Auto-layout-types-should-not-be-COM-visible.md)|Auto layout types should not be COM visible|  
|[CA1404](../VS_IDE/CA1404--Call-GetLastError-immediately-after-P-Invoke.md)|Call GetLastError immediately after P/Invoke|  
|[CA1405](../VS_IDE/CA1405--COM-visible-type-base-types-should-be-COM-visible.md)|COM visible type base types should be COM visible|  
|[CA1410](../VS_IDE/CA1410--COM-registration-methods-should-be-matched.md)|COM registration methods should be matched|  
|[CA1415](../VS_IDE/CA1415--Declare-P-Invokes-correctly.md)|Declare P/Invokes correctly|  
|[CA1821](../VS_IDE/CA1821--Remove-empty-finalizers.md)|Remove empty finalizers|  
|[CA1900](../VS_IDE/CA1900--Value-type-fields-should-be-portable.md)|Value type fields should be portable|  
|[CA1901](../VS_IDE/CA1901--P-Invoke-declarations-should-be-portable.md)|P/Invoke declarations should be portable|  
|[CA2002](../VS_IDE/CA2002--Do-not-lock-on-objects-with-weak-identity.md)|Do not lock on objects with weak identity|  
|[CA2100](../VS_IDE/CA2100--Review-SQL-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|  
|[CA2101](../VS_IDE/CA2101--Specify-marshaling-for-P-Invoke-string-arguments.md)|Specify marshaling for P/Invoke string arguments|  
|[CA2108](../VS_IDE/CA2108--Review-declarative-security-on-value-types.md)|Review declarative security on value types|  
|[CA2111](../VS_IDE/CA2111--Pointers-should-not-be-visible.md)|Pointers should not be visible|  
|[CA2112](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md)|Secured types should not expose fields|  
|[CA2114](../VS_IDE/CA2114--Method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|  
|[CA2116](../VS_IDE/CA2116--APTCA-methods-should-only-call-APTCA-methods.md)|APTCA methods should only call APTCA methods|  
|[CA2117](../VS_IDE/CA2117--APTCA-types-should-only-extend-APTCA-base-types.md)|APTCA types should only extend APTCA base types|  
|[CA2122](../VS_IDE/CA2122--Do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|  
|[CA2123](../VS_IDE/CA2123--Override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|  
|[CA2124](../VS_IDE/CA2124--Wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|  
|[CA2126](../VS_IDE/CA2126--Type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|  
|[CA2131](../VS_IDE/CA2131--Security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|  
|[CA2132](../VS_IDE/CA2132--Default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|  
|[CA2133](../VS_IDE/CA2133--Delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|  
|[CA2134](../VS_IDE/CA2134--Methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|  
|[CA2137](../VS_IDE/CA2137--Transparent-methods-must-contain-only-verifiable-IL.md)|Transparent methods must contain only verifiable IL|  
|[CA2138](../VS_IDE/CA2138--Transparent-methods-must-not-call-methods-with-the-SuppressUnmanagedCodeSecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|  
|[CA2140](../VS_IDE/CA2140--Transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|  
|[CA2141](../VS_IDE/CA2141-Transparent-methods-must-not-satisfy-LinkDemands.md)|Transparent methods must not satisfy LinkDemands|  
|[CA2146](../VS_IDE/CA2146--Types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|  
|[CA2147](../VS_IDE/CA2147--Transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|  
|[CA2149](../VS_IDE/CA2149--Transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|  
|[CA2200](../VS_IDE/CA2200--Rethrow-to-preserve-stack-details.md)|Rethrow to preserve stack details|  
|[CA2202](../VS_IDE/CA2202--Do-not-dispose-objects-multiple-times.md)|Do not dispose objects multiple times|  
|[CA2207](../VS_IDE/CA2207--Initialize-value-type-static-fields-inline.md)|Initialize value type static fields inline|  
|[CA2212](../VS_IDE/CA2212--Do-not-mark-serviced-components-with-WebMethod.md)|Do not mark serviced components with WebMethod|  
|[CA2213](../VS_IDE/CA2213--Disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|  
|[CA2214](../VS_IDE/CA2214--Do-not-call-overridable-methods-in-constructors.md)|Do not call overridable methods in constructors|  
|[CA2216](../VS_IDE/CA2216--Disposable-types-should-declare-finalizer.md)|Disposable types should declare finalizer|  
|[CA2220](../VS_IDE/CA2220--Finalizers-should-call-base-class-finalizer.md)|Finalizers should call base class finalizer|  
|[CA2229](../VS_IDE/CA2229--Implement-serialization-constructors.md)|Implement serialization constructors|  
|[CA2231](../VS_IDE/CA2231--Overload-operator-equals-on-overriding-ValueType.Equals.md)|Overload operator equals on overriding ValueType.Equals|  
|[CA2232](../VS_IDE/CA2232--Mark-Windows-Forms-entry-points-with-STAThread.md)|Mark Windows Forms entry points with STAThread|  
|[CA2235](../VS_IDE/CA2235--Mark-all-non-serializable-fields.md)|Mark all non-serializable fields|  
|[CA2236](../VS_IDE/CA2236--Call-base-class-methods-on-ISerializable-types.md)|Call base class methods on ISerializable types|  
|[CA2237](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)|Mark ISerializable types with SerializableAttribute|  
|[CA2238](../VS_IDE/CA2238--Implement-serialization-methods-correctly.md)|Implement serialization methods correctly|  
|[CA2240](../VS_IDE/CA2240--Implement-ISerializable-correctly.md)|Implement ISerializable correctly|  
|[CA2241](../VS_IDE/CA2241--Provide-correct-arguments-to-formatting-methods.md)|Provide correct arguments to formatting methods|  
|[CA2242](../VS_IDE/CA2242--Test-for-NaN-correctly.md)|Test for NaN correctly|