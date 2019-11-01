---
title: "Browsing SharePoint Connections Using Server Explorer | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.SharePointExplorer.SharePointConnection"
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
# Browse SharePoint connections by using Server Explorer
  You can now browse local SharePoint connections in **Server Explorer**. By using this technique, you can navigate through the components of a SharePoint site on your system. SharePoint site components, such as list definitions and content types, appear in a node that's named **SharePoint Connections** in the tree view of **Server Explorer**. To display **Server Explorer**, on the menu bar, choose **View** > **Server Explorer**. In addition to displaying the SharePoint site components, you can remove items, view their properties, or refresh the tree view by using commands on the shortcut menu.

> [!IMPORTANT]
> To browse a SharePoint site, you must be an administrator of the SharePoint site collection, and you must be running Visual Studio as an administrator of the local computer. Otherwise, the site appears in **Server Explorer**, but you can't expand its node. To verify whether you are an administrator of the site collection, open the site in a web browser, open the **Site Actions** menu, choose **Site Permissions**, and then, on the **Permissions: Team Site** page, choose the **Site Collection Administrators** command from the **Manage** group on the ribbon. Your name will appear in the text box if you are a site collection administrator. If the **Site Collection Administrators** command doesn't appear in the Manage group on the ribbon, you aren't an administrator for the site collection, and you must obtain the appropriate permissions from the site administrator.

## Server Explorer nodes
 Every component of a SharePoint site is represented by a node in the **Server Explorer** tree view under **SharePoint Connections**. For example, default SharePoint sites include a content type called Discussion, which represents a discussion type that displays in the **Discussions** page of the SharePoint site. The Discussion content type contains several fields. To view these fields in **Server Explorer**, expand the **ContentTypes** node, and then the **Discussion** node. Under it are several field nodes, such as Body, Discussion Subject, and Title.

## Node shortcut menu commands
 Each node has a shortcut menu that you access by right-clicking the node or choosing it and then choosing the **Shift**+**F10** keys. Node commands may include the following:

|Command Name|Description|
|------------------|-----------------|
|Refresh|Updates the tree view to reflect any changes that may have occurred since the last time the node was displayed.|
|Delete|Removes the selected node from the tree view. **Note:**  This command is enabled only on SharePoint connections listed under the **SharePoint Connections** node.|
|Properties|Displays the available properties for the selected node in the **Properties** window. The properties are all read-only, and not every node has properties associated with it.|
|Add Connection|Allows you to specify a SharePoint site that you want to browse. Available on the **SharePoint Connections** node and sub-site nodes.|
|View in Browser|Displays the selected list in the Web browser. This command is available on some lists under the **Lists** node which is contained in **Lists and Libraries**.|

## Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Add or remove SharePoint connections](../sharepoint/how-to-add-or-remove-sharepoint-connections.md)|Describes the steps that are required for adding a new SharePoint site to the **SharePoint Connections** node in **Server Explorer**.|

## See also
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
