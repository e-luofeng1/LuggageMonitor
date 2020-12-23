namespace LuggageMonitor
{
    partial class ForceSignMonitor
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
            this.pnlSignMonitor = new CCWin.SkinControl.SkinCaptionPanel();
            this.btnCloseLight = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblComPressionFault = new CCWin.SkinControl.SkinLabel();
            this.btnOpenLight = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblloosenFault = new CCWin.SkinControl.SkinLabel();
            this.btnAlarm = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblPowerSwitch = new CCWin.SkinControl.SkinLabel();
            this.btnPanel_PowerOnOff = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.btnGas_OK = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.btnScreen_OK = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.btnEmergency_OK = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblWarn = new CCWin.SkinControl.SkinLabel();
            this.lblAirPressure = new CCWin.SkinControl.SkinLabel();
            this.lblScreem = new CCWin.SkinControl.SkinLabel();
            this.lblQuickStop = new CCWin.SkinControl.SkinLabel();
            this.lblAuto = new CCWin.SkinControl.SkinLabel();
            this.btnAuto = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.pnlSignMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignMonitor
            // 
            this.pnlSignMonitor.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.pnlSignMonitor.Controls.Add(this.btnCloseLight);
            this.pnlSignMonitor.Controls.Add(this.lblComPressionFault);
            this.pnlSignMonitor.Controls.Add(this.btnOpenLight);
            this.pnlSignMonitor.Controls.Add(this.lblloosenFault);
            this.pnlSignMonitor.Controls.Add(this.btnAlarm);
            this.pnlSignMonitor.Controls.Add(this.lblPowerSwitch);
            this.pnlSignMonitor.Controls.Add(this.btnPanel_PowerOnOff);
            this.pnlSignMonitor.Controls.Add(this.btnGas_OK);
            this.pnlSignMonitor.Controls.Add(this.btnScreen_OK);
            this.pnlSignMonitor.Controls.Add(this.btnEmergency_OK);
            this.pnlSignMonitor.Controls.Add(this.lblWarn);
            this.pnlSignMonitor.Controls.Add(this.lblAirPressure);
            this.pnlSignMonitor.Controls.Add(this.lblScreem);
            this.pnlSignMonitor.Controls.Add(this.lblQuickStop);
            this.pnlSignMonitor.Controls.Add(this.lblAuto);
            this.pnlSignMonitor.Controls.Add(this.btnAuto);
            this.pnlSignMonitor.Cursor = System.Windows.Forms.Cursors.No;
            this.pnlSignMonitor.Location = new System.Drawing.Point(18, 33);
            this.pnlSignMonitor.Name = "pnlSignMonitor";
            this.pnlSignMonitor.ShowBorder = true;
            this.pnlSignMonitor.Size = new System.Drawing.Size(728, 286);
            this.pnlSignMonitor.TabIndex = 3;
            this.pnlSignMonitor.Text = "PLC信号监控";
            // 
            // btnCloseLight
            // 
            this.btnCloseLight.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLight.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseLight.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseLight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseLight.Label = "不正常";
            this.btnCloseLight.Location = new System.Drawing.Point(158, 205);
            this.btnCloseLight.Name = "btnCloseLight";
            this.btnCloseLight.Renderer = null;
            this.btnCloseLight.RepeatInterval = 100;
            this.btnCloseLight.RepeatState = false;
            this.btnCloseLight.Size = new System.Drawing.Size(45, 43);
            this.btnCloseLight.StartRepeatInterval = 500;
            this.btnCloseLight.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnCloseLight.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnCloseLight.TabIndex = 22;
            // 
            // lblComPressionFault
            // 
            this.lblComPressionFault.AutoSize = true;
            this.lblComPressionFault.BackColor = System.Drawing.Color.Transparent;
            this.lblComPressionFault.BorderColor = System.Drawing.Color.White;
            this.lblComPressionFault.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComPressionFault.Location = new System.Drawing.Point(7, 216);
            this.lblComPressionFault.Name = "lblComPressionFault";
            this.lblComPressionFault.Size = new System.Drawing.Size(128, 16);
            this.lblComPressionFault.TabIndex = 21;
            this.lblComPressionFault.Text = "电磁阀压紧故障：";
            // 
            // btnOpenLight
            // 
            this.btnOpenLight.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLight.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenLight.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenLight.Label = "不正常";
            this.btnOpenLight.Location = new System.Drawing.Point(614, 120);
            this.btnOpenLight.Name = "btnOpenLight";
            this.btnOpenLight.Renderer = null;
            this.btnOpenLight.RepeatInterval = 100;
            this.btnOpenLight.RepeatState = false;
            this.btnOpenLight.Size = new System.Drawing.Size(45, 43);
            this.btnOpenLight.StartRepeatInterval = 500;
            this.btnOpenLight.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnOpenLight.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnOpenLight.TabIndex = 20;
            // 
            // lblloosenFault
            // 
            this.lblloosenFault.AutoSize = true;
            this.lblloosenFault.BackColor = System.Drawing.Color.Transparent;
            this.lblloosenFault.BorderColor = System.Drawing.Color.White;
            this.lblloosenFault.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblloosenFault.Location = new System.Drawing.Point(467, 135);
            this.lblloosenFault.Name = "lblloosenFault";
            this.lblloosenFault.Size = new System.Drawing.Size(128, 16);
            this.lblloosenFault.TabIndex = 19;
            this.lblloosenFault.Text = "电磁阀松开故障：";
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.Transparent;
            this.btnAlarm.ButtonColor = System.Drawing.Color.Lime;
            this.btnAlarm.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlarm.Label = "正常";
            this.btnAlarm.Location = new System.Drawing.Point(362, 204);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Renderer = null;
            this.btnAlarm.RepeatInterval = 100;
            this.btnAlarm.RepeatState = false;
            this.btnAlarm.Size = new System.Drawing.Size(45, 43);
            this.btnAlarm.StartRepeatInterval = 500;
            this.btnAlarm.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnAlarm.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnAlarm.TabIndex = 18;
            // 
            // lblPowerSwitch
            // 
            this.lblPowerSwitch.AutoSize = true;
            this.lblPowerSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerSwitch.BorderColor = System.Drawing.Color.White;
            this.lblPowerSwitch.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPowerSwitch.Location = new System.Drawing.Point(24, 52);
            this.lblPowerSwitch.Name = "lblPowerSwitch";
            this.lblPowerSwitch.Size = new System.Drawing.Size(113, 16);
            this.lblPowerSwitch.TabIndex = 17;
            this.lblPowerSwitch.Text = "电源控制开关：";
            // 
            // btnPanel_PowerOnOff
            // 
            this.btnPanel_PowerOnOff.BackColor = System.Drawing.Color.Transparent;
            this.btnPanel_PowerOnOff.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnPanel_PowerOnOff.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPanel_PowerOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPanel_PowerOnOff.Label = "关闭";
            this.btnPanel_PowerOnOff.Location = new System.Drawing.Point(159, 37);
            this.btnPanel_PowerOnOff.Name = "btnPanel_PowerOnOff";
            this.btnPanel_PowerOnOff.Renderer = null;
            this.btnPanel_PowerOnOff.RepeatInterval = 100;
            this.btnPanel_PowerOnOff.RepeatState = false;
            this.btnPanel_PowerOnOff.Size = new System.Drawing.Size(45, 43);
            this.btnPanel_PowerOnOff.StartRepeatInterval = 500;
            this.btnPanel_PowerOnOff.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnPanel_PowerOnOff.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnPanel_PowerOnOff.TabIndex = 16;
            // 
            // btnGas_OK
            // 
            this.btnGas_OK.BackColor = System.Drawing.Color.Transparent;
            this.btnGas_OK.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnGas_OK.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGas_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGas_OK.Label = "不正常";
            this.btnGas_OK.Location = new System.Drawing.Point(362, 124);
            this.btnGas_OK.Name = "btnGas_OK";
            this.btnGas_OK.Renderer = null;
            this.btnGas_OK.RepeatInterval = 100;
            this.btnGas_OK.RepeatState = false;
            this.btnGas_OK.Size = new System.Drawing.Size(45, 43);
            this.btnGas_OK.StartRepeatInterval = 500;
            this.btnGas_OK.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnGas_OK.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnGas_OK.TabIndex = 14;
            // 
            // btnScreen_OK
            // 
            this.btnScreen_OK.BackColor = System.Drawing.Color.Transparent;
            this.btnScreen_OK.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnScreen_OK.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScreen_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScreen_OK.Label = "不正常";
            this.btnScreen_OK.Location = new System.Drawing.Point(614, 37);
            this.btnScreen_OK.Name = "btnScreen_OK";
            this.btnScreen_OK.Renderer = null;
            this.btnScreen_OK.RepeatInterval = 100;
            this.btnScreen_OK.RepeatState = false;
            this.btnScreen_OK.Size = new System.Drawing.Size(45, 43);
            this.btnScreen_OK.StartRepeatInterval = 500;
            this.btnScreen_OK.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnScreen_OK.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnScreen_OK.TabIndex = 13;
            // 
            // btnEmergency_OK
            // 
            this.btnEmergency_OK.BackColor = System.Drawing.Color.Transparent;
            this.btnEmergency_OK.ButtonColor = System.Drawing.Color.Lime;
            this.btnEmergency_OK.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmergency_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmergency_OK.Label = "正常";
            this.btnEmergency_OK.Location = new System.Drawing.Point(363, 37);
            this.btnEmergency_OK.Name = "btnEmergency_OK";
            this.btnEmergency_OK.Renderer = null;
            this.btnEmergency_OK.RepeatInterval = 100;
            this.btnEmergency_OK.RepeatState = false;
            this.btnEmergency_OK.Size = new System.Drawing.Size(45, 43);
            this.btnEmergency_OK.StartRepeatInterval = 500;
            this.btnEmergency_OK.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnEmergency_OK.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnEmergency_OK.TabIndex = 12;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.BackColor = System.Drawing.Color.Transparent;
            this.lblWarn.BorderColor = System.Drawing.Color.White;
            this.lblWarn.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.Location = new System.Drawing.Point(261, 217);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(68, 16);
            this.lblWarn.TabIndex = 8;
            this.lblWarn.Text = "总报警：";
            // 
            // lblAirPressure
            // 
            this.lblAirPressure.AutoSize = true;
            this.lblAirPressure.BackColor = System.Drawing.Color.Transparent;
            this.lblAirPressure.BorderColor = System.Drawing.Color.White;
            this.lblAirPressure.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAirPressure.Location = new System.Drawing.Point(226, 135);
            this.lblAirPressure.Name = "lblAirPressure";
            this.lblAirPressure.Size = new System.Drawing.Size(113, 16);
            this.lblAirPressure.TabIndex = 6;
            this.lblAirPressure.Text = "进气气压正常：";
            // 
            // lblScreem
            // 
            this.lblScreem.AutoSize = true;
            this.lblScreem.BackColor = System.Drawing.Color.Transparent;
            this.lblScreem.BorderColor = System.Drawing.Color.White;
            this.lblScreem.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScreem.Location = new System.Drawing.Point(512, 46);
            this.lblScreem.Name = "lblScreem";
            this.lblScreem.Size = new System.Drawing.Size(83, 16);
            this.lblScreem.TabIndex = 4;
            this.lblScreem.Text = "光幕正常：";
            // 
            // lblQuickStop
            // 
            this.lblQuickStop.AutoSize = true;
            this.lblQuickStop.BackColor = System.Drawing.Color.Transparent;
            this.lblQuickStop.BorderColor = System.Drawing.Color.White;
            this.lblQuickStop.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuickStop.Location = new System.Drawing.Point(261, 47);
            this.lblQuickStop.Name = "lblQuickStop";
            this.lblQuickStop.Size = new System.Drawing.Size(83, 16);
            this.lblQuickStop.TabIndex = 2;
            this.lblQuickStop.Text = "急停正常：";
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblAuto.BorderColor = System.Drawing.Color.White;
            this.lblAuto.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAuto.Location = new System.Drawing.Point(52, 135);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(83, 16);
            this.lblAuto.TabIndex = 1;
            this.lblAuto.Text = "自动手动：";
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.Transparent;
            this.btnAuto.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuto.Font = new System.Drawing.Font("华文细黑", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuto.Label = "手动";
            this.btnAuto.Location = new System.Drawing.Point(158, 124);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Renderer = null;
            this.btnAuto.RepeatInterval = 100;
            this.btnAuto.RepeatState = false;
            this.btnAuto.Size = new System.Drawing.Size(45, 43);
            this.btnAuto.StartRepeatInterval = 500;
            this.btnAuto.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnAuto.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnAuto.TabIndex = 0;
            // 
            // ForceSignMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 332);
            this.Controls.Add(this.pnlSignMonitor);
            this.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForceSignMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "信号查看";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForceSignMonitor_FormClosed);
            this.Load += new System.EventHandler(this.SignMonitor_Load);
            this.pnlSignMonitor.ResumeLayout(false);
            this.pnlSignMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinCaptionPanel pnlSignMonitor;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnCloseLight;
        private CCWin.SkinControl.SkinLabel lblComPressionFault;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnOpenLight;
        private CCWin.SkinControl.SkinLabel lblloosenFault;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnAlarm;
        private CCWin.SkinControl.SkinLabel lblPowerSwitch;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnPanel_PowerOnOff;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnGas_OK;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnScreen_OK;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnEmergency_OK;
        private CCWin.SkinControl.SkinLabel lblWarn;
        private CCWin.SkinControl.SkinLabel lblAirPressure;
        private CCWin.SkinControl.SkinLabel lblScreem;
        private CCWin.SkinControl.SkinLabel lblQuickStop;
        private CCWin.SkinControl.SkinLabel lblAuto;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnAuto;
    }
}