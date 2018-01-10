---
title: "How to: Create a User Control for a SharePoint Application Page or Web Part | Microsoft Docs"
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
  - "user controls [SharePoint development in Visual Studio], creating"
  - "user controls [SharePoint development in Visual Studio], adding"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Create a User Control for a SharePoint Application Page or Web Part
  You can create custom user controls that provide custom functionality for your SharePoint solution, and you can reuse that functionality within your project. You can include the user controls in a web part or application page, add other ASP.NET controls and SharePoint controls, and define properties and methods for the control. For more information about user controls, see [Creating Reusable Controls for Web Parts or Application Pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md) and [User Controls and Server Controls in SharePoint](http://blogs.msdn.com/b/kaevans/archive/2011/04/28/user-controls-and-server-controls-in-sharepoint.aspx).  
  
### To create a user control for SharePoint  
  
1.  In Visual Studio, open or create a SharePoint project.  
  
     See [SharePoint Project and Project Item Templates](../sharepoint/sharepoint-project-and-project-item-templates.md).  
  
2.  In **Solution Explorer**, choose the project node.  
  
3.  On the menu bar, choose **Project**, **Add New Item**.  
  
     The **Add New Item** dialog box opens.  
  
4.  In the **Installed** pane, choose the **Office/SharePoint** node.  
  
5.  In the list of SharePoint templates, choose **User Control (Farm Solution Only)**.  
  
    > [!NOTE]  
    >  User controls work only in farm solutions.  
  
6.  In the **Name** box, specify a name for the user control, and then choose the **Add** button.  
  
     Visual Studio adds several folders and files to your project. For more information about these files, see [Creating Reusable Controls for Web Parts or Application Pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md).  
  
     By default, the user control file appears in the **Source** view of the Visual Web Developer designer. In this view, you can edit the XML markup of the control. You can switch to **Design** view if you want to design the control visually by dragging controls from the **Toolbox**. See [Design View, Web Page Designer](http://msdn.microsoft.com/en-us/d8f2270a-357d-40a4-9b39-1a3f2366216d).  
  
7.  If you want to handle events that occur in the control, add code to the code file of the user control.  
  
     This file appears in **Solution Explorer** under the user control file and has a .cs or .vb extension, depending on the language of the project.  
  
## See Also  
 [Creating Reusable Controls for Web Parts or Application Pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)   
 [Creating Application Pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md)   
 [Creating Web Parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)  
  
  