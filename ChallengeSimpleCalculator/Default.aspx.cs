using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            double sum = number1 + number2;
            answerLabel.Text = sum.ToString();
        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            double diff = number1 - number2;
            answerLabel.Text = diff.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            double prod = number1 * number2;
            answerLabel.Text = prod.ToString();
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            double quo = number1 / number2;
            answerLabel.Text = quo.ToString();
        }

        protected void exButton_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            if ((number2 % 1) == 0) {
                double prod = 1;
                for (int i = 0; i < Math.Abs(number2); i++)
                {
                    prod *= number1;
                }
                if(number2 < 0) {
                    prod = 1 / prod;
                }
                answerLabel.Text = prod.ToString();
            } else {
                answerLabel.Text = "Exponent must be an integer.";
            }
        }
    }
}