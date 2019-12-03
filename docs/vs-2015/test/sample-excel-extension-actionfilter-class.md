---
title: "Sample Excel Extension: ActionFilter Class | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: c69fe3c7-f797-4e90-b21c-f2cc4dddf152
caps.latest.revision: 13
ms.author: jillfra
manager: jillfra
---
# Sample Excel Extension: ActionFilter Class
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This internal class extends the [UITestActionFilter](/previous-versions/visualstudio/visual-studio-2012/dd985757(v=vs.110)) class and represents a filter for test actions on a [!INCLUDE[ofprexcel](../includes/ofprexcel-md.md)] element.

## Simple Properties
 These read-only properties enable the developer to specify how this test action filter is to be executed by the coded UI testing framework. For example, the `UITestActionFilter.Name` property provides the name of the action filter. Other properties get the `UITestActionFilter.Category` of the action filter, the `UITestActionFilter.FilterType`, the `UITestActionFilter.Group` name for the test actions that are filtered by this test action filter. Others indicate whether to `UITestActionFilter.ApplyTimeout` and also whether the test action is `UITestActionFilter.Enabled`.

## ProcessRule Method
 This method is called by the coded UI testing framework, and executes the filter against the provided `IUITestActionStack`. This particular override removes a mouse choose action on a cell when the next action in the stack sends keystrokes to the cell. It then returns `false`.

## Private Methods
 The `IsLeftClick` method determines whether the provided action represents a left-click of the mouse. The `AreActionsOnSameExcelCell` method determines whether two provided actions are executed on the same cell in Excel.

## See also

- [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)
