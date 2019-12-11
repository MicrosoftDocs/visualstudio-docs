---
title: "Browse and Select a .NET Type Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "TypeBrowser.UI"
  - "ActivityTypeResolver.UI"
ms.assetid: 864b60b6-a070-4e5c-aa5b-a25341b57ea6
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: jillfra
---
# Browse and Select a .NET Type Dialog Box
In the **Properties** window, dialog boxes, or designers such as the variable designer, when you select **Browse for Types…** from a list of data types, is the **Browse and Select a .NET Type** dialog box (referred to in an abbreviated form as the “type browser”). In this dialog box, you can choose a type from a tree view of assemblies and projects.

 This dialog box is employed in a number of user scenarios, including the following:

- When setting the type of a variable or argument.

- When selecting a type for a generic activity.

- When adding a catch on the <xref:System.Activities.Statements.TryCatch> activity.

> [!NOTE]
> The type browser can display Visual Basic jagged array types, but not multidimensional array types. See [Jagged Arrays](https://go.microsoft.com/fwlink/?LinkId=195226) and [Multidimensional Arrays](https://go.microsoft.com/fwlink/?LinkId=195227) for details.

## Selecting a Value or Reference Type from the Type Browser

#### To select a value or reference type from the type browser

1. In the **Type Name** box, enter the name of the type that you want to use.

2. Do one of the following:

    - Once the name of the type that you want to use appears in the tree in the **Type Name** box, double-click the type to select it.

    - Type enough characters in the **Type Name** box to uniquely identify the type that you want to use and then press enter to select the type

#### To select a generic type from the type browser

1. In the **Type Name** box, type in the name of the type that you want to use.

2. Once the name of the type that you want to use appears in the tree in the **Type Name** box, click the type to select it to cause drop-down boxes appear.

     Select the type that you want to use to close the generic from the drop-down boxes, and then click **OK**.

## Types displayed in the type browser
 The types displayed in the type browser can vary depending on how the type browser was launched. If the type browser was launched from a workflow project inside of **vs2010**, by default all of the types in the referenced assemblies and referenced projects are shown. If the type browser was launched from outside of a **vs2010** project system (such as in a rehosted workflow application or in a standalone workflow file), then by default the types from all of the assemblies loaded in the AppDomain are shown.

 Types in the type browser can be filtered by activity designer developers. For any given activity, you may see just a subset of the types. For example, in the <xref:System.Activities.Statements.TryCatch> activity, only types derived from <xref:System.Exception> are shown in the type browser.

## Filtering Search Results in the Type Browser
 The list of types in the **Type Name** box gets shorter as you type more characters to find a match. Only types whose fully-qualified name begins with the string you have typed or types whose short name begins with the string that you have typed appear in the filtered list.

 For example:

1. Typing **Operation** matches <xref:System.OperationCanceledException> but not <xref:System.InvalidOperationException>. To match <xref:System.InvalidOperationException>, start typing System.I or Invalid.

2. Typing **Generic** matches <xref:System.GenericUriParser> but not types in the <xref:System.Collections.Generic> namespace. To search for types in the <xref:System.Collections.Generic> namespace, type the fully-qualified name of the namespace.

## Selecting a service contract using the type browser dialog
 When selecting a service contract type, the type browser only shows types that have the <xref:System.ServiceModel.ServiceContractAttribute> attribute.

## See Also
 [Using the Activity Designers](../workflow-designer/using-the-activity-designers.md)