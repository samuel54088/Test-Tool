namespace UART_beta
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.label_Com = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.button_ComUpdate = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.Location = new System.Drawing.Point(32, 24);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Com.TabIndex = 0;
            this.comboBox_Com.SelectedIndexChanged += new System.EventHandler(this.comboBox_Com_SelectedIndexChanged);
            // 
            // label_Com
            // 
            this.label_Com.AutoSize = true;
            this.label_Com.Location = new System.Drawing.Point(30, 9);
            this.label_Com.Name = "label_Com";
            this.label_Com.Size = new System.Drawing.Size(31, 12);
            this.label_Com.TabIndex = 1;
            this.label_Com.Text = "COM";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(32, 216);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(32, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 76);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 99);
            this.textBox1.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(232, 152);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "1228800"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(32, 68);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_BaudRate.TabIndex = 6;
            this.comboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_BaudRate_SelectedIndexChanged);
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(30, 53);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(50, 12);
            this.label_BaudRate.TabIndex = 7;
            this.label_BaudRate.Text = "Baud rate";
            // 
            // button_ComUpdate
            // 
            this.button_ComUpdate.Location = new System.Drawing.Point(159, 24);
            this.button_ComUpdate.Name = "button_ComUpdate";
            this.button_ComUpdate.Size = new System.Drawing.Size(49, 20);
            this.button_ComUpdate.TabIndex = 8;
            this.button_ComUpdate.Text = "Update";
            this.button_ComUpdate.UseVisualStyleBackColor = true;
            this.button_ComUpdate.Click += new System.EventHandler(this.button_ComUpdate_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(123, 216);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 9;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 430);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_ComUpdate);
            this.Controls.Add(this.label_BaudRate);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_Com);
            this.Controls.Add(this.comboBox_Com);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Com;
        private System.Windows.Forms.Label label_Com;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.Button button_ComUpdate;
        private System.Windows.Forms.Button button_Disconnect;
    }
}

