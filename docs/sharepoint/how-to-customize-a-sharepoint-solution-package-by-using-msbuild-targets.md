---
title: "Customize SharePoint solution package using MSBuild targets"
titleSuffix: ""
description: Customize how Visual Studio creates SharePoint solution package files (.wsp) by using MSBuild targets at a command prompt.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packages"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Customize a SharePoint Solution package by using MSBuild targets
  By using MSBuild targets at a command prompt, you can customize how Visual Studio creates SharePoint package files (*.wsp*). For example, you can customize the MSBuild properties to change the packaging intermediate directory and the MSBuild item groups that specify the enumerated files.

## Customize and run MSBuild targets
 If you customize the BeforeLayout and AfterLayout targets, you can perform tasks before package layout, such as adding, removing, or modifying files that will be packaged.

#### To customize the BeforeLayout target

1. Open an editor, such as Notepad, and then add the following code.

   ```xml
   <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
     <Target Name="BeforeLayout">
       <Message Importance="high" Text="In the BeforeLayout Target"></Message>
     </Target>
   </Project>
   ```

    This example displays a message before the packaging of this target.

2. Name the file **CustomLayout.SharePoint.targets**, and then save it in the folder for the SharePoint project.

3. Open the project, open its shortcut menu, and then choose **Unload Project**.

4. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Edit** *\<ProjectName>.vbproj* or **Edit** *\<ProjectName>.csproj*.

5. After the `Import` line near the end of the project file, add the following line.

   ```xml
   <Import Project="CustomLayout.SharePoint.targets" />
   ```

6. Save and close the project file.

7. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Reload Project**.

   When you publish the project, the message will appear in the output before packaging begins.

#### To customize the AfterLayout target

1. On the menu bar, choose **File** > **Open** > **File**.

2. In the **Open File** dialog box, navigate to the project folder, choose the CustomLayout.target file, and then choose the **Open** button.

3. Just before the `</Project>` tag, add the following code:

   ```xml
   <Target Name="AfterLayout">
     <Message Importance="high" Text="In the AfterLayout Target"></Message>
   </Target>
   ```

    This example displays a message after this target is packaged.

4. Save and close the targets file.

5. Restart Visual Studio, and then open the project.

   When you publish the project, the BeforeLayout message appears before packaging starts, and the AfterLayout message appears after packaging finishes.

## See also
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
