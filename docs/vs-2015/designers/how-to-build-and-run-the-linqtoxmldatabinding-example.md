---
title: "How to: Build and Run the LinqToXmlDataBinding Example | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 3943deaf-80e2-4968-ac04-d3ef56cfad6c
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Build and Run the LinqToXmlDataBinding Example
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic shows how to create and build the LinqToXmlDataBinding Visual Studio project, and how to run the resulting LinqToXmlDataBinding Windows Presentation Foundation (WPF) example program.

 For more information about using Visual Studio to create projects, see [Application Development in Visual Studio](https://msdn.microsoft.com/97490c1b-a247-41fb-8f2c-bc4c201eff68).

## Creating and Populating the Project

#### To create the starting project

1. Start Visual Studio and create a C# WPF application named LinqToXmlDataBinding. The project must use the .NET Framework 3.5 (or later).

2. If not already present, add project references for the following .NET assemblies:

    - System.Data

    - System.Data.DataSetExtensions

    - System.Xml

    - System.Xml.Linq

3. Build the solution by pressing **Ctnrl+Shift+B**, then run it by pressing **F5**. The project should compile without errors and run as a generic WPF application.

#### To add custom code to the project

1. In the Solution Explorer, rename the source file Window1.xaml to L2XDBForm.xaml. The dependent source file Window1.xaml.cs should automatically be renamed to L2XDBForm.xaml.cs.

2. Replace the source code found in the file L2XDBForm.xaml with the code section from the topic [L2DBForm.xaml Source Code](../designers/l2dbform-xaml-source-code.md). (Use the XAML source view to work with this file.)

3. Similarly, replace the source in L2XDBForm.xaml.cs with the code found in [L2DBForm.xaml.cs Source Code](../designers/l2dbform-xaml-cs-source-code.md).

4. In the file App.xaml, replace all occurrences of the string "Window1.xaml" with "L2XDBForm.xaml".

5. Build the solution pressing **Ctrl+Shift+B**.

## Running the Program
 The LinqToXmlDataBinding program enables the user to view and manipulate a list of books that is stored as an embedded XML element.

#### To run the program and view the book list

1. Run LinqToXmlDataBinding by pressing **F5** (**Start Debugging**) or **Ctrl+F5** (**Start Without Debugging**). A program window with the title **WPF Data Binding using LINQ to XML** should be displayed.

2. Notice the top section of the UI, which displays the raw **XML** that represents the book list. It is displayed using a WPF <xref:System.Windows.Controls.TextBlock> control, which does not enable interaction through the mouse or keyboard.

3. The second vertical section, labeled **Book List**, displays the books as a plain text ordered list. It uses a <xref:System.Windows.Controls.ListBox> control that enables selection though the mouse or keyboard.

#### To add and delete books from the list

1. To delete an existing book from the list, select it in the **Book List** section, then click the **Remove Selected Book** button. Notice that the book entry has been removed from both the book and the raw XML source listings.

2. To add a new book to the list, enter values into the **ID** and **Value**<xref:System.Windows.Controls.TextBox> controls in the last section, **Add New Book**, then click the **Add Book** button. Note that the book is appended to the list in both the book and XML listings. This program does not validate input values.

#### To edit an existing book entry

1. Select the book entry in the second **Book List** section. Its current values should be displayed in the third section, **Edit Selected Book**.

2. Edit the values using the keyboard. As soon as either <xref:System.Windows.Controls.TextBox> control looses focus, changes are automatically propagated to the XML source and book listings.

## See Also
 [WPF Data Binding Using LINQ to XML Example](../designers/wpf-data-binding-using-linq-to-xml-example.md)
 [Walkthrough: LinqToXmlDataBinding Example](../designers/walkthrough-linqtoxmldatabinding-example.md)
 [Application Development in Visual Studio](https://msdn.microsoft.com/97490c1b-a247-41fb-8f2c-bc4c201eff68)
