---
title: Manage application resources
description: Manage application resources files that aren't part of the compilation process in Visual Studio, such as icon files or audio files.
ms.custom: engagement-fy23
ms.date: 8/26/2024
ms.topic: article
f1_keywords:
- msvse_resedit.dlg.SetCustomTool
helpviewer_keywords:
- Resource Designer
- Resource Editor
- Resource View
- resources [Visual Studio]
- Resources page in Project Designer
- application resources [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Manage application resources

Resource files are files that are part of an application but are not compiled, for example icon files or audio files. Since these files are not part of the compilation process, you can change them without having to recompile your binaries. If you are planning to localize your application, you should use resource files for all the strings and other resources that need to be changed when you localize your application.

> [!CAUTION]
> Resources in `.resx` files may be serialized using `BinaryFormatter`, which is [not secure](/dotnet/standard/serialization/binaryformatter-security-guide). Include only those `.resx` files in your build process that you trust.

For more information about resources in .NET apps, see [Resources in .NET apps](/dotnet/framework/resources/index).

## Work with resources

In a managed code project, open the project properties window. You can open the properties window by either:

- Right-clicking the project node in **Solution Explorer** and selecting **Properties**
- Typing **project properties** in the **Ctrl**+**Q** search box
- Pressing **Alt**+**Enter** in **Solution Explorer**

Select the **Resources** tab. You can add a *.resx* file if your project does not contain one already, add and delete different kinds of resources, and modify existing resources.

:::moniker range=">=vs-2022"
## Resource Explorer improvements in Visual Studio 2022 and later

Starting with Visual Studio 2022 version 17.11, the resources explorer has been significantly improved. See [Introducing the Revamped Visual Studio Resource Explorer](https://devblogs.microsoft.com/visualstudio/introducing-the-revamped-visual-studio-resource-explorer/).

To use the new Resource Explorer, you need to have a .NET project that contains one or more resource files (`.resx`). To open the Resource Explorer, right-click on any resource file in the Solution Explorer and select **Open With** > **Resource Explorer**. Alternatively, you can use the keyboard shortcut **Ctrl**+**Alt**+**R**.

When you open the new Resource Explorer, on the left side, you see an overview of all the resources you’ve stored alongside the locales for each file. You can configure which locales are visible in the datagrid. This interface allows you to compare translations side-by-side and edit them in place.

:::image type="content" alt-text="Screenshot of the grid view of resources." source="media/vs-2022/resources-explorer/grid-view.png" lightbox="media/vs-2022/resources-explorer/grid-view.png":::

## Search for resource strings

At the top left of the grid, you can use the search box to do a text of search all your resource files. To search for a resource, type in the search box on the toolbar and press Enter. The data grid will show only the resources that match your query in their name, value, or comment. You can use wildcards (`*`) to perform partial matches, and quotation marks (`"`) to perform exact matches.

### Add comments to specific translations of a resource

Comments are a useful way to provide more information or context for a resource, such as the meaning, usage, or tone of a string. In the Resource Explorer, you can add comments to each translation of a resource and view them all at once in the data grid.

To add a comment to a resource, select the cell that corresponds to the translation you want to comment on, and click on the **Edit Comment** button on the toolbar, or press **Shift**+**Enter**. A comment box appears below the cell, where you can type in your comment. Press **Enter** to save the comment, or **Esc** to discard it.

You can edit or delete existing comments by clicking on the comment box or using the same keyboard shortcut. To view all the comments for a resource, look for the small triangle icon in the corner of each cell that has a comment. You can hover over the icon to see a tooltip with the comment text or click on it to open the comment box.

Comments are available to multiple users of the resource files. The translator, a developer, or a resource manager can leave notes, questions, explanations, or caveats alongside the translations. A small icon in the corner of each cell indicates the presence of a comment.

:::image type="content" alt-text="Screenshot of the comment UI in Resources Explorer." source="media/vs-2022/resources-explorer/comment-ui.png" lightbox="media/vs-2022/resources-explorer/comment-ui.png":::

### Filter resources

To filter resources, click on the filter icon on the toolbar and select the criteria you want to apply. You can filter resources by name, value, comment, type, or file.

| Filter | Description |
| - | - |
| Name | Show only the resources that have a certain name or prefix. |
| Value | Show only the resources that have a certain value or contain a certain string. |
| Comment | Show only the resources that have a comment or contain a certain string in their comment. |
| Type | Show only the resources that have a certain type, such as string, image, or icon. |
| File | Show only the resources that belong to a certain file or culture. |

You can combine multiple filters to narrow down your results and clear them by clicking on the Clear Filter button. 

### Validation and warnings

Placeholders are special tokens that are replaced by dynamic values at runtime, such as `{0}`, `{1}`, or `{name}`. If you use placeholders in your resources, you need to make sure they are consistent across all localizations, otherwise you might see errors or unexpected behavior in your app.

The new Resource Explorer automatically validates placeholders for each resource and shows a warning icon if there is a mismatch between the default culture and any other localization. For example, if the default value of a resource is "Hello, {name}!" and the Spanish value is "Hola, {nombre}!", you'll see a warning icon showing that the placeholder name is different. You can hover over the icon to see a tooltip with the details of the mismatch and click on it to fix it.

Missing translations are another common issue that can affect the user experience of your app. If you don't provide a translation for a resource in a certain culture, the app will fall back to the default culture, which might not be proper or desirable for some users. The Resource Explorer helps you avoid this problem by showing a warning icon if there is no value for a resource in a certain culture. For example, if> you have a resource with a default value of `File` and no value for the French culture, you'll see a warning icon showing that the translation is missing. You can hover over the icon to see a tooltip with the message **No value** and select it to add a value.

:::image type="content" alt-text="Screenshot of the Resources Explorer when a missing translation is detected." source="media/vs-2022/resources-explorer/missing-translation.png" lightbox="media/vs-2022/resources-explorer/missing-translation.png":::

### Customization options

The Resource Explorer in Visual Studio 2022 and later is compatible with screen readers and assistive technology, to make it more accessible for developers with visual impairments or disabilities. You can use keyboard shortcuts to navigate through the data grid, edit values and comments, and perform common actions. You can also use the narrator to read each cell's contents, as well as the tooltips and warnings.

To adjust the zoom level, use the zoom slider on the toolbar, or the keyboard shortcuts **Ctrl**+**=** and **Ctrl**+**-**, to zoom in or out. Use **Ctrl**+**0** to reset the zoom level to default.

The theme for the Resource Explorer is consistent with the rest of the Visual Studio environment. You can choose between light, dark, or blue themes, and the Resource Explorer will adapt accordingly. You can also change the font and colors of the data grid, by using the **Tools** > **Options** > **Environment** > **Fonts and Colors dialog**.

:::moniker-end

## Resources in other project types

Resources are managed differently in .NET projects than in other project types. For more information about resources in:

- Universal Windows Platform (UWP) apps, see [App resources and the Resource Management System](/windows/uwp/app-resources/)
- C++/CLI (managed) projects, see [Resources in Desktop Apps](/dotnet/framework/resources/index)
- C++ projects, see [Work with resource files](/cpp/windows/working-with-resource-files) and [How to: Create a resource](/cpp/windows/how-to-create-a-resource)
    - Use the **Resource View** window (**View** > **Other Windows** > **Resource View**) to display resource files included in your projects.

## Support options

If you run into a problem with managing application resources, see [Troubleshoot errors in the Resource Editor](/troubleshoot/developer/visualstudio/project-build/troubleshoot-resource-editor-errors).

## Related content

- [Resources in .NET apps (.NET Framework)](/dotnet/framework/resources/index)
- [Resource Editor](/cpp/windows/resource-editors)
- [Work with resource files (C++)](/cpp/windows/working-with-resource-files)
- [Resources in Universal Windows Platform apps](/windows/uwp/app-resources/)
