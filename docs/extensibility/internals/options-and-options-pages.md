---
title: Options and Options Pages
description: Learn about support for options pages, which let you change the values of the options that determine the state of a VSPackage.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Tools Options pages [Visual Studio SDK], managed package framework support
- managed package framework, Tools Options pages support
- support, Tools Options pages
- Tools Options pages [Visual Studio SDK], layouts
- Tools Options pages [Visual Studio SDK], attributes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Options and Options Pages

Clicking **Options** on the **Tools** menu opens the **Options** dialog box. The options in this dialog box are collectively referred to as options pages. The tree control in the navigation pane includes options categories, and every category has options pages. When you select a page, its options appear in the right pane. These pages let you change the values of the options that determine the state of a VSPackage.

## Support for Options Pages
 The <xref:Microsoft.VisualStudio.Shell.Package> class provides support for creating options pages and options categories. The <xref:Microsoft.VisualStudio.Shell.DialogPage> class implements an options page.

 The default implementation of <xref:Microsoft.VisualStudio.Shell.DialogPage> offers its public properties to a user in a generic grid of properties. You can customize this behavior by overriding various methods on the page to create a custom options page that has its own user interface (UI). For more information, see [Creating an Options Page](../../extensibility/creating-an-options-page.md).

 The <xref:Microsoft.VisualStudio.Shell.DialogPage> class implements <xref:Microsoft.VisualStudio.Shell.IProfileManager>, which provides persistence for options pages and also for user settings. The default implementations of the <xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage%2A> and <xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToStorage%2A> methods persist property changes into a user section of the registry if the property can be converted to and from a string.

## Options Page Registry Path
 By default, the registry path of the properties managed by an options page is determined by combining <xref:Microsoft.VisualStudio.Shell.Package.UserRegistryRoot%2A>, the word DialogPage, and the type name of the options page class. For example, an options page class might be defined as follows.

 ### [C#](#tab/csharp)
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforoptionspages/cs/vssdksupportforoptionspagespackage.cs" id="Snippet1":::
 ### [VB](#tab/vb)
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforoptionspages/vb/vssdksupportforoptionspagespackage.vb" id="Snippet1":::
---

 If the <xref:Microsoft.VisualStudio.Shell.Package.UserRegistryRoot%2A> is HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0Exp, then the property name and value pairs are subkeys of HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0Exp\DialogPage\Company.OptionsPage.OptionsPageGeneral.

 The registry path of the options page itself is determined by combining <xref:Microsoft.VisualStudio.Shell.Package.ApplicationRegistryRoot%2A>, the word, ToolsOptionsPages, and the options page category and name. For example, if the Custom options page has the category, My Option Pages, and the <xref:Microsoft.VisualStudio.Shell.Package.ApplicationRegistryRoot%2A> is HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp, then the options page has the registry key, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\ToolsOptionsPages\My Option Pages\Custom.

## Tools/Options Page Attributes and Layout
 The <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> attribute determines the grouping of custom options pages into categories in the navigation tree of the **Options** dialog box. The <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> attribute associates an options page with the VSPackage that provides the interface. Consider the following code fragment:

### [C#](#tab/csharp)
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforoptionspages/cs/vssdksupportforoptionspagespackage.cs" id="Snippet2":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforoptionspages/vb/vssdksupportforoptionspagespackage.vb" id="Snippet2":::
 ---

 This declares that MyPackage provides two options pages, OptionsPageGeneral and OptionsPageCustom. In the **Options** dialog box, both options pages appear in the **My Option Pages** category as **General** and **Custom**, respectively.

## Option Attributes and Layout
 The user interface (UI) that the page provides determines the appearance of options in a custom options page. The layout, labeling, and description of options in a generic options page are determined by the following attributes:

- <xref:System.ComponentModel.CategoryAttribute> determines the category of the option.

- <xref:System.ComponentModel.DisplayNameAttribute> determines the display name of the option.

- <xref:System.ComponentModel.DescriptionAttribute> determines the description of the option.

  > [!NOTE]
  > Equivalent attributes, SRCategory, LocDisplayName, and SRDescription, use string resources for localization and are defined in the [managed project sample](/azure/devops/integrate/index).

  Consider the following code fragment:

  ### [C#](#tab/csharp)
  :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforoptionspages/cs/optionspagecustom.cs" id="Snippet3":::

  ### [VB](#tab/vb)
  :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforoptionspages/vb/optionspagegeneral.vb" id="Snippet3":::
  ---

  The OptionInteger option appears on the options page as **Integer Option** in the **My Options** category. If the option is selected, the description, **My integer option**, appears in the description box.

## Accessing Options Pages from Another VSPackage
 A VSPackage that hosts and manages an options page can be programmatically accessed from another VSPackage by using the automation model. For example, in the following code a VSPackage is registered as hosting an option page.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforoptionspages/cs/vssdksupportforoptionspagespackage.cs" id="Snippet4":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforoptionspages/vb/vssdksupportforoptionspagespackage.vb" id="Snippet4":::
 ---

 The following code fragment gets the value of OptionInteger from MyOptionPage:

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdksupportforoptionspages/cs/vssdksupportforoptionspagespackage.cs" id="Snippet5":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdksupportforoptionspages/vb/vssdksupportforoptionspagespackage.vb" id="Snippet5":::
 ---

 When the <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> attribute registers an options page, the page is registered under the AutomationProperties key if the `SupportsAutomation` argument of the attribute is `true`. Automation examines this registry entry to find the associated VSPackage, and automation then accesses the property through the hosted options page, in this case, My Grid Page.

 The registry path of the automation property is determined by combining <xref:Microsoft.VisualStudio.Shell.Package.ApplicationRegistryRoot%2A>, the word, AutomationProperties, and the options page category and name. For example, if the options page has the My Category category, the My Grid Page name, and the <xref:Microsoft.VisualStudio.Shell.Package.ApplicationRegistryRoot%2A>, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp, then the automation property has the registry key, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\AutomationProperties\My Category\My Grid Page.

> [!NOTE]
> The canonical name, My Category.My Grid Page, is the value of the Name subkey of this key.
