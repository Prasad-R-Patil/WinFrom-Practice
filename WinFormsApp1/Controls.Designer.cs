namespace WinFormsApp1
{
    partial class Controls
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            namelbl = new Label();
            nametxt = new TextBox();
            submtbtn = new Button();
            resultlbl = new Label();
            ContrylistBox = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timelbl = new Label();
            pictureBox1 = new PictureBox();
            infolbl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.Location = new Point(44, 66);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(55, 20);
            namelbl.TabIndex = 0;
            namelbl.Text = "Name:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(117, 68);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(308, 27);
            nametxt.TabIndex = 1;
            // 
            // submtbtn
            // 
            submtbtn.AutoSize = true;
            submtbtn.BackColor = Color.LawnGreen;
            submtbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submtbtn.Location = new Point(318, 140);
            submtbtn.Name = "submtbtn";
            submtbtn.Size = new Size(94, 38);
            submtbtn.TabIndex = 2;
            submtbtn.Text = "Submit";
            submtbtn.UseVisualStyleBackColor = false;
            submtbtn.Click += submtbtn_Click;
            // 
            // resultlbl
            // 
            resultlbl.AutoSize = true;
            resultlbl.BackColor = SystemColors.ActiveCaption;
            resultlbl.Location = new Point(171, 260);
            resultlbl.Name = "resultlbl";
            resultlbl.Size = new Size(46, 20);
            resultlbl.TabIndex = 3;
            resultlbl.Text = "helllo";
            // 
            // ContrylistBox
            // 
            ContrylistBox.FormattingEnabled = true;
            ContrylistBox.Items.AddRange(new object[] { "india", "Select your Country", "UK", "USA" });
            ContrylistBox.Location = new Point(140, 140);
            ContrylistBox.Name = "ContrylistBox";
            ContrylistBox.Size = new Size(150, 104);
            ContrylistBox.Sorted = true;
            ContrylistBox.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Location = new Point(117, 104);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(39, 20);
            timelbl.TabIndex = 5;
            timelbl.Text = "time";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // infolbl
            // 
            infolbl.AutoSize = true;
            infolbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infolbl.Location = new Point(375, 392);
            infolbl.Name = "infolbl";
            infolbl.Size = new Size(118, 24);
            infolbl.TabIndex = 7;
            infolbl.TabStop = true;
            infolbl.Text = "Information";
            infolbl.LinkClicked += Goglelbl_LinkClicked;
            // 
            // Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 671);
            Controls.Add(infolbl);
            Controls.Add(pictureBox1);
            Controls.Add(timelbl);
            Controls.Add(ContrylistBox);
            Controls.Add(resultlbl);
            Controls.Add(submtbtn);
            Controls.Add(nametxt);
            Controls.Add(namelbl);
            Name = "Controls";
            Text = "hello";
            Load += Controls_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelbl;
        private TextBox nametxt;
        private Button submtbtn;
        private Label resultlbl;
        private ListBox ContrylistBox;
        private System.Windows.Forms.Timer timer1;
        private Label timelbl;
        private PictureBox pictureBox1;
        private LinkLabel infolbl;
    }
}