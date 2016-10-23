---
title: "Extended Correctness Rules rule set for managed code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5b181f5b-6c7a-4e46-a783-360e1da427a0
caps.latest.revision: 11
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
# Extended Correctness Rules rule set for managed code
The Microsoft Extended Correctness Rules rule set maximizes the logic and framework usage errors that are reported by code analysis. Extra emphasis is placed on specific scenarios such as COM interoperability and mobile applications. You should consider including this rule set if one of these scenarios applies to your project or to find additional problems in your project.  
  
 The Microsoft Extended Correctness Rules rule set includes the rules that are in the Microsoft Basic Correctness Rules rule set. The Basic Correctness Rules include the rules that are in the Microsoft Minimum Recommended Rules rule set. For more information see [Basic Correctness Rules rule set for managed code](../VS_IDE/Basic-Correctness-Rules-rule-set-for-managed-code.md) and [Managed Recommended Rules rule set for managed code](../VS_IDE/Managed-Recommended-Rules-rule-set-for-managed-code.md)  
  
 The following table describes all of the rules in the Microsoft Extended Correctness Rules rule set.  
  
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
|[CA1008](../VS_IDE/CA1008--Enums-should-have-zero-value.md)|Enums should have zero value|  
|[CA1013](../VS_IDE/CA1013--Overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|  
|[CA1303](../VS_IDE/CA1303--Do-not-pass-literals-as-localized-parameters.md)|Do not pass literals as localized parameters|  
|[CA1308](../VS_IDE/CA1308--Normalize-strings-to-uppercase.md)|Normalize strings to uppercase|  
|[CA1806](../VS_IDE/CA1806--Do-not-ignore-method-results.md)|Do not ignore method results|  
|[CA1816](../VS_IDE/CA1816--Call-GC.SuppressFinalize-correctly.md)|Call GC.SuppressFinalize correctly|  
|[CA1819](../VS_IDE/CA1819--Properties-should-not-return-arrays.md)|Properties should not return arrays|  
|[CA1820](../VS_IDE/CA1820--Test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|  
|[CA1903](../VS_IDE/CA1903--Use-only-API-from-targeted-framework.md)|Use only API from targeted framework|  
|[CA2004](../VS_IDE/CA2004--Remove-calls-to-GC.KeepAlive.md)|Remove calls to GC.KeepAlive|  
|[CA2006](../VS_IDE/CA2006--Use-SafeHandle-to-encapsulate-native-resources.md)|Use SafeHandle to encapsulate native resources|  
|[CA2102](../VS_IDE/CA2102--Catch-non-CLSCompliant-exceptions-in-general-handlers.md)|Catch non-CLSCompliant exceptions in general handlers|  
|[CA2104](../VS_IDE/CA2104--Do-not-declare-read-only-mutable-reference-types.md)|Do not declare read only mutable reference types|  
|[CA2105](../VS_IDE/CA2105--Array-fields-should-not-be-read-only.md)|Array fields should not be read only|  
|[CA2106](../VS_IDE/CA2106--Secure-asserts.md)|Secure asserts|  
|[CA2115](../VS_IDE/CA2115--Call-GC.KeepAlive-when-using-native-resources.md)|Call GC.KeepAlive when using native resources|  
|[CA2119](../VS_IDE/CA2119--Seal-methods-that-satisfy-private-interfaces.md)|Seal methods that satisfy private interfaces|  
|[CA2120](../VS_IDE/CA2120--Secure-serialization-constructors.md)|Secure serialization constructors|  
|[CA2121](../VS_IDE/CA2121--Static-constructors-should-be-private.md)|Static constructors should be private|  
|[CA2130](../VS_IDE/CA2130--Security-critical-constants-should-be-transparent.md)|Security critical constants should be transparent|  
|[CA2205](../VS_IDE/CA2205--Use-managed-equivalents-of-Win32-API.md)|Use managed equivalents of Win32 API|  
|[CA2215](../VS_IDE/CA2215--Dispose-methods-should-call-base-class-dispose.md)|Dispose methods should call base class dispose|  
|[CA2221](../VS_IDE/CA2221--Finalizers-should-be-protected.md)|Finalizers should be protected|  
|[CA2222](../VS_IDE/CA2222--Do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|  
|[CA2223](../VS_IDE/CA2223--Members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|  
|[CA2224](../VS_IDE/CA2224--Override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|  
|[CA2226](../VS_IDE/CA2226--Operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|  
|[CA2227](../VS_IDE/CA2227--Collection-properties-should-be-read-only.md)|Collection properties should be read only|  
|[CA2239](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|  
|[CA1032](../VS_IDE/CA1032--Implement-standard-exception-constructors.md)|Implement standard exception constructors|  
|[CA1054](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)|URI parameters should not be strings|  
|[CA1055](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)|URI return values should not be strings|  
|[CA1056](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)|URI properties should not be strings|  
|[CA1057](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)|String URI overloads call System.Uri overloads|  
|[CA1402](../VS_IDE/CA1402--Avoid-overloads-in-COM-visible-interfaces.md)|Avoid overloads in COM visible interfaces|  
|[CA1406](../VS_IDE/CA1406--Avoid-Int64-arguments-for-Visual-Basic-6-clients.md)|Avoid Int64 arguments for Visual Basic 6 clients|  
|[CA1407](../VS_IDE/CA1407--Avoid-static-members-in-COM-visible-types.md)|Avoid static members in COM visible types|  
|[CA1408](../VS_IDE/CA1408--Do-not-use-AutoDual-ClassInterfaceType.md)|Do not use AutoDual ClassInterfaceType|  
|[CA1409](../VS_IDE/CA1409--Com-visible-types-should-be-creatable.md)|Com visible types should be creatable|  
|[CA1411](../VS_IDE/CA1411--COM-registration-methods-should-not-be-visible.md)|COM registration methods should not be visible|  
|[CA1412](../VS_IDE/CA1412--Mark-ComSource-Interfaces-as-IDispatch.md)|Mark ComSource Interfaces as IDispatch|  
|[CA1413](../VS_IDE/CA1413--Avoid-non-public-fields-in-COM-visible-value-types.md)|Avoid non-public fields in COM visible value types|  
|[CA1414](../VS_IDE/CA1414--Mark-boolean-P-Invoke-arguments-with-MarshalAs.md)|Mark boolean P/Invoke arguments with MarshalAs|  
|[CA1600](../VS_IDE/CA1600--Do-not-use-idle-process-priority.md)|Do not use idle process priority|  
|[CA1601](../VS_IDE/CA1601--Do-not-use-timers-that-prevent-power-state-changes.md)|Do not use timers that prevent power state changes|  
|[CA1824](../VS_IDE/CA1824--Mark-assemblies-with-NeutralResourcesLanguageAttribute.md)|Mark assemblies with NeutralResourcesLanguageAttribute|  
|[CA2001](../VS_IDE/CA2001--Avoid-calling-problematic-methods.md)|Avoid calling problematic methods|  
|[CA2003](../VS_IDE/CA2003--Do-not-treat-fibers-as-threads.md)|Do not treat fibers as threads|  
|[CA2135](../VS_IDE/CA2135--Level-2-assemblies-should-not-contain-LinkDemands.md)|Level 2 assemblies should not contain LinkDemands|  
|[CA2136](../VS_IDE/CA2136--Members-should-not-have-conflicting-transparency-annotations.md)|Members should not have conflicting transparency annotations|  
|[CA2139](../VS_IDE/CA2139--Transparent-methods-may-not-use-the-HandleProcessCorruptingExceptions-attribute.md)|Transparent methods may not use the HandleProcessCorruptingExceptions attribute|  
|[CA2142](../VS_IDE/CA2142--Transparent-code-should-not-be-protected-with-LinkDemands.md)|Transparent code should not be protected with LinkDemands|  
|[CA2143](../VS_IDE/CA2143--Transparent-methods-should-not-use-security-demands.md)|Transparent methods should not use security demands|  
|[CA2144](../VS_IDE/CA2144--Transparent-code-should-not-load-assemblies-from-byte-arrays.md)|Transparent code should not load assemblies from byte arrays|  
|[CA2145](../VS_IDE/CA2145--Transparent-methods-should-not-be-decorated-with-the-SuppressUnmanagedCodeSecurityAttribute.md)|Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute|  
|[CA2204](../VS_IDE/CA2204--Literals-should-be-spelled-correctly.md)|Literals should be spelled correctly|  
|[CA2211](../VS_IDE/CA2211--Non-constant-fields-should-not-be-visible.md)|Non-constant fields should not be visible|  
|[CA2217](../VS_IDE/CA2217--Do-not-mark-enums-with-FlagsAttribute.md)|Do not mark enums with FlagsAttribute|  
|[CA2218](../VS_IDE/CA2218--Override-GetHashCode-on-overriding-Equals.md)|Override GetHashCode on overriding Equals|  
|[CA2219](../VS_IDE/CA2219--Do-not-raise-exceptions-in-exception-clauses.md)|Do not raise exceptions in exception clauses|  
|[CA2225](../VS_IDE/CA2225--Operator-overloads-have-named-alternates.md)|Operator overloads have named alternates|  
|[CA2228](../VS_IDE/CA2228--Do-not-ship-unreleased-resource-formats.md)|Do not ship unreleased resource formats|  
|[CA2230](../VS_IDE/CA2230--Use-params-for-variable-arguments.md)|Use params for variable arguments|  
|[CA2233](../VS_IDE/CA2233--Operations-should-not-overflow.md)|Operations should not overflow|  
|[CA2234](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)|Pass System.Uri objects instead of strings|  
|[CA2243](../VS_IDE/CA2243--Attribute-string-literals-should-parse-correctly.md)|Attribute string literals should parse correctly|