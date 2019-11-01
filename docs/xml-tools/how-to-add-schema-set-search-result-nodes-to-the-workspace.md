---
title: "Add XML Schema Set Search Result Nodes to the Workspace"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: ff33b3cc-4db9-4b4e-9378-b45ed5999b18
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Add schema set search result nodes to the workspace

This topic explains how to add nodes that are highlighted in the **XML Schema Explorer** as the result of a keyword search in the workspace.

> [!NOTE]
> Only global nodes can be added to the [workspace](../xml-tools/xml-schema-designer-workspace.md).

This example uses the sample [purchase order schema](../xml-tools/sample-xsd-file-purchase-order-schema.md).

## To add schema set result nodes

1. Follow the steps in [How to: Create and edit an XSD schema file](../xml-tools/how-to-create-and-edit-an-xsd-schema-file.md).

2. Type "purchaseOrder" in the search text box of the [XML Explorer](../xml-tools/xml-schema-explorer.md) toolbar and click on the search button.

     ![XML Schema Explorer Keyword Search](../xml-tools/media/schemaexplorersearch.gif)

     The search results are highlighted in the **XML Schema Explorer** and marked by ticks on the vertical scroll bar.

3. Add the search results to the workspace by clicking the **Add highlighted nodes to Workspace** button on the summary results pane.

     ![XML Schema Explorer Search Result](../xml-tools/media/schemaexplorersearchresult.gif)

     The `purchaseOrder` node and the `PurchaseOrderType` node appear next to each other on the design surface of the [Graph View](../xml-tools/graph-view.md). Because the two nodes are related (the `purchaseOrder` element is of the `PurchaseOrderType` type), an arrow is drawn between them.