---
title: "Font and Color Overview | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], font and color"
  - "font and color control [Visual Studio SDK], editors"
ms.assetid: 2203e4e7-8b7f-44ec-8884-6ff718d4f278
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Font and Color Overview
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic discusses text font and color settings in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE). It also introduces the concepts of Categories and Display Items, and it describes how VSPackages and the core editor use text attributes.  
  
## The Fonts and Colors Property Page  
 You can manage attributes of displayed text in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE) through the **Fonts and Colors** property page. To find the **Fonts and Colors** property page, on the **Tools** menu, click **Options**. Expand **Environment**, and then click **Fonts and Colors**.  
  
## Categories and Display Items  
 Fonts and colors are organized into **Categories** and **Display Items**.  
  
- A **Category** is a logical or functional container for a number of **Display Items**.  
  
   A list of **Categories** is in the **Show settings for** drop-down box of the **Fonts and Colors** property page.  
  
- A **Display Item** is a well-defined text entity such as a comment, a string, or a control structure that is to be colorized when displayed.  
  
  Each **Display Item** is uniquely defined within the **Category** that contains it. Consequently, more than one **Category** can have a **Display Item** with the same name.  
  
## VSPackage Control of Fonts and Colors  
 The [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] allows VSPackages to:  
  
- Define font and color **Categories**.  
  
- Specify the fonts and colors used to present **Display Items**.  
  
- Interact with the **Fonts and Colors** property page.  
  
- Aggregate multiple **Categories** into groups.  
  
- Persist changes in default settings.  
  
  There are two ways to interact with font and color selections within the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)].  
  
- One way is referred to as *Syntax Coloring*. It is used by a VSPackage that customizes the existing [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] editor to implement a language service and create a source editor.  
  
   Only one **Category** supports this mechanism, namely, the **Text Editor**.  
  
- A more general alternative supports all other **Categories** and user interface components other than the source editor when displaying text. For more information, see <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider>.  
  
## Core Editor Text Settings  
 Font and color settings for the core editor of a language service object are governed by the **Text EditorCategory** found in the **Show settings for** drop-down box of the **Fonts and Colors** property page.  
  
 When working with editors, you should use the specialized font and color control mechanism that the language service provides to control and extend the **Text Editor** settings. The mechanism is referred to as *syntax coloring* and provides:  
  
- A simplified technique for managing the fonts and colors of display items.  
  
   For more information, see <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorableItem>.  
  
- A well-defined and optimized colorization mechanism.  
  
   For more information, see <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer>.  
  
- The ability to both use built-in display items from the **Text EditorCategory** and to extend them.  
  
   For more information, see [How to: Use Built-In Colorable Items](../extensibility/internals/how-to-use-built-in-colorable-items.md) and [Custom Colorable Items](../extensibility/internals/custom-colorable-items.md).  
  
- Automatic persistence of the current state of both built-in and custom display items with the **Text Editor** category.  
  
  For more information on syntax coloring see [Syntax Coloring in a Legacy Language Service](../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md).  
  
## See Also  
 [Legacy Interfaces in the Editor](../extensibility/legacy-interfaces-in-the-editor.md)   
 [Syntax Coloring in a Legacy Language Service](../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)
