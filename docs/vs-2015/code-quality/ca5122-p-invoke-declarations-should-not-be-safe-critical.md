---
title: "CA5122 P-Invoke declarations should not be safe critical | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: f2581a6d-2a0e-40c1-b600-f5dc70909200
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA5122 P/Invoke declarations should not be safe critical
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PInvokesShouldNotBeSafeCriticalFxCopRule|
|CheckId|CA5122|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A P/Invoke declaration has been marked with a <xref:System.Security.SecuritySafeCriticalAttribute>:

```csharp
[assembly: AllowPartiallyTrustedCallers]

// ...
public class C
{
    [SecuritySafeCritical]
    [DllImport("kernel32.dll")]
    public static extern bool Beep(int frequency, int duration); // CA5122 – safe critical p/invoke
   }
```

 In this example, `C.Beep(...)` has been marked as a security safe critical method.

## Rule Description
 Methods are marked as SecuritySafeCritical when they perform a security sensitive operation, but are also safe to be used by transparent code. One of the fundamental rules of the security transparency model is that transparent code may never directly call native code through a P/Invoke. Therefore, marking a P/Invoke as security safe critical will not enable transparent code to call it, and is misleading for security analysis.

## How to Fix Violations
 To make a P/Invoke available to transparent code, expose a security safe critical wrapper method for it:

```csharp
[assembly: AllowPartiallyTrustedCallers

class C
{
   [SecurityCritical]
   [DllImport(“kernel32.dll”, EntryPoint=”Beep”)]
   private static extern bool BeepPinvoke(int frequency, int duration); // Security Critical P/Invoke

   [SecuritySafeCritical]
   public static bool Beep(int frequency, int duration)
   {
      return BeepPInvoke(frequency, duration);
   }
}
```

## When to Suppress Warnings
 Do not suppress a warning from this rule.
