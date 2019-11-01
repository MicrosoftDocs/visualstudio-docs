---
title: "XML Schema Designer integration with XML editor"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 43d7a8e6-bd94-4407-a800-15a145c74223
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Integration with XML editor

The XML Schema Designer is integrated with the XML editor. If you modify an XSD file in the XML editor, the change will be reflected in the [XML Schema Explorer](../xml-tools/xml-schema-explorer.md). If you have the [Graph View](../xml-tools/graph-view.md) or the [Content Model View](../xml-tools/content-model-view.md) open, the change will also be reflected there. You can navigate between the XML Schema Designer and the XML editor in the following ways:

- In the XML editor, right-click a node and select **Show in XML Schema Explorer**.

- In the Graph View and the **XML Schema Explorer**, double-click a node, or right-click a node and select **View Code**. In the Content Model View, right-click a node and select **View Code**.

The following screenshot shows an XML Schema opened in the **XML Schema Explorer**. The **XML Schema Explorer** displays the schema set in a tree view. The XML editor displays the text view of the node that is currently active in the **XML Schema Explorer**.

![XSDDesignerWithXMLEditor](../xml-tools/media/xsddesignerwithxmleditor.gif)

Sometimes it is helpful to see the code in the XML editor and the graphical designer side by side. To view both files at the same time, right-click anywhere in the XML editor and select **View Designer**. In the Visual Studio Windows menu, select **New Horizontal (or Vertical) Tab Group**.

![XSDDesignerWithXMLEditorAndCMV](../xml-tools/media/xsddesignerwithxmleditorandcmv.gif)

## See also

- [XML Schema Explorer](../xml-tools/xml-schema-explorer.md)