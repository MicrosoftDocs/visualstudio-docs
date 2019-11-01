---
title: "Syntax Colorizing in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "language services [managed package framework], syntax highlighting"
  - "colorization, supporting in language services [managed package framework]"
  - "syntax highlighting, supporting in language services [managed package framework]"
  - "language services [managed package framework], colorization"
ms.assetid: 1ca1736a-f554-42e4-a9c7-fe8c3c1717df
caps.latest.revision: 29
ms.author: gregvanl
manager: jillfra
---
# Syntax Colorizing in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Syntax colorization is a feature that causes different elements of a programming language to be displayed in a source file in different colors and styles. To support this feature, you need to supply a parser or scanner that can identify the types of lexical elements or tokens in the file. Many languages distinguish keywords, delimiters (such as parentheses or braces), and comments by colorizing them in different ways.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor and Language Services](../../extensibility/extending-the-editor-and-language-services.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Implementation  
 To support colorization, the managed package framework (MPF) includes the <xref:Microsoft.VisualStudio.Package.Colorizer> class, which implements the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> interface. This class interacts with an <xref:Microsoft.VisualStudio.Package.IScanner> to determine the token and colors. For more information on scanners, see [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md). The <xref:Microsoft.VisualStudio.Package.Colorizer> class then marks each character of the token with the color information and returns that information to the editor displaying the source file.  
  
 The color information returned to the editor is an index into a list of colorable items. Each colorable item specifies a color value and a set of font attributes, such as bold or strikethrough. The editor supplies a set of default colorable items that your language service can use. All you need to do is specify the appropriate color index for each token type. However, you can provide a set of custom colorable items and the indices you supply for tokens, and reference your own list of colorable items instead of the default list. You must also set the `RequestStockColors` registry entry to 0 (or do not specify the `RequestStockColors` entry at all) to support custom colors. You can set this registry entry with a named parameter to the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> user-defined attribute. For more information on registering a language service and setting its options, see [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md).  
  
## Custom Colorable Items  
 To supply your own custom colorable items, you must override the <xref:Microsoft.VisualStudio.Package.LanguageService.GetItemCount%2A> and <xref:Microsoft.VisualStudio.Package.LanguageService.GetColorableItem%2A> method on the <xref:Microsoft.VisualStudio.Package.LanguageService> class. The first method returns the number of custom colorable items that your language service supports and the second gets the custom colorable item by index. You create the default list of custom colorable items. In the constructor of your language service, all you need to do is supply each colorable item with a name. Visual Studio automatically handles the case where the user selects a different set of colorable items. This name is what appears in the **Fonts and Colors** property page on the **Options** dialog box (available from Visual Studio **Tools** menu) and this name determines which color a user has overridden. The user's choices are stored in a cache in the registry and accessed by the color name. The **Fonts and Colors** property page lists all of the color names in alphabetical order, so you can group your custom colors by preceding each color name with your language name; for example, "**TestLanguage- Comment**" and "**TestLanguage- Keyword**". Or you can group your colorable items by type, "**Comment (TestLanguage)**" and "**Keyword (TestLanguage)**". Grouping by language name is preferred.  
  
> [!CAUTION]
> It is strongly recommended that you include the language name in the colorable item name to avoid collisions with existing colorable item names.  
  
> [!NOTE]
> If you change the name of one of your colors during development, you must reset the cache that Visual Studio created the first time your colors were accessed. You can do so by running the **Reset the Experimental Hive** command from the Visual Studio SDK program menu.  
  
 Note that the first item in your list of colorable items is never referenced. Visual Studio always supplies the default text colors and attributes for that item. The easiest way of dealing with this is to supply a placeholder colorable item as the first item.  
  
### High Color Colorable Items  
 Colorable items can also support 24-bit or high color values through the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiColorItem> interface. The MPF <xref:Microsoft.VisualStudio.Package.ColorableItem> class supports the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiColorItem> interface and the 24-bit colors are specified in the constructor along with the normal colors. See the <xref:Microsoft.VisualStudio.Package.ColorableItem> class for more details. The example below shows how to set the 24-bit colors for keywords and comments. The 24-bit colors are used when 24-bit color is supported on the user's desktop; otherwise, the normal text colors are used.  
  
 Remember, these are the default colors for your language; the user can change these colors to whatever they want.  
  
### Example  
 This example shows one way to declare and populate an array of custom colorable items using the <xref:Microsoft.VisualStudio.Package.ColorableItem> class. This example sets the keyword and comment colors using 24-bit colors.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    public class TestLanguageService : LanguageService  
    {  
        private ColorableItem[] m_colorableItems;  
  
        TestLanguageService() : base()  
        {  
            m_colorableItems = new ColorableItem[] {  
                new ColorableItem("TestLanguage – Text",  
                                  "Text",  
                                  COLORINDEX.CI_SYSPLAINTEXT_FG,  
                                  COLORINDEX.CI_SYSPLAINTEXT_BK,  
                                  System.Drawing.Color.Empty,  
                                  System.Drawing.Color.Empty,  
                                  FONTFLAGS.FF_DEFAULT),  
                new ColorableItem("TestLanguage – Keyword",  
                                  "Keyword",  
                                  COLORINDEX.CI_MAROON,  
                                  COLORINDEX.CI_SYSPLAINTEXT_BK,  
                                  System.Drawing.Color.FromArgb(192,32,32),  
                                  System.Drawing.Color.Empty,  
                                  FONTFLAGS.FF_BOLD),  
                new ColorableItem("TestLanguage – Comment",  
                                  "Comment",  
                                  COLORINDEX.CI_DARKGREEN,  
                                  COLORINDEX.CI_LIGHTGRAY,  
                                  System.Drawing.Color.FromArgb(32,128,32),  
                                  System.Drawing.Color.Empty,  
                                  FONTFLAGS.FF_DEFAULT)  
                // ...  
                // Add as many colorable items as you want to support.  
            };  
        }  
    }  
}  
```  
  
## The Colorizer class and the Scanner  
 The base <xref:Microsoft.VisualStudio.Package.LanguageService> class has a <xref:Microsoft.VisualStudio.Package.LanguageService.GetColorizer%2A> method that instantiantes the <xref:Microsoft.VisualStudio.Package.Colorizer> class. The scanner that is returned from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method is passed to the <xref:Microsoft.VisualStudio.Package.Colorizer> class constructor.  
  
 You must implement the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method in your own version of the <xref:Microsoft.VisualStudio.Package.LanguageService> class. The <xref:Microsoft.VisualStudio.Package.Colorizer> class uses the scanner to obtain all token color information.  
  
 The scanner needs to populate a <xref:Microsoft.VisualStudio.Package.TokenInfo> structure for every token it finds. This structure contains information such as the span the token occupies, the color index to use, what type is the token, and token triggers (see <xref:Microsoft.VisualStudio.Package.TokenTriggers>). Only the span and color index are needed for colorization by the <xref:Microsoft.VisualStudio.Package.Colorizer> class.  
  
 The color index stored in the <xref:Microsoft.VisualStudio.Package.TokenInfo> structure is typically a value from the <xref:Microsoft.VisualStudio.Package.TokenColor> enumeration, which provides a number of named indices corresponding to various language elements such as keywords and operators. If your custom colorable items list matches the items presented in the <xref:Microsoft.VisualStudio.Package.TokenColor> enumeration, then you can just use the enumeration as the color for each token. However, if you have additional colorable items or you do not want to use the existing values in that order, you can arrange your custom colorable items list to suit your needs and return the appropriate index into that list. Just be sure to cast the index to a <xref:Microsoft.VisualStudio.Package.TokenColor> when storing it in the <xref:Microsoft.VisualStudio.Package.TokenInfo> structure; [!INCLUDE[vs_current_short](../../includes/vs-current-short-md.md)] sees only the index.  
  
### Example  
 The following example shows how the scanner might identify three token types: numbers, punctuation, and identifiers (anything that is not a number or punctuation). This example is for illustrative purposes only and does not represent a comprehensive parser and scanner implementation. It assumes that there is a `Lexer` class with a `GetNextToken()` method that returns a string.  
  
```csharp  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    private Lexer lex;  
  
    public class TestScanner : IScanner  
    {  
        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo,  
                                                   ref int state)  
        {  
            bool foundToken = false;  
            string token = lex.GetNextToken();  
            if (token != null)  
            {  
                char firstChar = token[0];  
                if (Char.IsPunctuation(firstChar))  
                {  
                    tokenInfo.Type = TokenType.Operator;  
                    tokenInfo.Color = TokenColor.Keyword;  
                }  
                else if (Char.IsNumber(firstChar))  
                {  
                    tokenInfo.Type = TokenType.Literal;  
                    tokenInfo.Color = TokenColor.Number;  
                }  
                else  
                {  
                    tokenInfo.Type = TokenType.Identifier;  
                    tokenInfo.Color = TokenColor.Identifier;  
                }  
            }  
            return foundToken;  
        }  
```  
  
## See Also  
 [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)   
 [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)   
 [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)
