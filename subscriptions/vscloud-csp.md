---
title: Visual Studio cloud subscription purchasing for CSPs
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 3/15/2018
Ms.topic: Get-Started-Article
Description:  Information for Cloud Solution Providers on how to buy and manage Visual Studio cloud subscriptions for your customers. 
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription

# Buy and manage Visual Studio cloud subscriptions for your customers

Partners in the [Cloud Solution Provider (CSP)](https://partner.microsoft.com/en-US/cloud-solution-provider) program can purchase 
Visual Studio Enterprise and Visual Studio Professional cloud subscriptions for their customers. 

[Compare cloud subscription options](https://www.visualstudio.com/vs/pricing)

## Prerequisites
You must first set up your customer tenant in the Partner Center and create an Azure subscription for this tenant. 
[Learn more](https://docs.microsoft.com/vsts/billing/csp/set-up-csp-customer)

## How to buy

<iframe src="//channel9.msdn.com/Shows/Visual-Studio-for-CSP-Partners/CSP-How-to-buy-Visual-Studio-Subscriptions/player" width="600" height="315" allowFullScreen="true" frameBorder="0"></iframe>

0. Log into the [Microsoft Partner Center](https://partnercenter.microsoft.com).
0. Choose **Customers** and select a customer to buy for.
0. Choose **Service Management**.
0. Choose **Visual Studio Marketplace**.
0. Make sure you're customer's name is in the upper right corner.
0. Choose **Subscriptions**.
0. Choose Enterprise or Professional and choose monthly or annual for Visual Studio.
0. Choose **Buy**.
0. Choose the Azure subscription to bill for the purchase.
0. Enter the number of users your customer needs.
0. Review the order and **Confirm** it.

>[!NOTE]
> You will need to follow these steps every time you purchase Visual Studio subscriptions as a CSP. At this time, there is no API
> for automation of purchasing.

Once you confirm the purchase, you can choose **Manage** to assign subscriptions to your customer's end users.  You can 
also access the Subscription Administration portal from the Partner Center by choosing **Service management**.  From there see the steps or video below.

## How to manage Visual Studio cloud subscriptions for your customer

<iframe src="//channel9.msdn.com/Shows/Visual-Studio-for-CSP-Partners/CSP-How-to-manage-Visual-Studio-Subscriptions/player" width="600" height="315" allowFullScreen="true" frameBorder="0"></iframe>

0. Log into the [Microsoft Partner Center](https://partnercenter.microsoft.com).
0. Choose **Customers** and the customer's name.
0. Choose **Service Management**.
0. choose **Manage Visual Studio Subscriptions**.

If you have more than one Azure subscription for this customer, use the drop-down menu to choose the Azure subscription through which 
you made the purchases.  The **License Summary** shows you the number of subscriptions that have been assigned and how many 
are available for each Visual Studio cloud subscription option.  The summary also allows you to purchase additional subscriptions 
or reduce the number of subscriptions.

Choose **add** to assign a subscription to a new user.  The displayed count updates, and the end user receives an email notification. 
The end user can then sign in using the email address you provided to activate their Visual Studio subscription in the .

To reassign a Visual Studio subscription to a different user, you can delete the current subscriber and add a new subscriber. 

If a subscriber hasn't activated their Visual Studio subscription, it may be because they missed the invitation email.  You can request that we resend the 
activation invitation to the user.

## View Visual Studio pricing for CSP partners

To view Visual Studio pricing for CSP partners, log into the [Partner Center](https://partnercenter.microsoft.com).  Choose
**Pricing and offers** from the left nav.  Choose the current month pricing file under **usage-based services** in
the upper right. Once the Excel spreadsheet downloads, go to the **Azure Price List** sheet, and
filter the **Meter Category** column to **Visual Studio**.

Here's how to interpret what you see on this spreadsheet:
| Meter category    |	Name                 |	Units	                             |           What this is                          |
|-------------------|------------------------|---------------------------------------|-------------------------------------------------|
| Visual Studio	    | Enterprise             |	Subscription	                     | Visual Studio Enterprise monthly subscription   || Visual Studio	    | Enterprise (Annual)    |	Annual Subscriptions                 | Visual Studio Enterprise annual subscription    |
| Visual Studio	    | Professional           |	Subscription	                     | Visual Studio Professional monthly subscription || Visual Studio	    | Professional (Annual)  |	Annual Subscriptions                 | Visual Studio Professional annual subscription  |
We offer a 5% discount on the 6th unit you buy (for a given customer) each month of each Visual Studio subscription. That�s why you see two rows for each subscription option. One row shows a "Minimum Value" of 0, which you should interpret as the base price for units 1 through 5. The other row shows a "Minimum Value" of 5, so this is the 5% discount price that applies to units 6 and above.

## FAQ
### Q: How are **monthly** cloud subscription charges processed?
A: At the first purchase, we bill a prorated quantity to cover the remaining days in the current month. For instance, if a purchase of 10 Visual Studio Professional monthly 
cloud subscriptions was made on April 15, then we would charge 5 units because there are 15 days left in the 30-day month, or 50% and we prorate the units charged by 50%. 
On the first of May, and each month thereafter until you cancel, the full 10 units will be billed.

When you increase the paid quantity later, we also prorate the increased units to cover the remaining days in the current month. So if you bought 1 more Visual Studio 
Professional monthly cloud subscription on May 10, we would bill roughly 0.677 units (21 days remaining in the 31-day month of May). 

### Q: How are **annual** cloud subscription charges processed?
A: At each purchase, we bill the full quantity purchased immediately. Charges are not spread over the year and there is no prorating. If you buy annual cloud subscriptions 
at different times in the year, you will have subscriptions renewing in different months. We do not make all of a customer's annual cloud subscriptions coterminous as is 
common with Microsoft volume licensing agreement purchasing.

### Q: How do cancelations work?
A: When you cancel a Visual Studio cloud subscription, you are canceling automatic renewal. The subscription continues until its normal renewal date and then simply expires. 
At expiration, the Visual Studio subscriber can no longer use Visual Studio or any other benefits from the subscription.

With monthly cloud subscriptions, cancelations take effect the first day of the next month. If you only cancel some of your customer's monthly cloud subscriptions, 
be sure to remove users on the first of the next month to ensure that the correct people continue to have active subscriptions assigned.

For annual cloud subscriptions, cancelations take effect the first day of the month following 12 months from the original purchase, or 12 months from the last annual 
renewal charge. For instance, if you bought a Visual Studio Enterprise annual cloud subscription on January 3, 2018 then it remains active until February 1, 2019 when 
it automatically renews for another year. If you cancel at any time between then and February 1, 2020 then the subscription will expire on February 1, 2020. There is no 
rebate for canceling part way through the subscription year with annual cloud subscriptions.

### Q: What kind of volume discounts are available for Visual Studio subscriptions?

A:  You get a 5% discount on the 6th and all subsequent subscriptions *within each type* of subscription:

* Visual Studio Professional monthly
* Visual Studio Professional annual
* Visual Studio Enterprise monthly
* Visual Studio Enterprise annual

So for example, if you buy 6 Visual Studio Professional monthly subscriptions and 5 Visual Studio Enterprise monthly subscriptions, you'll pay the regular price on
5 Professional, get a 5% discount on the 6th Professional, and pay regular price on all 5 Enterprise subscriptions.

Also, the discount only applies to charges in a given monthly billing period. So if you buy 5 Visual Studio Professional annual subscriptions in one month, 
and then you buy 5 more the next month, you'll pay the regular price on all 10 subscriptions.

These discounts are reflected in the pricing data within the Partner Center. 

### Q: Are there renewal discounts?

A:  No, prices for Visual Studio subscriptions are flat. The same price is offered for new subscriptions and continuing subscriptions.

### Q: Are there Azure dev/test pricing options for CSPs?

A: Not at this time. Your customers can take advantage of [Azure dev/test pricing](http://aka.ms/azuredevtestpricing), but we do not have anything 
specifically for CSPs.