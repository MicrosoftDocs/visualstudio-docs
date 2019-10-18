---
title: "CA1060: Move P-Invokes to NativeMethods class | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MovePInvokesToNativeMethodsClass"
  - "CA1060"
helpviewer_keywords:
  - "MovePInvokesToNativeMethodsClass"
  - "CA1060"
ms.assetid: 06686c8c-6ad3-42f7-a355-cbaefa347cfc
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1060: Move P/Invokes to NativeMethods class
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MovePInvokesToNativeMethodsClass|
|CheckId|CA1060|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A method uses Platform Invocation Services to access unmanaged code and is not a member of one of the **NativeMethods** classes.

## Rule Description
 Platform Invocation methods, such as those that are marked by using the <xref:System.Runtime.InteropServices.DllImportAttribute?displayProperty=fullName> attribute, or methods that are defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], access unmanaged code. These methods should be in one of the following classes:

- **NativeMethods** - This class does not suppress stack walks for unmanaged code permission. (<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute?displayProperty=fullName> must not be applied to this class.) This class is for methods that can be used anywhere because a stack walk will be performed.

- **SafeNativeMethods** - This class suppresses stack walks for unmanaged code permission. (<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute?displayProperty=fullName> is applied to this class.) This class is for methods that are safe for anyone to call. Callers of these methods are not required to perform a full security review to make sure that the usage is secure because the methods are harmless for any caller.

- **UnsafeNativeMethods** - This class suppresses stack walks for unmanaged code permission. (<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute?displayProperty=fullName> is applied to this class.) This class is for methods that are potentially dangerous. Any caller of these methods must perform a full security review to make sure that the usage is secure because no stack walk will be performed.

  These classes are declared as `internal` (`Friend`, in Visual Basic) and declare a private constructor to prevent new instances from being created. The methods in these classes should be `static` and `internal` (`Shared` and `Friend` in Visual Basic).

## How to Fix Violations
 To fix a violation of this rule, move the method to the appropriate **NativeMethods** class. For most applications, moving P/Invokes to a new class that is named **NativeMethods** is enough.

 However, if you are developing libraries for use in other applications, you should consider defining two other classes that are called **SafeNativeMethods** and **UnsafeNativeMethods**. These classes resemble the **NativeMethods** class; however, they are marked by using a special attribute called **SuppressUnmanagedCodeSecurityAttribute**. When this attribute is applied, the runtime does not perform a full stack walk to make sure that all callers have the **UnmanagedCode** permission. The runtime ordinarily checks for this permission at startup. Because the check is not performed, it can greatly improve performance for calls to these unmanaged methods, It also enables code that has limited permissions to call these methods.

 However, you should use this attribute with great care. It can have serious security implications if it is implemented incorrectly..

 For information about how to implement the methods, see the **NativeMethods** Example, **SafeNativeMethods** Example, and **UnsafeNativeMethods** Example.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example declares a method that violates this rule. To correct the violation, the **RemoveDirectory** P/Invoke should be moved to an appropriate class that is designed to hold only P/Invokes.

 [!code-csharp[FxCop.Design.DllImportNativeMethods#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.DllImportNativeMethods/cs/FxCop.Design.DllImportNativeMethods.cs#1)]
 [!code-vb[FxCop.Design.DllImportNativeMethods#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.DllImportNativeMethods/vb/FxCop.Design.DllImportNativeMethods.vb#1)]

## NativeMethods Example

### Description
 Because the **NativeMethods** class should not be marked by using **SuppressUnmanagedCodeSecurityAttribute**, P/Invokes that are put in it will require **UnmanagedCode** permission. Because most applications run from the local computer and run together with full trust, this is usually not a problem. However, if you are developing reusable libraries, you should consider defining a **SafeNativeMethods** or **UnsafeNativeMethods** class.

 The following example shows an **Interaction.Beep** method that wraps the **MessageBeep** function from user32.dll. The **MessageBeep** P/Invoke is put in the **NativeMethods** class.

### Code
 [!code-csharp[FxCop.Design.NativeMethods#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethods/cs/FxCop.Design.NativeMethods.cs#1)]
 [!code-vb[FxCop.Design.NativeMethods#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethods/vb/FxCop.Design.NativeMethods.vb#1)]

## SafeNativeMethods Example

### Description
 P/Invoke methods that can be safely exposed to any application and that do not have any side effects should be put in a class that is named **SafeNativeMethods**. You do not have to demand permissions and you do not have to pay much attention to where they are called from.

 The following example shows an **Environment.TickCount** property that wraps the **GetTickCount** function from kernel32.dll.

### Code
 [!code-csharp[FxCop.Design.NativeMethodsSafe#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethodsSafe/cs/FxCop.Design.NativeMethodsSafe.cs#1)]
 [!code-vb[FxCop.Design.NativeMethodsSafe#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethodsSafe/vb/FxCop.Design.NativeMethodsSafe.vb#1)]

## UnsafeNativeMethods Example

### Description
 P/Invoke methods that cannot be safely called and that could cause side effects should be put in a class that is named **UnsafeNativeMethods**. These methods should be rigorously checked to make sure that they are not exposed to the user unintentionally. The rule [CA2118: Review SuppressUnmanagedCodeSecurityAttribute usage](../code-quality/ca2118-review-suppressunmanagedcodesecurityattribute-usage.md) can help with this. Alternatively, the methods should have another permission that is demanded instead of **UnmanagedCode** when they use them.

 The following example shows a **Cursor.Hide** method that wraps the **ShowCursor** function from user32.dll.

### Code
 [!code-csharp[FxCop.Design.NativeMethodsUnsafe#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethodsUnsafe/cs/FxCop.Design.NativeMethodsUnsafe.cs#1)]
 [!code-vb[FxCop.Design.NativeMethodsUnsafe#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.NativeMethodsUnsafe/vb/FxCop.Design.NativeMethodsUnsafe.vb#1)]

## See Also
 [Design Warnings](../code-quality/design-warnings.md)
