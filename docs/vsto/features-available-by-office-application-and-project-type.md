---
title: "Features Available by Office Application and Project Type | Microsoft Docs"
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
  - "application-level add-ins [Office development in Visual Studio]"
  - "Office development in Visual Studio, features"
  - "Ribbon [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], features available"
  - "document-level customizations [Office development in Visual Studio]"
  - "Office projects [Office development in Visual Studio], features available"
  - "add-ins [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], features available"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Features Available by Office Application and Project Type
  Visual Studio has several types of project templates that support different business scenarios for Microsoft Office applications, including the following types:  
  
-   Document-level customizations.  
  
-   VSTO Add-ins.  
  
 Not all applications can use every project type. For example, document-level projects are available only for Microsoft Office Word and Microsoft Office Excel. Similarly, some features are available only for certain types of projects or applications. For example, the actions pane is available only in document-level projects, and Ribbon extensions are available only for some applications. For more information about the different project types, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).  
  
> [!NOTE]  
>  Office project templates are available only in some editions of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information, see [Configuring a Computer to Develop Office Solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md).  
  
## Project Types Available for Different Microsoft Office Applications  
 The following table shows the applications that you can use with each project type.  
  
|Project types|Microsoft Office application|  
|-------------------|----------------------------------|  
|Document-level customizations|Excel<br /><br /> Word|  
|VSTO Add-ins|Excel<br /><br /> InfoPath (InfoPath 2013 and InfoPath 2010 only)<br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Visio<br /><br /> Word<br /><br /> Excel|  
  
## Features Available in Different Project Types  
 The following table shows which project types provide each feature.  
  
|Feature|Project types that provide the feature|Further reading|  
|-------------|--------------------------------------------|---------------------|  
|Actions pane.|Document-level projects.|[Actions Pane Overview](../vsto/actions-pane-overview.md)|  
|ClickOnce deployment.|VS and document-level projects.|[Deploying an Office Solution](../vsto/deploying-an-office-solution.md)|  
|Custom task panes.|VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Word|[Custom Task Panes](../vsto/custom-task-panes.md)|  
|Custom XML parts.|Document-level projects.<br /><br /> Application level projects for the following applications:<br /><br /> -   Excel<br />-   PowerPoint<br />-   Word|[Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md)|  
|Data cache.|Document-level projects.|[Cached Data in Document-Level Customizations](../vsto/cached-data-in-document-level-customizations.md)|  
|Expose an object in an VSTO Add-in to other Microsoft Office solutions.|VSTO Add-in projects.|[Calling Code in VSTO Add-ins from Other Office Solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)|  
|The following host controls:<br /><br /> -   Chart<br />-   ListObject<br />-   NamedRange<br />-   Content controls<br />-   Bookmark|Document-level projects.<br /><br /> VSTO Add-in projects for Word and Excel.|[Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)|  
|The following host controls:<br /><br /> -   XMLMappedRange<br />-   XMLNode<br />-   XMLNodes|Document-level projects.|[Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)|  
|Multi-project deployment.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Deploying Multiple Office Solutions in a Single ClickOnce Installer](http://msdn.microsoft.com/en-us/051223c0-4082-4799-b78b-a4763a9def55)|  
|Outlook form regions.|VSTO Add-in projects for Outlook.|[Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md)|  
|Post-deployment actions.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Copying a Document to the End User Computer after a ClickOnce Installation](http://msdn.microsoft.com/en-us/100090f7-bc63-4152-b3e1-19b48bc27466)|  
|Ribbon customizations.|Document-level projects.<br /><br /> VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Project<br />-   Visio<br />-   Word|[Ribbon Overview](../vsto/ribbon-overview.md)|  
|Visual document designer.|Document-level projects.|[Office Projects in the Visual Studio Environment](../vsto/office-projects-in-the-visual-studio-environment.md)|  
  
## See Also  
 [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)   
 [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)   
 [Actions Pane Overview](../vsto/actions-pane-overview.md)   
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Cached Data in Document-Level Customizations](../vsto/cached-data-in-document-level-customizations.md)   
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)  
  
  