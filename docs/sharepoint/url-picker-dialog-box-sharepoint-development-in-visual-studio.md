---
title: "URL picker dialog box (SharePoint development)"
description: Learn about the URL picker dialog box, which lets a user choose files located in their project or on the local server that's running SharePoint.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VS.SharePointTools.VWD.URLPicker"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, URL picker"
  - "SharePoint development in Visual Studio, designer"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# URL picker dialog box (SharePoint development in Visual Studio)

  In the URL picker dialog box, you can choose files such as master page files or image files that are located in your project or on the local server that's running SharePoint.

 This dialog box appears when you have the option to choose a file to set a property. You can open this dialog box by choosing the ellipsis button (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) next to various properties in the **Properties** window. The ellipsis button also appears as an IntelliSense prompt when you assign values to certain attributes in the **Source** view of the designer.

## UIElement list
 **Project folders**
 Displays a list of the folders defined in the project or on the local server that's running SharePoint. Choose the expansion button to display subfolders.

 Expand the **Project** node to choose files in your project. To appear as selectable in the dialog box, files in your project must meet the following criteria:

- The file must be contained in a mapped folder.

- The file must be added to the solution package.

- The file cannot be located in another project.

  If you want to reference files that do not meet these criteria, you have to enter the path of the file manually.

  Expand the **Server** node to choose files that are located on the local server that's running SharePoint. To appear as selectable in the dialog box, these files must meet the following criteria:

- The file must be located in one of the following mapped folders: **Images**, **Layouts**, or **ControlTemplates**.

- The file cannot be located in the SharePoint content database.

  If you want to reference files that do not meet these criteria, you have to enter the path of the file manually.

  **Contents of folder**
  Displays a list of files in the selected folder. Choose a file, and then choose the **OK** button to close the dialog box and send your selection to the process that called it.

  **Files of type**
  Allows you to choose from a list of files that are appropriate for the task you are performing.

## Related content
- [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md)
- [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)
- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)
