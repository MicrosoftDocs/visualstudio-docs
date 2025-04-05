---
title: Creating a Windows Forms Toolbox Control | Microsoft Docs
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- winforms
- toolbox
- windows forms
ms.assetid: 0be6ffc1-8afd-4d02-9a5d-e27dde05fde6
author: acangialosi
ms.author: anthc
manager: jillfra
ms.workload:
- vssdk
---
# Create a Windows Forms Toolbox Control

The Windows Forms Toolbox Control item template that is included in the Visual Studio Extensibility Tools (VS SDK), lets you create a **Toolbox** control that is automatically added when the extension is installed. This walkthrough shows how to use the template to create a simple counter control that you can distribute to other users.

## Prerequisites

Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create the Toolbox Control

The Windows Forms Toolbox Control template creates an undefined user control and provides all of the functionality that is required to add the control to the **Toolbox**.

### Create an extension with a Windows Forms Toolbox Control

1. Create a VSIX project named `MyWinFormsControl`. You can find the VSIX project template in the **New Project** dialog, by searching for "vsix".

2. When the project opens, add a **Windows Forms Toolbox Control** item template named `Counter`. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Windows Forms Toolbox Control**

3. This adds a user control, a `ProvideToolboxControlAttribute` <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute> to place the control in the **Toolbox**, and a **Microsoft.VisualStudio.ToolboxControl** Asset entry in the VSIX manifest for deployment.

### Build a user interface for the control

The `Counter` control requires two child controls: a <xref:System.Windows.Forms.Label> to display the current count, and a <xref:System.Windows.Forms.Button> to reset the count to 0. No other child controls are required because callers will increment the counter programmatically.

#### To build the user interface

1. In **Solution Explorer**, double-click *Counter.cs* to open it in the designer.

2. Remove the **Click Here !** button that is included by default when you add the Windows Forms Toolbox Control item template.

3. From the **Toolbox**, drag a `Label` control and then a `Button` control below it to the design surface.

4. Resize the overall user control to 150, 50 pixels, and resize the button control to 50, 20 pixels.

5. In the **Properties** window, set the following values for the controls on the design surface.

    |Control|Property|Value|
    |-------------|--------------|-----------|
    |`Label1`|**Text**|""|
    |`Button1`|**Name**|btnReset|
    |`Button1`|**Text**|Reset|

### Code the user control

The `Counter` control will expose a method to increment the counter, an event to be raised whenever the counter is incremented, a **Reset** button, and three properties to store the current count, the display text, and whether to show or hide the **Reset** button. The `ProvideToolboxControl` attribute determines where in the **Toolbox** the `Counter` control will appear.

#### To code the user control

1. Double-click the form to open its load event handler in the code window.

2. Above the event handler method, in the control class create an integer to store the counter value and a string to store the display text as shown in the following example.

    ```csharp
    int currentValue;
    string displayText;
    ```

3. Create the following public property declarations.

    ```csharp
    public int Value {
        get { return currentValue; }
    }

    public string Message {
        get { return displayText; }
        set { displayText = value; }
    }

    public bool ShowReset {
        get { return btnReset.Visible; }
        set { btnReset.Visible = value; }
    }

    ```

    Callers can access these properties to get and set the display text of the counter and to show or hide the **Reset** button. Callers can obtain the current value of the read-only `Value` property, but they cannot set the value directly.

4. Put the following code in the `Load` event for the control.

    ```csharp
    private void Counter_Load(object sender, EventArgs e)
    {
        currentValue = 0;
        label1.Text = Message + Value;
    }

    ```

    Setting the **Label** text in the <xref:System.Windows.Forms.UserControl.Load> event enables the target properties to load before their values are applied. Setting the **Label** text in the constructor would result in an empty **Label**.

5. Create the following public method to increment the counter.

    ```csharp
    public void Increment()
    {
        currentValue++;
        label1.Text = displayText + Value;
        Incremented(this, EventArgs.Empty);
    }

    ```

6. Add a declaration for the `Incremented` event to the control class.

    ```csharp
    public event EventHandler Incremented;
    ```

    Callers can add handlers to this event to respond to changes in the value of the counter.

7. Return to design view and double-click the **Reset** button to generate the `btnReset_Click` event handler, and then fill it in as shown in the following example.

    ```csharp
    private void btnReset_Click(object sender, EventArgs e)
    {
        currentValue = 0;
        label1.Text = displayText + Value;
    }

    ```

8. Immediately above the class definition, in the `ProvideToolboxControl` attribute declaration, change the value of the first parameter from `"MyWinFormsControl.Counter"` to `"General"`. This sets the name of the item group that will host the control in the **Toolbox**.

    The following example shows the `ProvideToolboxControl` attribute and the adjusted class definition.

    ```csharp
    [ProvideToolboxControl("General", false)]
    public partial class Counter : UserControl
    ```

### Test the control

 To test a **Toolbox** control, first test it in the development environment and then test it in a compiled application.

#### To test the control

1. Press **F5** to **Start Debugging**.

    This command builds the project and opens a second Experimental instance of Visual Studio that has the control installed.

2. In the Experimental instance of Visual Studio, create a **Windows Forms Application** project.

3. In **Solution Explorer**, double-click *Form1.cs* to open it in the designer if it is not already open.

4. In the **Toolbox**, the `Counter` control should be displayed in the **General** section.

5. Drag a `Counter` control to your form, and then select it. The `Value`, `Message`, and `ShowReset` properties will be displayed in the **Properties** window, together with the properties that are inherited from <xref:System.Windows.Forms.UserControl>.

6. Set the `Message` property to `Count:`.

7. Drag a <xref:System.Windows.Forms.Button> control to the form, and then set the name and text properties of the button to `Test`.

8. Double-click the button to open *Form1.cs* in code view and create a click handler.

9. In the click handler, call `counter1.Increment()`.

10. In the constructor function, after the call to `InitializeComponent`, type `counter1``.``Incremented +=` and then press **Tab** twice.

    Visual Studio generates a form-level handler for the `counter1.Incremented` event.

11. Highlight the `Throw` statement in the event handler, type `mbox`, and then press **Tab** twice to generate a message box from the mbox code snippet.

12. On the next line, add the following `if`/`else` block to set the visibility of the **Reset** button.

    ```csharp
    if (counter1.Value < 5) counter1.ShowReset = false;
    else counter1.ShowReset = true;
    ```

13. Press **F5**.

    The form opens. The `Counter` control displays the following text.

    **Count: 0**

14. Click **Test**.

    The counter increments and Visual Studio displays a message box.

15. Close the message box.

    The **Reset** button disappears.

16. Click **Test** until the counter reaches **5** closing the message boxes each time.

    The **Reset** button reappears.

17. Click **Reset**.

    The counter resets to **0**.

## Next steps

When you build a **Toolbox** control, Visual Studio creates a file named *ProjectName.vsix* in the \bin\debug\ folder of your project. You can deploy the control by uploading the *.vsix* file to a network or to a Web site. When a user opens the *.vsix* file, the control is installed and added to the Visual Studio **Toolbox** on the user's computer. Alternatively, you can upload the *.vsix* file to [Visual Studio Marketplace](https://marketplace.visualstudio.com/) so that users can find it by browsing in the **Tools** > **Extensions and Updates** dialog.

## See also

- [Extend other parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)
- [Create a WPF Toolbox Control](../extensibility/creating-a-wpf-toolbox-control.md)
- [Extend other parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)
- [Windows Forms control development basics](/dotnet/framework/winforms/controls/windows-forms-control-development-basics)
