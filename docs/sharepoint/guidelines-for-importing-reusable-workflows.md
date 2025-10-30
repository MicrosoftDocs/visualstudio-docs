---
title: "Guidelines for Importing Reusable Workflows"
description: Review guidelines for importing reusable workflows that were created in SharePoint Designer into Visual Studio.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, importing items"
  - "SharePoint development in Visual Studio, reusable workflows"
  - "importing items [SharePoint development in Visual Studio]"
  - "reusable workflows [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Guidelines for importing reusable workflows

  To import reusable workflows created in SharePoint Designer, use the Import Reusable SharePoint 2010 Workflow project template in Visual Studio. This template imports a *declarative* *workflow* (XML-only) and converts it into a *code workflow*, which is a workflow that you can enhance with either Visual Basic or Visual C# code. For more information, see [Walkthrough: Import a SharePoint Designer reusable workflow into Visual Studio](../sharepoint/walkthrough-import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md).

 However, the Import Reusable SharePoint 2010 Workflow template can import only farm solutions. If you want to deploy your workflow as a sandboxed solution, import it with the Import SharePoint 2010 Solution Package template. However, by doing this, you cannot convert it to code workflow and will not be able to modify it as such.

## Import reusable workflows by using the Import Reusable Workflow template
 If you import a reusable workflow by using the Import Reusable SharePoint 2010 Workflow template, you can run or change the solution just like any other Visual Studio SharePoint solution, but you may have to manually fix some items.

### Import task forms
 The Import Reusable SharePoint 2010 Workflow project template imports all initiation and association forms, but imports only one task form because the code workflow schema only permits one task form. Any additional task forms from the original workflow solution are put into the **Other Imported Files** folder in **Solution Explorer**.

## Import reusable workflows by using the Import SharePoint 2010 Solution Package template
 If you import a reusable workflow by using the Import SharePoint 2010 Solution Package template, you need to consider the following issues:

- After importing the workflow, you can immediately deploy and run it in Visual Studio by choosing the **F5** key. However, if you change anything in the workflow in the imported solution, you may have to manually fix elements in the project before you can deploy and run the workflow.

- Because the workflow is declarative, code cannot be added to it. To convert the workflow into a code workflow, you must import it into Visual Studio by using the Import Reusable SharePoint 2010 Workflow template.

- While you can edit the workflow designer (.xoml) file in Design view, it is recommended that you edit it in Source view, because the workflow designer displays false errors.

- Debugging in the workflow does not work for declarative content. Breakpoints set in the Workflow Designer are not hit.

## Import globally reusable workflow solutions
 Globally reusable workflows cannot be imported by using the Import Reusable SharePoint 2010 Workflow template. To import a globally reusable workflow, you have to convert it into a non-globally reusable workflow or you have to use the Import SharePoint 2010 Solution Package template.

 To convert the workflow, make a copy of the globally reusable workflow in SharePoint Designer (by opening the shortcut menu for the workflow and then choosing **Save as Copy**). Then import the new reusable workflow with the Import Reusable SharePoint 2010 Workflow template in Visual Studio.

 To import the globally reusable workflow without modifying it, use the Import SharePoint 2010 Solution Package template. If you use this method, the workflow is not converted to a code workflow and remains a declarative workflow.

## Related content
- [Import items from an existing SharePoint site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)
- [Walkthrough: Import a SharePoint Designer reusable workflow into Visual Studio](../sharepoint/walkthrough-import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md)
