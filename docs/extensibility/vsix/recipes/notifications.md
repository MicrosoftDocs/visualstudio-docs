---
title: Notifications
description: A recipe for the various different ways to show notifications to users.
ms.date: 12/01/2021
ms.topic: concept-article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Displaying notifications in Visual Studio extensions

There are several mechanisms for displaying notifications to the user of your extension. Picking the right one can be challenging, so let's look at the options.

* Status bar
* Info bar
* Message box
* Output window

They are used for different purposes and have different levels of demand on the users attention.

Use the **status bar** to inform the user of an event that doesn't require any action or input from the user. If they miss the notification in the status bar, then that's ok - it wasn't critical for them to see it.

If you want to grab the attention of the user and present them with some actions for them to take, use the **info bar**. They don't have to do it right away, they can wait until they are done with what they are doing. The notification is important, but not critical.

When the notification must block the current user from continuing what they are doing, use a **message box**. This is a blocking and critical notification.

To inform the user about non-critical errors, use the **Output Window**. You can bring focus to the Output Window if you want to make sure the users sees it, but it is recommended that you don't.

## Status bar
A status bar is an area at the bottom of a primary window that displays information about the current window's state (such as what is being viewed and how), background tasks (such as printing, scanning, and formatting), or other contextual information (such as selection and keyboard state).

:::image type="content" source="../media/status-bar.png" alt-text="Status bar showing custom text.":::

Use the status bar when you don't need to take the full attention of the user, but still give them information.

### Set the text
This will set the text in the status bar to any string.

```csharp
// call it from an async context
await VS.StatusBar.ShowMessageAsync("My text");

// or from a synchronous method:
VS.StatusBar.ShowMessageAsync("My text").FireAndForget();
```

### Animation icon
Adding an animation icon to the status bar is easy.

:::image type="content" source="../media/status-bar-animation.gif" alt-text="Status bar animating using the StatusAnimation.Sync icon.":::

Simply specify which animation icon to use.

```csharp
// call it from an async context
await VS.StatusBar.StartAnimationAsync(StatusAnimation.Sync);

// or from a synchronous method:
VS.StatusBar.StartAnimationAsync(StatusAnimation.Sync).FireAndForget();
```

Stop the animation again by calling `EndStatusbarAnimationAsync`.

```csharp
// call it from an async context
await VS.StatusBar.EndAnimationAsync(StatusAnimation.Sync);

// or from a synchronous method:
VS.StatusBar.EndAnimationAsync(StatusAnimation.Sync).FireAndForget();
```

## Info bar
An Info Bar is a yellow bar at the top of a tool- or document window. It's useful for grabbing the attention of the user without blocking them. An Info Bar can contain an icon, text, and several hyperlinks.

:::image type="content" source="../media/info-bar-solution-explorer.png" alt-text="An Info Bar showing in Solution Explorer.":::

Here's how to add an Info Bar to the Solution Explorer tool window.

```csharp
var model = new InfoBarModel(
    new[] {
        new InfoBarTextSpan("The text in the Info Bar. "),
        new InfoBarHyperlink("Click me")
    },
    KnownMonikers.PlayStepGroup,
    true);

InfoBar infoBar = VS.InfoBar.CreateInfoBar(ToolWindowGuids80.SolutionExplorer, model);
infoBar.ActionItemClicked += InfoBar_ActionItemClicked;
await infoBar.TryShowInfoBarUIAsync();

...

private void InfoBar_ActionItemClicked(object sender, InfoBarActionItemEventArgs e)
{
    ThreadHelper.ThrowIfNotOnUIThread();

    if (e.ActionItem.Text == "Click me")
    {
        // do something
    }
}
```

To add an Info Bar to a document window, simply pass in a file name of an open document to the `VS.Notifications.CreateInfoBar(fileName, model)` method.

:::image type="content" source="../media/info-bar-document.png" alt-text="An Info Bar showing at the top of a document.":::

If you want to the Info Bar directly to an `ITextView`, then you can do that with this handy extension method:

```csharp
InfoBar infoBar = textView.CreateInfoBar(model);
```

## Message box
There are various ways of showing a message box using .NET. For instance through Windows Forms or WPF. They cause some issues in Visual Studio extensions with parenting correctly against the main window, so it is recommended to use Visual Studio's own message box.

:::image type="content" source="../media/message-box.png" alt-text="Native Visual Studio message box.":::

Use a message box when you need to block the UI to get the full attention of the user.

```csharp
// Simple text box
VS.MessageBox.Show("Title", "The message");

// Async and with buttons defined
await VS.MessageBox.ShowAsync("Title", "The message", OLEMSGICON.OLEMSGICON_INFO, OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL);   
```

## Output Window
Use the Output Window to display information about exceptions and other textual information.

:::image type="content" source="../media/output-window.png" alt-text="Text written to custom Output Window pane.":::

Creating a custom Output Window pane and write to it is straight forward when using the `VS.Windows.CreateOutputWindowPaneAsync` method.

```csharp
OutputWindowPane pane = await VS.Windows.CreateOutputWindowPaneAsync("Name of pane");
await pane.WriteLineAsync("Line 1");
await pane.WriteLineAsync("Line 2");
await pane.WriteLineAsync("Line 3");

```

See the [Error handling recipe](handle-errors.md) for more info on logging exceptions.
