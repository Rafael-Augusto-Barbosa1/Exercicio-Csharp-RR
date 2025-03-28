namespace RR_exe1_2
{
    partial class Form1
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtpar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(173, 67);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 0;
            // 
            // txtpar
            // 
            this.txtpar.Location = new System.Drawing.Point(173, 180);
            this.txtpar.Name = "txtpar";
            this.txtpar.Size = new System.Drawing.Size(100, 20);
            this.txtpar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num Sorteado";
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(376, 138);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 57);
            this.btncal.TabIndex = 4;
            this.btncal.Text = "CALCULAR";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(376, 229);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 57);
            this.btnlimp.TabIndex = 5;
            this.btnlimp.Text = "LIMPAR";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(564, 229);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(75, 57);
            this.btnvolt.TabIndex = 6;
            this.btnvolt.Text = "VOLTAR";
            this.btnvolt.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(564, 138);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 57);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num Pares:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpar);
            this.Controls.Add(this.txtnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label2;
    }
}

