---
title: "Create Visual Studio extensions with C# & .NET Framework"
description: Create a Visual Studio extension with the .NET Framework and C# and an existing project template file, such as Empty VSIX Project (Community).
ms.date: 12/01/2021
ms.topic: conceptual
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Your first Visual Studio extension

This article walks you through some simple steps to get your first Visual Studio extension up and running. A Visual Studio extension is written using the .NET Framework and C#. If you're already a .NET developer, you will find that writing extensions is similar to writing most other .NET programs and libraries.

The extension you'll be writing today adds a command that inserts a new guid into the text editor when executed. It's simple, useful, and provides a good introduction to the various aspects of extension development.

If you're a visual learner, check out this short video of someone following the tutorial.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=fbe3f134-ac8d-461b-aa19-b114e73e0090]

Before you start writing your first Visual Studio extension (it's easy, I promise!), make sure you've got the [tools needed](get-tools.md).

## Create the project
There are several project templates to choose from, so you want to make the right choice. The templates used in this community toolkit, all have the moniker **(Community)** in the name.

The **VSIX Project w/Command (Community)** template comes with a command hooked up, making it easy to start from there. This is a great starting point for most extensions. If you know you want a tool window, use the **VSIX Project w/Tool Window (Community)** template. It also has a command to open the tool window.

Use the **Empty VSIX Project (Community)** or **VSIX Project (Community)** templates for MEF-only extensions or other advanced scenarios.

This time, you'll select the **VSIX Project w/Command (Community)** template, as shown in the screenshot below.

:::image type="content" source="../media/new-project-dialog.png" alt-text="New Project Dialog showing VSIX project templates.":::

After selecting the project template, you need to give your project a name. Call it **InsertGuid**.

:::image type="content" source="../media/configure-new-project.png" alt-text="Configure your new project.":::

After hitting the **Create** button, you should end up with a basic VSIX Project looking like this:

:::image type="content" source="../media/new-project-files.png" alt-text="New project files and folders.":::

## Important files
Let's go over the most important files.

**InsertGuidPackage.cs** is what is referred to as the Package class. Its `InitializeAsync(...)` method is called by Visual Studio to initialize your extension. It's from here you add event listeners and register commands, tool windows, settings and other things.

**source.extension.vsixmanifest** is the manifest file for your extension. It contains meta data such as title and description, but also information about what the extension contains.

**VSCommandTable.vsct** is an XML file where commands and key bindings are declaratively defined, so they can be registered with Visual Studio.

**Commands/MyCommand.cs** is the command handler for the command defined in the *VSCommandTable.vsct* file. It controls what happens when the command is executed by clicking the button.

## Modifying the command
First, you want to make sure your command has the right name, icon, and position within the Visual Studio menu system.

Open the *VSCommandTable.vsct* file and find a `<Group>` and a `<Button>`. Notice how the button specifies the group as being its parent and the group's parent is the built-in *VSMainMenu/Tools* menu.

For your extension, you want the *Insert GUID* command button to be under the *Edit* main menu, so you are going to re-parent the group to the Edit menu. Replace *Tools* with *Edit* just like in the following snippet:

```xml
<Group guid="InsertGuid" id="MyMenuGroup" priority="0x0600">
  <Parent guid="VSMainMenu" id="Edit"/>
</Group>
```

You get full IntelliSense for the placements to make it easy to find the right spot.

:::image type="content" source="../media/vsct-parent-intellisense.png" alt-text="VSCT parent IntelliSense.":::

The `<Button>` needs updating as well. You'll give it a new icon by updating the `id` attribute of the `<Icon>` element to *PasteAppend*. Update the `<ButtonText>` text with a good, descriptive name, and update the `<LocCanonicalName>` with the technical name of your command - this is the name shown to users when they assign custom keyboard shortcuts to your command in the **Tools > Options > Environment > Keyboard** dialog.

```xml
<Button guid="InsertGuid" id="MyCommand" priority="0x0100" type="Button">
  <Parent guid="InsertGuid" id="MyMenuGroup" />
  <Icon guid="ImageCatalogGuid" id="PasteAppend" />
  <CommandFlag>IconIsMoniker</CommandFlag>
  <Strings>
    <ButtonText>Insert GUID</ButtonText>
    <LocCanonicalName>.Edit.InsertGuid</LocCanonicalName>
  </Strings>
</Button>
```

>[!NOTE]
> Always start the `<LocCanonicalName>` with a dot character. It ensures no other text is automatically pre-pended, and the dot will not be shown.  

You can use the thousands of icons available within Visual Studio's image library and even get a preview shown in IntelliSense:

:::image type="content" source="../media/vsct-icon-intellisense.png" alt-text="VSCT icon IntelliSense.":::

Now, you've updated the name, icon, and location of our command and it's time to write some code to insert the guid into the text editor.

Open the */Commands/MyCommand.cs* file and modify it to insert a new guid when executed:

```csharp
using System;
using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace InsertGuid
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await Package.JoinableTaskFactory.SwitchToMainThreadAsync();
            DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
            if (docView?.TextView == null) return;
            SnapshotPoint position = docView.TextView.Caret.Position.BufferPosition;
            docView.TextBuffer?.Insert(position, Guid.NewGuid().ToString()); 
        }
    }
}
```

You're using the `VS` object to get the active editor text view, and then insert the guid at its text buffer's caret position. `VS` is a static object that provides access to Visual Studio IDE UI elements; see its definition in [VS.cs](https://github.com/VsixCommunity/Community.VisualStudio.Toolkit/blob/master/src/toolkit/Community.VisualStudio.Toolkit.Shared/VS.cs) in the [VSIX Community Toolkit GitHub repository](https://github.com/VsixCommunity/Community.VisualStudio.Toolkit/tree/master).

>[!NOTE]
> You'll see `await JoinableTaskFactory.SwitchToMainThreadAsync()` and `ThreadHelper.ThrowIfNotOnUIThread()` in many places in this community toolkit. They handle thread switching best practices and you don't need to know when and how to use them at this point - compiler warnings with Code Fixes (light bulbs) makes that super easy.

The first draft of our extension is now complete and it is time to test it.

## Running and debugging
Running your extension is as easy as running any other .NET project. Simply hit *F5* to run with the debugger attached or *Ctrl+F5* for running without.

Doing so will start the Experimental Instance of Visual Studio with your extension installed. The Experimental Instance is your regular version of Visual Studio, but with separate settings and extensions installed. It helps keep things separate.

When the Experimental Instance starts up, you should see the *Insert GUID* command in the *Edit* main menu.

:::image type="content" source="../media/insert-guid-command.png" alt-text="Insert GUID command located in the Edit main menu.":::

Open any text based file and execute the command to insert a new guid. That's it!

## Summary
You've now created your first extension that adds a command button to the main menu and interacts with the text editor when executed.

Congratulations!!

You can find the code for this extension in the [samples repository](https://github.com/VsixCommunity/Samples).

## Related content

* [Anatomy of extensions](extension-anatomy.md)
* [Menus & Commands](../recipes/menus-buttons-commands.md)
* [Best practices checklist](../publish/checklist.md)
