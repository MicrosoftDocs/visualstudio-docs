---
title: "Use Visual Studio Help Viewer table of contents | Microsoft Docs"
ms.custom: ""
ms.date: "11/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-help-viewer"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "hv_contents"
helpviewer_keywords: 
  - "Help Viewer, table of contents filtering"
  - "Help Viewer, Contents tab"
  - "Contents tab [Help Viewer]"
  - "table of contents filtering [Help Viewer]"
ms.assetid: 8b98464d-2b05-4710-ad68-5647e78c6b7b
caps.latest.revision: 12
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# How to: find topics in the table of contents
In the **Contents** tab, you can use the table of contents (TOC) to find information. The table of contents is an expandable list that contains all of the topics in the installed books. For accessibility information about how to navigate through the TOC, see [Shortcut Keys (Help Viewer)](../ide/shortcut-keys-help-viewer.md).  
  
> [!IMPORTANT]
>  The scope of topics available in the TOC depends on the filter you have selected.  
  
## Filter the TOC  
You can filter the TOC to narrow the scope of topics that appear in the **Contents** tab. Titles appear in the list only if they contain the root of the term that you specify. For example, if you specify "troubleshooting" as a filter, only titles that contain "troubleshoot" or "troubleshooting" appear. Nodes whose titles don't contain the term are collapsed to a single node with an ellipsis (...).  
  
#### To filter the TOC  
  
1.  Choose the **Contents** tab.  
  
2.  In the **Filter Contents** text box, enter a term.  
  
> [!NOTE]
>  If the filter takes a long time to run, you might display results more quickly by using the `title:` advanced search operator.  
  
## Synchronize a topic with the TOC  
If you have opened a topic using the index or full-text search features, you can determine where this topic is in the TOC by synchronizing the TOC with the topic window.
  
#### To synchronize the TOC with the topic window  
  
1.  View a topic.  
  
2.  Click the **Show Topic in Contents** button on the toolbar, or press **Ctrl+S**.  
  
     The **Contents** tab opens and displays the topic's location in the TOC.  
  
## See also
[How to: find topics in the index](../ide/how-to-find-topics-in-the-index.md)  
[How to: search for topics](../ide/how-to-search-for-topics.md)  
[Microsoft Help Viewer](../ide/microsoft-help-viewer.md)