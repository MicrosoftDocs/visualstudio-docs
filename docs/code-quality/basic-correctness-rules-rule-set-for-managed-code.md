---
title: Basic Correctness Rules rule set for managed code
ms.date: 11/04/2016
description: Learn about the Basic Correctness Rules rule set in Visual Studio, which focuses on logic errors and common framework API mistakes. See rule descriptions.
ms.custom: SEO-VS-2020
ms.topic: reference
ms.assetid: 631f0daf-1d42-4c90-a7dc-1a6a9de64c93
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---
# Basic Correctness Rules rule set for managed code

The Basic Correctness Rules rule set focuses on logic errors and common mistakes in the usage of framework APIs. The Basic Correctness Rules include the rules in the [Managed Recommended Rules](managed-recommended-rules-rule-set-for-managed-code.md) rule set.

The following table describes all the rules in the Microsoft Basic Correctness Rules rule set.

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
|[CA1008](/dotnet/fundamentals/code-analysis/quality-rules/ca1008)|Enums should have zero value|
|[CA1013](../code-quality/ca1013.md)|Overload operator equals on overloading add and subtract|
|[CA1303](/dotnet/fundamentals/code-analysis/quality-rules/ca1303)|Do not pass literals as localized parameters|
|[CA1308](/dotnet/fundamentals/code-analysis/quality-rules/ca1308)|Normalize strings to uppercase|
|[CA1806](/dotnet/fundamentals/code-analysis/quality-rules/ca1806)|Do not ignore method results|
|[CA1816](/dotnet/fundamentals/code-analysis/quality-rules/ca1816)|Call GC.SuppressFinalize correctly|
|[CA1819](/dotnet/fundamentals/code-analysis/quality-rules/ca1819)|Properties should not return arrays|
|[CA1820](/dotnet/fundamentals/code-analysis/quality-rules/ca1820)|Test for empty strings using string length|
|[CA1903](../code-quality/ca1903.md)|Use only API from targeted framework|
|[CA2004](../code-quality/ca2004.md)|Remove calls to GC.KeepAlive|
|[CA2006](../code-quality/ca2006.md)|Use SafeHandle to encapsulate native resources|
|[CA2102](../code-quality/ca2102.md)|Catch non-CLSCompliant exceptions in general handlers|
|[CA2104](../code-quality/ca2104.md)|Do not declare read only mutable reference types|
|[CA2105](../code-quality/ca2105.md)|Array fields should not be read only|
|[CA2106](../code-quality/ca2106.md)|Secure asserts|
|[CA2115](../code-quality/ca2115.md)|Call GC.KeepAlive when using native resources|
|[CA2119](/dotnet/fundamentals/code-analysis/quality-rules/ca2119)|Seal methods that satisfy private interfaces|
|[CA2120](../code-quality/ca2120.md)|Secure serialization constructors|
|[CA2121](../code-quality/ca2121.md)|Static constructors should be private|
|[CA2130](../code-quality/ca2130.md)|Security critical constants should be transparent|
|[CA2205](../code-quality/ca2205.md)|Use managed equivalents of Win32 API|
|[CA2215](/dotnet/fundamentals/code-analysis/quality-rules/ca2215)|Dispose methods should call base class dispose|
|[CA2221](../code-quality/ca2221.md)|Finalizers should be protected|
|[CA2222](../code-quality/ca2222.md)|Do not decrease inherited member visibility|
|[CA2223](../code-quality/ca2223.md)|Members should differ by more than return type|
|[CA2224](../code-quality/ca2224.md)|Override equals on overloading operator equals|
|[CA2226](/dotnet/fundamentals/code-analysis/quality-rules/ca2226)|Operators should have symmetrical overloads|
|[CA2227](/dotnet/fundamentals/code-analysis/quality-rules/ca2227)|Collection properties should be read only|
|[CA2239](../code-quality/ca2239.md)|Provide deserialization methods for optional fields|
