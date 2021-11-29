using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CTCBE;
using CTCBAL;

namespace ClickToCart
{
    public partial class ViewUserDisplayGridView : System.Web.UI.Page
    {
        UserDisplayBAL GetUserObj = new UserDisplayBAL();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void refereshdata()
        {

            Response.Redirect("~/ViewUserDisplayGridView.aspx");

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            UserDisplayRequestBE request = new UserDisplayRequestBE();
            request.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["USERID"]);
            var response = GetUserObj.delete(request);
            refereshdata();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            RegisterRequest request = new RegisterRequest();
            request.Statement = "UPDATE";
            request.USERID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["USERID"]);
            TextBox txtUSER_NAME = GridView1.Rows[e.RowIndex].FindControl("USER_NAME") as TextBox;
            TextBox txtFIRST_NAME = GridView1.Rows[e.RowIndex].FindControl("FIRST_NAME") as TextBox;
            TextBox txtLAST_NAME = GridView1.Rows[e.RowIndex].FindControl("LAST_NAME") as TextBox;
            TextBox txtCONTACT_NUMBER = GridView1.Rows[e.RowIndex].FindControl("CONTACT_NUMBER") as TextBox;
            TextBox txtADDRESS = GridView1.Rows[e.RowIndex].FindControl("ADDRESS") as TextBox;
            TextBox txtCITY = GridView1.Rows[e.RowIndex].FindControl("CITY") as TextBox;
            TextBox txtZIP = GridView1.Rows[e.RowIndex].FindControl("ZIP") as TextBox;
            TextBox txtCOUNTRY = GridView1.Rows[e.RowIndex].FindControl("COUNTRY") as TextBox;

            TextBox txtEMAIL_ID = GridView1.Rows[e.RowIndex].FindControl("EMAIL_ID") as TextBox;
            TextBox txtPASSWORD = GridView1.Rows[e.RowIndex].FindControl("PASSWORD") as TextBox;

            request.USER_NAME = txtUSER_NAME.Text;
            request.FIRST_NAME = txtFIRST_NAME.Text;
            request.LAST_NAME = txtLAST_NAME.Text;
            request.CONTACT_NUMBER = txtCONTACT_NUMBER.Text;
            request.ADDRESS = txtADDRESS.Text;
            request.CITY = txtCITY.Text;
            request.ZIP = txtZIP.Text;
            request.COUNTRY = txtCOUNTRY.Text;
            request.EMAIL_ID = txtEMAIL_ID.Text;
            request.PASSWORD = txtPASSWORD.Text;

            var response = GetUserObj.UpdateDatas(request);
            refereshdata();






        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AfterAdminLogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}