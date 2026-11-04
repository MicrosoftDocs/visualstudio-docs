---
title: Detailed comparison of Visual Studio extensibility models
description: Compare VisualStudio.Extensibility and the Visual Studio SDK (VSSDK), including command configuration, process isolation, and threading.
author: TinaSchrepfer
ms.author: tinali

ms.date: 10/20/2026
ms.topic: concept-article
ms.subservice: extensibility-integration
---
# Detailed comparison of Visual Studio extensibility models

This article compares the VisualStudio.Extensibility SDK with the Visual Studio SDK (VSSDK), focusing on command implementation, hosting, and threading. If you're deciding which model to use, start with [Choose the right extensibility model](../how-it-works/models/extensibility-models.md).

## Code comparison: inserting text from a file

The following snippets illustrate the same operation: reading text from a file and inserting it at the beginning of the active document. They show differences in editor access and command configuration, rather than complete extension implementations.

### VisualStudio.Extensibility

``` csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    var activeTextView = await context.GetActiveTextViewAsync(cancellationToken);
    if (activeTextView is not null)
    {
        var fileText = await File.ReadAllTextAsync(
            Path.Combine(Path.GetTempPath(), "test.txt"), cancellationToken);

        await this.Extensibility.Editor().EditAsync(batch =>
        {
            ITextDocumentEditor editor = activeTextView.Document.AsEditable(batch);
            editor.Insert(0, fileText);
        }, cancellationToken);
    }
}
```

Configure the command's display name, icon, and placement in C#:

``` csharp
public override CommandConfiguration CommandConfiguration => new("%VisualStudio.Extensibility.Command1.DisplayName%")
{
    Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
};
```

The SDK exposes editor access and edits through asynchronous APIs. Command configuration is discoverable through IntelliSense and doesn't require a separate command table.

### [VSSDK ↗](/visualstudio/extensibility/visual-studio-sdk)

``` csharp
private void Execute(object sender, EventArgs e)
{
    ThreadHelper.ThrowIfNotOnUIThread();

    var textManager = package.GetService<SVsTextManager, IVsTextManager>();
    textManager.GetActiveView(1, null, out IVsTextView activeTextView);

    if (activeTextView != null && activeTextView is IVsTextViewEx nativeView)
    {
        ErrorHandler.ThrowOnFailure(nativeView.GetWindowFrame(out object frameValue));

        IComponentModel2 compService = package.GetService<SComponentModel, IComponentModel2>();
        IVsEditorAdaptersFactoryService editorAdapter = compService.GetService<IVsEditorAdaptersFactoryService>();
        var wpfTextView = editorAdapter?.GetWpfTextView(activeTextView);

        if (frameValue is IVsWindowFrame frame && wpfTextView != null)
        {
            var fileText = File.ReadAllText(Path.Combine(Path.GetTempPath(), "test.txt"));
            wpfTextView.TextBuffer?.Insert(0, fileText);
        }
    }
}
```

In addition, VSSDK requires a `.vsct` file to define command configuration:

``` xml
<Commands package="guidVSSDKPackage">
    <Groups>
        <Group guid="guidVSSDKPackageCmdSet" id="MyMenuGroup" priority="0x0600">
        <Parent guid="guidSHLMainMenu" id="IDM_VS_MENU_TOOLS" />
        </Group>
    </Groups>

    <Buttons>
        <Button guid="guidVSSDKPackageCmdSet" id="InsertTextCommandId" priority="0x0100" type="Button">
        <Parent guid="guidVSSDKPackageCmdSet" id="MyMenuGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <Strings>
            <ButtonText>Insert text from file</ButtonText>
        </Strings>
        </Button>
    </Buttons>

    <Bitmaps>
        <Bitmap guid="guidImages" href="Resources\InsertTextCommand.png" usedList="bmpPic1, bmpPic2, bmpPicSearch, bmpPicX, bmpPicArrows, bmpPicStrikethrough" />
    </Bitmaps>
</Commands>
```

VSSDK uses services and editor adapters to access the active view. This synchronous example runs on the UI thread, including the file read. In a production extension, move file I/O off the UI thread and switch back before accessing services that require it.

## Why VisualStudio.Extensibility is architecturally different

The differences extend beyond the amount of code. The SDK you choose affects where your extension runs, how it accesses IDE state, and which threading responsibilities you manage.

### Process isolation and runtime

VisualStudio.Extensibility extensions run out of process by default, communicating with Visual Studio through RPC. This separates extension execution from the IDE process and supports modern .NET. Process isolation reduces the risk that an extension failure crashes Visual Studio, but extensions must still handle exceptions, cancellation, and changing IDE state.

VSSDK extensions run inside the Visual Studio process and use .NET Framework. They can access in-process services, COM interfaces, and MEF components, including scenarios not yet available through VisualStudio.Extensibility. Blocking or failing in-process code can affect the IDE directly.

### Asynchronous operations and command execution

VisualStudio.Extensibility commands implement `ExecuteCommandAsync` and start on a background thread. Await SDK operations and pass their cancellation tokens through to asynchronous work. The SDK manages communication with Visual Studio; extension code doesn't need to switch to the IDE's UI thread to call these APIs.

VSSDK command handlers commonly begin with synchronous callbacks. They can start asynchronous work using [`JoinableTaskFactory` ↗](/dotnet/api/microsoft.visualstudio.threading.joinabletaskfactory), but the extension must manage that work's lifetime, exceptions, reentrancy, and cancellation. An asynchronous method doesn't by itself move work off the UI thread or remove a service's thread-affinity requirements.

### UI-thread requirements

Many VSSDK services require the UI thread. Follow each API's threading contract, switch with `JoinableTaskFactory.SwitchToMainThreadAsync` when required, and keep expensive computation and I/O off that thread.

VisualStudio.Extensibility reduces explicit thread switching for SDK calls. It doesn't make synchronous I/O nonblocking or remove the need to coordinate concurrent operations in your extension.

### Using both SDKs

If a required feature isn't available out of process, a [hybrid extension](../how-it-works/models/in-proc-extensions.md) can use VisualStudio.Extensibility alongside VSSDK. It runs in process and uses .NET Framework, so it doesn't provide out-of-process isolation or modern .NET hosting.

VisualStudio.Extensibility commands still start on a background thread in a hybrid extension. When calling VSSDK services, follow their UI-thread and lifetime requirements.

> [!NOTE]
> The [Community Toolkit ↗](/visualstudio/extensibility/vsix/visual-studio-community-toolkit) is an optional, community-maintained helper library over VSSDK, not a separate extensibility model. Its helpers don't change VSSDK's hosting, runtime, or threading requirements.

## Related content

- [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) — scenario recommendations
- [In-process (hybrid) extensions](../how-it-works/models/in-proc-extensions.md) — when you need VSSDK APIs alongside VisualStudio.Extensibility
- [Out-of-process architecture](../how-it-works/inside-the-sdk.md) — how the out-of-process model works
