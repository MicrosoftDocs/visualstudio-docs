---
title: Contributions and configurations
description: Learn how to expose extensions components to Visual Studio and how to configure them.
ms.date: 3/31/2023
ms.topic: how-to
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Contributions and Configurations

You can expose extensions components to Visual Studio by deriving from certain base classes, and you can configure them by defining certain properties and using various attributes.

## Visual Studio Contributions

The purpose of a Visual Studio extension is to *contribute* new features to Visual Studio. This is achieved by extending one of many classes like [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command), [`ToolWindow`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindow), or [`ExtensionPart`](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart) and applying the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute.

This article references the [Command Parenting](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandParentingSample) sample extension to explain the concepts of contributing and configuring extension components.

Every VisualStudio.Extensibility extension must contribute at least one [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) class:

```csharp
namespace CommandParentingSample;

[VisualStudioContribution]
public class CommandParentingSampleExtension : Extension
{
    /// <inheritdoc/>
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);
    }
}
```

The [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) class is the first instantiated class of the extension and allows you to add your own services to the `IServiceCollection` to be used for [dependency injection](./dependency-injection.md).

The Command Parenting sample contributes another class, a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command), to Visual Studio:

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
    public SampleCommand()
    {
    }
    ...
```

When extending a base class provided by the VisualStudio.Extensibility SDK, you can know if you're expected to use the `VisualStudioContribution` attribute by checking whether the base class implements [`IVisualStudioContributionClass`](/dotnet/api/microsoft.visualstudio.extensibility.ivisualstudiocontributionclass) (both `Extension` and `Command` do).

Visual Studio contribution classes are lazily instantiated singletons: only one instance is created and its creation is delayed until Visual Studio needs to interact with it (for example when a `Command` is first invoked by the user).

The VisualStudio.Extensibility infrastructure also allows you to receive services through dependency injection as constructor parameters of Visual Studio contribution classes (see [Dependency injection in VisualStudio.Extensibility extensions](./dependency-injection.md)), including any service that you added to the `IServiceCollection` in the `Extension` class' `InitializeServices` method.

Visual Studio often requires a unique identifier to be associated with contributions. In most cases, the VisualStudio.Extensibility infrastructure uses the full name of the Visual Studio contribution class as the contribution identifier. For example, the identifier of the `Extension` class above would be `CommandParentingSample.CommandParentingSampleExtension`. You might want to carefully choose the type name and namespace of your Visual Studio contribution classes, since they might appear in Visual Studio logs and error messages.

## Configuring Visual Studio Contributions

Most Visual Studio contribution classes require or allow configuration. For example, the [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) abstract class requires the implementation of a [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) property specifying at least the command's display name and, optionally, other properties like its placement.

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%CommandParentingSample.SampleCommand.DisplayName%")
    {
        Placements = new[]
        {
            // File in project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 1072, priority: 0),

            // Project context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id:  1026, priority: 0),

            // Solution context menu
            CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id:  1043, priority: 0),
        },
    };
    ...
```

[`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) is a *compile-time constant*, which means that its value is evaluated when the extension is built and it is included in the extension manifest (`extension.json`). Visual Studio can read the extension manifest without loading the extension itself, which allows for better performance.

*Compile-time constants* are subject to additional limitations compared to normal properties, for example they must be readonly and their initialization code can't include references to non-static members or multi-statement imperative code blocks. These restrictions are enforced by the VisualStudio.Extensibility build tools and results in error messages like the following:

> An issue was encountered when evaluating the compile-time constant SampleCommand.CommandConfiguration. References to user-defined non-static members are not supported when evaluating compile-time constant values.

In general, the extension shouldn't reference *compile-time constant* configuration properties at run time.

You can easily identify *Compile-time constant* configuration properties since their definition has the [`CompileTimeEvaluation`](/dotnet/api/microsoft.visualstudio.extensibility.compiletimeevaluationattribute) attribute.

```csharp
public abstract class Command : ExecutableCommandHandler, IVisualStudioContributionClass
{
    ...
    /// <summary>
    /// Gets the configuration for this command. The value of this property is evaluated at compile time
    /// when building the Visual Studio extension.
    /// </summary>
    [CompileTimeEvaluation]
    public abstract CommandConfiguration CommandConfiguration { get; }
    ...
```

On rare occasions, configuration properties may be optional. In certain cases, you may need to implement multiple configuration properties on the same class. This is common when extending [`ExtensionPart`](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart) and implementing multiple interfaces, each one requiring its own configuration property.

## Standalone configuration properties

As described above, Visual Studio contribution classes define a singleton class that usually exposes one or more *compile-time constant* configuration properties. The configuration properties values are saved as extension metadata.

Some extensibility features require you to specify extension metadata that isn't tied to any class and it's either meaningful on its own or it's meant to be referenced by other configurations. A few examples are menu, toolbar and document type definitions. This is achieved by applying the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute to a static readonly configuration property.

Visual Studio contribution properties can be placed in any class.

The [Command Parenting](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandParentingSample/ExtensionCommandConfiguration.cs) sample defines a toolbar by declaring a static property of type [`ToolbarConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.toolbarconfiguration) and marking it as [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute).

```csharp
namespace CommandParentingSample;

internal static class ExtensionCommandConfiguration
{
    [VisualStudioContribution]
    public static ToolbarConfiguration ToolBar => new("%CommandParentingSample.ToolBar.DisplayName%")
    {
        Children = new[]
        {
            ToolbarChild.Command<SampleCommand>(),
        },
    };
}
```

Visual Studio contribution properties are also *compile-time constants* and are subject to the same limitations discussed earlier.

A Visual Studio contribution property can also reference another configuration property. For example:

```csharp
public static class MenuConfigurations
{
    [VisualStudioContribution]
    public static CommandGroupConfiguration MyCommandGroup => new(GroupPlacement.KnownPlacements.ExtensionsMenu)
    {
        Children = new GroupChild[]
        {
            GroupChild.Menu(MyMenu),
        },
    };

    [VisualStudioContribution]
    public static MenuConfiguration MyMenu => new("%MyMenu.DisplayName%")
    {
        Children = new[]
        {
            MenuChild.Command<MyCommand>(),
        },
    };
    ...
```

Types that are meant to be used to define Visual Studio contribution properties implement the [`IVisualStudioContributionProperty`](/dotnet/api/microsoft.visualstudio.extensibility.ivisualstudiocontributionproperty) interface and are marked with the [`CompileTimeEvaluation`](/dotnet/api/microsoft.visualstudio.extensibility.compiletimeevaluationattribute) attribute to document that their values are evaluated when the extension is built.

```csharp
[CompileTimeEvaluation]
public sealed class DocumentTypeConfiguration : IVisualStudioContributionProperty ...
```

The guidance about not referencing *compile-time constant* configuration properties at run time applies to Visual Studio contribution properties as well.

In case a unique identifier is required for a Visual Studio contribution property, its full name (containing type full name and property name) is used by the VisualStudio.Extensibility infrastructure as an identifier. For example, the unique identifier of the toolbar configuration discussed here would be `CommandParentingSample.ExtensionCommandConfiguration.ToolbarConfiguration`.

## Related content

- [Components of a VisualStudio.Extensibility extension](./extension-anatomy.md).
