namespace rasm_matn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xuiRadio1 = new XanderUI.XUIRadio();
            this.xuiRadio3 = new XanderUI.XUIRadio();
            this.xuiRadio2 = new XanderUI.XUIRadio();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pbimg = new System.Windows.Forms.PictureBox();
            this.zeroitLollipopFlatButton5 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton();
            this.zeroitLollipopFlatButton4 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zeroitLollipopFlatButton2 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zeroitLollipopFlatButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.xuiRadio1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.xuiRadio3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.xuiRadio2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(107, 29);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // xuiRadio1
            // 
            this.xuiRadio1.Checked = false;
            this.xuiRadio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiRadio1.ForeColor = System.Drawing.Color.White;
            this.xuiRadio1.Location = new System.Drawing.Point(73, 3);
            this.xuiRadio1.Name = "xuiRadio1";
            this.xuiRadio1.RadioColor = System.Drawing.Color.Lime;
            this.xuiRadio1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.xuiRadio1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio1.Size = new System.Drawing.Size(31, 23);
            this.xuiRadio1.TabIndex = 1;
            this.xuiRadio1.Click += new System.EventHandler(this.xuiRadio1_Click);
            // 
            // xuiRadio3
            // 
            this.xuiRadio3.Checked = false;
            this.xuiRadio3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiRadio3.ForeColor = System.Drawing.Color.White;
            this.xuiRadio3.Location = new System.Drawing.Point(38, 3);
            this.xuiRadio3.Name = "xuiRadio3";
            this.xuiRadio3.RadioColor = System.Drawing.Color.Yellow;
            this.xuiRadio3.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuiRadio3.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio3.Size = new System.Drawing.Size(29, 23);
            this.xuiRadio3.TabIndex = 4;
            this.xuiRadio3.Click += new System.EventHandler(this.xuiRadio3_Click);
            // 
            // xuiRadio2
            // 
            this.xuiRadio2.Checked = false;
            this.xuiRadio2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiRadio2.ForeColor = System.Drawing.Color.White;
            this.xuiRadio2.Location = new System.Drawing.Point(3, 3);
            this.xuiRadio2.Name = "xuiRadio2";
            this.xuiRadio2.RadioColor = System.Drawing.Color.Red;
            this.xuiRadio2.RadioHoverColor = System.Drawing.Color.Red;
            this.xuiRadio2.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio2.Size = new System.Drawing.Size(29, 23);
            this.xuiRadio2.TabIndex = 3;
            this.xuiRadio2.Click += new System.EventHandler(this.xuiRadio2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbimg, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 339);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(279, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(408, 333);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Yuklangan rasmdagi matn shu yerda ko\'rinadi";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pbimg
            // 
            this.pbimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbimg.Location = new System.Drawing.Point(3, 3);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(270, 333);
            this.pbimg.TabIndex = 1;
            this.pbimg.TabStop = false;
            // 
            // zeroitLollipopFlatButton5
            // 
            this.zeroitLollipopFlatButton5.AllowClickAnimation = true;
            this.zeroitLollipopFlatButton5.AllowTransparency = true;
            this.zeroitLollipopFlatButton5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopFlatButton5.BorderColor = System.Drawing.Color.Black;
            this.zeroitLollipopFlatButton5.BorderRadius = 1;
            this.zeroitLollipopFlatButton5.ClickMaxOffset = 10;
            this.zeroitLollipopFlatButton5.ClickOffset = 1;
            this.zeroitLollipopFlatButton5.ClickSpeed = 1;
            this.zeroitLollipopFlatButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitLollipopFlatButton5.Location = new System.Drawing.Point(306, 3);
            this.zeroitLollipopFlatButton5.Name = "zeroitLollipopFlatButton5";
            this.zeroitLollipopFlatButton5.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zeroitLollipopFlatButton5.RippleOpacity = 100;
            this.zeroitLollipopFlatButton5.Size = new System.Drawing.Size(96, 36);
            this.zeroitLollipopFlatButton5.TabIndex = 4;
            this.zeroitLollipopFlatButton5.Text = "Tozalash";
            this.zeroitLollipopFlatButton5.Visible = false;
            this.zeroitLollipopFlatButton5.Click += new System.EventHandler(this.zeroitLollipopFlatButton5_Click);
            // 
            // zeroitLollipopFlatButton4
            // 
            this.zeroitLollipopFlatButton4.AllowClickAnimation = true;
            this.zeroitLollipopFlatButton4.AllowTransparency = true;
            this.zeroitLollipopFlatButton4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopFlatButton4.BorderColor = System.Drawing.Color.Black;
            this.zeroitLollipopFlatButton4.BorderRadius = 1;
            this.zeroitLollipopFlatButton4.ClickMaxOffset = 10;
            this.zeroitLollipopFlatButton4.ClickOffset = 1;
            this.zeroitLollipopFlatButton4.ClickSpeed = 1;
            this.zeroitLollipopFlatButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitLollipopFlatButton4.Location = new System.Drawing.Point(205, 3);
            this.zeroitLollipopFlatButton4.Name = "zeroitLollipopFlatButton4";
            this.zeroitLollipopFlatButton4.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zeroitLollipopFlatButton4.RippleOpacity = 100;
            this.zeroitLollipopFlatButton4.Size = new System.Drawing.Size(95, 36);
            this.zeroitLollipopFlatButton4.TabIndex = 3;
            this.zeroitLollipopFlatButton4.Text = "Nusxa olish";
            this.zeroitLollipopFlatButton4.Visible = false;
            this.zeroitLollipopFlatButton4.Click += new System.EventHandler(this.zeroitLollipopFlatButton4_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.zeroitLollipopFlatButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.zeroitLollipopFlatButton5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.zeroitLollipopFlatButton4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.zeroitLollipopFlatButton2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 42);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // zeroitLollipopFlatButton2
            // 
            this.zeroitLollipopFlatButton2.AllowClickAnimation = true;
            this.zeroitLollipopFlatButton2.AllowTransparency = true;
            this.zeroitLollipopFlatButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopFlatButton2.BorderColor = System.Drawing.Color.Black;
            this.zeroitLollipopFlatButton2.BorderRadius = 1;
            this.zeroitLollipopFlatButton2.ClickMaxOffset = 10;
            this.zeroitLollipopFlatButton2.ClickOffset = 1;
            this.zeroitLollipopFlatButton2.ClickSpeed = 1;
            this.zeroitLollipopFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitLollipopFlatButton2.Location = new System.Drawing.Point(104, 3);
            this.zeroitLollipopFlatButton2.Name = "zeroitLollipopFlatButton2";
            this.zeroitLollipopFlatButton2.RippleColor = System.Drawing.Color.Green;
            this.zeroitLollipopFlatButton2.RippleOpacity = 100;
            this.zeroitLollipopFlatButton2.Size = new System.Drawing.Size(95, 36);
            this.zeroitLollipopFlatButton2.TabIndex = 1;
            this.zeroitLollipopFlatButton2.Text = "Rasm yuklash";
            this.zeroitLollipopFlatButton2.Click += new System.EventHandler(this.zeroitLollipopFlatButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 42);
            this.panel2.TabIndex = 2;
            // 
            // zeroitLollipopFlatButton1
            // 
            this.zeroitLollipopFlatButton1.AllowClickAnimation = true;
            this.zeroitLollipopFlatButton1.AllowTransparency = true;
            this.zeroitLollipopFlatButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopFlatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zeroitLollipopFlatButton1.BackgroundImage")));
            this.zeroitLollipopFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zeroitLollipopFlatButton1.BorderColor = System.Drawing.Color.Black;
            this.zeroitLollipopFlatButton1.BorderRadius = 1;
            this.zeroitLollipopFlatButton1.ClickMaxOffset = 10;
            this.zeroitLollipopFlatButton1.ClickOffset = 1;
            this.zeroitLollipopFlatButton1.ClickSpeed = 1;
            this.zeroitLollipopFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitLollipopFlatButton1.Location = new System.Drawing.Point(3, 3);
            this.zeroitLollipopFlatButton1.Name = "zeroitLollipopFlatButton1";
            this.zeroitLollipopFlatButton1.RippleColor = System.Drawing.Color.Red;
            this.zeroitLollipopFlatButton1.RippleOpacity = 100;
            this.zeroitLollipopFlatButton1.Size = new System.Drawing.Size(95, 36);
            this.zeroitLollipopFlatButton1.TabIndex = 5;
            this.zeroitLollipopFlatButton1.Click += new System.EventHandler(this.zeroitLollipopFlatButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(690, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIRadio xuiRadio1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XanderUI.XUIRadio xuiRadio3;
        private XanderUI.XUIRadio xuiRadio2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pbimg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton zeroitLollipopFlatButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton zeroitLollipopFlatButton5;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton zeroitLollipopFlatButton4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopFlatButton zeroitLollipopFlatButton1;
    }
}

