---
title: Designer Initialization and Metadata Configuration
description: Learn how the Visual Studio SDK facilitates the control of a designer's or designer component's initialization and its metadata by a VSPackage.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- designers [Visual Studio SDK], initializing
- designers [Visual Studio SDK], configuring metadata
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Designer initialization and metadata configuration

Manipulation of the metadata and filter attributes associated with a designer or designer component provides a mechanism for applications to define which tools are used by a particular designer to handle different <xref:System.Type> objects (such as data structures, classes, or graphical entities), when the designer is available, and how the Visual Studio IDE is configured to support the designer (for instance which **Toolbox** category or tab is available).

The Visual Studio SDK provides several mechanisms to facilitate the control of a designer's or designer component's initialization and the manipulation of its metadata by a VSPackage.

## Initialize metadata and configuration information
 Because they are loaded on demand, VSPackages may not have been loaded by the Visual Studio environment prior to the instantiation of a designer. Therefore, VSPackages cannot use the standard mechanism for configuring a designer or designer component on creation, which is to handle a <xref:System.ComponentModel.Design.IDesignerEventService.DesignerCreated> event. Instead, a VSPackage implements an instance of the <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> interface and  registers itself to provide customizations, referred to as design surface extensions.

### Customize initialization

Customizing a designer, a component, or a designer surface, involves:

1. Modifying the designer metadata and effectively changing how a certain <xref:System.Type> is accessed or converted.

    This is typically done through the <xref:System.Drawing.Design.UITypeEditor> or <xref:System.ComponentModel.TypeConverter> mechanisms.

    For example, when <xref:System.Windows.Forms>-based designers are initialized, the Visual Studio environment modifies the <xref:System.Drawing.Design.UITypeEditor> for <xref:System.Web.UI.WebControls.Image> objects used with the designer to use the resource manager to obtain bitmaps rather than the file system.

2. Integrating with the environment, for example, by subscribing to events or obtaining project configuration information. You can obtain project configuration information and subscribe to events by obtaining the <xref:System.ComponentModel.Design.ITypeResolutionService> interface.

3. Modification of the user environment by activating appropriate **Toolbox** categories or by restricting the designer's applicability by applying an instance of the <xref:System.ComponentModel.ToolboxItemFilterAttribute> class to the designer.

### Designer initialization by a VSPackage

A VSPackage should handle designer initialization by:

1. Creating an object implementing the <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> class.

   > [!NOTE]
   > The <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> class should never be implemented on the same object as the <xref:Microsoft.VisualStudio.Shell.Package> class.

2. Registering the class that implements <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> as providing support for the VSPackage's designer extensions. Register the class by applying instances of  <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtensionAttribute>, <xref:Microsoft.VisualStudio.Shell.ProvideObjectAttribute>, and <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> to the class that provides the VSPackage's implementation of <xref:Microsoft.VisualStudio.Shell.Package>.

Whenever a designer or designer component is created, the Visual Studio environment:

- Accesses each registered design surface extension provider.

- Instantiates and initializes an instance of each design surface extension provider's <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> object.

- Calls each design surface extension provider's <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension.OnDesignerCreated%2A> method or <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension.OnComponentCreated%2A> method (as appropriate).

When implementing the <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> object as a member of a VSPackage, it is important to understand that:

- The Visual Studio environment does not provide any control over what metadata or other configuration settings a particular `DesignSurfaceExtension` provider's modifies. It is possible for two or more `DesignSurfaceExtension` providers modifying the same designer feature in conflicting ways, with the final modification being definitive. It is indeterminate which modification is last applied.

- It's possible to explicitly restrict an implementation of the <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension> object to specific designers by applying instances of <xref:System.ComponentModel.ToolboxItemFilterAttribute> to that implementation. For more information on **Toolbox** item filtering, see the <xref:System.ComponentModel.ToolboxItemFilterAttribute> and <xref:System.ComponentModel.ToolboxItemFilterType>.

## Additional metadata provisioning

A VSPackage can change the configuration of a designer or designer component other than at design time.

The <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute> class can be used programmatically or applied to a VSPackage that provides a designer.

An instance of the <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute> class is used to modify the metadata of components created on a design surface. For example, one could replace a default property browser used by <xref:System.Windows.Forms.CommonDialog> objects with a custom property browser.

Modifications provided by an instance of <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute> applied to a VSPackage's implementation of <xref:Microsoft.VisualStudio.Shell.Package> can have one of two scopes:

- Global -- for all new instances of a given component

- Local -- pertaining only to instance of the component created on a design surface provided by the current VSPackage.

The `IsGlobal` property of the <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute> instance applied to a VSPackage's implementation of <xref:Microsoft.VisualStudio.Shell.Package> determines this scope.

Applying the attribute to an implementation of <xref:Microsoft.VisualStudio.Shell.Package> with the <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute.IsGlobal%2A> property of the <xref:Microsoft.VisualStudio.Shell.Design.ProvideDesignerMetadataAttribute> object set to `true`, as below, changes the browser for the entire Visual Studio environment:

`[ProvideDesignerMetadata(typeof(Color), typeof(CustomBrowser),`   `IsGlobal=true`  `)]`

`internal class MyPackage : Package {}`

If the global flag was set to `false`, then the metadata change is local to the current designer supported by the current VSPackage:

`[ProvideDesignerMetadata(typeof(Color), typeof(CustomBrowser),`   `IsGlobal=false`  `)]`

`internal class MyPackage : Package {}`

> [!NOTE]
> The design surface only supports creating components, and therefore only components can have local metadata. In the example above, we were attempting to modify a property, such as the `Color` property of an object. If `false` was passed in for the global flag, `CustomBrowser` would never appear because the designer never actually creates an instance of `Color`. Setting the global flag to `false` is useful for components, such as controls, timers, and dialog boxes.

## Related content

- <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtension>
- <xref:Microsoft.VisualStudio.Shell.Design.DesignSurfaceExtensionAttribute>
- <xref:System.ComponentModel.ToolboxItemFilterType>
- [Extend design-time support](/previous-versions/37899azc(v=vs.140))