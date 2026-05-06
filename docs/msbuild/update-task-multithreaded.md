---
title: Update an MSBuild custom task for multithreaded builds
description: Learn how to migrate an MSBuild custom task to work in the multithreaded build model using IMultiThreadableTask, TaskEnvironment, and AbsolutePath.
ms.date: 04/03/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
ms.custom: doc-kit-assisted, awp-ai
monikerRange: visualstudio
#customer intent: As a developer, I want to update an existing task to work in the MSBuild multithreaded build model.
---

# Update an MSBuild task to work in multithreaded mode

MSBuild 18.6 introduces the capability to build in parallel within the same process. To opt in to this mode, pass the `-mt` command-line switch. Previous versions of MSBuild supported parallel builds, but builds were done in separate processes. This change has some impacts to how you author tasks. Whereas previously, tasks would run in a separate process, now all multithread-enabled tasks run in the same process. While most logic doesn't need to change, there are some process-level constructs that need to be handled more carefully. Process-level constructs include the current working directory, environment variables, and process start info (`ProcessStartInfo`).

To support these changes, MSBuild 18.6 introduces the `IMultiThreadableTask` interface (in `Microsoft.Build.Framework`) and the `TaskEnvironment` class. `TaskEnvironment` includes a `ProjectDirectory` property and methods such as `GetAbsolutePath()`, `GetEnvironmentVariable()`, `SetEnvironmentVariable()`, and `GetProcessStartInfo()`.

The `IMultiThreadableTask` interface defines the contract for tasks that can run in-process in multithreaded builds:

```csharp
// Microsoft.Build.Framework
public interface IMultiThreadableTask : ITask
{
    TaskEnvironment TaskEnvironment { get; set; }
}
```

To migrate a task, implement `IMultiThreadableTask` alongside your existing `Task` base class and expose the `TaskEnvironment` property:

```csharp
public class MyTask : Task, IMultiThreadableTask
{
    // Initialize to Fallback so the task works safely outside the MSBuild engine (for example, in unit tests).
    public TaskEnvironment TaskEnvironment { get; set; } = TaskEnvironment.Fallback;
    // ...
}
```

Tasks that implement `IMultiThreadableTask` can run in-process. All such tasks must also carry the `[MSBuildMultiThreadableTask]` attribute — the attribute is the marker MSBuild uses to opt the task into in-process execution. Before adding the attribute, confirm that the task doesn't have any dependencies on process-level constructs like the current working directory or the environment, and that its code is thread-safe. Pay particular attention to ensure thread-safe access to static variables, as these are shared among all task instances and might be accessed or modified by different instances of the task that are also running in the same process.

## Example task: BuildCommentTask

The following example `AddBuildCommentTask` is used throughout this article to illustrate the migration process. This task prepends a build comment to text files. By default, it writes plain text; the optional `CommentPrefix` and `CommentSuffix` properties let callers wrap the comment in language-appropriate syntax (for example, `//` for C#, `<!--` and `-->` for XML, `#` for Python or YAML):

```csharp
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace BuildCommentTask
{
    public class AddBuildCommentTask : Microsoft.Build.Utilities.Task
    {
        private static int ModifiedFileCount = 0;

        // Callers are responsible for passing only text files in TargetFiles,
        // and for setting CommentPrefix/CommentSuffix to match the file type.
        [Required]
        public ITaskItem[] TargetFiles { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        // Optional CommentPrefix and CommentSuffix wrap the comment in
        // language-appropriate syntax, e.g., "// " for C# or "# " for Python.
        // Include any desired spacing in the prefix or suffix value.
        public string CommentPrefix { get; set; } = "";
        public string CommentSuffix { get; set; } = "";

        public override bool Execute()
        {
            string disableComments = Environment.GetEnvironmentVariable("DISABLE_BUILD_COMMENTS");
            if (!string.IsNullOrEmpty(disableComments))
            {
                Log.LogMessage(MessageImportance.Normal, "Build comments disabled via environment variable.");
                return true;
            }

            string buildDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string commentPattern = $@"^{Regex.Escape(CommentPrefix)}\s*Build Date:.*Version:.*{Regex.Escape(CommentSuffix)}$";

            foreach (var item in TargetFiles)
            {
                var filePath = item.ItemSpec;
                try
                {
                    string[] originalLines = File.ReadAllLines(filePath);

                    if (originalLines.Length > 0 && Regex.IsMatch(originalLines[0], commentPattern))
                    {
                        Log.LogMessage(MessageImportance.Low, $"Skipped (already annotated): {filePath}");
                        continue;
                    }

                    ModifiedFileCount++;
                    string comment = $"{CommentPrefix}Build Date: {buildDate}, Version: {VersionNumber}, File #: {ModifiedFileCount}{CommentSuffix}";
                    File.WriteAllLines(filePath, new[] { comment }.Concat(originalLines));
                    Log.LogMessage(MessageImportance.High, $"Added build comment to: {filePath}");
                }
                catch (Exception ex)
                {
                    Log.LogError($"Failed to process {filePath}: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
    }
}
```

A project file might invoke this task for different file types, passing the appropriate comment syntax for each:

```xml
<!-- Stamp generated text files with plain text (no comment prefix) -->
<AddBuildCommentTask
    TargetFiles="@(GeneratedFiles)"
    VersionNumber="$(Version)" />

<!-- Stamp C# source files with // comments -->
<AddBuildCommentTask
    TargetFiles="@(Compile)"
    VersionNumber="$(Version)"
    CommentPrefix="// " />

<!-- Stamp XML content files with <!-- --> comments -->
<AddBuildCommentTask
    TargetFiles="@(Content -> WithMetadataValue('Extension', '.xml'))"
    VersionNumber="$(Version)"
    CommentPrefix="&lt;!-- "
    CommentSuffix=" --&gt;" />
```

This task has four thread-safety issues that need to be addressed for multithreaded builds:

1. **Relative paths**: `File.ReadAllLines` and `File.WriteAllLines` use `item.ItemSpec` directly, which might be a relative path. In multithreaded mode, the process working directory isn't guaranteed to be the project directory.
2. **Static field**: `ModifiedFileCount` is a `static` field shared across all instances, which causes data races when multiple builds run concurrently.
3. **Environment variable**: `Environment.GetEnvironmentVariable()` reads from the process-level environment, which is shared across all concurrent builds. In multithreaded mode, one build's environment changes can bleed into another.
4. **No TaskEnvironment usage**: The task doesn't use `TaskEnvironment` for path resolution or environment access, so it can't reliably operate in multithreaded mode.

> [!IMPORTANT]
> The multithreaded build mode is currently available only for CLI (`dotnet build` and `MSBuild.exe`) builds. Visual Studio MSBuild builds do not yet support multithreaded execution in-process. In Visual Studio, all task execution continues to run out of process. Visual Studio integration is planned for a future release.

## Prerequisites

- MSBuild 18.6 or later.
- Enable multithreaded task execution with the `-mt` command-line switch:

  ```console
  dotnet build -mt
  ```

  For more information about the `-mt` switch, see [MSBuild command-line reference](msbuild-command-line-reference.md).

## Plan the migration

Review your task code for the following issues:

1. Check the task code and identify any usage of relative paths. Check all input and file I/O.
1. Check for any uses of environment variables.
1. Check for any `ProcessStartInfo` API usage.
1. Check any static fields or data structures and use standard methods to make them thread-safe.
1. If none of the above apply, consider adding the attribute only.
1. Consider special requirements for supporting earlier versions of MSBuild. See [Support earlier versions of MSBuild](#support-earlier-versions-of-msbuild).

> [!TIP]
> MSBuild provides a Roslyn analyzer that can detect problematic API usage in your task code. Enable the analyzer in your task project to automatically flag calls to `Environment.GetEnvironmentVariable()`, `Environment.CurrentDirectory`, relative path usage, and other patterns that need to be updated for multithreaded builds.

## API replacement quick reference

The following table summarizes the .NET APIs that you should replace and their `TaskEnvironment` equivalents:

| .NET API to avoid | Level | Replacement |
|---|---|---|
| `Path.GetFullPath(path)` | ERROR | See note following this table |
| `File.*` with relative paths | ERROR | Resolve with `TaskEnvironment.GetAbsolutePath()` first |
| `Directory.*` with relative paths | ERROR | Resolve with `TaskEnvironment.GetAbsolutePath()` first |
| `Environment.GetEnvironmentVariable()` | ERROR | `TaskEnvironment.GetEnvironmentVariable()` |
| `Environment.SetEnvironmentVariable()` | ERROR | `TaskEnvironment.SetEnvironmentVariable()` |
| `Environment.CurrentDirectory` | ERROR | `TaskEnvironment.ProjectDirectory` |
| `new ProcessStartInfo()` | ERROR | `TaskEnvironment.GetProcessStartInfo()` |
| `Process.Start()` | ERROR | Use `ToolTask` or `TaskEnvironment.GetProcessStartInfo()` |
| Static fields | WARNING | Use instance fields or thread-safe collections |

> [!NOTE]
> `Path.GetFullPath(path)` does two things: it converts a relative path to an absolute path, and it produces a **canonical** form of the path (resolving `.` and `..` segments). These need to be handled separately:
>
> - **Absolute path only**: Use `TaskEnvironment.GetAbsolutePath(path)`. This is sufficient for most file I/O operations where you're passing the path directly to .NET APIs.
> - **Canonical path**: If you rely on the canonical form — for example, when using a path as a cache or dictionary key — use `Path.GetFullPath(TaskEnvironment.GetAbsolutePath(path))` to get a fully resolved, canonical absolute path.

## Mark the task with the attribute

All tasks that participate in multithreaded builds must be marked with the `[MSBuildMultiThreadableTask]` attribute. This is the signal MSBuild uses to identify tasks that are safe to run in-process.

```csharp
[MSBuildMultiThreadableTask]
public class MyTask : Task
{
    public override bool Execute()
    {
        // Task logic that doesn't depend on process-level state
        return true;
    }
}
```

If your task is already thread-safe and doesn't use any process-level APIs (current working directory, environment variables, `ProcessStartInfo`), the attribute alone is all you need. The task continues to inherit from `Task` (or `ToolTask`) without any other changes.

If your task does need to replace process-level API calls — for example, to resolve relative paths or read environment variables safely — also implement `IMultiThreadableTask`. This gives your task access to the `TaskEnvironment` property. The attribute remains required in both cases; `IMultiThreadableTask` is an additional step that unlocks the `TaskEnvironment` API.

> [!NOTE]
> MSBuild detects the `MSBuildMultiThreadableTaskAttribute` by namespace and name only, ignoring the defining assembly. This means you can define the attribute yourself in your own code (see [Support earlier versions of MSBuild](#support-earlier-versions-of-msbuild)) and MSBuild still recognizes it.

> [!NOTE]
> The `MSBuildMultiThreadableTaskAttribute` is non-inheritable (`Inherited = false`). Each task class must explicitly declare the attribute to be recognized as multithreadable. Inheriting from a class that has the attribute doesn't automatically make the derived class multithreadable.

### Initialize TaskEnvironment to Fallback

When implementing `IMultiThreadableTask`, initialize the `TaskEnvironment` property to `TaskEnvironment.Fallback`:

```csharp
public TaskEnvironment TaskEnvironment { get; set; } = TaskEnvironment.Fallback;
```

MSBuild sets this property before calling `Execute()` in a normal build. The `Fallback` default ensures the task works correctly in other hosting scenarios — such as unit tests or custom build orchestration tools — where MSBuild isn't present to set the property. Without it, accessing `TaskEnvironment` outside the engine would throw a null reference exception.

If you need to support MSBuild versions earlier than 18.6 that don't include `TaskEnvironment.Fallback`, initialize the property to `null` instead and guard any `TaskEnvironment` calls with a null check. See [Support earlier versions of MSBuild](#support-earlier-versions-of-msbuild) for more options.

## Update paths and file I/O

A task often accepts inputs, such as item lists in MSBuild, which if they are files, might be in the form of relative paths.

Relative paths are always relative to the current working directory of the process, but because the task now executes in-process, the working directory might not be the same as it was when the task ran in its own process. Such paths are relative to the project directory. The `TaskEnvironment` includes a `ProjectDirectory` property and a `GetAbsolutePath()` method that you can use to resolve relative paths to absolute paths.

### The AbsolutePath type

`AbsolutePath` is a readonly struct in `Microsoft.Build.Framework` that represents a validated absolute file path. Key members include:

```csharp
public readonly struct AbsolutePath : IEquatable<AbsolutePath>
{
    public string Value { get; }
    public string OriginalValue { get; }
    public AbsolutePath(string path);  // Validates Path.IsPathRooted
    public AbsolutePath(string path, AbsolutePath basePath);
    public static implicit operator string(AbsolutePath path);
}
```

The `AbsolutePath` constructor validates that the provided path is rooted. You can also construct an `AbsolutePath` by providing a relative path and a base path. The implicit conversion to `string` means you can pass an `AbsolutePath` directly to any API that expects a `string` path.

The `OriginalValue` property preserves the original path string as it was passed in before resolution. This is useful when you need to keep relative paths in task outputs or log messages. For example, a task that logs which files it processed may use `OriginalValue` in its log messages so that paths in output remain relative and readable, while still using the resolved `Value` (or the implicit `string` conversion) for actual file I/O.

Use `TaskEnvironment.GetAbsolutePath()` to resolve item paths:

**Before:**

```csharp
var filePath = item.ItemSpec;
string[] originalLines = File.ReadAllLines(filePath);
File.WriteAllLines(filePath, new[] { comment }.Concat(originalLines));
```

**After:**

```csharp
AbsolutePath filePath = TaskEnvironment.GetAbsolutePath(item.ItemSpec);
string[] originalLines = File.ReadAllLines(filePath);  // AbsolutePath converts to string implicitly
File.WriteAllLines(filePath, new[] { comment }.Concat(originalLines));
// Use filePath.OriginalValue in log messages to preserve the relative path as written by the user
Log.LogMessage(MessageImportance.High, $"Added build comment to: {filePath.OriginalValue}");
```

### Handle file contention in parallel builds

File contention can occur whenever multiple tasks run in parallel and access the same file — this applies to both the traditional multi-process model and the newer in-process multithreaded mode. In both cases, the same file might be accessed concurrently when:

- The same file appears in multiple sub-project builds (for example, a shared configuration file or a linked source file).
- A task reads and writes a file that another task instance is also processing.

Convenience methods like `File.ReadAllLines` and `File.WriteAllLines` don't provide explicit control over file locking. When concurrent access is possible, use `FileStream` with explicit sharing and locking:

```csharp
using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
{
    // FileShare.None ensures exclusive access — other attempts
    // to open this file will throw IOException until the stream
    // is disposed.
    using var reader = new StreamReader(stream);
    string content = reader.ReadToEnd();

    stream.SetLength(0); // Truncate before rewriting.
    stream.Position = 0;

    using var writer = new StreamWriter(stream);
    writer.WriteLine(comment);
    writer.Write(content);
}
```

Key guidelines for file I/O in multithreaded tasks:

- **Use `FileShare.None` for read-modify-write operations.** This prevents another task from reading stale content while you're updating the file.
- **Catch `IOException` and consider retrying.** When another task or process holds a lock, your open attempt throws `IOException`. A short retry with backoff is often appropriate.
- **Avoid holding locks on multiple files at once.** If two tasks each lock one file and then try to lock the other, you get a deadlock. If you must operate on multiple files, lock them in a consistent order (for example, sorted by full path).
- **Keep locks as short as possible.** Open the file, read, modify, write, and close in one operation. Don't hold a file lock while doing unrelated work.

The preceding example is one approach. For general guidance on thread-safe file I/O in .NET, see [FileStream class](/dotnet/fundamentals/runtime-libraries/system-io-filestream), [FileShare enum](/dotnet/api/system.io.fileshare), and [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices).

> [!NOTE]
> `TaskEnvironment` itself is not thread-safe. This only matters if your task internally spawns its own threads (for example, using `Parallel.ForEach` or `Task.Run`). Most tasks don't do this — they implement `Execute()` linearly and let MSBuild handle parallelism across task instances. If your task does create its own threads, capture values from `TaskEnvironment` into local variables before spawning them, rather than accessing `TaskEnvironment` from multiple threads concurrently.

## Update environment variables

> [!NOTE]
> Using environment variables to pass data between tasks or projects is not the recommended MSBuild pattern. The preferred approach is to use MSBuild properties and items, which are explicitly scoped, trackable, and work correctly across all build modes. If you're writing a new task, use task parameters (`[Required]` or optional properties) rather than environment variables to receive inputs and return outputs.
>
> The guidance in this section is for migrating existing tasks that already rely on environment variables. If you have the opportunity to refactor, consider moving that data to properties and items instead.

In the multi-process model, the original environment variables for a process are read by the first task to execute in the project. That task can read or write the environment variables, and subsequent tasks that run in the same project see the modified values.

To preserve this behavior in-process, MSBuild's `TaskEnvironment` captures the original environment variable table and allows read and write operations on that per-project table. The same table is reused by later tasks in the same project, so existing patterns continue to work correctly as long as tasks are updated to use `TaskEnvironment` rather than the process-level `Environment` APIs.

> [!NOTE]
> This introduces a subtle behavioral difference compared to the multi-process model. In the multi-process model, a worker process can handle multiple projects, so environment variable changes made by one project's tasks are visible to tasks in other projects running in the same process. In multithreaded mode, `TaskEnvironment` is scoped strictly to a single project — changes made by tasks in one project are not visible to tasks in another. If your task relies on environment variable changes being visible across project boundaries, that behavior will not carry over to multithreaded mode and you should refactor to use MSBuild properties instead.

Replace all calls to `Environment` get and set methods with the equivalent methods on `TaskEnvironment` throughout the task.

**Before** (from `BuildCommentTask`):

```csharp
string disableComments = Environment.GetEnvironmentVariable("DISABLE_BUILD_COMMENTS");
```

**After:**

```csharp
string disableComments = TaskEnvironment.GetEnvironmentVariable("DISABLE_BUILD_COMMENTS");
```

The same pattern applies to setting environment variables and enumerating all variables:

```csharp
// Set a variable in the task's isolated environment table
TaskEnvironment.SetEnvironmentVariable("BUILD_OUTPUT", outputPath);

// Enumerate all environment variables visible to the task
IReadOnlyDictionary<string, string> allVars = TaskEnvironment.GetEnvironmentVariables();
```

## Update ProcessStart API calls

Typically, if a task starts a process, you should use `ToolTask`, which handles everything for you. In cases where you're updating a task that calls `ProcessStartInfo` directly, use the `TaskEnvironment.GetProcessStartInfo()` method. This method returns a `ProcessStartInfo` that's configured with the correct working directory and environment variables for the task's project context.

**Before:**

```csharp
var startInfo = new ProcessStartInfo("mytool.exe")
{
    WorkingDirectory = ".",
    UseShellExecute = false
};
Process.Start(startInfo);
```

**After:**

```csharp
ProcessStartInfo startInfo = TaskEnvironment.GetProcessStartInfo();
startInfo.FileName = "mytool.exe";
startInfo.UseShellExecute = false;
Process.Start(startInfo);
```

> [!NOTE]
> If your task inherits from `ToolTask`, process start info is already handled for you. You only need to update tasks that create `ProcessStartInfo` directly.

## Update static fields and data structures to be thread-safe

Static fields require careful treatment when you migrate to multithreaded builds. Even in the multi-process model, static state doesn't always behave as expected. When MSBuild node reuse is enabled (the default), worker processes persist between builds, so static fields aren't reset between successive `dotnet build` invocations. A counter like `ModifiedFileCount` keeps incrementing across builds rather than starting fresh each time. Many task authors don't notice because builds run sequentially within each worker process and stale counters are a minor nuisance rather than a correctness issue.

Multithreaded mode adds a new dimension to this problem. Multiple builds can now share the same process and run tasks concurrently (especially with MSBuild Server, which is automatically enabled with multithreading). A static field is shared across all task instances in the process — not just within your build, but potentially across separate build invocations running concurrently. For example, two developers running `dotnet build` at the same time on a build server, or two terminal windows on the same machine, might share the same static state — and now those builds access it at the same time.

In the `BuildCommentTask` example, the static field `ModifiedFileCount` is shared across all instances:

**Before:**

```csharp
private static int ModifiedFileCount = 0;

// In Execute():
ModifiedFileCount++;
```

This code has two problems. First, the `++` operator isn't atomic — when multiple task instances run concurrently, two threads can read the same value and both write the same incremented result, causing lost counts. Second, because the field is static, it persists across builds and is shared between concurrent builds in the same process.

The following sections show two approaches for fixing these problems, from simplest to most correct.

### Approach 1: `Interlocked.Increment` — thread-safe but process-wide

The simplest fix is to make the increment atomic:

```csharp
private static int ModifiedFileCount = 0;

// In Execute():
int fileNumber = Interlocked.Increment(ref ModifiedFileCount);
```

`Interlocked.Increment` performs the read-increment-write as a single atomic operation, so no counts are lost. This approach solves the concurrency problem, but the counter is still shared across all builds in the process — including consecutive builds and concurrent builds. If two builds run concurrently, their file numbers interleave (Build A gets #1, #3, #5; Build B gets #2, #4, #6). Whether this is acceptable depends on whether your task requires per-build isolation. For a sequential file numbering counter like `ModifiedFileCount`, cross-build sharing is a correctness issue — use `RegisterTaskObject` instead (see Approach 2).

### Approach 2: `RegisterTaskObject` — build-scoped isolation

If your task needs static state that's shared across sub-projects within a single build invocation but isolated from other concurrent builds, use `IBuildEngine4.RegisterTaskObject` with `RegisteredTaskObjectLifetime.Build`. MSBuild manages the lifetime of the object — it's created on first use and cleaned up when the build ends.

First, define a simple thread-safe counter class:

```csharp
internal class FileCounter
{
    private int _count = 0;
    public int Next() => Interlocked.Increment(ref _count);
}
```

Then use a helper method with double-checked locking to get or create the counter:

```csharp
private static readonly object s_counterLock = new();

private FileCounter GetOrCreateCounter()
{
    const string key = "BuildCommentTask.FileCounter";

    var counter = BuildEngine4.GetRegisteredTaskObject(
        key, RegisteredTaskObjectLifetime.Build) as FileCounter;

    if (counter == null)
    {
        lock (s_counterLock)
        {
            counter = BuildEngine4.GetRegisteredTaskObject(
                key, RegisteredTaskObjectLifetime.Build) as FileCounter;

            if (counter == null)
            {
                counter = new FileCounter();
                BuildEngine4.RegisterTaskObject(
                    key, counter,
                    RegisteredTaskObjectLifetime.Build,
                    allowEarlyCollection: false);
            }
        }
    }
    return counter;
}
```

In `Execute()`:

```csharp
FileCounter counter = GetOrCreateCounter();
// ...
int fileNumber = counter.Next();
```

With this approach, each build invocation gets its own `FileCounter`. All sub-projects within the same build share the counter (sequential numbering), but a separate `dotnet build` running at the same time on the same machine gets a different counter. `RegisteredTaskObjectLifetime.Build` tells MSBuild to scope the object to the current build invocation and clean it up when the build ends.

### Choose the right approach

When deciding how to handle static state, start from this question: **is this data safe to share across all builds that might ever run in the same process, including consecutive builds and concurrent builds?**

MSBuild worker processes persist across invocations (node reuse is on by default), and an MSBuild process can potentially serve multiple solution builds over its lifetime — not just within a single `dotnet build` call. Don't assume that a process handles only one build.

Use these guidelines:

- **Retain the static field** only if the cached data is safe to access from multiple threads across different projects and across multiple builds without requiring invalidation between builds. For example, a cache of immutable data computed once from inputs that never change (such as assembly metadata loaded once at startup) might qualify.
- **Use `IBuildEngine4.RegisterTaskObject` with `RegisteredTaskObjectLifetime.Build`** when the state must be isolated per build invocation — for example, counters, accumulators, or caches that should reset between builds or not leak between concurrent builds. This is the preferred approach for most shared mutable state.
- **Use `System.Threading` primitives** (`Interlocked`, `ConcurrentDictionary`, `lock`, `ReaderWriterLockSlim`) to make any retained static state thread-safe, but remember that thread-safety alone does not provide build-level isolation. See [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices).

> [!TIP]
> The complete migration example later in this article uses the `RegisterTaskObject` approach to demonstrate build-scoped isolation.

## Complete migration example

The following code shows the fully migrated `AddBuildCommentTask` with all five changes applied:

1. Has the `[MSBuildMultiThreadableTask]` attribute, marking it for in-process execution.
1. Implements `IMultiThreadableTask` alongside the existing `Task` base class, and exposes the `TaskEnvironment` property.
1. Uses `TaskEnvironment.GetAbsolutePath()` for path resolution.
1. Uses `TaskEnvironment.GetEnvironmentVariable()` instead of `Environment.GetEnvironmentVariable()`.
1. Uses `IBuildEngine4.RegisterTaskObject` with `RegisteredTaskObjectLifetime.Build` to scope the file counter to the current build invocation, replacing the process-wide static counter.

```csharp
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace BuildCommentTask
{
    internal class FileCounter
    {
        private int _count = 0;
        public int Next() => Interlocked.Increment(ref _count);
    }

    [MSBuildMultiThreadableTask]
    public class AddBuildCommentTask : Task, IMultiThreadableTask
    {
        private static readonly object s_counterLock = new();

        public TaskEnvironment TaskEnvironment { get; set; } = TaskEnvironment.Fallback;

        // Callers are responsible for passing only text files in TargetFiles,
        // and for setting CommentPrefix/CommentSuffix to match the file type.
        [Required]
        public ITaskItem[] TargetFiles { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        // Optional CommentPrefix and CommentSuffix wrap the comment in
        // language-appropriate syntax, e.g., "// " for C# or "# " for Python.
        // Include any desired spacing in the prefix or suffix value.
        public string CommentPrefix { get; set; } = "";
        public string CommentSuffix { get; set; } = "";

        public override bool Execute()
        {
            string disableComments = TaskEnvironment.GetEnvironmentVariable("DISABLE_BUILD_COMMENTS");
            if (!string.IsNullOrEmpty(disableComments))
            {
                Log.LogMessage(MessageImportance.Normal, "Build comments disabled via environment variable.");
                return true;
            }

            FileCounter counter = GetOrCreateCounter();

            string buildDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string commentPattern = $@"^{Regex.Escape(CommentPrefix)}\s*Build Date:.*Version:.*{Regex.Escape(CommentSuffix)}$";

            foreach (var item in TargetFiles)
            {
                AbsolutePath filePath = TaskEnvironment.GetAbsolutePath(item.ItemSpec);

                try
                {
                    string[] originalLines = File.ReadAllLines(filePath);

                    if (originalLines.Length > 0 && Regex.IsMatch(originalLines[0], commentPattern))
                    {
                        Log.LogMessage(MessageImportance.Low, $"Skipped (already annotated): {filePath}");
                        continue;
                    }

                    int fileNumber = counter.Next();
                    string comment = $"{CommentPrefix}Build Date: {buildDate}, Version: {VersionNumber}, File #: {fileNumber}{CommentSuffix}";
                    File.WriteAllLines(filePath, new[] { comment }.Concat(originalLines));
                    Log.LogMessage(MessageImportance.High, $"Added build comment to: {filePath}");
                }
                catch (Exception ex)
                {
                    Log.LogError($"Failed to process {filePath}: {ex.Message}");
                    return false;
                }
            }
            return true;
        }

        private FileCounter GetOrCreateCounter()
        {
            const string key = "BuildCommentTask.FileCounter";

            var counter = BuildEngine4.GetRegisteredTaskObject(
                key, RegisteredTaskObjectLifetime.Build) as FileCounter;

            if (counter == null)
            {
                lock (s_counterLock)
                {
                    counter = BuildEngine4.GetRegisteredTaskObject(
                        key, RegisteredTaskObjectLifetime.Build) as FileCounter;

                    if (counter == null)
                    {
                        counter = new FileCounter();
                        BuildEngine4.RegisterTaskObject(
                            key, counter,
                            RegisteredTaskObjectLifetime.Build,
                            allowEarlyCollection: false);
                    }
                }
            }
            return counter;
        }
    }
}
```

## What happens to non-migrated tasks

Tasks that don't have the `[MSBuildMultiThreadableTask]` attribute or don't implement `IMultiThreadableTask` continue to work without any changes. MSBuild runs these tasks in a sidecar `TaskHost` process, which provides the same process-level isolation as earlier versions of MSBuild. This approach is slower because of the overhead of inter-process communication, but it's fully compatible with existing task code. Migration is optional for correctness—non-migrated tasks still produce correct results—but migrating improves build performance.

## Support earlier versions of MSBuild

If you update your custom task and then distribute it to others, your task supports clients using MSBuild 18.6 or later. To support clients on earlier versions of MSBuild, you have three options.

### Option 1: Maintain separate implementations

Build separate task assemblies for MSBuild 18.6+ and earlier versions. The MSBuild 18.6+ version implements `IMultiThreadableTask` and uses `TaskEnvironment`. The earlier version continues to use `Task` with process-level APIs.

### Option 2: Compatibility bridge

Define the `MSBuildMultiThreadableTaskAttribute` yourself in your task assembly. Because MSBuild detects the attribute by namespace and name only (ignoring the defining assembly), your self-defined attribute works in both old and new versions of MSBuild:

```csharp
namespace Microsoft.Build.Framework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class MSBuildMultiThreadableTaskAttribute : Attribute { }
}
```

When running on MSBuild 18.6 or later, MSBuild recognizes the attribute and runs the task in-process. When running on earlier versions, MSBuild ignores the unknown attribute and runs the task out-of-process as before.

### Option 3: Accept reduced performance

Make no changes to your task. MSBuild runs non-attributed tasks in a sidecar `TaskHost` process, which is slower but fully compatible. This option requires no code changes.

### Comparison of approaches

The following table compares the three approaches when running in multithreaded mode (`-mt`). In non-multithreaded mode, all tasks run out-of-process regardless of how they are marked.

| Approach | Maintenance | Performance (18.6+) | Performance (older) | TaskEnvironment access |
|---|---|---|---|---|
| Separate implementations | High | Full in-process | Full out-of-process | Yes (18.6+ version) |
| Compatibility bridge | Low | Full in-process | Full out-of-process | No (attribute-only) |
| No changes | None | Sidecar (slower) | Full out-of-process | No |

## Related content

- [MSBuild tasks](msbuild-tasks.md)
- [Create an MSBuild task](task-writing.md)
- [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices)
