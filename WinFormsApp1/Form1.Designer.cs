namespace WinFormsApp1
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
            namelbl = new Label();
            addresslbl = new Label();
            nametxt = new TextBox();
            addresstxt = new TextBox();
            button1 = new Button();
            citylbl = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            femaleradio = new RadioButton();
            maleradio = new RadioButton();
            sharinglbl = new Label();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.Location = new Point(80, 56);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(73, 28);
            namelbl.TabIndex = 0;
            namelbl.Text = "Name:";
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addresslbl.Location = new Point(80, 131);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(92, 28);
            addresslbl.TabIndex = 1;
            addresslbl.Text = "Address:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(173, 60);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(297, 27);
            nametxt.TabIndex = 2;
            // 
            // addresstxt
            // 
            addresstxt.Location = new Point(173, 135);
            addresstxt.Multiline = true;
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(297, 59);
            addresstxt.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(173, 470);
            button1.Name = "button1";
            button1.Size = new Size(174, 49);
            button1.TabIndex = 4;
            button1.Text = "Register Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // citylbl
            // 
            citylbl.AutoSize = true;
            citylbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            citylbl.Location = new Point(80, 232);
            citylbl.Name = "citylbl";
            citylbl.Size = new Size(54, 28);
            citylbl.TabIndex = 5;
            citylbl.Text = "City:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select City", "Pune", "Akurdi", "Buldhana", "Motala", "Malkapur", "Advihir" });
            comboBox1.Location = new Point(173, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 28);
            comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(femaleradio);
            groupBox1.Controls.Add(maleradio);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 85);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // femaleradio
            // 
            femaleradio.AutoSize = true;
            femaleradio.Location = new Point(243, 33);
            femaleradio.Name = "femaleradio";
            femaleradio.Size = new Size(100, 32);
            femaleradio.TabIndex = 1;
            femaleradio.TabStop = true;
            femaleradio.Text = "Female";
            femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            maleradio.AutoSize = true;
            maleradio.Location = new Point(62, 33);
            maleradio.Name = "maleradio";
            maleradio.Size = new Size(80, 32);
            maleradio.TabIndex = 0;
            maleradio.TabStop = true;
            maleradio.Text = "Male";
            maleradio.UseVisualStyleBackColor = true;
            // 
            // sharinglbl
            // 
            sharinglbl.AutoSize = true;
            sharinglbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sharinglbl.Location = new Point(69, 410);
            sharinglbl.Name = "sharinglbl";
            sharinglbl.Size = new Size(84, 28);
            sharinglbl.TabIndex = 8;
            sharinglbl.Text = "Sharing";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(173, 421);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(897, 567);
            Controls.Add(checkBox1);
            Controls.Add(sharinglbl);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(citylbl);
            Controls.Add(button1);
            Controls.Add(addresstxt);
            Controls.Add(nametxt);
            Controls.Add(addresslbl);
            Controls.Add(namelbl);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            Click += LoginFrom;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelbl;
        private Label addresslbl;
        private TextBox nametxt;
        private TextBox addresstxt;
        private Button button1;
        private Label citylbl;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton femaleradio;
        private RadioButton maleradio;
        private Label sharinglbl;
        private CheckBox checkBox1;
    }
}
