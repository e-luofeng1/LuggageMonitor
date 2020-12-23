namespace LuggageMonitor.TestPLC
{
    partial class SIEMENS
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
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.btnUnConnect = new CCWin.SkinControl.SkinButton();
            this.btnConnect = new CCWin.SkinControl.SkinButton();
            this.txtSlot = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txtRack = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtIP = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtOut = new CCWin.SkinControl.RtfRichTextBox();
            this.skinCaptionPanel2 = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinCaptionPanel3 = new CCWin.SkinControl.SkinCaptionPanel();
            this.btnRead = new CCWin.SkinControl.SkinButton();
            this.Write_Value = new CCWin.SkinControl.SkinTextBox();
            this.cboDataType = new CCWin.SkinControl.SkinComboBox();
            this.btnWrite = new CCWin.SkinControl.SkinButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.Start_Address = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.DB_Number = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.Current_Value = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinCaptionPanel1.SuspendLayout();
            this.skinCaptionPanel2.SuspendLayout();
            this.skinCaptionPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.skinCaptionPanel1.Controls.Add(this.skinLine1);
            this.skinCaptionPanel1.Controls.Add(this.btnUnConnect);
            this.skinCaptionPanel1.Controls.Add(this.btnConnect);
            this.skinCaptionPanel1.Controls.Add(this.txtSlot);
            this.skinCaptionPanel1.Controls.Add(this.skinLabel3);
            this.skinCaptionPanel1.Controls.Add(this.txtRack);
            this.skinCaptionPanel1.Controls.Add(this.skinLabel2);
            this.skinCaptionPanel1.Controls.Add(this.txtIP);
            this.skinCaptionPanel1.Controls.Add(this.skinLabel1);
            this.skinCaptionPanel1.Location = new System.Drawing.Point(12, 21);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.skinCaptionPanel1.Size = new System.Drawing.Size(1024, 183);
            this.skinCaptionPanel1.TabIndex = 0;
            this.skinCaptionPanel1.Text = "连接参数";
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(0, 103);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(1024, 12);
            this.skinLine1.TabIndex = 7;
            this.skinLine1.Text = "skinLine1";
            // 
            // btnUnConnect
            // 
            this.btnUnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnUnConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnUnConnect.DownBack = null;
            this.btnUnConnect.Location = new System.Drawing.Point(856, 129);
            this.btnUnConnect.MouseBack = null;
            this.btnUnConnect.Name = "btnUnConnect";
            this.btnUnConnect.NormlBack = null;
            this.btnUnConnect.Size = new System.Drawing.Size(99, 40);
            this.btnUnConnect.TabIndex = 6;
            this.btnUnConnect.Text = "断开";
            this.btnUnConnect.UseVisualStyleBackColor = false;
            this.btnUnConnect.Click += new System.EventHandler(this.btnUnConnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConnect.DownBack = null;
            this.btnConnect.Location = new System.Drawing.Point(678, 129);
            this.btnConnect.MouseBack = null;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NormlBack = null;
            this.btnConnect.Size = new System.Drawing.Size(99, 40);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSlot
            // 
            this.txtSlot.BackColor = System.Drawing.Color.Transparent;
            this.txtSlot.DownBack = null;
            this.txtSlot.Icon = null;
            this.txtSlot.IconIsButton = false;
            this.txtSlot.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSlot.IsPasswordChat = '\0';
            this.txtSlot.IsSystemPasswordChar = false;
            this.txtSlot.Lines = new string[0];
            this.txtSlot.Location = new System.Drawing.Point(770, 43);
            this.txtSlot.Margin = new System.Windows.Forms.Padding(0);
            this.txtSlot.MaxLength = 32767;
            this.txtSlot.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSlot.MouseBack = null;
            this.txtSlot.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSlot.Multiline = false;
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.NormlBack = null;
            this.txtSlot.Padding = new System.Windows.Forms.Padding(5);
            this.txtSlot.ReadOnly = false;
            this.txtSlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlot.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtSlot.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSlot.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSlot.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtSlot.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSlot.SkinTxt.Name = "BaseText";
            this.txtSlot.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtSlot.SkinTxt.TabIndex = 0;
            this.txtSlot.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSlot.SkinTxt.WaterText = "";
            this.txtSlot.TabIndex = 5;
            this.txtSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSlot.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSlot.WaterText = "";
            this.txtSlot.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(674, 47);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(93, 20);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "槽号(Slot)：";
            // 
            // txtRack
            // 
            this.txtRack.BackColor = System.Drawing.Color.Transparent;
            this.txtRack.DownBack = null;
            this.txtRack.Icon = null;
            this.txtRack.IconIsButton = false;
            this.txtRack.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRack.IsPasswordChat = '\0';
            this.txtRack.IsSystemPasswordChar = false;
            this.txtRack.Lines = new string[0];
            this.txtRack.Location = new System.Drawing.Point(447, 41);
            this.txtRack.Margin = new System.Windows.Forms.Padding(0);
            this.txtRack.MaxLength = 32767;
            this.txtRack.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtRack.MouseBack = null;
            this.txtRack.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRack.Multiline = false;
            this.txtRack.Name = "txtRack";
            this.txtRack.NormlBack = null;
            this.txtRack.Padding = new System.Windows.Forms.Padding(5);
            this.txtRack.ReadOnly = false;
            this.txtRack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRack.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtRack.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRack.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRack.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtRack.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtRack.SkinTxt.Name = "BaseText";
            this.txtRack.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtRack.SkinTxt.TabIndex = 0;
            this.txtRack.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRack.SkinTxt.WaterText = "";
            this.txtRack.TabIndex = 3;
            this.txtRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRack.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRack.WaterText = "";
            this.txtRack.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(335, 46);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(109, 20);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "机架号(rack)：";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Transparent;
            this.txtIP.DownBack = null;
            this.txtIP.Icon = null;
            this.txtIP.IconIsButton = false;
            this.txtIP.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIP.IsPasswordChat = '\0';
            this.txtIP.IsSystemPasswordChar = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(101, 41);
            this.txtIP.Margin = new System.Windows.Forms.Padding(0);
            this.txtIP.MaxLength = 32767;
            this.txtIP.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtIP.MouseBack = null;
            this.txtIP.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIP.Multiline = false;
            this.txtIP.Name = "txtIP";
            this.txtIP.NormlBack = null;
            this.txtIP.Padding = new System.Windows.Forms.Padding(5);
            this.txtIP.ReadOnly = false;
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtIP.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtIP.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtIP.SkinTxt.Name = "BaseText";
            this.txtIP.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtIP.SkinTxt.TabIndex = 0;
            this.txtIP.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIP.SkinTxt.WaterText = "";
            this.txtIP.TabIndex = 1;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIP.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIP.WaterText = "";
            this.txtIP.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(20, 46);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(67, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "IP地址：";
            // 
            // txtOut
            // 
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOut.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtOut.Location = new System.Drawing.Point(2, 24);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(1020, 86);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "";
            this.txtOut.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinCaptionPanel2
            // 
            this.skinCaptionPanel2.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.skinCaptionPanel2.Controls.Add(this.txtOut);
            this.skinCaptionPanel2.Location = new System.Drawing.Point(12, 439);
            this.skinCaptionPanel2.Name = "skinCaptionPanel2";
            this.skinCaptionPanel2.Size = new System.Drawing.Size(1024, 112);
            this.skinCaptionPanel2.TabIndex = 2;
            this.skinCaptionPanel2.Text = "输出";
            // 
            // skinCaptionPanel3
            // 
            this.skinCaptionPanel3.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.skinCaptionPanel3.Controls.Add(this.Current_Value);
            this.skinCaptionPanel3.Controls.Add(this.skinLabel7);
            this.skinCaptionPanel3.Controls.Add(this.btnRead);
            this.skinCaptionPanel3.Controls.Add(this.Write_Value);
            this.skinCaptionPanel3.Controls.Add(this.cboDataType);
            this.skinCaptionPanel3.Controls.Add(this.btnWrite);
            this.skinCaptionPanel3.Controls.Add(this.skinLabel6);
            this.skinCaptionPanel3.Controls.Add(this.Start_Address);
            this.skinCaptionPanel3.Controls.Add(this.skinLabel5);
            this.skinCaptionPanel3.Controls.Add(this.DB_Number);
            this.skinCaptionPanel3.Controls.Add(this.skinLabel9);
            this.skinCaptionPanel3.Controls.Add(this.skinLabel4);
            this.skinCaptionPanel3.Location = new System.Drawing.Point(14, 211);
            this.skinCaptionPanel3.Name = "skinCaptionPanel3";
            this.skinCaptionPanel3.Size = new System.Drawing.Size(1022, 222);
            this.skinCaptionPanel3.TabIndex = 3;
            this.skinCaptionPanel3.Text = "读取数据";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRead.DownBack = null;
            this.btnRead.Location = new System.Drawing.Point(392, 160);
            this.btnRead.MouseBack = null;
            this.btnRead.Name = "btnRead";
            this.btnRead.NormlBack = null;
            this.btnRead.Size = new System.Drawing.Size(99, 40);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Write_Value
            // 
            this.Write_Value.BackColor = System.Drawing.Color.Transparent;
            this.Write_Value.DownBack = null;
            this.Write_Value.Icon = null;
            this.Write_Value.IconIsButton = false;
            this.Write_Value.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Write_Value.IsPasswordChat = '\0';
            this.Write_Value.IsSystemPasswordChar = false;
            this.Write_Value.Lines = new string[0];
            this.Write_Value.Location = new System.Drawing.Point(445, 93);
            this.Write_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Write_Value.MaxLength = 32767;
            this.Write_Value.MinimumSize = new System.Drawing.Size(28, 28);
            this.Write_Value.MouseBack = null;
            this.Write_Value.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Write_Value.Multiline = false;
            this.Write_Value.Name = "Write_Value";
            this.Write_Value.NormlBack = null;
            this.Write_Value.Padding = new System.Windows.Forms.Padding(5);
            this.Write_Value.ReadOnly = false;
            this.Write_Value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Write_Value.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Write_Value.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Write_Value.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Write_Value.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.Write_Value.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Write_Value.SkinTxt.Name = "BaseText";
            this.Write_Value.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.Write_Value.SkinTxt.TabIndex = 0;
            this.Write_Value.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Write_Value.SkinTxt.WaterText = "";
            this.Write_Value.TabIndex = 11;
            this.Write_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Write_Value.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Write_Value.WaterText = "";
            this.Write_Value.WordWrap = true;
            // 
            // cboDataType
            // 
            this.cboDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Location = new System.Drawing.Point(163, 147);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(185, 26);
            this.cboDataType.TabIndex = 12;
            this.cboDataType.WaterText = "";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Transparent;
            this.btnWrite.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnWrite.DownBack = null;
            this.btnWrite.Location = new System.Drawing.Point(546, 160);
            this.btnWrite.MouseBack = null;
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.NormlBack = null;
            this.btnWrite.Size = new System.Drawing.Size(99, 40);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(75, 151);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(69, 20);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "数据类型";
            // 
            // Start_Address
            // 
            this.Start_Address.BackColor = System.Drawing.Color.Transparent;
            this.Start_Address.DownBack = null;
            this.Start_Address.Icon = null;
            this.Start_Address.IconIsButton = false;
            this.Start_Address.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Start_Address.IsPasswordChat = '\0';
            this.Start_Address.IsSystemPasswordChar = false;
            this.Start_Address.Lines = new string[0];
            this.Start_Address.Location = new System.Drawing.Point(162, 93);
            this.Start_Address.Margin = new System.Windows.Forms.Padding(0);
            this.Start_Address.MaxLength = 32767;
            this.Start_Address.MinimumSize = new System.Drawing.Size(28, 28);
            this.Start_Address.MouseBack = null;
            this.Start_Address.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Start_Address.Multiline = false;
            this.Start_Address.Name = "Start_Address";
            this.Start_Address.NormlBack = null;
            this.Start_Address.Padding = new System.Windows.Forms.Padding(5);
            this.Start_Address.ReadOnly = false;
            this.Start_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Start_Address.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Start_Address.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Start_Address.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start_Address.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.Start_Address.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Start_Address.SkinTxt.Name = "BaseText";
            this.Start_Address.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.Start_Address.SkinTxt.TabIndex = 0;
            this.Start_Address.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Start_Address.SkinTxt.WaterText = "";
            this.Start_Address.TabIndex = 10;
            this.Start_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Start_Address.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Start_Address.WaterText = "";
            this.Start_Address.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(74, 101);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(69, 20);
            this.skinLabel5.TabIndex = 9;
            this.skinLabel5.Text = "起始位：";
            // 
            // DB_Number
            // 
            this.DB_Number.BackColor = System.Drawing.Color.Transparent;
            this.DB_Number.DownBack = null;
            this.DB_Number.Icon = null;
            this.DB_Number.IconIsButton = false;
            this.DB_Number.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.DB_Number.IsPasswordChat = '\0';
            this.DB_Number.IsSystemPasswordChar = false;
            this.DB_Number.Lines = new string[0];
            this.DB_Number.Location = new System.Drawing.Point(162, 40);
            this.DB_Number.Margin = new System.Windows.Forms.Padding(0);
            this.DB_Number.MaxLength = 32767;
            this.DB_Number.MinimumSize = new System.Drawing.Size(28, 28);
            this.DB_Number.MouseBack = null;
            this.DB_Number.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.DB_Number.Multiline = false;
            this.DB_Number.Name = "DB_Number";
            this.DB_Number.NormlBack = null;
            this.DB_Number.Padding = new System.Windows.Forms.Padding(5);
            this.DB_Number.ReadOnly = false;
            this.DB_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DB_Number.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.DB_Number.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DB_Number.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_Number.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.DB_Number.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.DB_Number.SkinTxt.Name = "BaseText";
            this.DB_Number.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.DB_Number.SkinTxt.TabIndex = 0;
            this.DB_Number.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DB_Number.SkinTxt.WaterText = "";
            this.DB_Number.TabIndex = 5;
            this.DB_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DB_Number.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DB_Number.WaterText = "";
            this.DB_Number.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(373, 101);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(69, 20);
            this.skinLabel9.TabIndex = 13;
            this.skinLabel9.Text = "写入值：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(69, 48);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(74, 20);
            this.skinLabel4.TabIndex = 4;
            this.skinLabel4.Text = "DB块号：";
            // 
            // Current_Value
            // 
            this.Current_Value.BackColor = System.Drawing.Color.Transparent;
            this.Current_Value.DownBack = null;
            this.Current_Value.Icon = null;
            this.Current_Value.IconIsButton = false;
            this.Current_Value.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Current_Value.IsPasswordChat = '\0';
            this.Current_Value.IsSystemPasswordChar = false;
            this.Current_Value.Lines = new string[0];
            this.Current_Value.Location = new System.Drawing.Point(445, 40);
            this.Current_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Current_Value.MaxLength = 32767;
            this.Current_Value.MinimumSize = new System.Drawing.Size(28, 28);
            this.Current_Value.MouseBack = null;
            this.Current_Value.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Current_Value.Multiline = false;
            this.Current_Value.Name = "Current_Value";
            this.Current_Value.NormlBack = null;
            this.Current_Value.Padding = new System.Windows.Forms.Padding(5);
            this.Current_Value.ReadOnly = false;
            this.Current_Value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Current_Value.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Current_Value.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Current_Value.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Current_Value.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.Current_Value.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Current_Value.SkinTxt.Name = "BaseText";
            this.Current_Value.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.Current_Value.SkinTxt.TabIndex = 0;
            this.Current_Value.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Current_Value.SkinTxt.WaterText = "";
            this.Current_Value.TabIndex = 14;
            this.Current_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Current_Value.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Current_Value.WaterText = "";
            this.Current_Value.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(373, 48);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(69, 20);
            this.skinLabel7.TabIndex = 15;
            this.skinLabel7.Text = "当前值：";
            // 
            // SIEMENS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.skinCaptionPanel3);
            this.Controls.Add(this.skinCaptionPanel2);
            this.Controls.Add(this.skinCaptionPanel1);
            this.Name = "SIEMENS";
            this.Text = "SIEMENS";
            this.Load += new System.EventHandler(this.SIEMENS_Load);
            this.skinCaptionPanel1.ResumeLayout(false);
            this.skinCaptionPanel1.PerformLayout();
            this.skinCaptionPanel2.ResumeLayout(false);
            this.skinCaptionPanel3.ResumeLayout(false);
            this.skinCaptionPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinButton btnUnConnect;
        private CCWin.SkinControl.SkinButton btnConnect;
        private CCWin.SkinControl.SkinTextBox txtSlot;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox txtRack;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtIP;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.RtfRichTextBox txtOut;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel2;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel3;
        private CCWin.SkinControl.SkinButton btnWrite;
        private CCWin.SkinControl.SkinButton btnRead;
        private CCWin.SkinControl.SkinTextBox Write_Value;
        private CCWin.SkinControl.SkinComboBox cboDataType;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinTextBox Start_Address;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox DB_Number;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox Current_Value;
        private CCWin.SkinControl.SkinLabel skinLabel7;
    }
}