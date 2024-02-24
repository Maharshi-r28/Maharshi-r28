namespace Arithematic_Calculator
{
    partial class Form1
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
            lblarithematiccalculator = new Label();
            lblfirstnum = new Label();
            lblsecondnum = new Label();
            txtfirstnum = new TextBox();
            txtsecondnum = new TextBox();
            lbloperation = new Label();
            combooption = new ComboBox();
            lblresult = new Label();
            txtresult = new TextBox();
            btncalc = new Button();
            btnreset = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // lblarithematiccalculator
            // 
            lblarithematiccalculator.AutoSize = true;
            lblarithematiccalculator.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblarithematiccalculator.Location = new Point(434, 87);
            lblarithematiccalculator.Name = "lblarithematiccalculator";
            lblarithematiccalculator.Size = new Size(375, 44);
            lblarithematiccalculator.TabIndex = 0;
            lblarithematiccalculator.Text = "Arithematic Calculator";
            // 
            // lblfirstnum
            // 
            lblfirstnum.AutoSize = true;
            lblfirstnum.Location = new Point(198, 219);
            lblfirstnum.Name = "lblfirstnum";
            lblfirstnum.Size = new Size(187, 25);
            lblfirstnum.TabIndex = 1;
            lblfirstnum.Text = "Enter the First number";
            // 
            // lblsecondnum
            // 
            lblsecondnum.AutoSize = true;
            lblsecondnum.Location = new Point(198, 283);
            lblsecondnum.Name = "lblsecondnum";
            lblsecondnum.Size = new Size(213, 25);
            lblsecondnum.TabIndex = 2;
            lblsecondnum.Text = "Enter the Second number";
            // 
            // txtfirstnum
            // 
            txtfirstnum.Location = new Point(554, 219);
            txtfirstnum.Name = "txtfirstnum";
            txtfirstnum.Size = new Size(377, 31);
            txtfirstnum.TabIndex = 3;
            // 
            // txtsecondnum
            // 
            txtsecondnum.Location = new Point(554, 283);
            txtsecondnum.Name = "txtsecondnum";
            txtsecondnum.Size = new Size(377, 31);
            txtsecondnum.TabIndex = 4;
            // 
            // lbloperation
            // 
            lbloperation.AutoSize = true;
            lbloperation.Location = new Point(198, 354);
            lbloperation.Name = "lbloperation";
            lbloperation.Size = new Size(181, 25);
            lbloperation.TabIndex = 5;
            lbloperation.Text = "Choose an Operation";
            // 
            // combooption
            // 
            combooption.FormattingEnabled = true;
            combooption.Location = new Point(554, 354);
            combooption.Name = "combooption";
            combooption.Size = new Size(377, 33);
            combooption.TabIndex = 6;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(198, 435);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(59, 25);
            lblresult.TabIndex = 7;
            lblresult.Text = "Result";
            // 
            // txtresult
            // 
            txtresult.Location = new Point(554, 429);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(377, 31);
            txtresult.TabIndex = 8;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(198, 528);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(112, 34);
            btncalc.TabIndex = 9;
            btncalc.Text = "Calculate";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(529, 528);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(112, 34);
            btnreset.TabIndex = 10;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(819, 519);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 11;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 655);
            Controls.Add(btnexit);
            Controls.Add(btnreset);
            Controls.Add(btncalc);
            Controls.Add(txtresult);
            Controls.Add(lblresult);
            Controls.Add(combooption);
            Controls.Add(lbloperation);
            Controls.Add(txtsecondnum);
            Controls.Add(txtfirstnum);
            Controls.Add(lblsecondnum);
            Controls.Add(lblfirstnum);
            Controls.Add(lblarithematiccalculator);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblarithematiccalculator;
        private Label lblfirstnum;
        private Label lblsecondnum;
        private TextBox txtfirstnum;
        private TextBox txtsecondnum;
        private Label lbloperation;
        private ComboBox combooption;
        private Label lblresult;
        private TextBox txtresult;
        private Button btncalc;
        private Button btnreset;
        private Button btnexit;
    }
}
