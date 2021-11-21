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
 *   Data da Criação: 11/09/2008                                      *
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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle
{
  public partial class frmModelo : Form
  {
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.Button btnLocalizar;
    private System.Windows.Forms.Button btnNovo     ;
    private System.Windows.Forms.Button btnDeletar  ;
    private System.Windows.Forms.Button btnOk       ;
    private System.Windows.Forms.Button btnCancela  ;
    
    private System.Windows.Forms.GroupBox gbxCodModelo  ;
    private System.Windows.Forms.GroupBox grbModelo     ;
    private System.Windows.Forms.GroupBox grbPortas     ;
    private System.Windows.Forms.GroupBox grbLargura    ;
    private System.Windows.Forms.GroupBox grbComprimento;
    private System.Windows.Forms.GroupBox grbImagem     ;
    
    private System.Windows.Forms.TextBox txtComprimento;
    private System.Windows.Forms.TextBox txtLargura    ;
    private System.Windows.Forms.TextBox txtPortas     ;
    private System.Windows.Forms.TextBox txtModelo     ;
    private System.Windows.Forms.TextBox txtCodModelo  ;
    
    private System.Windows.Forms.PictureBox pctImagem;
    
    public frmModelo()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelo));
      
      this.btnLocalizar = new System.Windows.Forms.Button();
      this.btnNovo      = new System.Windows.Forms.Button();
      this.btnDeletar   = new System.Windows.Forms.Button();
      this.btnOk        = new System.Windows.Forms.Button();
      this.btnCancela   = new System.Windows.Forms.Button();
      
      this.gbxCodModelo   = new System.Windows.Forms.GroupBox();
      this.grbModelo      = new System.Windows.Forms.GroupBox();
      this.grbPortas      = new System.Windows.Forms.GroupBox();
      this.grbLargura     = new System.Windows.Forms.GroupBox();
      this.grbComprimento = new System.Windows.Forms.GroupBox();
      this.grbImagem      = new System.Windows.Forms.GroupBox();
      
      this.txtComprimento = new System.Windows.Forms.TextBox();
      this.txtLargura     = new System.Windows.Forms.TextBox();
      this.txtPortas      = new System.Windows.Forms.TextBox();
      this.txtModelo      = new System.Windows.Forms.TextBox();
      this.txtCodModelo   = new System.Windows.Forms.TextBox();
      
      this.pctImagem = new System.Windows.Forms.PictureBox();
      
      this.gbxCodModelo.SuspendLayout()  ;
      this.grbModelo.SuspendLayout()     ;
      this.grbPortas.SuspendLayout()     ;
      this.grbLargura.SuspendLayout()    ;
      this.grbComprimento.SuspendLayout();
      this.grbImagem.SuspendLayout()     ;
      
      ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
      
      this.SuspendLayout();
       
      this.gbxCodModelo.Controls.Add(this.txtCodModelo);
      
      this.gbxCodModelo.Location = new System.Drawing.Point(13, 13);
      this.gbxCodModelo.Name     = "gbxCodModelo";
      this.gbxCodModelo.Size     = new System.Drawing.Size(117, 50);
      this.gbxCodModelo.TabIndex = 0;
      this.gbxCodModelo.TabStop  = false;
      this.gbxCodModelo.Text     = " Código do Modelo";
       
      this.txtCodModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCodModelo.Location        = new System.Drawing.Point(7, 20);
      this.txtCodModelo.Name            = "txtCodModelo";
      this.txtCodModelo.Size            = new System.Drawing.Size(100, 20);
      this.txtCodModelo.TabIndex        = 0;
       
      this.grbModelo.Controls.Add(this.txtModelo);
      
      this.grbModelo.Location = new System.Drawing.Point(13, 70);
      this.grbModelo.Name     = "grbModelo";
      this.grbModelo.Size     = new System.Drawing.Size(200, 50);
      this.grbModelo.TabIndex = 1;
      this.grbModelo.TabStop  = false;
      this.grbModelo.Text     = " Modelo ";
       
      this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtModelo.Location        = new System.Drawing.Point(7, 20);
      this.txtModelo.Name            = "txtModelo";
      this.txtModelo.ReadOnly        = true;
      this.txtModelo.Size            = new System.Drawing.Size(187, 20);
      this.txtModelo.TabIndex        = 0;
       
      this.grbPortas.Controls.Add(this.txtPortas);
      
      this.grbPortas.Location = new System.Drawing.Point(13, 127);
      this.grbPortas.Name     = "grbPortas";
      this.grbPortas.Size     = new System.Drawing.Size(117, 50);
      this.grbPortas.TabIndex = 2;
      this.grbPortas.TabStop  = false;
      this.grbPortas.Text     = " Qtd Portas ";
       
      this.txtPortas.Location = new System.Drawing.Point(7, 20);
      this.txtPortas.Name     = "txtPortas";
      this.txtPortas.ReadOnly = true;
      this.txtPortas.Size     = new System.Drawing.Size(100, 20);
      this.txtPortas.TabIndex = 0;
       
      this.grbLargura.Controls.Add(this.txtLargura);
      
      this.grbLargura.Location = new System.Drawing.Point(133, 127);
      this.grbLargura.Name     = "grbLargura";
      this.grbLargura.Size     = new System.Drawing.Size(80, 50);
      this.grbLargura.TabIndex = 3;
      this.grbLargura.TabStop  = false;
      this.grbLargura.Text     = " Largura ";
    
      this.txtLargura.Location = new System.Drawing.Point(7, 20);
      this.txtLargura.Name     = "txtLargura";
      this.txtLargura.ReadOnly = true;
      this.txtLargura.Size     = new System.Drawing.Size(67, 20);
      this.txtLargura.TabIndex = 0;
       
      this.grbComprimento.Controls.Add(this.txtComprimento);
      
      this.grbComprimento.Location = new System.Drawing.Point(216, 127);
      this.grbComprimento.Name     = "grbComprimento";
      this.grbComprimento.Size     = new System.Drawing.Size(91, 50);
      this.grbComprimento.TabIndex = 4;
      this.grbComprimento.TabStop  = false;
      this.grbComprimento.Text     = " Comprimento ";
       
      this.txtComprimento.Location = new System.Drawing.Point(7, 20);
      this.txtComprimento.Name     = "txtComprimento";
      this.txtComprimento.ReadOnly = true;
      this.txtComprimento.Size     = new System.Drawing.Size(78, 20);
      this.txtComprimento.TabIndex = 0;
       
      this.grbImagem.Controls.Add(this.pctImagem);
      
      this.grbImagem.Location = new System.Drawing.Point(217, 13);
      this.grbImagem.Name     = "grbImagem";
      this.grbImagem.Size     = new System.Drawing.Size(90, 107);
      this.grbImagem.TabIndex = 5;
      this.grbImagem.TabStop  = false;
      this.grbImagem.Text     = " Imagem ";
       
      this.pctImagem.Location = new System.Drawing.Point(7, 20);
      this.pctImagem.Name     = "pctImagem";
      this.pctImagem.Size     = new System.Drawing.Size(77, 77);
      this.pctImagem.TabIndex = 0;
      this.pctImagem.TabStop  = false;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(29, 190);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 6;
      this.btnLocalizar.UseVisualStyleBackColor = true;
       
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(83, 190);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 7;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(137, 190);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 8;
      this.btnDeletar.UseVisualStyleBackColor = true;
       
      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(191, 190);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 9;
      this.btnOk.UseVisualStyleBackColor = true;
       
      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(245, 190);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 10;
      this.btnCancela.UseVisualStyleBackColor = true;
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(320, 253);
      
      this.Controls.Add(this.btnCancela)    ;
      this.Controls.Add(this.btnOk)         ;
      this.Controls.Add(this.btnDeletar)    ;
      this.Controls.Add(this.btnNovo)       ;
      this.Controls.Add(this.btnLocalizar)  ;
      this.Controls.Add(this.grbImagem)     ;
      this.Controls.Add(this.grbComprimento);
      this.Controls.Add(this.grbLargura)    ;
      this.Controls.Add(this.grbPortas)     ;
      this.Controls.Add(this.grbModelo)     ;
      this.Controls.Add(this.gbxCodModelo)  ;
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmModelo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text          = "Modelo dos Veículos";
      
      this.gbxCodModelo.ResumeLayout(false)  ;
      this.gbxCodModelo.PerformLayout()      ;
      this.grbModelo.ResumeLayout(false)     ;
      this.grbModelo.PerformLayout()         ;
      this.grbPortas.ResumeLayout(false)     ;
      this.grbPortas.PerformLayout()         ;
      this.grbLargura.ResumeLayout(false)    ;
      this.grbLargura.PerformLayout()        ;
      this.grbComprimento.ResumeLayout(false);
      this.grbComprimento.PerformLayout()    ;
      this.grbImagem.ResumeLayout(false)     ;
      
      ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
      
      this.ResumeLayout(false);

      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;

      this.txtComprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtLargura.KeyPress     += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);

    }

    private void Localizar(object sender, EventArgs e)
    {
      string strPesq               = "SELECT * FROM Modelos WHERE CodModelo = '" + this.txtCodModelo.Text + "'";
      DataSet dsPesquisa           = new DataSet();
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, this.myCon);
      
      dapPesquisa.Fill(dsPesquisa,"Modelos");
      
      if (dsPesquisa.Tables["Modelos"].Rows.Count > 0)
      {
        this.txtCodModelo.Text   = Convert.ToString(dsPesquisa.Tables["Modelos"].Rows[0]["CodModelo"])  ;
        this.txtModelo.Text      = Convert.ToString(dsPesquisa.Tables["Modelos"].Rows[0]["Modelo"])     ;
        this.txtPortas.Text      = Convert.ToString(dsPesquisa.Tables["Modelos"].Rows[0]["Portas"])     ;
        this.txtLargura.Text     = Convert.ToString(dsPesquisa.Tables["Modelos"].Rows[0]["Largura"])    ;
        this.txtComprimento.Text = Convert.ToString(dsPesquisa.Tables["Modelos"].Rows[0]["Comprimento"]);
      }
      else
      {
        MessageBox.Show("Modelo não localizado...","Pesquisa de Modelos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      }

      this.myCon.Close();
    }

    private void Novo(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = false;
      this.btnNovo.Enabled      = false;
      this.btnDeletar.Enabled   = false;
      this.btnOk.Enabled        = true;
      this.btnCancela.Enabled   = true;

      this.txtCodModelo.Clear()  ;
      this.txtModelo.Clear()     ;
      this.txtPortas.Clear()     ;
      this.txtLargura.Clear()    ;
      this.txtComprimento.Clear();

      this.txtModelo.ReadOnly      = false;
      this.txtPortas.ReadOnly      = false;
      this.txtLargura.ReadOnly     = false;
      this.txtComprimento.ReadOnly = false;

      this.txtCodModelo.Focus();
    }

    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Modelos (CodModelo,Modelo,Portas,Largura,Comprimento)" +
                              " VALUES (@CodMo,@Mod,@NPortas,@Largu,@Comp)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, this.myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@CodMo"  , OleDbType.Char,  6));
      cmdGrava.Parameters.Add(new OleDbParameter("@Mod"    , OleDbType.Char, 30));
      cmdGrava.Parameters.Add(new OleDbParameter("@NPortas", OleDbType.Integer ));
      cmdGrava.Parameters.Add(new OleDbParameter("@Largu"  , OleDbType.Single  ));
      cmdGrava.Parameters.Add(new OleDbParameter("@Comp"   , OleDbType.Single  ));

      cmdGrava.Parameters["@CodMo"].Value   = this.txtCodModelo.Text                    ;
      cmdGrava.Parameters["@Mod"].Value     = this.txtModelo.Text                       ;
      cmdGrava.Parameters["@NPortas"].Value = Convert.ToInt32(this.txtPortas.Text)      ;
      cmdGrava.Parameters["@Largu"].Value   = Convert.ToSingle(this.txtLargura.Text)    ;
      cmdGrava.Parameters["@Comp"].Value    = Convert.ToSingle(this.txtComprimento.Text);

      cmdGrava.Connection.Open() ; 
      cmdGrava.ExecuteNonQuery() ;
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtModelo.ReadOnly      = true;
      this.txtPortas.ReadOnly      = true;
      this.txtLargura.ReadOnly     = true;
      this.txtComprimento.ReadOnly = true; 
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtCodModelo.Clear()  ;
      this.txtModelo.Clear()     ;
      this.txtPortas.Clear()     ;
      this.txtLargura.Clear()    ;
      this.txtComprimento.Clear();

      this.txtModelo.ReadOnly      = true;
      this.txtPortas.ReadOnly      = true;
      this.txtLargura.ReadOnly     = true;
      this.txtComprimento.ReadOnly = true;

      this.txtCodModelo.Focus();
    }

    private void Deletar(object sender, EventArgs e)
    {
      string strExclu       = "DELETE FROM Modelos WHERE CodModelo = '" + this.txtCodModelo.Text + "'";
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, this.myCon);

      cmdExclu.Connection.Open() ;
      cmdExclu.ExecuteNonQuery() ;
      cmdExclu.Connection.Close();

      MessageBox.Show("Modelo excluído...", "Exclusão de Modelos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.txtCodModelo.Clear()  ;
      this.txtModelo.Clear()     ;
      this.txtPortas.Clear()     ;
      this.txtLargura.Clear()    ;
      this.txtComprimento.Clear();
      
      this.txtCodModelo.Focus();
    }

    private void Only_Number(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
        e.Handled = true;
    }

  }
}