---
title: "Visio object model overview"
description: Explore the Visio object model and review the different types of objects you can use to develop Office solutions for Microsoft Visio.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visio [Office development in Visual Studio], object model"
  - "object models [Office development in Visual Studio], Office"
  - "object models [Office development in Visual Studio], Visio"
  - "objects [Office development in Visual Studio], Office object models"
  - "Office object models"
  - "Visio object model"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Visio object model overview

  To develop Office solutions for Microsoft Office Visio, you can interact with the Visio object model. This object model consists of classes and interfaces that are provided in the primary interop assembly for Visio, and are defined in the `Microsoft.Office.Interop.Visio` namespace.

 This topic provides a brief overview of the Visio object model. For information about using the Visio object model to perform tasks in Office projects, see the following topics:

- [Work with Visio documents](../vsto/working-with-visio-documents.md)

- [Work with Visio shapes](../vsto/working-with-visio-shapes.md)

## Understand the Visio object model
 Visio provides many objects with which you can interact. These objects are organized in a hierarchy that closely follows the user interface. At the top of the hierarchy is the [Microsoft.Office.Interop.Visio.Application](/office/vba/api/Visio.Application) object. This object represents the current instance of Visio. The `Microsoft.Office.Interop.Visio.Application` object contains the `Microsoft.Office.Interop.Visio.Document` and `Microsoft.Office.Interop.Visio.Page` objects as well as the `Microsoft.Office.Interop.Visio.Documents` and `Microsoft.Office.Interop.Visio.Pages` collections. Each of these objects and collections has many methods and properties that you can access to manipulate and interact with it.

 For more information, see the VBA reference documentation for [Microsoft.Office.Interop.Visio.Application](/office/vba/api/Visio.Application), [Microsoft.Office.Interop.Visio.Document](/office/vba/api/Visio.Document), and [Microsoft.Office.Interop.Visio.Page](/office/vba/api/Visio.Page) objects, and also the [Microsoft.Office.Interop.Visio.Documents](/office/vba/api/Visio.Documents) and [Microsoft.Office.Interop.Visio.Pages](/office/vba/api/Visio.Pages) collections.

 The following sections briefly describe the top-level objects and how they interact with each other. These objects include the following objects:

- Application object

- Document object

- Page object

### Application object
 The Microsoft.Office.Interop.Visio.Application object represents the Visio application, and is the parent of all of the other objects. Its members usually apply to Visio as a whole. You can use the properties and methods of the Microsoft.Office.Interop.Visio.Application and the `Microsoft.Office.Interop.Visio.ApplicationSettings` objects to control the Visio environment.

 In VSTO Add-in projects, you can access the Microsoft.Office.Interop.Visio.Application object by using the `Application` field of the `ThisAddIn` class. For more information, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).

### Document object
 The Microsoft.Office.Interop.Visio.Document object is central to programming Visio. It represents a drawing, stencil, or template file. When you open a Visio document or create a new document, you create a new Microsoft.Office.Interop.Visio.Document object, which is added to the Microsoft.Office.Interop.Visio.Documents collection of the Microsoft.Office.Interop.Visio.Application object.

 The document that has the focus is called the active document. It is represented by the `Microsoft.Office.Interop.Visio.Application.ActiveDocument` property of the Microsoft.Office.Interop.Visio.Application object.

### Page object
 The Microsoft.Office.Interop.Visio.Page object represents the drawing area of a foreground page or a background page. You can use the `Microsoft.Office.Interop.Visio.Page.Background` property to determine whether a page is a foreground or background page.

 To create shapes, you can use methods that include the `Microsoft.Office.Interop.Visio.Page.DrawSpline` and `Microsoft.Office.Interop.Visio.Page.DrawOval` methods. Additionally, you can retrieve masters from stencils and place the shapes on a page by using the `Microsoft.Office.Interop.Visio.Page.Drop` or `Microsoft.Office.Interop.Visio.Page.DropMany` methods.

## Use the Visio object model documentation
 For complete information about the Visio object model, you can refer to the Visio VBA object model reference. The VBA object model reference documents the Visio object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [Visio object model reference](/office/vba/api/overview/visio/object-model).

 All of the objects and members in the VBA object model reference correspond to types and members in the Visio primary interop assembly (PIA). For example, the `Document` object in the VBA object model reference corresponds to the Microsoft.Office.Interop.Visio.Document type in the Visio PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in a Visio VSTO Add-in project that you create by using Visual Studio.

> [!NOTE]
> At this time, there is no reference documentation for the Visio primary interop assembly.

 For related code samples and additional tools for creating Visio solutions, see [Visio 2010 software development kit](https://www.microsoft.com/download/details.aspx?id=12365).

### Additional types in primary interop assemblies
 You can find types in the primary interop assemblies that are not visible to VBA because of implementation differences. VBA provides a view of the Visio object model that includes only the objects and members that you can use directly. The primary interop assemblies expose the same object model, but they also include other interfaces, classes, and members that translate objects in the COM object model to managed code. These additional items are not intended to be used directly in your code.

 For more information, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12/ms247299(v=office.12)) and [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

## Related content
- [Visio solutions](../vsto/visio-solutions.md)
- [Work with Visio documents](../vsto/working-with-visio-documents.md)
- [Work with Visio shapes](../vsto/working-with-visio-shapes.md)
