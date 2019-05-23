---
title: "Getting Field Descriptions from the Properties Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "Properties window, field descriptions"
ms.assetid: 7d92bb6a-b9b9-4cd8-99e9-b5ee129b52a3
caps.latest.revision: 9
manager: jillfra
---
# Getting Field Descriptions from the Properties Window
At the bottom of the **Properties** window, a description area displays information related to the selected property field. This feature is turned on by default. If you want to hide the description field, right-click the **Properties** window and click **Description**. Doing so also removes the check mark next to the **Description** title in the menu window. You can display the field again by following the same steps to toggle **Description** back on.  
  
 The information in the description field comes from <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo>. Each method, interface, coclass, and so on can have an unlocalized `helpstring` attribute in the type library. The **Properties** window retrieves the string from <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo.GetDocumentation%2A>.  
  
### To specify localized help strings  
  
1. Add the `helpstringdll` attribute to the library statement in the type library (`typelib`).  
  
   > [!NOTE]
   > This step is optional if the type library is in an object library (.olb) file.  
  
2. Specify `helpstringcontext` attributes for the strings. You can also specify `helpstring` attributes.  
  
    These attributes are distinct from the `helpfile` and `helpcontext` attributes, which are contained in actual .chm file Help topics.  
  
   To retrieve the description information to be displayed for the highlighted property name, the **Properties** window calls <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2.GetDocumentation2%2A> for the property that is selected, specifying the desired `lcid` attribute for the output string. Internally, <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2> finds the .dll file specified in the `helpstringdll` attribute and calls `DLLGetDocumentation` on that .dll file with the specified context and `lcid` attribute.  
  
   The signature and implementation of `DLLGetDocumentation` are:  
  
```  
STDAPI DLLGetDocumentation  
(  
   ITypeLib * /* ptlib */,  
   ITypeInfo * /* ptinfo */,  
   LCID /* lcid */,  
   DWORD dwCtx,  
   BSTR * pbstrHelpString  
);  
```  
  
 The `DLLGetDocumentation` function must be an export defined in the .def file for the DLL.  
  
 Internally, an .olb file is created which is actually a DLL. This DLL contains one resource, the type library (.tlb) file, and one exported function, `DLLGetDocumentation`.  
  
 In the case of .olb files, the `helpstringdll` attribute is optional because it is the same file that contains the .tlb file itself.  
  
 To get strings to show up in the **Descriptions** pane, therefore, the minimum you have to do is specify the `helpstring` attribute in the type library. If you want those strings to be localized, you have to specify the `helpstringdll` (optional) attribute and the `helpstringcontext` (required) attribute and implement `DLLGetDocumentation`.  
  
 There are no additional interfaces that need to be implemented when getting localized information through idl's `helpstringcontext` attribute and `DLLGetDocumentation`.  
  
 Another way of obtaining the localized name and description of a property is by implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.GetLocalizedPropertyInfo%2A>. For more information relating to the implementation of this method, see [Properties Window Fields and Interfaces](../extensibility/internals/properties-window-fields-and-interfaces.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing>   
 [Properties Window Fields and Interfaces](../extensibility/internals/properties-window-fields-and-interfaces.md)   
 [Extending Properties](../extensibility/internals/extending-properties.md)   
 [helpstringdll](https://msdn.microsoft.com/library/121271fa-f061-492b-b87f-bbfcf4b02e7b)   
 [helpstring](https://msdn.microsoft.com/library/0401e905-a63e-4fad-98d0-d1efea111966)   
 [helpstringcontext](https://msdn.microsoft.com/library/d4cd135e-d91c-4aa3-9353-8aeb096f52cf)   
 [helpcontext](https://msdn.microsoft.com/library/6fbb022d-a4b7-4989-a02f-7f18a9b0ad96)   
 [helpfile](https://msdn.microsoft.com/library/d75161c1-1363-4019-ae09-e7e3b8a3971e)   
 [lcid](https://msdn.microsoft.com/library/7f248c69-ee1c-42c3-9411-39cf27c9f43d)