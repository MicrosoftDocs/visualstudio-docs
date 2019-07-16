---
title: "How to: Create Custom Text Markers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - custom text markers"
ms.assetid: 6e32ed81-c604-4a32-9012-8db3bec7c846
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# How to: Create Custom Text Markers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you want to create a custom text marker to emphasize or organize code, you must take the following steps:  
  
- Register the new text marker, so that other tools can access it  
  
- Provide a default implementation and configuration of the text marker  
  
- Create a service which can be used by other processes to make use of the text marker  
  
  For details on how to apply a text marker to a region of code, see [How to: Use Text Markers](../extensibility/how-to-use-text-markers.md).  
  
### To register a custom marker  
  
1. Create a registry entry as follows:  
  
    HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>*\Text Editor\External Markers\\*\<MarkerGUID>*  
  
    <em>\<MarkerGUID></em>is a `GUID` used to identify the marker being added  
  
    *\<Version>* is the version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], for example 8.0  
  
    *\<PackageGUID>* is the GUID of the VSPackage implementing the automation object.  
  
   > [!NOTE]
   > The root path of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>* can be overridden with an alternate root when the Visual Studio shell is initialized, for more information see, [Command-Line Switches](../extensibility/command-line-switches-visual-studio-sdk.md).  
  
2. Create four values under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>*\Text Editor\External Markers\\*\<MarkerGUID>*  
  
   - (Default)  
  
   - Service  
  
   - DisplayName  
  
   - Package  
  
   - `Default` is an optional entry of type REG_SZ. When set, the value of the entry is a string containing some useful identifying information, for example "Custom Text Marker".  
  
   - `Service` is an entry of type REG_SZ containing the GUID string of the service that provides the custom text marker by proffering <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerTypeProvider>. The format is {XXXXXX XXXX XXXX XXXX XXXXXXXXX}.  
  
   - `DisplayName` is an entry of type REG_SZ containing the resource ID of the name of the custom text marker. The format is #YYYY.  
  
   - `Package` is entry of type REG_SZ containing the `GUID` of VSPackage that provides the service listed under Service. The format is {XXXXXX XXXX XXXX XXXX XXXXXXXXX}.  
  
### To create a custom text marker  
  
1. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsPackageDefinedTextMarkerType> interface.  
  
     Your implementation of this interface defines the behavior and appearance of your custom marker type.  
  
     This interface is called when  
  
    1. A user starts the IDE for the first time.  
  
    2. A user selects the **Reset Defaults** button under the **Fonts and Colors** property page in the **Environment** folder, located on the left pane of the **Options** dialog box obtained from the **Tools** menu of the IDE.  
  
2. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerTypeProvider.GetTextMarkerType%2A> method, specifying which `IVsPackageDefinedTextMarkerType` implementation should be returned based on the marker type GUID specified in the method call.  
  
     The environment calls this method the first time your custom marker type is created, and specifies a GUID identifying the custom marker type.  
  
### To proffer your marker type as a service  
  
1. Call the <xref:Microsoft.VisualStudio.OLE.Interop.IOleComponentManager.QueryService%2A> method for <xref:Microsoft.VisualStudio.Shell.Interop.SProfferService>.  
  
     A pointer to <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService> is returned.  
  
2. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService.ProfferService%2A> method, specifying the GUID identifying your custom marker type service and providing a pointer to your implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> interface. Your <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> implementation should return a pointer to your implementation of <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerTypeProvider> interface.  
  
     A unique cookie identifying that your service is returned. You can later use this cookie to revoke your custom marker type service by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService.RevokeService%2A> method of the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService> interface specifying this cookie value.  
  
## See Also  
 [Using Text Markers with the Legacy API](../extensibility/using-text-markers-with-the-legacy-api.md)   
 [How to: Add Standard Text Markers](../extensibility/how-to-add-standard-text-markers.md)   
 [How to: Implement Error Markers](../extensibility/how-to-implement-error-markers.md)   
 [How to: Use Text Markers](../extensibility/how-to-use-text-markers.md)
