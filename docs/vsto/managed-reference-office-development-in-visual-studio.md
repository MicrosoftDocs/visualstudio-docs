---
title: "Managed reference (Office development in Visual Studio)"
description: Learn about API reference documentation for namespaces and types that are used in Office projects that target the .NET Framework.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "08/14/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "reference [Office development in Visual Studio], 2007 Microsoft Office system"
  - "Office development in Visual Studio, reference"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Managed reference (Office development in Visual Studio)
  This section contains API reference documentation for namespaces and types that are used in Office projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](includes/net-v45-md.md)]. For API reference documentation about the namespaces and types that are used in Office projects that target the .NET Framework 3.5, see the following reference section in the Visual Studio documentation: [Managed reference (Office development in Visual Studio)](managed-reference-office-development-in-visual-studio.md).

[!include[Add-ins note](includes/addinsnote.md)]

## In this section
 <xref:Microsoft.Office.Tools>

 Contains classes common to programming Office solutions. These include the base class for VSTO Add-ins, classes for creating custom task panes in VSTO Add-ins, classes for creating smart tags in Excel and Word solutions, and classes for creating actions panes in document-level customizations.

 <xref:Microsoft.Office.Tools.Excel>

 Contains host controls and host items that can be used in solutions for Excel.

 <xref:Microsoft.Office.Tools.Excel.Controls>

 Contains Excel controls and Windows Forms controls that can be used in solutions for Excel.

 <xref:Microsoft.Office.Tools.Outlook>

 Contains classes used by VSTO Add-ins for Outlook, including classes that are used to create custom form regions.

 <xref:Microsoft.Office.Tools.Ribbon>

 Contains classes that are used to programmatically modify Ribbon customizations created by using the Ribbon designer.

 <xref:Microsoft.Office.Tools.Word>

 Contains host controls and host items that can be used in solutions for Word.

 <xref:Microsoft.Office.Tools.Word.Controls>

 Contains Word controls and Windows Forms controls that can be used in solutions for Word.

 <xref:Microsoft.VisualStudio.Tools.Applications>

 Contains the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class and a set of related cached data classes. These classes can be used to modify some aspects of document-level customizations on computers that do not have Microsoft Office installed.

 <xref:Microsoft.VisualStudio.Tools.Applications.Deployment>

 Contains the <xref:Microsoft.VisualStudio.Tools.Applications.Deployment.IAddInPostDeploymentAction> interface (which you can implement to create a *post deployment action* for an Office solution), exceptions that can be thrown when installing an Office solution, and other APIs that are part of the Visual Studio infrastructure.

 <xref:Microsoft.VisualStudio.Tools.Applications.Runtime>

 Contains most of the exceptions that can be thrown by the [!INCLUDE[vsto_runtime](includes/vsto-runtime-md.md)], several classes that can be used to cache data in document-level customizations, and other APIs that are part of the Visual Studio infrastructure.

 <xref:Microsoft.VisualStudio.Tools.Office.BuildTasks>

 Contains MSBuild task classes that are used to build Office projects.

## See also
- [Visual Studio tools for Office runtime overview](visual-studio-tools-for-office-runtime-overview.md)
- [Get started &#40;Office development in Visual Studio&#41;](getting-started-office-development-in-visual-studio.md)
- [Office development samples and walkthroughs](office-development-samples-and-walkthroughs.md)
- [Design and create Office solutions](designing-and-creating-office-solutions.md)
