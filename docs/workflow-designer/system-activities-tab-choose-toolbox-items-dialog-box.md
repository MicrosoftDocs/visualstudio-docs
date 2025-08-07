---
title: System.Activities, Choose Toolbox Items
description: In Workflow Designer, learn how the System.Activities tab displays a list of Windows Workflow Foundation (WF) activities, templates, and items available to you.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.CHOOSEITEMS.SYSTEM.ACTIVITIES_COMPONENTS
- VS.CHOOSEITEMS.SYSTEM.ACTIVITIES COMPONENTS
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# System.Activities tab, Choose Toolbox Items dialog box

This tab of the **Choose Toolbox Items** dialog box displays a list of Windows Workflow Foundation (WF) activities, templates, and items available to you. To display this list, select **Choose Toolbox Items** from the **Tools** menu or by right-clicking the **Toolbox** and selecting **Choose Items** to display the **Choose Toolbox Items** dialog box, and then select its **System.Activities** tab. Out of the box, the list contains workflow activities from System.Activities, System.ServiceModel.Activities, and System.Activities.Core.Presentation assemblies; however, only the system-provided activities shown and activities added through other assemblies displayed in the **Toolbox** are checked by default. Recently added activities are automatically checked and appear in the **Toolbox** when you click **OK** on the dialog box. Also, these items appear in the **Toolbox** under a new category that corresponds to the namespace where the activity/item/template resides.

> [!WARNING]
> If you try to add an assembly that does not contain any workflow activities, an error dialog is displayed that explains that the assembly does not contain any activities.

This dialog box is project agnostic and hence the **System.Activities** tab continues to show up in standalone XAML or a non-workflow project type.

Filtering is done on each tab, and it's not possible to add workflow activities through the **.NET Component** tab. Add them through the **System.Activities** tab itself.

You can uncheck any items you do not want to see in the **Toolbox** from this dialog tab, or alternatively, you can do so using the **Delete** right-click menu option in the **Toolbox** and de-referencing an assembly does not remove the item from the **Toolbox**.

Instantiating the activity, by dragging and dropping it on the designer adds the assembly that contains the item to the referenced assemblies list automatically. Also if the activity references an assembly C, it does not add C to the referenced assembly list. Assembly C has to be in the GAC or the same directory as the activity B. In the standalone case, the assembly has to be in GAC or the Probe paths of VS. Only then can you drag and drop the activity on the workflow designer surface.

**Toolbox** settings are saved by default as user options, so the next time, when you open the **Toolbox**, it displays your customized list of workflow activities. One side effect of this is that if you have added your specific domain items to the **Toolbox** through the **Choose Toolbox Items** dialog box, you still continue to see those items when you are working in a Workflow Console Application as well. If you do not want to see them, then delete them using the right-click menu or uncheck them through the **Choose Toolbox Items** dialog box as noted previously.

The columns in this dialog box contain the following information:

Name\
Lists the names of the workflow activities currently registered on your local machine.

Namespace\
Displays the hierarchy of the .NET namespace that defines the structure of the activity.

Assembly Name\
Displays the name and version of the .NET assembly that contains the activity.

Directory\
Displays the location of the .NET assembly that contains the workflow activities. The default location for all assemblies is the Global Assembly Cache.

To sort the components listed, select any column heading.
