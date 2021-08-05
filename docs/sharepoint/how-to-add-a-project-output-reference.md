---
title: "How to: Add a Project Output Reference | Microsoft Docs"
description: Learn to add a project output reference so that you can deploy non-SharePoint project assemblies (or .xap files in Silverlight projects) to SharePoint.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "project output references [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, project output references"
  - "SharePoint development in Visual Studio, advanced packaging tools"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a project output reference
  To deploy non-SharePoint project assemblies (or .xap files in Silverlight projects) to SharePoint, add them as a project output reference.

 This process creates a solution build dependency between the two projects. Projects associated with project output references are built before the SharePoint project is built and deployed.

### To add a project output reference

1. Load a solution that contains at least one SharePoint project and one non-SharePoint project.

2. In **Solution Explorer**, choose an item in the SharePoint project node.

3. In the **Properties** window, choose the **Project Output References** property, and then choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button next to it.

4. In the **Project Output References** dialog box, choose the **Add** button.

5. In the properties pane, choose the arrow next to the **Deployment Type** property, and then choose an appropriate value for the non-SharePoint item you are referencing, such as **ElementFile**.

6. Choose the arrow next to **Project Name**, choose the name of the non-SharePoint project item, and then choose the **OK** button.

## See also
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
- [How to: Mark controls as safe controls](../sharepoint/how-to-mark-controls-as-safe-controls.md)
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
