---
title: "Bitmap Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, Bitmaps"
  - "Bitmaps element (VSCT XML schema)"
ms.assetid: edcd7891-f4e7-416d-809d-5e2eed9f17e4
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Bitmap Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Defines a bitmap. The bitmap is loaded either from a resource or from a file.  
  
## Syntax  
  
```  
<Bitmap guid="guidImages" href="images\MyImage.bmp" usedList="bmp1, bmp2, bmp3" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. GUID of the GUID/ID command identifier.<br /><br /> The guid attribute for a bitmap is not associated with any VSPackage or other command group.  It should be unique to the bitmap definition and should not be used for any other purpose.|  
|resID|ID of the GUID/ID command identifier. Either the resID or the href attribute is required.<br /><br /> The resID attribute is an integer resource ID that determines the bitmap strip that is to be loaded during command table merging.  When the command table is being loaded, the bitmaps specified by the resource ID will be loaded from the resource of the same module.|  
|usedList|Required if the resID attribute is present. Selects the available images in the bitmap strip.|  
|href|Path to the bitmap. Either the resID or the href attribute is required.<br /><br /> The include path is searched for the indicated image file, which is embedded in the resulting binary.  During the command table merge, the image is copied and no additional resource lookup or load is required.  If the usedList attribute is not present, all images in the strip are available. **Note:**  Images may be supplied in one of several formats that include .bmp, .png, and .gif.  Earlier versions of the compiler did not support 32-bit bitmap images that had alpha information for partial transparency. The workaround for these versions is to use the .png format.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Bitmaps Element](../extensibility/bitmaps-element.md)|Groups Bitmap elements.|  
  
## Example  
  
```  
<Bitmap guid="guidWidgetIcons" href="WidgetToolbarIcons_32.bmp" />  
<Bitmap guid="guidWidgetIcons2" resID="IDBMP_WIDGETICONS"  
  usedList="1, 2, 3, 4"/>  
```  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
