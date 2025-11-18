---
title: Error handling
description: Explains how to best handle errors and exceptions occurring in extensions
ms.date: 12/01/2021
ms.topic: article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Error handling in Visual Studio extensions

Exceptions will likely occur in any program including Visual Studio extensions. Let's make sure we handle them correctly in a way that optimizes the user experiences when they do occur.

If an exception is an anomaly that shouldn't happen, you want to log the details of the exception in a way you can fix it. Depending on the severity of the issue, you might also want to let the user know about it.

## Include the symbols
To ensure you have the most accurate information about the exception that happened, make sure to include the .pdb file in the extension. This is enabled by default, but make sure to check by showing the properties (F4) of your project.

:::image type="content" source="../media/include-pdb.png" alt-text="Include the PDB file in the VSIX container.":::

Make sure to set the property **Include Debug Symbols in VSIX Container** to **True**.

This sets you up to collect the information you need. Let's look at some strategies for doing that.

## Automated telemetry
You can use any telemetry mechanism you can use in any .NET application from your extension. Popular options are [Application Insights](/powerapps/maker/canvas-apps/application-insights), [Raygun](https://raygun.com/), [Google Analytics](https://analytics.google.com/) etc.

You'll manually have to report the exception details through these telemetry systems using their APIs. This option is a great way to stay on top of any issues that occur on your user's machines and allow you to proactive fix issues early.

When using this option, make sure to mention it in your privacy statement, since some users don't like reporting telemetry.

## Log to Output Window
When using `try/catch` blocks to handle exceptions, it may be advantageous to let the user know what went wrong. That way they can easily report the issue to you in a way that's easy for you to fix.

One of the best ways is to output the exception details to the Output Window. That way, the user can see an exception occurred and provide them with the stacktrace to send you in a bug report.

The Community Toolkit makes it super easy to do that. In synchronous contexts, simply use the `Log()` extension method on any `Exception`.

```csharp
try
{
    // Do work;
}
catch (Exception ex)
{
    ex.Log();
}
```

For asynchronous contexts, the same thing is done by awaiting the `LogAsync()` extension method.

```csharp
try
{
    // Do work;
}
catch (Exception ex)
{
    await ex.LogAsync();
}
```

## Notify the user
When the exception has low severity to the user, there is no reason to interrupt them. Consider using the status bar to show that an error occurred.

If the exception is severe and causes the user flow to be interrupted, consider using a message box to let the user know about the error. Make sure to still log the exception through telemetry and/or the Output Window as described previously.

To learn more about how to use the status bar and message boxes, see the [Notifications recipe](notifications.md).
