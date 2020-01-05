using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("Tek kişilik", "150"));
            DropDownList1.Items.Add(new ListItem("Çift kişilik", "220"));
            DropDownList1.Items.Add(new ListItem("Aile boyu", "250"));

            for (int i = 1; i < 30; i++)
            {
                DropDownList2.Items.Add(i.ToString());
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /* int fiyat = 0, süre, fatura;
        switch(DropDownList1.SelectedValue)
        {
            case "1": fiyat = 150; break;
            case "2": fiyat = 220; break;
            case "3": fiyat = 250; break;
        }
        süre = int.Parse(DropDownList2.SelectedItem.Text);
        fatura = fiyat * süre;
         */
        Label1.Text = "Borcunuz:" + (int.Parse(DropDownList1.SelectedValue)*int.Parse(DropDownList2.SelectedValue)).ToString() + "TL";
    }
}