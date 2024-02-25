namespace Item_move_program
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
            lblitemmoveprog = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            lblfirstlist = new Label();
            lblsecondlist = new Label();
            btnmoveright = new Button();
            btnmoveleft = new Button();
            btnmultiright = new Button();
            btnmoveallleft = new Button();
            btnmoveallright = new Button();
            btnmultileft = new Button();
            btnreset = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // lblitemmoveprog
            // 
            lblitemmoveprog.AutoSize = true;
            lblitemmoveprog.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblitemmoveprog.Location = new Point(344, 71);
            lblitemmoveprog.Name = "lblitemmoveprog";
            lblitemmoveprog.Size = new Size(596, 60);
            lblitemmoveprog.TabIndex = 0;
            lblitemmoveprog.Text = "ITEM MOVE PROGRAMME";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow", "Orange", "Pink", "White", "Violet", "Navy blue", "Black", "White" });
            listBox1.Location = new Point(344, 261);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 329);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(760, 261);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 329);
            listBox2.TabIndex = 2;
            // 
            // lblfirstlist
            // 
            lblfirstlist.AutoSize = true;
            lblfirstlist.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfirstlist.Location = new Point(344, 200);
            lblfirstlist.Name = "lblfirstlist";
            lblfirstlist.Size = new Size(143, 40);
            lblfirstlist.TabIndex = 3;
            lblfirstlist.Text = "First list";
            // 
            // lblsecondlist
            // 
            lblsecondlist.AutoSize = true;
            lblsecondlist.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsecondlist.Location = new Point(760, 200);
            lblsecondlist.Name = "lblsecondlist";
            lblsecondlist.Size = new Size(188, 40);
            lblsecondlist.TabIndex = 4;
            lblsecondlist.Text = "Second list";
            // 
            // btnmoveright
            // 
            btnmoveright.Location = new Point(551, 261);
            btnmoveright.Name = "btnmoveright";
            btnmoveright.Size = new Size(188, 34);
            btnmoveright.TabIndex = 5;
            btnmoveright.Text = ">";
            btnmoveright.UseVisualStyleBackColor = true;
            btnmoveright.Click += btnmoveright_Click;
            // 
            // btnmoveleft
            // 
            btnmoveleft.Location = new Point(551, 319);
            btnmoveleft.Name = "btnmoveleft";
            btnmoveleft.Size = new Size(188, 34);
            btnmoveleft.TabIndex = 6;
            btnmoveleft.Text = "<";
            btnmoveleft.UseVisualStyleBackColor = true;
            btnmoveleft.Click += btnmoveleft_Click;
            // 
            // btnmultiright
            // 
            btnmultiright.Location = new Point(551, 374);
            btnmultiright.Name = "btnmultiright";
            btnmultiright.Size = new Size(188, 34);
            btnmultiright.TabIndex = 7;
            btnmultiright.Text = ">>";
            btnmultiright.UseVisualStyleBackColor = true;
            btnmultiright.Click += btnmultiright_Click;
            // 
            // btnmoveallleft
            // 
            btnmoveallleft.Location = new Point(551, 541);
            btnmoveallleft.Name = "btnmoveallleft";
            btnmoveallleft.Size = new Size(188, 34);
            btnmoveallleft.TabIndex = 10;
            btnmoveallleft.Text = "All Left";
            btnmoveallleft.UseVisualStyleBackColor = true;
            btnmoveallleft.Click += btnmoveallleft_Click;
            // 
            // btnmoveallright
            // 
            btnmoveallright.Location = new Point(551, 486);
            btnmoveallright.Name = "btnmoveallright";
            btnmoveallright.Size = new Size(188, 34);
            btnmoveallright.TabIndex = 9;
            btnmoveallright.Text = "All Right";
            btnmoveallright.UseVisualStyleBackColor = true;
            btnmoveallright.Click += btnmoveallright_Click;
            // 
            // btnmultileft
            // 
            btnmultileft.Location = new Point(551, 428);
            btnmultileft.Name = "btnmultileft";
            btnmultileft.Size = new Size(188, 34);
            btnmultileft.TabIndex = 8;
            btnmultileft.Text = "<<";
            btnmultileft.UseVisualStyleBackColor = true;
            btnmultileft.Click += btnmultileft_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(344, 626);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(180, 34);
            btnreset.TabIndex = 11;
            btnreset.Text = "RESET";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(760, 626);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(180, 34);
            btnexit.TabIndex = 12;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 699);
            Controls.Add(btnexit);
            Controls.Add(btnreset);
            Controls.Add(btnmoveallleft);
            Controls.Add(btnmoveallright);
            Controls.Add(btnmultileft);
            Controls.Add(btnmultiright);
            Controls.Add(btnmoveleft);
            Controls.Add(btnmoveright);
            Controls.Add(lblsecondlist);
            Controls.Add(lblfirstlist);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(lblitemmoveprog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblitemmoveprog;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label lblfirstlist;
        private Label lblsecondlist;
        private Button btnmoveright;
        private Button btnmoveleft;
        private Button btnmultiright;
        private Button btnmoveallleft;
        private Button btnmoveallright;
        private Button btnmultileft;
        private Button btnreset;
        private Button btnexit;
    }
}
