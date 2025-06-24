---
title: Browse and rearrange code maps
description: Learn how you can rearrange items on code maps to make them easier to read and improve their performance.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.progression.dgmlgraph.layouthelp
- vs.progression.graphdocument
- vs.progression.dgmlgraph.message.notUlt.noexpandgroup
- vs.progression.colorsetpicker
- vs.progression.iconsetpicker
helpviewer_keywords:
- Visual Studio Ultimate, dependency graphs
- code visualization [Visual Studio ALM]
- graph documents, browsing
- Visual Studio ALM, dependency graphs
- code visualization
- Visual Studio ALM, graph documents
- Visual Studio Ultimate, graph documents
- dependency graphs, browsing
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Browse and rearrange code maps

Rearrange items on code maps to make them easier to read and improve their performance.

You can customize code maps without affecting the underlying code in a solution. This is useful when you want to focus on key code elements or communicate ideas about the code. For example, to highlight interesting areas, you can select code elements on the map and filter them, change the style of code elements and links, hide or delete code elements, and organize code elements using properties, categories, or groups.

 **Requirements**

- To create code maps, you must have Visual Studio Enterprise.

- You can view code maps and make limited edits to code maps in Visual Studio Professional.

## <a name="ManageLargeGraphs"></a> Get started working with code maps

Create a code map (see [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md) for more details). If you don't want to wait for the map to finish generating, click the **Cancel** link at any time to stop the generation process. However, you will not see the details of all dependencies and links if you do this.

After you generate the map, get started with these tips for reviewing your code:

- Look at the natural dependency clusters in the code. On the map toolbar, choose **Layout**, **Quick Clusters**![Quick Clusters button on graph toolbar](../modeling/media/quickclustersicon.gif). See [Change the map layout](#Selecting).

     ![Dependency graph &#45; Quick Clusters layout](../modeling/media/dependencygraph_quickclusters.png)

- Organize the map into smaller areas by grouping related nodes. Collapse those groups to see only the intergroup dependencies, which appear automatically. See [Group nodes](#OrganizeGroups).

- Use filters to simplify the map and focus on the types of nodes or links you are interested in. See [Filter nodes and links](#FilterNodes).

- Maximize the performance of large maps. See [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md) for more information.For example, turn on **Skip Build** on the map toolbar so that Visual Studio doesn't rebuild your solution when you update items on the map.

## <a name="Selecting"></a> Change the map layout

|**To**|**Perform these steps**|
|-|-|
|Arrange the dependency flow for the entire map in a specific direction. This can help you see architectural layers in the code.|On the map toolbar, choose **Layout**, and then:<br /><br /> -   **Top to Bottom** ![Top to Bottom graph button](../modeling/media/topbottomgraphbutton.gif)<br />-   **Bottom to Top** ![Bottom to Top graph button](../modeling/media/bottomtopgraphbutton.gif)<br />-   **Left to Right** ![Left to Right layout button](../modeling/media/leftrightgraphbutton.gif)<br />-   **Right to Left** ![Right to Left graph button](../modeling/media/rightleftgraphbutton.gif)|
|See natural dependency clusters in the code with the most dependent nodes at the center of the clusters and the least dependent nodes at the outside of those clusters.|On the map toolbar, choose **Layout**, and then **Quick Clusters**![Quick Clusters button on graph toolbar](../modeling/media/quickclustersicon.gif).|
|Select one or more nodes on the map.|Click on a node to select it. To select or deselect more than one node, hold **CTRL** while clicking.<br /><br /> Keyboard: press **TAB** or use the arrow keys to move the dotted focus rectangle to a node and press **SPACE** to select it. Press **CTRL** + **SPACE** to multi-select or deselect nodes.|
|Move specific nodes around on the map.|Drag nodes to move them. To move other nodes and links out of the way as you drag nodes, press and hold the **SHIFT** key.<br /><br /> Keyboard: hold **CTRL** and press the arrow keys.|
|Change the layout inside a group independently of the other nodes and groups on the map.|Select a node and open the shortcut menu. Choose **Layout** and select a layout style.<br /><br /> - or -<br /><br /> Select a node and expand it to show the child nodes. Click the node title to show group pop-up toolbar, and open the **Change the layout style of the group**![Dependency graph &#45; group toolbar &#45; layout](../modeling/media/dependencygraph_grouptoolbar.gif) list. Select one of the tree layouts, **Quick Clusters**, or **List View** (which arranges the group's contents into a list).<br /><br /> See [Group nodes](#OrganizeGroups) for more details.|
|Undo an action in the map.|Press **CTRL** + **Z** or use the Visual Studio **Undo** command.|

## <a name="Explore"></a> Browse the map

|**To**|**Perform these steps**|
|-|-|
|Scan the map.|Drag the map in any direction using the mouse.<br /><br /> - or -<br /><br /> Hold **SHIFT** and rotate the mouse wheel to scroll horizontally. Hold **SHIFT** + **CTRL** and rotate the mouse wheel to scroll horizontally.|
|Zoom in or out of the map.|Rotate the mouse wheel.<br /><br /> - or -<br /><br /> Use the **Zoom** drop-down list on the code map toolbar.<br /><br /> - or -<br /><br /> Use the keyboard shortcuts. To zoom in, press **CTRL + SHIFT + .** (period). To zoom out, press **CTRL + SHIFT + ,** (comma).|
|Zoom in on a specific area using the mouse.|Hold the right mouse button while drawing a rectangle around that area you are interested in.|
|Resize and fit the map in its window.|Choose **Zoom to Fit** from the **Zoom** list on the code map toolbar.<br /><br /> - or -<br /><br /> Click the **Zoom to fit** icon ![Zoom icon on map toolbar](../modeling/media/almcodemapzoomicon.png) on the code map toolbar. Keyboard: press **CTRL + 0** (zero).|
|Find a node on the map by its name. **Tip:**  This works only for items on the map. To find items in your solution but not on the map, find them in **Solution Explorer**, and then drag them to the map. (Drag your selection, or on the **Solution Explorer** toolbar, click **Show on Code Map**).|1.  Choose the **Find** icon ![Find icon on map toolbar](../modeling/media/almcodemapfindicon.png) on the code map toolbar (Keyboard: press **CTRL + F**) to show the search box in the upper right corner of the map.<br />2.  Type the item name and press **Return** or click the "magnifier" icon. The first item that matches your search appears selected on the map.<br />3.  To customize your search, open the drop-down list and choose a search option. The options are **Find Next**, **Find Previous**, and **Select All**. Then click the corresponding button next to the search textbox.<br />     ![Search options drop&#45;down list](../modeling/media/almcodemapssearchdropdown.png)<br />     Alternatively, use the keyboard: press **F3** to select the next matching node or **SHIFT + F3** to select the previous matching node.<br />4.  Select any one of the options that specify how search terms are handled by clicking the icons below the search textbox.<br />     ![Search match options](../modeling/media/almcodemapssearchmatchicons.png)<br />     The options are, from left to right, case sensitive matching, match whole words only, use .NET regular expression syntax, automatically expand groups to show matches to enclosed items. **Important:**  You can use the search box to find matches in collapsed groups only if those groups were expanded previously. To find these matches and expand their parent groups automatically, choose this option under the search box.|
|Select all unselected nodes.|Open the shortcut menu for the selected nodes. Choose **Select**, **Invert Selection**.|
|Select additional nodes that link to the selected ones.|Open the shortcut menu for the selected nodes. Choose **Select** and one of these:<br /><br /> -   To select additional nodes that link directly to the selected node, choose **Incoming Dependencies**.<br />-   To select additional nodes that link directly from the selected node, choose **Outgoing Dependencies**.<br />-   To select additional nodes that link directly to and from the selected node, choose **Both**.<br />-   To select all nodes that link to and from the selected node, choose **Connected Subgraph**.<br />-   To select all children of the selected node, choose **Children**.|

## <a name="FilterNodes"></a> Filter nodes and links

|**To**|**Perform these steps**|
|-|-|
|Show or hide the Filters pane.|Choose the **Filters** button on the code map toolbar. The **Filters** pane is displayed as a tabbed page in **Solution Explorer**, by default.|
|Filter the types of nodes that are shown on the map.|Set or clear the checkboxes in the **Code Elements** list in the Filters pane.|
|Filter the types of links that are shown on the map.|Set or clear the checkboxes in the **Relationships** list in the Filters pane.|
|Show or hide Test project nodes on the map.|Set or clear the **Test Assets** checkbox in the **Miscellaneous** list in the Filters pane.|

The icons shown in the Legend panel of the map reflect the settings you make in the list. To show or hide the Legend panel, click the **Legend** button on the code map toolbar.

## <a name="Inspect"></a> Examine nodes and links

Code maps show these kinds of links:

- An individual link represents a single relationship between two nodes.

- A cross-group link represents a relationship between two nodes in different groups.

- An aggregate link represents all the relationships that point in the same direction between two groups.

> [!TIP]
> By default, the map shows cross-group links only for selected nodes. To change this behavior to show or hide aggregated links between groups, click **Layout** on the code map toolbar and choose **Advanced**, then **Show All Cross-Group Links** or **Hide All Cross-Group Links**. See [Hide or show nodes and links](#HidingShowing) for more details.

|**To**|**Perform these steps**|
|-|-|
|See more information about a node or a link.|Move the mouse pointer on top of the node or link until a tooltip appears.<br /><br /> The tooltip for an aggregated link lists the individual dependencies that it represents.<br /><br /> - or -<br /><br /> Open the shortcut menu for the node or the link. Choose **Edit**, **Properties**.|
|Show or hide the contents of a group.|-   To expand a group, open the shortcut menu for the node and choose **Group**, **Expand**.<br />     - or -<br />     Move the mouse pointer on top of the node until the chevron (down arrow) button appears. Click this button to expand the group. Keyboard: to expand or collapse the selected group, press the **PLUS** key (**+**) or the **MINUS** key (**-**).<br />-   To collapse a group, open the shortcut menu for the node and choose **Group**, **Collapse**.<br />     - or -<br />     Move the mouse pointer on top of a group until the chevron (up arrow) button appears. Click this button to collapse the group.<br />-   To expand all groups, press **CTRL** + **A** to select all the nodes. Open the shortcut menu for the map and choose **Group**, **Expand**. **Note:**      This command is not available if expanding all groups generates an unusable map or memory issues. It is recommended that you expand the map only to the level of detail that you care about.<br />-   To collapse all groups, open the shortcut menu for a node or for the map. Choose **Group**, **Collapse All**.|
|See the code definition for a namespace, type, or member.|Open the shortcut menu for the node and choose **Go To Definition**.<br /><br /> -or-<br /><br /> Double-click the node. For expanded groups, double-click the header on the group.<br /><br /> -or-<br /><br /> Select the node and press **F12**.<br /><br /> For example:<br /><br /> -   For a namespace containing one class, the code file for the class opens to show the definition of that class. In other cases, the **Find Symbol Results** window shows a list of code files. **Note:**      When you perform this task on a Visual Basic namespace, the code file behind the namespace does not open. This issue also occurs when you perform this task on a group of selected nodes that include a Visual Basic namespace. To work around this issue, browse manually to the code file behind the namespace, or omit the node for the namespace from your selection.<br />-   For a class or a partial class, the code file for that class opens to show the class definition.<br />-   For a method, the code file for the parent class opens to show the method definition.|
|Examine dependencies and items that participate in an aggregate link.|Select the links you're interested in and open the shortcut menu for your selection. Choose **Show Contributing Links**  or **Show Contributing Links on New Code Map**.<br /><br /> Visual Studio expands the groups at both ends of the link and shows only those items and dependencies that participate in the link. **Note:**  When you examine dependencies between items in partial groups, you might see this behavior: <ul><li>Links to items that don't participate in your examination disappear from the map, even though those links still exist.</li><li>Suppose you examine a link to an item in a partial group, and then later examine a different link to the same item. During your second examination, the target partial group shows only items from your first examination. Links and target items that didn't participate in your first examination but participate in your second examination don't appear.</li></ul> To see missing items from a group, choose **Refetch Children**![Refetch Children Icon](../modeling/media/dependencygraph_deletednodesicon.png) (which indicates that not all members of a group appear on the map). You can also try undoing your actions (Keyboard: press **CTRL+Z**) and examine the dependencies on a new map.|
|Examine dependencies across multiple nodes in different groups.|Expand the groups so you can see all their children. Select all the nodes that interest you, including their children. The map shows the cross-group links between the selected nodes.<br /><br /> To select all nodes in a group, press and hold **SHIFT** and the left mouse button while you draw a rectangle around that group. To select all nodes on a map, press **CTRL**+**A**. **Tip:**  To show cross-group links at all times, choose **Layout** on the map toolbar, **Advanced**, **Show All Cross-Group Links**.|
|See the items that a node or link references.|Open the shortcut menu for the node and choose **Find All References**. **Note:**  This applies only when the `Reference` attribute is set for the node or link in the map's .dgml file. To add references to items from nodes or links, see [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md).|

## <a name="HidingShowing"></a> Hide or show nodes and links

Hiding nodes keeps them from participating in layout algorithms. By default, cross-group links are hidden. Cross-group links are individual links that connect nodes across groups. When groups are collapsed, the map aggregates all cross-group links into single links between groups. When you expand a group and select nodes inside the group, cross-group links appear and show the dependencies in that group.

> [!CAUTION]
> Before you share a map that was created in Visual Studio Enterprise with those who use Visual Studio Professional, make sure to unhide any nodes or cross-group links that you want others to see. Otherwise, those users won't be able to unhide those items.

### To hide or show nodes

|**To**|**Perform these steps**|
|-|-|
|Hide selected nodes.|1.  Select nodes you want to hide.<br />2.  Open the shortcut menu for the selected nodes or for the map. Choose **Select**, **Hide Selected**.|
|Hide unselected nodes.|1.  Select nodes you want to remain visible.<br />2.  Open the shortcut menu for the selected nodes or for the map. Choose **Select**, **Hide Unselected**.|
|Show hidden nodes.|-   To show all hidden nodes inside a group, first make sure the group is expanded. Open the shortcut menu and choose **Select**, **Unhide Children**.<br />     - or -<br />     Click the **Unhide Children**![Unhide Children Icon](../modeling/media/dependencygraph_filtericon_hiddennodes.gif) icon in the upper left corner of the group (this is visible only when there are hidden child nodes).<br />-   To show all hidden nodes, open the shortcut menu for the map or a node and choose **Select**, **Unhide All**.|

### To hide or show links

|**To**|**On the map toolbar, choose Layout, Advanced, and then choose**|
|-|-|
|Show cross-group links at all times.|**Show All Cross-Group Links**. This hides aggregated links between groups.|
|Hide cross-group links at all times.|**Hide All Cross-Group Links**|
|Show only cross-group links for selected nodes.|**Show Cross-Group Links On Selected Nodes**|
|Hide all links.|**Hide All Links**. To show links again, choose one of the options listed above.|

## <a name="OrganizeGroups"></a> Group nodes

|**To**|**Perform these steps**|
|-|-|
|Show container nodes as group nodes or leaf nodes.|To show container nodes as leaf nodes: select the nodes, open the shortcut menu for your selection, and choose **Group**, **Convert To Leaf**.<br /><br /> To show container nodes as group nodes: select the nodes, open the shortcut menu for your selection, and choose **Group**, **Convert To Group**.|
|Change the layout inside a group.|Select the group, open the shortcut menu, choose **Layout**, and select the layout style you want.<br /><br /> - or -<br /><br /> 1.  Select the group and make sure it is expanded.<br />2.  Click the group header again and the group toolbar appears.<br />     ![Dependency graph &#45; group toolbar](../modeling/media/dependencygraph_group.png)<br />3.  Open the **Change the layout style of the group** list ![Dependency graph &#45; group toolbar &#45; layout](../modeling/media/dependencygraph_grouptoolbar.gif) and choose the layout style you want.<br /><br /> **List View** rearranges the group's members into list. **Graph Default** resets the group layout to the map default layout. For other options, see [Change the map layout](#Selecting).|
|Add a node to a group.|Drag the node onto the group.<br /><br /> While you drag the node, Visual Studio displays an indicator to show that you are moving the node.<br /><br /> You can also drag nodes out of a group.|
|Add a node to a non-group node.|Drag the node onto the target node. You can convert any target node into a group by adding nodes to it.|
|Group selected nodes.|1.  Select the nodes that you want to group. A pop-up toolbar appears above the last node you select.<br />     ![Dependency graph toolbar](../modeling/media/depedencygraph_toolbar.png)<br />2.  On the toolbar, choose the fourth icon **Group the selected nodes** (if the node is expanded it will have five instead of four icons). Type the name for the new group and press **Return**.<br />     - or -<br />     Select the nodes that you want to group and open the shortcut menu for your selection. Choose **Group**, **Add Parent Group**, type the name for the new group, and press **Return**.<br /><br /> You can rename a group. Open the shortcut menu for the group and choose **Edit**, **Properties** to open the Visual Studio Properties window. In the **Label** property, rename the group as required.|
|Remove groups.|Select the group or groups that you want to remove. Open the shortcut menu for your selection and choose **Group**, **Remove Group**.|
|Remove nodes from their parent group.|Select the nodes that you want to move. Open the shortcut menu for your selection and choose **Group**, **Remove From Parent**. This removes nodes up to their grandparent, or to outside the group if they have no grandparent group.<br /><br /> - or -<br /><br /> Select the nodes and drag them out of the group.|

## <a name="AddRemoveNodesLinks"></a> Add, remove, or rename nodes, links, and comments

You can display more or fewer items on a map in order to drill down or to simplify the map. You can also rename items, and add comments to items.

> [!CAUTION]
> Before you share a map that was created using Visual Studio Enterprise with those who use Visual Professional, make sure any code elements you want others to see are visible on the map. Otherwise, those users won't be able to retrieve deleted code elements.

### Add a node for a code element

|**To**|**Perform these steps**|
|-|-|
|Add a new generic node at the current mouse pointer location.|1.  Move the mouse pointer to the place on the map where you want to put the new code element and press **Insert**.<br />     - or -<br />     Open the shortcut menu for the map and choose **Edit**, **Add**, **Generic Node**.<br />2.  Type the name for the new node and press **Return**.|
|Add a specific type of code element node at the current mouse pointer location.|1.  Move the mouse pointer to the place on the map where you want to put the new code element and open the shortcut menu for the map.<br />2.  Choose **Edit**, **Add**, and select the type of node you want.<br />3.  Type the name for the new node and press **Return**.|
|Add a generic or a specific type of code element node to a group.|1.  Select the group node and open the shortcut menu.<br />2.  Choose **Edit**, **Add**, and select the type of node you want.<br />3.  Type the name for the new node and press **Return**.|
|Add a new node of the same type, and linked from, an existing node.|1.  Select the code element. A pop-up toolbar appears above it.<br />     ![Dependency graph toolbar](../modeling/media/depedencygraph_toolbar.png)<br />2.  On the toolbar, choose the second icon **Create a node with the same category as this node and add a new link to it**.<br />3.  Choose a place on the map to put the new code element and click the left mouse button.<br />4.  Type the name for the new node and press **Return**.|
|Add a new generic node that is linked from an existing code element that has focus.|1.  Using the keyboard, press **Tab** until the code element to link from has the focus (dotted rectangle).<br />2.  Press **Alt**+**Insert**.<br />3.  Type the name for the new node and press **Return**.|
|Add a new generic node that links to an existing code element that has focus.|1.  Using the keyboard, press **Tab** until the code element to link to has the focus (dotted rectangle).<br />2.  Press **Alt**+**Shift**+**Insert**.<br />3.  Type the name for the new node and press **Return**.|

|**To add code elements for**|**Perform these steps**|
|-|-|
|Code elements in the solution.|1.  Find the code element in **Solution Explorer**. Use the **Solution Explorer** search box or browse the solution. **Tip:**      To find code elements that have dependencies on a type or a member, open the shortcut menu for the type or the member in **Solution Explorer**. Choose the relationship that interests you. **Solution Explorer** shows only those code elements with the specified dependencies.<br />2.  Drag the code elements that interest you to the map surface. You can also drag code elements from Class View or Object Browser.<br />     - or -<br />     In **Solution Explorer**, select the code elements that you want to map. Then, on the **Solution Explorer** toolbar, click **Show on Code Map**.<br /><br /> By default, the parent container hierarchy for the new code elements is shown on the map. Use the **Include Parents** button on the code map toolbar to change this behavior. When turned off, only the code element itself is added to the map. To reverse this behavior for just one drag and drop action, press and hold the **CTRL** key while you drag the code elements to the map.<br /><br /> Visual Studio adds code elements for the top-level code elements in your selection. To see if a code element contains other code elements, move the mouse pointer on top of the code element so that the chevron (down arrow) appears. Choose the chevron to expand the code element. To expand all code elements, press **CTRL**+**A** to select all elements, open the shortcut menu for the map, and choose **Group**, **Expand**. This command is not available if expanding all groups would produce an unusable map or cause shortage of memory issues.|
|Code elements related to code elements on the map.|Click the **Show Related** button on the code map toolbar and choose the type of related items you are interested in.<br /><br /> - or -<br /><br /> Open the shortcut menu for the code element. Choose one of the **Show ...** items on the menu depending on the kind of relationship that interests you. For example, you can see items that the current item references, items that reference the current item, base and derived types for classes, method callers, and the containing classes, namespaces, and assemblies.<br /><br /> For more details, see [this topic](../modeling/map-dependencies-across-your-solutions.md).|
|Compiled .NET assemblies (.dll or .exe) or binaries.|Drag the assemblies or binaries from outside Visual Studio to a map.<br /><br /> You can drag from Windows Explorer or File Explorer only if you are running it and Visual Studio at the same User Access Control (UAC) permissions level. For example, if UAC is turned on and you are running Visual Studio as Administrator, Windows Explorer or File Explorer will block the dragging operation.|

### <a name="AddNodes"></a>

#### Add a link between existing code elements

1. Select the source code element. A toolbar appears above the code element.

    ![Dependency graph toolbar](../modeling/media/depedencygraph_toolbar.png)

2. On the toolbar, choose the first icon, **Create new link from this node to which ever node that you click on next**.

3. Select the target code element. A link appears between the two code elements.

**OR**

1. Select the source code element on the map.

2. If you have a mouse installed, move the mouse pointer outside the bounds of the map.

3. Open the code element's shortcut menu and choose **Edit** > **Add** > **Generic Link**.

4. Tab to and select the target code element for the link.

5. Press **Enter**.

### <a name="AddComments"></a>

#### Add a comment to an existing node on the map

1. Select the code element. A toolbar appears above it.

     ![Dependency graph toolbar](../modeling/media/depedencygraph_toolbar.png)

2. On the toolbar, choose the third icon, **Create a new comment node with a new link to the selected node**.

     \- or -

     Open the shortcut menu for the code element and choose **Edit** > **New Comment**.

3. Type your comments. To type on a new line, press **Shift** + **Enter**.

#### Add a comment to the map itself

1. Open the shortcut menu for the map and choose **Edit** > **New Comment**.

2. Type your comments. To type on a new line, press **Shift** + **Enter**.

### <a name="RenameNodes"></a>

#### Rename a code element or link

1. Select the code element or the link you want to rename.

2. Press **F2**, or open the shortcut menu and choose **Edit** > **Rename**.

3. When the edit box appears in the map, rename the code element or the link.

**OR**

1. Open the shortcut menu and choose **Edit** > **Properties**.

2. Edit the **Label** property in the Visual Studio Properties window.

#### Remove a code element or link from the map

1. Select the code element or link and press the **Delete** key.

     \- or -

     Open the shortcut menu for the code element or link and choose **Edit** > **Remove**.

2. If the element or link is part of a group, the **Refetch Children** button ![Refetch Children Icon](../modeling/media/dependencygraph_deletednodesicon.png) appears inside the group. Click this to retrieve missing elements and links.

- You can remove code elements and links from a map without affecting the underlying code. When you delete them, their definitions are removed from the DGML (.dgml) file.

- Maps created by editing the DGML, by adding undefined code elements, or by using some earlier versions of Visual Studio, do not support this capability.

#### Flag a code element for follow-up

1. Select the code element or link you want to flag for follow-up.

2. Open the shortcut menu and choose **Edit** > **Flag for Follow Up**.

- By default, the code element gains a red background. Consider [adding a comment](#AddComments) to it with the appropriate follow-up information.

- Change the background color of the element or clear the follow-up flag by choosing **Edit** > **Other Flag Colors**.

## <a name="ChangeStyleCodeOrLink"></a> Change the style of a code element or link

You can change the icons on code elements and the colors of code elements and links using predefined icons and colors. For example, you can choose a color to highlight code elements and links that have a certain category or property. This lets you identify and focus on specific areas of the map. You can specify custom icons and colors by editing the map's .dgml file; see [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md).

### To apply a predefined color or icon to code elements or links with a certain category or property

1. On the map toolbar, choose **Legend**.

2. In the **Legend** box, see if the code element category or property already appears in the list.

3. If the list does not include the category or property, choose **+** in the **Legend** box, then choose **Node Property**, **Node Category**, **Link Property**, or **Link Category**. Then choose the property or category. The category or property now appears in the **Legend** box.

    > [!NOTE]
    > To create and assign a category or a property to a code element, you can edit the map's .dgml file; see [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md).

4. In the **Legend** box, click the icon next to the category or property you added or you want to change.

5. Use the following table to select the style that you want to change:

    |**To change the**|**Choose**|
    |-|-|
    |Background color|**Background**|
    |Outline color|**Stroke**|
    |Text color (a letter "f" is displayed to show the result)|**Foreground**|
    |Icon|**Icons**|

     The **Color Set Picker** or **Icon Set Picker** dialog box appears for you to select a color or icon.

6. In the **Color Set Picker** or **Icon Set Picker** dialog box, do one of the following:

    |**To apply a**|**Perform these steps**|
    |-|-|
    |Set of colors or icons|Open the **Select color** (or **icon**) **set** list. Select a set of colors or icons.|
    |Specific color or icon|Open the category or property value list. Select a color or icon.|

    > [!NOTE]
    > You can rearrange, delete, or temporarily deactivate styles in the **Legend** box. See [Edit the Legend box](#ModifyLegend).

## <a name="ModifyLegend"></a> Edit the Legend box

You can rearrange, delete, or temporarily deactivate styles in the **Legend** box:

1. Open the shortcut menu for a style in the **Legend** box.

2. Perform one of the following tasks:

    |**To**|**Choose**|
    |-|-|
    |Deactivate the code element|**Disable**|
    |Delete the code element|**Delete**|
    |Move the style up|**Move Up**|
    |Move the code element down|**Move Down**|

## <a name="CopyLegend"></a> Copy styles from one map to another

1. Make sure the **Legend** box appears on the source map. If it is not visible, on the map toolbar, click **Legend**.

2. Open the shortcut menu for the **Legend** box. Choose **Copy Legend**.

3. Paste the legend onto the target map.

## <a name="MergeMaps"></a> Merge code maps

You can merge maps by copying and pasting code elements between maps. If the code element identifiers match, then pasting code elements functions like a merge operation. To make this task easier, put all the assemblies or binaries that you want to visualize in the same folder so that the full path of each assembly or binary is the same for each map that you want to merge.

Alternatively, you can drag those assemblies or binaries to the same map from that folder.

## Related content

- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)
- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)
- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)
- [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md)
- [Directed Graph Markup Language (DGML) reference](../modeling/directed-graph-markup-language-dgml-reference.md)
