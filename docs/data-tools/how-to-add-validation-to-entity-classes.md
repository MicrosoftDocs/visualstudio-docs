---
title: "How to: Add validation to entity classes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 61107da9-7fa3-4dba-b101-ae46536f52c4
caps.latest.revision: 3
author: "mikeblome"
ms.author: "mblome"
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
# How to: Add validation to entity classes
*Validating* entity classes is the process of confirming that the values entered into data objects comply with the constraints in an object's schema, and also to the rules established for the application. Validating data before you send updates to the underlying database is a good practice that reduces errors. It also reduces the potential number of round trips between an application and the database.  
  
 The [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md) provides partial methods that enable users to extend the designer-generated code that runs during Inserts, Updates, and Deletes of complete entities, and also during and after individual column changes.  
  
> [!NOTE]
>  This topic provides the basic steps for adding validation to entity classes by using the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]. Because it might be difficult to follow these generic steps without referring to a specific entity class, a walkthrough that uses actual data has been provided.  
  
## Adding Validation for Changes to the Value in a Specific Column  
 This procedure shows how to validate data when the value in a column changes. Because the validation is performed inside the class definition (instead of in the user interface) an exception is thrown if the value causes validation to fail. Implement error handling for the code in your application that attempts to change the column values.  
  
 [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
#### To validate data during a column's value change  
  
1.  Open or create a new LINQ to SQL Classes file (**.dbml** file) in the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]. (Double-click the **.dbml** file in **Solution Explorer**.)  
  
2.  In the O/R Designer, right-click the class for which you want to add validation and then click **View Code**.  
  
     The Code Editor opens with a partial class for the selected entity class.  
  
3.  Place the cursor in the partial class.  
  
4.  For Visual Basic projects:  
  
    1.  Expand the **Method Name** list.  
  
    2.  Locate the **On***COLUMNNAME***Changing** method for the column you want to add validation to.  
  
    3.  An `On`*COLUMNNAME*`Changing` method is added to the partial class.  
  
    4.  Add the following code to first verify that a value has been entered and then to ensure that the value entered for the column is acceptable for your application. The `value` argument contains the proposed value, so add logic to confirm that it is a valid value:  
  
        ```vb#  
        If value.HasValue Then  
            ' Add code to ensure that the value is acceptable.  
            ' If value < 1 Then  
            '    Throw New Exception("Invalid data!")  
            ' End If  
        End If  
        ```  
  
     For C# projects:  
  
    1.  Because C# projects do not automatically generate the event handlers, you can use IntelliSense to create the column-changing partial methods.  
  
         Type `partial` and then a space to access the list of available partial methods. Click the column-changing method for the column you want to add validation for. The following code resembles code that is generated when you select a column-changing partial method:  
  
        ```c#  
        partial void OnCOLUMNNAMEChanging(COLUMNDATATYPE value)  
            {  
               throw new System.NotImplementedException();  
            }  
  
        ```  
  
## Adding Validation for Updates to an Entity Class  
 In addition to checking values during changes, you can also validate data when an attempt is made to update a complete entity class. Validation during an attempted update enables you to compare values in multiple columns if business rules require this. The following procedure shows how to validate when an attempt is made to update a complete entity class.  
  
> [!NOTE]
>  Validation code for updates to complete entity classes is executed in the partial <xref:System.Data.Linq.DataContext> class (instead of in the partial class of a specific entity class).  
  
#### To validate data during an update to an entity class  
  
1.  Open or create a new LINQ to SQL Classes file (**.dbml** file) in the [!INCLUDE[vs_ordesigner_short](../data-tools/includes/vs_ordesigner_short_md.md)]. (Double-click the **.dbml** file in **Solution Explorer**.)  
  
2.  Right-click an empty area on the O/R Designer and click **View Code**.  
  
     The Code Editor opens with a partial class for the `DataContext`.  
  
3.  Place the cursor in the partial class for the `DataContext`.  
  
4.  For Visual Basic projects:  
  
    1.  Expand the **Method Name** list.  
  
    2.  Click **Update***ENTITYCLASSNAME*.  
  
    3.  An `Update`*ENTITYCLASSNAME* method is added to the partial class.  
  
    4.  Access individual column values by using the `instance` argument, as shown in the following code:  
  
        ```vb#  
        If (instance.COLUMNNAME = x) And (instance.COLUMNNAME = y) Then  
            Dim ErrorMessage As String = "Invalid data!"  
            Throw New Exception(ErrorMessage)  
        End If  
        ```  
  
     For C# projects:  
  
    1.  Because C# projects do not automatically generate the event handlers, you can use IntelliSense to create the partial `Update`*CLASSNAME* method.  
  
    2.  Type `partial` and then a space to access the list of available partial methods. Click the update method for the class you want to add validation for. The following code resembles code that is generated when you select an `Update`*CLASSNAME* partial method:  
  
        ```c#  
        partial void UpdateCLASSNAME(CLASSNAME instance)  
        {  
            if ((instance.COLUMNNAME == x) && (instance.COLUMNNAME = y))  
            {  
                string ErrorMessage = "Invalid data!";  
                throw new System.Exception(ErrorMessage);  
            }  
        }  
        ```  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Validating Data](../Topic/Validating%20Data.md)