namespace Step_Motor_Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stepText = new Label();
            degreeText = new Label();
            startButton = new Button();
            resultListBox = new ListBox();
            stepBox = new TextBox();
            degreeBox = new ComboBox();
            label1 = new Label();
            portsBox = new ComboBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // stepText
            // 
            stepText.AutoSize = true;
            stepText.Location = new Point(12, 9);
            stepText.Name = "stepText";
            stepText.Size = new Size(323, 20);
            stepText.TabIndex = 0;
            stepText.Text = "Aşağıya kaç adımda dönemesi gerektiğini girin.";
            // 
            // degreeText
            // 
            degreeText.AutoSize = true;
            degreeText.Location = new Point(12, 63);
            degreeText.Name = "degreeText";
            degreeText.Size = new Size(277, 20);
            degreeText.TabIndex = 1;
            degreeText.Text = "Aşağıdan size uygun olan dereceyi seçin.";
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 153);
            startButton.Name = "startButton";
            startButton.Size = new Size(323, 29);
            startButton.TabIndex = 3;
            startButton.Text = "Başlat";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_ClickAsync;
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.Location = new Point(12, 188);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(323, 244);
            resultListBox.TabIndex = 4;
            // 
            // stepBox
            // 
            stepBox.Location = new Point(12, 32);
            stepBox.Name = "stepBox";
            stepBox.Size = new Size(323, 27);
            stepBox.TabIndex = 5;
            stepBox.TextChanged += stepBox_TextChanged;
            // 
            // degreeBox
            // 
            degreeBox.FormattingEnabled = true;
            degreeBox.Location = new Point(12, 86);
            degreeBox.Name = "degreeBox";
            degreeBox.Size = new Size(323, 28);
            degreeBox.TabIndex = 6;
            degreeBox.SelectedIndexChanged += degreeBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 435);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 7;
            label1.Text = "Bağlantı Ayarları";
            // 
            // portsBox
            // 
            portsBox.FormattingEnabled = true;
            portsBox.Location = new Point(12, 458);
            portsBox.Name = "portsBox";
            portsBox.Size = new Size(323, 28);
            portsBox.TabIndex = 8;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(12, 492);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(323, 29);
            connectBtn.TabIndex = 9;
            connectBtn.Text = "Bağlan";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(12, 527);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(323, 29);
            disconnectBtn.TabIndex = 10;
            disconnectBtn.Text = "Bağlantıyı Kes";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(12, 120);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(323, 27);
            resultBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 590);
            Controls.Add(resultBox);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(portsBox);
            Controls.Add(label1);
            Controls.Add(degreeBox);
            Controls.Add(stepBox);
            Controls.Add(resultListBox);
            Controls.Add(startButton);
            Controls.Add(degreeText);
            Controls.Add(stepText);
            Name = "Form1";
            Text = "Step Motor Arayüzü";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stepText;
        private Label degreeText;
        private Button startButton;
        private ListBox resultListBox;
        private TextBox stepBox;
        private ComboBox degreeBox;
        private Label label1;
        private ComboBox portsBox;
        private Button connectBtn;
        private Button disconnectBtn;
        private TextBox resultBox;
    }
}
