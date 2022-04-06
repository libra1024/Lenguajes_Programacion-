namespace Introduccion;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    /*Modificacion*/
    private Label? lblBase;
    private TextBox?  txtBase;
    private Label? lblHip;
    private TextBox? txtHip;
     /*Fin*/
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        /*Modificacion*/
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.Items.Add("Triángulo");
        /*Fin*/
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(60,75);
        txtAltura.Visible=false;
        /*Modificacion*/
        //Etiqueta Base
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,100);
        lblBase.Visible = false;

        //TextBox Base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 20);
        txtBase.Location = new Point(60, 95);
        txtBase.Visible = false;

        //Etiqueta Hipotenusa
        lblHip= new Label();
        lblHip.Text = "Hipotenusa";
        lblHip.AutoSize = true;
        lblHip.Location = new Point(10, 120);
        lblHip.Visible = false;

        //TextBox Hipotenusa
        txtHip= new TextBox();
        txtHip.Size = new Size(100,20);
        txtHip.Location = new Point(80, 120);
        txtHip.Visible = false;

        /*Fin*/

        //Etiqueta Resultado
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(70,275);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        /*Modificacion*/
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblHip);
        this.Controls.Add(txtHip);
        /*Fin*/
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);

    }
    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            /*Modificacion*/
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = false;
                    lblBase.Visible = false;
                    txtHip.Visible = false;
                    lblHip.Visible = false;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = false;
                    lblBase.Visible = false;
                    txtHip.Visible = false;
                    lblHip.Visible = false;
                }
            }
            if(cmbFiguras.SelectedItem.ToString()=="Rectángulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                     txtHip.Visible = false;
                    lblHip.Visible = false;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                     txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                    txtHip.Visible = false;
                    lblHip.Visible = false;
                }

            }
            if(cmbFiguras.SelectedItem.ToString()=="Triángulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                    lblHip.Visible = true;
                    txtHip.Visible = true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                    txtHip.Visible = false;
                    lblHip.Visible = false;
                }

            }
            /*Fin*/
        }
        else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible = false;
            lblBase.Visible = false;
            txtHip.Visible = false;
            lblHip.Visible = false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo = cmbCalculos.SelectedItem.ToString();
        string figura  =  cmbFiguras.SelectedItem.ToString();
        float altura = float.Parse(txtAltura.Text);
        float @base  = float.Parse(txtBase.Text);
        float hipotenusa = float.Parse(txtHip.Text);
        if(txtAltura.Text!=""){
            /*if(calculo=="Périmetro"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*4).ToString();
            }
            if(calculo=="Área"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*altura).ToString();
            }*/

            if(figura == "Cuadrado"){

                if(calculo == "Área"){
                    txtResultado.Text=(altura*4).ToString();
                }
                if(calculo == "Périmetro"){
                    txtResultado.Text=(altura*altura).ToString();
                }
            }
            if(figura == "Rectángulo"){
                if(calculo == "Área"){
                    txtResultado.Text = (altura*@base).ToString();
                }
                if(calculo == "Périmetro"){
                    txtResultado.Text = (2*(altura*@base)).ToString();
                }
            }
            if(figura == "Triángulo"){

                if(calculo == "Périmetro"){
                    txtResultado.Text = (altura+@base+hipotenusa).ToString();
                }
                if(calculo == "Área"){
                    txtResultado.Text = ((@base*altura)/2).ToString();
                }
            }
        }
    }
}
