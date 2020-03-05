---
title: "Update Ribbon customizations in Office projects migrated to .NET Framework 4, 4.5"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Update Ribbon customizations in Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5
  If your project contains a Ribbon customization that was created by using the **Ribbon (Visual Designer)** project item, you must make the following changes to your project code if the target framework is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

- Modify the generated Ribbon code.

- Modify any code that instantiates Ribbon controls at run time, handles Ribbon events, or sets the position of a Ribbon component programmatically.

## Update the generated Ribbon code
 If the target framework of your project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must change the generated code for the Ribbon item by performing the following steps. The code files you need to update depend on the programming language and how you created the project:

- In Visual Basic projects, or in Visual C# projects that you created in either [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)] or [!INCLUDE[vs_dev10_long](../sharepoint/includes/vs-dev10-long-md.md)] perform all of the steps in the Ribbon code-behind file (*YourRibbonItem*.Designer.cs or *YourRibbonItem*.Designer.vb). To see the code-behind file in Visual Basic projects, click the **Show All Files** button in **Solution Explorer**.

- In Visual C# projects that you created in Visual Studio 2008 and then upgraded to [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)], perform the first two steps in the Ribbon code file (*YourRibbonItem*.cs or *YourRibbonItem*.vb), and perform the remaining steps in the Ribbon code-behind file.

### To change the generated Ribbon code

1. Modify the declaration of the Ribbon class so that it derives from <xref:Microsoft.Office.Tools.Ribbon.RibbonBase> instead of `Microsoft.Office.Tools.Ribbon.OfficeRibbon`.

2. Modify the constructor of the Ribbon class as shown below. If you have added any of your own code to the constructor, do not change your code. In Visual Basic projects, modify only the parameterless constructor. Ignore the other constructor.

     The following code example shows the default constructor of a Ribbon class in a project that targets the .NET Framework 3.5.

    ```vb
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    ```

    ```csharp
    public Ribbon1()
    {
        InitializeComponent();
    }
    ```

     The following code example shows the default constructor of a Ribbon class in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

    ```vb
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())
        InitializeComponent()
    End Sub
    ```

    ```csharp
    public Ribbon1()
        : base(Globals.Factory.GetRibbonFactory())
    {
        InitializeComponent();
    }
    ```

3. In the `InitializeComponent` method, modify any code that constructs a Ribbon control so that the code instead uses one of the helper methods of the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

    > [!NOTE]
    > In Visual C# projects, you must expand the region that is named `Component Designer generated code` to see the `InitializeComponent` method.

     For example, assume that your file contains the following line of code that instantiates a <xref:Microsoft.Office.Tools.Ribbon.RibbonButton> named `button1` in a project that targets the .NET Framework 3.5.

    ```vb
    Me.button1 = New Microsoft.Office.Tools.Ribbon.RibbonButton()
    ```

    ```csharp
    this.button1 = new Microsoft.Office.Tools.Ribbon.RibbonButton();
    ```

     In a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must use the following code instead.

    ```vb
    Me.button1 = Me.Factory.CreateRibbonButton()
    ```

    ```csharp
    this.button1 = this.Factory.CreateRibbonButton();
    ```

     For a full list of the helper methods for the Ribbon controls, see [Instantiate Ribbon controls](#ribboncontrols).

4. In Visual C# projects, modify any line of code in the `InitializeComponent` method that uses an <xref:System.EventHandler%601> delegate to use a specific Ribbon delegate instead.

     For example, assume that your file contains the following line of code that handles the <xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> event in a project that targets the .NET Framework 3.5.

    \<CodeContentPlaceHolder>8</CodeContentPlaceHolder>
     In a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must use the following code instead.

    \<CodeContentPlaceHolder>9</CodeContentPlaceHolder>
     For a full list of the Ribbon delegates, see [Handle Ribbon events](#ribbonevents).

5. In Visual Basic projects, locate the `ThisRibbonCollection` class at the end of the file. Modify the declaration of this class so that it no longer inherits from `Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection`.

## <a name="ribboncontrols"></a> Instantiate Ribbon controls
 You must modify any code that dynamically instantiates Ribbon controls. In projects that target the .NET Framework 3.5, Ribbon controls are classes that you can instantiate directly in certain scenarios. In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, these controls are interfaces that you cannot instantiate directly. You must create the controls by using methods that are provided by the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

 There are two ways to access the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object:

- By using the Factory property of the Ribbon class. Use this approach from code in your Ribbon class.

- By using the `Globals.Factory.GetRibbonFactory` method. Use this approach from code outside your Ribbon class. For more information about the Globals class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

  The following code example demonstrates how to create a <xref:Microsoft.Office.Tools.Ribbon.RibbonButton> in a Ribbon class in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

\<CodeContentPlaceHolder>10</CodeContentPlaceHolder>
\<CodeContentPlaceHolder>11</CodeContentPlaceHolder>
 The following table lists the controls you can create programmatically and the method to use to create the controls in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

|Control|RibbonFactory method to use in [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] and later projects|
|-------------| - |
|<xref:Microsoft.Office.Tools.Ribbon.RibbonButton>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonButton%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonButtonGroup>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonButtonGroup%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonCheckBox%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonComboBox>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonComboBox%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonDialogLauncher%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown>:|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonDropDown%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonDropDownItem>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonDropDownItem%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonEditBox>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonEditBox%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonGallery>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonGallery%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonGroup>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonGroup%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonLabel>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonLabel%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonManager>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonManager%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonMenu>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonMenu%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonSeparator>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonSeparator%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonSplitButton>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonSplitButton%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonTab>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonTab%2A>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton>|<xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.CreateRibbonToggleButton%2A>|

## <a name="ribbonevents"></a> Handle Ribbon events
 You must modify any code that handles events of Ribbon controls. In projects that target the .NET Framework 3.5, these events are handled by the generic <xref:System.EventHandler%601> delegate. In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, these events are now handled by other delegates.

 The following table lists the Ribbon events and the delegates that are associated with them in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

|Event|Delegate to use in [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] and later projects|
|-----------| - |
|<xref:Microsoft.Office.Tools.Ribbon.OfficeRibbon.LoadImage> event in a generated Ribbon class|<xref:Microsoft.Office.Tools.Ribbon.RibbonLoadImageEventHandler>|
|<xref:Microsoft.Office.Tools.Ribbon.OfficeRibbon.Load>|<xref:Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonComboBox.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonComboBox.TextChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.ButtonClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.SelectionChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonEditBox.TextChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.ButtonClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGroup.DialogLauncherClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonMenu.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonSplitButton.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click>|<xref:Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler>|

## Set the position of a Ribbon component programmatically
 You must modify any code that sets the position of Ribbon groups, tabs, or controls. In projects that target the .NET Framework 3.5, you can use the `AfterOfficeId` and `BeforeOfficeId` methods of the static `Microsoft.Office.Tools.Ribbon.RibbonPosition` class to assign the `Position` property of a group, tab, or control. In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must access these methods by using the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.RibbonPosition%2A> property provided by the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

 There are two ways to access the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object:

- By using the `Factory` property of the Ribbon class. Use this approach from code in your Ribbon class.

- By using the `Globals.Factory.GetRibbonFactory` method. Use this approach from code outside your Ribbon class. For more information about the Globals class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

  The following code example demonstrates how to set the `Position` property of a tab in a Ribbon class in a project that targets the .NET Framework 3.5.

```vb
Me.tab1.Position = RibbonPosition.AfterOfficeId("TabHome")
```

```csharp
this.tab1.Position = RibbonPosition.AfterOfficeId("TabHome");
```

 The following code example demonstrates the same task in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)].

```vb
Me.tab1.Position = Me.Factory.RibbonPosition.AfterOfficeId("TabHome")
```

```csharp
this.tab1.Position = this.Factory.RibbonPosition.AfterOfficeId("TabHome");
```

## See also
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
