---
title: "Status bar"
description: "Display text notifications and progress indicators in the Visual Studio status bar using the VisualStudio.Extensibility SDK."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
monikerRange: ">=vs-2022"
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Status bar

Show non-critical notifications and progress indicators in the Visual Studio status bar.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

> [!TIP]
> No standalone status bar sample is available. For a full extension example, see [SimpleRemoteCommandSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample/).

**Related concepts:** [Contributions and configurations](../../how-it-works/contributions-and-configurations.md) — how extensions interact with the Visual Studio shell

## Understand the example

### Show progress in the status bar

```csharp
using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync(
    "Analyzing files...",
    new ProgressReporterOptions(isWorkCancellable: true),
    cancellationToken);

for (int i = 0; i < fileCount; i++)
{
    await AnalyzeFileAsync(files[i], cancellationToken);
    reporter.Report(new ProgressStatus((int)(((i + 1) / (double)fileCount) * 100)));
}
```

## Tips

### ✅ DO

- Use status bar for non-critical background information only
- Report progress with both current and total steps for a visible progress bar
- Keep status text short — the status bar has limited space

### ❌ DON'T

- Don't use the status bar for critical notifications (users may not see it)
- Don't write high-frequency updates — throttle to avoid UI flicker
- Don't assume your text persists — any other write replaces it immediately

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Text disappears immediately | Another extension or VS overwrote it; status bar is not persistent |
| Progress bar not visible | Ensure percentage is between 0 and 100 in ProgressStatus |
| Nothing appears | Verify command is executing and cancellation token is valid |

## Next steps

- [Output window](output-window.md) — for persistent log output
- [User prompts](../prompts/user-prompts.md) — for notifications requiring user attention
