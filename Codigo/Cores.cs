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
 *   Data da Criação: 08/09/2008                                      *
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
  public partial class frmCores : Form
  {
    
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.GroupBox grbRGB    ;
    private System.Windows.Forms.GroupBox grbNomeCor;
    
    private System.Windows.Forms.TextBox txtRGB    ;
    private System.Windows.Forms.TextBox txtNomeCor;
    
    private System.Windows.Forms.Button btnCancela  ;
    private System.Windows.Forms.Button btnOk       ;
    private System.Windows.Forms.Button btnDeletar  ;
    private System.Windows.Forms.Button btnNovo     ;
    private System.Windows.Forms.Button btnLocalizar;
  
    public frmCores()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCores));
      
      this.grbRGB     = new System.Windows.Forms.GroupBox();
      this.grbNomeCor = new System.Windows.Forms.GroupBox();
      
      this.txtRGB     = new System.Windows.Forms.TextBox();
      this.txtNomeCor = new System.Windows.Forms.TextBox();
      
      this.btnCancela   = new System.Windows.Forms.Button();
      this.btnOk        = new System.Windows.Forms.Button();
      this.btnDeletar   = new System.Windows.Forms.Button();
      this.btnNovo      = new System.Windows.Forms.Button();
      this.btnLocalizar = new System.Windows.Forms.Button();

      this.grbRGB.SuspendLayout()    ;
      this.grbNomeCor.SuspendLayout();
      
      this.SuspendLayout();
       
      this.grbRGB.Controls.Add(this.txtRGB);
      
      this.grbRGB.Location = new System.Drawing.Point(219, 12);
      this.grbRGB.Name     = "grbRGB";
      this.grbRGB.Size     = new System.Drawing.Size(114, 50);
      this.grbRGB.TabIndex = 27;
      this.grbRGB.TabStop  = false;
      this.grbRGB.Text     = " RGB ";
       
      this.txtRGB.Location        = new System.Drawing.Point(7, 20);
      this.txtRGB.MaxLength       = 6;
      this.txtRGB.Name            = "txtRGB";
      this.txtRGB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRGB.ReadOnly        = true;
      this.txtRGB.Size            = new System.Drawing.Size(97, 20);
      this.txtRGB.TabIndex        = 0;
       
      this.grbNomeCor.Controls.Add(this.txtNomeCor);
      
      this.grbNomeCor.Location = new System.Drawing.Point(12, 12);
      this.grbNomeCor.Name     = "grbNomeCor";
      this.grbNomeCor.Size     = new System.Drawing.Size(203, 50);
      this.grbNomeCor.TabIndex = 26;
      this.grbNomeCor.TabStop  = false;
      this.grbNomeCor.Text =  " Nome da Cor ";
    
      this.txtNomeCor.Location        = new System.Drawing.Point(7, 20);
      this.txtNomeCor.MaxLength       = 20;
      this.txtNomeCor.Name            = "txtNomeCor";
      this.txtNomeCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeCor.Size            = new System.Drawing.Size(184, 20);
      this.txtNomeCor.TabIndex        = 0;
       
      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(257, 80);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 25;
      this.btnCancela.UseVisualStyleBackColor = true;
 
      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(203, 80);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 24;
      this.btnOk.UseVisualStyleBackColor = true;
    
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(149, 80);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 23;
      this.btnDeletar.UseVisualStyleBackColor = true;
       
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(95, 80);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 22;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(41, 80);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 21;
      this.btnLocalizar.UseVisualStyleBackColor = true;
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(346, 150);
      
      this.Controls.Add(this.grbRGB)      ;
      this.Controls.Add(this.grbNomeCor)  ;
      this.Controls.Add(this.btnCancela)  ;
      this.Controls.Add(this.btnOk)       ;
      this.Controls.Add(this.btnDeletar)  ;
      this.Controls.Add(this.btnNovo)     ;
      this.Controls.Add(this.btnLocalizar);
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmCores";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text          = "Manutenção de Cores";
     
      
      this.grbRGB.ResumeLayout(false)    ;
      this.grbRGB.PerformLayout()        ;
      this.grbNomeCor.ResumeLayout(false);
      this.grbNomeCor.PerformLayout()    ;
      this.ResumeLayout(false)           ;
   
      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);
    }

    private void Localizar(object sender, EventArgs e)
    {
      string strPesq               = "SELECT * FROM Cores WHERE NomeCor = '" + this.txtNomeCor.Text + "'";
      DataSet dsPesquisa           = new DataSet();
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, this.myCon);
      
      dapPesquisa.Fill(dsPesquisa, "Cores");

      if (dsPesquisa.Tables["Cores"].Rows.Count > 0)
      {
        this.txtNomeCor.Text = Convert.ToString(dsPesquisa.Tables["Cores"].Rows[0]["NomeCor"]);
        this.txtRGB.Text     = Convert.ToString(dsPesquisa.Tables["Cores"].Rows[0]["Cor_RGB"]);
      }
      else
      {
        MessageBox.Show("Cor não localizada...", "Pesquisa de Cores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      this.myCon.Close();
    }

    private void Novo(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = false;
      this.btnNovo.Enabled      = false;
      this.btnDeletar.Enabled   = false;
      this.btnOk.Enabled        = true ;
      this.btnCancela.Enabled   = true ;

      this.txtNomeCor.Clear();
      this.txtRGB.Clear()    ;
      
      this.txtNomeCor.ReadOnly = false;
      this.txtRGB.ReadOnly     = false;

      this.txtNomeCor.Focus();
    }

    private void Deletar(object sender, EventArgs e)
    {
      string strExclu       = "DELETE FROM Cores WHERE NomeCor = '" + this.txtNomeCor.Text + "'";
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, this.myCon);

      cmdExclu.Connection.Open();
      cmdExclu.ExecuteNonQuery();
      cmdExclu.Connection.Close();

      MessageBox.Show("Cor excluída...", "Exclusão de Cores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.txtNomeCor.Clear();
      this.txtRGB.Clear()    ;
      
      this.txtNomeCor.Focus();
    }

    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Cores (NomeCor,Cor_RGB) VALUES (@Nome,@RGB)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, this.myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@Nome", OleDbType.Char, 20));
      cmdGrava.Parameters.Add(new OleDbParameter("@RGB" , OleDbType.Char, 6 ));

      cmdGrava.Parameters["@Nome"].Value = this.txtNomeCor.Text;
      cmdGrava.Parameters["@RGB" ].Value = this.txtRGB.Text    ;

      cmdGrava.Connection.Open() ;
      cmdGrava.ExecuteNonQuery() ;
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtNomeCor.ReadOnly = false;
      this.txtRGB.ReadOnly     = true ;
      
      this.txtNomeCor.Clear();
      this.txtRGB.Clear()    ;
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtNomeCor.Clear();
      this.txtRGB.Clear()    ;

      this.txtNomeCor.ReadOnly = false;
      this.txtRGB.ReadOnly     = true;

      this.txtNomeCor.Focus();
    }
  }
}