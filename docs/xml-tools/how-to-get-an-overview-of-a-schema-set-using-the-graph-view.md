---
title: "How to: Get an Overview of a Schema Set Using the Graph View | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c0df4b0d-52ef-4a6c-9676-1d8311aad7c7
caps.latest.revision: 3
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
# How to: Get an Overview of a Schema Set Using the Graph View
This topic describes how to use the [Graph View](../xml-tools/graph-view.md) to see a high-level view of the nodes in a schema set and the relationships between the nodes.  
  
### To create a new XSD file and display the root element in the Content Model View  
  
1.  Create a new XML Schema file and save the file as Relationships.xsd.  
  
2.  Click the **Use XML Editor to view and edit the underlying XML Schema file** link on the Start View.  
  
3.  Copy the XML Schema sample code from [Sample XML Schema: Relationships](../xml-tools/sample-xsd-file-relationships.md) and paste it to replace the code that was added to the new XSD file by default.  
  
4.  Right-click anywhere in the XML Editor and select **View Designer**.  
  
5.  Select the Graph View from the XSD Toolbar.  
  
6.  Select **Schema Set** node in the XML Schema Explorer and drag the node to design suface of the Graph View. You should see all the global nodes, and arrows connecting the nodes that have relationships.  
  
     ![Graph View](../xml-tools/media/relationshipingraphview.gif "RelationshipInGraphView")  
  
7.  Click on any node on the design surface and look at the breadcrumb bar to see where the selected node is located in the schema set.  
  
8.  Rick-click on any element node on the desing surface and select **Generate Sample XML** to see the XML instance document.