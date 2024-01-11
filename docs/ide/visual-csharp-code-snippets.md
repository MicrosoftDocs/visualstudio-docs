---
title: C# code snippets
description: Learn how to use code snippets to add commonly-used code to your C# code files.
ms.date: 06/05/2017
ms.topic: reference
helpviewer_keywords:
- snippets [C#]
- code snippets [C#]
- Code Snippet Inserter [C#]
- C#, code snippets
author: Mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: general-ide
---
# C# code snippets

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Code snippets are ready-made snippets of code you can quickly insert into your code. For example, the `for` code snippet creates an empty `for` loop. Some code snippets are surround-with code snippets, which enable you to select lines of code, and then choose a code snippet which incorporates the selected lines of code. For example, when you select lines of code and then activate the `for` code snippet, it creates a `for` loop with those lines of code inside the loop block. Code snippets can make writing program code quicker, easier, and more reliable.

You can insert a code snippet at the cursor location, or insert a surround-with code snippet around the currently selected code. The Code Snippet Inserter is invoked through the **Insert Code Snippet** or **Surround With** commands on the **IntelliSense** menu, or by using the keyboard shortcuts **Ctrl**+**K**,**X** or **Ctrl**+**K**,**S** respectively.

The **Code Snippet Inserter** displays the code snippet name for all available code snippets. The Code Snippet Inserter also includes an input dialog box where you can type the name of the code snippet, or part of the code snippet name. The Code Snippet Inserter highlights the closest match to a code snippet name. Pressing **Tab** at any time will dismiss the Code Snippet Inserter and insert the currently selected code snippet. Pressing **Esc** or clicking the mouse in the code editor will dismiss the Code Snippet Inserter without inserting a code snippet.

## Default code snippets

By default the following code snippets are included in Visual Studio for C#.

|Name (or shortcut)|Description|Valid locations to insert snippet|
| - |-----------------| - |
|#if|Creates a [#if](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if) directive and a [#endif](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-endif) directive.|Anywhere.|
|#region|Creates a [#region](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region) directive and a [#endregion](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-endregion) directive.|Anywhere.|
|~|Creates a [finalizer](/dotnet/csharp/programming-guide/classes-and-structs/destructors) (destructor) for the containing class.|Inside a class.|
|attribute|Creates a declaration for a class that derives from <xref:System.Attribute>.|Inside a namespace (including the global namespace), a class, or a struct.|
|checked|Creates a [checked](/dotnet/csharp/language-reference/keywords/checked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|class|Creates a class declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|ctor|Creates a constructor for the containing class.|Inside a class.|
|cw|Creates a call to <xref:System.Console.WriteLine%2A>.|Inside a method, an indexer, a property accessor, or an event accessor.|
|do|Creates a [do](/dotnet/csharp/language-reference/keywords/do) `while` loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|else|Creates an [else](/dotnet/csharp/language-reference/keywords/if-else) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|enum|Creates an [enum](/dotnet/csharp/language-reference/keywords/enum) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|equals|Creates a method declaration that overrides the <xref:System.Object.Equals%2A> method defined in the <xref:System.Object> class.|Inside a class or a struct.|
|exception|Creates a declaration for a class that derives from an exception (<xref:System.Exception> by default).|Inside a namespace (including the global namespace), a class, or a struct.|
|for|Creates a [for](/dotnet/csharp/language-reference/keywords/for) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|foreach|Creates a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|
|forr|Creates a [for](/dotnet/csharp/language-reference/keywords/for) loop that decrements the loop variable after each iteration.|Inside a method, an indexer, a property accessor, or an event accessor.|
|if|Creates an [if](/dotnet/csharp/language-reference/keywords/if-else) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|indexer|Creates an indexer declaration.|Inside a class or a struct.|
|interface|Creates an [interface](/dotnet/csharp/language-reference/keywords/interface) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|invoke|Creates a block that safely invokes an event.|Inside a method, an indexer, a property accessor, or an event accessor.|
|iterator|Creates an iterator.|Inside a class or a struct.|
|iterindex|Creates a "named" iterator and indexer pair by using a nested class.|Inside a class or a struct.|
|lock|Creates a [lock](/dotnet/csharp/language-reference/keywords/lock-statement) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|mbox|Creates a call to <xref:System.Windows.Forms.MessageBox.Show%2A?displayProperty=fullName>. You may have to add a reference to *System.Windows.Forms.dll*.|Inside a method, an indexer, a property accessor, or an event accessor.|
|namespace|Creates a [namespace](/dotnet/csharp/language-reference/keywords/namespace) declaration.|Inside a namespace (including the global namespace).|
|prop|Creates an [auto-implemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) declaration.|Inside a class or a struct.|
|propfull|Creates a property declaration with `get` and `set` accessors.|Inside a class or a struct.|
|propg|Creates a read-only [auto-implemented property](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties) with a private `set` accessor.|Inside a class or a struct.|
|sim|Creates a [static](/dotnet/csharp/language-reference/keywords/static) [int](/dotnet/csharp/language-reference/keywords/int) Main method declaration.|Inside a class or a struct.|
|struct|Creates a [struct](/dotnet/csharp/language-reference/keywords/struct) declaration.|Inside a namespace (including the global namespace), a class, or a struct.|
|svm|Creates a [static](/dotnet/csharp/language-reference/keywords/static) [void](/dotnet/csharp/language-reference/keywords/void) Main method declaration.|Inside a class or a struct.|
|switch|Creates a [switch](/dotnet/csharp/language-reference/keywords/switch) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|try|Creates a [try-catch](/dotnet/csharp/language-reference/keywords/try-catch) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|tryf|Creates a [try-finally](/dotnet/csharp/language-reference/keywords/try-finally) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unchecked|Creates an [unchecked](/dotnet/csharp/language-reference/keywords/unchecked) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|unsafe|Creates an [unsafe](/dotnet/csharp/language-reference/keywords/unsafe) block.|Inside a method, an indexer, a property accessor, or an event accessor.|
|using|Creates a [using](/dotnet/csharp/language-reference/keywords/using-directive) directive.|Inside a namespace (including the global namespace).|
|while|Creates a [while](/dotnet/csharp/language-reference/keywords/while) loop.|Inside a method, an indexer, a property accessor, or an event accessor.|

## Code snippet functions

There are three functions available to use with C# code snippets. Functions are specified in the [Function](../ide/code-snippets-schema-reference.md#function-element) element of the code snippet. For information on creating code snippets, see [Code snippets](../ide/code-snippets.md).

The following table describes the functions available for use with the `Function` element in code snippets.

|Function|Description|Language|
|--------------|-----------------|--------------|
|`GenerateSwitchCases(EnumerationLiteral)`|Generates a switch statement and a set of case statements for the members of the enumeration specified by the `EnumerationLiteral` parameter. The `EnumerationLiteral` parameter must be either a reference to an enumeration literal or an enumeration type.|C#|
|`ClassName()`|Returns the name of the class that contains the inserted snippet.|C#|
|`SimpleTypeName(TypeName)`|Reduces the *TypeName* parameter to its simplest form in the context in which the snippet was invoked.|C#|

### GenerateSwitchCases example

The following example shows how to use the `GenerateSwitchCases` function. When this snippet is inserted and an enumeration is entered into the `$switch_on$` literal, the `$cases$` literal generates a `case` statement for every value in the enumeration.

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

The following example shows how to use the `ClassName` function. When this snippet is inserted, the `$classname$` literal is replaced with the name of the enclosing class at that location in the code file.

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

This example shows how to use the `SimpleTypeName` function. When this snippet is inserted into a code file, the `$SystemConsole$` literal will be replaced with the simplest form of the <xref:System.Console> type in the context in which the snippet was invoked.

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

## See also

- [Code snippets](../ide/code-snippets.md)
- [Template parameters](../ide/template-parameters.md)
- [Expansion snippets and surround-with snippets](../ide/code-snippets.md#expansion-snippets-and-surround-with-snippets)
