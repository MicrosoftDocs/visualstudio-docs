---
title: "CA2233: Operations should not overflow | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "OperationsShouldNotOverflow"
  - "CA2233"
helpviewer_keywords: 
  - "OperationsShouldNotOverflow"
  - "CA2233"
ms.assetid: 3a2b06ba-6d1b-4666-9eaf-e053ef47ffaa
caps.latest.revision: 19
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2233: Operations should not overflow
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
 A method in the following example manipulates an integer that violates this rule. [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] requires the **Remove** integer overflow option to be disabled for this to fire.  
  
### Code  
 [!code-vb[FxCop.Usage.OperationOverflow#1](../code-quality/codesnippet/VisualBasic/ca2233-operations-should-not-overflow_1.vb)]
 [!code-cs[FxCop.Usage.OperationOverflow#1](../code-quality/codesnippet/CSharp/ca2233-operations-should-not-overflow_1.cs)]  
  
### Comments  
 If the method in this example is passed <xref:System.Int32.MinValue?displayProperty=fullName>, the operation would underflow. This causes the most significant bit of the result to be discarded. The following code shows how this occurs.  
  
 [C#]  
  
```  
public static void Main()  
{  
    int value = int.MinValue;    // int.MinValue is -2147483648   
    value = Calculator.Decrement(value);   
    Console.WriteLine(value);  
}  
```  
  
 [VB]  
  
```  
Public Shared Sub Main()       
    Dim value = Integer.MinValue    ' Integer.MinValue is -2147483648   
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
 [!code-cs[FxCop.Usage.OperationOverflowFixed#1](../code-quality/codesnippet/CSharp/ca2233-operations-should-not-overflow_2.cs)]
 [!code-vb[FxCop.Usage.OperationOverflowFixed#1](../code-quality/codesnippet/VisualBasic/ca2233-operations-should-not-overflow_2.vb)]  
  
## Fix with a Checked Block  
  
### Description  
 The following example fixes the previous violation by wrapping the operation in a checked block. If the operation causes an overflow, a <xref:System.OverflowException?displayProperty=fullName> will be thrown.  
  
 Note that checked blocks are not supported in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)].  
  
### Code  
 [!code-cs[FxCop.Usage.OperationOverflowChecked#1](../code-quality/codesnippet/CSharp/ca2233-operations-should-not-overflow_3.cs)]  
  
## Turn on Checked Arithmetic Overflow/Underflow  
 If you turn on checked arithmetic overflow/underflow in C#, it is equivalent to wrapping every integer operation in a checked block.  
  
 **To turn on checked arithmetic overflow/underflow in C#**  
  
1.  In **Solution Explorer**, right-click your project and choose **Properties**.  
  
2.  Select the **Build** tab and click **Advanced**.  
  
3.  Select **Check for arithmetic overflow/underflow** and click **OK**.  
  
## See Also  
 <xref:System.OverflowException?displayProperty=fullName>   
 [C# Operators](/dotnet/csharp/language-reference/operators/index)   
 [Checked and Unchecked](/dotnet/csharp/language-reference/keywords/checked-and-unchecked)