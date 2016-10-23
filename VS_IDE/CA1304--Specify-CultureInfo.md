---
title: "CA1304: Specify CultureInfo"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b912d76a-54fd-4c93-b25d-16491e0ae319
caps.latest.revision: 20
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA1304: Specify CultureInfo
|||  
|-|-|  
|TypeName|SpecifyCultureInfo|  
|CheckId|CA1304|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method or constructor calls a member that has an overload that accepts a <xref:System.Globalization.CultureInfo?qualifyHint=True> parameter, and the method or constructor does not call the overload that takes the <xref:System.Globalization.CultureInfo?qualifyHint=False> parameter. This rule ignores calls to the following methods:  
  
-   <xref:System.Activator.CreateInstance?qualifyHint=True>  
  
-   <xref:System.Resources.ResourceManager.GetObject?qualifyHint=True>  
  
-   <xref:System.Resources.ResourceManager.GetString?qualifyHint=True>  
  
## Rule Description  
 When a <xref:System.Globalization.CultureInfo?qualifyHint=False> or <xref:System.IFormatProvider?qualifyHint=True> object is not supplied, the default value that is supplied by the overloaded member might not have the effect that you want in all locales. Also, .NET Framework members choose default culture and formatting based on assumptions that might not be correct for your code. To ensure the code works as expected for your scenarios, you should supply culture-specific information according to the following guidelines:  
  
-   If the value will be displayed to the user, use the current culture. See <xref:System.Globalization.CultureInfo.CurrentCulture?qualifyHint=True>.  
  
-   If the value will be stored and accessed by software, that is, persisted to a file or database, use the invariant culture. See <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=True>.  
  
-   If you do not know the destination of the value, have the data consumer or provider specify the culture.  
  
 Note that <xref:System.Globalization.CultureInfo.CurrentUICulture?qualifyHint=True> is used only to retrieve localized resources by using an instance of the <xref:System.Resources.ResourceManager?qualifyHint=True> class.  
  
 Even if the default behavior of the overloaded member is appropriate for your needs, it is better to explicitly call the culture-specific overload so that your code is self-documenting and more easily maintained.  
  
## How to Fix Violations  
 To fix a violation of this rule, use the overload that takes a <xref:System.Globalization.CultureInfo?qualifyHint=False> or <xref:System.IFormatProvider?qualifyHint=False> and specify the argument according to the guidelines that were listed earlier.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when it is certain that the default culture/format provider is the correct choice, and where code maintainability is not an important development priority.  
  
## Example  
 In the following example, `BadMethod` causes two violations of this rule. `GoodMethod` corrects the first violation by passing the invariant culture to System.String.Compare, and corrects the second violation by passing the current culture to <xref:System.String.ToLower?qualifyHint=False> because `string3` is displayed to the user.  
  
 [!CODE [FxCop.Globalization.CultureInfo#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Globalization.CultureInfo#1)]  
  
## Example  
 The following example shows the effect of current culture on the default <xref:System.IFormatProvider?qualifyHint=False> that is selected by the <xref:System.DateTime?qualifyHint=False> type.  
  
 [!CODE [FxCop.Globalization.IFormatProvider#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Globalization.IFormatProvider#1)]  
  
 This example produces the following output.  
  
 **6/4/1900 12:15:12 PM**  
**06/04/1900 12:15:12**   
## Related Rules  
 [CA1305: Specify IFormatProvider](../VS_IDE/CA1305--Specify-IFormatProvider.md)  
  
## See Also  
 [NIB: Using the CultureInfo Class](assetId:///d4329e34-64c3-4d1e-8c73-5b0ee626ba7a)