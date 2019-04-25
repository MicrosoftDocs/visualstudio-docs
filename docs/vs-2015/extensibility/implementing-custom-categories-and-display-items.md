---
title: "Implementing Custom Categories and Display Items | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "font and color control [Visual Studio SDK], categories"
  - "custom categories"
ms.assetid: 99311a93-d642-4344-bbf9-ff6e7fa5bf7f
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# Implementing Custom Categories and Display Items
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A VSPackage can provide control of the fonts and colors of its text to the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE) through custom categories and display items.  
  
 Custom categories and display items are on the **Fonts and Colors** property page. To open the **Fonts and Colors** property page, on the **Tools** menu, click **Options**. Expand **Environment** and then click **Fonts and Colors**.  
  
 When using this mechanism, VSPackages must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider> interface and its associated interfaces.  
  
 In principle, this mechanism can be used to modify all existing **Display items** and the **Categories** that contain them. However, it should not be used to modify the **Text EditorCategory** or its **Display items**. For more information, see [Font and Color Overview](../extensibility/font-and-color-overview.md).  
  
 To implement custom **Categories** or **Display items**, a VSPackage must:  
  
- Create or identify categories in the registry.  
  
   The IDE's implementation of the **Fonts and Colors** property page uses this information to correctly query for the service supporting a given category.  
  
- Create or identify groups (optional) in the registry.  
  
   It may be useful to define a group, which represents the union of two or more categories. If a group is defined, the IDE automatically merges subcategories and distributes display items within the group.  
  
- Implement IDE support.  
  
- Handle font and color changes.  
  
  For information, see [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md).  
  
## To create or identify categories  
  
- Construct a special type of category registry entry under [HKLM\SOFTWARE\Microsoft \Visual Studio\\*\<Visual Studio version>*\FontAndColors\\`<Category>`]  
  
   *\<Category>* is the non-localized name of the category.  
  
- Populate the registry with two values:  
  
  |Name|Type|Data|Description|  
  |----------|----------|----------|-----------------|  
  |Category|REG_SZ|GUID|A GUID created to identify the category.|  
  |Package|REG_SZ|GUID|The GUID of the VSPackage service that supports the category.|  
  
  The service specified in the registry must provide an implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults> for the corresponding category.  
  
## To Create or Identify Groups  
  
- Construct a special type of category registry entry under [HKLM\SOFTWARE\Microsoft \Visual Studio\\*\<Visual Studio version>*\FontAndColors\\*\<group>*]  
  
   *\<group>* is the non-localized name of the group.  
  
- Populate the registry with two values:  
  
  |Name|Type|Data|Description|  
  |----------|----------|----------|-----------------|  
  |Category|REG_SZ|GUID|A GUID created to identify the group.|  
  |Package|REG_SZ|GUID|The GUID of the service that supports the category.|  
  
  The service specified in the registry must provide an implementation of `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup` for the corresponding group.  
  
## To Implement IDE Support  
  
- Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider.GetObject%2A>, which returns either an <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults> interface or an `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup` interface to the IDE for each **Category** or group GUID supplied.  
  
- For every **Category** it supports, a VSPackage implements a separate instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults> interface.  
  
- The methods implemented through <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults> must provide the IDE with:  
  
  - Lists of **Display items** in the **Category.**  
  
  - Localizable names for **Display items**.  
  
  - Display information for each member of **Category**.  
  
  > [!NOTE]
  > Every **Category** must contain at least one **Display item**.  
  
- The IDE uses the `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup` interface to define a union of several categories.  
  
   Its implementation provides the IDE with:  
  
  - A list of the **Categories** that comprise a given group.  
  
  - Access to instances of <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults> supporting each **Category** within the group.  
  
  - Localizable group names.  
  
- Updating the IDE:  
  
   The IDE caches information about **Font and Color** settings. Therefore, after any modification of the IDE **Font and Color** configuration, it is advisable to make sure that the cache is up-to-date.  
  
  Updating the cache is done through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager> interface and can be performed globally or just on selected items.  
  
## To Handle Font and Color Changes  
 To properly support the colorization of text that a VSPackage displays, the colorization service supporting the VSPackage must respond to the user-initiated changes made through the **Fonts and Colors** properties page. A VSPackage does this by:  
  
- Handling IDE-generated events by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents> interface.  
  
     The IDE calls the appropriate method following user modifications of the **Fonts and Colors** page. For example, it calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents.OnFontChanged%2A> method if a new font is selected.  
  
     -or-  
  
- Polling the IDE for changes.  
  
     This can be done through the system-implemented <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage> interface. Although primarily for support of persistence, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetItem%2A> method can be used to obtain font and color information for **Display items**. For more information, see [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md).  
  
    > [!NOTE]
    > To ensure that the results obtained by polling are correct, it may be useful to use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager> interface to determine if a cache flush and update are needed prior to calling the retrieval methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage> interface.  
  
## See Also  
 <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorGroup>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaultsProvider>   
 [Getting Font and Color Information for Text Colorization](../extensibility/getting-font-and-color-information-for-text-colorization.md)   
 [Accessing Stored Font and Color Settings](../extensibility/accessing-stored-font-and-color-settings.md)   
 [How to: Access the Built-in Fonts and Color Scheme](../extensibility/how-to-access-the-built-in-fonts-and-color-scheme.md)   
 [Font and Color Overview](../extensibility/font-and-color-overview.md)
