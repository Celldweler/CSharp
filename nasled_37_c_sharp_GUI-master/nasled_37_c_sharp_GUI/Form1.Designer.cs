namespace nasled_37_c_sharp_GUI
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
            this.panelSquare = new System.Windows.Forms.Panel();
            this.btnAddSquare = new System.Windows.Forms.Button();
            this.richTextBoxSquare = new System.Windows.Forms.RichTextBox();
            this.lblSquarePanelTitle = new System.Windows.Forms.Label();
            this.lblSquareSide = new System.Windows.Forms.Label();
            this.lblSquareTitle = new System.Windows.Forms.Label();
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.txtSquareTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSquarePrizmHeight = new System.Windows.Forms.Label();
            this.txtSquarePrizmHeight = new System.Windows.Forms.TextBox();
            this.richTextBoxSqaurePrizm = new System.Windows.Forms.RichTextBox();
            this.lblSqaurePrizm = new System.Windows.Forms.Label();
            this.lblSqaurePrizmSide = new System.Windows.Forms.Label();
            this.lblSqaurePrizmTitle = new System.Windows.Forms.Label();
            this.txtSqaurePrizmSide = new System.Windows.Forms.TextBox();
            this.txtSqaurePrizmTitle = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelSquaresCounter = new System.Windows.Forms.Label();
            this.panelSquare.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSquare
            // 
            this.panelSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSquare.Controls.Add(this.labelSquaresCounter);
            this.panelSquare.Controls.Add(this.btnAddSquare);
            this.panelSquare.Controls.Add(this.richTextBoxSquare);
            this.panelSquare.Controls.Add(this.lblSquarePanelTitle);
            this.panelSquare.Controls.Add(this.lblSquareSide);
            this.panelSquare.Controls.Add(this.lblSquareTitle);
            this.panelSquare.Controls.Add(this.txtSquareSide);
            this.panelSquare.Controls.Add(this.txtSquareTitle);
            this.panelSquare.Location = new System.Drawing.Point(15, 12);
            this.panelSquare.Margin = new System.Windows.Forms.Padding(2);
            this.panelSquare.Name = "panelSquare";
            this.panelSquare.Size = new System.Drawing.Size(368, 407);
            this.panelSquare.TabIndex = 0;
            // 
            // btnAddSquare
            // 
            this.btnAddSquare.Location = new System.Drawing.Point(87, 143);
            this.btnAddSquare.Name = "btnAddSquare";
            this.btnAddSquare.Size = new System.Drawing.Size(197, 50);
            this.btnAddSquare.TabIndex = 6;
            this.btnAddSquare.Text = "Add square";
            this.btnAddSquare.UseVisualStyleBackColor = true;
            this.btnAddSquare.Click += new System.EventHandler(this.btnAddSquare_Click);
            // 
            // richTextBoxSquare
            // 
            this.richTextBoxSquare.Location = new System.Drawing.Point(24, 199);
            this.richTextBoxSquare.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxSquare.Name = "richTextBoxSquare";
            this.richTextBoxSquare.Size = new System.Drawing.Size(326, 206);
            this.richTextBoxSquare.TabIndex = 5;
            this.richTextBoxSquare.Text = "";
            // 
            // lblSquarePanelTitle
            // 
            this.lblSquarePanelTitle.AutoSize = true;
            this.lblSquarePanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSquarePanelTitle.Location = new System.Drawing.Point(146, 8);
            this.lblSquarePanelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquarePanelTitle.Name = "lblSquarePanelTitle";
            this.lblSquarePanelTitle.Size = new System.Drawing.Size(91, 29);
            this.lblSquarePanelTitle.TabIndex = 4;
            this.lblSquarePanelTitle.Text = "Square";
            // 
            // lblSquareSide
            // 
            this.lblSquareSide.AutoSize = true;
            this.lblSquareSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSquareSide.Location = new System.Drawing.Point(19, 99);
            this.lblSquareSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquareSide.Name = "lblSquareSide";
            this.lblSquareSide.Size = new System.Drawing.Size(63, 29);
            this.lblSquareSide.TabIndex = 3;
            this.lblSquareSide.Text = "Side";
            // 
            // lblSquareTitle
            // 
            this.lblSquareTitle.AutoSize = true;
            this.lblSquareTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSquareTitle.Location = new System.Drawing.Point(19, 65);
            this.lblSquareTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquareTitle.Name = "lblSquareTitle";
            this.lblSquareTitle.Size = new System.Drawing.Size(61, 29);
            this.lblSquareTitle.TabIndex = 2;
            this.lblSquareTitle.Text = "Title";
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSquareSide.Location = new System.Drawing.Point(112, 99);
            this.txtSquareSide.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(128, 34);
            this.txtSquareSide.TabIndex = 1;
            // 
            // txtSquareTitle
            // 
            this.txtSquareTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSquareTitle.Location = new System.Drawing.Point(112, 61);
            this.txtSquareTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquareTitle.Name = "txtSquareTitle";
            this.txtSquareTitle.Size = new System.Drawing.Size(128, 34);
            this.txtSquareTitle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSquarePrizmHeight);
            this.panel1.Controls.Add(this.txtSquarePrizmHeight);
            this.panel1.Controls.Add(this.richTextBoxSqaurePrizm);
            this.panel1.Controls.Add(this.lblSqaurePrizm);
            this.panel1.Controls.Add(this.lblSqaurePrizmSide);
            this.panel1.Controls.Add(this.lblSqaurePrizmTitle);
            this.panel1.Controls.Add(this.txtSqaurePrizmSide);
            this.panel1.Controls.Add(this.txtSqaurePrizmTitle);
            this.panel1.Location = new System.Drawing.Point(414, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 407);
            this.panel1.TabIndex = 6;
            // 
            // lblSquarePrizmHeight
            // 
            this.lblSquarePrizmHeight.AutoSize = true;
            this.lblSquarePrizmHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSquarePrizmHeight.Location = new System.Drawing.Point(19, 138);
            this.lblSquarePrizmHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquarePrizmHeight.Name = "lblSquarePrizmHeight";
            this.lblSquarePrizmHeight.Size = new System.Drawing.Size(83, 29);
            this.lblSquarePrizmHeight.TabIndex = 7;
            this.lblSquarePrizmHeight.Text = "Height";
            // 
            // txtSquarePrizmHeight
            // 
            this.txtSquarePrizmHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSquarePrizmHeight.Location = new System.Drawing.Point(112, 138);
            this.txtSquarePrizmHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquarePrizmHeight.Name = "txtSquarePrizmHeight";
            this.txtSquarePrizmHeight.Size = new System.Drawing.Size(128, 34);
            this.txtSquarePrizmHeight.TabIndex = 5;
            // 
            // richTextBoxSqaurePrizm
            // 
            this.richTextBoxSqaurePrizm.Location = new System.Drawing.Point(24, 198);
            this.richTextBoxSqaurePrizm.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxSqaurePrizm.Name = "richTextBoxSqaurePrizm";
            this.richTextBoxSqaurePrizm.Size = new System.Drawing.Size(326, 206);
            this.richTextBoxSqaurePrizm.TabIndex = 6;
            this.richTextBoxSqaurePrizm.Text = "";
            // 
            // lblSqaurePrizm
            // 
            this.lblSqaurePrizm.AutoSize = true;
            this.lblSqaurePrizm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSqaurePrizm.Location = new System.Drawing.Point(146, 8);
            this.lblSqaurePrizm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSqaurePrizm.Name = "lblSqaurePrizm";
            this.lblSqaurePrizm.Size = new System.Drawing.Size(158, 29);
            this.lblSqaurePrizm.TabIndex = 4;
            this.lblSqaurePrizm.Text = "Square Prizm";
            // 
            // lblSqaurePrizmSide
            // 
            this.lblSqaurePrizmSide.AutoSize = true;
            this.lblSqaurePrizmSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSqaurePrizmSide.Location = new System.Drawing.Point(19, 99);
            this.lblSqaurePrizmSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSqaurePrizmSide.Name = "lblSqaurePrizmSide";
            this.lblSqaurePrizmSide.Size = new System.Drawing.Size(63, 29);
            this.lblSqaurePrizmSide.TabIndex = 3;
            this.lblSqaurePrizmSide.Text = "Side";
            // 
            // lblSqaurePrizmTitle
            // 
            this.lblSqaurePrizmTitle.AutoSize = true;
            this.lblSqaurePrizmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSqaurePrizmTitle.Location = new System.Drawing.Point(19, 65);
            this.lblSqaurePrizmTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSqaurePrizmTitle.Name = "lblSqaurePrizmTitle";
            this.lblSqaurePrizmTitle.Size = new System.Drawing.Size(61, 29);
            this.lblSqaurePrizmTitle.TabIndex = 2;
            this.lblSqaurePrizmTitle.Text = "Title";
            // 
            // txtSqaurePrizmSide
            // 
            this.txtSqaurePrizmSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqaurePrizmSide.Location = new System.Drawing.Point(112, 99);
            this.txtSqaurePrizmSide.Margin = new System.Windows.Forms.Padding(2);
            this.txtSqaurePrizmSide.Name = "txtSqaurePrizmSide";
            this.txtSqaurePrizmSide.Size = new System.Drawing.Size(128, 34);
            this.txtSqaurePrizmSide.TabIndex = 1;
            // 
            // txtSqaurePrizmTitle
            // 
            this.txtSqaurePrizmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqaurePrizmTitle.Location = new System.Drawing.Point(112, 61);
            this.txtSqaurePrizmTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtSqaurePrizmTitle.Name = "txtSqaurePrizmTitle";
            this.txtSqaurePrizmTitle.Size = new System.Drawing.Size(128, 34);
            this.txtSqaurePrizmTitle.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(382, 14);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(38, 442);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "C   A   L   C   U   L   A   T   E";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelSquaresCounter
            // 
            this.labelSquaresCounter.AutoSize = true;
            this.labelSquaresCounter.Location = new System.Drawing.Point(314, 8);
            this.labelSquaresCounter.Name = "labelSquaresCounter";
            this.labelSquaresCounter.Size = new System.Drawing.Size(0, 17);
            this.labelSquaresCounter.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 459);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSquare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "37";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSquare.ResumeLayout(false);
            this.panelSquare.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSquare;
        private System.Windows.Forms.Label lblSquarePanelTitle;
        private System.Windows.Forms.Label lblSquareSide;
        private System.Windows.Forms.Label lblSquareTitle;
        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtSquareTitle;
        private System.Windows.Forms.RichTextBox richTextBoxSquare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxSqaurePrizm;
        private System.Windows.Forms.Label lblSqaurePrizm;
        private System.Windows.Forms.Label lblSqaurePrizmSide;
        private System.Windows.Forms.Label lblSqaurePrizmTitle;
        private System.Windows.Forms.TextBox txtSqaurePrizmSide;
        private System.Windows.Forms.TextBox txtSqaurePrizmTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSquarePrizmHeight;
        private System.Windows.Forms.TextBox txtSquarePrizmHeight;
        private System.Windows.Forms.Button btnAddSquare;
        private System.Windows.Forms.Label labelSquaresCounter;
    }
}

