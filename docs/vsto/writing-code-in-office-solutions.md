---
title: "Write code in Office solutions"
description: Learn how to write code in Microsoft Office solutions and learn about the way the Office object models are exposed to managed code.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VST.Project.RefactoringCancelled"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "solutions [Office development in Visual Studio], writing code"
  - "managed code [Office development in Visual Studio]"
  - "Office development in Visual Studio, programming languages supported"
  - "Office applications [Office development in Visual Studio], automating"
  - "Office applications [Office development in Visual Studio], writing code"
  - "writing code for Office solutions"
  - "programming [Office development in Visual Studio], model"
  - "Automation [Office development in Visual Studio], managed code"
  - "application development [Office development in Visual Studio], programming model"
  - "Office solutions [Office development in Visual Studio], writing code"
  - "automating Office applications"
  - "application development [Office development in Visual Studio], writing code"
  - "application development [Office development in Visual Studio], automating"
  - "Office projects [Office development in Visual Studio], changing namespaces"
  - "solutions [Office development in Visual Studio], programming model"
  - "programming [Office development in Visual Studio]"
  - "namespaces [Office developmentin Visual Studio], changing in Office solutions"
  - "projects [Office development in Visual Studio], writing code"
  - "Office applications [Office development in Visual Studio], programming model"
  - "managed code extensions [Office development in Visual Studio], writing code"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Write code in Office solutions

  There are some aspects of writing code in Office projects that are different from other types of projects in Visual Studio. Many of these differences are related to the way the Office object models are exposed to managed code. Other differences are related to the design of Office projects.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Managed code and Office programming
 The key technology that makes creating an integrated Microsoft Office solution possible is Automation, which is part of the Component Object Model (COM) technology. Automation enables you to use code to create and control software objects exposed by any application, DLL, or ActiveX control that supports the appropriate programmatic interfaces.

### Understand primary interop assemblies
 Microsoft Office applications expose much of their functionality to Automation. However, you cannot use managed code (such as Visual Basic or C#) directly to automate Office applications. To automate Office applications by using managed code, you must use the Office primary interop assemblies (PIAs). The primary interop assemblies enable managed code to interact with the COM-based object model of the Office applications.

 Every Microsoft Office application has a PIA. When you create an Office project in Visual Studio, a reference to the appropriate PIA is automatically added to the project. To automate the features of other Office applications from the project, you must add a reference to the appropriate PIA manually. For more information, see [How to: Target Office applications through primary interop assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md).

### Use primary interop assemblies at design time and runtime
 You must have the Office PIAs installed and registered in the global assembly cache on your development computer to perform most development tasks. For more information, see [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

 The Office PIAs are not required on end-user computers to run Office solutions that target the .NET Framework 4 or later. For more information, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

### Use types in primary interop assemblies
 The Office PIAs contain a combination of types that expose the object model of the Office applications and additional infrastructure types that are not intended to be used directly in your code. For an overview of the types in the Office PIAs, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12/ms247299\(v\=office.12\)).

 Because the types in the Office PIAs correspond to types in the COM-based object models, the way you use these types is often different from other managed types. For example, the way you call methods that have optional parameters in an Office primary interop assembly depends on the programming language you are using in your project. For more information, see the following topics:

- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md).

- [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md).

## Program model of Office projects
 All Office projects include one or more generated classes that provide the entry point for your code. These classes also provide access to the object model of the host application and access to features like actions panes and custom task panes.

### Understand the generated classes
 In document-level projects for Excel and Word, the generated class resembles a top-level object in the application's object model. For example, the generated `ThisDocument` class in a Word document project provides the same members as the <xref:Microsoft.Office.Interop.Word.Document> class in the Word object model. For more information about the generated classes in document-level projects, see [Program document-level customizations](../vsto/programming-document-level-customizations.md).

 VSTO Add-in projects provide a generated class called `ThisAddIn`. This class does not resemble a class in the host application's object model. Instead, this class represents the VSTO Add-in itself, and it provides members you can use to access the object model of the host application and access other features available to VSTO Add-ins. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

 All generated classes in Office projects include `Startup` and `Shutdown` event handlers. To get started writing code, you typically add code to these event handlers. To initialize your VSTO Add-in, you can add code to the `Startup` event handler. To clean up resources used by your VSTO Add-in, you can add code to the `Shutdown` event handler. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### Access the generated classes at run time
 When an Office solution is loaded, the  Visual Studio Tools for Office runtime  instantiates each of the generated classes in your project. You can access these objects from any code in your project by using the `Globals` class. For example, you can use the `Globals` class to call code in the `ThisAddIn` class from an event handler of a Ribbon button in a VSTO Add-in.

 For more information, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

### Namespace considerations in Office solutions
 You cannot change the *default namespace* (or *root namespace* in Visual Basic) of an Office project after you create the project. The default namespace will always match the project name you specified when you created the project. If you rename your project, the default namespace does not change. For more information about the default namespace in projects, see [Application Page, Project Designer &#40;C&#35;&#41;](../ide/reference/application-page-project-designer-csharp.md) and [Application Page, Project Designer &#40;Visual Basic&#41;](../ide/reference/application-page-project-designer-visual-basic.md).

### Change the namespace of host item classes in C# projects
 Host item classes (for example, the `ThisAddIn`, `ThisWorkbook`, or `ThisDocument` classes) have their own namespaces in Visual C# Office projects. By default, the namespace for host items in your project matches the project name you specified when you created the project.

 To change the namespace of the host items in a Visual C# Office project, use the **Namespace for Host Item** property. For more information, see [Properties in Office projects](../vsto/properties-in-office-projects.md).

## Supported programming languages in Office projects
 The Office project templates in Visual Studio support only the Visual Basic and Visual C# programming languages. Therefore, these project templates are available only under the **Visual Basic** and **Visual C#** nodes of the **New Project** dialog box in Visual Studio. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

## Language choice and Office programming
 Microsoft Office and Visual Basic for Applications (VBA) were developed to work together to optimize the workflow of application customization. Visual Basic has inherited some of those developments. For example, Visual Basic supports optional parameters, which means that you can write less code when calling some methods in the Microsoft Office primary interop assemblies than when you use Visual C#.

## Program with Visual Basic vs. Visual C# in Office solutions
 You can create Office solutions by using either Visual Basic or Visual C#. Because the Microsoft Office object models were designed to be used with Microsoft Visual Basic for Applications (VBA), Visual Basic developers can work comfortably with the objects exposed by the Microsoft Office applications. Visual C# developers can use most of the same features as Visual Basic developers, but there are some cases where they must write additional code to use the Office object models. There are also some differences between basic programming features in Office development and managed code written in Visual Basic and C#.

<!-- markdownlint-disable MD003 MD020 -->
## Key differences between Visual Basic and Visual C#
<!-- markdownlint-enable MD003 MD020 -->

The following table shows key differences between Visual Basic and Visual C# in Office development.

|Feature|Description|Visual Basic support|Visual C# support|
|-------------|-----------------|--------------------------|------------------------|
|Optional parameters|Many Microsoft Office methods have parameters that are not required when you call the method. If no value is passed for the parameter, a default value is used.|Visual Basic supports optional parameters.|Visual C# supports optional parameters in most cases. For more information, see [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md).|
|Passing parameters by reference|Optional parameters in most of the Microsoft Office primary interop assemblies can be passed by value. However, in some primary interop assemblies, optional parameters that accept reference types must be passed by reference.<br /><br /> For more information about value and reference type parameters, see [Pass arguments by value and by reference &#40;Visual Basic&#41;](/dotnet/visual-basic/programming-guide/language-features/procedures/passing-arguments-by-value-and-by-reference) (for Visual Basic) and [Pass parameters &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters).|No additional work is needed to pass parameters by reference. The Visual Basic compiler automatically passes the parameters by reference when necessary.|In most cases, the Visual C# compiler automatically passes the parameters by reference when necessary. For more information, see [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md).|
|Parameterized properties|Some properties accept parameters, and act as read-only functions.|Visual Basic supports properties that accept parameters.|Visual C# supports properties that accept parameters.|
|Late binding|Late binding involves determining the properties of objects at run time, instead of casting variables to the object type at design time.|Visual Basic performs late binding when **Option Strict** is off. When **Option Strict** is on, you must explicitly convert objects and use types in the <xref:System.Reflection> namespace to access late-bound members. For more information, see [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md).|Visual C# performs late binding in projects that target the .NET Framework 4. For more information, see [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md).|

## Key differences between Office development and managed code
 The following table shows key differences between Office development and managed code written in Visual Basic or Visual C#.

|Feature|Description|Visual Basic and Visual C# support|
|-------------|-----------------|-----------------------------------------|
|Array indexes|The lower array bound of collections in Microsoft Office applications begins with 1. Visual Basic and Visual C# use 0-based arrays. For more information, see [Arrays &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/arrays/index) and [Arrays in Visual Basic](/dotnet/visual-basic/programming-guide/language-features/arrays/index).|To access the first item of a collection in the object model of a Microsoft Office application, use the index 1 instead of 0.|

## Related content

- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Events in Office projects](../vsto/events-in-office-projects.md)
- [How to: Target Office applications through primary interop assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md)
- [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md)
- [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md)
- [Collaborative development of Office solutions](../vsto/collaborative-development-of-office-solutions.md)
