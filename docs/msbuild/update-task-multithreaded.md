---
title: Update an MSBuild custom task for multithreaded builds
description: Learn how to migrate an MSBuild custom task to work in the multithreaded build model using IMultiThreadableTask, TaskEnvironment, and AbsolutePath.
ms.date: 04/03/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
ms.custom: doc-kit-assisted
monikerRange: visualstudio
#customer intent: As a developer, I want to update an existing task to work in the MSBuild multithreaded build model.
---

# Update an MSBuild task to work in multithreaded mode

MSBuild 18.0 introduces the capability to build in parallel within the same process. Previous versions of MSBuild supported parallel builds, but builds were done in separate processes. This change has some impacts to how you author tasks. Whereas previously, tasks would run in a separate process, now tasks run in the same process. While most logic doesn't need to change, there are some process-level constructs that need to be handled more carefully. Process-level constructs include the current working directory, environment variables, and process start info (`ProcessStartInfo`).

To support these changes, MSBuild 18.0 introduces the `IMultiThreadableTask` interface (in `Microsoft.Build.Framework`), the `MultiThreadableTask` abstract class (in `Microsoft.Build.Utilities`), and the `TaskEnvironment` class. `TaskEnvironment` includes a `ProjectDirectory` property and methods such as `GetAbsolutePath()`, `GetEnvironmentVariable()`, `SetEnvironmentVariable()`, and `GetProcessStartInfo()`.

The `IMultiThreadableTask` interface defines the contract for tasks that can run in-process in multithreaded builds:

```csharp
// Microsoft.Build.Framework
public interface IMultiThreadableTask : ITask
{
    ITaskEnvironment TaskEnvironment { get; set; }
}
```

The `MultiThreadableTask` abstract class (in `Microsoft.Build.Utilities`) provides a convenient base class that implements `IMultiThreadableTask` and extends `Task`:

```csharp
// Microsoft.Build.Utilities
public abstract class MultiThreadableTask : Task, IMultiThreadableTask
{
    public ITaskEnvironment TaskEnvironment { get; set; }
}
```

Tasks that inherit from `MultiThreadableTask` (or implement `IMultiThreadableTask`) can run in-process. If you have an existing task that you know is already safe to run in-process, you can add the `[MSBuildMultiThreadableTask]` attribute to indicate that the task is able to run in-process. Before marking a task with the attribute, confirm that it doesn't have any dependencies on process-level constructs like the current working directory or the environment, and that its code is thread-safe. Pay particular attention to ensure thread-safe access to static variables, as these are shared among all task instances and might be accessed or modified by different instances of the task that are also running in the same process.

## Example task: BuildCommentTask

The following example `AddBuildCommentTask` is used throughout this article to illustrate the migration process. This task prepends a build comment to source files:

```csharp
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace BuildCommentTask
{
    public class AddBuildCommentTask : Microsoft.Build.Utilities.Task
    {
        private static int ModifiedFileCount = 0;

        [Required]
        public ITaskItem[] TargetFiles { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        public string CommentPrefix { get; set; } = "//";
        public string CommentSuffix { get; set; } = "";

        public override bool Execute()
        {
            string buildDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
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

                    int fileNumber = Interlocked.Increment(ref ModifiedFileCount);
                    string comment = $"{CommentPrefix} Build Date: {buildDate}, Version: {VersionNumber}, File #: {fileNumber}{CommentSuffix}";
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

This task has three thread-safety issues that need to be addressed for multithreaded builds:

1. **Relative paths**: `File.ReadAllLines` and `File.WriteAllLines` use `item.ItemSpec` directly, which might be a relative path. In multithreaded mode, the process working directory isn't guaranteed to be the project directory.
2. **Static field**: `ModifiedFileCount` is a `static` field shared across all instances, which causes data races when multiple builds run concurrently.
3. **No TaskEnvironment usage**: The task doesn't use `TaskEnvironment` for path resolution, so it can't reliably resolve file paths in multithreaded mode.

> [!IMPORTANT]
> The multithreaded build mode is currently available only for .NET CLI (`dotnet build`) builds. Visual Studio MSBuild builds do not yet support multithreaded execution in-process. In Visual Studio, all task execution continues to run out of process. Visual Studio integration is planned for a future release.

## Prerequisites

- MSBuild 18.0 or later.

## Plan the migration

Review your task code for the following issues:

1. Check the task code and identify any usage of relative paths. Check all input and file I/O.
1. Check for any uses of environment variables.
1. Check for any `ProcessStartInfo` API usage.
1. Check any static fields or data structures and use standard methods to make them thread-safe.
1. If none of the above apply, consider adding the attribute only.
1. Consider special requirements for supporting earlier versions of MSBuild.

> [!TIP]
> MSBuild provides a Roslyn analyzer that can detect problematic API usage in your task code. Enable the analyzer in your task project to automatically flag calls to `Environment.GetEnvironmentVariable()`, `Environment.CurrentDirectory`, relative path usage, and other patterns that need to be updated for multithreaded builds.

## API replacement quick reference

The following table summarizes the .NET APIs that you should replace and their `TaskEnvironment` equivalents:

| .NET API to avoid | Level | Replacement |
|---|---|---|
| `Path.GetFullPath(path)` | ERROR | `TaskEnvironment.GetAbsolutePath(path)` |
| `File.*` with relative paths | ERROR | Resolve with `TaskEnvironment.GetAbsolutePath()` first |
| `Directory.*` with relative paths | ERROR | Resolve with `TaskEnvironment.GetAbsolutePath()` first |
| `Environment.GetEnvironmentVariable()` | ERROR | `TaskEnvironment.GetEnvironmentVariable()` |
| `Environment.SetEnvironmentVariable()` | ERROR | `TaskEnvironment.SetEnvironmentVariable()` |
| `Environment.CurrentDirectory` | ERROR | `TaskEnvironment.ProjectDirectory` |
| `new ProcessStartInfo()` | ERROR | `TaskEnvironment.GetProcessStartInfo()` |
| `Process.Start()` | ERROR | Use `ToolTask` or `TaskEnvironment.GetProcessStartInfo()` |
| Static fields | WARNING | Use instance fields or thread-safe collections |

## Apply the attribute to thread-safe tasks

If your task already doesn't rely on process-level state and is thread-safe, you can add the `[MSBuildMultiThreadableTask]` attribute without any other code changes. This approach is a compatibility bridge that tells MSBuild the task is safe to run in-process.

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

You have two options when marking a task for multithreaded builds:

- **Attribute-only**: Add `[MSBuildMultiThreadableTask]` to an existing task that inherits from `Task`. This approach works for tasks that are already thread-safe and don't need access to `TaskEnvironment`. The task continues to inherit from `Task` (or `ToolTask`) as before.
- **Interface-based**: Implement `IMultiThreadableTask` or inherit from `MultiThreadableTask`. This approach gives your task access to the `TaskEnvironment` property for resolving paths, reading environment variables, and getting process start info. Use this approach when your task needs to replace process-level API calls.

> [!NOTE]
> MSBuild detects the `MSBuildMultiThreadableTaskAttribute` by namespace and name only, ignoring the defining assembly. This means you can define the attribute yourself in your own code (see [Support earlier versions of MSBuild](#support-earlier-versions-of-msbuild)) and MSBuild still recognizes it.

> [!NOTE]
> The `MSBuildMultiThreadableTaskAttribute` is non-inheritable (`Inherited = false`). Each task class must explicitly declare the attribute to be recognized as thread-safe. Inheriting from a class that has the attribute doesn't automatically make the derived class multithreadable.

## Update paths and file I/O

A task often accepts inputs, such as item lists in MSBuild, which if they are files, might be in the form of relative paths.

Relative paths are always relative to the current working directory of the process, but because the task now executes in-process, the working directory might not be the same as it was when the task ran in its own process. Such paths are relative to the project directory. The `TaskEnvironment` includes a `ProjectDirectory` property and a `GetAbsolutePath()` method that you can use to resolve relative paths to absolute paths.

### The AbsolutePath type

`AbsolutePath` is a readonly struct in `Microsoft.Build.Framework` that represents a validated absolute file path. Key members include:

```csharp
public readonly struct AbsolutePath : IEquatable<AbsolutePath>
{
    public string Value { get; }
    public AbsolutePath(string path);  // Validates Path.IsPathRooted
    public AbsolutePath(string path, AbsolutePath basePath);
    public static implicit operator string(AbsolutePath path);
}
```

The `AbsolutePath` constructor validates that the provided path is rooted. You can also construct an `AbsolutePath` by providing a relative path and a base path. The implicit conversion to `string` means you can pass an `AbsolutePath` directly to any API that expects a `string` path.

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
```

> [!WARNING]
> `TaskEnvironment` itself is not thread-safe. If your task spawns multiple threads internally, you must synchronize access to `TaskEnvironment` methods and properties.

## Update environment variables

In the earlier task runtime model, the original environment variables for a process would be read by the first task to execute in the project. That task might read or write the environment variables. Subsequent tasks that run in the same project use the modified environment variables.

The goal of the update work is to preserve the analogy of this behavior, but in-process. To do that, MSBuild's `TaskEnvironment` captures the original environment variable table, and then allows read and write operations to occur on that table of variables. The same table is reused for later tasks that run in the same project. This behavior ensures that the task environment usage pattern is preserved for all tasks in the project, as long as they are updated to use the `TaskEnvironment`'s table and not the actual process's environment variables.

Replace all calls to `Environment` get and set methods with the equivalent methods on `TaskEnvironment` throughout the task.

**Before:**

```csharp
string value = Environment.GetEnvironmentVariable("MY_VAR");
Environment.SetEnvironmentVariable("BUILD_OUTPUT", outputPath);
```

**After:**

```csharp
string value = TaskEnvironment.GetEnvironmentVariable("MY_VAR");
TaskEnvironment.SetEnvironmentVariable("BUILD_OUTPUT", outputPath);
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

Static fields require the same treatment as in any multithreaded app development scenario. Your task might be used by more than one build at the same time, and if these builds modify the static data, it must not adversely affect other running builds. Static fields must be protected from updates by multiple threads at the same time. Coding must follow best practices to avoid deadlocks and race conditions.

In the `BuildCommentTask` example, the static field `ModifiedFileCount` is shared across all instances:

**Before:**

```csharp
private static int ModifiedFileCount = 0;

// In Execute():
int fileNumber = Interlocked.Increment(ref ModifiedFileCount);
```

You have two options for fixing this issue:

**Option 1: Use an instance field** (recommended when the count is per-task-invocation):

```csharp
private int _modifiedFileCount = 0;

// In Execute():
_modifiedFileCount++;
string comment = $"{CommentPrefix} Build Date: {buildDate}, Version: {VersionNumber}, File #: {_modifiedFileCount}{CommentSuffix}";
```

**Option 2: Use a `ConcurrentDictionary`** (when you need shared state keyed by build):

```csharp
private static readonly ConcurrentDictionary<string, int> ModifiedFileCounts = new();

// In Execute():
string buildId = BuildEngine9.GetGlobalProperties()["BuildSessionId"];
int fileNumber = ModifiedFileCounts.AddOrUpdate(buildId, 1, (_, count) => count + 1);
```

## Complete migration example

The following code shows the fully migrated `AddBuildCommentTask` with all four changes applied:

1. Inherits `MultiThreadableTask` instead of `Task`.
1. Has the `[MSBuildMultiThreadableTask]` attribute.
1. Uses `TaskEnvironment.GetAbsolutePath()` for path resolution.
1. Replaces the static field with an instance field.

```csharp
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BuildCommentTask
{
    [MSBuildMultiThreadableTask]
    public class AddBuildCommentTask : MultiThreadableTask
    {
        private int _modifiedFileCount = 0;

        [Required]
        public ITaskItem[] TargetFiles { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        public string CommentPrefix { get; set; } = "//";
        public string CommentSuffix { get; set; } = "";

        public override bool Execute()
        {
            string buildDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
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

                    _modifiedFileCount++;
                    string comment = $"{CommentPrefix} Build Date: {buildDate}, Version: {VersionNumber}, File #: {_modifiedFileCount}{CommentSuffix}";
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

## What happens to non-migrated tasks

Tasks that don't have the `[MSBuildMultiThreadableTask]` attribute or don't implement `IMultiThreadableTask` continue to work without any changes. MSBuild runs these tasks in a sidecar `TaskHost` process, which provides the same process-level isolation as earlier versions of MSBuild. This approach is slower because of the overhead of inter-process communication, but it's fully compatible with existing task code. Migration is optional for correctness—non-migrated tasks still produce correct results—but migrating improves build performance.

## Support earlier versions of MSBuild

If you update your custom task and then distribute it to others, your task supports clients using MSBuild 18.0 or later. To support clients on earlier versions of MSBuild, you have three options.

### Option 1: Maintain separate implementations

Build separate task assemblies for MSBuild 18.0+ and earlier versions. The MSBuild 18.0+ version uses `MultiThreadableTask` and `TaskEnvironment`. The earlier version continues to use `Task` with process-level APIs.

### Option 2: Compatibility bridge (recommended)

Define the `MSBuildMultiThreadableTaskAttribute` yourself in your task assembly. Because MSBuild detects the attribute by namespace and name only (ignoring the defining assembly), your self-defined attribute works in both old and new versions of MSBuild:

```csharp
namespace Microsoft.Build.Framework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class MSBuildMultiThreadableTaskAttribute : Attribute { }
}
```

When running on MSBuild 18.0+, MSBuild recognizes the attribute and runs the task in-process. When running on earlier versions, MSBuild ignores the unknown attribute and runs the task out-of-process as before.

### Option 3: Accept reduced performance

Make no changes to your task. MSBuild runs non-attributed tasks in a sidecar `TaskHost` process, which is slower but fully compatible. This option requires no code changes.

### Comparison of approaches

| Approach | Maintenance | Performance (18.0+) | Performance (older) | TaskEnvironment access |
|---|---|---|---|---|
| Separate implementations | High | Full in-process | Full out-of-process | Yes (18.0+ version) |
| Compatibility bridge | Low | Full in-process | Full out-of-process | No (attribute-only) |
| No changes | None | Sidecar (slower) | Full out-of-process | No |

## Example

Consider the following task code.

```csharp

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace BuildCommentTask
{
    public class AddBuildCommentTask : Microsoft.Build.Utilities.Task
    {
        private static int ModifiedFileCount = 0;

        [Required]
        public ITaskItem[] TargetFiles { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        public string CommentPrefix { get; set; } = "//";
        public string CommentSuffix { get; set; } = "";

        public override bool Execute()
        {
            string buildDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            string commentPattern = $@"^{Regex.Escape(CommentPrefix)}\s*Build Date:.*Version:.*{Regex.Escape(CommentSuffix)}$";

            foreach (var item in TargetFiles)
            {
                var filePath = item.ItemSpec;
                try
                {
                    string[] originalLines = File.ReadAllLines(filePath);

                    // Check if a similar comment already exists at the top
                    if (originalLines.Length > 0 && Regex.IsMatch(originalLines[0], commentPattern))
                    {
                        Log.LogMessage(MessageImportance.Low, $"Skipped (already annotated): {filePath}");
                        continue;
                    }

                    int fileNumber = Interlocked.Increment(ref ModifiedFileCount);
                    string comment = $"{CommentPrefix} Build Date: {buildDate}, Version: {VersionNumber}, File #: {fileNumber}{CommentSuffix}";
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


## Related content

- [MSBuild tasks](msbuild-tasks.md)
- [Create an MSBuild task](task-writing.md)
- [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices)
