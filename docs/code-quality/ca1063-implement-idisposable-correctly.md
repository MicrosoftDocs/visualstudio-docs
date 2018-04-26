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

`IDisposable` is not implemented correctly. Some reasons for this problem are listed here:

- IDisposable is re-implemented in the class.

- Finalize is re-overridden.

- Dispose is overridden.

- Dispose() is not public, sealed, or named Dispose.

- Dispose(bool) is not protected, virtual, or unsealed.

- In unsealed types, Dispose() must call Dispose(true).

- For unsealed types, the Finalize implementation does not call either or both Dispose(bool) or the case class finalizer.

Violation of any one of these patterns will trigger this warning.

Every unsealed type that declares and implements the IDisposable interface must provide its own protected virtual void Dispose(bool) method. Dispose() should call Dipose(true) and Finalize should call Dispose(false). If you are creating an unsealed type that declares and implements the IDisposable interface, you must define Dispose(bool) and call it. For more information, see [Cleaning up unmanaged resources](/dotnet/standard/garbage-collection/unmanaged) in the [.NET Framework design guidelines](/dotnet/standard/design-guidelines/index).

## Rule description

All IDisposable types should implement the Dispose pattern correctly.

## How to fix violations

Examine your code and determine which of the following resolutions will fix this violation.

- Remove IDisposable from the list of interfaces that are implemented by {0} and override the base class Dispose implementation instead.

- Remove the finalizer from type {0}, override Dispose(bool disposing), and put the finalization logic in the code path where 'disposing' is false.

- Remove {0}, override Dispose(bool disposing), and put the dispose logic in the code path where 'disposing' is true.

- Ensure that {0} is declared as public and sealed.

- Rename {0} to 'Dispose' and make sure that it is declared as public and sealed.

- Make sure that {0} is declared as protected, virtual, and unsealed.

- Modify {0} so that it calls Dispose(true), then calls GC.SuppressFinalize on the current object instance ('this' or 'Me' in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]), and then returns.

- Modify {0} so that it calls Dispose(false) and then returns.

- If you are creating an unsealed type that declares and implements the IDisposable interface, make sure that the implementation of IDisposable follows the pattern that is described earlier in this section.

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
    // own unmanaged resources itself, but leave the other methods
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