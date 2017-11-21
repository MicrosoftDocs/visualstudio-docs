---
title: Edit Subscriptions in the Administrator Portal | Visual Studio Marketplace
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 10/3/2017
Ms.topic: Get-Started-Article
Description:  Learn how administrators can edit subscription assignments.
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
---

# Editing Visual Studio Subscription Assignments

## Making changes to subscriber information
You can edit a subscriber’s information to correct errors or update information. 
**Please note that editing a subscriber’s email address will cause any existing benefits to be reset.**

To edit a subscriber, select the ellipses (…) that appear next to the subscriber’s email address when you hover your mouse over it. A dropdown will appear.  Select **edit** to modify the subscriber’s details. You can also double click on the subscriber's row in the grid to open the edit window.

![Select Subscriber to Edit](_img\edit-license\select-subscriber.png)

You can update the subscriber’s first name, last name, country, language and downloads. Edit the subscriber’s information, and then click **Save**.

![Edit Subscriber Details](_img\edit-license\edit-subscriber.png)

Note: If you need to change the subscription level for a subscriber, you will need to delete the user from the portal and add them again. Subscription levels are not editable.

## Editing multiple subscribers by using bulk edit

You can edit multiple subscribers at once using the bulk edit process. This feature is primarily used for organizations that are going through corporate email address changes or if an organization has decided to restrict access to downloads. **IMPORTANT:**  Subscription levels (i.e. Enterprise, Professional, etc.) and subscription GUIDs cannot be altered.  If you attempt an upload with these items changed, the upload will fail.  

1.	To edit multiple subscribers at once, navigate to the Subscribers tab. In the ribbon at the top, click **Bulk Edit**. 

![Editing a License - Bulk Edits](_img\edit-license\edit-license-bulk-edit.png)

2.  Bulk edit uses an Excel template to make edits to subscriber information. In the Bulk Edit box, click **Export this Excel** to download the current list of subscribers including all of their information. 

![Editing a License - Export Bulk Edits List](_img\edit-license\edit-license-bulk-edit-export.png)

3.	Next, save the file locally so you can easily find it and make any necessary changes prior to uploading it. To ensure a successful upload, **don’t edit the subscription level or the subscription GUID** as doing so will cause the upload to fail. 

4.	Return to the Visual Studio Subscriptions Administration portal and in the Bulk Edit dialog box, click **Browse**. Select the Excel file you saved and click **OK**. You will see the upload progress on the screen.

![Editing a License - Bulk Edits File Upload](_img\edit-license\edit-license-bulk-file-upload.png)

5.	Once you’ve uploaded the file, you will see a notification letting you know it was successful. 

![Editing a License - Bulk Edits Upload Complete](_img\edit-license\edit-license-bulk-upload-complete.png)


