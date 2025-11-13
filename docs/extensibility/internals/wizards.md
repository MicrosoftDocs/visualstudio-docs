---
title: Wizards
description: Learn how to list your wizard among the available wizards and templates in Visual Studio and about the requirements that your wizard must meet in the IDE.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- projects [Visual Studio SDK], providing wizard support
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Wizards

After you create a wizard, you typically want to add it to the Visual Studio integrated development environment (IDE) so that others can use it. The added wizard then appears in the **Add New Project** or **Add New Item** dialog boxes. To see the **Add New Project** or **Add New Item** dialog boxes, right-click an open solution in **Solution Explorer**, point to **Add**, and then click **New Project** or **New Item**.

 Wizards can be implemented in Visual Studio to let users select from a tree view of available values when they open the **Add New Project** dialog box or the **Add New Item** dialog box, or when they right-click an item in **Solution Explorer**.

 In your wizard, you can provide the option of localizing the name of a new project or item, and you can determine the icon that users will see when they select the wizard. You can also control the order in which new items appear relative to other available items; items do not have to be organized alphabetically.

 You can also supply a wizard that starts differently, based on custom parameters that are passed to the wizard when it is opened.

 The topics in this section discuss the files that you implement to cause the Visual Studio **Add New Project** and **Add New Item** dialog boxes to list your wizard among the available wizards and templates, and the requirements that your wizard must meet to operate correctly in the IDE.

## In This Section
- [Template Directory Description (.Vsdir) Files](../../extensibility/internals/template-directory-description-dot-vsdir-files.md)

 Provides an overview of what template directory description files and explains how they function in the IDE to display folders, wizard .vsz files, and template files that are associated with a project in the dialog boxes.

- [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)

 Explains how the IDE starts wizards and lists the three parts of the .vsz file.

- [Wizard Interface (IDTWizard)](../../extensibility/internals/wizard-interface-idtwizard.md)

 Describes the `IDTWizard` interface that wizards must implement to work in the IDE.

- [Context Parameters](../../extensibility/internals/context-parameters.md)

 Explains how wizards are implemented and what occurs when the IDE passes Context Parameters to the implementation.

- [Custom Parameters](../../extensibility/internals/custom-parameters.md)

 Explains how to use Custom Parameters to control the operation of the wizard after the wizard is started.

## Related Sections
- [Project Types](../../extensibility/internals/project-types.md)

 Provides links to additional topics that offer information about how to design new project types.

- [Extending Projects](../../extensibility/extending-projects.md)

 Describes how to use Visual Studio projects and solutions to organize code files and resource files, and how to implement source control.
