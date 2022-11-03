namespace Spa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbltarifa = new System.Windows.Forms.Label();
            this.txttarifa = new System.Windows.Forms.TextBox();
            this.cbmassagem = new System.Windows.Forms.CheckBox();
            this.txtmassagem = new System.Windows.Forms.TextBox();
            this.cbdrenagem = new System.Windows.Forms.CheckBox();
            this.cblifting = new System.Windows.Forms.CheckBox();
            this.cbofuro = new System.Windows.Forms.CheckBox();
            this.txtdrenagem = new System.Windows.Forms.TextBox();
            this.txtlifting = new System.Windows.Forms.TextBox();
            this.txtofuro = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.pcbSpa = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpa)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtofuro);
            this.gb1.Controls.Add(this.txtlifting);
            this.gb1.Controls.Add(this.txtdrenagem);
            this.gb1.Controls.Add(this.cbofuro);
            this.gb1.Controls.Add(this.cblifting);
            this.gb1.Controls.Add(this.cbdrenagem);
            this.gb1.Controls.Add(this.txtmassagem);
            this.gb1.Controls.Add(this.cbmassagem);
            this.gb1.Location = new System.Drawing.Point(26, 83);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(745, 166);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // lbltarifa
            // 
            this.lbltarifa.AutoSize = true;
            this.lbltarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltarifa.Location = new System.Drawing.Point(26, 44);
            this.lbltarifa.Name = "lbltarifa";
            this.lbltarifa.Size = new System.Drawing.Size(92, 15);
            this.lbltarifa.TabIndex = 1;
            this.lbltarifa.Text = "Tarifa Inicial (R$):";
            // 
            // txttarifa
            // 
            this.txttarifa.Location = new System.Drawing.Point(183, 44);
            this.txttarifa.Name = "txttarifa";
            this.txttarifa.Size = new System.Drawing.Size(100, 20);
            this.txttarifa.TabIndex = 2;
            this.txttarifa.TextChanged += new System.EventHandler(this.txttarifa_TextChanged);
            // 
            // cbmassagem
            // 
            this.cbmassagem.AutoSize = true;
            this.cbmassagem.Location = new System.Drawing.Point(21, 43);
            this.cbmassagem.Name = "cbmassagem";
            this.cbmassagem.Size = new System.Drawing.Size(151, 17);
            this.cbmassagem.TabIndex = 0;
            this.cbmassagem.Text = "Massagem Relaxante (R$)";
            this.cbmassagem.UseVisualStyleBackColor = true;
            this.cbmassagem.CheckedChanged += new System.EventHandler(this.cbmassagem_CheckedChanged);
            // 
            // txtmassagem
            // 
            this.txtmassagem.Location = new System.Drawing.Point(178, 40);
            this.txtmassagem.Name = "txtmassagem";
            this.txtmassagem.Size = new System.Drawing.Size(100, 20);
            this.txtmassagem.TabIndex = 1;
            // 
            // cbdrenagem
            // 
            this.cbdrenagem.AutoSize = true;
            this.cbdrenagem.Location = new System.Drawing.Point(21, 112);
            this.cbdrenagem.Name = "cbdrenagem";
            this.cbdrenagem.Size = new System.Drawing.Size(141, 17);
            this.cbdrenagem.TabIndex = 2;
            this.cbdrenagem.Text = "Drenagem Linfática (R$)";
            this.cbdrenagem.UseVisualStyleBackColor = true;
            // 
            // cblifting
            // 
            this.cblifting.AutoSize = true;
            this.cblifting.Location = new System.Drawing.Point(362, 43);
            this.cblifting.Name = "cblifting";
            this.cblifting.Size = new System.Drawing.Size(108, 17);
            this.cblifting.TabIndex = 3;
            this.cblifting.Text = "Lifting Facial (R$)";
            this.cblifting.UseVisualStyleBackColor = true;
            // 
            // cbofuro
            // 
            this.cbofuro.AutoSize = true;
            this.cbofuro.Location = new System.Drawing.Point(362, 112);
            this.cbofuro.Name = "cbofuro";
            this.cbofuro.Size = new System.Drawing.Size(124, 17);
            this.cbofuro.TabIndex = 4;
            this.cbofuro.Text = "Banho de Ofurô (R$)";
            this.cbofuro.UseVisualStyleBackColor = true;
            // 
            // txtdrenagem
            // 
            this.txtdrenagem.Location = new System.Drawing.Point(178, 109);
            this.txtdrenagem.Name = "txtdrenagem";
            this.txtdrenagem.Size = new System.Drawing.Size(100, 20);
            this.txtdrenagem.TabIndex = 5;
            // 
            // txtlifting
            // 
            this.txtlifting.Location = new System.Drawing.Point(509, 43);
            this.txtlifting.Name = "txtlifting";
            this.txtlifting.Size = new System.Drawing.Size(100, 20);
            this.txtlifting.TabIndex = 6;
            // 
            // txtofuro
            // 
            this.txtofuro.Location = new System.Drawing.Point(509, 112);
            this.txtofuro.Name = "txtofuro";
            this.txtofuro.Size = new System.Drawing.Size(100, 20);
            this.txtofuro.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(526, 404);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(657, 403);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(437, 333);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(56, 13);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Valor Final";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(535, 333);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 6;
            // 
            // pcbSpa
            // 
            this.pcbSpa.Image = ((System.Drawing.Image)(resources.GetObject("pcbSpa.Image")));
            this.pcbSpa.Location = new System.Drawing.Point(26, 264);
            this.pcbSpa.Name = "pcbSpa";
            this.pcbSpa.Size = new System.Drawing.Size(336, 163);
            this.pcbSpa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSpa.TabIndex = 7;
            this.pcbSpa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbSpa);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txttarifa);
            this.Controls.Add(this.lbltarifa);
            this.Controls.Add(this.gb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtofuro;
        private System.Windows.Forms.TextBox txtlifting;
        private System.Windows.Forms.TextBox txtdrenagem;
        private System.Windows.Forms.CheckBox cbofuro;
        private System.Windows.Forms.CheckBox cblifting;
        private System.Windows.Forms.CheckBox cbdrenagem;
        private System.Windows.Forms.TextBox txtmassagem;
        private System.Windows.Forms.CheckBox cbmassagem;
        private System.Windows.Forms.Label lbltarifa;
        private System.Windows.Forms.TextBox txttarifa;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.PictureBox pcbSpa;
    }
}

