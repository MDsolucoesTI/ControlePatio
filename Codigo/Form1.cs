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
 *   Data da Criação: 03/09/2008                                      *
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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmModelo wndModelo = new frmModelo();
      wndModelo.ShowDialog();
    }

    private void btnPortos_Click(object sender, EventArgs e)
    {
      frmPorto wndPorto = new frmPorto();
      wndPorto.ShowDialog();
    }

    private void btnPatios_Click(object sender, EventArgs e)
    {
      frmPatio wndPatio = new frmPatio();
      wndPatio.ShowDialog();
    }

    private void btnEmbarque_Click(object sender, EventArgs e)
    {
      frmEmbarque wndEmbarque = new frmEmbarque();
      wndEmbarque.ShowDialog();
    }

    private void btnBlocos_Click(object sender, EventArgs e)
    {
      frmBloco wndBloco = new frmBloco();
      wndBloco.ShowDialog();
    }

    private void btnCores_Click(object sender, EventArgs e)
    {
      frmCores wndCores = new frmCores();
      wndCores.ShowDialog();
    }

    private void btnCarros_Click(object sender, EventArgs e)
    {
      frmCarros wndCarros = new frmCarros();
      wndCarros.ShowDialog();
    }

    private void btnPDAPatio_Click(object sender, EventArgs e)
    {
      frmPatXML wndPatXML = new frmPatXML();
      wndPatXML.ShowDialog();
    }

    private void btnPesquisa_Click(object sender, EventArgs e)
    {
      frmPesquisa wndPesquisa = new frmPesquisa();
      wndPesquisa.ShowDialog();
    }
  }
}