---
title: Buy and manage cloud subscriptions for CSPs
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 04/28/2025
ms.topic: conceptual
description: Help for Cloud Solution Providers on how to buy and manage Visual Studio cloud subscriptions for customers and answers to frequently asked questions.
---
# Buy and manage Visual Studio cloud subscriptions for your customers

Partners in the [Cloud Solution Provider (CSP)](https://partner.microsoft.com/cloud-solution-provider) program can purchase
Visual Studio Enterprise and Visual Studio Professional cloud subscriptions for their customers.

[Compare cloud subscription options](https://visualstudio.microsoft.com/vs/pricing).

> [!NOTE]
> Microsoft ended the offering of **annual** Cloud Subscriptions for Visual Studio Professional and Visual Studio Enterprise. This change doesn't affect existing customers, who retain the ability to renew, modify, or cancel their current subscriptions without any disruption to their service. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio. Monthly subscriptions are still available. 

## Prerequisites

You must first set up your customer tenant in Partner Center and create an Azure subscription for this tenant.

[Learn more](/azure/devops/organizations/billing/csp/set-up-csp-customer)

## Who can buy Visual Studio subscriptions?

Anyone with [owner or contributor access](https://na01.safelinks.protection.outlook.com/?url=https%3A%2F%2Fdocs.microsoft.com%2Fen-us%2Fvsts%2Forganizations%2Fbilling%2Fadd-backup-billing-managers%3Fview%3Dvsts%2520%2520sa&data=02%7C01%7C%7Cb9e717e8abff47b0cd7e08d618edd860%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636723807145220358&sdata=aIaamEXHhx94KCYVY%2FFibqFzNBEqKPntpql867xAMgU%3D&reserved=0) to the Azure subscription can purchase Visual Studio subscriptions.

## How to buy

1. Sign in to [Partner Center](https://partner.microsoft.com/dashboard/home).
0. Choose **Customers** and select a customer to buy for.
0. Choose **Service Management**.
0. Choose **Visual Studio Marketplace**.
0. Make sure your customer's name is in the upper right corner.
0. Choose **Subscriptions**.
0. Choose Enterprise or Professional for Visual Studio.
0. Choose **Buy**.
0. Choose the Azure subscription to bill for the purchase.
0. Enter the number of users your customer needs.
0. Review the order and **Confirm** it.

>[!NOTE]
> You need to follow these steps every time you purchase Visual Studio subscriptions as a CSP. There's no API
> for automation of purchasing.

After you confirm the purchase, you can choose **Manage** to assign subscriptions to your customer's end users. You can
also access the Subscription Admin portal from the Partner Center by choosing **Service management** to see the steps or video.

## How to manage Visual Studio cloud subscriptions for your customer

1. Sign in to [Partner Center](https://partner.microsoft.com/dashboard/home).
0. Choose **Customers** and the customer's name.
0. Choose **Service Management**.
0. Choose **Manage Visual Studio Subscriptions**.

If you have more than one Azure subscription for this customer, use the drop-down menu to choose the Azure subscription through which you made the purchases. The **License Summary** shows you the number of subscriptions assigned and how many are available for each Visual Studio cloud subscription option. The summary also allows you to purchase more subscriptions or reduce the number of subscriptions.

Choose **add** to assign a subscription to a new user. The displayed count updates, and the end user receives an email notification. The end user can then sign in using the email address you provided to activate their Visual Studio subscription in the [Visual Studio subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs).

To reassign a Visual Studio subscription to a different user, you can delete the current subscriber and add a new subscriber.

If a subscriber didn't activate their Visual Studio subscription, it might be because they missed the invitation email. You can request that we resend the activation invitation to the user from within the Visual Studio admin portal too.

## View Visual Studio pricing for CSP partners

To view Visual Studio pricing for CSP partners, sign in to [Partner Center](https://partner.microsoft.com/dashboard/home). Choose the **Pricing** workspace button from the Home page. Choose the current month's pricing file under **Azure Plan pricing**. After the Excel spreadsheet downloads, go to the **Azure Price List** sheet, and filter the **Meter Category** column to **Visual Studio**.

Here's how to interpret what you see on this spreadsheet:

| Meter category    |   Name         |  Units         |           Item                                  |
|-------------------|----------------|----------------|-------------------------------------------------|
| Visual Studio     | Enterprise     |  Subscription  | Visual Studio Enterprise monthly subscription   |
| Visual Studio     | Professional   |  Subscription  | Visual Studio Professional monthly subscription |

We offer a 5% discount on the sixth unit you buy (for a given customer) each month of each Visual Studio subscription. You see two rows for each subscription option. One row shows a "Minimum Value" of zero, which you should interpret as the base price for units one through five. The other row shows a "Minimum Value" of five, which shows the 5% discount price that applies to units six and above.

## Frequently asked questions

### Q: How are **monthly** cloud subscription charges processed?

A: At the first purchase, we bill a prorated quantity to cover the remaining days in the current month. For instance, if a purchase of 10 Visual Studio Professional monthly cloud subscriptions were made on April 15, we would charge five units because there are 15 days left in the 30-day month (50%). We prorate the units charged by 50%. On the May 1, and each month thereafter until you cancel, the full 10 units are billed.

When you increase the paid quantity later, we also prorate the increased units to cover the remaining days in the current month. So, if you bought one more Visual Studio Professional monthly cloud subscription on May 10, we would bill roughly 0.677 units (21 days remaining in the 31-day month of May).

### Q: How do cancellations work?

A: When you cancel a Visual Studio cloud subscription, you cancel automatic renewal. The subscription continues until its normal renewal date and then simply expires. At expiration, the Visual Studio subscriber can no longer use Visual Studio or any other benefits from the subscription.

With monthly cloud subscriptions, cancellations take effect on the first day of the following month. If you only cancel some of your customer's monthly cloud subscriptions, be sure to remove users on the first day of the next month to ensure that the correct people continue to have active subscriptions assigned.

For annual cloud subscriptions, cancellations take effect on the first day of the month following 12 months from the original purchase, or 12 months from the last annual renewal charge. For instance, if you bought a Visual Studio Enterprise annual cloud subscription on January 3, 2018, then it remains active until February 1, 2019, when it automatically renews for another year. If you cancel between then and February 1, 2020, the subscription will expire on February 1, 2020. There's no rebate for canceling part way through the subscription year with annual cloud subscriptions.

### Q: What kind of volume discounts are available for Visual Studio subscriptions?

A: You get a 5% discount on the sixth and all subsequent subscriptions *within each type* of subscription:
+ Visual Studio Professional monthly
+ Visual Studio Enterprise monthly

So, for example, if you buy six Visual Studio Professional monthly subscriptions and five Visual Studio Enterprise monthly subscriptions, you pay the regular price on five Professional, get a 5% discount on the sixth Professional, and pay regular price on all five Enterprise subscriptions.

Also, the discount only applies to charges in any given monthly billing period. So, if you buy five Visual Studio Professional annual subscriptions in one month, and then you buy five more the next month, you'll pay the regular price on all 10 subscriptions.

These discounts are reflected in the pricing data within [Partner Center](https://partner.microsoft.com/dashboard/home).

### Q: Are there renewal discounts?

A: No, prices for Visual Studio subscriptions are flat. The same price is offered for new subscriptions and continuing subscriptions.

### Q: Are there Azure dev/test pricing options for CSPs?

A: Not at this time. Your customers can take advantage of [Azure dev/test pricing](https://azure.microsoft.com/pricing/dev-test/), but we don't have anything specifically for CSPs.

## Resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp).

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps Services documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)
+ [Partner Center documentation](/partner-center/)

## Next steps

See the [cloud billing FAQ](vscloud-billing-faq.yml) for answers to common billing questions.
