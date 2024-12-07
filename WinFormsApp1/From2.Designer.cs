namespace WinFormsApp1
{
    partial class From2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Addresstxt = new TextBox();
            Nametxt = new TextBox();
            Addresslbl = new Label();
            Namelbl = new Label();
            tabPage2 = new TabPage();
            OFCtxt = new TextBox();
            OCNlbl = new Label();
            tabPage3 = new TabPage();
            winformbox = new CheckBox();
            Csharpbox = new CheckBox();
            javabox = new CheckBox();
            cppbox = new CheckBox();
            cbox = new CheckBox();
            KTlbl = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(29, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(595, 631);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Addresstxt);
            tabPage1.Controls.Add(Nametxt);
            tabPage1.Controls.Add(Addresslbl);
            tabPage1.Controls.Add(Namelbl);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(587, 598);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Informatio";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(146, 101);
            Addresstxt.Multiline = true;
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(155, 55);
            Addresstxt.TabIndex = 3;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(146, 62);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(158, 27);
            Nametxt.TabIndex = 2;
            // 
            // Addresslbl
            // 
            Addresslbl.AutoSize = true;
            Addresslbl.Location = new Point(57, 101);
            Addresslbl.Name = "Addresslbl";
            Addresslbl.Size = new Size(65, 20);
            Addresslbl.TabIndex = 1;
            Addresslbl.Text = "Address:";
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Location = new Point(55, 65);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(52, 20);
            Namelbl.TabIndex = 0;
            Namelbl.Text = "Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(OFCtxt);
            tabPage2.Controls.Add(OCNlbl);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(587, 598);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Official Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // OFCtxt
            // 
            OFCtxt.Location = new Point(202, 60);
            OFCtxt.Name = "OFCtxt";
            OFCtxt.Size = new Size(202, 27);
            OFCtxt.TabIndex = 1;
            // 
            // OCNlbl
            // 
            OCNlbl.AutoSize = true;
            OCNlbl.Location = new Point(43, 63);
            OCNlbl.Name = "OCNlbl";
            OCNlbl.Size = new Size(134, 20);
            OCNlbl.TabIndex = 0;
            OCNlbl.Text = "Office Concate No:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(winformbox);
            tabPage3.Controls.Add(Csharpbox);
            tabPage3.Controls.Add(javabox);
            tabPage3.Controls.Add(cppbox);
            tabPage3.Controls.Add(cbox);
            tabPage3.Controls.Add(KTlbl);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(587, 598);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Technology Skill";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // winformbox
            // 
            winformbox.AutoSize = true;
            winformbox.Location = new Point(193, 221);
            winformbox.Name = "winformbox";
            winformbox.Size = new Size(95, 24);
            winformbox.TabIndex = 5;
            winformbox.Text = "Winforms";
            winformbox.UseVisualStyleBackColor = true;
            // 
            // Csharpbox
            // 
            Csharpbox.AutoSize = true;
            Csharpbox.Location = new Point(193, 191);
            Csharpbox.Name = "Csharpbox";
            Csharpbox.Size = new Size(92, 24);
            Csharpbox.TabIndex = 4;
            Csharpbox.Text = "C - Sharp";
            Csharpbox.UseVisualStyleBackColor = true;
            // 
            // javabox
            // 
            javabox.AutoSize = true;
            javabox.Location = new Point(193, 163);
            javabox.Name = "javabox";
            javabox.Size = new Size(59, 24);
            javabox.TabIndex = 3;
            javabox.Text = "Java";
            javabox.UseVisualStyleBackColor = true;
            // 
            // cppbox
            // 
            cppbox.AutoSize = true;
            cppbox.Location = new Point(193, 132);
            cppbox.Name = "cppbox";
            cppbox.Size = new Size(60, 24);
            cppbox.TabIndex = 2;
            cppbox.Text = "C++";
            cppbox.UseVisualStyleBackColor = true;
            // 
            // cbox
            // 
            cbox.AutoSize = true;
            cbox.Location = new Point(193, 102);
            cbox.Name = "cbox";
            cbox.Size = new Size(145, 24);
            cbox.TabIndex = 1;
            cbox.Text = "C - Programming";
            cbox.UseVisualStyleBackColor = true;
            // 
            // KTlbl
            // 
            KTlbl.AutoSize = true;
            KTlbl.Location = new Point(50, 72);
            KTlbl.Name = "KTlbl";
            KTlbl.Size = new Size(129, 20);
            KTlbl.TabIndex = 0;
            KTlbl.Text = "Know Technology:";
            // 
            // From2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 719);
            Controls.Add(tabControl1);
            Name = "From2";
            Text = "From2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox Addresstxt;
        private TextBox Nametxt;
        private Label Addresslbl;
        private Label Namelbl;
        private Label OCNlbl;
        private TextBox OFCtxt;
        private CheckBox winformbox;
        private CheckBox Csharpbox;
        private CheckBox javabox;
        private CheckBox cppbox;
        private CheckBox cbox;
        private Label KTlbl;
    }
}