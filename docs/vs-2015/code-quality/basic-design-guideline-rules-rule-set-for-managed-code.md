---
title: "Basic Design Guideline Rules rule set for managed code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
ms.assetid: 7eb384f5-f961-400b-b151-115d92addc6a
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Basic Design Guideline Rules rule set for managed code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the Microsoft Basic Design Guideline Rules rule set to focus on making your code easier to understand and use. You should include this rule set if your project includes library code or if you want to enforce best practices for code that is easy to maintain.

 The Basic Design Guideline Rules include all the rules in the Microsoft Minimum Recommeded Rules rule set. For a list of the minimum rules, see [Managed Recommended Rules rule set for managed code](../code-quality/managed-recommended-rules-rule-set-for-managed-code.md).

 The following table describes all of the rules in the Microsoft Basic Design Guideline Rules rule set.

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
|[CA1000](../code-quality/ca1000-do-not-declare-static-members-on-generic-types.md)|Do not declare static members on generic types|
|[CA1002](../code-quality/ca1002-do-not-expose-generic-lists.md)|Do not expose generic lists|
|[CA1003](../code-quality/ca1003-use-generic-event-handler-instances.md)|Use generic event handler instances|
|[CA1004](../code-quality/ca1004-generic-methods-should-provide-type-parameter.md)|Generic methods should provide type parameter|
|[CA1005](../code-quality/ca1005-avoid-excessive-parameters-on-generic-types.md)|Avoid excessive parameters on generic types|
|[CA1006](../code-quality/ca1006-do-not-nest-generic-types-in-member-signatures.md)|Do not nest generic types in member signatures|
|[CA1007](../code-quality/ca1007-use-generics-where-appropriate.md)|Use generics where appropriate|
|[CA1008](../code-quality/ca1008-enums-should-have-zero-value.md)|Enums should have zero value|
|[CA1010](../code-quality/ca1010-collections-should-implement-generic-interface.md)|Collections should implement generic interface|
|[CA1011](../code-quality/ca1011-consider-passing-base-types-as-parameters.md)|Consider passing base types as parameters|
|[CA1012](../code-quality/ca1012-abstract-types-should-not-have-constructors.md)|Abstract types should not have constructors|
|[CA1013](../code-quality/ca1013-overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|
|[CA1014](../code-quality/ca1014-mark-assemblies-with-clscompliantattribute.md)|Mark assemblies with CLSCompliantAttribute|
|[CA1017](../code-quality/ca1017-mark-assemblies-with-comvisibleattribute.md)|Mark assemblies with ComVisibleAttribute|
|[CA1018](../code-quality/ca1018-mark-attributes-with-attributeusageattribute.md)|Mark attributes with AttributeUsageAttribute|
|[CA1019](../code-quality/ca1019-define-accessors-for-attribute-arguments.md)|Define accessors for attribute arguments|
|[CA1023](../code-quality/ca1023-indexers-should-not-be-multidimensional.md)|Indexers should not be multidimensional|
|[CA1024](../code-quality/ca1024-use-properties-where-appropriate.md)|Use properties where appropriate|
|[CA1025](../code-quality/ca1025-replace-repetitive-arguments-with-params-array.md)|Replace repetitive arguments with params array|
|[CA1026](../code-quality/ca1026-default-parameters-should-not-be-used.md)|Default parameters should not be used|
|[CA1027](../code-quality/ca1027-mark-enums-with-flagsattribute.md)|Mark enums with FlagsAttribute|
|[CA1028](../code-quality/ca1028-enum-storage-should-be-int32.md)|Enum storage should be Int32|
|[CA1030](../code-quality/ca1030-use-events-where-appropriate.md)|Use events where appropriate|
|[CA1031](../code-quality/ca1031-do-not-catch-general-exception-types.md)|Do not catch general exception types|
|[CA1032](../code-quality/ca1032-implement-standard-exception-constructors.md)|Implement standard exception constructors|
|[CA1034](../code-quality/ca1034-nested-types-should-not-be-visible.md)|Nested types should not be visible|
|[CA1035](../code-quality/ca1035-icollection-implementations-have-strongly-typed-members.md)|ICollection implementations have strongly typed members|
|[CA1036](../code-quality/ca1036-override-methods-on-comparable-types.md)|Override methods on comparable types|
|[CA1038](../code-quality/ca1038-enumerators-should-be-strongly-typed.md)|Enumerators should be strongly typed|
|[CA1039](../code-quality/ca1039-lists-are-strongly-typed.md)|Lists are strongly typed|
|[CA1041](../code-quality/ca1041-provide-obsoleteattribute-message.md)|Provide ObsoleteAttribute message|
|[CA1043](../code-quality/ca1043-use-integral-or-string-argument-for-indexers.md)|Use integral or string argument for indexers|
|[CA1044](../code-quality/ca1044-properties-should-not-be-write-only.md)|Properties should not be write only|
|[CA1046](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)|Do not overload operator equals on reference types|
|[CA1047](../code-quality/ca1047-do-not-declare-protected-members-in-sealed-types.md)|Do not declare protected members in sealed types|
|[CA1048](../code-quality/ca1048-do-not-declare-virtual-members-in-sealed-types.md)|Do not declare virtual members in sealed types|
|[CA1050](../code-quality/ca1050-declare-types-in-namespaces.md)|Declare types in namespaces|
|[CA1051](../code-quality/ca1051-do-not-declare-visible-instance-fields.md)|Do not declare visible instance fields|
|[CA1052](../code-quality/ca1052-static-holder-types-should-be-sealed.md)|Static holder types should be sealed|
|[CA1053](../code-quality/ca1053-static-holder-types-should-not-have-constructors.md)|Static holder types should not have constructors|
|[CA1054](../code-quality/ca1054-uri-parameters-should-not-be-strings.md)|URI parameters should not be strings|
|[CA1055](../code-quality/ca1055-uri-return-values-should-not-be-strings.md)|URI return values should not be strings|
|[CA1056](../code-quality/ca1056-uri-properties-should-not-be-strings.md)|URI properties should not be strings|
|[CA1057](../code-quality/ca1057-string-uri-overloads-call-system-uri-overloads.md)|String URI overloads call System.Uri overloads|
|[CA1058](../code-quality/ca1058-types-should-not-extend-certain-base-types.md)|Types should not extend certain base types|
|[CA1059](../code-quality/ca1059-members-should-not-expose-certain-concrete-types.md)|Members should not expose certain concrete types|
|[CA1064](../code-quality/ca1064-exceptions-should-be-public.md)|Exceptions should be public|
|[CA1500](../code-quality/ca1500-variable-names-should-not-match-field-names.md)|Variable names should not match field names|
|[CA1502](../code-quality/ca1502-avoid-excessive-complexity.md)|Avoid excessive complexity|
|[CA1708](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)|Identifiers should differ by more than case|
|[CA1716](../code-quality/ca1716-identifiers-should-not-match-keywords.md)|Identifiers should not match keywords|
|[CA1801](../code-quality/ca1801-review-unused-parameters.md)|Review unused parameters|
|[CA1804](../code-quality/ca1804-remove-unused-locals.md)|Remove unused locals|
|[CA1809](../code-quality/ca1809-avoid-excessive-locals.md)|Avoid excessive locals|
|[CA1810](../code-quality/ca1810-initialize-reference-type-static-fields-inline.md)|Initialize reference type static fields inline|
|[CA1811](../code-quality/ca1811-avoid-uncalled-private-code.md)|Avoid uncalled private code|
|[CA1812](../code-quality/ca1812-avoid-uninstantiated-internal-classes.md)|Avoid uninstantiated internal classes|
|[CA1813](../code-quality/ca1813-avoid-unsealed-attributes.md)|Avoid unsealed attributes|
|[CA1814](../code-quality/ca1814-prefer-jagged-arrays-over-multidimensional.md)|Prefer jagged arrays over multidimensional|
|[CA1815](../code-quality/ca1815-override-equals-and-operator-equals-on-value-types.md)|Override equals and operator equals on value types|
|[CA1819](../code-quality/ca1819-properties-should-not-return-arrays.md)|Properties should not return arrays|
|[CA1820](../code-quality/ca1820-test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|
|[CA1822](../code-quality/ca1822-mark-members-as-static.md)|Mark members as static|
|[CA1823](../code-quality/ca1823-avoid-unused-private-fields.md)|Avoid unused private fields|
|[CA2201](../code-quality/ca2201-do-not-raise-reserved-exception-types.md)|Do not raise reserved exception types|
|[CA2205](../code-quality/ca2205-use-managed-equivalents-of-win32-api.md)|Use managed equivalents of Win32 API|
|[CA2208](../code-quality/ca2208-instantiate-argument-exceptions-correctly.md)|Instantiate argument exceptions correctly|
|[CA2211](../code-quality/ca2211-non-constant-fields-should-not-be-visible.md)|Non-constant fields should not be visible|
|[CA2217](../code-quality/ca2217-do-not-mark-enums-with-flagsattribute.md)|Do not mark enums with FlagsAttribute|
|[CA2219](../code-quality/ca2219-do-not-raise-exceptions-in-exception-clauses.md)|Do not raise exceptions in exception clauses|
|[CA2221](../code-quality/ca2221-finalizers-should-be-protected.md)|Finalizers should be protected|
|[CA2222](../code-quality/ca2222-do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|
|[CA2223](../code-quality/ca2223-members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|
|[CA2224](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|
|[CA2225](../code-quality/ca2225-operator-overloads-have-named-alternates.md)|Operator overloads have named alternates|
|[CA2226](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|
|[CA2227](../code-quality/ca2227-collection-properties-should-be-read-only.md)|Collection properties should be read only|
|[CA2230](../code-quality/ca2230-use-params-for-variable-arguments.md)|Use params for variable arguments|
|[CA2234](../code-quality/ca2234-pass-system-uri-objects-instead-of-strings.md)|Pass System.Uri objects instead of strings|
|[CA2239](../code-quality/ca2239-provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|
