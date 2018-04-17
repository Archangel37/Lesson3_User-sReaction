namespace Lesson3_UserResponse
{
    partial class UR_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UR_MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxClick = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClicksPerMin = new System.Windows.Forms.TextBox();
            this.buttonCalculateClicks = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.checkBoxHardcoreOn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBoxClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество измерений";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(203, 25);
            this.numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBoxClick
            // 
            this.groupBoxClick.Controls.Add(this.label2);
            this.groupBoxClick.Controls.Add(this.textBoxClicksPerMin);
            this.groupBoxClick.Controls.Add(this.buttonCalculateClicks);
            this.groupBoxClick.Location = new System.Drawing.Point(662, 12);
            this.groupBoxClick.Name = "groupBoxClick";
            this.groupBoxClick.Size = new System.Drawing.Size(368, 426);
            this.groupBoxClick.TabIndex = 2;
            this.groupBoxClick.TabStop = false;
            this.groupBoxClick.Text = "Кликомер =) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // textBoxClicksPerMin
            // 
            this.textBoxClicksPerMin.Enabled = false;
            this.textBoxClicksPerMin.Location = new System.Drawing.Point(67, 163);
            this.textBoxClicksPerMin.Name = "textBoxClicksPerMin";
            this.textBoxClicksPerMin.Size = new System.Drawing.Size(198, 20);
            this.textBoxClicksPerMin.TabIndex = 1;
            // 
            // buttonCalculateClicks
            // 
            this.buttonCalculateClicks.Location = new System.Drawing.Point(95, 189);
            this.buttonCalculateClicks.Name = "buttonCalculateClicks";
            this.buttonCalculateClicks.Size = new System.Drawing.Size(151, 117);
            this.buttonCalculateClicks.TabIndex = 0;
            this.buttonCalculateClicks.Text = "> Двойной клик  <";
            this.buttonCalculateClicks.UseVisualStyleBackColor = true;
            this.buttonCalculateClicks.Click += new System.EventHandler(this.buttonCalculateClicks_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(46, 154);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(88, 78);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Test!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraph.Location = new System.Drawing.Point(189, 63);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(467, 375);
            this.pictureBoxGraph.TabIndex = 4;
            this.pictureBoxGraph.TabStop = false;
            // 
            // checkBoxHardcoreOn
            // 
            this.checkBoxHardcoreOn.AutoSize = true;
            this.checkBoxHardcoreOn.Location = new System.Drawing.Point(31, 90);
            this.checkBoxHardcoreOn.Name = "checkBoxHardcoreOn";
            this.checkBoxHardcoreOn.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHardcoreOn.TabIndex = 5;
            this.checkBoxHardcoreOn.Text = "Hardcore Test!!!";
            this.checkBoxHardcoreOn.UseVisualStyleBackColor = true;
            // 
            // UR_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.checkBoxHardcoreOn);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxClick);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "UR_MainForm";
            this.Text = "User\'s Response";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBoxClick.ResumeLayout(false);
            this.groupBoxClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.GroupBox groupBoxClick;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Button buttonCalculateClicks;
        private System.Windows.Forms.TextBox textBoxClicksPerMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxHardcoreOn;
    }
}

