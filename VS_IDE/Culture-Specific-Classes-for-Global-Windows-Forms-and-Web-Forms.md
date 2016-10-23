---
title: "Culture-Specific Classes for Global Windows Forms and Web Forms"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0d06a0a4-f887-4f7c-bde7-1d543c06f803
caps.latest.revision: 10
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Culture-Specific Classes for Global Windows Forms and Web Forms
Each culture has different conventions for displaying dates, time, numbers, currency, and other information. The <xref:System.Globalization?qualifyHint=False> namespace contains classes that can be used to modify how culture-specific values are displayed, such as <xref:System.Globalization.DateTimeFormatInfo?qualifyHint=False>, **Calendar**, and <xref:System.Globalization.NumberFormatInfo?qualifyHint=False>.  
  
## Using the Culture Setting  
 But most of the time you will use the culture setting, stored either in the application or in the **Regional Options** control panel, to automatically determine the conventions at run time and format the information accordingly. For more information on setting the culture, see [How to: Set the Culture and UI Culture for Windows Forms Globalization](assetId:///694e049f-0b91-474a-9789-d35124f248f0) or [How to: Set the Culture and UI Culture for ASP.NET Web Page Globalization](../Topic/How%20to:%20Set%20the%20Culture%20and%20UI%20Culture%20for%20ASP.NET%20Web%20Page%20Globalization.md). Classes that automatically format information according to the culture setting are called culture-specific. Some culture-specific methods are <xref:System.IFormattable.ToString?qualifyHint=True>, <xref:System.Console.WriteLine?qualifyHint=True>, and <xref:System.String.Format?qualifyHint=True>. Some culture-specific functions (in the Visual Basic language) are `MonthName` and `WeekDayName`.  
  
 For example, the following code shows how you can use the <xref:System.IFormattable.ToString?qualifyHint=False> method to format currency for the current culture:  
  
```vb#  
' Put the Imports statements at the beginning of the code module  
Imports System.Threading  
Imports System.Globalization  
' Display a number with the culture-specific currency formatting  
Dim MyInt As Integer = 100  
Console.WriteLine(MyInt.ToString("C", Thread.CurrentThread.CurrentCulture))  
  
```  
  
```c#  
// Put the using statements at the beginning of the code module  
using System.Threading;  
using System.Globalization;  
// Display a number with the culture-specific currency formatting  
int myInt = 100;  
Console.WriteLine(myInt.ToString("C", Thread.CurrentThread.CurrentCulture));  
```  
  
 If the culture is set to "fr-FR", you will see this in the output window:  
  
 `100,00`  
  
 If the culture is set to "en-US", you will see this in the output window:  
  
 `$100.00`  
  
## See Also  
 <xref:System.IFormattable.ToString?qualifyHint=True>   
 <xref:System.Globalization.DateTimeFormatInfo?qualifyHint=False>   
 <xref:System.Globalization.NumberFormatInfo?qualifyHint=False>   
 <xref:System.Globalization.Calendar?qualifyHint=False>   
 <xref:System.Console.WriteLine?qualifyHint=True>   
 <xref:System.String.Format?qualifyHint=True>   
 [Globalizing and Localizing Applications](../VS_IDE/Globalizing-and-Localizing-Applications.md)