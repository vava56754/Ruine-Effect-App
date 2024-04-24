namespace RuneEffect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rune1 = new PictureBox();
            rune2 = new PictureBox();
            rune3 = new PictureBox();
            rune4 = new PictureBox();
            rune5 = new PictureBox();
            rune6 = new PictureBox();
            enter = new Button();
            back = new Button();
            plus = new Label();
            egale = new Label();
            pictureBoxInput1 = new PictureBox();
            pictureBoxInput2 = new PictureBox();
            result = new TextBox();
            listViewStock = new ListView();
            listViewStock1 = new ListView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)rune1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rune2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rune3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rune4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rune5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rune6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput2).BeginInit();
            SuspendLayout();
            // 
            // rune1
            // 
            rune1.Image = (Image)resources.GetObject("rune1.Image");
            rune1.Location = new Point(37, 364);
            rune1.Name = "rune1";
            rune1.Size = new Size(100, 100);
            rune1.TabIndex = 0;
            rune1.TabStop = false;
            rune1.Click += rune1_Click;
            // 
            // rune2
            // 
            rune2.Image = (Image)resources.GetObject("rune2.Image");
            rune2.Location = new Point(143, 364);
            rune2.Name = "rune2";
            rune2.Size = new Size(100, 100);
            rune2.TabIndex = 1;
            rune2.TabStop = false;
            rune2.Click += rune2_Click;
            // 
            // rune3
            // 
            rune3.Image = (Image)resources.GetObject("rune3.Image");
            rune3.Location = new Point(249, 364);
            rune3.Name = "rune3";
            rune3.Size = new Size(100, 100);
            rune3.TabIndex = 2;
            rune3.TabStop = false;
            rune3.Click += rune3_Click;
            // 
            // rune4
            // 
            rune4.Image = (Image)resources.GetObject("rune4.Image");
            rune4.Location = new Point(37, 470);
            rune4.Name = "rune4";
            rune4.Size = new Size(100, 100);
            rune4.TabIndex = 3;
            rune4.TabStop = false;
            rune4.Click += rune4_Click;
            // 
            // rune5
            // 
            rune5.Image = (Image)resources.GetObject("rune5.Image");
            rune5.Location = new Point(143, 470);
            rune5.Name = "rune5";
            rune5.Size = new Size(100, 100);
            rune5.TabIndex = 4;
            rune5.TabStop = false;
            rune5.Click += rune5_Click;
            // 
            // rune6
            // 
            rune6.Image = (Image)resources.GetObject("rune6.Image");
            rune6.Location = new Point(249, 470);
            rune6.Name = "rune6";
            rune6.Size = new Size(100, 100);
            rune6.TabIndex = 5;
            rune6.TabStop = false;
            rune6.Click += rune6_Click;
            // 
            // enter
            // 
            enter.Location = new Point(355, 364);
            enter.Name = "enter";
            enter.Size = new Size(140, 100);
            enter.TabIndex = 6;
            enter.Text = "Enter";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // back
            // 
            back.Location = new Point(355, 470);
            back.Name = "back";
            back.Size = new Size(140, 100);
            back.TabIndex = 7;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // plus
            // 
            plus.AutoSize = true;
            plus.BackColor = Color.Transparent;
            plus.Font = new Font("Segoe UI", 40F);
            plus.ForeColor = SystemColors.ButtonHighlight;
            plus.Location = new Point(143, 202);
            plus.Name = "plus";
            plus.Size = new Size(67, 72);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // egale
            // 
            egale.AutoSize = true;
            egale.BackColor = Color.Transparent;
            egale.Font = new Font("Segoe UI", 40F);
            egale.ForeColor = SystemColors.ButtonHighlight;
            egale.Location = new Point(322, 203);
            egale.Name = "egale";
            egale.Size = new Size(67, 72);
            egale.TabIndex = 11;
            egale.Text = "=";
            // 
            // pictureBoxInput1
            // 
            pictureBoxInput1.BackColor = Color.DarkSlateBlue;
            pictureBoxInput1.Location = new Point(37, 191);
            pictureBoxInput1.Name = "pictureBoxInput1";
            pictureBoxInput1.Size = new Size(100, 100);
            pictureBoxInput1.TabIndex = 12;
            pictureBoxInput1.TabStop = false;
            pictureBoxInput1.Click += pictureBoxInput1_Click;
            // 
            // pictureBoxInput2
            // 
            pictureBoxInput2.BackColor = Color.DarkSlateBlue;
            pictureBoxInput2.Location = new Point(216, 191);
            pictureBoxInput2.Name = "pictureBoxInput2";
            pictureBoxInput2.Size = new Size(100, 100);
            pictureBoxInput2.TabIndex = 13;
            pictureBoxInput2.TabStop = false;
            pictureBoxInput2.Click += pictureBoxInput2_Click;
            // 
            // result
            // 
            result.BackColor = Color.DarkSlateBlue;
            result.Font = new Font("Segoe UI", 52F);
            result.ForeColor = SystemColors.ButtonHighlight;
            result.Location = new Point(395, 191);
            result.Name = "result";
            result.Size = new Size(100, 100);
            result.TabIndex = 14;
            result.TextAlign = HorizontalAlignment.Center;
            result.TextChanged += result_TextChanged;
            // 
            // listViewStock
            // 
            listViewStock.BackColor = Color.DarkSlateBlue;
            listViewStock.ForeColor = SystemColors.ButtonHighlight;
            listViewStock.Location = new Point(555, 191);
            listViewStock.Name = "listViewStock";
            listViewStock.Size = new Size(134, 379);
            listViewStock.TabIndex = 15;
            listViewStock.UseCompatibleStateImageBehavior = false;
            listViewStock.View = View.Details;
            listViewStock.SelectedIndexChanged += listViewStock_SelectedIndexChanged;
            // 
            // listViewStock1
            // 
            listViewStock1.BackColor = Color.DarkSlateBlue;
            listViewStock1.ForeColor = SystemColors.ButtonHighlight;
            listViewStock1.Location = new Point(626, 191);
            listViewStock1.Name = "listViewStock1";
            listViewStock1.Size = new Size(136, 379);
            listViewStock1.TabIndex = 16;
            listViewStock1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 45F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(763, 94);
            label1.TabIndex = 17;
            label1.Text = "RUNE EFFECT APP";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(850, 669);
            Controls.Add(label1);
            Controls.Add(listViewStock1);
            Controls.Add(listViewStock);
            Controls.Add(result);
            Controls.Add(pictureBoxInput2);
            Controls.Add(pictureBoxInput1);
            Controls.Add(egale);
            Controls.Add(plus);
            Controls.Add(back);
            Controls.Add(enter);
            Controls.Add(rune6);
            Controls.Add(rune5);
            Controls.Add(rune4);
            Controls.Add(rune3);
            Controls.Add(rune2);
            Controls.Add(rune1);
            Name = "Form1";
            Text = "RuneApp";
            ((System.ComponentModel.ISupportInitialize)rune1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rune2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rune3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rune4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rune5).EndInit();
            ((System.ComponentModel.ISupportInitialize)rune6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInput2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox rune1;
        private PictureBox rune2;
        private PictureBox rune3;
        private PictureBox rune4;
        private PictureBox rune5;
        private PictureBox rune6;
        private Button enter;
        private Button back;
        private Label plus;
        private Label egale;
        private PictureBox pictureBoxInput1;
        private PictureBox pictureBoxInput2;
        private TextBox result;
        private ListView listViewStock;
        private ListView listViewStock1;
        private Label label1;
    }
}
