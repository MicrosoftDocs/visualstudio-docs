using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//<Snippet1>
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
//</Snippet1>

namespace CS.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        //<Snippet2>
        private MonthlyCalendarView MonthlyCalendarView1;
        //</Snippet2>
        //<Snippet3>
        protected void Page_Load(object sender, EventArgs e)
        {
            MonthlyCalendarView1 = new MonthlyCalendarView();
            this.Controls.Add(MonthlyCalendarView1);
            SPCalendarItemCollection items = new SPCalendarItemCollection();
            SPWeb thisWeb = SPControl.GetContextWeb(Context);

            if (CheckBoxList1.Items.Count == 0)
            {
                foreach (SPList listItem in thisWeb.Lists)
                {
                    if (listItem.BaseTemplate == SPListTemplateType.Events)
                    {
                        CheckBoxList1.Items.Add(new ListItem(listItem.Title));
                    }
                }
            }
            MonthlyCalendarView1.ItemTemplateName =
                "CalendarViewMonthItemTemplate";
            MonthlyCalendarView1.ItemAllDayTemplateName =
                "CalendarViewMonthItemAllDayTemplate";
            MonthlyCalendarView1.ItemMultiDayTemplateName =
                "CalendarViewMonthItemMultiDayTemplate";
        }
        //</Snippet3>
        //<Snippet4>
        protected void Button1_Click(object sender, EventArgs e)
        {
            SPCalendarItemCollection items = new SPCalendarItemCollection();
            SPWeb thisWeb = SPControl.GetContextWeb(Context);

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected == true)
                {
                    SPList calendarList = thisWeb.Lists[item.Text];
                    DateTime dtStart = DateTime.Now.AddDays(-7);
                    DateTime dtEnd = dtStart.AddMonths(1).AddDays(7);
                    SPQuery query = new SPQuery();
                    query.Query = String.Format(
                        "<Query>" +
                        "<Where><And>" +
                        "<Geq><FieldRef Name=\"{0}\" />" +
                        "<Value Type=\"DateTime\">{1}</Value></Geq>" +
                        "<Leq><FieldRef Name=\"{0}\" />" +
                        "<Value Type=\"DateTime\">{2}</Value></Leq>" +
                        "</And></Where><OrderBy><FieldRef Name=\"{0}\" /></OrderBy>" +
                        "</Query>",
                        "Start Time",
                        dtStart.ToShortDateString(),
                        dtEnd.ToShortDateString());

                    foreach (SPListItem listItem in calendarList.GetItems(query))
                    {
                        SPCalendarItem calItem = new SPCalendarItem();
                        calItem.ItemID = listItem["ID"].ToString();
                        calItem.Title = listItem["Title"].ToString();
                        calItem.CalendarType = Convert.ToInt32(SPCalendarType.Gregorian);
                        calItem.StartDate = (DateTime)listItem["Start Time"];
                        calItem.ItemID = listItem.ID.ToString();
                        calItem.WorkSpaceLink = String.Format(
                            "/Lists/{0}/DispForm.aspx", calendarList.Title);
                        calItem.DisplayFormUrl = String.Format(
                            "/Lists/{0}/DispForm.aspx", calendarList.Title);
                        calItem.EndDate = (DateTime)listItem["End Time"];
                        calItem.Description = listItem["Description"].ToString();
                        if (listItem["Location"] != null)
                        {
                            calItem.Location = listItem["Location"].ToString();
                        }
                        items.Add(calItem);
                    }
                    MonthlyCalendarView1.DataSource = items;
                }

            }

        }
        //</Snippet4>
    }
}
