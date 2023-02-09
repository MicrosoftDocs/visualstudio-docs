---
title: Troubleshoot Resource Editor errors
description: Learn more about errors that can occur when you use the Resource Editor and how to resolve them.
ms.date: 01/31/2023
ms.topic: troubleshooting
f1_keywords:
- msvse_settingsdesigner.err.formatvalue
- msvse_resedit.err.nameblank
- msvse_resedit.err.duplicatename
helpviewer_keywords:
- Resource Designer
- Resource Editor
- resources [Visual Studio]
- Resources page in Project Designer
- application resources [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Troubleshoot errors in the Resource Editor

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When you're working with resource files for your application by using the Resource Editor in Visual Studio, you might run in to errors. Here are some of the typical error messages that can appear, along with instructions on how to resolve the errors.

## Error message: There is already another resource with the name 'Name'

This error occurs when you have a duplicate name for a resource in your resource list. Here's how to fix it.

1. In **Solution Explorer**, right-click the project node, and then select **Properties**.

1. In the **Search properties** dialog, select **Resources**.

1. Delete the duplicate resource item or rename it.

## Error message: The resource name cannot be empty

This error occurs when you have a value for a resource that's yet unnamed. Here's how to fix it.

1. In **Solution Explorer**, right-click the project node, and then select **Properties**.

1. In the **Search properties** dialog, select **Resources**.

1. Make sure to provide a name for each resource item.

## Support options

Here are more support resources that you might find useful:

- Ask a question or find an answer on the [Microsoft Q&A](/answers/tags/176/vs) page for Visual Studio.
- Report product issues to the engineering team via the [Report a problem](how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
- Track product issues and engineering team responses in the [Visual Studio Developer Community](https://aka.ms/feedback/suggest?space=8).

## See also

- [Manage application resources (.NET)](managing-application-resources-dotnet.md)
- [Managing app resources (Visual Studio for Mac)](/visualstudio/mac/managing-app-resources)
