---
title: "Walkthrough: LinqToXmlDataBinding Example | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: aedf42e8-896c-48fa-88df-7f7c9536aa69
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: LinqToXmlDataBinding Example
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough describes the LinqToXmlDataBinding example, and explains some of the more interesting contents of its two primary source files, L2DBForm.xaml and L2DBForm.xaml.cs.

## Prerequisites
 Before you read this walkthrough, we highly recommended that you build and run the LinqToXmlDataBinding program as described in [How to: Build and Run the LinqToXmlDataBinding Example](../designers/how-to-build-and-run-the-linqtoxmldatabinding-example.md).

## Remarks
 The LinqToXmlDataBinding program is a Windows Presentation Foundation (WPF) application that is composed of C# and XAML source files. It contains an embedded XML document that defines a list of books, and enables the user to view, add, delete, and edit these entries. It is composed of the following two primary source files:

- L2DBForm.xaml contains the XAML declaration code for the user interface (UI) of the main window. It also contains a window resource section that defines a data provider and embedded XML document for the book listings.

- L2DBForm.xaml.cs contains the initialization and event-handling methods associated with the UI.

  The main window is divided into the following four vertical UI sections:

- **XML** displays the raw XML source of the embedded book listing.

- **Book List** displays the book entries as standard text and enables the user to select and delete individual entries.

- **Edit Selected Book** enables the user to edit the values associated with the currently selected book entry.

- **Add New Book** enables the creation of a new book entry based on values entered by the user.

## In This Section

|Topic|Description|
|-----------|-----------------|
|[L2DBForm.xaml Source Code](../designers/l2dbform-xaml-source-code.md)|Contains the contents and description of the XAML code in file L2DBForm.xaml.|
|[L2DBForm.xaml.cs Source Code](../designers/l2dbform-xaml-cs-source-code.md)|Contains the contents and description of the C# source code in the file L2DBForm.xaml.cs.|

## See Also
 [WPF Data Binding Using LINQ to XML Example](../designers/wpf-data-binding-using-linq-to-xml-example.md)
 [How to: Build and Run the LinqToXmlDataBinding Example](../designers/how-to-build-and-run-the-linqtoxmldatabinding-example.md)
