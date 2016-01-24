namespace $safeprojectname$
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
            this.EMULATOR = new System.Windows.Forms.TabControl();
            this.Sim = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.runStep = new System.Windows.Forms.Button();
            this.runProgram = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Editor = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Help = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.EMULATOR.SuspendLayout();
            this.Sim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Editor.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMULATOR
            // 
            this.EMULATOR.Controls.Add(this.Sim);
            this.EMULATOR.Controls.Add(this.Editor);
            this.EMULATOR.Controls.Add(this.Help);
            this.EMULATOR.Location = new System.Drawing.Point(12, 12);
            this.EMULATOR.Name = "EMULATOR";
            this.EMULATOR.SelectedIndex = 0;
            this.EMULATOR.Size = new System.Drawing.Size(594, 584);
            this.EMULATOR.TabIndex = 0;
            // 
            // Sim
            // 
            this.Sim.Controls.Add(this.numericUpDown1);
            this.Sim.Controls.Add(this.runStep);
            this.Sim.Controls.Add(this.runProgram);
            this.Sim.Controls.Add(this.textBox4);
            this.Sim.Controls.Add(this.groupBox1);
            this.Sim.Controls.Add(this.textBox3);
            this.Sim.Controls.Add(this.textBox2);
            this.Sim.Controls.Add(this.textBox1);
            this.Sim.Controls.Add(this.label5);
            this.Sim.Controls.Add(this.label4);
            this.Sim.Controls.Add(this.label3);
            this.Sim.Controls.Add(this.label2);
            this.Sim.Controls.Add(this.label1);
            this.Sim.Location = new System.Drawing.Point(4, 22);
            this.Sim.Name = "Sim";
            this.Sim.Padding = new System.Windows.Forms.Padding(3);
            this.Sim.Size = new System.Drawing.Size(586, 558);
            this.Sim.TabIndex = 0;
            this.Sim.Text = "Sim";
            this.Sim.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 420);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(488, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // runStep
            // 
            this.runStep.BackColor = System.Drawing.Color.Yellow;
            this.runStep.Location = new System.Drawing.Point(233, 16);
            this.runStep.Name = "runStep";
            this.runStep.Size = new System.Drawing.Size(103, 28);
            this.runStep.TabIndex = 12;
            this.runStep.Text = "STEP ";
            this.runStep.UseVisualStyleBackColor = false;
            // 
            // runProgram
            // 
            this.runProgram.BackColor = System.Drawing.Color.ForestGreen;
            this.runProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runProgram.Location = new System.Drawing.Point(47, 16);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(103, 28);
            this.runProgram.TabIndex = 11;
            this.runProgram.Text = "RUN";
            this.runProgram.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Signals";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Memory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bus ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.button3);
            this.Editor.Controls.Add(this.groupBox2);
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(586, 558);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(421, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "Load Program";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 469);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Code Below";
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label6);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(586, 558);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "This tab will contain the instructions on operating the Emulator. ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 608);
            this.Controls.Add(this.EMULATOR);
            this.Name = "Form1";
            this.Text = "MicroBaby Emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EMULATOR.ResumeLayout(false);
            this.Sim.ResumeLayout(false);
            this.Sim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Editor.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EMULATOR;
        private System.Windows.Forms.TabPage Sim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Editor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button runStep;
        private System.Windows.Forms.Button runProgram;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label6;
    }
}

