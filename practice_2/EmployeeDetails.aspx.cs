using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

            try
            {
                var idFormat = "^[A-z]{2}_[0-9]{3}$";//DK_003
                var letterValidations = @"^[a-zA-Z]+$"; 
                var numberValidation = @"^[0-9]*$";

                if (string.IsNullOrEmpty(txtEid.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Employee ID')", true);
                }
                else if (string.IsNullOrEmpty(txtEname.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Employee Name')", true);
                }
                else if (string.IsNullOrEmpty(txtHrs.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Working Hours')", true);
                }
                else if (string.IsNullOrEmpty(txtPay.Text.ToString())) {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Payment Per Hour')", true);
                }
                else if (!Regex.Match(txtEid.Text.ToString(), idFormat).Success)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter ID in correct format')", true);
                }
                else if (!Regex.Match(txtEname.Text.ToString(), letterValidations).Success) {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter OnlyLettters for Employee Name')", true);
                }
                else if (!Regex.Match(txtHrs.Text.ToString(), numberValidation).Success) {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Only Numbers for Working Hours')", true);
                }
                else if (!Regex.Match(txtPay.Text.ToString(), numberValidation).Success)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Only Numbers for Payment Per Hour')", true);
                }
                else if (txtEname.Text.ToString().Length > 10)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter less than 10 characters for Employee name')", true);
                } 
                else if (Convert.ToInt32(txtHrs.Text.ToString()) < 150)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Working hours should be greater than 150')", true);
                }
                else if (Convert.ToDouble(txtPay.Text.ToString()) > 1500)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Working hours should be less than 1500')", true);
                }
                string eid = txtEid.Text.ToString();
                string ename = txtEname.Text.ToString();
                int hrs = Convert.ToInt32(txtHrs.Text.ToString());
                double sal = Convert.ToDouble(txtPay.Text.ToString());
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            
        }
    }
}