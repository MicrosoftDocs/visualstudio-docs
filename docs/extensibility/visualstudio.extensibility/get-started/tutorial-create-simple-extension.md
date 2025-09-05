---
title: Create a simple extension
description: A tutorial for creating a simple extension
ms.topic: tutorial
ms.date: 3/31/2023
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---
# Create a simple extension

In [Create your first extension](create-your-first-extension.md), you learned how to use the VisualStudio.Extensibility project template to create an extension project, and learned how to build it and debug it in the experimental instance of Visual Studio.

In this tutorial, you learn how to create an extension with a simple command that does something in the [Visual Studio editor](../editor/editor.md). In this case, it inserts a newly generated GUID. You also see how to tell Visual Studio what file types the GUID extension is enabled for, and how to make the new command show up as a toolbar or menu item.

The completed sample for this tutorial may be found [here](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuid/).

The tutorial contains the following steps:

- [Configure the command](#configure-the-command)
- [Create the execution method](#create-the-execution-method)

## Configure the command

In this step, you'll learn about options for configuring and placing the command. The purpose of hosting the command is to expose it to the user in some way, such as adding a menu item or a command bar button.

The project template or the sample you created in the [Create your first extension](create-your-first-extension.md) tutorial consists of a single C# file that includes a [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) class already. You can update that in place.

1. Rename the `Command1.cs` file to `InsertGuidCommand.cs`, rename the class `InsertGuidCommand`, update the [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) property.

   ```csharp
   public override CommandConfiguration CommandConfiguration => new("%InsertGuidCommand.DisplayName%")
   {
       Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
   };
   ```

   [`Placements`](/dotnet/api/microsoft.visualstudio.extensibility.commands.basecontrolconfiguration.placements) specifies where the command should appear in the IDE. In this case, the command is placed in the Extensions menu, one of the top-level menus in Visual Studio.

   The argument to the [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) constructor is the command's display name, which is the menu text. The display name is enclosed by `%` characters because it references a string resource from `.vsextension/string-resources.json` to support localization.

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

   You can specify a known built-in icon, in this case [`OfficeWebExtension`](/dotnet/api/microsoft.visualstudio.extensibility.imagemoniker.knownvalues.officewebextension), or upload images for the icon as described in [Add Visual Studio commands](../command/command.md). The second argument is an enumeration that determines how the command should appear in toolbars (in addition to its place in a menu). The option [`IconSettings.IconAndText`](/dotnet/api/microsoft.visualstudio.extensibility.commands.iconsettings#microsoft-visualstudio-extensibility-commands-iconsettings-iconandtext) means show the icon and the display name next to each other.

1. Add the [`VisibleWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.visiblewhen) property, which specifies the conditions that must apply for the item to appear to the user.

   ```csharp
   public override CommandConfiguration CommandConfiguration => new("%InsertGuidCommand.DisplayName%")
   {
       Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
       Icon = new(ImageMoniker.KnownValues.OfficeWebExtension, IconSettings.IconAndText),
       VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, ".+"),
   };
   ```

See [using rule based activation constraints](./../inside-the-sdk/activation-constraints.md#rule-based-activation-constraints) for more information.

## Create the execution method

In this step, you implement the command's [`ExecuteCommandAsync`](/dotnet/api/microsoft.visualstudio.extensibility.commands.dynamiccommand.executecommandasync) method, which defines what happens when the user chooses the menu item, or presses the item in the toolbar for your command.

Copy the following code to implement the method.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        Requires.NotNull(context, nameof(context));
        var newGuidString = Guid.NewGuid().ToString("N", CultureInfo.CurrentCulture);

        using var textView = await context.GetActiveTextViewAsync(cancellationToken);
        if (textView is null)
        {
            this.logger.TraceInformation("There was no active text view when command is executed.");
            return;
        }

        await this.Extensibility.Editor().EditAsync(
            batch =>
            {
                textView.Document.AsEditable(batch).Replace(textView.Selection.Extent, newGuidString);
            },
            cancellationToken);
    }
```

The first line validates the arguments, then we create a new `Guid` to use later.

Then, we create an [`ITextViewSnapshot`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) (the `textView` object here) by calling the asynchronous method [`GetActiveTextViewAsync`](/dotnet/api/microsoft.visualstudio.extensibility.extensionmethods.getactivetextviewasync). A cancellation token is passed in to preserve the ability to cancel the asynchronous request, but this part isn't demonstrated in this sample. If we don't get a text view successfully, we write to the log and terminate without doing anything else.

Now we're ready to call the asynchronous method that submits an edit request to Visual Studio's editor. The method we want is [`EditAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility.editasync). That's a member of the [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) class, which allows interaction with the running Visual Studio Editor in the IDE. The `Command` type, which your own `InsertGuidCommand` class inherits from, has a member `Extensibility` that provides access to the [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) object, so we can get to the `EditorExtensibility` class with a call to `this.Extensibility.Editor()`.

The [`EditAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility.editasync) method takes an `Action<IEditBatch>` as a parameter. This parameter is called `editorSource`,

The call to `EditAsync` uses a lambda expression. To break this down a little, you could also write that call as follows:

```csharp
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        var editor = textView.Document.AsEditable(batch);
        // specify the desired changes here:
        editor.Replace(textView.Selection.Extent, newGuidString);
    },
    cancellationToken);
```

You could think of this call as specifying the code that you want to be run in the Visual Studio editor process. The lambda expression specifies what you want changed in the editor. The `batch` is of type `IEditBatch`, which implies that the lambda expression defined here makes a small set of changes that should be accomplished as a unit, rather than being interrupted by other edits by the user or language service. If the code executes too long, that can lead to unresponsiveness, so it's important to keep changes within this lambda expression limited and understand anything that could lead to delays.

Using the [`AsEditable`](/dotnet/api/microsoft.visualstudio.extensibility.editor.ieditable-1.aseditable) method on the document, you get a temporary editor object that you can use to specify the desired changes. Think of everything in the lambda expression as a request for Visual Studio to execute rather than as actually executing, because as described in the [Use Visual Studio editor extensibility](../editor/editor.md), there's a particular protocol for handling these asynchronous edit requests from extensions, and there's a possibility of the changes not being accepted, such as if the user is making changes at the same time that create a conflict.

The [`EditAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility.editasync) pattern can be used to modify text in general by specifying your modifications after the "specify your desired changes here" comment.
