using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Addition_Click(object sender, EventArgs e)
        {
            //check if the text values can be converted to number
            //I opted for using decimal just in case.
            //I also test for the presence of both numbers.
            //This code can be largely reused for the other three operators.

            if (CheckBoxValues())
            {
                decimal num1;
                decimal num2;
                decimal result;
                bool num1Test = decimal.TryParse(firstNumber.Text, out num1);
                bool num2test = decimal.TryParse(secondNumber.Text, out num2);
                if(num1Test && num2test)
                {
                    result = num1 + num2;  //Here's where the operator is used.
                    Result.Text = result.ToString();

                }
                else
                {
                    Result.Text = "Cannot do arithmetic without two numbers. Check inputs and try again.";
                }
 
            }
        }



        protected bool CheckBoxValues()
        {

            return true;
        }

        protected void Subtraction_Click(object sender, EventArgs e)
        {
            //check if the text values can be converted to number
            //I opted for using decimal just in case.
            //I also test for the presence of both numbers.
            //This code can be largely reused for the other three operators.

            if (CheckBoxValues())
            {
                decimal num1;
                decimal num2;
                decimal result;
                bool num1Test = decimal.TryParse(firstNumber.Text, out num1);
                bool num2test = decimal.TryParse(secondNumber.Text, out num2);
                if (num1Test && num2test)
                {
                    result = num1 - num2;  //Here's where the operator is used.
                    Result.Text = result.ToString();

                }
                else
                {
                    Result.Text = "Cannot do arithmetic without two numbers. Check inputs and try again.";
                }

            }
        }

        protected void Multiplication_Click(object sender, EventArgs e)
        {
            //check if the text values can be converted to number
            //I opted for using decimal just in case.
            //I also test for the presence of both numbers.
            //This code can be largely reused for the other three operators.

            if (CheckBoxValues())
            {
                decimal num1;
                decimal num2;
                decimal result;
                bool num1Test = decimal.TryParse(firstNumber.Text, out num1);
                bool num2test = decimal.TryParse(secondNumber.Text, out num2);
                if (num1Test && num2test)
                {
                    result = num1 * num2;  //Here's where the operator is used.
                    Result.Text = result.ToString();

                }
                else
                {
                    Result.Text = "Cannot do arithmetic without two numbers. Check inputs and try again.";
                }

            }
        }

        protected void Division_Click(object sender, EventArgs e)
        {
            //check if the text values can be converted to number
            //I opted for using decimal just in case.
            //I also test for the presence of both numbers.
            //This code can be largely reused for the other three operators.

            if (CheckBoxValues())
            {
                decimal num1;
                decimal num2;
                decimal result;
                bool num1Test = decimal.TryParse(firstNumber.Text, out num1);
                bool num2test = decimal.TryParse(secondNumber.Text, out num2);
                if (num1Test && num2test)  //First make sure they are numbers
                {
                    if (num2 != 0)           //Now make sure we aren't dividing by zero

                    {
                        result = num1 / num2;  //Here's where the operator is used.
                        Result.Text = result.ToString();
                    }
                    else
                    {
                        Result.Text = "Division by zero is not allowed.";
                    }
                }
                else
                {
                    Result.Text = "Cannot do arithmetic without two numbers. Check inputs and try again.";
                }
                    
               
            }
        }
    }
}