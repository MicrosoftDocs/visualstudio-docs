---
title: 'Workflow Designer - Use the Imports Designer'
description: Learn how the imports designer enables you to enter namespaces for the types that you will use in your expressions.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- System.Activities.Presentation.View.ImportDesigner.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use the Imports Designer

The imports designer enables you to enter namespaces for the types that you will use in your expressions. Much like the **Imports** or **using** keywords in Visual Basic and C#, specifying namespaces in the imports designer enable you to simply enter a type name in your expression rather than a fully qualified version type name.

The imports designer reacts to both changes in the UI and changes made when the workflow is saved. When the workflow is saved, namespaces can be added automatically to the imports designer. These include the following:

- Namespaces for any types used in variable and argument declarations.

- Namespaces for any types used in expressions.

- Any other namespaces required for serializing the workflow (for example, namespaces used by custom activities dropped in the workflow).

  When the workflow is saved, you might notice that some namespaces you have manually deleted are automatically re-added to the imports designer because of the logic described in the preceding list.

## To add a namespace to the list of imported namespaces

1. Open a WCF Workflow service application, workflow console application, or activity library project in Visual Studio or a rehosted workflow application.

2. Click **Imports** on the bottom of the main canvas. The Imports designer will appear.

3. Enter or select a namespace from the drop-down list control at the top of the Imports Designer.

     As you type, a list of valid namespaces that match the typed characters appears.

4. Press **Enter** to add the namespace to the list.

5. If you want to remove a namespace from the list, select the namespace and then press the **Delete** key on your keyboard. Note that a namespace can only be deleted if the namespace is invalid for any reason, for example if the assembly that contains the namespace is no longer referenced by the project.
