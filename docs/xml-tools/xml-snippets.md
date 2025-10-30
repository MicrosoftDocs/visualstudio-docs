---
title: XML snippets
description: Learn about the XML snippets feature in the XML editor that allows you to build XML files more quickly by reusing XML snippets and inserting them into your files.
ms.date: 11/04/2016
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# XML snippets

The XML editor offers a feature, called *XML snippets*, that allows you to build XML files more quickly. You can reuse XML snippets by inserting them into your files. You can also generate XML data based on an XML schema definition language (XSD) schema.

## Reusable XML snippets

The XML editor includes many snippets that cover some common tasks. This allows you to create XML files more easily. For example, if you were authoring an XML schema, using the "Complex Type Sequence Element" and "Simple Type Element" snippets inserts the following XML text to your file. You would then change the `name` value to suit your needs.

```xml
<xs:element name="name">
  <xs:complexType>
    <xs:sequence>
      <xs:element name="name">
        <xs:simpleType>
          <xs:restriction base="xs:string"></xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
</xs:element>
```

You can insert snippets in two ways. The **Insert Snippet** command inserts the XML snippet at the cursor position. The **Surround With** command wraps the XML snippet around the selected text. Both commands are available either from the **IntelliSense** submenu under the **Edit** menu, or from the right-click menu within the editor.

For more information, see [How to: Use XML snippets](../xml-tools/how-to-use-xml-snippets.md).

## Schema-generated XML snippets

The XML editor also has the ability to generate an XML snippet from an XML schema. This feature allows you to populate an element with XML elements generated from the schema information for that element. For more information, see [How to: Generate an XML snippet from an XML schema](../xml-tools/how-to-generate-an-xml-snippet-from-an-xml-schema.md).

## Create new XML snippets

In addition to the snippets that are included with Visual Studio by default, you can also create and use your own XML snippets. For more information, see [How to: Create XML snippets](../xml-tools/how-to-create-xml-snippets.md).

## Related content

- [Code snippets in Visual Studio](../ide/code-snippets.md)
- [XML editor](../xml-tools/xml-editor.md)
