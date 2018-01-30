---
title: "Developing Office Solutions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office development in Visual Studio, about developing solutions"
  - "solutions [Office development in Visual Studio], developing"
  - "Office solutions [Office development in Visual Studio], developing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Developing Office Solutions
  After you design a project by using the Office developer tools in Visual Studio and set up the project files, you can begin to concentrate on implementing the code and custom user interface (UI).  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Office Solutions Programming Model  
 The Office object model exposes a variety of objects that you can program against. Whenever you program Office solutions by using managed code, you write code that uses types in the Office primary interop assemblies. In solutions you create by using the Office project templates in Visual Studio, you also write code directly against generated classes in your project. For more information, see [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md).  
  
## Programming Different Types of Office Solutions  
 The type of solution that you are creating determines which features you can use in your project. For example, you can add Windows Forms controls and extended Office controls (named *host controls*) to document-level customizations by dragging items from the **Toolbox** in Visual Studio at design time. However, if you are developing a VSTO Add-in, you can only add these sorts of controls to documents at run time, by writing code.  
  
 For more information about features that are specific to different types of solutions, see the following topics:  
  
-   [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
-   [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md).  
  
-   [Office UI Customization](../vsto/office-ui-customization.md).  
  
 For background information to help you plan your Office solutions and procedures to help you create projects, see [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)|Describes different aspects of writing code in Office solutions.|  
|[Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)|Provides an overview of the programming model of VSTO Add-ins and related programming tasks.|  
|[Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)|Provides an overview of the programming model of document-level customizations and related programming tasks.|  
|[Office UI Customization](../vsto/office-ui-customization.md)|Describes the different ways that you can customize the UI of Office applications by using VSTO Add-ins and document-level customizations.|  
|[Data in Office Solutions](../vsto/data-in-office-solutions.md)|Describes the different ways that you can work with data in Office solutions, such as binding data to controls and caching data in document-level customizations.|  
|[How AutoSave Impacts Office Solutions](./how-autosave-impacts-office-solutions.md)|Describes adjustments you might need to make to Office Solutions when AutoSave is enabled.|
|[Troubleshooting Office Solutions](../vsto/troubleshooting-office-solutions.md)|Provides tips for solving common problems that you might encounter when creating Office solutions.|  
|[Threading Support in Office](../vsto/threading-support-in-office.md)|Provides an overview of working with multiple threads in Office solutions.|  
|[Accessibility in Office Projects](../vsto/accessibility-in-office-projects.md)|Describes the accessibility features that are available in Office solutions.|  
  
## See Also  
 [How to: Create and Modify Custom Document Properties](../vsto/how-to-create-and-modify-custom-document-properties.md)   
 [How to: Read from and Write to Document Properties](../vsto/how-to-read-from-and-write-to-document-properties.md)   
 [How to: Target the Office Multilingual User Interface](../vsto/how-to-target-the-office-multilingual-user-interface.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)   
 [Walkthrough: Creating Your First Document-Level Customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)   
 [Walkthrough: Creating Your First VSTO Add-In for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)   
 [Walkthrough: Creating Your First VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)   
 [Walkthrough: Creating Your First Document-Level Customization For Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md)  
  
  