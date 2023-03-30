namespace PDFStamper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLoadStamp = new System.Windows.Forms.Button();
            this.stampImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTransparency = new System.Windows.Forms.CheckBox();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStamp = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRotation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stampImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLoadStamp);
            this.groupBox1.Controls.Add(this.stampImage);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изображение";
            // 
            // btLoadStamp
            // 
            this.btLoadStamp.ForeColor = System.Drawing.Color.Black;
            this.btLoadStamp.Location = new System.Drawing.Point(6, 219);
            this.btLoadStamp.Name = "btLoadStamp";
            this.btLoadStamp.Size = new System.Drawing.Size(75, 23);
            this.btLoadStamp.TabIndex = 1;
            this.btLoadStamp.Text = "Загрузить";
            this.btLoadStamp.UseVisualStyleBackColor = true;
            this.btLoadStamp.Click += new System.EventHandler(this.btLoadStamp_Click);
            // 
            // stampImage
            // 
            this.stampImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stampImage.Location = new System.Drawing.Point(6, 19);
            this.stampImage.Name = "stampImage";
            this.stampImage.Size = new System.Drawing.Size(514, 194);
            this.stampImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stampImage.TabIndex = 0;
            this.stampImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTransparency);
            this.groupBox2.Controls.Add(this.tbScale);
            this.groupBox2.Controls.Add(this.tbY);
            this.groupBox2.Controls.Add(this.tbX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // cbTransparency
            // 
            this.cbTransparency.AutoSize = true;
            this.cbTransparency.Location = new System.Drawing.Point(10, 122);
            this.cbTransparency.Name = "cbTransparency";
            this.cbTransparency.Size = new System.Drawing.Size(147, 17);
            this.cbTransparency.TabIndex = 3;
            this.cbTransparency.Text = "Прозрачный белый фон";
            this.cbTransparency.UseVisualStyleBackColor = true;
            this.cbTransparency.CheckedChanged += new System.EventHandler(this.cbTransparency_CheckedChanged);
            // 
            // tbScale
            // 
            this.tbScale.BackColor = System.Drawing.SystemColors.Control;
            this.tbScale.Location = new System.Drawing.Point(108, 86);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(100, 20);
            this.tbScale.TabIndex = 5;
            this.tbScale.Text = "22";
            this.tbScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitals);
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.SystemColors.Control;
            this.tbY.Location = new System.Drawing.Point(108, 55);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 4;
            this.tbY.Text = "0";
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitals);
            // 
            // tbX
            // 
            this.tbX.BackColor = System.Drawing.SystemColors.Control;
            this.tbX.Location = new System.Drawing.Point(108, 24);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "0";
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitals);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Масштаб:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расположение Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расположение Х:";
            // 
            // btStamp
            // 
            this.btStamp.Location = new System.Drawing.Point(366, 420);
            this.btStamp.Name = "btStamp";
            this.btStamp.Size = new System.Drawing.Size(172, 23);
            this.btStamp.TabIndex = 2;
            this.btStamp.Text = "Добавить на PDF - документ";
            this.btStamp.UseVisualStyleBackColor = true;
            this.btStamp.Click += new System.EventHandler(this.btStamp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbRotation);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbPage);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(278, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.SystemColors.Control;
            this.tbPage.Enabled = false;
            this.tbPage.Location = new System.Drawing.Point(108, 24);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(100, 20);
            this.tbPage.TabIndex = 1;
            this.tbPage.Text = "1";
            this.tbPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitals);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер страницы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Наклон:";
            // 
            // tbRotation
            // 
            this.tbRotation.BackColor = System.Drawing.SystemColors.Control;
            this.tbRotation.Location = new System.Drawing.Point(108, 54);
            this.tbRotation.Name = "tbRotation";
            this.tbRotation.Size = new System.Drawing.Size(100, 20);
            this.tbRotation.TabIndex = 3;
            this.tbRotation.Text = "0";
            this.tbRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitals);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btStamp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Stamper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stampImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLoadStamp;
        private System.Windows.Forms.PictureBox stampImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btStamp;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbTransparency;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRotation;
        private System.Windows.Forms.Label label5;
    }
}

