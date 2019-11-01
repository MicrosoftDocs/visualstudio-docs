---
title: "Validating Breakpoints in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "breakpoint validation"
  - "language services [managed package framework], breakpoint validation"
ms.assetid: a7e873cd-dfe1-474f-bda5-fd7532774b15
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# Validating Breakpoints in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A breakpoint indicates that program execution should stop at a particular point while it is being run in a debugger. A user can place a breakpoint on any line in the source file, since the editor has no knowledge of what constitutes a valid location for a breakpoint. When the debugger is launched, all of the marked breakpoints (called pending breakpoints) are bound to the appropriate location in the running program. At the same time the breakpoints are validated to ensure that they mark valid code  locations. For example, a breakpoint on a comment is not valid, because there is no code at that location in the source code. The debugger disables invalid breakpoints.  
  
 Since the language service knows about the source code being displayed, it can validate breakpoints before the debugger is launched. You can override the <xref:Microsoft.VisualStudio.Package.LanguageService.ValidateBreakpointLocation%2A> method to return a span specifying a valid location for a breakpoint. The breakpoint location is still validated when the debugger is launched, but the user is notified of invalid breakpoints without waiting for the debugger to load.  
  
## Implementing Support for Validating Breakpoints  
  
- The <xref:Microsoft.VisualStudio.Package.LanguageService.ValidateBreakpointLocation%2A> method is given the position of the breakpoint. Your implementation must decide whether or not the location is valid, and indicate this by returning a text span that identifies the code associated with the line position the breakpoint.  
  
- Return <xref:Microsoft.VisualStudio.VSConstants.S_OK> if the location is valid, or <xref:Microsoft.VisualStudio.VSConstants.S_FALSE> if it is not valid.  
  
- If the breakpoint is valid the text span is highlighted along with the breakpoint.  
  
- If the breakpoint is invalid, an error message appears in the status bar.  
  
### Example  
 This example shows an implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.ValidateBreakpointLocation%2A> method that calls the parser to obtain the span of code (if any) at the specified location.  
  
 This example assumes that you have added a `GetCodeSpan` method to the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class that validates the text span and returns `true` if it is a valid breakpoint location.  
  
```csharp  
using Microsoft VisualStudio;  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    class TestLanguageService : LanguageService  
    {  
        public override int ValidateBreakpointLocation(IVsTextBuffer buffer,  
                                                       int line,  
                                                       int col,  
                                                       TextSpan[] pCodeSpan)  
        {  
            int retval = VSConstants.S_FALSE;  
            if (pCodeSpan != null)  
            {  
                // Initialize span to current line by default.  
                pCodeSpan[0].iStartLine = line;  
                pCodeSpan[0].iStartIndex = col;  
                pCodeSpan[0].iEndLine = line;  
                pCodeSpan[0].iEndIndex = col;  
            }  
  
            if (buffer != null)  
            {  
                IVsTextLines textLines = buffer as IVsTextLines;  
                if (textLines != null)  
                {  
                    Source src = this.GetSource(textLines);  
                    if (src != null)  
                    {  
                        TokenInfo tokenInfo = new TokenInfo();  
                        string text = src.GetText();  
                        ParseRequest req = CreateParseRequest(src,  
                                                              line,  
                                                              col,  
                                                              tokenInfo,  
                                                              text,  
                                                              src.GetFilePath(),  
                                                              ParseReason.CodeSpan,  
                                                              null);  
                        req.Scope = this.ParseSource(req);  
                        TestAuthoringSink sink = req.Sink as TestAuthoringSink;  
  
                        TextSpan span = new TextSpan();  
                        if (sink.GetCodeSpan(out span))  
                        {  
                            pCodeSpan[0] = span;  
                            retval = VSConstants.S_OK;  
                        }  
                    }  
                }  
            }  
            return retval;  
        }  
    }  
}  
```  
  
## See Also  
 [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)
