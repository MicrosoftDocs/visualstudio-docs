---
title: "Outlining in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "outlining"
  - "language services [managed package framework], outlining"
  - "outlining, supporting in language services [managed package framework]"
ms.assetid: 7b5578b4-a20a-4b94-ad4c-98687ac133b9
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Outlining in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Outlining makes it possible to collapse a complex program into an overview or outline. For example, in C# all methods can be collapsed to a single line, showing only the method signature. In addition, structures and classes can be collapsed to show only the names of the structures and classes. Inside a single method, complex logic can be collapsed to show the overall flow by showing only the first line of statements such as `foreach`, `if`, and `while`.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Walkthrough: Outlining](../../extensibility/walkthrough-outlining.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Enabling Support for Outlining  
 The `AutoOutlining` registry entry is set to 1 to enable automatic outlining. Automatic outlining sets up a parse of the whole source when a file is loaded or changed in order to identify hidden regions and show the outlining glyphs. Outlining can also be controlled manually by the user.  
  
 The value of the `AutoOutlining` registry entry can be obtained through the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.AutoOutlining%2A> property on the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class. The `AutoOutlining` registry entry can be initialized with a named parameter to the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> attribute (see [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md) for details).  
  
## The Hidden Region  
 To provide outlining, your language service must support hidden regions. These are spans of text that can be expanded or collapsed. Hidden regions can be delimited by standard language symbols, such as curly braces, or by custom symbols. For example, C# has a `#region`/`#endregion` pair that delimits a hidden region.  
  
 Hidden regions are managed by a hidden region manager, which is exposed as the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession> interface.  
  
 Outlining uses hidden regions the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegion> interface and contain the span of the hidden region, the current visible state, and the banner to be shown when the span is collapsed.  
  
 The language service parser uses the <xref:Microsoft.VisualStudio.Package.AuthoringSink.AddHiddenRegion%2A> method to add a new hidden region with the default behavior for hidden regions, while the <xref:Microsoft.VisualStudio.Package.AuthoringSink.AddHiddenRegion%2A> method allows you to customize the appearance and behavior of the outline. Once hidden regions are given to the hidden region session, [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] manages the hidden regions for the language service.  
  
 If you need to determine when the hidden region session is destroyed, a hidden region is changed, or you need to make sure a particular hidden region is visible; you must derive a class from the <xref:Microsoft.VisualStudio.Package.Source> class and override the appropriate methods, <xref:Microsoft.VisualStudio.Package.Source.OnBeforeSessionEnd%2A>, <xref:Microsoft.VisualStudio.Package.Source.OnHiddenRegionChange%2A>, and <xref:Microsoft.VisualStudio.Package.Source.MakeBaseSpanVisible%2A>, respectively.  
  
### Example  
 Here is a simplified example of creating hidden regions for all pairs of curly braces. It is assumed that the language provides brace matching, and that the braces to be matched include at least the curly braces ({ and }). This approach is for illustrative purposes only. A full implementation would have a complete handling of cases in <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A>. This example also shows how to set the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.AutoOutlining%2A> preference to `true` temporarily. An alternative is to specify the `AutoOutlining` named parameter in the `ProvideLanguageServiceAttribute` attribute in your language package.  
  
 This example assumes C# rules for comments, strings, and literals.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace MyLanguagePackage  
{  
  
    public class MyLanguageService : LanguageService  
    {  
        private LanguagePreferences m_preferences;  
  
        public override LanguagePreferences  GetLanguagePreferences()  
        {  
            if (m_preferences == null)  
            {  
                m_preferences = new LanguagePreferences(this.Site,  
                                                        typeof(MyLanguageService).GUID,  
                                                        Name);  
                m_preferences.Init();  
                // Temporarily enabled auto-outlining  
                m_preferences.AutoOutlining = true;  
            }  
            return m_preferences;  
        }  
  
        public override AuthoringScope  ParseSource(ParseRequest req)  
        {  
            Source source = (Source) this.GetSource(req.FileName);  
            switch (req.Reason)  
            {  
               case ParseReason.HighlightBraces:  
               case ParseReason.MatchBraces:  
               case ParseReason.MemberSelectAndHighlightBraces:  
                  if (source.Braces != null)  
                  {  
                      foreach (TextSpan[] brace in source.Braces)  
                      {  
                         if (brace.Length == 2)  
                         {  
                             if (req.Sink.HiddenRegions == true   
                                   && source.GetText(brace[0]).Equals("{")   
                                   && source.GetText(brace[1]).Equals("}"))  
                             {  
                                //construct a TextSpan of everything between the braces  
                                TextSpan hideSpan = new TextSpan();  
                                hideSpan.iStartIndex = brace[0].iStartIndex;  
                                hideSpan.iStartLine = brace[0].iStartLine;  
                                hideSpan.iEndIndex = brace[1].iEndIndex;  
                                hideSpan.iEndLine = brace[1].iEndLine;  
                                req.Sink.ProcessHiddenRegions = true;  
                                req.Sink.AddHiddenRegion(hideSpan);  
                             }  
                             req.Sink.MatchPair(brace[0], brace[1], 1);  
                         }  
                         else if (brace.Length >= 3)  
                             req.Sink.MatchTriple(brace[0], brace[1], brace[2], 1);  
                  }  
        }  
                   break;  
               default:  
                   break;  
      }  
            // Must always return a valid AuthoringScope object.  
            return new MyAuthoringScope();  
        }  
    }  
}  
```  
  
## See Also  
 [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)   
 [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)
