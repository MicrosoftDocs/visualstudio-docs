---
title: Dialogs Reference
description: A reference for extensibility dialogs.
ms.topic: overview
ms.date: 3/31/2023
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Create Visual Studio dialogs

Dialogs are a way to prompt a user for information or to allow for customizations of feature behavior. For example, the **Tools** > **Options** dialog has individual pages that let the user control the behavior for features like themes, editors, and document tabs.

## Get started

To get started, follow the steps in [Create your first Visual Studio extension](./../get-started/create-your-first-extension.md).

## Work with dialogs

This article covers the top user scenarios when you work with dialogs:

- [Create a dialog](#create-a-dialog)
- [Customize the dialog title](#customize-the-dialog-title)
- [Customize the dialog buttons](#customize-the-dialog-buttons)
- [Get the dialog result](#get-the-dialog-result)

## Create a dialog

Creating a tool window with the new Extensibility model is as simple as calling the [ShowDialogAsync](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync) method from the [ShellExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility) helpers and passing in your dialog content.

![Screenshot that shows a dialog.](./media/dialog.png)

### ShowDialogAsync

The [ShowDialogAsync](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync) method has several overloads that you should become familiar with:

#### Overloads

- [`ShowDialogAsync(content,cancellationToken)`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync#microsoft-visualstudio-extensibility-shell-shellextensibility-showdialogasync(microsoft-visualstudio-rpccontracts-remoteui-iremoteusercontrol-system-threading-cancellationtoken))
- [`ShowDialogAsync(content,title,cancellationToken)`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync#microsoft-visualstudio-extensibility-shell-shellextensibility-showdialogasync(microsoft-visualstudio-rpccontracts-remoteui-iremoteusercontrol-system-string-system-threading-cancellationtoken))
- [`ShowDialogAsync(content,options,cancellationToken)`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync#microsoft-visualstudio-extensibility-shell-shellextensibility-showdialogasync(microsoft-visualstudio-rpccontracts-remoteui-iremoteusercontrol-microsoft-visualstudio-rpccontracts-notifications-dialogoption-system-threading-cancellationtoken))
- [`ShowDialogAsync(content,title,options,cancellationToken)`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync#microsoft-visualstudio-extensibility-shell-shellextensibility-showdialogasync(microsoft-visualstudio-rpccontracts-remoteui-iremoteusercontrol-system-string-microsoft-visualstudio-rpccontracts-notifications-dialogoption-system-threading-cancellationtoken))

#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| `content` | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](/dotnet/api/microsoft.visualstudio.rpccontracts.remoteui.iremoteusercontrol 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| `title` | [System.String](/dotnet/api/System.String 'System.String') | The title of the dialog. |
| `options` | `Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption` | The options for displaying the dialog. |
| `cancellationToken` | [System.Threading.CancellationToken](/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    // Ownership of the RemoteUserControl is transferred to Visual Studio, so it shouldn't be disposed by the extension
    #pragma warning disable CA2000 // Dispose objects before losing scope
    var control = new MyDialogControl(null);
    #pragma warning restore CA2000 // Dispose objects before losing scope

    await this.Extensibility.Shell().ShowDialogAsync(control, cancellationToken);
}
```

For more information on how to create a remote user control, see [Remote UI](./../inside-the-sdk/remote-ui.md).

## Customize the dialog title

When your extension shows a dialog, you can provide a custom title string which is displayed in the dialog's caption region.

![Screenshot that shows a dialog title.](./media/dialog-title.png)

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    // Ownership of the RemoteUserControl is transferred to Visual Studio, so it shouldn't be disposed by the extension
    #pragma warning disable CA2000 // Dispose objects before losing scope
    var control = new MyDialogControl(null);
    #pragma warning restore CA2000 // Dispose objects before losing scope

    await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", cancellationToken);
}
```

## Customize the dialog buttons

When a dialog is shown in the integrated development environment, you can select certain combinations of predefined dialog buttons and default actions. You can find the predefined button and action combinations in `Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption`.

![Screenshot of a dialog button.](./media/dialog-button.png)

You can also create your own combination of buttons and default actions from:

- `Microsoft.VisualStudio.RpcContracts.Notifications.DialogButton`

    ```csharp
    public enum DialogButton
    {
        // Hides all of the dialog buttons.
        None,
        // Shows a single close button.
        Close,
        // Shows a single OK button.
        OK,
        // Shows an OK and Cancel button.
        OKCancel
    }
    ```

- `Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult`

    ```csharp
    public enum DialogResult
    {
        // The dialog was closed via the System.Threading.CancellationToken or by using an
        // action provided by the Microsoft.Visual Studio.RpcContracts.RemoteUI.IRemoteUserControl
        // content.
        None,
        // The user pressed the Close button.
        Close,
        // The user pressed the OK button.
        OK,
        // The user pressed the Cancel button, or pressed the nonclient close button, or
        // pressed the Esc key.
        Cancel
    }
   ```

### Examples

Add a Cancel button:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    // Ownership of the RemoteUserControl is transferred to Visual Studio, so it shouldn't be disposed by the extension
    #pragma warning disable CA2000 // Dispose objects before losing scope
    var control = new MyDialogControl(null);
    #pragma warning restore CA2000 // Dispose objects before losing scope

    await this.Extensibility.Shell().ShowDialogAsync(control, DialogOption.OKCancel, cancellationToken);
}
```

No dialog buttons:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    // Ownership of the RemoteUserControl is transferred to Visual Studio, so it shouldn't be disposed by the extension
    #pragma warning disable CA2000 // Dispose objects before losing scope
    var control = new MyDialogControl(null);
    #pragma warning restore CA2000 // Dispose objects before losing scope

    await this.Extensibility.Shell().ShowDialogAsync(control, new DialogOption(DialogButton.None, DialogResult.None), cancellationToken);
}
```

## Get the dialog result

If you need to know whether a user affirmatively closed a dialog or dismissed it, you can await the call to [`ShowDialogAsync`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showdialogasync). It returns `Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult`, which represents the action taken by the user.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    // Ownership of the RemoteUserControl is transferred to Visual Studio, so it shouldn't be disposed by the extension
    #pragma warning disable CA2000 // Dispose objects before losing scope
    var control = new MyDialogControl(null);
    #pragma warning restore CA2000 // Dispose objects before losing scope

    DialogResult result = await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", DialogOption.OKCancel, cancellationToken);

    if (result == DialogResult.OK)
    {
        // The user pressed the OK button.
    }
}
```

## Related content

- See [DialogSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DialogSample) for a full example of how to create an extension with a dialog.