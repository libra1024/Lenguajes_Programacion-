namespace Calculadora;

public partial class Form1 : Form
{
    private Button btnDeleteAll;
    private Button btnDeleteLast;
    private Button btnDeleteCurrent;
    private Button btnSign;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnAddition;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnSubtraction;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMultiplication;
    private Button btn0;
    private Button btnDot;
    private Button btnEquals;
    private Button btnDivision;
    private TextBox txtDisplay;
    private Label lblOperation;
    private String strOperation;
    private Double answer;

    public Form1()
    {
        strOperation = "";
        answer = 0;
        txtDisplay = new TextBox();
        lblOperation = new Label();

        btnDeleteAll = new Button();
        btnDeleteLast = new Button();
        btnDeleteCurrent = new Button();
        btnSign = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnAddition = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnSubtraction = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnMultiplication = new Button();
        btn0 = new Button();
        btnDot = new Button();
        btnEquals = new Button();
        btnDivision = new Button();
        InitializeComponent();
        InitializeComponents();
    }

    private void InitializeComponents(){

        /*Window Size*/
        this.Size = new Size(300,500);

        /*Calculator Label*/
        this.Text = "Calculadora";

        /*Size of buttons*/
         btnDeleteAll.Size = new Size(60, 60);
        btnDeleteLast.Size = new Size(60, 60);
        btnDeleteCurrent.Size = new Size(60, 60);
        btnSign.Size = new Size(60, 60);
        btn7.Size = new Size(60, 60);
        btn8.Size = new Size(60, 60);
        btn9.Size = new Size(60, 60);
        btnAddition.Size = new Size(60, 60);
        btn4.Size = new Size(60, 60);
        btn5.Size = new Size(60, 60);
        btn6.Size = new Size(60, 60);
        btnSubtraction.Size = new Size(60, 60);
        btn1.Size = new Size(60, 60);
        btn2.Size = new Size(60, 60);
        btn3.Size = new Size(60, 60);
        btnMultiplication.Size = new Size(60, 60);
        btn0.Size = new Size(60, 60);
        btnDot.Size = new Size(60, 60);
        btnEquals.Size = new Size(60, 60);
        btnDivision.Size = new Size(60, 60);

        /*Display size*/
        txtDisplay.Size = new Size(260, 50);
        txtDisplay.Multiline = true;

        /*Label*/
        lblOperation.AutoSize = true;


        /*Text*/ 
        btnDeleteAll.Text = "⌫";
        btnDeleteLast.Text = "CE";
        btnDeleteCurrent.Text = "C";
        btnSign.Text = "±";
        btn7.Text = "7";
        btn8.Text = "8";
        btn9.Text = "9";
        btnAddition.Text = "+";
        btn4.Text = "4";
        btn5.Text = "5";
        btn6.Text = "6";
        btnSubtraction.Text = "-";
        btn1.Text = "1";
        btn2.Text = "2";
        btn3.Text = "3";
        btnMultiplication.Text = "*";
        btn0.Text = "0";
        btnDot.Text = ".";
        btnEquals.Text = "=";
        btnDivision.Text = "/";

        /*Display location*/
        txtDisplay.Location = new Point(10, 30);
        lblOperation.Location = new Point(10, 30);
        lblOperation.BringToFront();

        /*List of Buttons*/
        List<Button> list = new List<Button>();
        list.Add(btnDeleteAll);
        list.Add(btnDeleteLast);
        list.Add(btnDeleteCurrent);
        list.Add(btnSign);
        list.Add(btn7);
        list.Add(btn8);
        list.Add(btn9);
        list.Add(btnAddition);
        list.Add(btn4);
        list.Add(btn5);
        list.Add(btn6);
        list.Add(btnSubtraction);
        list.Add(btn1);
        list.Add(btn2);
        list.Add(btn3);
        list.Add(btnMultiplication);
        list.Add(btn0);
        list.Add(btnDot);
        list.Add(btnEquals);
        list.Add(btnDivision);

        /*Points*/
        int x = 10;
        int y = 85;
        int count = 0;

        foreach (Button btn in list){
            
            if(count ==  4){
                x = 10;
                y += 67;
                count = 0;
            }
            btn.Location = new Point(x, y);
            this.Controls.Add(btn);
            x += 67;
            count++;
        }

        /*Add controls to the form */
        this.Controls.Add(txtDisplay);
        this.Controls.Add(lblOperation);


    }
}

