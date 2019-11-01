---
title: "CA1901: P-Invoke declarations should be portable | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1901"
  - "PInvokeDeclarationsShouldBePortable"
helpviewer_keywords:
  - "CA1901"
  - "PInvokeDeclarationsShouldBePortable"
ms.assetid: 90361812-55ca-47f7-bce9-b8775d3b8803
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1901: P/Invoke declarations should be portable
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|PInvokeDeclarationsShouldBePortable|
|CheckId|CA1901|
|Category|Microsoft.Portability|
|Breaking Change|Breaking - If the P/Invoke is visible outside the assembly. Non Breaking - If the P/Invoke is not visible outside the assembly.|

## Cause
 This rule evaluates the size of each parameter and the return value of a P/Invoke and verifies that their size, when marshaled to unmanaged code on 32-bit and 64-bit platforms, is correct. The most common violation of this rule is to pass a fixed-sized integer where a platform-dependent, pointer-sized variable is required.

## Rule Description
 Either of the following scenarios violates this rule occurs:

- The return value or parameter is typed as a fixed-size integer when it should be typed as an `IntPtr`.

- The return value or parameter is typed as an `IntPtr` when it should be typed as a fixed-size integer.

## How to Fix Violations
 You can fix this violation by using `IntPtr` or `UIntPtr` to represent handles instead of `Int32` or `UInt32`.

## When to Suppress Warnings
 You should not suppress this warning.

## Example
 The following example demonstrates a violation of this rule.

```csharp
internal class NativeMethods
{
    [DllImport("shell32.dll", CharSet=CharSet.Auto)]
    internal static extern IntPtr ExtractIcon(IntPtr hInst,
        string lpszExeFileName, IntPtr nIconIndex);
}
```

 In this example, the `nIconIndex` parameter is declared as an `IntPtr`, which is 4 bytes wide on a 32-bit platform and 8 bytes wide on a 64-bit platform. In the unmanaged declaration that follows, you can see that `nIconIndex` is a 4-byte unsigned integer on all platforms.

```csharp
HICON ExtractIcon(HINSTANCE hInst, LPCTSTR lpszExeFileName,
    UINT nIconIndex);
```

## Example
 To fix the violation, change the declaration to the following:

```csharp
internal class NativeMethods{
    [DllImport("shell32.dll", CharSet=CharSet.Auto)]
    internal static extern IntPtr ExtractIcon(IntPtr hInst,
        string lpszExeFileName, uint nIconIndex);
}
```

## See Also
 [Portability Warnings](../code-quality/portability-warnings.md)
