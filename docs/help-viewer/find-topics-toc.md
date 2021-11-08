---
title: Use Help Viewer table of contents
description: Use Microsoft Help Viewer to find topics in the table of contents (TOC). The TOC is an expandable list that contains all of the topics in the installed books.
ms.date: 11/02/2017
ms.topic: how-to
f1_keywords:
  - "hv_contents"
helpviewer_keywords:
  - "Help Viewer, table of contents filtering"
  - "Help Viewer, Contents tab"
  - "Contents tab [Help Viewer]"
  - "table of contents filtering [Help Viewer]"
ms.assetid: 8b98464d-2b05-4710-ad68-5647e78c6b7b
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-help-viewer
ms.workload:
  - "multiple"
---
# How to: Find topics in the table of contents

In the **Contents** tab, you can use the table of contents (TOC) to find information. The table of contents is an expandable list that contains all of the topics in the installed books. For accessibility information about how to navigate through the TOC, see [Shortcut keys (Help Viewer)](../help-viewer/shortcut-keys.md).

> [!IMPORTANT]
> The scope of topics available in the TOC depends on the filter you have selected.

## Filter the TOC

You can filter the TOC to narrow the scope of topics that appear in the **Contents** tab. Titles appear in the list only if they contain the root of the term that you specify. For example, if you specify "troubleshooting" as a filter, only titles that contain "troubleshoot" or "troubleshooting" appear. Nodes whose titles don't contain the term are collapsed to a single node with an ellipsis (**...**).

1. Choose the **Contents** tab.

2. In the **Filter Contents** text box, enter a term.

> [!NOTE]
> If the filter takes a long time to run, you might display results more quickly by using the `title:` advanced search operator.

## Synchronize a topic with the TOC

If you have opened a topic using the index or full-text search features, you can determine where this topic is in the TOC by synchronizing the TOC with the topic window.

1. View a topic.

2. Click the **Show Topic in Contents** button on the toolbar, or press **Ctrl**+**S**.

     The **Contents** tab opens and displays the topic's location in the TOC.

## See also

- [How to: Find topics in the index](../help-viewer/find-topics-index.md)
- [How to: Search for topics](../help-viewer/find-topics.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)