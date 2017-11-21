---
Title: Assign licenses to Visual Studio Subscriptions
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 10/3/2017
Ms.topic: Get-Started-Article
Description:  Learn how administrators can assign licenses to subscribers
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
---

# Assigning Licenses in the Visual Studio Subscriptions Administrator Portal
## Assigning a single user
If you have available licenses for Visual Studio Subscriptions, you can assign these licenses to new users for them to access their subscription benefits. 
1.	To assign a single Visual Studio subscriber, at the top of the table, click **Add**.

![Add subscriber](_img\assign-license-add\assign-license-add.png)

2.	Enter the information into the form fields for the new subscriber. If your organization is using Azure Active Directory, then this field acts as a search function to find people in your current directory so you can select the correct user from the search results. Once you select that person, their name, sign-in email and notification email will automatically populate as you see below. 

If your organization has a different email for receiving emails than the one to be used to sign in, you have the option for entering it here. Select the hyperlink that indicates “Different email for communication than sign-in?”. 

If you want this subscriber to be able to sign into the [Visual Studio Subscriptions Portal](https:/my.visualstudio.com) and have access to software downloads and all other subscription services and resources (including Microsoft Azure, Visual Studio Team Services, Xamarin and Pluralsight training, technical support and others), make sure to leave the Downloads box checked. If you choose to uncheck this box, the user will not have access to software downloads, but access to all other benefits included in the subscription will be unaffected. When you’re done, click **Add**.

![Enter subscriber information](_img\assign-license-add\add-subscriber-1.png)
![Enter subscriber information](_img\assign-license-add\add-subscriber-2.png)

3.	After adding the subscriber, an Assignment Email will be automatically sent to the new subscriber with further instructions. You can send the Assignment Email again at any time by clicking the Resend button in the top menu.

![Subscriber added](_img\assign-license-add\add-subscriber-complete.png)

## Bulk assignments
1.	To add multiple subscribers at once, navigate to the Subscribers tab. In the ribbon at the top, click **Bulk Add**. 

![Bulk Add](_img\assign-license-add\bulk-assign-add.png)

2. Bulk assign uses a Microsoft Excel template to upload subscribers. In the Upload Multiple Subscribers dialog box, click **Download** to download the template. Always download the latest version of this template. If you use an older version, your bulk upload may fail.
!Upload Multiple Subscribers](_img\assign-license-add\bulk-assign-upload.png)
3.	In the Excel spreadsheet, fill out the fields with the information for the individuals you want to assign subscriptions to. Reference is an optional field. If you have filled out any part of the template incorrectly, you should see an error message describing the problem. Save the file on your hard drive when done.
**To help ensure a smooth upload, observe the following best practices:**
- Ensure that none of the form fields contain commas.
- Remove spaces before and after form fields such as users’ names.
- Make sure users’ names do not contain extra spaces between two-part first or last names (e.g. two-part first name such as “Maggie May” should not be typed as “Maggie  May” as the system will not trim the extra space)

![Bulk Add Template](_img\assign-license-add\bulk-template.png)

4.	Return to the Visual Studio Subscriptions Administration portal and in the Upload Multiple Subscribers dialog box, click **Browse**. Navigate to the Excel file you saved and click **OK**. You will see the upload progress on the screen. 

![Bulk Add Upload](_img\assign-license-add\bulk-assign-upload-2.png)

If the template contains errors, the upload will fail, and you will be shown the errors so you can correct the template and attempt the bulk upload again.

![Upload Fail](_img\assign-license-add\bulk-assign-upload-fail.png)

When the upload is successful, you'll see the list of subscribers and a confirmation message.

![Upload Complete](_img\assign-license-add\bulk-assign-upload-complete.png)