---
title: "Integration with XML Editor | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 43d7a8e6-bd94-4407-a800-15a145c74223
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
# Integration with XML Editor
The XML Schema Designer is integrated with the XML Editor. If you modify an XSD file in the XML Editor, the change will be reflected in the [XML Schema Explorer](../xml-tools/xml-schema-explorer.md). If you have the [Graph View](../xml-tools/graph-view.md) or the [Content Model View](../xml-tools/content-model-view.md) open, the change will also be reflected there. You can navigate between the XML Schema Designer and the XML Editor in the following ways:  
  
-   In the XML Editor, right-click a node and select **Show in XML Schema Explorer**.  
  
-   In the Graph View and the XML Schema Explorer, double-click a node, or right-click a node and select **View Code**. In the Content Model View, right-click a node and select **View Code**.  
  
 The following screenshot shows an XML Schema opened in the XML Schema Explorer. The XML Schema Explorer displays the schema set in a tree view. The XML Editor displays the text view of the node that is currently active in the XML Schema Explorer.  
  
 ![XSDDesignerWithXMLEditor](../xml-tools/media/xsddesignerwithxmleditor.gif "XSDDesignerWithXMLEditor")  
  
 Sometimes it is helpful to see the code in the XML Editor and the graphical designer side by side. To view both files at the same time, right-click anywhere in the XML Editor and select **View Designer**. In the Visual Studio Windows menu, select **New Horizontal (or Vertical) Tab Group**.  
  
 ![XSDDesignerWithXMLEditorAndCMV](../xml-tools/media/xsddesignerwithxmleditorandcmv.gif "XSDDesignerWithXMLEditorAndCMV")  
  
## See Also  
 [XML Schema Explorer](../xml-tools/xml-schema-explorer.md)