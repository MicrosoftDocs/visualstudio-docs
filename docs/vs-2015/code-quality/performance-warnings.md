---
title: "Performance Warnings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.performancerules"
helpviewer_keywords:
  - "warnings, performance"
  - "performance warnings"
  - "performance, warnings"
  - "managed code analysis warnings, performance warnings"
ms.assetid: e014ac3a-02e6-46d9-942c-3491dd63782f
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Performance Warnings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Performance warnings support high-performance libraries and applications.

## In This Section

|Rule|Description|
|----------|-----------------|
|[CA1800: Do not cast unnecessarily](../code-quality/ca1800-do-not-cast-unnecessarily.md)|Duplicate casts decrease performance, especially when the casts are performed in compact iteration statements.|
|[CA1801: Review unused parameters](../code-quality/ca1801-review-unused-parameters.md)|A method signature includes a parameter that is not used in the method body.|
|[CA1802: Use Literals Where Appropriate](../code-quality/ca1802-use-literals-where-appropriate.md)|A field is declared static and read-only (Shared and ReadOnly in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]), and is initialized with a value that is computable at compile time. Because the value that is assigned to the targeted field is computable at compile time, change the declaration to a const (Const in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) field so that the value is computed at compile time instead of at run time.|
|[CA1804: Remove unused locals](../code-quality/ca1804-remove-unused-locals.md)|Unused local variables and unnecessary assignments increase the size of an assembly and decrease performance.|
|[CA1806: Do not ignore method results](../code-quality/ca1806-do-not-ignore-method-results.md)|A new object is created but never used, or a method that creates and returns a new string is called and the new string is never used, or a Component Object Model (COM) or P/Invoke method returns an HRESULT or error code that is never used.|
|[CA1809: Avoid excessive locals](../code-quality/ca1809-avoid-excessive-locals.md)|A common performance optimization is to store a value in a processor register instead of memory, which is referred to as "enregistering the value".  To increase the chance that all local variables are enregistered, limit the number of local variables to 64.|
|[CA1810: Initialize reference type static fields inline](../code-quality/ca1810-initialize-reference-type-static-fields-inline.md)|When a type declares an explicit static constructor, the just-in-time (JIT) compiler adds a check to each static method and instance constructor of the type to make sure that the static constructor was previously called. Static constructor checks can decrease performance.|
|[CA1811: Avoid uncalled private code](../code-quality/ca1811-avoid-uncalled-private-code.md)|A private or internal (assembly-level) member does not have callers in the assembly, it is not invoked by the common language runtime, and it is not invoked by a delegate.|
|[CA1812: Avoid uninstantiated internal classes](../code-quality/ca1812-avoid-uninstantiated-internal-classes.md)|An instance of an assembly-level type is not created by code in the assembly.|
|[CA1813: Avoid unsealed attributes](../code-quality/ca1813-avoid-unsealed-attributes.md)|The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] class library provides methods for retrieving custom attributes. By default, these methods search the attribute inheritance hierarchy. Sealing the attribute eliminates the search through the inheritance hierarchy and can improve performance.|
|[CA1814: Prefer jagged arrays over multidimensional](../code-quality/ca1814-prefer-jagged-arrays-over-multidimensional.md)|A jagged array is an array whose elements are arrays. The arrays that make up the elements can be of different sizes, which can result in less wasted space for some sets of data.|
|[CA1815: Override equals and operator equals on value types](../code-quality/ca1815-override-equals-and-operator-equals-on-value-types.md)|For value types, the inherited implementation of Equals uses the Reflection library and compares the contents of all fields. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances, or to use instances as hash table keys, your value type should implement Equals.|
|[CA1816: Call GC.SuppressFinalize correctly](../code-quality/ca1816-call-gc-suppressfinalize-correctly.md)|A method that is an implementation of Dispose does not call GC.SuppressFinalize, or a method that is not an implementation of Dispose calls GC.SuppressFinalize, or a method calls GC.SuppressFinalize and passes something other than this (Me in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]).|
|[CA1819: Properties should not return arrays](../code-quality/ca1819-properties-should-not-return-arrays.md)|Arrays that are returned by properties are not write-protected, even if the property is read-only. To keep the array tamper-proof, the property must return a copy of the array. Typically, users will not understand the adverse performance implications of calling such a property.|
|[CA1820: Test for empty strings using string length](../code-quality/ca1820-test-for-empty-strings-using-string-length.md)|Comparing strings by using the String.Length property or the String.IsNullOrEmpty method is significantly faster than using Equals.|
|[CA1821: Remove empty finalizers](../code-quality/ca1821-remove-empty-finalizers.md)|Whenever you can, avoid finalizers because of the additional performance overhead that is involved in tracking object lifetime. An empty finalizer incurs added overhead without any benefit.|
|[CA1822: Mark members as static](../code-quality/ca1822-mark-members-as-static.md)|Members that do not access instance data or call instance methods can be marked as static (Shared in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]). After you mark the methods as static, the compiler will emit nonvirtual call sites to these members. This can give you a measurable performance gain for performance-sensitive code.|
|[CA1823: Avoid unused private fields](../code-quality/ca1823-avoid-unused-private-fields.md)|Private fields were detected that do not appear to be accessed in the assembly.|
|[CA1824: Mark assemblies with NeutralResourcesLanguageAttribute](../code-quality/ca1824-mark-assemblies-with-neutralresourceslanguageattribute.md)|The NeutralResourcesLanguage attribute informs the ResourceManager of the language that was used to display the resources of a neutral culture for an assembly. This improves lookup performance for the first resource that you load and can reduce your working set.|
