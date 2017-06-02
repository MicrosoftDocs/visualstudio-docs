---
title: "Creating unit test method stubs with the Create Unit Tests command | Microsoft Docs"
ms.custom: ""
ms.date: "05/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliTest, Get started"
ms.assetid: 21FE4D68-9E7F-4BB1-BD69-B0D09A941F09
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
# Get started with Microsoft IntelliTest

* If this is your first time with IntelliTest:
  * watch the [Channel 9 video](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Intellitest)
  * read this [overview on MSDN Magazine](https://msdn.microsoft.com/magazine/dn904672.aspx)
  * read our [documentation](https://docs.microsoft.com/en-gb/visualstudio/test/generate-unit-tests-for-your-code-with-intellitest)
* Ask your questions on [stackoverflow](http://stackoverflow.com/questions/tagged/intellitest)
* Read the rest of this reference manual
* Print this page for quick reference

<a name="important-attributes"></a>
## Important attributes

* [PexClass](attribute-glossary.md#pexclass) marks a type containing **PUT**
* [PexMethod](attribute-glossary.md#pexmethod) marks a **PUT**
* [PexAssumeNotNull](attribute-glossary.md#pexassumenotnull) marks a non-null parameter 

```
using Microsoft.Pex.Framework;

[..., PexClass(typeof(Foo))]
public partial class FooTest {
    [PexMethod]
    public void Bar([PexAssumeNotNull]Foo target, int i) {
        target.Bar(i);
    }
}
```

* [PexAssemblyUnderTest](attribute-glossary.md#pexassemblyundertest) binds a test project to a project
* [PexInstrumentAssembly](attribute-glossary.md#pexinstrumentassemblyattribute) specifies an assembly to instrument

```
[assembly: PexAssemblyUnderTest("MyAssembly")] // also instruments "MyAssembly"
[assembly: PexInstrumentAssembly("Lib")]
```

<a name="helper-classes"></a>
## Important static helper classes

* [PexAssume](static-helper-classes.md#pexassume) evaluates assumptions (input filtering)
* [PexAssert](static-helper-classes.md#pexassert) evaluates assertions
* [PexChoose](static-helper-classes.md#pexchoose) generates new choices (additional inputs)
* [PexObserve](static-helper-classes.md#pexobserve) logs live values to the generated tests

```
[PexMethod]
void StaticHelpers(Foo target) {
    PexAssume.IsNotNull(target);

    int i = PexChoose.Value<int>("i");
    string result = target.Bar(i);

    PexObserve.ValueForViewing<string>("result", result);
    PexAssert.IsNotNull(result);
}
```

[!INCLUDE [irm-help-support-shared](irm-help-support-shared.md)]
