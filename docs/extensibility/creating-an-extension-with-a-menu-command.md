---
title: Creating an Extension with a Menu Command
description: Create an extension with a menu command that launches Notepad, create a menu command, and change the menu command handler in Visual Studio.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- write a vspackage
- vspackage
- tutorials
- visual studio package
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an extension with a menu command

This walkthrough shows how to create an extension with a menu command that launches Notepad.

## Create a menu command

1. Create a VSIX project named **FirstMenuCommand**. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. When the project opens, add a custom command item template named **FirstCommand**. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **C# Items** > **Extensibility** and select **Command**. In the **Name** field at the bottom of the window, change the command file name to *FirstCommand.cs*.

3. Build the project and start debugging.

    The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The experimental instance](../extensibility/the-experimental-instance.md).

4. In the experimental instance, open the **Extensions** > **Manage Extensions** window. You should see the **FirstMenuCommand** extension here. (If you open **Manage Extensions** in your working instance of Visual Studio, you won't see **FirstMenuCommand**).

Now go to the **Tools** menu in the experimental instance. You should see **Invoke FirstCommand** command. At this point, the command brings up a message box that says **FirstCommand Inside FirstMenuCommand.FirstCommand.MenuItemCallback()**. We'll see how to actually start Notepad from this command in the next section.

## Change the menu command handler

Now let's update the command handler to start Notepad.

1. Stop debugging and go back to your working instance of Visual Studio. Open the *FirstCommand.cs* file and add the following using statement:

    ```csharp
    using System.Diagnostics;
    ```

2. Find the private FirstCommand constructor. This is where the command is hooked up to the command service and the command handler is specified. Change the name of the command handler to StartNotepad, as follows:

    ```csharp
    private FirstCommand(AsyncPackage package, OleMenuCommandService commandService)
    {
        this.package = package ?? throw new ArgumentNullException(nameof(package));
        commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

        CommandID menuCommandID = new CommandID(CommandSet, CommandId);
        // Change to StartNotepad handler.
        MenuCommand menuItem = new MenuCommand(this.StartNotepad, menuCommandID);
        commandService.AddCommand(menuItem);
    }
    ```

3. Remove the `Execute` method and add a `StartNotepad` method, which will just start Notepad:

    ```csharp
    private void StartNotepad(object sender, EventArgs e)
    {
        ThreadHelper.ThrowIfNotOnUIThread();

        Process proc = new Process();
        proc.StartInfo.FileName = "notepad.exe";
        proc.Start();
    }
    ```

4. Now try it out. When you start debugging the project and click **Tools** > **Invoke FirstCommand**, you should see an instance of Notepad come up.

    You can use an instance of the <xref:System.Diagnostics.Process> class to run any executable, not just Notepad. Try it with `calc.exe`, for example.

## Clean up the experimental environment

If you are developing multiple extensions, or just exploring outcomes with different versions of your extension code, your experimental environment may stop working the way it should. In this case, you should run the reset script. It's called **Reset the Visual Studio Experimental Instance**, and it ships as part of the Visual Studio SDK. This script removes all references to your extensions from the experimental environment, so you can start from scratch.

You can get to this script in one of two ways:

:::moniker range="vs-2019"
1. From the desktop, find **Reset the Visual Studio Experimental Instance**.

2. From the command line, run the *CreateExpInstance.exe* command. It's located in the Visual Studio installation folder under *VSSDK\Common\Tools\Bin*. You can construct it's full path and enclose the full path in quotes to invoke it. For example, if Visual Studio is installed to *C:\Program Files\Microsoft Visual Studio\2019\Community*, then the command is:

    ```cmd
    "C:\Program Files\Microsoft Visual Studio\2019\Community\CreateExpInstance.exe" /Reset /VSInstance=<version> /RootSuffix=Exp && PAUSE

    ```
:::moniker-end

:::moniker range="vs-2022"
1. From the desktop, find **Reset the Visual Studio Experimental Instance**.

2. From the command line, run the *CreateExpInstance.exe* command. It's located in the Visual Studio installation folder under *VSSDK\Common\Tools\Bin*. You can construct it's full path and enclose the full path in quotes to invoke it. For example, if Visual Studio is installed to *C:\Program Files\Microsoft Visual Studio\2022\Community*, then the command is:

    ```cmd
    "C:\Program Files\Microsoft Visual Studio\2022\Community\CreateExpInstance.exe" /Reset /VSInstance=<version> /RootSuffix=Exp && PAUSE

    ```
:::moniker-end
:::moniker range="visualstudio"
1. From the desktop, find **Reset the Visual Studio Experimental Instance**.

2. From the command line, run the *CreateExpInstance.exe* command. It's located in the Visual Studio installation folder under *VSSDK\Common\Tools\Bin*. You can construct it's full path and enclose the full path in quotes to invoke it. For example, if Visual Studio is installed to *C:\Program Files\Microsoft Visual Studio\18\Community*, then the command is:

    ```cmd
    "C:\Program Files\Microsoft Visual Studio\18\Community\CreateExpInstance.exe" /Reset /VSInstance=<version> /RootSuffix=Exp && PAUSE

    ```
:::moniker-end

## Deploy your extension

Now that you have your tool extension running the way you want, it's time to think about sharing it with your friends and colleagues. That's easy, as long as they have Visual Studio 2015 installed. All you have to do is send them the *.vsix* file you built. (Be sure to build it in Release mode.)

You can find the *.vsix* file for this extension in the *FirstMenuCommand* bin directory. Specifically, assuming you have built the Release configuration, it will be in:

*\<code directory>\FirstMenuCommand\FirstMenuCommand\bin\Release\FirstMenuCommand.vsix*

To install the extension, your friend needs to close all open instances of Visual Studio, then double-click the *.vsix* file, which brings up the **VSIX Installer**. The files are copied to the *%LocalAppData%\Microsoft\VisualStudio\<version>\Extensions* directory.

When your friend brings up Visual Studio again, they'll find the FirstMenuCommand extension in **Tools** > **Extensions and Updates**. They can go to **Extensions and Updates** to uninstall or disable the extension, too.

## Next steps

This walkthrough has shown you only a small part of what you can do with a Visual Studio extension. Here's a short list of other (reasonably easy) things you can do with Visual Studio extensions:

1. You can do many more things with a simple menu command:

   1. Add your own icon: [Add icons to menu commands](../extensibility/adding-icons-to-menu-commands.md)

   2. Change the text of the menu command: [Change the text of a menu command](../extensibility/changing-the-text-of-a-menu-command.md)

   3. Add a menu shortcut to a command: [Bind keyboard shortcuts to menu items](../extensibility/binding-keyboard-shortcuts-to-menu-items.md)

2. Add different kinds of commands, menus, and toolbars: [Extend menus and commands](../extensibility/extending-menus-and-commands.md)

3. Add tool windows and extend the built-in Visual Studio tool windows: [Extend and Customize tool windows](../extensibility/extending-and-customizing-tool-windows.md)

4. Add IntelliSense, code suggestions, and other features to existing code editors: [Extend the editor and language services](../extensibility/extending-the-editor-and-language-services.md)

5. Add Options and Property pages and user settings to your extension: [Extend properties and the Property window](/previous-versions/visualstudio/visual-studio-2017/extensibility/extending-properties-and-the-property-window) and [Extend user settings and options](../extensibility/extending-user-settings-and-options.md)

   Other kinds of extensions require a little more work, such as creating a new type of project ([Extend projects](../extensibility/extending-projects.md)), or creating a new type of editor ([Create custom editors and designers](../extensibility/creating-custom-editors-and-designers.md)).
