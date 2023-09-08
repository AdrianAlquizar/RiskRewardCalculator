namespace Risk_Reward_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtentryprice = new System.Windows.Forms.TextBox();
            this.txtexitprice = new System.Windows.Forms.TextBox();
            this.txtstoploss = new System.Windows.Forms.TextBox();
            this.lblentryprice = new System.Windows.Forms.Label();
            this.lblexitprice = new System.Windows.Forms.Label();
            this.lblstoploss = new System.Windows.Forms.Label();
            this.lblriskrewardratio = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbloutputRR = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RISK REWARD CALCULATOR";
            // 
            // txtentryprice
            // 
            this.txtentryprice.BackColor = System.Drawing.Color.DimGray;
            this.txtentryprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtentryprice.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentryprice.ForeColor = System.Drawing.Color.Lime;
            this.txtentryprice.Location = new System.Drawing.Point(99, 116);
            this.txtentryprice.Name = "txtentryprice";
            this.txtentryprice.Size = new System.Drawing.Size(370, 35);
            this.txtentryprice.TabIndex = 1;
            // 
            // txtexitprice
            // 
            this.txtexitprice.BackColor = System.Drawing.Color.DimGray;
            this.txtexitprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtexitprice.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexitprice.ForeColor = System.Drawing.Color.Lime;
            this.txtexitprice.Location = new System.Drawing.Point(99, 219);
            this.txtexitprice.Name = "txtexitprice";
            this.txtexitprice.Size = new System.Drawing.Size(370, 35);
            this.txtexitprice.TabIndex = 2;
            // 
            // txtstoploss
            // 
            this.txtstoploss.BackColor = System.Drawing.Color.DimGray;
            this.txtstoploss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstoploss.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstoploss.ForeColor = System.Drawing.Color.Lime;
            this.txtstoploss.Location = new System.Drawing.Point(99, 322);
            this.txtstoploss.Name = "txtstoploss";
            this.txtstoploss.Size = new System.Drawing.Size(370, 35);
            this.txtstoploss.TabIndex = 3;
            // 
            // lblentryprice
            // 
            this.lblentryprice.AutoSize = true;
            this.lblentryprice.BackColor = System.Drawing.Color.Transparent;
            this.lblentryprice.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentryprice.ForeColor = System.Drawing.Color.Lime;
            this.lblentryprice.Location = new System.Drawing.Point(94, 86);
            this.lblentryprice.Name = "lblentryprice";
            this.lblentryprice.Size = new System.Drawing.Size(144, 27);
            this.lblentryprice.TabIndex = 4;
            this.lblentryprice.Text = "Entry Price";
            // 
            // lblexitprice
            // 
            this.lblexitprice.AutoSize = true;
            this.lblexitprice.BackColor = System.Drawing.Color.Transparent;
            this.lblexitprice.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexitprice.ForeColor = System.Drawing.Color.Lime;
            this.lblexitprice.Location = new System.Drawing.Point(94, 189);
            this.lblexitprice.Name = "lblexitprice";
            this.lblexitprice.Size = new System.Drawing.Size(132, 27);
            this.lblexitprice.TabIndex = 5;
            this.lblexitprice.Text = "Exit Price";
            this.lblexitprice.Click += new System.EventHandler(this.txtexitprice_Click);
            // 
            // lblstoploss
            // 
            this.lblstoploss.AutoSize = true;
            this.lblstoploss.BackColor = System.Drawing.Color.Transparent;
            this.lblstoploss.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstoploss.ForeColor = System.Drawing.Color.Lime;
            this.lblstoploss.Location = new System.Drawing.Point(94, 292);
            this.lblstoploss.Name = "lblstoploss";
            this.lblstoploss.Size = new System.Drawing.Size(120, 27);
            this.lblstoploss.TabIndex = 6;
            this.lblstoploss.Text = "Stop Loss";
            // 
            // lblriskrewardratio
            // 
            this.lblriskrewardratio.AutoSize = true;
            this.lblriskrewardratio.BackColor = System.Drawing.Color.Transparent;
            this.lblriskrewardratio.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblriskrewardratio.ForeColor = System.Drawing.Color.Lime;
            this.lblriskrewardratio.Location = new System.Drawing.Point(636, 86);
            this.lblriskrewardratio.Name = "lblriskrewardratio";
            this.lblriskrewardratio.Size = new System.Drawing.Size(252, 27);
            this.lblriskrewardratio.TabIndex = 7;
            this.lblriskrewardratio.Text = "Risk Reward Ratio is";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.BackColor = System.Drawing.Color.Transparent;
            this.lbloutput.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.ForeColor = System.Drawing.Color.Lime;
            this.lbloutput.Location = new System.Drawing.Point(636, 124);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 27);
            this.lbloutput.TabIndex = 8;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Transparent;
            this.btncalculate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btncalculate.FlatAppearance.BorderSize = 2;
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Lime;
            this.btncalculate.Location = new System.Drawing.Point(99, 397);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(370, 57);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "CALCULATE";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbloutputRR
            // 
            this.lbloutputRR.AutoSize = true;
            this.lbloutputRR.BackColor = System.Drawing.Color.Transparent;
            this.lbloutputRR.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputRR.ForeColor = System.Drawing.Color.Lime;
            this.lbloutputRR.Location = new System.Drawing.Point(636, 189);
            this.lbloutputRR.Name = "lbloutputRR";
            this.lbloutputRR.Size = new System.Drawing.Size(0, 27);
            this.lbloutputRR.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Lime;
            this.btnClear.Location = new System.Drawing.Point(625, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(370, 57);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CALCULATE AGAIN";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1226, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1297, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbloutputRR);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblriskrewardratio);
            this.Controls.Add(this.lblstoploss);
            this.Controls.Add(this.lblexitprice);
            this.Controls.Add(this.lblentryprice);
            this.Controls.Add(this.txtstoploss);
            this.Controls.Add(this.txtexitprice);
            this.Controls.Add(this.txtentryprice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtentryprice;
        private System.Windows.Forms.TextBox txtexitprice;
        private System.Windows.Forms.TextBox txtstoploss;
        private System.Windows.Forms.Label lblentryprice;
        private System.Windows.Forms.Label lblexitprice;
        private System.Windows.Forms.Label lblstoploss;
        private System.Windows.Forms.Label lblriskrewardratio;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbloutputRR;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}

