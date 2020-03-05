---
title: "Commit in-process edits on data-bound controls before saving data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "committing edited records"
  - "data-bound controls, in-process edits"
  - "DataBinding class, committing edited records"
  - "hierarchical update, committing edited records"
  - "BindingSource class, committing edited records"
  - "EndEdit method"
ms.assetid: 61af4798-eef7-468c-b229-5e1497febb2f
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Commit in-process edits on data-bound controls before saving data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When editing values in data-bound controls, users must navigate off the current record to commit the updated value to the underlying data source that the control is bound to. When you drag items from the [Data Sources Window](https://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992) onto a form, the first item that you drop generates code into the **Save** button click event of the <xref:System.Windows.Forms.BindingNavigator>. This code calls the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method of the <xref:System.Windows.Forms.BindingSource>. Therefore, the call to the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method is generated only for the first <xref:System.Windows.Forms.BindingSource> that is added to the form.

 The <xref:System.Windows.Forms.BindingSource.EndEdit%2A> call commits any changes that are in process, in any data-bound controls that are currently being edited. Therefore, if a data-bound control still has focus and you click the **Save** button, all pending edits in that control are committed before the actual save (the `TableAdapterManager.UpdateAll` method).

 You can configure your application to automatically commit changes, even if a user tries to save data without committing the changes, as part of the save process.

> [!NOTE]
> The designer adds the `BindingSource.EndEdit` code only for the first item dropped onto a form. Therefore, you have to add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource> on the form. You can manually add a line of code to call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource>. Alternatively, you can add the `EndEditOnAllBindingSources` method to the form and call it before you perform a save.

 The following code uses a [LINQ (Language-Integrated Query)](https://msdn.microsoft.com/library/a73c4aec-5d15-4e98-b962-1274021ea93d) query to iterate all <xref:System.Windows.Forms.BindingSource> components and call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method for each <xref:System.Windows.Forms.BindingSource> on a form.

## To call EndEdit for all BindingSource components on a form

1. Add the following code to the form that contains the <xref:System.Windows.Forms.BindingSource> components.

     [!code-csharp[VSProDataOrcasEndEditOnAll#1](../snippets/csharp/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll/CS/Form1.cs#1)]
     [!code-vb[VSProDataOrcasEndEditOnAll#1](../snippets/visualbasic/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll/VB/Form1.vb#1)]

2. Add the following line of code immediately before any calls to save the form's data (the `TableAdapterManager.UpdateAll()` method):

     [!code-csharp[VSProDataOrcasEndEditOnAll#2](../snippets/csharp/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll/CS/Form1.cs#2)]
     [!code-vb[VSProDataOrcasEndEditOnAll#2](../snippets/visualbasic/VS_Snippets_VBCSharp/VSProDataOrcasEndEditOnAll/VB/Form1.vb#2)]

## See Also
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
 [Hierarchical update](../data-tools/hierarchical-update.md)
