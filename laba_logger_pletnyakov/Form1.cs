using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_logger_pletnyakov
{
    public partial class Form1 : Form
    {
        Logger log;
        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numberString = textBox1.Text;
            try
            {
                double number = Convert.ToDouble(numberString);
                log.Debug(number + "/10=" + number / 10);
                label1.Text = number + "/10=" + number / 10;
            }
            catch
            {
                log.Error(numberString + " не число");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            try
            {
                double number = Convert.ToDouble(word);
                log.Error(word + " является числом");
            }
            catch
            {
                log.Debug("Длина \""+word+"\" = "+word.Length);
                label1.Text = "Длина \"" + word + "\" = " + word.Length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            log.Info("Было введено: \"" + result + "\"");
            label1.Text = "В логи введено: \"" + result + "\"";
        }
    }
}
