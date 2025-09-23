---
title: Output window overview
description: An overview for output window extensibility
ms.topic: overview
ms.date: 10/16/2024
ms.author: murphymcquet
monikerRange: ">=vs-2022"
author: murphymcquet
manager: tinali
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Write to the Visual Studio output window

The Output window in the Visual Studio IDE is a [Tool Window](./../tool-window/tool-window.md) that can be used to deliver status, diagnostics/logging, or any other informational text to the user. Unlike [User Prompts](./../user-prompt/user-prompts.md), which might display a message box, the messages written to the Output window are only displayed if the user has the Output window visible in the IDE and your channel is selected in the **Show output from** dropdown list. The Output window becomes visible when the user selects **View > Output menu** from the main menu.

## Get started

> [!IMPORTANT]
> The VisualStudio.Extensibility Output window APIs are currently in preview and are subject to change. Any extension that leverages these APIs may fail to work in future versions of Visual Studio and will need to be updated when a newer version of the APIs is released.

To get started, follow the [create the project](./../get-started/create-your-first-extension.md#create-the-extension-project) section in Getting Started section.

## Work with the Output window

This guide is designed to cover the most common things you can do with the Output window:

- [Get an Output window channel](#get-an-output-window-channel)
- [Write to the Output window](#write-to-the-output-channel)

## Get an Output window channel

In order to write to the Output window, you need an Output window channel, which can be created by calling [`VisualStudioExtensibility.Views().Output.CreateOutputChannelAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputwindowextensibility.createoutputchannelasync).

### `OutputWindowExtensibility.CreateOutputChannelAsync()`

The [`CreateOutputChannelAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputwindowextensibility.createoutputchannelasync) method has two parameters:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| `displayName` | `string` | yes | The display name of the output window. This is what will be visible in the "Show output from:" dropdown menu in the Output pane. This value is marked as ['Localizable'](/dotnet/api/system.componentmodel.localizableattribute) to localize the display name. |
| `cancellationToken` | [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) | yes | The [`CancellationToken`](/dotnet/api/system.threading.cancellationtoken) for the async operation. |

### Edit or add the Extension class

If your project doesn't already contain a class that derives from [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension), you need to add one like the simple one below (in this case called `MyExtension.cs`):

```csharp
using System.Resources;
using Microsoft.VisualStudio.Extensibility;

namespace MyProject
{
    public class MyExtension : Extension
    {
        // Initiailzation code here
    }
}
```

### Add the initialization code

This code can be in whichever class you intend to use to show output messages (such as a [Command](./../command/command.md)), but the important thing is that [`CreateOutputChannelAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputwindowextensibility.CreateOutputChannelAsync) can only be called once for a given Output window channel display name - if there are conflicts then an exception will be thrown - so consider calling it in a one-time initialization method such as [`InitializeAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart.initializeasync).

```csharp
public override async Task InitializeAsync(CancellationToken cancellationToken)
{
    string displayName = "My Output Window";

     // To use this Output window Channel elsewhere in the class, such as the ExecuteCommandAsync() method in a Command, save this result to a field in the class.
    OutputChannel? outputChannel = await this.Extensibility.Views().Output.CreateOutputChannelAsync(displayName, cancellationToken);
}
```

## Write to the Output channel

The [`OutputChannel`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputchannel) instance obtained in [Get an Output window channel](#get-an-output-window-channel) has a [`System.IO.TextWriter`](/dotnet/api/system.io.textwriter) property called `Writer`, which supports familiar operations for writing text, such as:

- [`Write()`](/dotnet/api/system.io.textwriter.write)
- [`WriteAsync()`](/dotnet/api/system.io.textwriter.writeasync)
- [`WriteLine()`](/dotnet/api/system.io.textwriter.writeline)
- [`WriteLineAsync()`](/dotnet/api/system.io.textwriter.writelineasync).

Additionally, you can call [`WriteAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputchannel.writeasync) or [`WriteLineAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.documents.outputchannel.writelineasync) directly on the `OutputChannel`, or access a [`System.IO.Pipelines.PipeWriter`](/dotnet/api/system.io.pipelines.pipewriter) via the `PipeWriter` property.

### Example

This snippet could be used wherever you want to display a message in the Output window, such as in the [`ExecuteCommandAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.commands.iexecutablecommand.executecommandasync) method in a [Command](./../command/command.md).

```csharp
if (this.outputChannel != null)
{
    await this.outputChannel.Writer.WriteLineAsync("This is a test of the output channel TextWriter.");
    
    await this.outputChannel.WriteLineAsync("This is a test of the output channel.");

    var rom = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes("This is a test of the output channel PipeWriter."));
    await this.outputChannel.PipeWriter.WriteLineAsync(rom, new());
}
```

## Next steps

Learn more:

- Learn more about [commands](./../command/command.md)
- Learn more about exposing functionality in the IDE in a [tool window](./../tool-window/tool-window.md)
- Learn about interacting with the user with [user prompts](./../user-prompt/user-prompts.md)

Look at sample code:

- See the [OutputWindowSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample) sample for a full example of creating an extension that uses the output window.
