---
title: "Culture-Specific Classes for Global Windows Forms and Web Forms | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "globalization [Windows Forms], classes"
  - "Web applications [.NET Framework], globalization"
  - "culture, culture-specific classes"
  - "numbers, international"
  - "localization [Windows Forms], classes"
  - "globalization [Visual Studio], culture-specific classes"
  - "Windows Forms, localization"
  - "international applications [Visual Studio], data formats"
  - "time [Visual Studio], international"
  - "dates [Visual Studio], international"
  - "culture"
  - "international characters"
  - "currency formats"
  - "ASP.NET, globalization"
  - "classes [Visual Studio], culture-specific"
  - "localization [Visual Studio], culture-specific classes"
ms.assetid: 0d06a0a4-f887-4f7c-bde7-1d543c06f803
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# Culture-Specific Classes for Global Windows Forms and Web Forms
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Each culture has different conventions for displaying dates, time, numbers, currency, and other information. The <xref:System.Globalization> namespace contains classes that can be used to modify how culture-specific values are displayed, such as <xref:System.Globalization.DateTimeFormatInfo>, **Calendar**, and <xref:System.Globalization.NumberFormatInfo>.

## Using the Culture Setting
 But most of the time you will use the culture setting, stored either in the application or in the **Regional Options** control panel, to automatically determine the conventions at run time and format the information accordingly. For more information on setting the culture, see [How to: Set the Culture and UI Culture for Windows Forms Globalization](https://msdn.microsoft.com/694e049f-0b91-474a-9789-d35124f248f0) or [How to: Set the Culture and UI Culture for ASP.NET Web Page Globalization](https://msdn.microsoft.com/library/76091f86-f967-4687-a40f-de87bd8cc9a0). Classes that automatically format information according to the culture setting are called culture-specific. Some culture-specific methods are <xref:System.IFormattable.ToString%2A?displayProperty=fullName>, <xref:System.Console.WriteLine%2A?displayProperty=fullName>, and <xref:System.String.Format%2A?displayProperty=fullName>. Some culture-specific functions (in the Visual Basic language) are `MonthName` and `WeekDayName`.

 For example, the following code shows how you can use the <xref:System.IFormattable.ToString%2A> method to format currency for the current culture:

```vb
' Put the Imports statements at the beginning of the code module
Imports System.Threading
Imports System.Globalization
' Display a number with the culture-specific currency formatting
Dim MyInt As Integer = 100
Console.WriteLine(MyInt.ToString("C", Thread.CurrentThread.CurrentCulture))

```

```csharp
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
 <xref:System.IFormattable.ToString%2A?displayProperty=fullName>
 <xref:System.Globalization.DateTimeFormatInfo>
 <xref:System.Globalization.NumberFormatInfo>
 <xref:System.Globalization.Calendar>
 <xref:System.Console.WriteLine%2A?displayProperty=fullName>
 <xref:System.String.Format%2A?displayProperty=fullName>
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)
