---
title: Brace Matching in a Legacy Language Service | Microsoft Docs
description: Learn about brace matching in a legacy language service, that helps you track language elements that must occur together, such as parentheses and curly braces.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- brace matching
- language services [managed package framework], brace matching
ms.assetid: 4e3d0a70-f22f-49dd-92d8-edf48ab62b52
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Brace matching in a legacy language service
Brace matching helps the developer track language elements that need to occur together, such as parentheses and curly braces. When a developer enters a closing brace, the opening brace is highlighted.

 You can match two or three co-occurring elements, called pairs and triples. Triples are sets of three co-occurring elements. For example, in C#, the `foreach` statement forms a triple: `foreach()`, `{`, and `}`. All three elements are highlighted when the closing brace is typed.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement brace matching, see [Walkthrough: Display matching braces](../../extensibility/walkthrough-displaying-matching-braces.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

 The <xref:Microsoft.VisualStudio.Package.AuthoringSink> class supports both pairs and triples with the <xref:Microsoft.VisualStudio.Package.AuthoringSink.MatchPair%2A> and <xref:Microsoft.VisualStudio.Package.AuthoringSink.MatchTriple%2A> methods.

## Implementation
 The language service needs to identify all matched elements in the language and then locate all matching pairs. This is typically accomplished by implementing <xref:Microsoft.VisualStudio.Package.IScanner> to detect a matched language and then using the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method to match the elements.

 The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method calls the scanner to tokenize the line and return the token just before the caret. The scanner indicates that a language element pair has been found by setting a token trigger value of <xref:Microsoft.VisualStudio.Package.TokenTriggers> on the current token. The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method calls the <xref:Microsoft.VisualStudio.Package.Source.MatchBraces%2A> method that in turn calls the <xref:Microsoft.VisualStudio.Package.LanguageService.BeginParse%2A> method with the parse reason value of <xref:Microsoft.VisualStudio.Package.ParseReason> to locate the matching language element. When the matching language element is found, both elements are highlighted.

 For a complete description of how typing a brace triggers the brace highlighting, see the *Example parse operation* section in the article [Legacy language service parser and scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md).

## Enable support for brace matching
 The <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> attribute can set the **MatchBraces**, **MatchBracesAtCaret**, and **ShowMatchingBrace** registry entries that set the corresponding properties of the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class. Language preference properties can also be set by the user.

|Registry entry|Property|Description|
|--------------------|--------------|-----------------|
|MatchBraces|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableMatchBraces%2A>|Enables brace matching.|
|MatchBracesAtCaret|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableMatchBracesAtCaret%2A>|Enables brace matching as the caret moves.|
|ShowMatchingBrace|<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableShowMatchingBrace%2A>|Highlights the matching brace.|

## Match conditional statements
 You can match conditional statements, such as `if`, `else if`, and `else`, or `#if`, `#elif`, `#else`, `#endif`, in the same way as matching delimiters. You can subclass the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class and provide a method that can add text spans as well as delimiters to the internal array of matching elements.

## Set the trigger
 The following example shows how to detect matching parentheses, curly braces and square braces, and setting the trigger for it in the scanner. The <xref:Microsoft.VisualStudio.Package.Source.OnCommand%2A> method on the <xref:Microsoft.VisualStudio.Package.Source> class detects the trigger and calls the parser to find the matching pair (see the *Finding the match* section in this article). This example is for illustrative purposes only. It assumes that your scanner contains a method `GetNextToken` that identifies and returns tokens from a line of text.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestScanner : IScanner
    {
        private const string braces = "()[]{}";
        private Lexer lex;

        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo,
                                                   ref int state)
        {
            bool foundToken = false;
            string token = lex.GetNextToken();
            if (token != null)
            {
                foundToken = true;
                char firstChar = token[0];
                if (Char.IsPunctuation(firstChar) && token.Length > 0)
                {
                    if (braces.IndexOf(firstChar) != -1)
                    {
                        tokenInfo.Trigger = TokenTriggers.MatchBraces;
                    }
                }
            }
            return foundToken;
        }
```

## Match the braces
 Here is a simplified example for matching the language elements `{ }`, `( )`, and `[ ]`, and adding their spans to the <xref:Microsoft.VisualStudio.Package.AuthoringSink> object. This approach is not a recommended approach to parsing source code; it is for illustrative purposes only.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class Parser
    {
         private IList<TextSpan[]> m_braces;
         public IList<TextSpan[]> Braces
         {
             get { return m_braces; }
         }
         private void AddMatchingBraces(TextSpan braceSpan1, TextSpan braceSpan2)
         {
             if IsMatch(braceSpan1, braceSpan2)
                 m_braces.Add(new TextSpan[] { braceSpan1, braceSpan2 });
         }

         private bool IsMatch(TextSpan braceSpan1, TextSpan braceSpan2)
         {
             //definition for matching here
          }
    }

    public class TestLanguageService : LanguageService
    {
         Parser parser = new Parser();
         Source source = (Source) this.GetSource(req.FileName);

         private AuthoringScope ParseSource(ParseRequest req)
         {
             if (req.Sink.BraceMatching)
             {
                 if (req.Reason==ParseReason.MatchBraces)
                 {
                     foreach (TextSpan[] brace in parser.Braces)
                     {
                         req.Sink.MatchPair(brace[0], brace[1], 1);
                     }
                 }
             }
             return new TestAuthoringScope();
         }
    }
}
```

## See also
- [Legacy language service features](../../extensibility/internals/legacy-language-service-features1.md)
- [Legacy language service parser and scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)
