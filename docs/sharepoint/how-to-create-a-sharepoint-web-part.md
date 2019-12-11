---
title: "How to: Create a SharePoint Web Part | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Web Parts [SharePoint development in Visual Studio], adding"
  - "Web Parts [SharePoint development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Create a SharePoint web part
  You can create and customize a web part by adding a **Web Part** item to any SharePoint project and then editing the code file for the web part or by using a designer. For more information, see [How to: Create a SharePoint web part by using a designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md).

### To create a SharePoint web part

1. Create or open a SharePoint project.

     For more information, see [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md).

2. Choose the SharePoint project node in **Solution Explorer** and then choose **Project** > **Add New Item**.

3. In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

4. In the list of SharePoint templates, choose **Web Part**.

5. In the **Name** box, specify a name for the web part, and then choose the **Add** button.

     The web part appears in **Solution Explorer**. For more information about the files that a web part includes, see [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md).

6. In **Solution Explorer**, open the code file for the web part that you just created.

     For example, if the name of your web part is *WebPart1*, open *WebPart1.vb* (in Visual Basic) or *WebPart1.cs* (in C#).

7. In the code file, add controls to the <xref:System.Web.UI.Control.CreateChildControls%2A> method.

     For an example, see [Walkthrough: Create a web part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md).

## See also
- [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)
- [How to: Create a SharePoint web part by using a designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md)
- [Walkthrough: Create a web part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md)
- [Walkthrough: Create a web part for SharePoint by using a designer](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md)
