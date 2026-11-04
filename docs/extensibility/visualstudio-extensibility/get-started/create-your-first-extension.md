---
title: Create Your First Extension Reference
description: A quickstart for creating your first out-of-process extension
ms.topic: quickstart
ms.date: 10/09/2026
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer

ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Create your first Visual Studio extension

This document is a quickstart that shows how to create your first extension using VisualStudio.Extensibility. The extension runs out-of-process, meaning outside of the Visual Studio process.

## Prerequisites

* Visual Studio 2026 version 18.11 or later with the **Visual Studio extension development** workload is recommended. For earlier versions, VisualStudio.Extensibility requires Visual Studio 2022 version 17.9 or later.

## Create the extension project

### Visual Studio 18.11 or later (recommended)

Use the **Modern VSIX Project** template and select **VisualStudio.Extensibility (Out-Of-Process)** under **Extension Type**. The template defaults to VSSDK, so select the out-of-process option for this quickstart.

Follow [Create an extension with the Modern VSIX Project template](../ship/create-vsix-with-project-sdk.md#create-the-project-in-visual-studio) for the wizard steps and project SDK options.

### Earlier Visual Studio versions

Use the **VisualStudio.Extensibility Project** template to create a new extensibility project.

![Screenshot of the VSExtensibility template.](./media/visual-studio-extensibility-project-template.png)

At this point, you're ready to start extending Visual Studio by adding commands and editor components to your extension.

## The Extension class

The template creates a class that extends [`Extension` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension). This class is the first that is instantiated when your extension is loaded. In the [`InitializeServices` ↗](/dotnet/api/microsoft.visualstudio.extensibility.extension.initializeservices) method, you can add your own services to the service collection to make them available for dependency injection.

```csharp
[VisualStudioContribution]
internal class ExtensionEntrypoint : Extension
{
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            id: "MyExtension.abc123",
            version: this.ExtensionAssemblyVersion,
            publisherName: "My Company",
            displayName: "My Extension"),
    };

    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);

        // You can configure dependency injection here by adding services to the serviceCollection.
    }
}
```

You can also see the [`VisualStudioContribution` ↗](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute that is used to mark extension components that are meant to be consumed by Visual Studio. This attribute can be applied to classes implementing [`IVisualStudioContributionClass` ↗](/dotnet/api/microsoft.visualstudio.extensibility.ivisualstudiocontributionclass) or static properties of a type implementing [`IVisualStudioContributionProperty` ↗](/dotnet/api/microsoft.visualstudio.extensibility.ivisualstudiocontributionproperty).

## Add your first command

The template creates `Command1.cs` as your first command handler, which you can use as a starting point. Since we want to make Visual Studio aware of this command, and the [`Command` ↗](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) class implements [`IVisualStudioContributionClass` ↗](/dotnet/api/microsoft.visualstudio.extensibility.ivisualstudiocontributionclass), the command is marked with the `VisualStudioContribution` attribute.

```csharp
[VisualStudioContribution]
internal class Command1 : Command
{
```

The command has a configuration property named [`CommandConfiguration` ↗](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration), which defines its display name, icon and placement under the `Extensions` menu.

```csharp
    public override CommandConfiguration CommandConfiguration => new("%MyExtension.Command1.DisplayName%")
    {
        // Use this object initializer to set optional parameters for the command. The required parameter,
        // displayName, is set above. DisplayName is localized and references an entry in .vsextension\string-resources.json.
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
        Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
    };
```

Configuration properties are evaluated by the C# compiler when building the extension and their values are saved as extension metadata so that Visual Studio can read it without loading the extension assembly. For this reason, configuration properties have additional restrictions compared to normal properties (for example, they must be readonly).

You can see that the display name of the command is `"%MyExtension.Command1.DisplayName%"`, which references the `MyExtension.Command1.DisplayName` string in the `.vsextension/string-resources.json` file, allowing this string to be localized.

When the command is executed, Visual Studio calls into the [`ExecuteCommandAsync` ↗](/dotnet/api/microsoft.visualstudio.extensibility.commands.dynamiccommand.executecommandasync) method where you can place a breakpoint. You can use the `context` argument or `this.Extensibility` to interact with Visual Studio.

For example, a command handler could be as follows:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    await this.Extensibility.Shell().ShowPromptAsync(
        "Hello from an extension!", 
        PromptOptions.OK, 
        cancellationToken);
}
```

For more information on how to add commands, refer to [Commands](../recipes/commands/commands.md) section.

## Debug your extension

1. Make sure that your extension project is selected as startup project in Visual Studio, and press `F5` to start debugging.
1. Pressing `F5` builds your extension and deploys it to the experimental instance of Visual Studio version you're using. The debugger should attach once your extension is loaded.
1. You can find the new command in `Extensions` menu as shown in the following image:

   ::: moniker range="visualstudio"

   ![Screenshot showing sample command in Visual Studio.](media/visual-studio-extension-command.png)

   ::: moniker-end

   ::: moniker range="vs-2022"

   ![Screenshot showing sample command.](./media/extension-command.png)

   ::: moniker-end

## Next steps

- [Add a command](../recipes/commands/commands.md) — the most common first feature to build
- [Tool windows](../recipes/tool-windows.md) — add custom UI panels
- [Anatomy of an extension](../how-it-works/models/extension-anatomy.md) — understand the project structure and key concepts
- [Browse all samples ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples) — full working extensions on GitHub
