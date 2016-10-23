---
title: "CA1300: Specify MessageBoxOptions"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9357a724-026e-4a3d-a03a-f14635064ec6
caps.latest.revision: 19
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
# CA1300: Specify MessageBoxOptions
|||  
|-|-|  
|TypeName|SpecifyMessageBoxOptions|  
|CheckId|CA1300|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method calls an overload of the <xref:System.Windows.Forms.MessageBox.Show?qualifyHint=True> method that does not take a <xref:System.Windows.Forms.MessageBoxOptions?qualifyHint=True> argument.  
  
## Rule Description  
 To display a message box correctly for cultures that use a right-to-left reading order, the <xref:System.Windows.Forms.MessageBoxOptions?qualifyHint=False> and <xref:System.Windows.Forms.MessageBoxOptions?qualifyHint=False> members of the <xref:System.Windows.Forms.MessageBoxOptions?qualifyHint=False> enumeration must be passed to the <xref:System.Windows.Forms.MessageBox.Show?qualifyHint=False> method. Examine the <xref:System.Windows.Forms.Control.RightToLeft?qualifyHint=True> property of the containing control to determine whether to use a right-to-left reading order.  
  
## How to Fix Violations  
 To fix a violation of this rule, call an overload of the <xref:System.Windows.Forms.MessageBox.Show?qualifyHint=False> method that takes a <xref:System.Windows.Forms.MessageBoxOptions?qualifyHint=False> argument.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the code library will not be localized for a culture that uses a right-to-left reading order.  
  
## Example  
 The following example shows a method that displays a message box that has options that are appropriate for the reading order of the culture. A resource file, which is not shown, is required to build the example. Follow the comments in the example to build the example without a resource file and to test the right-to-left feature.  
  
 [!CODE [FxCop.Globalization.SpecifyMBOptions#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Globalization.SpecifyMBOptions#1)]  
  
## See Also  
 <xref:System.Resources.ResourceManager?qualifyHint=True>   
 [Resources in Desktop Apps](../Topic/Resources%20in%20Desktop%20Apps.md)