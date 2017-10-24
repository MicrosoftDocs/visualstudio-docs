---
title: "Settings waterfall | Microsoft IntelliTest Developer Test Tool | Microsoft Docs"
ms.custom: ""
ms.date: "05/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliTest, Settings waterfall"
ms.assetid: 45777037-9E16-4ABF-BD26-5AF4E740D4E6
caps.latest.revision: 56
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Settings waterfall

The concept of the settings waterfall means that the 
user can specify settings at the **Assembly**, 
**Fixture** and **Exploration** level: 

* Assembly - [PexAssemblySettings](attribute-glossary.md#pexassemblysettings)
* Fixture - [PexClass](attribute-glossary.md#pexclass)
* Exploration - [PexExplorationAttributeBase](attribute-glossary.md#pexexplorationattributebase)

Settings specified at the **Assembly** level will affect all 
fixtures and exploration under that assembly. Settings 
specified at the **Fixture** level will affect all 
explorations under that fixture. Child settings win: 
if a setting is defined at the **Assembly** and the 
**Fixture** levels, the **Fixture** settings will be used.

Note that some settings are specific to the **Assembly** 
level or **Fixture** level. 

**Example**

```
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

Post your ideas and feature requests on 
**[UserVoice](https://visualstudio.uservoice.com/forums/121579-visual-studio-2015/category/157869-test-tools?query=IntelliTest)**.
