namespace hwpHelper
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.OpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.axHwpCtrl2 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.PeachPuff;
            this.OpenFile.Location = new System.Drawing.Point(1440, 23);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(126, 57);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "열기";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1440, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.axHwpCtrl1);
            this.flowLayoutPanel1.Controls.Add(this.axHwpCtrl2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1402, 574);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(3, 3);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(1335, 752);
            this.axHwpCtrl1.TabIndex = 4;
            // 
            // axHwpCtrl2
            // 
            this.axHwpCtrl2.Enabled = true;
            this.axHwpCtrl2.Location = new System.Drawing.Point(3, 761);
            this.axHwpCtrl2.Name = "axHwpCtrl2";
            this.axHwpCtrl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl2.OcxState")));
            this.axHwpCtrl2.Size = new System.Drawing.Size(1335, 1091);
            this.axHwpCtrl2.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1619, 912);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenFile);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl2;
    }
}

