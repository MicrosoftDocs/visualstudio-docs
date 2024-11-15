---
title: Add a Tool Window & integrate into Visual Studio
description: Create a tool window and integrate it into Visual Studio by adding a control and a toolbar containing a command to the tool window.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tutorials
- tool windows
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add a tool window

In this walkthrough you learn how to create a tool window and integrate it into Visual Studio in the following ways:

- Add a control to the tool window.

- Add a toolbar to a tool window.

- Add a command to the toolbar.

- Implement the commands.

- Set the default position for the tool window.

## Prerequisites

The Visual Studio SDK is included as an optional feature in Visual Studio setup. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create a tool window

1. Create a project named **FirstToolWindow** using the VSIX template, and add a custom tool window item template named **FirstToolWindow**.

    > [!NOTE]
    > For more information about creating an extension with a tool window, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

## Add a control to the tool window

1. Remove the default control. Open *FirstToolWindowControl.xaml* and delete the **Click Me!** button.

2. In the **Toolbox**, expand the **All WPF Controls** section and drag the **Media Element** control to the **FirstToolWindowControl** form. Select the control, and in the **Properties** window, name this element **mediaElement1**.

## Add a toolbar to the tool window
By adding a toolbar in the following manner, you guarantee that its gradients and colors are consistent with the rest of the IDE.

1. In **Solution Explorer**, open *FirstToolWindowPackage.vsct*. The *.vsct* file defines the graphical user interface (GUI) elements in your tool window by using XML.

2. In the `<Symbols>` section, find the `<GuidSymbol>` node whose `name` attribute is `guidFirstToolWindowPackageCmdSet`. Add the following two `<IDSymbol>` elements to the list of `<IDSymbol>` elements in this node to define a toolbar and a toolbar group.

    ```xml
    <IDSymbol name="ToolbarID" value="0x1000" />
    <IDSymbol name="ToolbarGroupID" value="0x1001" />
    ```

3. Just above the `<Buttons>` section, create a `<Menus>` section that resembles this:

    ```xml
    <Menus>
        <Menu guid="guidFirstToolWindowPackageCmdSet" id="ToolbarID" priority="0x0000" type="ToolWindowToolbar">
            <Parent guid="guidFirstToolWindowPackageCmdSet" id="ToolbarID" />
            <Strings>
                <ButtonText>Tool Window Toolbar</ButtonText>
                <CommandName>Tool Window Toolbar</CommandName>
            </Strings>
        </Menu>
    </Menus>
    ```

    There are several different kinds of menu. This menu is a toolbar in a tool window, defined by its `type` attribute. The `guid` and `id` settings make up the fully qualified ID of the toolbar. Typically, the `<Parent>` of a menu is the containing group. However, a toolbar is defined as its own parent. Therefore, the same identifier is used for the `<Menu>` and `<Parent>` elements. The `priority` attribute is just '0'.

4. Toolbars resemble menus in many ways. For example, just as a menu may have groups of commands, toolbars may also have groups. (On menus, the command groups are separated by horizontal lines. On toolbars, the groups are not separated by visual dividers.)

    Add a `<Groups>` section that contains a `<Group>` element. This defines the group whose ID you declared in the `<Symbols>` section. Add the `<Groups>` section just after the `<Menus>` section.

    ```xml
    <Groups>
        <Group guid="guidFirstToolWindowPackageCmdSet" id="ToolbarGroupID" priority="0x0000">
            <Parent guid="guidFirstToolWindowPackageCmdSet" id="ToolbarID" />
        </Group>
    </Groups>
    ```

    By setting the parent GUID and ID to the GUID and ID of the toolbar, you add the group to the toolbar.

## Add a command to the toolbar

Add a command to the toolbar, which is displayed as a button.

1. In the `<Symbols>` section, declare the following IDSymbol elements just after the toolbar and toolbar group declarations.

    ```xml
    <IDSymbol name="cmdidWindowsMedia" value="0x0100" />
    <IDSymbol name="cmdidWindowsMediaOpen" value="0x132" />
    ```

2. Add a Button element inside the `<Buttons>` section. This element will appear on the toolbar in the tool window, with a **Search** (magnifying glass) icon.

    ```xml
    <Button guid="guidFirstToolWindowPackageCmdSet" id="cmdidWindowsMediaOpen" priority="0x0101" type="Button">
        <Parent guid="guidFirstToolWindowPackageCmdSet" id="ToolbarGroupID"/>
        <Icon guid="guidImages" id="bmpPicSearch" />
        <Strings>
            <CommandName>cmdidWindowsMediaOpen</CommandName>
            <ButtonText>Load File</ButtonText>
        </Strings>
    </Button>
    ```

3. Open *FirstToolWindowCommand.cs* and add the following lines in the class just after the existing fields.

    ```csharp
    public const string guidFirstToolWindowPackageCmdSet = "00000000-0000-0000-0000-0000";  // get the GUID from the .vsct file
    public const uint cmdidWindowsMedia = 0x100;
    public const int cmdidWindowsMediaOpen = 0x132;
    public const int ToolbarID = 0x1000;
    ```

    Doing this makes your commands available in code.

## Add a MediaPlayer property to FirstToolWindowControl
From the event handlers for the toolbar controls, your code must be able to access the Media Player control, which is a child of the FirstToolWindowControl class.

In **Solution Explorer**, right-click *FirstToolWindowControl.xaml*, click **View Code**, and add the following code to the FirstToolWindowControl class.

```csharp
public System.Windows.Controls.MediaElement MediaPlayer
{
    get { return mediaElement1; }
}
```

## Instantiate the tool window and toolbar
Add a toolbar and a menu command that invokes the **Open File** dialog and plays the selected media file.

1. Open *FirstToolWindow.cs* and add the following `using` directives:

    ```csharp
    using System.ComponentModel.Design;
    using System.Windows.Forms;
    using Microsoft.VisualStudio.Shell.Interop;
    ```

2. Inside the FirstToolWindow class, add a public reference to the FirstToolWindowControl control.

    ```csharp
    public FirstToolWindowControl control;
    ```

3. At the end of the constructor, set this control variable to the newly-created control.

    ```csharp
    control = new FirstToolWindowControl();
    base.Content = control;
    ```

4. Instantiate the toolbar inside the constructor.

    ```csharp
    this.ToolBar = new CommandID(new Guid(FirstToolWindowCommand.guidFirstToolWindowPackageCmdSet),
        FirstToolWindowCommand.ToolbarID);
    this.ToolBarLocation = (int)VSTWT_LOCATION.VSTWT_TOP;
    ```

5. At this point, the FirstToolWindow constructor should look like this:

    ```csharp
    public FirstToolWindow() : base(null)
    {
        this.Caption = "FirstToolWindow";
        this.BitmapResourceID = 301;
        this.BitmapIndex = 1;
        control = new FirstToolWindowControl();
        base.Content = control;
        this.ToolBar = new CommandID(new Guid(FirstToolWindowCommand.guidFirstToolWindowPackageCmdSet),
            FirstToolWindowCommand.ToolbarID);
            this.ToolBarLocation = (int)VSTWT_LOCATION.VSTWT_TOP;
    }
    ```

6. Add the menu command to the toolbar. In the FirstToolWindowCommand.cs class, add the following using directive:

    ```csharp
    using System.Windows.Forms;
    ```

7. In the FirstToolWindowCommand class, add the following code at the end of the ShowToolWindow() method. The ButtonHandler command will be implemented in the next section.

    ```csharp
    // Create the handles for the toolbar command.
    var mcs = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
    var toolbarbtnCmdID = new CommandID(new Guid(FirstToolWindowCommand.guidFirstToolWindowPackageCmdSet),
        FirstToolWindowCommand.cmdidWindowsMediaOpen);
    var menuItem = new MenuCommand(new EventHandler(
        ButtonHandler), toolbarbtnCmdID);
    mcs.AddCommand(menuItem);
    ```

### To implement a menu command in the tool window

1. In the FirstToolWindowCommand class, add a ButtonHandler method that invokes the **Open File** dialog. When a file has been selected, it plays the media file.

2. In the FirstToolWindowCommand class, add a private reference to the FirstToolWindow window that gets created in the FindToolWindow() method.

    ```csharp
    private FirstToolWindow window;
    ```

3. Change the ShowToolWindow() method to set the window you defined above (so that the ButtonHandler command handler can access the window control. Here is the complete ShowToolWindow() method.

    ```csharp
    private void ShowToolWindow(object sender, EventArgs e)
    {
        window = (FirstToolWindow) this.package.FindToolWindow(typeof(FirstToolWindow), 0, true);
        if ((null == window) || (null == window.Frame))
        {
            throw new NotSupportedException("Cannot create tool window");
        }

        IVsWindowFrame windowFrame = (IVsWindowFrame)window.Frame;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(windowFrame.Show());

        var mcs = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
        var toolbarbtnCmdID = new CommandID(new Guid(FirstToolWindowCommandguidFirstToolWindowPackageCmdSet),
            FirstToolWindowCommand.cmdidWindowsMediaOpen);
        var menuItem = new MenuCommand(new EventHandler(
            ButtonHandler), toolbarbtnCmdID);
        mcs.AddCommand(menuItem);
    }
    ```

4. Add the ButtonHandler method. It creates an OpenFileDialog for the user to specify the media file to play, and then plays the selected file.

    ```csharp
    private void ButtonHandler(object sender, EventArgs arguments)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        DialogResult result = openFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            window.control.MediaPlayer.Source = new System.Uri(openFileDialog.FileName);
        }
    }
    ```

## Set the default position for the tool window

Next, specify a default location in the IDE for the tool window. Configuration information for the tool window is in the *FirstToolWindowPackage.cs* file.

1. In *FirstToolWindowPackage.cs*, find the <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute> attribute on the `FirstToolWindowPackage` class, which passes the FirstToolWindow type to the constructor. To specify a default position, you must add more parameters to the constructor following example.

    ```csharp
    [ProvideToolWindow(typeof(FirstToolWindow),
        Style = Microsoft.VisualStudio.Shell.VsDockStyle.Tabbed,
        Window = "3ae79031-e1bc-11d0-8f78-00a0c9110057")]
    ```

    The first named parameter is `Style` and its value is `Tabbed`, which means that the window will be a tab in an existing window. The docking position is specified by the `Window` parameter, n this case, the GUID of the **Solution Explorer**.

    > [!NOTE]
    > For more information about the types of windows in the IDE, see <xref:EnvDTE.vsWindowType>.

## Test the tool window

1. Press **F5** to open a new instance of the Visual Studio experimental build.

2. On the **View** menu, point to **Other Windows** and then click **First Tool Window**.

    The media player tool window should open in the same position as **Solution Explorer**. If it still appears in the same position as before, reset the window layout (**Window / Reset Window Layout**).

3. Click the button (it has the **Search** icon) in the tool window. Select a supported sound or video file, for example, *C:\windows\media\chimes.wav*, then press **Open**.

    You should hear the chime sound.

## Related content
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
