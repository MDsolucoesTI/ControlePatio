/**********************************************************************
 *                                                                    *
 *   Propriedade Intelectual:                                         *
 *                            Denny Paulista Azevedo Filho            *
 *                                          &                         *
 *                                  Marilene Esquiavoni               *
 *                                                                    *
 *   Conforme leis 9.609/98 e 9.610/98                                *
 *                                                                    *
 *   Projeto, Desenvolvimento e Programação:                          *
 *                                      Denny Paulista Azevedo Filho  *
 *                                      Marilene Esquiavoni           *
 *                                                                    *
 *   Data da Criação: 14/09/2008                                      *
 *                                                                    *  
 *   Todos os direitos reservados                                     *
 *                                                                    *
 *   Fica autorizado o uso apenas da Sincrolg, sem fins comerciais    *
 *   É vetada a alteração, distribuição e cópias sem concentimento    *
 *   formal e por escrito do proprietário e autor.                    *
 *   Este aviso deve acompanhar todo o programa que utiliza total     *
 *   ou parcialmente este código.                                     *
 *                                                                    *
 * *******************************************************************/

namespace Patio
{
  partial class frmRegistro
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtChassi = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbCor = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnVer = new System.Windows.Forms.Button();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.txtPortas = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnReparo = new System.Windows.Forms.Button();
      this.btnCancela = new System.Windows.Forms.Button();
      this.cmbBloco = new System.Windows.Forms.ComboBox();
      this.btnIn = new System.Windows.Forms.Button();
      this.btnOut = new System.Windows.Forms.Button();
      this.txtLinha = new System.Windows.Forms.NumericUpDown();
      this.txtColuna = new System.Windows.Forms.NumericUpDown();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.ckLeitor = new System.Windows.Forms.CheckBox();
      this.pnlLeitor = new System.Windows.Forms.Panel();
      this.pnlTecla = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.txtChassiF = new System.Windows.Forms.TextBox();
      this.txtChassiV = new System.Windows.Forms.TextBox();
      this.lblQuant = new System.Windows.Forms.Label();
      this.pnlLeitor.SuspendLayout();
      this.pnlTecla.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(7, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 20);
      this.label1.Text = "Chassi";
      // 
      // txtChassi
      // 
      this.txtChassi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.txtChassi.Location = new System.Drawing.Point(4, 20);
      this.txtChassi.MaxLength = 17;
      this.txtChassi.Name = "txtChassi";
      this.txtChassi.Size = new System.Drawing.Size(152, 23);
      this.txtChassi.TabIndex = 1;
      this.txtChassi.TextChanged += new System.EventHandler(this.txtChassi_TextChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(9, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 20);
      this.label2.Text = "Modelo";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(120, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 20);
      this.label3.Text = "Cor";
      // 
      // cmbCor
      // 
      this.cmbCor.Location = new System.Drawing.Point(120, 104);
      this.cmbCor.Name = "cmbCor";
      this.cmbCor.Size = new System.Drawing.Size(100, 23);
      this.cmbCor.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(9, 131);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(47, 20);
      this.label4.Text = "Portas";
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(56, 132);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(52, 20);
      this.label6.Text = "Bloco";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(124, 130);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 20);
      this.label5.Text = "Linha";
      // 
      // btnVer
      // 
      this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
      this.btnVer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
      this.btnVer.ForeColor = System.Drawing.Color.White;
      this.btnVer.Location = new System.Drawing.Point(11, 227);
      this.btnVer.Name = "btnVer";
      this.btnVer.Size = new System.Drawing.Size(136, 29);
      this.btnVer.TabIndex = 12;
      this.btnVer.Text = "Verifica Embarque";
      this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
      // 
      // txtModelo
      // 
      this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.txtModelo.Location = new System.Drawing.Point(9, 104);
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(87, 23);
      this.txtModelo.TabIndex = 21;
      // 
      // txtPortas
      // 
      this.txtPortas.Location = new System.Drawing.Point(9, 147);
      this.txtPortas.Name = "txtPortas";
      this.txtPortas.Size = new System.Drawing.Size(38, 23);
      this.txtPortas.TabIndex = 22;
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(178, 130);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 20);
      this.label7.Text = "Coluna";
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.Color.YellowGreen;
      this.btnOK.Location = new System.Drawing.Point(12, 192);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(62, 30);
      this.btnOK.TabIndex = 31;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnReparo
      // 
      this.btnReparo.BackColor = System.Drawing.Color.Yellow;
      this.btnReparo.Location = new System.Drawing.Point(85, 192);
      this.btnReparo.Name = "btnReparo";
      this.btnReparo.Size = new System.Drawing.Size(62, 30);
      this.btnReparo.TabIndex = 32;
      this.btnReparo.Text = "Reparo";
      this.btnReparo.Click += new System.EventHandler(this.btnReparo_Click);
      // 
      // btnCancela
      // 
      this.btnCancela.BackColor = System.Drawing.Color.IndianRed;
      this.btnCancela.Location = new System.Drawing.Point(158, 192);
      this.btnCancela.Name = "btnCancela";
      this.btnCancela.Size = new System.Drawing.Size(62, 30);
      this.btnCancela.TabIndex = 33;
      this.btnCancela.Text = "Rejeita";
      this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
      // 
      // cmbBloco
      // 
      this.cmbBloco.Location = new System.Drawing.Point(55, 147);
      this.cmbBloco.Name = "cmbBloco";
      this.cmbBloco.Size = new System.Drawing.Size(53, 23);
      this.cmbBloco.TabIndex = 44;
      this.cmbBloco.SelectedIndexChanged += new System.EventHandler(this.cmbBloco_SelectedIndexChanged);
      // 
      // btnIn
      // 
      this.btnIn.BackColor = System.Drawing.Color.Navy;
      this.btnIn.ForeColor = System.Drawing.Color.White;
      this.btnIn.Location = new System.Drawing.Point(9, 4);
      this.btnIn.Name = "btnIn";
      this.btnIn.Size = new System.Drawing.Size(87, 20);
      this.btnIn.TabIndex = 0;
      this.btnIn.Text = "Importar...";
      this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
      // 
      // btnOut
      // 
      this.btnOut.BackColor = System.Drawing.Color.Navy;
      this.btnOut.ForeColor = System.Drawing.Color.White;
      this.btnOut.Location = new System.Drawing.Point(124, 4);
      this.btnOut.Name = "btnOut";
      this.btnOut.Size = new System.Drawing.Size(87, 20);
      this.btnOut.TabIndex = 46;
      this.btnOut.Text = "Exportar...";
      this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
      // 
      // txtLinha
      // 
      this.txtLinha.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
      this.txtLinha.Location = new System.Drawing.Point(117, 147);
      this.txtLinha.Name = "txtLinha";
      this.txtLinha.Size = new System.Drawing.Size(46, 30);
      this.txtLinha.TabIndex = 2;
      this.txtLinha.ValueChanged += new System.EventHandler(this.txtLinha_ValueChanged);
      // 
      // txtColuna
      // 
      this.txtColuna.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
      this.txtColuna.Location = new System.Drawing.Point(173, 147);
      this.txtColuna.Name = "txtColuna";
      this.txtColuna.Size = new System.Drawing.Size(46, 30);
      this.txtColuna.TabIndex = 3;
      this.txtColuna.ValueChanged += new System.EventHandler(this.txtColuna_ValueChanged);
      // 
      // ckLeitor
      // 
      this.ckLeitor.Checked = true;
      this.ckLeitor.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckLeitor.Location = new System.Drawing.Point(175, 57);
      this.ckLeitor.Name = "ckLeitor";
      this.ckLeitor.Size = new System.Drawing.Size(44, 20);
      this.ckLeitor.TabIndex = 54;
      this.ckLeitor.Text = "LO";
      this.ckLeitor.CheckStateChanged += new System.EventHandler(this.ckLeitor_CheckStateChanged);
      // 
      // pnlLeitor
      // 
      this.pnlLeitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.pnlLeitor.Controls.Add(this.txtChassi);
      this.pnlLeitor.Controls.Add(this.label1);
      this.pnlLeitor.Location = new System.Drawing.Point(5, 35);
      this.pnlLeitor.Name = "pnlLeitor";
      this.pnlLeitor.Size = new System.Drawing.Size(162, 51);
      // 
      // pnlTecla
      // 
      this.pnlTecla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.pnlTecla.Controls.Add(this.txtChassiV);
      this.pnlTecla.Controls.Add(this.txtChassiF);
      this.pnlTecla.Controls.Add(this.label8);
      this.pnlTecla.Location = new System.Drawing.Point(5, 35);
      this.pnlTecla.Name = "pnlTecla";
      this.pnlTecla.Size = new System.Drawing.Size(162, 51);
      this.pnlTecla.Visible = false;
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(4, 2);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(100, 20);
      this.label8.Text = "Chassi";
      // 
      // txtChassiF
      // 
      this.txtChassiF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.txtChassiF.Location = new System.Drawing.Point(4, 20);
      this.txtChassiF.MaxLength = 11;
      this.txtChassiF.Name = "txtChassiF";
      this.txtChassiF.Size = new System.Drawing.Size(90, 23);
      this.txtChassiF.TabIndex = 2;
      // 
      // txtChassiV
      // 
      this.txtChassiV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.txtChassiV.Location = new System.Drawing.Point(97, 20);
      this.txtChassiV.MaxLength = 6;
      this.txtChassiV.Name = "txtChassiV";
      this.txtChassiV.Size = new System.Drawing.Size(58, 23);
      this.txtChassiV.TabIndex = 3;
      this.txtChassiV.TextChanged += new System.EventHandler(this.txtChassi_TextChanged);
      // 
      // lblQuant
      // 
      this.lblQuant.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.lblQuant.Location = new System.Drawing.Point(166, 233);
      this.lblQuant.Name = "lblQuant";
      this.lblQuant.Size = new System.Drawing.Size(48, 20);
      // 
      // frmRegistro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(233, 265);
      this.Controls.Add(this.lblQuant);
      this.Controls.Add(this.pnlTecla);
      this.Controls.Add(this.pnlLeitor);
      this.Controls.Add(this.ckLeitor);
      this.Controls.Add(this.txtColuna);
      this.Controls.Add(this.txtLinha);
      this.Controls.Add(this.btnOut);
      this.Controls.Add(this.btnIn);
      this.Controls.Add(this.cmbBloco);
      this.Controls.Add(this.btnCancela);
      this.Controls.Add(this.btnReparo);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtPortas);
      this.Controls.Add(this.txtModelo);
      this.Controls.Add(this.btnVer);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbCor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label5);
      this.Menu = this.mainMenu1;
      this.Name = "frmRegistro";
      this.Text = "Controle Patio";
      this.Deactivate += new System.EventHandler(this.frmRegistro_Deactivate);
      this.pnlLeitor.ResumeLayout(false);
      this.pnlTecla.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtChassi;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbCor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnVer;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.TextBox txtPortas;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnReparo;
    private System.Windows.Forms.Button btnCancela;
    private System.Windows.Forms.ComboBox cmbBloco;
    private System.Windows.Forms.Button btnIn;
    private System.Windows.Forms.Button btnOut;
    private System.Windows.Forms.NumericUpDown txtLinha;
    private System.Windows.Forms.NumericUpDown txtColuna;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.CheckBox ckLeitor;
    private System.Windows.Forms.Panel pnlLeitor;
    private System.Windows.Forms.Panel pnlTecla;
    private System.Windows.Forms.TextBox txtChassiF;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtChassiV;
    private System.Windows.Forms.Label lblQuant;
  }
}

