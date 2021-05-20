using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserTest
{
    public partial class RNC : Form
    {

         public static String valstr = "";
        short value = 0; 
        public RNC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] t = null;
            valstr = chiffreEntree.Text;
            t = valstr.ToCharArray();
            int i=0;
            /*do
            {
                MessageBox.Show("Veuillez saisir une valeur correcte!", "Alerte");
                i++;
            } while (t[i] != 'I' || t[i] != 'V' || t[i] != 'X' || t[i] != 'L' || t[i] != 'C' || t[i] != 'D' || t[i] != 'M');
            */
          MessageBox.Show(string.Format("La valeur en valeur romane est :{0}", romanValue()), "Alerte", MessageBoxButtons.OK);
        }
        short romanValue()
        {
            Dictionary<char, short> valchar = new Dictionary<char, short>();
            valchar.Add('I', 1);
            valchar.Add('V', 5);
            valchar.Add('X', 10);
            valchar.Add('L', 50);
            valchar.Add('C', 100);
            valchar.Add('D', 500);
            valchar.Add('M', 1000);
            short total = 0;
            short last_value = 0;
            short new_value = 0;


            for (int i = 0; i <= valstr.Length - 2; i = i + 2)
            {
                short t = valchar.GetValueOrDefault(valstr[i + 1]);
                new_value = valchar.GetValueOrDefault(valstr[i]);

                if (new_value < t)
                {
                    total = (short) (total+ valchar.GetValueOrDefault(valstr[i + 1]) - new_value);
                    //new_value = valchar.GetValueOrDefault(valstr[i]);
                  //  last_value = new_value;
                }
                else
                {
                   //new_value = (short)(valchar.GetValueOrDefault(valstr[i - 1]));
                    total = (short)(total + valchar.GetValueOrDefault(valstr[i + 1]) + new_value);                    //last_value = new_value;
                }
            }

            return total;
        }
    }
}
