namespace Program1_CS_A
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
            this.TxBxMerter1S = new System.Windows.Forms.TextBox();
            this.TxBxMerter2S = new System.Windows.Forms.TextBox();
            this.TxBxMerter3S = new System.Windows.Forms.TextBox();
            this.TxBxMerter1E = new System.Windows.Forms.TextBox();
            this.TxBxMerter2E = new System.Windows.Forms.TextBox();
            this.TxBxMerter3E = new System.Windows.Forms.TextBox();
            this.LblMeter1 = new System.Windows.Forms.Label();
            this.LblMeter2 = new System.Windows.Forms.Label();
            this.LblMeter3 = new System.Windows.Forms.Label();
            this.LblStarting = new System.Windows.Forms.Label();
            this.LblEnding = new System.Windows.Forms.Label();
            this.LblPrior = new System.Windows.Forms.Label();
            this.TxBxPrior = new System.Windows.Forms.TextBox();
            this.LblMeterCount = new System.Windows.Forms.Label();
            this.TxBxMCount = new System.Windows.Forms.TextBox();
            this.BtnAfter = new System.Windows.Forms.Button();
            this.BtnMissed = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRecalc = new System.Windows.Forms.Button();
            this.LblKWH = new System.Windows.Forms.Label();
            this.Meter1KWH = new System.Windows.Forms.Label();
            this.Meter2KWH = new System.Windows.Forms.Label();
            this.Meter3KWH = new System.Windows.Forms.Label();
            this.LblTotalKWH = new System.Windows.Forms.Label();
            this.TotalKWUsed = new System.Windows.Forms.Label();
            this.LblKWHCharge = new System.Windows.Forms.Label();
            this.KWHCharge = new System.Windows.Forms.Label();
            this.LblMeterCharge = new System.Windows.Forms.Label();
            this.MeterCharge = new System.Windows.Forms.Label();
            this.LblAfterCharge = new System.Windows.Forms.Label();
            this.AfterCharge = new System.Windows.Forms.Label();
            this.LblMissedCharge = new System.Windows.Forms.Label();
            this.MissedCharge = new System.Windows.Forms.Label();
            this.LblTotalDue = new System.Windows.Forms.Label();
            this.VerifyInput = new System.Windows.Forms.Label();
            this.GrpbxUsage = new System.Windows.Forms.GroupBox();
            this.LblKWHDisc = new System.Windows.Forms.Label();
            this.LblRehab = new System.Windows.Forms.Label();
            this.LblKWHMes = new System.Windows.Forms.Label();
            this.LblRehabMes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRehab = new System.Windows.Forms.Button();
            this.GrpbxUsage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxBxMerter1S
            // 
            this.TxBxMerter1S.Location = new System.Drawing.Point(103, 37);
            this.TxBxMerter1S.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter1S.MaxLength = 4;
            this.TxBxMerter1S.Name = "TxBxMerter1S";
            this.TxBxMerter1S.Size = new System.Drawing.Size(80, 24);
            this.TxBxMerter1S.TabIndex = 0;
            // 
            // TxBxMerter2S
            // 
            this.TxBxMerter2S.Location = new System.Drawing.Point(103, 76);
            this.TxBxMerter2S.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter2S.MaxLength = 4;
            this.TxBxMerter2S.Name = "TxBxMerter2S";
            this.TxBxMerter2S.Size = new System.Drawing.Size(80, 24);
            this.TxBxMerter2S.TabIndex = 2;
            this.TxBxMerter2S.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxBxMerter3S
            // 
            this.TxBxMerter3S.Location = new System.Drawing.Point(103, 117);
            this.TxBxMerter3S.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter3S.MaxLength = 4;
            this.TxBxMerter3S.Name = "TxBxMerter3S";
            this.TxBxMerter3S.Size = new System.Drawing.Size(80, 24);
            this.TxBxMerter3S.TabIndex = 4;
            this.TxBxMerter3S.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxBxMerter1E
            // 
            this.TxBxMerter1E.Location = new System.Drawing.Point(224, 37);
            this.TxBxMerter1E.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter1E.MaxLength = 4;
            this.TxBxMerter1E.Name = "TxBxMerter1E";
            this.TxBxMerter1E.Size = new System.Drawing.Size(75, 24);
            this.TxBxMerter1E.TabIndex = 1;
            // 
            // TxBxMerter2E
            // 
            this.TxBxMerter2E.Location = new System.Drawing.Point(224, 76);
            this.TxBxMerter2E.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter2E.MaxLength = 4;
            this.TxBxMerter2E.Name = "TxBxMerter2E";
            this.TxBxMerter2E.Size = new System.Drawing.Size(75, 24);
            this.TxBxMerter2E.TabIndex = 3;
            // 
            // TxBxMerter3E
            // 
            this.TxBxMerter3E.Location = new System.Drawing.Point(224, 117);
            this.TxBxMerter3E.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxMerter3E.MaxLength = 4;
            this.TxBxMerter3E.Name = "TxBxMerter3E";
            this.TxBxMerter3E.Size = new System.Drawing.Size(75, 24);
            this.TxBxMerter3E.TabIndex = 5;
            // 
            // LblMeter1
            // 
            this.LblMeter1.AutoSize = true;
            this.LblMeter1.Location = new System.Drawing.Point(18, 41);
            this.LblMeter1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMeter1.Name = "LblMeter1";
            this.LblMeter1.Size = new System.Drawing.Size(54, 18);
            this.LblMeter1.TabIndex = 7;
            this.LblMeter1.Text = "Meter1";
            // 
            // LblMeter2
            // 
            this.LblMeter2.AutoSize = true;
            this.LblMeter2.Location = new System.Drawing.Point(18, 80);
            this.LblMeter2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMeter2.Name = "LblMeter2";
            this.LblMeter2.Size = new System.Drawing.Size(54, 18);
            this.LblMeter2.TabIndex = 8;
            this.LblMeter2.Text = "Meter2";
            // 
            // LblMeter3
            // 
            this.LblMeter3.AutoSize = true;
            this.LblMeter3.Location = new System.Drawing.Point(18, 121);
            this.LblMeter3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMeter3.Name = "LblMeter3";
            this.LblMeter3.Size = new System.Drawing.Size(54, 18);
            this.LblMeter3.TabIndex = 9;
            this.LblMeter3.Text = "Meter3";
            // 
            // LblStarting
            // 
            this.LblStarting.AutoSize = true;
            this.LblStarting.Location = new System.Drawing.Point(116, 15);
            this.LblStarting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStarting.Name = "LblStarting";
            this.LblStarting.Size = new System.Drawing.Size(58, 18);
            this.LblStarting.TabIndex = 10;
            this.LblStarting.Text = "Starting";
            // 
            // LblEnding
            // 
            this.LblEnding.AutoSize = true;
            this.LblEnding.Location = new System.Drawing.Point(232, 15);
            this.LblEnding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEnding.Name = "LblEnding";
            this.LblEnding.Size = new System.Drawing.Size(53, 18);
            this.LblEnding.TabIndex = 11;
            this.LblEnding.Text = "Ending";
            // 
            // LblPrior
            // 
            this.LblPrior.AutoSize = true;
            this.LblPrior.Location = new System.Drawing.Point(534, 18);
            this.LblPrior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrior.Name = "LblPrior";
            this.LblPrior.Size = new System.Drawing.Size(117, 18);
            this.LblPrior.TabIndex = 13;
            this.LblPrior.Text = "Prior Balance   $";
            // 
            // TxBxPrior
            // 
            this.TxBxPrior.Location = new System.Drawing.Point(651, 15);
            this.TxBxPrior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxBxPrior.Name = "TxBxPrior";
            this.TxBxPrior.Size = new System.Drawing.Size(102, 24);
            this.TxBxPrior.TabIndex = 6;
            // 
            // LblMeterCount
            // 
            this.LblMeterCount.AutoSize = true;
            this.LblMeterCount.Location = new System.Drawing.Point(585, 52);
            this.LblMeterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMeterCount.Name = "LblMeterCount";
            this.LblMeterCount.Size = new System.Drawing.Size(90, 18);
            this.LblMeterCount.TabIndex = 12;
            this.LblMeterCount.Text = "Meter Count";
            this.LblMeterCount.Click += new System.EventHandler(this.LblMeterCount_Click);
            // 
            // TxBxMCount
            // 
            this.TxBxMCount.Location = new System.Drawing.Point(682, 49);
            this.TxBxMCount.Name = "TxBxMCount";
            this.TxBxMCount.Size = new System.Drawing.Size(71, 24);
            this.TxBxMCount.TabIndex = 7;
            // 
            // BtnAfter
            // 
            this.BtnAfter.Location = new System.Drawing.Point(307, 248);
            this.BtnAfter.Name = "BtnAfter";
            this.BtnAfter.Size = new System.Drawing.Size(101, 33);
            this.BtnAfter.TabIndex = 16;
            this.BtnAfter.Text = "&After Hours";
            this.BtnAfter.UseVisualStyleBackColor = true;
            this.BtnAfter.Click += new System.EventHandler(this.BtnAfter_Click);
            // 
            // BtnMissed
            // 
            this.BtnMissed.Location = new System.Drawing.Point(307, 294);
            this.BtnMissed.Name = "BtnMissed";
            this.BtnMissed.Size = new System.Drawing.Size(101, 32);
            this.BtnMissed.TabIndex = 17;
            this.BtnMissed.Text = "&Missed Appt";
            this.BtnMissed.UseVisualStyleBackColor = true;
            this.BtnMissed.Click += new System.EventHandler(this.BtnMissed_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(91, 414);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(101, 28);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRecalc
            // 
            this.BtnRecalc.Location = new System.Drawing.Point(91, 448);
            this.BtnRecalc.Name = "BtnRecalc";
            this.BtnRecalc.Size = new System.Drawing.Size(187, 35);
            this.BtnRecalc.TabIndex = 19;
            this.BtnRecalc.Text = "&Recalculate";
            this.BtnRecalc.UseVisualStyleBackColor = true;
            this.BtnRecalc.Click += new System.EventHandler(this.BtnRecalc_Click);
            // 
            // LblKWH
            // 
            this.LblKWH.AutoSize = true;
            this.LblKWH.Location = new System.Drawing.Point(371, 15);
            this.LblKWH.Name = "LblKWH";
            this.LblKWH.Size = new System.Drawing.Size(83, 18);
            this.LblKWH.TabIndex = 20;
            this.LblKWH.Text = "KWH Used";
            // 
            // Meter1KWH
            // 
            this.Meter1KWH.AutoSize = true;
            this.Meter1KWH.Location = new System.Drawing.Point(383, 40);
            this.Meter1KWH.Name = "Meter1KWH";
            this.Meter1KWH.Size = new System.Drawing.Size(0, 18);
            this.Meter1KWH.TabIndex = 21;
            // 
            // Meter2KWH
            // 
            this.Meter2KWH.AutoSize = true;
            this.Meter2KWH.Location = new System.Drawing.Point(383, 79);
            this.Meter2KWH.Name = "Meter2KWH";
            this.Meter2KWH.Size = new System.Drawing.Size(0, 18);
            this.Meter2KWH.TabIndex = 22;
            // 
            // Meter3KWH
            // 
            this.Meter3KWH.AutoSize = true;
            this.Meter3KWH.Location = new System.Drawing.Point(383, 120);
            this.Meter3KWH.Name = "Meter3KWH";
            this.Meter3KWH.Size = new System.Drawing.Size(0, 18);
            this.Meter3KWH.TabIndex = 23;
            // 
            // LblTotalKWH
            // 
            this.LblTotalKWH.AutoSize = true;
            this.LblTotalKWH.Location = new System.Drawing.Point(286, 150);
            this.LblTotalKWH.Name = "LblTotalKWH";
            this.LblTotalKWH.Size = new System.Drawing.Size(81, 18);
            this.LblTotalKWH.TabIndex = 24;
            this.LblTotalKWH.Text = "Total KWH";
            // 
            // TotalKWUsed
            // 
            this.TotalKWUsed.AutoSize = true;
            this.TotalKWUsed.Location = new System.Drawing.Point(380, 154);
            this.TotalKWUsed.Name = "TotalKWUsed";
            this.TotalKWUsed.Size = new System.Drawing.Size(0, 18);
            this.TotalKWUsed.TabIndex = 25;
            // 
            // LblKWHCharge
            // 
            this.LblKWHCharge.AutoSize = true;
            this.LblKWHCharge.Location = new System.Drawing.Point(8, 28);
            this.LblKWHCharge.Name = "LblKWHCharge";
            this.LblKWHCharge.Size = new System.Drawing.Size(96, 18);
            this.LblKWHCharge.TabIndex = 26;
            this.LblKWHCharge.Text = "KWH Charge";
            // 
            // KWHCharge
            // 
            this.KWHCharge.AutoSize = true;
            this.KWHCharge.Location = new System.Drawing.Point(158, 26);
            this.KWHCharge.Name = "KWHCharge";
            this.KWHCharge.Size = new System.Drawing.Size(0, 18);
            this.KWHCharge.TabIndex = 27;
            // 
            // LblMeterCharge
            // 
            this.LblMeterCharge.AutoSize = true;
            this.LblMeterCharge.Location = new System.Drawing.Point(8, 102);
            this.LblMeterCharge.Name = "LblMeterCharge";
            this.LblMeterCharge.Size = new System.Drawing.Size(98, 18);
            this.LblMeterCharge.TabIndex = 28;
            this.LblMeterCharge.Text = "Meter Charge";
            // 
            // MeterCharge
            // 
            this.MeterCharge.AutoSize = true;
            this.MeterCharge.Location = new System.Drawing.Point(158, 102);
            this.MeterCharge.Name = "MeterCharge";
            this.MeterCharge.Size = new System.Drawing.Size(0, 18);
            this.MeterCharge.TabIndex = 29;
            // 
            // LblAfterCharge
            // 
            this.LblAfterCharge.AutoSize = true;
            this.LblAfterCharge.Location = new System.Drawing.Point(8, 131);
            this.LblAfterCharge.Name = "LblAfterCharge";
            this.LblAfterCharge.Size = new System.Drawing.Size(135, 18);
            this.LblAfterCharge.TabIndex = 30;
            this.LblAfterCharge.Text = "After Hours Charge";
            // 
            // AfterCharge
            // 
            this.AfterCharge.AutoSize = true;
            this.AfterCharge.Location = new System.Drawing.Point(158, 131);
            this.AfterCharge.Name = "AfterCharge";
            this.AfterCharge.Size = new System.Drawing.Size(0, 18);
            this.AfterCharge.TabIndex = 31;
            // 
            // LblMissedCharge
            // 
            this.LblMissedCharge.AutoSize = true;
            this.LblMissedCharge.Location = new System.Drawing.Point(8, 158);
            this.LblMissedCharge.Name = "LblMissedCharge";
            this.LblMissedCharge.Size = new System.Drawing.Size(141, 18);
            this.LblMissedCharge.TabIndex = 32;
            this.LblMissedCharge.Text = "Missed Appt Charge";
            // 
            // MissedCharge
            // 
            this.MissedCharge.AutoSize = true;
            this.MissedCharge.Location = new System.Drawing.Point(158, 158);
            this.MissedCharge.Name = "MissedCharge";
            this.MissedCharge.Size = new System.Drawing.Size(0, 18);
            this.MissedCharge.TabIndex = 33;
            // 
            // LblTotalDue
            // 
            this.LblTotalDue.AutoSize = true;
            this.LblTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDue.Location = new System.Drawing.Point(486, 451);
            this.LblTotalDue.Name = "LblTotalDue";
            this.LblTotalDue.Size = new System.Drawing.Size(0, 18);
            this.LblTotalDue.TabIndex = 34;
            // 
            // VerifyInput
            // 
            this.VerifyInput.AutoSize = true;
            this.VerifyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyInput.ForeColor = System.Drawing.Color.Firebrick;
            this.VerifyInput.Location = new System.Drawing.Point(15, 219);
            this.VerifyInput.Name = "VerifyInput";
            this.VerifyInput.Size = new System.Drawing.Size(0, 18);
            this.VerifyInput.TabIndex = 35;
            // 
            // GrpbxUsage
            // 
            this.GrpbxUsage.Controls.Add(this.TotalKWUsed);
            this.GrpbxUsage.Controls.Add(this.LblTotalKWH);
            this.GrpbxUsage.Controls.Add(this.Meter3KWH);
            this.GrpbxUsage.Controls.Add(this.Meter2KWH);
            this.GrpbxUsage.Controls.Add(this.Meter1KWH);
            this.GrpbxUsage.Controls.Add(this.LblKWH);
            this.GrpbxUsage.Controls.Add(this.LblEnding);
            this.GrpbxUsage.Controls.Add(this.LblStarting);
            this.GrpbxUsage.Controls.Add(this.LblMeter3);
            this.GrpbxUsage.Controls.Add(this.LblMeter2);
            this.GrpbxUsage.Controls.Add(this.LblMeter1);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter3E);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter2E);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter1E);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter3S);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter2S);
            this.GrpbxUsage.Controls.Add(this.TxBxMerter1S);
            this.GrpbxUsage.Location = new System.Drawing.Point(18, 29);
            this.GrpbxUsage.Name = "GrpbxUsage";
            this.GrpbxUsage.Size = new System.Drawing.Size(478, 178);
            this.GrpbxUsage.TabIndex = 36;
            this.GrpbxUsage.TabStop = false;
            this.GrpbxUsage.Text = "Usage";
            // 
            // LblKWHDisc
            // 
            this.LblKWHDisc.AutoSize = true;
            this.LblKWHDisc.Location = new System.Drawing.Point(9, 56);
            this.LblKWHDisc.Name = "LblKWHDisc";
            this.LblKWHDisc.Size = new System.Drawing.Size(107, 18);
            this.LblKWHDisc.TabIndex = 37;
            this.LblKWHDisc.Text = "KWH Discount";
            // 
            // LblRehab
            // 
            this.LblRehab.AutoSize = true;
            this.LblRehab.Location = new System.Drawing.Point(9, 202);
            this.LblRehab.Name = "LblRehab";
            this.LblRehab.Size = new System.Drawing.Size(114, 18);
            this.LblRehab.TabIndex = 38;
            this.LblRehab.Text = "Rehab Discount";
            // 
            // LblKWHMes
            // 
            this.LblKWHMes.AutoSize = true;
            this.LblKWHMes.Location = new System.Drawing.Point(158, 56);
            this.LblKWHMes.Name = "LblKWHMes";
            this.LblKWHMes.Size = new System.Drawing.Size(0, 18);
            this.LblKWHMes.TabIndex = 39;
            // 
            // LblRehabMes
            // 
            this.LblRehabMes.AutoSize = true;
            this.LblRehabMes.Location = new System.Drawing.Point(158, 202);
            this.LblRehabMes.Name = "LblRehabMes";
            this.LblRehabMes.Size = new System.Drawing.Size(0, 18);
            this.LblRehabMes.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblRehabMes);
            this.groupBox1.Controls.Add(this.LblKWHMes);
            this.groupBox1.Controls.Add(this.LblRehab);
            this.groupBox1.Controls.Add(this.LblKWHDisc);
            this.groupBox1.Controls.Add(this.MissedCharge);
            this.groupBox1.Controls.Add(this.LblMissedCharge);
            this.groupBox1.Controls.Add(this.AfterCharge);
            this.groupBox1.Controls.Add(this.LblAfterCharge);
            this.groupBox1.Controls.Add(this.MeterCharge);
            this.groupBox1.Controls.Add(this.LblMeterCharge);
            this.groupBox1.Controls.Add(this.KWHCharge);
            this.groupBox1.Controls.Add(this.LblKWHCharge);
            this.groupBox1.Location = new System.Drawing.Point(510, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 238);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charges";
            // 
            // BtnRehab
            // 
            this.BtnRehab.Location = new System.Drawing.Point(307, 343);
            this.BtnRehab.Name = "BtnRehab";
            this.BtnRehab.Size = new System.Drawing.Size(101, 32);
            this.BtnRehab.TabIndex = 42;
            this.BtnRehab.Text = "Rehab";
            this.BtnRehab.UseVisualStyleBackColor = true;
            this.BtnRehab.Click += new System.EventHandler(this.BtnRehab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 499);
            this.Controls.Add(this.BtnRehab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpbxUsage);
            this.Controls.Add(this.VerifyInput);
            this.Controls.Add(this.LblTotalDue);
            this.Controls.Add(this.BtnRecalc);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnMissed);
            this.Controls.Add(this.BtnAfter);
            this.Controls.Add(this.TxBxMCount);
            this.Controls.Add(this.TxBxPrior);
            this.Controls.Add(this.LblPrior);
            this.Controls.Add(this.LblMeterCount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delinquent Calculator 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpbxUsage.ResumeLayout(false);
            this.GrpbxUsage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBxMerter1S;
        private System.Windows.Forms.TextBox TxBxMerter2S;
        private System.Windows.Forms.TextBox TxBxMerter3S;
        private System.Windows.Forms.TextBox TxBxMerter1E;
        private System.Windows.Forms.TextBox TxBxMerter2E;
        private System.Windows.Forms.TextBox TxBxMerter3E;
        private System.Windows.Forms.Label LblMeter1;
        private System.Windows.Forms.Label LblMeter2;
        private System.Windows.Forms.Label LblMeter3;
        private System.Windows.Forms.Label LblStarting;
        private System.Windows.Forms.Label LblEnding;
        private System.Windows.Forms.Label LblPrior;
        private System.Windows.Forms.TextBox TxBxPrior;
        private System.Windows.Forms.Label LblMeterCount;
        private System.Windows.Forms.TextBox TxBxMCount;
        private System.Windows.Forms.Button BtnAfter;
        private System.Windows.Forms.Button BtnMissed;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRecalc;
        private System.Windows.Forms.Label LblKWH;
        private System.Windows.Forms.Label Meter1KWH;
        private System.Windows.Forms.Label Meter2KWH;
        private System.Windows.Forms.Label Meter3KWH;
        private System.Windows.Forms.Label LblTotalKWH;
        private System.Windows.Forms.Label TotalKWUsed;
        private System.Windows.Forms.Label LblKWHCharge;
        private System.Windows.Forms.Label KWHCharge;
        private System.Windows.Forms.Label LblMeterCharge;
        private System.Windows.Forms.Label MeterCharge;
        private System.Windows.Forms.Label LblAfterCharge;
        private System.Windows.Forms.Label AfterCharge;
        private System.Windows.Forms.Label LblMissedCharge;
        private System.Windows.Forms.Label MissedCharge;
        private System.Windows.Forms.Label LblTotalDue;
        private System.Windows.Forms.Label VerifyInput;
        private System.Windows.Forms.GroupBox GrpbxUsage;
        private System.Windows.Forms.Label LblKWHDisc;
        private System.Windows.Forms.Label LblRehab;
        private System.Windows.Forms.Label LblKWHMes;
        private System.Windows.Forms.Label LblRehabMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRehab;
    }
}

