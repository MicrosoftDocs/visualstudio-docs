---
title: Creating an Options Page
description: Learn how to create a simple Tools/Options page that uses a property grid to examine and set properties.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- Tools Options pages [Visual Studio SDK], creating
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an options page

This walkthrough creates a simple Tools/Options page that uses a property grid to examine and set properties.

 To save these properties to and restore them from a settings file, follow these steps, and then see [Create a settings category](../extensibility/creating-a-settings-category.md).

 The MPF provides two classes to help you create Tools Options pages, the <xref:Microsoft.VisualStudio.Shell.Package> class and the <xref:Microsoft.VisualStudio.Shell.DialogPage> class. You create a VSPackage to provide a container for these pages by subclassing the `Package` class. You create each tools options page by deriving from the `DialogPage` class.

## Create a Tools Options grid page

 In this section, you create a simple Tools Options property grid. You use this grid to display and change the value of a property.

### To create the VSIX project and add a VSPackage

1. Every Visual Studio extension starts with a VSIX deployment project, which will contain the extension assets. Create a Visual Studio VSIX project named `MyToolsOptionsExtension`. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. Add a VSPackage by adding a Visual Studio Package item template named `MyToolsOptionsPackage`. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item dialog**, go to **Visual C# Items** > **Extensibility** and select **Visual Studio Package**. In the **Name** field at the bottom of the dialog, change the file name to `MyToolsOptionsPackage.cs`. For more information about how to create a VSPackage, see [Create an extension with a VSPackage](../extensibility/creating-an-extension-with-a-vspackage.md).

### To create the Tools Options property grid

1. Open the *MyToolsOptionsPackage* file in the code editor.

2. Add the following using statement.

   ```csharp
   using System.ComponentModel;
   ```

3. Declare an `OptionPageGrid` class and derive it from <xref:Microsoft.VisualStudio.Shell.DialogPage>.

   ```csharp
   public class OptionPageGrid : DialogPage
   {  }
   ```

4. Apply a <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> to the `VSPackage` class to assign to the class an options category and options page name for the OptionPageGrid. The result should look like this:

    ```csharp
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidMyToolsOptionsPkgString)]
    [ProvideOptionPage(typeof(OptionPageGrid),
        "My Category", "My Grid Page", 0, 0, true)]
    public sealed class MyToolsOptionsPackage : Package
    ```

5. Add an `OptionInteger` property to the `OptionPageGrid` class.

    - Apply a <xref:System.ComponentModel.CategoryAttribute?displayProperty=fullName> to assign to the property a property grid category.

    - Apply a <xref:System.ComponentModel.DisplayNameAttribute?displayProperty=fullName> to assign to the property a name.

    - Apply a <xref:System.ComponentModel.DescriptionAttribute?displayProperty=fullName> to assign to the property a description.

    ```csharp
    public class OptionPageGrid : DialogPage
    {
        private int optionInt = 256;

        [Category("My Category")]
        [DisplayName("My Integer Option")]
        [Description("My integer option")]
        public int OptionInteger
        {
            get { return optionInt; }
            set { optionInt = value; }
        }
    }
    ```

    > [!NOTE]
    > The default implementation of <xref:Microsoft.VisualStudio.Shell.DialogPage> supports properties that have appropriate converters or that are structures or arrays that can be expanded into properties that have appropriate converters. For a list of converters, see the <xref:System.ComponentModel> namespace.

6. Build the project and start debugging.

7. In the experimental instance of Visual Studio, on the **Tools** menu click **Options**.

     In the left pane, you should see **My Category**. (Options categories are listed in alphabetical order, so it should appear about halfway down the list.) Open **My Category** and then click **My Grid Page**. The options grid appears in the right pane. The property category is **My Options**, and the property name is **My Integer Option**. The property description, **My integer option**, appears at the bottom of the pane. Change the value from its initial value of 256 to something else. Click **OK**, and then reopen **My Grid Page**. You can see that the new value persists.

     Your options page is also available through Visual Studio's search box. In the search box near the top of the IDE, type **My Category** and you'll see **My Category -> My Grid Page** listed in the results.

## Create a Tools Options custom page

 In this section, you create a Tools Options page with a custom UI. You use this page to display and change the value of a property.

1. Open the *MyToolsOptionsPackage* file in the code editor.

2. Add the following using statement.

    ```csharp
    using System.Windows.Forms;
    ```

3. Add an `OptionPageCustom` class, just before the `OptionPageGrid` class. Derive the new class from `DialogPage`.

    ```csharp
    public class OptionPageCustom : DialogPage
    {
        private string optionValue = "alpha";

        public string OptionString
        {
            get { return optionValue; }
            set { optionValue = value; }
        }
    }
    ```

4. Add a GUID attribute. Add an OptionString property:

    ```csharp
    [Guid("00000000-0000-0000-0000-000000000000")]
    public class OptionPageCustom : DialogPage
    {
        private string optionValue = "alpha";

        public string OptionString
        {
            get { return optionValue; }
            set { optionValue = value; }
        }
    }
    ```

5. Apply a second <xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute> to the VSPackage class. This attribute assigns the class an options category and options page name.

    ```csharp
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidMyToolsOptionsPkgString)]
    [ProvideOptionPage(typeof(OptionPageGrid),
        "My Category", "My Grid Page", 0, 0, true)]
    [ProvideOptionPage(typeof(OptionPageCustom),
        "My Category", "My Custom Page", 0, 0, true)]
    public sealed class MyToolsOptionsPackage : Package
    ```

6. Add a new **User Control** named MyUserControl to the project.

7. Add a **TextBox** control to the user control.

     In the **Properties** window, on the toolbar, click the **Events** button, and then double-click the **Leave** event. The new event handler appears in the *MyUserControl.cs* code.

8. Add a public `OptionsPage` field, an `Initialize` method to the control class, and update the event handler to set the option value to the contents of the text box:

    ```csharp
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        internal OptionPageCustom optionsPage;

        public void Initialize()
        {
            textBox1.Text = optionsPage.OptionString;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            optionsPage.OptionString = textBox1.Text;
        }
    }
    ```

     The `optionsPage` field holds a reference to the parent `OptionPageCustom` instance. The `Initialize` method displays `OptionString` in the **TextBox**. The event handler writes the current value of the **TextBox** to the `OptionString` when focus leaves the **TextBox**.

9. In the package code file, add an override for the `OptionPageCustom.Window` property to the `OptionPageCustom` class to create, initialize, and return an instance of `MyUserControl`. The class should now look like this:

    ```csharp
    [Guid("00000000-0000-0000-0000-000000000000")]
    public class OptionPageCustom : DialogPage
    {
        private string optionValue = "alpha";

        public string OptionString
        {
            get { return optionValue; }
            set { optionValue = value; }
        }

        protected override IWin32Window Window
        {
            get
            {
                MyUserControl page = new MyUserControl();
                page.optionsPage = this;
                page.Initialize();
                return page;
            }
        }
    }
    ```

10. Build and run the project.

11. In the experimental instance, click **Tools** > **Options**.

12. Find **My Category** and then **My Custom Page**.

13. Change the value of **OptionString**. Click **OK**, and then reopen **My Custom Page**. You can see that the new value has persisted.

## Access options

 In this section, you get the value of an option from the VSPackage that hosts the associated Tools Options page. The same technique can be used to obtain the value of any public property.

1. In the package code file, add a public property called **OptionInteger** to the **MyToolsOptionsPackage** class.

    ```csharp
    public int OptionInteger
    {
        get
        {
            OptionPageGrid page = (OptionPageGrid)GetDialogPage(typeof(OptionPageGrid));
            return page.OptionInteger;
        }
    }

    ```

     This code calls <xref:Microsoft.VisualStudio.Shell.Package.GetDialogPage%2A> to create or retrieve an `OptionPageGrid` instance. `OptionPageGrid` calls <xref:Microsoft.VisualStudio.Shell.DialogPage.LoadSettingsFromStorage%2A> to load its options, which are public properties.

2. Now add a custom command item template named **MyToolsOptionsCommand** to display the value. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to *MyToolsOptionsCommand.cs*.

3. In the *MyToolsOptionsCommand* file, replace the body of the command's `ShowMessageBox` method with the following:

    ```csharp
    private void ShowMessageBox(object sender, EventArgs e)
    {
        MyToolsOptionsPackage myToolsOptionsPackage = this.package as MyToolsOptionsPackage;
        System.Windows.Forms.MessageBox.Show(string.Format(CultureInfo.CurrentCulture, "OptionInteger: {0}", myToolsOptionsPackage.OptionInteger));
    }

    ```

4. Build the project and start debugging.

5. In the experimental instance, on the **Tools** menu, click **Invoke MyToolsOptionsCommand**.

     A message box displays the current value of `OptionInteger`.

## Open options page

In this section, you'll add a Command and an event for the button to open the options page

1. First add a file called OpenPageCommand.cs. 

3. Then, open *OpenPageCommand.cs* and change your Execute method.

     ```csharp
     private void Execute(object sender, EventArgs e)
     {
         ThreadHelper.ThrowIfNotOnUIThread();
         Type optionsPageType = typeof(OptionPageCustom);
         Instance.package.ShowOptionPage(optionsPageType);
     }
    ```

3. Run the project, then click the Invoke button (it is under the Tool option by default), then you can see your options page is opened.

5. More details about opening options page can refer to the following documents

- [Opening an Options Page](/previous-versions/cc826083(v=vs.140))

## Related content

- [Options and options pages](../extensibility/internals/options-and-options-pages.md)
