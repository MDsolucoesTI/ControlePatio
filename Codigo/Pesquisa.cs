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
 *   Data da Criação: 05/09/2008                                      *
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
  public partial class frmPesquisa : Form
  {
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private string strCodPatio   ;
    private string strCodEmbarque;
    private string strBloco      ;

    private System.Windows.Forms.GroupBox grbEmbarque;
    private System.Windows.Forms.GroupBox grbInfor;
    private System.Windows.Forms.GroupBox grbColuna;
    private System.Windows.Forms.GroupBox grbChassi;
    private System.Windows.Forms.GroupBox grbLinha;
    private System.Windows.Forms.GroupBox grbDtEmba;
    private System.Windows.Forms.GroupBox grbPatio;
    private System.Windows.Forms.GroupBox grbBloco;
    private System.Windows.Forms.GroupBox grbModelo;

    private System.Windows.Forms.ComboBox cmbEmbarque;
    private System.Windows.Forms.ComboBox cmbPatio;
    private System.Windows.Forms.ComboBox cmbBloco;
    
    private System.Windows.Forms.DateTimePicker dtDtEmba;
    
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.TextBox txtChassiV;
    private System.Windows.Forms.TextBox txtChassiF;
    private System.Windows.Forms.TextBox txtLinha;
    private System.Windows.Forms.TextBox txtColuna;
    private System.Windows.Forms.TextBox txtQtBloco;
    private System.Windows.Forms.TextBox txtQtPatio;
    private System.Windows.Forms.TextBox txtQtTotal;
    
    private System.Windows.Forms.Button btnPesq;
    
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    
    
    public frmPesquisa()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
      
      this.grbEmbarque = new System.Windows.Forms.GroupBox();
      this.grbDtEmba   = new System.Windows.Forms.GroupBox();
      this.grbPatio    = new System.Windows.Forms.GroupBox();
      this.grbBloco    = new System.Windows.Forms.GroupBox();
      this.grbModelo   = new System.Windows.Forms.GroupBox();
      this.grbChassi   = new System.Windows.Forms.GroupBox();
      this.grbLinha    = new System.Windows.Forms.GroupBox();
      this.grbColuna   = new System.Windows.Forms.GroupBox();
      this.grbInfor    = new System.Windows.Forms.GroupBox();
      
      this.cmbEmbarque = new System.Windows.Forms.ComboBox();
      this.cmbPatio    = new System.Windows.Forms.ComboBox();
      this.cmbBloco    = new System.Windows.Forms.ComboBox();

      this.dtDtEmba = new System.Windows.Forms.DateTimePicker();

      this.btnPesq = new System.Windows.Forms.Button();

      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();

      this.txtQtTotal = new System.Windows.Forms.TextBox();
      this.txtQtPatio = new System.Windows.Forms.TextBox();
      this.txtQtBloco = new System.Windows.Forms.TextBox();
      this.txtModelo  = new System.Windows.Forms.TextBox();
      this.txtChassiV = new System.Windows.Forms.TextBox();
      this.txtChassiF = new System.Windows.Forms.TextBox();
      this.txtLinha   = new System.Windows.Forms.TextBox();
      this.txtColuna  = new System.Windows.Forms.TextBox();

      this.grbEmbarque.SuspendLayout();
      this.grbDtEmba.SuspendLayout();
      this.grbPatio.SuspendLayout();
      this.grbBloco.SuspendLayout();
      this.grbModelo.SuspendLayout();
      this.grbChassi.SuspendLayout();
      this.grbLinha.SuspendLayout();
      this.grbColuna.SuspendLayout();
      this.grbInfor.SuspendLayout();
      this.SuspendLayout();
  
      this.grbEmbarque.Controls.Add(this.cmbEmbarque);
      this.grbEmbarque.Location = new System.Drawing.Point(13, 13);
      this.grbEmbarque.Name = "grbEmbarque";
      this.grbEmbarque.Size = new System.Drawing.Size(89, 52);
      this.grbEmbarque.TabIndex = 0;
      this.grbEmbarque.TabStop = false;
      this.grbEmbarque.Text = " Embarque ";
 
      this.cmbEmbarque.FormattingEnabled = true;
      this.cmbEmbarque.Location = new System.Drawing.Point(13, 20);
      this.cmbEmbarque.Name = "cmbEmbarque";
      this.cmbEmbarque.Size = new System.Drawing.Size(63, 21);
      this.cmbEmbarque.TabIndex = 0;
      this.cmbEmbarque.SelectedIndexChanged += new System.EventHandler(this.cmbEmbarque_SelectedIndexChanged);
 
      this.grbDtEmba.Controls.Add(this.dtDtEmba);
      this.grbDtEmba.Location = new System.Drawing.Point(108, 13);
      this.grbDtEmba.Name = "grbDtEmba";
      this.grbDtEmba.Size = new System.Drawing.Size(120, 52);
      this.grbDtEmba.TabIndex = 1;
      this.grbDtEmba.TabStop = false;
      this.grbDtEmba.Text = " Data ";
 
      this.dtDtEmba.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtDtEmba.Location = new System.Drawing.Point(6, 19);
      this.dtDtEmba.Name = "dtDtEmba";
      this.dtDtEmba.Size = new System.Drawing.Size(106, 20);
      this.dtDtEmba.TabIndex = 0;
 
      this.grbPatio.Controls.Add(this.cmbPatio);
      this.grbPatio.Location = new System.Drawing.Point(234, 13);
      this.grbPatio.Name = "grbPatio";
      this.grbPatio.Size = new System.Drawing.Size(76, 52);
      this.grbPatio.TabIndex = 2;
      this.grbPatio.TabStop = false;
      this.grbPatio.Text = " Patio ";
 
      this.cmbPatio.FormattingEnabled = true;
      this.cmbPatio.Location = new System.Drawing.Point(14, 22);
      this.cmbPatio.Name = "cmbPatio";
      this.cmbPatio.Size = new System.Drawing.Size(50, 21);
      this.cmbPatio.TabIndex = 0;
      this.cmbPatio.SelectedIndexChanged += new System.EventHandler(this.cmbPatio_SelectedIndexChanged);
  
      this.grbBloco.Controls.Add(this.cmbBloco);
      this.grbBloco.Location = new System.Drawing.Point(12, 71);
      this.grbBloco.Name = "grbBloco";
      this.grbBloco.Size = new System.Drawing.Size(90, 52);
      this.grbBloco.TabIndex = 3;
      this.grbBloco.TabStop = false;
      this.grbBloco.Text = " Bloco ";
  
      this.cmbBloco.FormattingEnabled = true;
      this.cmbBloco.Location = new System.Drawing.Point(14, 22);
      this.cmbBloco.Name = "cmbBloco";
      this.cmbBloco.Size = new System.Drawing.Size(54, 21);
      this.cmbBloco.TabIndex = 0;
      this.cmbBloco.SelectedIndexChanged += new System.EventHandler(this.cmbBloco_SelectedIndexChanged);
 
      this.grbModelo.Controls.Add(this.txtModelo);
      this.grbModelo.Location = new System.Drawing.Point(108, 71);
      this.grbModelo.Name = "grbModelo";
      this.grbModelo.Size = new System.Drawing.Size(120, 52);
      this.grbModelo.TabIndex = 41;
      this.grbModelo.TabStop = false;
      this.grbModelo.Text = " Modelo ";
  
      this.txtModelo.Location = new System.Drawing.Point(14, 20);
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(98, 20);
      this.txtModelo.TabIndex = 0;
 
      this.grbChassi.Controls.Add(this.txtChassiV);
      this.grbChassi.Controls.Add(this.txtChassiF);
      this.grbChassi.Location = new System.Drawing.Point(12, 129);
      this.grbChassi.Name = "grbChassi";
      this.grbChassi.Size = new System.Drawing.Size(216, 52);
      this.grbChassi.TabIndex = 4;
      this.grbChassi.TabStop = false;
      this.grbChassi.Text = " Chassi ";
 
      this.txtChassiV.Location = new System.Drawing.Point(106, 20);
      this.txtChassiV.MaxLength = 6;
      this.txtChassiV.Name = "txtChassiV";
      this.txtChassiV.Size = new System.Drawing.Size(58, 20);
      this.txtChassiV.TabIndex = 6;
  
      this.txtChassiF.Location = new System.Drawing.Point(13, 20);
      this.txtChassiF.MaxLength = 11;
      this.txtChassiF.Name = "txtChassiF";
      this.txtChassiF.Size = new System.Drawing.Size(90, 20);
      this.txtChassiF.TabIndex = 5;
 
      this.grbLinha.Controls.Add(this.txtLinha);
      this.grbLinha.Location = new System.Drawing.Point(12, 188);
      this.grbLinha.Name = "grbLinha";
      this.grbLinha.Size = new System.Drawing.Size(59, 52);
      this.grbLinha.TabIndex = 42;
      this.grbLinha.TabStop = false;
      this.grbLinha.Text = " Linha ";
  
      this.txtLinha.Location = new System.Drawing.Point(14, 20);
      this.txtLinha.Name = "txtLinha";
      this.txtLinha.Size = new System.Drawing.Size(33, 20);
      this.txtLinha.TabIndex = 0;
 
      this.grbColuna.Controls.Add(this.txtColuna);
      this.grbColuna.Location = new System.Drawing.Point(78, 188);
      this.grbColuna.Name = "grbColuna";
      this.grbColuna.Size = new System.Drawing.Size(59, 52);
      this.grbColuna.TabIndex = 43;
      this.grbColuna.TabStop = false;
      this.grbColuna.Text = " Coluna ";
  
      this.txtColuna.Location = new System.Drawing.Point(11, 20);
      this.txtColuna.Name = "txtColuna";
      this.txtColuna.Size = new System.Drawing.Size(33, 20);
      this.txtColuna.TabIndex = 1;
 
      this.btnPesq.Image = global::Controle.Properties.Resources.CarrosPes;
      this.btnPesq.Location = new System.Drawing.Point(144, 188);
      this.btnPesq.Name = "btnPesq";
      this.btnPesq.Size = new System.Drawing.Size(84, 52);
      this.btnPesq.TabIndex = 44;
      this.btnPesq.UseVisualStyleBackColor = true;
      this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
  
      this.grbInfor.Controls.Add(this.txtQtBloco);
      this.grbInfor.Controls.Add(this.txtQtPatio);
      this.grbInfor.Controls.Add(this.txtQtTotal);
      this.grbInfor.Controls.Add(this.label3);
      this.grbInfor.Controls.Add(this.label2);
      this.grbInfor.Controls.Add(this.label1);
      this.grbInfor.Location = new System.Drawing.Point(234, 71);
      this.grbInfor.Name = "grbInfor";
      this.grbInfor.Size = new System.Drawing.Size(182, 169);
      this.grbInfor.TabIndex = 45;
      this.grbInfor.TabStop = false;
      this.grbInfor.Text = " Quantidades ";
 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label1.Location = new System.Drawing.Point(9, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Total :";
 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label2.Location = new System.Drawing.Point(9, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Patio :";
 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label3.Location = new System.Drawing.Point(9, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 15);
      this.label3.TabIndex = 46;
   
      this.txtQtTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtQtTotal.Location = new System.Drawing.Point(56, 24);
      this.txtQtTotal.Name = "txtQtTotal";
      this.txtQtTotal.Size = new System.Drawing.Size(74, 25);
      this.txtQtTotal.TabIndex = 47;
      this.txtQtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
  
      this.txtQtPatio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQtPatio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtQtPatio.Location = new System.Drawing.Point(57, 63);
      this.txtQtPatio.Name = "txtQtPatio";
      this.txtQtPatio.Size = new System.Drawing.Size(74, 25);
      this.txtQtPatio.TabIndex = 48;
      this.txtQtPatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
 
      this.txtQtBloco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQtBloco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtQtBloco.Location = new System.Drawing.Point(56, 104);
      this.txtQtBloco.Name = "txtQtBloco";
      this.txtQtBloco.Size = new System.Drawing.Size(74, 25);
      this.txtQtBloco.TabIndex = 49;
      this.txtQtBloco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(432, 254);

      this.Controls.Add(this.grbInfor);
      this.Controls.Add(this.btnPesq);
      this.Controls.Add(this.grbColuna);
      this.Controls.Add(this.grbLinha);
      this.Controls.Add(this.grbChassi);
      this.Controls.Add(this.grbModelo);
      this.Controls.Add(this.grbBloco);
      this.Controls.Add(this.grbPatio);
      this.Controls.Add(this.grbDtEmba);
      this.Controls.Add(this.grbEmbarque);

      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmPesquisa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pesquisa de Veículos";

      this.grbEmbarque.ResumeLayout(false);
      this.grbDtEmba.ResumeLayout(false);
      this.grbPatio.ResumeLayout(false);
      this.grbBloco.ResumeLayout(false);
      this.grbModelo.ResumeLayout(false);
      this.grbModelo.PerformLayout();
      this.grbChassi.ResumeLayout(false);
      this.grbChassi.PerformLayout();
      this.grbLinha.ResumeLayout(false);
      this.grbLinha.PerformLayout();
      this.grbColuna.ResumeLayout(false);
      this.grbColuna.PerformLayout();
      this.grbInfor.ResumeLayout(false);
      this.grbInfor.PerformLayout();
      this.ResumeLayout(false);
      
      InitializeComponent();

      string strEmbarque = "SELECT CodEmbarque FROM Embarque";
      DataSet dsEmbarque = new DataSet();
      OleDbDataAdapter dapEmbarque = new OleDbDataAdapter(strEmbarque, myCon);

      dapEmbarque.Fill(dsEmbarque, "Embarque");

      for (int iPos = 0; iPos < dsEmbarque.Tables["Embarque"].Rows.Count; iPos++)
      {
        this.cmbEmbarque.Items.Add(Convert.ToString(dsEmbarque.Tables["Embarque"].Rows[iPos]["CodEmbarque"]));
      }

    }

    private void cmbEmbarque_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmbEmbarque.Text != "")
      {
        string strCodPorto;

        string strPesqEmba = "SELECT * FROM Embarque WHERE CodEmbarque = " + this.cmbEmbarque.Text;
        DataSet dsPesqEmba = new DataSet();

        OleDbDataAdapter dapPesqEmba = new OleDbDataAdapter(strPesqEmba, this.myCon);

        dapPesqEmba.Fill(dsPesqEmba, "Embarque");

        strCodPorto = Convert.ToString(dsPesqEmba.Tables["Embarque"].Rows[0]["CodPorto"]);

        dtDtEmba.Value = Convert.ToDateTime(dsPesqEmba.Tables["Embarque"].Rows[0]["DtEmbarque"]);

        this.strCodEmbarque = Convert.ToString(dsPesqEmba.Tables["Embarque"].Rows[0]["CodEmbarque"]);

        string strPesqCar = "SELECT * FROM Carros WHERE CodEmbarque = " + this.cmbEmbarque.Text;
        
        OleDbDataAdapter dapCarros = new OleDbDataAdapter(strPesqCar, this.myCon);

        dapCarros.Fill(dsPesqEmba, "Carros");

        txtQtTotal.Text = Convert.ToString(dsPesqEmba.Tables["Carros"].Rows.Count);
        txtQtPatio.Text = "";
        txtQtBloco.Text = "";

        string strPatio = "SELECT IDPatio FROM Patio WHERE CodPorto = " + strCodPorto;

        OleDbDataAdapter dapPatio = new OleDbDataAdapter(strPatio, this.myCon);

        dapPatio.Fill(dsPesqEmba, "Patio");

        this.cmbPatio.Items.Clear();

        for (int iPos = 0; iPos < dsPesqEmba.Tables["Patio"].Rows.Count; iPos++)
        {
          this.cmbPatio.Items.Add(Convert.ToString(dsPesqEmba.Tables["Patio"].Rows[iPos]["IDPatio"]));
        }

        this.myCon.Close();

        cmbPatio.Focus();
      }
    }

    private void cmbPatio_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmbPatio.Text != "")
      {
        string strPesqPatio = "SELECT CodPatio FROM Patio WHERE IDPatio = '" + this.cmbPatio.Text + "'";
        DataSet dsPesqPatio = new DataSet();

        OleDbDataAdapter dapPesqPatio = new OleDbDataAdapter(strPesqPatio, this.myCon);

        dapPesqPatio.Fill(dsPesqPatio, "Patio");

        this.strCodPatio = Convert.ToString(dsPesqPatio.Tables["Patio"].Rows[0]["CodPatio"]);

        string strPesqCar = "SELECT * FROM Carros WHERE CodEmbarque = " + this.cmbEmbarque.Text + " AND CodPatio = " + this.strCodPatio;

        OleDbDataAdapter dapCarros = new OleDbDataAdapter(strPesqCar, this.myCon);

        dapCarros.Fill(dsPesqPatio, "Carros");

        txtQtPatio.Text = Convert.ToString(dsPesqPatio.Tables["Carros"].Rows.Count);
        txtQtBloco.Text = "";

        string strBloco = "SELECT Bloco FROM Bloco WHERE CodEmbarque = " + this.strCodEmbarque + " AND CodPatio = " + this.strCodPatio;

        OleDbDataAdapter dapBloco = new OleDbDataAdapter(strBloco, this.myCon);

        dapBloco.Fill(dsPesqPatio, "Bloco");

        this.cmbBloco.Items.Clear();

        for (int iPos = 0; iPos < dsPesqPatio.Tables["Bloco"].Rows.Count; iPos++)
        {
          this.cmbBloco.Items.Add(Convert.ToString(dsPesqPatio.Tables["Bloco"].Rows[iPos]["Bloco"]));
        }

        this.myCon.Close();

        cmbBloco.Focus();
      }
    }

    private void cmbBloco_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmbBloco.Text != "")
      {
        string strPesqBloco = "SELECT * FROM Bloco WHERE Bloco = '" + this.cmbBloco.Text + "' AND CodEmbarque = " + strCodEmbarque + " AND CodPatio = " + strCodPatio;
        DataSet dsPesBlo = new DataSet();

        OleDbDataAdapter dapPesBlo = new OleDbDataAdapter(strPesqBloco, this.myCon);

        dapPesBlo.Fill(dsPesBlo, "Bloco");

        strBloco = Convert.ToString(dsPesBlo.Tables["Bloco"].Rows[0]["Bloco"]);

        txtModelo.Text = Convert.ToString(dsPesBlo.Tables["Bloco"].Rows[0]["CodModelo"]);

        string strPesqCar = "SELECT * FROM Carros WHERE CodEmbarque = " + this.cmbEmbarque.Text + " AND CodPatio = " + this.strCodPatio + " AND Bloco = '" + strBloco + "'";

        OleDbDataAdapter dapCarros = new OleDbDataAdapter(strPesqCar, this.myCon);

        dapCarros.Fill(dsPesBlo, "Carros");

        txtQtBloco.Text = Convert.ToString(dsPesBlo.Tables["Carros"].Rows.Count);

        this.myCon.Close();

        txtChassiF.Focus();
      }
    }

    private void btnPesq_Click(object sender, EventArgs e)
    {
      DataSet dsPesCar = new DataSet();

      string strPesqCar = "SELECT * FROM Carros WHERE Chassi = '" + this.txtChassiF.Text.Trim() + txtChassiV.Text.Trim() + "'";

      OleDbDataAdapter dapCarros = new OleDbDataAdapter(strPesqCar, this.myCon);

      dapCarros.Fill(dsPesCar, "Carros");

      if (dsPesCar.Tables["Carros"].Rows.Count > 0)
      {
        cmbEmbarque.Text = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["CodEmbarque"]);
        cmbPatio.Text    = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["CodPatio"]);
        cmbBloco.Text    = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["Bloco"]);
        txtModelo.Text   = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["CodModelo"]);
        txtLinha.Text    = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["Linha"]);
        txtColuna.Text   = Convert.ToString(dsPesCar.Tables["Carros"].Rows[0]["Coluna"]);
      }
      else
        MessageBox.Show("Veículo não encontrado", "Pesquisa de Veículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      this.myCon.Close();

      txtChassiF.Focus();

    }
  }
}
