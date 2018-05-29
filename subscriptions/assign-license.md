---
title: Assign licenses to Visual Studio Subscriptions | Microsoft Docs
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 10/03/2017
ms.topic: Get-Started-Article
description:  Learn how administrators can assign licenses to subscribers
ms.prod: vs-subscription
ms.technology: vs-subscriptions
searchscope: VS Subscription
---

# Assigning licenses in the Visual Studio subscriptions administrator portal

As a Visual Studio subscriptions administrator, you can use the Visual Studio Subscriptions administrator portal to assign subscriptions to individual users.  
You can assign them one at a time, or use the "bulk add" feature to upload lists of subscribers with their subscription information quickly and easily. 

## Assigning a single user
If you have available licenses for Visual Studio subscriptions, you can assign these licenses to new users for them to access their subscription benefits. 
1.  Sign in to the [administrator portal](https://manage.visualstudio.com)

2.	To assign a single Visual Studio subscriber, at the top of the table, click **Add**.

    <img alt="Add subscriber" src="_img\assign-license-add\assign-license-add.png" style="border: 1px solid #CCCCCC" />

3.	Enter the information into the form fields for the new subscriber. If your organization is using Azure Active Directory, this field acts as a search function to find people in your current directory so you can select the correct user from the search results. Once you select that person, their name, sign-in email and notification email will automatically populate as you see below. 

    If your organization is not using Azure Active Directory (Azure AD), but has a different email for receiving emails than the one to be used to sign in, you have the option for entering it here. Select the hyperlink labeled “Add a different email for receiving communication”. 

    **Access to Downloads:**  
    If you want this subscriber to have accees to software downloads when they sign into the [Visual Studio Subscriptions Portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs), make sure to leave the downloads toggle enabled. If you choose to disable downloads, the user will not have access to software downloads, but will still have access to all other benefits included in the subscription. 
    
    When you’re done choosing the options for this subscriber, click **Add**.

    <img alt="Enter subscriber information" src="_img\assign-license-add\add-subscriber-1.png" style="border: 1px solid #CCCCCC" />
    <img alt="Enter subscriber information" src="_img\assign-license-add\add-subscriber-2.png" style="border: 1px solid #CCCCCC" />

4.	After adding the subscriber, an Assignment Email will be automatically sent to the new subscriber with further instructions. You can send the Assignment Email again at any time by selecting the subscriber and clicking the **Resend** button in the top menu.

    <img alt="Subscriber added" src="_img\assign-license-add\add-subscriber-complete.png" style="border: 1px solid #CCCCCC" />

## Bulk assignments
1.	To add multiple subscribers at once, navigate to the **Manage Subscribers** tab. In the ribbon at the top, click **Bulk Add**. 

    <img alt="Bulk add" src="_img\assign-license-add\bulk-assign-add.png" style="border: 1px solid #CCCCCC" />

2. Bulk assign uses a Microsoft Excel template to upload subscribers. In the Upload Multiple Subscribers dialog box, click **Download** to download the template. Always download the latest version of this template. If you use an older version, your bulk upload may fail.

    <img alt="Upload multiple subscribers" src="_img\assign-license-add\bulk-assign-upload.png" style="border: 1px solid #CCCCCC" />

3.	In the Excel spreadsheet, fill out the fields with the information for the individuals you want to assign subscriptions to. Reference is an optional field. If you have filled out any part of the template incorrectly, you should see an error message describing the problem. Save the file locally once done.
**To help ensure a smooth upload, observe the following best practices:**
    - Ensure that none of the form fields contain commas.
    - Remove spaces before and after form fields such as users’ names.
    - Make sure users’ names do not contain extra spaces between two-part first or last names (e.g. two-part first name such as “Maggie May” should not be typed as “Maggie  May” as the system will not trim the extra space.)
    <img alt="Bulk add template" src="_img\assign-license-add\bulk-template.png" style="border: 1px solid #CCCCCC" />

4.	Return to the Visual Studio Subscriptions Administration portal and in the Upload Multiple Subscribers dialog box, click **Browse**. Navigate to the Excel file you saved and click **OK**. You will see the upload progress on the screen. 

    <img alt="Bulk add upload" src="_img\assign-license-add\bulk-assign-upload-2.png" style="border: 1px solid #CCCCCC" />

If the template contains errors, the upload will fail, and you will be shown the errors so you can correct the template and attempt the bulk upload again.
    <img alt="Upload fail" src="_img\assign-license-add\bulk-assign-upload-fail.png" style="border: 1px solid #CCCCCC" />

When the upload is successful, you'll see the list of subscribers and a confirmation message.

   <img alt="Upload complete" src="_img\assign-license-add\bulk-assign-upload-complete.png" style="border: 1px solid #CCCCCC" />