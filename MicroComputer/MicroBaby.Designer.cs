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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroBaby));
            this.EMULATOR = new System.Windows.Forms.TabControl();
            this.Sim = new System.Windows.Forms.TabPage();
            this.memView = new System.Windows.Forms.GroupBox();
            this.refreshMem = new System.Windows.Forms.Button();
            this.programMem = new System.Windows.Forms.TextBox();
            this.dataMem = new System.Windows.Forms.TextBox();
            this.resetProgram = new System.Windows.Forms.Button();
            this.runStep = new System.Windows.Forms.Button();
            this.runProgram = new System.Windows.Forms.Button();
            this.dispDataBus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negFlag = new System.Windows.Forms.CheckBox();
            this.zeroFlag = new System.Windows.Forms.CheckBox();
            this.carryFlag = new System.Windows.Forms.CheckBox();
            this.dispAC = new System.Windows.Forms.TextBox();
            this.dispIR = new System.Windows.Forms.TextBox();
            this.dispPC = new System.Windows.Forms.TextBox();
            this.dataBusLabel = new System.Windows.Forms.Label();
            this.irLabel = new System.Windows.Forms.Label();
            this.acLabel = new System.Windows.Forms.Label();
            this.pcLabel = new System.Windows.Forms.Label();
            this.Editor = new System.Windows.Forms.TabPage();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.opCodes = new System.Windows.Forms.TextBox();
            this.dataMem2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enterMemAdd = new System.Windows.Forms.ComboBox();
            this.enterMemContent = new System.Windows.Forms.TextBox();
            this.updateMem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loadProgram = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.programEditor = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.EMULATOR.SuspendLayout();
            this.Sim.SuspendLayout();
            this.memView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Editor.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.EMULATOR.Size = new System.Drawing.Size(885, 509);
            this.EMULATOR.TabIndex = 1;
            // 
            // Sim
            // 
            this.Sim.Controls.Add(this.memView);
            this.Sim.Controls.Add(this.resetProgram);
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
            this.Sim.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Sim.Size = new System.Drawing.Size(877, 483);
            this.Sim.TabIndex = 0;
            this.Sim.Text = "Sim";
            this.Sim.UseVisualStyleBackColor = true;
            // 
            // memView
            // 
            this.memView.Controls.Add(this.refreshMem);
            this.memView.Controls.Add(this.programMem);
            this.memView.Controls.Add(this.dataMem);
            this.memView.Location = new System.Drawing.Point(410, 16);
            this.memView.Name = "memView";
            this.memView.Size = new System.Drawing.Size(459, 451);
            this.memView.TabIndex = 16;
            this.memView.TabStop = false;
            this.memView.Text = "Memory Display";
            // 
            // refreshMem
            // 
            this.refreshMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshMem.Location = new System.Drawing.Point(295, 19);
            this.refreshMem.Name = "refreshMem";
            this.refreshMem.Size = new System.Drawing.Size(147, 46);
            this.refreshMem.TabIndex = 16;
            this.refreshMem.Text = "Refresh Memory";
            this.refreshMem.UseVisualStyleBackColor = true;
            this.refreshMem.Click += new System.EventHandler(this.refreshMem_Click);
            // 
            // programMem
            // 
            this.programMem.Location = new System.Drawing.Point(15, 73);
            this.programMem.Multiline = true;
            this.programMem.Name = "programMem";
            this.programMem.ReadOnly = true;
            this.programMem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programMem.Size = new System.Drawing.Size(206, 372);
            this.programMem.TabIndex = 14;
            // 
            // dataMem
            // 
            this.dataMem.Location = new System.Drawing.Point(236, 73);
            this.dataMem.Multiline = true;
            this.dataMem.Name = "dataMem";
            this.dataMem.ReadOnly = true;
            this.dataMem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMem.Size = new System.Drawing.Size(206, 372);
            this.dataMem.TabIndex = 15;
            // 
            // resetProgram
            // 
            this.resetProgram.BackColor = System.Drawing.Color.Coral;
            this.resetProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetProgram.Location = new System.Drawing.Point(274, 16);
            this.resetProgram.Name = "resetProgram";
            this.resetProgram.Size = new System.Drawing.Size(93, 42);
            this.resetProgram.TabIndex = 13;
            this.resetProgram.Text = "RESET";
            this.resetProgram.UseVisualStyleBackColor = false;
            this.resetProgram.Click += new System.EventHandler(this.resetProgram_Click);
            // 
            // runStep
            // 
            this.runStep.AllowDrop = true;
            this.runStep.BackColor = System.Drawing.Color.Khaki;
            this.runStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.runStep.Location = new System.Drawing.Point(153, 16);
            this.runStep.Name = "runStep";
            this.runStep.Size = new System.Drawing.Size(93, 42);
            this.runStep.TabIndex = 12;
            this.runStep.Text = "STEP";
            this.runStep.UseVisualStyleBackColor = false;
            this.runStep.Click += new System.EventHandler(this.runStep_Click);
            // 
            // runProgram
            // 
            this.runProgram.BackColor = System.Drawing.Color.MediumAquamarine;
            this.runProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.runProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runProgram.Location = new System.Drawing.Point(32, 16);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(93, 42);
            this.runProgram.TabIndex = 11;
            this.runProgram.Text = "RUN";
            this.runProgram.UseVisualStyleBackColor = false;
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // dispDataBus
            // 
            this.dispDataBus.Location = new System.Drawing.Point(73, 207);
            this.dispDataBus.Name = "dispDataBus";
            this.dispDataBus.ReadOnly = true;
            this.dispDataBus.Size = new System.Drawing.Size(141, 20);
            this.dispDataBus.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.negFlag);
            this.groupBox1.Controls.Add(this.zeroFlag);
            this.groupBox1.Controls.Add(this.carryFlag);
            this.groupBox1.Location = new System.Drawing.Point(21, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition Signals";
            // 
            // negFlag
            // 
            this.negFlag.AutoCheck = false;
            this.negFlag.AutoSize = true;
            this.negFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.negFlag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.negFlag.Location = new System.Drawing.Point(33, 80);
            this.negFlag.Name = "negFlag";
            this.negFlag.Size = new System.Drawing.Size(69, 17);
            this.negFlag.TabIndex = 8;
            this.negFlag.Text = "Negative";
            this.negFlag.UseVisualStyleBackColor = true;
            // 
            // zeroFlag
            // 
            this.zeroFlag.AutoCheck = false;
            this.zeroFlag.AutoSize = true;
            this.zeroFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zeroFlag.Location = new System.Drawing.Point(52, 122);
            this.zeroFlag.Name = "zeroFlag";
            this.zeroFlag.Size = new System.Drawing.Size(48, 17);
            this.zeroFlag.TabIndex = 7;
            this.zeroFlag.Text = "Zero";
            this.zeroFlag.UseVisualStyleBackColor = true;
            // 
            // carryFlag
            // 
            this.carryFlag.AutoCheck = false;
            this.carryFlag.AutoSize = true;
            this.carryFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carryFlag.Location = new System.Drawing.Point(49, 40);
            this.carryFlag.Name = "carryFlag";
            this.carryFlag.Size = new System.Drawing.Size(50, 17);
            this.carryFlag.TabIndex = 5;
            this.carryFlag.Text = "Carry";
            this.carryFlag.UseVisualStyleBackColor = true;
            // 
            // dispAC
            // 
            this.dispAC.Location = new System.Drawing.Point(73, 166);
            this.dispAC.Name = "dispAC";
            this.dispAC.ReadOnly = true;
            this.dispAC.Size = new System.Drawing.Size(141, 20);
            this.dispAC.TabIndex = 7;
            // 
            // dispIR
            // 
            this.dispIR.Location = new System.Drawing.Point(73, 127);
            this.dispIR.Name = "dispIR";
            this.dispIR.ReadOnly = true;
            this.dispIR.Size = new System.Drawing.Size(141, 20);
            this.dispIR.TabIndex = 6;
            // 
            // dispPC
            // 
            this.dispPC.Location = new System.Drawing.Point(73, 89);
            this.dispPC.Name = "dispPC";
            this.dispPC.ReadOnly = true;
            this.dispPC.Size = new System.Drawing.Size(141, 20);
            this.dispPC.TabIndex = 5;
            // 
            // dataBusLabel
            // 
            this.dataBusLabel.AutoSize = true;
            this.dataBusLabel.Location = new System.Drawing.Point(14, 207);
            this.dataBusLabel.Name = "dataBusLabel";
            this.dataBusLabel.Size = new System.Drawing.Size(54, 13);
            this.dataBusLabel.TabIndex = 3;
            this.dataBusLabel.Text = "Data Bus ";
            // 
            // irLabel
            // 
            this.irLabel.AutoSize = true;
            this.irLabel.Location = new System.Drawing.Point(50, 131);
            this.irLabel.Name = "irLabel";
            this.irLabel.Size = new System.Drawing.Size(18, 13);
            this.irLabel.TabIndex = 2;
            this.irLabel.Text = "IR";
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(50, 170);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(21, 13);
            this.acLabel.TabIndex = 1;
            this.acLabel.Text = "AC";
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.Location = new System.Drawing.Point(50, 91);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(21, 13);
            this.pcLabel.TabIndex = 0;
            this.pcLabel.Text = "PC";
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.saveFile);
            this.Editor.Controls.Add(this.openFile);
            this.Editor.Controls.Add(this.groupBox5);
            this.Editor.Controls.Add(this.groupBox3);
            this.Editor.Controls.Add(this.loadProgram);
            this.Editor.Controls.Add(this.groupBox2);
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Editor.Size = new System.Drawing.Size(877, 483);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            // 
            // saveFile
            // 
            this.saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.Location = new System.Drawing.Point(123, 17);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(84, 40);
            this.saveFile.TabIndex = 19;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(33, 17);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(84, 40);
            this.openFile.TabIndex = 18;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.opCodes);
            this.groupBox5.Controls.Add(this.dataMem2);
            this.groupBox5.Location = new System.Drawing.Point(410, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 451);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Memory Display";
            // 
            // opCodes
            // 
            this.opCodes.Location = new System.Drawing.Point(15, 73);
            this.opCodes.Multiline = true;
            this.opCodes.Name = "opCodes";
            this.opCodes.ReadOnly = true;
            this.opCodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opCodes.Size = new System.Drawing.Size(206, 372);
            this.opCodes.TabIndex = 4;
            // 
            // dataMem2
            // 
            this.dataMem2.Location = new System.Drawing.Point(236, 73);
            this.dataMem2.Multiline = true;
            this.dataMem2.Name = "dataMem2";
            this.dataMem2.ReadOnly = true;
            this.dataMem2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMem2.Size = new System.Drawing.Size(206, 372);
            this.dataMem2.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enterMemAdd);
            this.groupBox3.Controls.Add(this.enterMemContent);
            this.groupBox3.Controls.Add(this.updateMem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory Editor";
            // 
            // enterMemAdd
            // 
            this.enterMemAdd.FormattingEnabled = true;
            this.enterMemAdd.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "1F",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "2F",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "3F",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "4A",
            "4B",
            "4C",
            "4D",
            "4E",
            "4F",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "5A",
            "5B",
            "5C",
            "5D",
            "5E",
            "5F",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "6A",
            "6B",
            "6C",
            "6D",
            "6E",
            "6F",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "7A",
            "7B",
            "7C",
            "7D",
            "7E",
            "7F",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "8A",
            "8B",
            "8C",
            "8D",
            "8E",
            "8F",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "9A",
            "9B",
            "9C",
            "9D",
            "9E",
            "9F",
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "AA",
            "AB",
            "AC",
            "AD",
            "AE",
            "AF",
            "B0",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "B7",
            "B8",
            "B9",
            "BA",
            "BB",
            "BC",
            "BD",
            "BE",
            "BF",
            "C0",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8",
            "C9",
            "CA",
            "CB",
            "CC",
            "CD",
            "CE",
            "CF",
            "D0",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "DA",
            "DB",
            "DC",
            "DD",
            "DE",
            "DF",
            "E0",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5",
            "E6",
            "E7",
            "E8",
            "E9",
            "EA",
            "EB",
            "EC",
            "ED",
            "EE",
            "EF",
            "F0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "FA",
            "FB",
            "FC",
            "FD",
            "FE",
            "FF"});
            this.enterMemAdd.Location = new System.Drawing.Point(12, 50);
            this.enterMemAdd.Name = "enterMemAdd";
            this.enterMemAdd.Size = new System.Drawing.Size(105, 23);
            this.enterMemAdd.TabIndex = 9;
            // 
            // enterMemContent
            // 
            this.enterMemContent.Location = new System.Drawing.Point(135, 50);
            this.enterMemContent.Multiline = true;
            this.enterMemContent.Name = "enterMemContent";
            this.enterMemContent.Size = new System.Drawing.Size(105, 23);
            this.enterMemContent.TabIndex = 8;
            // 
            // updateMem
            // 
            this.updateMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMem.Location = new System.Drawing.Point(259, 36);
            this.updateMem.Name = "updateMem";
            this.updateMem.Size = new System.Drawing.Size(105, 48);
            this.updateMem.TabIndex = 6;
            this.updateMem.Text = "Update Memory";
            this.updateMem.UseVisualStyleBackColor = true;
            this.updateMem.Click += new System.EventHandler(this.updateMem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 28);
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
            // loadProgram
            // 
            this.loadProgram.Enabled = false;
            this.loadProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProgram.Location = new System.Drawing.Point(257, 17);
            this.loadProgram.Name = "loadProgram";
            this.loadProgram.Size = new System.Drawing.Size(128, 40);
            this.loadProgram.TabIndex = 1;
            this.loadProgram.Text = "Load Program";
            this.loadProgram.UseVisualStyleBackColor = true;
            this.loadProgram.Click += new System.EventHandler(this.loadProgram_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.programEditor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 271);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program Editor";
            // 
            // programEditor
            // 
            this.programEditor.AllowDrop = true;
            this.programEditor.Location = new System.Drawing.Point(6, 20);
            this.programEditor.Multiline = true;
            this.programEditor.Name = "programEditor";
            this.programEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programEditor.Size = new System.Drawing.Size(354, 239);
            this.programEditor.TabIndex = 3;
            this.programEditor.Text = "Enter your code...";
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label6);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Help.Size = new System.Drawing.Size(877, 483);
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
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 494);
            this.Controls.Add(this.EMULATOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(898, 544);
            this.MinimumSize = new System.Drawing.Size(857, 506);
            this.Name = "MicroBaby";
            this.Text = "MicroBaby Emulator";
            this.EMULATOR.ResumeLayout(false);
            this.Sim.ResumeLayout(false);
            this.Sim.PerformLayout();
            this.memView.ResumeLayout(false);
            this.memView.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Editor.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox opCodes;
        private System.Windows.Forms.TextBox dataMem;
        private System.Windows.Forms.TextBox programMem;
        private System.Windows.Forms.Button resetProgram;
        private System.Windows.Forms.GroupBox memView;
        private System.Windows.Forms.Button refreshMem;
        private System.Windows.Forms.TextBox programEditor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox dataMem2;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox enterMemAdd;
        private System.Windows.Forms.TextBox enterMemContent;
        private System.Windows.Forms.Button updateMem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox negFlag;
        private System.Windows.Forms.CheckBox zeroFlag;
        private System.Windows.Forms.CheckBox carryFlag;
    }
}

