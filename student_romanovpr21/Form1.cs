using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_romanovpr21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasExtranousSymbols = false;

            Student stud = new Student((double)height_sel.Value);
            stud.name = textBox1.Text;

            for (int i = 0; i < stud.name.Length; i++)
            {
                if (char.IsLetter(stud.name[i]) == false && stud.name[i] != ' ')
                {
                    hasExtranousSymbols = true;
                }
            }
            if (stud.name == "")
            {
                error.Text = "Не введены фамилия и имя";
            }
            else if (hasExtranousSymbols == true)
            {
                error.Text = "Присутствуют посторонние символы";
            }
            else
            {
                stud.height = (double)height_sel.Value;
                stud.Stud1((double)weight_sel.Value);
                stud.food_weight = (double)foodWeight_sel.Value;
                stud.SetEat(stud.food_weight);
                MessageBox.Show(string.Format($"Студент {stud.name} съел {stud.food_weight} кг, станет:\nРост {stud.height} см\nВес {stud.GetEat()} кг"));
            }
        }
    }
}
