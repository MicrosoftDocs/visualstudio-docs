---
title: "Adding Visual Studio Commands to a Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "start page commands"
  - "vs:VSCommands"
ms.assetid: a8e2765c-cfb5-47b5-a414-6e48b434e0c2
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Adding Visual Studio Commands to a Start Page
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you create a custom start page, you can add Visual Studio commands to it. This document discusses the different ways to bind Visual Studio commands to XAML objects on a start page.  
  
 For more information about commands in XAML, see [Commanding Overview](https://msdn.microsoft.com/library/bc208dfe-367d-426a-99de-52b7e7511e81)  
  
## Adding Commands from the Command Well  
 The start page created in [Creating a Custom Start Page](../extensibility/creating-a-custom-start-page.md) added the <xref:Microsoft.VisualStudio.PlatformUI?displayProperty=fullName> and <xref:Microsoft.VisualStudio.Shell?displayProperty=fullName> namespaces, as follows.  
  
```  
xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.14.0"  
xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.14.0"  
```  
  
 Add another namespace for Microsoft.VisualStudio.Shell from the assembly Microsoft.VisualStudio.Shell.Immutable.11.0.dll. (You may need to add a reference to this assembly in your project.)  
  
```xml  
xmlns:vscom="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.Immutable.11.0"  
```  
  
 You can use the `vscom:` alias to bind Visual Studio commands to XAML controls on the page by setting the <xref:System.Windows.Controls.Primitives.ButtonBase.Command%2A> property of the control to `vscom:VSCommands.ExecuteCommand`. You can then set the <xref:System.Windows.Controls.Primitives.ButtonBase.CommandParameter%2A> property to the name of the command to execute, as shown in the following example.  
  
```xml  
<Button Name="btnNewProj" Content="New Project"   
    Command="{x:Static vscom:VSCommands.ExecuteCommand}"  
    CommandParameter="File.NewProject" >  
</Button>  
```  
  
> [!NOTE]
> The `x:` alias, which refers to the XAML schema, is required at the beginning of all commands.  
  
 You can set the value of the `Command` property to any command that can be accessed from the **Command** window. For a list of available commands, see [Visual Studio Command Aliases](../ide/reference/visual-studio-command-aliases.md).  
  
 If the command to add requires an additional parameter, you can add it to the value of the `CommandParameter` property. Separate parameters from commands by using spaces, as shown in the following example.  
  
```xml  
<Button Content="Web Search"   
        Command="{x:Static vscom:VSCommands.ExecuteCommand}"  
        CommandParameter="View.WebBrowser www.bing.com" />  
```  
  
### Calling Extensions from the Command Well  
 You can call commands from registered VSPackages by using the same syntax that is used to call other Visual Studio commands. For example, if an installed VSPackage adds a **Home Page** command to the **View** menu, you can call that command by setting `CommandParameter` to `View.HomePage`.  
  
> [!NOTE]
> If you call a command that is associated with a VSPackage, the package must be loaded when the command is invoked.  
  
## Adding Commands from Assemblies  
 To call a command from an assembly, or to access code in a VSPackage that is not associated with a menu command, you must create an alias for the assembly and then call the alias.  
  
#### To call a command from an assembly  
  
1. In your solution, add a reference to the assembly.  
  
2. At the top of the StartPage.xaml file, add a namespace directive for the assembly, as shown in the following example.  
  
    ```xml  
    xmlns:vsc="clr-namespace:WebUserControl;assembly=WebUserControl"  
    ```  
  
3. Invoke the command by setting the `Command` property of a XAML object, as shown in the following example.  
  
     Xaml  
  
    ```  
    <vs:Button Text="Hide me" Command="{x:Static vsc:HideControl}" .../>  
    ```  
  
> [!NOTE]
> You must copy your assembly and then paste it in ..\\*Visual Studio installation folder*\Common7\IDE\PrivateAssemblies\ to make sure it is loaded before it is called.  
  
## Adding Commands with the DTE object  
 You can access the DTE object from a Start Page, both in markup and in code.  
  
 In markup, you can access it by using the [Binding Markup Extension](https://msdn.microsoft.com/library/83d6e2a4-1b0c-4fc8-bd96-b5e98800ab63) syntax to call the <xref:EnvDTE.DTE> object. You can use this approach to bind to simple properties such as those that return collections, but you cannot bind to methods or services. The following example shows a <xref:System.Windows.Controls.TextBlock> control that binds to the <xref:EnvDTE._DTE.Name%2A> property, and a <xref:System.Windows.Controls.ListBox> control that enumerates the <xref:EnvDTE.Window.Caption%2A> properties of the collection that is returned by the <xref:EnvDTE._DTE.Windows%2A> property.  
  
```xml  
<TextBlock Text="{Binding Path=DTE.Name}" FontSize="12" HorizontalAlignment="Center"/>  
<ListBox ItemsSource="{Binding Path=DTE.Windows}">  
    <ListBox.ItemTemplate>  
        <DataTemplate>  
            <TextBlock Text="{Binding Path=Caption}"/>  
        </DataTemplate>  
    </ListBox.ItemTemplate>  
</ListBox  
```  
  
 For an example, see [Walkthrough: Saving User Settings on a Start Page](../extensibility/walkthrough-saving-user-settings-on-a-start-page.md).  
  
## See Also  
 [Adding User Control to the Start Page](../extensibility/adding-user-control-to-the-start-page.md)
