namespace LuggageMonitor
{
    partial class FrmRealBootMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCountInfo = new CCWin.SkinControl.SkinCaptionPanel();
            this.lblNgCount = new CCWin.SkinControl.SkinLabel();
            this.lblNOK = new CCWin.SkinControl.SkinLabel();
            this.lblOKCount = new CCWin.SkinControl.SkinLabel();
            this.lblOK = new CCWin.SkinControl.SkinLabel();
            this.pnlSystem = new CCWin.SkinControl.SkinCaptionPanel();
            this.txtContent = new CCWin.SkinControl.SkinChatRichTextBox();
            this.CurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.btnRest = new CCWin.SkinControl.SkinButton();
            this.btnPlc = new CCWin.SkinControl.SkinButton();
            this.btnCloseLightAction2 = new CCWin.SkinControl.SkinButton();
            this.btnOpenLigntAction2 = new CCWin.SkinControl.SkinButton();
            this.btnCloseLightAction1 = new CCWin.SkinControl.SkinButton();
            this.btnOpenLigntAction1 = new CCWin.SkinControl.SkinButton();
            this.btnSelectHistory = new CCWin.SkinControl.SkinButton();
            this.pnlpicReult = new CCWin.SkinControl.SkinCaptionPanel();
            this.picForceImage = new CCWin.SkinControl.SkinPictureBox();
            this.Explain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStep = new CCWin.SkinControl.SkinCaptionPanel();
            this.gridStep = new CCWin.SkinControl.SkinDataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MistakeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picCommpany = new CCWin.SkinControl.SkinPictureBox();
            this.pnlBasicInfo = new CCWin.SkinControl.SkinCaptionPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkHeart = new CCWin.SkinControl.SkinCheckBox();
            this.txtRealItemName = new CCWin.SkinControl.SkinLabel();
            this.lblItemName = new CCWin.SkinControl.SkinLabel();
            this.txtRealPartNo = new CCWin.SkinControl.SkinLabel();
            this.lblPartNo = new CCWin.SkinControl.SkinLabel();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new CCWin.SkinControl.SkinLabel();
            this.btnRealPLCState = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lblTime = new CCWin.SkinControl.SkinLabel();
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.axTcpRealClient = new SocketHelper.AxTcpClient(this.components);
            this.pnlCountInfo.SuspendLayout();
            this.pnlSystem.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.pnlpicReult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picForceImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommpany)).BeginInit();
            this.pnlBasicInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.DefaultCellStyle = dataGridViewCellStyle1;
            this.Result.HeaderText = "结果";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // IsValid
            // 
            this.IsValid.DataPropertyName = "IsValid";
            this.IsValid.HeaderText = "是否有效";
            this.IsValid.Name = "IsValid";
            this.IsValid.ReadOnly = true;
            this.IsValid.Visible = false;
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
            this.pnlCountInfo.Location = new System.Drawing.Point(549, 141);
            this.pnlCountInfo.Name = "pnlCountInfo";
            this.pnlCountInfo.ShowBorder = true;
            this.pnlCountInfo.Size = new System.Drawing.Size(402, 63);
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
            this.lblNgCount.Size = new System.Drawing.Size(17, 16);
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
            this.lblNOK.Size = new System.Drawing.Size(65, 12);
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
            this.lblOKCount.Size = new System.Drawing.Size(17, 16);
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
            this.lblOK.Size = new System.Drawing.Size(53, 12);
            this.lblOK.TabIndex = 21;
            this.lblOK.Text = "合格数：";
            // 
            // pnlSystem
            // 
            this.pnlSystem.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlSystem, 2);
            this.pnlSystem.Controls.Add(this.txtContent);
            this.pnlSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSystem.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlSystem.Location = new System.Drawing.Point(549, 210);
            this.pnlSystem.Name = "pnlSystem";
            this.tableLayoutPanel1.SetRowSpan(this.pnlSystem, 2);
            this.pnlSystem.ShowBorder = true;
            this.pnlSystem.Size = new System.Drawing.Size(402, 132);
            this.pnlSystem.TabIndex = 19;
            this.pnlSystem.Text = "系统提示";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.Info;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtContent.Location = new System.Drawing.Point(2, 24);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.SelectControl = null;
            this.txtContent.SelectControlIndex = 0;
            this.txtContent.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.txtContent.Size = new System.Drawing.Size(398, 106);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
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
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.BorderColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("华文细黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(338, 201);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 32);
            this.lblResult.TabIndex = 3;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.skinPanel2, 4);
            this.skinPanel2.Controls.Add(this.btnRest);
            this.skinPanel2.Controls.Add(this.btnPlc);
            this.skinPanel2.Controls.Add(this.btnCloseLightAction2);
            this.skinPanel2.Controls.Add(this.btnOpenLigntAction2);
            this.skinPanel2.Controls.Add(this.btnCloseLightAction1);
            this.skinPanel2.Controls.Add(this.btnOpenLigntAction1);
            this.skinPanel2.Controls.Add(this.btnSelectHistory);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(3, 624);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(948, 66);
            this.skinPanel2.TabIndex = 20;
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Transparent;
            this.btnRest.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRest.DownBack = null;
            this.btnRest.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRest.Location = new System.Drawing.Point(1, 3);
            this.btnRest.Margin = new System.Windows.Forms.Padding(5);
            this.btnRest.MouseBack = null;
            this.btnRest.Name = "btnRest";
            this.btnRest.NormlBack = null;
            this.btnRest.Size = new System.Drawing.Size(120, 40);
            this.btnRest.TabIndex = 57;
            this.btnRest.Text = "重置";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnPlc
            // 
            this.btnPlc.BackColor = System.Drawing.Color.Transparent;
            this.btnPlc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPlc.DownBack = null;
            this.btnPlc.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlc.Location = new System.Drawing.Point(650, 3);
            this.btnPlc.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlc.MouseBack = null;
            this.btnPlc.Name = "btnPlc";
            this.btnPlc.NormlBack = null;
            this.btnPlc.Size = new System.Drawing.Size(120, 40);
            this.btnPlc.TabIndex = 56;
            this.btnPlc.Text = "PLC监控";
            this.btnPlc.UseVisualStyleBackColor = false;
            this.btnPlc.Click += new System.EventHandler(this.btnPlc_Click);
            // 
            // btnCloseLightAction2
            // 
            this.btnCloseLightAction2.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLightAction2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseLightAction2.DownBack = null;
            this.btnCloseLightAction2.Enabled = false;
            this.btnCloseLightAction2.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseLightAction2.Location = new System.Drawing.Point(518, 3);
            this.btnCloseLightAction2.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseLightAction2.MouseBack = null;
            this.btnCloseLightAction2.Name = "btnCloseLightAction2";
            this.btnCloseLightAction2.NormlBack = null;
            this.btnCloseLightAction2.Size = new System.Drawing.Size(120, 40);
            this.btnCloseLightAction2.TabIndex = 11;
            this.btnCloseLightAction2.Text = "电磁阀夹紧";
            this.btnCloseLightAction2.UseVisualStyleBackColor = false;
            this.btnCloseLightAction2.Click += new System.EventHandler(this.btnCloseLightAction2_Click);
            // 
            // btnOpenLigntAction2
            // 
            this.btnOpenLigntAction2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLigntAction2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenLigntAction2.DownBack = null;
            this.btnOpenLigntAction2.Enabled = false;
            this.btnOpenLigntAction2.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLigntAction2.Location = new System.Drawing.Point(390, 3);
            this.btnOpenLigntAction2.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenLigntAction2.MouseBack = null;
            this.btnOpenLigntAction2.Name = "btnOpenLigntAction2";
            this.btnOpenLigntAction2.NormlBack = null;
            this.btnOpenLigntAction2.Size = new System.Drawing.Size(120, 40);
            this.btnOpenLigntAction2.TabIndex = 10;
            this.btnOpenLigntAction2.Text = "电磁阀松开";
            this.btnOpenLigntAction2.UseVisualStyleBackColor = false;
            this.btnOpenLigntAction2.Click += new System.EventHandler(this.btnOpenLigntAction2_Click);
            // 
            // btnCloseLightAction1
            // 
            this.btnCloseLightAction1.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLightAction1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseLightAction1.DownBack = null;
            this.btnCloseLightAction1.Enabled = false;
            this.btnCloseLightAction1.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseLightAction1.Location = new System.Drawing.Point(260, 3);
            this.btnCloseLightAction1.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseLightAction1.MouseBack = null;
            this.btnCloseLightAction1.Name = "btnCloseLightAction1";
            this.btnCloseLightAction1.NormlBack = null;
            this.btnCloseLightAction1.Size = new System.Drawing.Size(120, 40);
            this.btnCloseLightAction1.TabIndex = 9;
            this.btnCloseLightAction1.Text = "电磁阀下降";
            this.btnCloseLightAction1.UseVisualStyleBackColor = false;
            this.btnCloseLightAction1.Click += new System.EventHandler(this.btnCloseLightAction1_Click);
            // 
            // btnOpenLigntAction1
            // 
            this.btnOpenLigntAction1.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLigntAction1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenLigntAction1.DownBack = null;
            this.btnOpenLigntAction1.Enabled = false;
            this.btnOpenLigntAction1.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLigntAction1.Location = new System.Drawing.Point(132, 3);
            this.btnOpenLigntAction1.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenLigntAction1.MouseBack = null;
            this.btnOpenLigntAction1.Name = "btnOpenLigntAction1";
            this.btnOpenLigntAction1.NormlBack = null;
            this.btnOpenLigntAction1.Size = new System.Drawing.Size(120, 40);
            this.btnOpenLigntAction1.TabIndex = 8;
            this.btnOpenLigntAction1.Text = "电磁阀上升";
            this.btnOpenLigntAction1.UseVisualStyleBackColor = false;
            this.btnOpenLigntAction1.Click += new System.EventHandler(this.btnOpenLigntAction1_Click);
            // 
            // btnSelectHistory
            // 
            this.btnSelectHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectHistory.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelectHistory.DownBack = null;
            this.btnSelectHistory.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectHistory.Location = new System.Drawing.Point(776, 3);
            this.btnSelectHistory.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectHistory.MouseBack = null;
            this.btnSelectHistory.Name = "btnSelectHistory";
            this.btnSelectHistory.NormlBack = null;
            this.btnSelectHistory.Size = new System.Drawing.Size(120, 40);
            this.btnSelectHistory.TabIndex = 6;
            this.btnSelectHistory.Text = "历史查询";
            this.btnSelectHistory.UseVisualStyleBackColor = false;
            this.btnSelectHistory.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlpicReult
            // 
            this.pnlpicReult.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlpicReult, 2);
            this.pnlpicReult.Controls.Add(this.lblResult);
            this.pnlpicReult.Controls.Add(this.picForceImage);
            this.pnlpicReult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpicReult.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlpicReult.Location = new System.Drawing.Point(549, 348);
            this.pnlpicReult.Name = "pnlpicReult";
            this.tableLayoutPanel1.SetRowSpan(this.pnlpicReult, 4);
            this.pnlpicReult.ShowBorder = true;
            this.pnlpicReult.Size = new System.Drawing.Size(402, 270);
            this.pnlpicReult.TabIndex = 4;
            this.pnlpicReult.Text = "拍照结果";
            // 
            // picForceImage
            // 
            this.picForceImage.BackColor = System.Drawing.Color.Transparent;
            this.picForceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picForceImage.Image = global::LuggageMonitor.Properties.Resources.q;
            this.picForceImage.ImageLocation = "";
            this.picForceImage.Location = new System.Drawing.Point(2, 24);
            this.picForceImage.Name = "picForceImage";
            this.picForceImage.Size = new System.Drawing.Size(398, 244);
            this.picForceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForceImage.TabIndex = 0;
            this.picForceImage.TabStop = false;
            // 
            // Explain
            // 
            this.Explain.DataPropertyName = "Explain";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Explain.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 693);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.pnlStep.Size = new System.Drawing.Size(540, 477);
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
            this.gridStep.Size = new System.Drawing.Size(536, 451);
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
            this.picCommpany.Click += new System.EventHandler(this.picCommpany_Click);
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
            this.pnlBasicInfo.Size = new System.Drawing.Size(948, 63);
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
            this.tableLayoutPanel2.Controls.Add(this.txtRealItemName, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblItemName, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRealPartNo, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPartNo, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBarCode, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBarCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRealPLCState, 17, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(944, 37);
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
            this.chkHeart.Location = new System.Drawing.Point(865, 8);
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
            // txtRealItemName
            // 
            this.txtRealItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtRealItemName.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.txtRealItemName, 3);
            this.txtRealItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRealItemName.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealItemName.Location = new System.Drawing.Point(614, 0);
            this.txtRealItemName.Name = "txtRealItemName";
            this.txtRealItemName.Size = new System.Drawing.Size(135, 37);
            this.txtRealItemName.TabIndex = 25;
            this.txtRealItemName.Text = "MODEL Y 后行李箱";
            this.txtRealItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtRealPartNo
            // 
            this.txtRealPartNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRealPartNo.BorderColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.txtRealPartNo, 3);
            this.txtRealPartNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRealPartNo.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealPartNo.Location = new System.Drawing.Point(379, 0);
            this.txtRealPartNo.Name = "txtRealPartNo";
            this.txtRealPartNo.Size = new System.Drawing.Size(135, 37);
            this.txtRealPartNo.TabIndex = 23;
            this.txtRealPartNo.Text = "1036010031";
            this.txtRealPartNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.SetColumnSpan(this.txtBarCode, 4);
            this.txtBarCode.Location = new System.Drawing.Point(97, 3);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
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
            // btnRealPLCState
            // 
            this.btnRealPLCState.BackColor = System.Drawing.Color.Transparent;
            this.btnRealPLCState.ButtonColor = System.Drawing.Color.DimGray;
            this.btnRealPLCState.Label = "";
            this.btnRealPLCState.Location = new System.Drawing.Point(802, 3);
            this.btnRealPLCState.Name = "btnRealPLCState";
            this.btnRealPLCState.Renderer = null;
            this.btnRealPLCState.RepeatInterval = 100;
            this.btnRealPLCState.RepeatState = false;
            this.btnRealPLCState.Size = new System.Drawing.Size(41, 31);
            this.btnRealPLCState.StartRepeatInterval = 500;
            this.btnRealPLCState.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.btnRealPLCState.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.btnRealPLCState.TabIndex = 26;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.BorderColor = System.Drawing.Color.White;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(799, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(152, 69);
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
            this.lblTitle.Size = new System.Drawing.Size(724, 69);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "MODEL Y行李箱--检测工装";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axTcpRealClient
            // 
            this.axTcpRealClient.Isclosed = false;
            this.axTcpRealClient.IsStartTcpthreading = false;
            this.axTcpRealClient.Receivestr = null;
            this.axTcpRealClient.ReConectedCount = 0;
            this.axTcpRealClient.ReConnectionTime = 3000;
            this.axTcpRealClient.ServerIp = "192.168.37.1";
            this.axTcpRealClient.ServerPort = 9001;
            this.axTcpRealClient.Tcpclient = null;
            this.axTcpRealClient.Tcpthread = null;
            this.axTcpRealClient.OnReceviceByte += new SocketHelper.AxTcpClient.ReceviceByteEventHandler(this.axTcpRealClient_OnReceviceByte);
            // 
            // FrmRealBootMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(962, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "FrmRealBootMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "后行李箱工装";
            this.AutoSizeChanged += new System.EventHandler(this.FrmRealBootMonitor_AutoSizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRealBootMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FrmRealBootMonitor_Load);
            this.pnlCountInfo.ResumeLayout(false);
            this.pnlCountInfo.PerformLayout();
            this.pnlSystem.ResumeLayout(false);
            this.skinPanel2.ResumeLayout(false);
            this.pnlpicReult.ResumeLayout(false);
            this.pnlpicReult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picForceImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlStep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommpany)).EndInit();
            this.pnlBasicInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsValid;
        private CCWin.SkinControl.SkinCaptionPanel pnlCountInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinButton btnRest;
        private CCWin.SkinControl.SkinButton btnPlc;
        private CCWin.SkinControl.SkinButton btnCloseLightAction2;
        private CCWin.SkinControl.SkinButton btnOpenLigntAction2;
        private CCWin.SkinControl.SkinButton btnCloseLightAction1;
        private CCWin.SkinControl.SkinButton btnOpenLigntAction1;
        private CCWin.SkinControl.SkinButton btnSelectHistory;
        private CCWin.SkinControl.SkinCaptionPanel pnlpicReult;
        private CCWin.SkinControl.SkinLabel lblResult;
        private CCWin.SkinControl.SkinPictureBox picForceImage;
        private CCWin.SkinControl.SkinCaptionPanel pnlStep;
        private CCWin.SkinControl.SkinDataGridView gridStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MistakeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explain;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentValue;
        private CCWin.SkinControl.SkinPictureBox picCommpany;
        private CCWin.SkinControl.SkinCaptionPanel pnlBasicInfo;
        private CCWin.SkinControl.SkinLabel lblTime;
        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinCaptionPanel pnlSystem;
        private CCWin.SkinControl.SkinChatRichTextBox txtContent;
        private CCWin.SkinControl.SkinLabel lblNgCount;
        private CCWin.SkinControl.SkinLabel lblNOK;
        private CCWin.SkinControl.SkinLabel lblOKCount;
        private CCWin.SkinControl.SkinLabel lblOK;
        private SocketHelper.AxTcpClient axTcpRealClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CCWin.SkinControl.SkinLabel lblBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private CCWin.SkinControl.SkinLabel lblPartNo;
        private CCWin.SkinControl.SkinLabel txtRealPartNo;
        private CCWin.SkinControl.SkinLabel lblItemName;
        private CCWin.SkinControl.SkinLabel txtRealItemName;
        private LBSoft.IndustrialCtrls.Buttons.LBButton btnRealPLCState;
        private CCWin.SkinControl.SkinCheckBox chkHeart;


    }
}