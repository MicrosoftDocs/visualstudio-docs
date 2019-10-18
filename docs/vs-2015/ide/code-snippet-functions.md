---
title: "Code Snippet Functions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords: 
  - "code snippets [Visual Studio], functions"
  - "snippets [Visual Studio], functions"
  - "IntelliSense code snippets, functions"
ms.assetid: c0a2bf21-8fa5-4457-9281-f599beb53e7d
caps.latest.revision: 15
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Code Snippet Functions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

There are three functions available to use with [!INCLUDE[csprcs](../includes/csprcs-md.md)] code snippets. Functions are specified in the [Function](https://msdn.microsoft.com/572c5549-5821-4e15-8ecd-0fa86c1c65df) element of the code snippet. For information on creating code snippets, see [Code Snippets](../ide/code-snippets.md).  
  
## Functions  
 The following table describes the functions available for use with the `Function` element in code snippets.  
  
|Function|Description|Language|  
|--------------|-----------------|--------------|  
|`GenerateSwitchCases(` `EnumerationLiteral` `)`|Generates a switch statement and a set of case statements for the members of the enumeration specified by the `EnumerationLiteral` parameter. The `EnumerationLiteral` parameter must be either a reference to an enumeration literal or an enumeration type.|[!INCLUDE[csprcs](../includes/csprcs-md.md)]|  
|`ClassName()`|Returns the name of the class that contains the inserted snippet.|[!INCLUDE[csprcs](../includes/csprcs-md.md)]|  
|`SimpleTypeName(` `TypeName` `)`|Reduces the *TypeName* parameter to its simplest form in the context in which the snippet was invoked.|[!INCLUDE[csprcs](../includes/csprcs-md.md)]|  
  
## Example  
 The following example shows how to use the `GenerateSwitchCases` function. When this snippet is inserted and an enumeration is entered into the `$switch_on$` literal, the `$cases$` literal generates a `case` statement for every value in the enumeration.  
  
```  
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
  
## Example  
 The following example shows how to use the `ClassName` function. When this snippet is inserted, the `$classname$` literal is replaced with the name of the enclosing class at that location in the code file.  
  
```  
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
            <Code Language="vjsharp" Format="CData">  
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
  
## Example  
 This example shows how to use the `SimpleTypeName` function. When this snippet is inserted into a code file, the `$SystemConsole$` literal will be replaced with the simplest form of the <xref:System.Console> type in the context in which the snippet was invoked.  
  
```  
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
 [Function Element (Intellisense Code Snippets)](https://msdn.microsoft.com/572c5549-5821-4e15-8ecd-0fa86c1c65df)   
 [Code Snippets Schema Reference](../ide/code-snippets-schema-reference.md)
