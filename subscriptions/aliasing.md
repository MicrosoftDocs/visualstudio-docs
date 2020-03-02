---
title: Signing in to Visual Studio Subscriptions May Fail When Using Aliases | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
<<<<<<< HEAD
ms.date: 02/09/2020
=======
ms.date: 02/14/2020
>>>>>>> 3c105990656cd509062ce60e52e776c794f6305d
ms.topic: conceptual
description: Sign-in may fail if aliases or friendly names are used
---

# Signing into Visual Studio subscriptions may fail when using aliases
Depending on the account type used to sign in, available subscriptions may not be correctly displayed when signing in to [https://my.visualstudio.com](https://my.visualstudio.com?wt.mc_id=o~msft~docs). One potential cause is the use of "aliases" or "friendly names" in place of the sign-in identity to which the subscription is assigned. This is called "aliasing".

## What is aliasing?
The term “aliasing” refers to users having different identities to sign in to Windows (or your Active Directory) and to access email.

<<<<<<< HEAD
Aliasing can be encountered when a company has a Microsoft Online Service for their directory sign-in, like 'JohnD@contoso.com', but users access their email accounts using aliases or friendly names, such as 'John.Doe@contoso.com'. For many customers who manage their subscriptions through the Volume Licensing Service Center (VLSC), this can result in an unsuccessful sign-in experience as the email address provided ('John.Doe@contoso.com') does not match the directory address ('JohnD@contoso.com') required for successful authentication through the “Work or School Account” option.  Make sure your users are using the “Sign-in Email Address” as listed in the admin portal at https://manage.visualstudio.com to access their subscriptions. 

## What are the potential issues?

Depending on the subscriber’s account type, they may encounter one of two issues. 

### Work or school account UPN mismatch issue 
A UPN mismatch can be encountered when a company has an Active Directory set up where the UserPrincipalName (UPN) is not same as the Primary SMTP Address. 

#### How to detect if your sign-in address is impacted by a UPN mismatch 

1. Sign into https://my.visualstudio.com/subscriptions using the sign-in address mentioned in your subscription assignment email.

2. Verify that the sign-in email address listed at the top right of the page matches the address you used to sign in.  If it does not, your UPN is mismatched and you will not be able to view your subscription. 

> [!div class="mx-imgBorder"]
> ![Sign in email address](_img//aliasing/sign-in-email.png)

#### How to fix a UPN mismatch

1. Access the Visual Studio Administration Management portal https://manage.visualstudio.com 

2. Locate the subscriber having the UPN mismatch issue. (The [Filter](search-license.md) feature can make it easy to find a subscriber.)

3. Change the sign-in mail address to the subscriber's UPN 

0. Save the changes 

0. Inform the subscriber to sign out of the subscriber portal and access again using the UPN 

### Personal account aliasing issue

Personal subscription accounts can also experience issues if the email address used to sign in to the Visual Studio Subscriptions portal does not match the email address associated with the subscription. 

#### How to detect if your personal subscription account is impacted by an aliasing issue

1. Sign in to https://my.visualstudio.com/subscriptions

0. Verify that the sign-in email address listed at the top right of the page matches the address you used to sign in.  If the signed-in email address is not the same as the email address used to access the website there is a conflict between your account and the alias.

#### How to fix an alias issue

The Visual Studio platform prioritizes the primary alias to show subscription details. 

1. Go to **Manage how you sign in to Microsoft**. Sign in to your Microsoft account if prompted. 

2. Under Account aliases, select **Make primary** next to the email address used to assign the subscription. 

> [!div class="mx-imgBorder"]
> ![Set the primary email address](_img//aliasing/account-aliases.png)

3. Sign out of the Visual Studio Subscriptions portal (https://my.visualstudio.com) 

4. Sign back in using the account used to assign the subscription which should now be configured as primary alias. 

## Preventing aliasing issues

As an administrator, there are two options to ensure your subscribers have a successful sign-in experience on [https://my.visualstudio.com](https://my.visualstudio.com?wt.mc_id=o~msft~docs).
- The first option (recommended), is to leverage the directory account as the sign-in for the Visual Studio Subscriptions portal at https://my.visualstudio.com.  
- The second option (less secure), is to allow your subscribers to sign in using a different email address than their directory email address.

Both of these options are configured in the admin portal by completing the following steps:  
1. Sign into https://manage.visualstudio.com 

0. If you are altering a single user, select that user in the table and right click to edit. This will open a panel where you can modify the sign-in email address. Make the necessary updates in the sign-in email address field. Click save and the changes will take effect.  

0. If you need to make these changes to a large quantity of users, you can utilize the bulk edit feature. Read the [Edit multiple subscribers using bulk edit](https://docs.microsoft.com/en-us/visualstudio/subscriptions/edit-license#edit-multiple-subscribers-using-bulk-edit) article for more information.

> [!NOTE]
> For both individual and bulk changes, the subscribers will receive an email with instructions that their sign-in email address has changed and they will need to sign in using the updated email address. It’s also important to note that if the subscriber previously activated benefits under the other sign-in address, they’ll need to continue using the other sign-in address to access them.  

## Next steps
Learn more about managing Visual Studio subscriptions.
- [Assign individual subscriptions](assign-license.md)
- [Assign multiple subscriptions](assign-license-bulk.md)
- [Edit subscriptions](edit-license.md)
- [Determine maximum usage](maximum-usage.md)

=======
Aliasing can be encountered when a company has a Microsoft Online Service for their directory sign-in, like 'olivia@contoso.com', but users access their email accounts using aliases or friendly names, such as 'OliviaG@contoso.com'. Make sure your users are signing in using the "Sign-in Email Address" as listed in the Visual Studio Subscriptions Administration Portal at https://manage.visualstudio.com to access their subscriptions

## As an administrator, what options do I have?

Depending on the subscriber's account type, find the applicable solution below:

### Work or school account UPN mismatch issue

A User Principal Name (UPN) mismatch can be encountered when a compnay has an Active Diretory set up where the UPN is not the same as the Primary SMTP Address. 

#### How to detect if a user's sign-in address has a UPN mismatch

Have the user complete the following steps:

1. Sign in to https://my.visualstudio.com using the sign-in address mentioned in their subscription assignment email.  

    > [!NOTE]
    > If they don't have their subscription assignment email, you can resend it to them from within the adminstration portal.  

2. Click on the **Subscriptions** tab.
3. Verify that the email address displayed in the upper right where it says "You are signed in as..." is the same as the sign-in email address in their subscription assignment email.  If it isn't, they will not be able to access their subscription benefits. 

   > [!div class="mx-imgBorder"]
   > ![Subscriptions page](_img/aliasing/aliasing-subscriptions-page.png)

#### How to correct the UPN mismatch

1. Access the Visual Studio Administration Management portal at https://manage.visualstudio.com 

2. Locate the user having the UPN mismatch issue.  The [Filter](search-license.md) feature can make this easier if you have a lot of subscriptions. 

3. Change the Sign-in Email address to the user’s UPN.

4. Save the changes 

5. Ask the user to logout of the subscriber portal and sign in again using the UPN.   

### Personal account aliasing issue

Aliasing issues can also impact personal accounts. 

#### How to detect if a personal account has an aliasing issue

1. Sign in https://my.visualstudio.com.

2. Click on the **Subscriptions** tab and check the address with which you are signed in. 

3. If the signed-in email address is not the same as the email address used to access the website there is a conflict between your account and the alias. 

#### How to fix a personal account aliasing issue

The Visual Studio subscriptions platform prioritizes the primary alias to show subscription details.  To resolve the issue, you need to make a different email alias your primary alias for signing in. 

1. Go to [Manage how you sign in to Microsoft](https://go.microsoft.com/fwlink/p/?linkid=842796).
2. Sign in to your Microsoft account if prompted. 
3. Under Account aliases, select **Make primary** next to the email address used to assign the subscription. 
4. Under Account aliases, select Make primary next to the email address used to assign the subscription. 
5. Sign out of the Visual Studio Subscriber portal (https://my.visualstudio.com) 
6. Access the portal again using the new primary alias. 

### Ensure a successful experience for your users

As an administrator, there are two options to ensure your subscribers have a successful sign-in experience on https://my.visualstudio.com. 

- The first option (recommended) is to leverage the directory account as the sign-in address on https://manage.visualstudio.com.
- The second option, which is less secure, The second option (less secure), is to allow your subscribers to sign in using a different email address than their directory email address.

Both options are configured in the admin portal by completing the following steps:

1. Sign into https://manage.visualstudio.com 

2. If you are altering a single user, select that user in the table and right click to edit. This will open a panel where you can modify the sign-in email address.  

3. Make the necessary updates in the sign-in email address field. 

4. Click save and the changes will take effect.  
If you need to make these changes to a large quantity of users, you can utilize the bulk edit feature. Read the **Edit multiple subscribers using bulk edit** section of our [Edit subscriptions]](edit-license.md) article for more information about that process.  

## Next steps
Learn more about managing Visual Studio subscriptions.
- [Assign individual subscriptions](assign-license.md)
- [Assign multiple subscriptions](assign-license-bulk.md)
- [Edit subscriptions](edit-license.md)
- [Delete subscriptions](delete-license.md)
- [Determine maximum usage](maximum-usage.md)

>>>>>>> 3c105990656cd509062ce60e52e776c794f6305d
## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)
<<<<<<< HEAD

=======
>>>>>>> 3c105990656cd509062ce60e52e776c794f6305d
