---
title: "How to: Generate an XML Snippet From an XML Schema | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 2c128d2a-aaa6-4814-aa95-e07056afe338
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Generate an XML Snippet From an XML Schema
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The XML Editor has the ability to generate XML snippets from an XML Schema definition language (XSD) schema. For example, as you are authoring an XML file, while positioned next to the element name, you can press TAB to populate the element with XML data generated from the schema information for that element.

 This feature is only available on elements. The following rules also apply:

- The element must have an associated schema type; that is, the element must be valid according to some associated schema. The schema type cannot be abstract and the type must contain the required attributes and/or required child elements.

- The current element in the editor must be empty with no attributes. For example,  the following are all valid

  - `<Account`

  - `<Account>`

  - `<Account></Account>`

- The cursor must be located immediately to the right of the element name.

  The generated snippet contains all required attributes and elements. If `minOccurs` is greater than one, the required minimum number of instances of that element is included in the snippet, up to a maximum of 100 instances. Any fixed values found in the schema result in fixed values in the snippet. `xsd:any` and `xsd:anyAttribute` elements are ignored and result in no additional snippet constructs.

  Default values are generated and noted as editable values. If the schema specifies a default value, this default value is used. However, if the schema default value is an empty string, the editor generates the default values in the following manner:

- If the schema type contains any enumeration facets, either directly or indirectly by means of any of members of a union type, the first enumerated value found in the Schema Object Model is used as the default.

- If the schema type is an atomic type, the editor gets the atomic type and inserts the atomic type name. For a derived simple type it uses the base simple type. For a list type the atomic type is the `itemType`. For a union, the atomic type is the atomic type of the first `memberType`.

## Example
 The steps in this section show you how use the schema-generated XML snippet feature of the XML Editor.

> [!NOTE]
> Before starting these procedures, save the schema file to your local computer.

#### To create a new XML file and associate it with an XML Schema

1. On the **File** menu, point to **New**, and click **File**.

2. Select **XML File** in the **Templates** pane and click **Open**.

     A new file is opened in the editor. The file contains a default XML declaration, `<?xml version="1.0" encoding="utf-8">`.

3. In the document properties window, click the browse button (**…**) on the **Schemas** field.

     The **XSD Schemas** dialog box is displayed.

4. Click **Add**.

     The **Open XSD Schema** dialog box is displayed.

5. Select the schema file and click **Open**.

6. Click **OK**.

     The XML Schema is now associated with the XML document.

#### To generate an XML snippet

1. Type `<` in the editor pane.

2. The members list displays the possible items:

     **!--** to add a comment.

     **!DOCTYPE** to add a document type.

     **?** to add a processing instruction.

     **Contact** to add the root element.

3. Select **Contact** from the member list and press ENTER.

     The editor adds the start tag `<Contact` and positions the cursor after the element name.

4. Press TAB to generate XML data for the `Contact` element based on its schema information.

### Input
 The following schema file is used by the walkthrough.

```
<?xml version="1.0" encoding="utf-8" ?>
<xs:schema elementFormDefault="qualified"
           xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <xs:simpleType name="phoneType">
    <xs:restriction base="xs:string">
      <xs:enumeration value="Voice"/>
      <xs:enumeration value="Fax"/>
      <xs:enumeration value="Pager"/>
    </xs:restriction>
  </xs:simpleType>
  <xs:element name="Contact">
    <xs:complexType>
      <xs:sequence>
        <xs:element name="Name">
          <xs:simpleType>
            <xs:restriction base="xs:string"></xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name="Title"
                    type="xs:string" />
        <xs:element name="Phone"
                    minOccurs="1"
                    maxOccurs="unbounded">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="Number"
                          minOccurs="1">
                <xs:simpleType>
                  <xs:restriction base="xs:string"></xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Type"
                          default="Voice"
                          minOccurs="1"
                          type="phoneType"/>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>
```

### Output
 Following is the XML data that is generated based on the schema information associated with the `Contact` element. Items marked as `bold` designate editable fields in the XML snippet.

```
<Contact>
  <Name>name</Name>
  <Title>title</Title>
  <Phone>
    <Number>number</Number>
    <Type>Voice</Type>
  </Phone>
</Contact>
```

## See Also
 [XML Snippets](../xml-tools/xml-snippets.md)
 [How to: Use XML Snippets](../xml-tools/how-to-use-xml-snippets.md)
