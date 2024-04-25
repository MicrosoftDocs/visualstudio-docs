---
title: C# code snippets
description: Learn how to use code snippets to add commonly used code to your C# code files.
ms.date: 04/05/2024
ms.topic: reference
helpviewer_keywords:
- snippets [C#]
- code snippets [C#]
- Code Snippet Inserter [C#]
- C#, code snippets
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# C# code snippets

In Visual Studio, you can use code snippets to add commonly used code to your C# code files. Code snippets can make writing program code quicker, easier, and more reliable.

*Expansion* code snippets are added at specified insertion points. *Surround-with* code snippets are added around selected code, and are available for C# and C++ only. For instructions on how to insert or surround code with code snippets, see [Code snippets](code-snippets.md).

## Code snippet reference

Code snippets work much the same way in C# and C++, but the set of default code snippets is different. The following C# code snippets are included in Visual Studio by default:

|Name or shortcut|Description|Valid insertion locations|
| - |-----------------| - |
|#if|Creates an [#if](/dotnet/csharp/language-reference/preprocessor-directives#conditional-compilation) directive and an [#endif](/dotnet/csharp/language-reference/preprocessor-directives#conditional-compilation) directive.|Anywhere.|
|#region|Creates a [#region](/dotnet/csharp/language-reference/preprocessor-directives#defining-regions) directive and an [#endregion](/dotnet/csharp/language-reference/preprocessor-directives#defining-regions) directive.|Anywhere.|
|~|Creates a [finalizer](/dotnet/csharp/programming-guide/classes-and-structs/finalizers) (destructor) for the containing class.|Inside a class.|
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute>.|Inside a namespace (including the global namespace), a class, or a struct.|
|checked|Creates a [checked](/dotnet/csharp/language-reference/statements/checked-and-unchecked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|ctor|Creates a constructor for the containing class.|Inside a class.|
|cw|Creates a call to <xref:System.Console.WriteLine%2A>.|Inside a method, an indexer, a property accessor, or an event accessor.|
|do|Creates a [do](/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement) [while](/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|else|Creates an [if-else](/dotnet/csharp/language-reference/statements/selection-statements) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|enum|Creates an [enum](/dotnet/csharp/language-reference/builtin-types/enum) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals%2A> method defined in the <xref:System.Object> class.|Inside a class or a struct.|
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception> by default).|Inside a namespace (including the global namespace), a class, or a struct.|
|for|Creates a [for](/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|foreach|Creates a [foreach](/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|forr|Creates a [for](/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|
|if|Creates an [if](/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|indexer|Creates an indexer declaration.|Inside a class or a struct.|
|interface|Creates an [interface](/dotnet/csharp/language-reference/keywords/interface) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|
|iterator|Creates an iterator.|Inside a class or a struct.|
|iterindex|Creates a `named` iterator and indexer pair by using a nested class.|Inside a class or a struct.|
|lock|Creates a [lock](/dotnet/csharp/language-reference/statements/lock) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show%2A?displayProperty=fullName>. You might have to add a reference to *System.Windows.Forms.dll*.|Inside a method, an indexer, a property accessor, or an event accessor.|
|namespace|Creates a [namespace](/dotnet/csharp/language-reference/keywords/namespace) declaration.|Inside a namespace, including the global namespace.|
|prop|Creates an [autoimplemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) declaration.|Inside a class or a struct.|
|propfull|Creates a property declaration with `get` and `set` accessors.|Inside a class or a struct.|
|propg|Creates a read-only [autoimplemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) with a private `set` accessor.|Inside a class or a struct.|
|sim|Creates a [static](/dotnet/csharp/language-reference/keywords/static) [int](/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) Main method declaration.|Inside a class or a struct.|
|struct|Creates a [struct](/dotnet/csharp/language-reference/builtin-types/struct) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|svm|Creates a [static](/dotnet/csharp/language-reference/keywords/static) [void](/dotnet/csharp/language-reference/builtin-types/void) Main method declaration.|Inside a class or a struct.|
|switch|Creates a [switch](/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|try|Creates a [try-catch](/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-catch-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|tryf|Creates a [try-finally](/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-finally-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unchecked|Creates an [unchecked](/dotnet/csharp/language-reference/statements/checked-and-unchecked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unsafe|Creates an [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|using|Creates a [using](/dotnet/csharp/language-reference/keywords/using-directive) directive.|Inside a namespace, including the global namespace.|
|while|Creates a [while](/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|

## C# code snippet functions

Functions are specified in the [Function](code-snippets-schema-reference.md#function-element) element of the code snippet. The following table describes the three functions available to use with the `Function` element in C# code snippets.

|Function|Description|
|--------------|-----------------|
|`GenerateSwitchCases(EnumerationLiteral)`|Generates a switch statement and a set of case statements for the members of the enumeration specified by the `EnumerationLiteral` parameter. The `EnumerationLiteral` parameter must be a reference either to an enumeration literal or an enumeration type.|
|`ClassName()`|Returns the name of the class that contains the inserted snippet.|
|`SimpleTypeName(TypeName)`|Reduces the `TypeName` parameter to its simplest form in the context in which the snippet was invoked.|

### GenerateSwitchCases example

The following example shows how to use the `GenerateSwitchCases` function. When you insert this snippet and enter an enumeration into the `$switch_on$` literal, the `$cases$` literal generates a `case` statement for every value in the enumeration.

```xml
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
    <CodeSnippet Format="1.0.0">
        <Header>
            <Title>switch</Title>
            <Shortcut>switch</Shortcut>
            <Description>Code snippet for switch statement</Description>
            <Author>Microsoft Corporation</Author>
            <SnippetTypes>
                <SnippetType>Expansion</SnippetType>
            </SnippetTypes>
        </Header>
        <Snippet>
            <Declarations>
                <Literal>
                    <ID>expression</ID>
                    <ToolTip>Expression to switch on</ToolTip>
                    <Default>switch_on</Default>
                </Literal>
                <Literal Editable="false">
                    <ID>cases</ID>
                    <Function>GenerateSwitchCases($expression$)</Function>
                    <Default>default:</Default>
                </Literal>
            </Declarations>
            <Code Language="csharp">
                <![CDATA[
                    switch ($expression$)
                    {
                        $cases$
                    }
                ]]>
            </Code>
        </Snippet>
    </CodeSnippet>
</CodeSnippets>
```

### ClassName example

The following example shows how to use the `ClassName` function. When you insert this snippet, the `$classname$` literal is replaced with the name of the enclosing class at that location in the code file.

```xml
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
    <CodeSnippet Format="1.0.0">
        <Header>
            <Title>Common constructor pattern</Title>
            <Shortcut>ctor</Shortcut>
            <Description>Code Snippet for a constructor</Description>
            <Author>Microsoft Corporation</Author>
            <SnippetTypes>
                <SnippetType>Expansion</SnippetType>
            </SnippetTypes>
        </Header>
        <Snippet>
            <Declarations>
                <Literal>
                    <ID>type</ID>
                    <Default>int</Default>
                </Literal>
                <Literal>
                    <ID>name</ID>
                    <Default>field</Default>
                </Literal>
                <Literal default="true" Editable="false">
                    <ID>classname</ID>
                    <ToolTip>Class name</ToolTip>
                    <Function>ClassName()</Function>
                    <Default>ClassNamePlaceholder</Default>
                </Literal>
            </Declarations>
            <Code Language="csharp" Format="CData">
                <![CDATA[
                    public $classname$ ($type$ $name$)
                    {
                        this._$name$ = $name$;
                    }
                    private $type$ _$name$;
                ]]>
            </Code>
        </Snippet>
    </CodeSnippet>
</CodeSnippets>
```

### SimpleTypeName example

This example shows how to use the `SimpleTypeName` function. When you insert this snippet into a code file, the `$SystemConsole$` literal is replaced with the simplest form of the <xref:System.Console> type in the context in which you invoked the snippet.

```xml
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
    <CodeSnippet Format="1.0.0">
        <Header>
            <Title>Console_WriteLine</Title>
            <Shortcut>cw</Shortcut>
            <Description>Code snippet for Console.WriteLine</Description>
            <Author>Microsoft Corporation</Author>
            <SnippetTypes>
                <SnippetType>Expansion</SnippetType>
            </SnippetTypes>
        </Header>
        <Snippet>
            <Declarations>
                <Literal Editable="false">
                    <ID>SystemConsole</ID>
                    <Function>SimpleTypeName(global::System.Console)</Function>
                </Literal>
            </Declarations>
            <Code Language="csharp">
                <![CDATA[
                    $SystemConsole$.WriteLine();
                ]]>
            </Code>
        </Snippet>
    </CodeSnippet>
</CodeSnippets>
```

## Related content

- [Code snippets](code-snippets.md)
- [Code snippets schema reference](code-snippets-schema-reference.md)
- [Template parameters](template-parameters.md)
- [Walkthrough: Create a code snippet in Visual Studio](walkthrough-creating-a-code-snippet.md)

