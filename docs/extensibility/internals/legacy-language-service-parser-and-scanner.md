---
title: Legacy Language Service Parser and Scanner | Microsoft Docs
description: Learn about the legacy language service parser and scanner that select information about the code being displayed.
ms.custom: SEO-VS-2020 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- parsers, language services [managed package framework]
- language services [managed package framework], Parsers
ms.assetid: 1ac3de27-a23b-438d-9593-389e45839cfa
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Legacy Language Service Parser and Scanner
The parser is the heart of the language service. The Managed Package Framework (MPF) language classes require a language parser to select information about the code being displayed. A parser separates the text into lexical tokens and then identifies those tokens by type and functionality.

## Discussion
 The following is a C# method.

```csharp
namespace MyNamespace
{
    class MyClass
    {
        public void MyFunction(int arg1)
        {
            int var1 = arg1;
        }
    }
}
```

 In this example, the tokens are the words and punctuation marks. The kinds of tokens are as follows.

|Token Name|Token Type|
|----------------|----------------|
|namespace, class, public, void, int|keyword|
|=|operator|
|{ } ( ) ;|delimiter|
|MyNamespace, MyClass, MyFunction, arg1, var1|identifier|
|MyNamespace|namespace|
|MyClass|class|
|MyFunction|method|
|arg1|parameter|
|var1|local variable|

 The role of the parser is to identify the tokens. Some tokens can have more than one type. After the parser has identified the tokens, the language service can use the information to provide helpful features, such as syntax highlighting, brace matching, and the IntelliSense operations.

## Types of Parsers
 A language service parser is not the same as a parser used as part of a compiler. However, this kind of parser needs to use both a scanner and a parser, in the same way as a compiler parser.

- A scanner is used to identify types of tokens. This information is used for syntax highlighting and for quickly identifying token types that can trigger other operations, for example, brace matching. This scanner is represented by the <xref:Microsoft.VisualStudio.Package.IScanner> interface.

- A parser is used to describe the functions and scope of the tokens. This information is used in IntelliSense operations to identify language elements, such as methods, variables, parameters, and declarations, and to provide lists of members and method signatures based on context. This parser is also used to locate matching language element pairs, such as braces and parentheses. This parser is accessed through the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class.

  How you implement a scanner and parser for your language service is up to you. Several resources are available that describe how parsers work and how to write your own parser. Also, several free and commercial products are available that help in creating a parser.

### The ParseSource Parser
 Unlike a parser that is used as part of a compiler (where the tokens are converted to some form of executable code), a language service parser can be called for many different reasons and in many different contexts. How you implement this approach in the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class is up to you. It is important to keep in mind that the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method might be called on a background thread.

> [!CAUTION]
> The <xref:Microsoft.VisualStudio.Package.ParseRequest> structure contains a reference to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> object. This <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> object cannot be used in the background thread. In fact, many of the base MPF classes cannot be used in the background thread. These include the <xref:Microsoft.VisualStudio.Package.Source>, <xref:Microsoft.VisualStudio.Package.ViewFilter>, <xref:Microsoft.VisualStudio.Package.CodeWindowManager> classes, and any other class that directly or indirectly communicates with the view.

 This parser typically parses the whole source file the first time it is called or when the parse reason value of <xref:Microsoft.VisualStudio.Package.ParseReason> is given. Subsequent calls to the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method handle a small part of the parsed code and can be executed much more quickly by using the results of the previous full parse operation. The <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method communicates the results of the parsing operation through the <xref:Microsoft.VisualStudio.Package.AuthoringSink> and <xref:Microsoft.VisualStudio.Package.AuthoringScope> objects. The <xref:Microsoft.VisualStudio.Package.AuthoringSink> object is used to collect information for a specific parsing reason, for example, information about the spans of matching braces or method signatures that have parameter lists. The <xref:Microsoft.VisualStudio.Package.AuthoringScope> provides collections of declarations and method signatures and also support for the Go To advanced edit option (**Go to Definition**, **Go to Declaration**, **Go to Reference**).

### The IScanner Scanner
 You must also implement a scanner that implements <xref:Microsoft.VisualStudio.Package.IScanner>. However, because this scanner operates on a line-by-line basis through the <xref:Microsoft.VisualStudio.Package.Colorizer> class, it is typically easier to implement. At the beginning of each line, the MPF gives the <xref:Microsoft.VisualStudio.Package.Colorizer> class a value to use as a state variable that is passed to the scanner. At the end of each line, the scanner returns the updated state variable. The MPF caches this state information for each line so that the scanner can start parsing from any line without having to start at the beginning of the source file. This fast scanning of a single line allows the editor to provide fast feedback to the user.

## Parsing for Matching Braces
 This example shows the flow of control for matching a closing brace that the user has typed. In this process, the scanner that is used for colorization is also used to determine the type of token and whether the token can trigger a match-brace operation. If the trigger is found, the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method is called to find the matching brace. Finally, the two braces are highlighted.

 Even though braces are used in the names of triggers and parse reasons, this process is not limited to actual braces. Any pair of characters that is specified to be a matching pair is supported. Examples include ( and ), \< and >, and [ and ].

 Assume that the language service supports matching braces.

1. The user types a closing curly brace (}).

2. The curly brace is inserted at the cursor in the source file and the cursor is advanced by one.

3. The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method in the <xref:Microsoft.VisualStudio.Package.Source> class is called with the typed closing brace.

4. The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method calls the <xref:Microsoft.VisualStudio.Package.Source.GetTokenInfo%2A> method in the <xref:Microsoft.VisualStudio.Package.Source> class to obtain the token at the position just before the current cursor position. This token corresponds to the typed closing brace).

    1. The <xref:Microsoft.VisualStudio.Package.Source.GetTokenInfo%2A> method calls the <xref:Microsoft.VisualStudio.Package.Colorizer.GetLineInfo%2A> method on the <xref:Microsoft.VisualStudio.Package.Colorizer> object to obtain all tokens on the current line.

    2. The <xref:Microsoft.VisualStudio.Package.Colorizer.GetLineInfo%2A> method calls the <xref:Microsoft.VisualStudio.Package.IScanner.SetSource%2A> method on the <xref:Microsoft.VisualStudio.Package.IScanner> object with the text of the current line.

    3. The <xref:Microsoft.VisualStudio.Package.Colorizer.GetLineInfo%2A> method repeatedly calls the <xref:Microsoft.VisualStudio.Package.IScanner.ScanTokenAndProvideInfoAboutIt%2A> method on the <xref:Microsoft.VisualStudio.Package.IScanner> object to gather all tokens from the current line.

    4. The <xref:Microsoft.VisualStudio.Package.Source.GetTokenInfo%2A> method calls a private method in the <xref:Microsoft.VisualStudio.Package.Source> class to obtain the token that contains the desired position, and passes in the list of tokens obtained from the <xref:Microsoft.VisualStudio.Package.Colorizer.GetLineInfo%2A> method.

5. The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method looks for a token trigger flag of <xref:Microsoft.VisualStudio.Package.TokenTriggers> on the token that is returned from the <xref:Microsoft.VisualStudio.Package.Source.GetTokenInfo%2A> method; that is, the token that represents the closing brace).

6. If the trigger flag of <xref:Microsoft.VisualStudio.Package.TokenTriggers> is found, the <xref:Microsoft.VisualStudio.Package.Source.MatchBraces%2A> method in the <xref:Microsoft.VisualStudio.Package.Source> class is called.

7. The <xref:Microsoft.VisualStudio.Package.Source.MatchBraces%2A> method starts a parsing operation with the parse reason value of <xref:Microsoft.VisualStudio.Package.ParseReason>. This operation ultimately calls the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method on the <xref:Microsoft.VisualStudio.Package.LanguageService> class. If asynchronous parsing is enabled, this call to the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method occurs on a background thread.

8. When the parsing operation is finished, an internal completion handler (also known as a callback method) named `HandleMatchBracesResponse` is called in the <xref:Microsoft.VisualStudio.Package.Source> class. This call is made automatically by the <xref:Microsoft.VisualStudio.Package.LanguageService> base class, not by the parser.

9. The `HandleMatchBracesResponse` method obtains a list of spans from the <xref:Microsoft.VisualStudio.Package.AuthoringSink> object that is stored in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object. (A span is a <xref:Microsoft.VisualStudio.TextManager.Interop.TextSpan> structure that specifies a range of lines and characters in the source file.) This list of spans typically contains two spans, one each for the opening and closing braces.

10. The `HandleBracesResponse` method calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.HighlightMatchingBrace%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> object that is stored in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object. This highlights the given spans.

11. If the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> property <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableShowMatchingBrace%2A> is enabled, the `HandleBracesResponse` method obtains the text that is encompassed by the matching span and displays the first 80 characters of that span in the status bar. This works best if the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method includes the language element that accompanies the matching pair. For more information, see the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableShowMatchingBrace%2A> property.

12. Done.

### Summary
 The matching braces operation is typically limited to simple pairs of language elements. More complex elements, such as matching triples ("`if(...)`", "`{`" and "`}`", or "`else`", "`{`" and "`}`"), can be highlighted as part of a word-completion operation. For example, when the "else" word is finished, the matching "`if`" statement can be highlighted. If there were a series of `if`/`else if` statements, all of them could be highlighted by using the same mechanism as matching braces. The <xref:Microsoft.VisualStudio.Package.Source> base class already supports this, as follows: The scanner must return the token trigger value <xref:Microsoft.VisualStudio.Package.TokenTriggers> combined with the trigger value <xref:Microsoft.VisualStudio.Package.TokenTriggers> for the token that is before the cursor position.

 For more information, see [Brace Matching in a Legacy Language Service](../../extensibility/internals/brace-matching-in-a-legacy-language-service.md).

## Parsing for Colorization
 Colorizing source code is straightforward, just identify the type of token and return color information about that type. The <xref:Microsoft.VisualStudio.Package.Colorizer> class acts as the intermediary between the editor and the scanner to provide color information about every token. The <xref:Microsoft.VisualStudio.Package.Colorizer> class uses the <xref:Microsoft.VisualStudio.Package.IScanner> object to help in colorizing a line and also to gather state information for all lines in the source file. In the MPF language service classes, the <xref:Microsoft.VisualStudio.Package.Colorizer> class does not have to be overridden because it communicates with the scanner only through the <xref:Microsoft.VisualStudio.Package.IScanner> interface. You supply the object that implements the <xref:Microsoft.VisualStudio.Package.IScanner> interface by overriding the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method on the <xref:Microsoft.VisualStudio.Package.LanguageService> class.

 The <xref:Microsoft.VisualStudio.Package.IScanner> scanner is given a line of source code through the <xref:Microsoft.VisualStudio.Package.IScanner.SetSource%2A> method. Calls to the <xref:Microsoft.VisualStudio.Package.IScanner.ScanTokenAndProvideInfoAboutIt%2A> method are repeated to obtain the next token in the line until the line is exhausted of tokens. For colorization, the MPF treats all source code as a sequence of lines. Therefore, the scanner must be able to cope with source coming at it as lines. In addition, any line can be passed to the scanner at any time, and the only guarantee is that the scanner receives the state variable from the line before the line about to be scanned.

 The <xref:Microsoft.VisualStudio.Package.Colorizer> class is also used to identify token triggers. These triggers tell the MPF that a particular token can initiate a more complex operation, such as word completion or matching braces. Because identifying such triggers must be fast and must occur at any location, the scanner is best suited for this task.

 For more information, see [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md).

## Parsing for Functionality and Scope
 Parsing for functionality and scope requires more effort than just identifying the types of tokens that are encountered. The parser has to identify not only the type of token, but also the functionality for which the token is used. For example, an identifier is just a name, but in your language, an identifier could be the name of a class, namespace, method, or variable, depending on the context. The general type of the token may be an identifier, but the identifier may also have other meanings, depending on what it is and where it is defined. This identification requires the parser to have more extensive knowledge about the language that is being parsed. This is where the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class comes in. The <xref:Microsoft.VisualStudio.Package.AuthoringSink> class collects information about identifiers, methods, matching language pairs (such as braces and parentheses), and language triples (similar to language pairs except that there are three parts, for example, "`foreach()`" "`{`" and "`}`"). In addition, you can override the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class to support code identification, which is used in early validation of breakpoints so that the debugger does not have to be loaded, and the **Autos** debugging window, which shows local variables and parameters automatically when a program is being debugged and requires the parser to identify appropriate local variables and parameters in addition to those that the debugger presents.

 The <xref:Microsoft.VisualStudio.Package.AuthoringSink> object is passed to the parser as part of the <xref:Microsoft.VisualStudio.Package.ParseRequest> object, and a new <xref:Microsoft.VisualStudio.Package.AuthoringSink> object is created every time that a new <xref:Microsoft.VisualStudio.Package.ParseRequest> object is created. In addition, the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method must return an <xref:Microsoft.VisualStudio.Package.AuthoringScope> object, which is used to handle various IntelliSense operations. The <xref:Microsoft.VisualStudio.Package.AuthoringScope> object maintains a list for declarations and a list for methods, either of which is populated, depending on the reason for parsing. The <xref:Microsoft.VisualStudio.Package.AuthoringScope> class must be implemented.

## See also
- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service1.md)
- [Legacy Language Service Overview](../../extensibility/internals/legacy-language-service-overview.md)
- [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md)
- [Brace Matching in a Legacy Language Service](../../extensibility/internals/brace-matching-in-a-legacy-language-service.md)
