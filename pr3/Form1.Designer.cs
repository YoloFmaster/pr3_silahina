namespace pr3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grBox1 = new GroupBox();
            btnCenter = new PictureBox();
            btnBottomLeght = new PictureBox();
            btnTopRight = new PictureBox();
            btnTopLefht = new PictureBox();
            pictureBox3 = new PictureBox();
            grBox2 = new GroupBox();
            btnC = new Button();
            btnB = new Button();
            btnP = new Button();
            grBox3 = new GroupBox();
            lblSizeWorkTable = new Label();
            lblSizeForm = new Label();
            lblLocationPanel = new Label();
            lblSolution = new Label();
            txtLocationPanel = new TextBox();
            txtSizeForm = new TextBox();
            txtSizeWorkTable = new TextBox();
            txtSolution = new TextBox();
            groupBox4 = new GroupBox();
            btnPlus = new Button();
            btn939 = new Button();
            btn839 = new Button();
            btnStandart = new Button();
            btnMinus = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ffdsToolStripMenuItem = new ToolStripMenuItem();
            grBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBottomLeght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTopLefht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grBox2.SuspendLayout();
            grBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // grBox1
            // 
            grBox1.BackColor = Color.Orange;
            grBox1.Controls.Add(btnCenter);
            grBox1.Controls.Add(btnBottomLeght);
            grBox1.Controls.Add(btnTopRight);
            grBox1.Controls.Add(btnTopLefht);
            grBox1.Controls.Add(pictureBox3);
            grBox1.Location = new Point(35, 83);
            grBox1.Margin = new Padding(3, 4, 3, 4);
            grBox1.Name = "grBox1";
            grBox1.Padding = new Padding(3, 4, 3, 4);
            grBox1.Size = new Size(362, 432);
            grBox1.TabIndex = 0;
            grBox1.TabStop = false;
            grBox1.Text = "Расположение формы";
            // 
            // btnCenter
            // 
            btnCenter.Image = (Image)resources.GetObject("btnCenter.Image");
            btnCenter.Location = new Point(138, 172);
            btnCenter.Margin = new Padding(3, 4, 3, 4);
            btnCenter.Name = "btnCenter";
            btnCenter.Size = new Size(87, 107);
            btnCenter.SizeMode = PictureBoxSizeMode.Zoom;
            btnCenter.TabIndex = 5;
            btnCenter.TabStop = false;
            btnCenter.Click += btnCenter_Click;
            // 
            // btnBottomLeght
            // 
            btnBottomLeght.Image = (Image)resources.GetObject("btnBottomLeght.Image");
            btnBottomLeght.Location = new Point(7, 307);
            btnBottomLeght.Margin = new Padding(3, 4, 3, 4);
            btnBottomLeght.Name = "btnBottomLeght";
            btnBottomLeght.Size = new Size(88, 105);
            btnBottomLeght.SizeMode = PictureBoxSizeMode.Zoom;
            btnBottomLeght.TabIndex = 3;
            btnBottomLeght.TabStop = false;
            btnBottomLeght.Click += btnBottomLeght_Click;
            // 
            // btnTopRight
            // 
            btnTopRight.Image = (Image)resources.GetObject("btnTopRight.Image");
            btnTopRight.Location = new Point(257, 29);
            btnTopRight.Margin = new Padding(3, 4, 3, 4);
            btnTopRight.Name = "btnTopRight";
            btnTopRight.Size = new Size(88, 105);
            btnTopRight.TabIndex = 4;
            btnTopRight.TabStop = false;
            btnTopRight.Click += pictureBox4_Click;
            // 
            // btnTopLefht
            // 
            btnTopLefht.Image = (Image)resources.GetObject("btnTopLefht.Image");
            btnTopLefht.Location = new Point(7, 29);
            btnTopLefht.Margin = new Padding(3, 4, 3, 4);
            btnTopLefht.Name = "btnTopLefht";
            btnTopLefht.Size = new Size(88, 105);
            btnTopLefht.TabIndex = 2;
            btnTopLefht.TabStop = false;
            btnTopLefht.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(257, 307);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 105);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // grBox2
            // 
            grBox2.BackColor = Color.Orange;
            grBox2.Controls.Add(btnC);
            grBox2.Controls.Add(btnB);
            grBox2.Controls.Add(btnP);
            grBox2.Location = new Point(465, 83);
            grBox2.Margin = new Padding(3, 4, 3, 4);
            grBox2.Name = "grBox2";
            grBox2.Padding = new Padding(3, 4, 3, 4);
            grBox2.Size = new Size(307, 187);
            grBox2.TabIndex = 1;
            grBox2.TabStop = false;
            grBox2.Text = "Размер формы";
            // 
            // btnC
            // 
            btnC.Location = new Point(10, 128);
            btnC.Margin = new Padding(3, 4, 3, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(287, 43);
            btnC.TabIndex = 2;
            btnC.Text = "Свернуть";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(10, 77);
            btnB.Margin = new Padding(3, 4, 3, 4);
            btnB.Name = "btnB";
            btnB.Size = new Size(287, 43);
            btnB.TabIndex = 1;
            btnB.Text = "Восстановить";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnP
            // 
            btnP.Location = new Point(10, 29);
            btnP.Margin = new Padding(3, 4, 3, 4);
            btnP.Name = "btnP";
            btnP.Size = new Size(287, 43);
            btnP.TabIndex = 0;
            btnP.Text = "Развернуть";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click += button1_Click;
            // 
            // grBox3
            // 
            grBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grBox3.BackColor = Color.Orange;
            grBox3.Controls.Add(lblSizeWorkTable);
            grBox3.Controls.Add(lblSizeForm);
            grBox3.Controls.Add(lblLocationPanel);
            grBox3.Controls.Add(lblSolution);
            grBox3.Controls.Add(txtLocationPanel);
            grBox3.Controls.Add(txtSizeForm);
            grBox3.Controls.Add(txtSizeWorkTable);
            grBox3.Controls.Add(txtSolution);
            grBox3.Location = new Point(869, 83);
            grBox3.Margin = new Padding(3, 4, 3, 4);
            grBox3.Name = "grBox3";
            grBox3.Padding = new Padding(3, 4, 3, 4);
            grBox3.Size = new Size(302, 529);
            grBox3.TabIndex = 1;
            grBox3.TabStop = false;
            grBox3.Text = "Информация о экране";
            // 
            // lblSizeWorkTable
            // 
            lblSizeWorkTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSizeWorkTable.AutoSize = true;
            lblSizeWorkTable.Location = new Point(74, 350);
            lblSizeWorkTable.Name = "lblSizeWorkTable";
            lblSizeWorkTable.Size = new Size(172, 20);
            lblSizeWorkTable.TabIndex = 9;
            lblSizeWorkTable.Text = "Размер рабочего стола";
            // 
            // lblSizeForm
            // 
            lblSizeForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSizeForm.AutoSize = true;
            lblSizeForm.Location = new Point(105, 241);
            lblSizeForm.Name = "lblSizeForm";
            lblSizeForm.Size = new Size(114, 20);
            lblSizeForm.TabIndex = 8;
            lblSizeForm.Text = "Размер формы";
            // 
            // lblLocationPanel
            // 
            lblLocationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLocationPanel.AutoSize = true;
            lblLocationPanel.Location = new Point(62, 149);
            lblLocationPanel.Name = "lblLocationPanel";
            lblLocationPanel.Size = new Size(210, 20);
            lblLocationPanel.TabIndex = 7;
            lblLocationPanel.Text = "Расположение панели задач";
            lblLocationPanel.Click += label4_Click;
            // 
            // lblSolution
            // 
            lblSolution.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSolution.AutoSize = true;
            lblSolution.Location = new Point(91, 54);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(139, 20);
            lblSolution.TabIndex = 4;
            lblSolution.Text = "Разрешени экрана";
            lblSolution.Click += lblSolution_Click;
            // 
            // txtLocationPanel
            // 
            txtLocationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLocationPanel.Location = new Point(51, 172);
            txtLocationPanel.Name = "txtLocationPanel";
            txtLocationPanel.Size = new Size(222, 27);
            txtLocationPanel.TabIndex = 3;
            // 
            // txtSizeForm
            // 
            txtSizeForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSizeForm.Location = new Point(51, 264);
            txtSizeForm.Name = "txtSizeForm";
            txtSizeForm.Size = new Size(222, 27);
            txtSizeForm.TabIndex = 2;
            txtSizeForm.TextChanged += txtSizeForm_TextChanged;
            // 
            // txtSizeWorkTable
            // 
            txtSizeWorkTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSizeWorkTable.Location = new Point(51, 373);
            txtSizeWorkTable.Name = "txtSizeWorkTable";
            txtSizeWorkTable.Size = new Size(222, 27);
            txtSizeWorkTable.TabIndex = 1;
            txtSizeWorkTable.TextChanged += textBox2_TextChanged;
            // 
            // txtSolution
            // 
            txtSolution.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSolution.Location = new Point(51, 77);
            txtSolution.Name = "txtSolution";
            txtSolution.Size = new Size(222, 27);
            txtSolution.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Orange;
            groupBox4.Controls.Add(btnPlus);
            groupBox4.Controls.Add(btn939);
            groupBox4.Controls.Add(btn839);
            groupBox4.Controls.Add(btnStandart);
            groupBox4.Controls.Add(btnMinus);
            groupBox4.Location = new Point(465, 316);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(307, 260);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Размер формы";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(205, 195);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(86, 57);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn939
            // 
            btn939.Location = new Point(3, 124);
            btn939.Margin = new Padding(3, 4, 3, 4);
            btn939.Name = "btn939";
            btn939.Size = new Size(287, 43);
            btn939.TabIndex = 5;
            btn939.Text = "939 X 564";
            btn939.UseVisualStyleBackColor = true;
            btn939.Click += btn939_Click;
            // 
            // btn839
            // 
            btn839.Location = new Point(3, 73);
            btn839.Margin = new Padding(3, 4, 3, 4);
            btn839.Name = "btn839";
            btn839.Size = new Size(287, 43);
            btn839.TabIndex = 4;
            btn839.Text = "839 X 464";
            btn839.UseVisualStyleBackColor = true;
            btn839.Click += btn839_Click;
            // 
            // btnStandart
            // 
            btnStandart.Location = new Point(3, 23);
            btnStandart.Margin = new Padding(3, 4, 3, 4);
            btnStandart.Name = "btnStandart";
            btnStandart.Size = new Size(287, 43);
            btnStandart.TabIndex = 3;
            btnStandart.Text = "Стандартный";
            btnStandart.UseVisualStyleBackColor = true;
            btnStandart.Click += btnStandart_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(10, 195);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(86, 57);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { ffdsToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(104, 28);
            // 
            // ffdsToolStripMenuItem
            // 
            ffdsToolStripMenuItem.Name = "ffdsToolStripMenuItem";
            ffdsToolStripMenuItem.Size = new Size(103, 24);
            ffdsToolStripMenuItem.Text = "ffds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 736);
            Controls.Add(grBox2);
            Controls.Add(grBox3);
            Controls.Add(groupBox4);
            Controls.Add(grBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBottomLeght).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTopLefht).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grBox2.ResumeLayout(false);
            grBox3.ResumeLayout(false);
            grBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grBox1;
        private GroupBox grBox2;
        private GroupBox grBox3;
        private GroupBox groupBox4;
        private PictureBox btnTopLefht;
        private PictureBox btnCenter;
        private PictureBox btnBottomLeght;
        private PictureBox btnTopRight;
        private PictureBox pictureBox3;
        private Button btnC;
        private Button btnB;
        private Button btnP;
        private Button btnPlus;
        private Button btn939;
        private Button btn839;
        private Button btnStandart;
        private Button btnMinus;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem ffdsToolStripMenuItem;
        private Label lblLocationPanel;
        private Label lblSolution;
        private TextBox txtLocationPanel;
        private TextBox txtSizeForm;
        private TextBox txtSizeWorkTable;
        private TextBox txtSolution;
        private Label lblSizeForm;
        private Label lblSizeWorkTable;
    }
}