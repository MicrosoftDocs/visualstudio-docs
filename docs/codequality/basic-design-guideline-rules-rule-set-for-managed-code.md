---
title: "Basic Design Guideline Rules rule set for managed code"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7eb384f5-f961-400b-b151-115d92addc6a
caps.latest.revision: 11
ms.author: "susanno"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Basic Design Guideline Rules rule set for managed code
You can use the Microsoft Basic Design Guideline Rules rule set to focus on making your code easier to understand and use. You should include this rule set if your project includes library code or if you want to enforce best practices for code that is easy to maintain.  
  
 The Basic Design Guideline Rules include all the rules in the Microsoft Minimum Recommeded Rules rule set. For a list of the minimum rules, see [Managed Recommended Rules rule set for managed code](../codequality/managed-recommended-rules-rule-set-for-managed-code.md).  
  
 The following table describes all of the rules in the Microsoft Basic Design Guideline Rules rule set.  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1001](../codequality/ca1001--types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|  
|[CA1009](../codequality/ca1009--declare-event-handlers-correctly.md)|Declare event handlers correctly|  
|[CA1016](../codequality/ca1016--mark-assemblies-with-assemblyversionattribute.md)|Mark assemblies with AssemblyVersionAttribute|  
|[CA1033](../codequality/ca1033--interface-methods-should-be-callable-by-child-types.md)|Interface methods should be callable by child types|  
|[CA1049](../codequality/ca1049--types-that-own-native-resources-should-be-disposable.md)|Types that own native resources should be disposable|  
|[CA1060](../codequality/ca1060--move-p-invokes-to-nativemethods-class.md)|Move P/Invokes to NativeMethods class|  
|[CA1061](../codequality/ca1061--do-not-hide-base-class-methods.md)|Do not hide base class methods|  
|[CA1063](../codequality/ca1063--implement-idisposable-correctly.md)|Implement IDisposable correctly|  
|[CA1065](../codequality/ca1065--do-not-raise-exceptions-in-unexpected-locations.md)|Do not raise exceptions in unexpected locations|  
|[CA1301](../codequality/ca1301--avoid-duplicate-accelerators.md)|Avoid duplicate accelerators|  
|[CA1400](../codequality/ca1400--p-invoke-entry-points-should-exist.md)|P/Invoke entry points should exist|  
|[CA1401](../codequality/ca1401--p-invokes-should-not-be-visible.md)|P/Invokes should not be visible|  
|[CA1403](../codequality/ca1403--auto-layout-types-should-not-be-com-visible.md)|Auto layout types should not be COM visible|  
|[CA1404](../codequality/ca1404--call-getlasterror-immediately-after-p-invoke.md)|Call GetLastError immediately after P/Invoke|  
|[CA1405](../codequality/ca1405--com-visible-type-base-types-should-be-com-visible.md)|COM visible type base types should be COM visible|  
|[CA1410](../codequality/ca1410--com-registration-methods-should-be-matched.md)|COM registration methods should be matched|  
|[CA1415](../codequality/ca1415--declare-p-invokes-correctly.md)|Declare P/Invokes correctly|  
|[CA1821](../codequality/ca1821--remove-empty-finalizers.md)|Remove empty finalizers|  
|[CA1900](../codequality/ca1900--value-type-fields-should-be-portable.md)|Value type fields should be portable|  
|[CA1901](../codequality/ca1901--p-invoke-declarations-should-be-portable.md)|P/Invoke declarations should be portable|  
|[CA2002](../codequality/ca2002--do-not-lock-on-objects-with-weak-identity.md)|Do not lock on objects with weak identity|  
|[CA2100](../codequality/ca2100--review-sql-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|  
|[CA2101](../codequality/ca2101--specify-marshaling-for-p-invoke-string-arguments.md)|Specify marshaling for P/Invoke string arguments|  
|[CA2108](../codequality/ca2108--review-declarative-security-on-value-types.md)|Review declarative security on value types|  
|[CA2111](../codequality/ca2111--pointers-should-not-be-visible.md)|Pointers should not be visible|  
|[CA2112](../codequality/ca2112--secured-types-should-not-expose-fields.md)|Secured types should not expose fields|  
|[CA2114](../codequality/ca2114--method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|  
|[CA2116](../codequality/ca2116--aptca-methods-should-only-call-aptca-methods.md)|APTCA methods should only call APTCA methods|  
|[CA2117](../codequality/ca2117--aptca-types-should-only-extend-aptca-base-types.md)|APTCA types should only extend APTCA base types|  
|[CA2122](../codequality/ca2122--do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|  
|[CA2123](../codequality/ca2123--override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|  
|[CA2124](../codequality/ca2124--wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|  
|[CA2126](../codequality/ca2126--type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|  
|[CA2131](../codequality/ca2131--security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|  
|[CA2132](../codequality/ca2132--default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|  
|[CA2133](../codequality/ca2133--delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|  
|[CA2134](../codequality/ca2134--methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|  
|[CA2137](../codequality/ca2137--transparent-methods-must-contain-only-verifiable-il.md)|Transparent methods must contain only verifiable IL|  
|[CA2138](../codequality/ca2138--transparent-methods-must-not-call-methods-with-the-suppressunmanagedcodesecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|  
|[CA2140](../codequality/ca2140--transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|  
|[CA2141](../codequality/ca2141-transparent-methods-must-not-satisfy-linkdemands.md)|Transparent methods must not satisfy LinkDemands|  
|[CA2146](../codequality/ca2146--types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|  
|[CA2147](../codequality/ca2147--transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|  
|[CA2149](../codequality/ca2149--transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|  
|[CA2200](../codequality/ca2200--rethrow-to-preserve-stack-details.md)|Rethrow to preserve stack details|  
|[CA2202](../codequality/ca2202--do-not-dispose-objects-multiple-times.md)|Do not dispose objects multiple times|  
|[CA2207](../codequality/ca2207--initialize-value-type-static-fields-inline.md)|Initialize value type static fields inline|  
|[CA2212](../codequality/ca2212--do-not-mark-serviced-components-with-webmethod.md)|Do not mark serviced components with WebMethod|  
|[CA2213](../codequality/ca2213--disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|  
|[CA2214](../codequality/ca2214--do-not-call-overridable-methods-in-constructors.md)|Do not call overridable methods in constructors|  
|[CA2216](../codequality/ca2216--disposable-types-should-declare-finalizer.md)|Disposable types should declare finalizer|  
|[CA2220](../codequality/ca2220--finalizers-should-call-base-class-finalizer.md)|Finalizers should call base class finalizer|  
|[CA2229](../codequality/ca2229--implement-serialization-constructors.md)|Implement serialization constructors|  
|[CA2231](../codequality/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)|Overload operator equals on overriding ValueType.Equals|  
|[CA2232](../codequality/ca2232--mark-windows-forms-entry-points-with-stathread.md)|Mark Windows Forms entry points with STAThread|  
|[CA2235](../codequality/ca2235--mark-all-non-serializable-fields.md)|Mark all non-serializable fields|  
|[CA2236](../codequality/ca2236--call-base-class-methods-on-iserializable-types.md)|Call base class methods on ISerializable types|  
|[CA2237](../codequality/ca2237--mark-iserializable-types-with-serializableattribute.md)|Mark ISerializable types with SerializableAttribute|  
|[CA2238](../codequality/ca2238--implement-serialization-methods-correctly.md)|Implement serialization methods correctly|  
|[CA2240](../codequality/ca2240--implement-iserializable-correctly.md)|Implement ISerializable correctly|  
|[CA2241](../codequality/ca2241--provide-correct-arguments-to-formatting-methods.md)|Provide correct arguments to formatting methods|  
|[CA2242](../codequality/ca2242--test-for-nan-correctly.md)|Test for NaN correctly|  
|[CA1000](../codequality/ca1000--do-not-declare-static-members-on-generic-types.md)|Do not declare static members on generic types|  
|[CA1002](../codequality/ca1002--do-not-expose-generic-lists.md)|Do not expose generic lists|  
|[CA1003](../codequality/ca1003--use-generic-event-handler-instances.md)|Use generic event handler instances|  
|[CA1004](../codequality/ca1004--generic-methods-should-provide-type-parameter.md)|Generic methods should provide type parameter|  
|[CA1005](../codequality/ca1005--avoid-excessive-parameters-on-generic-types.md)|Avoid excessive parameters on generic types|  
|[CA1006](../codequality/ca1006--do-not-nest-generic-types-in-member-signatures.md)|Do not nest generic types in member signatures|  
|[CA1007](../codequality/ca1007--use-generics-where-appropriate.md)|Use generics where appropriate|  
|[CA1008](../codequality/ca1008--enums-should-have-zero-value.md)|Enums should have zero value|  
|[CA1010](../codequality/ca1010--collections-should-implement-generic-interface.md)|Collections should implement generic interface|  
|[CA1011](../codequality/ca1011--consider-passing-base-types-as-parameters.md)|Consider passing base types as parameters|  
|[CA1012](../codequality/ca1012--abstract-types-should-not-have-constructors.md)|Abstract types should not have constructors|  
|[CA1013](../codequality/ca1013--overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|  
|[CA1014](../codequality/ca1014--mark-assemblies-with-clscompliantattribute.md)|Mark assemblies with CLSCompliantAttribute|  
|[CA1017](../codequality/ca1017--mark-assemblies-with-comvisibleattribute.md)|Mark assemblies with ComVisibleAttribute|  
|[CA1018](../codequality/ca1018--mark-attributes-with-attributeusageattribute.md)|Mark attributes with AttributeUsageAttribute|  
|[CA1019](../codequality/ca1019--define-accessors-for-attribute-arguments.md)|Define accessors for attribute arguments|  
|[CA1023](../codequality/ca1023--indexers-should-not-be-multidimensional.md)|Indexers should not be multidimensional|  
|[CA1024](../codequality/ca1024--use-properties-where-appropriate.md)|Use properties where appropriate|  
|[CA1025](../codequality/ca1025--replace-repetitive-arguments-with-params-array.md)|Replace repetitive arguments with params array|  
|[CA1026](../codequality/ca1026--default-parameters-should-not-be-used.md)|Default parameters should not be used|  
|[CA1027](../codequality/ca1027--mark-enums-with-flagsattribute.md)|Mark enums with FlagsAttribute|  
|[CA1028](../codequality/ca1028--enum-storage-should-be-int32.md)|Enum storage should be Int32|  
|[CA1030](../codequality/ca1030--use-events-where-appropriate.md)|Use events where appropriate|  
|[CA1031](../codequality/ca1031--do-not-catch-general-exception-types.md)|Do not catch general exception types|  
|[CA1032](../codequality/ca1032--implement-standard-exception-constructors.md)|Implement standard exception constructors|  
|[CA1034](../codequality/ca1034--nested-types-should-not-be-visible.md)|Nested types should not be visible|  
|[CA1035](../codequality/ca1035--icollection-implementations-have-strongly-typed-members.md)|ICollection implementations have strongly typed members|  
|[CA1036](../codequality/ca1036--override-methods-on-comparable-types.md)|Override methods on comparable types|  
|[CA1038](../codequality/ca1038--enumerators-should-be-strongly-typed.md)|Enumerators should be strongly typed|  
|[CA1039](../codequality/ca1039--lists-are-strongly-typed.md)|Lists are strongly typed|  
|[CA1041](../codequality/ca1041--provide-obsoleteattribute-message.md)|Provide ObsoleteAttribute message|  
|[CA1043](../codequality/ca1043--use-integral-or-string-argument-for-indexers.md)|Use integral or string argument for indexers|  
|[CA1044](../codequality/ca1044--properties-should-not-be-write-only.md)|Properties should not be write only|  
|[CA1046](../codequality/ca1046--do-not-overload-operator-equals-on-reference-types.md)|Do not overload operator equals on reference types|  
|[CA1047](../codequality/ca1047--do-not-declare-protected-members-in-sealed-types.md)|Do not declare protected members in sealed types|  
|[CA1048](../codequality/ca1048--do-not-declare-virtual-members-in-sealed-types.md)|Do not declare virtual members in sealed types|  
|[CA1050](../codequality/ca1050--declare-types-in-namespaces.md)|Declare types in namespaces|  
|[CA1051](../codequality/ca1051--do-not-declare-visible-instance-fields.md)|Do not declare visible instance fields|  
|[CA1052](../codequality/ca1052--static-holder-types-should-be-sealed.md)|Static holder types should be sealed|  
|[CA1053](../codequality/ca1053--static-holder-types-should-not-have-constructors.md)|Static holder types should not have constructors|  
|[CA1054](../codequality/ca1054--uri-parameters-should-not-be-strings.md)|URI parameters should not be strings|  
|[CA1055](../codequality/ca1055--uri-return-values-should-not-be-strings.md)|URI return values should not be strings|  
|[CA1056](../codequality/ca1056--uri-properties-should-not-be-strings.md)|URI properties should not be strings|  
|[CA1057](../codequality/ca1057--string-uri-overloads-call-system.uri-overloads.md)|String URI overloads call System.Uri overloads|  
|[CA1058](../codequality/ca1058--types-should-not-extend-certain-base-types.md)|Types should not extend certain base types|  
|[CA1059](../codequality/ca1059--members-should-not-expose-certain-concrete-types.md)|Members should not expose certain concrete types|  
|[CA1064](../codequality/ca1064--exceptions-should-be-public.md)|Exceptions should be public|  
|[CA1500](../codequality/ca1500--variable-names-should-not-match-field-names.md)|Variable names should not match field names|  
|[CA1502](../codequality/ca1502--avoid-excessive-complexity.md)|Avoid excessive complexity|  
|[CA1708](../codequality/ca1708--identifiers-should-differ-by-more-than-case.md)|Identifiers should differ by more than case|  
|[CA1716](../codequality/ca1716--identifiers-should-not-match-keywords.md)|Identifiers should not match keywords|  
|[CA1801](../codequality/ca1801--review-unused-parameters.md)|Review unused parameters|  
|[CA1804](../codequality/ca1804--remove-unused-locals.md)|Remove unused locals|  
|[CA1809](../codequality/ca1809--avoid-excessive-locals.md)|Avoid excessive locals|  
|[CA1810](../codequality/ca1810--initialize-reference-type-static-fields-inline.md)|Initialize reference type static fields inline|  
|[CA1811](../codequality/ca1811--avoid-uncalled-private-code.md)|Avoid uncalled private code|  
|[CA1812](../codequality/ca1812--avoid-uninstantiated-internal-classes.md)|Avoid uninstantiated internal classes|  
|[CA1813](../codequality/ca1813--avoid-unsealed-attributes.md)|Avoid unsealed attributes|  
|[CA1814](../codequality/ca1814--prefer-jagged-arrays-over-multidimensional.md)|Prefer jagged arrays over multidimensional|  
|[CA1815](../codequality/ca1815--override-equals-and-operator-equals-on-value-types.md)|Override equals and operator equals on value types|  
|[CA1819](../codequality/ca1819--properties-should-not-return-arrays.md)|Properties should not return arrays|  
|[CA1820](../codequality/ca1820--test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|  
|[CA1822](../codequality/ca1822--mark-members-as-static.md)|Mark members as static|  
|[CA1823](../codequality/ca1823--avoid-unused-private-fields.md)|Avoid unused private fields|  
|[CA2201](../codequality/ca2201--do-not-raise-reserved-exception-types.md)|Do not raise reserved exception types|  
|[CA2205](../codequality/ca2205--use-managed-equivalents-of-win32-api.md)|Use managed equivalents of Win32 API|  
|[CA2208](../codequality/ca2208--instantiate-argument-exceptions-correctly.md)|Instantiate argument exceptions correctly|  
|[CA2211](../codequality/ca2211--non-constant-fields-should-not-be-visible.md)|Non-constant fields should not be visible|  
|[CA2217](../codequality/ca2217--do-not-mark-enums-with-flagsattribute.md)|Do not mark enums with FlagsAttribute|  
|[CA2219](../codequality/ca2219--do-not-raise-exceptions-in-exception-clauses.md)|Do not raise exceptions in exception clauses|  
|[CA2221](../codequality/ca2221--finalizers-should-be-protected.md)|Finalizers should be protected|  
|[CA2222](../codequality/ca2222--do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|  
|[CA2223](../codequality/ca2223--members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|  
|[CA2224](../codequality/ca2224--override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|  
|[CA2225](../codequality/ca2225--operator-overloads-have-named-alternates.md)|Operator overloads have named alternates|  
|[CA2226](../codequality/ca2226--operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|  
|[CA2227](../codequality/ca2227--collection-properties-should-be-read-only.md)|Collection properties should be read only|  
|[CA2230](../codequality/ca2230--use-params-for-variable-arguments.md)|Use params for variable arguments|  
|[CA2234](../codequality/ca2234--pass-system.uri-objects-instead-of-strings.md)|Pass System.Uri objects instead of strings|  
|[CA2239](../codequality/ca2239--provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|