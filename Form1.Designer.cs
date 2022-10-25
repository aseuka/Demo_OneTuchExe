namespace Demo_OneTuchExe
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbExeFilePath = new System.Windows.Forms.Label();
            this.lbTargetFilePath = new System.Windows.Forms.Label();
            this.chkRunAs = new System.Windows.Forms.CheckBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnExeFileOpen = new System.Windows.Forms.Button();
            this.btnTargetFileOpen = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1142, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtLog, 3);
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 138);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1210, 323);
            this.txtLog.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbExeFilePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTargetFilePath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkRunAs, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnExeFileOpen, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTargetFileOpen, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTest, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 490);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1210, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "원터치";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "실행파일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "대상파일";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "관리자 여부";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "타이틀";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbExeFilePath
            // 
            this.lbExeFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExeFilePath.Location = new System.Drawing.Point(103, 26);
            this.lbExeFilePath.Name = "lbExeFilePath";
            this.lbExeFilePath.Size = new System.Drawing.Size(1010, 26);
            this.lbExeFilePath.TabIndex = 4;
            this.lbExeFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTargetFilePath
            // 
            this.lbTargetFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTargetFilePath.Location = new System.Drawing.Point(103, 52);
            this.lbTargetFilePath.Name = "lbTargetFilePath";
            this.lbTargetFilePath.Size = new System.Drawing.Size(1010, 26);
            this.lbTargetFilePath.TabIndex = 4;
            this.lbTargetFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkRunAs
            // 
            this.chkRunAs.AutoSize = true;
            this.chkRunAs.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkRunAs.Location = new System.Drawing.Point(103, 81);
            this.chkRunAs.Name = "chkRunAs";
            this.chkRunAs.Size = new System.Drawing.Size(88, 20);
            this.chkRunAs.TabIndex = 5;
            this.chkRunAs.Text = "관리자 모드";
            this.chkRunAs.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Location = new System.Drawing.Point(103, 104);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1010, 26);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExeFileOpen
            // 
            this.btnExeFileOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExeFileOpen.Location = new System.Drawing.Point(1119, 29);
            this.btnExeFileOpen.Name = "btnExeFileOpen";
            this.btnExeFileOpen.Size = new System.Drawing.Size(94, 20);
            this.btnExeFileOpen.TabIndex = 6;
            this.btnExeFileOpen.Text = "찾기";
            this.btnExeFileOpen.UseVisualStyleBackColor = true;
            this.btnExeFileOpen.Click += new System.EventHandler(this.btnExeFileOpen_Click);
            // 
            // btnTargetFileOpen
            // 
            this.btnTargetFileOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTargetFileOpen.Location = new System.Drawing.Point(1119, 55);
            this.btnTargetFileOpen.Name = "btnTargetFileOpen";
            this.btnTargetFileOpen.Size = new System.Drawing.Size(94, 20);
            this.btnTargetFileOpen.TabIndex = 6;
            this.btnTargetFileOpen.Text = "찾기";
            this.btnTargetFileOpen.UseVisualStyleBackColor = true;
            this.btnTargetFileOpen.Click += new System.EventHandler(this.btnTargetFileOpen_Click);
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTest.Location = new System.Drawing.Point(1119, 107);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 20);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Location = new System.Drawing.Point(1119, 467);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 20);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = ".Reg";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(103, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1010, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "!!주의 :: *.jsexe  파일내 경로 지정 시 \\\\문자를 2개씩 붙여줘야 함.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1216, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbExeFilePath;
        private System.Windows.Forms.Label lbTargetFilePath;
        private System.Windows.Forms.CheckBox chkRunAs;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnExeFileOpen;
        private System.Windows.Forms.Button btnTargetFileOpen;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
    }
}

