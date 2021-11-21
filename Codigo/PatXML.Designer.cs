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


namespace Controle
{
  partial class frmPatXML
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatXML));
      this.btnCarros = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCarros
      // 
      this.btnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnCarros.Image")));
      this.btnCarros.Location = new System.Drawing.Point(63, 96);
      this.btnCarros.Name = "btnCarros";
      this.btnCarros.Size = new System.Drawing.Size(197, 57);
      this.btnCarros.TabIndex = 8;
      this.btnCarros.Text = "Gerar XML - Patio";
      this.btnCarros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCarros.UseVisualStyleBackColor = true;
      this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
      // 
      // frmPatXML
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(321, 175);
      this.Controls.Add(this.btnCarros);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmPatXML";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PDA - Patio";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCarros;
  }
}