namespace MicroComputer
{
    partial class MicroBaby
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.memAddLabel = new System.Windows.Forms.Label();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.dispMemContent = new System.Windows.Forms.TextBox();
            this.memContLabel = new System.Windows.Forms.Label();
            this.dispMemAdd = new System.Windows.Forms.TextBox();
            this.runStep = new System.Windows.Forms.Button();
            this.runProgram = new System.Windows.Forms.Button();
            this.dispDataBus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negativeLabel = new System.Windows.Forms.Label();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.overflowLabel = new System.Windows.Forms.Label();
            this.carryLabel = new System.Windows.Forms.Label();
            this.dispAC = new System.Windows.Forms.TextBox();
            this.dispIR = new System.Windows.Forms.TextBox();
            this.dispPC = new System.Windows.Forms.TextBox();
            this.dataBusLabel = new System.Windows.Forms.Label();
            this.irLabel = new System.Windows.Forms.Label();
            this.acLabel = new System.Windows.Forms.Label();
            this.pcLabel = new System.Windows.Forms.Label();
            this.Editor = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enterMemContent = new System.Windows.Forms.TextBox();
            this.enterMemAdd = new System.Windows.Forms.TextBox();
            this.updateMem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.memScroll = new System.Windows.Forms.VScrollBar();
            this.loadProgram = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.programEditor = new System.Windows.Forms.TextBox();
            this.opCodes = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.EMULATOR.SuspendLayout();
            this.Sim.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Editor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMULATOR
            // 
            this.EMULATOR.Controls.Add(this.Sim);
            this.EMULATOR.Controls.Add(this.Editor);
            this.EMULATOR.Controls.Add(this.Help);
            this.EMULATOR.Location = new System.Drawing.Point(-1, 1);
            this.EMULATOR.Name = "EMULATOR";
            this.EMULATOR.SelectedIndex = 0;
            this.EMULATOR.Size = new System.Drawing.Size(552, 500);
            this.EMULATOR.TabIndex = 1;
            // 
            // Sim
            // 
            this.Sim.Controls.Add(this.groupBox4);
            this.Sim.Controls.Add(this.runStep);
            this.Sim.Controls.Add(this.runProgram);
            this.Sim.Controls.Add(this.dispDataBus);
            this.Sim.Controls.Add(this.groupBox1);
            this.Sim.Controls.Add(this.dispAC);
            this.Sim.Controls.Add(this.dispIR);
            this.Sim.Controls.Add(this.dispPC);
            this.Sim.Controls.Add(this.dataBusLabel);
            this.Sim.Controls.Add(this.irLabel);
            this.Sim.Controls.Add(this.acLabel);
            this.Sim.Controls.Add(this.pcLabel);
            this.Sim.Location = new System.Drawing.Point(4, 22);
            this.Sim.Name = "Sim";
            this.Sim.Padding = new System.Windows.Forms.Padding(3);
            this.Sim.Size = new System.Drawing.Size(544, 474);
            this.Sim.TabIndex = 0;
            this.Sim.Text = "Sim";
            this.Sim.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.memAddLabel);
            this.groupBox4.Controls.Add(this.vScrollBar2);
            this.groupBox4.Controls.Add(this.dispMemContent);
            this.groupBox4.Controls.Add(this.memContLabel);
            this.groupBox4.Controls.Add(this.dispMemAdd);
            this.groupBox4.Location = new System.Drawing.Point(23, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 108);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Memory Content";
            // 
            // memAddLabel
            // 
            this.memAddLabel.AutoSize = true;
            this.memAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAddLabel.Location = new System.Drawing.Point(21, 29);
            this.memAddLabel.Name = "memAddLabel";
            this.memAddLabel.Size = new System.Drawing.Size(111, 16);
            this.memAddLabel.TabIndex = 15;
            this.memAddLabel.Text = "Memory Address";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(387, 48);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 48);
            this.vScrollBar2.TabIndex = 14;
            // 
            // dispMemContent
            // 
            this.dispMemContent.Location = new System.Drawing.Point(210, 48);
            this.dispMemContent.Name = "dispMemContent";
            this.dispMemContent.Size = new System.Drawing.Size(135, 20);
            this.dispMemContent.TabIndex = 18;
            // 
            // memContLabel
            // 
            this.memContLabel.AutoSize = true;
            this.memContLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memContLabel.Location = new System.Drawing.Point(207, 29);
            this.memContLabel.Name = "memContLabel";
            this.memContLabel.Size = new System.Drawing.Size(105, 16);
            this.memContLabel.TabIndex = 16;
            this.memContLabel.Text = "Memory Content";
            // 
            // dispMemAdd
            // 
            this.dispMemAdd.Location = new System.Drawing.Point(24, 48);
            this.dispMemAdd.Name = "dispMemAdd";
            this.dispMemAdd.Size = new System.Drawing.Size(135, 20);
            this.dispMemAdd.TabIndex = 17;
            // 
            // runStep
            // 
            this.runStep.BackColor = System.Drawing.Color.Yellow;
            this.runStep.Location = new System.Drawing.Point(226, 16);
            this.runStep.Name = "runStep";
            this.runStep.Size = new System.Drawing.Size(103, 28);
            this.runStep.TabIndex = 12;
            this.runStep.Text = "STEP ";
            this.runStep.UseVisualStyleBackColor = false;
            this.runStep.Click += new System.EventHandler(this.runStep_Click);
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
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // dispDataBus
            // 
            this.dispDataBus.Location = new System.Drawing.Point(80, 310);
            this.dispDataBus.Name = "dispDataBus";
            this.dispDataBus.Size = new System.Drawing.Size(140, 20);
            this.dispDataBus.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.negativeLabel);
            this.groupBox1.Controls.Add(this.zeroLabel);
            this.groupBox1.Controls.Add(this.overflowLabel);
            this.groupBox1.Controls.Add(this.carryLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition Signals";
            // 
            // negativeLabel
            // 
            this.negativeLabel.AutoSize = true;
            this.negativeLabel.Location = new System.Drawing.Point(207, 120);
            this.negativeLabel.Name = "negativeLabel";
            this.negativeLabel.Size = new System.Drawing.Size(50, 13);
            this.negativeLabel.TabIndex = 4;
            this.negativeLabel.Text = "Negative";
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.Location = new System.Drawing.Point(21, 120);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(29, 13);
            this.zeroLabel.TabIndex = 3;
            this.zeroLabel.Text = "Zero";
            // 
            // overflowLabel
            // 
            this.overflowLabel.AutoSize = true;
            this.overflowLabel.Location = new System.Drawing.Point(207, 44);
            this.overflowLabel.Name = "overflowLabel";
            this.overflowLabel.Size = new System.Drawing.Size(49, 13);
            this.overflowLabel.TabIndex = 2;
            this.overflowLabel.Text = "Overflow";
            // 
            // carryLabel
            // 
            this.carryLabel.AutoSize = true;
            this.carryLabel.Location = new System.Drawing.Point(21, 44);
            this.carryLabel.Name = "carryLabel";
            this.carryLabel.Size = new System.Drawing.Size(31, 13);
            this.carryLabel.TabIndex = 1;
            this.carryLabel.Text = "Carry";
            // 
            // dispAC
            // 
            this.dispAC.Location = new System.Drawing.Point(410, 71);
            this.dispAC.Name = "dispAC";
            this.dispAC.Size = new System.Drawing.Size(130, 20);
            this.dispAC.TabIndex = 7;
            // 
            // dispIR
            // 
            this.dispIR.Location = new System.Drawing.Point(226, 71);
            this.dispIR.Name = "dispIR";
            this.dispIR.Size = new System.Drawing.Size(130, 20);
            this.dispIR.TabIndex = 6;
            // 
            // dispPC
            // 
            this.dispPC.Location = new System.Drawing.Point(47, 71);
            this.dispPC.Name = "dispPC";
            this.dispPC.Size = new System.Drawing.Size(130, 20);
            this.dispPC.TabIndex = 5;
            // 
            // dataBusLabel
            // 
            this.dataBusLabel.AutoSize = true;
            this.dataBusLabel.Location = new System.Drawing.Point(20, 310);
            this.dataBusLabel.Name = "dataBusLabel";
            this.dataBusLabel.Size = new System.Drawing.Size(54, 13);
            this.dataBusLabel.TabIndex = 3;
            this.dataBusLabel.Text = "Data Bus ";
            // 
            // irLabel
            // 
            this.irLabel.AutoSize = true;
            this.irLabel.Location = new System.Drawing.Point(202, 71);
            this.irLabel.Name = "irLabel";
            this.irLabel.Size = new System.Drawing.Size(18, 13);
            this.irLabel.TabIndex = 2;
            this.irLabel.Text = "IR";
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(383, 71);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(21, 13);
            this.acLabel.TabIndex = 1;
            this.acLabel.Text = "AC";
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.Location = new System.Drawing.Point(20, 71);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(21, 13);
            this.pcLabel.TabIndex = 0;
            this.pcLabel.Text = "PC";
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.groupBox3);
            this.Editor.Controls.Add(this.loadProgram);
            this.Editor.Controls.Add(this.groupBox2);
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(544, 474);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enterMemContent);
            this.groupBox3.Controls.Add(this.enterMemAdd);
            this.groupBox3.Controls.Add(this.updateMem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.memScroll);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory Editor";
            // 
            // enterMemContent
            // 
            this.enterMemContent.Location = new System.Drawing.Point(167, 50);
            this.enterMemContent.Name = "enterMemContent";
            this.enterMemContent.Size = new System.Drawing.Size(135, 21);
            this.enterMemContent.TabIndex = 8;
            // 
            // enterMemAdd
            // 
            this.enterMemAdd.Location = new System.Drawing.Point(9, 50);
            this.enterMemAdd.Name = "enterMemAdd";
            this.enterMemAdd.Size = new System.Drawing.Size(135, 21);
            this.enterMemAdd.TabIndex = 7;
            // 
            // updateMem
            // 
            this.updateMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMem.Location = new System.Drawing.Point(355, 50);
            this.updateMem.Name = "updateMem";
            this.updateMem.Size = new System.Drawing.Size(139, 48);
            this.updateMem.TabIndex = 6;
            this.updateMem.Text = "Update";
            this.updateMem.UseVisualStyleBackColor = true;
            this.updateMem.Click += new System.EventHandler(this.updateMem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Memory Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Memory Address";
            // 
            // memScroll
            // 
            this.memScroll.Location = new System.Drawing.Point(316, 50);
            this.memScroll.Name = "memScroll";
            this.memScroll.Size = new System.Drawing.Size(17, 48);
            this.memScroll.TabIndex = 3;
            this.memScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.memScroll_Scroll);
            // 
            // loadProgram
            // 
            this.loadProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProgram.Location = new System.Drawing.Point(376, 17);
            this.loadProgram.Name = "loadProgram";
            this.loadProgram.Size = new System.Drawing.Size(139, 48);
            this.loadProgram.TabIndex = 1;
            this.loadProgram.Text = "Load Program";
            this.loadProgram.UseVisualStyleBackColor = true;
            this.loadProgram.Click += new System.EventHandler(this.loadProgram_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 271);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Code Below";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.programEditor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.opCodes, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 245);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // programEditor
            // 
            this.programEditor.Location = new System.Drawing.Point(3, 3);
            this.programEditor.Multiline = true;
            this.programEditor.Name = "programEditor";
            this.programEditor.Size = new System.Drawing.Size(233, 239);
            this.programEditor.TabIndex = 3;
            // 
            // opCodes
            // 
            this.opCodes.Location = new System.Drawing.Point(242, 3);
            this.opCodes.Multiline = true;
            this.opCodes.Name = "opCodes";
            this.opCodes.Size = new System.Drawing.Size(234, 239);
            this.opCodes.TabIndex = 4;
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label6);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(544, 474);
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
            // 
            // MicroBaby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 502);
            this.Controls.Add(this.EMULATOR);
            this.MaximumSize = new System.Drawing.Size(568, 594);
            this.MinimumSize = new System.Drawing.Size(568, 506);
            this.Name = "MicroBaby";
            this.Text = "MicroBaby Emulator";
            this.EMULATOR.ResumeLayout(false);
            this.Sim.ResumeLayout(false);
            this.Sim.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Editor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EMULATOR;
        private System.Windows.Forms.TabPage Sim;
        private System.Windows.Forms.Button runStep;
        private System.Windows.Forms.Button runProgram;
        private System.Windows.Forms.TextBox dispDataBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dispAC;
        private System.Windows.Forms.TextBox dispIR;
        private System.Windows.Forms.TextBox dispPC;
        private System.Windows.Forms.Label dataBusLabel;
        private System.Windows.Forms.Label irLabel;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.Label pcLabel;
        private System.Windows.Forms.TabPage Editor;
        private System.Windows.Forms.Button loadProgram;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox programEditor;
        private System.Windows.Forms.TextBox enterMemContent;
        private System.Windows.Forms.TextBox enterMemAdd;
        private System.Windows.Forms.Button updateMem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.VScrollBar memScroll;
        private System.Windows.Forms.Label carryLabel;
        private System.Windows.Forms.Label overflowLabel;
        private System.Windows.Forms.Label zeroLabel;
        private System.Windows.Forms.Label negativeLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label memAddLabel;
        private System.Windows.Forms.TextBox dispMemContent;
        private System.Windows.Forms.Label memContLabel;
        private System.Windows.Forms.TextBox dispMemAdd;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox opCodes;
    }
}

