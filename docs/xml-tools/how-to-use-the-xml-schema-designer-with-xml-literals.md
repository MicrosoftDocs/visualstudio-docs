---
title: 'How to: Use the XML Schema Designer with XML Literals'
description: Learn how to use the XML Schema Designer to view a schema associated with an XML literal in a Visual Basic project.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: d11803e7-f81a-41a2-a145-ba494a45cc93
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
dev_langs:
- VB
ms.workload:
- multiple
---
# How to: Use the XML Schema Designer with XML literals

This topic describes how to view a schema associated with an XML literal in a Visual Basic project.

## Create a new Visual Basic project

1. Open Visual Studio.

2. Create a new Visual Basic **Console App** project named **XMLLiterals**.

     The new project contains one Visual Basic source file, *Module1.vb*.

## Add an existing XSD file

1. Open a new text file in Notepad. Copy the XML Schema sample code from [purchase order schema](../xml-tools/sample-xsd-file-simple-schema.md) and paste it in to the file.

2. Save the file in some location with the name *PurchaseOrderSchema.xsd*.

3. In **Solution Explorer**, right-click the project's name, select **Add**, and then select **Existing Item**. The **AddExisting Item** dialog box appears. Browse to the *PurchaseOrderSchema.xsd* file, select it, and then click **Add**.

     The XMLLiterals project now contains two files: *Module1.vb* and *PurchaseOrderSchema.xsd*.

## Add code

To add Visual Basic code with an XML literal, based on the XSD file included in the project:

1. Replace the code in *Module1.vb* file with the following code:

   ```vb
   Imports <xmlns:ns="http://tempuri.org/PurchaseOrderSchema.xsd">

   Module Module1
      Sub Main()

          Dim XMLLiteral = <ns:PurchaseOrder OrderDate="1900-01-01">
                               <ns:ShipTo country="US">
                                   <ns:name>name1</ns:name>
                                   <ns:street>street1</ns:street>
                                   <ns:city>city1</ns:city>
                                   <ns:state>state1</ns:state>
                                   <ns:zip>1</ns:zip>
                               </ns:ShipTo>
                               <ns:BillTo country="US">
                                   <ns:name>name1</ns:name>
                                   <ns:street>street1</ns:street>
                                   <ns:city>city1</ns:city>
                                   <ns:state>state1</ns:state>
                                   <ns:zip>1</ns:zip>
                               </ns:BillTo>
                           </ns:PurchaseOrder>

      End Sub
   End Module
   ```

2. Right-click any XML node in an XML literal or an XML namespace import and select **Show in Schema Explorer**.

   The **XML Schema Explorer** is displayed side by side with a Visual Basic file that has the XML literal associated with the XML schema set.
