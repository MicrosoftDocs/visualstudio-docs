---
title: Changing the Appearance of a Command
description: Learn how to provide feedback changing the appearance of a command, such as making commands available/unavailable, hidden/shown, or checked/unchecked.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- commands, changing appearance
- menu commands, changing appearance
- menus, changing command appearance
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Change the appearance of a command

You can provide feedback to your user by changing the appearance of a command. For example, you may want a command to look different when it is unavailable. You can make commands available or unavailable, hide or show them, or check or uncheck them on the menu.

To change the appearance of a command, perform one of these actions:

- Specify the appropriate flags in the command definition in the command table file.

- Use the <xref:Microsoft.VisualStudio.Shell.OleMenuCommandService> service.

- Implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface and modify the raw command objects.

  The following steps show how to find and update the appearance of a command by using the Managed Package Framework (MPF).

### To change the appearance of a menu command

1. Follow the instructions in [Change the text of a menu command](../extensibility/changing-the-text-of-a-menu-command.md) to create a menu item named `New Text`.

2. In the *ChangeMenuText.cs* file, add the following using statement:

    ```csharp
    using System.Security.Permissions;
    ```

3. In the *ChangeMenuTextPackageGuids.cs* file, add the following line:

    ```csharp
    public const string guidChangeMenuTextPackageCmdSet= "00000000-0000-0000-0000-00000000";  // get the GUID from the .vsct file
    ```

4. In the *ChangeMenuText.cs* file, replace the code in the ShowMessageBox method with the following:

    ```csharp
    private void Execute(object sender, EventArgs e)
    {
        ThreadHelper.ThrowIfNotOnUIThread();
        var command = sender as OleMenuCommand;
        if (command.Text == "New Text")
            ChangeMyCommand(command.CommandID.ID, false);
    }
    ```

5. Obtain the command that you want to update from the <xref:Microsoft.VisualStudio.Shell.OleMenuCommandService> object and then set the appropriate properties on the command object. For example, the following method makes the specified command from a VSPackage command set available or unavailable. The following code makes the menu item named `New Text` unavailable after it has been clicked.

    ```csharp
    public bool ChangeMyCommand(int cmdID, bool enableCmd)
    {
        bool cmdUpdated = false;
        var mcs = this.package.GetService<IMenuCommandService, OleMenuCommandService>();
        var newCmdID = new CommandID(new Guid(ChangeMenuTextPackageGuids.guidChangeMenuTextPackageCmdSet), cmdID);
        MenuCommand mc = mcs.FindCommand(newCmdID);
        if (mc != null)
        {
            mc.Enabled = enableCmd;
            cmdUpdated = true;
        }
        return cmdUpdated;
    }
    ```

6. Build the project and start debugging. The experimental instance of Visual Studio should appear.

7. On the **Tools** menu, click the **Invoke ChangeMenuText** command. At this point the command name is **Invoke ChangeMenuText**, so the command handler doesn't call **ChangeMyCommand()**.

8. On the **Tools** menu you should now see **New Text**. Click **New Text**. The command should now be grayed out.

## Related content
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
- [How VSPackages add user interface elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Extending menus and commands](../extensibility/extending-menus-and-commands.md)
- [Visual Studio command table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
