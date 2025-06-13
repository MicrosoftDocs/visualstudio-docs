---
title: Exposing Properties to the Properties Window
description: Explore the public properties of an object and how changes you make to these properties are reflected in the Properties window.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- properties [Visual Studio SDK], exposing in Property Browser
- properties [Visual Studio SDK]
- Property Browser, exposing properties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Expose properties to the Properties window

This walkthrough exposes the public properties of an object to the **Properties** window. The changes you make to these properties are reflected in the **Properties** window.

## Expose properties to the Properties window

In this section, you create a custom tool window and display the public properties of the associated window pane object in the **Properties** window.

### To expose properties to the Properties window

1. Every Visual Studio extension starts with a VSIX deployment project, which will contain the extension assets. Create a Visual Studio VSIX project named `MyObjectPropertiesExtension`. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. Add a tool window by adding a Custom Tool Window item template named `MyToolWindow`. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item dialog**, go to **Visual C# Items** > **Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the dialog, change the file name to *MyToolWindow.cs*. For more information about how to create a custom tool window, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

3. Open *MyToolWindow.cs* and add the following using statement:

   ```csharp
   using System.Collections;
   using System.ComponentModel;
   using Microsoft.VisualStudio.Shell.Interop;
   ```

4. Now add the following fields to the `MyToolWindow` class.

   ```csharp
   private ITrackSelection trackSel;
   private SelectionContainer selContainer;

   ```

5. Add the following code to the `MyToolWindow` class.

   ```csharp
   private ITrackSelection TrackSelection
   {
       get
       {
           if (trackSel == null)
               trackSel =
                  GetService(typeof(STrackSelection)) as ITrackSelection;
           return trackSel;
       }
   }

   public void UpdateSelection()
   {
       ITrackSelection track = TrackSelection;
       if (track != null)
           track.OnSelectChange((ISelectionContainer)selContainer);
   }

   public void SelectList(ArrayList list)
   {
       selContainer = new SelectionContainer(true, false);
       selContainer.SelectableObjects = list;
       selContainer.SelectedObjects = list;
       UpdateSelection();
   }

   public override void OnToolWindowCreated()
   {
       ArrayList listObjects = new ArrayList();
       listObjects.Add(this);
       SelectList(listObjects);
   }
   ```

    The `TrackSelection` property uses `GetService` to obtain an `STrackSelection` service, which provides an <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection> interface. The `OnToolWindowCreated` event handler and `SelectList` method together create a list of selected objects that contains only the tool window pane object itself. The `UpdateSelection` method tells the **Properties** window to display the public properties of the tool window pane.

6. Build the project and start debugging. The experimental instance of Visual Studio should appear.

7. If the **Properties** window is not visible, open it by pressing **F4**.

8. Open the **MyToolWindow** window. You can find it in **View** > **Other Windows**.

    The window opens and the public properties of the window pane appear in the **Properties** window.

9. Change the **Caption** property in the **Properties** window to **My Object Properties**.

     The MyToolWindow window caption changes accordingly.

## Expose tool window properties

In this section, you add a tool window and expose its properties. The changes you make to properties are reflected in the **Properties** window.

### To expose tool window properties

1. Open *MyToolWindow.cs*, and add the public boolean property IsChecked to the `MyToolWindow` class.

    ```csharp
    [Category("My Properties")]
    [Description("MyToolWindowControl properties")]
    public bool IsChecked
    {
        get {
            if (base.Content == null)  return false;
            return (bool)(( MyToolWindowControl) base.Content).checkBox.IsChecked;
        }
        set {
            ((MyToolWindowControl) base.Content).checkBox.IsChecked = value;
        }
    }
    ```

     This property gets its state from the WPF checkbox you will create later.

2. Open *MyToolWindowControl.xaml.cs* and replace the MyToolWindowControl constructor with the following code.

    ```vb
    private MyToolWindow pane;
    public MyToolWindowControl(MyToolWindow pane)
    {
        InitializeComponent();
        this.pane = pane;
        checkBox.IsChecked = false;
    }
    ```

     This gives `MyToolWindowControl` access to the `MyToolWindow` pane.

3. In *MyToolWindow.cs*, change the `MyToolWindow` constructor as follows:

    ```csharp
    base.Content = new MyToolWindowControl(this);
    ```

4. Change to the design view of MyToolWindowControl.

5. Delete the button and add a check box from the **Toolbox** to the upper left corner.

6. Add the Checked and Unchecked events. Select the checkbox in the design view. In the **Properties** window, click the event handlers button (at the top right of the **Properties** window). Find **Checked** and type **checkbox_Checked** in the text box, then find **Unchecked** and type **checkbox_Unchecked** in the text box.

7. Add the check box event handlers:

    ```csharp
    private void checkbox_Checked(object sender, RoutedEventArgs e)
    {
        pane.IsChecked = true;
        pane.UpdateSelection();
    }
    private void checkbox_Unchecked(object sender, RoutedEventArgs e)
    {
        pane.IsChecked = false;
        pane.UpdateSelection();
    }
    ```

8. Build the project and start debugging.

9. In the experimental instance, open the **MyToolWindow** window.

     Look for the window's properties in the **Properties** window. The **IsChecked** property appears at the bottom of the window, under the **My Properties** category.

10. Check the check box in the **MyToolWindow** window. **IsChecked** in the **Properties** window changes to **True**. Clear the check box in the **MyToolWindow** window. **IsChecked** in the **Properties** window changes to **False**. Change the value of **IsChecked** in the **Properties** window. The check box in the **MyToolWindow** window changes to match the new value.

    > [!NOTE]
    > If you must dispose of an object that is displayed in the **Properties** window, call `OnSelectChange` with a `null` selection container first. After disposing the property or object, you can change to a selection container that has updated <xref:Microsoft.VisualStudio.Shell.SelectionContainer.SelectableObjects%2A> and <xref:Microsoft.VisualStudio.Shell.SelectionContainer.SelectedObjects%2A> lists.

## Change selection lists

 In this section, you add a selection list for a basic property class and use the tool window interface to choose which selection list to display.

### To change selection lists

1. Open *MyToolWindow.cs* and add a public class named `Simple`.

    ```csharp
    public class Simple
    {
        private string someText = "";

        [Category("My Properties")]
        [Description("Simple Properties")]
        [DisplayName("My Text")]
        public string SomeText
        {
            get { return someText; }
            set { someText = value; }
        }

        [Category("My Properties")]
        [Description("Read-only property")]
        public bool ReadOnly
        {
            get { return false; }
        }
    }
    ```

2. Add a `SimpleObject` property to the `MyToolWindow` class, plus two methods to switch the **Properties** window selection between the window pane and the `Simple` object.

    ```csharp
    private Simple simpleObject = null;
    public Simple SimpleObject
    {
        get
        {
            if (simpleObject == null) simpleObject = new Simple();
            return simpleObject;
        }
    }

    public void SelectSimpleList()
    {
        ArrayList listObjects = new ArrayList();
        listObjects.Add(SimpleObject);
        SelectList(listObjects);
    }

    public void SelectThisList()
    {
        ArrayList listObjects = new ArrayList();
        listObjects.Add(this);
        SelectList(listObjects);
    }
    ```

3. In *MyToolWindowControl.cs*, replace the check box handlers with these lines of code:

    ```csharp
    private void checkbox_Checked(object sender, RoutedEventArgs e)
     {
        pane.IsChecked = true;
        pane.SelectSimpleList();
        pane.UpdateSelection();
    }
    private void checkbox_Unchecked(object sender, RoutedEventArgs e)
    {
        pane.IsChecked = false;
        pane.SelectThisList();
        pane.UpdateSelection();
    }
    ```

4. Build the project and start debugging.

5. In the experimental instance, open the **MyToolWindow** window.

6. Select the check box in the **MyToolWindow** window. The **Properties** window displays the `Simple` object properties, **SomeText** and **ReadOnly**. Clear the check box. The public properties of the window appear in the **Properties** window.

    > [!NOTE]
    > The display name of **SomeText** is **My Text**.

## Best practice

In this walkthrough, <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> is implemented so that the selectable object collection and the selected object collection are the same collection. Only the selected object appears in the Property Browser list. For a more complete ISelectionContainer implementation, see the Reference.ToolWindow samples.

Visual Studio tool windows persist between Visual Studio sessions. For more information on persisting the tool window state, see <xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute>.

## Related content

- [Extend properties and the Property window](../extensibility/extending-properties-and-the-property-window.md)
