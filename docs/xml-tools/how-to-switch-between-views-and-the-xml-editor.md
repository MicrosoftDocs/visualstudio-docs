---
title: 'How to: Switch Between Views and the XML editor'
description: Learn how to switch between the XML Schema Designer (XSD Designer) views and the XML editor.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: cb69fbbd-d99c-439e-9498-5df9050f8df0
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# How to: Switch between views and the XML editor

This topic shows how to switch between the XML Schema Designer (XSD Designer) views and the XML editor. This example uses the [Purchase order schema](../xml-tools/sample-xsd-file-simple-schema.md).

## To switch between the views and the XML editor

1. To create and edit a new XML schema file, follow the steps in [How to: Create and edit an XSD schema file](../xml-tools/how-to-create-and-edit-an-xsd-schema-file.md).

2. To switch to the XML Schema Designer from the XML editor, right-click anywhere in the XML editor and select **View Designer**.

3. To switch to the Graph View using the watermark, click the **Use the Graph view to see the relationship between the nodes** link on the Start View.

4. Drag the `USAddress` node from the **XML Schema Explorer** onto the Graph View. Right-click the `USAddress` node in the Graph View and select **Show in Content Model View** in the context menu.

     The Content Model View with the details of `USAddress` node appears.

5. To switch to the Start View from the Content Model View using the toolbar, click the **Start View** button on the XSD toolbar.

6. To switch between the views using the hotkeys, press **Ctrl**+**1** for the Start View, **Ctrl**+**2** for the Graph View, and **Ctrl**+**3** for the Content Model View.

7. To go to XML editor from the Content Model View, right-click the node and select **View Code** in the context menu.
