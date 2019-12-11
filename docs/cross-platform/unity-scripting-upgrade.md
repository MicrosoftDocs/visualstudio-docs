---
title: "Using .NET 4.x in Unity"
author: therealjohn
ms.author: johmil
ms.date: "08/29/2018"
ms.topic: "conceptual"
ms.assetid: E2C9420F-A5D5-4472-9020-2B63FB27A133
ms.technology: vs-unity-tools
ms.workload:
  - "unity"
---
# Using .NET 4.x in Unity

C# and .NET, the technologies underlying Unity scripting, have continued to receive updates since Microsoft originally released them in 2002. But Unity developers may not be aware of the steady stream of new features added to the C# language and .NET Framework. That's because before Unity 2017.1, Unity has been using a .NET 3.5 equivalent scripting runtime, missing years of updates.

With the release of Unity 2017.1, Unity introduced an experimental version of its scripting runtime upgraded to a .NET 4.6, C# 6 compatible version. In Unity 2018.1, the .NET 4.x equivalent runtime is no longer considered experimental, while the older .NET 3.5 equivalent runtime is now considered to be the legacy version. And with the release of Unity 2018.3, Unity is projecting to make the upgraded scripting runtime the default selection, and to update even further to C# 7. For more information and the latest updates on this roadmap, read Unity's [blog post](https://blogs.unity3d.com/2018/07/11/scripting-runtime-improvements-in-unity-2018-2/) or visit their [Experimental Scripting Previews forum](https://forum.unity.com/forums/experimental-scripting-previews.107/). In the meantime, check out the sections below to learn more about the new features available now with the .NET 4.x scripting runtime.

## Prerequisites

* [Unity 2017.1 or above](https://unity3d.com/) (2018.2 recommended)
* [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download)

## Enabling the .NET 4.x scripting runtime in Unity

To enable the .NET 4.x scripting runtime, take the following steps:

1. Open PlayerSettings in the Unity Inspector by selecting **Edit > Project Settings > Player**.

1. Under the **Configuration** heading, click the **Scripting Runtime Version** dropdown and select **.NET 4.x Equivalent**. You will be prompted to restart Unity.

![Select .NET 4.x equivalent](media/vstu_scripting-runtime-version.png)

## Choosing between .NET 4.x and .NET Standard 2.0 profiles

Once you've switched to the .NET 4.x equivalent scripting runtime, you can specify the **Api Compatibility Level** using the dropdown menu in the PlayerSettings (**Edit > Project Settings > Player**). There are two options:

* **.NET Standard 2.0**. This profile matches the [.NET Standard 2.0 profile](https://github.com/dotnet/standard/blob/master/docs/versions/netstandard2.0.md) published by the .NET Foundation. Unity recommends .NET Standard 2.0 for new projects. It's smaller than .NET 4.x, which is advantageous for size-constrained platforms. Additionally, Unity has committed to supporting this profile across all platforms that Unity supports.

* **.NET 4.x**. This profile provides access to the latest .NET 4 API. It includes all of the code available in the .NET Framework class libraries and supports .NET Standard 2.0 profiles as well. Use the .NET 4.x profile if your project requires part of the API not included in the .NET Standard 2.0 profile. However, some parts of this API may not be supported on all of Unity's platforms.

You can read more about these options in Unity's [blog post](https://blogs.unity3d.com/2018/03/28/updated-scripting-runtime-in-unity-2018-1-what-does-the-future-hold/).

### Adding assembly references when using the .NET 4.x Api Compatibility Level

When using the .NET Standard 2.0 setting in the **Api Compatibility Level** dropdown, all assemblies in the API profile are referenced and usable. However, when using the larger .NET 4.x profile, some of the assemblies that Unity ships with aren't referenced by default. To use these APIs, you must manually add an assembly reference. You can view the assemblies Unity ships with in the **MonoBleedingEdge/lib/mono** directory of your Unity editor installation:

![MonoBleedingEdge directory](media/vstu_monobleedingedge.png)

For example, if you're using the .NET 4.x profile and want to use `HttpClient`, you must add an assembly reference for System.Net.Http.dll. Without it, the compiler will complain that you're missing an assembly reference:

![missing assembly reference](media/vstu_missing-reference.png)

Visual Studio regenerates .csproj and .sln files for Unity projects each time they're opened. As a result, you cannot add assembly references directly in Visual Studio because they'll be lost upon reopening the project. Instead, a special text file named **mcs.rsp** must be used:

1. Create a new text file named **mcs.rsp** in your Unity project's root **Assets** directory.

1. On the first line in the empty text file, enter: `-r:System.Net.Http.dll` and then save the file. You can replace "System.Net.Http.dll" with any included assembly that might be missing a reference.

1. Restart the Unity editor.

## Taking advantage of .NET compatibility

In addition to new C# syntax and language features, the .NET 4.x scripting runtime gives Unity users access to a huge library of .NET packages that are incompatible with the legacy .NET 3.5 scripting runtime.

### Add packages from NuGet to a Unity project

[NuGet](https://www.nuget.org/) is the package manager for .NET. NuGet is integrated into Visual Studio. However, Unity projects require a special process to add NuGet packages. This is because when you open a project in Unity, its Visual Studio project files are regenerated, undoing necessary configurations. To add a package from NuGet to your Unity project do the following:

1. Browse NuGet to locate a compatible package you'd like to add (.NET Standard 2.0 or .NET 4.x). This example will demonstrate adding [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/), a popular package for working with JSON, to a .NET Standard 2.0 project.

1. Click the **Download** button:

    ![download button](media/vstu_nuget-download.png)

1. Locate the downloaded file and change the extension from **.nupkg** to **.zip**.

1. Within the zip file, navigate to the **lib/netstandard2.0** directory and copy the **Newtonsoft.Json.dll** file.

1. In your Unity project's root **Assets** folder, create a new folder named **Plugins**. Plugins is a special folder name in Unity. See the [Unity documentation](https://docs.unity3d.com/Manual/Plugins.html) for more information.

1. Paste the **Newtonsoft.Json.dll** file into your Unity project's **Plugins** directory.

1. Create a file named **link.xml** in your Unity project's **Assets** directory and add the following XML.  This will ensure Unity's bytecode stripping process does not remove necessary data when exporting to an IL2CPP platform.  While this step is specific to this library, you may run into problems with other libraries that use Reflection in similar ways.  For more information, please see [Unity's docs](https://docs.unity3d.com/Manual/IL2CPP-BytecodeStripping.html) on this topic.

    ```xml
    <linker>
      <assembly fullname="System.Core">
        <type fullname="System.Linq.Expressions.Interpreter.LightLambda" preserve="all" />
      </assembly>
    </linker>
    ```

With everything in place, you can now use the Json.NET package.

```csharp
using Newtonsoft.Json;
using UnityEngine;

public class JSONTest : MonoBehaviour
{
    class Enemy
    {
        public string Name { get; set; }
        public int AttackDamage { get; set; }
        public int MaxHealth { get; set; }
    }
    private void Start()
    {
        string json = @"{
            'Name': 'Ninja',
            'AttackDamage': '40'
            }";

        var enemy = JsonConvert.DeserializeObject<Enemy>(json);

        Debug.Log($"{enemy.Name} deals {enemy.AttackDamage} damage.");
        // Output:
        // Ninja deals 40 damage.
    }
}
```

This is a simple example of using a library which has no dependencies. When NuGet packages rely on other NuGet packages, you would need to download these dependencies manually and add them to the project in the same way.

## New syntax and language features

Using the updated scripting runtime gives Unity developers access to C# 6 and a host of new language features and syntax.

### Auto-property initializers

In Unity's .NET 3.5 scripting runtime, the auto-property syntax makes it easy to quickly define uninitialized properties, but initialization has to happen elsewhere in your script. Now with the .NET 4.x runtime, it's possible to initialize auto-properties in the same line:

```csharp
// .NET 3.5
public int Health { get; set; } // Health has to be initialized somewhere else, like Start()

// .NET 4.x
public int Health { get; set; } = 100;
```

### String interpolation

With the older .NET 3.5 runtime, string concatenation required awkward syntax. Now with the .NET 4.x runtime, the [`$` string interpolation](https://docs.microsoft.com/dotnet/csharp/language-reference/tokens/interpolated) feature allows expressions to be inserted into strings in a more direct and readable syntax:

```csharp
// .NET 3.5
Debug.Log(String.Format("Player health: {0}", Health)); // or
Debug.Log("Player health: " + Health);

// .NET 4.x
Debug.Log($"Player health: {Health}");
```

### Expression-bodied members

With the newer C# syntax available in the .NET 4.x runtime, [lambda expressions](https://docs.microsoft.com/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions) can replace the body of functions to make them more succinct:

```csharp
// .NET 3.5
private int TakeDamage(int amount)
{
    return Health -= amount;
}

// .NET 4.x
private int TakeDamage(int amount) => Health -= amount;
```

You can also use expression-bodied members in read-only properties:

```csharp
// .NET 4.x
public string PlayerHealthUiText => $"Player health: {Health}";
```

### Task-based Asynchronous Pattern (TAP)

[Asynchronous programming](https://docs.microsoft.com/dotnet/csharp/async) allows time consuming operations to take place without causing your application to become unresponsive. This functionality also allows your code to wait for time consuming operations to finish before continuing with code that depends on the results of these operations. For example, you could wait for a file to load or a network operation to complete.

In Unity, asynchronous programming is typically accomplished with [coroutines](https://docs.unity3d.com/Manual/Coroutines.html). However, since C# 5, the preferred method of asynchronous programming in .NET development has been the [Task-based Asynchronous Pattern (TAP)](https://docs.microsoft.com/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap) using the `async` and `await` keywords with [System.Threading.Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task). In summary, in an `async` function you can `await` a task's completion without blocking the rest of your application from updating:

```csharp
// Unity coroutine
using UnityEngine;
public class UnityCoroutineExample : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitOneSecond());
        DoMoreStuff(); // This executes without waiting for WaitOneSecond
    }
    private IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Finished waiting.");
    }
}
```

```csharp
// .NET 4.x async-await
using UnityEngine;
using System.Threading.Tasks;
public class AsyncAwaitExample : MonoBehaviour
{
    private async void Start()
    {
        Debug.Log("Wait.");
        await WaitOneSecondAsync();
        DoMoreStuff(); // Will not execute until WaitOneSecond has completed
    }
    private async Task WaitOneSecondAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        Debug.Log("Finished waiting.");
    }
}
```

TAP is a complex subject, with Unity-specific nuances developers should consider. As a result, TAP isn't a universal replacement for coroutines in Unity; however, it is another tool to leverage. The scope of this feature is beyond this article, but some general best practices and tips are provided below.

#### Getting started reference for TAP with Unity

These tips can help you get started with TAP in Unity:

* Asynchronous functions intended to be awaited should have the return type [`Task`](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) or [`Task<TResult>`](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1).
* Asynchronous functions that return a task should have the suffix **"Async"** appended to their names. The "Async" suffix helps indicate that a function should always be awaited.
* Only use the `async void` return type for functions that fire off async functions from traditional synchronous code. Such functions cannot themselves be awaited and shouldn't have the "Async" suffix in their names.
* Unity uses the UnitySynchronizationContext to ensure async functions run on the main thread by default. The Unity API isn't accessible outside of the main thread.
* It's possible to run tasks on background threads with methods like [`Task.Run`](https://msdn.microsoft.com/library/hh195051.aspx) and [`Task.ConfigureAwait(false)`](https://msdn.microsoft.com/library/system.threading.tasks.task.configureawait.aspx). This technique is useful for offloading expensive operations from the main thread to enhance performance. However, using background threads can lead to problems that are difficult to debug, such as [race conditions](https://wikipedia.org/wiki/Race_condition).
* The Unity API isn't accessible outside the main thread.
* Tasks that use threads aren't supported on Unity WebGL builds.

#### Differences between coroutines and TAP

There are some important differences between coroutines and TAP / async-await:

* Coroutines cannot return values, but `Task<TResult>` can.
* You cannot put a `yield` in a try-catch statement, making error handling difficult with coroutines. However, try-catch works with TAP.
* Unity's coroutine feature isn't available in classes that don't derive from MonoBehaviour. TAP is great for asynchronous programming in such classes.
* At this point, Unity doesn't suggest TAP as a wholesale replacement of coroutines. Profiling is the only way to know the specific results of one approach versus the other for any given project.

> [!NOTE]
> As of Unity 2018.2, debugging async methods with break points isn't fully supported; however, [this functionality is expected in Unity 2018.3](https://twitter.com/jbevain/status/900043560665235456).

### nameof operator

The `nameof` operator gets the string name of a variable, type, or member. Some cases where `nameof` comes in handy are logging errors, and getting the string name of an enum:

```csharp
// Get the string name of an enum:
enum Difficulty {Easy, Medium, Hard};
private void Start()
{
    Debug.Log(nameof(Difficulty.Easy));
    RecordHighScore("John");
    // Output:
    // Easy
    // playerName
}
// Validate parameter:
private void RecordHighScore(string playerName)
{
    Debug.Log(nameof(playerName));
    if (playerName == null) throw new ArgumentNullException(nameof(playerName));
}
```

### Caller info attributes

[Caller info attributes](https://docs.microsoft.com/dotnet/csharp/programming-guide/concepts/caller-information) provide information about the caller of a method. You must provide a default value for each parameter you want to use with a Caller Info attribute:

```csharp
private void Start ()
{
    ShowCallerInfo("Something happened.");
}
public void ShowCallerInfo(string message,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
{
    Debug.Log($"message: {message}");
    Debug.Log($"member name: {memberName}");
    Debug.Log($"source file path: {sourceFilePath}");
    Debug.Log($"source line number: {sourceLineNumber}");
}
// Output:
// Something happened
// member name: Start
// source file path: D:\Documents\unity-scripting-upgrade\Unity Project\Assets\CallerInfoTest.cs
// source line number: 10
```

### Using static

[Using static](https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/using-static) allows you to use static functions without typing its class name. With using static, you can save space and time if you need to use several static functions from the same class:

```csharp
// .NET 3.5
using UnityEngine;
public class Example : MonoBehaviour
{
    private void Start ()
    {
        Debug.Log(Mathf.RoundToInt(Mathf.PI));
        // Output:
        // 3
    }
}
```

```csharp
// .NET 4.x
using UnityEngine;
using static UnityEngine.Mathf;
public class UsingStaticExample: MonoBehaviour
{
    private void Start ()
    {
        Debug.Log(RoundToInt(PI));
        // Output:
        // 3
    }
}
```

## IL2CPP Considerations

When exporting your game to platforms like iOS, Unity will use its IL2CPP engine to "transpile" IL to C++ code which is then compiled using the native compiler of the target platform. In this scenario, there are several .NET features which are not supported, such as parts of Reflection, and usage of the `dynamic` keyword. While you can control using these features in your own code, you may run into problems using 3rd party DLLs and SDKs which were not written with Unity and IL2CPP in mind. For more information on this topic, please see the [Scripting Restrictions](https://docs.unity3d.com/Manual/ScriptingRestrictions.html) docs on Unity's site.

Additionally, as mentioned in the Json.NET example above, Unity will attempt to strip out unused code during the IL2CPP export process.  While this typically isn't an issue, with libraries that use Reflection, it can accidentally strip out properties or methods that will be called at run time that can't be determined at export time.  To fix these issues, add a **link.xml** file to your project which contains a list of assemblies and namespaces to not run the stripping process against.  For full details, please see [Unity's docs on bytecode stripping](https://docs.unity3d.com/Manual/IL2CPP-BytecodeStripping.html).

## .NET 4.x Sample Unity Project

The sample contains examples of several .NET 4.x features. You can download the project or view the source code on [GitHub](https://github.com/Microsoft/unity-scripting-upgrade).

## Additional resources

* [Unity Blog - Scripting Runtime Improvements in Unity 2018.2](https://blogs.unity3d.com/2018/07/11/scripting-runtime-improvements-in-unity-2018-2/)
* [History of C#](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history)
* [What's New in C# 6](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-6)
* [Asynchronous programming in Unity, Using Coroutine and TAP](https://blogs.msdn.microsoft.com/appconsult/2017/09/01/unity-coroutine-tap)
* [Async-Await Instead of Coroutines in Unity 2017](http://www.stevevermeulen.com/index.php/2017/09/using-async-await-in-unity3d-2017/)
* [Unity Forum - Experimental Scripting Previews](https://forum.unity.com/forums/experimental-scripting-previews.107/)
