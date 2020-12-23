namespace LuggageMonitor
{
    partial class frmMain
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnFore = new CCWin.SkinControl.SkinButton();
            this.btnReal = new CCWin.SkinControl.SkinButton();
            this.btnSelect = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文细黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinLabel1.Location = new System.Drawing.Point(477, 215);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(174, 50);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "欢迎使用";
            // 
            // btnFore
            // 
            this.btnFore.BackColor = System.Drawing.Color.Transparent;
            this.btnFore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFore.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFore.DownBack = null;
            this.btnFore.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFore.Image = global::LuggageMonitor.Properties.Resources.F1;
            this.btnFore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFore.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFore.Location = new System.Drawing.Point(52, 11);
            this.btnFore.MouseBack = null;
            this.btnFore.Name = "btnFore";
            this.btnFore.NormlBack = null;
            this.btnFore.Size = new System.Drawing.Size(140, 60);
            this.btnFore.TabIndex = 0;
            this.btnFore.Text = "前行李箱工装";
            this.btnFore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFore.UseVisualStyleBackColor = false;
            this.btnFore.Click += new System.EventHandler(this.btnFore_Click);
            // 
            // btnReal
            // 
            this.btnReal.BackColor = System.Drawing.Color.Transparent;
            this.btnReal.BackgroundImage = global::LuggageMonitor.Properties.Resources.R1;
            this.btnReal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReal.DownBack = null;
            this.btnReal.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReal.Image = global::LuggageMonitor.Properties.Resources.R1;
            this.btnReal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReal.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReal.Location = new System.Drawing.Point(226, 11);
            this.btnReal.MouseBack = null;
            this.btnReal.Name = "btnReal";
            this.btnReal.NormlBack = null;
            this.btnReal.Size = new System.Drawing.Size(142, 60);
            this.btnReal.TabIndex = 1;
            this.btnReal.Text = "后行李箱工装";
            this.btnReal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReal.UseVisualStyleBackColor = false;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelect.DownBack = null;
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Image = global::LuggageMonitor.Properties.Resources.S1;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelect.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSelect.Location = new System.Drawing.Point(412, 11);
            this.btnSelect.MouseBack = null;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NormlBack = null;
            this.btnSelect.Size = new System.Drawing.Size(147, 60);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "数据查询";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel1.Controls.Add(this.btnSelect);
            this.skinPanel1.Controls.Add(this.btnReal);
            this.skinPanel1.Controls.Add(this.btnFore);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(7, 524);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1049, 80);
            this.skinPanel1.TabIndex = 4;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::LuggageMonitor.Properties.Resources.BJ;
            this.skinPictureBox1.Location = new System.Drawing.Point(7, 31);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(1049, 487);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 1;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Click += new System.EventHandler(this.skinPictureBox1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("华文细黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel2.Location = new System.Drawing.Point(300, 286);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(560, 50);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "特斯拉MODE Y行李箱工装系统";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 611);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinPictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用MODE Y 行李箱工装系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnFore;
        private CCWin.SkinControl.SkinButton btnReal;
        private CCWin.SkinControl.SkinButton btnSelect;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}