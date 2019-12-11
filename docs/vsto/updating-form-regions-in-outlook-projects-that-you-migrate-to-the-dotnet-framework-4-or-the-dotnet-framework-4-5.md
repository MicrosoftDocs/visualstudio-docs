---
title: "Update Outlook form regions in projects migrated to .NET Framework 4, 4.5"
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
# Update form regions in Outlook projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5
  If the target framework of an Outlook VSTO Add-in project with a form region is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must make some changes to the generated form region code and to any code that instantiates certain form region classes at run time.

## Update the generated form region code
 If the target framework of the project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must change the generated form region code. The changes you make are different for form regions that you designed in Visual Studio and form regions that you imported from Outlook. For more information about the differences between these types of form regions, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

### To update the generated code for a form region that you designed in Visual Studio

1. Open the form region code-behind file in the code editor. This file is named *YourFormRegion*.Designer.cs or *YourFormRegion*.Designer.vb. To see this file in Visual Basic projects, click the **Show All Files** button in **Solution Explorer**.

2. Modify the declaration of the form region class so that it derives from <xref:Microsoft.Office.Tools.Outlook.FormRegionBase> instead of `Microsoft.Office.Tools.Outlook.FormRegionControl`.

3. Modify the constructor of the form region class as shown in the following code examples.

     The following code example shows the constructor of a form region class in a project that targets the .NET Framework 3.5.

    ```vb
    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(formRegion)
        Me.InitializeComponent()
    End Sub
    ```

    ```csharp
    public FormRegion1(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
        : base(formRegion)
    {
        this.InitializeComponent();
    }
    ```

     The following code example shows the constructor of a form region class in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)].

    ```vb
    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(Globals.Factory, formRegion)
        Me.InitializeComponent()
    End Sub
    ```

    ```csharp
    public FormRegion1(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
        : base(Globals.Factory, formRegion)
    {
        this.InitializeComponent();
    }
    ```

4. Modify the signature of the `InitializeManifest` method as shown below. Make sure that you do not modify the code in the method; this code represents form region settings that you applied in the designer. In Visual C# projects, you must expand the region that is named `Form Region Designer generated code` to see this method.

     The following code example shows the signature of the `InitializeManifest` method in a project that targets the .NET Framework 3.5.

    ```vb
    Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest)

        ' Do not change code in this method.
    End Sub
    ```

    ```csharp
    private static void InitializeManifest(Microsoft.Office.Tools.Outlook.FormRegionManifest manifest)
    {
        // Do not change code in this method.
    }
    ```

     The following code example shows the signature `InitializeManifest` method in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)].

    ```vb
    Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest,
        ByVal factory As Microsoft.Office.Tools.Outlook.Factory)

        ' Do not change code in this method.
    End Sub
    ```

    ```csharp
    private static void InitializeManifest(Microsoft.Office.Tools.Outlook.FormRegionManifest manifest,
        Microsoft.Office.Tools.Outlook.Factory factory)
    {
        // Do not change code in this method.
    }
    ```

5. Add a new Outlook Form Region item to your project. Open the code-behind file for the new form region, locate the *YourNewFormRegion*`Factory` and `WindowFormRegionCollection` classes in the file, and copy these classes to the Clipboard.

6. Delete the new form region you added to your project.

7. In the code-behind file of the form region that you are updating to work in the retargeted project, locate the *YourOriginalFormRegion*`Factory` and `WindowFormRegionCollection` classes and replace them with the code that you copied from the new form region.

8. In the *YourNewFormRegion*`Factory` and `WindowFormRegionCollection` classes, search for all references to the *YourNewFormRegion* class and change each reference to the *YourOriginalFormRegion* class instead. For example, if the form region you are updating is named `SalesDataFormRegion` and the new form region you created in step 5 is named `FormRegion1`, change all references of `FormRegion1` to `SalesDataFormRegion`.

#### To update the generated code for a form region that you imported from Outlook

1. Open the form region code-behind file in the code editor. This file is named *YourFormRegion*.Designer.cs or *YourFormRegion*.Designer.vb. To see this file in Visual Basic projects, click the **Show All Files** button in **Solution Explorer**.

2. Modify the declaration of the form region class so that it derives from <xref:Microsoft.Office.Tools.Outlook.ImportedFormRegionBase> instead of `Microsoft.Office.Tools.Outlook.ImportedFormRegion`.

3. Modify the constructor of the form region class as shown in the following code examples.

     The following code example shows the constructor of a form region class in a project that targets the .NET Framework 3.5.

    ```vb
    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(formRegion)
    End Sub
    ```

    ```csharp
    public ImportedFormRegion1(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
        : base(formRegion)
    {
        this.FormRegionShowing += new System.EventHandler(this.TaskFormRegion_FormRegionShowing);
        this.FormRegionClosed += new System.EventHandler(this.TaskFormRegion_FormRegionClosed);
    }
    ```

     The following code example shows the signature of the constructor of a form region class in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)].

    ```vb
    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(Globals.Factory, formRegion)
    End Sub
    ```

    ```csharp
    public ImportedFormRegion1(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
        : base(Globals.Factory, formRegion)
    {
        this.FormRegionShowing += new System.EventHandler(this.TaskFormRegion_FormRegionShowing);
        this.FormRegionClosed += new System.EventHandler(this.TaskFormRegion_FormRegionClosed);
    }
    ```

4. For each line of code in the `InitializeControls` method that initializes a control in the form region class, modify the code as shown below.

     The following code example shows how to initialize a control in a project that targets the .NET Framework 3.5. In this code, the `GetFormRegionControl` method has a type parameter that specifies the type of the control that is returned.

    ```vb
    Me.olkTextBox1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox1")
    ```

    ```csharp
    this.olkTextBox1 = this.GetFormRegionControl<Microsoft.Office.Interop.Outlook.OlkTextBox>("OlkTextBox1");
    ```

     The following code example shows how to initialize a control in a project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. In this code, the <xref:Microsoft.Office.Tools.Outlook.ImportedFormRegionBase.GetFormRegionControl%2A> method does not have a type parameter. You must cast the return value to the type of the control that you are initializing.

    ```vb
    Me.olkTextBox1 = CType(GetFormRegionControl("OlkTextBox1"), Microsoft.Office.Interop.Outlook.OlkTextBox)
    ```

    ```csharp
    this.olkTextBox1 = (Microsoft.Office.Interop.Outlook.OlkTextBox)GetFormRegionControl("OlkTextBox1");
    ```

5. Add a new Outlook Form Region item to your project. Open the code-behind file for the new form region, locate the *YourNewFormRegion*`Factory` and `WindowFormRegionCollection` classes in the file, and copy these classes to the Clipboard.

6. Delete the new form region you added to your project.

7. In the code-behind file of the form region that you are updating to work in the retargeted project, locate the *YourOriginalFormRegion*`Factory` and `WindowFormRegionCollection` classes and replace them with the code that you copied from the new form region.

8. In the *YourNewFormRegion*`Factory` and `WindowFormRegionCollection` classes, search for all references to the *YourNewFormRegion* class and change each reference to the *YourOriginalFormRegion* class instead. For example, if the form region you are updating is named `SalesDataFormRegion` and the new form region you created in step 5 is named `FormRegion1`, change all references of `FormRegion1` to `SalesDataFormRegion`.

## Instantiate form region classes
 You must modify any code that dynamically instantiates certain form region classes. In projects that target the .NET Framework 3.5, you can instantiate form region classes such as `Microsoft.Office.Tools.Outlook.FormRegionManifest` directly. In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, these classes are interfaces that you cannot instantiate directly.

 If the target framework of your project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must instantiate the interfaces by using methods that are provided by the `Globals.Factory` property. For more information about the `Globals.Factory` property, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

 The following table lists the form region types and the method to use to instantiate the types in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

|Type|Factory method to use|
|----------|---------------------------|
|<xref:Microsoft.Office.Tools.Outlook.FormRegionCustomAction>|<xref:Microsoft.Office.Tools.Outlook.Factory.CreateFormRegionCustomAction%2A>|
|<xref:Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs>|<xref:Microsoft.Office.Tools.Outlook.Factory.CreateFormRegionInitializingEventArgs%2A>|
|<xref:Microsoft.Office.Tools.Outlook.FormRegionManifest>|<xref:Microsoft.Office.Tools.Outlook.Factory.CreateFormRegionManifest%2A>|

## See also
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
