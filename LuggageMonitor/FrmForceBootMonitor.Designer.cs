namespace LuggageMonitor
{
    partial class FrmForceBootMonitor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {

            }
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectHistory = new CCWin.SkinControl.SkinButton();
            this.Explain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.btnPlc = new CCWin.SkinControl.SkinButton();
            this.btnCloseLightAction = new CCWin.SkinControl.SkinButton();
            this.btnOpenLigntAction = new CCWin.SkinControl.SkinButton();
            this.btnRest = new CCWin.SkinControl.SkinButton();
            this.pnlpicReult = new CCWin.SkinControl.SkinCaptionPanel();
            this.lblResult = new CCWin.SkinControl.SkinLabel();
            this.picForceImage = new CCWin.SkinControl.SkinPictureBox();
            this.pnlCountInfo = new CCWin.SkinControl.SkinCaptionPanel();
            this.lblNgCount = new CCWin.SkinControl.SkinLabel();
            this.lblNOK = new CCWin.SkinControl.SkinLabel();
            this.lblOKCount = new CCWin.SkinControl.SkinLabel();
            this.lblOK = new CCWin.SkinControl.SkinLabel();
            this.pnlStep = new CCWin.SkinControl.SkinCaptionPanel();
            this.gridStep = new CCWin.SkinControl.SkinDataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MistakeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picCommpany = new CCWin.SkinControl.SkinPictureBox();
            this.pnlBasicInfo = new CCWin.SkinControl.SkinCaptionPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkHeart = new CCWin.SkinControl.SkinCheckBox();
            this.txtForceItemName = new CCWin.SkinControl.SkinLabel();
            this.lblItemName = new CCWin.SkinControl.SkinLabel();
            this.txtForcePartNo = new CCWin.SkinControl.SkinLabel();
            this.lblPartNo = new CCWin.SkinControl.SkinLabel();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new CCWin.SkinControl.SkinLabel();
            this.btnForcePLCState = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblTime = new CCWin.SkinControl.SkinLabel();
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.pnlSystem = new CCWin.SkinControl.SkinCaptionPanel();
            this.txtContent = new CCWin.SkinControl.SkinChatRichTextBox();
            this.axTcpForceClient = new SocketHelper.AxTcpClient(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.pnlpicReult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picForceImage)).BeginInit();
            this.pnlCountInfo.SuspendLayout();
            this.pnlStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommpany)).BeginInit();
            this.pnlBasicInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectHistory
            // 
            this.btnSelectHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectHistory.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelectHistory.DownBack = null;
            this.btnSelectHistory.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectHistory.Location = new System.Drawing.Point(524, 7);
            this.btnSelectHistory.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectHistory.MouseBack = null;
            this.btnSelectHistory.Name = "btnSelectHistory";
            this.btnSelectHistory.NormlBack = null;
            this.btnSelectHistory.Size = new System.Drawing.Size(120, 40);
            this.btnSelectHistory.TabIndex = 6;
            this.btnSelectHistory.Text = "历史查询";
            this.btnSelectHistory.UseVisualStyleBackColor = false;
            this.btnSelectHistory.Click += new System.EventHandler(this.btnSelectHistory_Click);
            // 
            // Explain
            // 
            this.Explain.DataPropertyName = "Explain";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Explain.DefaultCellStyle = dataGridViewCellStyle1;
            this.Explain.HeaderText = "说明";
            this.Explain.Name = "Explain";
            this.Explain.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.925498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.36726F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.23295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.47429F));
            this.tableLayoutPanel1.Controls.Add(this.skinPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pnlpicReult, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnlCountInfo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlStep, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picCommpany, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBasicInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSystem, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 693);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.skinPanel2, 4);
            this.skinPanel2.Controls.Add(this.btnPlc);
            this.skinPanel2.Controls.Add(this.btnCloseLightAction);
            this.skinPanel2.Controls.Add(this.btnOpenLigntAction);
            this.skinPanel2.Controls.Add(this.btnRest);
            this.skinPanel2.Controls.Add(this.btnSelectHistory);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(3, 624);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(953, 66);
            this.skinPanel2.TabIndex = 20;
            // 
            // btnPlc
            // 
            this.btnPlc.BackColor = System.Drawing.Color.Transparent;
            this.btnPlc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPlc.DownBack = null;
            this.btnPlc.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlc.Location = new System.Drawing.Point(392, 7);
            this.btnPlc.MouseBack = null;
            this.btnPlc.Name = "btnPlc";
            this.btnPlc.NormlBack = null;
            this.btnPlc.Size = new System.Drawing.Size(120, 40);
            this.btnPlc.TabIndex = 14;
            this.btnPlc.Text = "PLC监控";
            this.btnPlc.UseVisualStyleBackColor = false;
            this.btnPlc.Click += new System.EventHandler(this.btnPlc_Click);
            // 
            // btnCloseLightAction
            // 
            this.btnCloseLightAction.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLightAction.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseLightAction.DownBack = null;
            this.btnCloseLightAction.Enabled = false;
            this.btnCloseLightAction.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseLightAction.Location = new System.Drawing.Point(262, 7);
            this.btnCloseLightAction.MouseBack = null;
            this.btnCloseLightAction.Name = "btnCloseLightAction";
            this.btnCloseLightAction.NormlBack = null;
            this.btnCloseLightAction.Size = new System.Drawing.Size(120, 40);
            this.btnCloseLightAction.TabIndex = 13;
            this.btnCloseLightAction.Text = "电磁阀压紧";
            this.btnCloseLightAction.UseVisualStyleBackColor = false;
            this.btnCloseLightAction.Click += new System.EventHandler(this.btnCloseLightAction_Click);
            // 
            // btnOpenLigntAction
            // 
            this.btnOpenLigntAction.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLigntAction.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenLigntAction.DownBack = null;
            this.btnOpenLigntAction.Enabled = false;
            this.btnOpenLigntAction.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLigntAction.Location = new System.Drawing.Point(132, 7);
            this.btnOpenLigntAction.MouseBack = null;
            this.btnOpenLigntAction.Name = "btnOpenLigntAction";
            this.btnOpenLigntAction.NormlBack = null;
            this.btnOpenLigntAction.Size = new System.Drawing.Size(120, 40);
            this.btnOpenLigntAction.TabIndex = 12;
            this.btnOpenLigntAction.Text = "电磁阀松开";
            this.btnOpenLigntAction.UseVisualStyleBackColor = false;
            this.btnOpenLigntAction.Click += new System.EventHandler(this.btnOpenLightAction_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Transparent;
            this.btnRest.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRest.DownBack = null;
            this.btnRest.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRest.Location = new System.Drawing.Point(4, 7);
            this.btnRest.MouseBack = null;
            this.btnRest.Name = "btnRest";
            this.btnRest.NormlBack = null;
            this.btnRest.Size = new System.Drawing.Size(120, 40);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "重置";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pnlpicReult
            // 
            this.pnlpicReult.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlpicReult, 2);
            this.pnlpicReult.Controls.Add(this.lblResult);
            this.pnlpicReult.Controls.Add(this.picForceImage);
            this.pnlpicReult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpicReult.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlpicReult.Location = new System.Drawing.Point(552, 348);
            this.pnlpicReult.Name = "pnlpicReult";
            this.tableLayoutPanel1.SetRowSpan(this.pnlpicReult, 4);
            this.pnlpicReult.ShowBorder = true;
            this.pnlpicReult.Size = new System.Drawing.Size(404, 270);
            this.pnlpicReult.TabIndex = 4;
            this.pnlpicReult.Text = "拍照结果";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.BorderColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("华文细黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(338, 201);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 41);
            this.lblResult.TabIndex = 3;
            // 
            // picForceImage
            // 
            this.picForceImage.BackColor = System.Drawing.Color.Transparent;
            this.picForceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picForceImage.Image = global::LuggageMonitor.Properties.Resources.qlug;
            this.picForceImage.ImageLocation = "";
            this.picForceImage.Location = new System.Drawing.Point(2, 24);
            this.picForceImage.Name = "picForceImage";
            this.picForceImage.Size = new System.Drawing.Size(400, 244);
            this.picForceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForceImage.TabIndex = 0;
            this.picForceImage.TabStop = false;
            // 
            // pnlCountInfo
            // 
            this.pnlCountInfo.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlCountInfo, 2);
            this.pnlCountInfo.Controls.Add(this.lblNgCount);
            this.pnlCountInfo.Controls.Add(this.lblNOK);
            this.pnlCountInfo.Controls.Add(this.lblOKCount);
            this.pnlCountInfo.Controls.Add(this.lblOK);
            this.pnlCountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountInfo.Location = new System.Drawing.Point(552, 141);
            this.pnlCountInfo.Name = "pnlCountInfo";
            this.pnlCountInfo.ShowBorder = true;
            this.pnlCountInfo.Size = new System.Drawing.Size(404, 63);
            this.pnlCountInfo.TabIndex = 18;
            this.pnlCountInfo.Text = "计数值";
            // 
            // lblNgCount
            // 
            this.lblNgCount.AutoSize = true;
            this.lblNgCount.BackColor = System.Drawing.Color.Transparent;
            this.lblNgCount.BorderColor = System.Drawing.Color.White;
            this.lblNgCount.Font = new System.Drawing.Font("华文细黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNgCount.Location = new System.Drawing.Point(336, 31);
            this.lblNgCount.Name = "lblNgCount";
            this.lblNgCount.Size = new System.Drawing.Size(22, 21);
            this.lblNgCount.TabIndex = 24;
            this.lblNgCount.Text = "0";
            // 
            // lblNOK
            // 
            this.lblNOK.AutoSize = true;
            this.lblNOK.BackColor = System.Drawing.Color.Transparent;
            this.lblNOK.BorderColor = System.Drawing.Color.White;
            this.lblNOK.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNOK.Location = new System.Drawing.Point(199, 33);
            this.lblNOK.Name = "lblNOK";
            this.lblNOK.Size = new System.Drawing.Size(83, 16);
            this.lblNOK.TabIndex = 23;
            this.lblNOK.Text = "不合格数：";
            // 
            // lblOKCount
            // 
            this.lblOKCount.AutoSize = true;
            this.lblOKCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOKCount.BorderColor = System.Drawing.Color.White;
            this.lblOKCount.Font = new System.Drawing.Font("华文细黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOKCount.Location = new System.Drawing.Point(134, 31);
            this.lblOKCount.Name = "lblOKCount";
            this.lblOKCount.Size = new System.Drawing.Size(22, 21);
            this.lblOKCount.TabIndex = 22;
            this.lblOKCount.Text = "0";
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.BackColor = System.Drawing.Color.Transparent;
            this.lblOK.BorderColor = System.Drawing.Color.White;
            this.lblOK.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOK.Location = new System.Drawing.Point(14, 32);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(68, 16);
            this.lblOK.TabIndex = 21;
            this.lblOK.Text = "合格数：";
            // 
            // pnlStep
            // 
            this.pnlStep.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlStep, 2);
            this.pnlStep.Controls.Add(this.gridStep);
            this.pnlStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlStep.Location = new System.Drawing.Point(3, 141);
            this.pnlStep.Name = "pnlStep";
            this.tableLayoutPanel1.SetRowSpan(this.pnlStep, 7);
            this.pnlStep.Size = new System.Drawing.Size(543, 477);
            this.pnlStep.TabIndex = 17;
            this.pnlStep.Text = "防错信息";
            // 
            // gridStep
            // 
            this.gridStep.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridStep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridStep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStep.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridStep.ColumnFont = null;
            this.gridStep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.SetValue,
            this.MistakeType,
            this.Explain,
            this.Result,
            this.CurrentValue,
            this.IsValid});
            this.gridStep.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStep.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStep.EnableHeadersVisualStyles = false;
            this.gridStep.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridStep.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridStep.HeadFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridStep.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridStep.Location = new System.Drawing.Point(2, 24);
            this.gridStep.MultiSelect = false;
            this.gridStep.Name = "gridStep";
            this.gridStep.ReadOnly = true;
            this.gridStep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridStep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridStep.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridStep.RowTemplate.Height = 23;
            this.gridStep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStep.Size = new System.Drawing.Size(539, 451);
            this.gridStep.TabIndex = 0;
            this.gridStep.TitleBack = null;
            this.gridStep.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridStep.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.gridStep.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridStep_RowPrePaint);
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Visible = false;
            // 
            // SetValue
            // 
            this.SetValue.DataPropertyName = "SetValue";
            this.SetValue.HeaderText = "设定值";
            this.SetValue.Name = "SetValue";
            this.SetValue.ReadOnly = true;
            this.SetValue.Visible = false;
            // 
            // MistakeType
            // 
            this.MistakeType.DataPropertyName = "MistakeType";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MistakeType.DefaultCellStyle = dataGridViewCellStyle4;
            this.MistakeType.HeaderText = "防错类型";
            this.MistakeType.Name = "MistakeType";
            this.MistakeType.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.DefaultCellStyle = dataGridViewCellStyle5;
            this.Result.HeaderText = "结果";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // CurrentValue
            // 
            this.CurrentValue.DataPropertyName = "CurrentValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.CurrentValue.HeaderText = "当前值";
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.ReadOnly = true;
            // 
            // IsValid
            // 
            this.IsValid.DataPropertyName = "IsValid";
            this.IsValid.HeaderText = "是否有效";
            this.IsValid.Name = "IsValid";
            this.IsValid.ReadOnly = true;
            this.IsValid.Visible = false;
            // 
            // picCommpany
            // 
            this.picCommpany.BackColor = System.Drawing.Color.Transparent;
            this.picCommpany.Image = global::LuggageMonitor.Properties.Resources.companly;
            this.picCommpany.Location = new System.Drawing.Point(3, 3);
            this.picCommpany.Name = "picCommpany";
            this.picCommpany.Size = new System.Drawing.Size(60, 54);
            this.picCommpany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCommpany.TabIndex = 13;
            this.picCommpany.TabStop = false;
            this.picCommpany.Click += new System.EventHandler(this.picCommany_Click);
            // 
            // pnlBasicInfo
            // 
            this.pnlBasicInfo.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlBasicInfo, 4);
            this.pnlBasicInfo.Controls.Add(this.tableLayoutPanel2);
            this.pnlBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBasicInfo.Location = new System.Drawing.Point(3, 72);
            this.pnlBasicInfo.Name = "pnlBasicInfo";
            this.pnlBasicInfo.ShowBorder = true;
            this.pnlBasicInfo.Size = new System.Drawing.Size(953, 63);
            this.pnlBasicInfo.TabIndex = 16;
            this.pnlBasicInfo.Text = "产品信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 20;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.chkHeart, 18, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtForceItemName, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblItemName, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtForcePartNo, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPartNo, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBarCode, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBarCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnForcePLCState, 17, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(949, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chkHeart
            // 
            this.chkHeart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHeart.BackColor = System.Drawing.Color.Transparent;
            this.chkHeart.Checked = true;
            this.chkHeart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.chkHeart, 2);
            this.chkHeart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkHeart.DownBack = null;
            this.chkHeart.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHeart.Location = new System.Drawing.Point(867, 8);
            this.chkHeart.MouseBack = null;
            this.chkHeart.Name = "chkHeart";
            this.chkHeart.NormlBack = null;
            this.chkHeart.SelectedDownBack = null;
            this.chkHeart.SelectedMouseBack = null;
            this.chkHeart.SelectedNormlBack = null;
            this.chkHeart.Size = new System.Drawing.Size(60, 20);
            this.chkHeart.TabIndex = 27;
            this.chkHeart.Text = "心跳";
            this.chkHeart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHeart.UseVisualStyleBackColor = false;
            this.chkHeart.CheckedChanged += new System.EventHandler(this.chkPLCState_CheckedChanged);
            // 
            // txtForceItemName
            // 
            this.txtForceItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtForceItemName.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.txtForceItemName, 3);
            this.txtForceItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtForceItemName.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtForceItemName.Location = new System.Drawing.Point(614, 0);
            this.txtForceItemName.Name = "txtForceItemName";
            this.txtForceItemName.Size = new System.Drawing.Size(135, 37);
            this.txtForceItemName.TabIndex = 25;
            this.txtForceItemName.Text = "MODEL Y 后行李箱";
            this.txtForceItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.lblItemName, 2);
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemName.Location = new System.Drawing.Point(520, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(88, 37);
            this.lblItemName.TabIndex = 24;
            this.lblItemName.Text = "项目名称：";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForcePartNo
            // 
            this.txtForcePartNo.BackColor = System.Drawing.Color.Transparent;
            this.txtForcePartNo.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.txtForcePartNo, 3);
            this.txtForcePartNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtForcePartNo.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtForcePartNo.Location = new System.Drawing.Point(379, 0);
            this.txtForcePartNo.Name = "txtForcePartNo";
            this.txtForcePartNo.Size = new System.Drawing.Size(135, 37);
            this.txtForcePartNo.TabIndex = 23;
            this.txtForcePartNo.Text = "1036010031";
            this.txtForcePartNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartNo
            // 
            this.lblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPartNo.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.lblPartNo, 2);
            this.lblPartNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPartNo.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPartNo.Location = new System.Drawing.Point(285, 0);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(88, 37);
            this.lblPartNo.TabIndex = 22;
            this.lblPartNo.Text = "总成零件号：";
            this.lblPartNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtBarCode, 4);
            this.txtBarCode.Location = new System.Drawing.Point(97, 6);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(182, 25);
            this.txtBarCode.TabIndex = 21;
            this.txtBarCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyUp);
            this.txtBarCode.Leave += new System.EventHandler(this.txtBarCode_Leave);
            // 
            // lblBarCode
            // 
            this.lblBarCode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarCode.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.lblBarCode, 2);
            this.lblBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBarCode.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBarCode.Location = new System.Drawing.Point(3, 0);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(88, 37);
            this.lblBarCode.TabIndex = 20;
            this.lblBarCode.Text = "条码：";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForcePLCState
            // 
            this.btnForcePLCState.BackColor = System.Drawing.Color.Transparent;
            this.btnForcePLCState.ButtonColor = System.Drawing.Color.DimGray;
            this.btnForcePLCState.Label = "";
            this.btnForcePLCState.Location = new System.Drawing.Point(802, 3);
            this.btnForcePLCState.Name = "btnForcePLCState";
            this.btnForcePLCState.Renderer = null;
            this.btnForcePLCState.RepeatInterval = 100;
            this.btnForcePLCState.RepeatState = false;
            this.btnForcePLCState.Size = new System.Drawing.Size(41, 31);
            this.btnForcePLCState.StartRepeatInterval = 500;
            this.btnForcePLCState.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnForcePLCState.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnForcePLCState.TabIndex = 26;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.BorderColor = System.Drawing.Color.White;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(803, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 69);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "2020-10-26 10:26:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("华文细黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(69, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(728, 69);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "MODEL Y行李箱--检测工装";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlSystem
            // 
            this.pnlSystem.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlSystem, 2);
            this.pnlSystem.Controls.Add(this.txtContent);
            this.pnlSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSystem.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlSystem.Location = new System.Drawing.Point(552, 210);
            this.pnlSystem.Name = "pnlSystem";
            this.tableLayoutPanel1.SetRowSpan(this.pnlSystem, 2);
            this.pnlSystem.ShowBorder = true;
            this.pnlSystem.Size = new System.Drawing.Size(404, 132);
            this.pnlSystem.TabIndex = 19;
            this.pnlSystem.Text = "系统提示";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Beige;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtContent.Location = new System.Drawing.Point(2, 24);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.SelectControl = null;
            this.txtContent.SelectControlIndex = 0;
            this.txtContent.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.txtContent.Size = new System.Drawing.Size(400, 106);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // axTcpForceClient
            // 
            this.axTcpForceClient.Isclosed = false;
            this.axTcpForceClient.IsStartTcpthreading = false;
            this.axTcpForceClient.Receivestr = null;
            this.axTcpForceClient.ReConectedCount = 0;
            this.axTcpForceClient.ReConnectionTime = 3000;
            this.axTcpForceClient.ServerIp = "192.168.37.1";
            this.axTcpForceClient.ServerPort = 9001;
            this.axTcpForceClient.Tcpclient = null;
            this.axTcpForceClient.Tcpthread = null;
            this.axTcpForceClient.OnReceviceByte += new SocketHelper.AxTcpClient.ReceviceByteEventHandler(this.axTcpForceClient_OnReceviceByte);
            // 
            // FrmForceBootMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "FrmForceBootMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "前行李箱工装";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmForceBootMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FrmForceBootMonitor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.skinPanel2.ResumeLayout(false);
            this.pnlpicReult.ResumeLayout(false);
            this.pnlpicReult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picForceImage)).EndInit();
            this.pnlCountInfo.ResumeLayout(false);
            this.pnlCountInfo.PerformLayout();
            this.pnlStep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommpany)).EndInit();
            this.pnlBasicInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClockLib.AnalogClock analogClock1;
        private CCWin.SkinControl.SkinButton btnSelectHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinCaptionPanel pnlpicReult;
        private CCWin.SkinControl.SkinLabel lblResult;
        private CCWin.SkinControl.SkinPictureBox picForceImage;
        private CCWin.SkinControl.SkinCaptionPanel pnlCountInfo;
        private CCWin.SkinControl.SkinLabel lblNgCount;
        private CCWin.SkinControl.SkinLabel lblNOK;
        private CCWin.SkinControl.SkinLabel lblOKCount;
        private CCWin.SkinControl.SkinLabel lblOK;
        private CCWin.SkinControl.SkinCaptionPanel pnlStep;
        private CCWin.SkinControl.SkinDataGridView gridStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MistakeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsValid;
        private CCWin.SkinControl.SkinPictureBox picCommpany;
        private CCWin.SkinControl.SkinCaptionPanel pnlBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CCWin.SkinControl.SkinCheckBox chkHeart;
        private CCWin.SkinControl.SkinLabel txtForceItemName;
        private CCWin.SkinControl.SkinLabel lblItemName;
        private CCWin.SkinControl.SkinLabel txtForcePartNo;
        private CCWin.SkinControl.SkinLabel lblPartNo;
        private System.Windows.Forms.TextBox txtBarCode;
        private CCWin.SkinControl.SkinLabel lblBarCode;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnForcePLCState;
        private CCWin.SkinControl.SkinLabel lblTime;
        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinCaptionPanel pnlSystem;
        private CCWin.SkinControl.SkinChatRichTextBox txtContent;
        private SocketHelper.AxTcpClient axTcpForceClient;
        private CCWin.SkinControl.SkinButton btnPlc;
        private CCWin.SkinControl.SkinButton btnCloseLightAction;
        private CCWin.SkinControl.SkinButton btnOpenLigntAction;
        private CCWin.SkinControl.SkinButton btnRest;
    }
}

