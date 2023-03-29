---
title: Dialogs reference
description: A reference for extensibility dialogs
date: 2023-1-20
---

# Dialogs Overview

Dialogs are a way to prompt a user for information or to allow for customizations of feature behavior. For example, the Tools/Options dialog has individual pages that let the user control the behavior for features like themes, editors, and document tabs.

# Get Started

To get started, follow the [create the project](./../../getting-started/create-your-first-extension.md) section in the Getting Started section.

# Work with dialogs

This guide is designed to cover the top user scenarios when working with dialogs:

- [Create a dialog](#create-a-dialog)
- [Customize the dialog title](#customize-the-dialog-title)
- [Customize the dialog buttons](#customize-the-dialog-buttons)
- [Get the dialog result](#get-the-dialog-result)

# Create a dialog

Creating a tool window with the new Extensibility Model is as simple as calling the ShowDialogAsync method from the [ShellExtensibility](./../../api/Microsoft.VisualStudio.Extensibility.md/#T-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility) helpers and passing in your dialog content.

![Dialog](Dialog.png)

## ShowDialogAsync

The ShowDialogAsync method several overloads that you should become familiar with:

### Overloads

- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,title,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,options,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-)
- [`Microsoft.VisualStudio.Extensibility.Shell.ShellExtensibility.ShowDialogAsync(content,title,options,cancellationToken)`](./../../api/Microsoft.VisualStudio.Extensibility.md/#M-Microsoft-VisualStudio-Extensibility-Shell-ShellExtensibility-ShowDialogAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl,System-String,Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption,System-Threading-CancellationToken-)

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') | The content of the dialog. |
| title | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The title of the dialog. |
| options | [Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption](#T-Microsoft-VisualStudio-RpcContracts-Notifications-DialogOption 'Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption') | The options for displaying the dialog. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to cancel the dialog. |

## Example

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	// Ownership of the RemoteUserControl is transferred to Visual Studio, so it should not be disposed by the extension
	#pragma warning disable CA2000 // Dispose objects before losing scope
	var control = new MyDialogControl(null);
	#pragma warning restore CA2000 // Dispose objects before losing scope

	await this.Extensibility.Shell().ShowDialogAsync(control, cancellationToken);
}
```

See the [Remote UI](./../../inside-the-sdk/remote-ui.md) docs for more information on creating a RemoteUserControl.

# Customize the dialog title

When showing a dialog, a custom title string can be provided which will be displayed in the dialog's caption region.

![Dialog Title](DialogTitle.png)

## Example

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	// Ownership of the RemoteUserControl is transferred to Visual Studio, so it should not be disposed by the extension
	#pragma warning disable CA2000 // Dispose objects before losing scope
	var control = new MyDialogControl(null);
	#pragma warning restore CA2000 // Dispose objects before losing scope

	await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", cancellationToken);
}
```

# Customize the dialog buttons

When showing a dialog certain combinations of predefined dialog buttons and default actions can be selected. The predefined button and action combinations can be found in Microsoft.VisualStudio.RpcContracts.Notifications.DialogOption.

![Dialog Button](DialogButton.png)

Additionally, you can create your own combination of buttons and default actions from:

- Microsoft.VisualStudio.RpcContracts.Notifications.DialogButton
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
- Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult
	```csharp
    public enum DialogResult
	{
		// The dialog was closed via the System.Threading.CancellationToken or using an
		// action provided by the Microsoft.Visual Studio.RpcContracts.RemoteUI.IRemoteUserControl
		// content.
		None,
		// The user clicked the Close button.
		Close,
		// The user clicked the OK button.
		OK,
		// The user clicked the Cancel button, or clicked the nonclient close button, or
		// pressed the Esc key.
		Cancel
    }
	```



## Examples

Adding a cancel button:
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	// Ownership of the RemoteUserControl is transferred to Visual Studio, so it should not be disposed by the extension
	#pragma warning disable CA2000 // Dispose objects before losing scope
	var control = new MyDialogControl(null);
	#pragma warning restore CA2000 // Dispose objects before losing scope

	await this.Extensibility.Shell().ShowDialogAsync(control, DialogOption.OKCancel. cancellationToken);
}
```

Having no dialog buttons:
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	// Ownership of the RemoteUserControl is transferred to Visual Studio, so it should not be disposed by the extension
	#pragma warning disable CA2000 // Dispose objects before losing scope
	var control = new MyDialogControl(null);
	#pragma warning restore CA2000 // Dispose objects before losing scope

	await this.Extensibility.Shell().ShowDialogAsync(control, new DialogOption(DialogButton.None, DialogResult.None), cancellationToken);
}
```

# Get the dialog result

If you need to know whether a user affirmatively closed a dialog or dismissed it, you can await the call to ShowDialogAsync and it will return a Microsoft.VisualStudio.RpcContracts.Notifications.DialogResult which represents the action taken by the user.

## Example
```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
	// Ownership of the RemoteUserControl is transferred to Visual Studio, so it should not be disposed by the extension
	#pragma warning disable CA2000 // Dispose objects before losing scope
	var control = new MyDialogControl(null);
	#pragma warning restore CA2000 // Dispose objects before losing scope

	DialogResult result = await this.Extensibility.Shell().ShowDialogAsync(control, "My Dialog Title", DialogOption.OKCancel, cancellationToken);

	if (result == DialogResult.OK)
	{
		// User clicked the OK button
	}
}
```

# Next steps

See the [DialogExtension](./../../../../New_Extensibility_Model/Samples/DialogExtension) sample for a full example of creating an extension with a dialog.