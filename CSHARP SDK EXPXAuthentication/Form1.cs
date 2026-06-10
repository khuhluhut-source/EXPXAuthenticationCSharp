using System;
using System.Windows.Forms;
using EXPXAuth;

namespace CSHARP_SDK_EXPXAuthentication
{
    public partial class Form1 : Form
    {
        public static EXPX EXPX = new EXPX(
          name: "app_name",
          secret: "EXPX-secret",
          version: "1.0"
        );

        public Form1()
        {
            InitializeComponent();
        }

     

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await EXPX.Login(textBox1.Text, textBox2.Text);

            if (result.Success)
            {
                label1.Text = result.Message;  
            }
            else
            {
                label1.Text = result.Message;
            }
        }




        private async void button2_Click(object sender, EventArgs e)
        {
            var result = await EXPX.Register(textBox1.Text, textBox2.Text, textBox3.Text);

            if (result.Success)
            {
                label1.Text = result.Message;
            }
            else
            {
                label1.Text = result.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = EXPX.Var("AoB");
        }
    }
}
