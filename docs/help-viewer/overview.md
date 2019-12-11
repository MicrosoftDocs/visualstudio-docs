---
title: Offline help documentation
ms.date: 11/02/2017
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
ms.assetid: 74e41666-2ce8-4ac0-a0e5-3723d1e322c2
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# Microsoft Help Viewer

You can install and view content for various products and technologies on your local computer by using Microsoft Help Viewer. These products include Visual Studio, .NET, language reference, SQL Server, and Windows Development. Help Viewer enables you to:

- Download sets of content, which are also referred to as books. This can be useful if you need to work "offline" and still have access to documentation.

- Find topics by title by browsing and searching the table of contents.

- Look up subjects in the index.

- Find information by using full-text search.

- View, bookmark, and print topics.

To install Help Viewer, see [Microsoft Help Viewer installation](../help-viewer/installation.md). To start reading help topics in the Help Viewer rather than online, go to the **Help** menu in Visual Studio, and then choose **Set Help Preference** > **Launch in Help Viewer**.

> [!TIP]
> Another way to download content locally so you can view it when you don't have an internet connection is to download a PDF version of it. Many documentation sets on docs.microsoft.com include a link at the bottom of the table of contents (TOC) to download a PDF file that contains all the articles for that TOC.
>
> ![Download PDF for Visual Studio documentation](media/overview/download-pdf.png)

## Help Viewer tour

You can find information in installed content by using the navigation tabs, view installed content in the topic tab or tabs, and manage content by using the **Manage Content** tab. You can also perform additional tasks by using the buttons on the toolbar and find additional information in the lower-right corner of the window.

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

### Toolbar buttons

The toolbar in the **Help Viewer** window contains the following buttons:

- The **Show Topic in Contents** button shows the location of the topic in the **Contents** tab.

- The **Add to Favorites** button adds the active topic to the **Favorites** tab.

- The **Find in Topic** button highlights search text in the active topic.

- The **Print** button prints or shows a preview of the active topic.

- The **Viewer Options** button displays settings such as how large the text appears, how many search results to return, how many topics to show in history, and whether to check for updates online.

- The **Manage Content** button makes the **Manage Content** tab active.

- The small triangle on the right-hand side opens a list of tabs, including topic tabs and the **Manage Content** tab. You can choose a tab name to make it the active tab.

## See also

- [Microsoft Help Viewer installation](../help-viewer/installation.md)
- [Help Viewer administrator guide](../help-viewer/administrator-guide.md)
- [Install and manage local content](../help-viewer/install-manage-local-content.md)
