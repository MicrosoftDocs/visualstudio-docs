---
title: "How to: Add or Remove SharePoint Connections | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, browsing SharePoint sites"
  - "SharePoint development in Visual Studio, SharePoint Connections"
  - "SharePoint Connections [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add or remove SharePoint connections
  Server Explorer lets you browse SharePoint sites as well as data connections. However, before you can browse the contents of a SharePoint site you must add it to the **SharePoint Connections** node.

### To add a SharePoint site to the SharePoint connections node

1. On the menu bar, choose **View**, **Server Explorer**.

2. In **Server Explorer**, choose the **SharePoint Connections** node, and then, on the menu bar, choose **Tools** > **Add SharePoint Connection**.

3. In the **Add SharePoint Connection** box, enter the [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)] for the SharePoint site (for example, http://testserver/sites/unittests).

### To delete a SharePoint site from the SharePoint connections node

1. On the menu bar, choose **View**, **Server Explorer** to open **Server Explorer**.

2. Expand the **SharePoint Connections** node to reveal the SharePoint site that you want to delete from **Server Explorer**.

3. Choose the site, and then, on the menu bar, choose **Edit** > **Delete**.

    > [!NOTE]
    > This step doesn't delete the underlying site; it deletes only the connection from **Server Explorer**.

## See also
- [Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)
