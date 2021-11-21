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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Embarque
{
  public partial class frmRegistro : Form
  {
    DataSet dsLista;

    string sCodModelo;

    int iLinha;
    int iColuna;

    public frmRegistro()
    {
      InitializeComponent();

      iLinha = 0;
      iColuna = 0;

      sCodModelo = "";

      dsLista = new DataSet();
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
      FileStream fsPatio = new FileStream("spatio.xml", FileMode.Create);

      XmlTextWriter xtwPatio = new XmlTextWriter(fsPatio, System.Text.Encoding.Unicode);

      dsLista.WriteXml(xtwPatio, XmlWriteMode.WriteSchema);

      xtwPatio.Close();
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

      cmbModel.Items.Clear();

      for (int iPos = 0; iPos < dsLista.Tables["Modelos"].Rows.Count; iPos++)
      {
        cmbModel.Items.Add(Convert.ToString(dsLista.Tables["Modelos"].Rows[iPos]["CodModelo"]));
      }
    }

    private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
    {
      sCodModelo = cmbModel.Text;
      
      for (int iPos = 0; iPos < dsLista.Tables["Modelos"].Rows.Count; iPos++)
      {
        if (sCodModelo == Convert.ToString(dsLista.Tables["Modelos"].Rows[iPos]["CodModelo"]))
        {
          txtPortas.Text = Convert.ToString(dsLista.Tables["Modelos"].Rows[iPos]["Portas"]);
        }
      }
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      int iCodEmbarque = 0;

      DataRow drCarros;

      iCodEmbarque = Convert.ToInt32(dsLista.Tables["Bloco"].Rows[0]["CodEmbarque"]);
      iLinha       = Convert.ToInt32(txtDeck.Value);
      iColuna      = Convert.ToInt32(txtPorao.Value);

      drCarros = dsLista.Tables["Carros"].NewRow();

      drCarros["Chassi"     ] = txtChassi.Text;
      drCarros["CodModelo"  ] = cmbModel.Text ;
    //drCarros["Cor"        ] = cmbCor.Text   ;
      drCarros["CodEmbarque"] = iCodEmbarque  ;
      drCarros["Linha"      ] = iColuna       ;
      drCarros["Coluna"     ] = iLinha        ;
      drCarros["Status"     ] = 'P'           ;

      dsLista.Tables["Carros"].Rows.Add(drCarros);     
    }

  }
}