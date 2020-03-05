---
title: "Creating Options Pages | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "managed package framework, creating Tools Options pages"
  - "Tools Options pages [Visual Studio SDK], creating using managed package framework"
ms.assetid: 1bf11fec-dece-4943-8053-6de1483c43eb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Create options pages
In the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] managed package framework, classes derived from <xref:Microsoft.VisualStudio.Shell.DialogPage> extend the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE by adding **Options** pages under the **Tools** menu.

 An object implementing a given **Tools Option** page is associated with specific VSPackages by the <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> object.

 Because the environment instantiates the object implementing a particular **Tools Options** page when that particular page is displayed by the IDE:

- A **Tools Option** page should be implemented on its own object, and not on the object implementing a VSPackage.

- An object cannot implement multiple **Tools Options** pages.

## Register as a Tools Options page provider
 A VSPackage supporting user configuration through **Tools Options** pages indicates the objects providing these **Tools Options** pages by applying instances of <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> applied to the <xref:Microsoft.VisualStudio.Shell.Package> implementation.

 There must be one instance of <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> for every <xref:Microsoft.VisualStudio.Shell.DialogPage>-derived type that implements a **Tools Options** page.

 Each instance of <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> uses the type that implements the **Tools Options** page, strings that contain the category and sub-category used to identify a **Tools Options** page, and resource information to register the type as providing a **Tools Options** page.

## Persist Tools Options page state
 If a **Tools Options** page implementation is registered with automation support enabled, the IDE persists the page's state along with all other **Tools Options** pages.

 A VSPackage can manage its own persistence by using <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute>. Only one or the other method of persistence should be used.

## Implement DialogPage class
 An object providing a VSPackage's implementation of a <xref:Microsoft.VisualStudio.Shell.DialogPage>-derived type can take advantage of the following inherited features:

- A default user interface window.

- A default persistence mechanism available either if <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute> is applied to the class, or if the <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute.SupportsProfiles%2A> property is set to `true` for the <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> that is applied to the class.

- Automation support.

  The minimum requirement for an object implementing a **Tools Options** page using <xref:Microsoft.VisualStudio.Shell.DialogPage> is the addition of public properties.

  If the class properly registered as a **Tools Options** page provider, then its public properties are available on the **Options** section of the **Tools** menu in the form of a property grid.

  All these default features can be overridden. For example, to create a more sophisticated user interface requires only overriding the default implementation of <xref:Microsoft.VisualStudio.Shell.DialogPage.Window%2A>.

## Example
 What follows is a simple "Hello world" implementation of an options page. Adding the following code to a default project created by the Visual Studio package template with the **Menu Command** option selected will adequately demonstrate option page functionality.

### Description
 The following class defines a minimal "Hello world" options page. When opened, the user can set the public `HelloWorld` property in a property grid.

### Code
 [!code-csharp[UI_UserSettings_ToolsOptionPages#11](../../extensibility/internals/codesnippet/CSharp/creating-options-pages_1.cs)]
 [!code-vb[UI_UserSettings_ToolsOptionPages#11](../../extensibility/internals/codesnippet/VisualBasic/creating-options-pages_1.vb)]

### Description
 Applying the following attribute to the package class makes the options page available when the package loads. The numbers are arbitrary resource IDs for the category and the page, and the Boolean value at the end specifies whether the page supports automation.

### Code
 [!code-csharp[UI_UserSettings_ToolsOptionPages#07](../../extensibility/internals/codesnippet/CSharp/creating-options-pages_2.cs)]
 [!code-vb[UI_UserSettings_ToolsOptionPages#07](../../extensibility/internals/codesnippet/VisualBasic/creating-options-pages_2.vb)]

### Description
 The following event handler displays a result depending on the value of the property set in the options page. It uses the <xref:Microsoft.VisualStudio.Shell.Package.GetDialogPage%2A> method with the result explicitly cast into the custom option page type to access the properties exposed by the page.

 In the case of a project generated by the package template, call this function from the `MenuItemCallback` function to attach it to the default command added to the **Tools** menu.

### Code
 [!code-csharp[UI_UserSettings_ToolsOptionPages#08](../../extensibility/internals/codesnippet/CSharp/creating-options-pages_3.cs)]
 [!code-vb[UI_UserSettings_ToolsOptionPages#08](../../extensibility/internals/codesnippet/VisualBasic/creating-options-pages_3.vb)]

## See also
- [Extend user settings and options](../../extensibility/extending-user-settings-and-options.md)
- [Automation support for options pages](../../extensibility/internals/automation-support-for-options-pages.md)