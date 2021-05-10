
namespace OOP_Prot5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TolshinaBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorFillBox = new System.Windows.Forms.ComboBox();
            this.FigureBox = new System.Windows.Forms.ComboBox();
            this.ColorOutlineLabel = new System.Windows.Forms.Label();
            this.ColorFillLabel = new System.Windows.Forms.Label();
            this.TypeFigureLabel = new System.Windows.Forms.Label();
            this.ThicknessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_Button);
            // 
            // TolshinaBox
            // 
            this.TolshinaBox.FormattingEnabled = true;
            this.TolshinaBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.TolshinaBox.Location = new System.Drawing.Point(12, 617);
            this.TolshinaBox.Name = "TolshinaBox";
            this.TolshinaBox.Size = new System.Drawing.Size(121, 21);
            this.TolshinaBox.TabIndex = 2;
            this.TolshinaBox.Text = "Tickness";
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "SALATOVAYA SYLA"});
            this.ColorBox.Location = new System.Drawing.Point(175, 617);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(121, 21);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(930, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ColorFillBox
            // 
            this.ColorFillBox.FormattingEnabled = true;
            this.ColorFillBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "SALATOVAYA SYLA"});
            this.ColorFillBox.Location = new System.Drawing.Point(328, 617);
            this.ColorFillBox.Name = "ColorFillBox";
            this.ColorFillBox.Size = new System.Drawing.Size(121, 21);
            this.ColorFillBox.TabIndex = 5;
            this.ColorFillBox.Text = "ColorFill";
            // 
            // FigureBox
            // 
            this.FigureBox.FormattingEnabled = true;
            this.FigureBox.Items.AddRange(new object[] {
            "Stick",
            "Rectangle"});
            this.FigureBox.Location = new System.Drawing.Point(476, 617);
            this.FigureBox.Name = "FigureBox";
            this.FigureBox.Size = new System.Drawing.Size(92, 21);
            this.FigureBox.TabIndex = 6;
            this.FigureBox.Text = "Figure";
            // 
            // ColorOutlineLabel
            // 
            this.ColorOutlineLabel.AutoSize = true;
            this.ColorOutlineLabel.Location = new System.Drawing.Point(175, 598);
            this.ColorOutlineLabel.Name = "ColorOutlineLabel";
            this.ColorOutlineLabel.Size = new System.Drawing.Size(68, 13);
            this.ColorOutlineLabel.TabIndex = 7;
            this.ColorOutlineLabel.Text = "Color outline:";
            // 
            // ColorFillLabel
            // 
            this.ColorFillLabel.AutoSize = true;
            this.ColorFillLabel.Location = new System.Drawing.Point(328, 597);
            this.ColorFillLabel.Name = "ColorFillLabel";
            this.ColorFillLabel.Size = new System.Drawing.Size(59, 13);
            this.ColorFillLabel.TabIndex = 8;
            this.ColorFillLabel.Text = "Color fullfill:";
            // 
            // TypeFigureLabel
            // 
            this.TypeFigureLabel.AutoSize = true;
            this.TypeFigureLabel.Location = new System.Drawing.Point(476, 598);
            this.TypeFigureLabel.Name = "TypeFigureLabel";
            this.TypeFigureLabel.Size = new System.Drawing.Size(44, 13);
            this.TypeFigureLabel.TabIndex = 9;
            this.TypeFigureLabel.Text = "Figures:";
            // 
            // ThicknessLabel
            // 
            this.ThicknessLabel.AutoSize = true;
            this.ThicknessLabel.Location = new System.Drawing.Point(12, 596);
            this.ThicknessLabel.Name = "ThicknessLabel";
            this.ThicknessLabel.Size = new System.Drawing.Size(59, 13);
            this.ThicknessLabel.TabIndex = 10;
            this.ThicknessLabel.Text = "Thickness:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 650);
            this.Controls.Add(this.ThicknessLabel);
            this.Controls.Add(this.TypeFigureLabel);
            this.Controls.Add(this.ColorFillLabel);
            this.Controls.Add(this.ColorOutlineLabel);
            this.Controls.Add(this.FigureBox);
            this.Controls.Add(this.ColorFillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.TolshinaBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(1287, 689);
            this.MinimumSize = new System.Drawing.Size(1287, 689);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TolshinaBox;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColorFillBox;
        private System.Windows.Forms.ComboBox FigureBox;
        private System.Windows.Forms.Label ColorOutlineLabel;
        private System.Windows.Forms.Label ColorFillLabel;
        private System.Windows.Forms.Label TypeFigureLabel;
        private System.Windows.Forms.Label ThicknessLabel;
    }
}

