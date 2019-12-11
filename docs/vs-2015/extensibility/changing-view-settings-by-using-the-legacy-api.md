---
title: "Changing View Settings by Using the Legacy API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - changing view settings"
ms.assetid: 12c9b300-0894-4124-96a1-764326176d77
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Changing View Settings by Using the Legacy API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Settings for core editor features, such as word wrap, selection margin, and virtual space, can be changed by the user by means of the **Options** dialog box. However, it is also possible to change these settings programmatically.  
  
## Changing Settings by Using the Legacy API  
 The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer> interface exposes a set of text editor properties. The text view contains a category of properties (GUID_EditPropCategory_View_MasterSettings) that represents the group of programmatically changed settings for the text view. Once view settings have been changed in this way, they cannot be changed in the **Options** dialog box until they are reset.  
  
 Following is the typical process for changing view settings for an instance of the core editor.  
  
1. Call `QueryInterface` on the (<xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView>) for the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer> interface.  
  
2. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer.GetPropertyCategory%2A> method, specifying a value of GUID_EditPropCategory_View_MasterSettings for the `rguidCategory` parameter.  
  
     Doing this returns a pointer to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer> interface, which contains the set of forced properties for the view. Any settings in this group are permanently forced. If a setting is not in this group, then it will follow the options specified in the **Options** dialog box or the user's commands.  
  
3. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty%2A> method, specifying the appropriate settings value in the `idprop` parameter.  
  
     For example, to force word wrap, call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty%2A> and specify a value of VSEDITPROPID_ViewLangOpt_WordWrap, `vt` for the `idprop` parameter. In this call, `vt` is a VARIANT of type VT_BOOL and `vt.boolVal` is VARIANT_TRUE.  
  
## Resetting Changed View Settings  
 To reset any changed view setting for an instance of the core editor, call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.RemoveProperty%2A> method and specify the appropriate setting value in the `idprop` parameter.  
  
 For example, to allow word wrap to float freely, you would remove it from the property category by calling <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.RemoveProperty%2A> and specifying a value of VSEDITPROPID_ViewLangOpt_WordWrap for the `idprop` parameter.  
  
 To remove all changed settings for the core editor at once, specify a value of VSEDITPROPID_ViewComposite_AllCodeWindowDefaults, vt for the `idprop` parameter. In this call, vt is a VARIANT of type VT_BOOL and vt.boolVal is VARIANT_TRUE.  
  
## See Also  
 [Inside the Core Editor](../extensibility/inside-the-core-editor.md)   
 [Accessing theText View by Using the Legacy API](../extensibility/accessing-thetext-view-by-using-the-legacy-api.md)   
 [Options Dialog Box](../ide/reference/options-dialog-box-visual-studio.md)
