---
title: "How to: Create an Event Receiver for a Specific List Instance | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, event receivers"
  - "event receivers [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Create an event receiver for a specific list instance
  A list instance event receiver responds to events that occur in any instance of a list definition. Although the event receiver template does not enable the targeting of a specific list instance, you can modify an event receiver that is scoped to a list definition to respond to events in a specific list instance.

 To target a specific list instance, in the *Elements.xml* for the event receiver, replace `ListTemplateId` with `ListUrl` and add the URL of the list instance.

## Create a list instance event receiver
 The following steps show how to modify a list item event receiver to respond only to events that occur in a custom announcements-list instance.

#### To modify an event receiver to respond to a specific list instance

1. In a browser, open the SharePoint site.

2. In the navigation pane, **Lists** link.

3. In the **All Site Content** page, choose the **Create** link.

4. In the **Create** dialog box, choose the **Announcements** type, name the announcement **TestAnnouncements**, and then choose the **Create** button.

5. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], create an event receiver project.

6. In the **What type of event receiver do you want?** list, choose **List Item Events**.

    > [!NOTE]
    > You can also select any other kind of event receiver that scopes to a list definition, for example, **List Email Events** or **List Workflow Events**.

7. In the **What item should be the event source?** list, choose **Announcements**.

8. In the **Handle the following events** list, select the **An item is being added** check box, and then choose the **Finish** button.

9. In **Solution Explorer**, under EventReceiver1, open *Elements.xml*.

     The event receiver currently references the Announcements list definition by using the following line:

    ```xml
    <Receivers ListTemplateId="104">
    ```

     Change this line to the following text:

    ```xml
    <Receivers ListUrl="Lists/TestAnnouncements">
    ```

     This directs the event receiver to respond only to events that occur in the new **TestAnnouncements** announcements list that you just created. You can change the `ListURL` attribute to reference any list instance on the SharePoint server.

10. Open the code file for the event receiver and put a breakpoint in the ItemAdding method.

11. Choose the **F5** key to build and run the solution.

12. In SharePoint, choose the **TestAnnouncements** link in the navigation pane.

13. Choose the **Add new announcement** link.

14. Enter a title for the announcement, and then choose the **Save** button.

     Notice that the breakpoint is hit when the new item is added to the custom announcements list.

15. Choose the **F5** key to resume.

16. In the navigation pane, choose the **Lists** link, and then choose the **Announcements** link.

17. Add a new announcement.

     Notice that the event receiver does not trigger on the new announcement because the receiver is configured to respond only to events in the custom announcement list instance, **TestAnnouncements**.

## See also
- [How to: Create an event receiver](../sharepoint/how-to-create-an-event-receiver.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
