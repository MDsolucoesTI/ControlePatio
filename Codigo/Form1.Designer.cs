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


namespace Controle
{
  partial class frmPrincipal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
      this.btnPesquisa = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnPDAPatio = new System.Windows.Forms.Button();
      this.btnCarros = new System.Windows.Forms.Button();
      this.btnCores = new System.Windows.Forms.Button();
      this.btnBlocos = new System.Windows.Forms.Button();
      this.btnPatios = new System.Windows.Forms.Button();
      this.btnEmbarque = new System.Windows.Forms.Button();
      this.btnPortos = new System.Windows.Forms.Button();
      this.btnModelo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnPesquisa
      // 
      this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisa.Image = global::Controle.Properties.Resources.CarrosPes;
      this.btnPesquisa.Location = new System.Drawing.Point(353, 164);
      this.btnPesquisa.Name = "btnPesquisa";
      this.btnPesquisa.Size = new System.Drawing.Size(149, 61);
      this.btnPesquisa.TabIndex = 9;
      this.btnPesquisa.Text = "Pesquisa Carros";
      this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPesquisa.UseVisualStyleBackColor = true;
      this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Controle.Properties.Resources.top_01;
      this.pictureBox1.Location = new System.Drawing.Point(96, 248);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(326, 110);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // btnPDAPatio
      // 
      this.btnPDAPatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPDAPatio.Image = ((System.Drawing.Image)(resources.GetObject("btnPDAPatio.Image")));
      this.btnPDAPatio.Location = new System.Drawing.Point(354, 88);
      this.btnPDAPatio.Name = "btnPDAPatio";
      this.btnPDAPatio.Size = new System.Drawing.Size(149, 61);
      this.btnPDAPatio.TabIndex = 7;
      this.btnPDAPatio.Text = "PDA - Patio";
      this.btnPDAPatio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPDAPatio.UseVisualStyleBackColor = true;
      this.btnPDAPatio.Click += new System.EventHandler(this.btnPDAPatio_Click);
      // 
      // btnCarros
      // 
      this.btnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCarros.Image = ((System.Drawing.Image)(resources.GetObject("btnCarros.Image")));
      this.btnCarros.Location = new System.Drawing.Point(354, 12);
      this.btnCarros.Name = "btnCarros";
      this.btnCarros.Size = new System.Drawing.Size(149, 61);
      this.btnCarros.TabIndex = 6;
      this.btnCarros.Text = "Carros";
      this.btnCarros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCarros.UseVisualStyleBackColor = true;
      this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
      // 
      // btnCores
      // 
      this.btnCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCores.Image = ((System.Drawing.Image)(resources.GetObject("btnCores.Image")));
      this.btnCores.Location = new System.Drawing.Point(16, 88);
      this.btnCores.Name = "btnCores";
      this.btnCores.Size = new System.Drawing.Size(149, 61);
      this.btnCores.TabIndex = 5;
      this.btnCores.Text = "Cores";
      this.btnCores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCores.UseVisualStyleBackColor = true;
      this.btnCores.Click += new System.EventHandler(this.btnCores_Click);
      // 
      // btnBlocos
      // 
      this.btnBlocos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBlocos.Image = ((System.Drawing.Image)(resources.GetObject("btnBlocos.Image")));
      this.btnBlocos.Location = new System.Drawing.Point(184, 164);
      this.btnBlocos.Name = "btnBlocos";
      this.btnBlocos.Size = new System.Drawing.Size(149, 61);
      this.btnBlocos.TabIndex = 4;
      this.btnBlocos.Text = "Blocos";
      this.btnBlocos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnBlocos.UseVisualStyleBackColor = true;
      this.btnBlocos.Click += new System.EventHandler(this.btnBlocos_Click);
      // 
      // btnPatios
      // 
      this.btnPatios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatios.Image = ((System.Drawing.Image)(resources.GetObject("btnPatios.Image")));
      this.btnPatios.Location = new System.Drawing.Point(185, 12);
      this.btnPatios.Name = "btnPatios";
      this.btnPatios.Size = new System.Drawing.Size(149, 61);
      this.btnPatios.TabIndex = 3;
      this.btnPatios.Text = "Patios";
      this.btnPatios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPatios.UseVisualStyleBackColor = true;
      this.btnPatios.Click += new System.EventHandler(this.btnPatios_Click);
      // 
      // btnEmbarque
      // 
      this.btnEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEmbarque.Image = ((System.Drawing.Image)(resources.GetObject("btnEmbarque.Image")));
      this.btnEmbarque.Location = new System.Drawing.Point(15, 164);
      this.btnEmbarque.Name = "btnEmbarque";
      this.btnEmbarque.Size = new System.Drawing.Size(149, 61);
      this.btnEmbarque.TabIndex = 2;
      this.btnEmbarque.Text = "Embarque";
      this.btnEmbarque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnEmbarque.UseVisualStyleBackColor = true;
      this.btnEmbarque.Click += new System.EventHandler(this.btnEmbarque_Click);
      // 
      // btnPortos
      // 
      this.btnPortos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPortos.Image = ((System.Drawing.Image)(resources.GetObject("btnPortos.Image")));
      this.btnPortos.Location = new System.Drawing.Point(16, 12);
      this.btnPortos.Name = "btnPortos";
      this.btnPortos.Size = new System.Drawing.Size(149, 61);
      this.btnPortos.TabIndex = 1;
      this.btnPortos.Text = "Portos";
      this.btnPortos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPortos.UseVisualStyleBackColor = true;
      this.btnPortos.Click += new System.EventHandler(this.btnPortos_Click);
      // 
      // btnModelo
      // 
      this.btnModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnModelo.Image")));
      this.btnModelo.Location = new System.Drawing.Point(185, 88);
      this.btnModelo.Name = "btnModelo";
      this.btnModelo.Size = new System.Drawing.Size(149, 61);
      this.btnModelo.TabIndex = 0;
      this.btnModelo.Text = "Modelo";
      this.btnModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnModelo.UseVisualStyleBackColor = true;
      this.btnModelo.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(199)))), ((int)(((byte)(200)))));
      this.ClientSize = new System.Drawing.Size(518, 370);
      this.Controls.Add(this.btnPesquisa);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btnPDAPatio);
      this.Controls.Add(this.btnCarros);
      this.Controls.Add(this.btnCores);
      this.Controls.Add(this.btnBlocos);
      this.Controls.Add(this.btnPatios);
      this.Controls.Add(this.btnEmbarque);
      this.Controls.Add(this.btnPortos);
      this.Controls.Add(this.btnModelo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmPrincipal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sistema de Controle de Pátios";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnModelo;
    private System.Windows.Forms.Button btnPortos;
    private System.Windows.Forms.Button btnEmbarque;
    private System.Windows.Forms.Button btnPatios;
    private System.Windows.Forms.Button btnBlocos;
    private System.Windows.Forms.Button btnCores;
    private System.Windows.Forms.Button btnCarros;
    private System.Windows.Forms.Button btnPDAPatio;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnPesquisa;
  }
}

