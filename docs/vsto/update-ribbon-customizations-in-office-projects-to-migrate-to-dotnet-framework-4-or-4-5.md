---
title: "Update Ribbon customizations migrated to .NET Framework 4.5"
description: Learn that you must make changes to your project code if the target framework is changed to the .NET Framework 4 or later.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: upgrade-and-migration-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Update Ribbon customizations migrated to .NET Framework 4.5

  If your project contains a Ribbon customization that was created by using the **Ribbon (Visual Designer)** project item, you must make the following changes to your project code if the target framework is changed to the .NET Framework 4 or later.

- Modify the generated Ribbon code.

- Modify any code that instantiates Ribbon controls at run time, handles Ribbon events, or sets the position of a Ribbon component programmatically.

## Update the generated Ribbon code
 If the target framework of your project is changed to the .NET Framework 4 or later, you must change the generated code for the Ribbon item by performing the following steps. The code files you need to update depend on the programming language and how you created the project:

- In Visual Basic projects, or in Visual C# projects that you created in either Visual Studio 2012 or Visual Studio 2010 perform all of the steps in the Ribbon code-behind file (*YourRibbonItem*.Designer.cs or *YourRibbonItem*.Designer.vb). To see the code-behind file in Visual Basic projects, click the **Show All Files** button in **Solution Explorer**.

- In Visual C# projects that you created in Visual Studio 2008 and then upgraded to Visual Studio 2013, perform the first two steps in the Ribbon code file (*YourRibbonItem*.cs or *YourRibbonItem*.vb), and perform the remaining steps in the Ribbon code-behind file.

### To change the generated Ribbon code

1. Modify the declaration of the Ribbon class so that it derives from <xref:Microsoft.Office.Tools.Ribbon.RibbonBase> instead of `Microsoft.Office.Tools.Ribbon.OfficeRibbon`.

2. Modify the constructor of the Ribbon class as shown below. If you have added any of your own code to the constructor, do not change your code. In Visual Basic projects, modify only the parameterless constructor. Ignore the other constructor.

     The following code example shows the default constructor of a Ribbon class in a project that targets the .NET Framework 3.5.

    ### [C#](#tab/csharp)
    ```csharp
    public Ribbon1()
    {
        InitializeComponent();
    }
    ```

    ### [VB](#tab/vb)
    ```vb
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    ```
    ---

     The following code example shows the default constructor of a Ribbon class in a project that targets the .NET Framework 4 or later.

    ### [C#](#tab/csharp)
    ```csharp
    public Ribbon1()
        : base(Globals.Factory.GetRibbonFactory())
    {
        InitializeComponent();
    }
    ```

    ### [VB](#tab/vb)
    ```vb
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())
        InitializeComponent()
    End Sub
    ```
    ---

3. In the `InitializeComponent` method, modify any code that constructs a Ribbon control so that the code instead uses one of the helper methods of the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

    > [!NOTE]
    > In Visual C# projects, you must expand the region that is named `Component Designer generated code` to see the `InitializeComponent` method.

     For example, assume that your file contains the following line of code that instantiates a <xref:Microsoft.Office.Tools.Ribbon.RibbonButton> named `button1` in a project that targets the .NET Framework 3.5.

    ### [C#](#tab/csharp)
    ```csharp
    this.button1 = new Microsoft.Office.Tools.Ribbon.RibbonButton();
    ```

    ### [VB](#tab/vb)
    ```vb
    Me.button1 = New Microsoft.Office.Tools.Ribbon.RibbonButton()
    ```
    ---

     In a project that targets the .NET Framework 4 or later, you must use the following code instead.

    ### [C#](#tab/csharp)
    ```csharp
    this.button1 = this.Factory.CreateRibbonButton();
    ```

    ### [VB](#tab/vb)
    ```vb
    Me.button1 = Me.Factory.CreateRibbonButton()
    ```
    ---

     For a full list of the helper methods for the Ribbon controls, see [Instantiate Ribbon controls](#ribboncontrols).

4. In Visual C# projects, modify any line of code in the `InitializeComponent` method that uses an <xref:System.EventHandler%601> delegate to use a specific Ribbon delegate instead.

     For example, assume that your file contains the following line of code that handles the <xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> event in a project that targets the .NET Framework 3.5.

    \<CodeContentPlaceHolder>8</CodeContentPlaceHolder>
     In a project that targets the .NET Framework 4 or later, you must use the following code instead.

    \<CodeContentPlaceHolder>9</CodeContentPlaceHolder>
     For a full list of the Ribbon delegates, see [Handle Ribbon events](#ribbonevents).

5. In Visual Basic projects, locate the `ThisRibbonCollection` class at the end of the file. Modify the declaration of this class so that it no longer inherits from `Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection`.

## <a name="ribboncontrols"></a> Instantiate Ribbon controls
 You must modify any code that dynamically instantiates Ribbon controls. In projects that target the .NET Framework 3.5, Ribbon controls are classes that you can instantiate directly in certain scenarios. In projects that target the .NET Framework 4 or later, these controls are interfaces that you cannot instantiate directly. You must create the controls by using methods that are provided by the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

 There are two ways to access the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object:

- By using the Factory property of the Ribbon class. Use this approach from code in your Ribbon class.

- By using the `Globals.Factory.GetRibbonFactory` method. Use this approach from code outside your Ribbon class. For more information about the Globals class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

  The following code example demonstrates how to create a <xref:Microsoft.Office.Tools.Ribbon.RibbonButton> in a Ribbon class in a project that targets the .NET Framework 4 or later.

\<CodeContentPlaceHolder>10</CodeContentPlaceHolder>
\<CodeContentPlaceHolder>11</CodeContentPlaceHolder>
 The following table lists the controls you can create programmatically and the method to use to create the controls in projects that target the .NET Framework 4 or later.

|Control|RibbonFactory method to use in .NET Framework 4 and later projects|
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
 You must modify any code that handles events of Ribbon controls. In projects that target the .NET Framework 3.5, these events are handled by the generic <xref:System.EventHandler%601> delegate. In projects that target the .NET Framework 4 or later, these events are now handled by other delegates.

 The following table lists the Ribbon events and the delegates that are associated with them in projects that target the .NET Framework 4 or later.

|Event|Delegate to use in .NET Framework 4 and later projects|
|-----------| - |
|<xref:Microsoft.Office.Tools.Ribbon.OfficeRibbon.LoadImage> event in a generated Ribbon class|<xref:Microsoft.Office.Tools.Ribbon.RibbonLoadImageEventHandler>|
|<xref:Microsoft.Office.Tools.Ribbon.OfficeRibbon.Load>|<xref:Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler>|
|<xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonComboBox.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonComboBox.TextChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.ButtonClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonDropDown.SelectionChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonEditBox.TextChanged><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.ButtonClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGallery.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonGroup.DialogLauncherClick><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonMenu.ItemsLoading><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonSplitButton.Click><br /><br /> <xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click>|<xref:Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler>|

## Set the position of a Ribbon component programmatically
 You must modify any code that sets the position of Ribbon groups, tabs, or controls. In projects that target the .NET Framework 3.5, you can use the `AfterOfficeId` and `BeforeOfficeId` methods of the static `Microsoft.Office.Tools.Ribbon.RibbonPosition` class to assign the `Position` property of a group, tab, or control. In projects that target the .NET Framework 4 or later, you must access these methods by using the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory.RibbonPosition%2A> property provided by the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object.

 There are two ways to access the <xref:Microsoft.Office.Tools.Ribbon.RibbonFactory> object:

- By using the `Factory` property of the Ribbon class. Use this approach from code in your Ribbon class.

- By using the `Globals.Factory.GetRibbonFactory` method. Use this approach from code outside your Ribbon class. For more information about the Globals class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

  The following code example demonstrates how to set the `Position` property of a tab in a Ribbon class in a project that targets the .NET Framework 3.5.

### [C#](#tab/csharp)
```csharp
this.tab1.Position = RibbonPosition.AfterOfficeId("TabHome");
```

### [VB](#tab/vb)
```vb
Me.tab1.Position = RibbonPosition.AfterOfficeId("TabHome")
```
---

 The following code example demonstrates the same task in a project that targets the .NET Framework 4.

### [C#](#tab/csharp)
```csharp
this.tab1.Position = this.Factory.RibbonPosition.AfterOfficeId("TabHome");
```

### [VB](#tab/vb)
```vb
Me.tab1.Position = Me.Factory.RibbonPosition.AfterOfficeId("TabHome")
```
---

## Related content
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
