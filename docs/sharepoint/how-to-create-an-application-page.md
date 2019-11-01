---
title: "How to: Create an Application Page | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application pages [SharePoint development in Visual Studio], adding"
  - "application pages [SharePoint development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Create an application page
  You can create an ASP.NET web page for one or more SharePoint sites. In SharePoint, these pages are called application pages. Unlike a site page, an application page contains code that runs behind the page. For more information, see [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).

### To create an application page

1. In Visual Studio, open or create a SharePoint project.

     For more information, see [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md).

2. In **Solution Explorer**, choose the project node.

3. On the menu bar, choose **Project** > **Add New Item**.

4. In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** item.

5. In the list of SharePoint templates, choose **Application Page**.

6. In the **Name** box, specify a name for the application page, and then choose the **Add** button.

     Visual Studio adds several folders and files to your project. For more information about these files, see [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).

     In the **Source** view of the Visual Web Developer designer, the ASP.NET page file appears. You can design the page by adding controls from the **Toolbox** and placing them on content placeholders. For more information, see [Source View, Web Page Designer](/previous-versions/aspnet/ms178154\(v\=vs.100\)).

7. If you want to handle control events, add code to the code file for the application page.

     The code file appears if you expand the node for the ASP.NET page file and has a *.cs* or *.vb* extension, depending on the language of the project. For an end-to-end example of how to create an application page, see [Walkthrough: Create a SharePoint application page](../sharepoint/walkthrough-creating-a-sharepoint-application-page.md).

## See also
- [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md)
- [Walkthrough: Create a SharePoint application page](../sharepoint/walkthrough-creating-a-sharepoint-application-page.md)
