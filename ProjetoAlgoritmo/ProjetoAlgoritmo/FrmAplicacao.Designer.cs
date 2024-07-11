namespace ProjetoAlgoritmo
{
    partial class FrmAplicacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_db = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_db
            // 
            button_db.BackColor = SystemColors.Control;
            button_db.Font = new Font("Segoe UI", 14F);
            button_db.Location = new Point(63, 148);
            button_db.Name = "button_db";
            button_db.Size = new Size(216, 62);
            button_db.TabIndex = 1;
            button_db.Text = "Carregar ficheiro csv";
            button_db.UseVisualStyleBackColor = false;
            button_db.Click += buttonCsvVendas_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(317, 37);
            label1.TabIndex = 2;
            label1.Text = " Macro para Excel Vendas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(463, 46);
            label2.Name = "label2";
            label2.Size = new Size(309, 37);
            label2.TabIndex = 3;
            label2.Text = "Macro para Excel Faturas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(509, 148);
            button1.Name = "button1";
            button1.Size = new Size(216, 62);
            button1.TabIndex = 4;
            button1.Text = "Carregar ficheiro csv";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonCsvFaturas_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 373);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_db);
            Name = "Aplicação";
            Text = "Aplicação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_db;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
