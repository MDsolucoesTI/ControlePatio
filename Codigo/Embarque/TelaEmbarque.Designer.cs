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
 *   Data da Criação: 15/09/2008                                      *
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

namespace Embarque
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
      this.cmbModel = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbCor = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnIn = new System.Windows.Forms.Button();
      this.txtDeck = new System.Windows.Forms.NumericUpDown();
      this.txtPorao = new System.Windows.Forms.NumericUpDown();
      this.txtPortas = new System.Windows.Forms.TextBox();
      this.btnOut = new System.Windows.Forms.Button();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(9, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.Text = "Chassi";
      // 
      // txtChassi
      // 
      this.txtChassi.Location = new System.Drawing.Point(9, 45);
      this.txtChassi.Name = "txtChassi";
      this.txtChassi.Size = new System.Drawing.Size(203, 23);
      this.txtChassi.TabIndex = 1;
      // 
      // cmbModel
      // 
      this.cmbModel.Location = new System.Drawing.Point(9, 90);
      this.cmbModel.Name = "cmbModel";
      this.cmbModel.Size = new System.Drawing.Size(87, 23);
      this.cmbModel.TabIndex = 2;
      this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(9, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 20);
      this.label2.Text = "Modelos";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(112, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 20);
      this.label3.Text = "Cor";
      // 
      // cmbCor
      // 
      this.cmbCor.Location = new System.Drawing.Point(112, 90);
      this.cmbCor.Name = "cmbCor";
      this.cmbCor.Size = new System.Drawing.Size(100, 23);
      this.cmbCor.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(9, 120);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 20);
      this.label4.Text = "Portas";
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(68, 118);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(41, 20);
      this.label6.Text = "Deck";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(146, 119);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 20);
      this.label5.Text = "Porão";
      // 
      // btnOk
      // 
      this.btnOk.BackColor = System.Drawing.Color.YellowGreen;
      this.btnOk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
      this.btnOk.Location = new System.Drawing.Point(112, 189);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(100, 43);
      this.btnOk.TabIndex = 12;
      this.btnOk.Text = "OK";
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnIn
      // 
      this.btnIn.BackColor = System.Drawing.Color.Navy;
      this.btnIn.ForeColor = System.Drawing.Color.White;
      this.btnIn.Location = new System.Drawing.Point(9, 3);
      this.btnIn.Name = "btnIn";
      this.btnIn.Size = new System.Drawing.Size(87, 20);
      this.btnIn.TabIndex = 46;
      this.btnIn.Text = "Importar...";
      this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
      // 
      // txtDeck
      // 
      this.txtDeck.Location = new System.Drawing.Point(68, 135);
      this.txtDeck.Name = "txtDeck";
      this.txtDeck.Size = new System.Drawing.Size(64, 24);
      this.txtDeck.TabIndex = 47;
      // 
      // txtPorao
      // 
      this.txtPorao.Location = new System.Drawing.Point(146, 135);
      this.txtPorao.Name = "txtPorao";
      this.txtPorao.Size = new System.Drawing.Size(64, 24);
      this.txtPorao.TabIndex = 48;
      // 
      // txtPortas
      // 
      this.txtPortas.Location = new System.Drawing.Point(9, 136);
      this.txtPortas.Name = "txtPortas";
      this.txtPortas.Size = new System.Drawing.Size(43, 23);
      this.txtPortas.TabIndex = 49;
      // 
      // btnOut
      // 
      this.btnOut.BackColor = System.Drawing.Color.Navy;
      this.btnOut.ForeColor = System.Drawing.Color.White;
      this.btnOut.Location = new System.Drawing.Point(123, 3);
      this.btnOut.Name = "btnOut";
      this.btnOut.Size = new System.Drawing.Size(87, 20);
      this.btnOut.TabIndex = 50;
      this.btnOut.Text = "Exportar...";
      // 
      // frmRegistro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(225, 244);
      this.Controls.Add(this.btnOut);
      this.Controls.Add(this.txtPortas);
      this.Controls.Add(this.txtPorao);
      this.Controls.Add(this.txtDeck);
      this.Controls.Add(this.btnIn);
      this.Controls.Add(this.cmbModel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbCor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtChassi);
      this.Controls.Add(this.label1);
      this.Menu = this.mainMenu1;
      this.Name = "frmRegistro";
      this.Text = "Controle Embarque";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtChassi;
    private System.Windows.Forms.ComboBox cmbModel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbCor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnIn;
    private System.Windows.Forms.NumericUpDown txtDeck;
    private System.Windows.Forms.NumericUpDown txtPorao;
    private System.Windows.Forms.TextBox txtPortas;
    private System.Windows.Forms.Button btnOut;
    private System.Windows.Forms.MainMenu mainMenu1;
  }
}

