---
title: "Commit in-process edits on data-bound controls before saving data"
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
ms.assetid: 61af4798-eef7-468c-b229-5e1497febb2f
caps.latest.revision: 13
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
# Commit in-process edits on data-bound controls before saving data
When editing values in data-bound controls, users must navigate off the current record to commit the updated value to the underlying data source that the control is bound to. When you drag items from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto a form, the first item that you drop generates code into the **Save** button click event of the <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False>. This code calls the <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> method of the <xref:System.Windows.Forms.BindingSource?qualifyHint=False>. Therefore, the call to the <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> method is generated only for the first <xref:System.Windows.Forms.BindingSource?qualifyHint=False> that is added to the form.  
  
 The <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> call commits any changes that are in process, in any data-bound controls that are currently being edited. Therefore, if a data-bound control still has focus and you click the **Save** button, all pending edits in that control are committed before the actual save (the `TableAdapterManager.UpdateAll` method).  
  
 You can configure your application to automatically commit changes, even if a user tries to save data without committing the changes, as part of the save process.  
  
> [!NOTE]
>  The designer adds the `BindingSource.EndEdit` code only for the first item dropped onto a form. Therefore, you have to add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> method for each <xref:System.Windows.Forms.BindingSource?qualifyHint=False> on the form. You can manually add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> method for each <xref:System.Windows.Forms.BindingSource?qualifyHint=False>. Alternatively, you can add the `EndEditOnAllBindingSources` method to the form and call it before you perform a save.  
  
 The following code uses a [LINQ (Language-Integrated Query)](../Topic/LINQ%20\(Language-Integrated%20Query\).md) query to iterate all <xref:System.Windows.Forms.BindingSource?qualifyHint=False> components and call the <xref:System.Windows.Forms.BindingSource.EndEdit?qualifyHint=False> method for each <xref:System.Windows.Forms.BindingSource?qualifyHint=False> on a form.  
  
## To call EndEdit for all BindingSource components on a form  
  
1.  Add the following code to the form that contains the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> components.  
  
     [!CODE [VSProDataOrcasEndEditOnAll#1](../CodeSnippet/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll#1)]  
  
2.  Add the following line of code immediately before any calls to save the form's data (the `TableAdapterManager.UpdateAll()` method):  
  
     [!CODE [VSProDataOrcasEndEditOnAll#2](../CodeSnippet/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll#2)]  
  
## See Also  
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [Hierarchical update](../VS_raddata/Hierarchical-update.md)