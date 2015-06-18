using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void summaryButton_Click(object sender, EventArgs e)
        {
            Label1.Text = isNotempty(Form).ToString();
            Label2.Text = isPositive(Form).ToString();
            Label3.Text = isNotEqual(pointsScoredTextBox1, pointsAllowedTextBox1).ToString();
            Label4.Text = isNotEqual(pointsScoredTextBox2, pointsAllowedTextBox2).ToString();
            Label5.Text = isNotEqual(pointsScoredTextBox3, pointsAllowedTextBox3).ToString();
            Label6.Text = isNotEqual(pointsScoredTextBox4, pointsAllowedTextBox4).ToString();
        }//summaryButton_Click();
        protected void clearButton_Click(object sender, EventArgs e)
        {
            clearForm(Form);
        }//END clearButton_Click()

        /// <summary>
        /// Checks the control and resets all textboxes and radio buttons
        /// </summary>
        /// <param name="container"></param>
        void clearForm(Control container){

            foreach(var control in container.Controls){
                if(control is TextBox)
                {
                    ((TextBox)control).Text = String.Empty;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }//END isNotempty()

        /// <summary>
        /// Checks all textboxes and radioButtonList to see if theyre empty
        /// </summary>
        /// <value>Returns true if validation passes</value>
        /// <param name="container">Takes a Control</param>
        bool isNotempty(Control container)
        {
            bool isValid = true;
            foreach (var control in container.Controls)
            {
                if (control is TextBox)
                {
                    if (((TextBox)control).Text == String.Empty) { 
                        return false;
                    }
                }
                 if (control is RadioButtonList)
                 {
                     if (((RadioButtonList)control).SelectedIndex == -1)
                     {
                         return false;
                     } 
                 }
            }
            return isValid;
        }//END isNotEmpty();

        bool isPositive(Control container)
        {
            int check = 0;
            bool isPos = true;
            foreach (var control in container.Controls)
            {
                if (control is TextBox)
                {
                   check = int.Parse(((TextBox)control).Text);
                        if (check <= 0)
                        {
                            return false;
                        }
                }
            }//END forLoop
            return isPos;
        }//END isPositive()

        bool isNotEqual(TextBox text1, TextBox text2)
        {
            bool isDifferent = true;
            int check1 = int.Parse(text1.Text);
            int check2 = int.Parse(text2.Text);
            if (check1 == check2)
            {
                return false;
            }
            return isDifferent;
        }//END areValuesEqual()

    }//END class 
}//END namespace assignment1
