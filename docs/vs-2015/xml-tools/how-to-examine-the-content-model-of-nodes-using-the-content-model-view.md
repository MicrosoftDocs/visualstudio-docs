---
title: "How to: Examine the Content Model of Nodes Using the Content Model View | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: c42ddac8-b0e3-48d6-9832-112a19d6c104
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Examine the Content Model of Nodes Using the Content Model View
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes how to explore your nodes using the [Content Model View](../xml-tools/content-model-view.md).

### To create a new XSD file and display the root element in the Content Model View

1. Create a new XML Schema file.

2. Click **Use XML Editor to view and edit the underlying XML Schema file** on the Start View.

3. Copy the XML Schema sample code from [Sample XML Schema: Purchase Order Schema](../xml-tools/sample-xsd-file-purchase-order-schema.md) and paste it to replace the code that was added to the new XSD file by default.

4. Select the `purchaseOrder` element in the Schema Explorer by right-clicking the `purchaseOrder` element in the XML Editor and selecting **Show in XML Explorer**.

5. Right-click the `purchaseOrder` in the XML Explorer and select **Show in Content Model View**.

     The Content Model View displays the `purchaseOrder` element on its design surface.

6. Expand the `shipTo`, `billTo`, and `items` nodes either by double-clicking each node or by clicking the double arrow to the right of each node.

     The nodes of the `purchaseOrder` element are now expanded and you can see the content model of the element.

7. Click on any node under the `purchaseOrder` element and look at the breadcrumb bar to see where in the schema set the selected node is located.

8. Click the **Show Documentation** button in the XSD Toolbar to toggle documenation. You can also right-click the design surface to toggle the documentation.

9. Rick-click the `purchaseOrder` node and select **Generate Sample XML** to see the XML instance document.
