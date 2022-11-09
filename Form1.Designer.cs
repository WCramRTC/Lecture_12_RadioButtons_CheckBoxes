namespace Lecture_12_RadioButtons_CheckBoxes
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
            this.grpTerm = new System.Windows.Forms.GroupBox();
            this.rbFall = new System.Windows.Forms.RadioButton();
            this.rbWinter = new System.Windows.Forms.RadioButton();
            this.rbSpring = new System.Windows.Forms.RadioButton();
            this.chkProg = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.chkGame = new System.Windows.Forms.CheckBox();
            this.chkDatabase = new System.Windows.Forms.CheckBox();
            this.rbSummer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbEnroll = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.grpTerm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTerm
            // 
            this.grpTerm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTerm.Controls.Add(this.rbSummer);
            this.grpTerm.Controls.Add(this.rbSpring);
            this.grpTerm.Controls.Add(this.rbWinter);
            this.grpTerm.Controls.Add(this.rbFall);
            this.grpTerm.Location = new System.Drawing.Point(139, 33);
            this.grpTerm.Name = "grpTerm";
            this.grpTerm.Size = new System.Drawing.Size(161, 157);
            this.grpTerm.TabIndex = 0;
            this.grpTerm.TabStop = false;
            this.grpTerm.Text = "Drink Size";
            // 
            // rbFall
            // 
            this.rbFall.AutoSize = true;
            this.rbFall.Location = new System.Drawing.Point(19, 25);
            this.rbFall.Name = "rbFall";
            this.rbFall.Size = new System.Drawing.Size(59, 24);
            this.rbFall.TabIndex = 0;
            this.rbFall.TabStop = true;
            this.rbFall.Text = "Fall";
            this.rbFall.UseVisualStyleBackColor = true;
            // 
            // rbWinter
            // 
            this.rbWinter.AutoSize = true;
            this.rbWinter.Location = new System.Drawing.Point(19, 55);
            this.rbWinter.Name = "rbWinter";
            this.rbWinter.Size = new System.Drawing.Size(80, 24);
            this.rbWinter.TabIndex = 1;
            this.rbWinter.TabStop = true;
            this.rbWinter.Text = "Winter";
            this.rbWinter.UseVisualStyleBackColor = true;
            // 
            // rbSpring
            // 
            this.rbSpring.AutoSize = true;
            this.rbSpring.Location = new System.Drawing.Point(19, 85);
            this.rbSpring.Name = "rbSpring";
            this.rbSpring.Size = new System.Drawing.Size(80, 24);
            this.rbSpring.TabIndex = 2;
            this.rbSpring.TabStop = true;
            this.rbSpring.Text = "Spring";
            this.rbSpring.UseVisualStyleBackColor = true;
            // 
            // chkProg
            // 
            this.chkProg.AutoSize = true;
            this.chkProg.Location = new System.Drawing.Point(24, 29);
            this.chkProg.Name = "chkProg";
            this.chkProg.Size = new System.Drawing.Size(129, 24);
            this.chkProg.TabIndex = 1;
            this.chkProg.Text = "Programming";
            this.chkProg.UseVisualStyleBackColor = true;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(24, 148);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(166, 24);
            this.chkWeb.TabIndex = 2;
            this.chkWeb.Text = "Web Development";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // chkGame
            // 
            this.chkGame.AutoSize = true;
            this.chkGame.Location = new System.Drawing.Point(24, 110);
            this.chkGame.Name = "chkGame";
            this.chkGame.Size = new System.Drawing.Size(177, 24);
            this.chkGame.TabIndex = 3;
            this.chkGame.Text = "Game Development";
            this.chkGame.UseVisualStyleBackColor = true;
            // 
            // chkDatabase
            // 
            this.chkDatabase.AutoSize = true;
            this.chkDatabase.Location = new System.Drawing.Point(24, 70);
            this.chkDatabase.Name = "chkDatabase";
            this.chkDatabase.Size = new System.Drawing.Size(105, 24);
            this.chkDatabase.TabIndex = 4;
            this.chkDatabase.Text = "Database";
            this.chkDatabase.UseVisualStyleBackColor = true;
            // 
            // rbSummer
            // 
            this.rbSummer.AutoSize = true;
            this.rbSummer.Location = new System.Drawing.Point(19, 115);
            this.rbSummer.Name = "rbSummer";
            this.rbSummer.Size = new System.Drawing.Size(94, 24);
            this.rbSummer.TabIndex = 3;
            this.rbSummer.TabStop = true;
            this.rbSummer.Text = "Summer";
            this.rbSummer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.chkProg);
            this.panel1.Controls.Add(this.chkDatabase);
            this.panel1.Controls.Add(this.chkWeb);
            this.panel1.Controls.Add(this.chkGame);
            this.panel1.Location = new System.Drawing.Point(319, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 210);
            this.panel1.TabIndex = 5;
            // 
            // rtbEnroll
            // 
            this.rtbEnroll.Location = new System.Drawing.Point(559, 33);
            this.rtbEnroll.Name = "rtbEnroll";
            this.rtbEnroll.Size = new System.Drawing.Size(217, 324);
            this.rtbEnroll.TabIndex = 6;
            this.rtbEnroll.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 208);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 26);
            this.tbName.TabIndex = 7;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(233, 261);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(156, 32);
            this.btnEnroll.TabIndex = 8;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 651);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rtbEnroll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTerm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTerm.ResumeLayout(false);
            this.grpTerm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTerm;
        private System.Windows.Forms.RadioButton rbSpring;
        private System.Windows.Forms.RadioButton rbWinter;
        private System.Windows.Forms.RadioButton rbFall;
        private System.Windows.Forms.CheckBox chkProg;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.CheckBox chkGame;
        private System.Windows.Forms.CheckBox chkDatabase;
        private System.Windows.Forms.RadioButton rbSummer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbEnroll;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnEnroll;
    }
}

