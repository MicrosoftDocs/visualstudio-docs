---
title: "Code Snippets Schema Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "schema reference [Visual Studio]"
  - "snippets [Visual Studio], schema reference"
  - "code snippets [Visual Studio], schema reference"
  - "IntelliSense Code Snippets, XML Schema"
ms.assetid: 58a60621-725f-4763-93b7-62ea5424ef88
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Code Snippets Schema Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

IntelliSense Code Snippets are pre-authored pieces of code that are ready to be inserted into your application with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. You can increase productivity by providing code snippets that reduce the amount of time spent typing repetitive code or searching for samples. You can use the IntelliSense Code Snippet XML schema to create your own code snippets and add them to the code snippets that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] already includes.

## IntelliSense Code Snippets Schema Elements

||||
|-|-|-|
|[Assembly Element](../ide/code-snippets-schema-reference.md#assembly)|[HelpUrl Element](../ide/code-snippets-schema-reference.md#helpurl)|[References Element](../ide/code-snippets-schema-reference.md#references)|
|[Author Element](../ide/code-snippets-schema-reference.md#author)|[ID Element](../ide/code-snippets-schema-reference.md#id)|[Shortcut Element](../ide/code-snippets-schema-reference.md#shortcut)|
|[Code Element](../ide/code-snippets-schema-reference.md#code)|[Import Element](../ide/code-snippets-schema-reference.md#import)|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|
|[CodeSnippet Element](../ide/code-snippets-schema-reference.md#codesnippet)|[Imports Element](../ide/code-snippets-schema-reference.md#imports)|[SnippetType Element](../ide/code-snippets-schema-reference.md#snippettype)|
|[CodeSnippets Element](../ide/code-snippets-schema-reference.md#codesnippets)|[Keyword Element](../ide/code-snippets-schema-reference.md#keyword)|[SnippetTypes Element](../ide/code-snippets-schema-reference.md#snippettypes)|
|[Declarations Element](../ide/code-snippets-schema-reference.md#declarations)|[Keywords Element](../ide/code-snippets-schema-reference.md#keywords)|[Title Element](../ide/code-snippets-schema-reference.md#title)|
|[Default Element](../ide/code-snippets-schema-reference.md#default)|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|[ToolTip Element](../ide/code-snippets-schema-reference.md#tooltip)|
|[Description Element](../ide/code-snippets-schema-reference.md#description)|[Namespace Element](../ide/code-snippets-schema-reference.md#namespace)|[Type Element](../ide/code-snippets-schema-reference.md#type)|
|[Function Element](../ide/code-snippets-schema-reference.md#function)|[Object Element](../ide/code-snippets-schema-reference.md#object)|[Url Element](../ide/code-snippets-schema-reference.md#url)|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|[Reference Element](../ide/code-snippets-schema-reference.md#reference)||

## <a name="assembly"></a> Assembly Element
 Specifies the name of the assembly referenced by the code snippet.

> [!NOTE]
> The `Assembly` element is only supported by Visual Basic code snippets.

 The text value of the **Assembly** element is either the friendly text name of the assembly, such as `System.dll`, or its strong name, such as `System,Version=1.0.0.1,Culture=neutral,PublicKeyToken=9b35aa323c18d4fb1`.

```xml
<Assembly>
    AssemblyName
</Assembly>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Reference Element](../ide/code-snippets-schema-reference.md#reference)|Contains information about assembly references required by the code snippet.|

 A text value is required. This text specifies the assembly that the code snippet references.

## <a name="author"></a> Author Element
 Specifies the name of the snippet author. The **Code Snippets Manager** displays the name stored in the `Author` element of the code snippet.

```xml
<Author>
   Code Snippet Author
</Author>

```

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|

 A text value is required. This text specifies the author of the code snippet.

## <a name="code"></a> Code Element
 Provides a container for short code blocks.

 Two reserved words are available for use in the text of the `Code` element: `$end$` and `$selected$`. `$end$` marks the location to place the cursor after the code snippet is inserted. `$selected$` represents text selected in the document that is to be inserted into the snippet when it is invoked. For example, given a snippet that includes:

```xml
$selected$ is a great color.
```

 If the word "Blue" is selected when the user invokes the template, the result is:

```xml
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

```xml
<Code Language="Language"
    Kind="method body/method decl/type decl/page/file/any"
    Delimiter="Delimiter">
    Code to insert
</Code>
```

|Attribute|Description|
|---------------|-----------------|
|`Delimiter`|Optional attribute. Specifies the delimiter used to describe literals and objects in the code. By default, the delimiter is `$`.|
|`Kind`|Optional attribute. Specifies the kind of code that the snippet contains and the location at which a code snippet must be inserted for the code snippet to compile. The values available are `method body`, `method decl`, `type decl`, `file`, and `any`.|
|`Language`|Required attribute. Specifies the language of the code snippet.|

|Kind Attribute Value|Description|
|--------------------------|-----------------|
|`method body`|Specifies that the code snippet is a method body, and therefore, must be inserted inside a method declaration.|
|`method decl`|Specifies that the code snippet is a method, and therefore, must be inserted inside a class or module.|
|`type decl`|Specifies that the code snippet is a type, and therefore, must be inserted inside a class, module, or namespace.|
|`file`|Specifies that the snippet is a full code file. These code snippets can be inserted alone into a code file, or inside a namespace.|
|`any`|Specifies that the snippet can be inserted anywhere. This tag is used for code snippets that are context-independent, such as comments.|

|Language Attribute Value|Description|
|------------------------------|-----------------|
|`VB`|Identifies a Visual Basic code snippet.|
|`CSharp`|Identifies a C# code snippet.|
|`CPP`|Identifies a C++ code snippet.|
|`XML`|Identifies an XML code snippet.|
|`JavaScript`|Identifies a JavaScript code snippet.|
|`SQL`|Identifies a SQL code snippet.|
|`HTML`|Identifies an HTML code snippet.|

|Parent Element|Description|
|--------------------|-----------------|
|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|

 A text value is required. This text specifies the code, along with the literals and objects, that you can use when this code snippet is inserted into a project.

## <a name="codesnippet"></a> CodeSnippet Element
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

|Child Element|Description|
|-------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Required element. Contains general information about the code snippet. There must be exactly one `Header` element in a code snippet.|
|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|Required element. Contains the code that will be inserted by Visual Studio. There must be exactly one `Snippet` element in a code snippet.|

|Parent Element|Description|
|--------------------|-----------------|
|[CodeSnippets Element](../ide/code-snippets-schema-reference.md#codesnippets)|Root element of the code snippet XML schema.|

## <a name="codesnippets"></a> CodeSnippets Element
 Groups [CodeSnippet Element](../ide/code-snippets-schema-reference.md#codesnippet)elements. The `CodeSnippets` element is the root element of the code snippet XML schema.

```xml
<CodeSnippets>
    <CodeSnippet>... </CodeSnippet>
</CodeSnippets>

```

|Child Element|Description|
|-------------------|-----------------|
|[CodeSnippet Element](../ide/code-snippets-schema-reference.md#codesnippet)|Optional element. Parent element for all code snippet data. There may be zero or more `CodeSnippet` elements in a `CodeSnippets` element.|

## <a name="declarations"></a> Declarations Element
 Specifies the literals and objects that make up the parts of a code snippet that you can edit.

```xml
<Declarations>
    <Literal>... </Literal>
    <Object>... </Object>
</Declarations>

```

|Child Element|Description|
|-------------------|-----------------|
|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|Optional element. Defines the literals of the code snippet that you can edit. There may be zero or more `Literal` elements in a `Declarations` element.|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Optional element. Defines the objects of the code snippet that you can edit. There may be zero or more `Object` elements in a `Declarations` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|

## <a name="default"></a> Default Element
 Specifies the default value of the literal or object for an IntelliSense Code Snippet.

```xml
<Default>
    Default value
</Default>

```

|Parent Element|Description|
|--------------------|-----------------|
|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|

 A text value is required. This text specifies the default value of the literal or object that fills the fields of the code snippet that you can edit.

## <a name="description"></a> Description Element
 Specifies descriptive information about the contents of an IntelliSense Code Snippet.

```xml
<Description>
    Code Snippet Description
</Description>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|

 A text value is required. This text describes the code snippet.

## <a name="function"></a> Function Element
 Specifies a function to execute when the literal or object receives focus in Visual Studio.

> [!NOTE]
> The `Function` element is only supported in Visual C# code snippets.

```xml
<Function>
    FunctionName
</Function>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|

 A text value is required. This text specifies a function to execute when the literal or object field receives focus in Visual Studio.

## <a name="header"></a> Header Element
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

|Child Element|Description|
|-------------------|-----------------|
|[Author Element](../ide/code-snippets-schema-reference.md#author)|Optional element. The name of the person or company that authored the code snippet. There may be zero or one `Author` elements in a `Header` element.|
|[Description Element](../ide/code-snippets-schema-reference.md#description)|Optional element. A description of the code snippet. There may be zero or one `Description` elements in a `Header` element.|
|[HelpUrl Element](../ide/code-snippets-schema-reference.md#helpurl)|Optional element. A URL that contains more information about the code snippet. There may be zero or one `HelpURL` elements in a Header element. **Note:**  Visual Studio does not use the `HelpUrl` element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.|
|[Keywords Element](../ide/code-snippets-schema-reference.md#keywords)|Optional element. Groups `Keyword` elements. There may be zero or one `Keywords` elements in a `Header` element.|
|[Shortcut Element](../ide/code-snippets-schema-reference.md#shortcut)|Optional element. Specifies the shortcut text that can be used to insert the snippet. There may be zero or one `Shortcut` elements in a `Header` element.|
|[SnippetTypes Element](../ide/code-snippets-schema-reference.md#snippettypes)|Optional element. Groups `SnippetType` elements. There may be zero or one `SnippetTypes` elements in a `Header` element. If there are no `SnippetTypes` elements, the code snippet is always valid.|
|[Title Element](../ide/code-snippets-schema-reference.md#title)|Required element. The friendly name of the code snippet. There must be exactly one `Title` element in a `Header` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[CodeSnippet Element](../ide/code-snippets-schema-reference.md#codesnippet)|Parent element for all code snippet data.|

## <a name="helpurl"></a> HelpUrl Element
 Specifies a URL that provides more information about a code snippet.

> [!NOTE]
> Visual Studio does not use the `HelpUrl` element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.

```xml
<HelpUrl>
    www.microsoft.com
</HelpUrl>

```

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|

 A text value is optional. This text specifies the URL to visit for more information about a code snippet.

## <a name="id"></a> ID Element
 Specifies a unique identifier for a `Literal` or `Object` element. No two literals or objects in the same code snippet can have the same text value in their `ID` elements.Literals and objects cannot contain an `ID` element with a value of end. The value `$end$` is reserved, and is used to mark the location to place the cursor after the code snippet is inserted.

```xml
<ID>
    Unique Identifier
</ID>

```

|Parent Element|Description|
|--------------------|-----------------|
|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|

 A text value is required. This text specifies the unique identifier for the object or literal.

## <a name="import"></a> Import Element
 Specifies the imported namespaces used by an IntelliSense Code Snippet.

> [!NOTE]
> The `Import` element is only supported for Visual Basic projects.

```xml
<Import>
    <Namespace>... </Namespace>
</Import>

```

|Child Element|Description|
|-------------------|-----------------|
|[Namespace Element](../ide/code-snippets-schema-reference.md#namespace)|Required element. Specifies the namespace used by the code snippet. There must be exactly one `Namespace` element in an `Import` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Imports Element](../ide/code-snippets-schema-reference.md#imports)|Grouping element for **Import** elements.|

## <a name="imports"></a> Imports Element
 Groups individual `Import` elements.

> [!NOTE]
> The `Imports` element is only supported for Visual Basic projects.

```xml
<Imports>
    <Import>... </Import>
<Imports>
```

|Child Element|Description|
|-------------------|-----------------|
|[Import Element](../ide/code-snippets-schema-reference.md#import)|Optional element. Contains the imported namespaces for the code snippet. There may be zero or more **Import** elements in an `Imports` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|

## <a name="keyword"></a> Keyword Element
 Specifies a custom keyword for the code snippet. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization.

```xml
<Keyword>
    Code Snippet Keyword
</Keyword>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Keywords Element](../ide/code-snippets-schema-reference.md#keywords)|Groups individual `Keyword` elements.|

 A text value is required. The keyword for the code snippet.

## <a name="keywords"></a> Keywords Element
 Groups individual `Keyword` elements. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization

```xml
<Keywords>
    <Keyword>... </Keyword>
    <Keyword>... </Keyword>
<Keywords>
```

|Child Element|Description|
|-------------------|-----------------|
|[Keyword Element](../ide/code-snippets-schema-reference.md#keyword)|Optional element. Contains individual keywords for the code snippet. There may be zero or more `Keyword` elements in a `Keywords` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|

## <a name="literal"></a> Literal Element
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

|Child Element|Description|
|-------------------|-----------------|
|[Default Element](../ide/code-snippets-schema-reference.md#default)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function Element](../ide/code-snippets-schema-reference.md#function)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` elements in a `Literal` element.|
|[ID Element](../ide/code-snippets-schema-reference.md#id)|Required element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip Element](../ide/code-snippets-schema-reference.md#tooltip)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a `Literal` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Declarations Element](../ide/code-snippets-schema-reference.md#declarations)|Contains the literals and objects of a code snippet that you can edit.|

## <a name="namespace"></a> Namespace Element
 Specifies the namespace that must be imported for the code snippet to compile and run. The namespace specified in the `Namespace` element is automatically added to an `Imports` statement at the beginning of the code, if it does not already exist.

> [!NOTE]
> The `Namespace` element is only supported for Visual Basic projects.

```xml
<Namespace>
    Namespace
</Namespace>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Import Element](../ide/code-snippets-schema-reference.md#import)|Imports the specified namespace.|

 A text value is required. This text specifies a namespace that the code snippet assumes is imported.

## <a name="object"></a> Object Element
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

|Child Element|Description|
|-------------------|-----------------|
|[Default Element](../ide/code-snippets-schema-reference.md#default)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one `Default` element in a `Literal` element.|
|[Function Element](../ide/code-snippets-schema-reference.md#function)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one `Function` elements in a `Literal` element.|
|[ID Element](../ide/code-snippets-schema-reference.md#id)|Required element. Specifies a unique identifier for the literal. There must be exactly one `ID` element in a `Literal` element.|
|[ToolTip Element](../ide/code-snippets-schema-reference.md#tooltip)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a `Literal` element.|
|[Type Element](../ide/code-snippets-schema-reference.md#type)|Required element. Specifies the type of the object. There must be exactly one `Type` element in an `Object` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Declarations Element](../ide/code-snippets-schema-reference.md#declarations)|Contains the literals and objects of a code snippet that you can edit.|

## <a name="reference"></a> Reference Element
 Specifies information about the assembly references required by the code snippet.

> [!NOTE]
> The `Reference` element is only supported for Visual Basic projects.

```xml
<Reference>
    <Assembly>... </Assembly>
    <Url>... </Url>
</Reference>
```

|Child Element|Description|
|-------------------|-----------------|
|[Assembly Element](../ide/code-snippets-schema-reference.md#assembly)|Required element. Contains the name of the assembly referenced by the code snippet. There must be exactly one `Assembly` element in a `Reference` element.|
|[Url Element](../ide/code-snippets-schema-reference.md#url)|Optional element. Contains a URL that provides more information about the referenced assembly. There may be zero or one `Url` elements in a `Reference` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[References Element](../ide/code-snippets-schema-reference.md#references)|Grouping element for `Reference` elements.|

## <a name="references"></a> References Element
 Groups individual `Reference` elements.

> [!NOTE]
> The `References` element is only supported for Visual Basic projects.

```xml
<References>
    <Reference>... </Reference>
</References>
```

|Child Element|Description|
|-------------------|-----------------|
|[Reference Element](../ide/code-snippets-schema-reference.md#reference)|Optional element. Contains information about assembly references for the code snippet. There may be zero or more `Reference` elements in a `References` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Snippet Element](../ide/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|

## <a name="shortcut"></a> Shortcut Element
 Specifies the shortcut text used to insert the snippet. The text value of a `Shortcut` element can only contain alphanumeric characters, hyphens ( - ), and underscores ( _ ).

> [!CAUTION]
> _ and – are not supported characters in C++ snippet shortcuts.

```xml
<Shortcut>
    Shortcut Text
</Shortcut>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|

 A text value is optional. This text is used as a shortcut for inserting the code snippet.

## <a name="snippet"></a> Snippet Element
 Specifies the references, imports, declarations, and code for the code snippet.

```xml
<Snippet>
    <References>... </References>
    <Imports>... </Imports>
    <Declarations>... </Declarations>
    <Code>... </Code>
</Snippet>

```

|Child Element|Description|
|-------------------|-----------------|
|[Code Element](../ide/code-snippets-schema-reference.md#code)|Required element. Specifies the code that you want to insert into a documentation file. There must be exactly one `Code` element in a `Snippet` element.|
|[Declarations Element](../ide/code-snippets-schema-reference.md#declarations)|Optional element. Specifies the literals and objects that make up the parts of a code snippet that you can edit. There may be zero or one `Declarations` elements in a `Snippet` element.|
|[Imports Element](../ide/code-snippets-schema-reference.md#imports)|Optional element. Groups individual `Import` elements. There may be zero or one `Imports` elements in a `Snippet` element.|
||Optional element. Groups individual `Reference` elements. There may be zero or one `References` elements in a `Snippet` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[CodeSnippet Element](../ide/code-snippets-schema-reference.md#codesnippet)|Allows you to specify a heading and multiple IntelliSense Code Snippets, which you can insert into Visual Studio code files.|

## <a name="snippettype"></a> SnippetType Element
 Specifies how Visual Studio inserts the code snippet.

```xml
<SnippetType>
    SurroundsWith/Expansion
<SnippetType>
```

|Parent Element|Description|
|--------------------|-----------------|
|[SnippetTypes Element](../ide/code-snippets-schema-reference.md#snippettypes)|Groups `SnippetType` elements.|

 The text value must be one of the following values:

- `SurroundsWith`: allows the code snippet to be placed around a selected piece of code.

- `Expansion`: allows the code snippet to be inserted at the cursor.

- `Refactoring`: specifies that the code snippet is used during Visual C# refactoring. `Refactoring` cannot be used in custom code snippets.

## <a name="snippettypes"></a> SnippetTypes Element
 Groups individual `SnippetType` elements. If the `SnippetTypes` element is not present, the code snippet can be inserted anywhere in the code.

```xml
<SnippetTypes>
    <SnippetType>... </SnippetType>
    <SnippetType>... </SnippetType>
<SnippetTypes>
```

|Child Element|Description|
|-------------------|-----------------|
|[SnippetType Element](../ide/code-snippets-schema-reference.md#snippettype)|Optional element. Specifies how Visual Studio inserts the code snippet into the code. There may be zero or more `SnippetType` elements in a `SnippetTypes` element.|

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Specifies general information about the code snippet.|

## <a name="title"></a> Title Element
 Specifies the title for the code snippet. The title stored in the `Title` element of the code snippet appears in the **Code Snippet Picker** and in the code snippet's description in the **Code Snippets Manager**.

```xml
<Title>
    Code Snippet Title
<Title>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Header Element](../ide/code-snippets-schema-reference.md#header)|Specifies general information about the code snippet.|

 A text value is required. This text specifies the title of the code snippet.

## <a name="tooltip"></a> ToolTip Element
 Describes the expected value and usage of a literal or object in a code snippet, which Visual Studio displays in a ToolTip when it inserts the code snippet into a project. The ToolTip text is displayed when the mouse hovers over the literal or object after the code snippet has been inserted.

```xml
<ToolTip>
    ToolTip description
</ToolTip>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Literal Element](../ide/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|

 A text value is required. This text specifies the ToolTip description to be associated with the object or literal in the code snippet.

## <a name="type"></a> Type Element
 Specifies the type of the object. The `Object` element is used to identify an item that is required by the code snippet but is likely to be defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require that a type be specified, which is done with the `Type` element.

```xml
<Type>
    Type
</Type>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Object Element](../ide/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|

 A text value is required. This text specifies the type of the object.

## <a name="url"></a> Url Element
 Specifies a URL that provides more information about the referenced assembly.

> [!NOTE]
> The `Url` element is only supported for Visual Basic projects.

```xml
<Url>
    www.microsoft.com
</Url>
```

|Parent Element|Description|
|--------------------|-----------------|
|[Reference Element](../ide/code-snippets-schema-reference.md#reference)|Specifies the assembly references required by the code snippet.|

 A text value is required. This text specifies a URL with more information about the referenced assembly. This URL is displayed when the reference cannot be added to the project.

## See Also
 [Code Snippets](../ide/code-snippets.md)
 [Walkthrough: Creating a Code Snippet](../ide/walkthrough-creating-a-code-snippet.md)
