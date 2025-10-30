---
title: Git settings in Visual Studio
titleSuffix: ""
description: Explore how Visual Studio uses .gitconfig files and Git settings to manage your project and solution preferences, such as your preferred diff and merge tools.
ms.date: 5/5/2025
ms.topic: article
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2019"
ms.custom: sfi-image-nochange
---
# Git settings and preferences in Visual Studio

In Visual Studio, you can configure and view common Git settings and preferences, such as your name and email address, your preferred diff and merge tools, and more. These settings and preferences can be viewed and configured in the **Options dialog box** on either the **Git Global Settings** page (applies to all your repositories) or the **Git Repository Settings** page (applies to the current repository).

You can configure two types of settings:

- [Git settings](#git-settings) - The settings in this section correspond to Git settings that are saved in Git configuration files. These settings can be viewed and modified in Visual Studio, but are managed by Git configuration files.
- [Visual Studio settings](#visual-studio-settings) - The settings in this section configure Git-related settings and preferences that are managed by Visual Studio.

## How to configure settings

1. To configure Git settings in Visual Studio, choose **Settings** from the top-level Git menu.

   :::moniker range=">=vs-2022"
   :::image type="content" source="media/vs-2022/git-menu-settings.png" alt-text="The Git menu with a callout to the Settings command.":::
   :::moniker-end

   :::moniker range="<=vs-2019"
   :::image type="content" source="media/git-menu-settings.png" alt-text="The Git menu with a callout to the Settings command.":::
   :::moniker-end

2. Choose **Git Global Settings** or **Git Repository Settings** to view and configure global-level or repository-level settings.

   :::image type="content" source="media/source-control-settings.png" alt-text="The navigation pane in the Options dialog box with a callout to Git settings.":::

3. You can configure several common Git settings, as described in the following sections of this article. After configuring your desired settings, select **OK** to save the updated settings.

   :::image type="content" source="media/ok-button.png" alt-text="The display area of the Options dialog box with a callout to the OK button.":::

## Git settings

You can also configure and check some of the most common Git configuration settings. You can view and modify the following settings in Visual Studio, even though they are managed by Git configuration files.

- [Name and email](#name-and-email)
- [Prune remote branches during fetch](#prune-remote-branches-during-fetch)
- [Rebase local branch when pulling](#rebase-local-branch-when-pulling)
- [Cryptographic network provider](#cryptographic-network-provider)
- [Credential helper](#credential-helper)
- [Diff & merge Tools](#diff--merge-tools)
- [Git files](#git-files)
- [Remotes](#remotes)
- [Other settings](#other-settings)

>[!NOTE]
>Git settings configured in Visual Studio's **Global Settings** correspond to settings in Git's user-specific configuration file, and the settings in **Repository Settings** correspond to settings in the repository-specific configuration file. For more information about Git configuration, see the [Pro Git chapter on customizing Git](https://git-scm.com/book/en/v2/Customizing-Git-Git-Configuration), the [git-config documentation](https://git-scm.com/docs/git-config), and the [Pro Git reference on configuration files](https://git-scm.com/docs/git-config#FILES). To configure Git settings not exposed in Visual Studio, use the `git config` command to write a value to your configuration files: `git config [--local|--global|--system] section.key value`.

### Name and email

The name and email that you provide is used as the committer information for any commit you make. This setting is available at both global and repository scopes, and corresponds to the `git config` [user.name](https://git-scm.com/docs/git-config#Documentation/git-config.txt-username) and [user.email](https://git-scm.com/docs/git-config#Documentation/git-config.txt-useremail) settings.

1. From the Git menu, go to **Settings**. To set your user name and email at the global level, go to **Git Global Settings**; to set your user name and email at the repository level, go to **Git Repository Settings**.

2. Provide your user name and email, then choose **OK** to save.

   :::image type="content" source="media/user-email-setting.png" alt-text="Git Global settings pane in Options dialog box with a callout to username an email.":::

### Prune remote branches during fetch

Pruning removes remote-tracking branches that no longer exist on the remote and helps you keep your branches list clean and up to date. This setting is available at both global and repository scopes, and corresponds to the `git config` [fetch.prune](https://git-scm.com/docs/git-config#Documentation/git-config.txt-fetchprune) setting.

We recommend setting this option to **True** at the global level. Valid settings are, as follows:

- **True** (recommended)
- **False**
- **Unset** (default)

Here's how to change the settings:

1. From the Git menu, go to **Settings**. Go to **Git Global Settings** to configure this option at the global level; go to **Git Repository Settings** to configure this option at the repo level.

2. Set **Prune remote branches during fetch** to **True** (recommended). Select **Ok** to save.

    :::image type="content" source="media/prune-setting.png" alt-text="Screenshot that shows 'Prune remote branches during fetch' highlighted and with 'True' selected from the drop-down.":::

### Rebase local branch when pulling

Rebasing sets aside the changes made by commits in the current branch that are not in the upstream branch, resets the current branch to the upstream branch, then applies the changes that were set aside. This setting is available at both global and repository scopes, and corresponds to the `git config` [pull.rebase](https://git-scm.com/docs/git-config#Documentation/git-config.txt-pullrebase) setting. Valid settings are, as follows:

- **True**: Rebase current branch on top of upstream branch after fetch.
- **False**: Merge the current branch into the upstream branch.
- **Unset** (default): Unless specified in other configuration files, merge the current branch into the upstream branch.
- **Interactive**: Rebase in interactive mode.
- **Merges**: Rebase without flattening locally created merge commits.

  > [!NOTE]
  > In Visual Studio 2022 [version 17.2](/visualstudio/releases/2022/release-notes), we changed the "Preserve" setting to "Merges" to match a recent update from Git. So, if you're using an earlier version of Visual Studio with Git tooling, your user interface might say "Preserve" instead of "Merges". The functionality remains the same, however.

Here's how to change the settings:

1. From the Git menu, go to **Settings**. Go to **Git Global Settings** to configure this option at the global level; go to **Git Repository Settings** to configure this option at the repo level.

2. Set **Rebase local branch when pulling** to the desired setting, and select **OK** to save.

    :::image type="content" source="media/rebase-setting.png" alt-text="Screenshot that shows 'Rebase local branch when pulling' highlighted and 'Merges' selected from the drop-down.":::

It's not possible to configure `pull.rebase` to **Interactive** in Visual Studio. Visual Studio doesn't have interactive rebase support.
To configure `pull.rebase` to use interactive mode, use the command line.

### Cryptographic network provider

Cryptographic network provider is a Git configuration setting at global scope that configures which TLS/SSL backend to use at runtime, and corresponds to the `git config` [http.sslBackend](https://git-scm.com/docs/git-config#Documentation/git-config.txt-httpsslBackend) setting. The values are, as follows:

- **OpenSSL**: Use [OpenSSL](https://www.openssl.org/) for TLS and SSL protocols.
- **Secure Channel**: Use [Secure Channel (schannel)](/windows/win32/secauthn/secure-channel) for TLS and SSL protocols. Schannel is the native Windows solution, accessing the Windows Credential Store, thereby allowing for enterprise-wide management of certificates.
- **Unset** (default): If this setting is unset, OpenSSL is the default.

Here's how to change the settings:

1. From the Git menu, go to **Settings**. Go to **Git Global Settings** to configure this setting.

2. Set **Cryptographic network provider** to the desired value, and select **OK** to save.

   :::image type="content" source="media/network-provider-setting.png" alt-text="Screenshot that shows 'Cryptographic network provider' highlighted with 'OpenSSL' selected from the drop-down.":::

### Credential helper

When Visual Studio performs a remote Git operation, the remote endpoint might reject the request because it requires credentials to be provided with the request. At that time, Git invokes a credential helper, which returns the credentials needed to perform the operation, and then tries the request again. The credential helper used corresponds to the `git config` [credential.helper](https://git-scm.com/docs/gitcredentials) setting. It is available at the global scope with the following values:

- **GCM for Windows**: Use [Git Credential Manager for Windows](https://github.com/microsoft/Git-Credential-Manager-for-Windows) as the helper.
- **GCM Core**: Use [Git Credential Manager Core](https://github.com/microsoft/Git-Credential-Manager-Core) as the helper.
- **Unset** (default): If this setting is unset, the credential helper set in the system config is used. As of Git for Windows 2.29, the default credential helper is GCM Core.

Here's how to change the settings:

1. From the Git menu, go to **Settings**. Go to **Git Global Settings** to configure this setting.

2. Set **Credential helper** to the desired value, and select **OK** to save.

    :::image type="content" source="media/credential-helper-setting.png" alt-text="Screenshot showing the credential helper setting in the Options dialog box.":::

### Diff & merge tools

Git shows diffs and merge conflicts in your preferred tools. The settings in this section correspond to the `git config` [diff.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-difftool) and [merge.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-mergetool) settings. You can configure Git to use Visual Studio as your merge or diff tool in **Git Global Settings** and **Git Repository Settings** by selecting **Use Visual Studio**. To configure other diff and merge tools, use `git config` with the [diff.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-difftool) or [merge.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-mergetool) switch.

:::image type="content" source="media/tools-setting.png" alt-text="Screenshot that shows the section to set default Diff tool and Merge tool in the Options dialog box.":::

### Git files

You can use the **Git files** section in the **Git Repository Settings** scope to view and edit the [gitignore](https://git-scm.com/docs/gitignore) and [gitattributes](https://git-scm.com/docs/gitattributes) files for your repository.

:::image type="content" source="media/git-files-setting.png" alt-text="Screenshot that shows the section to view and edit the Ignore and attributes files in your repository.":::

### Remotes

You can use the **Remotes** pane under **Git Repository Settings** to configure the remotes for your repository. This setting corresponds to the [git remote](https://git-scm.com/docs/git-remote) command and allows you to add, edit, or remove remotes.

:::image type="content" source="media/remotes-settings.png" alt-text="Screenshot showing the Git Remotes pane in the Options dialog box.":::

### Other settings

To view all of your other Git configuration settings, you can open and view the configuration files themselves, or you can run `git config --list` to display the settings.

## Visual Studio settings

The following settings manage Git-related preferences in Visual Studio, and are managed by Visual Studio instead of Git configuration files. All of the settings in this section are configured in the **Git Global Settings** page.

:::moniker range=">=vs-2022"

- [Default location](#default-location)
- [Default branch name](#default-branch-name)
- [Close open solutions not under Git when opening a repository](#close-open-solutions-not-under-git-when-opening-a-repository)
- [Automatically activate multiple repositories](#automatically-activate-multiple-repositories)
- [Enable download of author images from third-party sources](#enable-download-of-author-images-from-third-party-sources)
- [Commit changes after merge by default](#commit-changes-after-merge-by-default)
- [Enable push --force](#enable-push---force-with-lease)
- [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository)
- [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository)
- [Automatically check out branches with double-click or the Enter key](#automatically-check-out-branches-with-double-click-or-the-enter-key)
- [Restore the Git Repository window on restart](#restore-the-git-repository-window-on-restart)

:::moniker-end

:::moniker range="<=vs-2019"

- [Default location](#default-location)
- [Close open solutions not under Git when opening a repository](#close-open-solutions-not-under-git-when-opening-a-repository)
- [Enable download of author images from third-party sources](#enable-download-of-author-images-from-third-party-sources)
- [Commit changes after merge by default](#commit-changes-after-merge-by-default)
- [Enable push --force](#enable-push---force-with-lease)
- [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository)
- [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository)
- [Automatically check out branches with double-click or the Enter key](#automatically-check-out-branches-with-double-click-or-the-enter-key)

:::moniker-end

### Default location

**Default location** configures the default folder in which repositories are cloned.

:::image type="content" source="media/default-location-setting.png" alt-text="Screenshot showing the default location field in the Options dialog box.":::

:::moniker range=">=vs-2022"
### Default branch name

The **Default branch name** setting configures the default branch for new repos that you create locally. If you leave it blank, the default for your locally installed Git is used.

:::image type="content" source="media/vs-2022/default-branch-name.png" alt-text="Screenshot showing the default branch name field in the Options dialog box.":::

This setting is available in Visual Studio 17.14 and later.

:::moniker-end

### Close open solutions not under Git when opening a repository

By default, Visual Studio closes any open solution or folder when you switch to another repository. When it does so, it might also load the solution or folder of the new repository based on if you choose to [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository) and [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository). This setting maintains the consistency between the open code and open repository. However, if your solution is not in the same folder root as your repository, you may want to keep the solution open when you switch to its repository. You can do that with this setting. The values are, as follows:

- **Yes**: When a repository is opened, the currently open solution is always closed
- **No**: When a repository is opened, Visual Studio performs a check as to whether the current solution is under Git. If it is not, then the solution remains open.
- **Always ask** (default): When this is set, you can make a choice through a dialog box per repository open, whether you want to keep the current solution open or close it.

    :::image type="content" source="media/close-sln-setting.png" alt-text="Screenshot showing the close solution setting in the Options dialog box.":::

:::moniker range=">=vs-2022"

### Automatically activate multiple repositories

This setting lets you control whether Visual Studio spends resources on activating multiple repositories at once, or whether to optimize your workflow by only activating a single repository at a time. If you primarily work with a single repository, you can turn off this setting to improve the performance of Visual Studio. If you change the setting, the change doesn't take effect until the next time the solution is loaded.

- **Yes** (default): Visual Studio activates multiple repositories.
- **No**: Visual Studio only activates one repository.

:::image type="content" source="media/vs-2022/git-settings-automatically-activate-multiple-repos.png" alt-text="Screenshot showing the Automatically activate multiple repositories setting in the Options dialog box.":::

See [Work with multiple repos](git-multi-repository-support.md).
:::moniker-end

### Enable download of author images from third-party sources

Enable download of author images from third-party sources is a Visual Studio-specific setting at global scope. When checked, author images are downloaded from the [Gravatar image service](https://en.gravatar.com/), if available, and displayed in the commit and history views.

:::image type="content" source="media/download-image-setting.png" alt-text="Screenshot showing checkbox to enable download of author images from third-party source in the Options dialog box. ":::

>[!IMPORTANT]
>In order to provide author images in the Commit and History views, the tool creates an MD5 hash for the author email addresses stored in the active repository. This hash is then sent to Gravatar to find a matching hash value for users that have previously signed up for the service. If a match is found, the user image is retrieved from the service and displayed in Visual Studio. Users that have not configured the service return a randomly generated image. Note, email addresses are not recorded by Visual Studio, nor are they ever shared with Gravatar or any other third party.

### Commit changes after merge by default

When **Commit changes after merge by default** is enabled, Git automatically creates a new commit when a branch is merged with the current branch.

:::image type="content" source="media/merge-commit-setting.png" alt-text="Screenshot showing the checkbox to commit changes after merge by default in the Options dialog box.":::

- When checked, `git merge` commands issued by Visual Studio are run with the `--commit` option.
- When unchecked, `git merge` commands issued by Visual Studio are run with the `--no-commit --no-ff` options.

For more information on these options, see [--commit and --no-commit](https://git-scm.com/docs/git-merge#Documentation/git-merge.txt---commit) and [--no-ff](https://git-scm.com/docs/git-merge#Documentation/git-merge.txt---no-ff).

### Enable push --force-with-lease

When enabled, this setting allows you to `push --force-with-lease` from within Visual Studio. By default **Enable push --force-with-lease** is disabled.

:::image type="content" source="media/push-force-setting.png" alt-text="Screenshot showing the checkbox to enable push force with lease in the Options dialog box.":::

For more information, see [push --force-with-lease](https://git-scm.com/docs/git-push#Documentation/git-push.txt---no-force-with-lease).

### Open folder in Solution Explorer when opening a Git repository

When you use Visual Studio to open or switch to a Git repository, Visual Studio loads the Git content so that you can view changes, commits, branches, and manage your repository from within the IDE. In addition, Visual Studio also loads the code of the repository in Solution Explorer. Visual Studio scans the repository folder for solutions, CMakeLists.txt, or any other view files that it recognizes and display them as a list in Solution Explorer. From there, you can select a solution to load or the folder to view the directory contents. When you turn off this checkbox, then Visual Studio doesn't open the repository folder in Solution Explorer. This option essentially allows you to open Visual Studio as a Git repository manager only. The setting is on by default.

:::image type="content" source="media/open-folder-setting.png" alt-text="Screenshot showing the checkbox to open folder when opening a Git repository in the Options dialog box.":::

### Automatically load the solution when opening a Git repository

This setting is applicable only when the [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository) setting is turned on. When you open a Git repository in Visual Studio, and the subsequent folder scan detects there is only one solution present in your repository, then Visual Studio automatically loads that solution. If you turn off the setting, then the Solution Explorer displays the single solution present in the repository in the list of views. But it doesn't load the solution. By default, this setting is off.

:::image type="content" source="media/load-solution-setting.png" alt-text="Screenshot showing the checkbox to automatically load the solution when opening a Git repository in the Options dialog box.":::

### Automatically check out branches with double-click or the Enter key

The **Git Repository** window has a list of branches displayed in a tree structure. Single selecting a branch switches the commit history pane to display the commits for the selected branch. To check out a branch, you can right-click to open the context menu and select **Checkout**. If you turn on this setting, then double-clicking or pressing the Enter key checks out the branch and display its commits.

:::image type="content" source="media/checkout-branch-setting.png" alt-text="Screenshot showing the checkbox to check out branches with double-click or Enter key in the Options dialog box.":::

:::moniker range=">=vs-2022"
### Restore the Git Repository window on restart

If checked, the **Git Repository** window will open along with other permanent windows when you start the Visual Studio IDE, if the window was open when Visual Studio was last closed. The position of the window is saved in the window layout, so if you had moved the window or docked it, it opens just where you had it before. Clear the checkbox to prevent the window from opening when Visual Studio starts. You can still open the window manually by using the **View**, **Git Repository** menu command, by pressing **Ctrl**+**0**, **Ctrl**+**R**, or by pressing **Ctrl**+**Q** and searching on **Git Repository**.

If you use this window regularly, it can be very convenient to open it automatically when you start the IDE. However, opening and populating the window on startup can use a lot of computing resources, so if you're not actively using it, it's more efficient to disable this behavior.

:::image type="content" source="./media/vs-2022/git-settings-restore-the-git-repository-window.png" alt-text="Screenshot showing the Restore Git Repository window setting in the Options dialog box.":::

This setting is available in Visual Studio 17.14 and later. For more information, see [Browse a repository](./git-browse-repository.md).
:::moniker-end

## Related content

> [!IMPORTANT]
> If you have a suggestion for us, please let us know! We appreciate the opportunity to engage with you on design decisions via the [**Developer Community**](https://aka.ms/vsgitsuggestions) portal.

- [Getting started with Git in Visual Studio](https://www.youtube.com/watch?v=GCZ9x3yqkyc) video on YouTube
- [Enhanced productivity with Git in Visual Studio](https://devblogs.microsoft.com/visualstudio/enhanced-productivity-with-git-in-visual-studio/) blog post
- [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md)
