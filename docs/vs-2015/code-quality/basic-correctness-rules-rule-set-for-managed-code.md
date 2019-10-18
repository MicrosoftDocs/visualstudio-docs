---
title: "Basic Correctness Rules rule set for managed code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
ms.assetid: 631f0daf-1d42-4c90-a7dc-1a6a9de64c93
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Basic Correctness Rules rule set for managed code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Basic Correctness Rules rule set focuses on logic errors and common mistakes in the usage of framework APIs. The Basic Correctness Rules include the rules in the Minimum Recommended Rules rule set. For more information, see [Managed Recommended Rules rule set for managed code](../code-quality/managed-recommended-rules-rule-set-for-managed-code.md) You should include this rule set to expand on the list of warnings that the minimum recommended rules report.

 The following table describes all the rules in the Microsoft Basic Correctness Rules rule set.

|Rule|Description|
|----------|-----------------|
|[CA1001](../code-quality/ca1001-types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|
|[CA1009](../code-quality/ca1009-declare-event-handlers-correctly.md)|Declare event handlers correctly|
|[CA1016](../code-quality/ca1016-mark-assemblies-with-assemblyversionattribute.md)|Mark assemblies with AssemblyVersionAttribute|
|[CA1033](../code-quality/ca1033-interface-methods-should-be-callable-by-child-types.md)|Interface methods should be callable by child types|
|[CA1049](../code-quality/ca1049-types-that-own-native-resources-should-be-disposable.md)|Types that own native resources should be disposable|
|[CA1060](../code-quality/ca1060-move-p-invokes-to-nativemethods-class.md)|Move P/Invokes to NativeMethods class|
|[CA1061](../code-quality/ca1061-do-not-hide-base-class-methods.md)|Do not hide base class methods|
|[CA1063](../code-quality/ca1063-implement-idisposable-correctly.md)|Implement IDisposable correctly|
|[CA1065](../code-quality/ca1065-do-not-raise-exceptions-in-unexpected-locations.md)|Do not raise exceptions in unexpected locations|
|[CA1301](../code-quality/ca1301-avoid-duplicate-accelerators.md)|Avoid duplicate accelerators|
|[CA1400](../code-quality/ca1400-p-invoke-entry-points-should-exist.md)|P/Invoke entry points should exist|
|[CA1401](../code-quality/ca1401-p-invokes-should-not-be-visible.md)|P/Invokes should not be visible|
|[CA1403](../code-quality/ca1403-auto-layout-types-should-not-be-com-visible.md)|Auto layout types should not be COM visible|
|[CA1404](../code-quality/ca1404-call-getlasterror-immediately-after-p-invoke.md)|Call GetLastError immediately after P/Invoke|
|[CA1405](../code-quality/ca1405-com-visible-type-base-types-should-be-com-visible.md)|COM visible type base types should be COM visible|
|[CA1410](../code-quality/ca1410-com-registration-methods-should-be-matched.md)|COM registration methods should be matched|
|[CA1415](../code-quality/ca1415-declare-p-invokes-correctly.md)|Declare P/Invokes correctly|
|[CA1821](../code-quality/ca1821-remove-empty-finalizers.md)|Remove empty finalizers|
|[CA1900](../code-quality/ca1900-value-type-fields-should-be-portable.md)|Value type fields should be portable|
|[CA1901](../code-quality/ca1901-p-invoke-declarations-should-be-portable.md)|P/Invoke declarations should be portable|
|[CA2002](../code-quality/ca2002-do-not-lock-on-objects-with-weak-identity.md)|Do not lock on objects with weak identity|
|[CA2100](../code-quality/ca2100-review-sql-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|
|[CA2101](../code-quality/ca2101-specify-marshaling-for-p-invoke-string-arguments.md)|Specify marshaling for P/Invoke string arguments|
|[CA2108](../code-quality/ca2108-review-declarative-security-on-value-types.md)|Review declarative security on value types|
|[CA2111](../code-quality/ca2111-pointers-should-not-be-visible.md)|Pointers should not be visible|
|[CA2112](../code-quality/ca2112-secured-types-should-not-expose-fields.md)|Secured types should not expose fields|
|[CA2114](../code-quality/ca2114-method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|
|[CA2116](../code-quality/ca2116-aptca-methods-should-only-call-aptca-methods.md)|APTCA methods should only call APTCA methods|
|[CA2117](../code-quality/ca2117-aptca-types-should-only-extend-aptca-base-types.md)|APTCA types should only extend APTCA base types|
|[CA2122](../code-quality/ca2122-do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|
|[CA2123](../code-quality/ca2123-override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|
|[CA2124](../code-quality/ca2124-wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|
|[CA2126](../code-quality/ca2126-type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|
|[CA2131](../code-quality/ca2131-security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|
|[CA2132](../code-quality/ca2132-default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|
|[CA2133](../code-quality/ca2133-delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|
|[CA2134](../code-quality/ca2134-methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|
|[CA2137](../code-quality/ca2137-transparent-methods-must-contain-only-verifiable-il.md)|Transparent methods must contain only verifiable IL|
|[CA2138](../code-quality/ca2138-transparent-methods-must-not-call-methods-with-the-suppressunmanagedcodesecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|
|[CA2140](../code-quality/ca2140-transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|
|[CA2141](../code-quality/ca2141-transparent-methods-must-not-satisfy-linkdemands.md)|Transparent methods must not satisfy LinkDemands|
|[CA2146](../code-quality/ca2146-types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|
|[CA2147](../code-quality/ca2147-transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|
|[CA2149](../code-quality/ca2149-transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|
|[CA2200](../code-quality/ca2200-rethrow-to-preserve-stack-details.md)|Rethrow to preserve stack details|
|[CA2202](../code-quality/ca2202-do-not-dispose-objects-multiple-times.md)|Do not dispose objects multiple times|
|[CA2207](../code-quality/ca2207-initialize-value-type-static-fields-inline.md)|Initialize value type static fields inline|
|[CA2212](../code-quality/ca2212-do-not-mark-serviced-components-with-webmethod.md)|Do not mark serviced components with WebMethod|
|[CA2213](../code-quality/ca2213-disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|
|[CA2214](../code-quality/ca2214-do-not-call-overridable-methods-in-constructors.md)|Do not call overridable methods in constructors|
|[CA2216](../code-quality/ca2216-disposable-types-should-declare-finalizer.md)|Disposable types should declare finalizer|
|[CA2220](../code-quality/ca2220-finalizers-should-call-base-class-finalizer.md)|Finalizers should call base class finalizer|
|[CA2229](../code-quality/ca2229-implement-serialization-constructors.md)|Implement serialization constructors|
|[CA2231](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)|Overload operator equals on overriding ValueType.Equals|
|[CA2232](../code-quality/ca2232-mark-windows-forms-entry-points-with-stathread.md)|Mark Windows Forms entry points with STAThread|
|[CA2235](../code-quality/ca2235-mark-all-non-serializable-fields.md)|Mark all non-serializable fields|
|[CA2236](../code-quality/ca2236-call-base-class-methods-on-iserializable-types.md)|Call base class methods on ISerializable types|
|[CA2237](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md)|Mark ISerializable types with SerializableAttribute|
|[CA2238](../code-quality/ca2238-implement-serialization-methods-correctly.md)|Implement serialization methods correctly|
|[CA2240](../code-quality/ca2240-implement-iserializable-correctly.md)|Implement ISerializable correctly|
|[CA2241](../code-quality/ca2241-provide-correct-arguments-to-formatting-methods.md)|Provide correct arguments to formatting methods|
|[CA2242](../code-quality/ca2242-test-for-nan-correctly.md)|Test for NaN correctly|
|[CA1008](../code-quality/ca1008-enums-should-have-zero-value.md)|Enums should have zero value|
|[CA1013](../code-quality/ca1013-overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|
|[CA1303](../code-quality/ca1303-do-not-pass-literals-as-localized-parameters.md)|Do not pass literals as localized parameters|
|[CA1308](../code-quality/ca1308-normalize-strings-to-uppercase.md)|Normalize strings to uppercase|
|[CA1806](../code-quality/ca1806-do-not-ignore-method-results.md)|Do not ignore method results|
|[CA1816](../code-quality/ca1816-call-gc-suppressfinalize-correctly.md)|Call GC.SuppressFinalize correctly|
|[CA1819](../code-quality/ca1819-properties-should-not-return-arrays.md)|Properties should not return arrays|
|[CA1820](../code-quality/ca1820-test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|
|[CA1903](../code-quality/ca1903-use-only-api-from-targeted-framework.md)|Use only API from targeted framework|
|[CA2004](../code-quality/ca2004-remove-calls-to-gc-keepalive.md)|Remove calls to GC.KeepAlive|
|[CA2006](../code-quality/ca2006-use-safehandle-to-encapsulate-native-resources.md)|Use SafeHandle to encapsulate native resources|
|[CA2102](../code-quality/ca2102-catch-non-clscompliant-exceptions-in-general-handlers.md)|Catch non-CLSCompliant exceptions in general handlers|
|[CA2104](../code-quality/ca2104-do-not-declare-read-only-mutable-reference-types.md)|Do not declare read only mutable reference types|
|[CA2105](../code-quality/ca2105-array-fields-should-not-be-read-only.md)|Array fields should not be read only|
|[CA2106](../code-quality/ca2106-secure-asserts.md)|Secure asserts|
|[CA2115](../code-quality/ca2115-call-gc-keepalive-when-using-native-resources.md)|Call GC.KeepAlive when using native resources|
|[CA2119](../code-quality/ca2119-seal-methods-that-satisfy-private-interfaces.md)|Seal methods that satisfy private interfaces|
|[CA2120](../code-quality/ca2120-secure-serialization-constructors.md)|Secure serialization constructors|
|[CA2121](../code-quality/ca2121-static-constructors-should-be-private.md)|Static constructors should be private|
|[CA2130](../code-quality/ca2130-security-critical-constants-should-be-transparent.md)|Security critical constants should be transparent|
|[CA2205](../code-quality/ca2205-use-managed-equivalents-of-win32-api.md)|Use managed equivalents of Win32 API|
|[CA2215](../code-quality/ca2215-dispose-methods-should-call-base-class-dispose.md)|Dispose methods should call base class dispose|
|[CA2221](../code-quality/ca2221-finalizers-should-be-protected.md)|Finalizers should be protected|
|[CA2222](../code-quality/ca2222-do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|
|[CA2223](../code-quality/ca2223-members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|
|[CA2224](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|
|[CA2226](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|
|[CA2227](../code-quality/ca2227-collection-properties-should-be-read-only.md)|Collection properties should be read only|
|[CA2239](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|
