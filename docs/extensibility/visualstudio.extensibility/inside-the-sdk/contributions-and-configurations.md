---
title: Contributions and Configurations
description: How to expose extensions components to Visual Studio and how to configure them
ms.date: 3/31/2023
ms.author: maiak
author: maiak
manager: jmartens
ms.technology: vs-ide-sdk
---

# Contributions and Configurations

## Visual Studio Contributions

The purpose of a Visual Studio extension is to *contribute* new features to Visual Studio. This is achieved by extending one of many classes like `Command`, `ToolWindow` or `ExtensionPart` and applying the `VisualStudioContribution` attribute.

Across this document we will refer to the [Command Parenting](../../../New_Extensibility_Model/Samples/CommandParentingSample) sample extension to explain the concepts of contributing and configuring extension components.

Every VisualStudio.Extensibility extension must contribute at least one `Extension` class:

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

The `Extension` class is the first instantiated class of the extension and allows you to add your own services to the `IServiceCollection` to be used for dependency injection.

The Command Parenting sample contributes another class, a `Command`, to Visual Studio:

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
    public SampleCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }
    ...
```

When extending a base class provided by the VisualStudio.Extensibility SDK, you can know if you are expected to use the `VisualStudioContribution` attribute by checking wheter the base class implements `IVisualStudioContributionClass` (both `Extension` and `Command` do).

Visual Studio contribution classes will be lazily-instantiated singletons: only one instance is created and its creation is delayed until Visual Studio needs to interact with it (for example when a `Command` is first invoked by the user).

The VisualStudio.Extensibility infrastructure also allows you to receive services through dependency injection as constructor parameters of Visual Studio contribution classes (see [Services provided by SDK for injection](./extension-anatomy.md#services-provided-by-sdk-for-injection)), including any service that you added to the `IServiceCollection` in the `Extension` class' `InitializeServices` method.

Visual Studio often requires a unique identifier to be associated with contributions. In most cases the VisualStudio.Extensibility infrastructure will simply use the full name of the Visual Studio contribution class as the contribution identifier. For example, the identifier of the `Extension` class above will be `CommandParentingSample.CommandParentingSampleExtension`. You may want to choose carefully the type name and namespace of your Visual Studio contribution classes since they may appear in Visual Studio logs and error messages.

## Configuring Visual Studio Contributions

Most Visual Studio contribution classes require or allow configuration. For example, the `Command` abstract class requires the implementation of a `CommandConfiguration` property specifying at least the command's display name and, optionally, other properties like its placement.

```csharp
[VisualStudioContribution]
internal class SampleCommand : Command
{
    ...
    public override CommandConfiguration CommandConfiguration => new("%SampleCommand.DisplayName%")
    {
        Placements = new[]
        {
            // File in project context menu
            CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 1072),

            // Project context menu
            CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 1026),

            // Solution context menu
            CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 1043),
        },
    };
    ...
```

`CommandConfiguration` is a *compile-time constant*, which means that its value will be evaluated when the extension is built and it will be included in the extension manifest (`extension.json`). Visual Studio can read the extension manifest without loading the extension itself, which allows for better performance.

*Compile-time constants* are subject to additional limitations compared to normal properties, for example they must be readonly and their initialization code cannot include references to non-static members or multi-statement imperative code blocks. These restrictions are enforced by the VisualStudio.Extensibility build tools and will result in error messages like the following:

> Property SampleCommand.CommandConfiguration is a compile-time constant. References to user-defined non-static members are not supported when evaluating compile-time constant values.

In general, the extension shouldn't reference *compile-time constant* configuration properties at run time.

You can easily identify *Compile-time constant* configuration properties since their definition has the `CompileTimeEvaluation` attribute.

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

On rare occasions, configuration properties are optional. For example, the `Extension` class has a virtual `ExtensionConfiguration` property which includes some less common configurations.

In certain cases, you may need to implement multiple configuration properties on the same class. This is common when extending `ExtensionPart` and implementing multiple interfaces, each one requiring its own configuration property.

## Standalone configuration properties

As described above, Visual Studio contribution classes define a singleton class which usually exposes one or more *compile-time constant* configuration properties. The configuration properties values will be saved as extension metadata.

Some extensibility feature require specifying extension metadata that is not tied to any class and it's either meaningful on its own or it's meant to be referenced by other configurations. A few examples are menu, toolbar and document type definitions. This is achieved by simply applying the `VisualStudioContribution` attribute to a static readonly configuration property.

Visual Studio contribution properties can be placed in any class.

The [Command Parenting](../../../New_Extensibility_Model/Samples/CommandParentingSample/ExtensionCommandConfiguration.cs) sample defines a toolbar by declaring a static property of type `ToolbarConfiguration` and marking it as `VisualStudioContribution`.

```csharp
namespace CommandParentingSample;

internal static class ExtensionCommandConfiguration
{
    [VisualStudioContribution]
    public static ToolbarConfiguration ToolBar => new("%ToolBar.DisplayName%")
    {
        Children = new[]
        {
            ToolbarChild.Command<SampleCommand>(),
        },
    };
}
```

Visual Studio contribution properties are also *compile-time constants* and are subject to the same limitations discussed earlier.

The [Markdown Linter](../../../New_Extensibility_Model/Samples/MarkdownLinter/TextViewEventListener.cs) project shows a sample of a Visual Studio contribution property being referenced by another configuration property:

```csharp
internal static class MarkdownLinterExtensionContributions
{
    [VisualStudioContribution]
    internal static DocumentTypeConfiguration MarkdownDocumentType => new("markdown")
    {
        FileExtensions = new[] { ".md", ".mdk", ".markdown" },
        BaseDocumentType = DocumentType.KnownValues.Text,
    };
}

[VisualStudioContribution]
internal class TextViewEventListener : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
    ...
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = new[]
        {
            DocumentFilter.FromDocumentType(MarkdownLinterExtensionContributions.MarkdownDocumentType),
        },
    };
    ...
```

Types that are meant to be used to define Visual Studio contribution properties implement the `IVisualStudioContributionProperty` interface and are marked with the `CompileTimeEvaluation` attribute to document that their value will be evaluated when the extension is built.

```csharp
[CompileTimeEvaluation]
public sealed class DocumentTypeConfiguration : IVisualStudioContributionProperty ...
```

The guidance about not referencing *compile-time constant* configuration properties at run time applies to Visual Studio contribution properties as well.

In case a unique identifier is required for a Visual Studio contribution property, its full name (containing type full name and property name) will be used by the VisualStudio.Extensibility infrastructure as identifier. For example, the unique identifier of the toolbar configuration above will be `CommandParentingSample.ExtensionCommandConfiguration.ToolbarConfiguration`.
