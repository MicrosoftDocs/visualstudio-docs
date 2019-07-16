---
title: "Member Completion in a Legacy Language Service | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "IntelliSense, Member Completion tool tip"
  - "Member Completion, supporting in language services [managed package framework]"
  - "language services [managed package framework], IntelliSense Member Completion"
ms.assetid: 500f718d-9028-49a4-8615-ba95cf47fc52
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Member Completion in a Legacy Language Service

The IntelliSense Member Completion is a tool tip that displays a list of possible members of a particular scope such as a class, structure, enumeration, or namespace. For example, in C#, if the user types "this" followed by a period, a list of all members of the class or structure at the current scope is presented in a list from which the user can select.

The managed package framework (MPF) provides support for the tool tip and managing the list in the tool tip; all that is needed is cooperation from the parser to supply the data that appears in the list.

Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor and Language Services](../../extensibility/extending-the-editor-and-language-services.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## How It Works

The following are the two ways in which a member list is shown using the MPF classes:

- Positioning the caret on an identifier or after a member completion character and selecting **List Members** from the **IntelliSense** menu.

- The <xref:Microsoft.VisualStudio.Package.IScanner> scanner detects a member completion character and sets a token trigger of [TokenTriggers.MemberSelect](<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect>) for that character.

A member completion character indicates that a member of a class, structure, or enumeration is to follow. For example, in C# or Visual Basic the member completion character is a `.`, while  in C++ the character is either a `.` or a `->`. The trigger value is set when the member select character is scanned.

### The IntelliSense Member List Command

The <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> command initiates a call to the <xref:Microsoft.VisualStudio.Package.Source.Completion%2A> method on the <xref:Microsoft.VisualStudio.Package.Source> class and the <xref:Microsoft.VisualStudio.Package.Source.Completion%2A> method, in turn, calls the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method parser with the parse reason of [ParseReason.DisplayMemberList](<xref:Microsoft.VisualStudio.Package.ParseReason.DisplayMemberList>).

The parser determines the context of the current position as well as the token under or immediately before the current position. Based on this token, a list of declarations is presented. For example, in C#, if you position the caret on a class member and select **List Members**, you get a list of all members of the class. If you position the caret after a period that follows an object variable, you get a list of all members of the class that object represents. Note that if the caret is positioned on a member when the member list is shown, selecting a member from the list replaces the member the caret is on with the one in the list.

### The Token Trigger

The [TokenTriggers.MemberSelect](<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect>) trigger initiates a call to the <xref:Microsoft.VisualStudio.Package.Source.Completion%2A> method on the <xref:Microsoft.VisualStudio.Package.Source> class and the <xref:Microsoft.VisualStudio.Package.Source.Completion%2A> method, in turn, calls the parser with the parse reason of [ParseReason.MemberSelect](<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelect>). If the token trigger also included the [TokenTriggers.MatchBraces](<xref:Microsoft.VisualStudio.Package.TokenTriggers.MatchBraces>) flag, the parse reason is [ParseReason.MemberSelectAndHighlightBraces](<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelectAndHighlightBraces>), which combines member selection and brace highlighting.

The parser determines the context of the current position as well as what has been typed before the member select character. From this information, the parser creates a list of all members of the requested scope. This list of declarations is stored in the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object that is returned from the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method. If any declarations are returned, the member completion tool tip is displayed. The tool tip is managed by an instance of the <xref:Microsoft.VisualStudio.Package.CompletionSet> class.

## Enable Support for Member Completion

You must have the `CodeSense` registry entry set to 1 to support any IntelliSense operation. This registry entry can be set with a named parameter passed to the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> user attribute associated with the language package. The language service classes read the value of this registry entry from the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCodeSense%2A> property on the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class.

If your scanner returns the token trigger of [TokenTriggers.MemberSelect](<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect>), and your parser returns a list of declarations, then the member completion list is displayed.

## Support Member Completion in the Scanner

The scanner must be able to detect a member completion character and set the token trigger of [TokenTriggers.MemberSelect](<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect>) when that character is parsed.

### Scanner example

Here is a simplified example of detecting the member completion character and setting the appropriate <xref:Microsoft.VisualStudio.Package.TokenTriggers> flag. This example is for illustrative purposes only. It assumes that your scanner contains a method `GetNextToken` that identifies and returns tokens from a line of text. The example code simply sets the trigger whenever it sees the right kind of character.

```csharp
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    public class TestScanner : IScanner
    {
        private Lexer lex;
        private const char memberSelectChar = '.';

        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo,
                                                   ref int state)
        {
            bool foundToken = false
            string token = lex.GetNextToken();
            if (token != null)
            {
                foundToken = true;
                char c = token[0];
                if (c == memberSelectChar)
                {
                        tokenInfo.Trigger |= TokenTriggers.MemberSelect;
                }
            }
            return foundToken;
        }
    }
}
```

## Support Member Completion in the Parser

For member completion, the <xref:Microsoft.VisualStudio.Package.Source> class calls the <xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDeclarations%2A> method. You must implement the list in a class that is derived from the <xref:Microsoft.VisualStudio.Package.Declarations> class. See the <xref:Microsoft.VisualStudio.Package.Declarations> class for details about the methods you must implement.

The parser is called with [ParseReason.MemberSelect](<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelect>) or [ParseReason.MemberSelectAndHighlightBraces](<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelectAndHighlightBraces>) when a member select character is typed. The location given in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object is immediately after the member select character. The parser must collect the names of all members that can appear in a member list at that particular point in the source code. Then the parser must parse the current line to determine the scope the user wants associated with the member select character.

This scope is based on the type of the identifier before the member select character. For example, in C#, given the member variable `languageService` that has a type of `LanguageService`, typing **languageService.** produces a list of all the members of the `LanguageService` class. Also in C#, typing **this.** produces a list of all the members of the class in the current scope.

### Parser example

The following example shows one way to populate a <xref:Microsoft.VisualStudio.Package.Declarations> list. This code assumes that the parser constructs a declaration and adds it to the list by calling an `AddDeclaration` method on the `TestAuthoringScope` class.

```csharp
using System.Collections;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace TestLanguagePackage
{
    internal class TestDeclaration
    {
        public string Name;            // Name of declaration
        public int     TypeImageIndex; // Glyph index
        public string Description;     // Description of declaration

        public TestDeclaration(string name, int typeImageIndex, string description)
        {
            this.Name = name;
            this.TypeImageIndex = typeImageIndex;
            this.Description = description;
        }
    }

    //===================================================
    internal class TestDeclarations : Declarations
    {
        private ArrayList declarations;

        public TestDeclarations()
            : base()
        {
            declarations = new ArrayList();
        }

        public void AddDeclaration(TestDeclaration declaration)
        {
            declarations.Add(declaration);
        }

        //////////////////////////////////////////////////////////////////////
        // Declarations of class methods that must be implemented.
        public override int GetCount()
        {
            // Return the number of declarations to show.
            return declarations.Count;
        }

        public override string GetDescription(int index)
        {
            // Return the description of the specified item.
            string description = "";
            if (index >= 0 && index < declarations.Count)
            {
                description = ((TestDeclaration)declarations[index]).Description;
            }
            return description;
        }

        public override string GetDisplayText(int index)
        {
            // Determine what is displayed in the tool tip list.
            string text = null;
            if (index >= 0 && index < declarations.Count)
            {
                text = ((TestDeclaration)declarations[index]).Name;
            }
            return text;
        }

        public override int GetGlyph(int index)
        {
            // Return index of image to display next to the display text.
            int imageIndex = -1;
            if (index >= 0 && index < declarations.Count)
            {
                imageIndex = ((TestDeclaration)declarations[index]).TypeImageIndex;
            }
            return imageIndex;
        }

        public override string GetName(int index)
        {
            string name = null;
            if (index >= 0 && index < declarations.Count)
            {
                name = ((TestDeclaration)declarations[index]).Name;
            }
            return name;
        }
    }

    //===================================================
    public class TestAuthoringScope : AuthoringScope
    {
        private TestDeclarations declarationsList;

        public void AddDeclaration(TestDeclaration declaration)
        {
            if (declaration != null)
            {
                if (declarationsList == null)
                {
                    declarationsList = new TestDeclarations();
                }
                declarationsList.AddDeclaration(declaration);
            }
        }

        public override Declarations GetDeclarations(IVsTextView view,
                                                     int line,
                                                     int col,
                                                     TokenInfo info,
                                                     ParseReason reason)
        {
            return declarationsList;
        }

        /////////////////////////////////////////////////
        // Remainder of AuthoringScope methods not shown.
        /////////////////////////////////////////////////
    }

    //===================================================
    class TestLanguageService : LanguageService
    {
        public override AuthoringScope ParseSource(ParseRequest req)
        {
            TestAuthoringScope scope = new TestAuthoringScope();
            if (req.Reason == ParseReason.MemberSelect ||
                req.Reason == ParseReason.MemberSelectAndHighlightBraces)
            {
                // Gather list of declarations based on what the user
                // has typed so far. In this example, this list is an array of
                // MemberDeclaration objects (a helper class you might implement
                // to hold member declarations).
                // How this list is gathered is dependent on the parser
                // and is not shown here.
                MemberDeclarations memberDeclarations;
                memberDeclarations = GetDeclarationsForScope();

                // Now populate the Declarations list in the authoring scope.
                // GetImageIndexBasedOnType() is a helper method you
                // might implement to convert a member type to an index into
                // the image list returned from the language service.
                foreach (MemberDeclaration dec in memberDeclarations)
                {
                    scope.AddDeclaration(new TestDeclaration(
                                             dec.Name,
                                             GetImageIndexBasedOnType(dec.Type),
                                             dec.Description));
                }
            }
            return scope;
        }
    }
}
```