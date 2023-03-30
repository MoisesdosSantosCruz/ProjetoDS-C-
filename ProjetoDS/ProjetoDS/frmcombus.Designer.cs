
namespace ProjetoDS
{
    partial class frmcombus
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
            this.lblgasolina = new System.Windows.Forms.Label();
            this.lblquanti = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtquanti = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgasolina
            // 
            this.lblgasolina.AutoSize = true;
            this.lblgasolina.Location = new System.Drawing.Point(76, 49);
            this.lblgasolina.Name = "lblgasolina";
            this.lblgasolina.Size = new System.Drawing.Size(188, 13);
            this.lblgasolina.TabIndex = 0;
            this.lblgasolina.Text = "Digite A para alcool e G para Gasoina:";
            // 
            // lblquanti
            // 
            this.lblquanti.AutoSize = true;
            this.lblquanti.Location = new System.Drawing.Point(76, 122);
            this.lblquanti.Name = "lblquanti";
            this.lblquanti.Size = new System.Drawing.Size(173, 13);
            this.lblquanti.TabIndex = 1;
            this.lblquanti.Text = "Digite o quanto de gasolina deseja:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(76, 193);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 13);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "Total:";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(272, 49);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(123, 20);
            this.txttipo.TabIndex = 3;
            // 
            // txtquanti
            // 
            this.txtquanti.Location = new System.Drawing.Point(272, 119);
            this.txtquanti.Name = "txtquanti";
            this.txtquanti.Size = new System.Drawing.Size(121, 20);
            this.txtquanti.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(270, 190);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(123, 20);
            this.txtresult.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(134, 297);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(272, 296);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(416, 296);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmcombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtquanti);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblquanti);
            this.Controls.Add(this.lblgasolina);
            this.Name = "frmcombus";
            this.Text = "Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgasolina;
        private System.Windows.Forms.Label lblquanti;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtquanti;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}