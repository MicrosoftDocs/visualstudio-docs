---
description: "Generate the monthly What's New in Visual Studio docs update from git history. Use at the start of each month to add the previous month's changes."
argument-hint: "Month and year to generate, e.g. 'March 2026'"
agent: agent
---

# Update "What's New in Visual Studio Docs"

Generate a monthly update section for [docs/ide/whats-new-visual-studio-docs.md](../../docs/ide/whats-new-visual-studio-docs.md) based on git commit history.

## Input

The target month: **${input:month}**

## Workflow

Follow these steps **in order**. Do not skip steps.

### Step 1: Determine the date range

Parse the month argument (e.g., "March 2026") to compute:
- `AFTER_DATE`: last day of the previous month (e.g., `2026-02-28`)
- `BEFORE_DATE`: first day of the next month (e.g., `2026-04-01`)

### Step 2: Get new articles

Run this git command to find files **added** during the month:

```
git log --after="AFTER_DATE" --before="BEFORE_DATE" --diff-filter=A --name-only --pretty=format:"COMMIT:%s" -- "docs/**/*.md"
```

Filter out files under `docs/**/includes/` and `whats-new` files.

### Step 3: Get updated articles

Run this git command to find files **modified** during the month:

```
git log --after="AFTER_DATE" --before="BEFORE_DATE" --diff-filter=M --name-only --pretty=format:"COMMIT:%s" -- "docs/**/*.md"
```

Filter out files under `docs/**/includes/` and `whats-new` files.

### Step 4: Build the file-to-commit-description mapping

Run a git command that pairs each file with its commit messages:

```
git log --after="AFTER_DATE" --before="BEFORE_DATE" --diff-filter=M --name-only --pretty=format:"COMMIT_MSG:%s" -- "docs/**/*.md"
```

Parse the output to build a mapping of `file → [list of commit messages]`. Deduplicate files. This mapping drives the descriptions for each entry.

### Step 5: Extract article titles

For each changed file, extract the `title:` field from its YAML front matter using `Select-String`:

```
Select-String -Path $file -Pattern '^title:\s*"?(.+?)"?\s*$'
```

### Step 6: Identify community contributors

Run this command to find all non-Microsoft contributors:

```
git log --after="AFTER_DATE" --before="BEFORE_DATE" --pretty=format:"%an|||%ae" -- "docs/**/*.md"
```

Filter out:
- `@microsoft.com` email addresses
- `prmerger-automator[bot]`
- `Learn Build Service`

Also get merge commit subjects to count PRs per external contributor:

```
git log --after="AFTER_DATE" --before="BEFORE_DATE" --merges --pretty=format:"%s" -- "docs/**/*.md"
```

**Important**: The contributor list will need manual review by the author. Some contributors with `@users.noreply.github.com` emails may still be Microsoft employees (vendors, contractors). The author knows who they are and will remove internal contributors after generation.

### Step 7: Compose the new month section

Build the section using these formatting rules.

#### Section structure

Organize by **doc area** (alphabetical), matching the folder structure under `docs/`. Use these area names:

| Folder | Section heading |
|--------|----------------|
| `docs/azure/` | Azure |
| `docs/code-quality/` | Code quality |
| `docs/containers/` | Containers |
| `docs/data-tools/` | Data tools |
| `docs/debugger/` | Debugger |
| `docs/deployment/` | Deployment |
| `docs/designers/` | Designers |
| `docs/extensibility/` | Extensibility |
| `docs/get-started/` | Get started |
| `docs/ide/` | IDE |
| `docs/install/` | Install |
| `docs/javascript/` | JavaScript |
| `docs/modeling/` | Modeling |
| `docs/msbuild/` | MSBuild |
| `docs/profiling/` | Profiling |
| `docs/python/` | Python |
| `docs/sharepoint/` | SharePoint |
| `docs/test/` | Test |
| `docs/version-control/` | Version control |
| `docs/vsto/` | VSTO |
| `docs/xaml-tools/` | XAML tools |
| `docs/xml-tools/` | XML tools |

Only include sections that have changes. Skip areas with no new or updated articles.

#### Entry format

Each article entry is a Markdown link using a **relative path from the what's-new file** (`../area/filename.md`), followed by a dash and a brief description derived from the commit messages:

```markdown
- [Article Title](../area/filename.md) - Brief description of change
```

#### Grouping related changes

When multiple files share the same commit message or change purpose, group them under a single description:

```markdown
- Description of shared change
  - [Article 1](../area/file1.md)
  - [Article 2](../area/file2.md)
```

#### New vs Updated

Within each area section, list **New articles** first (if any), then **Updated articles**:

```markdown
### Area Name

**New articles**

- [New Article Title](../area/new-article.md)

**Updated articles**

- [Updated Article Title](../area/updated-article.md) - What changed
```

If there are no new articles for an area, omit the **New articles** sub-heading entirely.

#### Description guidelines

- Derive descriptions from meaningful commit messages, not generic ones like "edits", "metadata", "fix typo"
- Consolidate multiple small commits on the same file into one meaningful description
- For screenshot-only updates, use "Review and update screenshots"
- For broad freshness passes, use "Review and update"
- Feature-related changes should name the feature (e.g., "Add content for middle-click scroll")
- Don't include internal commit artifacts like PR numbers

#### Community contributors section

Add at the end of the month, **after all area sections**:

```markdown
### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [GitHubUsername](https://github.com/GitHubUsername) - Display Name ![N pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-N-green)
```

Sort by PR count (descending), then alphabetically. Use the contributor's GitHub username for the link and their git author name as the display name.

### Step 8: Insert the section and update metadata

1. **Insert** the new month section immediately after the intro paragraph ("Welcome to what's new...") and **before** the previous month's section.
2. **Update `ms.date`** in the YAML front matter to the current date in `MM/DD/YYYY` format.
3. **Remove the oldest month** so the file always shows exactly **three months** of content. The oldest month section starts at its `## Month Year` heading and runs to the end of the file (including its Community contributors sub-section).

### Step 9: Final review

- Verify all relative links use the `../area/filename.md` pattern
- Verify article titles match the `title:` field in each file's front matter
- Confirm three months are shown (new month + two previous)
- Confirm no `docs/**/includes/` files appear in the listing
- Confirm the community contributors section is present (even if empty with a note)

## Reference: Current file location

The file to update is: `docs/ide/whats-new-visual-studio-docs.md`
