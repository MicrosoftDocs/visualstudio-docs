---
title: "CA2007: Do not directly await a Task"
ms.date: 03/08/2019
ms.topic: reference
f1_keywords:
  - "CA2007"
  - "DoNotDirectlyAwaitATaskAnalyzer"
helpviewer_keywords:
  - "CA2007"
author: gewarren
ms.author: gewarren
manager: jillfra
dev_langs:
 - CSharp
---
# CA2007: Do not directly await a Task

|||
|-|-|
|TypeName|DoNotDirectlyAwaitATaskAnalyzer|
|CheckId|CA2007|
|Category|Microsoft.Reliability|
|Breaking Change|Non-breaking|

## Cause

An asynchronous method [awaits](/dotnet/csharp/language-reference/keywords/await) a <xref:System.Threading.Tasks.Task> directly.

## Rule description

When an asynchronous method awaits a <xref:System.Threading.Tasks.Task> directly, the result is returned in the same thread that created the task. This can be costly in terms of performance and can result in a deadlock for a UI app. Consider calling <xref:System.Threading.Tasks.Task.ConfigureAwait(System.Boolean)?displayProperty=nameWithType> to return the result in a new thread. Otherwise, consumers of the library can face deadlocks if they consume the asynchronous method in a blocking fashion.

This rule was introduced with [FxCop analyzers](install-fxcop-analyzers.md) and doesn't exist in "legacy" (static code analysis) FxCop.

## How to fix violations

To fix violations, call <xref:System.Threading.Tasks.Task.ConfigureAwait%2A> on the awaited <xref:System.Threading.Tasks.Task>, passing `false` for the `continueOnCapturedContext` parameter.

## When to suppress warnings

You can suppress this warning if you know that the consumer is not a graphical user interface (GUI) app or if the consumer does not have a <xref:System.Threading.SynchronizationContext>.

## Example

The following code snippet generates the warning:

```csharp
public async Task Execute()
{
    Task task = null;
    await task;
}
```

To fix the violation, call <xref:System.Threading.Tasks.Task.ConfigureAwait%2A> on the awaited <xref:System.Threading.Tasks.Task>:

```csharp
public async Task Execute()
{
    Task task = null;
    await task.ConfigureAwait(false);
}
```

## See also

- [Install FxCop analyzers in Visual Studio](install-fxcop-analyzers.md)