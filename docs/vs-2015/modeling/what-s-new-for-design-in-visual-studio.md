---
title: "What&#39;s new for design"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "what's new [VIsual Studio], architecture and modeling"
  - "architecture [Visual Studio Ultimate], modeling"
  - "modeling software [Visual Studio], What's New"
ms.assetid: 36ab5c17-6dc0-4075-a28e-a0fa49b11260
caps.latest.revision: 34
author: jillre
ms.author: jillfra
manager: jillfra
---
# What's new for design in Visual Studio in Visual Studio 2015
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]
This release of Visual Studio includes the following improvements to help you better understand and design code.

 **Code maps and dependency graphs**

 In Visual Studio Enterprise, when you want to understand specific dependencies in your code, visualize them by creating code maps. You can then navigate these relationships by using the map, which appears next to your code. Code maps can also help you keep track of your place in the code while you work or debug code, so you'll read less code while you learn more about your code’s design.

 In the final (RTM) release, we made the shortcut menus for code elements and links much easier to use by grouping commands into sections related to selecting, editing, managing groups, and changing the layout of group contents. Notice also that test projects are displayed in a different style from other projects, and that we updated the icons for elements on the map to more appropriate versions.

 ![Show selected items on a new code map](../ide/media/codemapsshowonnewmap.png "CodeMapsShowOnNewMap")

 Other improvements include:

- **Improved top-down diagrams**. For medium to large Visual Studio solutions, you can now use a simplified Architecture menu to get a more useful code maps for your solution. The assemblies of your solution are grouped by the solution folders, so you can see them in context and leverage the effort you've put in structuring the solution. You'll immediately see project and assembly references, and then the link types appear. In addition, the assemblies external to your solution are grouped in a more compact way.

- **Test Projects are styled differently and can be filtered**. You can now more easily and quickly identify test projects on map because they are styled differently. They can also be filtered out so that you can focus on the application’s working code.

- **Simplified external dependency links**. Dependency links no longer represent the inheritance from System.Object, System.ValueType, System.Enum, and System.Delegate, which makes it easier to see external dependencies in your code map.

- **'Drill-in into dependency links' takes filters into account**. You get a useful, clear diagram when expanding it to understand the contributions to a dependency link. The diagram is less cluttered, and it takes into account the link filtering options you’ve selected.

- **Code elements are added to a code map with their context**. Because diagrams now appear with their context (up to the assembly and solution folder that you can filter out if required), you get more useful diagrams when dragging and dropping code elements from Solution Explorer, Class View, Object Browser; or when selecting elements in Solution Explorer and choosing Show on Code Map.

- **Get reactive code maps more quickly**. Drag and drop operations produce an immediate result, and the links between nodes are created much more quickly, without affecting subsequent user-initiated operations such as expanding a node or requesting more nodes. When you create code maps without building the solution, all the corner cases—such as when assemblies are not built—are now processed.

- **Skip rebuilding your solution.** Provides better performance when creating and editing diagrams.

- **Filter code element nodes and groups**. You can quickly unclutter your maps by showing or hiding code elements based on their category, as well as by grouping code elements by solution folders, assemblies, namespaces, project folders, and types.

- **Filter relationships to make diagrams easier to read**. Link filtering now also applies to cross group links, which makes working with the filter window less intrusive than it was in previous releases.

- **Create diagrams from the Class View and Object Browser**. Drag and drop files and assemblies into a new or an existing map from the Class View and Object Browser windows.

  See [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md).

  **Other design and modeling changes in this release:**

- **Layer diagrams**. Update these diagrams using Class View and Object Browser. To meet software design requirements, use layer diagrams to describe the desired dependencies for your software. Keep code consistent with this design by finding code that doesn’t meet these constraints, and by validating future code with this baseline.

- **UML diagrams**. You can no longer create UML class diagrams and sequence diagrams from code. But you still create these diagrams using new UML elements.

- **Architecture Explorer**. You can no longer use Architecture Explorer to create diagrams. But you can still use Solution Explorer.

## <a name="VersionSupport"></a> Edition support for architecture and modeling tools

Visual Studio 2015 is available in several editions. Not all of these provide support for the architecture and modeling tools. The following table shows the availability of each tool.

|**Feature**|**Enterprise**|**Professional**|**Community**|**Express**|
|-----------------|--------------------|----------------------|-------------------|-----------------|
|**Code maps**|Yes|Only supports reading and filtering code maps, adding new generic nodes, and creating a new Directed Graph from a selection.|-|-|
|**UML Class diagrams**|Yes|-|-|-|
|**UML Sequence diagrams**|Yes|-|-|-|
|**UML Use Case diagrams**|Yes|-|-|-|
|**UML Activity diagrams**|Yes|-|-|-|
|**UML Component diagrams**|Yes|-|-|-|
|**Layer diagrams**|Yes|-|-|-|
|**Directed Graphs** (DGML diagrams)|Yes|Yes|-|-|
|**Code clone**|Yes|-|-|-|