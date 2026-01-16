---
title: Git Settings in Visual Studio
titleSuffix: ""
description: Explore how Visual Studio uses .gitconfig files and Git settings to manage your project and solution preferences, such as your preferred diff and merge tools.
ms.date: 01/16/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2022"
ms.custom: sfi-image-nochange
---
# Git settings and preferences in Visual Studio

In Visual Studio, you can configure and view common Git settings and preferences, such as your name and email address, your preferred diff and merge tools, and more. The settings and preferences can be viewed and configured by selecting **Git** > **Settings** or **Tools** > **Options** on the menubar.

::: moniker range="visualstudio"

The **Options** pane opens to the **All Settings** > **Source Control** > **Git Settings** section where you can configure general Git options. To configure options to apply to all your repositories, expand the **Git Global Config** section. To configure options for the current repository only, expand the **Git Repository Config** section.

::: moniker-end
::: moniker range="vs-2022"

The **Options** dialog opens to the **Source Control** > **Git Global Settings** section where you can configure options to apply to all your repositories. To configure options for the current repository only, expand the **Git Repository Settings** section.

::: moniker-end

You can configure two types of settings:

- [Git settings](#git-settings) - These settings that are saved in Git configuration files. They can be viewed and modified in Visual Studio, but they're managed by Git configuration files.
- [Visual Studio settings](#visual-studio-settings) - These settings configure Git-related settings and preferences that are managed by Visual Studio.

## How to configure settings

1. To configure Git settings in Visual Studio, select **Git** > **Settings** from the main menubar.

   :::image type="content" source="media/vs-2022/git-menu-settings.png" alt-text="Screenshot of the Git menu with the Settings option highlighted.":::

::: moniker range="visualstudio"

2. The **Options** pane opens to the **All Settings** > **Source Control** > **Git Settings** section, which provides general Git options.

   - To view and configure global-level repository settings, expand the **Git Global Config** section.
   - For repository-level settings, expand the **Git Repository Config** section.

   :::image type="content" source="media/visualstudio/git-options-settings.png" border="false" alt-text="Screenshot of the Options pane showing the sections available under Git Settings.":::

::: moniker-end
::: moniker range="vs-2022"

2. The **Options** dialog opens to the **Source Control** > **Git Global Settings** section where you can configure options to apply to all your repositories.

   To configure options for the current repository only, expand the **Git Repository Settings** section.

   :::image type="content" source="media/vs-2022/source-control-settings.png" border="false" alt-text="Screenshot of the Options dialog showing the sections available under Source Control.":::

::: moniker-end

## Git settings

You can configure and check some of the most common Git configuration settings. You can view and modify the following settings in Visual Studio, even though they're managed by Git configuration files.

- [User name and email](#user-name-and-email)
- [Prune remote branches during fetch](#prune-remote-branches-during-fetch)
- [Rebase local branch when pulling](#rebase-local-branch-when-pulling)
- [Cryptographic network provider](#cryptographic-network-provider)
- [Credential helper](#credential-helper)
- [Enable commit graph for better Git performance](#enable-commit-graph)
- [Diff and Merge Tools](#diff-and-merge-tools)
- [Git files](#git-files)
- [Remotes](#remotes)
- [Other settings](#other-settings)

> [!NOTE]
> **Global** Git settings correspond to preferences in Git's user-specific configuration file. **Repository** settings correspond to preferences in the repository-specific configuration file. For more information about Git configuration, see the [Pro Git chapter on customizing Git](https://git-scm.com/book/en/v2/Customizing-Git-Git-Configuration), the [git-config documentation](https://git-scm.com/docs/git-config), and the [Pro Git reference on configuration files](https://git-scm.com/docs/git-config#FILES). To configure Git settings not exposed in Visual Studio, use the `git config` command to write a value to your configuration files: `git config [--local|--global|--system] section.key value`.

### User name and email

The name and email that you provide is used as the committer information for any commit you make. This setting is available at both global and repository scopes, and corresponds to the `git config` [user.name](https://git-scm.com/docs/git-config#Documentation/git-config.txt-username) and [user.email](https://git-scm.com/docs/git-config#Documentation/git-config.txt-useremail) settings.

Here's how to change the settings:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

   - To set your user name and email at the global level, expand the **Git Global Config** section.

   - To set your user name and email at the repository level, expand the**Git Repository Config** section.

1. Set the **User name** and **Email** options to your user name and email address.

   :::image type="content" source="media/visualstudio/user-email-setting.png" border="false" alt-text="Screenshot of the Git Global Config settings in the Options pane with the user name and email highlighted.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

   - To set your user name and email at the global level, expand the **Git Global Settings** section.

   - To set your user name and email at the repository level, expand the**Git Repository Settings** section.

1. Set the **User name** and **Email** options to your user name and email address, and select **OK**.

   :::image type="content" source="media/vs-2022/user-email-setting.png" border="false" alt-text="Screenshot of the Git Global Settings options in the Options dialog with the user name and email highlighted.":::

::: moniker-end

### Prune remote branches during fetch

Pruning removes remote-tracking branches that no longer exist on the remote and helps you keep your branches list clean and up to date. This setting is available at both global and repository scopes, and corresponds to the `git config` [fetch.prune](https://git-scm.com/docs/git-config#Documentation/git-config.txt-fetchprune) setting.

The following values are available, where **True** is recommended for the global-level setting:

- **True** (recommended)
- **False**
- **Unset** (default)

Here's how to change this setting:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

   - To adjust pruning at the global level, expand the **Git Global Config** section.

   - To adjust pruning at the repository level, expand the**Git Repository Config** section.

1. Set the **Prune remote branches during fetch** option to **True** (recommended).

   :::image type="content" source="media/visualstudio/prune-setting.png" border="false" alt-text="Screenshot that shows the 'Prune remote branches during fetch' option with 'True' selected in the dropdown list.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

   - To adjust pruning at the global level, expand the **Git Global Settings** section.

   - To adjust pruning at the repository level, expand the**Git Repository Settings** section.

1. Set the **Prune remote branches during fetch** option to **True** (recommended), and select **OK**.

   :::image type="content" source="media/vs-2022/prune-setting.png" border="false" alt-text="Screenshot that shows the 'Prune remote branches during fetch' option highlighted with 'True' selected in the dropdown list.":::

::: moniker-end

### Rebase local branch when pulling

Rebasing sets aside the changes made by commits in the current branch that aren't in the upstream branch. It resets the current branch to the upstream branch and then applies the changes that were set aside. This setting is available at both global and repository scopes, and corresponds to the `git config` [pull.rebase](https://git-scm.com/docs/git-config#Documentation/git-config.txt-pullrebase) setting.

The following values are available:

- **True**: Rebase current branch on top of upstream branch after fetch.
- **False**: Merge the current branch into the upstream branch.
- **Merges** (or **Preserve**): Rebase without flattening locally created merge commits.
- **Unset** (default): Unless specified in other configuration files, merge the current branch into the upstream branch.

> [!NOTE]
> It's not possible to configure `pull.rebase` to **Interactive** in Visual Studio. Visual Studio doesn't offer interactive rebase support. To configure `pull.rebase` to use interactive mode, use the command line.

Here's how to change this setting:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

   - To configure rebasing at the global level, expand the **Git Global Config** section.

   - To configure rebasing at the repository level, expand the**Git Repository Config** section.

1. Set the **Rebase local branch when pulling** option to **True** (recommended).

   :::image type="content" source="media/visualstudio/rebase-branch-setting.png" border="false" alt-text="Screenshot that shows the 'Rebase local branch when pulling' option with 'Merges' selected in the dropdown list.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

   - To configure rebasing at the global level, expand the **Git Global Settings** section.

   - To configure rebasing at the repository level, expand the**Git Repository Settings** section.

1. Set the **Rebase local branch when pulling** option to your desired value, and select **OK**.

   :::image type="content" source="media/vs-2022/rebase-branch-setting.png" border="false" alt-text="Screenshot that shows the 'Rebase local branch when pulling' option with 'Merges' selected in the dropdown list.":::

::: moniker-end

### Cryptographic network provider

Cryptographic network provider is a Git configuration setting at global scope that configures which TLS/SSL backend to use at runtime. This option corresponds to the `git config` [http.sslBackend](https://git-scm.com/docs/git-config#Documentation/git-config.txt-httpsslBackend) setting.

The following values are available at the global scope:

- **OpenSSL**: Use [OpenSSL](https://www.openssl.org/) for TLS and SSL protocols.
- **Secure Channel**: Use [Secure Channel (schannel)](/windows/win32/secauthn/secure-channel) for TLS and SSL protocols. Schannel is the native Windows solution, which accesses the Windows Credential Store and enables enterprise-wide management of certificates.
- **Unset** (default): If this setting is unset, OpenSSL is the default.

Here's how to change this setting:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

1. In the **Options** pane, expand the **Git Global Config** section.

1. Set the **Cryptographic network provider** option to your desired value, and select **OK**.

   :::image type="content" source="media/visualstudio/network-provider-setting.png" border="false" alt-text="Screenshot that shows the 'Cryptographic network provider' option with 'OpenSSL' selected in the dropdown list.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

1. In the **Options** dialog, expand the **Git Global Settings** section.

1. Set the **Cryptographic network provider** option to your desired value, and select **OK**.

   :::image type="content" source="media/vs-2022/network-provider-setting.png" border="false" alt-text="Screenshot that shows the 'Cryptographic network provider' option with 'OpenSSL' selected in the dropdown list.":::

::: moniker-end

### Credential helper

Credential helper is a Git configuration setting at global scope. When Visual Studio performs a remote Git operation, the remote endpoint might reject the request because it requires credentials to be provided with the request. At that time, Git invokes a credential helper, which returns the credentials needed to perform the operation, and then retries the request. The credential helper used corresponds to the `git config` [credential.helper](https://git-scm.com/docs/gitcredentials) setting.

The following values are available at the global scope:

- **GCM**: Use [Git Credential Manager](https://github.com/git-ecosystem/git-credential-manager) as the helper.
- **Unset** (default): If the option is unset, the credential helper specified in the system config is used.

Here's how to change this setting:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

1. In the **Options** pane, expand the **Git Global Config** section.

1. Set the **Credential helper** option to your desired value, and select **OK**.

   :::image type="content" source="media/visualstudio/credential-helper-setting.png" border="false" alt-text="Screenshot that shows the 'Credential helper' option with 'GCM' selected in the dropdown list.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

1. In the **Options** dialog, expand the **Git Global Settings** section.

1. Set the **Credential helper** option to your desired value, and select **OK**.

   :::image type="content" source="media/vs-2022/credential-helper-setting.png" border="false" alt-text="Screenshot that shows the 'Credential helper' option with 'GCM' selected in the dropdown list.":::

::: moniker-end

### Enable commit graph

The **Enable commit graph for better Git performance** option instructs Visual Studio to generate a commit graph file in your local repository for quick parsing and sorting of your commits. A commit graph can decrease delays in Git operations and improve performance of repository actions in Visual Studio. For more information, see [Supercharge your Git experience in Visual Studio with a commit graph](https://devblogs.microsoft.com/visualstudio/supercharge-your-git-experience-in-vs/#what-happens-when-you-enable-the-commit-graph). 

> [!NOTE]
> It can take a few minutes to generate the commit graph based on the size of your repository. Until the operation complete, you can't run other Git operations in Visual Studio, such as Fetch or Pull.

The following values are available at the local scope:

- **True**
- **False**
- **Unset** (default)

Here's how to configure this setting:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

1. In the **Options** pane, expand the **Git Repository Config** section.

1. Set the **Enable commit graph for better Git performance** option to your desired value, and select **OK**.

   :::image type="content" source="media/visualstudio/commit-graph-setting.png" border="false" alt-text="Screenshot that shows the 'Enable commit graph for better Git performance' option for a local repository.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

1. In the **Options** dialog, expand the **Git Repository Settings** > **General** section.

1. Set the **Enable commit graph for better Git performance** option to your desired value, and select **OK**.

   :::image type="content" source="media/vs-2022/commit-graph-setting.png" border="false" alt-text="Screenshot that shows the 'Enable commit graph for better Git performance' option for a local repository.":::

::: moniker-end

### Diff and Merge Tools

Git shows diffs and merge conflicts in your preferred tools. The configuration corresponds to the `git config` [diff.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-difftool) and [merge.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-mergetool) settings. You can specify your **Diff Tool** and **Merge Tool** preferences at both global and local scopes.

Here's how to configure these settings:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

   - To configure the tools at the global level, expand the **Git Global Config** section, and scroll to the **Tools** group.

   - To configure the tools at the repository level, expand the**Git Repository Config** section, and scroll to the **Tools** group.

1. Select **Visual Studio** in the dropdown list for the **Diff Tool** or **Merge Tool** option.

   :::image type="content" source="media/visualstudio/diff-merge-tools-setting.png" border="false" alt-text="Screenshot that shows the 'Diff Tool' and 'Merge Tool' options with the Use Visual Studio link highlighted.":::

After you configure a tool at the global level, the value is **Visual Studio | Global**, or for the current repository, **Visual Studio | Local**. Otherwise, the value is **Unset** (default).

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

   - To configure the tools at the global level, expand the **Git Global Settings** section, and scroll to the **Tools** group.

   - To configure the tools at the repository level, expand the**Git Repository Settings** section, and scroll to the **Tools** group.

1. Select the **Use Visual Studio** link for the **Diff Tool** or **Merge Tool** option.

   :::image type="content" source="media/vs-2022/diff-merge-tools-setting.png" border="false" alt-text="Screenshot that shows the 'Diff Tool' and 'Merge Tool' options with the Use Visual Studio link highlighted.":::

After you configure a tool at the global level, the value is **Visual Studio | Global**, or for the current repository, **Visual Studio | Local**. Otherwise, the value is **None** (default).

::: moniker-end

To configure other diff and merge tools, use `git config` with the [diff.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-difftool) or [merge.tool](https://git-scm.com/docs/git-config#Documentation/git-config.txt-mergetool) switch.

### Git files

You can use the **Git files** options to view and edit the [gitignore](https://git-scm.com/docs/gitignore) and [gitattributes](https://git-scm.com/docs/gitattributes) files for your local repository.

Here's how to work with these settings:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

1. In the **Options** pane, expand the **Git Repository Config** section and scroll to the **Git files** group.

1. To add the **Ignore file** (_.gitignore_) or **Attributes file** (_.gitattributes_), select **Add /.gitignore** or **Add /.gitattributes_**.

   Visual Studio adds the file and changes the button label to **Edit \<filename>**.

1. To view or edit a file, select **Edit \<filename>**.

:::image type="content" source="media/visualstudio/git-files-setting.png" border="false" alt-text="Screenshot that shows the section to Add the gitignore file and Edit the gitattributes file in your repository.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

1. In the **Options** dialog, expand the **Git Repository Settings** > **General** section.

1. To add the **Ignore file** (_.gitignore_) or **Attributes file** (_.gitattributes_), select **Add**.

   Visual Studio adds the file and changes the button label to **Edit**.
   
1. To view or edit the _.gitignore_ or _.gitattributes_ file, select **Edit**.

:::image type="content" source="media/vs-2022/git-files-setting.png" border="false" alt-text="Screenshot that shows the section to Add the gitignore file and Edit the gitattributes file in your repository.":::

::: moniker-end

### Remotes

You can configure the remotes for your local repository with the **Remotes** options. You can add and edit remotes, or delete remotes. This setting corresponds to the [git remote](https://git-scm.com/docs/git-remote) command and allows you to add, edit, or remove remotes.

Here's how to work with these settings:

::: moniker range="visualstudio"

1. Open the **Options** pane by selecting **Git** > **Settings**.

1. In the **Options** pane, expand the **Git Repository Config** section, and scroll to the **Remotes** group.

   :::image type="content" source="media/visualstudio/remotes-setting.png" border="false" alt-text="Screenshot that shows the Git Remotes section for the local repository.":::

::: moniker-end
::: moniker range="vs-2022"

1. Open the **Options** dialog by selecting **Git** > **Settings**.

1. In the **Options** dialog, expand the **Git Repository Settings** > **Remotes** section.

   :::image type="content" source="media/vs-2022/remotes-setting.png" border="false" alt-text="Screenshot that shows the Git Remotes section for the local repository.":::

::: moniker-end

The table lists the set of remotes defined for the repository.

- To add more remotes, select **Add**.

- To update a remote, select the remote in the list, and then select **Edit**.

- To delete a remote, select the remote in the list, and then select **Remove**. 

### Other settings

To view all of your other Git configuration settings, you can open and view the configuration files themselves, or you can run `git config --list` to display the settings.


## Visual Studio settings

::: moniker range="visualstudio"

The following settings manage Git-related preferences in Visual Studio, and are managed by Visual Studio instead of Git configuration files. Most of the settings are configured in the **All Settings** > **Source Control** > **Git Settings** section of the **Options** pane.

- [Default location](#default-location)
- [Default branch name](#default-branch-name)
- [Close non-Git solutions](#close-non-git-solutions)
- [Automatically activate multiple repositories](#automatically-activate-multiple-repositories)
- [Enable download of author images from third-party sources](#enable-download-of-author-images-from-third-party-source)
- [Commit changes after merge by default](#commit-changes-after-merge-by-default)
- [Enable push --force](#enable-push---force-with-lease)
- [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository)
- [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository)
- [Automatically check out branches with double-click or the Enter key](#automatically-check-out-branches-with-double-click-or-the-enter-key)
- [Restore the Git Repository window on restart](#restore-the-git-repository-window-on-restart)

::: moniker-end
::: moniker range="vs-2022"

The following settings configure Git-related preferences in Visual Studio, and are managed by Visual Studio instead of Git configuration files. All of the settings in this section are configured in the **Source Control** > **Git Global Settings** section of the **Options** dialog.

- [Default location](#default-location)
- [Default branch name](#default-branch-name)
- [Close open solutions not under Git when opening a repository](#close-open-solutions-not-under-git-when-opening-a-repository)
- [Automatically activate multiple repositories](#automatically-activate-multiple-repositories)
- [Enable download of author images from third-party sources](#enable-download-of-author-images-from-third-party-source)
- [Commit changes after merge by default](#commit-changes-after-merge-by-default)
- [Enable push --force](#enable-push---force-with-lease)
- [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository)
- [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository)
- [Automatically check out branches with double-click or the Enter key](#automatically-check-out-branches-with-double-click-or-the-enter-key)
- [Restore the Git Repository window on restart](#restore-the-git-repository-window-on-restart)

::: moniker-end

### Default location

This setting configures the default folder in which repositories are cloned.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/default-location-setting.png" border="false" alt-text="Screenshot of the 'Default location' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/default-location-setting.png" border="false" alt-text="Screenshot of the 'Default location' option in the Options dialog.":::

::: moniker-end

### Default branch name

This setting configures the default branch for new repositories that you create locally. If you leave the value blank, Visual Studio uses your locally installed Git by default.

::: moniker range="visualstudio"

The setting is located in the **All Settings** > **Source Control** > **Git Settings** > **Git Global Config** section.

:::image type="content" source="media/visualstudio/default-branch-name.png" border="false" alt-text="Screenshot of the 'Default branch name' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/default-branch-name.png" border="false" alt-text="Screenshot of the 'Default branch name' option in the Options dialog.":::

::: moniker-end

::: moniker range="visualstudio"

### Close non-Git solutions

::: moniker-end
::: moniker range="vs-2022"

### Close open solutions not under Git when opening a repository

::: moniker-end

By default, Visual Studio closes any open solution or folder when you switch to another repository. When it does so, it might also load the solution or folder of the new repository based on if you choose to [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository) and [Automatically load the solution when opening a Git repository](#automatically-load-the-solution-when-opening-a-git-repository). 

This setting maintains the consistency between the open code and open repository. If your solution isn't in the same folder root as your repository, you can select this option and keep the solution open when you switch to its repository.

The following values are available:

- **Yes**: When a repository opens, the current open solution is always closed.
- **No**: When a repository opens, Visual Studio checks if the current solution is under Git. If it isn't, the solution remains open.
- **Always ask** (default): When a repository opens, a dialog prompts you to keep the current solution open or close it.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/close-solution-setting.png" border="false" alt-text="Screenshot of the 'Close non-Git solutions' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/close-solution-setting.png" border="false" alt-text="Screenshot of the 'Close open solutions not under Git when opening a repository' option in the Options dialog.":::

::: moniker-end

### Automatically activate multiple repositories

This setting lets you control whether Visual Studio spends resources on activating multiple repositories at once, or whether to optimize your workflow by activating a single repository at a time. If you primarily work with a single repository, you can unselect this setting to improve the performance of Visual Studio. If you change the setting, the change doesn't take effect until the next time the solution loads.

The following values are available:

- **Yes** (default): Visual Studio activates multiple repositories.
- **No**: Visual Studio only activates one repository.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/activate-multiple-repos.png" border="false" alt-text="Screenshot of the 'Automatically activate multiple repositories' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/activate-multiple-repos.png" border="false" alt-text="Screenshot of the 'Automatically activate multiple repositories' option in the Options dialog.":::

::: moniker-end

For more information, see [Work with multiple repos](git-multi-repository-support.md).

### Enable download of author images from third-party source

This option is a Visual Studio-specific setting at global scope. When the option is selected, author images are downloaded from the [Gravatar image service](https://en.gravatar.com/), if available, and displayed in the Commit and History views.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/download-image-setting.png" border="false" alt-text="Screenshot of the 'Enable download of author images from 3rd party source' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/download-image-setting.png" border="false" alt-text="Screenshot of the 'Enable download of author images from 3rd party source' option in the Options dialog.":::

::: moniker-end

> [!IMPORTANT]
> To provide author images in the Commit and History views, the tool creates an MD5 hash for the author email addresses stored in the active repository. The hash is sent to Gravatar to find a matching hash value for users registered with the service. If a match is found, the user image is retrieved from the service and displayed in Visual Studio. If the user isn't registered with the service, a randomly generated image is returned. Visual Studio doesn't record email addresses or share them with Gravatar or other third-parties.

### Commit changes after merge by default

When you select this option, Git automatically creates a new commit when a branch is merged with the current branch.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/merge-commit-setting.png" border="false" alt-text="Screenshot of the 'Commit changes after merge by default' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/merge-commit-setting.png" border="false" alt-text="Screenshot of the 'Commit changes after merge by default' option in the Options dialog.":::

::: moniker-end

- When the option is selected, `git merge` commands issued by Visual Studio run with the `--commit` option.
- When the option isn't selected, `git merge` commands issued by Visual Studio run with the `--no-commit --no-ff` options.

For more information on these options, see [--commit and --no-commit](https://git-scm.com/docs/git-merge#Documentation/git-merge.txt---commit) and [--no-ff](https://git-scm.com/docs/git-merge#Documentation/git-merge.txt---no-ff).

### Enable push --force-with-lease

When you select this option, you can `push --force-with-lease` from within Visual Studio. By default, this option isn't selected.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/push-force-setting.png" border="false" alt-text="Screenshot of the 'Enable push --force-with-lease' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/push-force-setting.png" border="false" alt-text="Screenshot of the 'Enable push --force-with-lease' option in the Options dialog.":::

::: moniker-end

For more information, see [push --force-with-lease](https://git-scm.com/docs/git-push#Documentation/git-push.txt---no-force-with-lease).

### Open folder in Solution Explorer when opening a Git repository

When you use Visual Studio to open or switch to a Git repository, Visual Studio loads the Git content so you can view changes, commits, branches, and manage your repository from within the IDE. Visual Studio also loads the code of the repository in Solution Explorer. Visual Studio scans the repository folder for solutions, _CMakeLists.txt_, or other recognized view files and displays them as a list in Solution Explorer. From there, you can select a solution to load or the folder to view the directory contents. When you unselect this option, Visual Studio doesn't open the repository folder in Solution Explorer. This option essentially allows you to open Visual Studio as a Git repository manager only. The setting is selected by default.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/open-folder-setting.png" border="false" alt-text="Screenshot of the 'Open folder in Solution Explorer when opening a Git repository' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/open-folder-setting.png" border="false" alt-text="Screenshot of the 'Open folder in Solution Explorer when opening a Git repository' option in the Options dialog.":::

::: moniker-end

### Automatically load the solution when opening a Git repository

This setting is applicable only when the [Open folder in Solution Explorer when opening a Git repository](#open-folder-in-solution-explorer-when-opening-a-git-repository) option is selected. When you open a Git repository in Visual Studio, and the subsequent folder scan detects only one solution in your repository, Visual Studio automatically loads that solution. If you unselect this setting, Solution Explorer displays the single solution in the repository in the list of views, but it doesn't load the solution. By default, this setting isn't selected.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/load-solution-setting.png" border="false" alt-text="Screenshot of the 'Automatically load the solution when opening a Git repository' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/load-solution-setting.png" border="false" alt-text="Screenshot of the 'Automatically load the solution when opening a Git repository' option in the Options dialog.":::

::: moniker-end

### Automatically check out branches with double-click or the Enter key

The **Git Repository** window has a list of branches displayed in a tree structure. Single selecting a branch switches the commit history pane to display the commits for the selected branch. To check out a branch, right-click and select **Checkout**. If you select this setting, double-clicking or pressing **Enter** checks out the branch and display its commits.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/checkout-branch-setting.png" border="false" alt-text="Screenshot of the 'Automatically check out branches with double-click or Enter key' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/checkout-branch-setting.png" border="false" alt-text="Screenshot of the 'Automatically check out branches with double-click or Enter key' option in the Options dialog.":::

::: moniker-end

### Restore the Git Repository window on restart

If checked, the **Git Repository** window opens along with other permanent windows when you start the Visual Studio IDE, if the window was open when Visual Studio was last closed. The position of the window is saved in the window layout. If you moved the window or docked it, it opens just where you had it before. Clear the checkbox to prevent the window from opening when Visual Studio starts. You can still open the window manually by selecting **View** > **Git Repository** on the main menubar command. The keyboard shortcut is **Ctrl**+**0**, **Ctrl**+**R**, or **Ctrl**+**Q** and searching on _Git Repository_.

If you use this window regularly, it can be convenient to open it automatically when you start the IDE. However, opening and populating the window on startup can use many computing resources. If you're not actively using the window, it's more efficient to disable this behavior.

::: moniker range="visualstudio"

:::image type="content" source="./media/visualstudio/restore-git-repository-window.png" border="false" alt-text="Screenshot of the 'Restore the Git Repository window on restart' option in the Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="./media/vs-2022/restore-git-repository-window.png" border="false" alt-text="Screenshot of the 'Restore the Git Repository window on restart' option in the Options dialog.":::

::: moniker-end

For more information, see [Browse a repository](./git-browse-repository.md).

## Related content

> [!IMPORTANT]
> If you have a suggestion for us, please let us know! We appreciate the opportunity to engage with you on design decisions via the [**Developer Community**](https://aka.ms/vsgitsuggestions) portal.

- [Getting started with Git in Visual Studio](https://www.youtube.com/watch?v=GCZ9x3yqkyc) video on YouTube
- [Enhanced productivity with Git in Visual Studio](https://devblogs.microsoft.com/visualstudio/enhanced-productivity-with-git-in-visual-studio/) blog post
- [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md)
