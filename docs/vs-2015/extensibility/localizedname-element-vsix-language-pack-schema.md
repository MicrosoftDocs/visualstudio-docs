---
title: "LocalizedName Element (VSIX Language Pack Schema) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
ms.assetid: 57b7f502-3b04-42d9-90d5-f57772a7c757
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# LocalizedName Element (VSIX Language Pack Schema)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Required. The localized name of the extension to be installed.  
  
## Syntax  
  
```  
<Name>Localized name of the extension</Name>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|None||  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[VSIX LanguagePack Element](../extensibility/vsixlanguagepack-element-vsix-language-pack-schema.md)|Required. Provides the root element for a VSIX language pack.|  
  
## Text Value  
 Required. The name of the language pack in the target language.  
  
## Element Information  

:::row:::
    :::column:::
        Namespace
    :::column-end:::
    :::column:::
        `http://schemas.microsoft.com/developer/vsx-schema-lp/2010`
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Schema Name
    :::column-end:::
    :::column:::
        VSIX Language Pack Schema
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Validation File
    :::column-end:::
    :::column:::
        VSIXLanguagePackSchema.xsd
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Can be Empty
    :::column-end:::
    :::column:::
        Not applicable
    :::column-end:::
:::row-end:::
  
## See Also  
 [VSX Language Pack Schema Reference](../extensibility/vsx-language-pack-schema-reference.md)   
 [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md)   
 [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110))
