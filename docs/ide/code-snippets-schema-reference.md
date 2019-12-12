---
title: Code snippets schema reference
ms.date: 02/25/2019
ms.topic: reference
helpviewer_keywords:
  - "schema reference [Visual Studio]"
  - "snippets [Visual Studio], schema reference"
  - "code snippets [Visual Studio], schema reference"
  - "IntelliSense Code Snippets, XML Schema"
ms.assetid: 58a60621-725f-4763-93b7-62ea5424ef88
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Code snippets schema reference

IntelliSense Code Snippets are pre-authored pieces of code that are ready to be inserted into your application with Visual Studio. You can increase productivity by providing code snippets that reduce the amount of time spent typing repetitive code or searching for samples. You can use the IntelliSense Code Snippet XML schema to create your own code snippets and add them to the code snippets that Visual Studio already includes.

## Assembly element

Specifies the name of the assembly referenced by the code snippet.

The text value of the **Assembly** element is either the friendly text name of the assembly, such as `System.dll`, or its strong name, such as `System,Version=1.0.0.1,Culture=neutral,PublicKeyToken=9b35aa323c18d4fb1`.

```xml
<Assembly>
    AssemblyName
</Assembly>
```

|Parent element|Description|
| - |-----------------|
|[Reference element](../ide/code-snippets-schema-reference.md#reference-element)|Contains information about assembly references required by the code snippet.|

A text value is required. This text specifies the assembly that the code snippet references.

## Author element

Specifies the name of the snippet author. The **Code Snippets Manager** displays the name stored in the `Author` element of the code snippet.

```xml
<Author>
   Code Snippet Author
</Author>
```

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Contains general information about the code snippet.|

A text value is required. This text specifies the author of the code snippet.

## Code element

Provides a container for short code blocks.

### Keywords

Two reserved words are available for use in the text of the `Code` element: `$end$` and `$selected$`. `$end$` marks the location to place the cursor after the code snippet is inserted. `$selected$` represents text selected in the document that is to be inserted into the snippet when it is invoked. For example, given a snippet that includes:

```
$selected$ is a great color.
```

If the word "Blue" is selected when the user invokes the template, the result is:

```
Blue is a great color.
```

You may not use either `$end$` or `$selected$` more than once in a code snippet. If you do, only the second instance is recognized. Given a snippet that includes:

```
$selected$ is a great color. I love $selected$.
```

If the word "Blue" is selected, the result is:

```
 is a great color. I love Blue.
```

The initial space appears because there is a space between `$selected$` and `is`.

All other `$` keywords are dynamically defined in the `<Literal>` and `<Object>` tags.

Following is the structure of the Code element:

```xml
<Code Language="Language"
    Kind="method body/method decl/type decl/page/file/any"
    Delimiter="Delimiter">
    Code to insert
</Code>
```

A text value is required. This text specifies the code, along with the literals and objects, that you can use when this code snippet is inserted into a code file.

### Attributes

There are three attributes available for the Code element:

- **Language** - _Required_ attribute that specifies the language of the code snippet. The value can be one of the following:

   |Value|Description|
   |-----|-----------|
   |`VB`|Identifies a Visual Basic code snippet.|
   |`CSharp`|Identifies a C# code snippet.|
   |`CPP`|Identifies a C++ code snippet.|
   |`XML`|Identifies an XML code snippet.|
   |`JavaScript`|Identifies a JavaScript code snippet.|
   |`TypeScript`|Identifies a TypeScript code snippet.|
   |`SQL`|Identifies a SQL code snippet.|
   |`HTML`|Identifies an HTML code snippet.|

- **Kind** - _Optional_ attribute that specifies the kind of code that the snippet contains. The value can be one of the following:

   |Value|Description|
   |-----|-----------|
   |`method body`|Specifies that the code snippet is a method body, and therefore, must be inserted inside a method declaration.|
   |`method decl`|Specifies that the code snippet is a method, and therefore, must be inserted inside a class or module.|
   |`type decl`|Specifies that the code snippet is a type, and therefore, must be inserted inside a class, module, or namespace.|
   |`file`|Specifies that the snippet is a full code file. These code snippets can be inserted alone into a code file, or inside a namespace.|
   |`any`|Specifies that the snippet can be inserted anywhere. This tag is used for code snippets that are context-independent, such as comments.|

- **Delimiter** - _Optional_ attribute that specifies the delimiter used to describe literals and objects in the code. By default, the delimiter is `$`.

### Parent element

|Parent element|Description|
| - |-----------------|
|[Snippet element](../ide/code-snippets-schema-reference.md#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## CodeSnippet element

Allows you to specify a heading and multiple IntelliSense Code Snippets, which you can insert into Visual Studio code files.

```xml
<CodeSnippet Format="x.x.x">
    <Header>... </Header>
    <Snippet>... </Snippet>
</CodeSnippet>
```

|Attribute|Description|
|---------------|-----------------|
|`Format`|Required attribute. Specifies the schema version of the code snippet. The Format attribute must be a string in the syntax of x.x.x, where each "x" represents a numerical value of the version number. Visual Studio will ignore code snippets with `Format` attributes that it does not understand.|

|Child element|Description|
|-------------------|-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Required element. Contains general information about the code snippet. There must be exactly one `Header` element in a code snippet.|
|[Snippet element](../ide/code-snippets-schema-reference.md#snippet-element)|Required element. Contains the code that will be inserted by Visual Studio. There must be exactly one `Snippet` element in a code snippet.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippets element](../ide/code-snippets-schema-reference.md#codesnippets-element)|Root element of the code snippet XML schema.|

## CodeSnippets element

Groups [CodeSnippet](../ide/code-snippets-schema-reference.md#codesnippet-element) elements. The `CodeSnippets` element is the root element of the code snippet XML schema.

```xml
<CodeSnippets>
    <CodeSnippet>... </CodeSnippet>
</CodeSnippets>
```

|Child element|Description|
|-------------------|-----------------|
|[CodeSnippet element](../ide/code-snippets-schema-reference.md#codesnippet-element)|Optional element. Parent element for all code snippet data. There may be zero or more `CodeSnippet` elements in a `CodeSnippets` element.|

## Declarations element

Specifies the literals and objects that make up the parts of a code snippet that you can edit.

```xml
<Declarations>
    <Literal>... </Literal>
    <Object>... </Object>
</Declarations>
```

|Child element|Description|
|-------------------|-----------------|
|[Literal element](../ide/code-snippets-schema-reference.md#literal-element)|Optional element. Defines the literals of the code snippet that you can edit. There may be zero or more `Literal` elements in a `Declarations` element.|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Optional element. Defines the objects of the code snippet that you can edit. There may be zero or more `Object` elements in a `Declarations` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](../ide/code-snippets-schema-reference.md#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Default element

Specifies the default value of the literal or object for an IntelliSense Code Snippet.

```xml
<Default>
    Default value
</Default>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](../ide/code-snippets-schema-reference.md#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the default value of the literal or object that fills the fields of the code snippet that you can edit.

## Description element

Specifies descriptive information about the contents of an IntelliSense Code Snippet.

```xml
<Description>
    Code Snippet Description
</Description>
```

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Contains general information about the code snippet.|

A text value is required. This text describes the code snippet.

## Function element

Specifies a function to execute when the literal or object receives focus in Visual Studio.

> [!NOTE]
> The `Function` element is only supported in C# code snippets.

```xml
<Function>
    FunctionName
</Function>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](../ide/code-snippets-schema-reference.md#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies a function to execute when the literal or object field receives focus in Visual Studio.

## Header element

Specifies general information about the IntelliSense Code Snippet.

```xml
<Header>
    <Title>... </Title>
    <Author>... </Author>
    <Description>... </Description>
    <HelpUrl>... </HelpUrl>
    <SnippetTypes>... </SnippetTypes>
    <Keywords>... </Keywords>
    <Shortcut>... </Shortcut>
</Header>
```

|Child element|Description|
|-------------------|-----------------|
|[Author element](../ide/code-snippets-schema-reference.md#author-element)|Optional element. The name of the person or company that authored the code snippet. There may be zero or one `Author` elements in a `Header` element.|
|[Description element](../ide/code-snippets-schema-reference.md#description-element)|Optional element. A description of the code snippet. There may be zero or one `Description` elements in a `Header` element.|
|[HelpUrl element](../ide/code-snippets-schema-reference.md#helpurl-element)|Optional element. A URL that contains more information about the code snippet. There may be zero or one `HelpURL` elements in a Header element. **Note:**  Visual Studio does not use the `HelpUrl` element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.|
|[Keywords element](../ide/code-snippets-schema-reference.md#keywords-element)|Optional element. Groups `Keyword` elements. There may be zero or one `Keywords` elements in a `Header` element.|
|[Shortcut element](../ide/code-snippets-schema-reference.md#shortcut-element)|Optional element. Specifies the shortcut text that can be used to insert the snippet. There may be zero or one `Shortcut` elements in a `Header` element.|
|[SnippetTypes element](../ide/code-snippets-schema-reference.md#snippettypes-element)|Optional element. Groups `SnippetType` elements. There may be zero or one `SnippetTypes` elements in a `Header` element. If there are no `SnippetTypes` elements, the code snippet is always valid.|
|[Title element](../ide/code-snippets-schema-reference.md#title-element)|Required element. The friendly name of the code snippet. There must be exactly one `Title` element in a `Header` element.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippet element](../ide/code-snippets-schema-reference.md#codesnippet-element)|Parent element for all code snippet data.|

## HelpUrl element

Specifies a URL that provides more information about a code snippet.

> [!NOTE]
> Visual Studio does not use the `HelpUrl` element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.

```xml
<HelpUrl>
    www.microsoft.com
</HelpUrl>
```

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Contains general information about the code snippet.|

A text value is optional. This text specifies the URL to visit for more information about a code snippet.

## ID element

Specifies a unique identifier for a `Literal` or `Object` element. No two literals or objects in the same code snippet can have the same text value in their `ID` elements. Literals and objects cannot contain an `ID` element with a value of end. The value `$end$` is reserved, and is used to mark the location to place the cursor after the code snippet is inserted.

```xml
<ID>
    Unique Identifier
</ID>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](../ide/code-snippets-schema-reference.md#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the unique identifier for the object or literal.

## Import element

Specifies the imported namespaces used by an IntelliSense code snippet.

```xml
<Import>
    <Namespace>... </Namespace>
</Import>
```

|Child element|Description|
|-------------------|-----------------|
|[Namespace element](../ide/code-snippets-schema-reference.md#namespace-element)|Required element. Specifies the namespace used by the code snippet. There must be exactly one `Namespace` element in an `Import` element.|

|Parent element|Description|
| - |-----------------|
|[Imports element](../ide/code-snippets-schema-reference.md#imports-element)|Grouping element for **Import** elements.|

## Imports element

Groups individual `Import` elements.

```xml
<Imports>
    <Import>... </Import>
</Imports>
```

|Child element|Description|
|-------------------|-----------------|
|[Import element](../ide/code-snippets-schema-reference.md#import-element)|Optional element. Contains the imported namespaces for the code snippet. There may be zero or more **Import** elements in an `Imports` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](../ide/code-snippets-schema-reference.md#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Keyword element

Specifies a custom keyword for the code snippet. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization.

```xml
<Keyword>
    Code Snippet Keyword
</Keyword>
```

|Parent element|Description|
| - |-----------------|
|[Keywords element](../ide/code-snippets-schema-reference.md#keywords-element)|Groups individual `Keyword` elements.|

A text value is required. The keyword for the code snippet.

## Keywords element

Groups individual `Keyword` elements. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization

```xml
<Keywords>
    <Keyword>... </Keyword>
    <Keyword>... </Keyword>
</Keywords>
```

|Child element|Description|
|-------------------|-----------------|
|[Keyword element](../ide/code-snippets-schema-reference.md#keyword-element)|Optional element. Contains individual keywords for the code snippet. There may be zero or more `Keyword` elements in a `Keywords` element.|

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Contains general information about the code snippet.|

## Literal element

Defines the literals of the code snippet that you can edit. The `Literal` element is used to identify a replacement for a piece of code that is entirely contained within the snippet, but will likely be customized after it is inserted into the code. For example, literal strings, numeric values, and some variable names should be declared as literals.

Literals and objects cannot contain an **ID** element with a value of selected or end. The value `$selected$` represents text selected in the document that is to be inserted into the snippet when it is invoked. `$end$` marks the location to place the cursor after the code snippet is inserted.

```xml
<Literal Editable="true/false">
   <ID>... </ID>
   <ToolTip>... </ToolTip>
   <Default>... </Default>
   <Function>... </Function>
</Literal>
```

|Attribute|Description|
|---------------|-----------------|
|`Editable`|Optional `Boolean` attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is `true`.|

|Child element|Description|
|-------------------|-----------------|
|[Default element](../ide/code-snippets-schema-reference.md#default-element)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function element](../ide/code-snippets-schema-reference.md#function-element)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` elements in a `Literal` element.|
|[ID element](../ide/code-snippets-schema-reference.md#id-element)|Required element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip element](../ide/code-snippets-schema-reference.md#tooltip-element)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a `Literal` element.|

|Parent element|Description|
| - |-----------------|
|[Declarations element](../ide/code-snippets-schema-reference.md#declarations-element)|Contains the literals and objects of a code snippet that you can edit.|

## Namespace element

Specifies the namespace that must be imported for the code snippet to compile and run. The namespace specified in the `Namespace` element is automatically added to a `using` directive or `Imports` statement at the beginning of the code if it doesn't already exist.

```xml
<Namespace>
    Namespace
</Namespace>
```

|Parent element|Description|
| - |-----------------|
|[Import element](../ide/code-snippets-schema-reference.md#import-element)|Imports the specified namespace.|

A text value is required. This text specifies a namespace that the code snippet assumes is imported.

## Object element

Defines the objects of the code snippet that you can edit. The `Object` element is used to identify an item that is required by the code snippet but is likely to be defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require that a type be specified, which is done with the `Type` element.

```xml
<Object Editable="true/false">
    <ID>... </ID>
    <Type>... </Type>
    <ToolTip>... </ToolTip>
    <Default>... </Default>
    <Function>... </Function>
</Object>
```

|Attribute|Description|
|---------------|-----------------|
|`Editable`|Optional `Boolean` attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is `true`.|

|Child element|Description|
|-------------------|-----------------|
|[Default element](../ide/code-snippets-schema-reference.md#default-element)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function element](../ide/code-snippets-schema-reference.md#function-element)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` elements in a `Literal` element.|
|[ID element](../ide/code-snippets-schema-reference.md#id-element)|Required element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip element](../ide/code-snippets-schema-reference.md#tooltip-element)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a `Literal` element.|
|[Type element](../ide/code-snippets-schema-reference.md#type-element)|Required element. Specifies the type of the object. There must be exactly one `Type` element in an `Object` element.|

|Parent element|Description|
| - |-----------------|
|[Declarations element](../ide/code-snippets-schema-reference.md#declarations-element)|Contains the literals and objects of a code snippet that you can edit.|

## Reference element

Specifies information about the assembly references required by the code snippet.

```xml
<Reference>
    <Assembly>... </Assembly>
    <Url>... </Url>
</Reference>
```

|Child element|Description|
|-------------------|-----------------|
|[Assembly element](../ide/code-snippets-schema-reference.md#assembly-element)|Required element. Contains the name of the assembly referenced by the code snippet. There must be exactly one `Assembly` element in a `Reference` element.|
|[Url element](../ide/code-snippets-schema-reference.md#url-element)|Optional element. Contains a URL that provides more information about the referenced assembly. There may be zero or one `Url` elements in a `Reference` element.|

|Parent element|Description|
| - |-----------------|
|[References element](../ide/code-snippets-schema-reference.md#references-element)|Grouping element for `Reference` elements.|

## References element

Groups individual `Reference` elements.

```xml
<References>
    <Reference>... </Reference>
</References>
```

|Child element|Description|
|-------------------|-----------------|
|[Reference element](../ide/code-snippets-schema-reference.md#reference-element)|Optional element. Contains information about assembly references for the code snippet. There may be zero or more `Reference` elements in a `References` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](../ide/code-snippets-schema-reference.md#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Shortcut element

Specifies the shortcut text used to insert the snippet. The text value of a `Shortcut` element can only contain alphanumeric characters, and underscores ( _ ).

> [!CAUTION]
> Underscore (_) is not supported characters in C++ snippet shortcuts.

```xml
<Shortcut>
    Shortcut Text
</Shortcut>
```

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Contains general information about the code snippet.|

A text value is optional. This text is used as a shortcut for inserting the code snippet.

## Snippet element

Specifies the references, imports, declarations, and code for the code snippet.

```xml
<Snippet>
    <References>... </References>
    <Imports>... </Imports>
    <Declarations>... </Declarations>
    <Code>... </Code>
</Snippet>
```

|Child element|Description|
|-------------------|-----------------|
|[Code element](../ide/code-snippets-schema-reference.md#code-element)|Required element. Specifies the code that you want to insert into a documentation file. There must be exactly one `Code` element in a `Snippet` element.|
|[Declarations element](../ide/code-snippets-schema-reference.md#declarations-element)|Optional element. Specifies the literals and objects that make up the parts of a code snippet that you can edit. There may be zero or one `Declarations` elements in a `Snippet` element.|
|[Imports element](../ide/code-snippets-schema-reference.md#imports-element)|Optional element. Groups individual `Import` elements. There may be zero or one `Imports` elements in a `Snippet` element.|
|[References element](../ide/code-snippets-schema-reference.md#references-element)|Optional element. Groups individual `Reference` elements. There may be zero or one `References` elements in a `Snippet` element.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippet element](../ide/code-snippets-schema-reference.md#codesnippet-element)|Allows you to specify a heading and multiple IntelliSense Code Snippets, which you can insert into Visual Studio code files.|

## SnippetType element

Specifies how Visual Studio inserts the code snippet.

```xml
<SnippetType>
    SurroundsWith/Expansion
</SnippetType>
```

|Parent element|Description|
| - |-----------------|
|[SnippetTypes element](../ide/code-snippets-schema-reference.md#snippettypes-element)|Groups `SnippetType` elements.|

The text value must be one of the following values:

- `SurroundsWith`: allows the code snippet to be placed around a selected piece of code.

- `Expansion`: allows the code snippet to be inserted at the cursor.

- `Refactoring`: specifies that the code snippet is used during C# refactoring. `Refactoring` cannot be used in custom code snippets.

## SnippetTypes element

Groups individual `SnippetType` elements. If the `SnippetTypes` element is not present, the code snippet can be inserted anywhere in the code.

```xml
<SnippetTypes>
    <SnippetType>... </SnippetType>
    <SnippetType>... </SnippetType>
</SnippetTypes>
```

|Child element|Description|
|-------------------|-----------------|
|[SnippetType element](../ide/code-snippets-schema-reference.md#snippettype-element)|Optional element. Specifies how Visual Studio inserts the code snippet into the code. There may be zero or more `SnippetType` elements in a `SnippetTypes` element.|

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Specifies general information about the code snippet.|

## Title element

Specifies the title for the code snippet. The title stored in the `Title` element of the code snippet appears in the **Code Snippet Picker** and in the code snippet's description in the **Code Snippets Manager**.

```xml
<Title>
    Code Snippet Title
</Title>
```

|Parent element|Description|
| - |-----------------|
|[Header element](../ide/code-snippets-schema-reference.md#header-element)|Specifies general information about the code snippet.|

A text value is required. This text specifies the title of the code snippet.

## ToolTip element

Describes the expected value and usage of a literal or object in a code snippet, which Visual Studio displays in a ToolTip when it inserts the code snippet into a project. The ToolTip text is displayed when the mouse hovers over the literal or object after the code snippet has been inserted.

```xml
<ToolTip>
    ToolTip description
</ToolTip>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](../ide/code-snippets-schema-reference.md#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the ToolTip description to be associated with the object or literal in the code snippet.

## Type element

Specifies the type of the object. The `Object` element is used to identify an item that is required by the code snippet but is likely to be defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require that a type be specified, which is done with the `Type` element.

```xml
<Type>
    Type
</Type>
```

|Parent element|Description|
| - |-----------------|
|[Object element](../ide/code-snippets-schema-reference.md#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the type of the object. For example:

```xml
<Type>System.Data.SqlClient.SqlConnection</Type>
```

## Url element

Specifies a URL that provides more information about the referenced assembly.

> [!NOTE]
> The `Url` element is only supported for Visual Basic projects.

```xml
<Url>
    www.microsoft.com
</Url>
```

|Parent element|Description|
| - |-----------------|
|[Reference element](../ide/code-snippets-schema-reference.md#reference-element)|Specifies the assembly references required by the code snippet.|

A text value is required. This text specifies a URL with more information about the referenced assembly. This URL is displayed when the reference cannot be added to the project.

## See also

- [Code snippets](../ide/code-snippets.md)
- [Walkthrough: Create a code snippet](../ide/walkthrough-creating-a-code-snippet.md)
