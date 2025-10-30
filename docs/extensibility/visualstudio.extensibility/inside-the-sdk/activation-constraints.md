---
title: Rule-based activation constraints
description: Learn about activation constraints, which extension authors can use to control the conditions under which extensions surface in the IDE.
ms.topic: article
ms.date: 6/30/2023
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Rule-based activation constraints

One of the common concepts in VisualStudio.Extensibility is the use of context-based activation rules. These rules govern the conditions under which an extension or a command is surfaced to the user. An example of a context-based activation rule is the [`VisibleWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.visiblewhen) property in a command's configuration that declares when the command is made visible.

## Constraint types

Each constraint is defined as an instance of the [`ActivationConstraint`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint) type created with one of the `ActivationConstraint`'s factory methods, like [`ClientContext`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.clientcontext).

Multiple activation constraints can be combined together using the [`And`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.and), [`Or`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.or), and [`Not`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.not) methods. You can also combine activation constraints using operators `&`, `|`, and `!`.

## Example definition

In the following example, the command configuration property [`EnabledWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.enabledwhen) defines when the command is in the enabled state. The [`ClientContext`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.clientcontext) method is one of the activation constraint factory methods. It generates the activation constraint, given the two arguments, a string and regular expression pattern to match against that string. Therefore, the following code indicates that a command is enabled when the user selects a file with one of those extensions.

```csharp
public override CommandConfiguration CommandConfiguration => new("%My command.DisplayName%")
{
    EnabledWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(jpg|jpeg|txt)$"),
};
```

The [`ClientContextKey`](/dotnet/api/microsoft.visualstudio.extensibility.clientcontextkey) class provides the range of IDE state information that you can test against; for a table of values, see [Client context keys](#client-context-keys).

The following example shows how to combine multiple constraints:

```csharp
EnabledWhen = ActivationConstraint.And(
    ActivationConstraint.SolutionState(SolutionState.Exists),
    ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorFileName, @"\.(jpg|jpeg|txt)$")),
```

or, more succinctly, using the `&` operator:

```csharp
EnabledWhen =
    ActivationConstraint.SolutionState(SolutionState.Exists) &
    ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorFileName, @"\.(jpg|jpeg|txt)$")),
```

## Activation constraint properties

Activation constraints can be used to configure a variety of VisualStudio.Extensibility functionalities, including the [loading of an extension](/dotnet/api/microsoft.visualstudio.extensibility.extensionconfiguration.loadedwhen), and the [enabled](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.enabledwhen) or [visible](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.visiblewhen) state of a command. The configuration types contain property of type [`ActivationConstraint`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint), typically with a `When` suffix that implies that something activates when the specified conditions are satisfied.

## Activation constraint factory methods

This section shows the list of currently supported activation constraints. Each entry on the list is a factory method on the [`ActivationConstraint`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint) type.

| Term | Description |
| -- | -- |
| [`ClientContext`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.clientcontext)(\<key>=[`ClientContextKey`](/dotnet/api/microsoft.visualstudio.extensibility.clientcontextkey), \<pattern>=\<regex>) | True when the provided client context key matches to regular expression. See [client context keys](#client-context-keys). |
| [`ActiveProjectCapability`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.activeprojectcapability)(\<expression>=[`ProjectCapability`](/dotnet/api/microsoft.visualstudio.extensibility.projectcapability)) | True whenever solution has a project with capabilities matching the provided subexpression. An expression can be something like `VB | CSharp`. For more about project capabilities, see [Project query API overview](../project/project.md). |
| [`ProjectAddedItem`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.projectaddeditem)(\<pattern>=\<regex>) | The term is true when a file matching the "pattern" is added to a project in the solution that is opened. |
| [`SolutionHasProjectCapability`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.solutionhasprojectcapability)(\<expression>=[`ProjectCapability`](/dotnet/api/microsoft.visualstudio.extensibility.projectcapability)) | True whenever solution has a project with capabilities matching the provided subexpression. An expression can be something like `VB | CSharp`. For more about project capabilities, see [Project query API overview](../project/project.md). |
| [`SolutionState`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.solutionstate)(\<state>=[`SolutionState`](/dotnet/api/microsoft.visualstudio.extensibility.solutionstate)) | True when solution state matches the provided value, see [solution states](#solution-states) for list of values. |
| [`EditorContentType`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.editorcontenttype)(\<contentType>) | True when active editor content type is or inherits from specific content type.

For compatibility reasons, the following legacy activation constraints are also supported:

| Term | Description |
| -- | -- |
| [`ActiveProjectBuildProperty`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.activeprojectbuildproperty)(\<property>=\<regex>) | The term is true when the selected project has the specified build property and the property value matches the regex pattern provided. |
| [`ActiveProjectFlavor`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.activeprojectflavor)(\<guid>) | True whenever the selected project has a flavor matching the given project type GUID. |
| [`SolutionHasProjectBuildProperty`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.solutionhasprojectbuildproperty)(\<property>=\<regex>) | The term is true when solution has a loaded project with the specified build property and property value matches to regex filter provided. |
| [`SolutionHasProjectFlavor`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.solutionhasprojectflavor)(\<guid>) | True whenever a solution has project that is flavored (aggregated) and has a flavor matching the given project type GUID. |
| [`UIContext`](/dotnet/api/microsoft.visualstudio.extensibility.activationconstraint.uicontext)(\<guid>) | True when specified [UI Context](/dotnet/api/microsoft.visualstudio.vsconstants.uicontext) is active in Visual Studio instance. |

## Solution states

The [solution state](/dotnet/api/microsoft.visualstudio.extensibility.solutionstate) refers to the state of the solution and its projects, whether a solution is loaded, whether it has zero, one, or multiple projects, and whether it is building.

Activation constraints that correspond to solution states can be combined in the same way as any other activation constraints. For example, you can combine an activation constraint that specifies a `FullyLoaded` solution and a `SingleProject` solution to capture single-project solutions when they are fully loaded.

```csharp
this.EnabledWhen = ActivationConstraint.And(
    ActivationConstraint.SolutionState(SolutionState.SingleProject),
    ActivationConstraint.SolutionState(SolutionState.FullyLoaded));
```

## Client context keys

Activation rules can also utilize the [client context](extension-anatomy.md#client-context) contents as parts of its expression.

Currently, the client context is limited to a [small set of values](/dotnet/api/microsoft.visualstudio.extensibility.clientcontextkey.shell#properties) in IDE state.

## Related content

- [Components of a VisualStudio.Extensibility extension](./extension-anatomy.md).
