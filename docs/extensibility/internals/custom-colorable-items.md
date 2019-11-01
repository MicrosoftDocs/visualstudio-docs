---
title: "Custom Colorable Items | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "colorable items"
  - "language services, custom colorable items"
ms.assetid: b4d0ddee-c04b-48dc-ba82-f6068570cef0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Custom colorable items
You can override the list of types for colorizing, such as keywords and comments, by implementing custom colorable items as part of your language service.

## User settings of colorable items
 You can display the **Fonts and Colors** dialog box by selecting **Options** on the **Tools** menu, and then selecting **Fonts and Colors** under **Environment**. When you select a display, such as **Text Editor** or **Command Window**, the **Display items** list box shows all the colorable items for that display. You can view and change the font, size, foreground color, and background color for each colorable item. Your choices are stored in a cache in the registry and accessed by the colorable item name.

## Presentation of colorable items
 Because the IDE handles user overrides of colorable items in the **Fonts and Colors** dialog box, you need only supply each custom colorable item with a name. This name is what appears in the **Display items** list. The colorable items appear in alphabetical order. To group your language service's custom colorable items, you can begin each name with your language name, for example **NewLanguage - Comment** and **NewLanguage - Keyword**.

> [!CAUTION]
> You should include the language name in the colorable item name to avoid collisions with existing colorable item names. If you change the name of one of your colorable items during development, you must reset the cache that was created the first time your colorable items were accessed. You can reset the experimental cache with the **CreateExpInstance** tool, which is installed with the Visual Studio SDK, typically in the directory:
>
> *C:\Program Files (x86)\Microsoft Visual Studio 14.0\VSSDK\VisualStudioIntegration\Tools\Bin*
>
> To reset the cache, enter **CreateExpInstance /Reset**. For more information about **CreateExpInstance**, see [CreateExpInstance utility](../../extensibility/internals/createexpinstance-utility.md).

 The first item in your list of colorable items is never referenced. The first item corresponds to a colorable item index of 0, and [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] always supplies the default text colors and attributes for that item. The easiest way of dealing with this unreferenced item is to supply a placeholder colorable item in your list as the first item.

## Implement custom colorable items

1. Define what must be colorized in your language, for example Keyword, Operator, and Identifier.

2. Create an enumeration of these colorable items.

3. Associate the token types returned from a parser or scanner with the enumerated values.

    For example, the values representing the token types could be the same values in the custom colorable items enumeration.

4. In your implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method in your <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> object, fill the attributes list with the values from your custom colorable items enumeration corresponding to the token types returned from the parser or scanner.

5. In the same class that implements the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo> interface, implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems> interface and its two methods, <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems.GetItemCount%2A> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems.GetColorableItem%2A>.

6. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorableItem> interface.

7. If you want to support 24-bit or high color values, also implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiColorItem> interface.

8. In your language service object, create a list that contains your <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorableItem> objects, one for each colorable item your parser or scanner can identify.

    You can access each item in the list by using the corresponding value from the custom colorable items enumeration. Use the enumeration values as an index into the list. The first item in the list is never accessed, because it corresponds to the default text style that [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] always handles itself. You can compensate for this by inserting a placeholder colorable item at the beginning of your list.

9. In your implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems.GetItemCount%2A> method, return the number of items in your custom colorable items list.

10. In your implementation of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems.GetColorableItem%2A> method, return the requested colorable item from your list.

    For an example of how to implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorableItem> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiColorItem> interfaces, see <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiColorItem>.

## See also
- [Model of a legacy language service](../../extensibility/internals/model-of-a-legacy-language-service.md)
- [Syntax coloring in custom editors](../../extensibility/syntax-coloring-in-custom-editors.md)
- [Syntax coloring in a legacy language service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)
- [Implement syntax coloring](../../extensibility/internals/implementing-syntax-coloring.md)
- [How to: Use built-in colorable items](../../extensibility/internals/how-to-use-built-in-colorable-items.md)