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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle
{
  public partial class frmPatXML : Form
  {
    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.ComboBox cmbEmbarque;

    private System.Windows.Forms.GroupBox grbEmbarque;
    
    public frmPatXML()
    {
      InitializeComponent();

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarros));

      this.grbEmbarque = new System.Windows.Forms.GroupBox();

      this.cmbEmbarque = new System.Windows.Forms.ComboBox();

      this.grbEmbarque.SuspendLayout();

      this.SuspendLayout();
      this.grbEmbarque.Controls.Add(this.cmbEmbarque);

      this.grbEmbarque.Location = new System.Drawing.Point(12, 15);
      this.grbEmbarque.Name = "grbEmbarque";
      this.grbEmbarque.Size = new System.Drawing.Size(193, 50);
      this.grbEmbarque.TabIndex = 1;
      this.grbEmbarque.TabStop = false;
      this.grbEmbarque.Text = " Embarque ";

      this.cmbEmbarque.FormattingEnabled = true;
      this.cmbEmbarque.Location = new System.Drawing.Point(7, 19);
      this.cmbEmbarque.Name = "cmbEmbarque";
      this.cmbEmbarque.Size = new System.Drawing.Size(180, 21);
      this.cmbEmbarque.TabIndex = 0;

      this.Controls.Add(this.grbEmbarque);

      this.grbEmbarque.ResumeLayout(false);
      this.grbEmbarque.PerformLayout();
      this.ResumeLayout(false);

      string strEmbarque = "SELECT CodEmbarque FROM Embarque";
      DataSet dsEmbarque = new DataSet();
      OleDbDataAdapter dapEmbarque = new OleDbDataAdapter(strEmbarque, this.myCon);

      dapEmbarque.Fill(dsEmbarque, "Embarques");

      for (int iPos = 0; iPos < dsEmbarque.Tables["Embarques"].Rows.Count; iPos++)
      {
        this.cmbEmbarque.Items.Add(Convert.ToString(dsEmbarque.Tables["Embarques"].Rows[iPos]["CodEmbarque"]));
      }

    }

    private void btnCarros_Click(object sender, EventArgs e)
    {
      DataSet dsPatio;

      OleDbDataAdapter dapBloco  ;
      OleDbDataAdapter dapCarros ;
      OleDbDataAdapter dapCores  ;
      OleDbDataAdapter dapModelos;

      //Indicativo de situação, campo Status => P: Patio -  R: Reparo - A: Ausente - V: Retorno (Voltar) - E: Embarcado
      string strBloco   = "SELECT * FROM Bloco WHERE CodEmbarque = " + cmbEmbarque.Text;
      string strCarros  = "SELECT * FROM Carros WHERE CodEmbarque = " + cmbEmbarque.Text;
      string strCores   = "SELECT * FROM Cores";
      string strModelos = "SELECT * FROM Modelos";

      dsPatio = new DataSet();

      dapBloco   = new OleDbDataAdapter(strBloco, this.myCon) ;
      dapCarros  = new OleDbDataAdapter(strCarros, this.myCon);
      dapCores   = new OleDbDataAdapter(strCores,this.myCon)  ;
      dapModelos = new OleDbDataAdapter(strModelos,this.myCon);

      dapBloco.Fill  (dsPatio, "Bloco"  );
      dapCarros.Fill (dsPatio, "Carros" );
      dapCores.Fill  (dsPatio, "Cores"  );
      dapModelos.Fill(dsPatio, "Modelos");
      
      this.myCon.Close();
      
      FileStream fsPatio = new FileStream("patio.xml",FileMode.Create);
      
      XmlTextWriter xtwPatio = new XmlTextWriter(fsPatio, System.Text.Encoding.Unicode);
      
      dsPatio.WriteXml(xtwPatio,XmlWriteMode.WriteSchema);
      
      xtwPatio.Close();
      
      MessageBox.Show("Geração concluída...", "Geração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    }
  }
}