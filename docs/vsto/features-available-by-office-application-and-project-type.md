---
title: Find features for Office apps and project types (Visual Studio)
description: Explore the project templates and features available in Visual Studio that support different business scenarios for Microsoft Office applications.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio]"
  - "Office development in Visual Studio, features"
  - "Ribbon [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], features available"
  - "document-level customizations [Office development in Visual Studio]"
  - "Office projects [Office development in Visual Studio], features available"
  - "add-ins [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], features available"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Features available by Office application and project type

  Visual Studio has several types of project templates that support different business scenarios for Microsoft Office applications, including the following types:

- Document-level customizations.

- VSTO Add-ins.

  Not all applications can use every project type. For example, document-level projects are available only for Microsoft Office Word and Microsoft Office Excel. Similarly, some features are available only for certain types of projects or applications. For example, the actions pane is available only in document-level projects, and Ribbon extensions are available only for some applications. For more information about the different project types, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

> [!NOTE]
> Office project templates are available only in some editions of Visual Studio. For more information, see [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

## Project types available for different Microsoft Office applications
 The following table shows the applications that you can use with each project type.

|Project types|Microsoft Office application|
|-------------------|----------------------------------|
|Document-level customizations|Excel<br /><br /> Word|
|VSTO Add-ins|Excel<br /><br /> InfoPath (InfoPath 2013 and InfoPath 2010 only)<br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Visio<br /><br /> Word<br /><br /> Excel|

## Features available in different project types
 The following table shows which project types provide each feature.

|Feature|Project types that provide the feature|Further reading|
|-------------|--------------------------------------------|---------------------|
|Actions pane.|Document-level projects.|[Actions pane overview](../vsto/actions-pane-overview.md)|
|ClickOnce deployment.|VS and document-level projects.|[Deploy an Office solution](../vsto/deploying-an-office-solution.md)|
|Custom task panes.|VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Word|[Custom task panes](../vsto/custom-task-panes.md)|
|Custom XML parts.|Document-level projects.<br /><br /> Application level projects for the following applications:<br /><br /> -   Excel<br />-   PowerPoint<br />-   Word|[Custom XML parts overview](../vsto/custom-xml-parts-overview.md)|
|Data cache.|Document-level projects.|[Cached data in document-level customizations](../vsto/cached-data-in-document-level-customizations.md)|
|Expose an object in a VSTO Add-in to other Microsoft Office solutions.|VSTO Add-in projects.|[Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)|
|The following host controls:<br /><br /> -   Chart<br />-   ListObject<br />-   NamedRange<br />-   Content controls<br />-   Bookmark|Document-level projects.<br /><br /> VSTO Add-in projects for Word and Excel.|[Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)|
|The following host controls:<br /><br /> -   XMLMappedRange<br />-   XMLNode<br />-   XMLNodes|Document-level projects.|[Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)|
|Multi-project deployment.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Deploy multiple Office solutions in a single ClickOnce installer](/previous-versions/dd465290(v=vs.110))|
|Outlook form regions.|VSTO Add-in projects for Outlook.|[Create Outlook form regions](../vsto/creating-outlook-form-regions.md)|
|Post-deployment actions.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Copy a document to the end user computer after a ClickOnce installation](/previous-versions/dd465291(v=vs.110))|
|Ribbon customizations.|Document-level projects.<br /><br /> VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Project<br />-   Visio<br />-   Word|[Ribbon overview](../vsto/ribbon-overview.md)|
|Visual document designer.|Document-level projects.|[Office projects in the Visual Studio environment](../vsto/office-projects-in-the-visual-studio-environment.md)|

## Related content
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Cached data in document-level customizations](../vsto/cached-data-in-document-level-customizations.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
