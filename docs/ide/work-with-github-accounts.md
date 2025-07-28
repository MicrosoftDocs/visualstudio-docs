---
title: Add GitHub accounts to your keychain
ms.date: 05/13/2025
ms.topic: how-to
description: Add your public GitHub or GitHub Enterprise account to your Visual Studio keychain so you can track code changes in GitHub repositories from Visual Studio.
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2019"
---
# Add your GitHub accounts to your Visual Studio keychain

::: moniker range="<=vs-2019"

In this article, you learn how to add your public GitHub or GitHub Enterprise account to your Visual Studio keychain. After you add your account, you can [track your code changes in GitHub repositories](../version-control/git-create-repository.md), right from Visual Studio. You can also create and use [GitHub Actions for deployment automation](../azure/azure-deployment-using-github-actions.md).

## Adding public GitHub accounts

You can add your public GitHub account at any point, after you've [signed into Visual Studio with a Microsoft account, work account, or school account](signing-in-to-visual-studio.md#sign-in-to-your-account).

::: moniker-end

::: moniker range=">=vs-2022"

In this article, you learn how to add your public GitHub or GitHub Enterprise account to your Visual Studio keychain. After you add your account, you can use [GitHub Copilot](visual-studio-github-copilot-install-and-states.md) and [track your code changes in GitHub repositories](../version-control/git-create-repository.md), right from Visual Studio. You can also create and use [GitHub Actions for deployment automation](../azure/azure-deployment-using-github-actions.md).

## Adding public GitHub accounts

You can add your public GitHub account at first launch or later, without needing to [sign into Visual Studio with a Microsoft account, work account, or school account](signing-in-to-visual-studio.md#sign-in-to-your-account). You can add multiple GitHub accounts to the IDE. The first account added becomes the **active** account, but you can switch the active account to another one at any time. Adding multiple GitHub accounts impacts Copilot, and version control scenarios,  as well as general GitHub authentication experiences across Visual Studio.

If you have [GitHub Copilot installed](visual-studio-github-copilot-install-and-states.md), you can add a GitHub account with a Copilot subscription by selecting **Sign in to use Copilot** from the [GitHub Copilot status icon](visual-studio-github-copilot-install-and-states.md#copilot-is-inactive) or [**Sign up for Copilot Free**](copilot-free-plan.md) from the chat window, even if you haven't [signed into Visual Studio with a Microsoft account, work account, or school account](signing-in-to-visual-studio.md#sign-in-to-your-account). You can now also sign in with your [Google account linked to your GitHub account](https://github.blog/changelog/2025-07-15-social-login-with-google-is-now-generally-available), offering more flexibility for authentication.

### Add a GitHub account at first launch

With Visual Studio 17.13 or later, you can now sign in with a GitHub account when you [launch Visual Studio for the first time](signing-in-to-visual-studio.md#sign-in).

:::image type="content" source="../ide/media/vs-2022/visual-studio-sign-in-pop-up-first-launch.png" alt-text="Screenshot showing sign in at Visual Studio first launch.":::

If you sign in with a GitHub account that doesn't have an active GitHub Copilot subscription, you can choose to **Activate Copilot Free** during first launch with Visual Studio 17.14 or later, or [sign up later](copilot-free-plan.md#get-started-with-copilot-free-in-visual-studio) from the GitHub Copilot badge in the IDE or the chat window.

> If [Copilot is disabled by your administrator](visual-studio-github-copilot-admin.md#disabling-copilot-skus), the first launch experience respects the group policy.

If you choose to not sign in with GitHub at first launch, you can add your GitHub account later using the **profile card** or the **Account Settings** dialog as follows.

### Add a GitHub account from the Copilot chat window

If you have [GitHub Copilot installed](visual-studio-github-copilot-install-and-states.md), you can add a new or existing GitHub account by selecting [**Sign up for Copilot Free**](copilot-free-plan.md) from the Copilot chat window, even if you haven't [signed into Visual Studio](signing-in-to-visual-studio.md#sign-in-to-your-account).

You can also sign in with your [Google account linked to your GitHub account](https://github.blog/changelog/2025-07-15-social-login-with-google-is-now-generally-available), offering more flexibility for authentication.

In Visual Studio 17.14.10 or later, you can add your Google account more seamlessly by selecting **Sign up with Google**.

:::image type="content" source="media/vs-2022/copilot-free/sign-up-for-copilot-free.png" alt-text="Screenshot of Sign up for Copilot Free in the Chat window.":::

### Add a GitHub account from the **profile card**

Select the **Sign in** link in the upper-right corner of the Visual Studio environment and sign in with a [Microsoft account, work account, or school account](signing-in-to-visual-studio.md) or a GitHub account.

:::image type="content" source="../ide/media/vs-2022/signin-profile-card.png" alt-text="Screenshot showing profile card in Visual Studio.":::

Then, follow these instructions to add your GitHub account.

1. Select the icon with your profile name in the upper-right corner of the Visual Studio environment, select **GitHub** if you haven't already signed in or **Add another account**, and then select **GitHub**.

    :::image type="content" source="../ide/media/vs-2022/add-another-account-github-profile-card.png" alt-text="Screenshot of using Add another account option to add a GitHub account from profile care.":::

1. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

1. The GitHub account you added will now be present in your profile card. Note that the account you signed in with first is the **Active** account.

    :::image type="content" source="../ide/media/vs-2022/show-both-accounts-flyout-profile-card.png" alt-text="Screenshot showing both accounts on the sign in profile.":::

::: moniker-end

### Add a GitHub account from the **Account settings** dialog

::: moniker range="<=vs-2019"

1. Open the Account Settings dialog by going to **File** > **Account Settings...**.

1. From the **All Accounts** submenu, select **+ Add** to add an account, and select **GitHub**.
    
    :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Select add GitHub account":::

1. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Success window in browser":::

1. Your GitHub account will now be present in the **All Accounts** submenu.

   :::image type="content" source="../ide/media/show-both-accounts.png" alt-text="Both accounts showing":::
   
::: moniker-end
   
::: moniker range=">=vs-2022"

1. Open the Account Settings dialog by going to **File** > **Account Settings...**.

1. From the **All Accounts** submenu, select **+ Add** to add an account, and then select **GitHub**.

   :::image type="content" source="../ide/media/vs-2022/account-settings-sign-in-add-github.png" alt-text="Screenshot showing the Add GitHub account option.":::

1. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

1. Your GitHub account will now be present in the **All Accounts** submenu. This account becomes the **Active** account.

   :::image type="content" source="../ide/media/vs-2022/account-settings-multiple-github-accounts.png" alt-text="Screenshot showing multiple GitHub accounts on the Account settings dialog.":::

### Switch the **active** account

You can switch the active account to another signed-in GitHub account from the **profile card** or the **Account Settings** dialog.

**Switch using profile card**

Select the **Sign in** link in the upper-right corner of the IDE, select **...** for the account you want to make the new **active** account, then select **Set as active account**.

:::image type="content" source="../ide/media/vs-2022/set-as-active-account-profile-card.png" alt-text="Screenshot showing setting a different active GitHub account using profile card.":::

**Switch using Account Settings**

Open **Account options** by clicking **...** for the account you want to make the new **active** account, then select **Set as active account**.

:::image type="content" source="../ide/media/vs-2022/set-as-active-account.png" alt-text="Screenshot showing setting a different active account using Account Settings.":::

::: moniker-end

## Enable GitHub enterprise accounts

By default, Visual Studio only has public GitHub accounts enabled. Use the following steps to add a GitHub Enterprise Server account or an account associated with `.ghe.com` endpoints.

::: moniker range="<=vs-2019"

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** and search for the **Accounts** options.

    :::image type="content" source="../ide/media/vs-2022/add-github-enterprise-account.png" alt-text="Screenshot of GitHub Account.":::

1. Then, check the box to **Include GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

   :::image type="content" source="../ide/media/github-enterprise-endpoint-signin.png" alt-text="Screenshot showing Sign in with GitHub Enterprise.":::

1. After you enter your GitHub Enterprise server address, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

::: moniker-end

::: moniker range=">=vs-2022"

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** > **More Accounts**.

    :::image type="content" source="../ide/media/vs-2022/add-github-enterprise-cloud-server-accounts.png" alt-text="Screenshot of GitHub Account.":::

1. Then, check the box to **Include GitHub Enterprise Cloud and GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

   :::image type="content" source="../ide/media/vs-2022/github-enterprise-endpoint-signin.png" alt-text="Screenshot showing the Sign in with GitHub Enterprise.":::

1. After you enter your GitHub Enterprise URL, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

> [!NOTE]
>  To add an account to access `github.com` resources, such as `github.com/enterprises/*`, follow the [steps for adding public GitHub accounts](#adding-public-github-accounts).

::: moniker-end

## Add GitHub Enterprise Managed User (EMU) accounts

You can add your GitHub EMU account as follows:

::: moniker range=">=vs-2022"

### Manage accounts using the profile card

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Then, select **Add another account** > **GitHub**. 

    :::image type="content" source="../ide/media/vs-2022/add-another-account-github.png" alt-text="Screenshot of adding Enterprise Managed User.":::

1. You'll be redirected to the browser, where you can sign in with your GitHub EMU credentials.

::: moniker-end

### Manage accounts using the Account Settings dialog

::: moniker range="<=vs-2019"

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Open the Account Settings dialog by selecting **Account settings** or by going to **File** > **Account Settings...**. 

   :::image type="content" source="../ide/media/vs-2019/account-settings-1.png" alt-text="Screenshot of the Account Settings window.":::

1. From the **All Accounts** submenu, select **+ Add** dropdown to add an account, and then select **GitHub**.

   :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Screenshot showing how to select and add a GitHub account.":::

1. Select **GitHub Enterprise** on the **Connect to GitHub** dialog.

::: moniker-end

::: moniker range=">=vs-2022"

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

## Remove an account

::: moniker range="vs-2019"

To remove an account, select **Remove** for the account you want to remove from the **All Accounts** submenu in the **Account Settings** dialog.

1. Select **File > Account Settings...**.
1. **All Accounts** lists all accounts signed into Visual Studio. Select **Remove** for the account you want to remove.
1. Confirm the removal on the dialog that appears.

::: moniker-end

::: moniker range=">=vs-2022"

To remove an account:

1. Select the icon with your profile name in the upper-right corner of your Visual Studio environment.
1. Select **Remove account** for the account you want to remove.

   :::image type="content" source="media/vs-2022/signing-in-to-visual-studio/remove-an-account.png" alt-text="Screenshot of removing an account.":::

You can also use the **Account Settings** dialog to remove an account.

1. Select **File > Account Settings...**.
1. **All Accounts** lists all accounts signed into Visual Studio. Select **Remove** for the account you want to remove.
1. Confirm the removal on the dialog that appears.

   :::image type="content" source="media/vs-2022/signing-in-to-visual-studio/remove-an-account-account-settings.png" alt-text="Screenshot of removing an account in Account Settings.":::
::: moniker-end

## Troubleshooting sign in issues

If you're experiencing issues when adding or re-authenticating GitHub accounts, try the following steps:

### HTTP Strict Transport Security (HSTS) issues
Verify that HTTP Strict Transport Security (HSTS) is not enabled for `localhost` on your system's default web browser:
- On Microsoft Edge, you can type: edge://net-internals/#hsts and enter `localhost` under the **Delete domain security policies** section.
- On Google Chrome, type: chrome://net-internals/#hsts and enter `localhost` under the **Delete domain security policies** section.

### Run-as issues
Running Visual Studio using an account that doesn't match your signed-in Windows account, may cause issues when adding GitHub accounts to Visual Studio. You may encounter this issue when using 3rd party products that attempt to run Visual Studio elevated.

You can verify the user by following these steps:
1. Open the `Task Manager`
2. Navigate to the `Details` tab
3. Search for the `devenv.exe` process
4. Ensure the username for that process matches the signed in Windows Account
   
To fix this, run Visual Studio as the user you're signed into Windows with, and then add your GitHub account. 

> [!NOTE]
> Please [report a problem](https://developercommunity.visualstudio.com/report?space=8&entry=problem) if you're still experiencing sign in issues.

## Related content
- [Sign in to Visual Studio](signing-in-to-visual-studio.md)
- [How Visual Studio makes version control easy with Git](../version-control/git-with-visual-studio.md)
- [Deploy your application to Azure using GitHub Actions workflows](../azure/azure-deployment-using-github-actions.md).
