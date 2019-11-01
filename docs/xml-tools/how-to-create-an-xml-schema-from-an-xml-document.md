---
title: Create an XML Schema
ms.date: 03/05/2019
ms.topic: conceptual
ms.assetid: 1d6700a9-fd67-4794-8997-399589e99bec
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Create an XML schema from an XML document

The XML editor lets you create an XML Schema definition language (XSD) schema from an XML document. The XML file determines how the schema is generated in the following manner:

- If the XML document has no schema or Document Type Definition (DTD) associated with it, the data in the XML document is used to infer a new XML Schema.

- If the XML document contains an associated DTD, the external DTD and internal subset are converted to a corresponding XML Schema.

- If the XML document contains an inline XML-Data Reduced (XDR) schema, the XDR schema is converted to a corresponding XML Schema.

The schemas that are created are then used to provide IntelliSense for the XML file.

For more information about the schema inference engine, see [Infer an XML schema](/dotnet/standard/data/xml/inferring-an-xml-schema).

## To create an XML schema

1. Open an XML file in Visual Studio.

2. On the menu bar, choose **XML** > **Create Schema**.

   An XML Schema document is created and opened for each namespace found in the XML file. Each schema is opened as a temporary miscellaneous file. The schemas can be saved to disk, added to your project, or discarded.

## See also

- [XML editor](../xml-tools/xml-editor.md)