---
title: "Support for the Autos Window in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "language services [managed package framework], Autos window"
  - "Autos window, supporting in language services [managed package framework]"
ms.assetid: 47d40aae-7a3c-41e1-a949-34989924aefb
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Support for the Autos Window in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **Autos** window displays expressions such as variables and parameters that are in scope when the program being debugged is paused (either due to a breakpoint or an exception). The expressions can include variables, local or global, and parameters that have been changed in the local scope. The **Autos** window can also include instantiations of a class, structure, or some other type. Anything that an expression evaluator can evaluate can potentially be shown in the **Autos** window.  
  
 The managed package framework (MPF) does not provide direct support for the **Autos** window. However, if you override the <xref:Microsoft.VisualStudio.Package.LanguageService.GetProximityExpressions%2A> method, you can return a list of expressions to be presented in the **Autos** window.  
  
## Implementing Support for the Autos Window  
 All you need to do to support the **Autos** window is to implement the <xref:Microsoft.VisualStudio.Package.LanguageService.GetProximityExpressions%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class. Your implementation must decide, given a location in the source file, which expressions should appear in the **Autos** window. The method returns a list of strings in which each string represents a single expression. A return value of <xref:Microsoft.VisualStudio.VSConstants.S_OK> indicates that the list contains expressions, while <xref:Microsoft.VisualStudio.VSConstants.S_FALSE> indicates that there are no expressions to show.  
  
 The actual expressions returned are the names of the variables or parameters that appear at that location in the code. These names are passed to the expression evaluator to obtain values and types that are then displayed in the **Autos** window.  
  
### Example  
 The following example shows an implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.GetProximityExpressions%2A> method that gets a list of expressions from the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method using the parse reason <xref:Microsoft.VisualStudio.Package.ParseReason>. Each of the expressions is wrapped as a `TestVsEnumBSTR` that implements the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsEnumBSTR> interface.  
  
 Note that the `GetAutoExpressionsCount` and `GetAutoExpression` methods are custom methods on the `TestAuthoringSink` object and were added to support this example. They represent one way in which expressions added to the `TestAuthoringSink` object by the parser (by calling the <xref:Microsoft.VisualStudio.Package.AuthoringSink.AutoExpression%2A> method) can be accessed outside the parser.  
  
```csharp  
using Microsoft.VisualStudio;  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    public class TestLanguageService : LanguageService  
    {  
        public override int GetProximityExpressions(IVsTextBuffer buffer,  
                                                    int line,  
                                                    int col,  
                                                    int cLines,  
                                                    out IVsEnumBSTR ppEnum)  
        {  
            int retval = VSConstants.E_NOTIMPL;  
            ppEnum = null;  
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
                                                              ParseReason.Autos,  
                                                              null);  
                        req.Scope = this.ParseSource(req);  
                        TestAuthoringSink sink = req.Sink as TestAuthoringSink;  
  
                        retval = VSConstants.S_FALSE;  
                        int spanCount = sink.GetAutoExpressionsCount();  
                        if (spanCount > 0) {  
                            TestVsEnumBSTR bstrList = new TestVsEnumBSTR();  
                            for (int i = 0; i < spanCount; i++)  
                            {  
                                TextSpan span;  
                                sink.GetAutoExpression(i, out span);  
                                string expression = src.GetText(span.iStartLine,  
                                                                span.iStartIndex,  
                                                                span.iEndLine,  
                                                                span.iEndIndex);  
                                bstrList.AddString(expression);  
                            }  
                            ppEnum = bstrList;  
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
