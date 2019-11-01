---
title: "CA2233: Operations should not overflow | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "OperationsShouldNotOverflow"
  - "CA2233"
helpviewer_keywords:
  - "OperationsShouldNotOverflow"
  - "CA2233"
ms.assetid: 3a2b06ba-6d1b-4666-9eaf-e053ef47ffaa
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2233: Operations should not overflow
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OperationsShouldNotOverflow|
|CheckId|CA2233|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A method performs an arithmetic operation and does not validate the operands beforehand to prevent overflow.

## Rule Description
 Arithmetic operations should not be performed without first validating the operands to make sure that the result of the operation is not outside the range of possible values for the data types involved. Depending on the execution context and the data types involved, arithmetic overflow can result in either a <xref:System.OverflowException?displayProperty=fullName> or the most significant bits of the result discarded.

## How to Fix Violations
 To fix a violation of this rule, validate the operands before you perform the operation.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the possible values of the operands will never cause the arithmetic operation to overflow.

## Example of a Violation

### Description
 A method in the following example manipulates an integer that violates this rule. [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] requires the **Remove** integer overflow option to be disabled for this to fire.

### Code
 [!code-csharp[FxCop.Usage.OperationOverflow#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OperationOverflow/cs/FxCop.Usage.OperationOverflow.cs#1)]
 [!code-vb[FxCop.Usage.OperationOverflow#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.OperationOverflow/vb/FxCop.Usage.OperationOverflow.vb#1)]

### Comments
 If the method in this example is passed <xref:System.Int32.MinValue?displayProperty=fullName>, the operation would underflow. This causes the most significant bit of the result to be discarded. The following code shows how this occurs.

 [C#]

```
public static void Main()
{
    int value = int.MinValue;    // int.MinValue is -2147483648
    value = Calculator.Decrement(value);
    Console.WriteLine(value);
}
```

 [VB]

```
Public Shared Sub Main()
    Dim value = Integer.MinValue    ' Integer.MinValue is -2147483648
    value = Calculator.Decrement(value)
    Console.WriteLine(value)
End Sub
```

### Output

```
2147483647
```

## Fix with Input Parameter Validation

### Description
 The following example fixes the previous violation by validating the value of input.

### Code
 [!code-csharp[FxCop.Usage.OperationOverflowFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OperationOverflowFixed/cs/FxCop.Usage.OperationOverflowFixed.cs#1)]
 [!code-vb[FxCop.Usage.OperationOverflowFixed#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.OperationOverflowFixed/vb/FxCop.Usage.OperationOverflowFixed.vb#1)]

## Fix with a Checked Block

### Description
 The following example fixes the previous violation by wrapping the operation in a checked block. If the operation causes an overflow, a <xref:System.OverflowException?displayProperty=fullName> will be thrown.

 Note that checked blocks are not supported in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)].

### Code
 [!code-csharp[FxCop.Usage.OperationOverflowChecked#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OperationOverflowChecked/cs/FxCop.Usage.OperationOverflowChecked.cs#1)]

## Turn on Checked Arithmetic Overflow/Underflow
 If you turn on checked arithmetic overflow/underflow in C#, it is equivalent to wrapping every integer operation in a checked block.

 **To turn on checked arithmetic overflow/underflow in C#**

1. In **Solution Explorer**, right-click your project and choose **Properties**.

2. Select the **Build** tab and click **Advanced**.

3. Select **Check for arithmetic overflow/underflow** and click **OK**.

## See Also
 <xref:System.OverflowException?displayProperty=fullName>
 [C# Operators](https://msdn.microsoft.com/library/0301e31f-22ad-49af-ac3c-d5eae7f0ac43)
 [Checked and Unchecked](https://msdn.microsoft.com/library/a84bc877-2c7f-4396-8735-1ce97c42f35e)
