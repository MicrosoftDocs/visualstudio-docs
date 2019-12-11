---
title: "CA1302: Do not hardcode locale specific strings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotHardcodeLocaleSpecificStrings"
  - "CA1302"
helpviewer_keywords:
  - "DoNotHardcodeLocaleSpecificStrings"
  - "CA1302"
ms.assetid: 05ed134a-837d-43d7-bf97-906edeac44ce
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1302: Do not hardcode locale specific strings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotHardcodeLocaleSpecificStrings|
|CheckId|CA1302|
|Category|Microsoft.Globalization|
|Breaking Change|Non-breaking|

## Cause
 A method uses a string literal that represents part of the path of certain system folders.

## Rule Description
 The <xref:System.Environment.SpecialFolder?displayProperty=fullName> enumeration contains members that refer to special system folders. The locations of these folders can have different values on different operating systems, the user can change some of the locations, and the locations are localized. An example of a special folder is the System folder, which is "C:\WINDOWS\system32" on [!INCLUDE[winxp](../includes/winxp-md.md)] but "C:\WINNT\system32" on [!INCLUDE[win2kfamily](../includes/win2kfamily-md.md)]. The <xref:System.Environment.GetFolderPath%2A?displayProperty=fullName> method returns the locations that are associated with the <xref:System.Environment.SpecialFolder> enumeration. The locations that are returned by <xref:System.Environment.GetFolderPath%2A> are localized and appropriate for the currently running computer.

 This rule tokenizes the folder paths that are retrieved by using the <xref:System.Environment.GetFolderPath%2A> method into separate directory levels. Each string literal is compared to the tokens. If a match is found, it is assumed that the method is building a string that refers to the system location that is associated with the token. For portability and localizability, use the <xref:System.Environment.GetFolderPath%2A> method to retrieve the locations of the special system folders instead of using string literals.

## How to Fix Violations
 To fix a violation of this rule, retrieve the location by using the <xref:System.Environment.GetFolderPath%2A> method.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the string literal is not used to refer to one of the system locations that is associated with the <xref:System.Environment.SpecialFolder> enumeration.

## Example
 The following example builds the path of the common application data folder, which generates three warnings from this rule. Next, the example retrieves the path by using the <xref:System.Environment.GetFolderPath%2A> method.

 [!code-csharp[FxCop.Globalization.HardcodedLocaleStrings#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Globalization.HardcodedLocaleStrings/cs/FxCop.Globalization.HardcodedLocaleStrings.cs#1)]
 [!code-vb[FxCop.Globalization.HardcodedLocaleStrings#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Globalization.HardcodedLocaleStrings/vb/FxCop.Globalization.HardcodedLocaleStrings.vb#1)]

## Related Rules
 [CA1303: Do not pass literals as localized parameters](../code-quality/ca1303-do-not-pass-literals-as-localized-parameters.md)
