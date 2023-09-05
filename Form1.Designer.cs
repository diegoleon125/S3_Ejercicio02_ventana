namespace S3_Ejercicio02_ventana
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtcateg = new TextBox();
            label4 = new Label();
            txtdias = new TextBox();
            button1 = new Button();
            lblresult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 45);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "(3) 3 estrellas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 65);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "(5) 5 estrellas";
            // 
            // txtcateg
            // 
            txtcateg.Location = new Point(259, 18);
            txtcateg.Name = "txtcateg";
            txtcateg.Size = new Size(125, 27);
            txtcateg.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 119);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 4;
            label4.Text = "Ingrese dias de estadia:";
            // 
            // txtdias
            // 
            txtdias.Location = new Point(259, 116);
            txtdias.Name = "txtdias";
            txtdias.Size = new Size(125, 27);
            txtdias.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(198, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Comprobar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(141, 222);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(111, 20);
            lblresult.TabIndex = 7;
            lblresult.Text = "el precio sería...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 353);
            Controls.Add(lblresult);
            Controls.Add(button1);
            Controls.Add(txtdias);
            Controls.Add(label4);
            Controls.Add(txtcateg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtcateg;
        private Label label4;
        private TextBox txtdias;
        private Button button1;
        private Label lblresult;
    }
}