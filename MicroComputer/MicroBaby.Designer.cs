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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
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
            this.EMULATOR.Location = new System.Drawing.Point(-2, 2);
            this.EMULATOR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EMULATOR.Name = "EMULATOR";
            this.EMULATOR.SelectedIndex = 0;
            this.EMULATOR.Size = new System.Drawing.Size(828, 769);
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
            this.Sim.Location = new System.Drawing.Point(4, 29);
            this.Sim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sim.Name = "Sim";
            this.Sim.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sim.Size = new System.Drawing.Size(820, 736);
            this.Sim.TabIndex = 0;
            this.Sim.Text = "Sim";
            this.Sim.UseVisualStyleBackColor = true;
            this.Sim.Click += new System.EventHandler(this.Sim_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.memAddLabel);
            this.groupBox4.Controls.Add(this.vScrollBar2);
            this.groupBox4.Controls.Add(this.dispMemContent);
            this.groupBox4.Controls.Add(this.memContLabel);
            this.groupBox4.Controls.Add(this.dispMemAdd);
            this.groupBox4.Location = new System.Drawing.Point(34, 552);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(774, 166);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Memory Content";
            // 
            // memAddLabel
            // 
            this.memAddLabel.AutoSize = true;
            this.memAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAddLabel.Location = new System.Drawing.Point(32, 45);
            this.memAddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memAddLabel.Name = "memAddLabel";
            this.memAddLabel.Size = new System.Drawing.Size(161, 25);
            this.memAddLabel.TabIndex = 15;
            this.memAddLabel.Text = "Memory Address";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(580, 74);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 74);
            this.vScrollBar2.TabIndex = 14;
            // 
            // dispMemContent
            // 
            this.dispMemContent.Location = new System.Drawing.Point(315, 74);
            this.dispMemContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispMemContent.Name = "dispMemContent";
            this.dispMemContent.Size = new System.Drawing.Size(200, 26);
            this.dispMemContent.TabIndex = 18;
            this.dispMemContent.TextChanged += new System.EventHandler(this.dispMemContent_TextChanged);
            // 
            // memContLabel
            // 
            this.memContLabel.AutoSize = true;
            this.memContLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memContLabel.Location = new System.Drawing.Point(310, 45);
            this.memContLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memContLabel.Name = "memContLabel";
            this.memContLabel.Size = new System.Drawing.Size(157, 25);
            this.memContLabel.TabIndex = 16;
            this.memContLabel.Text = "Memory Content";
            // 
            // dispMemAdd
            // 
            this.dispMemAdd.Location = new System.Drawing.Point(36, 74);
            this.dispMemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispMemAdd.Name = "dispMemAdd";
            this.dispMemAdd.Size = new System.Drawing.Size(200, 26);
            this.dispMemAdd.TabIndex = 17;
            this.dispMemAdd.TextChanged += new System.EventHandler(this.dispMemAdd_TextChanged);
            // 
            // runStep
            // 
            this.runStep.BackColor = System.Drawing.Color.Yellow;
            this.runStep.Location = new System.Drawing.Point(339, 25);
            this.runStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.runStep.Name = "runStep";
            this.runStep.Size = new System.Drawing.Size(154, 43);
            this.runStep.TabIndex = 12;
            this.runStep.Text = "STEP";
            this.runStep.UseVisualStyleBackColor = false;
            this.runStep.Click += new System.EventHandler(this.runStep_Click);
            // 
            // runProgram
            // 
            this.runProgram.BackColor = System.Drawing.Color.ForestGreen;
            this.runProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runProgram.Location = new System.Drawing.Point(70, 25);
            this.runProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(154, 43);
            this.runProgram.TabIndex = 11;
            this.runProgram.Text = "RUN";
            this.runProgram.UseVisualStyleBackColor = false;
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // dispDataBus
            // 
            this.dispDataBus.Location = new System.Drawing.Point(120, 477);
            this.dispDataBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispDataBus.Name = "dispDataBus";
            this.dispDataBus.Size = new System.Drawing.Size(208, 26);
            this.dispDataBus.TabIndex = 10;
            this.dispDataBus.TextChanged += new System.EventHandler(this.dispDataBus_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(776, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition Signals";
            // 
            // dispAC
            // 
            this.dispAC.Location = new System.Drawing.Point(615, 109);
            this.dispAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispAC.Name = "dispAC";
            this.dispAC.Size = new System.Drawing.Size(193, 26);
            this.dispAC.TabIndex = 7;
            this.dispAC.TextChanged += new System.EventHandler(this.dispAC_TextChanged);
            // 
            // dispIR
            // 
            this.dispIR.Location = new System.Drawing.Point(339, 109);
            this.dispIR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispIR.Name = "dispIR";
            this.dispIR.Size = new System.Drawing.Size(193, 26);
            this.dispIR.TabIndex = 6;
            this.dispIR.TextChanged += new System.EventHandler(this.dispIR_TextChanged);
            // 
            // dispPC
            // 
            this.dispPC.Location = new System.Drawing.Point(70, 109);
            this.dispPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dispPC.Name = "dispPC";
            this.dispPC.Size = new System.Drawing.Size(193, 26);
            this.dispPC.TabIndex = 5;
            this.dispPC.TextChanged += new System.EventHandler(this.dispPC_TextChanged);
            // 
            // dataBusLabel
            // 
            this.dataBusLabel.AutoSize = true;
            this.dataBusLabel.Location = new System.Drawing.Point(30, 477);
            this.dataBusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataBusLabel.Name = "dataBusLabel";
            this.dataBusLabel.Size = new System.Drawing.Size(80, 20);
            this.dataBusLabel.TabIndex = 3;
            this.dataBusLabel.Text = "Data Bus ";
            // 
            // irLabel
            // 
            this.irLabel.AutoSize = true;
            this.irLabel.Location = new System.Drawing.Point(303, 109);
            this.irLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.irLabel.Name = "irLabel";
            this.irLabel.Size = new System.Drawing.Size(26, 20);
            this.irLabel.TabIndex = 2;
            this.irLabel.Text = "IR";
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(574, 109);
            this.acLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(31, 20);
            this.acLabel.TabIndex = 1;
            this.acLabel.Text = "AC";
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.Location = new System.Drawing.Point(30, 109);
            this.pcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(30, 20);
            this.pcLabel.TabIndex = 0;
            this.pcLabel.Text = "PC";
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.groupBox3);
            this.Editor.Controls.Add(this.loadProgram);
            this.Editor.Controls.Add(this.groupBox2);
            this.Editor.Location = new System.Drawing.Point(4, 29);
            this.Editor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editor.Size = new System.Drawing.Size(820, 736);
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
            this.groupBox3.Location = new System.Drawing.Point(32, 555);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(750, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory Editor";
            // 
            // enterMemContent
            // 
            this.enterMemContent.Location = new System.Drawing.Point(250, 77);
            this.enterMemContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterMemContent.Name = "enterMemContent";
            this.enterMemContent.Size = new System.Drawing.Size(200, 28);
            this.enterMemContent.TabIndex = 8;
            // 
            // enterMemAdd
            // 
            this.enterMemAdd.Location = new System.Drawing.Point(14, 77);
            this.enterMemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterMemAdd.Name = "enterMemAdd";
            this.enterMemAdd.Size = new System.Drawing.Size(200, 28);
            this.enterMemAdd.TabIndex = 7;
            // 
            // updateMem
            // 
            this.updateMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMem.Location = new System.Drawing.Point(532, 77);
            this.updateMem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateMem.Name = "updateMem";
            this.updateMem.Size = new System.Drawing.Size(208, 74);
            this.updateMem.TabIndex = 6;
            this.updateMem.Text = "Update";
            this.updateMem.UseVisualStyleBackColor = true;
            this.updateMem.Click += new System.EventHandler(this.updateMem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Memory Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Memory Address";
            // 
            // memScroll
            // 
            this.memScroll.Location = new System.Drawing.Point(474, 77);
            this.memScroll.Name = "memScroll";
            this.memScroll.Size = new System.Drawing.Size(17, 74);
            this.memScroll.TabIndex = 3;
            this.memScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.memScroll_Scroll);
            // 
            // loadProgram
            // 
            this.loadProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProgram.Location = new System.Drawing.Point(564, 26);
            this.loadProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadProgram.Name = "loadProgram";
            this.loadProgram.Size = new System.Drawing.Size(208, 74);
            this.loadProgram.TabIndex = 1;
            this.loadProgram.Text = "Load Program";
            this.loadProgram.UseVisualStyleBackColor = true;
            this.loadProgram.Click += new System.EventHandler(this.loadProgram_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(741, 417);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 377);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // programEditor
            // 
            this.programEditor.Location = new System.Drawing.Point(4, 5);
            this.programEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programEditor.Multiline = true;
            this.programEditor.Name = "programEditor";
            this.programEditor.Size = new System.Drawing.Size(348, 366);
            this.programEditor.TabIndex = 3;
            this.programEditor.TextChanged += new System.EventHandler(this.programEditor_TextChanged);
            // 
            // opCodes
            // 
            this.opCodes.Location = new System.Drawing.Point(363, 5);
            this.opCodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opCodes.Multiline = true;
            this.opCodes.Name = "opCodes";
            this.opCodes.Size = new System.Drawing.Size(349, 366);
            this.opCodes.TabIndex = 4;
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label6);
            this.Help.Location = new System.Drawing.Point(4, 29);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Help.Size = new System.Drawing.Size(820, 736);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "This tab will contain the instructions on operating the Emulator. ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Carry";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(314, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 24);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Overflow";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(36, 181);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 24);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Zero";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(314, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 24);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Negative";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // MicroBaby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 772);
            this.Controls.Add(this.EMULATOR);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(841, 884);
            this.MinimumSize = new System.Drawing.Size(841, 748);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label memAddLabel;
        private System.Windows.Forms.TextBox dispMemContent;
        private System.Windows.Forms.Label memContLabel;
        private System.Windows.Forms.TextBox dispMemAdd;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox opCodes;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

