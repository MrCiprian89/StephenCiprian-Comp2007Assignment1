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
        RadioButtonList[] radioButtons;
        TextBox[] scoredTextBox;
        TextBox[] allowedTextBox;
        TextBox[] spectatorTextBox;
        const int NUMOFGAMES = 4;
   
        protected void Page_Load(object sender, EventArgs e)
        {
            radioButtons = new RadioButtonList[NUMOFGAMES] { RadioButtonList1, RadioButtonList2, RadioButtonList3, RadioButtonList4 };
            scoredTextBox = new TextBox[NUMOFGAMES] { pointsScoredTextBox1, pointsScoredTextBox2, pointsScoredTextBox3, pointsScoredTextBox4 };
            allowedTextBox = new TextBox[NUMOFGAMES] { pointsAllowedTextBox1, pointsAllowedTextBox2, pointsAllowedTextBox3, pointsAllowedTextBox4 };
            spectatorTextBox = new TextBox[NUMOFGAMES] { spectatorsTextBox1, spectatorsTextBox2, spectatorsTextBox3, spectatorsTextBox4 };
        }

        protected void summaryButton_Click(object sender, EventArgs e)
        {
            Label1.Text = isNotEqual(scoredTextBox, allowedTextBox).ToString();
            if (isNotempty(Form)) {
                if (isPositive(Form)){
                    if (isNotEqual(scoredTextBox, allowedTextBox)){
                                    Label1.Text = "Total Games Won: " + gamesWon(radioButtons).ToString();
                                    Label2.Text = "Total Games Lost: " + gamesLost(radioButtons).ToString();
                                    Label3.Text = "Winning Percentage: " + ((gamesWon(radioButtons) / 4.00) * 100).ToString() + "%";
                                    Label4.Text = "Total Points Scored: " + calculateTotal(scoredTextBox).ToString();
                                    Label5.Text = "Total Points Allowed: " + calculateTotal(allowedTextBox).ToString();
                                    Label6.Text = "Total Point Differential: " + (calculateTotal(scoredTextBox) - calculateTotal  (allowedTextBox)).ToString();
                                    Label7.Text = "Total Spectators: " + calculateTotal(spectatorTextBox).ToString();
                                    Label8.Text = "Average Number of Spectators: " + (calculateTotal(spectatorTextBox) /  NUMOFGAMES).ToString();
                                }
                            }
                        }           
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
                    try
                    {
                        check = int.Parse(((TextBox)control).Text);
                        if (check <= 0)
                        {
                            return false;
                        }
                    }
                    catch
                    {                  
                        return false;
                    }
                }
            }//END forLoop
            return isPos;
        }//END isPositive()

        bool isNotEqual(TextBox[] text1, TextBox[] text2)
        {
            bool isDifferent = true;

            for (int i = 0; i < text1.Length; i++)
            {
                int check1 = int.Parse(text1[i].Text);
                int check2 = int.Parse(text2[i].Text);
                if (check1 == check2)
                {
                    return false;
                }
            }       
            return isDifferent;
        }//END areValuesEqual()

        int gamesWon(RadioButtonList[] radioList)
        {
            int win=0;
            for (int i = 0; i < radioList.Length; i++)
            {
                if (radioList[i].SelectedItem.Value.ToString() == "Win")
                {
                    win++;
                }
            }
            return win;
        }//END gamesWon()
        int gamesLost(RadioButtonList[] radioList)
        {
            int loss = 0;
            for (int i = 0; i < radioList.Length; i++)
            {
                if (radioList[i].SelectedItem.Value.ToString() == "Lose")
                {
                    loss++;
                }
            }
            return loss;
        }//END gamesLost()
        int calculateTotal(TextBox[] textbox)
        {
            int total = 0;
            for (int i = 0; i < textbox.Length; i++)
            {
                total += int.Parse(textbox[i].Text);
            }
            return total;
        }//END totalPointsScored()

    }//END class 
}//END namespace assignment1
