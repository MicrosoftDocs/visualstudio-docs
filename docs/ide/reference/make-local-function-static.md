---
title: Make local function static
ms.date: 08/06/2019
ms.topic: reference
author: governesss
ms.author: t-gosimp
manager: jillfra
f1_keywords:
  - "vs.csharp.refactoring.make.local.function.static"
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---

# Make local function static

This refactoring applies to:

- C#

**What:** Makes a local function static and passes in variables defined outside the function to the function’s declaration and calls.   

**When:** You want your local function to be static and for all variables to be defined in the scope of the function. 

**Why:** Static local functions improves readability: knowing that specific code is isolated makes it easier to understand, reread, and reuse. Static local functions also provide scoping to prevent polluting a class with a static function that's only called in a single method.  

## How-to

1. Place your caret on the local function name. 


2. Press **Crtl**+**.** to trigger the **Quick Actions and Refactorings** menu. 


    ![Make local function static](media/make-local-function-static.png)

3. Select **Make local function ‘static’.** 


# Pass variable explicitly in a static local function

This refactoring applies to:

- C#

**What:** Passes in a variable explicitly into a local static function.  

**When:** You want your local function to be static, but still use variables initialized outside of it without running into a compiler error. 

**Why:** Using static local functions provides clarification to readers, as they know that it can be only be declared and called in a specific context of the program. It provides the flexibility to define variables outside this context, but still be able to pass them in as arguments to the static local function.  

## How-to

1. Place your caret on the offending code. 


2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu. 

    ![Pass variable explicitly in static local function](media/pass-variable-explicitly-in-static-local-function.PNG)

3. Select **Pass variable explicitly in local static function**. 

  



## See also

- [Refactoring](../refactoring-in-visual-studio.md)
