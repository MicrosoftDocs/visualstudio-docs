---
title: Extended Design Guidelines Rules rule set for managed code
ms.date: 11/04/2016
description: Learn about the Extended Design Guidelines Rules rule set in Visual Studio, which focuses on usability and maintainability. See rule descriptions.
ms.custom: SEO-VS-2020
ms.topic: reference
ms.assetid: a338caf2-b75d-4f23-a0f9-3024fa0bceac
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---
# Extended Design Guidelines Rules rule set for managed code

The Microsoft Extended Design Guideline Rules rule set expands on the basic design guideline rules to maximize the usability and maintainability issues that are reported. Extra emphasis is placed on naming guidelines. You should consider including this rule set if your project includes library code or if you want to enforce the highest standards for writing code that is easy to maintain.

The Extended Design Guideline Rules include all rules in the [Basic Design Guideline Rules](../code-quality/basic-design-guideline-rules-rule-set-for-managed-code.md) rule set, which includes the rules in the [Managed Recommended Rules](../code-quality/managed-recommended-rules-rule-set-for-managed-code.md) rule set.

The following table describes all the rules in the Microsoft Extended Design Guideline Rules rule set.

|Rule|Description|
|----------|-----------------|
|[CA1001](/dotnet/fundamentals/code-analysis/quality-rules/ca1001)|Types that own disposable fields should be disposable|
|[CA1009](../code-quality/ca1009.md)|Declare event handlers correctly|
|[CA1016](/dotnet/fundamentals/code-analysis/quality-rules/ca1016)|Mark assemblies with AssemblyVersionAttribute|
|[CA1033](/dotnet/fundamentals/code-analysis/quality-rules/ca1033)|Interface methods should be callable by child types|
|[CA1049](../code-quality/ca1049.md)|Types that own native resources should be disposable|
|[CA1060](/dotnet/fundamentals/code-analysis/quality-rules/ca1060)|Move P/Invokes to NativeMethods class|
|[CA1061](/dotnet/fundamentals/code-analysis/quality-rules/ca1061)|Do not hide base class methods|
|[CA1063](/dotnet/fundamentals/code-analysis/quality-rules/ca1063)|Implement IDisposable correctly|
|[CA1065](/dotnet/fundamentals/code-analysis/quality-rules/ca1065)|Do not raise exceptions in unexpected locations|
|[CA1301](../code-quality/ca1301.md)|Avoid duplicate accelerators|
|[CA1400](../code-quality/ca1400.md)|P/Invoke entry points should exist|
|[CA1401](/dotnet/fundamentals/code-analysis/quality-rules/ca1401)|P/Invokes should not be visible|
|[CA1403](../code-quality/ca1403.md)|Auto layout types should not be COM visible|
|[CA1404](../code-quality/ca1404.md)|Call GetLastError immediately after P/Invoke|
|[CA1405](../code-quality/ca1405.md)|COM visible type base types should be COM visible|
|[CA1410](../code-quality/ca1410.md)|COM registration methods should be matched|
|[CA1415](../code-quality/ca1415.md)|Declare P/Invokes correctly|
|[CA1821](/dotnet/fundamentals/code-analysis/quality-rules/ca1821)|Remove empty finalizers|
|[CA1900](../code-quality/ca1900.md)|Value type fields should be portable|
|[CA1901](../code-quality/ca1901.md)|P/Invoke declarations should be portable|
|[CA2002](/dotnet/fundamentals/code-analysis/quality-rules/ca2002)|Do not lock on objects with weak identity|
|[CA2100](/dotnet/fundamentals/code-analysis/quality-rules/ca2100)|Review SQL queries for security vulnerabilities|
|[CA2101](/dotnet/fundamentals/code-analysis/quality-rules/ca2101)|Specify marshaling for P/Invoke string arguments|
|[CA2108](../code-quality/ca2108.md)|Review declarative security on value types|
|[CA2111](../code-quality/ca2111.md)|Pointers should not be visible|
|[CA2112](../code-quality/ca2112.md)|Secured types should not expose fields|
|[CA2114](../code-quality/ca2114.md)|Method security should be a superset of type|
|[CA2116](../code-quality/ca2116.md)|APTCA methods should only call APTCA methods|
|[CA2117](../code-quality/ca2117.md)|APTCA types should only extend APTCA base types|
|[CA2122](../code-quality/ca2122.md)|Do not indirectly expose methods with link demands|
|[CA2123](../code-quality/ca2123.md)|Override link demands should be identical to base|
|[CA2124](../code-quality/ca2124.md)|Wrap vulnerable finally clauses in outer try|
|[CA2126](../code-quality/ca2126.md)|Type link demands require inheritance demands|
|[CA2131](../code-quality/ca2131.md)|Security critical types may not participate in type equivalence|
|[CA2132](../code-quality/ca2132.md)|Default constructors must be at least as critical as base type default constructors|
|[CA2133](../code-quality/ca2133.md)|Delegates must bind to methods with consistent transparency|
|[CA2134](../code-quality/ca2134.md)|Methods must keep consistent transparency when overriding base methods|
|[CA2137](../code-quality/ca2137.md)|Transparent methods must contain only verifiable IL|
|[CA2138](../code-quality/ca2138.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|
|[CA2140](../code-quality/ca2140.md)|Transparent code must not reference security critical items|
|[CA2141](../code-quality/ca2141.md)|Transparent methods must not satisfy LinkDemands|
|[CA2146](../code-quality/ca2146.md)|Types must be at least as critical as their base types and interfaces|
|[CA2147](../code-quality/ca2147.md)|Transparent methods may not use security asserts|
|[CA2149](../code-quality/ca2149.md)|Transparent methods must not call into native code|
|[CA2200](/dotnet/fundamentals/code-analysis/quality-rules/ca2200)|Rethrow to preserve stack details|
|[CA2202](../code-quality/ca2202.md)|Do not dispose objects multiple times|
|[CA2207](/dotnet/fundamentals/code-analysis/quality-rules/ca2207)|Initialize value type static fields inline|
|[CA2212](../code-quality/ca2212.md)|Do not mark serviced components with WebMethod|
|[CA2213](/dotnet/fundamentals/code-analysis/quality-rules/ca2213)|Disposable fields should be disposed|
|[CA2214](/dotnet/fundamentals/code-analysis/quality-rules/ca2214)|Do not call overridable methods in constructors|
|[CA2216](/dotnet/fundamentals/code-analysis/quality-rules/ca2216)|Disposable types should declare finalizer|
|[CA2220](../code-quality/ca2220.md)|Finalizers should call base class finalizer|
|[CA2229](/dotnet/fundamentals/code-analysis/quality-rules/ca2229)|Implement serialization constructors|
|[CA2231](/dotnet/fundamentals/code-analysis/quality-rules/ca2231)|Overload operator equals on overriding ValueType.Equals|
|[CA2232](../code-quality/ca2232.md)|Mark Windows Forms entry points with STAThread|
|[CA2235](/dotnet/fundamentals/code-analysis/quality-rules/ca2235)|Mark all non-serializable fields|
|[CA2236](../code-quality/ca2236.md)|Call base class methods on ISerializable types|
|[CA2237](/dotnet/fundamentals/code-analysis/quality-rules/ca2237)|Mark ISerializable types with SerializableAttribute|
|[CA2238](../code-quality/ca2238.md)|Implement serialization methods correctly|
|[CA2240](../code-quality/ca2240.md)|Implement ISerializable correctly|
|[CA2241](/dotnet/fundamentals/code-analysis/quality-rules/ca2241)|Provide correct arguments to formatting methods|
|[CA2242](/dotnet/fundamentals/code-analysis/quality-rules/ca2242)|Test for NaN correctly|
|[CA1000](/dotnet/fundamentals/code-analysis/quality-rules/ca1000)|Do not declare static members on generic types|
|[CA1002](/dotnet/fundamentals/code-analysis/quality-rules/ca1002)|Do not expose generic lists|
|[CA1003](/dotnet/fundamentals/code-analysis/quality-rules/ca1003)|Use generic event handler instances|
|[CA1004](../code-quality/ca1004.md)|Generic methods should provide type parameter|
|[CA1005](/dotnet/fundamentals/code-analysis/quality-rules/ca1005)|Avoid excessive parameters on generic types|
|[CA1006](../code-quality/ca1006.md)|Do not nest generic types in member signatures|
|[CA1007](../code-quality/ca1007.md)|Use generics where appropriate|
|[CA1008](/dotnet/fundamentals/code-analysis/quality-rules/ca1008)|Enums should have zero value|
|[CA1010](/dotnet/fundamentals/code-analysis/quality-rules/ca1010)|Collections should implement generic interface|
|[CA1011](../code-quality/ca1011.md)|Consider passing base types as parameters|
|[CA1012](/dotnet/fundamentals/code-analysis/quality-rules/ca1012)|Abstract types should not have constructors|
|[CA1013](../code-quality/ca1013.md)|Overload operator equals on overloading add and subtract|
|[CA1014](/dotnet/fundamentals/code-analysis/quality-rules/ca1014)|Mark assemblies with CLSCompliantAttribute|
|[CA1017](/dotnet/fundamentals/code-analysis/quality-rules/ca1017)|Mark assemblies with ComVisibleAttribute|
|[CA1018](/dotnet/fundamentals/code-analysis/quality-rules/ca1018)|Mark attributes with AttributeUsageAttribute|
|[CA1019](/dotnet/fundamentals/code-analysis/quality-rules/ca1019)|Define accessors for attribute arguments|
|[CA1023](../code-quality/ca1023.md)|Indexers should not be multidimensional|
|[CA1024](/dotnet/fundamentals/code-analysis/quality-rules/ca1024)|Use properties where appropriate|
|[CA1025](../code-quality/ca1025.md)|Replace repetitive arguments with params array|
|[CA1026](../code-quality/ca1026.md)|Default parameters should not be used|
|[CA1027](/dotnet/fundamentals/code-analysis/quality-rules/ca1027)|Mark enums with FlagsAttribute|
|[CA1028](/dotnet/fundamentals/code-analysis/quality-rules/ca1028)|Enum storage should be Int32|
|[CA1030](/dotnet/fundamentals/code-analysis/quality-rules/ca1030)|Use events where appropriate|
|[CA1031](/dotnet/fundamentals/code-analysis/quality-rules/ca1031)|Do not catch general exception types|
|[CA1032](/dotnet/fundamentals/code-analysis/quality-rules/ca1032)|Implement standard exception constructors|
|[CA1034](/dotnet/fundamentals/code-analysis/quality-rules/ca1034)|Nested types should not be visible|
|[CA1035](../code-quality/ca1035.md)|ICollection implementations have strongly typed members|
|[CA1036](/dotnet/fundamentals/code-analysis/quality-rules/ca1036)|Override methods on comparable types|
|[CA1038](../code-quality/ca1038.md)|Enumerators should be strongly typed|
|[CA1039](../code-quality/ca1039.md)|Lists are strongly typed|
|[CA1041](/dotnet/fundamentals/code-analysis/quality-rules/ca1041)|Provide ObsoleteAttribute message|
|[CA1043](/dotnet/fundamentals/code-analysis/quality-rules/ca1043)|Use integral or string argument for indexers|
|[CA1044](/dotnet/fundamentals/code-analysis/quality-rules/ca1044)|Properties should not be write only|
|[CA1046](/dotnet/fundamentals/code-analysis/quality-rules/ca1046)|Do not overload operator equals on reference types|
|[CA1047](/dotnet/fundamentals/code-analysis/quality-rules/ca1047)|Do not declare protected members in sealed types|
|[CA1048](../code-quality/ca1048.md)|Do not declare virtual members in sealed types|
|[CA1050](/dotnet/fundamentals/code-analysis/quality-rules/ca1050)|Declare types in namespaces|
|[CA1051](/dotnet/fundamentals/code-analysis/quality-rules/ca1051)|Do not declare visible instance fields|
|[CA1052](/dotnet/fundamentals/code-analysis/quality-rules/ca1052)|Static holder types should be sealed|
|[CA1053](/dotnet/fundamentals/code-analysis/quality-rules/ca1053)|Static holder types should not have constructors|
|[CA1054](/dotnet/fundamentals/code-analysis/quality-rules/ca1054)|URI parameters should not be strings|
|[CA1055](/dotnet/fundamentals/code-analysis/quality-rules/ca1055)|URI return values should not be strings|
|[CA1056](/dotnet/fundamentals/code-analysis/quality-rules/ca1056)|URI properties should not be strings|
|[CA1057](../code-quality/ca1057.md)|String URI overloads call System.Uri overloads|
|[CA1058](/dotnet/fundamentals/code-analysis/quality-rules/ca1058)|Types should not extend certain base types|
|[CA1059](../code-quality/ca1059.md)|Members should not expose certain concrete types|
|[CA1064](/dotnet/fundamentals/code-analysis/quality-rules/ca1064)|Exceptions should be public|
|[CA1500](../code-quality/ca1500.md)|Variable names should not match field names|
|[CA1502](/dotnet/fundamentals/code-analysis/quality-rules/ca1502)|Avoid excessive complexity|
|[CA1708](/dotnet/fundamentals/code-analysis/quality-rules/ca1708)|Identifiers should differ by more than case|
|[CA1716](/dotnet/fundamentals/code-analysis/quality-rules/ca1716)|Identifiers should not match keywords|
|[CA1801](/dotnet/fundamentals/code-analysis/quality-rules/ca1801)|Review unused parameters|
|[CA1804](../code-quality/ca1804.md)|Remove unused locals|
|[CA1809](../code-quality/ca1809.md)|Avoid excessive locals|
|[CA1810](/dotnet/fundamentals/code-analysis/quality-rules/ca1810)|Initialize reference type static fields inline|
|[CA1811](../code-quality/ca1811.md)|Avoid uncalled private code|
|[CA1812](/dotnet/fundamentals/code-analysis/quality-rules/ca1812)|Avoid uninstantiated internal classes|
|[CA1813](/dotnet/fundamentals/code-analysis/quality-rules/ca1813)|Avoid unsealed attributes|
|[CA1814](/dotnet/fundamentals/code-analysis/quality-rules/ca1814)|Prefer jagged arrays over multidimensional|
|[CA1815](/dotnet/fundamentals/code-analysis/quality-rules/ca1815)|Override equals and operator equals on value types|
|[CA1819](/dotnet/fundamentals/code-analysis/quality-rules/ca1819)|Properties should not return arrays|
|[CA1820](/dotnet/fundamentals/code-analysis/quality-rules/ca1820)|Test for empty strings using string length|
|[CA1822](/dotnet/fundamentals/code-analysis/quality-rules/ca1822)|Mark members as static|
|[CA1823](/dotnet/fundamentals/code-analysis/quality-rules/ca1823)|Avoid unused private fields|
|[CA2201](/dotnet/fundamentals/code-analysis/quality-rules/ca2201)|Do not raise reserved exception types|
|[CA2205](../code-quality/ca2205.md)|Use managed equivalents of Win32 API|
|[CA2208](/dotnet/fundamentals/code-analysis/quality-rules/ca2208)|Instantiate argument exceptions correctly|
|[CA2211](/dotnet/fundamentals/code-analysis/quality-rules/ca2211)|Non-constant fields should not be visible|
|[CA2217](/dotnet/fundamentals/code-analysis/quality-rules/ca2217)|Do not mark enums with FlagsAttribute|
|[CA2219](/dotnet/fundamentals/code-analysis/quality-rules/ca2219)|Do not raise exceptions in exception clauses|
|[CA2221](../code-quality/ca2221.md)|Finalizers should be protected|
|[CA2222](../code-quality/ca2222.md)|Do not decrease inherited member visibility|
|[CA2223](../code-quality/ca2223.md)|Members should differ by more than return type|
|[CA2224](../code-quality/ca2224.md)|Override equals on overloading operator equals|
|[CA2225](/dotnet/fundamentals/code-analysis/quality-rules/ca2225)|Operator overloads have named alternates|
|[CA2226](/dotnet/fundamentals/code-analysis/quality-rules/ca2226)|Operators should have symmetrical overloads|
|[CA2227](/dotnet/fundamentals/code-analysis/quality-rules/ca2227)|Collection properties should be read only|
|[CA2230](../code-quality/ca2230.md)|Use params for variable arguments|
|[CA2234](/dotnet/fundamentals/code-analysis/quality-rules/ca2234)|Pass System.Uri objects instead of strings|
|[CA2239](../code-quality/ca2239.md)|Provide deserialization methods for optional fields|
|[CA1020](../code-quality/ca1020.md)|Avoid namespaces with few types|
|[CA1021](/dotnet/fundamentals/code-analysis/quality-rules/ca1021)|Avoid out parameters|
|[CA1040](/dotnet/fundamentals/code-analysis/quality-rules/ca1040)|Avoid empty interfaces|
|[CA1045](/dotnet/fundamentals/code-analysis/quality-rules/ca1045)|Do not pass types by reference|
|[CA1062](/dotnet/fundamentals/code-analysis/quality-rules/ca1062)|Validate arguments of public methods|
|[CA1501](/dotnet/fundamentals/code-analysis/quality-rules/ca1501)|Avoid excessive inheritance|
|[CA1504](../code-quality/ca1504.md)|Review misleading field names|
|[CA1505](/dotnet/fundamentals/code-analysis/quality-rules/ca1505)|Avoid unmaintainable code|
|[CA1506](/dotnet/fundamentals/code-analysis/quality-rules/ca1506)|Avoid excessive class coupling|
|[CA1700](/dotnet/fundamentals/code-analysis/quality-rules/ca1700)|Do not name enum values 'Reserved'|
|[CA1701](../code-quality/ca1701.md)|Resource string compound words should be cased correctly|
|[CA1702](../code-quality/ca1702.md)|Compound words should be cased correctly|
|[CA1703](../code-quality/ca1703.md)|Resource strings should be spelled correctly|
|[CA1704](../code-quality/ca1704.md)|Identifiers should be spelled correctly|
|[CA1707](/dotnet/fundamentals/code-analysis/quality-rules/ca1707)|Identifiers should not contain underscores|
|[CA1709](../code-quality/ca1709.md)|Identifiers should be cased correctly|
|[CA1710](/dotnet/fundamentals/code-analysis/quality-rules/ca1710)|Identifiers should have correct suffix|
|[CA1711](/dotnet/fundamentals/code-analysis/quality-rules/ca1711)|Identifiers should not have incorrect suffix|
|[CA1712](/dotnet/fundamentals/code-analysis/quality-rules/ca1712)|Do not prefix enum values with type name|
|[CA1713](/dotnet/fundamentals/code-analysis/quality-rules/ca1713)|Events should not have before or after prefix|
|[CA1714](/dotnet/fundamentals/code-analysis/quality-rules/ca1714)|Flags enums should have plural names|
|[CA1715](/dotnet/fundamentals/code-analysis/quality-rules/ca1715)|Identifiers should have correct prefix|
|[CA1717](/dotnet/fundamentals/code-analysis/quality-rules/ca1717)|Only FlagsAttribute enums should have plural names|
|[CA1719](../code-quality/ca1719.md)|Parameter names should not match member names|
|[CA1720](/dotnet/fundamentals/code-analysis/quality-rules/ca1720)|Identifiers should not contain type names|
|[CA1721](/dotnet/fundamentals/code-analysis/quality-rules/ca1721)|Property names should not match get methods|
|[CA1722](../code-quality/ca1722.md)|Identifiers should not have incorrect prefix|
|[CA1724](/dotnet/fundamentals/code-analysis/quality-rules/ca1724)|Type Names Should Not Match Namespaces|
|[CA1725](/dotnet/fundamentals/code-analysis/quality-rules/ca1725)|Parameter names should match base declaration|
|[CA1726](../code-quality/ca1726.md)|Use preferred terms|
|[CA2204](../code-quality/ca2204.md)|Literals should be spelled correctly|
