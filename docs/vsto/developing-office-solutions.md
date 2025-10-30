---
title: "Develop Office solutions"
description: Learn how to design a project by using Office developer tools in Visual Studio. Also learn how to begin implementing the code and custom user interface (UI).
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, about developing solutions"
  - "solutions [Office development in Visual Studio], developing"
  - "Office solutions [Office development in Visual Studio], developing"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Develop Office solutions

  After you design a project by using the Office developer tools in Visual Studio and set up the project files, you can begin to concentrate on implementing the code and custom user interface (UI).

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Office solutions programming model
 The Office object model exposes a variety of objects that you can program against. Whenever you program Office solutions by using managed code, you write code that uses types in the Office primary interop assemblies. In solutions you create by using the Office project templates in Visual Studio, you also write code directly against generated classes in your project. For more information, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

## Program different types of Office solutions
 The type of solution that you are creating determines which features you can use in your project. For example, you can add Windows Forms controls and extended Office controls (named *host controls*) to document-level customizations by dragging items from the **Toolbox** in Visual Studio at design time. However, if you are developing a VSTO Add-in, you can only add these sorts of controls to documents at run time, by writing code.

 For more information about features that are specific to different types of solutions, see the following topics:

- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- [Program document-level customizations](../vsto/programming-document-level-customizations.md).

- [Office UI customization](../vsto/office-ui-customization.md).

  For background information to help you plan your Office solutions and procedures to help you create projects, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)|Describes different aspects of writing code in Office solutions.|
|[Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)|Provides an overview of the programming model of VSTO Add-ins and related programming tasks.|
|[Program document-level customizations](../vsto/programming-document-level-customizations.md)|Provides an overview of the programming model of document-level customizations and related programming tasks.|
|[Office UI customization](../vsto/office-ui-customization.md)|Describes the different ways that you can customize the UI of Office applications by using VSTO Add-ins and document-level customizations.|
|[Data in Office solutions](../vsto/data-in-office-solutions.md)|Describes the different ways that you can work with data in Office solutions, such as binding data to controls and caching data in document-level customizations.|
|[Troubleshoot Office solutions](../vsto/troubleshooting-office-solutions.md)|Provides tips for solving common problems that you might encounter when creating Office solutions.|
|[Threading support in Office](../vsto/threading-support-in-office.md)|Provides an overview of working with multiple threads in Office solutions.|
|[Accessibility in Office projects](../vsto/accessibility-in-office-projects.md)|Describes the accessibility features that are available in Office solutions.|

## Related content
- [How to: Create and modify custom document properties](../vsto/how-to-create-and-modify-custom-document-properties.md)
- [How to: Read from and write to document properties](../vsto/how-to-read-from-and-write-to-document-properties.md)
- [How to: Target the Office multilingual user interface](../vsto/how-to-target-the-office-multilingual-user-interface.md)
- [Walkthrough: Create your first VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)
- [Walkthrough: Create your first document-level customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)
- [Walkthrough: Create your first VSTO Add-in for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)
- [Walkthrough: Create your first VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)
- [Walkthrough: Create your first VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)
- [Walkthrough: Create your first VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)
- [Walkthrough: Create your first document-level customization for Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md)
