---
title: Set the run order for MSBuild targets
description: Specify the order in which MSBuild targets run and whether the input to one target depends on the output of another target.
ms.date: 5/1/2025
ms.topic: how-to
helpviewer_keywords:
- msbuild, build order
author: baronfel
ms.author: chethusk

ms.subservice: msbuild
---

# Target build order

Targets must specify order relationships if the input to one target depends on the output of another target. The order of the `Target` elements in the XML doesn't determine execution order. Use these attributes to specify the order in which targets run:

- `InitialTargets`. This `Project` attribute specifies the targets that will run first, even if targets are specified on the command line or in the `DefaultTargets` attribute.

- `DefaultTargets`. This `Project` attribute specifies which targets are run if a target isn't specified explicitly on the command line.

- `DependsOnTargets`. This `Target` attribute specifies targets that must run before this target can run.

- `BeforeTargets` and `AfterTargets`. These `Target` attributes specify that this target should run before or after the specified targets, if they run.

A target is never run twice during a build, even if a subsequent target in the build depends on it. Once a target has been run, its contribution to the build is complete.

Targets can have a `Condition` attribute. If the specified condition evaluates to `false`, the target isn't executed and is considered skipped. See [Determine the target build order](#determine-the-target-build-order) for details on how skipped targets behave. For more information about conditions, see [Conditions](../msbuild/msbuild-conditions.md).

## Initial targets

The `InitialTargets` attribute of the [Project](../msbuild/project-element-msbuild.md) element specifies targets that will run first, even if targets are specified on the command line or in the `DefaultTargets` attribute. Initial targets are typically used for error checking.

The value of the `InitialTargets` attribute can be a semicolon-delimited, ordered list of targets. The following example specifies that the `Warm` target runs, and then the `Eject` target runs.

```xml
<Project InitialTargets="Warm;Eject">
```

Imported projects can have their own `InitialTargets` attributes. All initial targets are aggregated together and run in order.

For more information, see [How to: Specify which target to build first](../msbuild/how-to-specify-which-target-to-build-first.md).

## Default targets

The `DefaultTargets` attribute of the [Project](../msbuild/project-element-msbuild.md) element specifies which target or targets are built if a target isn't specified explicitly in a command line.

The value of the `DefaultTargets` attribute can be a semicolon-delimited, ordered list of default targets. The following example specifies that the `Clean` target runs, and then the `Build` target runs.

```xml
<Project DefaultTargets="Clean;Build">
```

You can override the default targets by using the **-target** switch on the command line. The following example specifies that the `Build` target runs, and then the `Report` target runs. When you specify targets in this way, any default targets are ignored.

 `msbuild -target:Build;Report`

If both initial targets and default targets are specified, and if no command-line targets are specified, MSBuild runs the initial targets first, and then runs the default targets.

Imported projects can have their own `DefaultTargets` attributes. The first `DefaultTargets` attribute encountered determines which default targets will run.

For more information, see [How to: Specify which target to build first](../msbuild/how-to-specify-which-target-to-build-first.md).

## First target

If there are no initial targets, default targets, or command-line targets, then MSBuild runs the first target it encounters in the project file or any imported project files.

## Target dependencies

Targets can describe dependency relationships with each other. The `DependsOnTargets` attribute indicates that a target depends on other targets. For example,

```xml
<Target Name="Serve" DependsOnTargets="Chop;Cook" />
```

tells MSBuild that the `Serve` target depends on the `Chop` target and the `Cook` target. MSBuild ensures that both the `Chop` target and the `Cook` target run before it runs the `Serve` target.

> [!CAUTION]
> Order within `DependsOnTargets` is considered when running targets, but it does not provide a guarantee. The build engine will consider `DependsOnTargets`, `BeforeTargets`, and `AfterTargets` specified for each target. In the example above, if neither `Chop` nor `Cook` specifies any dependencies, `Chop` will run first, but it's possible for `Cook` to run first, for example if `Chop` specifies `DependsOnTargets="Cook"`.

> [!NOTE]
> The standard targets in the SDK define a number of `DependsOn` properties that contain the list of targets that are dependencies for that target (for example, `$(BuildDependsOn)`, `$(CleanDependsOn)`, and so on). For example,
>
> `<Target Name="Build" DependsOnTargets="$(BuildDependsOn)">`
>
> To customize a project, you can override the `DependsOn` properties with additional custom targets that extend the build process, as described in [Extend the Visual Studio build process](./how-to-extend-the-visual-studio-build-process.md).

## BeforeTargets and AfterTargets

You can specify target order by using the `BeforeTargets` and `AfterTargets` attributes. These attributes allow you to augment build logic you don't directly control, such as the .NET SDK or MSBuild’s [default build targets](./msbuild-targets.md#sdk-and-default-build-targets).

Consider the following script.

```xml
<Project DefaultTargets="Compile;Link">
    <Target Name="Compile">
        <Message Text="Compiling" />
    </Target>
    <Target Name="Link">
        <Message Text="Linking" />
    </Target>
</Project>
```

To create an intermediate target `Optimize` that runs after the `Compile` target, but before the `Link` target, add the following target anywhere in the `Project` element.

```xml
<Target Name="Optimize" AfterTargets="Compile">
    <Message Text="Optimizing" />
</Target>
```

Alternately, specify the order as

```xml
<Target Name="Optimize" BeforeTargets="Link">
    <Message Text="Optimizing" />
</Target>
```

It isn't useful to specify *both* `BeforeTargets` and `AfterTargets` on the same target. As described in the next section, only the first target encountered will cause the new target to run.

## Choosing between `AfterTargets` and `DependsOnTargets`

`DependsOnTargets` and `AfterTargets` have different behavior. The differences involve what happens when targets aren't built, and what happens when you specify multiple targets.

If a target produces data that your target depends on, you should specify it in `DependsOnTargets`. **Every** target specified in `DependsOnTargets` will be run before your target.

Use `AfterTargets` to run your target any time the specified target runs or is skipped. If you specify multiple targets, your target follows the *first* one that runs (or is skipped).

If your target runs (or is skipped) first because of other dependencies or an explicit request, the targets you specify in `AfterTargets` **aren't guaranteed to run**. You can observe this behavior with a project like

```xml
<Project DefaultTargets="Default;After1">
  <Target Name="Default" AfterTargets="After1">
    <Warning Text="Default" />
  </Target>
  <Target Name="After1">
    <Warning Text="After1" />
  </Target>
  <Target Name="After2" AfterTargets="Default">
    <Warning Text="After2" />
  </Target>
</Project>
```

which emits

```text
warning : Default
warning : After2
warning : After1
```

because `Default` doesn't have a `DependsOnTargets` attribute and isn't named in any `BeforeTargets`, so it can run immediately when `DefaultTargets` requests it. When it runs, `After2`'s `AfterTargets` causes it to run. Then `Default` is complete, so the next target to run is `After1` from `DefaultTargets`. `Default`'s `AfterTargets` doesn't do anything in this build because `Default` already ran and can't run again.

In some cases, it makes sense to specify a target or targets in _both_ `AfterTargets` and `DependsOnTargets`.

```xml
<Target Name="SpecifiesBoth"
        AfterTargets="A;B;C"
        DependsOnTargets="A;B;C" />
```

In this example, `SpecifiesBoth` runs if _any_ of `A`, `B`, or `C` runs, and ensures that all of `A`, `B`, and `C` run before `SpecifiesBoth`.

## Determine the target build order

MSBuild determines the target build order as follows:

1. `InitialTargets` targets are run.

2. Targets specified on the command line by the **-target** switch are run. If you specify no targets on the command line, then the `DefaultTargets` targets are run. If neither is present, then the first target encountered is run.

3. The `Condition` attribute of the target is evaluated. If the `Condition` attribute is present and evaluates to `false`, the target isn't executed and is considered skipped.

   Other targets that list the conditional target in `BeforeTargets` or `AfterTargets` still execute in the prescribed order, regardless of the result of the condition.

    > [!NOTE]
    > A skipped target is not considered run. If another target later requests it through `DependsOnTargets` and the condition now evaluates to `true`, the target will execute at that point. However, `BeforeTargets` and `AfterTargets` that already ran for the originally skipped target will not run again.

4. Before the target is executed or skipped, its `DependsOnTargets` targets are run, unless the `Condition` attribute is applied to the target and evaluates to `false`.

   > [!NOTE]
   > A target is considered skipped if it isn't executed because its output items are up-to-date (see [incremental build](../msbuild/incremental-builds.md)). This check is done just before executing the tasks inside the target, and does not affect the order of execution of targets.

5. Before the target is executed or skipped, any other target that lists the target in a `BeforeTargets` attribute is run.

6. Before the target is executed, its `Inputs` attribute and `Outputs` attribute are compared. If MSBuild determines that any output files are out of date with respect to the corresponding input file or files, then MSBuild executes the target. Otherwise, MSBuild skips the target.

7. After the target is executed or skipped, any other target that lists it in an `AfterTargets` attribute is run.

## Related content

- [Targets](../msbuild/msbuild-targets.md)
