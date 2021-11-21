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
 *   Data da Criação: 07/09/2008                                      *
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
  public partial class frmPorto : Form
  {
    public  OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");
    
    private System.Windows.Forms.Button btnCancela  ;
    private System.Windows.Forms.Button btnOk       ;
    private System.Windows.Forms.Button btnDeletar  ;
    private System.Windows.Forms.Button btnNovo     ;
    private System.Windows.Forms.Button btnLocalizar;
    
    private System.Windows.Forms.GroupBox grbCodigo   ;
    private System.Windows.Forms.GroupBox grbNomePorto;
    private System.Windows.Forms.GroupBox grbDocas    ;
    private System.Windows.Forms.GroupBox grbPatios   ;
    private System.Windows.Forms.GroupBox grbCidade   ;
    
    private System.Windows.Forms.TextBox txtNomePorto;
    private System.Windows.Forms.TextBox txtNumDocas ;
    private System.Windows.Forms.TextBox txtNumPatios;
    private System.Windows.Forms.TextBox txtCodPorto ;
    private System.Windows.Forms.TextBox txtCidade   ;
    
    public frmPorto()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPorto));
      
      this.btnCancela   = new System.Windows.Forms.Button()  ;
      this.btnOk        = new System.Windows.Forms.Button()  ;
      this.btnDeletar   = new System.Windows.Forms.Button()  ;
      this.btnNovo      = new System.Windows.Forms.Button()  ;
      this.btnLocalizar = new System.Windows.Forms.Button()  ;
      
      this.grbCodigo    = new System.Windows.Forms.GroupBox();
      this.grbNomePorto = new System.Windows.Forms.GroupBox();
      this.grbDocas     = new System.Windows.Forms.GroupBox();
      this.grbPatios    = new System.Windows.Forms.GroupBox();
      this.grbCidade    = new System.Windows.Forms.GroupBox();

      this.txtNumPatios = new System.Windows.Forms.TextBox() ;
      this.txtCidade    = new System.Windows.Forms.TextBox() ;
      this.txtNumDocas  = new System.Windows.Forms.TextBox() ;
      this.txtCodPorto  = new System.Windows.Forms.TextBox() ;
      this.txtNomePorto = new System.Windows.Forms.TextBox() ;
      
      this.grbCodigo.SuspendLayout();
      this.grbNomePorto.SuspendLayout();
      this.grbDocas.SuspendLayout();
      this.grbPatios.SuspendLayout();
      this.grbCidade.SuspendLayout();
      
      this.SuspendLayout();
      
      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(330, 191);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 15;
      this.btnCancela.UseVisualStyleBackColor = true;
      
      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(276, 191);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 14;
      this.btnOk.UseVisualStyleBackColor = true;
       
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(222, 191);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 13;
      this.btnDeletar.UseVisualStyleBackColor = true;
      
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(168, 191);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 12;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(114, 191);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 11;
      this.btnLocalizar.UseVisualStyleBackColor = true;
      
      this.grbCodigo.Controls.Add(this.txtCodPorto);
      
      this.grbCodigo.Location = new System.Drawing.Point(13, 13);
      this.grbCodigo.Name     = "grbCodigo";
      this.grbCodigo.Size     = new System.Drawing.Size(105, 50);
      this.grbCodigo.TabIndex = 16;
      this.grbCodigo.TabStop  = false;
      this.grbCodigo.Text     = " Código ";
      
      this.txtCodPorto.BackColor = System.Drawing.SystemColors.Info;
      this.txtCodPorto.Enabled   = true;
      this.txtCodPorto.Location  = new System.Drawing.Point(7, 20);
      this.txtCodPorto.Name      = "txtCodPorto";
      this.txtCodPorto.Size      = new System.Drawing.Size(88, 20);
      this.txtCodPorto.TabIndex  = 0;
       
      this.grbNomePorto.Controls.Add(this.txtNomePorto);
      
      this.grbNomePorto.Location = new System.Drawing.Point(13, 70);
      this.grbNomePorto.Name     = "grbNomePorto";
      this.grbNomePorto.Size     = new System.Drawing.Size(299, 50);
      this.grbNomePorto.TabIndex = 17;
      this.grbNomePorto.TabStop  = false;
      this.grbNomePorto.Text     = " Nome do Porto ";
      
      this.txtNomePorto.Location = new System.Drawing.Point(7, 20);
      this.txtNomePorto.Name     = "txtNomePorto";
      this.txtNomePorto.ReadOnly = true;
      this.txtNomePorto.Size     = new System.Drawing.Size(286, 20);
      this.txtNomePorto.TabIndex = 0;
      
      this.grbDocas.Controls.Add(this.txtNumDocas);
      
      this.grbDocas.Location = new System.Drawing.Point(315, 70);
      this.grbDocas.Name     = "grbDocas";
      this.grbDocas.Size     = new System.Drawing.Size(69, 50);
      this.grbDocas.TabIndex = 18;
      this.grbDocas.TabStop  = false;
      this.grbDocas.Text     = " Docas ";
      
      this.txtNumDocas.Location = new System.Drawing.Point(7, 20);
      this.txtNumDocas.Name     = "txtNumDocas";
      this.txtNumDocas.ReadOnly = true;
      this.txtNumDocas.Size     = new System.Drawing.Size(54, 20);
      this.txtNumDocas.TabIndex = 0;
      
      this.grbPatios.Controls.Add(this.txtNumPatios);
      
      this.grbPatios.Location = new System.Drawing.Point(387, 70);
      this.grbPatios.Name     = "grbPatios";
      this.grbPatios.Size     = new System.Drawing.Size(64, 50);
      this.grbPatios.TabIndex = 19;
      this.grbPatios.TabStop  = false;
      this.grbPatios.Text     = " Patios ";
      
      this.txtNumPatios.Location = new System.Drawing.Point(7, 20);
      this.txtNumPatios.Name     = "txtNumPatios";
      this.txtNumPatios.ReadOnly = true;
      this.txtNumPatios.Size     = new System.Drawing.Size(50, 20);
      this.txtNumPatios.TabIndex = 0;
      
      this.grbCidade.Controls.Add(this.txtCidade);
      
      this.grbCidade.Location = new System.Drawing.Point(13, 126);
      this.grbCidade.Name     = "grbCidade";
      this.grbCidade.Size     = new System.Drawing.Size(438, 50);
      this.grbCidade.TabIndex = 20;
      this.grbCidade.TabStop  = false;
      this.grbCidade.Text     = " Cidade ";
      
      this.txtCidade.Location = new System.Drawing.Point(7, 20);
      this.txtCidade.Name     = "txtCidade";
      this.txtCidade.ReadOnly = true;
      this.txtCidade.Size     = new System.Drawing.Size(424, 20);
      this.txtCidade.TabIndex = 0;
      
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(493, 255);
      
      this.Controls.Add(this.grbCidade)   ;
      this.Controls.Add(this.grbPatios)   ;
      this.Controls.Add(this.grbDocas)    ;
      this.Controls.Add(this.grbNomePorto);
      this.Controls.Add(this.grbCodigo)   ;
      this.Controls.Add(this.btnCancela)  ;
      this.Controls.Add(this.btnOk)       ;
      this.Controls.Add(this.btnDeletar)  ;
      this.Controls.Add(this.btnNovo)     ;
      this.Controls.Add(this.btnLocalizar);
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmPorto";
      this.Text          = "Registro de Portos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      
      this.grbCodigo.ResumeLayout(false)   ;
      this.grbCodigo.PerformLayout()       ;
      this.grbNomePorto.ResumeLayout(false);
      this.grbNomePorto.PerformLayout()    ;
      this.grbDocas.ResumeLayout(false)    ;
      this.grbDocas.PerformLayout()        ;
      this.grbPatios.ResumeLayout(false)   ;
      this.grbPatios.PerformLayout()       ;
      this.grbCidade.ResumeLayout(false)   ;
      this.grbCidade.PerformLayout()       ;
      this.ResumeLayout(false)             ;
      
      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;

      this.txtNumDocas.KeyPress  += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtNumPatios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
    }

    private void Localizar(object sender, EventArgs e)
    {
      string strPesq               = "SELECT * FROM Portos WHERE CodPorto = " + txtCodPorto.Text;
      DataSet dsPesquisa           = new DataSet();
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, myCon);
      dapPesquisa.Fill(dsPesquisa, "Portos");

      if (dsPesquisa.Tables["Portos"].Rows.Count > 0)
      {
        this.txtNomePorto.Text = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["NomePorto"]);
        this.txtCidade.Text    = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["Cidade"])   ;
        this.txtNumPatios.Text = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["NumPatios"]);
        this.txtNumDocas.Text  = Convert.ToString(dsPesquisa.Tables["Portos"].Rows[0]["NumDocas"]) ;
      }
      else
      {
        MessageBox.Show("Porto não localizado...", "Pesquisa de Portos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

      this.txtCodPorto.Clear() ;
      this.txtNomePorto.Clear();
      this.txtCidade.Clear()   ;
      this.txtNumDocas.Clear() ;
      this.txtNumPatios.Clear();

      this.txtNomePorto.ReadOnly = false;
      this.txtCidade.ReadOnly    = false;
      this.txtNumDocas.ReadOnly  = false;
      this.txtNumPatios.ReadOnly = false;
      this.txtCodPorto.ReadOnly  = true ;

      this.txtNomePorto.Focus();
    }

    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Portos (NomePorto,Cidade,NumPatios,NumDocas)" +
                              " VALUES (@NomPorto,@Cid,@NPatios,@NDocas)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@NomPorto", OleDbType.Char, 30));
      cmdGrava.Parameters.Add(new OleDbParameter("@Cid"     , OleDbType.Char, 50));
      cmdGrava.Parameters.Add(new OleDbParameter("@NPatios" , OleDbType.Integer ));
      cmdGrava.Parameters.Add(new OleDbParameter("@NDocas"  , OleDbType.Integer ));

      cmdGrava.Parameters["@NomPorto"].Value = txtNomePorto.Text                 ;
      cmdGrava.Parameters["@Cid"].Value      = txtCidade.Text                    ;
      cmdGrava.Parameters["@NPatios"].Value  = Convert.ToInt32(txtNumPatios.Text);
      cmdGrava.Parameters["@NDocas"].Value   = Convert.ToInt32(txtNumDocas.Text);

      cmdGrava.Connection.Open() ;
      cmdGrava.ExecuteNonQuery() ;
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtNomePorto.ReadOnly = true ;
      this.txtCidade.ReadOnly    = true ;
      this.txtNumDocas.ReadOnly  = true ;
      this.txtNumPatios.ReadOnly = true ;
      this.txtCodPorto.ReadOnly  = false; 
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtCodPorto.Clear() ;
      this.txtNomePorto.Clear();
      this.txtCidade.Clear()   ;
      this.txtNumDocas.Clear() ;
      this.txtNumPatios.Clear();

      this.txtNomePorto.ReadOnly = true ;
      this.txtCidade.ReadOnly    = true ;
      this.txtNumDocas.ReadOnly  = true ;
      this.txtNumPatios.ReadOnly = true ;
      this.txtCodPorto.ReadOnly  = false;

      this.txtCodPorto.Focus();
    }

    private void Deletar(object sender, EventArgs e)
    {
      string strExclu       = "DELETE FROM Portos WHERE CodPorto = " + txtCodPorto.Text;
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, myCon);

      cmdExclu.Connection.Open() ;
      cmdExclu.ExecuteNonQuery() ;
      cmdExclu.Connection.Close();

      MessageBox.Show("Porto excluído...", "Exclusão de Portos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.txtCodPorto.Clear() ;
      this.txtNomePorto.Clear();
      this.txtCidade.Clear()   ;
      this.txtNumDocas.Clear() ;
      this.txtNumPatios.Clear();

      this.txtCodPorto.Focus();
    }

    private void Only_Number(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
        e.Handled = true;
    }
    
  }
}