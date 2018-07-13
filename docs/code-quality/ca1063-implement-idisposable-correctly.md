---
title: "CA1063: Implement IDisposable correctly"
ms.date: 02/12/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ImplementIDisposableCorrectly"
  - "CA1063"
helpviewer_keywords:
  - "CA1063"
  - "ImplementIDisposableCorrectly"
ms.assetid: 12afb1ea-3a17-4a3f-a1f0-fcdb853e2359
author: gewarren
ms.author: gewarren
manager: douge
dev_langs:
 - "CSharp"
ms.workload:
  - "multiple"
---
# CA1063: Implement IDisposable correctly

|||
|-|-|
|TypeName|ImplementIDisposableCorrectly|
|CheckId|CA1063|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause

The <xref:System.IDisposable?displayProperty=nameWithType> interface is not implemented correctly. Possible reasons for this include:

- <xref:System.IDisposable> is reimplemented in the class.

- Finalize is re-overridden.

- Dispose() is overridden.

- The dispose method is not public, [sealed](/dotnet/csharp/language-reference/keywords/sealed), or named Dispose.

- Dispose(bool) is not protected, virtual, or unsealed.

- In unsealed types, Dispose() must call Dispose(true).

- For unsealed types, the Finalize implementation does not call either or both Dispose(bool) or the base class finalizer.

Violation of any one of these patterns triggers warning CA1063.

Every unsealed type that declares and implements the <xref:System.IDisposable> interface must provide its own protected virtual void Dispose(bool) method. Dispose() should call Dipose(true), and Finalize should call Dispose(false). If create an unsealed type that declares and implements the <xref:System.IDisposable> interface, you must define Dispose(bool) and call it. For more information, see [Clean up unmanaged resources](/dotnet/standard/garbage-collection/unmanaged) in the [.NET Framework design guidelines](/dotnet/standard/design-guidelines/index).

## Rule description

All <xref:System.IDisposable> types should implement the Dispose pattern correctly.

## How to fix violations

Examine your code and determine which of the following resolutions will fix this violation:

- Remove <xref:System.IDisposable> from the list of interfaces that are implemented by your type, and override the base class Dispose implementation instead.

- Remove the finalizer from your type, override Dispose(bool disposing), and put the finalization logic in the code path where 'disposing' is false.

- Remove Dispose(), override Dispose(bool disposing), and put the dispose logic in the code path where 'disposing' is true.

- Make sure that Dispose() is declared as public and [sealed](/dotnet/csharp/language-reference/keywords/sealed).

- Rename your dispose method to **Dispose** and make sure that it's declared as public and [sealed](/dotnet/csharp/language-reference/keywords/sealed).

- Make sure that Dispose(bool) is declared as protected, virtual, and unsealed.

- Modify your finalize method so that it calls Dispose(true), then calls GC.SuppressFinalize on the current object instance (`this`, or `Me` in Visual Basic), and then returns.

- Modify your finalize method so that it calls Dispose(false) and then returns.

- If you create an unsealed type that declares and implements the <xref:System.IDisposable> interface, make sure that the implementation of <xref:System.IDisposable> follows the pattern that is described earlier in this section.

## When to suppress warnings

Do not suppress a warning from this rule.

## Pseudo-code example

The following pseudo-code provides a general example of how Dispose(bool) should be implemented in a class that uses managed and native resources.

```csharp
public class Resource : IDisposable
{
    private IntPtr nativeResource = Marshal.AllocHGlobal(100);
    private AnotherResource managedResource = new AnotherResource();

    // Dispose() calls Dispose(true)
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // NOTE: Leave out the finalizer altogether if this class doesn't
    // own unmanaged resources, but leave the other methods
    // exactly as they are.
    ~Resource()
    {
        // Finalizer calls Dispose(false)
        Dispose(false);
    }

    // The bulk of the clean-up code is implemented in Dispose(bool)
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // free managed resources
            if (managedResource != null)
            {
                managedResource.Dispose();
                managedResource = null;
            }
        }
        // free native resources if there are any.
        if (nativeResource != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(nativeResource);
            nativeResource = IntPtr.Zero;
        }
    }
}
```