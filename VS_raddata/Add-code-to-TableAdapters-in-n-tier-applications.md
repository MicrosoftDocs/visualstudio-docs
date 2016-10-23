---
title: "Add code to TableAdapters in n-tier applications"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dafac00e-df9d-4d4a-95a6-e34b4d099425
caps.latest.revision: 19
manager: ghogen
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
# Add code to TableAdapters in n-tier applications
You can extend the functionality of a `TableAdapter` by creating a partial class file for the `TableAdapter` and adding code to it (instead of adding code to the *DatasetName*.DataSet.Designer file). Partial classes enable code for a specific class to be divided among multiple physical files. For more information, see [Partial](../Topic/Partial%20\(Visual%20Basic\).md) or [partial (Type)](../Topic/partial%20\(Type\)%20\(C%23%20Reference\).md).  
  
 The code that defines a `TableAdapter` is generated every time changes are made to the `TableAdapter` (in the [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md)). This code is also generated when changes are made during the running of any wizard that modifies the configuration of the `TableAdapter`. To prevent your code from being deleted during the regeneration of a `TableAdapter`, add code to the partial class file of the `TableAdapter`.  
  
 By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a file named *DatasetName*.Designer.vb (or *DatasetName*.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file named *DatasetName*.DataSet.Designer.vb (or *DatasetName*.DataSet.Designer.cs) that contains the dataset code.  
  
> [!NOTE]
>  When you separate datasets and `TableAdapter`s (by setting the **DataSet Project** property), existing partial dataset classes in the project will not be moved automatically. Existing dataset partial classes must be moved manually to the dataset project.  
  
> [!NOTE]
>  The [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md) provides functionality for generating <xref:System.Data.DataTable.ColumnChanging?qualifyHint=False> and <xref:System.Data.DataTable.RowChanging?qualifyHint=False> event handlers when validation is needed. For more information, see [Add validation to an n-tier dataset](../VS_raddata/Add-validation-to-an-n-tier-dataset.md).  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
### To add user code to a TableAdapter in an n-tier application  
  
1.  Locate the project that contains the .xsd file (the [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md)).  
  
2.  Double click the **.xsd** file to open the [Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md).  
  
3.  Right-click the `TableAdapter` that you want to add code to, and then select**View Code**.  
  
     A partial class is created and opens in the Code Editor.  
  
4.  Add code inside the partial class declaration.  
  
5.  The following example shows where to add code to the `CustomersTableAdapter` in the `NorthwindDataSet`:  
  
    ```vb#  
    Partial Public Class CustomersTableAdapter  
        ' Add code here to add functionality   
        ' to the CustomersTableAdapter.  
    End Class  
    ```  
  
    ```c#  
    public partial class CustomersTableAdapter  
    {  
        // Add code here to add functionality  
        // to the CustomersTableAdapter.  
    }  
    ```  
  
## See Also  
 [N-Tier Data Applications Overview](../VS_raddata/N-Tier-Data-Applications-Overview.md)   
 [Add code to datasets in n-tier applications](../VS_raddata/Add-code-to-datasets-in-n-tier-applications.md)   
 [TableAdapters](../Topic/TableAdapters.md)   
 [TableAdapterManager Overview](../Topic/TableAdapterManager%20Overview.md)   
 [Hierarchical Update Overview](../Topic/Hierarchical%20Update%20Overview.md)   
 [Creating Data Applications](../VS_raddata/Creating-Data-Applications.md)