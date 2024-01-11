---
title: Add GitHub accounts to your keychain
ms.date: 05/16/2023
ms.topic: how-to
description: Add your public GitHub or GitHub Enterprise account to your Visual Studio keychain so you can track code changes in GitHub repositories from Visual Studio.
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.subservice: general-ide
monikerRange: ">=vs-2019"
---
# Add your GitHub accounts to your Visual Studio keychain


In this article, you learn how to add your public GitHub or GitHub Enterprise account to your Visual Studio keychain. After you add your account, you'll be able to [track your code changes in GitHub repositories](../version-control/git-create-repository.md), right from Visual Studio. You can also create and use [GitHub Actions for deployment automation](../azure/azure-deployment-using-github-actions.md).

## Adding public GitHub accounts

You can add your public GitHub account at any point, even if you haven't signed into Visual Studio with a Microsoft account, work account, or school account.

**Add a GitHub account from the **Account settings** dialog:**

::: moniker range="<=vs-2019"

1. Open the Account Settings dialog by going to **File** > **Account Settings...**.

2. From the **All Accounts** submenu, select **+ Add** to add an account, and select **GitHub**.
    
    :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Select add GitHub account":::

3. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Success window in browser":::

4. Your GitHub account will now be present in the **All Accounts** submenu.

   :::image type="content" source="../ide/media/show-both-accounts.png" alt-text="Both accounts showing":::
   
::: moniker-end
   
::: moniker range="vs-2022"

1. Open the Account Settings dialog by going to **File** > **Account Settings...**.

2. From the **All Accounts** submenu, select **+ Add** to add an account, and then select **GitHub**.

   :::image type="content" source="../ide/media/vs-2022/sign-in-add-github.png" alt-text="Screenshot showing the Add GitHub account option.":::

3. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

   :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Success window in browser.":::

4. Your GitHub account will now be present in the **All Accounts** submenu.

   :::image type="content" source="../ide/media/vs-2022/show-both-accounts.png" alt-text="Screenshot showing both accounts on the Account settings dialog.":::

::: moniker-end

::: moniker range="vs-2022"

**Add a GitHub account from the **profile card**:**

If you're not already signed in to Visual Studio, select the **Sign in** link in the upper-right corner of the Visual Studio environment and use a Microsoft account, work account, or school account to sign in. 

:::image type="content" source="../ide/media/vs-2022/signin-different-account.png" alt-text="Screenshot showing not signed in to Visual Studio.":::

Then, follow these instructions to add your GitHub account.

1. Select the icon with your profile name in the upper-right corner of the Visual Studio environment, select **Add another account**, and then select **GitHub**.

    :::image type="content" source="../ide/media/vs-2022/add-another-account-github.png" alt-text="Screenshot of using Add another account option to add a GitHub account.":::

1. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Screenshot of the success window in browser.":::

1. Your GitHub account will now be present in your profile card.

    :::image type="content" source="../ide/media/vs-2022/show-both-accounts-flyout.png" alt-text="Screenshot showing both accounts on the sign in profile.":::

::: moniker-end

## Enabling GitHub enterprise accounts

By default, Visual Studio only has public GitHub accounts enabled.

::: moniker range="<=vs-2019"

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** and search for the **Accounts** options.

    :::image type="content" source="../ide/media/vs-2022/add-github-enterprise-account.png" alt-text="Screenshot of GitHub Account.":::

1. Then, check the box to **Include GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

   :::image type="content" source="../ide/media/github-enterprise-endpoint-signin.png" alt-text="Screenshot showing Sign in with GitHub Enterprise.":::

1. After you enter your GitHub Enterprise server address, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

::: moniker-end

::: moniker range="vs-2022"

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** and search for the **Accounts** options.

    :::image type="content" source="../ide/media/vs-2022/add-github-enterprise-account.png" alt-text="Screenshot of GitHub Account.":::

1. Then, check the box to **Include GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

   :::image type="content" source="../ide/media/vs-2022/github-enterprise-endpoint-signin.png" alt-text="Screenshot showing the Sign in with GitHub Enterprise.":::

1. After you enter your GitHub Enterprise server address, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

::: moniker-end

## Adding GitHub Enterprise Managed User (EMU) accounts

You can add your GitHub EMU account if you're already signed into Visual Studio with a Microsoft account, work account, or school account.

::: moniker range="vs-2022"

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Then, select **Add another account** > **GitHub**. 

    :::image type="content" source="../ide/media/vs-2022/add-another-account-github.png" alt-text="Screenshot of adding Enterprise Managed User.":::

1. You'll be redirected to the browser, where you can sign in with your GitHub EMU credentials.

::: moniker-end

**You can use the Account Settings dialog to manage your accounts:**

::: moniker range="<=vs-2019"

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Open the Account Settings dialog by selecting **Account settings** or by going to **File** > **Account Settings...**. 

   :::image type="content" source="../ide/media/vs-2019/account-settings-1.png" alt-text="Screenshot of the Account Settings window.":::

1. From the **All Accounts** submenu, select **+ Add** dropdown to add an account, and then select **GitHub**.

   :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Screenshot showing how to select and add a GitHub account.":::

1. Select **GitHub Enterprise** on the **Connect to GitHub** dialog.

::: moniker-end

::: moniker range="vs-2022"

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Open the Account Settings dialog by selecting **Account settings** or by going to **File** > **Account Settings...**. 

   :::image type="content" source="../ide/media/vs-2022/account-settings-1.png" alt-text="Screenshot of the Account Settings window.":::

1. From the **All Accounts** submenu, select **+ Add** dropdown to add an account, and then select **GitHub**.

   :::image type="content" source="../ide/media/vs-2022/sign-in-add-github.png" alt-text="Screenshot showing how to select and add a GitHub account.":::

1. Select **GitHub Enterprise** on the **Connect to GitHub** dialog.

::: moniker-end

> [!NOTE]
> Ensure you enter your GitHub EMU account credentials (the username has an underscore followed by the company name) on this page.
>
> :::image type="content" source="../ide/media/github-enterprise-managed-users-sign-in.png" alt-text="Screenshot showing the GitHub sign in experience for the GitHub Enterprise Managed User account.":::

After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

:::image type="content" source="../ide/media/github-success-signin.png" alt-text="Screenshot showing the sign-in success window in the browser.":::

## Troubleshooting sign in issues

If you're experiencing issues when adding or re-authenticating GitHub accounts, try the following steps:

Verify that HTTP Strict Transport Security (HSTS) is not enabled for localhost on your system's default web browser:
- On Microsoft Edge, you can type: edge://net-internals/#hsts and enter _localhost_ under the **Delete domain security policies** section.
- On Google Chrome, type: chrome://net-internals/#hsts and enter _localhost_ under the **Delete domain security policies** section.

> [!NOTE]
> Please [report a problem](https://developercommunity.visualstudio.com/report?space=8&entry=problem) if you're still experiencing sign in issues.

## Related content
- [Sign in to Visual Studio](signing-in-to-visual-studio.md)
- [How Visual Studio makes version control easy with Git](../version-control/git-with-visual-studio.md)
- [Deploy your application to Azure using GitHub Actions workflows](../azure/azure-deployment-using-github-actions.md).
