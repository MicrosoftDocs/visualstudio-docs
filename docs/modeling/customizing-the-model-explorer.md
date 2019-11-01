---
title: Customizing the Model Explorer
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.dsltools.dsldesigner.explorerbehavior"
helpviewer_keywords:
  - "Domain-Specific Language Tools, Domain-Specific Language Explorer"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Customizing the Model Explorer
You can change the appearance and behavior of the explorer for your domain-specific language designer as follows:

- Change the window title.

- Change the tab icon.

- Change the icons for nodes.

- Hide nodes.

## Changing the Window Title
 To change the window title of the generated explorer, select **Explorer Behavior** in the **DSL Explorer**, and then in the **Properties** window, set the **Title** property to the title you want.

## Changing the Tab Icon
 To change the tab icon for the explorer, use a 16x16-pixel icon in a .bmp file. Put the icon file in the \DslPackage\Resources\ folder, and then change the file name to **ModelExplorerToolWindowBitmaps.bmp**. For example, you could change the Visual Studio setup.ico icon file to .bmp format and rename it to **DSLLanguageName\DslPackage\Resources\ModelExplorerToolWindowBitmaps.bmp**. The generated designer will display this icon on the tab of your explorer when it is docked together with **Solution Explorer**.

## Setting Custom Icons on Explorer Nodes
 You can customize nodes in your explorer by using explorer node settings. The following procedure shows how to add an icon to a node.

#### To add an icon to an explorer node

1. Create a [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] solution by using the Task Flow solution template.

2. Put a .bmp file that contains a 16x16-pixel icon in the **Dsl\Resources** folder in the solution.

3. In the **DSL Explorer**, right-click **Explorer Behavior** and then click **Add New Explorer Node Settings**.

    An **ExplorerNodeSettings** node appears under the **Custom Node Settings** node.

4. Select **ExplorerNodeSettings**, and then in the **Properties** window, set **Class** to **Actor**.

5. Set **Icon To Display** to the path of the icon file.

6. Transform all templates, and then build and run the solution.

7. In the generated designer, open the Sample diagram.

    The Explorer should show three **Actor** nodes that have your icon.

> [!NOTE]
> If you have set a node icon for any element that is displayed in the generated explorer, all explorer nodes will display the icon. If no icon has been set, the nodes will display the default icon.

## Changing the Name Displayed on an Explorer Node
 You can change how the names of model elements are displayed in your explorer. The following procedure shows how to display the name of the **Task** that is referenced by a **Comment** in the comment node.

#### To display a property

1. Open the solution that you created in the earlier procedure.

2. Make sure that the **Comment** references only a single domain class by setting the multiplicity of the role with property name **Subjects** to 0..1. The property name should become **Subject**, and the relationship name should become **CommentReferencesSubject**.

3. In the **DSL Explorer**, right-click **Explorer Behavior** and then click **Add New Explorer Node Settings**.

     An **ExplorerNodeSettings** node appears under the **Custom Node Settings** node.

4. Select **ExplorerNodeSettings**, and then in the **Properties** window, set **Class** to **Comment**.

5. Right-click the **Comment** node, and then click **Add New Property Path**.

     A new node appears that is named **Property Displayed**.

6. Select **Property Displayed**, and then in the **Properties** window, click the value field of **Path To Property**. Select **Comment**, then **CommentReferencesSubject**, then **FlowElement**. The resulting path should resemble **CommentReferencesSubject.Subject/!Subject**.

7. In the value field of **Property**, select **Name**.

8. Transform all templates, and then build and run your solution.

9. In the generated designer, open the Sample diagram.

10. Draw a **Comment Connector** between the comment element and the **Task1** element on the diagram.

     The Explorer node should display the comment as **Task1**.

## Hiding Nodes
 You can hide a node in your explorer by adding its path to the **Hidden Nodes** node of the **DSL Explorer**. The following procedure shows how to hide **Comment** nodes.

#### To hide an explorer node

1. Open the solution that you created in the earlier procedure.

2. In the **DSL Explorer**, right-click **Explorer Behavior** and then click **Add New Domain Path**.

     A **Domain Path** node appears under **Hidden Nodes**.

3. Select **Domain Path**, and then in the **Properties** window, click the value field of **Path Definition**. Select **FlowGraph**, then **FlowGraphHasComments**. The resulting path should resemble **FlowGraphHasComments.Comments**

4. Transform all templates, and then build and run your solution.

5. In the generated designer, open the Sample diagram.

     The explorer should show only an **Actors** node, and should not show the **Comments** node.

## See also

- [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)