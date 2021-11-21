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
using System.Data;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patio
{
  public partial class frmRegistro : Form
  {
    DataSet dsLista;
    
    string sCodModelo;
    
    int iLinha  ;
    int iColuna ;
    int iULinha ;
    int iUColuna;
    int iQuant;

    bool bMuda;

    public frmRegistro()
    {
      InitializeComponent();
      
      iLinha   = 0;
      iColuna  = 0;
      iULinha  = 0;
      iUColuna = 0;
      
      sCodModelo = "";

      bMuda = true;

      lblQuant.Text = "0";
      
      dsLista = new DataSet();
    }

    private void btnVer_Click(object sender, EventArgs e)
    {
      bool bFlag = true;

      for(int iPos = 0; iPos < dsLista.Tables["Carros"].Rows.Count; iPos++)
      {
        if (ckLeitor.Checked)
        {
          if (txtChassi.Text == Convert.ToString(dsLista.Tables["Carros"].Rows[iPos]["Chassi"]))
          {
            MessageBox.Show("Veículo pertence ao embarque", "Verificação de Embarque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            txtModelo.Text  = Convert.ToString (dsLista.Tables["Carros"].Rows[iPos]["CodModelo"]);
            cmbBloco.Text   = Convert.ToString (dsLista.Tables["Carros"].Rows[iPos]["Bloco"]    );
            txtLinha.Value  = Convert.ToDecimal(dsLista.Tables["Carros"].Rows[iPos]["Linha"]    );
            txtColuna.Value = Convert.ToDecimal(dsLista.Tables["Carros"].Rows[iPos]["Coluna"]   );

            bFlag = false;

            break;
          }
        }
        else
        {
          if (txtChassiV.Text == Convert.ToString(dsLista.Tables["Carros"].Rows[iPos]["Chassi"]).Substring(11))
          {
            MessageBox.Show("Veículo pertence ao embarque", "Verificação de Embarque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            txtModelo.Text  = Convert.ToString (dsLista.Tables["Carros"].Rows[iPos]["CodModelo"]);
            cmbBloco.Text   = Convert.ToString (dsLista.Tables["Carros"].Rows[iPos]["Bloco"]    );
            txtLinha.Value  = Convert.ToDecimal(dsLista.Tables["Carros"].Rows[iPos]["Linha"]    );
            txtColuna.Value = Convert.ToDecimal(dsLista.Tables["Carros"].Rows[iPos]["Coluna"]   );

            bFlag = false;

            break;
          }
        }
      }

      if (bFlag)
      {
        MessageBox.Show("Veículo não pertence ao embarque", "Verificação de Embarque", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      int iCodEmbarque = 0;
      int iCodPatio    = 0;

      char cBloco;

      DataRow drCarros;

      string sChassi;

      iLinha  = Convert.ToInt32(txtLinha.Value) ;
      iColuna = Convert.ToInt32(txtColuna.Value);

      for (int iPos = 0; iPos < dsLista.Tables["Bloco"].Rows.Count; iPos++)
      {
        if (cmbBloco.Text == Convert.ToString(dsLista.Tables["Bloco"].Rows[iPos]["Bloco"]))
        {
          dsLista.Tables["Bloco"].Rows[iPos]["LinAtu"] = iLinha;
          dsLista.Tables["Bloco"].Rows[iPos]["ColAtu"] = iColuna;

          iCodEmbarque = Convert.ToInt32(dsLista.Tables["Bloco"].Rows[iPos]["CodEmbarque"]);
          iCodPatio    = Convert.ToInt32(dsLista.Tables["Bloco"].Rows[iPos]["CodPatio"   ]);

          break;  
        }
      }

      cBloco = Convert.ToChar(cmbBloco.Text);

      if (ckLeitor.Checked)
        sChassi = txtChassi.Text;
      else
        sChassi = txtChassiF.Text.TrimEnd() + txtChassiV.Text;

      bool bInclu = true;

      for (int iPos = 0; iPos < dsLista.Tables["Carros"].Rows.Count; iPos++)
      {
        if (sChassi == Convert.ToString(dsLista.Tables["Carros"].Rows[iPos]["Chassi"]))
        {
          dsLista.Tables["Carros"].Rows[iPos]["CodModelo"] = txtModelo.Text ;
          dsLista.Tables["Carros"].Rows[iPos]["Bloco"    ] = cmbBloco.Text  ;
          dsLista.Tables["Carros"].Rows[iPos]["Linha"    ] = txtLinha.Value ;
          dsLista.Tables["Carros"].Rows[iPos]["Coluna"   ] = txtColuna.Value;
          dsLista.Tables["Carros"].Rows[iPos]["Status"   ] = 'P'            ;

          bInclu = false;
        }
      }

      if (bInclu)
      {
        drCarros = dsLista.Tables["Carros"].NewRow();

        drCarros["Chassi"     ] = sChassi       ;
        drCarros["CodModelo"  ] = txtModelo.Text;
      //drCarros["Cor"        ] = cmbCor.Text   ;
        drCarros["CodEmbarque"] = iCodEmbarque  ;
        drCarros["CodPatio"   ] = iCodPatio     ;
        drCarros["Bloco"      ] = cBloco        ;
        drCarros["Linha"      ] = iLinha        ;
        drCarros["Coluna"     ] = iColuna       ;
        drCarros["Status"     ] = 'P'           ;

        dsLista.Tables["Carros"].Rows.Add(drCarros);
      }

      bMuda = true;

      iQuant += 1;

      lblQuant.Text = Convert.ToString(iQuant);

      if (pnlLeitor.Visible)
      {
        txtChassi.Text = "";
        txtChassi.Focus();
      }
      else
      {
        txtChassiV.Text = "";
        txtChassiV.Focus();
      }
    }

    private void btnReparo_Click(object sender, EventArgs e)
    {
      DataRow drCarros;

      string sChassi;

      if (ckLeitor.Checked)
        sChassi = txtChassi.Text;
      else
        sChassi = txtChassiF.Text.TrimEnd() + txtChassiV.Text;

      bool bInclu = true;

      for (int iPos = 0; iPos < dsLista.Tables["Carros"].Rows.Count; iPos++)
      {
        if (sChassi == Convert.ToString(dsLista.Tables["Carros"].Rows[iPos]["Chassi"]))
        {
          dsLista.Tables["Carros"].Rows[iPos]["CodModelo"] = txtModelo.Text ;
          dsLista.Tables["Carros"].Rows[iPos]["Status"   ] = 'R'            ;

          bInclu = false;
        }
      }

      if (bInclu)
      {
        drCarros = dsLista.Tables["Carros"].NewRow();

        drCarros["Chassi"   ] = sChassi       ;
        drCarros["CodModelo"] = txtModelo.Text;
      //drCarros["Cor"      ] = cmbCor.Text   ;
        drCarros["Status"   ] = 'R'           ;

        dsLista.Tables["Carros"].Rows.Add(drCarros);
      }

      bMuda = true;

      if (pnlLeitor.Visible)
      {
        txtChassi.Text = "";
        txtChassi.Focus();
      }
      else
      {
        txtChassiV.Text = "";
        txtChassiV.Focus();
      }
    }

    private void btnCancela_Click(object sender, EventArgs e)
    {
      DataRow drCarros;

      string sChassi;

      if (ckLeitor.Checked)
        sChassi = txtChassi.Text;
      else
        sChassi = txtChassiF.Text.TrimEnd() + txtChassiV.Text;

      bool bInclu = true;

      for (int iPos = 0; iPos < dsLista.Tables["Carros"].Rows.Count; iPos++)
      {
        if (sChassi == Convert.ToString(dsLista.Tables["Carros"].Rows[iPos]["Chassi"]))
        {
          dsLista.Tables["Carros"].Rows[iPos]["CodModelo"] = txtModelo.Text ;
          dsLista.Tables["Carros"].Rows[iPos]["Status"   ] = 'V'            ;

          bInclu = false;
        }
      }

      if (bInclu)
      {
        drCarros = dsLista.Tables["Carros"].NewRow();

        drCarros["Chassi"   ] = sChassi       ;
        drCarros["CodModelo"] = txtModelo.Text;
      //drCarros["Cor"      ] = cmbCor.Text   ;
        drCarros["Status"   ] = 'V'           ;

        dsLista.Tables["Carros"].Rows.Add(drCarros);
      }

      bMuda = true;

      if (pnlLeitor.Visible)
      {
        txtChassi.Text = "";
        txtChassi.Focus();
      }
      else
      {
        txtChassiV.Text = "";
        txtChassiV.Focus();
      }
    }

    private void btnIn_Click(object sender, EventArgs e)
    {
      FileStream fsLista = new FileStream("patio.xml", System.IO.FileMode.Open);

      XmlTextReader xtrLista = new XmlTextReader(fsLista);

      dsLista.ReadXml(xtrLista, XmlReadMode.ReadSchema);

      xtrLista.Close();

      cmbCor.Items.Clear();

      for (int iPos = 0; iPos < dsLista.Tables["Cores"].Rows.Count; iPos++)
      {
        cmbCor.Items.Add(Convert.ToString(dsLista.Tables["Cores"].Rows[iPos]["NomeCor"]));
      }

      cmbBloco.Items.Clear();

      for (int iPos = 0; iPos < dsLista.Tables["Bloco"].Rows.Count; iPos++)
      {
        cmbBloco.Items.Add(Convert.ToString(dsLista.Tables["Bloco"].Rows[iPos]["Bloco"]));
      }

      iQuant = 0;

      lblQuant.Text = Convert.ToString(iQuant);
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
      FileStream fsPatio = new FileStream("apatio.xml", FileMode.Create);

      XmlTextWriter xtwPatio = new XmlTextWriter(fsPatio, System.Text.Encoding.Unicode);

      dsLista.WriteXml(xtwPatio, XmlWriteMode.WriteSchema);

      xtwPatio.Close();
    }

    private void cmbBloco_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int iPos = 0; iPos < dsLista.Tables["Bloco"].Rows.Count; iPos++)
      { 
        if (cmbBloco.Text == Convert.ToString(dsLista.Tables["Bloco"].Rows[iPos]["Bloco"]))
        {
          sCodModelo = Convert.ToString(dsLista.Tables["Bloco"].Rows[iPos]["CodModelo"]);
          iLinha     = Convert.ToInt32 (dsLista.Tables["Bloco"].Rows[iPos]["LinAtu"]   );
          iColuna    = Convert.ToInt32 (dsLista.Tables["Bloco"].Rows[iPos]["ColAtu"]   );
          iUColuna   = Convert.ToInt32 (dsLista.Tables["Bloco"].Rows[iPos]["Linhas"]   );
          iULinha    = Convert.ToInt32 (dsLista.Tables["Bloco"].Rows[iPos]["Colunas"]  );

          txtModelo.Text = sCodModelo;

          break;
        }
      }

      for (int iPos = 0; iPos < dsLista.Tables["Modelos"].Rows.Count; iPos++)
      {
        if (sCodModelo == Convert.ToString(dsLista.Tables["Modelos"].Rows[iPos]["CodModelo"]))
        {
          txtPortas.Text = Convert.ToString(dsLista.Tables["Modelos"].Rows[iPos]["Portas"]);
        }
      }
    }

    private void txtLinha_ValueChanged(object sender, EventArgs e)
    {
      if (txtLinha.Value != iLinha)
      {
        if (txtLinha.Value > iULinha)
        {
          MessageBox.Show("Linha invalida");
          txtLinha.Focus();
        }
      }
    }

    private void txtColuna_ValueChanged(object sender, EventArgs e)
    {
      if (txtColuna.Value != iColuna)
      {
        if (txtColuna.Value > iUColuna)
        {
          MessageBox.Show("Coluna invalida");
          txtColuna.Focus();
        }
      }
    }

    private void ckLeitor_CheckStateChanged(object sender, EventArgs e)
    {
      if (ckLeitor.Checked)
      {
        pnlLeitor.Visible = true ;
        pnlTecla.Visible  = false;
      }
      else
      {
        pnlLeitor.Visible = false;
        pnlTecla.Visible  = true ;
      }
    }

    private void txtChassi_TextChanged(object sender, EventArgs e)
    {
      if (((TextBox)sender).Text.Length > 0)
      {
        if (bMuda)
        {
          if (iLinha == 0)
            txtLinha.Value = 1;

          if ((iColuna + 1) > iUColuna)
          {
            if ((iLinha + 1) > iULinha)
              MessageBox.Show("Linha ultrapassou Limite");
            else
              txtLinha.Value = iLinha + 1;
            txtColuna.Value = 1;
          }
          else
            txtColuna.Value = iColuna + 1;
        }
        bMuda = false;
      }
    }

    private void frmRegistro_Deactivate(object sender, EventArgs e)
    {
      FileStream fsPatio = new FileStream("patio.xml", FileMode.Create);

      XmlTextWriter xtwPatio = new XmlTextWriter(fsPatio, System.Text.Encoding.Unicode);

      dsLista.WriteXml(xtwPatio, XmlWriteMode.WriteSchema);

      xtwPatio.Close();
    }
  }
}