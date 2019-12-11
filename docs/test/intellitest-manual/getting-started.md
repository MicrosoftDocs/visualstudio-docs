---
title: "Introduction to IntelliTest"
ms.date: 05/02/2017
ms.topic: conceptual
helpviewer_keywords:
  - "IntelliTest, Get started"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Get started with Microsoft IntelliTest

* If this is your first time with IntelliTest:
  * watch the [Channel 9 video](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Intellitest)
  * read this [overview on MSDN Magazine](https://msdn.microsoft.com/magazine/dn904672.aspx)
  * read our [documentation](../../test/generate-unit-tests-for-your-code-with-intellitest.md)
* Ask your questions on [Stack Overflow](https://stackoverflow.com/questions/tagged/intellitest)
* Read the rest of this reference manual
* Print this page for quick reference

## Important attributes

* [PexClass](attribute-glossary.md#pexclass) marks a type containing **PUT**
* [PexMethod](attribute-glossary.md#pexmethod) marks a **PUT**
* [PexAssumeNotNull](attribute-glossary.md#pexassumenotnull) marks a non-null parameter

```csharp
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

```csharp
[assembly: PexAssemblyUnderTest("MyAssembly")] // also instruments "MyAssembly"
[assembly: PexInstrumentAssembly("Lib")]
```

## <a name="helper-classes"></a> Important static helper classes

* [PexAssume](static-helper-classes.md#pexassume) evaluates assumptions (input filtering)
* [PexAssert](static-helper-classes.md#pexassert) evaluates assertions
* [PexChoose](static-helper-classes.md#pexchoose) generates new choices (additional inputs)
* [PexObserve](static-helper-classes.md#pexobserve) logs live values to the generated tests

```csharp
[PexMethod]
void StaticHelpers(Foo target) {
    PexAssume.IsNotNull(target);

    int i = PexChoose.Value<int>("i");
    string result = target.Bar(i);

    PexObserve.ValueForViewing<string>("result", result);
    PexAssert.IsNotNull(result);
}
```

## Got feedback?

Post your ideas and feature requests on [Developer Community](https://developercommunity.visualstudio.com/content/idea/post.html?space=8).
