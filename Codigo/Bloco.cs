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
 *   Data da Criação: 010/09/2008                                      *
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
  public partial class frmBloco : Form
  {

    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");
    
    private string strCodPatio;

    private System.Windows.Forms.TextBox txtColunas;
    private System.Windows.Forms.TextBox txtLinhas ;
    private System.Windows.Forms.TextBox txtBloco  ;
    
    private System.Windows.Forms.ComboBox cmbEmbarque;
    private System.Windows.Forms.ComboBox cmbPatio   ;
    private System.Windows.Forms.ComboBox cmbModelo  ;
    
    private System.Windows.Forms.Button btnCancela  ;
    private System.Windows.Forms.Button btnOk       ;
    private System.Windows.Forms.Button btnDeletar  ;
    private System.Windows.Forms.Button btnNovo     ;
    private System.Windows.Forms.Button btnLocalizar;
    
    private System.Windows.Forms.GroupBox grbModelo  ;
    private System.Windows.Forms.GroupBox grbBloco   ;
    private System.Windows.Forms.GroupBox grbColunas ;
    private System.Windows.Forms.GroupBox grbLinhas  ;
    private System.Windows.Forms.GroupBox grbEmbarque;
    private System.Windows.Forms.GroupBox grbPatio   ;

    public frmBloco()
    {
      strCodPatio = "";
      
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloco));
      
      this.grbColunas  = new System.Windows.Forms.GroupBox();
      this.grbLinhas   = new System.Windows.Forms.GroupBox();
      this.grbEmbarque = new System.Windows.Forms.GroupBox();
      this.grbPatio    = new System.Windows.Forms.GroupBox();
      this.grbModelo   = new System.Windows.Forms.GroupBox();
      this.grbBloco    = new System.Windows.Forms.GroupBox();
      
      this.txtColunas = new System.Windows.Forms.TextBox();
      this.txtLinhas  = new System.Windows.Forms.TextBox();
      this.txtBloco   = new System.Windows.Forms.TextBox();
      
      this.cmbEmbarque = new System.Windows.Forms.ComboBox();
      this.cmbModelo   = new System.Windows.Forms.ComboBox();
      this.cmbPatio    = new System.Windows.Forms.ComboBox();
      
      this.btnCancela   = new System.Windows.Forms.Button();
      this.btnOk        = new System.Windows.Forms.Button();
      this.btnDeletar   = new System.Windows.Forms.Button();
      this.btnNovo      = new System.Windows.Forms.Button();
      this.btnLocalizar = new System.Windows.Forms.Button();
      
      this.grbColunas.SuspendLayout() ;
      this.grbLinhas.SuspendLayout()  ;
      this.grbEmbarque.SuspendLayout();
      this.grbPatio.SuspendLayout()   ;
      this.grbModelo.SuspendLayout()  ;
      this.grbBloco.SuspendLayout()   ;
      
      this.SuspendLayout();
 
      this.grbColunas.Controls.Add(this.txtColunas);
      
      this.grbColunas.Location = new System.Drawing.Point(305, 115);
      this.grbColunas.Name     = "grbColunas";
      this.grbColunas.Size     = new System.Drawing.Size(95, 50);
      this.grbColunas.TabIndex = 5;
      this.grbColunas.TabStop  = false;
      this.grbColunas.Text     = " Colunas ";
 
      this.txtColunas.Location = new System.Drawing.Point(7, 20);
      this.txtColunas.Name     = "txtColunas";
      this.txtColunas.ReadOnly = true;
      this.txtColunas.Size     = new System.Drawing.Size(82, 20);
      this.txtColunas.TabIndex = 0;
 
      this.grbLinhas.Controls.Add(this.txtLinhas);
      
      this.grbLinhas.Location = new System.Drawing.Point(207, 115);
      this.grbLinhas.Name     = "grbLinhas";
      this.grbLinhas.Size     = new System.Drawing.Size(95, 50);
      this.grbLinhas.TabIndex = 4;
      this.grbLinhas.TabStop  = false;
      this.grbLinhas.Text     = " Linhas ";
       
      this.txtLinhas.Location = new System.Drawing.Point(7, 20);
      this.txtLinhas.Name     = "txtLinhas";
      this.txtLinhas.ReadOnly = true;
      this.txtLinhas.Size     = new System.Drawing.Size(82, 20);
      this.txtLinhas.TabIndex = 0;
       
      this.grbEmbarque.Controls.Add(this.cmbEmbarque);
      
      this.grbEmbarque.Location = new System.Drawing.Point(12, 65);
      this.grbEmbarque.Name     = "grbEmbarque";
      this.grbEmbarque.Size     = new System.Drawing.Size(193, 50);
      this.grbEmbarque.TabIndex = 1;
      this.grbEmbarque.TabStop  = false;
      this.grbEmbarque.Text     = " Embarque ";
       
      this.cmbEmbarque.FormattingEnabled = true;
      this.cmbEmbarque.Location          = new System.Drawing.Point(7, 19);
      this.cmbEmbarque.Name              = "cmbEmbarque";
      this.cmbEmbarque.Size              = new System.Drawing.Size(180, 21);
      this.cmbEmbarque.TabIndex          = 0;
       
      this.btnCancela.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnCancela.BackgroundImage")));
      this.btnCancela.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCancela.Enabled                 = false;
      this.btnCancela.Location                = new System.Drawing.Point(289, 181);
      this.btnCancela.Name                    = "btnCancela";
      this.btnCancela.Size                    = new System.Drawing.Size(48, 48);
      this.btnCancela.TabIndex                = 38;
      this.btnCancela.UseVisualStyleBackColor = true;
       
      this.btnOk.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
      this.btnOk.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnOk.Enabled                 = false;
      this.btnOk.Location                = new System.Drawing.Point(235, 181);
      this.btnOk.Name                    = "btnOk";
      this.btnOk.Size                    = new System.Drawing.Size(48, 48);
      this.btnOk.TabIndex                = 37;
      this.btnOk.UseVisualStyleBackColor = true;
       
      this.btnDeletar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
      this.btnDeletar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDeletar.Location                = new System.Drawing.Point(181, 181);
      this.btnDeletar.Name                    = "btnDeletar";
      this.btnDeletar.Size                    = new System.Drawing.Size(48, 48);
      this.btnDeletar.TabIndex                = 36;
      this.btnDeletar.UseVisualStyleBackColor = true;
       
      this.btnNovo.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
      this.btnNovo.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNovo.Location                = new System.Drawing.Point(127, 181);
      this.btnNovo.Name                    = "btnNovo";
      this.btnNovo.Size                    = new System.Drawing.Size(48, 48);
      this.btnNovo.TabIndex                = 35;
      this.btnNovo.UseVisualStyleBackColor = true;
       
      this.btnLocalizar.BackgroundImage         = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
      this.btnLocalizar.BackgroundImageLayout   = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLocalizar.Location                = new System.Drawing.Point(73, 181);
      this.btnLocalizar.Name                    = "btnLocalizar";
      this.btnLocalizar.Size                    = new System.Drawing.Size(48, 48);
      this.btnLocalizar.TabIndex                = 34;
      this.btnLocalizar.UseVisualStyleBackColor = true;
       
      this.grbPatio.Controls.Add(this.cmbPatio);
      
      this.grbPatio.Location = new System.Drawing.Point(208, 65);
      this.grbPatio.Name     = "grbPatio";
      this.grbPatio.Size     = new System.Drawing.Size(193, 50);
      this.grbPatio.TabIndex = 2;
      this.grbPatio.TabStop  = false;
      this.grbPatio.Text     = " Patio ";
       
      this.cmbPatio.FormattingEnabled = true;
      this.cmbPatio.Location          = new System.Drawing.Point(7, 19);
      this.cmbPatio.Name              = "cmbPatio";
      this.cmbPatio.Size              = new System.Drawing.Size(180, 21);
      this.cmbPatio.TabIndex          = 0;
       
      this.grbModelo.Controls.Add(this.cmbModelo);
      
      this.grbModelo.Location = new System.Drawing.Point(11, 115);
      this.grbModelo.Name     = "grbModelo";
      this.grbModelo.Size     = new System.Drawing.Size(193, 50);
      this.grbModelo.TabIndex = 3;
      this.grbModelo.TabStop  = false;
      this.grbModelo.Text     = " Modelo Veículo ";
       
      this.cmbModelo.Enabled           = false;
      this.cmbModelo.FormattingEnabled = true;
      this.cmbModelo.Location          = new System.Drawing.Point(7, 19);
      this.cmbModelo.Name              = "cmbModelo";
      this.cmbModelo.Size              = new System.Drawing.Size(180, 21);
      this.cmbModelo.TabIndex          = 0;
       
      this.grbBloco.Controls.Add(this.txtBloco);
      
      this.grbBloco.Location = new System.Drawing.Point(12, 12);
      this.grbBloco.Name     = "grbBloco";
      this.grbBloco.Size     = new System.Drawing.Size(58, 50);
      this.grbBloco.TabIndex = 0;
      this.grbBloco.TabStop  = false;
      this.grbBloco.Text     = " Bloco ";
       
      this.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtBloco.Location        = new System.Drawing.Point(6, 19);
      this.txtBloco.MaxLength       = 1;
      this.txtBloco.Name            = "txtBloco";
      this.txtBloco.Size            = new System.Drawing.Size(44, 20);
      this.txtBloco.TabIndex        = 0;
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize          = new System.Drawing.Size(411, 240);
      
      this.Controls.Add(this.grbBloco)    ;
      this.Controls.Add(this.grbEmbarque) ;
      this.Controls.Add(this.grbModelo)   ;
      this.Controls.Add(this.grbPatio)    ;
      this.Controls.Add(this.grbColunas)  ;
      this.Controls.Add(this.grbLinhas)   ;
      this.Controls.Add(this.btnCancela)  ;
      this.Controls.Add(this.btnOk)       ;
      this.Controls.Add(this.btnDeletar)  ;
      this.Controls.Add(this.btnNovo)     ;
      this.Controls.Add(this.btnLocalizar);
      
      this.Icon          = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name          = "frmBloco"                                                ;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen       ;
      this.Text          = "Manutenção de Blocos"                                    ;
      
      this.grbColunas.ResumeLayout(false) ;
      this.grbColunas.PerformLayout()     ;
      this.grbLinhas.ResumeLayout(false)  ;
      this.grbLinhas.PerformLayout()      ;
      this.grbEmbarque.ResumeLayout(false);
      this.grbEmbarque.PerformLayout()    ;
      this.grbPatio.ResumeLayout(false)   ;
      this.grbModelo.ResumeLayout(false)  ;
      this.grbBloco.ResumeLayout(false)   ;
      this.grbBloco.PerformLayout()       ;
      this.ResumeLayout(false)            ;
      
      this.btnCancela.Click   += new System.EventHandler(this.Cancela)  ;
      this.btnOk.Click        += new System.EventHandler(this.Gravar)   ;
      this.btnDeletar.Click   += new System.EventHandler(this.Deletar)  ;
      this.btnNovo.Click      += new System.EventHandler(this.Novo)     ;
      this.btnLocalizar.Click += new System.EventHandler(this.Localizar);

      this.txtColunas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
      this.txtLinhas.KeyPress  += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);

      this.cmbEmbarque.TextChanged += new System.EventHandler(this.EmbarqueChanged);
      this.cmbPatio.TextChanged    += new System.EventHandler(this.PatioChanged)   ;

      string strEmbarque           = "SELECT CodEmbarque FROM Embarque";
      DataSet dsEmbarque           = new DataSet();
      OleDbDataAdapter dapEmbarque = new OleDbDataAdapter(strEmbarque, myCon);

      dapEmbarque.Fill(dsEmbarque, "Embarques");

      for (int iPos = 0; iPos < dsEmbarque.Tables["Embarques"].Rows.Count; iPos++)
      {
        this.cmbEmbarque.Items.Add(Convert.ToString(dsEmbarque.Tables["Embarques"].Rows[iPos]["CodEmbarque"]));
      }

      string strModelo           = "SELECT Modelo FROM Modelos";
      DataSet dsModelo           = new DataSet();
      OleDbDataAdapter dapModelo = new OleDbDataAdapter(strModelo, this.myCon);

      dapModelo.Fill(dsModelo, "Modelos");

      for (int iPos = 0; iPos < dsModelo.Tables["Modelos"].Rows.Count; iPos++)
      {
        this.cmbModelo.Items.Add(Convert.ToString(dsModelo.Tables["Modelos"].Rows[iPos]["Modelo"]));
      }
    }

    private void Localizar(object sender, EventArgs e)
    {
      string strCodModelo;
      
      string strPesq               = "SELECT * FROM Bloco WHERE Bloco = '" + this.txtBloco.Text + 
                                     "' AND CodEmbarque = " + this.cmbEmbarque.Text +
                                     " AND CodPatio = " + this.strCodPatio;
      DataSet dsPesquisa           = new DataSet();
      OleDbDataAdapter dapPesquisa = new OleDbDataAdapter(strPesq, this.myCon);
      
      dapPesquisa.Fill(dsPesquisa, "Bloco");

      if (dsPesquisa.Tables["Bloco"].Rows.Count > 0)
      {
        this.txtColunas.Text = Convert.ToString(dsPesquisa.Tables["Bloco"].Rows[0]["Colunas"])  ;
        this.txtLinhas.Text  = Convert.ToString(dsPesquisa.Tables["Bloco"].Rows[0]["Linhas"])   ;
        strCodModelo         = Convert.ToString(dsPesquisa.Tables["Bloco"].Rows[0]["CodModelo"]);

        string strModelo           = "SELECT Modelo FROM Modelos WHERE CodModelo = '" + strCodModelo + "'";
        OleDbDataAdapter dapModelo = new OleDbDataAdapter(strModelo, this.myCon);
        DataSet dsModelo           = new DataSet();

        dapModelo.Fill(dsModelo, "Modelos");

        this.cmbModelo.Text = Convert.ToString(dsModelo.Tables["Modelos"].Rows[0]["Modelo"]);
      }
      else
      {
        MessageBox.Show("Bloco não localizado...", "Pesquisa de Blocos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

      this.txtBloco.Clear();
      this.txtColunas.Clear();
      this.txtLinhas.Clear();
      
      this.cmbEmbarque.Text = "";
      this.cmbPatio.Text    = "";
      this.cmbModelo.Text   = "";
      
      this.txtBloco.ReadOnly   = false;
      this.txtColunas.ReadOnly = false;
      this.txtLinhas.ReadOnly  = false;
      
      this.cmbEmbarque.Enabled = true;
      this.cmbModelo.Enabled   = true;
      this.cmbPatio.Enabled    = true;

      this.txtBloco.Focus();
    }

    private void Deletar(object sender, EventArgs e)
    {
      string strExclu       = "DELETE FROM Bloco WHERE CodEmbarque = " + this.cmbEmbarque.Text + " AND " +
                              "CodPatio = " + this.strCodPatio + " AND Bloco = '" + this.txtBloco.Text + "'";
      OleDbCommand cmdExclu = new OleDbCommand(strExclu, this.myCon);

      cmdExclu.Connection.Open();
      cmdExclu.ExecuteNonQuery();
      cmdExclu.Connection.Close();

      MessageBox.Show("Bloco excluído...", "Exclusão de Bloco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.txtBloco.Clear()  ;
      this.txtColunas.Clear();
      this.txtLinhas.Clear() ;
      
      this.cmbEmbarque.Text = "";
      this.cmbPatio.Text    = "";
      this.cmbModelo.Text   = "";

      this.txtBloco.Focus();
    }

    private void Gravar(object sender, EventArgs e)
    {
      string strGuarda      = "INSERT INTO Bloco (CodEmbarque,CodPatio,Bloco,CodModelo,Linhas,Colunas,LinAtu,ColAtu) " +
                              "VALUES (@Embarque,@Patio,@IDBloco,@Modelo,@NuLin,@NuCol,@NuLinAtu,@NuColAtu)";
      OleDbCommand cmdGrava = new OleDbCommand(strGuarda, this.myCon);

      cmdGrava.Parameters.Add(new OleDbParameter("@Embarque", OleDbType.Integer));
      cmdGrava.Parameters.Add(new OleDbParameter("@Patio"   , OleDbType.Integer));
      cmdGrava.Parameters.Add(new OleDbParameter("@IDBloco" , OleDbType.Char, 1));
      cmdGrava.Parameters.Add(new OleDbParameter("@Modelo"  , OleDbType.Char, 6));
      cmdGrava.Parameters.Add(new OleDbParameter("@NuLin"   , OleDbType.Integer));
      cmdGrava.Parameters.Add(new OleDbParameter("@NuCol"   , OleDbType.Integer));
      cmdGrava.Parameters.Add(new OleDbParameter("@NuLinAtu", OleDbType.Integer));
      cmdGrava.Parameters.Add(new OleDbParameter("@NuColAtu", OleDbType.Integer));

      string strCodModelo;
      
      string strModelo           = "SELECT CodModelo FROM Modelos WHERE Modelo = '" + this.cmbModelo.Text + "'";
      DataSet dsModelo           = new DataSet();
      OleDbDataAdapter dapModelo = new OleDbDataAdapter(strModelo, this.myCon);
      
      dapModelo.Fill(dsModelo, "Modelos");

      strCodModelo = Convert.ToString(dsModelo.Tables["Modelos"].Rows[0]["CodModelo"]);

      string strCodPatio;
      
      string strPatio           = "SELECT CodPatio FROM Patio WHERE IDPatio = '" + this.cmbPatio.Text + "'";
      DataSet dsPatio           = new DataSet();
      OleDbDataAdapter dapPatio = new OleDbDataAdapter(strPatio, this.myCon);
      
      dapPatio.Fill(dsPatio, "Patio");

      strCodPatio = Convert.ToString(dsPatio.Tables["Patio"].Rows[0]["CodPatio"]);
      
      cmdGrava.Parameters["@Embarque"].Value = Convert.ToInt32(this.cmbEmbarque.Text);
      cmdGrava.Parameters["@Patio"   ].Value = Convert.ToInt32(strCodPatio)          ;
      cmdGrava.Parameters["@IDBloco" ].Value = Convert.ToChar(this.txtBloco.Text)    ;
      cmdGrava.Parameters["@Modelo"  ].Value = strCodModelo                          ;
      cmdGrava.Parameters["@NuLin"   ].Value = Convert.ToInt32(txtLinhas.Text)       ;
      cmdGrava.Parameters["@NuCol"   ].Value = Convert.ToInt32(txtColunas.Text)      ;
      cmdGrava.Parameters["@NuLinAtu"].Value = 0                                     ;
      cmdGrava.Parameters["@NuColAtu"].Value = 0                                     ;

      cmdGrava.Connection.Open() ;
      cmdGrava.ExecuteNonQuery() ;
      cmdGrava.Connection.Close();

      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.txtColunas.ReadOnly = true;
      this.txtLinhas.ReadOnly  = true;
      
      this.cmbModelo.Enabled = false;
    
      this.txtBloco.Clear()  ;
      this.txtColunas.Clear();
      this.txtLinhas.Clear() ;
      
      this.cmbEmbarque.Text = "";
      this.cmbModelo.Text   = "";
      this.cmbPatio.Text    = "";
    }

    private void Cancela(object sender, EventArgs e)
    {
      this.btnLocalizar.Enabled = true ;
      this.btnNovo.Enabled      = true ;
      this.btnDeletar.Enabled   = true ;
      this.btnOk.Enabled        = false;
      this.btnCancela.Enabled   = false;

      this.cmbEmbarque.Text = "";
      this.cmbModelo.Text   = "";
      this.cmbPatio.Text    = "";

      this.txtBloco.Clear()  ;
      this.txtColunas.Clear();
      this.txtLinhas.Clear() ;

      this.txtColunas.ReadOnly = true;
      this.txtLinhas.ReadOnly = true;

      this.cmbModelo.Enabled = false;

      this.txtBloco.Focus();
    }

    private void EmbarqueChanged(object sender, EventArgs e)
    {
      if(this.cmbEmbarque.Text != "")
      {
        string strCodPorto;

        string strPesqEmba           = "SELECT CodPorto FROM Embarque WHERE CodEmbarque = " + this.cmbEmbarque.Text;
        DataSet dsPesqEmba           = new DataSet();
        OleDbDataAdapter dapPesqEmba = new OleDbDataAdapter(strPesqEmba, this.myCon);
      
        dapPesqEmba.Fill(dsPesqEmba, "Embarque");

        strCodPorto = Convert.ToString(dsPesqEmba.Tables["Embarque"].Rows[0]["CodPorto"]);

        string strPatio           = "SELECT IDPatio FROM Patio WHERE CodPorto = " + strCodPorto ;
        DataSet dsPatio           = new DataSet();
        OleDbDataAdapter dapPatio = new OleDbDataAdapter(strPatio, this.myCon);
      
        dapPatio.Fill(dsPatio, "Patio");

        this.cmbPatio.Items.Clear();
        
        for (int iPos = 0; iPos < dsPatio.Tables["Patio"].Rows.Count; iPos++)
        {
          this.cmbPatio.Items.Add(Convert.ToString(dsPatio.Tables["Patio"].Rows[iPos]["IDPatio"]));
        }

        this.myCon.Close();
      }
    }

    private void PatioChanged(object sender, EventArgs e)
    {
      if(this.cmbPatio.Text != "")
      {
        string strPesqPatio = "SELECT CodPatio FROM Patio WHERE IDPatio = '" + this.cmbPatio.Text + "'";
        DataSet dsPesqPatio = new DataSet();
        OleDbDataAdapter dapPesqPatio = new OleDbDataAdapter(strPesqPatio, this.myCon);

        dapPesqPatio.Fill(dsPesqPatio, "Patio");

        this.strCodPatio = Convert.ToString(dsPesqPatio.Tables["Patio"].Rows[0]["CodPatio"]);

        this.myCon.Close();
      }
    }

    private void Only_Number(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
        e.Handled = true;
    }
  }
}