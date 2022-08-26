---
title: Work with GitHub accounts in Visual Studio
ms.date: 04/28/2022
ms.topic: how-to
description: "Learn how to use Visual Studio with GitHub accounts."
ms.custom: devdivchpfy22
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: ">=vs-2019"
---
# Work with GitHub accounts in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

If you have a public GitHub or GitHub Enterprise account, you can add it to your Visual Studio keychain. After you add your account, you'll be able to take advantage of the platform integration by accessing and creating GitHub repositories, right from Visual Studio.

## Adding public GitHub accounts

You can add your public GitHub account if you're already signed into Visual Studio with a Microsoft account,  work account, or school account.

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Then, select **Account settings...** to manage your accounts. You can also open the Account Settings dialog by going to **File** > **Account Settings...**.

    :::image type="content" source="../ide/media/vs-2022/account-settings-1.png" alt-text="Screenshot of the Account Settings window.":::

1. From the **All Accounts** submenu, select the plus sign to add an account, and select **GitHub**.

    :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Select add GitHub account":::

1. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Success window in browser":::

1. You'll have both accounts present in your **All Accounts** submenu.

    :::image type="content" source="../ide/media/show-both-accounts.png" alt-text="Both accounts showing":::

If you're not already signed in to Visual Studio with a different account, select the **Sign in** link in the upper-right corner of the Visual Studio environment. You can also open the Account Settings dialog by going to **File** > **Account Settings...**. Then, follow the instructions above to add your GitHub account.

:::image type="content" source="../ide/media/vs-2022/signin-different-account.png" alt-text="Not signed to VS 2022":::

## Adding GitHub Enterprise Managed User (EMU) accounts

You can add your GitHub EMU account if you're already signed into Visual Studio with a Microsoft account, work account, or school account.

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Then, select **Account settings...** to manage your accounts. You can also open the Account Settings dialog by going to **File** > **Account Settings...**.

    :::image type="content" source="../ide/media/vs-2022/account-settings-1.png" alt-text="Screenshot of Enterprise Managed User.":::

1. From the **All Accounts** submenu, select the **+** or the **Add** dropdown to add an account, and then select **GitHub**.

    :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Screenshot showing how to select and add a GitHub account":::

1. You'll be redirected to the browser, where you can sign in with your GitHub EMU credentials.

> [!NOTE]
> Ensure you enter your GitHub EMU account credentials (the username has an underscore followed by the company name) on this page.

:::image type="content" source="../ide/media/github-enterprise-managed-users-sign-in.png" alt-text="Screenshot showing the GitHub sign in experience for the GitHub Enterprise Managed User account":::

After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

:::image type="content" source="../ide/media/github-success-signin.png" alt-text="Screenshot showing the sign-in success window in the browser":::

## Adding GitHub enterprise accounts

By default, Visual Studio only has public GitHub accounts enabled.

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** and search for the **Accounts** options.

    :::image type="content" source="../ide/media/vs-2022/add-github-enterprise-account.png" alt-text="Screenshot of GitHub Account.":::

1. Then, check the box to **Include GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

    :::image type="content" source="../ide/media/github-enterprise-endpoint-signin.png" alt-text="Sign in with GitHub Enterprise":::

1. After you enter your GitHub Enterprise server address, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

## Troubleshooting sign in issues
If you're experiencing issues when adding or re-authenticating GitHub accounts, try the following steps:

1. Verify that HSTS is not enabled for localhost on yours system's default web browser
    - On Micrsoft Edge, you can type: edge://net-internals/#hsts and enter "localhost" under the "Delete domain security policies" section
    - On Google Chrome, type: chrome://net-internals/#hsts and enter "localhost" under the "Delete domain security policies" section

> [!NOTE]
> Please [report a problem](https://developercommunity.visualstudio.com/report?space=8&entry=problem) if you are still having sign in issues.

## See also
- [Sign in to Visual Studio](signing-in-to-visual-studio.md)
