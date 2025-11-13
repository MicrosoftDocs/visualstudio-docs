---
title: Settings waterfall | Microsoft IntelliTest Developer Test Tool
description: Learn about the settings waterfall, which organizes settings at the Assembly, Fixture, and Exploration level.
ms.date: 05/02/2017
ms.topic: article
helpviewer_keywords:
- IntelliTest, Settings waterfall
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Settings waterfall

The concept of the settings waterfall means that the user can specify settings at the **Assembly**, **Fixture**, and **Exploration** level:

* Assembly - [PexAssemblySettings](attribute-glossary.md#pexassemblysettings)
* Fixture - [PexClass](attribute-glossary.md#pexclass)
* Exploration - [PexExplorationAttributeBase](attribute-glossary.md#pexexplorationattributebase)

Settings specified at the **Assembly** level affect all fixtures and exploration under that assembly. Settings specified at the **Fixture** level affect all explorations under that fixture. Child settings win&mdash;if a setting is defined at the **Assembly** and the **Fixture** levels, the **Fixture** settings are used.

Note that some settings are specific to the **Assembly** level or **Fixture** level.

**Example**

```csharp
using Microsoft.Pex.Framework;

[assembly: PexAssemblySettings(MaxBranches = 1000)] // we override the default value of maxbranches

namespace MyTests
{
    [PexClass(MaxBranches = 500)] // we override the 1000 value and set maxbranches to 500
    public partial class MyTests
    {
        [PexMethod(MaxBranches = 100)] // we override again, maxbranches = 100
        public void MyTest(...) { ... }
    }
}
```

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://aka.ms/feedback/suggest?space=8).
