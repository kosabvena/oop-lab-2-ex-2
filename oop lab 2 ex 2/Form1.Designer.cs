namespace oop_lab_2_ex_2
{
    partial class frmMass
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmdStart = new Button();
            cmdClear = new Button();
            cmdExit = new Button();
            dgvMass = new DataGridView();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Кількість строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 1;
            label2.Text = "Кількість стовпців m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(0, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(0, 566);
            cmdStart.Margin = new Padding(4, 4, 4, 4);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(344, 77);
            cmdStart.TabIndex = 3;
            cmdStart.Text = "Порахувати";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(352, 566);
            cmdClear.Margin = new Padding(4, 4, 4, 4);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(380, 77);
            cmdClear.TabIndex = 4;
            cmdClear.Text = "Очистити поля";
            cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(740, 566);
            cmdExit.Margin = new Padding(4, 4, 4, 4);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(344, 77);
            cmdExit.TabIndex = 5;
            cmdExit.Text = "Завершити роботу";
            cmdExit.UseVisualStyleBackColor = true;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(428, 17);
            dgvMass.Margin = new Padding(4, 4, 4, 4);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.Size = new Size(656, 533);
            dgvMass.TabIndex = 6;
            // 
            // txtn
            // 
            txtn.Location = new Point(0, 41);
            txtn.Margin = new Padding(4, 4, 4, 4);
            txtn.Name = "txtn";
            txtn.Size = new Size(282, 34);
            txtn.TabIndex = 7;
            // 
            // txtm
            // 
            txtm.Location = new Point(0, 123);
            txtm.Margin = new Padding(4, 4, 4, 4);
            txtm.Name = "txtm";
            txtm.Size = new Size(282, 34);
            txtm.TabIndex = 8;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(0, 213);
            txtRez.Margin = new Padding(4, 4, 4, 4);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(400, 336);
            txtRez.TabIndex = 9;
            // 
            // frmMass
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 669);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(dgvMass);
            Controls.Add(cmdExit);
            Controls.Add(cmdClear);
            Controls.Add(cmdStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMass";
            Text = "Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button cmdStart;
        private Button cmdClear;
        private Button cmdExit;
        private DataGridView dgvMass;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
    }
}
