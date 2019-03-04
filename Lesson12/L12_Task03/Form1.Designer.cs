namespace L12_Task03
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
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.Label_Minutes = new System.Windows.Forms.Label();
            this.Label_Seconds = new System.Windows.Forms.Label();
            this.Label_Millis = new System.Windows.Forms.Label();
            this.Label_Ticks1 = new System.Windows.Forms.Label();
            this.Label_Ticks2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartStop.Location = new System.Drawing.Point(8, 99);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(120, 61);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(148, 99);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 61);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Label_Minutes
            // 
            this.Label_Minutes.AutoSize = true;
            this.Label_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Minutes.Location = new System.Drawing.Point(-3, 20);
            this.Label_Minutes.Name = "Label_Minutes";
            this.Label_Minutes.Size = new System.Drawing.Size(89, 63);
            this.Label_Minutes.TabIndex = 2;
            this.Label_Minutes.Text = "00";
            this.Label_Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Seconds
            // 
            this.Label_Seconds.AutoSize = true;
            this.Label_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Seconds.Location = new System.Drawing.Point(92, 20);
            this.Label_Seconds.Name = "Label_Seconds";
            this.Label_Seconds.Size = new System.Drawing.Size(89, 63);
            this.Label_Seconds.TabIndex = 2;
            this.Label_Seconds.Text = "00";
            this.Label_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Millis
            // 
            this.Label_Millis.AutoSize = true;
            this.Label_Millis.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Millis.Location = new System.Drawing.Point(194, 20);
            this.Label_Millis.Name = "Label_Millis";
            this.Label_Millis.Size = new System.Drawing.Size(89, 63);
            this.Label_Millis.TabIndex = 2;
            this.Label_Millis.Text = "00";
            this.Label_Millis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Ticks1
            // 
            this.Label_Ticks1.AutoSize = true;
            this.Label_Ticks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Ticks1.Location = new System.Drawing.Point(68, 20);
            this.Label_Ticks1.Name = "Label_Ticks1";
            this.Label_Ticks1.Size = new System.Drawing.Size(43, 63);
            this.Label_Ticks1.TabIndex = 2;
            this.Label_Ticks1.Text = ":";
            this.Label_Ticks1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Ticks2
            // 
            this.Label_Ticks2.AutoSize = true;
            this.Label_Ticks2.BackColor = System.Drawing.Color.Transparent;
            this.Label_Ticks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Ticks2.Location = new System.Drawing.Point(164, 20);
            this.Label_Ticks2.Name = "Label_Ticks2";
            this.Label_Ticks2.Size = new System.Drawing.Size(43, 63);
            this.Label_Ticks2.TabIndex = 2;
            this.Label_Ticks2.Text = ":";
            this.Label_Ticks2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 169);
            this.Controls.Add(this.Label_Ticks2);
            this.Controls.Add(this.Label_Millis);
            this.Controls.Add(this.Label_Seconds);
            this.Controls.Add(this.Label_Ticks1);
            this.Controls.Add(this.Label_Minutes);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonStartStop;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Label Label_Minutes;
        public System.Windows.Forms.Label Label_Seconds;
        public System.Windows.Forms.Label Label_Millis;
        public System.Windows.Forms.Label Label_Ticks1;
        public System.Windows.Forms.Label Label_Ticks2;
    }
}

