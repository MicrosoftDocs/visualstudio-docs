---
title: "CA1300: Specify MessageBoxOptions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "SpecifyMessageBoxOptions"
  - "CA1300"
helpviewer_keywords:
  - "SpecifyMessageBoxOptions"
  - "CA1300"
ms.assetid: 9357a724-026e-4a3d-a03a-f14635064ec6
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1300: Specify MessageBoxOptions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SpecifyMessageBoxOptions|
|CheckId|CA1300|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A method calls an overload of the <xref:System.Windows.Forms.MessageBox.Show%2A?displayProperty=fullName> method that does not take a <xref:System.Windows.Forms.MessageBoxOptions?displayProperty=fullName> argument.

## Rule Description
 To display a message box correctly for cultures that use a right-to-left reading order, the <xref:System.Windows.Forms.MessageBoxOptions> and <xref:System.Windows.Forms.MessageBoxOptions> members of the <xref:System.Windows.Forms.MessageBoxOptions> enumeration must be passed to the <xref:System.Windows.Forms.MessageBox.Show%2A> method. Examine the <xref:System.Windows.Forms.Control.RightToLeft%2A?displayProperty=fullName> property of the containing control to determine whether to use a right-to-left reading order.

## How to Fix Violations
 To fix a violation of this rule, call an overload of the <xref:System.Windows.Forms.MessageBox.Show%2A> method that takes a <xref:System.Windows.Forms.MessageBoxOptions> argument.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when the code library will not be localized for a culture that uses a right-to-left reading order.

## Example
 The following example shows a method that displays a message box that has options that are appropriate for the reading order of the culture. A resource file, which is not shown, is required to build the example. Follow the comments in the example to build the example without a resource file and to test the right-to-left feature.

 [!code-csharp[FxCop.Globalization.SpecifyMBOptions#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.SpecifyMBOptions/cs/FxCop.Globalization.SpecifyMBOptions.cs#1)]
 [!code-vb[FxCop.Globalization.SpecifyMBOptions#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Globalization.SpecifyMBOptions/vb/FxCop.Globalization.SpecifyMBOptions.vb#1)]

## See Also
 <xref:System.Resources.ResourceManager?displayProperty=fullName>
 [Resources in Desktop Apps](https://msdn.microsoft.com/library/8ad495d4-2941-40cf-bf64-e82e85825890)
