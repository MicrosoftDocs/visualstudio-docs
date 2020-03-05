---
title: "How to: Find Topics in the Table of Contents | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "hv_contents"
helpviewer_keywords:
  - "Help Viewer 2.0, table of contents filtering"
  - "Help Viewer 2.0, Contents tab"
  - "Contents tab [Help Viewer 2.0]"
  - "table of contents filtering [Help Viewer 2.0]"
ms.assetid: 8b98464d-2b05-4710-ad68-5647e78c6b7b
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Find Topics in the Table of Contents
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the **Contents** tab, you can use the table of contents (TOC) to find information. The table of contents is an expandable list that contains all of the topics in the installed books. For accessibility information about how to navigate through the TOC, see [Shortcut Keys (Help Viewer)](../ide/shortcut-keys-help-viewer.md).

> [!IMPORTANT]
> The scope of topics available in the TOC depends on the filter you have selected.

## Filter the TOC
 You can filter the TOC to narrow the scope of topics that appear in the **Contents** tab. Titles appear in the list only if they contain the root of the term that you specify. For example, if you specify "troubleshooting" as a filter, only titles that contain "troubleshoot" or "troubleshooting" appear. Nodes whose titles don't contain the term are collapsed to a single node with an ellipsis (...).

#### To filter the TOC

1. Choose the **Contents** tab.

2. In the **Filter Contents** text box, enter a term.

> [!NOTE]
> If the filter takes a long time to run, you might display results more quickly by using the `title:` advanced search operator.

## Synchronize a topic with the TOC
 If you have opened a topic using the index or full-text search features, you can determine where this topic is in the TOC by synchronizing the TOC with the topic window.

#### To synchronize the TOC with the topic window

1. View a topic.

2. Click the **Show Topic in Contents** button on the toolbar, or press Ctrl+S.

     The **Contents** tab opens and displays the topic's location in the TOC.

## See Also
 [Locate Information](../ide/locate-information.md)
 [Microsoft Help Viewer](../ide/microsoft-help-viewer.md)
