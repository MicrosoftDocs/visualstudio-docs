---
title: "XML Schema Designer: Get schema set overview using Graph View"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: c0df4b0d-52ef-4a6c-9676-1d8311aad7c7
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Get an overview of a schema set using the Graph View

This topic describes how to use the [Graph View](../xml-tools/graph-view.md) to see a high-level view of the nodes in a schema set and the relationships between the nodes.

## To create a new XSD file and display the root element in the Content Model View

1. Create a new XML Schema file and save the file as *Relationships.xsd*.

2. Click the **Use XML editor to view and edit the underlying XML Schema file** link on the Start View.

3. Copy the XML Schema sample code from [Sample XML schema: relationships](../xml-tools/sample-xsd-file-relationships.md) and paste it to replace the code that was added to the new XSD file by default.

4. Right-click anywhere in the XML editor and select **View Designer**.

5. Select the Graph View from the **XSD Toolbar**.

6. Select **Schema Set** node in the **XML Schema Explorer** and drag the node to design surface of the Graph View. You should see all the global nodes, and arrows connecting the nodes that have relationships.

     ![Graph View](../xml-tools/media/relationshipingraphview.gif)

7. Click on any node on the design surface and look at the breadcrumb bar to see where the selected node is located in the schema set.

8. Rick-click on any element node on the design surface and select **Generate Sample XML** to see the XML instance document.