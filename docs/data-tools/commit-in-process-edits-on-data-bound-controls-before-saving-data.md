---
title: "Commit in-process edits on data-bound controls before saving data | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "commiting edited records"
  - "data-bound controls, in-process edits"
  - "DataBinding class, commiting edited records"
  - "hierarchical update, commiting edited records"
  - "BindingSource class, commiting edited records"
  - "EndEdit method"
ms.assetid: 61af4798-eef7-468c-b229-5e1497febb2f
caps.latest.revision: 13
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
# Commit in-process edits on data-bound controls before saving data
When editing values in data-bound controls, users must navigate off the current record to commit the updated value to the underlying data source that the control is bound to. When you drag items from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto a form, the first item that you drop generates code into the **Save** button click event of the <xref:System.Windows.Forms.BindingNavigator>. This code calls the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method of the <xref:System.Windows.Forms.BindingSource>. Therefore, the call to the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method is generated only for the first <xref:System.Windows.Forms.BindingSource> that is added to the form.  
  
 The <xref:System.Windows.Forms.BindingSource.EndEdit%2A> call commits any changes that are in process, in any data-bound controls that are currently being edited. Therefore, if a data-bound control still has focus and you click the **Save** button, all pending edits in that control are committed before the actual save (the `TableAdapterManager.UpdateAll` method).  
  
 You can configure your application to automatically commit changes, even if a user tries to save data without committing the changes, as part of the save process.  
  
> [!NOTE]
>  The designer adds the `BindingSource.EndEdit` code only for the first item dropped onto a form. Therefore, you have to add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource> on the form. You can manually add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource>. Alternatively, you can add the `EndEditOnAllBindingSources` method to the form and call it before you perform a save.  
  
 The following code uses a [LINQ (Language-Integrated Query)](../Topic/LINQ%20\(Language-Integrated%20Query\).md) query to iterate all <xref:System.Windows.Forms.BindingSource> components and call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource> on a form.  
  
## To call EndEdit for all BindingSource components on a form  
  
1.  Add the following code to the form that contains the <xref:System.Windows.Forms.BindingSource> components.  
  
     [!code-cs[VSProDataOrcasEndEditOnAll#1](../data-tools/codesnippet/CSharp/commit-in-process-edits-on-data-bound-controls-before-saving-data_1.cs)]
     [!code-vb[VSProDataOrcasEndEditOnAll#1](../data-tools/codesnippet/VisualBasic/commit-in-process-edits-on-data-bound-controls-before-saving-data_1.vb)]  
  
2.  Add the following line of code immediately before any calls to save the form's data (the `TableAdapterManager.UpdateAll()` method):  
  
     [!code-cs[VSProDataOrcasEndEditOnAll#2](../data-tools/codesnippet/CSharp/commit-in-process-edits-on-data-bound-controls-before-saving-data_2.cs)]
     [!code-vb[VSProDataOrcasEndEditOnAll#2](../data-tools/codesnippet/VisualBasic/commit-in-process-edits-on-data-bound-controls-before-saving-data_2.vb)]  
  
## See Also  
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Hierarchical update](../data-tools/hierarchical-update.md)