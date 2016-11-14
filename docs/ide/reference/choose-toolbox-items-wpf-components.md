---
title: "Choose Toolbox Items, WPF Components | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.chooseitems.wpfcomponents"
helpviewer_keywords: 
  - "WPF Components tab, Choose Toolbox Items dialog box"
  - "Choose Toolbox Items dialog box, WPF Components tab"
ms.assetid: 6ce1d178-88c0-4295-8915-59fdeedabb11
caps.latest.revision: 13
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Choose Toolbox Items, WPF Components
This tab of the **Choose Toolbox Items** dialog box displays a list of Windows Presentation Foundation (WPF) controls available on your local computer. To display this list, select **Choose Toolbox Items** from the **Tools** menu to display the **Choose Toolbox Items** dialog box, and then select its **WPF Components** tab. To sort the components listed, select any column heading.  
  
-   When the check box next to a component is selected, an icon for that component will be displayed in the **Toolbox**.  
  
    > [!TIP]
    >  To add an instance of a WPF control to a project document open for editing, drag its **Toolbox** icon onto the Design view surface. Default markup and code for the component are inserted into your project, ready for you to modify. For more information, see [How to: Manage the Toolbox Window](http://msdn.microsoft.com/en-us/a022c3fe-298c-4a59-a48f-b050da90ebc2) and [How to: Manipulate Toolbox Tabs](http://msdn.microsoft.com/en-us/21285050-cadd-455a-b1f5-a2289a89c4db).  
  
-   When the check box next to a component is cleared, the corresponding icon will be removed from the **Toolbox.**  
  
    > [!NOTE]
    >  The .NET Framework components installed on your computer remain available whether or not icons for them are displayed in the **Toolbox**.  
  
 The columns on the **WPF Components** tab contain the following information:  
  
 Name  
 Lists the names of WPF controls for which entries exist in your computer's registry.  
  
 Namespace  
 Displays the hierarchy of the [NIB: .NET Framework Class Library](http://msdn.microsoft.com/en-us/6c4f3a62-6a0f-41f2-9d52-ee0b13686f29) namespace that defines the structure of the component. Sort on this column to list the available components within each .NET Framework namespace installed on your computer.  
  
 Assembly Name  
 Displays the name of the .NET Framework assembly that includes the namespace for each component. Sort on this column to list the namespaces contained in each .NET Framework assembly installed on your computer.  
  
 Directory  
 Displays the location of the .NET Framework assembly. The default location for all assemblies is the Global Assembly Cache. For further information on the Global Assembly Cache, see [Working with Assemblies and the Global Assembly Cache](../Topic/Working%20with%20Assemblies%20and%20the%20Global%20Assembly%20Cache.md).  
  
## UIElement List  
 **Filter**  
 Filters the list of WPF controls based on the string you provide in the text box. All matches from any of the four columns are shown.  
  
 **Clear**  
 Clears the filter string.  
  
 **Browse**  
 Opens the **Open** dialog box, which lets you navigate to assemblies which contain WPF controls. Use this to load assemblies which are not located in the Global Assembly Cache.  
  
 **Language**  
 Shows the localized language of the assembly which contains the selected WPF control.  
  
## Limitations  
 Adding a custom control or <xref:System.Windows.Controls.UserControl> to the Toolbox has the following limitations.  
  
-   Works only for custom controls defined outside the current project.  
  
-   Does not update correctly when you change the solution configuration from Debug to Release, or from Release to Debug. This is because the reference is not a project reference, but is for the assembly on disk instead. If the control is part of the current solution, when you change from Debug to Release, your project continues to reference the Debug version of the control.  
  
 In addition, if design-time metadata is applied to the custom control and this metadata specifies that the <xref:Microsoft.Windows.Design.ToolboxBrowsableAttribute> is set to `false`, the control does not appear in the Toolbox.  
  
 You can reference your controls directly in XAML view by mapping the namespace and assembly for your control. For more information, see [How to: Import a Namespace into XAML](http://msdn.microsoft.com/en-us/6cda7c7a-369c-47dd-9c2d-13a35dcf737c).  
  
## See Also  
 [Choose Toolbox Items Dialog Box (Visual Studio)](http://msdn.microsoft.com/en-us/bd07835f-18a8-433e-bccc-7141f65263bb)   
 [Toolbox](../../ide/reference/toolbox.md)   
 [How to: Use a Third-Party WPF Control in a WPF Application](http://msdn.microsoft.com/en-us/f4c0b601-3818-4f9f-85e5-77905f3b427f)   
 [WPF Designer](http://msdn.microsoft.com/en-us/c6c65214-8411-4e16-b254-163ed4099c26)