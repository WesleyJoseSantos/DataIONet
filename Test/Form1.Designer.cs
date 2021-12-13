
namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbMac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLedStatus = new System.Windows.Forms.TextBox();
            this.tbBool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFloat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDouble = new System.Windows.Forms.TextBox();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbBlinkCount = new System.Windows.Forms.TextBox();
            this.cbEnableBlink = new System.Windows.Forms.CheckBox();
            this.cbManualCmd = new System.Windows.Forms.CheckBox();
            this.tbBlinkTimer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOnline = new System.Windows.Forms.TabPage();
            this.tpLogger = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btOpen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpOnline.SuspendLayout();
            this.tpLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip:";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(105, 45);
            this.tbIp.Name = "tbIp";
            this.tbIp.ReadOnly = true;
            this.tbIp.Size = new System.Drawing.Size(100, 20);
            this.tbIp.TabIndex = 1;
            // 
            // tbMac
            // 
            this.tbMac.Location = new System.Drawing.Point(105, 71);
            this.tbMac.Name = "tbMac";
            this.tbMac.ReadOnly = true;
            this.tbMac.Size = new System.Drawing.Size(100, 20);
            this.tbMac.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mac:";
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(105, 97);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(100, 20);
            this.tbTimer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "LedStatus:";
            // 
            // tbLedStatus
            // 
            this.tbLedStatus.Location = new System.Drawing.Point(105, 123);
            this.tbLedStatus.Name = "tbLedStatus";
            this.tbLedStatus.ReadOnly = true;
            this.tbLedStatus.Size = new System.Drawing.Size(100, 20);
            this.tbLedStatus.TabIndex = 5;
            // 
            // tbBool
            // 
            this.tbBool.Location = new System.Drawing.Point(105, 149);
            this.tbBool.Name = "tbBool";
            this.tbBool.ReadOnly = true;
            this.tbBool.Size = new System.Drawing.Size(100, 20);
            this.tbBool.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Int:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Float:";
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(105, 175);
            this.tbInt.Name = "tbInt";
            this.tbInt.ReadOnly = true;
            this.tbInt.Size = new System.Drawing.Size(100, 20);
            this.tbInt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Double:";
            // 
            // tbFloat
            // 
            this.tbFloat.Location = new System.Drawing.Point(105, 228);
            this.tbFloat.Name = "tbFloat";
            this.tbFloat.ReadOnly = true;
            this.tbFloat.Size = new System.Drawing.Size(100, 20);
            this.tbFloat.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bool:";
            // 
            // tbDouble
            // 
            this.tbDouble.Location = new System.Drawing.Point(105, 254);
            this.tbDouble.Name = "tbDouble";
            this.tbDouble.ReadOnly = true;
            this.tbDouble.Size = new System.Drawing.Size(100, 20);
            this.tbDouble.TabIndex = 7;
            // 
            // serial
            // 
            this.serial.BaudRate = 74400;
            this.serial.PortName = "COM19";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "BlinkCount";
            // 
            // tbBlinkCount
            // 
            this.tbBlinkCount.Location = new System.Drawing.Point(105, 201);
            this.tbBlinkCount.Name = "tbBlinkCount";
            this.tbBlinkCount.ReadOnly = true;
            this.tbBlinkCount.Size = new System.Drawing.Size(100, 20);
            this.tbBlinkCount.TabIndex = 7;
            // 
            // cbEnableBlink
            // 
            this.cbEnableBlink.AutoSize = true;
            this.cbEnableBlink.Location = new System.Drawing.Point(262, 49);
            this.cbEnableBlink.Name = "cbEnableBlink";
            this.cbEnableBlink.Size = new System.Drawing.Size(82, 17);
            this.cbEnableBlink.TabIndex = 8;
            this.cbEnableBlink.Text = "EnableBlink";
            this.cbEnableBlink.UseVisualStyleBackColor = true;
            this.cbEnableBlink.CheckedChanged += new System.EventHandler(this.cbEnableBlink_CheckedChanged);
            // 
            // cbManualCmd
            // 
            this.cbManualCmd.AutoSize = true;
            this.cbManualCmd.Location = new System.Drawing.Point(262, 75);
            this.cbManualCmd.Name = "cbManualCmd";
            this.cbManualCmd.Size = new System.Drawing.Size(82, 17);
            this.cbManualCmd.TabIndex = 9;
            this.cbManualCmd.Text = "ManualCmd";
            this.cbManualCmd.UseVisualStyleBackColor = true;
            this.cbManualCmd.CheckedChanged += new System.EventHandler(this.cbManualCmd_CheckedChanged);
            // 
            // tbBlinkTimer
            // 
            this.tbBlinkTimer.Location = new System.Drawing.Point(330, 100);
            this.tbBlinkTimer.Name = "tbBlinkTimer";
            this.tbBlinkTimer.Size = new System.Drawing.Size(34, 20);
            this.tbBlinkTimer.TabIndex = 10;
            this.tbBlinkTimer.Text = "1000";
            this.tbBlinkTimer.TextChanged += new System.EventHandler(this.tbBlinkTimer_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "BlinkTimer:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOnline);
            this.tabControl1.Controls.Add(this.tpLogger);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 337);
            this.tabControl1.TabIndex = 12;
            // 
            // tpOnline
            // 
            this.tpOnline.Controls.Add(this.tbIp);
            this.tpOnline.Controls.Add(this.label10);
            this.tpOnline.Controls.Add(this.label1);
            this.tpOnline.Controls.Add(this.tbBlinkTimer);
            this.tpOnline.Controls.Add(this.label2);
            this.tpOnline.Controls.Add(this.cbManualCmd);
            this.tpOnline.Controls.Add(this.tbMac);
            this.tpOnline.Controls.Add(this.cbEnableBlink);
            this.tpOnline.Controls.Add(this.label3);
            this.tpOnline.Controls.Add(this.tbDouble);
            this.tpOnline.Controls.Add(this.tbTimer);
            this.tpOnline.Controls.Add(this.label8);
            this.tpOnline.Controls.Add(this.label4);
            this.tpOnline.Controls.Add(this.tbFloat);
            this.tpOnline.Controls.Add(this.tbLedStatus);
            this.tpOnline.Controls.Add(this.label7);
            this.tpOnline.Controls.Add(this.label5);
            this.tpOnline.Controls.Add(this.tbBlinkCount);
            this.tpOnline.Controls.Add(this.tbBool);
            this.tpOnline.Controls.Add(this.tbInt);
            this.tpOnline.Controls.Add(this.label9);
            this.tpOnline.Controls.Add(this.label6);
            this.tpOnline.Location = new System.Drawing.Point(4, 22);
            this.tpOnline.Name = "tpOnline";
            this.tpOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tpOnline.Size = new System.Drawing.Size(437, 311);
            this.tpOnline.TabIndex = 0;
            this.tpOnline.Text = "Monitor";
            this.tpOnline.UseVisualStyleBackColor = true;
            // 
            // tpLogger
            // 
            this.tpLogger.Controls.Add(this.propertyGrid1);
            this.tpLogger.Controls.Add(this.btOpen);
            this.tpLogger.Location = new System.Drawing.Point(4, 22);
            this.tpLogger.Name = "tpLogger";
            this.tpLogger.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogger.Size = new System.Drawing.Size(437, 311);
            this.tpLogger.TabIndex = 1;
            this.tpLogger.Text = "Logger";
            this.tpLogger.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(6, 6);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(423, 268);
            this.propertyGrid1.TabIndex = 1;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(354, 280);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpOnline.ResumeLayout(false);
            this.tpOnline.PerformLayout();
            this.tpLogger.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbMac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLedStatus;
        private System.Windows.Forms.TextBox tbBool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFloat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDouble;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBlinkCount;
        private System.Windows.Forms.CheckBox cbEnableBlink;
        private System.Windows.Forms.CheckBox cbManualCmd;
        private System.Windows.Forms.TextBox tbBlinkTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOnline;
        private System.Windows.Forms.TabPage tpLogger;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btOpen;
    }
}

