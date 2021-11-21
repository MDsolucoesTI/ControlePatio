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
 *   Data da Criação: 12/09/2008                                      *
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
  public partial class frmPatio : Form
  {
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.Button btnCancela  ;
    private System.Windows.Forms.Button btnOk       ;
    private System.Windows.Forms.Button btnDeletar  ;
    private System.Windows.Forms.Button btnNovo     ;
    private System.Windows.Forms.Button btnLocalizar;

    private System.Windows.Forms.GroupBox grbArea       ;
    private System.Windows.Forms.GroupBox grbPorto      ;
    private System.Windows.Forms.GroupBox grbPatio      ;
    private System.Windows.Forms.GroupBox grbCodigo     ;
    private System.Windows.Forms.GroupBox grbLargura    ;
    private System.Windows.Forms.GroupBox grbComprimento;
    private System.Windows.Forms.GroupBox grbRua        ;

    private System.Windows.Forms.ComboBox cmbPorto;
    
    private System.Windows.Forms.TextBox txtArea       ;
    private System.Windows.Forms.TextBox txtIDPatio    ;
    private System.Windows.Forms.TextBox txtCodPatio   ;
    private System.Windows.Forms.TextBox txtLargura    ;
    private System.Windows.Forms.TextBox txtComprimento;
    private System.Windows.Forms.TextBox txtRua        ;
    
    public frmPatio()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatio));
      
      this.btnCancela   = new System.Windows.Forms.Button();
      this.btnOk        = new System.Windows.Forms.Button();
      this.btnDeletar   = new System.Windows.Forms.Button();
      this.btnNovo      = new System.Windows.Forms.Button();
      this.btnLocalizar = new System.Windows.Forms.Button();
      
      this.grbPorto       = new System.Windows.Forms.GroupBox();
      this.grbArea        = new System.Windows.Forms.GroupBox();
      this.grbPatio       = new System.Windows.Forms.GroupBox();
      this.grbCodigo      = new System.Windows.Forms.GroupBox();
      this.grbLargura     = new System.Windows.Forms.GroupBox();
      this.grbComprimento = new System.Windows.Forms.GroupBox();
      this.grbRua         = new System.Windows.Forms.GroupBox();
      
      this.cmbPorto = new System.Windows.Forms.ComboBox();

      this.txtArea        = new System.Windows.Forms.TextBox();
      this.txtIDPatio     = new System.Windows.Forms.TextBox();
      this.txtCodPatio    = new System.Windows.Forms.TextBox();
      this.txtLargura     = new System.Windows.Forms.TextBox();
      this.txtComprimento = new System.Windows.Forms.TextBox();
      this.txtRua         = new System.Windows.Forms.TextBox();
      
      this.grbPorto.SuspendLayout();
      this.grbArea.SuspendLayout();
      this.grbPatio.SuspendLayout();
      this.grbCodigo.SuspendLayout();
      this.grbLargura.SuspendLayout();
      this.grbComprimento.SuspendLayout();
      this.grbRua.SuspendLayout();
      this.SuspendLayout();

      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(290, 191);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 25;
      this.btnCancela.UseVisualStyleBackColor = true;

      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(236, 191);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 24;
      this.btnOk.UseVisualStyleBackColor = true;
       
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(182, 191);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 23;
      this.btnDeletar.UseVisualStyleBackColor = true;
       
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(128, 191);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 22;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(74, 191);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 21;
      this.btnLocalizar.UseVisualStyleBackColor = true;
       
      this.grbPorto.Controls.Add(this.cmbPorto);
      
      this.grbPorto.Location = new System.Drawing.Point(206, 68);
      this.grbPorto.Name     = "grbPorto";
      this.grbPorto.Size     = new System.Drawing.Size(193, 50);
      this.grbPorto.TabIndex = 2;
      this.grbPorto.TabStop  = false;
      this.grbPorto.Text     = " Porto ";
       
      this.cmbPorto.Enabled           = false;
      this.cmbPorto.FormattingEnabled = true;
      this.cmbPorto.Location          = new System.Drawing.Point(7, 19);
      this.cmbPorto.Name              = "cmbPorto";
      this.cmbPorto.Size              = new System.Drawing.Size(180, 21);
      this.cmbPorto.TabIndex          = 0;
       
      this.grbArea.Controls.Add(this.txtArea);
      
      this.grbArea.Location = new System.Drawing.Point(12, 124);
      this.grbArea.Name     = "grbArea";
      this.grbArea.Size     = new System.Drawing.Size(95, 50);
      this.grbArea.TabIndex = 3;
      this.grbArea.TabStop  = false;
      this.grbArea.Text     = " Área ";
       
      this.txtArea.Location = new System.Drawing.Point(7, 20);
      this.txtArea.Name     = "txtArea";
      this.txtArea.ReadOnly = true;
      this.txtArea.Size     = new System.Drawing.Size(82, 20);
      this.txtArea.TabIndex = 0;
       
      this.grbPatio.Controls.Add(this.txtIDPatio);
      
      this.grbPatio.Location = new System.Drawing.Point(12, 68);
      this.grbPatio.Name     = "grbPatio";
      this.grbPatio.Size     = new System.Drawing.Size(191, 50);
      this.grbPatio.TabIndex = 1;
      this.grbPatio.TabStop  = false;
      this.grbPatio.Text     = " Identificação Patio ";
       
      this.txtIDPatio.Location = new System.Drawing.Point(6, 19);
      this.txtIDPatio.Name     = "txtIDPatio";
      this.txtIDPatio.ReadOnly = true;
      this.txtIDPatio.Size     = new System.Drawing.Size(178, 20);
      this.txtIDPatio.TabIndex = 0;
       
      this.grbCodigo.Controls.Add(this.txtCodPatio);
      
      this.grbCodigo.Location = new System.Drawing.Point(12, 12);
      this.grbCodigo.Name     = "grbCodigo";
      this.grbCodigo.Size     = new System.Drawing.Size(105, 50);
      this.grbCodigo.TabIndex = 0;
      this.grbCodigo.TabStop  = false;
      this.grbCodigo.Text     = " Código ";
       
      this.txtCodPatio.BackColor = System.Drawing.SystemColors.Info;
      this.txtCodPatio.Enabled   = true;
      this.txtCodPatio.Location  = new System.Drawing.Point(7, 20);
      this.txtCodPatio.Name      = "txtCodPatio";
      this.txtCodPatio.Size      = new System.Drawing.Size(88, 20);
      this.txtCodPatio.TabIndex  = 0;
       
      this.grbLargura.Controls.Add(this.txtLargura);
      
      this.grbLargura.Location = new System.Drawing.Point(109, 124);
      this.grbLargura.Name     = "grbLargura";
      this.grbLargura.Size     = new System.Drawing.Size(95, 50);
      this.grbLargura.TabIndex = 4;
      this.grbLargura.TabStop  = false;
      this.grbLargura.Text     = " Largura ";
       
      this.txtLargura.Location = new System.Drawing.Point(7, 20);
      this.txtLargura.Name     = "txtLargura";
      this.txtLargura.ReadOnly = true;
      this.txtLargura.Size     = new System.Drawing.Size(82, 20);
      this.txtLargura.TabIndex = 0;
       
      this.grbComprimento.Controls.Add(this.txtComprimento);
      
      this.grbComprimento.Location = new System.Drawing.Point(206, 124);
      this.grbComprimento.Name     = "grbComprimento";
      this.grbComprimento.Size     = new System.Drawing.Size(95, 50);
      this.grbComprimento.TabIndex = 5;
      this.grbComprimento.TabStop  = false;
      this.grbComprimento.Text     = " Comprimento ";
       
      this.txtComprimento.Location = new System.Drawing.Point(7, 20);
      this.txtComprimento.Name     = "txtComprimento";
      this.txtComprimento.ReadOnly = true;
      this.txtComprimento.Size     = new System.Drawing.Size(82, 20);
      this.txtComprimento.TabIndex = 0;
       
      this.grbRua.Controls.Add(this.txtRua);
      
      this.grbRua.Location = new System.Drawing.Point(304, 124);
      this.grbRua.Name     = "grbRua";
      this.grbRua.Size     = new System.Drawing.Size(95, 50);
      this.grbRua.TabIndex = 6;
      this.grbRua.TabStop  = false;
      this.grbRua.Text     = " Rua ";
       
      this.txtRua.Location = new System.Drawing.Point(7, 20);
      this.txtRua.Name     = "txtRua";
      this.txtRua.ReadOnly = true;
      this.txtRua.Size     = new System.Drawing.Size(82, 20);
      this.txtRua.TabIndex = 0;
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(413, 256);
      
      this.Controls.Add(this.grbRua)        ;
      this.Controls.Add(this.grbComprimento);
      this.Controls.Add(this.grbLargura)    ;
      this.Controls.Add(this.grbPorto)      ;
      this.Controls.Add(this.grbArea)       ;
      this.Controls.Add(this.grbPatio)      ;
      this.Controls.Add(this.grbCodigo)     ;
      this.Controls.Add(this.btnCancela)    ;
      this.Controls.Add(this.btnOk)         ;
      this.Controls.Add(this.btnDeletar)    ;
      this.Controls.Add(this.btnNovo)       ;
      this.Controls.Add(this.btnLocalizar)  ;
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmPatio";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text          = "Manutenção de Patios";
      
      this.grbPorto.ResumeLayout(false)      ;
      this.grbArea.ResumeLayout(false)       ;
      this.grbArea.PerformLayout()           ;
      this.grbPatio.ResumeLayout(false)      ;
      this.grbPatio.PerformLayout()          ;
      this.grbCodigo.ResumeLayout(false)     ;
      this.grbCodigo.PerformLayout()         ;
      this.grbLargura.ResumeLayout(false)    ;
      this.grbLargura.PerformLayout()        ;
      this.grbComprimento.ResumeLayout(false);
      this.grbComprimento.PerformLayout()    ;
      this.grbRua.ResumeLayout(false)        ;
      this.grbRua.PerformLayout()            ;
      this.ResumeLayout(false)               ;

      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;

      this.txtComprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtLargura.KeyPress     += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtArea.KeyPress        += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtRua.KeyPress         += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);

      string strComple             = "SELECT NomePorto FROM Portos"        ;
      DataSet dsCompleta           = new DataSet()                         ; 
      OleDbDataAdapter dapCompleta = new OleDbDataAdapter(strComple, myCon);
      
      dapCompleta.Fill(dsCompleta, "Portos");

      for (int iPos = 0; iPos < dsCompleta.Tables["Portos"].Rows.Count; iPos++)
      {
        cmbPorto.Items.Add(Convert.ToString(dsCompleta.Tables["Portos"].Rows[iPos]["NomePorto"]));
      }
    }

    private void Localizar(object sender, EventArgs e)
    {
      string strCodPorto;
      string strPesq               = "SELECT * FROM Patio WHERE CodPatio = " + txtCodPatio.Text;
      DataSet dsPesquisa           = new DataSet()                                             ;
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, this.myCon)                 ;
      dapPesquisa.Fill(dsPesquisa, "Patio");

      if (dsPesquisa.Tables["Patio"].Rows.Count > 0)
      {
        this.txtIDPatio.Text     = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["IDPatio"]);
        this.txtArea.Text        = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["Area"]);
        this.txtLargura.Text     = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["Largura"]);
        this.txtComprimento.Text = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["Comprimento"]);
        this.txtRua.Text         = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["LargRua"]);
        strCodPorto              = Convert.ToString(dsPesquisa.Tables["Patio"].Rows[0]["CodPorto"])   ;

        string strPorto           = "SELECT NomePorto FROM Portos WHERE CodPorto = " + strCodPorto;
        OleDbDataAdapter dapPorto = new OleDbDataAdapter(strPorto, this.myCon);
        
        dapPorto.Fill(dsPesquisa, "Portos");
        
       this.cmbPorto.Text = (Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["NomePorto"]));
      }
      else
      {
        MessageBox.Show("Patio não localizado...", "Pesquisa de Patios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

      this.cmbPorto.Text = "";

      this.txtCodPatio.Clear()   ;
      this.txtIDPatio.Clear()    ;
      this.txtArea.Clear()       ;
      this.txtLargura.Clear()    ;
      this.txtComprimento.Clear();
      this.txtRua.Clear()        ;

      this.cmbPorto.Enabled        = true ;
      this.txtIDPatio.ReadOnly     = false;
      this.txtArea.ReadOnly        = false;
      this.txtLargura.ReadOnly     = false;
      this.txtComprimento.ReadOnly = false;
      this.txtRua.ReadOnly         = false;
      this.txtCodPatio.ReadOnly    = true ;

      this.txtIDPatio.Focus();
    }

    private void Deletar(object sender, EventArgs e)
    {
      string strExclu = "DELETE FROM Patio WHERE CodPatio = " + this.txtCodPatio.Text;
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, this.myCon);

      cmdExclu.Connection.Open() ;
      cmdExclu.ExecuteNonQuery() ;
      cmdExclu.Connection.Close();

      MessageBox.Show("Patio excluído...", "Exclusão de Patio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.cmbPorto.Text = "";

      this.txtCodPatio.Clear()   ;
      this.txtIDPatio.Clear()    ;
      this.txtArea.Clear()       ;
      this.txtLargura.Clear()    ;
      this.txtComprimento.Clear();
      this.txtRua.Clear()        ;

      this.txtCodPatio.Focus();
    }

    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Patio (IDPatio,Area,Largura,Comprimento,LargRua,CodPorto)" +
                              " VALUES (@Patio,@VArea,@VLargura,@VCompri,@LRua,@CodPor)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@Patio"   , OleDbType.Char, 20));
      cmdGrava.Parameters.Add(new OleDbParameter("@VArea"   , OleDbType.Single  ));
      cmdGrava.Parameters.Add(new OleDbParameter("@VLargura", OleDbType.Single  ));
      cmdGrava.Parameters.Add(new OleDbParameter("@VCompri" , OleDbType.Single  ));
      cmdGrava.Parameters.Add(new OleDbParameter("@LRua"    , OleDbType.Single  ));
      cmdGrava.Parameters.Add(new OleDbParameter("@CodPor"  , OleDbType.Integer ));

      string strCodPorto;
      string strPorto = "SELECT CodPorto FROM Portos WHERE NomePorto = '" + this.cmbPorto.Text + "'";
      DataSet dsPesquisa        = new DataSet();
      OleDbDataAdapter dapPorto = new OleDbDataAdapter(strPorto, this.myCon);
      dapPorto.Fill(dsPesquisa, "Portos");

      strCodPorto = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["CodPorto"]);

      cmdGrava.Parameters["@Patio"].Value    = this.txtIDPatio.Text                      ;
      cmdGrava.Parameters["@VArea"].Value    = Convert.ToSingle(this.txtArea.Text)       ;
      cmdGrava.Parameters["@VLargura"].Value = Convert.ToSingle(this.txtLargura.Text)    ;
      cmdGrava.Parameters["@VCompri"].Value  = Convert.ToSingle(this.txtComprimento.Text);
      cmdGrava.Parameters["@LRua"].Value     = Convert.ToSingle(this.txtRua.Text)        ;
      cmdGrava.Parameters["@CodPor"].Value   = Convert.ToInt32(strCodPorto)              ;

      cmdGrava.Connection.Open();
      cmdGrava.ExecuteNonQuery();
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtIDPatio.ReadOnly     = true ;
      this.txtArea.ReadOnly        = true ;
      this.txtLargura.ReadOnly     = true ;
      this.txtComprimento.ReadOnly = true ;
      this.txtRua.ReadOnly         = true ;
      this.txtCodPatio.ReadOnly    = false;
      this.cmbPorto.Enabled        = false;
      
      this.txtCodPatio.Focus();
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.cmbPorto.Text = "";
      
      this.txtIDPatio.Clear()    ;
      this.txtCodPatio.Clear()   ;
      this.txtArea.Clear()       ;
      this.txtComprimento.Clear();
      this.txtLargura.Clear()    ;
      this.txtRua.Clear()        ;

      this.txtIDPatio.ReadOnly     = true ;
      this.txtArea.ReadOnly        = true ;
      this.txtLargura.ReadOnly     = true ;
      this.txtComprimento.ReadOnly = true ;
      this.txtRua.ReadOnly         = true ;
      this.txtCodPatio.ReadOnly    = false;
      this.cmbPorto.Enabled        = false;

      this.txtCodPatio.Focus();
    }

    private void Only_Number(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
        e.Handled = true;
    }
    
  }
}