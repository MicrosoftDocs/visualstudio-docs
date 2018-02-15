---
title: "How to: Create an Application Page | Microsoft Docs"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "application pages [SharePoint development in Visual Studio], adding"
  - "application pages [SharePoint development in Visual Studio], creating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Create an Application Page
  You can create an ASP.NET web page for one or more SharePoint sites. In SharePoint, these pages are called application pages. Unlike a site page, an application page contains code that runs behind the page. For more information, see [Creating Application Pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).  
  
### To create an application page  
  
1.  In Visual Studio, open or create a SharePoint project.  
  
     For more information, see [SharePoint Project and Project Item Templates](../sharepoint/sharepoint-project-and-project-item-templates.md).  
  
2.  In **Solution Explorer**, choose the project node.  
  
3.  On the menu bar, choose **Project**, **Add New Item**.  
  
4.  In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** item.  
  
5.  In the list of SharePoint templates, choose **Application Page**.  
  
6.  In the **Name** box, specify a name for the application page, and then choose the **Add** button.  
  
     Visual Studio adds several folders and files to your project. For more information about these files, see [Creating Application Pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).  
  
     In the **Source** view of the Visual Web Developer designer, the ASP.NET page file appears. You can design the page by adding controls from the **Toolbox** and placing them on content placeholders. For more information, see [Source View, Web Page Designer](http://msdn.microsoft.com/en-us/5911396b-fe51-4150-9ff1-b085f812862f).  
  
7.  If you want to handle control events, add code to the code file for the application page.  
  
     The code file appears if you expand the node for the ASP.NET page file and has a .cs or .vb extension, depending on the language of the project. For an end-to-end example of how to create an application page, see [Walkthrough: Creating a SharePoint Application Page](../sharepoint/walkthrough-creating-a-sharepoint-application-page.md).  
  
## See Also  
 [Creating Application Pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md)   
 [Walkthrough: Creating a SharePoint Application Page](../sharepoint/walkthrough-creating-a-sharepoint-application-page.md)  
  
  