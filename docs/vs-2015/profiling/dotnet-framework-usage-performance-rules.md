---
title: ".NET Framework Usage Performance Rules | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: ab573755-6370-48aa-853d-a7321c424c79
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# .NET Framework Usage Performance Rules
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Performance rules in the.NET Framework Usage category identify specific methods that can be optimized and also identify more general usage patterns, such as garbage collection and lock contention, that can be investigated for performance issues.  
  
|||  
|-|-|  
|[DA0001: Use StringBuilder for concatenations](../profiling/da0001-use-stringbuilder-for-concatenations.md)|Calls to <xref:System.String.Concat%28System.String%2CSystem.String%29?displayProperty=fullName> are a significant proportion of the profiling data. Consider using the <xref:System.Text.StringBuilder> class to construct strings from multiple segments.|  
|[DA0005: Frequent GC2 collections](../profiling/da0005-frequent-gc2-collections.md)|A relatively high number of .NET memory objects are being reclaimed in generation 2 garbage collection. If too many short-lived objects survive generation 1 collection, the cost of memory management can easily become excessive.|  
|[DA0006: Override Equals() for value types](../profiling/da0006-override-equals-parens-for-value-types.md)|Calls to the `Equals` method or the equality operators of a public value type are a significant proportion of the profiling data. Consider implementing a more efficient method.|  
|[DA0007: Avoid using exceptions for control flow](../profiling/da0007-avoid-using-exceptions-for-control-flow.md)|A high rate of .NET Framework exception handlers were called in the profiling data. Consider using other control flow logic to reduce the number of exceptions that are thrown.|  
|[DA0010: Expensive GetHashCode](../profiling/da0010-expensive-gethashcode.md)|Calls to the `GetHashCode` method of the type are a significant proportion of the profiling data or the `GetHashCode` method allocates memory. Reduce the complexity of the method.|  
|[DA0011: Expensive CompareTo](../profiling/da0011-expensive-compareto.md)|The `CompareTo` method of the type is expensive or the method allocates memory. Reduce the complexity of the `CompareTo` method.|  
|[DA0012: Significant amount of Reflection](../profiling/da0012-significant-amount-of-reflection.md)|Calls to the <xref:System.Reflection?displayProperty=fullName> methods such as <xref:System.Reflection.IReflect.InvokeMember%2A> and <xref:System.Reflection.IReflect.GetMember%2A> or to Type methods such as <xref:System.Type.InvokeMember%2A> are a significant proportion of the profiling data. When possible, consider replacing these methods with early binding to the methods of dependent assemblies.|  
|[DA0013: High usage of String.Split or String.Substring](../profiling/da0013-high-usage-of-string-split-or-string-substring.md)|Calls to the <xref:System.String.Split%2A?displayProperty=fullName> or <xref:System.String.Substring%2A> methods are a significant portion of the profiling data. Consider using <xref:System.String.IndexOf%2A> or <xref:System.String.IndexOfAny%2A> if you are testing for the existence of a substring in a string.|  
|[DA0018: 32-bit Application running at process managed memory limits](../profiling/da0018-32-bit-application-running-at-process-managed-memory-limits.md)|System data that is collected during the profiling run indicates the .NET Framework memory heaps approached the maximum size that the managed heaps can reach in a 32-bit process. Consider profiling again using the .NET memory profiling method and optimizing the use of managed resources by the application.|  
|[DA0021: High rate of Gen 1 garbage collections](../profiling/da0021-high-rate-of-gen-1-garbage-collections.md)|A relatively high number of .NET memory objects are being reclaimed in generation 1 garbage collection. If too many short-lived objects survive generation 0 collection, the cost of memory management can easily become excessive.|  
|[DA0022: High rate of Gen 2 garbage collections](../profiling/da0022-high-rate-of-gen-2-garbage-collections.md)|A high number of .NET memory objects are being reclaimed in generation 2 garbage collection. If too many short-lived objects survive generation 1 collection, the cost of memory management can easily become excessive. This rule fires when the rate of lock contentions exceeds the upper threshold value of rule DA0005.|  
|[DA0023: High GC CPU time](../profiling/da0023-high-gc-cpu-time.md)|System performance data that is collected during profiling indicates that the amount of time that is spent in garbage collection is significant compared with the total application processing time.|  
|[DA0024: Excessive GC CPU Time](../profiling/da0024-excessive-gc-cpu-time.md)|System performance data that is collected during profiling indicates that the amount of time that is spent in garbage collection is excessively high compared with the total application processing time. This rule fires when the amount of time spent in garbage collection exceeds the upper threshold value of rule DA0023.|  
|[DA0038: High Rate of Lock contentions](../profiling/da0038-high-rate-of-lock-contentions.md)|System performance data that is collected with the profiling data indicates that a significantly high rate of lock contentions occurred during application execution. Consider profiling again using the concurrency profiling method to find the cause of the contentions.|  
|[DA0039: Very High Rate of Lock contentions](../profiling/da0039-very-high-rate-of-lock-contentions.md)|System performance data that is collected with the profiling data indicates that an excessively high rate of lock contentions occurred during application execution. Consider profiling again using the concurrency profiling method to find the cause of the contentions. This rule fires when the rate of lock contentions exceeds the upper threshold value of rule DA0038.|
