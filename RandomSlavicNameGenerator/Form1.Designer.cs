namespace RandomNameLastNameGenerator
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.sexLabel = new System.Windows.Forms.Label();
            this.maleCB = new System.Windows.Forms.CheckBox();
            this.femaleCB = new System.Windows.Forms.CheckBox();
            this.copyButton1 = new System.Windows.Forms.Button();
            this.copyButton2 = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(13, 27);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(102, 20);
            this.firstNameTB.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(89, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Firtst Name (имя)";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 59);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(113, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name (фамилия)";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(13, 75);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 3;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.SlateGray;
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.Font = new System.Drawing.Font("MS PGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generateButton.Location = new System.Drawing.Point(316, 27);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(171, 68);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "G E N E R A T E";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(15, 118);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(52, 13);
            this.sexLabel.TabIndex = 5;
            this.sexLabel.Text = "Sex (пол)";
            // 
            // maleCB
            // 
            this.maleCB.AutoSize = true;
            this.maleCB.Location = new System.Drawing.Point(18, 144);
            this.maleCB.Name = "maleCB";
            this.maleCB.Size = new System.Drawing.Size(103, 17);
            this.maleCB.TabIndex = 6;
            this.maleCB.Text = "Male (мужской)";
            this.maleCB.UseVisualStyleBackColor = true;
            this.maleCB.CheckedChanged += new System.EventHandler(this.maleCB_CheckedChanged);
            // 
            // femaleCB
            // 
            this.femaleCB.AutoSize = true;
            this.femaleCB.Location = new System.Drawing.Point(18, 168);
            this.femaleCB.Name = "femaleCB";
            this.femaleCB.Size = new System.Drawing.Size(113, 17);
            this.femaleCB.TabIndex = 7;
            this.femaleCB.Text = "Female (женский)";
            this.femaleCB.UseVisualStyleBackColor = true;
            this.femaleCB.CheckedChanged += new System.EventHandler(this.femaleCB_CheckedChanged);
            // 
            // copyButton1
            // 
            this.copyButton1.Location = new System.Drawing.Point(122, 24);
            this.copyButton1.Name = "copyButton1";
            this.copyButton1.Size = new System.Drawing.Size(75, 23);
            this.copyButton1.TabIndex = 8;
            this.copyButton1.Text = "<--Copy";
            this.copyButton1.UseVisualStyleBackColor = true;
            this.copyButton1.Click += new System.EventHandler(this.copyButton1_Click);
            // 
            // copyButton2
            // 
            this.copyButton2.Location = new System.Drawing.Point(122, 72);
            this.copyButton2.Name = "copyButton2";
            this.copyButton2.Size = new System.Drawing.Size(75, 23);
            this.copyButton2.TabIndex = 9;
            this.copyButton2.Text = "<--Copy";
            this.copyButton2.UseVisualStyleBackColor = true;
            this.copyButton2.Click += new System.EventHandler(this.copyButton2_Click);
            // 
            // copyAllButton
            // 
            this.copyAllButton.Location = new System.Drawing.Point(221, 27);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(75, 68);
            this.copyAllButton.TabIndex = 10;
            this.copyAllButton.Text = "COPY ALL";
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.copyAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 184);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.copyButton2);
            this.Controls.Add(this.copyButton1);
            this.Controls.Add(this.femaleCB);
            this.Controls.Add(this.maleCB);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.CheckBox maleCB;
        private System.Windows.Forms.CheckBox femaleCB;
        private System.Windows.Forms.Button copyButton1;
        private System.Windows.Forms.Button copyButton2;
        private System.Windows.Forms.Button copyAllButton;
    }
}

