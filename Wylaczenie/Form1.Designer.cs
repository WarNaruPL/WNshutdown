namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.czas = new System.Windows.Forms.RadioButton();
            this.Godziny = new System.Windows.Forms.CheckBox();
            this.Minuty = new System.Windows.Forms.CheckBox();
            this.Sekundy = new System.Windows.Forms.CheckBox();
            this.GodzinyInput = new System.Windows.Forms.TextBox();
            this.MinutyInput = new System.Windows.Forms.TextBox();
            this.SekundyInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftTime = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Wyloguj = new System.Windows.Forms.RadioButton();
            this.Wylaczenie = new System.Windows.Forms.RadioButton();
            this.Hibernacja = new System.Windows.Forms.RadioButton();
            this.rodzaje = new System.Windows.Forms.GroupBox();
            this.Uspienie = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.rodzaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Checked = true;
            this.czas.Enabled = false;
            this.czas.Location = new System.Drawing.Point(12, 12);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(127, 17);
            this.czas.TabIndex = 0;
            this.czas.TabStop = true;
            this.czas.Text = "Wyłączenie czasowe";
            this.czas.UseVisualStyleBackColor = true;
            // 
            // Godziny
            // 
            this.Godziny.AutoSize = true;
            this.Godziny.Checked = true;
            this.Godziny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Godziny.Location = new System.Drawing.Point(35, 28);
            this.Godziny.Name = "Godziny";
            this.Godziny.Size = new System.Drawing.Size(64, 17);
            this.Godziny.TabIndex = 1;
            this.Godziny.Text = "Godziny";
            this.Godziny.UseVisualStyleBackColor = true;
            this.Godziny.CheckedChanged += new System.EventHandler(this.Godziny_CheckedChanged);
            // 
            // Minuty
            // 
            this.Minuty.AutoSize = true;
            this.Minuty.Checked = true;
            this.Minuty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Minuty.Location = new System.Drawing.Point(185, 28);
            this.Minuty.Name = "Minuty";
            this.Minuty.Size = new System.Drawing.Size(57, 17);
            this.Minuty.TabIndex = 2;
            this.Minuty.Text = "Minuty";
            this.Minuty.UseVisualStyleBackColor = true;
            this.Minuty.CheckedChanged += new System.EventHandler(this.Minuty_CheckedChanged);
            // 
            // Sekundy
            // 
            this.Sekundy.AutoSize = true;
            this.Sekundy.Checked = true;
            this.Sekundy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sekundy.Location = new System.Drawing.Point(335, 28);
            this.Sekundy.Name = "Sekundy";
            this.Sekundy.Size = new System.Drawing.Size(68, 17);
            this.Sekundy.TabIndex = 3;
            this.Sekundy.Text = "Sekundy";
            this.Sekundy.UseVisualStyleBackColor = true;
            this.Sekundy.CheckedChanged += new System.EventHandler(this.Sekundy_CheckedChanged);
            // 
            // GodzinyInput
            // 
            this.GodzinyInput.Location = new System.Drawing.Point(35, 51);
            this.GodzinyInput.Name = "GodzinyInput";
            this.GodzinyInput.Size = new System.Drawing.Size(80, 20);
            this.GodzinyInput.TabIndex = 4;
            this.GodzinyInput.Leave += new System.EventHandler(this.GodzinyInput_Leave);
            // 
            // MinutyInput
            // 
            this.MinutyInput.Location = new System.Drawing.Point(185, 51);
            this.MinutyInput.Name = "MinutyInput";
            this.MinutyInput.Size = new System.Drawing.Size(80, 20);
            this.MinutyInput.TabIndex = 5;
            this.MinutyInput.Leave += new System.EventHandler(this.MinutyInput_Leave);
            // 
            // SekundyInput
            // 
            this.SekundyInput.Location = new System.Drawing.Point(335, 51);
            this.SekundyInput.Name = "SekundyInput";
            this.SekundyInput.Size = new System.Drawing.Size(80, 20);
            this.SekundyInput.TabIndex = 6;
            this.SekundyInput.Leave += new System.EventHandler(this.SekundyInput_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftTime);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.Godziny);
            this.groupBox1.Controls.Add(this.SekundyInput);
            this.groupBox1.Controls.Add(this.Minuty);
            this.groupBox1.Controls.Add(this.MinutyInput);
            this.groupBox1.Controls.Add(this.Sekundy);
            this.groupBox1.Controls.Add(this.GodzinyInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wylaczenie Czasowe";
            // 
            // leftTime
            // 
            this.leftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftTime.Location = new System.Drawing.Point(6, 74);
            this.leftTime.Name = "leftTime";
            this.leftTime.Size = new System.Drawing.Size(448, 58);
            this.leftTime.TabIndex = 8;
            this.leftTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(180, 135);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 23);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.AutoSize = true;
            this.Wyloguj.Location = new System.Drawing.Point(23, 15);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(63, 17);
            this.Wyloguj.TabIndex = 8;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            // 
            // Wylaczenie
            // 
            this.Wylaczenie.AutoSize = true;
            this.Wylaczenie.Checked = true;
            this.Wylaczenie.Location = new System.Drawing.Point(119, 15);
            this.Wylaczenie.Name = "Wylaczenie";
            this.Wylaczenie.Size = new System.Drawing.Size(82, 17);
            this.Wylaczenie.TabIndex = 9;
            this.Wylaczenie.TabStop = true;
            this.Wylaczenie.Text = "Wyłaczenie";
            this.Wylaczenie.UseVisualStyleBackColor = true;
            this.Wylaczenie.CheckedChanged += new System.EventHandler(this.Wylaczenie_CheckedChanged);
            // 
            // Hibernacja
            // 
            this.Hibernacja.AutoSize = true;
            this.Hibernacja.Location = new System.Drawing.Point(339, 15);
            this.Hibernacja.Name = "Hibernacja";
            this.Hibernacja.Size = new System.Drawing.Size(76, 17);
            this.Hibernacja.TabIndex = 10;
            this.Hibernacja.Text = "Hibernacja";
            this.Hibernacja.UseVisualStyleBackColor = true;
            // 
            // rodzaje
            // 
            this.rodzaje.Controls.Add(this.Uspienie);
            this.rodzaje.Controls.Add(this.Hibernacja);
            this.rodzaje.Controls.Add(this.Wyloguj);
            this.rodzaje.Controls.Add(this.Wylaczenie);
            this.rodzaje.Location = new System.Drawing.Point(12, 205);
            this.rodzaje.Name = "rodzaje";
            this.rodzaje.Size = new System.Drawing.Size(460, 45);
            this.rodzaje.TabIndex = 11;
            this.rodzaje.TabStop = false;
            // 
            // Uspienie
            // 
            this.Uspienie.AutoSize = true;
            this.Uspienie.Location = new System.Drawing.Point(240, 15);
            this.Uspienie.Name = "Uspienie";
            this.Uspienie.Size = new System.Drawing.Size(66, 17);
            this.Uspienie.TabIndex = 11;
            this.Uspienie.TabStop = true;
            this.Uspienie.Text = "Uśpienie";
            this.Uspienie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.rodzaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.czas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ShutDown";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rodzaje.ResumeLayout(false);
            this.rodzaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton czas;
        private System.Windows.Forms.CheckBox Godziny;
        private System.Windows.Forms.CheckBox Minuty;
        private System.Windows.Forms.CheckBox Sekundy;
        private System.Windows.Forms.TextBox GodzinyInput;
        private System.Windows.Forms.TextBox MinutyInput;
        private System.Windows.Forms.TextBox SekundyInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label leftTime;
        private System.Windows.Forms.RadioButton Wyloguj;
        private System.Windows.Forms.RadioButton Wylaczenie;
        private System.Windows.Forms.RadioButton Hibernacja;
        private System.Windows.Forms.GroupBox rodzaje;
        private System.Windows.Forms.RadioButton Uspienie;

    }
}

