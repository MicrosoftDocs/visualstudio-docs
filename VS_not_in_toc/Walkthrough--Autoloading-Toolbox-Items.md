---
title: "Walkthrough: Autoloading Toolbox Items"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b03c0d62-3be0-475f-b1d9-725dee993ad6
caps.latest.revision: 56
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Walkthrough: Autoloading Toolbox Items
This walkthrough illustrates how a managed VSPackage can use reflection to automatically load all the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> items provided by its own assembly.  
  
> [!NOTE]
>  The recommended way to add custom controls to the Toolbox is to use the Toolbox Control templates that come with the Visual Studio SDK, which includes auto-loading support. This topic is retained for backward compatibility, for adding existing controls to the Toolbox, and for advanced Toolbox development.  
>   
>  For more information on creating toolbox controls by using the templates, see [How to: Create a Toolbox Control That Uses Windows Forms](../VS_not_in_toc/How-to--Create-a-Toolbox-Control-That-Uses-Windows-Forms.md) and [Creating a WPF Toolbox Control](../Topic/Creating%20a%20WPF%20Toolbox%20Control.md).  
  
 This walkthrough guides you through the following steps:  
  
1.  Add and correctly register all **Toolbox** controls in the VSPackage objects by using <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False>, <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False>, and <xref:System.ComponentModel.DisplayNameAttribute?qualifyHint=False>.  
  
2.  Create the following two controls, and add icons for each to the **Toolbox**:  
  
    -   Add one control by using a default <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
    -   Add another control by using a custom class that is derived from the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
3.  Register the VSPackage as providing <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that have the <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> class.  
  
4.  Use reflection to generate a list of all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the VSPackage provides when it is loaded.  
  
5.  Create a handler for the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events. Doing this guarantees that the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects of the VSPackage are correctly loaded.  
  
6.  Implement a command on the VSPackage to force re-initialization of the **Toolbox**.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Extending Visual Studio Overview](../Topic/Extending%20Visual%20Studio%20Overview.md).  
  
## Locations for the Visual Studio Package Project Template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1.  Under Visual Basic Extensibility. The default language of the project is Visual Basic.  
  
2.  Under C# Extensibility. The default language of the project is C#.  
  
3.  Under Other Project Types Extensibility. The default language of the project is C++.  
  
## Creating a Managed VSPackage  
  
#### To create the LoadToolboxMembers VSPackage  
  
1.  Create a VSPackage named `LoadToolboxMembers`. For more information, see [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template.md).  
  
2.  Add a menu command.  
  
     Name the command `Initialize LoadToolboxMembers VB` for Visual Basic or `Initialize LoadToolboxMembers CS` for Visual C#.  
  
 If you follow this walkthrough for more than one language, you must update the project to disambiguate the generated assemblies.  
  
#### To disambiguate Visual Basic and Visual C# VSPackages  
  
1.  For Visual Basic:  
  
    -   In **Solution Explorer**, open the project properties, and select the **Application** tab.  
  
         Change the assembly name to `LoadToolboxMembersVB`, and change the default namespace to `Company.LoadToolboxMembersVB`.  
  
2.  For Visual C#:  
  
    1.  In **Solution Explorer**, open the project properties, and select the **Application** tab.  
  
         Change the assembly name to `LoadToolboxMembersCS`, and change the default namespace to `Company.LoadToolboxMembersCS`.  
  
    2.  Open the LoadToolboxMembersPackage class in the code editor.  
  
         To use the refactoring tools to rename the existing namespace, right-click the existing namespace name, `LoadToolboxMembers`, point to **Refactor**, and then click **Rename**. Change the name to `LoadToolboxMembersCS`.  
  
3.  Save all changes.  
  
#### To add supporting references  
  
1.  In the LoadToolboxMembers project, add a reference to the <xref:System.Drawing.Design?qualifyHint=True> .NET Framework component, as follows.  
  
    1.  In **Solution Explorer**, right-click the LoadToolboxMembers project, and then click **Add**, **Reference**.  
  
    2.  On the **.NET** tab of the **References** dialog box, double-click **System.Drawing.Design**.  
  
2.  For Visual Basic, add the following namespaces to the imported namespaces list in the project:  
  
    -   Company.LoadToolboxMembersVB  
  
    -   System  
  
    -   System.ComponentModel  
  
    -   System.Drawing  
  
    -   System.Windows.Forms  
  
#### To test the generated code  
  
1.  Compile and start the VSPackage in the Visual Studio experimental hive.  
  
2.  On the **Tools** menu, click **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS**.  
  
     This opens a message box that contains text that indicates that the package's menu item handler was called.  
  
3.  Close the experimental version of Visual Studio.  
  
## Creating a Toolbox Control  
 In this section, you create and register a user control, `Control1`, that declares an associated default **Toolbox** item. For more information about how to author Windows Form controls and the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class, see [Developing Windows Forms Controls at Design Time](../Topic/Developing%20Windows%20Forms%20Controls%20at%20Design%20Time.md).  
  
#### To create a Toolbox control that will be used with a default ToolboxItem  
  
1.  In **Solution Explorer**, add a <xref:System.Windows.Forms.UserControl?qualifyHint=False> object to the LoadToolboxMembers project, as follows:  
  
    1.  In **Solution Explorer**, right-click the **LoadToolboxMembers** project, point to **Add**, and then click **User Control**.  
  
    2.  In the **Add New Item** dialog box, change the name to `Control1.vb` for Visual Basic or `Control1.cs` for Visual C#.  
  
         For more information about how to add new items to a project, see [NIB:How to: Add New Project Items](assetId:///63d3e16b-de6e-4bb5-a0e3-ecec762201ce).  
  
     The new control opens in Design view.  
  
2.  From the **Toolbox**, drag a **Button** control (located in the **Common Controls** category) to the designer.  
  
3.  Double-click the button you just created. Doing this generates an event handler for the button's <xref:System.Windows.Forms.Control.Click?qualifyHint=False> event. Update the event handler by using the following code:  
  
     [!CODE [LoadToolboxMembers#01](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#01)]  
  
4.  Modify the constructor of the control to set the button text after the `InitializeComponent` method is called:  
  
     [!CODE [LoadToolboxMembers#02](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#02)]  
  
5.  Add attributes to the file to enable the VSPackage to query the supplied <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class:  
  
     [!CODE [LoadToolboxMembers#03](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#03)]  
  
6.  Save the file.  
  
 In the following procedure, you create and register a second user control, `Control2`, and an associated custom **Toolbox** item, `Control2_ToolboxItem`, that is derived from the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
#### To create a Toolbox control for using a custom ToolboxItem-derived class  
  
1.  Create a second user control named `Control2`. Double click on the form to bring up the code file.  
  
2.  Add `System.Drawing.Design` and `System.Globalization` to the namespaces that are used in the class.  
  
     [!CODE [LoadToolboxMembers#04](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#04)]  
  
3.  Add a button and button click event handler and update the control's constructor just like you updated the first control.  
  
4.  Add the <xref:System.ComponentModel.DisplayNameAttribute?qualifyHint=False>, <xref:System.ComponentModel.DescriptionAttribute?qualifyHint=False>, <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False>, and <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> attributes to the file.  
  
     These attributes enable the VSPackage to query for a <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
     For more information and examples about how to write custom <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects, see the discussion in the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> reference page.  
  
     Together with the previous changes, your second control class should resemble the following code. The symbol `Control2_ToolboxMenu` will be undefined until after the next step.  
  
     [!CODE [LoadToolboxMembers#05](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#05)]  
  
5.  Create a class named `Control2_ToolboxItem`. This <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> is constructed for the second control and added to the **Toolbox**. The class must have `SerializableAttribute` applied to it.  
  
     [!CODE [LoadToolboxMembers#06](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#06)]  
  
6.  Save the file.  
  
## Embedding Bitmap Icons  
 The two instances of <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> used earlier indicate that the project represents the two controls by using the following icons:  
  
-   `Control1.bmp`, located in the namespace that contains the first control.  
  
-   `Control2.bmp`, located in the namespace that contains the second control.  
  
#### To embed bitmap icons for the ToolboxItem  
  
1.  Add two new bitmaps to the project, as follows.  
  
    1.  Right-click the `LoadToolboxMembers` project.  
  
    2.  Point to **Add**, and then click **New Item**.  
  
    3.  In the **Add New Item** dialog box, select **Bitmap File**, and name the file `Control1.bmp`.  
  
    4.  Repeat these steps for the second bitmap and name it `Control2.bmp`.  
  
         Doing this opens each bitmap in the Visual Studio bitmap editor.  
  
2.  Set the size of each icon to 16 x 16, as follows.  
  
    1.  For each bitmap, click **Properties Window** on the **View** menu.  
  
    2.  In the **Properties** window, set **Height** and **Width** to 16.  
  
3.  Use the bitmap editor in Visual Studio to create an image for each icon.  
  
4.  In **Solution Explorer**, click each bitmap file, and then, in the **Properties** window, set the **Build Action** property to **Embedded Resource**.  
  
5.  Save all open files.  
  
## Modifying the VSPackage Implementation  
 The default implementation of the VSPackage must be modified to do the following things:  
  
-   Register support for being a **Toolbox** item provider.  
  
-   Obtain a list of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the VSPackage supports.  
  
-   Load the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> object in the Visual Studio **Toolbox** when <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events are handled.  
  
 The next procedure shows how to modify the package implementation.  
  
#### To modify the package implementation to be a Toolbox item provider for the VSPackage  
  
1.  Open the LoadToolboxMembersPackage.cs or LoadToolboxMembersPackage.vb file in the code editor.  
  
2.  Modify the declaration of the `LoadToolboxMembersPackage` class, which is the implementation of the <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> class in the solution, as follows.  
  
    1.  Add the following namespace directives to the `LoadToolboxMembersPackage` class file.  
  
         [!CODE [LoadToolboxMembers#07](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#07)]  
  
    2.  Register the VSPackage as a <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class by adding an instance of <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False>.  
  
        > [!NOTE]
        >  The sole argument of <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> is the version of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> that is provided by the VSPackage. Changing this value forces the IDE to load the VSPackage even if it has an earlier cached version of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
    3.  Add the following two new `private` fields to the `LoadToolboxMembersPackage` class:  
  
         An <xref:System.Collections.ArrayList?qualifyHint=False> member, named `ToolboxItemList`, to hold a list of the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the `LoadToolboxMembersPackage` class manages.  
  
         A <xref:System.String?qualifyHint=False>, named `CategoryTab`, that contains the **Toolbox** category or tab that is used to hold the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are managed by the `LoadToolboxMembersPackage` class.  
  
     The result of this modification resembles the following code:  
  
     [!CODE [LoadToolboxMembers#08](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#08)]  
  
3.  Expand the Package Members region to modify the `Initialize` method to do the following things:  
  
    -   For Visual C#, subscribe to the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events.  
  
    -   Call the `CreateItemList` method to fill the <xref:System.Collections.ArrayList?qualifyHint=False> object `ToolboxItemList`. The `ToolboxItemList` will contain a list of all the toolbox items that `LoadToolboxMembersPackage` manages.  
  
     [!CODE [LoadToolboxMembers#09](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#09)]  
  
4.  Add two methods, `CreateItemList` and `CreateToolboxItem`, to construct, by using metadata, instances of the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are available in the `LoadToolboxMembers` assembly, as follows:  
  
     [!CODE [LoadToolboxMembers#10](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#10)]  
  
5.  Implement the `OnRefreshToolbox` method to handle the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events.  
  
     The `OnRefreshToolbox` method uses the list of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that is contained in the `ToolboxItemList` member of the `LoadToolboxMembersPackage` class. It also does the following things:  
  
    -   Removes all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are already present in the Toolbox category that is defined by the variable `CategoryTab`.  
  
    -   Adds new instances of all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are listed in `ToolboxItemList` to the category tab for the VSProject.  
  
    -   Sets the **Toolbox** active tab to the category tab for the VSProject.  
  
     [!CODE [LoadToolboxMembers#11](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#11)]  
  
    > [!NOTE]
    >  As an exercise, one could develop a mechanism for testing the version of the VSPackage or the items, and only update if the version of the VSPackage has changed, or if the version of the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> has changed.  
  
## Initializing the Toolbox  
  
#### To implement a command to initialize the Toolbox  
  
-   Change the menu item command handler method, `MenuItemCallBack`, as follows.  
  
    1.  Replace the existing implementation of `MenuItemCallBack` with the following code:  
  
         [!CODE [LoadToolboxMembers#12](../CodeSnippet/VS_Snippets_VSSDK/loadtoolboxmembers#12)]  
  
## Building and Running the Solution  
 You can exercise the product of this walkthrough by using an instance of Visual Studio that is running in the experimental hive.  
  
#### To exercise this walkthrough  
  
1.  In Visual Studio, on the **Build** menu, click **Rebuild Solution**.  
  
2.  Press F5 to start a second instance of Visual Studio in the experimental registry hive.  
  
     For more information about how to use the experimental hive, see [The Experimental Instance](../Topic/The%20Experimental%20Instance.md).  
  
3.  Click the **Tools** menu.  
  
     A command named **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS** should appear at the top of the menu, together with an icon that has the numeral 1.  
  
4.  Create a new Visual C# or Visual Basic Windows Forms application.  
  
     A <xref:System.Windows.Forms.Form?qualifyHint=False>-based designer should appear.  
  
5.  Drag one or both of the new controls in the **LoadToolboxMembers Walkthrough VB** or **LoadToolboxMembers Walkthrough CS** category of the **Toolbox** to the form in the designer.  
  
    > [!NOTE]
    >  If the **Toolbox** is not displayed, click **Toolbox** on the **View** menu. If the category tab for the VSPackage does not appear in the **Toolbox**, re-initialize the **Toolbox** by clicking **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS** on the **Tools** menu.  
  
6.  Build the windows application by clicking **Rebuild Solution** on the **Build** menu.  
  
7.  Run the application by clicking either **Start** or **Start with Debugging** on the **Debug** menu.  
  
8.  When the application runs, click one of the controls that you added to the application.  
  
     A message box appears and displays either `"Hello world from Company.LoadToolboxMembers.Control1"` or `"Hello world from Company.LoadToolboxMembers.Control2"`.  
  
## Analysis of the Implementation  
  
### Creating Toolbox Controls  
 The attributes assigned to `Control1` and `Control2` are used by the method `CreateItemList` when it queries the `Assembly` for available **Toolbox** controls.  
  
-   The <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> performs the following two functions:  
  
    -   The assignment of <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> to `Control1` and `Control2`, which indicates that each is a toolbox control.  
  
    -   The argument to the <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> constructor, which indicates whether the default <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> or a custom class derived from <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> is used when the control is added to the **Toolbox**.  
  
         The instance of <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> that is assigned to `Control1` is created by using an argument of `true`, which indicates that it uses a default <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class when it is added to the **Toolbox**.  
  
         The instance of <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> that is assigned to `Control2` is created by using the <xref:System.Type?qualifyHint=False> of a class that is derived from <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False>, `Control2_ToolboxItem`.  
  
-   The <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> class specifies bitmaps that are used by the environment to identify the controls.  
  
     Embedding a bitmap in an assembly by setting its **Build Action** property to **Embedded Resource** puts the bitmap in the namespace of the assembly. Therefore, `Control1.bmp` can be referred to as `Company.LoadToolboxMembers.Control1.bmp`.  
  
     <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> supports a constructor that takes this full path as an argument. For example, a <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> class could be applied to `Control1` by using `[ToolboxBitmap("Company.LoadToolboxMembers.Control1.bmp")]`.  
  
     To support flexibility, this walkthrough uses a constructor that takes a <xref:System.Type?qualifyHint=False> class as the first argument to the <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> constructor. The namespace that is used to identify the bitmap file is obtained from the <xref:System.Type?qualifyHint=False> and inserted in front of the base name of the bitmap.  
  
     Because the <xref:System.Type?qualifyHint=False> object that implements <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False>, `LoadToolboxMembers`, is in the `Company.LoadToolboxMembers` namespace `[ToolboxBitmap(typeof(Control1), "Control1.bmp")]` is equivalent to `[ToolboxBitmap("Company.LoadToolboxMembers.Control1.bmp")]`.  
  
-   <xref:System.ComponentModel.DisplayNameAttribute?qualifyHint=False> specifies the name of the control in the **Toolbox**.  
  
### Registering a Toolbox Control Provider  
 Applying the <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> class to the class that implements <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> affects the registry settings of the resulting VSPackage. For more information about the registry settings for a <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> provider, see [Registering Toolbox Support Features](../VS_not_in_toc/Registering-Toolbox-Support-Features.md).  
  
 The Visual Studio environment uses the version argument to the <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> constructor to manage the caching of VSPackages that provide items to the **Toolbox**. After a VSPackage has been loaded to provide **Toolbox** items, a cached version of the VSPackage is used until the registered version of the provider changes. Therefore, if you want to modify the product of this walkthrough after you build it, make sure to change the version argument of the <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> constructor that is applied to `AddToolboxItem`. For example, `[ProvideToolboxItems(1)]` should be changed to `[ProvideToolboxItems(2)]`. If the version is not changed, then the Visual Studio environment does not load any modifications that are made.  
  
 In this walkthrough, the VSPackage is configured to provide only **Toolbox** controls that support the default Clipboard format. For a list of default Clipboard formats, see [Extending the Toolbox](../VS_not_in_toc/Extending-the-Toolbox.md). If you want to support other Clipboard formats, or decide not to support a default format, apply the attribute <xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute?qualifyHint=False> to the `LoadToolboxMembersPackage` class. For more information about registering a **Toolbox** control provider, see [Advanced Toolbox Control Development](../VS_not_in_toc/Advanced-Toolbox-Control-Development.md).  
  
### Adding Controls to the Toolbox  
 The functionality in `CreateItemList` emulates what is available in <xref:System.Drawing.Design.ToolboxService.System#Drawing#Design#IToolboxService#GetToolboxItems?qualifyHint=False>.  
  
 The `CreateItemList` method only examines non-abstract <xref:System.Type?qualifyHint=False> objects that implement the <xref:System.ComponentModel.IComponent?qualifyHint=False> interfaces.  
  
## Next Steps  
 Using <xref:System.Drawing.Design.ToolboxService.System#Drawing#Design#IToolboxService#GetToolboxItems?qualifyHint=False> rather than `CreateItemList` would make the product of this walkthrough more robust.  
  
 You could also modify `CreateItemList` to use <xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource?qualifyHint=False> to load controls into the **Toolbox** based on a text list that is embedded in the `LoadToolboxMembers` assembly.  
  
## See Also  
 [Extending the Toolbox](../VS_not_in_toc/Extending-the-Toolbox.md)   
 [Registering Toolbox Support Features](../VS_not_in_toc/Registering-Toolbox-Support-Features.md)   
 [Advanced Toolbox Control Development](../VS_not_in_toc/Advanced-Toolbox-Control-Development.md)   
 [Toolbox Walkthroughs](../VS_not_in_toc/Toolbox-Walkthroughs.md)