---
title: "Globalization and localization of Excel solutions"
description: Learn about special considerations for Microsoft Office Excel solutions that will be run on computers that have non-English settings for Windows.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "globalization [Office development in Visual Studio], configuring"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Globalization and localization of Excel solutions

  This section contains information about special considerations for Microsoft Office Excel solutions that will be run on computers that have non-English settings for Windows. Most aspects of globalizing and localizing Microsoft Office solutions are the same as you encounter when you create other kinds of solutions using Visual Studio. For general information, see [Globalize and localizing applications](../ide/globalizing-and-localizing-applications.md).

 By default, host controls in Microsoft Office Excel work correctly in any Windows regional setting, as long as all data that is passed or manipulated using managed code is formatted using English (United States) formatting. In projects that target the .NET Framework 4 or the .NET Framework 4.5, this behavior is controlled by the common language runtime (CLR).

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Format data in Excel with various regional settings
 You must format all data that has locale-sensitive formatting, such as dates and currency, using the English (United States) data format (locale ID 1033) before you pass it to Microsoft Office Excel or read the data from code in your Office project.

 By default, when you develop an Office solution in Visual Studio, the Excel object model expects locale ID 1033 data formatting (this is also called locking the object model to locale ID 1033). This behavior matches the way that Visual Basic for Applications works. However, you can modify this behavior in your Office solutions.

### Understand how the Excel object model always expects locale ID 1033
 By default, Office solutions that you create by using Visual Studio are not affected by the end user's locale settings, and always behave as though the locale is English (United States). For example, if you get or set the <xref:Microsoft.Office.Interop.Excel.Range.Value2%2A> property in Excel, the data must be formatted the way that locale ID 1033 expects. If you use a different data format, you might get unexpected results.

 Even though you use the English (United States) format for data that is passed or manipulated by managed code, Excel interprets and displays the data correctly according to the end user's locale setting. Excel can format the data correctly because the managed code passes locale ID 1033 along with the data, which indicates that the data is in English (United States) format and therefore must be reformatted to match the user's locale setting.

 For example, if end users have their regional options set to the German (Germany) locale, they expect the date June 29, 2005, to be formatted this way: 29.06.2005. However, if your solution passes the date to Excel as a string, you must format the date according to English (United States) format: 6/29/2005. If the cell is formatted as a Date cell, Excel will display the date in German (Germany) format.

### Pass other locale IDs to the Excel object model
 The common language runtime (CLR) automatically passes locale ID 1033 to all methods and properties in the Excel object model that accept locale-sensitive data. There is no way to change this behavior automatically for all calls into the object model. However, you can pass a different locale ID to a specific method by using <xref:System.Type.InvokeMember%2A> to call the method and by passing the locale ID to the *culture* parameter of the method.

## Localize document text
 The document, template, or workbook in your project probably includes static text, which must be localized separately from the assembly and other managed resources. A straightforward way to do this is to make a copy of the document and translate the text using Microsoft Office Word or Microsoft Office Excel. This process works even if you make no changes to the code, because any number of documents can be linked to the same assembly.

 You must still make sure that any part of your code that interacts with the document text continues to match the language of the text, and that bookmarks, named ranges, and other display fields accommodate any reformatting of the Office document that was necessary to adjust for different grammar and text length. For document templates that contain relatively little text, you might want to consider storing the text in resource files, and then loading the text at run time.

### Text direction
 In Excel, you can set a property of the worksheet to render text right to left. Host controls, or any control that has a `RightToLeft` property, that is placed on the designer automatically match these settings at run time. Word does not have a document setting for bidirectional text (you just change your alignment of text), so the controls cannot be mapped to this setting. Instead, you must set the text alignment for each control. It is possible to write code to walk through all of the controls and force them to render text from right to left.

### Change culture
 Your document-level customization code typically shares the main UI thread of Excel, so any changes you make to the thread culture affects everything else that is running on that thread; the change is not restricted to your customization.

 Windows Forms controls are initialized before application-level VSTO Add-ins are started by the host application. In these situations, the culture should be changed before setting the UI controls.

## Install the language packs
 If you have non-English settings for Windows, you can install the  Visual Studio Tools for Office runtime  Language Packs to see  Visual Studio Tools for Office runtime  messages in the same language as Windows. If any end users run your solutions with non-English settings for Windows, they must have the correct language pack to see runtime messages in the same language as Windows. The  Visual Studio Tools for Office runtime  Language Packs are available from the [Microsoft download center](https://www.microsoft.com/download).

 In addition, the redistributable .NET Framework Language Packs are necessary for ClickOnce messages. The .NET Framework Language Packs are available from the [Microsoft download center](https://www.microsoft.com/download).

## Regional settings and Excel COM Calls
 Whenever a managed client calls a method on a COM object and it needs to pass in culture-specific information, it does so using the <xref:System.Globalization.CultureInfo.CurrentCulture%2A> (locale) that matches the current thread locale. The current thread locale is inherited from the user's regional settings by default. However, when you make a call into the Excel object model from an Excel solution created by using the Office development tools in Visual Studio, the English (United States) data format (locale ID 1033) is passed to the Excel object model automatically. You must format all data that has locale-sensitive formatting, such as dates and currency, using the English (United States) data format before you pass it to Microsoft Office Excel or read the data from your project code.

## Considerations for storing data
 To ensure that your data is correctly interpreted and displayed, you should also consider that problems can occur when an application is storing data, such as Excel worksheet formulas, in string literals (hard-coded) instead of in strongly-typed objects. You should use data that is formatted assuming a culture-invariant or English (United States) (the LCID value 1033) style.

### Applications that use string literals
 Possible values that might be hard-coded include date literals that are written in English (United States) format, and Excel worksheet formulas that contain localized function names. Another possibility might be a hard-coded string that contains a number such as "1,000"; in some cultures, this is interpreted as one thousand, but in other cultures, it represents one point zero. Calculations and comparisons performed on the wrong format might result in incorrect data.

 Excel interprets any strings in accordance with the LCID that is passed with the string. This can be a problem if the format of the string does not correspond to the LCID that is passed. Excel solutions created by using the Office development tools in Visual Studio use the LCID 1033 (en-US) when passing all data. Excel displays the data according to the regional settings and Excel user interface language. Visual Basic for Applications (VBA) also works this way; strings are formatted as en-US and VBA almost always passes 0 (language neutral) as the LCID. For example, the following VBA code displays a correctly formatted value for May 12, 2004, in accordance with the current user locale setting:

```vb
'VBA
Application.ActiveCell.Value2 = "05/12/04"
```

 The same code, when used in a solution created by using the Office development tools in Visual Studio and passed to Excel through COM interop, produces the same results when the date is formatted in en-US style.

 For example:

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreCreatingExcelCS/Sheet1.cs" id="Snippet6":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreCreatingExcelVB/Sheet1.vb" id="Snippet6":::
 ---

 You should work with strongly-typed data instead of string literals whenever possible. For example, instead of storing a date in a string literal, store it as a <xref:System.Double>, then convert it to a <xref:System.DateTime> object for manipulation.

 The following code example takes a date that a user enters into cell A5, stores it as a <xref:System.Double>, then converts it to a <xref:System.DateTime> object for display in cell A7. Cell A7 must be formatted to display a date.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreCreatingExcelCS/Sheet1.cs" id="Snippet7":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreCreatingExcelVB/Sheet1.vb" id="Snippet7":::
 ---

### Excel worksheet functions
 Worksheet function names are translated internally for most language versions of Excel. However, due to potential language and COM interop issues it is recommended that you use only English function names in your code.

### Applications that use external data
 Any code that opens or otherwise uses external data, such as files that include comma-separated values (CSV files) exported from a legacy system, might also be affected if such files are exported using any format besides en-US. Database access might not be affected because all values should be in binary format, unless the database stores dates as strings or performs operations that do not use binary format. Also, if you construct SQL queries using data from Excel, you might need to ensure they are in en-US format, depending on the function you use.

## Related content

- [How to: Target the Office multilingual user interface](../vsto/how-to-target-the-office-multilingual-user-interface.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
