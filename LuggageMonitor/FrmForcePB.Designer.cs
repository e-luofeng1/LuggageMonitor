namespace LuggageMonitor
{
    partial class FrmForcePB
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
            this.btnF1C = new CCWin.SkinControl.SkinButton();
            this.btnF2 = new CCWin.SkinControl.SkinButton();
            this.btnF3 = new CCWin.SkinControl.SkinButton();
            this.btnF4 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnF1C
            // 
            this.btnF1C.BackColor = System.Drawing.Color.Transparent;
            this.btnF1C.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnF1C.DownBack = null;
            this.btnF1C.Enabled = false;
            this.btnF1C.Location = new System.Drawing.Point(36, 52);
            this.btnF1C.MouseBack = null;
            this.btnF1C.Name = "btnF1C";
            this.btnF1C.NormlBack = null;
            this.btnF1C.Size = new System.Drawing.Size(156, 53);
            this.btnF1C.TabIndex = 0;
            this.btnF1C.Text = "传感器#1屏蔽";
            this.btnF1C.UseVisualStyleBackColor = false;
            this.btnF1C.Click += new System.EventHandler(this.btnF1C_Click);
            // 
            // btnF2
            // 
            this.btnF2.BackColor = System.Drawing.Color.Transparent;
            this.btnF2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnF2.DownBack = null;
            this.btnF2.Enabled = false;
            this.btnF2.Location = new System.Drawing.Point(253, 52);
            this.btnF2.MouseBack = null;
            this.btnF2.Name = "btnF2";
            this.btnF2.NormlBack = null;
            this.btnF2.Size = new System.Drawing.Size(156, 53);
            this.btnF2.TabIndex = 1;
            this.btnF2.Text = "传感器#2屏蔽";
            this.btnF2.UseVisualStyleBackColor = false;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF3
            // 
            this.btnF3.BackColor = System.Drawing.Color.Transparent;
            this.btnF3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnF3.DownBack = null;
            this.btnF3.Enabled = false;
            this.btnF3.Location = new System.Drawing.Point(36, 131);
            this.btnF3.MouseBack = null;
            this.btnF3.Name = "btnF3";
            this.btnF3.NormlBack = null;
            this.btnF3.Size = new System.Drawing.Size(156, 53);
            this.btnF3.TabIndex = 2;
            this.btnF3.Text = "传感器#3屏蔽";
            this.btnF3.UseVisualStyleBackColor = false;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF4
            // 
            this.btnF4.BackColor = System.Drawing.Color.Transparent;
            this.btnF4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnF4.DownBack = null;
            this.btnF4.Enabled = false;
            this.btnF4.Location = new System.Drawing.Point(253, 131);
            this.btnF4.MouseBack = null;
            this.btnF4.Name = "btnF4";
            this.btnF4.NormlBack = null;
            this.btnF4.Size = new System.Drawing.Size(156, 53);
            this.btnF4.TabIndex = 3;
            this.btnF4.Text = "传感器#4屏蔽";
            this.btnF4.UseVisualStyleBackColor = false;
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // FrmForcePB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 228);
            this.Controls.Add(this.btnF4);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnF1C);
            this.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForcePB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "前行李箱信号屏蔽";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmForcePB_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnF1C;
        private CCWin.SkinControl.SkinButton btnF2;
        private CCWin.SkinControl.SkinButton btnF3;
        private CCWin.SkinControl.SkinButton btnF4;
    }
}