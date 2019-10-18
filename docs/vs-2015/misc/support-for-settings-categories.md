---
title: "Support for Settings Categories | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "settings, supporting with Visual Studio SDK"
  - "Visual Studio SDK, supporting settings"
ms.assetid: 3bac375d-8bd5-41be-a8de-32eb33c5cfac
caps.latest.revision: 20
manager: jillfra
---
# Support for Settings Categories
A settings category consists of a group of options that customize the integrated development environment (IDE). For example, settings can control the layout of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] windows and the contents of menus. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 On the **Tools** menu click **Import and Export Settings** to start the **Import and Export Settings Wizard**. The wizard offers three choices: export, import, or reset your settings. Selecting export, for example, opens the **Choose Settings to Export** page of the wizard.  
  
 The tree control in the navigation pane of this page lists categories. A category is a group of related settings which appear as a "custom settings point", that is, as a check box. You use these check boxes to select the categories to persist in a .vsettings file. The wizard lets you name the .vsettings file and specify its path.  
  
> [!NOTE]
> Settings are saved or restored as a category, and individual setting names are not displayed in the wizard.  
  
 The managed package framework (MPF) supports creating settings categories with a minimum of additional code.  
  
- You create a VSPackage to provide a container for the category by subclassing the <xref:Microsoft.VisualStudio.Shell.Package> class.  
  
- You create the category itself by deriving it from the <xref:Microsoft.VisualStudio.Shell.DialogPage> class.  
  
- You connect the two with the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute>.  
  
## Support for Settings Categories  
 The <xref:Microsoft.VisualStudio.Shell.Package> class provides support for creating categories. The <xref:Microsoft.VisualStudio.Shell.DialogPage> class implements a category. The default implementation of <xref:Microsoft.VisualStudio.Shell.DialogPage> offers its public properties to a user as a category. For more information, see [Creating a Settings Category](../extensibility/creating-a-settings-category.md).  
  
 The <xref:Microsoft.VisualStudio.Shell.DialogPage> class implements <xref:Microsoft.VisualStudio.Shell.IProfileManager>, which provides persistence for both options pages and user settings. The <xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml%2A> and <xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml%2A> methods persist settings into a .vssettings file that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] provides as an <xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter>, respectively. The <xref:Microsoft.VisualStudio.Shell.IProfileManager.ResetSettings%2A> method resets settings to their default values.  
  
 The <xref:Microsoft.VisualStudio.Shell.DialogPage> class provides an implementation of the <xref:Microsoft.VisualStudio.Shell.DialogPage.LoadSettingsFromXml%2A> method that reads name-value pairs from the xml feed, and uses reflection to discover public properties in the <xref:Microsoft.VisualStudio.Shell.DialogPage> derived class. Properties that have names that match the name-value pairs are given the corresponding values.  
  
 The default implementation of <xref:Microsoft.VisualStudio.Shell.DialogPage.SaveSettingsToXml%2A> uses reflection to discover public properties in the <xref:Microsoft.VisualStudio.Shell.DialogPage> derived class and writes the property names and values to the XML feed as name-value pairs.  
  
### Settings Category Registry Path  
 The registry path of the settings category is determined by combining <xref:Microsoft.VisualStudio.Shell.Package.ApplicationRegistryRoot%2A>, the word, UserSettings, the settings category, and the name of the custom settings point. The names of the settings category and custom settings point are joined and separated by an underscore to form the canonical, non-localized name that appears in the registry. For example, if the settings category is "My Category", the custom settings point name "My Settings", and the ApplicationRegistryRoot HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp, then the settings category has the registry key, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\UserSettings\My Category_My Settings.  
  
> [!NOTE]
> The canonical name does not appear in a user interface (UI). It is used to associate a readable name with the settings category, much like a programmatic identifier (ProgID).  
  
### Settings Category Attribute  
 The <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> determines the mapping of categories to custom settings points in the **Import and Export Settings Wizard** by associating a category with the VSPackage that provides it. Consider the following code fragment:  
  
 [!code-csharp[VSSDKSupportForSettingsCategories#1](../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforsettingscategories/cs/vssdksupportforsettingscategoriespackage.cs#1)]
 [!code-vb[VSSDKSupportForSettingsCategories#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforsettingscategories/vb/vssdksupportforsettingscategoriespackage.vb#1)]  
  
 Resource ID 106 maps to "My Category", 107 to "My Settings", and 108 to "Various Options". This declares that `MyPackage` provides the category, My Category_My Settings. The category is provided by the `OptionsPageGeneral` class, which must implement <xref:Microsoft.VisualStudio.Shell.IProfileManager>. The settings in that category are the public properties of the `OptionsPageGeneral` class.  
  
 In the **Import and Export Settings Wizard**, the settings point has the name, My Settings. When the settings point is selected, the description, **Various Options**, appears. The settings point name and description are taken from localized string resources.  
  
## See also  
 [Creating an Options Page](../extensibility/creating-an-options-page.md)   
 [VSSDK Samples](../misc/vssdk-samples.md)   
 [VSPackage State](../misc/vspackage-state.md)   
 [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3)