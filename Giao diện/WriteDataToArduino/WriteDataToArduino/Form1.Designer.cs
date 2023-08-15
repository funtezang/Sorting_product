namespace WriteDataToArduino
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.sensorValue = new System.Windows.Forms.Label();
            this.textDateReceive = new System.Windows.Forms.TextBox();
            this.Communications = new System.Windows.Forms.GroupBox();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.selectBaudrate = new System.Windows.Forms.Label();
            this.selectCom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yellow = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Label();
            this.textRedCount = new System.Windows.Forms.TextBox();
            this.textBlueCount = new System.Windows.Forms.TextBox();
            this.textYellowCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Communications.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(134, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(533, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Điều khiển hệ thống phân loại sản phẩm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(23, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(155, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(23, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AccessibleDescription = "";
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(155, 170);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 27);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Kết thúc";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // sensorValue
            // 
            this.sensorValue.AutoSize = true;
            this.sensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorValue.Location = new System.Drawing.Point(6, 25);
            this.sensorValue.Name = "sensorValue";
            this.sensorValue.Size = new System.Drawing.Size(191, 20);
            this.sensorValue.TabIndex = 5;
            this.sensorValue.Text = "Giá trị cảm biến màu sắc :";
            // 
            // textDateReceive
            // 
            this.textDateReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDateReceive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDateReceive.Location = new System.Drawing.Point(10, 58);
            this.textDateReceive.Multiline = true;
            this.textDateReceive.Name = "textDateReceive";
            this.textDateReceive.Size = new System.Drawing.Size(279, 139);
            this.textDateReceive.TabIndex = 6;
            // 
            // Communications
            // 
            this.Communications.Controls.Add(this.btnStop);
            this.Communications.Controls.Add(this.btnStart);
            this.Communications.Controls.Add(this.cbxBaudrate);
            this.Communications.Controls.Add(this.cbxCom);
            this.Communications.Controls.Add(this.button2);
            this.Communications.Controls.Add(this.button1);
            this.Communications.Controls.Add(this.selectBaudrate);
            this.Communications.Controls.Add(this.selectCom);
            this.Communications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Communications.Location = new System.Drawing.Point(58, 93);
            this.Communications.Name = "Communications";
            this.Communications.Size = new System.Drawing.Size(300, 216);
            this.Communications.TabIndex = 7;
            this.Communications.TabStop = false;
            this.Communications.Text = "Điều khiển";
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Location = new System.Drawing.Point(155, 77);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(116, 24);
            this.cbxBaudrate.TabIndex = 3;
            // 
            // cbxCom
            // 
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Location = new System.Drawing.Point(155, 31);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(116, 24);
            this.cbxCom.TabIndex = 2;
            // 
            // selectBaudrate
            // 
            this.selectBaudrate.AutoSize = true;
            this.selectBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBaudrate.Location = new System.Drawing.Point(19, 81);
            this.selectBaudrate.Name = "selectBaudrate";
            this.selectBaudrate.Size = new System.Drawing.Size(130, 20);
            this.selectBaudrate.TabIndex = 1;
            this.selectBaudrate.Text = "Chọn Baudrate";
            // 
            // selectCom
            // 
            this.selectCom.AutoSize = true;
            this.selectCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCom.Location = new System.Drawing.Point(19, 35);
            this.selectCom.Name = "selectCom";
            this.selectCom.Size = new System.Drawing.Size(95, 20);
            this.selectCom.TabIndex = 0;
            this.selectCom.Text = "Chọn COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDateReceive);
            this.groupBox1.Controls.Add(this.sensorValue);
            this.groupBox1.Location = new System.Drawing.Point(450, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow.Location = new System.Drawing.Point(234, 59);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(71, 20);
            this.yellow.TabIndex = 9;
            this.yellow.Text = "Xanh lục";
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.Location = new System.Drawing.Point(234, 89);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(76, 20);
            this.blue.TabIndex = 8;
            this.blue.Text = "Xanh lam";
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red.Location = new System.Drawing.Point(234, 27);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(30, 20);
            this.Red.TabIndex = 7;
            this.Red.Text = "Đỏ";
            // 
            // textRedCount
            // 
            this.textRedCount.Location = new System.Drawing.Point(320, 27);
            this.textRedCount.Name = "textRedCount";
            this.textRedCount.Size = new System.Drawing.Size(47, 20);
            this.textRedCount.TabIndex = 10;
            this.textRedCount.Text = "0";
            this.textRedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBlueCount
            // 
            this.textBlueCount.Location = new System.Drawing.Point(320, 89);
            this.textBlueCount.Name = "textBlueCount";
            this.textBlueCount.Size = new System.Drawing.Size(47, 20);
            this.textBlueCount.TabIndex = 11;
            this.textBlueCount.Text = "0";
            this.textBlueCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textYellowCount
            // 
            this.textYellowCount.Location = new System.Drawing.Point(320, 59);
            this.textYellowCount.Name = "textYellowCount";
            this.textYellowCount.Size = new System.Drawing.Size(47, 20);
            this.textYellowCount.TabIndex = 12;
            this.textYellowCount.Text = "0";
            this.textYellowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sản phẩm đã phân loại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBlueCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textYellowCount);
            this.groupBox2.Controls.Add(this.textRedCount);
            this.groupBox2.Controls.Add(this.Red);
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.yellow);
            this.groupBox2.Location = new System.Drawing.Point(222, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 129);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.Communications);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Sorting product";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Communications.ResumeLayout(false);
            this.Communications.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Label sensorValue;
        private System.Windows.Forms.TextBox textDateReceive;
        private System.Windows.Forms.GroupBox Communications;
        private System.Windows.Forms.Label selectCom;
        private System.Windows.Forms.Label selectBaudrate;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yellow;
        private System.Windows.Forms.Label blue;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.TextBox textYellowCount;
        private System.Windows.Forms.TextBox textBlueCount;
        private System.Windows.Forms.TextBox textRedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

