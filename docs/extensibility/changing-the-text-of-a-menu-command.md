---
title: Changing the Text of a Menu Command
description: Learn how to change the text label of a menu command by using the IMenuCommandService service by reviewing this code example.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- menus, changing text
- text, menus
- commands, changing text
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Change the text of a menu command

The following steps show how to change the text label of a menu command by using the <xref:System.ComponentModel.Design.IMenuCommandService> service.

## Changing a menu command label with the IMenuCommandService

1. Create a VSIX project named `MenuText` with a menu command named **ChangeMenuText**. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. In the *.vsct* file, add the `TextChanges` flag to your menu command, as shown in the following example.

    ```xml
    <Button guid="guidChangeMenuTextPackageCmdSet" id="ChangeMenuTextId" priority="0x0100" type="Button">
        <Parent guid="guidChangeMenuTextPackageCmdSet" id="MyMenuGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <CommandFlag>TextChanges</CommandFlag>
        <Strings>
            <ButtonText>Invoke ChangeMenuText</ButtonText>
        </Strings>
    </Button>
    ```

3. In the *ChangeMenuText.cs* file, create an event handler that will be called before the menu command is displayed.

    ```csharp
    private void OnBeforeQueryStatus(object sender, EventArgs e)
    {
        var myCommand = sender as OleMenuCommand;
        if (null != myCommand)
        {
            myCommand.Text = "New Text";
        }
    }
    ```

    You can also update the status of the menu command in this method by changing the <xref:System.ComponentModel.Design.MenuCommand.Visible%2A>, <xref:System.ComponentModel.Design.MenuCommand.Checked%2A>, and <xref:System.ComponentModel.Design.MenuCommand.Enabled%2A> properties on the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object.

4. In the ChangeMenuText constructor, replace the original command initialization and placement code with code that creates a <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> (rather than a `MenuCommand`) that represents the menu command, adds the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus> event handler, and gives the menu command to the menu command service.

    Here is what it should look like:

    ```csharp
    private ChangeMenuText(AsyncPackage package, OleMenuCommandService commandService)
    {
        this.package = package ?? throw new ArgumentNullException(nameof(package));
        commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));
        
        var menuCommandID = new CommandID(CommandSet, CommandId);
        var menuItem = new OleMenuCommand(this.Execute, menuCommandID);
        menuItem.BeforeQueryStatus += new EventHandler(OnBeforeQueryStatus);
        commandService.AddCommand(menuItem);
    }
    ```

5. Build the project and start debugging. The experimental instance of Visual Studio appears.

6. On the **Tools** menu you should see a command named **Invoke ChangeMenuText**.

7. Click the command. You should see the message box announcing that **MenuItemCallback** has been called. When you dismiss the message box, you should see that the name of the command on the Tools menu is now **New Text**.
