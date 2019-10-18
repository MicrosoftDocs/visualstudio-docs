---
title: "CA1305: Specify IFormatProvider | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "SpecifyIFormatProvider"
  - "CA1305"
helpviewer_keywords:
  - "CA1305"
  - "SpecifyIFormatProvider"
ms.assetid: fb34ed9a-4eab-47cc-8eef-3068a4a1397e
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1305: Specify IFormatProvider
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SpecifyIFormatProvider|
|CheckId|CA1305|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A method or constructor calls one or more members that have overloads that accept a <xref:System.IFormatProvider?displayProperty=fullName> parameter, and the method or constructor does not call the overload that takes the <xref:System.IFormatProvider> parameter. This rule ignores calls to [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] methods that are documented as ignoring the <xref:System.IFormatProvider> parameter and additionally the following methods:

- <xref:System.Activator.CreateInstance%2A?displayProperty=fullName>

- <xref:System.Resources.ResourceManager.GetObject%2A?displayProperty=fullName>

- <xref:System.Resources.ResourceManager.GetString%2A?displayProperty=fullName>

## Rule Description
 When a <xref:System.Globalization.CultureInfo?displayProperty=fullName> or <xref:System.IFormatProvider> object is not supplied, the default value that is supplied by the overloaded member might not have the effect that you want in all locales. Also, [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] members choose default culture and formatting based on assumptions that might not be correct for your code. To make sure that the code works as expected for your scenarios, you should supply culture-specific information according to the following guidelines:

- If the value will be displayed to the user, use the current culture. See <xref:System.Globalization.CultureInfo.CurrentCulture%2A?displayProperty=fullName>.

- If the value will be stored and accessed by software (persisted to a file or database), use the invariant culture. See <xref:System.Globalization.CultureInfo.InvariantCulture%2A?displayProperty=fullName>.

- If you do not know the destination of the value, have the data consumer or provider specify the culture.

  Note that <xref:System.Globalization.CultureInfo.CurrentUICulture%2A?displayProperty=fullName> is used only to retrieve localized resources by using an instance of the <xref:System.Resources.ResourceManager?displayProperty=fullName> class.

  Even if the default behavior of the overloaded member is appropriate for your needs, it is better to explicitly call the culture-specific overload so that your code is self-documenting and more easily maintained.

## How to Fix Violations
 To fix a violation of this rule, use the overload that takes a <xref:System.Globalization.CultureInfo> or <xref:System.IFormatProvider> and specify the argument according to the guidelines that were listed earlier.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when it is certain that the default culture/format provider is the correct choice and where code maintainability is not an important development priority.

## Example
 In the following example, `BadMethod` causes two violations of this rule. `GoodMethod` corrects the first violation by passing the invariant culture to <xref:System.String.Compare%2A>, and corrects the second violation by passing the current culture to <xref:System.String.ToLower%2A> because `string3` is displayed to the user.

 [!code-csharp[FxCop.Globalization.CultureInfo#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.CultureInfo/cs/FxCop.Globalization.CultureInfo.cs#1)]

## Example
 The following example shows the effect of current culture on the default <xref:System.IFormatProvider> that is selected by the <xref:System.DateTime> type.

 [!code-csharp[FxCop.Globalization.IFormatProvider#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.IFormatProvider/cs/FxCop.Globalization.IFormatProvider.cs#1)]

 This example produces the following output.

 **6/4/1900 12:15:12 PM**
**06/04/1900 12:15:12**
## Related Rules
 [CA1304: Specify CultureInfo](../code-quality/ca1304-specify-cultureinfo.md)

## See Also
 [NIB: Using the CultureInfo Class](https://msdn.microsoft.com/d4329e34-64c3-4d1e-8c73-5b0ee626ba7a)
