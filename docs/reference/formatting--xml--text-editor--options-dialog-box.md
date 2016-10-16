---
title: "Formatting, XML, Text Editor, Options Dialog Box"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: bb539b3a-027c-4b2f-906e-403e0e22ba8d
caps.latest.revision: 2
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Formatting, XML, Text Editor, Options Dialog Box
This dialog box allows you to specify the formatting settings for the XML Editor. You can access the **Options** dialog box from the **Tools** menu.  
  
> [!NOTE]
>  These settings are available when you select the **Text Editor** folder, the **XML** folder, and then the **Formatting** option from the **Options** dialog box.  
  
## Attributes  
 **Preserve manual attribute formatting**  
 Attributes are not reformatted. This is the default.  
  
> [!NOTE]
>  If the attributes are on multiple lines, the editor indents each line of attributes to match the indentation of the parent element.  
  
 **Align attributes each on their own line**  
 Aligns the second and subsequent attributes vertically to match the indentation of the first attribute. The following XML text is an example of how the attributes would be aligned.  
  
```  
<item id = "123-A"  
      name = "hammer"  
      price = "9.95">  
</item>  
```  
  
## Auto Reformat  
 **On paste from the Clipboard**  
 Reformats XML text pasted from the Clipboard.  
  
 **On completion of end tag**  
 Reformats the element when the end tag is completed.  
  
## Mixed Content  
 **Preserve mixed content by default**  
 Determines whether the editor reformats mixed content. By default, the editor attempts to reformat mixed content, except when the content is found in an `xml:space="preserve"` scope.  
  
 If an element contains a mix of text and markup, the contents are considered to be mixed content. The following is an example of an element with mixed content.  
  
```  
<dir>c:\data\AlphaProject\  
  <file readOnly="false">test1.txt</file>  
  <file readOnly="false">test2.txt</file>  
</dir>  
```  
  
## See Also  
 [XML Document Properties, Properties Window](../reference/xml-document-properties--properties-window.md)   
 [XML Editor Components](../reference/xml-editor-components.md)