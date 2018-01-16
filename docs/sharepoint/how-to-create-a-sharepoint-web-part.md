---
title: "How to: Create a SharePoint Web Part | Microsoft Docs"
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
  - "Web Parts [SharePoint development in Visual Studio], adding"
  - "Web Parts [SharePoint development in Visual Studio], creating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Create a SharePoint Web Part
  You can create and customize a web part by adding a **Web Part** item to any SharePoint project and then editing the code file for the web part or by using a designer. For more information, see [How to: Create a SharePoint Web Part by Using a Designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md).  
  
### To create a SharePoint Web Part  
  
1.  Create or open a SharePoint project.  
  
     For more information, see [SharePoint Project and Project Item Templates](../sharepoint/sharepoint-project-and-project-item-templates.md).  
  
2.  Choose the SharePoint project node in **Solution Explorer** and then choose **Project**, **Add New Item**.  
  
3.  In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** node.  
  
4.  In the list of SharePoint templates, choose **Web Part**.  
  
5.  In the **Name** box, specify a name for the web part, and then choose the **Add** button.  
  
     The web part appears in **Solution Explorer**. For more information about the files that a web part includes, see [Creating Web Parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md).  
  
6.  In **Solution Explorer**, open the code file for the web part that you just created.  
  
     For example, if the name of your web part is WebPart1, open WebPart1.vb (in Visual Basic) or WebPart1.cs (in C#).  
  
7.  In the code file, add controls to the <xref:System.Web.UI.Control.CreateChildControls%2A> method.  
  
     For an example, see [Walkthrough: Creating a Web Part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md).  
  
## See Also  
 [Creating Web Parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)   
 [How to: Create a SharePoint Web Part by Using a Designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md)   
 [Walkthrough: Creating a Web Part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md)   
 [Walkthrough: Creating a Web Part for SharePoint by Using a Designer](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md)  
  
  