---
title: Code snippets schema reference
description: Learn about the IntelliSense Code Snippet XML schema and how you can use them to increase your productivity.
ms.date: 04/06/2024
ms.topic: reference
helpviewer_keywords:
- schema reference [Visual Studio]
- snippets [Visual Studio], schema reference
- code snippets [Visual Studio], schema reference
- IntelliSense Code Snippets, XML Schema
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Code snippets schema reference

Code snippets are preauthored pieces of code that are ready to insert into your application. You can increase productivity and reliability by using code snippets to reduce the time spent typing repetitive code or searching for samples.

This article provides a reference to the Visual Studio IntelliSense Code Snippet XML schema. You can use the schema to create your own code snippets and add them to the code snippets that Visual Studio already includes.

- For more information on creating code snippets, see [Walkthrough: Create a code snippet in Visual Studio](walkthrough-creating-a-code-snippet.md).
- For information about the code snippets that Visual Studio includes by default, see [C# code snippets](visual-csharp-code-snippets.md) or [Visual C++ code snippets](visual-cpp-code-snippets.md).

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
|[Reference element](#reference-element)|Contains information about assembly references required by the code snippet.|

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
|[Header element](#header-element)|Contains general information about the code snippet.|

A text value is required. This text specifies the author of the code snippet.

## Code element

Provides a container for short code blocks.

### Keywords

Two reserved words are available for use in the text of the `Code` element: `$end$` and `$selected$`. `$end$` marks the location to place the cursor after the code snippet is inserted. `$selected$` represents selected document text to insert into the snippet when the snippet is invoked. For example, given a snippet that includes:

```text
$selected$ is a great color.
```

If the word `Blue` is selected when the user invokes the snippet, the result is:

```text
Blue is a great color.
```

You may not use either `$end$` or `$selected$` more than once in a code snippet. If you do, only the second instance is recognized. Given a snippet that includes:

```text
$selected$ is a great color. I love $selected$.
```

If the word `Blue` is selected, the result is:

```text
 is a great color. I love Blue.
```

The initial space appears because there's a space between `$selected$` and `is`.

All other `$` keywords are dynamically defined in the `<Literal>` and `<Object>` tags.

The following code shows the structure of the `Code` element:

```xml
<Code Language="Language"
    Kind="method body/method decl/type decl/page/file/any"
    Delimiter="Delimiter">
    Code to insert
</Code>
```

A text value is required. This text specifies the code, along with the literals and objects, that you can use when this code snippet is inserted into a code file.

### Attributes

There are three attributes available for the `Code` element:

- **Language**. *Required* attribute that specifies the language of the code snippet. The value must be one of the following values:

   |Value|Description|
   |-----|-----------|
   |`VB`|Visual Basic code snippet.|
   |`CSharp`|C# code snippet.|
   |`CPP`|C++ code snippet.|
   |`XAML`|XAML code snippet.|
   |`XML`|XML code snippet.|
   |`JavaScript`|JavaScript code snippet.|
   |`TypeScript`|TypeScript code snippet.|
   |`SQL`|SQL code snippet.|
   |`HTML`|HTML code snippet.|

- **Kind**. Optional attribute that specifies the kind of code that the snippet contains. The value must be one of the following values:

   |Value|Description|
   |-----|-----------|
   |`method body`|The snippet is a method body, and therefore must be inserted inside a method declaration.|
   |`method decl`|The snippet is a method, and therefore must be inserted inside a class or module.|
   |`type decl`|The snippet is a type, and therefore must be inserted inside a class, module, or namespace.|
   |`file`|The snippet is a full code file and can be inserted alone into a code file or inside a namespace.|
   |`any`|The snippet can be inserted anywhere. This tag is used for code snippets that are context-independent, such as comments.|

- **Delimiter**. Optional attribute that specifies the delimiter used to describe literals and objects in the code. By default, the delimiter is `$`.

### Parent element

|Parent element|Description|
| - |-----------------|
|[Snippet element](#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## CodeSnippet element

Allows you to specify a heading and multiple code snippets, which you can insert into Visual Studio Code files.

```xml
<CodeSnippet Format="x.x.x">
    <Header>... </Header>
    <Snippet>... </Snippet>
</CodeSnippet>
```

|Attribute|Description|
|---------------|-----------------|
|**Format**|*Required* attribute. Specifies the schema version of the code snippet. The **Format** attribute must be a string in the syntax of `x.x.x`, where each `x` represents a numerical value of the version number. Visual Studio ignores code snippets with **Format** attributes that it doesn't understand.|

|Child element|Description|
|-------------------|-----------------|
|[Header element](#header-element)|*Required* element. Contains general information about the code snippet. There must be exactly one `Header` element in a code snippet.|
|[Snippet element](#snippet-element)|*Required* element. Contains the code to be inserted by Visual Studio. There must be exactly one `Snippet` element in a code snippet.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippets element](#codesnippets-element)|Root element of the code snippet XML schema.|

## CodeSnippets element

Groups [CodeSnippet](#codesnippet-element) elements. The `CodeSnippets` element is the root element of the code snippet XML schema.

```xml
<CodeSnippets>
    <CodeSnippet>... </CodeSnippet>
</CodeSnippets>
```

|Child element|Description|
|-------------------|-----------------|
|[CodeSnippet element](#codesnippet-element)|Optional element. Parent element for all code snippet data. There may be zero or more `CodeSnippet` elements in a `CodeSnippets` element.|

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
|[Literal element](#literal-element)|Optional element. Defines the literals of the code snippet that you can edit. There may be zero or more `Literal` elements in a `Declarations` element.|
|[Object element](#object-element)|Optional element. Defines the objects of the code snippet that you can edit. There may be zero or more `Object` elements in a `Declarations` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Default element

Specifies the default value of the literal or object for a code snippet.

```xml
<Default>
    Default value
</Default>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the default value of the literal or object that fills the fields of the code snippet that you can edit.

## Description element

Specifies descriptive information about the contents of a code snippet.

```xml
<Description>
    Code Snippet Description
</Description>
```

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Contains general information about the code snippet.|

A text value is required. This text describes the code snippet.

## Function element

Specifies a function to execute when the literal or object receives focus in Visual Studio.

> [!NOTE]
> Not all languages support `Function` elements. See language specific documentation for what functions are available.

```xml
<Function>
    FunctionName
</Function>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies a function to execute when the literal or object field receives focus in Visual Studio.

## Header element

Specifies general information about the code snippet.

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
|[Author element](#author-element)|Optional element. The name of the person or company that authored the code snippet. There may be zero or one `Author` element in a `Header` element.|
|[Description element](#description-element)|Optional element. A description of the code snippet. There may be zero or one `Description` element in a `Header` element.|
|[HelpUrl element](#helpurl-element)|Optional element. A URL that contains more information about the code snippet. There may be zero or one `HelpURL` element in a `Header` element.|
|[Keywords element](#keywords-element)|Optional element. Groups `Keyword` elements. There may be zero or one `Keywords` element in a `Header` element.|
|[Shortcut element](#shortcut-element)|Optional element. Specifies the shortcut text that can be used to insert the snippet. There may be zero or one `Shortcut` element in a `Header` element.|
|[SnippetTypes element](#snippettypes-element)|Optional element. Groups `SnippetType` elements. There may be zero or one `SnippetTypes` element in a `Header` element. If there are no `SnippetTypes` elements, the code snippet is always valid.|
|[Title element](#title-element)|*Required* element. The friendly name of the code snippet. There must be exactly one `Title` element in a `Header` element.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippet element](#codesnippet-element)|Parent element for all code snippet data.|

## HelpUrl element

Specifies a URL that provides more information about a code snippet.

> [!NOTE]
> Visual Studio doesn't use the `HelpUrl` element. The element is part of the IntelliSense Code Snippet XML schema, and code snippets containing the element validate, but the value of the element is never used.

```xml
<HelpUrl>
    www.microsoft.com
</HelpUrl>
```

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Contains general information about the code snippet.|

A text value is optional. This text specifies the URL to visit for more information about a code snippet.

## ID element

Specifies a unique identifier for a `Literal` or `Object` element. No two literals or objects in the same code snippet can have the same text value in their `ID` elements. Literals and objects can't contain an `ID` element with a value of `end`. The value `$end$` is reserved, and is used to mark the location to place the cursor after the code snippet is inserted.

```xml
<ID>
    Unique Identifier
</ID>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the unique identifier for the object or literal.

## Import element

Specifies the imported namespaces used by a code snippet.

```xml
<Import>
    <Namespace>... </Namespace>
</Import>
```

|Child element|Description|
|-------------------|-----------------|
|[Namespace element](#namespace-element)|*Required* element. Specifies the namespace used by the code snippet. There must be exactly one `Namespace` element in an `Import` element.|

|Parent element|Description|
| - |-----------------|
|[Imports element](#imports-element)|Grouping element for `Import` elements.|

## Imports element

Groups individual `Import` elements.

```xml
<Imports>
    <Import>... </Import>
</Imports>
```

|Child element|Description|
|-------------------|-----------------|
|[Import element](#import-element)|Optional element. Contains the imported namespaces for the code snippet. There may be zero or more `Import` elements in an `Imports` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Keyword element

Specifies a custom keyword for the code snippet. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization.

```xml
<Keyword>
    Code Snippet Keyword
</Keyword>
```

|Parent element|Description|
| - |-----------------|
|[Keywords element](#keywords-element)|Groups individual `Keyword` elements.|

A text value is required. The keyword for the code snippet.

## Keywords element

Groups individual `Keyword` elements. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization.

```xml
<Keywords>
    <Keyword>... </Keyword>
    <Keyword>... </Keyword>
</Keywords>
```

|Child element|Description|
|-------------------|-----------------|
|[Keyword element](#keyword-element)|Optional element. Contains individual keywords for the code snippet. There may be zero or more `Keyword` elements in a `Keywords` element.|

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Contains general information about the code snippet.|

## Literal element

Defines the literals of the code snippet that you can edit. The `Literal` element identifies a replacement for a piece of code entirely contained within the snippet that can be customized after the snippet is inserted. For example, literal strings, numeric values, and some variable names should be declared as literals.

Literals and objects can't contain an `ID` element with a value of `selected` or `end`. The value `$selected$` represents selected document text to be inserted into the snippet when the snippet is invoked. `$end$` marks the location to place the cursor after the code snippet is inserted.

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
|**Editable**|Optional `Boolean` attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is `true`.|

|Child element|Description|
|-------------------|-----------------|
|[Default element](#default-element)|*Required* element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function element](#function-element)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` element in a `Literal` element.|
|[ID element](#id-element)|*Required* element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip element](#tooltip-element)|Optional element. Describes the expected value and usage of the literal. There may be zero or one `ToolTip` element in a `Literal` element.|

|Parent element|Description|
| - |-----------------|
|[Declarations element](#declarations-element)|Contains the literals and objects of a code snippet that you can edit.|

## Namespace element

Specifies the namespace that must be imported for the code snippet to compile and run. The namespace specified in the `Namespace` element is automatically added to a `using` directive or `Imports` statement at the beginning of the code if it doesn't already exist.

```xml
<Namespace>
    Namespace
</Namespace>
```

|Parent element|Description|
| - |-----------------|
|[Import element](#import-element)|Imports the specified namespace.|

A text value is required. This text specifies a namespace that the code snippet assumes is imported.

## Object element

Defines the objects of the code snippet that you can edit. The `Object` element identifies an item required by the code snippet that's defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require a type to be specified, which is done with the `Type` element.

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
|**Editable**|Optional `Boolean` attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is `true`.|

|Child element|Description|
|-------------------|-----------------|
|[Default element](#default-element)|*Required* element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function element](#function-element)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` element in a `Literal` element.|
|[ID element](#id-element)|*Required* element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip element](#tooltip-element)|Optional element. Describes the expected value and usage of the literal. There may be zero or one `ToolTip` element in a `Literal` element.|
|[Type element](#type-element)|*Required* element. Specifies the type of the object. There must be exactly one `Type` element in an `Object` element.|

|Parent element|Description|
| - |-----------------|
|[Declarations element](#declarations-element)|Contains the literals and objects of a code snippet that you can edit.|

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
|[Assembly element](#assembly-element)|*Required* element. Contains the name of the assembly referenced by the code snippet. There must be exactly one `Assembly` element in a `Reference` element.|
|[Url element](#url-element)|Optional element. Contains a URL that provides more information about the referenced assembly. There may be zero or one `Url` element in a `Reference` element.|

|Parent element|Description|
| - |-----------------|
|[References element](#references-element)|Grouping element for `Reference` elements.|

## References element

Groups individual `Reference` elements.

```xml
<References>
    <Reference>... </Reference>
</References>
```

|Child element|Description|
|-------------------|-----------------|
|[Reference element](#reference-element)|Optional element. Contains information about assembly references for the code snippet. There may be zero or more `Reference` elements in a `References` element.|

|Parent element|Description|
| - |-----------------|
|[Snippet element](#snippet-element)|Contains the references, imports, declarations, and code for the code snippet.|

## Shortcut element

Specifies the shortcut text used to insert the snippet. The text value of a `Shortcut` element can only contain alphanumeric characters and underscores (`_`).

> [!NOTE]
> The underscore (`_`) character isn't supported in C++ snippet shortcuts.

```xml
<Shortcut>
    Shortcut Text
</Shortcut>
```

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Contains general information about the code snippet.|

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
|[Code element](#code-element)|*Required* element. Specifies the code that you want to insert into a documentation file. There must be exactly one `Code` element in a `Snippet` element.|
|[Declarations element](#declarations-element)|Optional element. Specifies the literals and objects that make up the parts of a code snippet that you can edit. There may be zero or one `Declarations` element in a `Snippet` element.|
|[Imports element](#imports-element)|Optional element. Groups individual `Import` elements. There may be zero or one `Imports` element in a `Snippet` element.|
|[References element](#references-element)|Optional element. Groups individual `Reference` elements. There may be zero or one `References` element in a `Snippet` element.|

|Parent element|Description|
| - |-----------------|
|[CodeSnippet element](#codesnippet-element)|Allows you to specify a heading and multiple code snippets, which you can insert into Visual Studio Code files.|

## SnippetType element

Specifies how Visual Studio adds the code snippet.

```xml
<SnippetType>
    SurroundsWith/Expansion
</SnippetType>
```

|Parent element|Description|
| - |-----------------|
|[SnippetTypes element](#snippettypes-element)|Groups `SnippetType` elements.|

The value must be one of the following values:

|Value|Description|
|-----|-----------|
|`Expansion`|Allows the code snippet to be inserted at the cursor.
|`Refactoring`|Specifies that the code snippet is used during C# refactoring. `Refactoring` can't be used in custom code snippets.
|`SurroundsWith`|Allows the code snippet to be placed around a selected piece of code.|

## SnippetTypes element

Groups individual `SnippetType` elements. If the `SnippetTypes` element isn't present, the code snippet can be inserted at the cursor or placed around selected code.

```xml
<SnippetTypes>
    <SnippetType>... </SnippetType>
    <SnippetType>... </SnippetType>
</SnippetTypes>
```

|Child element|Description|
|-------------------|-----------------|
|[SnippetType element](#snippettype-element)|Optional element. Specifies how Visual Studio inserts the code snippet into the code. There may be zero or more `SnippetType` elements in a `SnippetTypes` element.|

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Specifies general information about the code snippet.|

## Title element

Specifies the title for the code snippet. The title stored in the `Title` element of the code snippet appears in the code snippet picker and as the code snippet's name in the **Code Snippets Manager**.

```xml
<Title>
    Code Snippet Title
</Title>
```

|Parent element|Description|
| - |-----------------|
|[Header element](#header-element)|Specifies general information about the code snippet.|

A text value is required. This text specifies the title of the code snippet.

## ToolTip element

Describes the expected value and usage of a literal or object in a code snippet. Visual Studio displays this information in a ToolTip when it inserts the code snippet into a project. The ToolTip also displays when the mouse hovers over the literal or object after the code snippet is inserted.

```xml
<ToolTip>
    ToolTip description
</ToolTip>
```

|Parent element|Description|
| - |-----------------|
|[Literal element](#literal-element)|Defines the literal fields of the code snippet that you can edit.|
|[Object element](#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the ToolTip description to be associated with the object or literal in the code snippet.

## Type element

Specifies the type of the object. The `Object` element identifies an item that the code snippet requires but is probably defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require a type to be specified, which is done with the `Type` element.

```xml
<Type>
    Type
</Type>
```

|Parent element|Description|
| - |-----------------|
|[Object element](#object-element)|Defines the object fields of the code snippet that you can edit.|

A text value is required. This text specifies the type of the object. For example:

```xml
<Type>System.Data.SqlClient.SqlConnection</Type>
```

## Url element

Specifies a URL that provides more information about the referenced assembly.

> [!NOTE]
> The `Url` element is supported only for Visual Basic projects.

```xml
<Url>
    www.microsoft.com
</Url>
```

|Parent element|Description|
| - |-----------------|
|[Reference element](#reference-element)|Specifies the assembly references required by the code snippet.|

A text value is required. This text specifies a URL with more information about the referenced assembly. This URL is displayed when the reference can't be added to the project.

## Related content

- [Code snippets](code-snippets.md)
- [Walkthrough: Create a code snippet](walkthrough-creating-a-code-snippet.md)
