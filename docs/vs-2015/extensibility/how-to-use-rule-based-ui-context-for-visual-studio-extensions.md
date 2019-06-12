---
title: "How to: Use Rule-based UI Context for Extensions | Microsoft Docs"
ms.date: 11/15/2016
ms.topic: conceptual
ms.assetid: 8dd2cd1d-d8ba-49b9-870a-45acf3a3259d
caps.latest.revision: 8
ms.author: gregvanl
---
# How to: Use Rule-based UI Context for Visual Studio Extensions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio allows loading of VSPackages when certain well-known <xref:Microsoft.VisualStudio.Shell.UIContext>s are activated. However, these UI Contexts are not very fine grained, leaving extension authors no choice but to pick an available UI Context that activates before the point they really wanted the VSPackage to load. For a list of well-known UI contexts, see <xref:Microsoft.VisualStudio.Shell.KnownUIContexts>.

 Loading packages can have a performance impact and loading them sooner than they are needed is not the best practice. Visual Studio 2015 introduced the concept of Rules-based UI Contexts, a mechanism that allows extension authors to define the precise conditions under which a UI Context is activated and associated VSPackages loaded.

## Rule-based UI Context
 A "Rule" consists of a new UI Context (a GUID) and a Boolean expression that references one or more "Terms" combined with logical "and", "or", "not" operations. "Terms" are evaluated dynamically at runtime and the expression is re-evaluated whenever any of its terms changes. When the expression evaluates to true, the associated UI Context is activated. Otherwise, the UI Context is de-activated.

 Rule-based UI Context can be used in a variety of ways:

1. Specify visibility constraints for commands and tool windows. You can hide the commands/tools windows until the UI Context rule is met.

2. As auto load constraints: auto load packages only when the rule is met

3. Delayed task: delay loading until a specified interval has passed and the rule is still met.

   The mechanism may be used by any Visual Studio extension.

## Create a Rule-based UI Context
 Suppose you have an extension called TestPackage, which offers a menu command which applies only to files with “.config” extension. Before VS2015, the best option was to load TestPackage when <xref:Microsoft.VisualStudio.Shell.KnownUIContexts.SolutionExistsAndFullyLoadedContext%2A> UI Context was activated. This is not efficient, since the loaded solution may not even contain a .config file. Let us see how rules-based UI Context can be used to activate a UI Context only when a file with .config extension is selected, and load TestPackage when that UI Context is activated.

1. Define a new UIContext GUID and add to the VSPackage class <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> and <xref:Microsoft.VisualStudio.Shell.ProvideUIContextRuleAttribute>.

    For example, let’s assume a new UIContext “UIContextGuid” is to be added. The GUID created (you can create a GUID by clicking on Tools -> create guid) is “8B40D5E2-5626-42AE-99EF-3DD1EFF46E7B”. You then add the following inside your package class:

   ```csharp
   public const string UIContextGuid = "8B40D5E2-5626-42AE-99EF-3DD1EFF46E7B";
   ```

    For the attributes, add the following: (Details of these attributes will be explained later)

   ```csharp
   [ProvideAutoLoad(TestPackage.UIContextGuid)]
   [ProvideUIContextRule(TestPackage.UIContextGuid,
       name: "Test auto load",
       expression: "DotConfig",
       termNames: new[] { "DotConfig" },
       termValues: new[] { "HierSingleSelectionName:.config$" })]
   ```

    These metadata define the new UIContext GUID (8B40D5E2-5626-42AE-99EF-3DD1EFF46E7B) and an expression referring to a single term, "DotConfig". The "DotConfig" term evaluates to true whenever the current selection in the active hierarchy has a name that matches the regular expression pattern "\\.config$" (ends with ".config"). The (Default) value defines an optional name for the rule useful for debugging.

    The values of the attribute are added to pkgdef generated during build time afterwards.

2. In the VSCT file for the TestPackage’s commands, add the “DynamicVisibility” flag to the appropriate commands:

   ```xml
   <CommandFlag>DynamicVisibility</CommandFlag>
   ```

3. In the Visibilities section of the VSCT, tie the appropriate commands to the new UIContext GUID defined in #1:

   ```xml
   <VisibilityConstraints>
       <VisibilityItem guid="guidTestPackageCmdSet" id="TestId"  context="guidTestUIContext"/>
   </VisibilityConstraints>
   ```

4. In the Symbols section, add the definition of the UIContext:

   ```xml
   <GuidSymbol name="guidTestUIContext" value="{8B40D5E2-5626-42AE-99EF-3DD1EFF46E7B}" />
   ```

    Now, the context menu commands for *.config files will be visible only when the selected item in the solution explorer is a ".config" file and the package will not be loaded until one of those commands is selected.

   Next, let's use a debugger to confirm that the package loads only when we expect it to. To debug TestPackage:

5. Set a breakpoint in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.

6. Build the TestPackage and start debugging.

7. Create a project or open one.

8. Select any file with an extension other than .config. The breakpoint should not be hit.

9. Select the App.Config file.

   The TestPackage loads and stops at the breakpoint.

## Adding More Rules for UI Context
 Since the UI Context rules are Boolean expressions, you can add more restricted rules for a UI Context. For example, in the above UI Context, you can specify that the rule applies only when a solution with a project is loaded. In this way, the commands won't show up if you open up a ".config" file as a standalone file, not as part of a project.

```csharp
[ProvideAutoLoad(TestPackage.UIContextGuid)]
[ProvideUIContextRule(TestPackage.UIContextGuid,
    name: "Test auto load",
    expression: "(SingleProject | MultipleProjects) & DotConfig",
    termNames: new[] { "SingleProject", "MultipleProjects","DotConfig" },
    termValues: new[] { VSConstants.UICONTEXT_SolutionHasSingleProject_string , VSConstants.UICONTEXT_SolutionHasMultipleProjects_string , "HierSingleSelectionName:.config$" })]
```

 Now the expression references three terms. The first two terms, "SingleProject" and "MultipleProjects", refer to other well-known UI Contexts (by their GUIDs). The third term, "DotConfig" is the rule-based UI Context we defined earlier.

## Delayed Activation
 Rules can have an optional "Delay". The delay is specified in milliseconds. If present, the delay causes the activation or deactivation of a Rule's UI Context to be delayed by that time interval. If the rule changes back before the delay interval, then nothing happens. This mechanism can be used to "stagger" initialization steps - especially one-time initialization without relying on timers or registering for idle notifications.

 For example, you can specify your test load rule to have a delay of 100 milliseconds:

```csharp
[ProvideAutoLoad(TestPackage.UIContextGuid)]
[ProvideUIContextRule(TestPackage.UIContextGuid,
    name: "Test auto load",
    expression: "DotConfig",
    termNames: new[] { "DotConfig" },
    termValues: new[] { "HierSingleSelectionName:.config$" },
    delay: 100)]
```

## Term Types
 Here are the various types of term that are supported:

|||
|-|-|
|{nnnnnnnn-nnnn-nnnn-nnnn-nnnnnnnnnnnn}|The GUID refers to a UI Context. The term will be true whenever the UI Context is active and false otherwise.|
|HierSingleSelectionName:\<pattern>|The term will be true whenever the selection in the active hierarchy is a single item and the name of the selected item matches the .Net regular expression given by "pattern".|
|UserSettingsStoreQuery:\<query>|"query" represents a full path into the user settings store which must evaluate to a non-zero value. The query is split into a "collection" and "propertyName" at the last slash.|
|ConfigSettingsStoreQuery:\<query>|"query" represents a full path into the config settings store which must evaluate to a non-zero value. The query is split into a "collection" and "propertyName" at the last slash.|
|ActiveProjectFlavor:\<projectTypeGuid>|The term will be true whenever the currently selected project is flavored (aggregated) and has a flavor matching the given project type GUID.|
|ActiveEditorContentType:\<contentType>|The term will be true when the selected document is a text editor with the given content type.|
|ActiveProjectCapability:\<Expression>|The term is true when active project capabilities matches the provided expression. An expression can be something like VB &#124; CSharp|
|SolutionHasProjectCapability:\<Expression>|Similar to above but term is true when solution has any loaded project that matches to the expression.|
|SolutionHasProjectFlavor:\<projectTypeGuid>|The term will be true whenever a solution has project that is flavored (aggregated) and has a flavor matching the given project type GUID.|

## Compatibility with cross-version extension
 Rule based UI Contexts is a new feature in Visual Studio 2015 and would not be ported to earlier versions. This creates a problem with extensions/packages that target multiple versions of Visual Studio which would have to be auto-loaded in Visual Studio 2013 and earlier, but can benefit from rule based UI Contexts to prevent being auto-loaded in Visual Studio 2015.

 In order to support such packages, AutoLoadPackages entries in the registry can now provide a flag in its value field to indicate that the entry should be skipped in Visual Studio 2015 and above. This can be done by adding a flags option to <xref:Microsoft.VisualStudio.Shell.PackageAutoLoadFlags>. VSPackages can now add **SkipWhenUIContextRulesActive** option to their <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> attribute to indicate the entry should be ignored in Visual Studio 2015 and above.

## Extensible UI Context Rules
 Sometimes, packages cannot use static UI Context rules. For example, suppose you have a package supporting extensibility such that the command state is based on editor types that are supported by imported MEF providers. The command is enabled if there is an extension supporting the current edit type. In such cases the package itself cannot use a static UI Context rule, since the terms would change depending on which MEF extensions are available.

 In order to support such packages, rule based UI Contexts support a hardcoded expression “*” that indicates all the terms below it will be joined with OR. This allows for the master package to define a known rule based UI Context and tie its command state to this context. Afterwards any MEF extension targeted for the master package can add its terms for editors it supports without impacting other terms or the master expression.

 The constructor <xref:Microsoft.VisualStudio.Shell.ProvideExtensibleUIContextRuleAttribute.%23ctor%2A> documentation shows the syntax for extensible UI Context rules.
