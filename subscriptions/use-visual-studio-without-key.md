---
title: Access and authenticate the Visual Studio IDE without a product key
author: joseb-rdc
ms.author: amast
ms.manager:  shve
ms.date: 05/11/2026
ms.topic: how-to
description: Learn how to download, install, and access the Visual Studio IDE by signing in with your Visual Studio Subscription.
---

# Access and authenticate the Visual Studio IDE by signing in
Visual Studio Subscribers don’t need a product key to use the Visual Studio IDE. Instead, sign in with the account that your subscription is assigned to. When you sign in, Visual Studio automatically verifies your subscription and unlocks the IDE.

## How Visual Studio authentication works
Visual Studio authenticates access to the IDE through the account you sign in with. It checks for an active subscription associated with that account and maintains access using a license token tied to your account.
 
Once signed in, you can continue working without needing a product key.

## Download Visual Studio from the Visual Studio page
To get started, download the Visual Studio installer package from the Visual Studio page instead of from the subscription portal.
+ Go to [https://visualstudio.microsoft.com](https://visualstudio.microsoft.com). 
+ Select **Download Visual Studio** to download the installer. 
+ The installer package is downloaded to the default downloads folder on your computer. 
+ Start the installer.

The installer doesn’t determine licensing. Your subscription is verified when you sign in to the Visual Studio IDE. 

## Sign in to authenticate the IDE
After Visual Studio is installed:
+ Launch Visual Studio.
+ When prompted, sign in using the email address your Visual Studio Subscription was assigned to. This address is normally the one where you received a notification that a subscription was assigned to you.
  + If you skipped sign-in, select **Sign in** in the upper-right corner of the IDE, or go to **File** > **Account Settings**. For more sign in information to the IDE, visit [Sign in from the IDE](https://learn.microsoft.com/visualstudio/ide/signing-in-to-visual-studio#sign-in-from-the-ide-1)

Once you're signed in, Visual Studio verifies your subscription and authenticates your access.

## What to expect after signing in
+ In most cases, you remain signed in between sessions and don’t need to reauthenticate each time you open Visual Studio.
+ Visual Studio uses a license token tied to your signed-in account. You might be prompted to sign in again if:
  + You sign out of the IDE.
  + You’re offline for an extended period.
  + The license token needs to refresh.

## If sign-in doesn't work
If you can’t sign in, or Visual Studio doesn’t recognize your subscription:
+ Confirm you’re using the same account that your subscription is assigned to.
+ Review troubleshooting guidance for common sign-in issues. Including tenant limitations and account changes by visiting [Sign in or switch Visual Studio user accounts](https://learn.microsoft.com/visualstudio/ide/signing-in-to-visual-studio)

> [!Note]
> The Visual Studio [Subscriptions portal]( https://my.visualstudio.com/?wt.mc_id=o%7Emsft%7Edocs) and [admin portal]( https://manage.visualstudio.com/) don't support [GCC High tenants,]( https://learn.microsoft.com/office365/servicedescriptions/office-365-platform-service-description/office-365-us-government/gcc-high-and-dod) also known as private or government domains. This limitation also applies when you try to sign in to the Visual Studio integrated development environment (IDE). To access Visual Studio Subscriptions, your organization needs to have a public tenant. For assistance in creating a public tenant, contact [Azure support]( https://azure.microsoft.com/support/create-ticket/).

## Product keys
Visual Studio Subscriptions might include product keys for certain products. However, for the Visual Studio IDE, sign-in is the primary method use to verify your subscription and unlock access. 

Product keys aren’t available for all subscription levels. 

To review product keys that are available with your subscription, sign in to the [Visual Studio Subscriptions portal](https://my.visualstudio.com/ProductKeys).

## Support resources
+ For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp).
+ For assistance with Visual Studio IDE, visit [Visual Studio support](https://visualstudio.microsoft.com/support/).

## See also
+ [Visual Studio documentation](/visualstudio/)

## Next steps
+ [Learn how signing in works in the Visual Studio IDE](https://learn.microsoft.com/visualstudio/ide/signing-in-to-visual-studio)
+ [Learn how the Visual Studio IDE is included with Visual Studio Subscriptions and installed](https://learn.microsoft.com/visualstudio/subscriptions/vs-ide-benefit)
