---
title: "Globalization Warnings"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.codeanalysis.globalizationrules"
helpviewer_keywords: 
  - "warnings, globalization"
  - "globalization warnings"
  - "globalization [Visual Studio], warnings"
  - "managed code analysis warnings, globalization warnings"
ms.assetid: a8d12d41-14bf-4b43-af24-168312d7c390
caps.latest.revision: 21
ms.author: "douge"
manager: "douge"
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
# Globalization Warnings
Globalization warnings support world-ready libraries and applications.  
  
## In This Section  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1300: Specify MessageBoxOptions](../codequality/ca1300--specify-messageboxoptions.md)|To correctly display a message box for cultures that use a right-to-left reading order, the RightAlign and RtlReading members of the MessageBoxOptions enumeration must be passed to the Show method.|  
|[CA1301: Avoid duplicate accelerators](../codequality/ca1301--avoid-duplicate-accelerators.md)|An access key, also known as an accelerator, enables keyboard access to a control by using the ALT key. When multiple controls have duplicate access keys, the behavior of the access key is not well defined.|  
|[CA1302: Do not hardcode locale specific strings](../codequality/ca1302--do-not-hardcode-locale-specific-strings.md)|The System.Environment.SpecialFolder enumeration contains members that refer to special system folders. The locations of these folders can have different values on different operating systems; the user can change some of the locations; and the locations are localized. The Environment.GetFolderPath method returns the locations that are associated with the Environment.SpecialFolder enumeration, localized and appropriate for the currently running computer.|  
|[CA1303: Do not pass literals as localized parameters](../codequality/ca1303--do-not-pass-literals-as-localized-parameters.md)|An externally visible method passes a string literal as a parameter to a constructor or method in the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] class library, and that string should be localizable.|  
|[CA1304: Specify CultureInfo](../codequality/ca1304--specify-cultureinfo.md)|A method or constructor calls a member that has an overload that accepts a System.Globalization.CultureInfo parameter, and the method or constructor does not call the overload that takes the CultureInfo parameter. When a CultureInfo or System.IFormatProvider object is not supplied, the default value that is supplied by the overloaded member might not have the effect that you want in all locales.|  
|[CA1305: Specify IFormatProvider](../codequality/ca1305--specify-iformatprovider.md)|A method or constructor calls one or more members that have overloads that accept a System.IFormatProvider parameter, and the method or constructor does not call the overload that takes the IFormatProvider parameter. When a System.Globalization.CultureInfo or IFormatProvider object is not supplied, the default value that is supplied by the overloaded member might not have the effect that you want in all locales.|  
|[CA1306: Set locale for data types](../codequality/ca1306--set-locale-for-data-types.md)|The locale determines culture-specific presentation elements for data, such as formatting that is used for numeric values, currency symbols, and sort order. When you create a DataTable or DataSet, you should explicitly set the locale.|  
|[CA1307: Specify StringComparison](../codequality/ca1307--specify-stringcomparison.md)|A string comparison operation uses a method overload that does not set a StringComparison parameter.|  
|[CA1308: Normalize strings to uppercase](../codequality/ca1308--normalize-strings-to-uppercase.md)|Strings should be normalized to uppercase. A small group of characters cannot make a round trip when they are converted to lowercase.|  
|[CA1309: Use ordinal StringComparison](../codequality/ca1309--use-ordinal-stringcomparison.md)|A string comparison operation that is nonlinguistic does not set the StringComparison parameter to either Ordinal or OrdinalIgnoreCase. By explicitly setting the parameter to either StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase, your code often gains speed, becomes more correct, and becomes more reliable.|  
|[CA2101: Specify marshaling for P/Invoke string arguments](../codequality/ca2101--specify-marshaling-for-p-invoke-string-arguments.md)|A platform invoke member allows for partially trusted callers, has a string parameter, and does not explicitly marshal the string. This can cause a potential security vulnerability.|