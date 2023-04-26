namespace _1
{
    partial class formClasses
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
            NameBox1 = new TextBox();
            AmountBox1 = new TextBox();
            ResultBox = new TextBox();
            MedalBox1 = new TextBox();
            groupBox1 = new GroupBox();
            MedalBox3 = new TextBox();
            AmountBox3 = new TextBox();
            NameBox3 = new TextBox();
            MedalBox2 = new TextBox();
            AmountBox2 = new TextBox();
            NameBox2 = new TextBox();
            StartButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NameBox1
            // 
            NameBox1.Location = new Point(126, 80);
            NameBox1.Name = "NameBox1";
            NameBox1.Size = new Size(89, 34);
            NameBox1.TabIndex = 21;
            // 
            // AmountBox1
            // 
            AmountBox1.Location = new Point(126, 143);
            AmountBox1.Name = "AmountBox1";
            AmountBox1.Size = new Size(89, 34);
            AmountBox1.TabIndex = 20;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(460, 33);
            ResultBox.Margin = new Padding(4);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(618, 302);
            ResultBox.TabIndex = 2;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // MedalBox1
            // 
            MedalBox1.Location = new Point(126, 200);
            MedalBox1.Name = "MedalBox1";
            MedalBox1.Size = new Size(89, 34);
            MedalBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MedalBox3);
            groupBox1.Controls.Add(AmountBox3);
            groupBox1.Controls.Add(NameBox3);
            groupBox1.Controls.Add(MedalBox2);
            groupBox1.Controls.Add(AmountBox2);
            groupBox1.Controls.Add(NameBox2);
            groupBox1.Controls.Add(StartButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MedalBox1);
            groupBox1.Controls.Add(AmountBox1);
            groupBox1.Controls.Add(NameBox1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(439, 322);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // MedalBox3
            // 
            MedalBox3.Location = new Point(317, 200);
            MedalBox3.Name = "MedalBox3";
            MedalBox3.Size = new Size(89, 34);
            MedalBox3.TabIndex = 25;
            // 
            // AmountBox3
            // 
            AmountBox3.Location = new Point(317, 143);
            AmountBox3.Name = "AmountBox3";
            AmountBox3.Size = new Size(89, 34);
            AmountBox3.TabIndex = 26;
            // 
            // NameBox3
            // 
            NameBox3.Location = new Point(317, 80);
            NameBox3.Name = "NameBox3";
            NameBox3.Size = new Size(89, 34);
            NameBox3.TabIndex = 27;
            // 
            // MedalBox2
            // 
            MedalBox2.Location = new Point(222, 200);
            MedalBox2.Name = "MedalBox2";
            MedalBox2.Size = new Size(89, 34);
            MedalBox2.TabIndex = 22;
            // 
            // AmountBox2
            // 
            AmountBox2.Location = new Point(222, 143);
            AmountBox2.Name = "AmountBox2";
            AmountBox2.Size = new Size(89, 34);
            AmountBox2.TabIndex = 23;
            // 
            // NameBox2
            // 
            NameBox2.Location = new Point(222, 80);
            NameBox2.Name = "NameBox2";
            NameBox2.Size = new Size(89, 34);
            NameBox2.TabIndex = 24;
            NameBox2.TextChanged += textBox3_TextChanged;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(223, 269);
            StartButton.Margin = new Padding(4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(183, 50);
            StartButton.TabIndex = 5;
            StartButton.Text = "Додати";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 203);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 6;
            label3.Text = "Медалі";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 5;
            label2.Text = "Спортсмени";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 4;
            label1.Text = "Kраїна";
            // 
            // formClasses
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 372);
            Controls.Add(groupBox1);
            Controls.Add(ResultBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "formClasses";
            Text = "Перелік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox1;
        private TextBox AmountBox1;
        private TextBox ResultBox;
        private TextBox MedalBox1;
        private GroupBox groupBox1;
        private Button StartButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox MedalBox3;
        private TextBox AmountBox3;
        private TextBox NameBox3;
        private TextBox MedalBox2;
        private TextBox AmountBox2;
        private TextBox NameBox2;
    }
}