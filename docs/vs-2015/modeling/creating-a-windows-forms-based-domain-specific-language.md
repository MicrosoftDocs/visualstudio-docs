---
title: "Creating a Windows Forms-Based Domain-Specific Language | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 452318ff-8ecf-46d0-8ca0-4013d0cdafaf
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Creating a Windows Forms-Based Domain-Specific Language
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use Windows Forms to display the state of a domain-specific language (DSL) model, instead of using a DSL diagram. This topic walks you through binding a Windows Form to a DSL, using the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Visualization and Modeling SDK.

 ![DSL&#45;Wpf&#45;2](../modeling/media/dsl-wpf-2.png "DSL-Wpf-2")
A DSL instance, showing a Windows Form UI and the model explorer.

## Creating a Windows Forms DSL
 The **Minimal WinForm Designer** DSL template creates a minimal DSL that you can modify to suit your own requirements.

#### To create a minimal WinForms DSL

1. Create a DSL from the **Minimal WinForm Designer** template.

    In this walkthrough, the following names are assumed:

   |                       |                 |
   |-----------------------|-----------------|
   | Solution and DSL name |     FarmApp     |
   |       Namespace       | Company.FarmApp |

2. Experiment with the initial example that the template provides:

   1. Transform All Templates.

   2. Build and run the sample (**CTRL+F5**).

   3. In the experimental instance of Visual Studio, open the `Sample` file in the debugging project.

        Notice that it is displayed in a Windows Forms control.

        You can also see the elements of the model displayed in the Explorer.

        Add some elements either in the form or the Explorer, and notice that they appear in the other display.

   In the main instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], notice the following points about the DSL solution:

- `DslDefinition.dsl` contains no diagram elements. This is because you will not use DSL diagrams to view instance models of this DSL. Instead, you will bind a Windows Form to the model, and the elements on the form will display the model.

- In addition to the `Dsl` and `DslPackage` projects, the solution contains a third project named `UI.`**UI** project contains the definition of a Windows Forms control. `DslPackage` depends on `UI`, and `UI` depends on `Dsl`.

- In the `DslPackage` project, `UI\DocView.cs` contains the code that displays the Windows Forms control that is defined in the `UI` project.

- The `UI` project contains a working sample of a form control bound to the DSL. However, it will not work when you have changed the DSL Definition. The `UI` project contains:

  - A Windows Forms class named `ModelViewControl`.

  - A file named `DataBinding.cs` that contains an additional partial definition of `ModelViewControl`. To see its content, in **Solution Explorer**, open the shortcut menu for the file and choose **View Code**.

### About the UI Project
 When you update the DSL Definition file to define your own DSL, you will have to update the control in the `UI` project to display your DSL. Unlike the `Dsl` and `DslPackage` projects, the sample `UI` project is not generated from `DslDefinitionl.dsl`. You can add .tt files to generate the code if you want, although that is not covered in this walkthrough.

## Updating the DSL Definition
 The following the DSL definition is used in this walkthrough.

 ![DSL&#45;Wpf&#45;1](../modeling/media/dsl-wpf-1.png "DSL-Wpf-1")

#### To update the DSL definition

1. Open DslDefinition.dsl in the DSL designer.

2. Delete **ExampleElement**

3. Rename the **ExampleModel** domain class to `Farm`.

     Give it additional domain properties named `Size` of type **Int32**, and `IsOrganic` of type **Boolean**.

    > [!NOTE]
    > If you delete the root domain class and then create a new root, you will have to reset the Editor Root Class property. In **DSL Explorer**, select **Editor**. Then in the Properties window, set **Root Class** to `Farm`.

4. Use the **Named Domain Class** tool to create the following domain classes:

    - `Field` – Give this an additional domain property named `Size`.

    - `Animal` – In the Properties window, set **Inheritance Modifier** to **Abstract**.

5. Use the **Domain Class** tool to create the following classes:

    - `Sheep`

    - `Goat`

6. Use the **Inheritance** tool to make `Goat` and `Sheep` inherit from `Animal`.

7. Use the **Embedding** tool to embed `Field` and `Animal` under `Farm`.

8. You might want to tidy the diagram. To reduce the number of duplicate elements, use the **Bring Subtree Here** command on the shortcut menu of leaf elements.

9. **Transform All Templates** in the toolbar of Solution Explorer.

10. Build the **Dsl** project.

    > [!NOTE]
    > At this stage, the other projects will not build without errors. However, we want to build the Dsl project so that its assembly is available to the Data Source Wizard.

## Updating the UI Project
 Now you can create a new user control that will display the information that is stored in the DSL model. The easiest way to connect the user control to the model is through data bindings. The data binding adaptor type named **ModelingBindingSource** is specifically designed to connect DSLs to non-VMSDK interfaces.

#### To define your DSL model as a data source

1. On the **Data** menu, choose **Show Data Sources**.

     The **Data Sources** window opens.

     Choose **Add New Data Source**. The **Data Source Configuration Wizard** opens.

2. Choose **Object**, **Next**.

     Expand **Dsl**, **Company.FarmApp**, and select **Farm**, which is the root class of your model. Choose **Finish**.

     In Solution Explorer, the **UI** project now contains **Properties\DataSources\Farm.datasource**

     The properties and relationships of your model class appear in the Data Sources window.

     ![DslWpf&#45;3](../modeling/media/dslwpf-3.png "DslWpf-3")

#### To connect your model to a form

1. In the **UI** project, delete all the existing .cs files.

2. Add a new **User Control** file named `FarmControl` to the **UI** project.

3. In the **Data Sources** window, on the drop-down menu on **Farm**, choose **Details**.

    Leave the default settings for the other properties.

4. Open FarmControl.cs in the design view.

    Drag **Farm** from the Data Sources window onto FarmControl.

    A set of controls appears, one for each property. The relationship properties do not generate controls.

5. Delete **farmBindingNavigator**. This is also automatically generated in the `FarmControl` designer, but it is not useful for this application.

6. Using the toolbox, create two instances of **DataGridView**, and name them `AnimalGridView` and `FieldGridView`.

   > [!NOTE]
   > An alternative step is to drag the Animals and Fields items from the Data Sources window onto the control. This action automatically creates data grids and bindings between the grid view and the data source. However, this binding does not work correctly for DSLs. Therefore it is better to create the data grids and bindings manually.

7. If the Toolbox does not contain the **ModelingBindingSource** tool, add it. On the shortcut menu of the **Data** tab, choose **Choose Items**. In the **Choose Toolbox Items** dialog, select **ModelingBindingSource** from the **.NET Framework Tab**.

8. Using the Toolbox, create two instances of **ModelingBindingSource**, and name them `AnimalBinding` and `FieldBinding`.

9. Set the **DataSource** property of each **ModelingBindingSource** to **farmBindingSource**.

     Set the **DataMember** property to **Animals** or **Fields**.

10. Set the **DataSource** properties of `AnimalGridView` to `AnimalBinding`, and of  `FieldGridView` to `FieldBinding`.

11. Adjust the layout of the Farm control to your taste.

    The **ModelingBindingSource** is an adapter that performs several functions that are specific to DSLs:

- It wraps updates in a VMSDK Store Transaction.

   For example, when the user deletes a row from the data view grid, a regular binding would result in a transaction exception.

- It ensures that, when the user selects a row, the Properties window displays the properties of the corresponding model element, instead of the data grid row.

  ![DslWpf4](../modeling/media/dslwpf4.png "DslWpf4")
  Schema of links between data sources and views.

#### To complete the bindings to the DSL

1. Add the following code in a separate code file in the **UI** project:

    ```csharp
    using System.ComponentModel;
    using Microsoft.VisualStudio.Modeling;
    using Microsoft.VisualStudio.Modeling.Design;

    namespace Company.FarmApp
    {
      partial class FarmControl
      {
        public IContainer Components { get { return components; } }

        /// <summary>Binds the WinForms data source to the DSL model.
        /// </summary>
        /// <param name="nodelRoot">The root element of the model.</param>
        public void DataBind(ModelElement modelRoot)
        {
          WinFormsDataBindingHelper.PreInitializeDataSources(this);
          this.farmBindingSource.DataSource = modelRoot;
          WinFormsDataBindingHelper.InitializeDataSources(this);
        }
      }
    }
    ```

2. In the **DslPackage** project, edit **DslPackage\DocView.tt** to update the following variable definition:

    ```csharp
    string viewControlTypeName = "FarmControl";
    ```

## Testing the DSL
 The DSL solution can now build and run, although you might want to add further improvements later.

#### To test the DSL

1. Build and run the solution.

2. In the experimental instance of Visual Studio, open the **Sample** file.

3. In the **FarmApp Explorer**, open the shortcut menu on the **Farm** root node, and choose **Add New Goat**.

     `Goat1` appears in the **Animals** view.

    > [!WARNING]
    > You must use the shortcut menu on the **Farm** node, not the **Animals** node.

4. Select the **Farm** root node and view its properties.

     In the form view, change the **Name** or **Size** of the farm.

     When you navigate away from each field in the form, the corresponding property changes in the Properties window.

## Enhancing the DSL

#### To make the properties update immediately

1. In the design view of FarmControl.cs, select a simple field such as Name, Size or IsOrganic.

2. In the Properties window, expand **DataBindings** and open **(Advanced)**.

     In the **Formatting and Advanced Binding** dialog, under **Data Source Update Mode**, choose **OnPropertyChanged**.

3. Build and run the solution.

     Verify that when you change the content of the field, the corresponding property of the Farm model changes immediately.

#### To provide Add buttons

1. In the design view of FarmControl.cs, use the toolbox to create a button on the form.

    Edit the name and text of the button, for example to `New Sheep`.

2. Open the code behind the button (for example by double-clicking it).

    Edit it as follows:

   ```csharp
   private void NewSheepButton_Click(object sender, EventArgs e)
   {
     using (Transaction t = farm.Store.TransactionManager.BeginTransaction("Add sheep"))
     {
       elementOperations.MergeElementGroup(farm,
         new ElementGroup(new Sheep(farm.Partition)));
       t.Commit();
     }
   }

   // The following code is shared with other add buttons:
   private ElementOperations operationsCache = null;
   private ElementOperations elementOperations
   {
     get
     {
       if (operationsCache == null)
       {
         operationsCache = new ElementOperations(farm.Store, farm.Partition);
       }
       return operationsCache;
     }
   }
   private Farm farm
   {
     get { return this.farmBindingSource.DataSource as Farm; }
   }

   ```

    You will also need to insert the following directive:

   ```csharp

   using Microsoft.VisualStudio.Modeling;

   ```

3. Add similar buttons for Goats and Fields.

4. Build and run the solution.

5. Verify that the new button adds an item. The new item should appear in both the FarmApp Explorer and in the appropriate data grid view.

    You should be able to edit the name of the element in the data grid view. You can also delete it from there.

   ![DSL&#45;Wpf&#45;2](../modeling/media/dsl-wpf-2.png "DSL-Wpf-2")

### About the code to add an element
 For the new element buttons, the following alternative code is slightly simpler.

```csharp
private void NewSheepButton_Click(object sender, EventArgs e)
{
  using (Transaction t = farm.Store.TransactionManager.BeginTransaction("Add sheep"))
  {
    farm.Animals.Add(new Sheep(farm.Partition)); ;
    t.Commit();
  }
}

```

 However, this code does not set a default name for the new item. It does not run any customized merge that you might have defined in the **Element Merge Directives** of the DSL, and it does not run any custom merge code that might have been defined.

 Therefore we recommend that you use <xref:Microsoft.VisualStudio.Modeling.ElementOperations> to create new elements. For more information, see [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).

## See Also
 [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)
 [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
 [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)
