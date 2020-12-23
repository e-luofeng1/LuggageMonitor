namespace LuggageMonitor
{
    partial class PwdInput
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
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.lblPlesaseInptPwd = new CCWin.SkinControl.SkinLabel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtInpteSign = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.DownBack = null;
            this.txtPwd.Icon = null;
            this.txtPwd.IconIsButton = false;
            this.txtPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.IsPasswordChat = '\0';
            this.txtPwd.IsSystemPasswordChar = false;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(71, 84);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MinimumSize = new System.Drawing.Size(32, 30);
            this.txtPwd.MouseBack = null;
            this.txtPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = null;
            this.txtPwd.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPwd.ReadOnly = false;
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.Size = new System.Drawing.Size(282, 30);
            // 
            // 
            // 
            this.txtPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtPwd.SkinTxt.Location = new System.Drawing.Point(6, 5);
            this.txtPwd.SkinTxt.Multiline = true;
            this.txtPwd.SkinTxt.Name = "BaseText";
            this.txtPwd.SkinTxt.Size = new System.Drawing.Size(270, 20);
            this.txtPwd.SkinTxt.TabIndex = 0;
            this.txtPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.SkinTxt.WaterText = "";
            this.txtPwd.TabIndex = 0;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "";
            this.txtPwd.WordWrap = true;
            // 
            // lblPlesaseInptPwd
            // 
            this.lblPlesaseInptPwd.AutoSize = true;
            this.lblPlesaseInptPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPlesaseInptPwd.BorderColor = System.Drawing.Color.White;
            this.lblPlesaseInptPwd.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlesaseInptPwd.Location = new System.Drawing.Point(37, 48);
            this.lblPlesaseInptPwd.Name = "lblPlesaseInptPwd";
            this.lblPlesaseInptPwd.Size = new System.Drawing.Size(143, 16);
            this.lblPlesaseInptPwd.TabIndex = 1;
            this.lblPlesaseInptPwd.Text = "请输入管理员密码：";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(255, 148);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 38);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtInpteSign
            // 
            this.txtInpteSign.AutoSize = true;
            this.txtInpteSign.BackColor = System.Drawing.Color.Transparent;
            this.txtInpteSign.BorderColor = System.Drawing.Color.White;
            this.txtInpteSign.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInpteSign.ForeColor = System.Drawing.Color.Red;
            this.txtInpteSign.Location = new System.Drawing.Point(71, 118);
            this.txtInpteSign.Name = "txtInpteSign";
            this.txtInpteSign.Size = new System.Drawing.Size(21, 20);
            this.txtInpteSign.TabIndex = 3;
            this.txtInpteSign.Text = "...";
            // 
            // PwdInput
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 194);
            this.ControlBox = false;
            this.Controls.Add(this.txtInpteSign);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPlesaseInptPwd);
            this.Controls.Add(this.txtPwd);
            this.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PwdInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox txtPwd;
        private CCWin.SkinControl.SkinLabel lblPlesaseInptPwd;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinLabel txtInpteSign;
    }
}