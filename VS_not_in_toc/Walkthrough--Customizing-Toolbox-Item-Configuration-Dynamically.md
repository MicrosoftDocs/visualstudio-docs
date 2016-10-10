---
title: "Walkthrough: Customizing Toolbox Item Configuration Dynamically"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 761f44b7-c748-4ff5-921f-fc4f71784b0e
caps.latest.revision: 45
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
# Walkthrough: Customizing Toolbox Item Configuration Dynamically
This walkthrough shows how a managed VSPackage can supply dynamic configuration support for the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects.  
  
> [!NOTE]
>  The simplest way to add custom controls to the Toolbox is to use the Toolbox Control templates that are included in the Visual Studio SDK. This topic relates to advanced Toolbox development.  
>   
>  For more information about how to create toolbox controls by using the templates, see [How to: Create a Toolbox Control That Uses Windows Forms](../VS_not_in_toc/How-to--Create-a-Toolbox-Control-That-Uses-Windows-Forms.md) and [Creating a WPF Toolbox Control](../Topic/Creating%20a%20WPF%20Toolbox%20Control.md).  
  
 This walkthrough guides you through the following steps:  
  
1.  Add and correctly register all **Toolbox** controls in the VSPackage objects by using the <xref:System.ComponentModel.ToolboxItemAttribute?qualifyHint=False> and <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> classes.  
  
2.  Create the following two controls and add icons for each of them to the **Toolbox**:  
  
    -   One control that declares an associated default <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False>.  
  
    -   One control that declares an associated custom **Toolbox** item that is derived from the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class.  
  
3.  Write an implementation of <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False>, and register it by doing the following things:  
  
    1.  Defining a filter class that derives from the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False> class and specifies the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> instances that this implementation will act on.  
  
    2.  Applying a <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute?qualifyHint=False>, which references the filter class, to the class that implements the <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> class for the VSPackage.  
  
4.  Register the VSPackage as a provider of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects by applying the <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> to the class that implements the <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> class for the VSPackage.  
  
5.  At package load time, use reflection to generate a list of all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the VSPackage provides.  
  
6.  Create a handler for the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events. Doing this guarantees that the VSPackage's <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects are correctly loaded.  
  
7.  Implement a command on the VSPackage to force re-initialization of the **Toolbox**.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../Topic/Visual%20Studio%20SDK.md).  
  
## Locations for the Visual Studio Package Project Template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1.  Under Visual Basic Extensibility. The default language of the project is Visual Basic.  
  
2.  Under C# Extensibility. The default language of the project is C#.  
  
3.  Under Other Project Types Extensibility. The default language of the project is C++.  
  
## Creating a Managed VSPackage  
 Complete the following procedures to create a managed VSPackage.  
  
#### To create a managed VSPackage to provide toolbox items  
  
1.  Create a VSPackage named `ItemConfiguration`. For more information, see [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template.md).  
  
2.  In the **Visual Studio Package** template, add a menu command.  
  
     Name the command `Initialize ItemConfigurationVB` for Visual Basic or `Initialize ItemConfigurationCS` for Visual C#.  
  
3.  For Visual Basic, add the following namespaces to the imported namespaces list in the generated project:  
  
    -   Company.ItemConfiguration  
  
    -   System  
  
    -   System.ComponentModel  
  
    -   System.Drawing  
  
    -   System.Windows.Forms  
  
4.  Add a reference to the <xref:System.Drawing.Design?qualifyHint=True> .NET Framework component.  
  
 If you follow this walkthrough for more than one language, you must update the project to disambiguate the generated assemblies.  
  
#### To disambiguate Visual Basic and Visual C# VSPackages  
  
1.  For Visual Basic:  
  
    1.  Open the project properties, and select the **Application** tab.  
  
         Change the assembly name to `ItemConfigurationVB`, and change the default namespace to `Company.ItemConfigurationVB`.  
  
    2.  Select the **References** tab.  
  
         Update the imported namespaces list.  
  
         Remove Company.ItemConfiguration.  
  
         Add Company.ItemConfigurationVB.  
  
2.  For Visual C#:  
  
    1.  Open the project properties, and select the **Application** tab.  
  
         Change the assembly name to `ItemConfigurationCS`, and change the default namespace to `Company.ItemConfigurationCS`.  
  
    2.  Open the ItemConfigurationPackage class in the code editor.  
  
         To use the refactoring tools to rename the existing namespace, right-click the existing namespace name, `ItemConfiguration`, point to **Refactor**, and then click **Rename**. Change the name to `ItemConfigurationCS`.  
  
3.  Save all changes.  
  
#### To test the generated code  
  
1.  Compile and start the VSPackage in the Visual Studio experimental hive.  
  
2.  On the **Tools** menu, click **Initialize Item Configuration VB** or **Initialize Item Configuration CS**.  
  
     Doing this opens a message box that contains text that indicates that the package's menu item handler was called.  
  
3.  Close the experimental version of Visual Studio.  
  
## Creating Toolbox Controls  
 In this section, you create and register a user control, `Control1`, that declares an associated default **Toolbox** item. You also create and register a second user control, `Control2`, and an associated custom **Toolbox** item, `Control2_ToolboxItem`, that is derived from the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> class. For more information about how to author Windows Forms controls and <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> classes, see [Developing Windows Forms Controls at Design Time](../Topic/Developing%20Windows%20Forms%20Controls%20at%20Design%20Time.md).  
  
#### To create default and custom toolbox items  
  
1.  Use the instructions in [Walkthrough: Autoloading Toolbox Items](../VS_not_in_toc/Walkthrough--Autoloading-Toolbox-Items.md) to create a default **Toolbox** item and a custom **Toolbox** item, as follows.  
  
    1.  Complete the procedure, "To create a **Toolbox** control that will be used with a default ToolboxItem." Update the <xref:System.ComponentModel.DescriptionAttribute?qualifyHint=False> to reference this project.  
  
         The resulting code for the `Control1` class should resemble the following code.  
  
         [!CODE [DynamicToolboxMembers#01](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#01)]  
  
    2.  Complete the procedure, "To create a **Toolbox** control for using a custom ToolboxItem-derived class." Update the <xref:System.ComponentModel.DescriptionAttribute?qualifyHint=False> to reference this project.  
  
         The resulting code for the `Control2` and `Control2_ToolboxItem` classes should resemble the following code.  
  
         [!CODE [DynamicToolboxMembers#02](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#02)]  
  
2.  Save the files.  
  
## Embedding Bitmap Icons  
 The <xref:System.Drawing.ToolboxBitmapAttribute?qualifyHint=False> attribute that is applied to each control specifies which icon to associate with that control. Create the bitmaps for both controls, and name them as follows:  
  
-   `Control1.bmp`, for the `Control1` class.  
  
-   `Control2.bmp`, for the `Control2` class.  
  
#### To embed a bitmap icon for a Toolbox item  
  
1.  Add a new bitmap to the project, as follows:  
  
    1.  In **Solution Explorer**, right-click the VSPackage project, point to **Add**, and then click **New Item**.  
  
    2.  In the **Add New Item** dialog box, select **Bitmap File**, and enter the name of the bitmap.  
  
2.  Use the bitmap editor to create a 16x16 icon, as follows.  
  
    1.  On the **View** menu, click **Properties Window**.  
  
    2.  In the **Properties** window, set **Height** and **Width** to 16.  
  
    3.  Use the editor to create the icon image.  
  
3.  In **Solution Explorer**, right-click the bitmap item, and then click **Properties**.  
  
4.  Set the **Build Action** property to **Embedded Resource**.  
  
5.  Save all open files.  
  
## Adding a Dynamic Toolbox Configuration Provider  
 In this section, you create and register a class that implements the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False> interface. This class is instantiated and used by the Visual Studio integrated development environment (IDE) to configure **Toolbox** controls.  
  
> [!NOTE]
>  Because the Visual Studio environment instantiates an instance of the implementation of <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False>, do not implement the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False> interface on the class that implements <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> for a VSPackage.  
  
#### To create and register a toolbox control configuration object  
  
1.  In **Solution Explorer**, add a class to the ItemConfiguration project, and name it `ToolboxConfig`.  
  
2.  Add the following namespace statements to the file.  
  
     [!CODE [DynamicToolboxMembers#03](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#03)]  
  
3.  Ensure that the `ToolboxConfig` class is `public` and implements the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False> interface.  
  
4.  Apply a <xref:System.Runtime.InteropServices.GuidAttribute?qualifyHint=False> and a <xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute?qualifyHint=False> to the `ToolboxConfig` class`.`  
  
    -   For Visual Basic, use an assembly name of `"ItemConfigurationVB, Version=*, Culture=*, PublicKeyToken=*"`.  
  
    -   For Visual C#, use an assembly name of `"ItemConfigurationCS, Version=*, Culture=*, PublicKeyToken=*"`.  
  
     Doing this restricts the `ToolboxConfig` class to working on <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are provided by the assembly that contains the current VSPackage.  
  
     [!CODE [DynamicToolboxMembers#04](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#04)]  
  
     You can generate a GUID by clicking **Create GUID** on the **Tools** menu. Select **the format with square braces**, click **Copy**, and then paste the GUID in your code. change the keyword `GUID` to `Guid`.  
  
5.  Implement the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem.ConfigureToolboxItem?qualifyHint=False> method of the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem?qualifyHint=False> interface so that the method only acts on the two <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> classes, `Control1` and `Control2`.  
  
     The implementation of <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem.ConfigureToolboxItem?qualifyHint=False> applies instances of <xref:System.ComponentModel.ToolboxItemFilterAttribute?qualifyHint=False> to the two <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects so that:  
  
    -   The <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> that is implemented by `Control1` is only available in the **Toolbox** for designers that handle <xref:System.Windows.Forms.UserControl?qualifyHint=False> objects.  
  
    -   The <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> that is implemented by `Control2` is not available in the **Toolbox** for designers that handle <xref:System.Windows.Forms.UserControl?qualifyHint=False> objects.  
  
     [!CODE [DynamicToolboxMembers#05](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#05)]  
  
## Modifying the VSPackage Implementation  
 The default implementation of the VSPackage that is provided by the Visual Studio Package template must be modified to do the following things:  
  
-   Register as a **Toolbox** item provider.  
  
-   Register the class that provides the dynamic **Toolbox** control configuration for the VSPackage.  
  
-   Use the <xref:System.Drawing.Design.ToolboxService?qualifyHint=False> to load all the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are provided by the VSPackage assembly.  
  
-   Handle <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events.  
  
#### To modify the Package implementation for a Toolbox item provider on the VSPackage  
  
1.  Open the ItemConfigurationPackage class in the code editor.  
  
2.  Modify the declaration of the `ItemConfigurationPackage` class, which is the implementation of the <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> class in the solution.  
  
    1.  Add the following namespace statements to the file.  
  
         [!CODE [DynamicToolboxMembers#06](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#06)]  
  
    2.  To register the VSPackage as providing **Toolbox** items, apply a <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> to the package. To register the `ToolboxConfig` class as providing a **Toolbox** control dynamic configuration, apply a <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute?qualifyHint=False> to the package.  
  
         [!CODE [DynamicToolboxMembers#07](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#07)]  
  
        > [!NOTE]
        >  The only argument of <xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute?qualifyHint=False> is the version of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> that is provided by the VSPackage. By changing this value, you force the IDE to load the VSPackage even if it has an earlier cached version of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False>.  
  
    3.  Create two new `private` fields in the `ItemConfiguration` class, as follows:  
  
         An <xref:System.Collections.ArrayList?qualifyHint=False> member, named `ToolboxItemList`, to hold a list of the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the `ItemConfiguration` class manages.  
  
         A <xref:System.String?qualifyHint=False>, named `CategoryTab`, that contains the **Toolbox** tab that is used to hold the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that the `ItemConfiguration` class manages.  
  
         [!CODE [DynamicToolboxMembers#08](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#08)]  
  
     The result of this modification resembles the following code:  
  
     [!CODE [DynamicToolboxMembers#09](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#09)]  
  
3.  Define an `OnRefreshToolbox` method to handle the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events.  
  
     The `OnRefreshToolbox` method uses the list of <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that is contained in the `ToolboxItemList` field and does the following things:  
  
    -   Removes all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects from the **Toolbox** tab that is defined by the `CategoryTab` field.  
  
    -   Adds to the **Toolbox** tab new instances of all <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are listed in the `ToolboxItemList` field.  
  
    -   Sets the **Toolbox** tab as the active tab.  
  
     [!CODE [DynamicToolboxMembers#10](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#10)]  
  
4.  For Visual C#, in the constructor, register the `OnRefreshToolbox` method as the event hander for the <xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded?qualifyHint=False> events.  
  
     [!CODE [DynamicToolboxMembers#11](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#11)]  
  
5.  Modify the `Initialize` method in `ItemConfigurationPackage` to fill the `ToolboxItemList` field by calling the <xref:System.Drawing.Design.ToolboxService.GetToolboxItems?qualifyHint=False> method of the <xref:System.Drawing.Design.ToolboxService?qualifyHint=True> class. The **Toolbox** service gets all the **Toolbox** item classes that are defined in the currently executing assembly. The `ToolboxItemList` field is used by the **Toolbox** event handlers to load the **Toolbox** items.  
  
     Add the following code at the end of the `Initialize` method.  
  
     [!CODE [DynamicToolboxMembers#12](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#12)]  
  
    > [!NOTE]
    >  As an exercise, one could develop a mechanism for testing the version of the VSPackage or the items, and only update if the VSPackage version has changed or if the version of the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> has changed.  
  
## Initializing the Toolbox  
  
#### To implement a command to initialize the Toolbox  
  
-   In the `ItemConfigurationPackage` class, change the `MenuItemCallBack` method, which is the menu item's command handler.  
  
     Replace the existing implementation of the `MenuItemCallBack` method by using the following code:  
  
     [!CODE [DynamicToolboxMembers#13](../CodeSnippet/VS_Snippets_VSSDK/dynamictoolboxmembers#13)]  
  
## Building and Running the Solution  
 You can exercise the product of this walkthrough by using an instance of Visual Studio that is running in the experimental hive.  
  
#### To exercise this walkthrough  
  
1.  In Visual Studio, on the **Build** menu, click **Rebuild Solution**.  
  
2.  Press F5 to start a second instance of Visual Studio in the experimental registry hive.  
  
     For more information about how to use the experimental hive, see [The Experimental Instance](../Topic/The%20Experimental%20Instance.md).  
  
3.  Click the **Tools** menu.  
  
     A command named **Initialize ItemConfiguration VB** or **Initialize ItemConfiguration CS** appears at the top of the menu, together with an icon that has the numeral 1.  
  
4.  Create a new Visual C# or Visual Basic Windows Forms application.  
  
     A <xref:System.Windows.Forms.Form?qualifyHint=False>-based designer appears.  
  
5.  Add a user control to the project.  
  
     A user control designer appears.  
  
6.  Pin the **Toolbox** open, and switch between the two design views.  
  
     Notice that which **Toolbox** item is visible and which one is hidden depends on which designer has focus.  
  
7.  Drag the first **Toolbox** item onto the user control to add an instance of `Control1` to the user control.  
  
8.  Drag the second **Toolbox** item onto the form to add an instance of `Control2` to the form.  
  
9. Build the Windows application.  
  
     The user control for the application is now available in the **Toolbox**.  
  
10. Add the application's user control to the form, and then rebuild the application and run it.  
  
     When the application runs, click each control on the form to get the associated message box.  
  
## Analysis of the Implementation  
 Because the `assemblyFilter` parameter is present in the <xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute?qualifyHint=False> class constructor, only <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects in the assembly produced in this walkthrough are acted on by the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem.ConfigureToolboxItem?qualifyHint=False> method of the `ToolboxConfg` class.  
  
 Therefore, whenever the **ItemConfiguration Walkthrough**category is active on the **Toolbox**, the <xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem.ConfigureToolboxItem?qualifyHint=False> method of the `ToolboxConfg` class is called, and <xref:System.ComponentModel.ToolboxItemFilterAttribute?qualifyHint=False> instances are applied on the <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects that are implemented by `Control1` and `Control2`.  
  
## See Also  
 [Extending the Toolbox](../VS_not_in_toc/Extending-the-Toolbox.md)   
 [Registering Toolbox Support Features](../VS_not_in_toc/Registering-Toolbox-Support-Features.md)   
 [Advanced Toolbox Control Development](../VS_not_in_toc/Advanced-Toolbox-Control-Development.md)   
 [Toolbox Walkthroughs](../VS_not_in_toc/Toolbox-Walkthroughs.md)