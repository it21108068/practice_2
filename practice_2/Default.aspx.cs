using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_2
{
    public partial class _Default : Page
    {
        SqlConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.con = new DBconnection().createConnection();
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            
            try
            {
                //declare patterns
                var letterValidations = @"^[a-zA-Z]+$"; //mewa js walin yana nisa var kiyla danne
                var numberValidation = @"^[0-9]*$";

                //always start doing validations from begining of the form ex: txt_Fname 
                //check the text field is null of empty
                if (string.IsNullOrEmpty(txt_fname.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter First Name')", true);
                }
                else if (string.IsNullOrEmpty(txt_Lname.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Last Name')", true);
                }
                else if (string.IsNullOrEmpty(txt_Age.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter age')", true);
                }
                else if (string.IsNullOrEmpty(txt_Num.Text.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Telephone Number')", true);
                }

                else if (ddl.SelectedValue == "-1")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please select gender')", true);
                }
                //uda widiyata validate karanna bari ewa pattern swidiyta(regex) validate karanna one
                else if (!Regex.Match(txt_fname.Text.ToString(), letterValidations).Success)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Only Letters')", true);
                }
                else if (!Regex.Match(txt_Lname.Text.ToString(), letterValidations).Success)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Only Letters')", true);
                }
                else if (!Regex.Match(txt_Age.Text.ToString(), numberValidation).Success)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter Only Numbers')", true);
                }
                //custom validation
                else if (Convert.ToInt32(txt_Age.Text.ToString()) < 18)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter a Age greter than 18')", true);
                }
                else if(txt_fname.Text.ToString().Length > 10)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Please Enter only 10 characters')", true);
                }
                //System.Diagnostics.Debug.WriteLine("Done");

                string fname = txt_fname.Text.ToString();
                string lname = txt_Lname.Text.ToString();
                int age = Convert.ToInt32(txt_Age.Text.ToString());
                string telephone = txt_Num.Text.ToString();
                string gender = ddl.SelectedValue.ToString();
                bool ckBox = CheckBox1.Checked;

                con.Open();
                //message eka
                string query = "INSERT INTO practice (fname, lname, age, gender, telephone, active) values('" + fname + "', '" + lname + "', " + age + ", '" + telephone + "', '" + gender + "', " + ckBox + ")";
               //message eka yawana address eka
                SqlCommand cmd = new SqlCommand(query, con);
                //message eka hambuna kiyna rply eka
                int rply = cmd.ExecuteNonQuery();//ExecuteNonQuery() --> DB ekata data daala rply ekk denawa

                if (rply == 0){
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Insert Success')", true);
                }
                else if(rply == 1){
                    ScriptManager.RegisterStartupScript(this, GetType(), "Validation", "alert('Insert Unsuccess')", true);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            

        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueOfDdl = ddl.SelectedValue.ToString().Trim();
            if (valueOfDdl == "0")
            {
                txt_Age.Text = "0";
                txt_Age.Visible = true;
                txt_Age.Enabled = true;
            }
            else if (valueOfDdl == "1")
            {
                txt_Age.Enabled = false; //disable
                txt_Age.Visible = true;
            }
            else if (valueOfDdl == "-1")
            {
                txt_Age.Visible = false; //age text box dissapear
                txt_Age.Enabled = true;
            }
        }
    }
}