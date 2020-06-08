namespace GiamSatTrangTrai
{
    partial class Form1
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
            this.iDriver1 = new ATSCADA.iDriver();
            this.ilabNhietDo = new ATSCADA.iWinTools.iLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ilabDoAm = new ATSCADA.iWinTools.iLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ilabTanSo = new ATSCADA.iWinTools.iLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ilabNH3 = new ATSCADA.iWinTools.iLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ilabO2 = new ATSCADA.iWinTools.iLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.ilabCO2 = new ATSCADA.iWinTools.iLabel();
            this.SuspendLayout();
            // 
            // iDriver1
            // 
            this.iDriver1.Designmode = false;
            this.iDriver1.GetTaskTimeOut = ((ulong)(5000ul));
            this.iDriver1.MaxTagWriteTimes = 10;
            this.iDriver1.ProjectFile = null;
            this.iDriver1.WaitingTime = 5000;
            // 
            // ilabNhietDo
            // 
            this.ilabNhietDo.Driver = this.iDriver1;
            this.ilabNhietDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabNhietDo.Location = new System.Drawing.Point(198, 57);
            this.ilabNhietDo.Name = "ilabNhietDo";
            this.ilabNhietDo.Size = new System.Drawing.Size(104, 40);
            this.ilabNhietDo.TabIndex = 0;
            this.ilabNhietDo.TagName = "ChuongGa1Device.nhietDoHienTai";
            this.ilabNhietDo.Text = "000.0";
            this.ilabNhietDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhiệt Độ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Độ Ẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilabDoAm
            // 
            this.ilabDoAm.Driver = this.iDriver1;
            this.ilabDoAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabDoAm.Location = new System.Drawing.Point(198, 128);
            this.ilabDoAm.Name = "ilabDoAm";
            this.ilabDoAm.Size = new System.Drawing.Size(104, 40);
            this.ilabDoAm.TabIndex = 2;
            this.ilabDoAm.TagName = "ChuongGa1Device.doAmHienTai";
            this.ilabDoAm.Text = "000.0";
            this.ilabDoAm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tần Số";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilabTanSo
            // 
            this.ilabTanSo.Driver = this.iDriver1;
            this.ilabTanSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabTanSo.Location = new System.Drawing.Point(574, 62);
            this.ilabTanSo.Name = "ilabTanSo";
            this.ilabTanSo.Size = new System.Drawing.Size(104, 40);
            this.ilabTanSo.TabIndex = 4;
            this.ilabTanSo.TagName = "ChuongGa1Device.tanSoHienTai";
            this.ilabTanSo.Text = "000.0";
            this.ilabTanSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "NH3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilabNH3
            // 
            this.ilabNH3.Driver = this.iDriver1;
            this.ilabNH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabNH3.Location = new System.Drawing.Point(574, 123);
            this.ilabNH3.Name = "ilabNH3";
            this.ilabNH3.Size = new System.Drawing.Size(104, 40);
            this.ilabNH3.TabIndex = 6;
            this.ilabNH3.TagName = "ChuongGa1Device.nh3HienTai";
            this.ilabNH3.Text = "000.0";
            this.ilabNH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "O2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilabO2
            // 
            this.ilabO2.Driver = this.iDriver1;
            this.ilabO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabO2.Location = new System.Drawing.Point(870, 62);
            this.ilabO2.Name = "ilabO2";
            this.ilabO2.Size = new System.Drawing.Size(104, 40);
            this.ilabO2.TabIndex = 8;
            this.ilabO2.TagName = "ChuongGa1Device.oxiHienTai";
            this.ilabO2.Text = "000.0";
            this.ilabO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(755, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "CO2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilabCO2
            // 
            this.ilabCO2.Driver = this.iDriver1;
            this.ilabCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabCO2.Location = new System.Drawing.Point(870, 123);
            this.ilabCO2.Name = "ilabCO2";
            this.ilabCO2.Size = new System.Drawing.Size(104, 40);
            this.ilabCO2.TabIndex = 10;
            this.ilabCO2.TagName = "ChuongGa1Device.co2HienTai";
            this.ilabCO2.Text = "000.0";
            this.ilabCO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 715);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ilabCO2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ilabO2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ilabNH3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilabTanSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ilabDoAm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilabNhietDo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ATSCADA.iDriver iDriver1;
        private ATSCADA.iWinTools.iLabel ilabNhietDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ATSCADA.iWinTools.iLabel ilabDoAm;
        private System.Windows.Forms.Label label3;
        private ATSCADA.iWinTools.iLabel ilabTanSo;
        private System.Windows.Forms.Label label4;
        private ATSCADA.iWinTools.iLabel ilabNH3;
        private System.Windows.Forms.Label label5;
        private ATSCADA.iWinTools.iLabel ilabO2;
        private System.Windows.Forms.Label label6;
        private ATSCADA.iWinTools.iLabel ilabCO2;
    }
}

