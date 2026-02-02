using System.Linq.Expressions;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Calculator project Iliyan Sidzhimkov, F112803
        private void button1_Click(object sender, EventArgs e)
        {   // Декларираме променливите.
            double firstOperand = double.Parse(FirstOperand.Text);
            double secondOperand = double.Parse(SecondOperand.Text);
            double result = 0;
            char operation = char.Parse(Operation.Text);
            // Проверяваме знака за извършване на математическата дейност, също така коагато делим с 0, в MessageBox извежда грешка, която казва че не може да се дели с числото 0;
            //Също така правим един if, в който проверяваме дали въведената операция е правилна, ако е правилна се влиза в swich case-а, където се проверява каква точно е операцията и се изпълнява. 
            if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
            {
                switch (operation)
                {

                    case '+': result = firstOperand + secondOperand; break;
                    case '-': result = firstOperand - secondOperand; break;
                    case '*': result = firstOperand * secondOperand; break;
                    case '/':
                        if (firstOperand == 0)
                        {
                            MessageBox.Show("You cannot devide by 0");
                            Close();
                        }
                        else
                        {
                            result = firstOperand / secondOperand;
                        }
                        break;

                        
                }
                // Извеждаме резултата в label
                res.Text = result.ToString();
            }
            else
            {
                //Ако операцията е невалидна извеждаме съобщение в MessageBox, в което казваме че операцията може да бъде една измежду +-*/ и не извеждаме нищо в лейбъла.
                MessageBox.Show("Enter valid operation! The operation should be +,-,*,/");
                res.Text = "";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Изчистване на лейбъла за резултат след натискане на бутона Clear.
            res.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Затваряне на програмата след натискане на бутона Exit.
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
