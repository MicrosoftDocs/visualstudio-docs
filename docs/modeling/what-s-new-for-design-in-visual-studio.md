---
title: "What&#39;s new for design in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "what's new [VIsual Studio ALM], architecture and modeling"
  - "architecture [Visual Studio Ultimate], modeling"
  - "modeling software [Visual Studio ALM], What's New"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# What&#39;s new for design in Visual Studio

## Live dependency validation

Removing unwanted dependencies is an important part of managing your technical debt.
Live validation of dependencies is now included, providing precise information about
issues, and benefitting fully from the new features in the Error list and the editor.

![Live dependency validation in action](media/dep-validation-whatsnew-01.png)

The authoring experience has changed to make dependency validation more discoverable
and more accessible, changing the terminology from "Layer diagram" to 
"Dependency diagram".

The **Architecture** menu now contains a command to directly create a Dependency diagram:

![Live dependency item on Architecture menu](media/dep-validation-whatsnew-02.png)

... and the property names of a Layer in a Dependency diagram, and their descriptions,
have been changed to make them more meaningful:

![Live dependency updated property names](media/dep-validation-whatsnew-03.png)

You now see the impact of your changes immediately in the analysis results for the 
current code in the solution each time you save the diagram. You don't have to wait
any longer for the completion of the "Validate Dependencies" command.

For more details, see [this blog post](https://blogs.msdn.microsoft.com/visualstudioalm/2016/10/07/live-architecture-dependency-validation-in-visual-studio-15-preview-5/). 
 
## UML designers have been removed

The UML designers have been removed from this version of Visual Studio Enterprise.

* UML diagrams are now presented as XML files
* The UML Model Explorer no longer exists
* Modeling project references are no longer used for dependency validation
* The "Layer References" node in Solution Explorer is no longer displayed
* The "Validate" build action on a Dependency (Layer) diagram is no longer used - the Build task has been removed 
* The project structure is maintained for round-tripping between versions
* You can still open, create, edit, and save a Dependency (Layer) diagram as XML
* TFS work items linked to a Dependency (Layer) diagram are not accessible on the design surface
* Back linking from to DSL or a Layer is no longer supported 
* UML extensibility in the Modeling SDK is no longer supported

However, support for visualizing the architecture of .NET and C++ code is available
through [code maps](map-dependencies-across-your-solutions.md), and the significant improvements to dependency validation
described above.

If you are a significant user of the UML designers, you can continue to use Visual Studio 2015
or earlier versions while you decide on an alternative tool for your UML needs.

For more details, see [this blog post](https://blogs.msdn.microsoft.com/visualstudioalm/2016/10/14/uml-designers-have-been-removed-layer-designer-now-supports-live-architectural-analysis/). 

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

<a name="VersionSupport"></a>
##  Version support for architecture and modeling tools  

Visual Studio is available in several versions. Not all of these provide support for the architecture and modelling tools. The following table shows the availability of each tool.  
  
|**Feature**|**Enterprise**|**Professional**|**Community**|**Express**|  
|-----------------|--------------------|----------------------|-------------------|-----------------|  
|**Code maps**|Yes|See Note (1)|-|-|  
|**Dependency diagrams**|Yes|See Note (2)|See Note (2)|-|  
|**Directed graphs** (DGML diagrams)|Yes|Yes|Yes|-|  
|**Code clone**|Yes|-|-|-|  
  
Note (1): Only supports reading code maps, filtering code maps, adding new generic nodes, and creating a new Directed Graph from a selection.

Note (2): Only supports reading dependency diagrams.
