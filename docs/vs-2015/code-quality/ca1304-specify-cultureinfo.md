---
title: "CA1304: Specify CultureInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "SpecifyCultureInfo"
  - "CA1304"
helpviewer_keywords:
  - "SpecifyCultureInfo"
  - "CA1304"
ms.assetid: b912d76a-54fd-4c93-b25d-16491e0ae319
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1304: Specify CultureInfo
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SpecifyCultureInfo|
|CheckId|CA1304|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A method or constructor calls a member that has an overload that accepts a <xref:System.Globalization.CultureInfo?displayProperty=fullName> parameter, and the method or constructor does not call the overload that takes the <xref:System.Globalization.CultureInfo> parameter. This rule ignores calls to the following methods:

- <xref:System.Activator.CreateInstance%2A?displayProperty=fullName>

- <xref:System.Resources.ResourceManager.GetObject%2A?displayProperty=fullName>

- <xref:System.Resources.ResourceManager.GetString%2A?displayProperty=fullName>

## Rule Description
 When a <xref:System.Globalization.CultureInfo> or <xref:System.IFormatProvider?displayProperty=fullName> object is not supplied, the default value that is supplied by the overloaded member might not have the effect that you want in all locales. Also, [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] members choose default culture and formatting based on assumptions that might not be correct for your code. To ensure the code works as expected for your scenarios, you should supply culture-specific information according to the following guidelines:

- If the value will be displayed to the user, use the current culture. See <xref:System.Globalization.CultureInfo.CurrentCulture%2A?displayProperty=fullName>.

- If the value will be stored and accessed by software, that is, persisted to a file or database, use the invariant culture. See <xref:System.Globalization.CultureInfo.InvariantCulture%2A?displayProperty=fullName>.

- If you do not know the destination of the value, have the data consumer or provider specify the culture.

  Note that <xref:System.Globalization.CultureInfo.CurrentUICulture%2A?displayProperty=fullName> is used only to retrieve localized resources by using an instance of the <xref:System.Resources.ResourceManager?displayProperty=fullName> class.

  Even if the default behavior of the overloaded member is appropriate for your needs, it is better to explicitly call the culture-specific overload so that your code is self-documenting and more easily maintained.

## How to Fix Violations
 To fix a violation of this rule, use the overload that takes a <xref:System.Globalization.CultureInfo> or <xref:System.IFormatProvider> and specify the argument according to the guidelines that were listed earlier.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule when it is certain that the default culture/format provider is the correct choice, and where code maintainability is not an important development priority.

## Example
 In the following example, `BadMethod` causes two violations of this rule. `GoodMethod` corrects the first violation by passing the invariant culture to System.String.Compare, and corrects the second violation by passing the current culture to <xref:System.String.ToLower%2A> because `string3` is displayed to the user.

 [!code-csharp[FxCop.Globalization.CultureInfo#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.CultureInfo/cs/FxCop.Globalization.CultureInfo.cs#1)]

## Example
 The following example shows the effect of current culture on the default <xref:System.IFormatProvider> that is selected by the <xref:System.DateTime> type.

 [!code-csharp[FxCop.Globalization.IFormatProvider#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.IFormatProvider/cs/FxCop.Globalization.IFormatProvider.cs#1)]

 This example produces the following output.

 **6/4/1900 12:15:12 PM**
**06/04/1900 12:15:12**
## Related Rules
 [CA1305: Specify IFormatProvider](../code-quality/ca1305-specify-iformatprovider.md)

## See Also
 [NIB: Using the CultureInfo Class](https://msdn.microsoft.com/d4329e34-64c3-4d1e-8c73-5b0ee626ba7a)
