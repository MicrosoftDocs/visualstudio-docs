---
title: Creating Options Pages
description: Learn how to create an Options page under the Tools menu in Visual Studio by implementing a DialogPage class from the managed package framework.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- managed package framework, creating Tools Options pages
- Tools Options pages [Visual Studio SDK], creating using managed package framework
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create options pages

In the Visual Studio managed package framework, classes derived from <xref:Microsoft.VisualStudio.Shell.DialogPage> extend the Visual Studio IDE by adding **Options** pages under the **Tools** menu.

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
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/cs/class1.cs" id="Snippet11":::
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/vb/class1.vb" id="Snippet11":::

### Description
 Applying the following attribute to the package class makes the options page available when the package loads. The numbers are arbitrary resource IDs for the category and the page, and the Boolean value at the end specifies whether the page supports automation.

### Code
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/cs/uiusersettingstoolsoptionspagespackage.cs" id="Snippet07":::
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/vb/uiusersettingstoolsoptionspagespackage.vb" id="Snippet07":::

### Description
 The following event handler displays a result depending on the value of the property set in the options page. It uses the <xref:Microsoft.VisualStudio.Shell.Package.GetDialogPage%2A> method with the result explicitly cast into the custom option page type to access the properties exposed by the page.

 In the case of a project generated by the package template, call this function from the `MenuItemCallback` function to attach it to the default command added to the **Tools** menu.

### Code
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/cs/uiusersettingstoolsoptionspagespackage.cs" id="Snippet08":::
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/ui_usersettings_toolsoptionpages/vb/uiusersettingstoolsoptionspagespackage.vb" id="Snippet08":::

## Related content
- [Extend user settings and options](../../extensibility/extending-user-settings-and-options.md)
- [Automation support for options pages](../../extensibility/internals/automation-support-for-options-pages.md)
