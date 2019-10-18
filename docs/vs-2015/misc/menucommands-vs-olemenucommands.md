---
title: "MenuCommands Vs. OleMenuCommands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "commands, creating in VSPackages"
  - "command buttons, creating and placing"
  - "menus, creating commands"
ms.assetid: 553d5e07-3e19-4aba-b490-6c7dd05fd82e
caps.latest.revision: 46
manager: jillfra
---
# MenuCommands Vs. OleMenuCommands
You can create menu commands by deriving either from <xref:System.ComponentModel.Design.MenuCommand> or from <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object, and implementing the appropriate event handlers. In the majority of cases you can use <xref:System.ComponentModel.Design.MenuCommand>, as the VSPackage project template does, but occasionally you may need to use <xref:Microsoft.VisualStudio.Shell.OleMenuCommand>.  
  
 The commands that a VSPackage makes available to the IDE must be visible and enabled before a user can use them. When commands are created in a .vsct file by using the Visual Studio Package project template, they are visible and enabled by default. Setting some command flags, such as `DynamicItemStart`, can change the default behavior. The visibility, enabled status, and other properties of a command can also be changed in code at run time by accessing the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object that is associated with the command.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## Template Locations for the Visual Studio Package Template  
 You can find the Visual Studio Package template in the **New Project** dialog under **Visual Basic / Extensibility**, **C# / Extensibility**, or **Other Project Types / Extensibility**.  
  
## Creating a Command  
 All commands, command groups, menus, toolbars, and tool windows are defined in the .vsct file. For more information, see [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).  
  
 If you are creating a VSPackage by using the package template, select **Menu Command** to create a .vsct file and define a default menu command. For more information, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).  
  
#### To add a command to the IDE  
  
1. Open the .vsct file.  
  
2. In the `Symbols` section, find the [GuidSymbol](../extensibility/guidsymbol-element.md) element that contains the groups and commands.  
  
3. Create an [IDSymbol](../extensibility/idsymbol-element.md) element for each menu, group, or command that you want to add, as shown in the following example.  
  
   ```xml
   <GuidSymbol name="guidButtonGroupCmdSet" value="{f69209e9-975a-4543-821d-1f4a2c52d737}">
     <IDSymbol name="MyMenuGroup" value="0x1020" />
     <IDSymbol name="cmdidMyCommand" value="0x0100" />
   </GuidSymbol>
   ```
      
    The `name` attributes of the `GuidSymbol` and `IDSymbol` elements provide the GUID:ID pair for each new menu, group, or command. The `guid` represents a command set that is defined for your VSPackage. You can define multiple command sets. Each GUID:ID pair must be unique.  
  
4. In the [Buttons](../extensibility/buttons-element.md) section, create a [Button](../extensibility/button-element.md) element to define the command, as shown in the following example.  
  
   ```xml
   <Button guid="guidButtonGroupCmdSet" id="cmdidMyCommand" priority="0x0100" type="Button">
     <Parent guid="guidButtonGroupCmdSet" id="MyMenuGroup" />
     <Icon guid="guidImages" id="bmpPic1" />
     <Strings>
       <CommandName>cmdidMyCommand</CommandName>
       <ButtonText>My Command name</ButtonText>
     </Strings>
   </Button>
   ``` 
     
   1. Set the `guid` and `id` fields to match the GUID:ID of the new command.  
  
   2. Set the `priority` attribute.  
  
        The `priority` attribute is used by the .vsct to determine the location of the button among the other objects in its parent group.  
  
        Commands that have lower priority values are displayed above, or to the left of, commands that have higher priority values. Duplicate priority values are permitted, but the relative position of commands that have equal priority is determined by the order in which VSPackages are processed at run time, and that order cannot be predetermined.  
  
        Omitting the `priority` attribute sets its value to 0.  
  
   3. Set the `type` attribute. In most cases, its value will be `"Button"`. For descriptions of other valid button types, see [Button Element](../extensibility/button-element.md).  
  
5. In the button definition, create a [Strings](../extensibility/strings-element.md) element that contains a [ButtonText](../extensibility/buttontext-element.md) element to contain the name of the menu as it appears in the IDE, and a [CommandName](../extensibility/commandname-element.md) element to contain the name of the command that is used to access the menu in the **Command** window.  
  
    If the button text string includes the '&' character, the user can open the menu by pressing ALT plus the character that immediately follows the '&'.  
  
    Adding a `Tooltip` element will cause the contained text to appear when a user hovers the pointer over the button.  
  
6. Add an [Icon](../extensibility/icon-element.md) element to specify the icon, if any, to be displayed with the command. Icons are required for buttons on toolbars but not for menu items. The `guid` and `id` of the `Icon` element must match those of a [Bitmap](../extensibility/bitmap-element.md) element defined in the `Bitmaps` section.  
  
7. Add command flags, as appropriate, to change the appearance and behavior of the button. To do this, add a [CommandFlag](../extensibility/command-flag-element.md) element in the menu definition.  
  
8. Set the parent group of the command. The parent group can be a group that you create, a group from another package, or a group from the IDE. For example, to add your command to the Visual Studio editing toolbar, next to the **Comment** and **Remove Comment** buttons, set the parent to guidStdEditor:IDG_VS_EDITTOOLBAR_COMMENT. If the parent is a user-defined group, it must be the child of a menu, toolbar, or tool window that appears in the IDE.  
  
    You can do this in one of two ways, depending on your design:  
  
   - In the `Button` element, create a [Parent](../extensibility/parent-element.md) element and set its `guid` and `id` fields to the Guid and ID of the group that will host the command, also known as the *primary parent group*.  
  
        The following example defines a command that will appear on a user-defined menu.  
  
       ```xml
       <Button guid="guidTopLevelMenuCmdSet" id="cmdidTestCommand" priority="0x0100" type="Button">
         <Parent guid="guidTopLevelMenuCmdSet" id="MyMenuGroup" />
         <Icon guid="guidImages" id="bmpPic1" />
         <Strings>
           <CommandName>cmdidTestCommand</CommandName>
           <ButtonText>Test Command</ButtonText>
             </Strings>
       </Button>
       ```
      
   - You may omit the `Parent` element if the command is to be positioned by using command placement. Create a [CommandPlacements](../extensibility/commandplacements-element.md) element before the `Symbols` section, and add a [CommandPlacement](../extensibility/commandplacement-element.md) element that has the `guid` and `id` of the command, a `priority`, and a parent, as shown in the following example.  
  
   ```xml
   <CommandPlacements>
     <CommandPlacement guid="guidButtonGroupCmdSet" id="cmdidMyCommand" priority="0x105">
       <Parent guid="guidButtonGroupCmdSet" id="MyMenuGroup" />
     </CommandPlacement>
   </CommandPlacements>
   ```
      
      Creating multiple command placements that have the same GUID:ID and have different parents causes a menu to appear in multiple locations. For more information, see [CommandPlacements](../extensibility/commandplacements-element.md) element.  
  
    For more information about command groups and parenting, see [Creating Reusable Groups of Buttons](../extensibility/creating-reusable-groups-of-buttons.md).  
  
   At this point, the command will be visible in the IDE, but will have no functionality. If the command was created by the package template, by default it will have a click handler that displays a message.  
  
## Handling the New Command  
 Most commands in managed code can be handled by the Managed Package Framework (MPF) by associating the command with a <xref:System.ComponentModel.Design.MenuCommand> object or <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object and implementing its event handlers.  
  
 For code that uses the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface directly for command handling, you must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface and its methods. The two most important methods are <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A>.  
  
1. Get the <xref:Microsoft.VisualStudio.Shell.OleMenuCommandService> instance, as shown in the following example.  
  
     [!code-csharp[ButtonGroup#21](../snippets/csharp/VS_Snippets_VSSDK/buttongroup/cs/buttongrouppackage.cs#21)]  
  
2. Create a <xref:System.ComponentModel.Design.CommandID> object that has as its parameters the GUID and ID of the command to handle, as shown in the following example.  
  
     [!code-csharp[ButtonGroup#22](../snippets/csharp/VS_Snippets_VSSDK/buttongroup/cs/buttongrouppackage.cs#22)]  
  
     The Visual Studio Package template provides two collections, `GuidList` and `PkgCmdIDList`, to hold the GUIDs and IDs of commands. These are populated automatically for commands that are added by the template, but for commands that you add manually, you must also add the ID entry to the `PkgCmdIdList` class.  
  
     Alternatively, you can populate the <xref:System.ComponentModel.Design.CommandID> object by using the raw string value of the GUID and the integer value of the ID.  
  
3. Instantiate either a <xref:System.ComponentModel.Design.MenuCommand> or <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object that specifies the method that handles the command together with the <xref:System.ComponentModel.Design.CommandID>, as shown in the following example.  
  
     [!code-csharp[ButtonGroup#23](../snippets/csharp/VS_Snippets_VSSDK/buttongroup/cs/buttongrouppackage.cs#23)]  
  
     The <xref:System.ComponentModel.Design.MenuCommand> is appropriate for static commands. Dynamic menu item displays require QueryStatus event handlers. The <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> adds the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus> event, which occurs when the host menu of the command is opened, and some other properties, such as <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.Text%2A>.  
  
     Commands created by the package template are passed by default to a <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object in the `Initialize()` method of the package class.  
  
4. The <xref:System.ComponentModel.Design.MenuCommand> is appropriate for static commands. Dynamic menu item displays require QueryStatus event handlers. The <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> adds the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus> event, which occurs when the host menu of the command is opened, and some other properties, such as <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.Text%2A>.  
  
     Commands created by the package template are passed by default to a <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object in the `Initialize()` method of the package class. The Visual Studio wizard implements the `Initialize` method by using `MenuCommand`. For dynamic menu item displays, you must change this to `OleMenuCommand`, as is shown in the next step. Furthermore, to change the menu item text, you must add a TextChanges command flag to the menu command button in the .vsct file, as is shown in the following example  
  
    ```xml
    <Button guid="guidMenuTextCmdSet" id="cmdidMyCommand" priority="0x0100" type="Button">
      <Parent guid="guidMenuTextCmdSet" id="MyMenuGroup" />
      <Icon guid="guidImages" id="bmpPic1" />
      <CommandFlag>TextChanges</CommandFlag>
      <Strings>
        <CommandName>cmdidMyCommand</CommandName>
        <ButtonText>My Command name</ButtonText>
      </Strings>
    </Button>
    ```
      
5. Pass the new menu command to the <xref:System.ComponentModel.Design.IMenuCommandService.AddCommand%2A> method in the <xref:System.ComponentModel.Design.IMenuCommandService> interface. This is accomplished by default for commands created by the package template, as shown in the following example  
  
     [!code-csharp[ButtonGroup#24](../snippets/csharp/VS_Snippets_VSSDK/buttongroup/cs/buttongrouppackage.cs#24)]  
  
6. Implement the method that handles the command.  
  
#### To implement QueryStatus  
  
1. The QueryStatus event occurs before a command is displayed. This enables properties of that command to be set in the event handler before it reaches the user. Only commands that are added as <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> objects can access this method.  
  
    Add an `EventHandler` object to the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus> event in the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object that is created to handle the command, as shown in the following example  (`menuItem` is the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> instance).  
  
    [!code-csharp[MenuText#14](../snippets/csharp/VS_Snippets_VSSDK/menutext/cs/menutextpackage.cs#14)]
    [!code-vb[MenuText#14](../snippets/visualbasic/VS_Snippets_VSSDK/menutext/vb/menutextpackage.vb#14)]  
  
    The `EventHandler` object is given the name of a method that is called when the status of the menu command is queried.  
  
2. Implement the query status handler method for the command. The `object` `sender` parameter can be cast to an <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object, which is used to set the various attributes of the menu command, including the text. The following table shows the properties on the <xref:System.ComponentModel.Design.MenuCommand> class (which the MPF class <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> derives from) that correspond to the <xref:Microsoft.VisualStudio.OLE.Interop.OLECMDF> flags.  
  
   |MenuCommand Property|OLECMDF flag|  
   |--------------------------|------------------|  
   |<xref:System.ComponentModel.Design.MenuCommand.Checked%2A> = `true`|<xref:Microsoft.VisualStudio.OLE.Interop.OLECMDF>|  
   |<xref:System.ComponentModel.Design.MenuCommand.Visible%2A> = `false`|<xref:Microsoft.VisualStudio.OLE.Interop.OLECMDF>|  
   |<xref:System.ComponentModel.Design.MenuCommand.Enabled%2A> = `true`|<xref:Microsoft.VisualStudio.OLE.Interop.OLECMDF>|  
  
    To change the text of a menu command, use the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.Text%2A> property on the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand> object, as shown in the following example.  
  
    [!code-csharp[MenuText#11](../snippets/csharp/VS_Snippets_VSSDK/menutext/cs/menutextpackage.cs#11)]
    [!code-vb[MenuText#11](../snippets/visualbasic/VS_Snippets_VSSDK/menutext/vb/menutextpackage.vb#11)]  
  
   The MPF automatically handles the case of unsupported or unknown groups. Unless a command has been added to the <xref:Microsoft.VisualStudio.Shell.OleMenuCommandService> by using the <xref:System.ComponentModel.Design.IMenuCommandService.AddCommand%2A> method, the command is not supported.  
  
### Handling Commands By Using the IOleCommandTarget Interface  
 For code that uses the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface directly, the VSPackage must implement both the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> methods of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. If the VSPackage implements a project hierarchy, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand%2A> methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface should be implemented instead.  
  
 Both the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> methods are designed to receive a single command set `GUID` and an array of command IDs as input. We recommend that VSPackages fully support this concept of multiple IDs in one call. However, as long as a VSPackage is not called from other VSPackages, you can assume that the command array contains only one command ID because the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> and <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> methods are executed in a well-defined order. For more information about routing, see [Command Routing in VSPackages](../extensibility/internals/command-routing-in-vspackages.md).  
  
 For code that uses the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface directly for command handling, you must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method in the VSPackage as follows to handle commands.  
  
##### To implement the QueryStatus method  
  
1. Return <xref:Microsoft.VisualStudio.VSConstants.S_OK> for valid commands.  
  
2. Set the `cmdf` element of the `prgCmds` parameter.  
  
    The value of the `cmdf` element is the logical union of values from the <xref:Microsoft.VisualStudio.OLE.Interop.OLECMDF> enumeration, combined by using the logical OR (`|`) operator.  
  
    Use the appropriate enumeration, based on the status of the command:  
  
   - If the command is supported:  
  
      `prgCmds[0].cmdf = OLECMDF_SUPPORTED;`  
  
   - If the command should be invisible at the moment:  
  
      `prgCmds[0].cmdf |= OLECMDF_INVISIBLE;`  
  
   - If the command is toggled on and appears to have been clicked:  
  
      `prgCmds[0].cmdf |= OLECMDF_LATCHED;`  
  
      In the case of processing commands that are hosted on a menu of type `MenuControllerLatched`, the first command that is marked by the `OLECMDF_LATCHED` flag is the default command that is displayed by the menu on start-up. For more information about `MenuController` menu types, see [Menu Element](../extensibility/menu-element.md).  
  
   - If the command is currently enabled:  
  
      `prgCmds[0].cmdf |= OLECMDF_ENABLED;`  
  
   - If the command is part of a shortcut menu and is hidden by default:  
  
      `prgCmds[0] cmdf |= OLECMDF_DEFHIDEONCTXMENU`  
  
   - If the command uses the `TEXTCHANGES` flag, set the `rgwz` element of the `pCmdText` parameter to the new text of the command and set the `cwActual` element of the `pCmdText` parameter to the size of the command string.  
  
     For error conditions, the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method must handle the following error cases:  
  
   - If the GUID is unknown or not supported, return `OLECMDERR_E_UNKNOWNGROUP`.  
  
   - If the GUID is known but the command ID is unknown or not supported, return `OLECMDERR_E_NOTSUPPORTED`.  
  
   The VSPackage implementation of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method must also return specific error codes, depending on whether the command is supported and whether the command was handled successfully.  
  
##### To implement the Exec method  
  
- If the command `GUID` is unknown, return `OLECMDERR_E_UNKNOWNGROUP`.  
  
- If the `GUID` is known but the command ID is unknown, return `OLECMDERR_E_NOTSUPPORTED`.  
  
- If the `GUID` and command ID match the GUID:ID pair that is used by the command in the .vsct file, execute the code that is associated with the command and return <xref:Microsoft.VisualStudio.VSConstants.S_OK>.  
  
## See also  
 [VSCT XML Schema Reference](../extensibility/vsct-xml-schema-reference.md)   
 [Extending Menus and Commands](../extensibility/extending-menus-and-commands.md)
