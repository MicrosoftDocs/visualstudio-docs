---
title: Troubleshoot project template and item template loading
ms.date: 01/02/2018
ms.topic: troubleshooting
helpviewer_keywords:
  - "templates [Visual Studio], troubleshooting"
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Troubleshoot templates

If a template fails to load in the development environment, there are several ways to locate the problem.

## Validate the vstemplate file

::: moniker range="vs-2017"

If the *vstemplate* file in a template doesn't adhere to the Visual Studio template schema, the template may not appear in the **New Project** dialog box.

::: moniker-end

::: moniker range=">=vs-2019"

If the *vstemplate* file in a template doesn't adhere to the Visual Studio template schema, the template may not appear in the dialog box where you create new projects.

::: moniker-end

### To validate the vstemplate file

1. Locate the *.zip* file that contains the template.

1. Extract the *.zip* file.

1. On the **File** menu in Visual Studio, choose **Open** > **File**.

1. Select the *vstemplate* file for the template, and choose **Open**.

1. Verify that the XML of the *vstemplate* file adheres to the template schema. For more information on the *vstemplate* schema, see [Template schema reference](../extensibility/visual-studio-template-schema-reference.md).

    > [!NOTE]
    > To get IntelliSense support while authoring the *vstemplate* file, add a `xmlns` attribute to the `VSTemplate` element, and assign it a value of http://schemas.microsoft.com/developer/vstemplate/2005.

1. Save and close the *vstemplate* file.

1. Select the files included in your template, right-click, and choose **Send to** > **Compressed (zipped) folder**. The files that you selected are compressed into a *.zip* file.

1. Place the new *.zip* file in the same directory as the old *.zip* file.

1. Delete the extracted template files and the old template *.zip* file.

## Enable diagnostic logging

You can enable diagnostic logging for template discovery by following the steps in [Troubleshoot template discovery (extensibility)](../extensibility/troubleshooting-template-discovery.md).

## See also

- [Troubleshoot template discovery (extensibility)](../extensibility/troubleshooting-template-discovery.md)
- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Template schema reference](../extensibility/visual-studio-template-schema-reference.md)