---
title: "How to: Access the Built-in Fonts and Color Scheme | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "fonts, accessing built-in"
  - "font and color control [Visual Studio SDK], categories"
  - "colors, accessing built-in schemes"
ms.assetid: 6905845e-e88e-4805-adcf-21da39108ec7
caps.latest.revision: 24
ms.author: gregvanl
manager: jillfra
---
# How to: Access the Built-in Fonts and Color Scheme
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio integrated development environment (IDE) has a scheme of fonts and colors that is associated with the editor window. You can access this scheme through the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface.  
  
 To use the built-in fonts and colors scheme, a VSPackage must:  
  
- Define a category to use with the default fonts and colors service.  
  
- Register the category with the default fonts and colors server.  
  
- Advise the IDE that a specific window uses the built-in display items and categories by using the `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer` and `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer` interfaces.  
  
  The IDE uses the resulting category as a handle to the window. The category's name is displayed in the **Show settings for:** drop-down box in the **Fonts and Colors** property page.  
  
### To define a category using built-in fonts and colors  
  
1. Create an arbitrary GUID.  
  
    This GUID is used to uniquely identify a category<strong>.</strong> This category reuses the IDE's default fonts and colors specification.  
  
   > [!NOTE]
   > When retrieving font and color data with the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents> or other interfaces, VSPackages use this GUID to reference built-in information.  
  
2. The category's name must be added to a string table inside the VSPackage's resources (.rc) file, so that it can be localized as needed when displayed in the IDE.  
  
    For more information, see [Adding or Deleting a String](https://msdn.microsoft.com/library/077077b4-0f4b-4633-92d6-60b321164cab).  
  
### To register a category using built-in fonts and colors  
  
1. Construct a special type of category registry entry in the following location:  
  
     [HKLM\SOFTWARE\Microsoft \Visual Studio\\*\<Visual Studio version>*\FontAndColors\\*\<Category>*]  
  
     *\<Category>* is the non-localized name of the category.  
  
2. Populate the registry to use the stock fonts and color scheme with four values:  
  
    |Name|Type|Data|Description|  
    |----------|----------|----------|-----------------|  
    |Category|REG_SZ|GUID|An arbitrary GUID that identifies a category that contains the stock font and color scheme.|  
    |Package|REG_SZ|GUID|{F5E7E71D-1401-11D1-883B-0000F87579D2}<br /><br /> This GUID is used by all VSPackages that use the default font and color configurations.|  
    |NameID|REG_DWORD|ID|The resource ID of a localizable category name in the VSPackage.|  
    |ToolWindowPackage|REG_SZ|GUID|The GUID of the VSPackage implementing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface.|  
  
3. 
  
### To initiate the use of system-provided fonts and colors  
  
1. Create an instance of the `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer` interface as part of the window's implementation and initialization.  
  
2. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer.GetPropertyCategory%2A> method to obtain an instance of the `T:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer` interface corresponding to the current <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> instance.  
  
3. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty%2A> twice.  
  
   - Call once with `VSEDITPROPID_ViewGeneral_ColorCategory`as an argument.  
  
   - Call once with `VSEDITPROPID_ViewGeneral_FontCategory` as an argument.  
  
     This sets and exposes the default fonts and colors services as a property of the window.  
  
## Example  
 The following example initiates the use of built-in fonts and colors.  
  
```  
CComVariant vt;  
CComQIPtr<IVsTextEditorPropertyCategoryContainer> spPropCatContainer(m_spView);  
if (spPropCatContainer != NULL){  
    CComPtr<IVsTextEditorPropertyContainer> spPropContainer;  
    if (SUCCEEDED(spPropCatContainer->GetPropertyCategory(GUID_EditPropCategory_View_MasterSettings,   
                                                          &spPropContainer))){  
        CComVariant vt;CComVariant VariantGUID(bstrGuidText);  
        spPropContainer->SetProperty(VSEDITPROPID_ViewGeneral_FontCategory, VariantGUID);  
        spPropContainer->SetProperty(VSEDITPROPID_ViewGeneral_ColorCategory, VariantGUID);  
    }  
}  
```  
  
## See Also  
 [Using Fonts and Colors](../extensibility/using-fonts-and-colors.md)   
 [Getting Font and Color Information for Text Colorization](../extensibility/getting-font-and-color-information-for-text-colorization.md)   
 [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md)   
 [Font and Color Overview](../extensibility/font-and-color-overview.md)
