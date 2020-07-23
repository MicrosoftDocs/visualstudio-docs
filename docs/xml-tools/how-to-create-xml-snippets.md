---
title: 'How to: Create XML Snippets'
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: d8556dd7-1382-4af7-ba80-3e873c9416be
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
- multiple
---
# How to: Create XML snippets

The XML editor can be used to create new XML snippets. The editor includes an XML snippet, named "Snippet", that is a boilerplate snippet for creating new XML snippets.

## To create a new XML snippet

To create a new XML code snippet create a new XML file and use the **Insert Snippet** feature.

1. On the **File** menu, click **New** and then click **File**.

2. Click **XML File** and then click **Open**.

3. Right-click in the editor pane and select **Insert Snippet**.

4. Select **Snippet** from the list and press **Enter**.

5. Make any changes to the new snippet.

6. From the **File** menu select **Save XMLFile.xml**.

     The **Save File As** dialog box is displayed.

7. Enter the name for the new snippet and select **Snippet Files** from the **Save as type** drop-down window.

8. Use the **Save in** drop-down list to change the file location to the *My Documents\Visual Studio 2005\Code Snippets\XML\My XML Snippets* folder and then press **Save**.

## Snippet description

This section describes some of the key elements in the boilerplate snippet. For more information about schema elements used by the XML snippets, see [Code snippets schema reference](../ide/code-snippets-schema-reference.md).

### SnippetType element

The editor supports two snippet types:

```xml
<SnippetTypes>
  <SnippetType>SurroundsWith</SnippetType>
  <SnippetType>Expansion</SnippetType>
</SnippetTypes>
```

The `Expansion` type determines whether the snippet appears when you invoke the **Insert Snippet** command. The `SurroundsWith` type determines whether the snippet appears when you invoke the **Surrounds With** command.

### Code element

The `Code` element defines the XML text that will be inserted when the snippet is invoked.

> [!NOTE]
> The XML snippet text must be enclosed in a `<![CDATA[...]]>` section.

The following is the `Code` element that is created by the boilerplate snippet.

```xml
<Code Language="XML">
  <![CDATA[<test>
  <name>$name$</name>
  $selected$ $end$</test>]]>
</Code>
```

The `Code` element includes three variables.

- $name$ is user-defined variable. It creates a `name` element, which has an editable value that defaults to "name". User-defined variables are defined using the `Literal` element.

- $selected$ is a predefined variable. It represents the text that was selected in the XML editor before invoking the snippet. The placement of this variable determines where the selected text appears in the code snippet that surrounds that selection.

- $end$ is a predefined variable. When the user presses **Enter** to finish editing the code snippet fields, this variable determines where the caret (^) is moved to.

  The above `Code` element inserts the following XML text:

```xml
<test>
  <name>name</name>
</test>
```

The value of the name element is marked as an editable region.

### Literal element

The `Literal` element is used to identify replacement text that can be customized after it is inserted into the file. For example, literal strings, numeric values, and some variable names can be declared as literals. You can define any number of literals in your XML snippet and you can refer to them multiple times from within the snippet. The following is an example of a `Literal` element that defines a $name$ variable whose default value is "name."

```xml
<Literal>
  <ID>name</ID>
  <Default>name</Default>
</Literal
```

Literals can also refer to functions. The XML editor includes a function named **LookupPrefix**. The **LookupPrefix** function looks up the given namespace URI from the location in the XML document that this snippet is invoked from and returns the namespace prefix that is defined for that namespace, if any, and it includes the colon (:) in that name. The following is an example of a `Literal` element that uses the **LookupPrefix** function.

```xml
<Literal Editable="false">
   <ID>prefix</ID>
   <Function>LookupPrefix("namespaceURI")</Function>
</Literal>
```

The $prefix$ variable can then be used elsewhere in your XML snippet.

## See also

- [XML snippets](../xml-tools/xml-snippets.md)
- [How to: Use XML snippets](../xml-tools/how-to-use-xml-snippets.md)
- [How to: Generate an XML snippet from an XML schema](../xml-tools/how-to-generate-an-xml-snippet-from-an-xml-schema.md)
