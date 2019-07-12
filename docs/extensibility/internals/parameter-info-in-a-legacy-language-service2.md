---
title: "Parameter Info in a Legacy Language Service2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "IntelliSense, Parameter Info tool tip"
  - "language services [managed package framework], IntelliSense Parameter Info"
  - "Parameter Info (IntelliSense), supporting in language services [managed package framework]"
ms.assetid: a117365d-320d-4bb5-b61d-3e6457b8f6bc
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Parameter Info in a Legacy Language Service
IntelliSense Parameter Info is a tooltip that displays the signature of a method when the user types the parameter list start character (typically an open parenthesis) for the method parameter list. As each parameter is entered and the parameter separator (typically a comma) is typed, the tooltip is updated to show the next parameter in bold.

 The managed package framework (MPF) classes provide support for managing the Parameter Info tooltip. The parser must detect parameter start, parameter next, and parameter end characters, and it must supply a list of the method signatures and their associated parameters.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor and Language Services](../../extensibility/extending-the-editor-and-language-services.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## Implementation
 The parser should set the trigger value <xref:Microsoft.VisualStudio.Package.TokenTriggers> is set when it finds a parameter list start character (often an open parenthesis). It should set a <xref:Microsoft.VisualStudio.Package.TokenTriggers> trigger when it finds a parameter separator (often a comma). This causes a Parameter Info tooltip to be updated and show the next parameter in bold. The parser should set the trigger value <xref:Microsoft.VisualStudio.Package.TokenTriggers> when if finds the parameter list end character (often a close parenthesis).

 The <xref:Microsoft.VisualStudio.Package.TokenTriggers> trigger value initiates a call to the <xref:Microsoft.VisualStudio.Package.Source.MethodTip%2A> method, which in turn calls the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method parser with a parse reason of <xref:Microsoft.VisualStudio.Package.ParseReason>. If the parser determines that the identifier before the parameter list start character is a recognized method name, it returns a list of matching method signatures in the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object. If any method signatures were found, the Parameter Info tooltip is displayed with the first signature in the list. This tooltip is then updated as more of the signature is typed. When the parameter list end character is typed, the Parameter Info tooltip is removed from view.

> [!NOTE]
> To ensure that the Parameter Info tooltip is properly formatted, you must override the properties on the <xref:Microsoft.VisualStudio.Package.Methods> class to supply the appropriate characters. The base <xref:Microsoft.VisualStudio.Package.Methods> class assumes a C#-style method signature. See the <xref:Microsoft.VisualStudio.Package.Methods> class for details on how this can be done.

## Enabling Support for the Parameter Info
 To support Parameter Info tooltips, you must set the `ShowCompletion` named parameter of the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> to `true`. The language service reads the value of this registry entry from the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCodeSense%2A> property.

 In addition, the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.ParameterInformation%2A> property must be set to `true` for the Parameter Info tooltip to be shown.

### Example
 Here is a simplified example of detecting the parameter list characters and setting the appropriate triggers. This example is for illustrative purposes only. It assumes that your scanner contains a method `GetNextToken` that identifies and returns tokens from a line of text. The example code simply sets the triggers whenever it sees the right kind of character.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestScanner : IScanner
    {
        private Lexer lex;
        private const char parameterListStartChar = '(';
        private const char parameterListEndChar   = ')';
        private const char parameterNextChar      = ',';

        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo,
                                                   ref int state)
        {
            bool foundToken = false
            string token = lex.GetNextToken();
            if (token != null)
            {
                foundToken = true;
                char c = token[0];
                if (Char.IsPunctuation(c))
                {
                    tokenInfo.Type = TokenType.Operator;
                    tokenInfo.Color = TokenColor.Keyword;
                    tokenInfo.EndIndex = index;

                    if (c == parameterListStartChar)
                    {
                        tokenInfo.Trigger |= TokenTriggers.ParameterStart;
                    }
                    else if (c == parameterListNextChar)
                    {
                        tokenInfo.Trigger |= TokenTriggers.ParameterNext;
                    else if (c == parameterListEndChar)
                    {
                        tokenInfo.Trigger |= TokenTriggers.ParameterEnd;
                    }
                }
            return foundToken;
        }
    }
}
```

## Supporting the Parameter Info ToolTip in the Parser
 The <xref:Microsoft.VisualStudio.Package.Source> class makes some assumptions about the contents of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> and <xref:Microsoft.VisualStudio.Package.AuthoringSink> classes when the Parameter Info tooltip is displayed and updated.

- The parser is given <xref:Microsoft.VisualStudio.Package.ParseReason> when the parameter list start character is typed.

- The location given in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object is immediately after the parameter list start character. The parser must collect the signatures of all method declarations available at that position and store them in a list in your version of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object. This list includes the method name, method type (or return type), and a list of possible parameters. This list is later searched for the method signature or signatures to display in the Parameter Info tooltip.

  The parser must then parse the line specified by the <xref:Microsoft.VisualStudio.Package.ParseRequest> object to gather the name of the method being entered as well as how far along the user is in typing parameters. This is accomplished by passing the name of the method to the <xref:Microsoft.VisualStudio.Package.AuthoringSink.StartName%2A> method on the <xref:Microsoft.VisualStudio.Package.AuthoringSink> object and then calling the <xref:Microsoft.VisualStudio.Package.AuthoringSink.StartParameters%2A> method when the parameter list start character is parsed, calling the <xref:Microsoft.VisualStudio.Package.AuthoringSink.NextParameter%2A> method when the parameter list next character is parsed, and finally calling the <xref:Microsoft.VisualStudio.Package.AuthoringSink.EndParameters%2A> method when the parameter list end character is parsed. The results of these method calls are used by the <xref:Microsoft.VisualStudio.Package.Source> class to update the Parameter Info tooltip appropriately.

### Example
 Here is a line of text the user might enter. The numbers below the line indicate which step is taken by the parser at that position in the line (assuming parsing moves left to right). The assumption here is that everything before the line has already been parsed for method signatures, including the "testfunc" method signature.

```
testfunc("a string",3);
     ^^          ^ ^
     12          3 4
```

 The steps that the parser takes are outlined below:

1. The parser calls <xref:Microsoft.VisualStudio.Package.AuthoringSink.StartName%2A> with the text "testfunc".

2. The parser calls <xref:Microsoft.VisualStudio.Package.AuthoringSink.StartParameters%2A>.

3. The parser calls <xref:Microsoft.VisualStudio.Package.AuthoringSink.NextParameter%2A>.

4. The parser calls <xref:Microsoft.VisualStudio.Package.AuthoringSink.EndParameters%2A>.