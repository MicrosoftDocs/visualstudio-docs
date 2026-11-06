---
title: Assign specific subscription GUIDs in the Visual Studio Subscriptions Admin Portal
author: a-haage
ms.author: amast
ms.manager: madownie
ms.date: 11/05/2026
ms.topic: how-to
description: Learn how admins can assign specific subscription GUID to users.
ms.custom: sfi-image-nochange
---

# Assign specific subscriptions in the Visual Studio Subscriptions Admin Portal

As a Visual Studio Subscription administrator, you can choose which available subscription to assign to a user by specifying its unique identifier, or GUID (Globally Unique Identifier).

When you assign a subscription through the standard process, you select a subscription level, and the Admin Portal manages the assignment. In most cases, you don't need to select a specific GUID.

However, assigning a specific GUID gives you more control over how your organization's available subscriptions are used. For example, you might want to assign a previously used subscription to a contractor who needs access for a limited period, while reserving unused subscriptions for a longer-term employee.

This article explains when to use specific GUID assignments, what to consider before reassigning a previously used subscription, and how to complete the process in the Admin Portal.

Watch the video or read on to learn how to assign specific subscription GUIDs to users. 

> [!VIDEO https://medius.microsoft.com/Embed/video-nc/0873adfc-6e4b-4676-9eee-76e79103c44e?r=253107379154]

## When should you assign a specific GUID

Consider assigning a specific GUID when you want to:
+ **Manage temporary or short-term assignments:** Assign a previously used subscription to an eligible contractor or temporary employee who needs access for a limited period.
+ **Prioritize unused subscriptions:** Reserve subscriptions that you didn't previously assign for users who are expected to need them for a longer term.
+ **Manage available subscription inventory:** Select a subscription based on its assignment history, subscription level, and expiration date rather than allowing the Admin Portal to select one automatically.

## Before you begin

### Check subscription status

Use the Admin Portal export to identify available subscriptions:

| Field | Value | Meaning |
|-------|-------|---------|
| Subscription Status | Assigned | Currently assigned to a user |
| Subscription Status | Unassigned | Available for assignment |
| Usage Status | New | Not assigned previously |
| Usage Status | Used | Assigned previously and might have benefits that were already claimed or used |

To assign a specific GUID, the subscription must be Unassigned. Its Usage Status can be **New** or **Used**.

### Before reusing a subscription

A previously assigned subscription might be partially used, meaning the previous subscriber used or claimed some of its available benefits. Because some benefits and usage limits might not reset when the subscription is reassigned, the next subscriber might not receive the same benefit availability as they would with a new subscription.

Before assigning a previously used or partially used subscription, verify:

+ **Reassignment restrictions:** Visual Studio subscriptions generally can't be reassigned to another user until at least 90 days after the previous assignment.
+ **Previously claimed benefits:** Some product keys and benefit limits might not reset after reassignment.
+ **Expiration:** Make sure the subscription remains valid for the required period.
+ **Subscription level:** Confirm that it provides the required access.

For more information, see [Delete Visual Studio subscription assignment](https://learn.microsoft.com/visualstudio/subscriptions/delete-license)

### Upload your new assignments

Download the **Bulk add** template, complete the required information for the subscriptions you want to assign, and upload the template. For more information, see [Add multiple users](assign-license-bulk.md). 

> [!IMPORTANT]
>
> Assigning a specific GUID doesn't override licensing requirements, reassignment restrictions, or benefit eligibility rules. Ensure the subscription is eligible for reassignment before proceeding.
>  

## Assign a specific GUID to a user

To assign a specific GUID, use the **Export** and **Bulk add** features in the Visual Studio Subscriptions Admin Portal.

**Step 1: Export your subscription inventory**

1. Sign in to the [Visual Studio Subscriptions Admin Portal](https://manage.visualstudio.com/).

2. Select **Export** to download your subscription information.

3. Open the downloaded Excel file.

The export includes subscription identifiers, assignment information, subscription levels, expiration dates, and usage status.

**Step 2: Identify the GUID you want to assign**

1. In the exported Excel file, locate the **Subscription GUID** column.

2. Filter the **Subscription Status** column to show subscriptions marked **Unassigned**.

3. Review the **Usage Status** column to distinguish previously used subscriptions from new subscriptions.

4. Check the subscription level and expiration date.

5. Copy the GUID for the subscriptions you want to assign.

If the subscription was previously used, confirm that it's eligible for reassignment.

**Step 3: Assign the GUID by using Bulk add**

1. Return to the Admin Portal.

2. On the **Manage Subscribers** tab, select **Add**, and then select **Bulk add**.

3. In the **Upload Multiple Subscribers** dialog, download the current Excel template.

4. Open the template and enter the required subscriber information, including the specific subscription GUID.

5. Save the completed file.

6. Return to the **Bulk add** dialog and upload the file.

7. Review the upload results and resolve any reported errors.

> [!IMPORTANT]
>
> Always download a new **Bulk add** template from the Admin Portal. Older templates might not contain the required fields and can cause the upload to fail.
>
> Although this process uses **Bulk add**, you can use it to assign a specific GUID to a single subscriber.
>
> For more information about the upload process, see [Assign subscriptions to multiple users](https://learn.microsoft.com/visualstudio/subscriptions/assign-license-bulk).

**Step 4: Verify the assignment**

After the upload completes:

1. Confirm that the subscriber appears in the Admin Portal.

2. Check that the correct subscription level is assigned.

3. Export the subscription inventory again if you need to confirm that the intended GUID is now associated with the subscriber.

### Troubleshooting

If your upload fails, review the following table:

| **Issue** | **What to check** |
|-----------|-------------------|
| GUID is already assigned | Confirm that the GUID has a Subscription Status of Unassigned. |
| Subscription level mismatch | Make sure the level entered in the template matches the level associated with the GUID. |
| Duplicate GUID | Each GUID can appear only once in the upload file. |
| Missing information | Complete all required fields in the template. |
| Template errors | Download a fresh template and check the Error message column. |

## Frequently asked questions

### Q: Can I assign a specific GUID to someone who already has a subscription?

To replace a user's existing subscription GUID, first delete their current subscription assignment. Then follow the steps in this article to assign the new GUID.

Before deleting an assignment, consider the effect on the subscriber's access and benefits.

### Q: Can I assign a GUID that was previously used by someone else?

Yes, provided the subscription is unassigned and eligible for reassignment. Keep in mind that some benefits and product key limits might not reset when a subscription is reassigned.

### Q: Does assigning a specific GUID give the subscriber additional benefits?

No. The subscriber's available benefits depend on their subscription level and applicable benefit eligibility rules, not on whether the GUID was selected manually.

### Q: Do I need to assign a specific GUID every time I add a subscriber?

No. For most assignments, the standard individual or bulk assignment processes are sufficient. Use specific GUID assignment when you need to control which available subscription is assigned.

## Related content

+ [Assign subscriptions to individual users](https://learn.microsoft.com/visualstudio/subscriptions/assign-license)
+ [Assign subscriptions to multiple users](https://learn.microsoft.com/visualstudio/subscriptions/assign-license-bulk)
+ [Delete Visual Studio subscription assignments](https://learn.microsoft.com/visualstudio/subscriptions/delete-license)
+ [Overview of the Visual Studio Subscriptions Admin Portal](https://learn.microsoft.com/visualstudio/subscriptions/using-admin-portal)
