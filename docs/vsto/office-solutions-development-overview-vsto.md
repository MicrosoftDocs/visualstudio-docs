---
title: "Office solutions development overview (VSTO)"
description: Customize familiar Microsoft Office user interface items and tools, such as the word processing features in Word and the data analysis features of Excel.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "primary interop assemblies, Office"
  - "Office development in Visual Studio, about developing solutions"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Office solutions development overview (VSTO)

  By using Microsoft Office as the front end for solutions, you can take advantage of the familiar Microsoft Office user interfaces and tools such as the word processing features in Word, the data analysis features of Excel, and the e-mail management features of Outlook. You can develop solutions in Visual Studio to customize Office applications and add the specific features you need for your business processes. For example, you can turn Word into a contract generator that assembles contracts out of pre-existing parts that can be made editable or not editable. With Excel, you can create an automated budget worksheet customized for different projects. Your users can also take office solutions offline, which makes complex solutions more practical than they would be if you use a web-based architecture.

 This topic provides an overview of the types of Office solutions that you can create by using the Visual Studio Tools for Office (VSTO) templates available in the Office developer tools in Visual Studio. For general information about how to develop with Office, see the [Office developer center](https://developer.microsoft.com/office).

## Choose an Office project type
 Visual Studio provides the following types of project templates for VSTO-based Office development:

- **Document-level customizations** are associated with a specific document.

- **VSTO Add-ins** are associated with the application itself.

  To decide which of these project types is best for your solution, think about whether you want your code to run only when a specific document is open, or whether you want the code to be available whenever the application is running. For more information about the project templates, see [Office project templates overview](../vsto/office-project-templates-overview.md).

  The types of projects you can create depend on which Office applications you have installed on the development computer. For more information, see [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md).

### Document-level customizations
 Document-level customizations consist of an assembly that is associated with a single document, workbook, or template in Microsoft Office Word or Microsoft Office Excel. The assembly is loaded when the associated document is opened. Features in customizations that you create are available only when the associated document is open. Customizations cannot make application-wide changes, such as displaying a new menu item or ribbon tab when any document is open.

 Visual Studio includes tools to help you create document-level customizations. The document that you customize is hosted as a design surface in Visual Studio, which enables you to design the document by dragging and dropping controls onto it. Many other Visual Studio features are available in document-level projects, such as Windows Forms controls, drag-and-drop data binding, and an integrated debugger.

 For more information about customizations, see the following topics:

- [Get started programming document-level customizations for Excel](../vsto/getting-started-programming-document-level-customizations-for-excel.md)

- [Get started programming document-level customizations for Word](../vsto/getting-started-programming-document-level-customizations-for-word.md)

- [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md)

### VSTO Add-ins
 VSTO Add-ins consist of an assembly that is associated with a Microsoft Office application. Typically, the VSTO Add-in runs when the associated application is started, although users can also load VSTO Add-ins after the application is already running. Features in VSTO Add-ins that you create are available to the application itself, regardless of which documents are open.

 Visual Studio includes tools to help you create VSTO Add-ins. Add-in projects include an automatically generated class that represents the VSTO Add-in. This class provides properties and events that you can use to access the object model of the host application and run code when the VSTO Add-in is loaded and shut down. Many other Visual Studio features are available in VSTO Add-in projects, such as Windows Forms and an integrated debugger.

 For more information about VSTO Add-ins, see the following topics:

- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)

- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)

## Automate Office applications by using primary interop assemblies
 You can programmatically incorporate the features of an Office application into your solution by writing code that accesses the application's object model. Object models are an arrangement of classes that expose functionality through various properties and methods. The object model for each Office application is different.

 To use the object model of an Office application from a solution created by using the Office development tools in Visual Studio, you must use the primary interop assembly (PIA) for the application. The PIA enables the managed code in your solution to interact with the Office application's COM-based object model.

 You must have the Office PIAs installed and registered in the global assembly cache on your development computer to perform most development tasks. For more information, see [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md). The Office PIAs are not required on end-user computers to run VSTO Office solutions. For more information, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

 For more information about using the PIAs in VSTO Office solutions, see the following topics:

- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)

- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)

## Run Microsoft VSTO Office solutions on end-user computers
 When you create a VSTO Office solution, consider how the deployment requirements might affect your development choices.

### Deployment options
 Use ClickOnce or Windows Installer to deploy solutions that you create by using the Office development tools in Visual Studio. ClickOnce deployment enables you to create self-updating solutions that can be installed and run with minimal user interaction. Windows Installer (*.msi*) files can be easily distributed to end-user computers, or distributed by using Systems Management Server (SMS). For more information about deploying VSTO Office solutions, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

### Install prerequisites
 Before end users can run a solution you create by using the Office development tools in Visual Studio, their computers must have certain prerequisites installed. If you deploy your solution by using ClickOnce or by creating a Windows Installer file, these prerequisites can be installed with your solution. For more information, see [Office solution prerequisites for deployment](/previous-versions/bb608617(v=vs.110)) and [How to: Install prerequisites on end user computers to run Office solutions](/previous-versions/bb608608(v=vs.110)).

### Security
 Security for VSTO Office solutions is enforced by a series of checks that the  Visual Studio Tools for Office runtime  makes when it installs and loads the solution. These checks include verifying whether the location of the deployment manifest is trusted or whether the certificate used to sign the deployment manifest is trusted. For more information, see [Secure Office solutions](../vsto/securing-office-solutions.md).

## Related content
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Get started programming document-level customizations for Excel](../vsto/getting-started-programming-document-level-customizations-for-excel.md)
- [Get started programming document-level customizations for Word](../vsto/getting-started-programming-document-level-customizations-for-word.md)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
