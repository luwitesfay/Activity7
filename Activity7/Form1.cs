namespace Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try catch method to catch an erro if the user enters invalid value
            try
            {

                // defining and initializing a variable

                double pi = 1;
                double seq = 0;
                // converting user input into integer
                int terms = Convert.ToInt32((userInputBox.Text));
                // for loop that iteriate based on the users input
                for (int i = 0; i < terms; i++)
                {
                    // if statment to validate id the user enters an odd or even number and see if it has a remainder
                    if (i % 2 == 0)
                    {
                        // if there is no remainder add
                        seq += 4 / pi;
                        // display the value of pi
                        valueDisplay.Text = "Approximate value of PI after " + terms + "  Terms" + "\n" + "=" + seq;


                    }
                    else
                    {
                        // if there is a remainder subtract

                        seq -= 4 / pi;
                        // display the value of pi
                        valueDisplay.Text = "Approximate value of PI after " + terms + "  Terms" + "\n" + "=" + seq;
                    }
                    // for the value of pi add 2 for every iteration 
                    pi += 2;
                }
                
            }
            // throw an exception if the user enters invalid value
            catch (Exception)
            {
                MessageBox.Show("please enter a number");
            }


        }
    }
}