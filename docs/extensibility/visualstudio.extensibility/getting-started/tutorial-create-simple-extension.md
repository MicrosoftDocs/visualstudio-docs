---
title: Create a simple extension
description: A tutorial for creating a simple extension
date: 2022-2-6
---
# Create a simple extension

In [Create your first extension](create-your-first-extension.md), you learned how to use the VisualStudio.Extensibility project template to create an extension project, and learned how to build it and debug it in the experimental instance of Visual Studio.

In this tutorial, you'll learn how to create an extension with a simple command that does something in the [Visual Studio editor](../extension-guides/editor/editor.md). In this case, it inserts a newly generated GUID. You'll also see how to tell Visual Studio what file types the GUID extension is enabled for, and how to make the new command show up as a toolbar or menu item.

The completed sample for this tutorial may be found [here](../../../New_Extensibility_Model/Samples/InsertGuid/).

The tutorial contains the following steps:

- [Configure the command](#configure-the-command)
- [Create the execution method](#create-the-execution-method)

## Configure the command

In this step, you'll learn about options for configuring and placing the command. The purpose of hosting the command is to expose it to the user in some way, such as adding a menu item or a command bar button.

The project template or the sample you created in the [Create your first extension](create-your-first-extension.md) tutorial consists of a single C# file that includes a `Command` class already. You can simply update that in place.

1. Rename the `Command1.cs` file to `InsertGuidCommand.cs`, rename the class `InsertGuidCommand`, update the `CommandConfiguration` property.

```csharp
public override CommandConfiguration CommandConfiguration => new("%InsertGuidCommand.DisplayName%")
{
    Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
};
```

`Placements`, specifies where the command should appear in the IDE. In this case, the command is placed in the Extensions menu, one of the top-level menus in Visual Studio.

The argument to the `CommandConfiguration` constructor is the command's display name, which is the menu text. The display name is enclosed by `%` characters because it references a string resource from `.vsextension/string-resources.json` to support localization.

1. Update `.vsextension/string-resources.json` with the display name of `InsertGuidCommand`.

```json
{
  "InsertGuidCommand.DisplayName": "Insert new guid"
}
```

1. Add the `Icon` property.

```csharp
public override CommandConfiguration CommandConfiguration => new("%InsertGuidCommand.DisplayName%")
{
    Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
    Icon = new(ImageMoniker.KnownValues.OfficeWebExtension, IconSettings.IconAndText),
};
```

You can specify a known built-in icon, in this case `OfficeWebExtension`, or upload images for the icon as described in [Commands overview](../extension-guides/command/command.md). The second argument is an enumeration that determines how the command should appear in toolbars (in addition to its place in a menu). The option `IconSettings.IconAndText` means show the icon and the display name next to each other.

1. Add the `VisibleWhen` property which specifies the conditions that must apply for the item to appear to the user.

```csharp
public override CommandConfiguration CommandConfiguration => new("%InsertGuidCommand.DisplayName%")
{
    Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
    Icon = new(ImageMoniker.KnownValues.OfficeWebExtension, IconSettings.IconAndText),
    VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, ".+"),
};
```

See [using rule based activation constraints](./../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints) for additional details.

## Create the execution method

In this step, you'll implement the Command's `ExecuteCommandAsync` method, which defines what happens when the user chooses the menu item, or presses the item in the toolbar for your command.

Copy the following code to implement the method.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        Requires.NotNull(context, nameof(context));
        var newGuidString = Guid.NewGuid().ToString("N", CultureInfo.CurrentCulture);

        using var textView = await context.GetActiveTextViewAsync(cancellationToken);
        if (textView is null)
        {
            this.logger.TraceInformation("There was no active text view when command is     executed.");
            return;
        }

        var document = await textView.GetTextDocumentAsync(cancellationToken);
        await this.Extensibility.Editor().EditAsync(
            batch =>
            {
                document.AsEditable(batch).Replace(textView.Selection.Extent,    newGuidString);
            },
            cancellationToken);
    }
```

The first line validate the arguments, then we create a new Guid to use later.

Then, we create an `ITextViewSnapshot` (the `textView` object here) by calling the asynchronous method `GetActiveTextViewAsync`. A cancellation token is passed in to preserve the ability to cancel the asynchronous request, but this is not demonstrated in this sample. If we don't get a text view successfully, we'll write to the log and terminate without doing anything else.

Next, we request the document, an instance of `ITextDocumentSnapshot` (here `document`).

Now we're ready to call the asynchronous method that submits an edit request to Visual Studio's editor. The method we want is `EditAsync`. That's a member of the `EditorExtensibility` class, which allows interaction with the running Visual Studio Editor in the IDE. The `Command` type, which your own `InsertGuidCommand` class inherits from, has a member `Extensibility` that provides access to the `EditorExtensibility` object, so we can get to the `EditorExtensibility` class with a call to `this.Extensibility.Editor()`.

The `EditAsync` method takes an `Action<IEditBatch>` as a parameter. This is called `editorSource`,

The call to `EditAsync` uses a lambda expression. To break this down a little, you could also write that call as follows:

```csharp
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        var editor = document.AsEditable(batch);
        // specify the desired changes here:
        editor.Replace(textView.Selection.Extent, newGuidString);
    },
    cancellationToken);
```

You could think of this call as specifying the code that you want to be run in the Visual Studio editor process. The lambda expression specifies what you want changed in the editor. The `batch` is of type `IEditBatch` and this implies that the lambda expression defined here makes a small set of changes that should be accomplished as a unit, rather than being interrupted by other edits by the user or language service. If the code executes too long, that can lead to unresponsiveness, so it's important to keep changes within this lambda expression limited and understand anything that could lead to delays.

Using the `AsEditable` method on the document, you get a temporary editor object that you can use to specify the desired changes. Think of everything in the lambda expression as a request for Visual Studio to execute rather than as actually executing, because as described in the [Editor overview](../extension-guides/editor/editor.md), there's a particular protocol for handling these asynchronous edit requests from extensions, and there's a possibility of the changes not being accepted, such as if the user is making changes at the same time that create a conflict.

The `EditAsync` pattern can be used to modify text in general by specifying your modifications after the "specify your desired changes here" comment.
