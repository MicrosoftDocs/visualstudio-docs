---
title: "How to: Switch Between Views and the XML Editor | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cb69fbbd-d99c-439e-9498-5df9050f8df0
caps.latest.revision: 2
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Switch Between Views and the XML Editor
This topic shows how to switch between the XML Schema Designer (XSD Designer) views and the XML Editor. This example uses the [Purchase Order Schema](../xml-tools/sample-xsd-file-simple-schema.md).  
  
### To switch between the views and the XML Editor  
  
1.  To create and edit a new XML Schema file, follow the steps in [How to: Create and Edit an XSD Schema File](../xml-tools/how-to-create-and-edit-an-xsd-schema-file.md).  
  
2.  To switch to the XML Schema Designer from the XML Editor, right click anywhere in the XML Editor and select **View Designer**.  
  
3.  To switch to the Graph View using the watermark, click the **Use the Graph view to see the relationship between the nodes** link on the Start View.  
  
4.  Drag the `USAddress` node from the XML Schema Explorer onto the Graph View. Right-click the `USAddress` node in the Graph View and select **Show in Content Model View** in the context menu.  
  
     The Content Model View with the details of `USAddress` node appears.  
  
5.  To switch to the Start View from the Content Model View using the toolbar, click the Start View button on the XSD toolbar.  
  
6.  To switch between the views using the hotkeys, press CTRL+1 for the Start View, CTRL+2 for the Graph View, and CTRL+3 for the Content Model View.  
  
7.  To go to XML Editor from the Content Model View, right-click the node and select **View Code** in the context menu.