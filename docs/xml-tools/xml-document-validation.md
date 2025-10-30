---
title: XML Document Validation in XML editor
description: Understand how XML document validation works in the XML editor and how it checks XML 1.0 syntax and performs data validation as you enter input.
ms.date: 09/16/2021
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# XML document validation

The XML editor checks XML 1.0 syntax and also performs data validation as you type. The editor can validate using a document type definition (DTD) or a schema. Red wavy underlines highlight any XML 1.0 well-formed errors. Blue wavy underlines show semantic errors based on DTD or schema validation. Each error has an associated entry in the error list. You can also view the error message by pausing the mouse over the wavy underline.

Schemas used in validation are found by matching the `targetNamespace` of a compiled schema with the element's xmlns declaration. Compiled schemas are loaded from one of the following locations, listed in order of priority:

- From the file name specified in the **Schemas** field of the document **Properties** window.

- An inline schema or DTD.

- An external DTD or an `xsd:schemaLocation` and `xsd:noNamespaceSchemaLocation` attribute

- An "x-schema" XDR schema namespace URI.

Schemas can also be found in the following additional locations when the schema has a non-empty target namespace:

- Another editor window that contains the schema.

- A schema in the current solution.

- A schema from the schema cache directory.

## XSLT files
When editing an XSLT file, the *xslt.xsd* file located in the schema cache is used for validation. Validation errors are shown as blue wavy underlines. Errors from the XSLT compiler are shown as red wavy underlines.

## XML schema (XSD) files
When editing an XML Schema file, the *xsdschema.xsd* file located in the schema cache is used for validation. Validation errors are shown as blue wavy underlines. Any compilation errors are also shown with red wavy underlines.

## Entity Reference Limit
DTD processing limits the number of entity references by default to 10,000 references and can accommodate most XML schemas.  The error message in Visual Studio may read "Exceeded entity references limit for filename".

If you encounter this limitation in processing an XML document and wish to extend the validator to a larger schema, this can be changed with the `MaxNumberOfDtdEntityReferences` Visual Studio registry key. See [editing the registry for a Visual Studio instance](../install/tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance) for more information on making this change. Please note that this applies to all XML documents opened by the user on that machine.

## Related content

- [XML editor](../xml-tools/xml-editor.md)
