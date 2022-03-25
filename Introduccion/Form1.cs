namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;
    Label? lblLado1;
    TextBox? txtLado1;
    Label? lblLado2;
    TextBox? txtLado2;
    Label? lblLado3;
    TextBox? txtLado3;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        cmbCalculo.SelectedItem = "Périmetro";
        cmbFiguras.SelectedItem = "Cuadrado";
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 350);
        //Etiqueta "Figura"
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);
        //Combobox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);
        //Etiqueta "Cálculo"
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);
        //Combobox Cálculos
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Périmetro");
        cmbCalculo.Items.Add("Área");
        cmbCalculo.Location = new Point(150, 40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);
        //Etiqueta "Altura"
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10, 80);
        lblAltura.Visible=false;
        //TextBox Altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100, 20);
        txtAltura.Location = new Point(60, 75);
        txtAltura.Visible=false;
        //Etiqueta "Base"
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10, 120);
        lblBase.Visible=false;
        //TextBox Base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 20);
        txtBase.Location = new Point(60, 115);
        txtBase.Visible=false;
        //Etiqueta "Lado 1"
        lblLado1 = new Label();
        lblLado1.Text = "Lado 1";
        lblLado1.AutoSize = true;
        lblLado1.Location = new Point(10, 80);
        lblLado1.Visible=false;
        //TextBox Lado 1
        txtLado1 = new TextBox();
        txtLado1.Size = new Size(100, 20);
        txtLado1.Location = new Point(60, 75);
        txtLado1.Visible=false;
        //Etiqueta "Lado 2"
        lblLado2 = new Label();
        lblLado2.Text = "Lado 2";
        lblLado2.AutoSize = true;
        lblLado2.Location = new Point(10, 120);
        lblLado2.Visible=false;
        //TextBox Lado 2
        txtLado2 = new TextBox();
        txtLado2.Size = new Size(100, 20);
        txtLado2.Location = new Point(60, 115);
        txtLado2.Visible=false;
        //Etiqueta "Lado 3"
        lblLado3 = new Label();
        lblLado3.Text = "Lado 3";
        lblLado3.AutoSize = true;
        lblLado3.Location = new Point(10, 160);
        lblLado3.Visible=false;
        //TextBox Lado 3
        txtLado3 = new TextBox();
        txtLado3.Size = new Size(100, 20);
        txtLado3.Location = new Point(60, 155);
        txtLado3.Visible=false;
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);
        //Etiqueta "Resultado"
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);
        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(70, 275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(lblLado1);
        this.Controls.Add(txtLado1);
        this.Controls.Add(lblLado2);
        this.Controls.Add(txtLado2);
        this.Controls.Add(lblLado3);
        this.Controls.Add(txtLado3);

    }
    private Boolean esNumero(string valor){
        try
        {
            int valorInt = Convert.ToInt32(valor);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculo.SelectedIndex.ToString();
        int altura=0;
        int base1=0;
        int lado1=0;
        int lado2=0;
        int lado3=0;
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                if(txtAltura.Text!=""&&esNumero(txtAltura.Text)){
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*4).ToString();
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                if(txtAltura.Text!="" && txtBase.Text!=""&&esNumero(txtAltura.Text)&&esNumero(txtBase.Text)){
                    altura=Convert.ToInt32(txtAltura.Text);
                    base1=Convert.ToInt32(txtBase.Text);
                    txtResultado.Text=((altura+base1)*2).ToString();
                }
                
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                if(txtLado1.Text!="" && txtLado2.Text!=""&& txtLado3.Text!=""&&esNumero(txtLado1.Text)&&esNumero(txtLado2.Text)&&esNumero(txtLado3.Text)){
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    lado3=Convert.ToInt32(txtLado3.Text);
                    txtResultado.Text=(lado1+lado2+lado3).ToString();
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                if(txtAltura.Text!=""&&esNumero(txtAltura.Text)){
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*altura).ToString();
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                if(txtAltura.Text!="" && txtBase.Text!=""&&esNumero(txtAltura.Text)&&esNumero(txtBase.Text)){
                    altura=Convert.ToInt32(txtAltura.Text);
                    base1=Convert.ToInt32(txtBase.Text);
                    txtResultado.Text=(altura*base1).ToString();
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                if(txtAltura.Text!="" && txtBase.Text!=""&&esNumero(txtAltura.Text)&&esNumero(txtBase.Text)){
                    altura=Convert.ToInt32(txtAltura.Text);
                    base1=Convert.ToInt32(txtBase.Text);
                    txtResultado.Text=((altura*base1)/2.0).ToString();
                }
            }
        }
    }
    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            quitarElementosPantalla();
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
        }

    }
    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            quitarElementosPantalla();
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
        }
    }
    
    private void quitarElementosPantalla(){
        lblAltura.Visible = false;
        txtAltura.Visible = false;
        lblBase.Visible = false;
        txtBase.Visible = false;
        lblLado1.Visible = false;
        txtLado1.Visible = false;
        lblLado2.Visible = false;
        txtLado2.Visible = false;
        lblLado3.Visible = false;
        txtLado3.Visible = false;

    }
}
