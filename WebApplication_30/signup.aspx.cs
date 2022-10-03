using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;



namespace WebApplication_30
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.fname = TextBox1.Text;
            cus.lname = TextBox3.Text;
            TextBox8.Text = Calendars.SelectedDate.ToLongDateString();
            cus.bdate = Calendars.SelectedDate;
            cus.city = TextBox5.Text;
            cus.state = TextBox6.Text;
            HttpCookie k = new HttpCookie("cusdata");
            k.Expires = DateTime.Now.AddMinutes(20);
            k.Values.Add("fname", cus.fname);
            k.Values.Add("lname", cus.lname);
            k.Values.Add("bdate", cus.bdate.ToLongDateString());
            k.Values.Add("city", cus.city);
            k.Values.Add("state", cus.state);
            TextBox7.Text = cus.fname;
            Response.Write(cus.fname);
            Response.Cookies.Add(k);




        }
    }
}
