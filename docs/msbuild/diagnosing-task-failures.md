---
title: "Diagnosing task failures | Microsoft Docs"
ms.date: "10/25/2019"
ms.topic: "reference"
f1_keywords:
  - "MSBuild.ToolTask.ToolCommandFailed"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Diagnosing task failures

`MSB6006` is emitted when a <xref:Microsoft.Build.Utilities.ToolTask>–derived class runs a tool process that returns a nonzero exit code and did not log a more-specific error.

## Identifying the failing task

### Command-line builds

If the build 

### In Visual Studio

## Finding more failure information

TODO: there's hopefully some useful console output?

## Next steps

----

Yeah, that’s pretty bogus. Code in that class is why that specific error is thrown, but unlikely to help the actual problem, which is an error that some tool or script has returned for whatever reason (bad inputs? MSBuild authoring error? Network blip?)

It might be worth making a new page just for MSB6006, if it’s a common source of user pain. The troubleshooting steps are (extremely rough, if we want to go this direction I can actually write it up):

* Figure out what actually failed
  * what task was it?
  * What target is it in?
* Figure out what went wrong
  * were errors, warnings, or other messages logged?
* Figure out whose problem it is
  * is it a bug in your build logic? Probably!
  * Is it a bug in a task? Who owns it? NuGet package? VS? You?
* Fix it
  * Fix your build logic/project file
  * Update tools
  * File bug, work around?
