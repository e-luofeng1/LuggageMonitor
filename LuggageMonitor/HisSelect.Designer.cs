namespace LuggageMonitor
{
    partial class HisSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCondition = new CCWin.SkinControl.SkinCaptionPanel();
            this.txtEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtStartTime = new System.Windows.Forms.DateTimePicker();
            this.cboReult = new CCWin.SkinControl.SkinComboBox();
            this.lblResult = new CCWin.SkinControl.SkinLabel();
            this.lblCheckTimeTo = new CCWin.SkinControl.SkinLabel();
            this.lblCheckTimeS = new CCWin.SkinControl.SkinLabel();
            this.btnReset = new CCWin.SkinControl.SkinButton();
            this.txtItemName = new CCWin.SkinControl.SkinTextBox();
            this.lblItemName = new CCWin.SkinControl.SkinLabel();
            this.txtPartNo = new CCWin.SkinControl.SkinTextBox();
            this.lblPartNo = new CCWin.SkinControl.SkinLabel();
            this.txtBarCode = new CCWin.SkinControl.SkinTextBox();
            this.lblBarCode = new CCWin.SkinControl.SkinLabel();
            this.btnSelect = new CCWin.SkinControl.SkinButton();
            this.gridData = new CCWin.SkinControl.SkinDataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckReult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoamBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSelectResult = new CCWin.SkinControl.SkinCaptionPanel();
            this.pnlCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.pnlSelectResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCondition
            // 
            this.pnlCondition.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.pnlCondition.Controls.Add(this.txtEndTime);
            this.pnlCondition.Controls.Add(this.txtStartTime);
            this.pnlCondition.Controls.Add(this.cboReult);
            this.pnlCondition.Controls.Add(this.lblResult);
            this.pnlCondition.Controls.Add(this.lblCheckTimeTo);
            this.pnlCondition.Controls.Add(this.lblCheckTimeS);
            this.pnlCondition.Controls.Add(this.btnReset);
            this.pnlCondition.Controls.Add(this.txtItemName);
            this.pnlCondition.Controls.Add(this.lblItemName);
            this.pnlCondition.Controls.Add(this.txtPartNo);
            this.pnlCondition.Controls.Add(this.lblPartNo);
            this.pnlCondition.Controls.Add(this.txtBarCode);
            this.pnlCondition.Controls.Add(this.lblBarCode);
            this.pnlCondition.Controls.Add(this.btnSelect);
            this.pnlCondition.Location = new System.Drawing.Point(8, 33);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.ShowBorder = true;
            this.pnlCondition.Size = new System.Drawing.Size(904, 175);
            this.pnlCondition.TabIndex = 0;
            this.pnlCondition.Text = "查询条件";
            // 
            // txtEndTime
            // 
            this.txtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndTime.Location = new System.Drawing.Point(394, 90);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(191, 28);
            this.txtEndTime.TabIndex = 15;
            // 
            // txtStartTime
            // 
            this.txtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartTime.Location = new System.Drawing.Point(105, 90);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(188, 28);
            this.txtStartTime.TabIndex = 14;
            // 
            // cboReult
            // 
            this.cboReult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboReult.FormattingEnabled = true;
            this.cboReult.Location = new System.Drawing.Point(705, 92);
            this.cboReult.Name = "cboReult";
            this.cboReult.Size = new System.Drawing.Size(182, 29);
            this.cboReult.TabIndex = 13;
            this.cboReult.WaterText = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.BorderColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(619, 98);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(83, 16);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "检测结果：";
            // 
            // lblCheckTimeTo
            // 
            this.lblCheckTimeTo.AutoSize = true;
            this.lblCheckTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckTimeTo.BorderColor = System.Drawing.Color.White;
            this.lblCheckTimeTo.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckTimeTo.Location = new System.Drawing.Point(333, 97);
            this.lblCheckTimeTo.Name = "lblCheckTimeTo";
            this.lblCheckTimeTo.Size = new System.Drawing.Size(38, 16);
            this.lblCheckTimeTo.TabIndex = 10;
            this.lblCheckTimeTo.Text = "至：";
            // 
            // lblCheckTimeS
            // 
            this.lblCheckTimeS.AutoSize = true;
            this.lblCheckTimeS.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckTimeS.BorderColor = System.Drawing.Color.White;
            this.lblCheckTimeS.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckTimeS.Location = new System.Drawing.Point(6, 98);
            this.lblCheckTimeS.Name = "lblCheckTimeS";
            this.lblCheckTimeS.Size = new System.Drawing.Size(83, 16);
            this.lblCheckTimeS.TabIndex = 8;
            this.lblCheckTimeS.Text = "检测时间：";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReset.DownBack = null;
            this.btnReset.Location = new System.Drawing.Point(788, 136);
            this.btnReset.MouseBack = null;
            this.btnReset.Name = "btnReset";
            this.btnReset.NormlBack = null;
            this.btnReset.Size = new System.Drawing.Size(84, 34);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtItemName.DownBack = null;
            this.txtItemName.Icon = null;
            this.txtItemName.IconIsButton = false;
            this.txtItemName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtItemName.IsPasswordChat = '\0';
            this.txtItemName.IsSystemPasswordChar = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(705, 34);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(0);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.MinimumSize = new System.Drawing.Size(32, 30);
            this.txtItemName.MouseBack = null;
            this.txtItemName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.NormlBack = null;
            this.txtItemName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemName.ReadOnly = false;
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.Size = new System.Drawing.Size(182, 30);
            // 
            // 
            // 
            this.txtItemName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemName.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtItemName.SkinTxt.Location = new System.Drawing.Point(6, 5);
            this.txtItemName.SkinTxt.Multiline = true;
            this.txtItemName.SkinTxt.Name = "BaseText";
            this.txtItemName.SkinTxt.Size = new System.Drawing.Size(170, 20);
            this.txtItemName.SkinTxt.TabIndex = 0;
            this.txtItemName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtItemName.SkinTxt.WaterText = "";
            this.txtItemName.TabIndex = 6;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtItemName.WaterText = "";
            this.txtItemName.WordWrap = true;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.BorderColor = System.Drawing.Color.White;
            this.lblItemName.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemName.Location = new System.Drawing.Point(619, 39);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(83, 16);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "项目名称：";
            // 
            // txtPartNo
            // 
            this.txtPartNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPartNo.DownBack = null;
            this.txtPartNo.Icon = null;
            this.txtPartNo.IconIsButton = false;
            this.txtPartNo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPartNo.IsPasswordChat = '\0';
            this.txtPartNo.IsSystemPasswordChar = false;
            this.txtPartNo.Lines = new string[0];
            this.txtPartNo.Location = new System.Drawing.Point(394, 34);
            this.txtPartNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtPartNo.MaxLength = 32767;
            this.txtPartNo.MinimumSize = new System.Drawing.Size(32, 30);
            this.txtPartNo.MouseBack = null;
            this.txtPartNo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPartNo.Multiline = true;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.NormlBack = null;
            this.txtPartNo.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPartNo.ReadOnly = false;
            this.txtPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPartNo.Size = new System.Drawing.Size(191, 30);
            // 
            // 
            // 
            this.txtPartNo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartNo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPartNo.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtPartNo.SkinTxt.Location = new System.Drawing.Point(6, 5);
            this.txtPartNo.SkinTxt.Multiline = true;
            this.txtPartNo.SkinTxt.Name = "BaseText";
            this.txtPartNo.SkinTxt.Size = new System.Drawing.Size(179, 20);
            this.txtPartNo.SkinTxt.TabIndex = 0;
            this.txtPartNo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPartNo.SkinTxt.WaterText = "";
            this.txtPartNo.TabIndex = 4;
            this.txtPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPartNo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPartNo.WaterText = "";
            this.txtPartNo.WordWrap = true;
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPartNo.BorderColor = System.Drawing.Color.White;
            this.lblPartNo.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPartNo.Location = new System.Drawing.Point(323, 39);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(68, 16);
            this.lblPartNo.TabIndex = 3;
            this.lblPartNo.Text = "零件号：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.Transparent;
            this.txtBarCode.DownBack = null;
            this.txtBarCode.Icon = null;
            this.txtBarCode.IconIsButton = false;
            this.txtBarCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtBarCode.IsPasswordChat = '\0';
            this.txtBarCode.IsSystemPasswordChar = false;
            this.txtBarCode.Lines = new string[0];
            this.txtBarCode.Location = new System.Drawing.Point(105, 34);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtBarCode.MaxLength = 32767;
            this.txtBarCode.MinimumSize = new System.Drawing.Size(32, 30);
            this.txtBarCode.MouseBack = null;
            this.txtBarCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.NormlBack = null;
            this.txtBarCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBarCode.ReadOnly = false;
            this.txtBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarCode.Size = new System.Drawing.Size(188, 30);
            // 
            // 
            // 
            this.txtBarCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBarCode.SkinTxt.Font = new System.Drawing.Font("华文细黑", 9.75F);
            this.txtBarCode.SkinTxt.Location = new System.Drawing.Point(6, 5);
            this.txtBarCode.SkinTxt.Multiline = true;
            this.txtBarCode.SkinTxt.Name = "BaseText";
            this.txtBarCode.SkinTxt.Size = new System.Drawing.Size(176, 20);
            this.txtBarCode.SkinTxt.TabIndex = 0;
            this.txtBarCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtBarCode.SkinTxt.WaterText = "";
            this.txtBarCode.TabIndex = 2;
            this.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtBarCode.WaterText = "";
            this.txtBarCode.WordWrap = true;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarCode.BorderColor = System.Drawing.Color.White;
            this.lblBarCode.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBarCode.Location = new System.Drawing.Point(6, 39);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(83, 16);
            this.lblBarCode.TabIndex = 1;
            this.lblBarCode.Text = "总成条码：";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelect.DownBack = null;
            this.btnSelect.Location = new System.Drawing.Point(646, 133);
            this.btnSelect.MouseBack = null;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NormlBack = null;
            this.btnSelect.Size = new System.Drawing.Size(84, 34);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gridData
            // 
            this.gridData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridData.ColumnFont = null;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.PartNo,
            this.ItemName,
            this.PartType,
            this.CheckTime,
            this.CheckReult,
            this.CreateTime,
            this.FoamBarCode,
            this.PicAdr,
            this.CreateMachine,
            this.ID});
            this.gridData.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridData.HeadFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridData.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridData.Location = new System.Drawing.Point(2, 24);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridData.RowTemplate.Height = 23;
            this.gridData.Size = new System.Drawing.Size(902, 408);
            this.gridData.TabIndex = 1;
            this.gridData.TitleBack = null;
            this.gridData.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridData.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            //this.gridData.DoubleClick += new System.EventHandler(this.gridData_DoubleClick);
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "总成条码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 120;
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "PartNo";
            this.PartNo.HeaderText = "零件号";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            this.PartNo.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "项目名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 150;
            // 
            // PartType
            // 
            this.PartType.DataPropertyName = "PartType";
            this.PartType.HeaderText = "零件类型";
            this.PartType.Name = "PartType";
            this.PartType.ReadOnly = true;
            this.PartType.Visible = false;
            // 
            // CheckTime
            // 
            this.CheckTime.DataPropertyName = "CheckTime";
            this.CheckTime.HeaderText = "检测时间";
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.ReadOnly = true;
            this.CheckTime.Width = 150;
            // 
            // CheckReult
            // 
            this.CheckReult.DataPropertyName = "CheckReult";
            this.CheckReult.HeaderText = "检测结果";
            this.CheckReult.Name = "CheckReult";
            this.CheckReult.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Visible = false;
            // 
            // FoamBarCode
            // 
            this.FoamBarCode.DataPropertyName = "FoamBarCode";
            this.FoamBarCode.HeaderText = "泡棉条码";
            this.FoamBarCode.Name = "FoamBarCode";
            this.FoamBarCode.ReadOnly = true;
            this.FoamBarCode.Width = 120;
            // 
            // PicAdr
            // 
            this.PicAdr.DataPropertyName = "PicAdr";
            this.PicAdr.HeaderText = "图片地址";
            this.PicAdr.Name = "PicAdr";
            this.PicAdr.ReadOnly = true;
            this.PicAdr.Width = 200;
            // 
            // CreateMachine
            // 
            this.CreateMachine.DataPropertyName = "CreateMachine";
            this.CreateMachine.HeaderText = "创建机器";
            this.CreateMachine.Name = "CreateMachine";
            this.CreateMachine.ReadOnly = true;
            this.CreateMachine.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // pnlSelectResult
            // 
            this.pnlSelectResult.CaptionFont = new System.Drawing.Font("华文细黑", 9F);
            this.pnlSelectResult.Controls.Add(this.gridData);
            this.pnlSelectResult.Location = new System.Drawing.Point(8, 214);
            this.pnlSelectResult.Name = "pnlSelectResult";
            this.pnlSelectResult.ShowBorder = true;
            this.pnlSelectResult.Size = new System.Drawing.Size(906, 434);
            this.pnlSelectResult.TabIndex = 1;
            this.pnlSelectResult.Text = "查询结果";
            // 
            // HisSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 662);
            this.Controls.Add(this.pnlSelectResult);
            this.Controls.Add(this.pnlCondition);
            this.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HisSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询";
            this.pnlCondition.ResumeLayout(false);
            this.pnlCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.pnlSelectResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinCaptionPanel pnlCondition;
        private CCWin.SkinControl.SkinDataGridView gridData;
        private CCWin.SkinControl.SkinButton btnSelect;
        private CCWin.SkinControl.SkinComboBox cboReult;
        private CCWin.SkinControl.SkinLabel lblResult;
        private CCWin.SkinControl.SkinLabel lblCheckTimeTo;
        private CCWin.SkinControl.SkinLabel lblCheckTimeS;
        private CCWin.SkinControl.SkinButton btnReset;
        private CCWin.SkinControl.SkinTextBox txtItemName;
        private CCWin.SkinControl.SkinLabel lblItemName;
        private CCWin.SkinControl.SkinTextBox txtPartNo;
        private CCWin.SkinControl.SkinLabel lblPartNo;
        private CCWin.SkinControl.SkinTextBox txtBarCode;
        private CCWin.SkinControl.SkinLabel lblBarCode;
        private CCWin.SkinControl.SkinCaptionPanel pnlSelectResult;
        private System.Windows.Forms.DateTimePicker txtEndTime;
        private System.Windows.Forms.DateTimePicker txtStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckReult;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoamBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PicAdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}