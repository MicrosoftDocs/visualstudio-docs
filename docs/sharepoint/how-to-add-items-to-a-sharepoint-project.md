---
title: "How to: Add Items to a SharePoint Project | Microsoft Docs"
description: Add new or existing items to a SharePoint project in Visual Studio after you open or create a SharePoint solution.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, adding items"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add items to a SharePoint project
  SharePoint solutions contain one or more projects, each of which contains multiple SharePoint project items. After you open or create a SharePoint solution, you can add either new or existing items to these projects. For example, new workflow projects come with a default form that's named default.aspx, but you can replace that form with a new or different form, or add another ASPX form.

### To add a new project item to a SharePoint solution

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], open or create a SharePoint solution.

2. In **Solution Explorer**, choose the project's node.

3. On the menu bar, choose **Project** > **Add New Item** to display the **Add New Item** dialog box.

4. In the **Installed Templates** list, expand the **SharePoint** node, and then choose the **2010** node.

5. In the list of project item templates, choose a template.

6. In the **Name** text box, enter a name, and then choose the **OK** button.

### To add an existing project item to a SharePoint solution

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], open or create a SharePoint solution.

2. In **Solution Explorer**, choose the project's node.

3. On the menu bar, choose **Project** > **Add Existing Item** to display the **Add Existing Item** dialog box.

4. Browse to the folder that contains the item that you want to add, choose it, and then choose the **Add** button.

## See also
- [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
