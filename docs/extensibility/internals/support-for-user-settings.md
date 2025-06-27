---
title: Support for User Settings
description: Learn how to enable persistence of settings categories by using the settings APIs in the Visual Studio SDK.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Custom Settings Points
- user settings [Visual Studio SDK], registering persistence support
- persistence, registering settings
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Support for User Settings

A VSPackage may define one or more settings categories, which are groups of state variables that persist when a user chooses the **Import/Export Settings** command on the **Tools** menu. To enable this persistence, you use the settings APIs in the Visual Studio SDK.

 A registry entry that is referred to as a Custom Settings Point and a GUID defines a VSPackage's settings category. A VSPackage can support multiple settings categories, each defined by a Custom Settings Point.

- Implementations of settings that are based on interop assemblies (using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings> interface) should create Custom Settings Point by either editing the registry or using a Registrar script (.rgs file). For more information, see [Creating Registrar Scripts](/cpp/atl/creating-registrar-scripts).

- Code that uses the Managed Package Framework (MPF) should create Custom Settings Points by attaching a <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> to the VSPackage for each Custom Settings Point.

     If a single VSPackage supports several Custom Settings Points, each Custom Settings Point is implemented by a separate class, and each is registered by a unique instance of the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> class. Consequently, a settings implementing class can support more than one settings category.

## Custom Settings Point Registry Entry Details
 Custom Settings Points are created in a registry entry in the following location: HKLM\Software\Microsoft\VisualStudio\\*\<Version>*\UserSettings\\`<CSPName>`, where `<CSPName>` is the name of the Custom Settings Point the VSPackage supports and *\<Version>* is the version of Visual Studio, for example 8.0.

> [!NOTE]
> The root path of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>* can be overridden with an alternate root when the Visual Studio integrated development environment (IDE) is initialized. For more information, see [Command-Line Switches](/previous-versions/visualstudio/visual-studio-2017/extensibility/command-line-switches-visual-studio-sdk).

 The structure of the registry entry is illustrated below:

 HKLM\Software\Microsoft\VisualStudio\\*\<Version>*\UserSettings\

 `<CSPName`>= s '#12345'

 Package = '{XXXXXX XXXX XXXX XXXX XXXXXXXXX}'

 Category = '{YYYYYY YYYY YYYY YYYY YYYYYYYYY}'

 ResourcePackage = '{ZZZZZZ ZZZZ ZZZZ ZZZZ ZZZZZZZZZ}'

 AlternateParent = CategoryName

| Name | Type | Data | Description |
|-----------------|--------| - | - |
| (Default) | REG_SZ | Name of the Custom Settings Point | The key's name, `<CSPName`>, is the unlocalized name of the Custom Settings Point.<br /><br /> For implementations based on MPF, the key's name is obtained by combining the `categoryName` and `objectName` arguments of the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> constructor into `categoryName_objectName`.<br /><br /> The key can be empty, or it can contain the reference ID to the localized string in a satellite DLL. This value is obtained from the `objectNameResourceID` argument to the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> constructor. |
| Package | REG_SZ | GUID | The GUID of the VSPackage that implements the Custom Settings Point.<br /><br /> Implementations based on MPF using the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> class, use the constructor's `objectType` argument containing the VSPackage's <xref:System.Type> and reflection to obtain this value. |
| Category | REG_SZ | GUID | GUID identifying the settings category.<br /><br /> For implementations based on interop assemblies, this value can be an arbitrarily chosen GUID, which the Visual Studio IDE passes to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ExportSettings%2A> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings%2A> methods. All implementations of these two methods should verify their GUID arguments.<br /><br /> For implementations based on MPF, this GUID is obtained by the <xref:System.Type> of the class implementing the Visual Studio settings mechanism. |
| ResourcePackage | REG_SZ | GUID | Optional.<br /><br /> Path to satellite DLL containing localized strings if the implementing VSPackage does not supply them.<br /><br /> MPF uses reflection to obtain the correct resource VSPackage, so the <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> class does not set this argument. |
| AlternateParent | REG_SZ | Name of the folder under the Tools Options page containing this Custom Settings Point. | Optional.<br /><br /> You must set this value only if a settings implementation supports **Tools Options** pages that use the persistence mechanism in the Visual Studio SDK rather than the mechanism in the automation model to save state.<br /><br /> In these cases, the value in the AlternateParent key is the `topic` section of the `topic.sub-topic` string used to identify the particular **ToolsOptions** page. For example, for the **ToolsOptions** page `"TextEditor.Basic"` the value of AlternateParent would be `"TextEditor"`.<br /><br /> When <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> generates the Custom Settings Point, it is the same as the category name. |
