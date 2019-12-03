---
title: Basic Design Guideline Rules rule set for managed code
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 7eb384f5-f961-400b-b151-115d92addc6a
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Basic Design Guideline Rules rule set for managed code

You can use the Microsoft Basic Design Guideline Rules rule set to focus on making your code easier to understand and use. You should include this rule set if your project includes library code or if you want to enforce best practices for code that is easy to maintain.

The Basic Design Guideline Rules include all the rules in the [Managed Recommended Rules](managed-recommended-rules-rule-set-for-managed-code.md) rule set.

The following table describes all of the rules in the Microsoft Basic Design Guideline Rules rule set.

|Rule|Description|
|----------|-----------------|
|[CA1000](../code-quality/ca1000.md)|Do not declare static members on generic types|
|[CA1001](../code-quality/ca1001.md)|Types that own disposable fields should be disposable|
|[CA1002](../code-quality/ca1002.md)|Do not expose generic lists|
|[CA1003](../code-quality/ca1003.md)|Use generic event handler instances|
|[CA1004](../code-quality/ca1004.md)|Generic methods should provide type parameter|
|[CA1005](../code-quality/ca1005.md)|Avoid excessive parameters on generic types|
|[CA1006](../code-quality/ca1006.md)|Do not nest generic types in member signatures|
|[CA1007](../code-quality/ca1007.md)|Use generics where appropriate|
|[CA1008](../code-quality/ca1008.md)|Enums should have zero value|
|[CA1009](../code-quality/ca1009.md)|Declare event handlers correctly|
|[CA1010](../code-quality/ca1010.md)|Collections should implement generic interface|
|[CA1011](../code-quality/ca1011.md)|Consider passing base types as parameters|
|[CA1012](../code-quality/ca1012.md)|Abstract types should not have constructors|
|[CA1013](../code-quality/ca1013.md)|Overload operator equals on overloading add and subtract|
|[CA1014](../code-quality/ca1014.md)|Mark assemblies with CLSCompliantAttribute|
|[CA1016](../code-quality/ca1016.md)|Mark assemblies with AssemblyVersionAttribute|
|[CA1017](../code-quality/ca1017.md)|Mark assemblies with ComVisibleAttribute|
|[CA1018](../code-quality/ca1018.md)|Mark attributes with AttributeUsageAttribute|
|[CA1019](../code-quality/ca1019.md)|Define accessors for attribute arguments|
|[CA1023](../code-quality/ca1023.md)|Indexers should not be multidimensional|
|[CA1024](../code-quality/ca1024.md)|Use properties where appropriate|
|[CA1025](../code-quality/ca1025.md)|Replace repetitive arguments with params array|
|[CA1026](../code-quality/ca1026.md)|Default parameters should not be used|
|[CA1027](../code-quality/ca1027.md)|Mark enums with FlagsAttribute|
|[CA1028](../code-quality/ca1028.md)|Enum storage should be Int32|
|[CA1030](../code-quality/ca1030.md)|Use events where appropriate|
|[CA1031](../code-quality/ca1031.md)|Do not catch general exception types|
|[CA1032](../code-quality/ca1032.md)|Implement standard exception constructors|
|[CA1033](../code-quality/ca1033.md)|Interface methods should be callable by child types|
|[CA1034](../code-quality/ca1034.md)|Nested types should not be visible|
|[CA1035](../code-quality/ca1035.md)|ICollection implementations have strongly typed members|
|[CA1036](../code-quality/ca1036.md)|Override methods on comparable types|
|[CA1038](../code-quality/ca1038.md)|Enumerators should be strongly typed|
|[CA1039](../code-quality/ca1039.md)|Lists are strongly typed|
|[CA1041](../code-quality/ca1041.md)|Provide ObsoleteAttribute message|
|[CA1043](../code-quality/ca1043.md)|Use integral or string argument for indexers|
|[CA1044](../code-quality/ca1044.md)|Properties should not be write only|
|[CA1046](../code-quality/ca1046.md)|Do not overload operator equals on reference types|
|[CA1047](../code-quality/ca1047.md)|Do not declare protected members in sealed types|
|[CA1048](../code-quality/ca1048.md)|Do not declare virtual members in sealed types|
|[CA1049](../code-quality/ca1049.md)|Types that own native resources should be disposable|
|[CA1050](../code-quality/ca1050.md)|Declare types in namespaces|
|[CA1051](../code-quality/ca1051.md)|Do not declare visible instance fields|
|[CA1052](../code-quality/ca1052.md)|Static holder types should be sealed|
|[CA1053](../code-quality/ca1053.md)|Static holder types should not have constructors|
|[CA1054](../code-quality/ca1054.md)|URI parameters should not be strings|
|[CA1055](../code-quality/ca1055.md)|URI return values should not be strings|
|[CA1056](../code-quality/ca1056.md)|URI properties should not be strings|
|[CA1057](../code-quality/ca1057.md)|String URI overloads call System.Uri overloads|
|[CA1058](../code-quality/ca1058.md)|Types should not extend certain base types|
|[CA1059](../code-quality/ca1059.md)|Members should not expose certain concrete types|
|[CA1060](../code-quality/ca1060.md)|Move P/Invokes to NativeMethods class|
|[CA1061](../code-quality/ca1061.md)|Do not hide base class methods|
|[CA1063](../code-quality/ca1063.md)|Implement IDisposable correctly|
|[CA1064](../code-quality/ca1064.md)|Exceptions should be public|
|[CA1065](../code-quality/ca1065.md)|Do not raise exceptions in unexpected locations|
|[CA1301](../code-quality/ca1301.md)|Avoid duplicate accelerators|
|[CA1400](../code-quality/ca1400.md)|P/Invoke entry points should exist|
|[CA1401](../code-quality/ca1401.md)|P/Invokes should not be visible|
|[CA1403](../code-quality/ca1403.md)|Auto layout types should not be COM visible|
|[CA1404](../code-quality/ca1404.md)|Call GetLastError immediately after P/Invoke|
|[CA1405](../code-quality/ca1405.md)|COM visible type base types should be COM visible|
|[CA1410](../code-quality/ca1410.md)|COM registration methods should be matched|
|[CA1415](../code-quality/ca1415.md)|Declare P/Invokes correctly|
|[CA1500](../code-quality/ca1500.md)|Variable names should not match field names|
|[CA1502](../code-quality/ca1502.md)|Avoid excessive complexity|
|[CA1708](../code-quality/ca1708.md)|Identifiers should differ by more than case|
|[CA1716](../code-quality/ca1716.md)|Identifiers should not match keywords|
|[CA1801](../code-quality/ca1801.md)|Review unused parameters|
|[CA1804](../code-quality/ca1804.md)|Remove unused locals|
|[CA1809](../code-quality/ca1809.md)|Avoid excessive locals|
|[CA1810](../code-quality/ca1810.md)|Initialize reference type static fields inline|
|[CA1811](../code-quality/ca1811.md)|Avoid uncalled private code|
|[CA1812](../code-quality/ca1812.md)|Avoid uninstantiated internal classes|
|[CA1813](../code-quality/ca1813.md)|Avoid unsealed attributes|
|[CA1814](../code-quality/ca1814.md)|Prefer jagged arrays over multidimensional|
|[CA1815](../code-quality/ca1815.md)|Override equals and operator equals on value types|
|[CA1819](../code-quality/ca1819.md)|Properties should not return arrays|
|[CA1820](../code-quality/ca1820.md)|Test for empty strings using string length|
|[CA1821](../code-quality/ca1821.md)|Remove empty finalizers|
|[CA1822](../code-quality/ca1822.md)|Mark members as static|
|[CA1823](../code-quality/ca1823.md)|Avoid unused private fields|
|[CA1900](../code-quality/ca1900.md)|Value type fields should be portable|
|[CA1901](../code-quality/ca1901.md)|P/Invoke declarations should be portable|
|[CA2002](../code-quality/ca2002.md)|Do not lock on objects with weak identity|
|[CA2100](../code-quality/ca2100.md)|Review SQL queries for security vulnerabilities|
|[CA2101](../code-quality/ca2101.md)|Specify marshaling for P/Invoke string arguments|
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
|[CA2200](../code-quality/ca2200.md)|Rethrow to preserve stack details|
|[CA2201](../code-quality/ca2201.md)|Do not raise reserved exception types|
|[CA2202](../code-quality/ca2202.md)|Do not dispose objects multiple times|
|[CA2205](../code-quality/ca2205.md)|Use managed equivalents of Win32 API|
|[CA2207](../code-quality/ca2207.md)|Initialize value type static fields inline|
|[CA2208](../code-quality/ca2208.md)|Instantiate argument exceptions correctly|
|[CA2211](../code-quality/ca2211.md)|Non-constant fields should not be visible|
|[CA2212](../code-quality/ca2212.md)|Do not mark serviced components with WebMethod|
|[CA2213](../code-quality/ca2213.md)|Disposable fields should be disposed|
|[CA2214](../code-quality/ca2214.md)|Do not call overridable methods in constructors|
|[CA2216](../code-quality/ca2216.md)|Disposable types should declare finalizer|
|[CA2217](../code-quality/ca2217.md)|Do not mark enums with FlagsAttribute|
|[CA2219](../code-quality/ca2219.md)|Do not raise exceptions in exception clauses|
|[CA2220](../code-quality/ca2220.md)|Finalizers should call base class finalizer|
|[CA2221](../code-quality/ca2221.md)|Finalizers should be protected|
|[CA2222](../code-quality/ca2222.md)|Do not decrease inherited member visibility|
|[CA2223](../code-quality/ca2223.md)|Members should differ by more than return type|
|[CA2224](../code-quality/ca2224.md)|Override equals on overloading operator equals|
|[CA2225](../code-quality/ca2225.md)|Operator overloads have named alternates|
|[CA2226](../code-quality/ca2226.md)|Operators should have symmetrical overloads|
|[CA2227](../code-quality/ca2227.md)|Collection properties should be read only|
|[CA2229](../code-quality/ca2229.md)|Implement serialization constructors|
|[CA2230](../code-quality/ca2230.md)|Use params for variable arguments|
|[CA2231](../code-quality/ca2231.md)|Overload operator equals on overriding ValueType.Equals|
|[CA2232](../code-quality/ca2232.md)|Mark Windows Forms entry points with STAThread|
|[CA2234](../code-quality/ca2234.md)|Pass System.Uri objects instead of strings|
|[CA2235](../code-quality/ca2235.md)|Mark all non-serializable fields|
|[CA2236](../code-quality/ca2236.md)|Call base class methods on ISerializable types|
|[CA2237](../code-quality/ca2237.md)|Mark ISerializable types with SerializableAttribute|
|[CA2238](../code-quality/ca2238.md)|Implement serialization methods correctly|
|[CA2239](../code-quality/ca2239.md)|Provide deserialization methods for optional fields|
|[CA2240](../code-quality/ca2240.md)|Implement ISerializable correctly|
|[CA2241](../code-quality/ca2241.md)|Provide correct arguments to formatting methods|
|[CA2242](../code-quality/ca2242.md)|Test for NaN correctly|
