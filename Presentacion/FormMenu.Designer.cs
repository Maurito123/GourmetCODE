namespace proyecto.Presentacion;

partial class Menu
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
        btnAltas = new Button();
        btnBaja = new Button();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // btnAltas
        // 
        btnAltas.BackColor = Color.White;
        btnAltas.Image = Properties.Resources.AGREGAR_BOTON;
        btnAltas.Location = new Point(26, 30);
        btnAltas.Name = "btnAltas";
        btnAltas.Size = new Size(58, 54);
        btnAltas.TabIndex = 0;
        btnAltas.TabStop = false;
        btnAltas.UseVisualStyleBackColor = false;
        btnAltas.Click += btnAltas_Click;
        // 
        // btnBaja
        // 
        btnBaja.BackColor = Color.White;
        btnBaja.Image = Properties.Resources.Quitar_usuario40x40;
        btnBaja.Location = new Point(245, 30);
        btnBaja.Name = "btnBaja";
        btnBaja.Size = new Size(58, 54);
        btnBaja.TabIndex = 1;
        btnBaja.TabStop = false;
        btnBaja.UseVisualStyleBackColor = false;
        btnBaja.Click += btnBaja_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 87);
        label1.Name = "label1";
        label1.Size = new Size(87, 15);
        label1.TabIndex = 2;
        label1.Text = "Alta de Usuario";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(232, 87);
        label2.Name = "label2";
        label2.Size = new Size(88, 15);
        label2.TabIndex = 3;
        label2.Text = "Baja de Usuario";
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 128);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnBaja);
        Controls.Add(btnAltas);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Menu";
        Text = "Menu";
        Load += Menu_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnAltas;
    private Button btnBaja;
    private Label label1;
    private Label label2;
}