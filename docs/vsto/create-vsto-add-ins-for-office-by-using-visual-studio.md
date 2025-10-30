---
title: Create VSTO Add-ins for Office by using Visual Studio
description: Explore how to use the Microsoft Office developer tools in Visual Studio to create .NET Framework applications that extend Office.
titleSuffix: ""
ms.date: "04/28/2021"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Create VSTO Add-ins for Office by using Visual Studio

> [!IMPORTANT]
> VSTO relies on the [.NET Framework](/dotnet/framework/get-started/overview). COM add-ins can also be written with the .NET Framework. Office Add-ins cannot be created with [.NET Core and .NET 5+](/dotnet/core/dotnet-five), the latest versions of .NET. This is because .NET Core/.NET 5+ cannot work together with .NET Framework in the same process and may lead to add-in load failures. You can continue to use .NET Framework to write VSTO and COM add-ins for Office. Microsoft will not be updating VSTO or the COM add-in platform to use .NET Core or .NET 5+. You can take advantage of .NET Core and .NET 5+, including ASP.NET Core, to create the server side of [Office Web Add-ins](/office/dev/add-ins/overview/office-add-ins).

  You can use the Microsoft Office developer tools in Visual Studio to create .NET Framework applications that extend Office. These applications are also named *Office solutions*.

 The Office developer tools provide features that help you create Office solutions to suit a variety of business needs. The tools include project templates to help you create Office solutions by using Visual Basic or Visual C#, and visual designers that help you create custom user interfaces for your Office solutions.

[!include[Add-ins note](includes/addinsnote.md)]

 For the latest information about Office development, see the [Microsoft Office developer center](https://developer.microsoft.com/office/docs).

## In this section

- [Get started &#40;Office development in Visual Studio&#41;](getting-started-office-development-in-visual-studio.md)

 Provides links to information about how to configure a development computer to create Office solutions, how to begin creating Office solutions, and what is new for Office development in Visual Studio.

- [Upgrade and migrate Office solutions](upgrading-and-migrating-office-solutions.md)

 Provides links to information about the upgrade process for projects created by using earlier versions of Visual Studio.

- [Architecture of Office solutions in Visual Studio](architecture-of-office-solutions-in-visual-studio.md)

 Provides links to information about how Office solutions work, including information about document-level customizations and VSTO Add-ins.

- [Design and create Office solutions](designing-and-creating-office-solutions.md)

 Provides information about how to create an Office project and configure your project in Visual Studio.

- [Develop Office solutions](developing-office-solutions.md)

 Provides information about how to use managed code with Office solutions, including how to customize the Office user interface, work with data, and troubleshoot problems.

- [Excel solutions](excel-solutions.md)

 Provides information about how to automate Excel, create Excel solutions, and understand globalization issues specific to Excel.

- [InfoPath solutions](infopath-solutions.md)

 Provides information about how to create form templates and VSTO Add-ins for InfoPath.

- [Outlook solutions](outlook-solutions.md)

 Provides information about how to automate Outlook and create Outlook VSTO Add-ins and form regions.

- [PowerPoint solutions](powerpoint-solutions.md)

 Provides information about how to automate PowerPoint and create PowerPoint VSTO Add-ins.

- [Project solutions](project-solutions.md)

 Provides information about how to automate Microsoft Office project and create project VSTO Add-ins.

- [Visio solutions](visio-solutions.md)

 Provides information about how to automate Visio and create Visio VSTO Add-ins.

- [Word solutions](word-solutions.md)

 Provides information about how to automate Word and create Word solutions.

- [Build Office solutions](building-office-solutions.md)

 Provides information about the differences between building Office projects and other types of projects in Visual Studio.

- [Debug Office projects](debugging-office-projects.md)

 Provides information about the differences between debugging Office projects and other types of projects in Visual Studio.

- [Secure Office solutions](securing-office-solutions.md)

 Provides information about how security features work in Office solutions.

- [Deploy an Office solution](deploying-an-office-solution.md)

 Provides information about how to make Office solutions available to your users, and the major issues to consider when you choose a deployment method.

- [Office development samples and walkthroughs](office-development-samples-and-walkthroughs.md)

 Provides links to sample applications and topics that give step-by-step instructions for performing common tasks.

- [General reference &#40;Office development in Visual Studio&#41;](general-reference-office-development-in-visual-studio.md)

 Provides links to detailed information about Office primary interop assemblies, manifests, user interface elements, and error messages.

- [Managed reference &#40;Office development in Visual Studio&#41;](managed-reference-office-development-in-visual-studio.md)

 Provides links to information about API namespaces and types that are used in Office projects that target the .NET Framework 4. For API reference documentation about the namespaces and types that are used in Office projects that target the .NET Framework 3.5, see the following reference section in the Visual Studio 2008 documentation: [2007 system managed reference](managed-reference-office-development-in-visual-studio.md).

- [Unmanaged API reference &#40;Office development in Visual Studio&#41;](unmanaged-api-reference-office-development-in-visual-studio.md)

 Contains links to information about COM interfaces that you can use to perform actions such as load and unload managed VSTO Add-ins in Office applications.

## Related content

- [Office development with Visual Studio developer portal](https://developer.microsoft.com/office/docs) provides additional resources such as technical articles, videos, and blogs.

- [Visual Studio developer center](https://visualstudio.microsoft.com/) provides additional Visual Studio resources such as technical articles, videos, and blogs.

- [Microsoft Office development section of the MSDN library](/previous-versions/office/office-12/bb726434(v=office.12)) provides  articles and reference documentation about developing solutions for several versions of Office (not specific to Office development using Visual Studio).

- [Application development in Visual Studio](/previous-versions/h8w79z10(v=vs.140)) contains links to topics that explain how you can use Visual Studio to design, develop, debug, and deploy web applications, XML web services, and traditional client applications.

- [.NET Framework programming in Visual Studio](/previous-versions/visualstudio/visual-studio-2010/k1s94fta(v=vs.100)) discusses application development with the .NET Framework in Visual Basic and Visual C#.
