---
title: Add custom properties to dependency diagrams
description: Learn how you can store values with any element on a dependency diagram when you write extension code for dependency diagrams.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- dependency diagrams, adding custom properties
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# Add custom properties to dependency diagrams

When you write extension code for dependency diagrams, you can store values with any element on a dependency diagram. The values will persist when the diagram is saved and re-opened. You can also have these properties appear in the **Properties** window so that users can see and edit them. For example, you could let users specify a regular expression for each layer, and write validation code to verify that the names of classes in each layer conform to the pattern specified by the user.

## Non-visible properties

If you just want your code to attach values to any element in a dependency diagram, you don't need to define a MEF component. There is a dictionary named `Properties` in [ILayerElement](/previous-versions/ff644511(v=vs.140)). Simply add marshalable values to the dictionary of any layer element. They will be saved as part of the dependency diagram.

## Editable properties

**Initial preparation**

> [!IMPORTANT]
> To make properties appear, make the following change on each computer where you want layer properties to be visible:
>
> 1. Run Notepad by using **Run as Administrator**. Open *%ProgramFiles%\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\ExtensibilityRuntime\extension.vsixmanifest*.
> 2. Inside the **Content** element, add:
>
>     ```xml
>     <MefComponent>Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.Provider.dll</MefComponent>
>     ```
>
> 3. Under the **Visual Studio Tools** section of the Visual Studio application start menu, open **Developer Command Prompt**. Enter:
>
>      `devenv /rootSuffix /updateConfiguration`
>
>      `devenv /rootSuffix Exp /updateConfiguration`
> 4. Restart Visual Studio.

**Make sure your code is in a VSIX project**

If your property is part of a command, gesture, or validation project, you don't need to add anything. The code for your custom property should be defined in a Visual Studio Extensibility project defined as a MEF component. For more information, see [Add commands and gestures to dependency diagrams](../modeling/add-commands-and-gestures-to-layer-diagrams.md) or [Add custom architecture validation to dependency diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md).

**Define the custom property**

To create a custom property, define a class like this:

```csharp
[Export(typeof(IPropertyExtension))]
public class MyProperty : PropertyExtension<ILayerElement>
{
  // Implement the interface.
}
```

You can define properties on [ILayerElement](/previous-versions/ff644511(v=vs.140)) or any of its derived classes, which include:

- `ILayerModel` - the model

- `ILayer` - each layer

- `ILayerDependencyLink` - the links between layers

- `ILayerComment`

- `ILayerCommentLink`

## Example

The following code is a typical custom property descriptor. It defines a Boolean property on the layer model (`ILayerModel`) that lets the user provide values for a custom validation method.

```csharp
using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer;

namespace MyNamespace
{
  /// <summary>
  /// Custom properties are added to the Layer Designer via a custom
  /// Property Descriptor. We have to export this Property Descriptor
  /// using MEF to make it available in the Layer Designer.
  /// </summary>
  [Export(typeof(IPropertyExtension))]
  public class AllTypesMustBeReferencedProperty
      : PropertyExtension<ILayerModel>
  {
    /// <summary>
    /// Each custom property must have a unique name.
    /// Usually we use the full name of this class.
    /// </summary>
    public static readonly string FullName =
      typeof(AllTypesMustBeReferencedProperty).FullName;

    /// <summary>
    /// Construct the property. Notice the use of FullName.
    /// </summary>
    public AllTypesMustBeReferencedProperty()
            : base(FullName)
    {  }

    /// <summary>
    /// The display name is shown in the Properties window.
    /// We therefore use a localizable resource.
    /// </summary>
    public override string DisplayName
    {
      get { return Strings.AllTypesMustBeReferencedDisplayName; }
    }

    /// <summary>
    /// Description shown at the bottom of the Properties window.
    /// We use a resource string for easier localization.
    /// </summary>
    public override string Description
    {
      get { return Strings.AllTypesMustBeReferencedDescription; }
    }

    /// <summary>
    /// This is called to set a new value for this property. We must
    /// throw an exception if the value is invalid.
    /// </summary>
    /// <param name="component">The target ILayerElement</param>
    /// <param name="value">The new value</param>
    public override void SetValue(object component, object value)
    {
      ValidateValue(value);
      base.SetValue(component, value);
    }
    /// <summary>
    /// Helper to validate the value.
    /// </summary>
    /// <param name="value">The value to validate</param>
    private static void ValidateValue(object value)
    {  }

    public override Type PropertyType
    { get { return typeof(bool); } }

    /// <summary>
    /// The segment label of the properties window.
    /// </summary>
    public override string Category
    {
      get
      {
        return Strings.AllTypesMustBeReferencedCategory;
      }
    }
  }
}
```

## See also

- [Extend dependency diagrams](../modeling/extend-layer-diagrams.md)
