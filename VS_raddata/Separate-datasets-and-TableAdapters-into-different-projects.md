---
title: "Separate datasets and TableAdapters into different projects"
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
ms.assetid: f66a3940-6227-46af-a930-9177f425f4fd
caps.latest.revision: 18
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
# Separate datasets and TableAdapters into different projects
Typed datasets have been enhanced so that the [TableAdapters](../Topic/TableAdapters.md) and dataset classes can be generated into separate projects. This enables you to quickly separate application layers and generate n-tier data applications.  
  
 The following procedure describes the process of using the[Creating and Editing Typed Datasets](../VS_raddata/Creating-and-Editing-Typed-Datasets.md) to generate dataset code into a project that is separate from the project that contains the generated `TableAdapter` code.  
  
## Separatedatasets and TableAdapters  
 When you separate dataset code from `TableAdapter` code, the project that  contains the dataset code must be located in the current solution. If this project is not located in the current solution, it won't be available in the **DataSet Project** list in the **Properties** window.  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
#### To separate the dataset into a different project  
  
1.  Open a solution that contains a dataset (.xsd file).  
  
    > [!NOTE]
    >  If the solution does not contain the project into which you want to separate your dataset code, create the project, or add an existing project to the solution.  
  
2.  Double-click a typed dataset file (an .xsd file) in **Solution Explorer** to open the dataset in the **Dataset Designer**.  
  
3.  Select an empty area of the **Dataset Designer**.  
  
4.  In the **Properties** window, locate the **DataSet Project** node.  
  
5.  In the **DataSet Project** list, select the name of the project into which you want to generate the dataset code.  
  
     After you select the project into which you want to generate the dataset code, the **DataSet File** property is populated with a default file name. You can change this name if necessary. Additionally, if you want to generate the dataset code into a specific directory, you can set the **Project Folder** property to the name of a folder.  
  
    > [!NOTE]
    >  When you separate datasets and TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project won't be moved automatically. Existing dataset partial classes must be  moved manually to the dataset project.  
  
6.  Save the dataset.  
  
     The dataset code is generated into the selected project  in the **DataSet Project** property, and the **TableAdapter** code is generated into the current project.  
  
 By default, after you separate the dataset and `TableAdapter` code, the result is a discrete class file in each project. The original project has a file  named DatasetName.Designer.vb (or DatasetName.Designer.cs) that contains the `TableAdapter` code. The project that's designated in the **Dataset Project** property has a file named DatasetName.DataSet.Designer.vb (or DatasetName.DataSet.Designer.cs) that contains the dataset code.  
  
> [!NOTE]
>  To view the generated class file, select the dataset or `TableAdapter` project. Then, in  **Solution Explorer**, select **Show All Files** .  
  
## See Also  
 [N-Tier Data Applications Overview](../VS_raddata/N-Tier-Data-Applications-Overview.md)   
 [Walkthrough: Creating an N-Tier Data Application](../VS_raddata/Walkthrough--Creating-an-N-Tier-Data-Application.md)   
 [Hierarchical update](../VS_raddata/Hierarchical-update.md)   
 [Accessing data in Visual Studio](../VS_raddata/Accessing-data-in-Visual-Studio.md)   
 [ADO.NET](../Topic/ADO.NET.md)