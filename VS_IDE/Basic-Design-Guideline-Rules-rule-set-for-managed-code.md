---
title: "Basic Design Guideline Rules rule set for managed code"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7eb384f5-f961-400b-b151-115d92addc6a
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
# Basic Design Guideline Rules rule set for managed code
You can use the Microsoft Basic Design Guideline Rules rule set to focus on making your code easier to understand and use. You should include this rule set if your project includes library code or if you want to enforce best practices for code that is easy to maintain.  
  
 The Basic Design Guideline Rules include all the rules in the Microsoft Minimum Recommeded Rules rule set. For a list of the minimum rules, see [Managed Recommended Rules rule set for managed code](../VS_IDE/Managed-Recommended-Rules-rule-set-for-managed-code.md).  
  
 The following table describes all of the rules in the Microsoft Basic Design Guideline Rules rule set.  
  
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
|[CA1000](../VS_IDE/CA1000--Do-not-declare-static-members-on-generic-types.md)|Do not declare static members on generic types|  
|[CA1002](../VS_IDE/CA1002--Do-not-expose-generic-lists.md)|Do not expose generic lists|  
|[CA1003](../VS_IDE/CA1003--Use-generic-event-handler-instances.md)|Use generic event handler instances|  
|[CA1004](../VS_IDE/CA1004--Generic-methods-should-provide-type-parameter.md)|Generic methods should provide type parameter|  
|[CA1005](../VS_IDE/CA1005--Avoid-excessive-parameters-on-generic-types.md)|Avoid excessive parameters on generic types|  
|[CA1006](../VS_IDE/CA1006--Do-not-nest-generic-types-in-member-signatures.md)|Do not nest generic types in member signatures|  
|[CA1007](../VS_IDE/CA1007--Use-generics-where-appropriate.md)|Use generics where appropriate|  
|[CA1008](../VS_IDE/CA1008--Enums-should-have-zero-value.md)|Enums should have zero value|  
|[CA1010](../VS_IDE/CA1010--Collections-should-implement-generic-interface.md)|Collections should implement generic interface|  
|[CA1011](../VS_IDE/CA1011--Consider-passing-base-types-as-parameters.md)|Consider passing base types as parameters|  
|[CA1012](../VS_IDE/CA1012--Abstract-types-should-not-have-constructors.md)|Abstract types should not have constructors|  
|[CA1013](../VS_IDE/CA1013--Overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|  
|[CA1014](../VS_IDE/CA1014--Mark-assemblies-with-CLSCompliantAttribute.md)|Mark assemblies with CLSCompliantAttribute|  
|[CA1017](../VS_IDE/CA1017--Mark-assemblies-with-ComVisibleAttribute.md)|Mark assemblies with ComVisibleAttribute|  
|[CA1018](../VS_IDE/CA1018--Mark-attributes-with-AttributeUsageAttribute.md)|Mark attributes with AttributeUsageAttribute|  
|[CA1019](../VS_IDE/CA1019--Define-accessors-for-attribute-arguments.md)|Define accessors for attribute arguments|  
|[CA1023](../VS_IDE/CA1023--Indexers-should-not-be-multidimensional.md)|Indexers should not be multidimensional|  
|[CA1024](../VS_IDE/CA1024--Use-properties-where-appropriate.md)|Use properties where appropriate|  
|[CA1025](../VS_IDE/CA1025--Replace-repetitive-arguments-with-params-array.md)|Replace repetitive arguments with params array|  
|[CA1026](../VS_IDE/CA1026--Default-parameters-should-not-be-used.md)|Default parameters should not be used|  
|[CA1027](../VS_IDE/CA1027--Mark-enums-with-FlagsAttribute.md)|Mark enums with FlagsAttribute|  
|[CA1028](../VS_IDE/CA1028--Enum-storage-should-be-Int32.md)|Enum storage should be Int32|  
|[CA1030](../VS_IDE/CA1030--Use-events-where-appropriate.md)|Use events where appropriate|  
|[CA1031](../VS_IDE/CA1031--Do-not-catch-general-exception-types.md)|Do not catch general exception types|  
|[CA1032](../VS_IDE/CA1032--Implement-standard-exception-constructors.md)|Implement standard exception constructors|  
|[CA1034](../VS_IDE/CA1034--Nested-types-should-not-be-visible.md)|Nested types should not be visible|  
|[CA1035](../VS_IDE/CA1035--ICollection-implementations-have-strongly-typed-members.md)|ICollection implementations have strongly typed members|  
|[CA1036](../VS_IDE/CA1036--Override-methods-on-comparable-types.md)|Override methods on comparable types|  
|[CA1038](../VS_IDE/CA1038--Enumerators-should-be-strongly-typed.md)|Enumerators should be strongly typed|  
|[CA1039](../VS_IDE/CA1039--Lists-are-strongly-typed.md)|Lists are strongly typed|  
|[CA1041](../VS_IDE/CA1041--Provide-ObsoleteAttribute-message.md)|Provide ObsoleteAttribute message|  
|[CA1043](../VS_IDE/CA1043--Use-integral-or-string-argument-for-indexers.md)|Use integral or string argument for indexers|  
|[CA1044](../VS_IDE/CA1044--Properties-should-not-be-write-only.md)|Properties should not be write only|  
|[CA1046](../VS_IDE/CA1046--Do-not-overload-operator-equals-on-reference-types.md)|Do not overload operator equals on reference types|  
|[CA1047](../VS_IDE/CA1047--Do-not-declare-protected-members-in-sealed-types.md)|Do not declare protected members in sealed types|  
|[CA1048](../VS_IDE/CA1048--Do-not-declare-virtual-members-in-sealed-types.md)|Do not declare virtual members in sealed types|  
|[CA1050](../VS_IDE/CA1050--Declare-types-in-namespaces.md)|Declare types in namespaces|  
|[CA1051](../VS_IDE/CA1051--Do-not-declare-visible-instance-fields.md)|Do not declare visible instance fields|  
|[CA1052](../VS_IDE/CA1052--Static-holder-types-should-be-sealed.md)|Static holder types should be sealed|  
|[CA1053](../VS_IDE/CA1053--Static-holder-types-should-not-have-constructors.md)|Static holder types should not have constructors|  
|[CA1054](../VS_IDE/CA1054--URI-parameters-should-not-be-strings.md)|URI parameters should not be strings|  
|[CA1055](../VS_IDE/CA1055--URI-return-values-should-not-be-strings.md)|URI return values should not be strings|  
|[CA1056](../VS_IDE/CA1056--URI-properties-should-not-be-strings.md)|URI properties should not be strings|  
|[CA1057](../VS_IDE/CA1057--String-URI-overloads-call-System.Uri-overloads.md)|String URI overloads call System.Uri overloads|  
|[CA1058](../VS_IDE/CA1058--Types-should-not-extend-certain-base-types.md)|Types should not extend certain base types|  
|[CA1059](../VS_IDE/CA1059--Members-should-not-expose-certain-concrete-types.md)|Members should not expose certain concrete types|  
|[CA1064](../VS_IDE/CA1064--Exceptions-should-be-public.md)|Exceptions should be public|  
|[CA1500](../VS_IDE/CA1500--Variable-names-should-not-match-field-names.md)|Variable names should not match field names|  
|[CA1502](../VS_IDE/CA1502--Avoid-excessive-complexity.md)|Avoid excessive complexity|  
|[CA1708](../VS_IDE/CA1708--Identifiers-should-differ-by-more-than-case.md)|Identifiers should differ by more than case|  
|[CA1716](../VS_IDE/CA1716--Identifiers-should-not-match-keywords.md)|Identifiers should not match keywords|  
|[CA1801](../VS_IDE/CA1801--Review-unused-parameters.md)|Review unused parameters|  
|[CA1804](../VS_IDE/CA1804--Remove-unused-locals.md)|Remove unused locals|  
|[CA1809](../VS_IDE/CA1809--Avoid-excessive-locals.md)|Avoid excessive locals|  
|[CA1810](../VS_IDE/CA1810--Initialize-reference-type-static-fields-inline.md)|Initialize reference type static fields inline|  
|[CA1811](../VS_IDE/CA1811--Avoid-uncalled-private-code.md)|Avoid uncalled private code|  
|[CA1812](../VS_IDE/CA1812--Avoid-uninstantiated-internal-classes.md)|Avoid uninstantiated internal classes|  
|[CA1813](../VS_IDE/CA1813--Avoid-unsealed-attributes.md)|Avoid unsealed attributes|  
|[CA1814](../VS_IDE/CA1814--Prefer-jagged-arrays-over-multidimensional.md)|Prefer jagged arrays over multidimensional|  
|[CA1815](../VS_IDE/CA1815--Override-equals-and-operator-equals-on-value-types.md)|Override equals and operator equals on value types|  
|[CA1819](../VS_IDE/CA1819--Properties-should-not-return-arrays.md)|Properties should not return arrays|  
|[CA1820](../VS_IDE/CA1820--Test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|  
|[CA1822](../VS_IDE/CA1822--Mark-members-as-static.md)|Mark members as static|  
|[CA1823](../VS_IDE/CA1823--Avoid-unused-private-fields.md)|Avoid unused private fields|  
|[CA2201](../VS_IDE/CA2201--Do-not-raise-reserved-exception-types.md)|Do not raise reserved exception types|  
|[CA2205](../VS_IDE/CA2205--Use-managed-equivalents-of-Win32-API.md)|Use managed equivalents of Win32 API|  
|[CA2208](../VS_IDE/CA2208--Instantiate-argument-exceptions-correctly.md)|Instantiate argument exceptions correctly|  
|[CA2211](../VS_IDE/CA2211--Non-constant-fields-should-not-be-visible.md)|Non-constant fields should not be visible|  
|[CA2217](../VS_IDE/CA2217--Do-not-mark-enums-with-FlagsAttribute.md)|Do not mark enums with FlagsAttribute|  
|[CA2219](../VS_IDE/CA2219--Do-not-raise-exceptions-in-exception-clauses.md)|Do not raise exceptions in exception clauses|  
|[CA2221](../VS_IDE/CA2221--Finalizers-should-be-protected.md)|Finalizers should be protected|  
|[CA2222](../VS_IDE/CA2222--Do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|  
|[CA2223](../VS_IDE/CA2223--Members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|  
|[CA2224](../VS_IDE/CA2224--Override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|  
|[CA2225](../VS_IDE/CA2225--Operator-overloads-have-named-alternates.md)|Operator overloads have named alternates|  
|[CA2226](../VS_IDE/CA2226--Operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|  
|[CA2227](../VS_IDE/CA2227--Collection-properties-should-be-read-only.md)|Collection properties should be read only|  
|[CA2230](../VS_IDE/CA2230--Use-params-for-variable-arguments.md)|Use params for variable arguments|  
|[CA2234](../VS_IDE/CA2234--Pass-System.Uri-objects-instead-of-strings.md)|Pass System.Uri objects instead of strings|  
|[CA2239](../VS_IDE/CA2239--Provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|