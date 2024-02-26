namespace FrumuNotePad
{
    partial class formFind
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
            btnFindd = new Button();
            btnCancel = new Button();
            textFindWhat = new Label();
            textBox1 = new TextBox();
            chkMatchCase = new CheckBox();
            groupBox1 = new GroupBox();
            rdoUp = new RadioButton();
            rdoDown = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFindd
            // 
            btnFindd.Location = new Point(489, 44);
            btnFindd.Name = "btnFindd";
            btnFindd.Size = new Size(117, 46);
            btnFindd.TabIndex = 0;
            btnFindd.Text = "Find Next";
            btnFindd.UseVisualStyleBackColor = true;
            btnFindd.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(489, 119);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textFindWhat
            // 
            textFindWhat.AutoSize = true;
            textFindWhat.Location = new Point(36, 60);
            textFindWhat.Name = "textFindWhat";
            textFindWhat.Size = new Size(59, 15);
            textFindWhat.TabIndex = 2;
            textFindWhat.Text = "Find what";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 43);
            textBox1.TabIndex = 3;
            // 
            // chkMatchCase
            // 
            chkMatchCase.AutoSize = true;
            chkMatchCase.Location = new Point(56, 119);
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.Size = new Size(86, 19);
            chkMatchCase.TabIndex = 4;
            chkMatchCase.Text = "Match case";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDown);
            groupBox1.Controls.Add(rdoUp);
            groupBox1.Location = new Point(56, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 103);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direction";
            // 
            // rdoUp
            // 
            rdoUp.AutoSize = true;
            rdoUp.Location = new Point(20, 25);
            rdoUp.Name = "rdoUp";
            rdoUp.Size = new Size(40, 19);
            rdoUp.TabIndex = 0;
            rdoUp.TabStop = true;
            rdoUp.Text = "Up";
            rdoUp.UseVisualStyleBackColor = true;
            // 
            // rdoDown
            // 
            rdoDown.AutoSize = true;
            rdoDown.Location = new Point(23, 60);
            rdoDown.Name = "rdoDown";
            rdoDown.Size = new Size(56, 19);
            rdoDown.TabIndex = 1;
            rdoDown.TabStop = true;
            rdoDown.Text = "Down";
            rdoDown.UseVisualStyleBackColor = true;
            rdoDown.CheckedChanged += rdoDown_CheckedChanged;
            // 
            // formFind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 442);
            Controls.Add(groupBox1);
            Controls.Add(chkMatchCase);
            Controls.Add(textBox1);
            Controls.Add(textFindWhat);
            Controls.Add(btnCancel);
            Controls.Add(btnFindd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formFind";
            Text = "Find";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindd;
        private Button btnCancel;
        private Label textFindWhat;
        private TextBox textBox1;
        private CheckBox chkMatchCase;
        private GroupBox groupBox1;
        private RadioButton rdoDown;
        private RadioButton rdoUp;
    }
}