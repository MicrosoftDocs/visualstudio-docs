---
title: "XML Snippets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 348dbf64-3f09-4fff-b47a-a7ecdf3221cc
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# XML Snippets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The XML Editor offers a feature, called *XML snippets*, that allows you to build XML files more quickly. You can reuse XML snippets by inserting them into your files. You can also generate XML data based on an XML Schema definition language (XSD) schema.

## Reusable XML Snippets
 The XML Editor includes many snippets that cover some common tasks. This allows you to create XML files more easily. For example, if you were authoring an XML Schema, using the "Complex Type Sequence Element" and "Simple Type Element" snippets inserts the following XML text to your file. You would then change the `name` value to suit your needs.

```
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

 You can insert snippets in two ways. The **Insert Snippet** command inserts the XML snippet at the cursor position. The **Surround With** command wraps the XML snippet around the selected text. Both commands are available either from the **IntelliSense** submenu under the **Edit** menu, or from the editor shortcut menu.

 For more information, see [How to: Use XML Snippets](../xml-tools/how-to-use-xml-snippets.md).

## Schema-Generated XML Snippets
 The XML editor also has the ability to generate an XML snippet from an XML Schema. This feature allows you to populate an element with XML elements generated from the schema information for that element.

 For more information, see [How to: Generate an XML Snippet From an XML Schema](../xml-tools/how-to-generate-an-xml-snippet-from-an-xml-schema.md).

## Create New XML Snippets
 In addition to the snippets that are included with [!INCLUDE[msCoName](../includes/msconame-md.md)] Visual Studio by default you can also create and use your own XML snippets.

 For more information, see [How to: Create XML Snippets](../xml-tools/how-to-create-xml-snippets.md).

## See Also
 [XML Editor](../xml-tools/xml-editor.md)
