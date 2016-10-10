---
title: "MSBuild Glossary"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f767d8e4-24d8-4803-80eb-e857202dbe2c
caps.latest.revision: 20
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Glossary
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>These terms are used to describe the Microsoft Build Engine (MSBuild) and its components.</para>
  </introduction>
  <section>
    <title>Glossary</title>
    <content>
      <definitionTable>
        <definedTerm>AssemblyFoldersEx</definedTerm>
        <definition>
          <para>A registry location where third party vendors store paths for each version of the framework that they support where design time resolution can look to find reference assemblies.</para>
        </definition>
        <definedTerm>batching</definedTerm>
        <definition>
          <para>Batching means dividing items into different categories known as <newTerm>batches</newTerm>, based on item metadata, and then running a target or task one time by using each batch. Batching is the MSBuild equivalent of the for--loop construct. For more information, see <link xlink:href="d35c085b-27b8-49d7-b6f8-8f2f3a0eec38">MSBuild Batching</link>.</para>
        </definition>
        <definedTerm>build-scope</definedTerm>
        <definition>
          <para>Build-scope describes an MSBuild object, for example, a global property, that is potentially visible to a project and to any child projects that are created in a multi-project build.</para>
        </definition>
        <definedTerm>child project</definedTerm>
        <definition>
          <para>See <newTerm>project, child</newTerm>.</para>
        </definition>
        <definedTerm>condition</definedTerm>
        <definition>
          <para>Many MSBuild elements can be defined conditionally; that is, the <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute appears in the element. The contents of conditional elements are ignored unless the condition evaluates to <languageKeyword>true</languageKeyword>. For more information, see <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>.</para>
        </definition>
        <definedTerm>definition, item</definedTerm>
        <definition>
          <para>See <newTerm>item definition</newTerm>.</para>
        </definition>
        <definedTerm>emit item</definedTerm>
        <definition>
          <para>During the execution phase of a build, items can be created or modified by tasks that have child <unmanagedCodeEntityReference>Output</unmanagedCodeEntityReference> elements that have the <unmanagedCodeEntityReference>ItemName</unmanagedCodeEntityReference> attribute. The task is said to "emit" the new items.</para>
        </definition>
        <definedTerm>emit property</definedTerm>
        <definition>
          <para>During the execution phase of a build, properties can be created or modified by tasks that have child <unmanagedCodeEntityReference>Output</unmanagedCodeEntityReference> elements that have the <unmanagedCodeEntityReference>PropertyName</unmanagedCodeEntityReference> attribute. The task is said to "emit" the new property.</para>
        </definition>
        <definedTerm>evaluation phase</definedTerm>
        <definition>
          <para>Evaluation is the first phase of a project build. All properties and items are evaluated in the order in which they appear in the project. Imported projects are evaluated as they are encountered in the project. Targets and tasks are not run until the execution phase, and any properties or items they would declare or emit are ignored during evaluation.</para>
        </definition>
        <definedTerm>execution phase</definedTerm>
        <definition>
          <para>Execution is the second phase of a project build. Selected targets are built and tasks are run. Properties and items can be created or modified compared to their evaluation values.</para>
        </definition>
        <definedTerm>function, property</definedTerm>
        <definition>
          <para>See <newTerm>property function</newTerm>.</para>
        </definition>
        <definedTerm>function, item</definedTerm>
        <definition>
          <para>See item function.</para>
        </definition>
        <definedTerm>item</definedTerm>
        <definition>
          <para>Items are inputs into the build system, and are grouped into item types based on their element names. Items typically represent files. Because items are named by the item type they belong to, the terms <newTerm>item</newTerm> and <newTerm>item value</newTerm> can be used interchangeably. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
        </definition>
        <definedTerm>item definition</definedTerm>
        <definition>
          <para>Item definition groups contain item definitions that add default metadata to any item type. Like well-known metadata, the default metadata is associated with all items of the specified item type. Default metadata can be explicitly overridden in an item definition. For more information, see <link xlink:href="8e3dc223-f9e5-4974-aa0e-5dc7967419cb">Item Definitions</link>.</para>
        </definition>
        <definedTerm>item function</definedTerm>
        <definition>
          <para>Item functions get information about the items in the project. These functions simplify getting Distinct() items and are faster than looping through the items. There are functions to manipulate item paths and strings. For more information, see <link xlink:href="5e6df3cc-2db8-4cbd-8fdd-3ffd03ac0876">Item Functions</link></para>
        </definition>
        <definedTerm>item metadata</definedTerm>
        <definition>
          <para>See <newTerm>metadata, item</newTerm>.</para>
        </definition>
        <definedTerm>item type</definedTerm>
        <definition>
          <para>Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
        </definition>
        <definedTerm>metadata, item</definedTerm>
        <definition>
          <para>Item metadata is a collection of name-value pairs that is associated with an item. Metadata provides descriptive information for the item and is optional, except for well-known metadata. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
        </definition>
        <definedTerm>metadata, well-known</definedTerm>
        <definition>
          <para>Well-known metadata is read-only item metadata that is initialized by using a predefined value. Well-known metadata provides descriptive information for an item that references a file. For example, the value of the well-known metadata named <codeInline>FullPath</codeInline> is the full path of the referenced file. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
        </definition>
        <definedTerm>multitargeting</definedTerm>
        <definition>
          <para>The ability for an application or assembly project to target many different CLR’s and frameworks from MSBuild and from Visual Studio.</para>
        </definition>
        <definedTerm>profile</definedTerm>
        <definition>
          <para>A subset of the full framework. This is used to minimize the amount that needs to be downloaded to a machine.</para>
        </definition>
        <definedTerm>project file</definedTerm>
        <definition>
          <para>A project file contains the MSBuild script that controls the build. Project files typically have a file extension that ends with "proj", such as .csproj or .vbproj. Project files may import property files and target files.</para>
        </definition>
        <definedTerm>property</definedTerm>
        <definition>
          <para>A property is a key-value pair that is used to control the build process. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </definition>
        <definedTerm>property, environment</definedTerm>
        <definition>
          <para>An environment property is a property that is automatically initialized to the value of a system environment variable that has the same name. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </definition>
        <definedTerm>property file</definedTerm>
        <definition>
          <para>A property file is a project file that contains mostly property groups and item groups that guide the build. By convention, It has the file extension .props. Property files are typically imported at the beginning of associated project files.</para>
        </definition>
        <definedTerm>property, function</definedTerm>
        <definition>
          <para>A property function is a system property or method that can be used to evaluate MSBuild scripts. Property methods can be used to read the system time, compare strings, match regular expressions, and perform other actions. For more information, see <link xlink:href="2253956e-3ae0-4bdc-9d3a-4881dfae4ddb">Property Functions</link>.</para>
        </definition>
        <definedTerm>property function, nested</definedTerm>
        <definition>
          <para>Property functions may be combined to form more complex functions. For example, </para>
          <para>
            <codeInline>$([MSBuild]::BitwiseAnd(32,   $([System.IO.File]::GetAttributes(tempFile))))</codeInline>
          </para>
          <para>For more information, see <link xlink:href="2253956e-3ae0-4bdc-9d3a-4881dfae4ddb">Property Functions</link>.</para>
        </definition>
        <definedTerm>property, global</definedTerm>
        <definition>
          <para>A global property is a key-value pair that is used to control the build process. Global properties are set at a command prompt, or by using the <languageKeyword>Properties</languageKeyword> attribute of an <legacyLink xlink:href="76577f6c-7669-44ad-a840-363e37a04d34">MSBuild task</legacyLink>, and cannot be modified during the evaluation phase of a build. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </definition>
        <definedTerm>property, local</definedTerm>
        <definition>
          <para>A local property is a key-value pair that is used to control the build process. This term is only used to distinguish a property that is not a global property.</para>
        </definition>
        <definedTerm>property, registry</definedTerm>
        <definition>
          <para>A registry property has a value that is set by using a special syntax that reads the value of a system registry subkey. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </definition>
        <definedTerm>property, reserved</definedTerm>
        <definition>
          <para>A reserved property is a key-value pair that is used to control the build process. Reserved properties are automatically initialized to predefined values. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </definition>
        <definedTerm>project-scope</definedTerm>
        <definition>
          <para>Project-scope describes an MSBuild object, for example, a local property, that is visible only in the containing project file and to any projects that it imports.</para>
        </definition>
        <definedTerm>project, child</definedTerm>
        <definition>
          <para>A child project is created by the MSBuild task during a project build. This new project is a child of the project that contains or imports the target that contains the MSBuild task. The child project inherits the global properties of the parent project, unless they are modified by the <unmanagedCodeEntityReference>Properties</unmanagedCodeEntityReference> attribute.</para>
        </definition>
        <definedTerm>redist list</definedTerm>
        <definition>
          <para>Redistribution list: the list of assemblies that correspond to a given framework.</para>
        </definition>
        <definedTerm>reference assembly</definedTerm>
        <definition>
          <para>An assembly that is used during design time to create an application. A reference assembly can have the actual code and private interfaces removed from it, leaving only the metadata and public interfaces.</para>
        </definition>
        <definedTerm>registry property</definedTerm>
        <definition>
          <para>See <newTerm>property, registry</newTerm>.</para>
        </definition>
        <definedTerm>target</definedTerm>
        <definition>
          <para>A target groups tasks together in a particular order and exposes sections of the project file as entry points into the build process. For more information, see <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>.</para>
        </definition>
        <definedTerm>target, building</definedTerm>
        <definition>
          <para>See target, running.</para>
        </definition>
        <definedTerm>target, evaluating</definedTerm>
        <definition>
          <para>Because of incremental compilation, targets must be analyzed for potential changes to properties and items. Even if the target is skipped, these changes must be made. Evaluating a target means performing this analysis and making these changes. For more information, see <link xlink:href="325e28c7-4838-4e3f-b672-4586adc7500c">Incremental Builds</link>.</para>
        </definition>
        <definedTerm>target, executing</definedTerm>
        <definition>
          <para>Executing a target means evaluating it and executing all tasks that have no conditions, or whose conditions evaluate to true. During incremental compilation, targets may be skipped or executed, but they are always evaluated. For more information, see target, evaluating. </para>
        </definition>
        <definedTerm>target, running</definedTerm>
        <definition>
          <para>A target that has a condition that evaluates to false is not run, that is, has no effect on the build. Targets that run are either executed or skipped. In either case, the target is evaluated. For more information, see target, evaluating.</para>
        </definition>
        <definedTerm>target, skipping</definedTerm>
        <definition>
          <para>If incremental compilation determines that all output files are up-to-date, then the target is skipped, that is, the target is evaluated, but the tasks within the target are not executed. For more information, see target, evaluating. </para>
        </definition>
        <definedTerm>target framework moniker</definedTerm>
        <definition>
          <para>A name that describes the framework (such as .NETFramwork, Silverlight, etc.), the version, and the profile (such as Client, Server, etc.) that you wish to target. </para>
        </definition>
        <definedTerm>targeting pack</definedTerm>
        <definition>
          <para>The list of assemblies that are distributed with a given framework and the set of reference assemblies for that framework.</para>
        </definition>
        <definedTerm>targets file</definedTerm>
        <definition>
          <para>A targets file is a project file that contains mostly targets and tasks that guide the build. By convention, It has the file extension .targets. Target files are typically imported at the end of associated project files.</para>
        </definition>
        <definedTerm>task</definedTerm>
        <definition>
          <para>Tasks are units of executable code that <token>vstecmsbuild</token> projects use to perform build operations. For example, a task might compile input files or run an external tool. For more information, see <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link>.</para>
        </definition>
        <definedTerm>transform</definedTerm>
        <definition>
          <para>A transform is a one-to-one conversion of one item collection to another. In addition to enabling a project to convert item collections, a transform enables a target to identify a direct mapping between its inputs and outputs. For more information, see <link xlink:href="d0bcfc3c-14fa-455e-805c-63ccffa4a3bf">MSBuild Transforms</link>.</para>
        </definition>
        <definedTerm>well-known metadata</definedTerm>
        <definition>
          <para>See <newTerm>metadata, well-known</newTerm>.</para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
</relatedTopics>
</developerConceptualDocument>