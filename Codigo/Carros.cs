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
using System.IO;
using System.Data.OleDb;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle
{
  public partial class frmCarros : Form
  {

    OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Patio.MDB");

    private System.Windows.Forms.ComboBox cmbEmbarque;

    private System.Windows.Forms.GroupBox grbEmbarque;

    public frmCarros()
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
      this.grbEmbarque.PerformLayout()    ;
      this.ResumeLayout(false)            ;

      string strEmbarque           = "SELECT CodEmbarque FROM Embarque";
      DataSet dsEmbarque           = new DataSet();
      OleDbDataAdapter dapEmbarque = new OleDbDataAdapter(strEmbarque, this.myCon);

      dapEmbarque.Fill(dsEmbarque, "Embarques");

      for (int iPos = 0; iPos < dsEmbarque.Tables["Embarques"].Rows.Count; iPos++)
      {
        this.cmbEmbarque.Items.Add(Convert.ToString(dsEmbarque.Tables["Embarques"].Rows[iPos]["CodEmbarque"]));
      }

    }

    private void btnCarros_Click(object sender, EventArgs e)
    {
      DataSet dsImportar;
      DataSet dsFonte;

      DataRow drCarros;

      OleDbDataAdapter dapBloco;
      OleDbDataAdapter dapCarros;
      OleDbDataAdapter dapCores;
      OleDbDataAdapter dapModelos;

      //Indicativo de situação, campo Status => P: Patio -  R: Reparo - A: Ausente - V: Retorno (Voltar) - E: Embarcado
      string strBloco  = "SELECT * FROM Bloco WHERE CodEmbarque = " + cmbEmbarque.Text;
      string strCarro  = "SELECT * FROM Carros WHERE CodEmbarque = " + cmbEmbarque.Text;
      string strModelo = "SELECT * FROM Modelos";
      string strCores  = "SELECT * FROM Cores";

      string sChassiFon;
      string sChassiImp;

      int iPatioFon;
      int iPatioImp;

      char cBlocoFon;
      char cBlocoImp;

      bool bFlag;
      
      dsImportar = new DataSet();
      dsFonte    = new DataSet();

      FileStream fsLista = new FileStream("apatio.xml", System.IO.FileMode.Open);

      XmlTextReader xtrLista = new XmlTextReader(fsLista);

      dsFonte.ReadXml(xtrLista, XmlReadMode.ReadSchema);

      xtrLista.Close();
      
      dapBloco   = new OleDbDataAdapter(strBloco,this.myCon);
      dapCarros  = new OleDbDataAdapter(strCarro, this.myCon);
      dapCores   = new OleDbDataAdapter(strCores, this.myCon);
      dapModelos = new OleDbDataAdapter(strModelo, this.myCon);

      dapBloco.Fill  (dsImportar, "Bloco"  );
      dapCarros.Fill (dsImportar, "Carros" );
      dapCores.Fill  (dsImportar, "Cores"  );
      dapModelos.Fill(dsImportar, "Modelos");

      prbImportar.Maximum = dsFonte.Tables["Carros"].Rows.Count + dsFonte.Tables["Bloco"].Rows.Count;
      prbImportar.Value   = 0;

      for (int iPos = 0; iPos < dsFonte.Tables["Carros"].Rows.Count; iPos++)
      {
        sChassiFon = Convert.ToString(dsFonte.Tables["Carros"].Rows[iPos]["Chassi"]);

        bFlag = true;

        for (int iVer = 0; iVer < dsImportar.Tables["Carros"].Rows.Count; iVer++)
        {
          sChassiImp = Convert.ToString(dsImportar.Tables["Carros"].Rows[iVer]["Chassi"]);
          if ( sChassiImp == sChassiFon )
          {
            bFlag = false;

            dsImportar.Tables["Carros"].Rows[iVer]["CodPatio"] = dsFonte.Tables["Carros"].Rows[iPos]["CodPatio"];
            dsImportar.Tables["Carros"].Rows[iVer]["Bloco"   ] = dsFonte.Tables["Carros"].Rows[iPos]["Bloco"   ];
            dsImportar.Tables["Carros"].Rows[iVer]["Linha"   ] = dsFonte.Tables["Carros"].Rows[iPos]["Linha"   ];
            dsImportar.Tables["Carros"].Rows[iVer]["Coluna"  ] = dsFonte.Tables["Carros"].Rows[iPos]["Coluna"  ];
            dsImportar.Tables["Carros"].Rows[iVer]["Status"  ] = dsFonte.Tables["Carros"].Rows[iPos]["Status"  ];

            string strGrava = "UPDATE Carros SET CodPatio = @CodPatio, Bloco = @Bloco, Linha = @Linha, Coluna = @Coluna, Status = @Status WHERE Chassi = '" + sChassiImp + "'";

            OleDbCommand cmdGrava = new OleDbCommand(strGrava, this.myCon);

            cmdGrava.Parameters.Add(new OleDbParameter("@CodPatio", OleDbType.Integer));
            cmdGrava.Parameters.Add(new OleDbParameter("@Bloco"   , OleDbType.Char, 1));
            cmdGrava.Parameters.Add(new OleDbParameter("@Linha"   , OleDbType.Integer));
            cmdGrava.Parameters.Add(new OleDbParameter("@Coluna"  , OleDbType.Integer));
            cmdGrava.Parameters.Add(new OleDbParameter("@Status"  , OleDbType.Char, 1));

            cmdGrava.Parameters["@CodPatio"].Value = dsFonte.Tables["Carros"].Rows[iPos]["CodPatio"];
            cmdGrava.Parameters["@Bloco"   ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Bloco"   ];
            cmdGrava.Parameters["@Linha"   ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Linha"   ];
            cmdGrava.Parameters["@Coluna"  ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Coluna"  ];
            cmdGrava.Parameters["@Status"  ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Status"  ];

            cmdGrava.Connection.Open();
            cmdGrava.ExecuteNonQuery();
            cmdGrava.Connection.Close();
          }
        }

        if (bFlag)
        {
          drCarros = dsImportar.Tables["Carros"].NewRow();

          drCarros["Chassi"     ] = dsFonte.Tables["Carros"].Rows[iPos]["Chassi"     ];
          drCarros["CodModelo"  ] = dsFonte.Tables["Carros"].Rows[iPos]["CodModelo"  ];
          drCarros["Cor"        ] = dsFonte.Tables["Carros"].Rows[iPos]["Cor"        ];
          drCarros["CodEmbarque"] = dsFonte.Tables["Carros"].Rows[iPos]["CodEmbarque"];
          drCarros["CodPatio"   ] = dsFonte.Tables["Carros"].Rows[iPos]["CodPatio"   ];
          drCarros["Bloco"      ] = dsFonte.Tables["Carros"].Rows[iPos]["Bloco"      ];
          drCarros["Linha"      ] = dsFonte.Tables["Carros"].Rows[iPos]["Linha"      ];
          drCarros["Coluna"     ] = dsFonte.Tables["Carros"].Rows[iPos]["Coluna"     ];
          drCarros["Status"     ] = dsFonte.Tables["Carros"].Rows[iPos]["Status"     ];

          dsImportar.Tables["Carros"].Rows.Add(drCarros);

          string strGrava = "INSERT INTO Carros (Chassi, CodModelo, Cor, CodEmbarque, CodPatio, Bloco, Linha, Coluna, Status) " +
                            "VALUES (@Chassi, @CodModelo, @Cor, @CodEmbarque, @CodPatio, @Bloco, @Linha, @Coluna, @Status)";

          OleDbCommand cmdGrava = new OleDbCommand(strGrava, this.myCon);

          cmdGrava.Parameters.Add(new OleDbParameter("@Chassi     ", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@CodModelo  ", OleDbType.Char, 1));
          cmdGrava.Parameters.Add(new OleDbParameter("@Cor        ", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@CodEmbarque", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@CodPatio   ", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@Bloco      ", OleDbType.Char, 1));
          cmdGrava.Parameters.Add(new OleDbParameter("@Linha      ", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@Coluna     ", OleDbType.Integer));
          cmdGrava.Parameters.Add(new OleDbParameter("@Status     ", OleDbType.Char, 1));

          cmdGrava.Parameters["@Chassi"     ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Chassi"     ];
          cmdGrava.Parameters["@CodModelo"  ].Value = dsFonte.Tables["Carros"].Rows[iPos]["CodModelo"  ];
          cmdGrava.Parameters["@Cor"        ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Cor"        ];
          cmdGrava.Parameters["@CodEmbarque"].Value = dsFonte.Tables["Carros"].Rows[iPos]["CodEmbarque"];
          cmdGrava.Parameters["@CodPatio"   ].Value = dsFonte.Tables["Carros"].Rows[iPos]["CodPatio"   ];
          cmdGrava.Parameters["@Bloco"      ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Bloco"      ];
          cmdGrava.Parameters["@Linha"      ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Linha"      ];
          cmdGrava.Parameters["@Coluna"     ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Coluna"     ];
          cmdGrava.Parameters["@Status"     ].Value = dsFonte.Tables["Carros"].Rows[iPos]["Status"     ];

          cmdGrava.Connection.Open();
          cmdGrava.ExecuteNonQuery();
          cmdGrava.Connection.Close();
        }
      }

      for (int iPos = 0; iPos < dsFonte.Tables["Bloco"].Rows.Count; iPos++)
      {
        iPatioFon = Convert.ToInt32(dsFonte.Tables["Bloco"].Rows[iPos]["CodPatio"]);
        cBlocoFon = Convert.ToChar (dsFonte.Tables["Bloco"].Rows[iPos]["Bloco"   ]);

        for (int iVer = 0; iVer < dsImportar.Tables["Bloco"].Rows.Count; iVer++)
        {
          iPatioImp = Convert.ToInt32(dsImportar.Tables["Bloco"].Rows[iVer]["CodPatio"]);
          cBlocoImp = Convert.ToChar (dsImportar.Tables["Bloco"].Rows[iVer]["Bloco"    ]);

          if ((iPatioFon == iPatioImp) && (cBlocoFon == cBlocoImp))
          {
            dsImportar.Tables["Bloco"].Rows[iVer]["LinAtu"] = dsFonte.Tables["Bloco"].Rows[iPos]["LinAtu"];
            dsImportar.Tables["Bloco"].Rows[iVer]["ColAtu"] = dsFonte.Tables["Bloco"].Rows[iPos]["ColAtu"];

            string strGrava = "UPDATE Bloco SET LinAtu = @LinAtu, ColAtu = @ColAtu WHERE CodPatio = " + iPatioImp + " AND Bloco = '" + cBlocoImp;

            OleDbCommand cmdGrava = new OleDbCommand(strGrava, this.myCon);

            cmdGrava.Parameters.Add(new OleDbParameter("@LinAtu", OleDbType.Integer));
            cmdGrava.Parameters.Add(new OleDbParameter("@ColAtu", OleDbType.Integer));

            cmdGrava.Parameters["@LinAtu"].Value = dsFonte.Tables["Bloco"].Rows[iPos]["LinAtu"];
            cmdGrava.Parameters["@ColAtu"].Value = dsFonte.Tables["Bloco"].Rows[iPos]["ColAtu"];

            cmdGrava.Connection.Open();
            cmdGrava.ExecuteNonQuery();
            cmdGrava.Connection.Close();
          }
        }
      }

      MessageBox.Show("Importacão concluída...", "Importação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}