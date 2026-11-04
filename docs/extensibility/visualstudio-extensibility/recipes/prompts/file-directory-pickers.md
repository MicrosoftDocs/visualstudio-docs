---
title: "File and folder pickers"
description: "Show file open, file save, and folder picker dialogs in Visual Studio extensions."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# File and folder pickers

Show native OS file and folder picker dialogs using the `ShellExtensibility` helpers.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/FilePickerSample/OpenFileCommand.cs":::

> [!TIP]
> See the full working sample: [FilePickerSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/FilePickerSample/)

**Related concepts:** [Remote UI](../../how-it-works/remote-ui.md) — the data-binding model used for Visual Studio UI

## Understand the example

### Open a file

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    FileDialogOptions options = new()
    {
        Title = "Select a file",
        Filters = new DialogFilters(
            new DialogFilter("Text Files", ".txt", ".md"),
            new DialogFilter("All Files", ".*"))
    };

    string? filePath = await this.Extensibility.Shell().ShowOpenFileDialogAsync(options, cancellationToken);
}
```

### Open multiple files

```csharp
FileDialogOptions options = new();
IReadOnlyList<string>? filePaths = await this.Extensibility.Shell()
    .ShowOpenMultipleFilesDialogAsync(options, cancellationToken);
```

### Save a file

```csharp
FileDialogOptions options = new()
{
    Title = "Save As",
    InitialFileName = "document.txt"
};

string? filePath = await this.Extensibility.Shell().ShowSaveAsFileDialogAsync(options, cancellationToken);
```

### Open a folder

```csharp
FolderDialogOptions options = new()
{
    Title = "Choose a folder",
    InitialDirectory = @"C:\Projects"
};

string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, cancellationToken);
```

### Options reference

#### FileDialogOptions

| Property | Type | Description |
|----------|------|-------------|
| `Title` | `string` | Dialog title. Defaults to **Open** or **Save As**. |
| `InitialFileName` | `string` | Pre-filled filename in the dialog input box. |
| `Filters` | `DialogFilters` | File type filters (for example, `*.txt`, `*.cs`). |

#### FolderDialogOptions

| Property | Type | Description |
|----------|------|-------------|
| `Title` | `string` | Dialog title. |
| `InitialDirectory` | `string` | Absolute path to start in. Defaults to the last opened directory. |

## Tips

### ✅ DO

- Check for `null` return — it means the user cancelled the dialog.
- Use `DialogFilter` to restrict visible file types to what your extension needs.

### ❌ DON'T

- Use hardcoded paths for `InitialDirectory` — prefer environment-based or user-relative paths.
- Use file pickers when you already know the file path — they're for user selection only.

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| `ShowOpenFileDialogAsync` throws | Verify `FileDialogOptions` is not null and the `InitialFileName` (if set) exists on disk. |

## Next steps

- [Dialogs](./dialogs.md) — custom dialogs with Remote UI content
- [User prompts](./user-prompts.md) — simple message boxes