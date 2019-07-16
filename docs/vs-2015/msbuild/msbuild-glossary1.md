---
title: "Glossary of MSBuild terms"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
ms.assetid: f767d8e4-24d8-4803-80eb-e857202dbe2c
caps.latest.revision: 25
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild glossary
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These terms are used to describe the Microsoft Build Engine (MSBuild) and its components.

## Glossary
 AssemblyFoldersEx

 A registry location where third party vendors store paths for each version of the framework that they support where design time resolution can look to find reference assemblies.

 batching

 Batching means dividing items into different categories known as *batches*, based on item metadata, and then running a target or task one time by using each batch. Batching is the MSBuild equivalent of the for--loop construct. For more information, see [Batching](../msbuild/msbuild-batching.md).

 build-scope

 Build-scope describes an MSBuild object, for example, a global property, that is potentially visible to a project and to any child projects that are created in a multi-project build.

 child project

 See *project, child*.

 condition

 Many MSBuild elements can be defined conditionally; that is, the `Condition` attribute appears in the element. The contents of conditional elements are ignored unless the condition evaluates to `true`. For more information, see [Conditions](../msbuild/msbuild-conditions.md).

 definition, item

 See *item definition*.

 emit item

 During the execution phase of a build, items can be created or modified by tasks that have child `Output` elements that have the `ItemName` attribute. The task is said to "emit" the new items.

 emit property

 During the execution phase of a build, properties can be created or modified by tasks that have child `Output` elements that have the `PropertyName` attribute. The task is said to "emit" the new property.

 evaluation phase

 Evaluation is the first phase of a project build. All properties and items are evaluated in the order in which they appear in the project. Imported projects are evaluated as they are encountered in the project. Targets and tasks are not run until the execution phase, and any properties or items they would declare or emit are ignored during evaluation.

 execution phase

 Execution is the second phase of a project build. Selected targets are built and tasks are run. Properties and items can be created or modified compared to their evaluation values.

 function, property

 See *property function*.

 function, item

 See item function.

 item

 Items are inputs into the build system, and are grouped into item types based on their element names. Items typically represent files. Because items are named by the item type they belong to, the terms *item* and *item value* can be used interchangeably. For more information, see [Items](../msbuild/msbuild-items.md).

 item definition

 Item definition groups contain item definitions that add default metadata to any item type. Like well-known metadata, the default metadata is associated with all items of the specified item type. Default metadata can be explicitly overridden in an item definition. For more information, see [Item Definitions](../msbuild/item-definitions.md).

 item function

 Item functions get information about the items in the project. These functions simplify getting Distinct() items and are faster than looping through the items. There are functions to manipulate item paths and strings. For more information, see [Item Functions](../msbuild/item-functions.md)

 item metadata

 See *metadata, item*.

 item type

 Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process. For more information, see [Items](../msbuild/msbuild-items.md).

 metadata, item

 Item metadata is a collection of name-value pairs that is associated with an item. Metadata provides descriptive information for the item and is optional, except for well-known metadata. For more information, see [Items](../msbuild/msbuild-items.md).

 metadata, well-known

 Well-known metadata is read-only item metadata that is initialized by using a predefined value. Well-known metadata provides descriptive information for an item that references a file. For example, the value of the well-known metadata named `FullPath` is the full path of the referenced file. For more information, see [Items](../msbuild/msbuild-items.md).

 multitargeting

 The ability for an application or assembly project to target many different CLR’s and frameworks from MSBuild and from Visual Studio.

 profile

 A subset of the full framework. This is used to minimize the amount that needs to be downloaded to a machine.

 project file

 A project file contains the MSBuild script that controls the build. Project files typically have a file extension that ends with "proj", such as .csproj or .vbproj. Project files may import property files and target files.

 property

 A property is a key-value pair that is used to control the build process. For more information, see [MSBuild Properties](msbuild-properties1.md).

 property, environment

 An environment property is a property that is automatically initialized to the value of a system environment variable that has the same name. For more information, see [MSBuild Properties](msbuild-properties1.md).

 property file

 A property file is a project file that contains mostly property groups and item groups that guide the build. By convention, It has the file extension .props. Property files are typically imported at the beginning of associated project files.

 property, function

 A property function is a system property or method that can be used to evaluate MSBuild scripts. Property methods can be used to read the system time, compare strings, match regular expressions, and perform other actions. For more information, see [Property Functions](../msbuild/property-functions.md).

 property function, nested

 Property functions may be combined to form more complex functions. For example,

 `$([MSBuild]::BitwiseAnd(32,   $([System.IO.File]::GetAttributes(tempFile))))`

 For more information, see [Property Functions](../msbuild/property-functions.md).

 property, global

 A global property is a key-value pair that is used to control the build process. Global properties are set at a command prompt, or by using the `Properties` attribute of an [MSBuild task](../msbuild/msbuild-task.md), and cannot be modified during the evaluation phase of a build. For more information, see [MSBuild Properties](msbuild-properties1.md).

 property, local

 A local property is a key-value pair that is used to control the build process. This term is only used to distinguish a property that is not a global property.

 property, registry

 A registry property has a value that is set by using a special syntax that reads the value of a system registry subkey. For more information, see [MSBuild Properties](msbuild-properties1.md).

 property, reserved

 A reserved property is a key-value pair that is used to control the build process. Reserved properties are automatically initialized to predefined values. For more information, see [MSBuild Properties](msbuild-properties1.md).

 project-scope

 Project-scope describes an MSBuild object, for example, a local property, that is visible only in the containing project file and to any projects that it imports.

 project, child

 A child project is created by the MSBuild task during a project build. This new project is a child of the project that contains or imports the target that contains the MSBuild task. The child project inherits the global properties of the parent project, unless they are modified by the `Properties` attribute.

 redist list

 Redistribution list: the list of assemblies that correspond to a given framework.

 reference assembly

 An assembly that is used during design time to create an application. A reference assembly can have the actual code and private interfaces removed from it, leaving only the metadata and public interfaces.

 registry property

 See *property, registry*.

 target

 A target groups tasks together in a particular order and exposes sections of the project file as entry points into the build process. For more information, see [Targets](../msbuild/msbuild-targets.md).

 target, building

 See target, running.

 target, evaluating

 Because of incremental compilation, targets must be analyzed for potential changes to properties and items. Even if the target is skipped, these changes must be made. Evaluating a target means performing this analysis and making these changes. For more information, see [Incremental Builds](../msbuild/incremental-builds.md).

 target, executing

 Executing a target means evaluating it and executing all tasks that have no conditions, or whose conditions evaluate to true. During incremental compilation, targets may be skipped or executed, but they are always evaluated. For more information, see target, evaluating.

 target, running

 A target that has a condition that evaluates to false is not run, that is, has no effect on the build. Targets that run are either executed or skipped. In either case, the target is evaluated. For more information, see target, evaluating.

 target, skipping

 If incremental compilation determines that all output files are up-to-date, then the target is skipped, that is, the target is evaluated, but the tasks within the target are not executed. For more information, see target, evaluating.

 target framework moniker

 A name that describes the framework (such as .NETFramwork, Silverlight, etc.), the version, and the profile (such as Client, Server, etc.) that you wish to target.

 targeting pack

 The list of assemblies that are distributed with a given framework and the set of reference assemblies for that framework.

 targets file

 A targets file is a project file that contains mostly targets and tasks that guide the build. By convention, It has the file extension .targets. Target files are typically imported at the end of associated project files.

 task

 Tasks are units of executable code that [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] projects use to perform build operations. For example, a task might compile input files or run an external tool. For more information, see [Tasks](../msbuild/msbuild-tasks.md).

 transform

 A transform is a one-to-one conversion of one item collection to another. In addition to enabling a project to convert item collections, a transform enables a target to identify a direct mapping between its inputs and outputs. For more information, see [Transforms](../msbuild/msbuild-transforms.md).

 well-known metadata

 See *metadata, well-known*.

## See also

- [MSBuild1](../msbuild/msbuild.md)