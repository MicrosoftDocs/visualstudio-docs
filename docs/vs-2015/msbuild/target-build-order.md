---
title: "Target Build Order | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "msbuild, build order"
ms.assetid: f4a26339-9f9a-497a-9aa6-0797183d450d
caps.latest.revision: 21
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Target Build Order
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Targets must be ordered if the input to one target depends on the output of another target. You can use these attributes to specify the order in which targets are run:  
  
- `InitialTargets`. This `Project` attribute specifies the targets that will run first, even if targets are specified on the command line or in the `DefaultTargets` attribute.  
  
- `DefaultTargets`. This `Project` atttribute specifies which targets are run if a target is not specified explicitly on the command line.  
  
- `DependsOnTargets`. This `Target` attribute specifies targets that must run before this target can run.  
  
- `BeforeTargets` and `AfterTargets`. These `Target` attributes specify that this target should run before or after the specified targets (MSBuild 4.0).  
  
  A target is never run twice during a build, even if a subsequent target in the build depends on it. Once a target has been run, its contribution to the build is complete.  
  
  Targets may have a `Condition` attribute. If the specified condition evaluates to `false`, the target isn't executed and has no effect on the build. For more information about conditions, see [Conditions](../msbuild/msbuild-conditions.md).  
  
## Initial Targets  
 The `InitialTargets` attribute of the [Project](../msbuild/project-element-msbuild.md) element specifies targets that will run first, even if targets are specified on the command line or in the `DefaultTargets` attribute. Initial targets are typically used for error checking.  
  
 The value of the `InitialTargets` attribute can be a semicolon-delimited, ordered list of targets. The following example specifies that the `Warm` target runs, and then the `Eject` target runs.  
  
```  
<Project InitialTargets="Warm;Eject" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
```  
  
 Imported projects may have their own `InitialTargets` attributes. All initial targets are aggregated together and run in order.  
  
 For more information, see [How to: Specify Which Target to Build First](../msbuild/how-to-specify-which-target-to-build-first.md).  
  
## Default Targets  
 The `DefaultTargets` attribute of the [Project](../msbuild/project-element-msbuild.md) element specifies which target or targets are built if a target isn't specified explicitly in a command line.  
  
 The value of the `DefaultTargets` attribute can be a semicolon-delimited, ordered list of default targets. The following example specifies that the `Clean` target runs, and then the `Build` target runs.  
  
```  
<Project DefaultTargets="Clean;Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
```  
  
 You can override the default targets by using the **/target** switch on the command line. The following example specifies that the `Build` target runs, and then the `Report` target runs. When you specify targets in this way, any default targets are ignored.  
  
 `msbuild /target:Build;Report`  
  
 If both initial targets and default targets are specified, and if no command-line targets are specified, MSBuild runs the initial targets first, and then runs the default targets.  
  
 Imported projects may have their own `DefaultTargets` attributes. The first `DefaultTargets` attribute encountered determines which default targets will run.  
  
 For more information, see [How to: Specify Which Target to Build First](../msbuild/how-to-specify-which-target-to-build-first.md).  
  
## First Target  
 If there are no initial targets, default targets, or command-line targets, then MSBuild runs the first target it encounters in the project file or any imported project files.  
  
## Target Dependencies  
 Targets can describe dependency relationships with each other. The `DependsOnTargets` attribute indicates that a target depends on other targets. For example,  
  
```  
<Target Name="Serve" DependsOnTargets="Chop;Cook" />  
```  
  
 tells MSBuild that the `Serve` target depends on the `Chop` target and the `Cook` target. MSBuild runs the `Chop` target, and then runs the `Cook` target before it runs the `Serve` target.  
  
## BeforeTargets and After Targets  
 In MSBuild 4.0, you can specify target order by using the `BeforeTargets` and `AfterTargets` attributes.  
  
 Consider the following script.  
  
```  
<Project DefaultTargets="Compile;Link" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="Compile">  
        <Message Text="Compiling" />  
    </Target>  
    <Target Name="Link">  
        <Message Text="Linking" />  
    </Target>  
</Project>  
```  
  
 To create an intermediate target `Optimize` that runs after the `Compile` target, but before the `Link` target, add the following target anywhere in the `Project` element.  
  
```  
<Target Name="Optimize"   
    AfterTargets="Compile" BeforeTargets="Link">  
    <Message Text="Optimizing" />  
</Target>  
```  
  
## Determining the Target Build Order  
 MSBuild determines the target build order as follows:  
  
1. `InitialTargets` targets are run.  
  
2. Targets specified on the command line by the **/target** switch are run. If you specify no targets on the command line, then the `DefaultTargets` targets are run. If neither is present, then the first target encountered is run.  
  
3. The `Condition` attribute of the target is evaluated. If the `Condition` attribute is present and evaluates to `false`, the target isn't executed and has no further effect on the build.  
  
4. Before a target is executed, its `DependsOnTargets` targets are run.  
  
5. Before a target is executed, any target that lists it in a `BeforeTargets` attribute is run.  
  
6. Before a target is executed, its `Inputs` attribute and `Outputs` attribute are compared. If MSBuild determines that any output files are out of date with respect to the corresponding input file or files, then MSBuild executes the target. Otherwise, MSBuild skips the target.  
  
7. After a target is executed or skipped, any target that lists it in an `AfterTargets` attribute is run.  
  
## See Also  
 [Targets](../msbuild/msbuild-targets.md)
