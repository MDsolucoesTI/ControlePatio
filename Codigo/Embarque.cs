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
 *   Data da Criação: 10/09/2008                                      *
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
  public partial class frmEmbarque : Form
  {
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.Button btnCancela;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnDeletar;
    private System.Windows.Forms.Button btnNovo;
    private System.Windows.Forms.Button btnLocalizar;
    
    private System.Windows.Forms.GroupBox grbCodigo;
    private System.Windows.Forms.GroupBox grbDtEmba;
    private System.Windows.Forms.GroupBox grbQtEmba;
    private System.Windows.Forms.GroupBox grbNavio ;
    private System.Windows.Forms.GroupBox grbPorto ;
    
    private System.Windows.Forms.TextBox txtNavio      ;
    private System.Windows.Forms.TextBox txtQtEmbarque ;
    private System.Windows.Forms.TextBox txtCodEmbarque;
    
    private System.Windows.Forms.DateTimePicker dtDtEmbarque;
    
    private System.Windows.Forms.ComboBox cmbPorto;
 
    public frmEmbarque()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmbarque));
      
      this.btnCancela   = new System.Windows.Forms.Button();
      this.btnOk        = new System.Windows.Forms.Button();
      this.btnDeletar   = new System.Windows.Forms.Button();
      this.btnNovo      = new System.Windows.Forms.Button();
      this.btnLocalizar = new System.Windows.Forms.Button();
      
      this.grbCodigo = new System.Windows.Forms.GroupBox();
      this.grbDtEmba = new System.Windows.Forms.GroupBox();
      this.grbQtEmba = new System.Windows.Forms.GroupBox();
      this.grbNavio  = new System.Windows.Forms.GroupBox();
      this.grbPorto  = new System.Windows.Forms.GroupBox();
      
      this.txtCodEmbarque = new System.Windows.Forms.TextBox();
      this.txtNavio       = new System.Windows.Forms.TextBox();
      this.txtQtEmbarque  = new System.Windows.Forms.TextBox();
      
      this.dtDtEmbarque = new System.Windows.Forms.DateTimePicker();
      
      this.cmbPorto = new System.Windows.Forms.ComboBox();
      
      this.grbCodigo.SuspendLayout();
      this.grbDtEmba.SuspendLayout();
      this.grbQtEmba.SuspendLayout();
      this.grbNavio.SuspendLayout() ;
      this.grbPorto.SuspendLayout() ;
      this.SuspendLayout()          ;
       
      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(275, 191);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 20;
      this.btnCancela.UseVisualStyleBackColor = true;
       
      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(221, 191);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 19;
      this.btnOk.UseVisualStyleBackColor = true;
       
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(167, 191);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 18;
      this.btnDeletar.UseVisualStyleBackColor = true;
       
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(113, 191);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 17;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(59, 191);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 16;
      this.btnLocalizar.UseVisualStyleBackColor = true;
       
      this.grbCodigo.Controls.Add(this.txtCodEmbarque);
      
      this.grbCodigo.Location = new System.Drawing.Point(12, 12);
      this.grbCodigo.Name     = "grbCodigo";
      this.grbCodigo.Size     = new System.Drawing.Size(105, 50);
      this.grbCodigo.TabIndex = 21;
      this.grbCodigo.TabStop  = false;
      this.grbCodigo.Text     = " Código ";
       
      this.txtCodEmbarque.BackColor = System.Drawing.SystemColors.Info;
      this.txtCodEmbarque.Enabled   = true;
      this.txtCodEmbarque.Location  = new System.Drawing.Point(7, 20);
      this.txtCodEmbarque.Name      = "txtCodEmbarque";
      this.txtCodEmbarque.Size      = new System.Drawing.Size(88, 20);
      this.txtCodEmbarque.TabIndex  = 0;
       
      this.grbDtEmba.Controls.Add(this.dtDtEmbarque);
      
      this.grbDtEmba.Location = new System.Drawing.Point(121, 12);
      this.grbDtEmba.Name     = "grbDtEmba";
      this.grbDtEmba.Size     = new System.Drawing.Size(249, 50);
      this.grbDtEmba.TabIndex = 22;
      this.grbDtEmba.TabStop  = false;
      this.grbDtEmba.Text     = " Data Embarque ";
       
      this.dtDtEmbarque.Enabled  = false;
      this.dtDtEmbarque.Location = new System.Drawing.Point(7, 20);
      this.dtDtEmbarque.Name     = "dtDtEmbarque";
      this.dtDtEmbarque.Size     = new System.Drawing.Size(230, 20);
      this.dtDtEmbarque.TabIndex = 0;
      this.dtDtEmbarque.Value    = new System.DateTime(2008, 8, 7, 0, 0, 0, 0);
       
      this.grbQtEmba.Controls.Add(this.txtQtEmbarque);
      
      this.grbQtEmba.Location = new System.Drawing.Point(12, 124);
      this.grbQtEmba.Name     = "grbQtEmba";
      this.grbQtEmba.Size     = new System.Drawing.Size(95, 50);
      this.grbQtEmba.TabIndex = 24;
      this.grbQtEmba.TabStop  = false;
      this.grbQtEmba.Text     = " Qtd Embarque ";
       
      this.txtQtEmbarque.Location = new System.Drawing.Point(7, 20);
      this.txtQtEmbarque.Name     = "txtQtEmbarque";
      this.txtQtEmbarque.ReadOnly = true;
      this.txtQtEmbarque.Size     = new System.Drawing.Size(82, 20);
      this.txtQtEmbarque.TabIndex = 0;
       
      this.grbNavio.Controls.Add(this.txtNavio);
      
      this.grbNavio.Location = new System.Drawing.Point(12, 68);
      this.grbNavio.Name     = "grbNavio";
      this.grbNavio.Size     = new System.Drawing.Size(358, 50);
      this.grbNavio.TabIndex = 23;
      this.grbNavio.TabStop  = false;
      this.grbNavio.Text     = " Nome do Navio ";
       
      this.txtNavio.Location = new System.Drawing.Point(7, 20);
      this.txtNavio.Name     = "txtNavio";
      this.txtNavio.ReadOnly = true;
      this.txtNavio.Size     = new System.Drawing.Size(339, 20);
      this.txtNavio.TabIndex = 0;
       
      this.grbPorto.Controls.Add(this.cmbPorto);
      
      this.grbPorto.Location = new System.Drawing.Point(111, 124);
      this.grbPorto.Name     = "grbPorto";
      this.grbPorto.Size     = new System.Drawing.Size(259, 50);
      this.grbPorto.TabIndex = 25;
      this.grbPorto.TabStop  = false;
      this.grbPorto.Text     = " Porto ";
       
      this.cmbPorto.Enabled           = false;
      this.cmbPorto.FormattingEnabled = true;
      this.cmbPorto.Location          = new System.Drawing.Point(7, 19);
      this.cmbPorto.Name              = "cmbPorto";
      this.cmbPorto.Size              = new System.Drawing.Size(240, 21);
      this.cmbPorto.TabIndex          = 0;
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(382, 254);
      
      this.Controls.Add(this.grbPorto)    ;
      this.Controls.Add(this.grbQtEmba)   ;
      this.Controls.Add(this.grbNavio)    ;
      this.Controls.Add(this.grbDtEmba)   ;
      this.Controls.Add(this.grbCodigo)   ;
      this.Controls.Add(this.btnCancela)  ;
      this.Controls.Add(this.btnOk)       ;
      this.Controls.Add(this.btnDeletar)  ;
      this.Controls.Add(this.btnNovo)     ;
      this.Controls.Add(this.btnLocalizar);
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmEmbarque";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text          = "Registro de Embarque";
      
      this.grbCodigo.ResumeLayout(false);
      this.grbCodigo.PerformLayout()    ;
      this.grbDtEmba.ResumeLayout(false);
      this.grbQtEmba.ResumeLayout(false);
      this.grbQtEmba.PerformLayout()    ;
      this.grbNavio.ResumeLayout(false) ;
      this.grbNavio.PerformLayout()     ;
      this.grbPorto.ResumeLayout(false) ;
      this.ResumeLayout(false)          ;

      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);

      this.txtQtEmbarque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);

      string strComple             = "SELECT NomePorto FROM Portos"       ;
      DataSet dsCompleta           = new DataSet()                        ;
      OleDbDataAdapter dapCompleta = new OleDbDataAdapter(strComple,myCon);
      
      dapCompleta.Fill(dsCompleta,"Portos");
      
      for(int iPos=0; iPos < dsCompleta.Tables["Portos"].Rows.Count; iPos++)
      {
        cmbPorto.Items.Add(Convert.ToString(dsCompleta.Tables["Portos"].Rows[iPos]["NomePorto"]));
      }
      
    }

    private void Localizar(object sender, EventArgs e)
    {
      string strCodPorto;
      string strPesq               = "SELECT * FROM Embarque WHERE CodEmbarque = " + txtCodEmbarque.Text;
      DataSet dsPesquisa           = new DataSet()                                                      ;
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, myCon)                               ;
      dapPesquisa.Fill(dsPesquisa, "Embarque");

      if (dsPesquisa.Tables["Embarque"].Rows.Count > 0)
      {
        txtCodEmbarque.Text = Convert.ToString(dsPesquisa.Tables["Embarque"].Rows[0]["CodEmbarque"]) ;
        dtDtEmbarque.Value  = Convert.ToDateTime(dsPesquisa.Tables["Embarque"].Rows[0]["DtEmbarque"]);
        txtNavio.Text       = Convert.ToString(dsPesquisa.Tables["Embarque"].Rows[0]["Navio"])       ;
        txtQtEmbarque.Text  = Convert.ToString(dsPesquisa.Tables["Embarque"].Rows[0]["QtEmbarque"])  ;
        strCodPorto         = Convert.ToString(dsPesquisa.Tables["Embarque"].Rows[0]["CodPorto"])    ;
        
        string strPorto           = "SELECT NomePorto FROM Portos WHERE CodPorto = " + strCodPorto;
        OleDbDataAdapter dapPorto = new OleDbDataAdapter(strPorto,myCon)                          ;
        dapPorto.Fill(dsPesquisa,"Portos");
        
        cmbPorto.Text = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["NomePorto"]);
      }
      else
      {
        MessageBox.Show("Embarque não localizado...", "Pesquisa de Embarques", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      myCon.Close();
    }      

    private void Novo(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = false;
      this.btnNovo.Enabled      = false;
      this.btnDeletar.Enabled   = false;
      this.btnOk.Enabled        = true ;
      this.btnCancela.Enabled   = true ;

      this.dtDtEmbarque.Value = DateTime.Now;
      this.cmbPorto.Text      = ""          ;
      
      this.txtCodEmbarque.Clear();
      this.txtNavio.Clear()      ;
      this.txtQtEmbarque.Clear() ;

      this.dtDtEmbarque.Enabled    = true ;
      this.cmbPorto.Enabled        = true ;
      this.txtNavio.ReadOnly       = false;
      this.txtQtEmbarque.ReadOnly  = false;
      this.txtCodEmbarque.ReadOnly = true ;
      
      this.txtNavio.Focus();
    }
    
    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Embarque (DtEmbarque,Navio,QtEmbarque,CodPorto)" +
                              " VALUES (@DtEmba,@Nav,@QtEmba,@CodPor)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, this.myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@DtEmba", OleDbType.DBTimeStamp));
      cmdGrava.Parameters.Add(new OleDbParameter("@Nav"   , OleDbType.Char,35))    ;
      cmdGrava.Parameters.Add(new OleDbParameter("@QtEmba", OleDbType.Integer))    ;
      cmdGrava.Parameters.Add(new OleDbParameter("@CodPor", OleDbType.Integer))    ;

      string strCodPorto;
      string strPorto           = "SELECT CodPorto FROM Portos WHERE NomePorto = '" + this.cmbPorto.Text + "'";
      DataSet dsPesquisa        = new DataSet();
      OleDbDataAdapter dapPorto = new OleDbDataAdapter(strPorto, this.myCon);
      dapPorto.Fill(dsPesquisa, "Portos");

      strCodPorto = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["CodPorto"]);  

      cmdGrava.Parameters["@DtEmba"].Value = this.dtDtEmbarque.Value                 ;
      cmdGrava.Parameters["@Nav"   ].Value = this.txtNavio.Text                      ;
      cmdGrava.Parameters["@QtEmba"].Value = Convert.ToInt32(this.txtQtEmbarque.Text);
      cmdGrava.Parameters["@CodPor"].Value = Convert.ToInt32(strCodPorto)            ;

      cmdGrava.Connection.Open() ;
      cmdGrava.ExecuteNonQuery() ;
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtNavio.ReadOnly       = true ;
      this.txtQtEmbarque.ReadOnly  = true ;
      this.dtDtEmbarque.Enabled    = false;
      this.cmbPorto.Enabled        = false;
      this.txtCodEmbarque.ReadOnly = false; 
      
      this.txtCodEmbarque.Focus();
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtCodEmbarque.Clear();
      this.txtNavio.Clear()      ;
      this.txtQtEmbarque.Clear() ;

      this.dtDtEmbarque.Value = DateTime.Now;
      this.cmbPorto.Text      = ""          ;

      this.txtNavio.ReadOnly       = true ;
      this.txtQtEmbarque.ReadOnly  = true ;
      this.dtDtEmbarque.Enabled    = false;
      this.cmbPorto.Enabled        = false;
      this.txtCodEmbarque.ReadOnly = false;

      this.txtCodEmbarque.Focus();
    } 
       
    private void Deletar(object sender, EventArgs e)
    {
      string strExclu = "DELETE FROM Embarque WHERE CodEmbarque = " + this.txtCodEmbarque.Text;
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, this.myCon);

      cmdExclu.Connection.Open() ;
      cmdExclu.ExecuteNonQuery() ;
      cmdExclu.Connection.Close();

      MessageBox.Show("Embarque excluído...", "Exclusão de Embarque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.txtCodEmbarque.Clear();
      this.txtNavio.Clear()      ;
      this.txtQtEmbarque.Clear() ;

      this.dtDtEmbarque.Value = DateTime.Now;
      this.cmbPorto.Text      = ""          ;

      this.txtCodEmbarque.Focus();
    }

    private void Only_Number(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
        e.Handled = true;
    }
    
  }
}