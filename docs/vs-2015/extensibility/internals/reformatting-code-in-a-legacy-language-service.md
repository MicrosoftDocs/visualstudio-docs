---
title: "Reformatting Code in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "reformatting code, supporting in language services [managed package framework]"
  - "language services [managed package framework], reformatting code"
ms.assetid: 08bb3375-8fef-4f4e-9efa-0d7333bab0eb
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Reformatting Code in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] source code can be reformatted by normalizing the use of indentations and whitespace. This can include inserting or removing spaces or tabs at the beginning of each line, adding new lines between lines, or replacing spaces with tabs or tabs with spaces.  
  
> [!NOTE]
> **Note** Inserting or deleting newline characters can affect markers such as breakpoints and bookmarks, but adding or removing spaces or tabs does not affect markers.  
  
 Users can start a reformatting operation by selecting **Format Selection** or **Format Document** from the **Advanced** menu on the **Edit** menu. A reformatting operation can also be triggered when a code snippet or a particular character is inserted. For example, when you type a closing brace in C#, everything between the matching open brace and the close brace is automatically indented to the proper level.  
  
 When [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] sends the **Format Selection** or **Format Document** command to the language service, the <xref:Microsoft.VisualStudio.Package.ViewFilter> class calls the <xref:Microsoft.VisualStudio.Package.Source.ReformatSpan%2A> method in the <xref:Microsoft.VisualStudio.Package.Source> class. To support formatting you must override the <xref:Microsoft.VisualStudio.Package.Source.ReformatSpan%2A> method and supply your own formatting code.  
  
## Enabling Support for Reformatting  
 To support formatting, the `EnableFormatSelection` parameter of the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> must be set to `true` when you register your VSPackage. This sets the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableFormatSelection%2A> property to `true`. The <xref:Microsoft.VisualStudio.Package.ViewFilter.CanReformat%2A> method returns the value of this property. If it returns true, the <xref:Microsoft.VisualStudio.Package.ViewFilter> class calls the <xref:Microsoft.VisualStudio.Package.Source.ReformatSpan%2A>.  
  
## Implementing Reformatting  
 To implement reformatting, you must derive a class from the <xref:Microsoft.VisualStudio.Package.Source> class and override the <xref:Microsoft.VisualStudio.Package.Source.ReformatSpan%2A> method. The <xref:Microsoft.VisualStudio.TextManager.Interop.TextSpan> object describes the span to format and the <xref:Microsoft.VisualStudio.Package.EditArray> object holds the edits made on the span. Note that this span can be the entire document. However, since there are likely to be multiple changes made to the span, all the changes should be reversible in a single action. To do this, wrap all changes in a <xref:Microsoft.VisualStudio.Package.CompoundAction> object (see "Using the CompoundAction Class" section in this topic).  
  
### Example  
 The following example ensures there is a single space after every comma in the selection, unless the comma is followed by a tab or is at the end of the line. Trailing spaces after the last comma in a line are deleted. See the "Using the CompoundAction Class" section in this topic to see how this method is called from the <xref:Microsoft.VisualStudio.Package.Source.ReformatSpan%2A> method.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft VisualStudio.TextManager.Interop;  
  
namespace MyLanguagePackage  
{  
    class MySource : Source  
    {  
        private void DoFormatting(EditArray mgr, TextSpan span)  
        {  
            // Make sure there is one space after every comma unless followed  
            // by a tab or comma is at end of line.  
            IVsTextLines pBuffer = GetTextLines();  
            if (pBuffer != null)  
            {  
                int    startIndex = span.iStartIndex;  
                int    endIndex   = 0;  
                string line       = "";  
                // Loop over all lines in span  
                for (int i = span.iStartLine; i <= span.iEndLine; i++)  
                {  
                    if (i < span.iEndLine)  
                    {  
                        pBuffer.GetLengthOfLine(i, out endIndex);  
                    }  
                    else  
                    {  
                        endIndex = span.iEndIndex;  
                    }  
                    pBuffer.GetLineText(i, startIndex, i, endIndex, out line);  
  
                    if (line.Length > 0)  
                    {  
                        int index = 0;  
                        // Loop over all commas in line  
                        while ((index = line.IndexOf(',', index)) != -1)  
                        {  
                            int spaceIndex = index + 1;  
                            // Determine how many spaces after comma  
                            while (spaceIndex < line.Length && line[spaceIndex] == ' ')  
                            {  
                                ++spaceIndex;  
                            }  
  
                            int      spaceCount      = spaceIndex - (index + 1);  
                            string   replacementText = " ";  
                            bool     fDoEdit         = true;  
                            TextSpan editTextSpan    = new TextSpan();  
  
                            editTextSpan.iStartLine  = i;  
                            editTextSpan.iEndLine    = i;  
                            editTextSpan.iStartIndex = index + 1;  
  
                            if (spaceIndex == line.Length)  
                            {  
                                if (spaceCount > 0)  
                                {  
                                    // Delete spaces after a comma at end of line  
                                    editTextSpan.iEndIndex = spaceIndex;  
                                    replacementText = "";  
                                }  
                                else  
                                {  
                                    // Otherwise, do not add spaces if comma is  
                                    // at end of line.  
                                    fDoEdit = false;  
                                }  
                            }  
                            else if (spaceCount == 0)  
                            {  
                                if (spaceIndex < line.Length && line[spaceIndex] == '\t')  
                                {  
                                    // Do not insert space if a tab follows  
                                    // a comma.  
                                    fDoEdit = false;  
                                }  
                                else  
                                {  
                                    // No space after comma so add a space.  
                                    editTextSpan.iEndIndex = index + 1;  
                                }  
                            }  
                            else if (spaceCount > 1)  
                            {  
                                // More than one space after comma, replace  
                                // with a single space.  
                                editTextSpan.iEndIndex = spaceIndex;  
                            }  
                            else  
                            {  
                                // Single space after a comma and not at end  
                                // of the line, leave it alone.  
                                fDoEdit = false;  
                            }  
                            if (fDoEdit)  
                            {  
                                // Add edit operation  
                                mgr.Add(new EditSpan(editTextSpan, replacementText));  
                            }  
                            index = spaceIndex;  
                        }  
                    }  
                    startIndex = 0; // All subsequent lines start at 0  
                }  
                // Apply all edits  
                mgr.ApplyEdits();  
            }  
        }  
    }  
}  
```  
  
## Using the CompoundAction Class  
 All the reformatting done on a section of code should be reversible in a single action. This can be accomplished using a <xref:Microsoft.VisualStudio.Package.CompoundAction> class. This class wraps a set of edit operations on the text buffer into a single edit operation.  
  
### Example  
 Here is an example of how to use the <xref:Microsoft.VisualStudio.Package.CompoundAction> class. See the example in the "Implementing Support for Formatting" section in this topic for an example of the `DoFormatting` method.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft VisualStudio.TextManager.Interop;  
  
namespace MyLanguagePackage  
{  
    class MySource : Source  
    {  
        public override void ReformatSpan(EditArray mgr, TextSpan span)  
        {  
            string description = "Reformat code";  
            CompoundAction ca = new CompoundAction(this, description);  
            using (ca)  
            {  
                ca.FlushEditActions();      // Flush any pending edits  
                DoFormatting(mgr, span);    // Format the span  
            }  
        }  
    }  
}  
```  
  
## See Also  
 [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)
