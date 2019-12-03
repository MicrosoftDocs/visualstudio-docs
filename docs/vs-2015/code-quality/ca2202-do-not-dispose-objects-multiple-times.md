---
title: "CA2202: Do not dispose objects multiple times | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2202"
  - "Do not dispose objects multiple times"
  - "DoNotDisposeObjectsMultipleTimes"
helpviewer_keywords:
  - "CA2202"
ms.assetid: fa85349a-cf1e-42c8-a86b-eacae1f8bd96
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2202: Do not dispose objects multiple times
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotDisposeObjectsMultipleTimes|
|CheckId|CA2202|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A method implementation contains code paths that could cause multiple calls to <xref:System.IDisposable.Dispose%2A?displayProperty=fullName> or a Dispose equivalent, such as a Close() method on some types, on the same object.

## Rule Description
 A correctly implemented <xref:System.IDisposable.Dispose%2A> method can be called multiple times without throwing an exception. However, this is not guaranteed and to avoid generating a <xref:System.ObjectDisposedException?displayProperty=fullName> you should not call <xref:System.IDisposable.Dispose%2A> more than one time on an object.

## Related Rules
 [CA2000: Dispose objects before losing scope](../code-quality/ca2000-dispose-objects-before-losing-scope.md)

## How to Fix Violations
 To fix a violation of this rule, change the implementation so that regardless of the code path, <xref:System.IDisposable.Dispose%2A> is called only one time for the object.

## When to Suppress Warnings
 Do not suppress a warning from this rule. Even if <xref:System.IDisposable.Dispose%2A> for the object is known to be safely callable multiple times, the implementation might change in the future.

## Example
 Nested `using` statements (`Using` in Visual Basic) can cause violations of the CA2202 warning. If the IDisposable resource of the nested inner `using` statement contains the resource of the outer `using` statement, the `Dispose` method of the nested resource releases the contained resource. When this situation occurs, the `Dispose` method of the outer `using` statement attempts to dispose its resource for a second time.

 In the following example, a <xref:System.IO.Stream> object that is created in an outer using statement is released at the end of the inner using statement in the Dispose method of the <xref:System.IO.StreamWriter> object that contains the `stream` object. At the end of the outer `using` statement, the `stream` object is released a second time. The second release is a violation of CA2202.

```
using (Stream stream = new FileStream("file.txt", FileMode.OpenOrCreate))
{
    using (StreamWriter writer = new StreamWriter(stream))
    {
        // Use the writer object...
    }
}
```

## Example
 To resolve this issue, use a `try`/`finally` block instead of the outer `using` statement. In the `finally` block, make sure that the `stream` resource is not null.

```
Stream stream = null;
try
{
    stream = new FileStream("file.txt", FileMode.OpenOrCreate);
    using (StreamWriter writer = new StreamWriter(stream))
    {
        stream = null;
        // Use the writer object...
    }
}
finally
{
    if(stream != null)
        stream.Dispose();
}
```

## See Also
 <xref:System.IDisposable?displayProperty=fullName>
 [Dispose Pattern](https://msdn.microsoft.com/library/31a6c13b-d6a2-492b-9a9f-e5238c983bcb)
