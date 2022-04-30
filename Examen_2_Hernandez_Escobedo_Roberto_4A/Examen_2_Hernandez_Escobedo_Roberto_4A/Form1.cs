namespace Examen_2_Hernandez_Escobedo_Roberto_4A
{
    public partial class Form1 : Form
    {
        private TextBox? txtUSD;
        private TextBox? txtCAD;
        private TextBox? txtMXN;
        private TextBox? txtEUR;
        private TextBox? txtJPN;

        private Label? lblUSD;
        private Label? lblCAD;
        private Label? lblMXN;
        private Label? lblEUR;  
        private Label? lblJPN;

        List<Label> lblList = new List<Label>();
        List<TextBox> txtList = new List<TextBox>();

        private Form2? frm;


        public Form1()
        {
            txtUSD = new TextBox();
            txtCAD = new TextBox();
            txtMXN = new TextBox();
            txtEUR = new TextBox();
            txtJPN = new TextBox();

            lblUSD = new Label();
            lblCAD = new Label();
            lblMXN = new Label();
            lblEUR = new Label();
            lblJPN = new Label();

            frm = new Form2();

            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            //Label Text
            lblUSD.Text = "USD - Dólar Estadounidense";
            lblCAD.Text = "CAD - Dólar Canadiense";
            lblMXN.Text = "MXN - Peso Mexicano";
            lblEUR.Text = "EUR - Euro";
            lblJPN.Text = "JPY - Yen";

            //Label Size
            lblUSD.AutoSize = true;
            lblCAD.AutoSize = true;
            lblMXN.AutoSize = true;
            lblEUR.AutoSize = true;
            lblJPN.AutoSize = true;

            //Label Visible
            lblUSD.Visible = false;
            lblCAD.Visible = false;
            lblMXN.Visible = false;
            lblEUR.Visible = false;
            lblJPN.Visible = false;

            //Label list ADD
            lblList.Add (lblUSD);
            lblList.Add (lblCAD);
            lblList.Add (lblMXN);
            lblList.Add (lblEUR);
            lblList.Add (lblJPN);

            //TextBox Size
            txtUSD.Size = new Size(60, 60);
            txtCAD.Size = new Size(60, 60);
            txtMXN.Size = new Size(60, 60);
            txtEUR.Size = new Size(60, 60);
            txtJPN.Size = new Size(60, 60);

            //TextBox Visible
            txtUSD.Visible = false;
            txtCAD.Visible = false;
            txtMXN.Visible = false;
            txtEUR.Visible = false;
            txtJPN.Visible = false;

            //TextBox list ADD
            txtList.Add (txtUSD);
            txtList.Add(txtCAD);
            txtList.Add(txtMXN);
            txtList.Add(txtEUR);
            txtList.Add(txtJPN);


        }

        private void btnCalcular_Click(Object? sender, EventArgs e)
        {
            string eleccion = comboBox1.SelectedItem.ToString();
            frm.ShowDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (eleccion == "USD - Dólar Estadounidense")
                {
                    foreach(string str in frm.checkList)
                    {
                        if(str != eleccion)
                        {
                           
                        }

                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(Object? sender, EventArgs e)
        {

        }
    }
}