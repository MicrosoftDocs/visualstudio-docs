---
title: "Changing the Text of a Menu Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "menus, changing text"
  - "text, menus"
  - "commands, changing text"
ms.assetid: 5cb676a0-c6e2-47e5-bd2b-133dc8842e46
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# Changing the Text of a Menu Command
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The following steps show how to change the text label of a menu command by using the <xref:System.ComponentModel.Design.IMenuCommandService> service.  
  
## Changing a menu command label with the IMenuCommandService  
  
1. Create a VSIX project named `MenuText` with a menu command named **ChangeMenuText**. For more information, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).  
  
2. In the .vstc file, add the `TextChanges` flag to your menu command, as shown in the following example.  
  
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
  
3. In the ChangeMenuText.cs file, create an event handler that will be called before the menu command is displayed.  
  
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
    private ChangeMenuText(Package package)  
    {  
        if (package == null)  
        {  
            throw new ArgumentNullException(nameof(package));  
        }  
  
        this.package = package;  
  
        OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;  
        if (commandService != null)  
        {  
            CommandID menuCommandID = new CommandID(MenuGroup, CommandId);  
            EventHandler eventHandler = this.ShowMessageBox;  
            OleMenuCommand menuItem = new OleMenuCommand(ShowMessageBox, menuCommandID);  
            menuItem.BeforeQueryStatus +=  
                new EventHandler(OnBeforeQueryStatus);  
            commandService.AddCommand(menuItem);  
        }  
    }  
    ```  
  
5. Build the project and start debugging. The experimental instance of Visual Studio appears.  
  
6. On the **Tools** menu you should see a command named **Invoke ChangeMenuText**.  
  
7. Click the command. You should see the message box announcing that MenuItemCallback has been called. When you dismiss the message box, you should see that the name of the command on the Tools menu is now **New Text**.
