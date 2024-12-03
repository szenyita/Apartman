namespace Apartman
{
    partial class Foglalas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            vendegNeveTextBox = new TextBox();
            foglalasHozzaadasaButton = new Button();
            foglalasModositasaButton = new Button();
            vendegKijelentkezteteseButton = new Button();
            mezokTorleseButton = new Button();
            foglalasDataGridView = new DataGridView();
            label7 = new Label();
            keresesTextBox = new TextBox();
            apartmanNeveComboBox = new ComboBox();
            szobaNeveComboBox = new ComboBox();
            foglalasIdTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            foglalasKezdeteTimePicker = new DateTimePicker();
            foglalasVegeTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)foglalasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 14);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 0;
            label1.Text = "Apartman Foglaló";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 98);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Apartman Neve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 132);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Szoba Neve";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 166);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Vendég Neve";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 199);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "Foglalás Kezdete";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 233);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Foglalás Vége";
            // 
            // vendegNeveTextBox
            // 
            vendegNeveTextBox.Location = new Point(156, 166);
            vendegNeveTextBox.Name = "vendegNeveTextBox";
            vendegNeveTextBox.Size = new Size(171, 27);
            vendegNeveTextBox.TabIndex = 8;
            // 
            // foglalasHozzaadasaButton
            // 
            foglalasHozzaadasaButton.Location = new Point(23, 321);
            foglalasHozzaadasaButton.Name = "foglalasHozzaadasaButton";
            foglalasHozzaadasaButton.Size = new Size(304, 29);
            foglalasHozzaadasaButton.TabIndex = 11;
            foglalasHozzaadasaButton.Text = "Foglalás Hozzáadása";
            foglalasHozzaadasaButton.UseVisualStyleBackColor = true;
            foglalasHozzaadasaButton.Click += foglalasHozzaadasaButton_Click;
            // 
            // foglalasModositasaButton
            // 
            foglalasModositasaButton.Location = new Point(23, 356);
            foglalasModositasaButton.Name = "foglalasModositasaButton";
            foglalasModositasaButton.Size = new Size(304, 29);
            foglalasModositasaButton.TabIndex = 12;
            foglalasModositasaButton.Text = "Foglalás Módosítása";
            foglalasModositasaButton.UseVisualStyleBackColor = true;
            foglalasModositasaButton.Click += foglalasModositasaButton_Click;
            // 
            // vendegKijelentkezteteseButton
            // 
            vendegKijelentkezteteseButton.Location = new Point(23, 391);
            vendegKijelentkezteteseButton.Name = "vendegKijelentkezteteseButton";
            vendegKijelentkezteteseButton.Size = new Size(304, 29);
            vendegKijelentkezteteseButton.TabIndex = 13;
            vendegKijelentkezteteseButton.Text = "Vendég Kijelentkeztetése";
            vendegKijelentkezteteseButton.UseVisualStyleBackColor = true;
            vendegKijelentkezteteseButton.Click += vendegKijelentkezteteseButton_Click;
            // 
            // mezokTorleseButton
            // 
            mezokTorleseButton.Location = new Point(23, 426);
            mezokTorleseButton.Name = "mezokTorleseButton";
            mezokTorleseButton.Size = new Size(304, 29);
            mezokTorleseButton.TabIndex = 14;
            mezokTorleseButton.Text = "Mezők Törlése";
            mezokTorleseButton.UseVisualStyleBackColor = true;
            mezokTorleseButton.Click += mezokTorleseButton_Click;
            // 
            // foglalasDataGridView
            // 
            foglalasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foglalasDataGridView.Location = new Point(371, 98);
            foglalasDataGridView.Name = "foglalasDataGridView";
            foglalasDataGridView.RowHeadersWidth = 51;
            foglalasDataGridView.Size = new Size(805, 357);
            foglalasDataGridView.TabIndex = 15;
            foglalasDataGridView.RowHeaderMouseClick += foglalasDataGridView_RowHeaderMouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(376, 63);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 16;
            label7.Text = "Keresés";
            // 
            // keresesTextBox
            // 
            keresesTextBox.Location = new Point(443, 63);
            keresesTextBox.Name = "keresesTextBox";
            keresesTextBox.Size = new Size(733, 27);
            keresesTextBox.TabIndex = 17;
            keresesTextBox.TextChanged += keresesTextBox_TextChanged;
            // 
            // apartmanNeveComboBox
            // 
            apartmanNeveComboBox.FormattingEnabled = true;
            apartmanNeveComboBox.Items.AddRange(new object[] { "Napfény Apartman", "Aranypart Apartman", "Panoráma Apartman", "Csendes Lak Apartman", "Belvárosi Apartman" });
            apartmanNeveComboBox.Location = new Point(156, 98);
            apartmanNeveComboBox.Name = "apartmanNeveComboBox";
            apartmanNeveComboBox.Size = new Size(171, 28);
            apartmanNeveComboBox.TabIndex = 18;
            // 
            // szobaNeveComboBox
            // 
            szobaNeveComboBox.FormattingEnabled = true;
            szobaNeveComboBox.Items.AddRange(new object[] { "Egyágyas szoba", "Kétágyas szoba", "Lakosztály" });
            szobaNeveComboBox.Location = new Point(156, 132);
            szobaNeveComboBox.Name = "szobaNeveComboBox";
            szobaNeveComboBox.Size = new Size(171, 28);
            szobaNeveComboBox.TabIndex = 19;
            // 
            // foglalasIdTextBox
            // 
            foglalasIdTextBox.Location = new Point(499, 178);
            foglalasIdTextBox.Name = "foglalasIdTextBox";
            foglalasIdTextBox.ReadOnly = true;
            foglalasIdTextBox.Size = new Size(125, 27);
            foglalasIdTextBox.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home_icon_silhouette;
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // foglalasKezdeteTimePicker
            // 
            foglalasKezdeteTimePicker.Location = new Point(156, 199);
            foglalasKezdeteTimePicker.Name = "foglalasKezdeteTimePicker";
            foglalasKezdeteTimePicker.Size = new Size(171, 27);
            foglalasKezdeteTimePicker.TabIndex = 22;
            // 
            // foglalasVegeTimePicker
            // 
            foglalasVegeTimePicker.Location = new Point(156, 233);
            foglalasVegeTimePicker.Name = "foglalasVegeTimePicker";
            foglalasVegeTimePicker.Size = new Size(171, 27);
            foglalasVegeTimePicker.TabIndex = 23;
            // 
            // Foglalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 504);
            Controls.Add(foglalasVegeTimePicker);
            Controls.Add(foglalasKezdeteTimePicker);
            Controls.Add(foglalasDataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(foglalasIdTextBox);
            Controls.Add(szobaNeveComboBox);
            Controls.Add(apartmanNeveComboBox);
            Controls.Add(keresesTextBox);
            Controls.Add(label7);
            Controls.Add(mezokTorleseButton);
            Controls.Add(vendegKijelentkezteteseButton);
            Controls.Add(foglalasModositasaButton);
            Controls.Add(foglalasHozzaadasaButton);
            Controls.Add(vendegNeveTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Foglalas";
            Text = "Apartman Foglaló";
            Load += Foglalas_Load;
            ((System.ComponentModel.ISupportInitialize)foglalasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox vendegNeveTextBox;
        private Button foglalasHozzaadasaButton;
        private Button foglalasModositasaButton;
        private Button vendegKijelentkezteteseButton;
        private Button mezokTorleseButton;
        private DataGridView foglalasDataGridView;
        private Label label7;
        private TextBox keresesTextBox;
        private ComboBox apartmanNeveComboBox;
        private ComboBox szobaNeveComboBox;
        private TextBox foglalasIdTextBox;
        private PictureBox pictureBox1;
        private DateTimePicker foglalasKezdeteTimePicker;
        private DateTimePicker foglalasVegeTimePicker;
    }
}