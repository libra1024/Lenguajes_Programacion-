using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2_Hernandez_Escobedo_Roberto_4A
{
    public partial class Form2 : Form
    {
       public List<string> checkList = new List<string>();
        public int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            checkList.Clear();
            foreach(string s in checkedListBox1.SelectedItems)
            {
               checkList.Add(s);
                count++;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            checkList.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            checkedListBox1_SelectedIndexChanged(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
