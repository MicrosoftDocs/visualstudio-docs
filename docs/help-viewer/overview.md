---
title: 'What is the offline Help Viewer?'
titleSuffix: ""
description: Install and view offline help documentation for various products and technologies such as Visual Studio and .NET with the Microsoft Help Viewer.
ms.date: 10/2/2025
ms.topic: conceptual
f1_keywords:
  - "hv_general"
helpviewer_keywords:
  - "Microsoft Help Viewer Help"
  - "Help Viewer, printing a topic"
  - "printing a topic [Help Viewer]"
  - "Help Viewer, toolbar"
  - "Help on Help [Help Viewer]"
  - "Help Viewer, window components"
  - "Help Viewer, navigating"
  - "toolbar [Help Viewer]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: help-viewer
---
# What is the Microsoft Help Viewer? 

You can use Microsoft Help Viewer to install, view, and manage local documentation installs for Microsoft products and technologies on local computers. These products include Visual Studio, .NET, language reference, SQL Server, and Windows development. 

With Help Viewer, you, and any users you support, can:

- Download documentation, which are also referred to as books. This is useful when you want to access documentation while working offline. 

- Search and find topics through the table of contents, book index, or even full-text search. 

- View, bookmark, and print content.

## Get started 

To install Help Viewer, see [Microsoft Help Viewer installation](../help-viewer/installation.md). 

To start reading help topics in the Help Viewer rather than online, go to the **Help** menu in Visual Studio, and then choose **Set Help Preference** > **Launch in Help Viewer**.

> [!TIP]
> Another way to download content locally so you can view it when you don't have an internet connection is to download a PDF version of it. Many documentation sets on Microsoft Learn include a link at the bottom of the table of contents to download a PDF file that contains all the articles for that TOC.
>
> Look for this link:
> ![Download PDF for Visual Studio documentation](media/overview/download-pdf.png)

## Tour the Help Viewer window

You can find information in installed content by using the navigation tabs, view installed content in the topic tab or tabs, and manage content by using the **Manage Content** tab. You can also perform additional tasks by using the buttons on the toolbar and find additional information in the lower-right corner of the window.

The following information describes the default setup for Help Viewer. You can also [customize it's layout and settings](../help-viewer/customize.md).

### Navigation tabs

|Tab|Description|
|---|-----------|
|Contents|Displays installed content as a hierarchy (table of contents). You can specify criteria to filter the titles that appear.|
|Index|Displays an alphabetical list of indexed terms. You can search the index, specify criteria to filter the entries, and require that index entries either contain or start with text that you specify.|
|Favorites|You can "favorite" topics by choosing the **Add to Favorites** button, and the topics appear in this tab. The **History** section displays a list of topics that you've viewed recently.|
|Search|Provides a text box where you can search for terms anywhere in the content, including code and topic titles.|

### View topics

Each topic appears in its own tab, and you can open multiple topics at the same time.

### Manage content

You can install, update, move, and delete content by using the **Manage Content** tab. At the top of the tab, you can use the **Installation source** control to specify whether to install books from a network location or from a disk or URI. The **Local store path** box shows where books are installed on the local computer, and you can move them to a different location by choosing the **Move** button.

The content list shows which books you can install or have already installed, whether an update is available, and how large each book is. You can install or remove one or more books by choosing the appropriate **Add** or **Remove** links and then choosing the **Update** button under the **Pending changes** pane. If updates are available for any books that you've already installed, you can refresh that content by choosing the **Click here to download now** link at the bottom of the window. In addition, all installed books are refreshed if updates are available when you install additional books.

> [!NOTE]
> The functionality of the **Manage Content** tab may differ if the Help Viewer administrator deactivates these features, or if no internet access is available.

### Keyboard shortcuts

Find the list of keyboard shortcuts in the article, "[Shortcut keys in Help Viewer](shortcut-keys.md)".

### Toolbar buttons

The toolbar in the **Help Viewer** window contains the following buttons:

| Toolbar buttons | Descriptions |
|-----------------|--------------|
| **Show Topic in Contents**|Shows the location of the topic in the **Contents** tab.|
| **Add to Favorites**|Adds the active topic to the **Favorites** tab.|
| **Find in Topic**|Highlights search text in the active topic.|
| **Print**|Prints or shows a preview of the active topic.|
| **Viewer Options**|Displays settings such as how large the text appears, how many search results to return, how many topics to show in history, and whether to check for updates online.|
| **Manage Content**|Makes the **Manage Content** tab active.|
| Small triangle on the right-hand side|Opens a list of tabs, including topic tabs and the **Manage Content** tab. You can choose a tab name to make it the active tab.|

## Related content

- [Microsoft Help Viewer installation](../help-viewer/installation.md)
- [Install content locally](../help-viewer/install-manage-local-content.md)
- [Deploy content to others](../help-viewer/administrator-guide.md)
- [Customize Help Viewer's layout and settings](../help-viewer/customize.md)
