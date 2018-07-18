---
title: Assign licenses to Visual Studio Subscriptions | Microsoft Docs
author: TerryGLee
ms.author: tglee
manager: douge
ms.date: 07/16/2018
ms.topic: conceptual
description:  Learn how administrators can assign licenses to subscribers
ms.prod: vs-subscription
ms.technology: vs-subscriptions
searchscope: VS Subscription
---

# Assign licenses in the Visual Studio subscriptions administrator portal

As a Visual Studio subscriptions administrator, you can use the administrator portal to assign subscriptions to individual users and groups of users.

For groups of users, you can assign subscriptions to them one at a time, or use the **Bulk Add** feature to upload lists of subscribers with their subscription information quickly and easily. 

## Individual assignments

Here's how to assign a Visual Studio subscriptions license to to a new user so that they can access the subscription benefits.

1. Sign in to the [administrator portal](https://manage.visualstudio.com).

2. To assign a license to a single Visual Studio subscriber, at the top of the table, select **Add**.

   ![Add a single subscriber](media\add-single-subscriber.png)

3. Enter the information into the form fields for the new subscriber. If your organization is using Azure Active Directory, this field acts as a search function to find people in your current directory so you can select the correct user from the search results. After you select that person, their name, sign-in email and notification email will automatically populate. 

   ![Add a new notification email address](media\add-new-subscriber-notification-email.png)

   If you want this subscriber to have access to software downloads when they sign into the [Visual Studio Subscriptions Portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs), make sure to leave the downloads toggle enabled in the **Download Settings** section. If you choose to disable downloads, the user will not have access to software downloads, but will still have access to all other benefits included in the subscription.

   ![Access to downloads](media\access-to-downloads.png)

   If you'd like to change the language in which the subscriber receives information, you can do so in the **Communication Preferences** section.

   ![Change the language to use when notification emails are sent](media\change-subscriber-communication-preference.png)

   If you'd like to add your own reference notes to the subscription, you can do so in the **Add reference** section.

   ![Add your own reference notes to each subscription](media\add-subscriber-reference-notes.png) 

    When you're done selecting options and entering data for the subscriber, choose **Add** at the bottom of the **Add Subscriber** fly-out.

   ![Choose the Add button](media\add-button.png)

4. After you add the subscriber, an Assignment Email will be automatically sent to the new subscriber with further instructions. You can send the Assignment Email again at any time by selecting the subscriber and clicking the **Resend** button in the top menu.

   ![Resend the activation email to any user or multiple users whenever you want to](media\resend-subscriber-activation-emails.png) 

## Bulk assignments

1. To add multiple subscribers at one time, navigate to the **Manage Subscribers** tab. In the ribbon at the top, click **Bulk Add**.

  ![Add multiple subscribers](media\add-multiple-subscribers.png)

1. Bulk assign uses a Microsoft Excel template to upload subscribers. In the Upload Multiple Subscribers dialog box, click **Download** to download the template.

  ![Download the Excel template to upload multiple subscribers](media\download-template-upload-subscribers.png)

  >![NOTE]
  > Always download the latest version of this template. If you use an older version, your bulk upload may fail.

1. In the Excel spreadsheet, fill out the fields with the information for the individuals that you want to assign subscriptions to. (*Reference* is an optional field.) Save the file locally after you're done.

  To help ensure a smooth upload, observe the following best practices:

    - Ensure that none of the form fields contain commas.
    - Remove spaces before and after form fields.
    - Make sure user's names do not contain extra spaces between two-part first or last names (for example, if a person has a two-part first name such as "Maggie May", it should be typed as "MaggieMay" because the system won't trim the extra space.)

1. Return to the Visual Studio Subscriptions Administration portal. In the **Upload Multiple Subscribers** dialog box, click **Browse**.

  ![Browse to your saved template to upload multiple subscribers](media\bulk-add-browse-saved-template.png)

1. Navigate to the Excel file that you saved, and then click **OK**.

  ![Upload the Excel template to upload multiple subscribers](media\bulk-upload-subscribers.png)

  An upload progress dialog appears.

  If the template contains errors, the upload will fail, and you will be shown the errors so that you can correct the template and attempt the bulk upload again.

  ![Error message if the upload of multiple subscribers fails](media\bulk-add-template-failed.png)

  When the upload is successful, you'll see the list of subscribers and a confirmation message.

  ![Confirmation message if the upload of multiple subscribers succeeds](media\bulk-add-template-success.png)