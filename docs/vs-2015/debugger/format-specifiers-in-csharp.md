---
title: "Format Specifiers in C# | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "CSharp"
helpviewer_keywords:
  - "expressions [C#], formatting values"
  - "variables [debugger], watch variable symbols"
  - "symbols, watch variable formatting"
  - "QuickWatch dialog box, using format specifiers"
  - "specifiers, watch variable format"
  - "QuickWatch dialog box, format specifiers in C#"
  - "specifiers"
  - "watch variable symbols"
  - "Watch window, format specifiers in C#"
  - "format specifiers, debugger"
  - "debugger, format specifiers recognized by"
ms.assetid: 345c8589-5f36-4d34-a58c-e56271687dd6
caps.latest.revision: 34
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Format Specifiers in C\#

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can change the format in which a value is displayed in the **Watch** window using format specifiers. You can also use format specifiers in the **Immediate** window, the **Command** window, and even in source windows. If you pause on an expression in those windows, the result will appear in a DataTip. DataTips will reflect the format specifier in the DataTip display.

To use a format specifier, type the expression followed by a comma. After the comma, add the appropriate specifier.

## Using Format Specifiers

If you have the following code:

```csharp
{
    int my_var1 = 0x0065;
    int my_var2 = 0x0066;
    int my_var3 = 0x0067;
}
```

Add the `my_var1` variable to the Watch window (while debugging, **Debug / Windows / Watch / Watch 1**) and set the display to hexadecimal (in the **Watch** window, right-click the variable and select **Hexadecimal Display**). Now the **Watch** window shows that it contains the value 0x0065. To see this value expressed as a decimal integer instead of a hexadecimal integer, in the Name column, after the variable name, add the decimal format specifier: **, d**. The Value column now displays the decimal value 101

![WatchFormatCSharp](../debugger/media/watchformatcsharp.png "WatchFormatCSharp")

## Format Specifiers

The following table shows the C# format specifiers recognized by the debugger.

|Specifier|Format|Original Watch Value|Displays|
|---------------|------------|--------------------------|--------------|
|ac|Force evaluation of an expression. This can be useful when implicit evaluation of properties and implicit function calls is turned off. See [Side Effects and Expressions](https://msdn.microsoft.com/library/e1f8a6ea-9e19-481d-b6bd-df120ad3bf4e).|Message “Implicit function evaluation is turned off by the user”|\<value>|
|d|decimal integer|0x0065|101|
|dynamic|Displays the specified object using a Dynamic View|Displays all the members of the object, including the Dynamic View|Displays only the Dynamic View|
|h|hexadecimal integer|61541|0x0000F065|
|nq|string with no quotes|"My String"|My String|
|hidden|Displays all public and non-public members|Displays public members|Displays all members|
|raw|Displays item as it appears in the raw item node. Valid on proxy objects only.|Dictionary\<T>|Raw View of Dictionary\<T>|
|results|Used with a variable of a type that implements IEnumerable or IEnumerable\<T>, usually the result of a query expression. Displays only the members that contain the query result.|Displays all the members.|Displays the members the meet the conditions of the query.|

## See Also

- [Watch and QuickWatch Windows](../debugger/watch-and-quickwatch-windows.md)
- [Variable Windows](https://msdn.microsoft.com/library/ce0a67f6-2502-4b7a-ba45-cc32f8aeba3e)
