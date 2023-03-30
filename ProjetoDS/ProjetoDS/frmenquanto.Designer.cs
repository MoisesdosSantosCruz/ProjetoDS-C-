
namespace ProjetoDS
{
    partial class frmenquanto
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
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncacular2 = new System.Windows.Forms.Button();
            this.btncalcular3 = new System.Windows.Forms.Button();
            this.lblenquanto = new System.Windows.Forms.Label();
            this.lblrepita = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(327, 93);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 0;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(327, 166);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(100, 41);
            this.txtresult.TabIndex = 2;
            this.txtresult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(162, 100);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(159, 13);
            this.lblnum.TabIndex = 3;
            this.lblnum.Text = "Cooque um numero da tabuada:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(202, 173);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(55, 13);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "Resultado";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(205, 265);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(352, 265);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(491, 265);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncacular2
            // 
            this.btncacular2.Location = new System.Drawing.Point(205, 324);
            this.btncacular2.Name = "btncacular2";
            this.btncacular2.Size = new System.Drawing.Size(75, 23);
            this.btncacular2.TabIndex = 8;
            this.btncacular2.Text = "Calcular";
            this.btncacular2.UseVisualStyleBackColor = true;
            this.btncacular2.Click += new System.EventHandler(this.btncacular2_Click);
            // 
            // btncalcular3
            // 
            this.btncalcular3.Location = new System.Drawing.Point(209, 377);
            this.btncalcular3.Name = "btncalcular3";
            this.btncalcular3.Size = new System.Drawing.Size(74, 21);
            this.btncalcular3.TabIndex = 9;
            this.btncalcular3.Text = "Calcular";
            this.btncalcular3.UseVisualStyleBackColor = true;
            this.btncalcular3.Click += new System.EventHandler(this.btncalcular3_Click);
            // 
            // lblenquanto
            // 
            this.lblenquanto.AutoSize = true;
            this.lblenquanto.Location = new System.Drawing.Point(120, 275);
            this.lblenquanto.Name = "lblenquanto";
            this.lblenquanto.Size = new System.Drawing.Size(53, 13);
            this.lblenquanto.TabIndex = 10;
            this.lblenquanto.Text = "Enquanto";
            // 
            // lblrepita
            // 
            this.lblrepita.AutoSize = true;
            this.lblrepita.Location = new System.Drawing.Point(120, 334);
            this.lblrepita.Name = "lblrepita";
            this.lblrepita.Size = new System.Drawing.Size(38, 13);
            this.lblrepita.TabIndex = 11;
            this.lblrepita.Text = "Repita";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(120, 385);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(29, 13);
            this.lblPara.TabIndex = 12;
            this.lblPara.Text = "Para";
            // 
            // frmenquanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblrepita);
            this.Controls.Add(this.lblenquanto);
            this.Controls.Add(this.btncalcular3);
            this.Controls.Add(this.btncacular2);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Name = "frmenquanto";
            this.Text = "frmenquanto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncacular2;
        private System.Windows.Forms.Button btncalcular3;
        private System.Windows.Forms.Label lblenquanto;
        private System.Windows.Forms.Label lblrepita;
        private System.Windows.Forms.Label lblPara;
    }
}