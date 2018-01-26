namespace VirtualBaja
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Velocidade = new System.Windows.Forms.Label();
            this.Frequencia = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.Label();
            this.Combustivel = new System.Windows.Forms.Label();
            this.Carga = new System.Windows.Forms.Label();
            this.valorVeloc = new System.Windows.Forms.Label();
            this.valorTemp = new System.Windows.Forms.Label();
            this.valorComb = new System.Windows.Forms.Label();
            this.valorRPM = new System.Windows.Forms.Label();
            this.valorCarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(13, 13);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            // 
            // Velocidade
            // 
            this.Velocidade.AutoSize = true;
            this.Velocidade.Location = new System.Drawing.Point(120, 50);
            this.Velocidade.Name = "Velocidade";
            this.Velocidade.Size = new System.Drawing.Size(60, 13);
            this.Velocidade.TabIndex = 2;
            this.Velocidade.Text = "Velocidade";
            // 
            // Frequencia
            // 
            this.Frequencia.AutoSize = true;
            this.Frequencia.Location = new System.Drawing.Point(510, 50);
            this.Frequencia.Name = "Frequencia";
            this.Frequencia.Size = new System.Drawing.Size(31, 13);
            this.Frequencia.TabIndex = 3;
            this.Frequencia.Text = "RPM";
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(120, 144);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(67, 13);
            this.Temperatura.TabIndex = 4;
            this.Temperatura.Text = "Temperatura";
            // 
            // Combustivel
            // 
            this.Combustivel.AutoSize = true;
            this.Combustivel.Location = new System.Drawing.Point(493, 144);
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.Size = new System.Drawing.Size(66, 13);
            this.Combustivel.TabIndex = 5;
            this.Combustivel.Text = "Combustível";
            // 
            // Carga
            // 
            this.Carga.AutoSize = true;
            this.Carga.Location = new System.Drawing.Point(332, 112);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(35, 13);
            this.Carga.TabIndex = 6;
            this.Carga.Text = "Carga";
            // 
            // valorVeloc
            // 
            this.valorVeloc.AutoSize = true;
            this.valorVeloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valorVeloc.Location = new System.Drawing.Point(70, 81);
            this.valorVeloc.Name = "valorVeloc";
            this.valorVeloc.Size = new System.Drawing.Size(188, 63);
            this.valorVeloc.TabIndex = 7;
            this.valorVeloc.Text = "0 km/h";
            this.valorVeloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorTemp
            // 
            this.valorTemp.AutoSize = true;
            this.valorTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valorTemp.Location = new System.Drawing.Point(99, 173);
            this.valorTemp.Name = "valorTemp";
            this.valorTemp.Size = new System.Drawing.Size(130, 63);
            this.valorTemp.TabIndex = 8;
            this.valorTemp.Text = "0 ºC";
            this.valorTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorComb
            // 
            this.valorComb.AutoSize = true;
            this.valorComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valorComb.Location = new System.Drawing.Point(471, 173);
            this.valorComb.Name = "valorComb";
            this.valorComb.Size = new System.Drawing.Size(119, 63);
            this.valorComb.TabIndex = 9;
            this.valorComb.Text = "0 %";
            this.valorComb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorRPM
            // 
            this.valorRPM.AutoSize = true;
            this.valorRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valorRPM.Location = new System.Drawing.Point(445, 81);
            this.valorRPM.Name = "valorRPM";
            this.valorRPM.Size = new System.Drawing.Size(164, 63);
            this.valorRPM.TabIndex = 10;
            this.valorRPM.Text = "0 rpm";
            this.valorRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valorRPM.Click += new System.EventHandler(this.valorRPM_Click);
            // 
            // valorCarga
            // 
            this.valorCarga.AutoSize = true;
            this.valorCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valorCarga.Location = new System.Drawing.Point(300, 125);
            this.valorCarga.Name = "valorCarga";
            this.valorCarga.Size = new System.Drawing.Size(107, 63);
            this.valorCarga.TabIndex = 11;
            this.valorCarga.Text = "0 V";
            this.valorCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 328);
            this.Controls.Add(this.valorCarga);
            this.Controls.Add(this.valorRPM);
            this.Controls.Add(this.valorComb);
            this.Controls.Add(this.valorTemp);
            this.Controls.Add(this.valorVeloc);
            this.Controls.Add(this.Carga);
            this.Controls.Add(this.Combustivel);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.Frequencia);
            this.Controls.Add(this.Velocidade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label Velocidade;
        private System.Windows.Forms.Label Frequencia;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Label Combustivel;
        private System.Windows.Forms.Label Carga;
        private System.Windows.Forms.Label valorVeloc;
        private System.Windows.Forms.Label valorTemp;
        private System.Windows.Forms.Label valorComb;
        private System.Windows.Forms.Label valorRPM;
        private System.Windows.Forms.Label valorCarga;
    }
}

