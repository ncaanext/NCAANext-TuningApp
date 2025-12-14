namespace NEXT_Tuning_App
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.NumericUpDown numPlaysPerGame;
        private System.Windows.Forms.NumericUpDown numAutoBids;
        private System.Windows.Forms.NumericUpDown numStartYear;
        private System.Windows.Forms.Label lblStartYearCaption;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnOpen = new Button();
            btnSave = new Button();
            lblFile = new Label();
            numPlaysPerGame = new NumericUpDown();
            numAutoBids = new NumericUpDown();
            lblStartYearCaption = new Label();
            numStartYear = new NumericUpDown();
            numFatigueJV = new NumericUpDown();
            numFatigueVarsity = new NumericUpDown();
            numFatigueAA = new NumericUpDown();
            numFatigueHeisman = new NumericUpDown();
            groupFatigue = new GroupBox();
            label13 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnPickTeamTextColor = new Button();
            pnlTeamTextColorPreview = new Panel();
            lblTeamTextColorRaw = new Label();
            PPGBox = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            lblMatchUpColorRaw = new Label();
            pnlMatchUpColorPreview = new Panel();
            btnMatchUpTextColor = new Button();
            groupSpeedNerf = new GroupBox();
            label15 = new Label();
            SpeedNerfAmount = new NumericUpDown();
            SpeedNerfBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numPlaysPerGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAutoBids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueJV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueVarsity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueHeisman).BeginInit();
            groupFatigue.SuspendLayout();
            groupBox2.SuspendLayout();
            groupSpeedNerf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedNerfAmount).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.SkyBlue;
            btnOpen.Location = new Point(17, 26);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 31);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SkyBlue;
            btnSave.Location = new Point(105, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFile
            // 
            lblFile.Location = new Point(6, 74);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(311, 20);
            lblFile.TabIndex = 5;
            lblFile.Text = "No file loaded";
            // 
            // numPlaysPerGame
            // 
            numPlaysPerGame.Location = new Point(12, 244);
            numPlaysPerGame.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numPlaysPerGame.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
            numPlaysPerGame.Name = "numPlaysPerGame";
            numPlaysPerGame.Size = new Size(75, 22);
            numPlaysPerGame.TabIndex = 6;
            numPlaysPerGame.TextAlign = HorizontalAlignment.Center;
            numPlaysPerGame.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numPlaysPerGame.ValueChanged += numPlaysPerGame_ValueChanged;
            // 
            // numAutoBids
            // 
            numAutoBids.Location = new Point(12, 348);
            numAutoBids.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numAutoBids.Name = "numAutoBids";
            numAutoBids.Size = new Size(75, 22);
            numAutoBids.TabIndex = 8;
            numAutoBids.TextAlign = HorizontalAlignment.Center;
            numAutoBids.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblStartYearCaption
            // 
            lblStartYearCaption.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblStartYearCaption.Location = new Point(12, 136);
            lblStartYearCaption.Name = "lblStartYearCaption";
            lblStartYearCaption.Size = new Size(258, 20);
            lblStartYearCaption.TabIndex = 0;
            lblStartYearCaption.Text = "Dynasty Starting Year";
            // 
            // numStartYear
            // 
            numStartYear.Location = new Point(12, 159);
            numStartYear.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numStartYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numStartYear.Name = "numStartYear";
            numStartYear.Size = new Size(75, 22);
            numStartYear.TabIndex = 1;
            numStartYear.TextAlign = HorizontalAlignment.Center;
            numStartYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // numFatigueJV
            // 
            numFatigueJV.DecimalPlaces = 3;
            numFatigueJV.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueJV.Location = new Point(100, 26);
            numFatigueJV.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueJV.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueJV.Name = "numFatigueJV";
            numFatigueJV.Size = new Size(59, 22);
            numFatigueJV.TabIndex = 10;
            numFatigueJV.TextAlign = HorizontalAlignment.Center;
            numFatigueJV.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numFatigueVarsity
            // 
            numFatigueVarsity.DecimalPlaces = 3;
            numFatigueVarsity.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueVarsity.Location = new Point(100, 71);
            numFatigueVarsity.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueVarsity.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueVarsity.Name = "numFatigueVarsity";
            numFatigueVarsity.Size = new Size(59, 22);
            numFatigueVarsity.TabIndex = 11;
            numFatigueVarsity.TextAlign = HorizontalAlignment.Center;
            numFatigueVarsity.Value = new decimal(new int[] { 75, 0, 0, 131072 });
            // 
            // numFatigueAA
            // 
            numFatigueAA.DecimalPlaces = 3;
            numFatigueAA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueAA.Location = new Point(100, 123);
            numFatigueAA.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueAA.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueAA.Name = "numFatigueAA";
            numFatigueAA.Size = new Size(59, 22);
            numFatigueAA.TabIndex = 12;
            numFatigueAA.TextAlign = HorizontalAlignment.Center;
            numFatigueAA.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // numFatigueHeisman
            // 
            numFatigueHeisman.DecimalPlaces = 3;
            numFatigueHeisman.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numFatigueHeisman.Location = new Point(100, 171);
            numFatigueHeisman.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numFatigueHeisman.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numFatigueHeisman.Name = "numFatigueHeisman";
            numFatigueHeisman.Size = new Size(59, 22);
            numFatigueHeisman.TabIndex = 13;
            numFatigueHeisman.TextAlign = HorizontalAlignment.Center;
            numFatigueHeisman.Value = new decimal(new int[] { 115, 0, 0, 131072 });
            // 
            // groupFatigue
            // 
            groupFatigue.Controls.Add(label13);
            groupFatigue.Controls.Add(label9);
            groupFatigue.Controls.Add(label4);
            groupFatigue.Controls.Add(label3);
            groupFatigue.Controls.Add(label2);
            groupFatigue.Controls.Add(label1);
            groupFatigue.Controls.Add(numFatigueJV);
            groupFatigue.Controls.Add(numFatigueHeisman);
            groupFatigue.Controls.Add(numFatigueVarsity);
            groupFatigue.Controls.Add(numFatigueAA);
            groupFatigue.Location = new Point(370, 13);
            groupFatigue.Name = "groupFatigue";
            groupFatigue.Size = new Size(193, 256);
            groupFatigue.TabIndex = 14;
            groupFatigue.TabStop = false;
            groupFatigue.Text = "Fatigue Slider";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F);
            label13.Location = new Point(2, 226);
            label13.Name = "label13";
            label13.Size = new Size(182, 13);
            label13.TabIndex = 19;
            label13.Text = "Next Defaults: 1.0 / 1.1 / 1.17 / 1.17";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F);
            label9.Location = new Point(2, 205);
            label9.Name = "label9";
            label9.Size = new Size(185, 13);
            label9.TabIndex = 18;
            label9.Text = "OG Defaults: 0.50 / 0.75 / 1.0 / 1.15 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "Heisman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 16;
            label3.Text = "All-American";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 79);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "Varsity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 14;
            label1.Text = "Junior Varsity";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(258, 20);
            label5.TabIndex = 15;
            label5.Text = "Sim Game Length Factor";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(258, 20);
            label6.TabIndex = 16;
            label6.Text = "No. of Conf Champ Automatic Playoff Spots";
            // 
            // btnPickTeamTextColor
            // 
            btnPickTeamTextColor.BackColor = Color.SkyBlue;
            btnPickTeamTextColor.Location = new Point(601, 34);
            btnPickTeamTextColor.Name = "btnPickTeamTextColor";
            btnPickTeamTextColor.Size = new Size(192, 33);
            btnPickTeamTextColor.TabIndex = 17;
            btnPickTeamTextColor.Text = "Color Chooser";
            btnPickTeamTextColor.UseVisualStyleBackColor = false;
            btnPickTeamTextColor.MouseClick += btnPickTeamTextColor_Click;
            // 
            // pnlTeamTextColorPreview
            // 
            pnlTeamTextColorPreview.Location = new Point(601, 73);
            pnlTeamTextColorPreview.Name = "pnlTeamTextColorPreview";
            pnlTeamTextColorPreview.Size = new Size(192, 47);
            pnlTeamTextColorPreview.TabIndex = 18;
            // 
            // lblTeamTextColorRaw
            // 
            lblTeamTextColorRaw.AutoSize = true;
            lblTeamTextColorRaw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamTextColorRaw.Location = new Point(601, 123);
            lblTeamTextColorRaw.Name = "lblTeamTextColorRaw";
            lblTeamTextColorRaw.Size = new Size(66, 15);
            lblTeamTextColorRaw.TabIndex = 19;
            lblTeamTextColorRaw.Text = "Raw Value";
            // 
            // PPGBox
            // 
            PPGBox.BackColor = SystemColors.Info;
            PPGBox.Enabled = false;
            PPGBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PPGBox.Location = new Point(111, 244);
            PPGBox.Name = "PPGBox";
            PPGBox.ReadOnly = true;
            PPGBox.Size = new Size(52, 25);
            PPGBox.TabIndex = 20;
            PPGBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 249);
            label7.Name = "label7";
            label7.Size = new Size(166, 16);
            label7.TabIndex = 21;
            label7.Text = "Predicted Plays Per Game";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFile);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 97);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(509, 384);
            label8.Name = "label8";
            label8.Size = new Size(327, 16);
            label8.TabIndex = 23;
            label8.Text = "NCAA Next Tuning App v1.0  by Antdroid + JDHalfrack";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label10.Location = new Point(601, 13);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 24;
            label10.Text = "User Team Highlighted Text Color";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F);
            label11.Location = new Point(12, 290);
            label11.Name = "label11";
            label11.Size = new Size(174, 13);
            label11.TabIndex = 19;
            label11.Text = "OG Default: 100  NEXT Default: 92";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F);
            label12.Location = new Point(12, 384);
            label12.Name = "label12";
            label12.Size = new Size(85, 13);
            label12.TabIndex = 25;
            label12.Text = "NEXT Default: 5";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label14.Location = new Point(601, 211);
            label14.Name = "label14";
            label14.Size = new Size(192, 20);
            label14.TabIndex = 29;
            label14.Text = "Match-Up Highlighted Text Color";
            // 
            // lblMatchUpColorRaw
            // 
            lblMatchUpColorRaw.AutoSize = true;
            lblMatchUpColorRaw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatchUpColorRaw.Location = new Point(601, 321);
            lblMatchUpColorRaw.Name = "lblMatchUpColorRaw";
            lblMatchUpColorRaw.Size = new Size(66, 15);
            lblMatchUpColorRaw.TabIndex = 28;
            lblMatchUpColorRaw.Text = "Raw Value";
            // 
            // pnlMatchUpColorPreview
            // 
            pnlMatchUpColorPreview.Location = new Point(601, 271);
            pnlMatchUpColorPreview.Name = "pnlMatchUpColorPreview";
            pnlMatchUpColorPreview.Size = new Size(192, 47);
            pnlMatchUpColorPreview.TabIndex = 27;
            // 
            // btnMatchUpTextColor
            // 
            btnMatchUpTextColor.BackColor = Color.SkyBlue;
            btnMatchUpTextColor.Location = new Point(601, 232);
            btnMatchUpTextColor.Name = "btnMatchUpTextColor";
            btnMatchUpTextColor.Size = new Size(192, 33);
            btnMatchUpTextColor.TabIndex = 26;
            btnMatchUpTextColor.Text = "Color Chooser";
            btnMatchUpTextColor.UseVisualStyleBackColor = false;
            btnMatchUpTextColor.Click += btnMatchUpTextColor_Click;
            // 
            // groupSpeedNerf
            // 
            groupSpeedNerf.Controls.Add(label15);
            groupSpeedNerf.Controls.Add(SpeedNerfAmount);
            groupSpeedNerf.Controls.Add(SpeedNerfBox);
            groupSpeedNerf.Location = new Point(370, 275);
            groupSpeedNerf.Name = "groupSpeedNerf";
            groupSpeedNerf.Size = new Size(193, 95);
            groupSpeedNerf.TabIndex = 30;
            groupSpeedNerf.TabStop = false;
            groupSpeedNerf.Text = "Speed Nerf";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(77, 60);
            label15.Name = "label15";
            label15.Size = new Size(80, 16);
            label15.TabIndex = 2;
            label15.Text = "Nerf Amount";
            // 
            // SpeedNerfAmount
            // 
            SpeedNerfAmount.Enabled = false;
            SpeedNerfAmount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpeedNerfAmount.Location = new Point(12, 56);
            SpeedNerfAmount.Maximum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            SpeedNerfAmount.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            SpeedNerfAmount.Name = "SpeedNerfAmount";
            SpeedNerfAmount.ReadOnly = true;
            SpeedNerfAmount.Size = new Size(59, 24);
            SpeedNerfAmount.TabIndex = 1;
            SpeedNerfAmount.TextAlign = HorizontalAlignment.Center;
            SpeedNerfAmount.Value = new decimal(new int[] { 20, 0, 0, int.MinValue });
            // 
            // SpeedNerfBox
            // 
            SpeedNerfBox.AutoSize = true;
            SpeedNerfBox.Location = new Point(14, 30);
            SpeedNerfBox.Name = "SpeedNerfBox";
            SpeedNerfBox.Size = new Size(153, 20);
            SpeedNerfBox.TabIndex = 0;
            SpeedNerfBox.Text = "Speed Nerf Disabled";
            SpeedNerfBox.UseVisualStyleBackColor = true;
            SpeedNerfBox.CheckedChanged += SpeedNerfBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(838, 407);
            Controls.Add(groupSpeedNerf);
            Controls.Add(label14);
            Controls.Add(lblMatchUpColorRaw);
            Controls.Add(pnlMatchUpColorPreview);
            Controls.Add(btnMatchUpTextColor);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(PPGBox);
            Controls.Add(lblTeamTextColorRaw);
            Controls.Add(pnlTeamTextColorPreview);
            Controls.Add(btnPickTeamTextColor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupFatigue);
            Controls.Add(lblStartYearCaption);
            Controls.Add(numStartYear);
            Controls.Add(numPlaysPerGame);
            Controls.Add(numAutoBids);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "NCAA Next Tuning App";
            ((System.ComponentModel.ISupportInitialize)numPlaysPerGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAutoBids).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueJV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueVarsity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFatigueHeisman).EndInit();
            groupFatigue.ResumeLayout(false);
            groupFatigue.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupSpeedNerf.ResumeLayout(false);
            groupSpeedNerf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedNerfAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private NumericUpDown numFatigueJV;
        private NumericUpDown numFatigueVarsity;
        private NumericUpDown numFatigueAA;
        private NumericUpDown numFatigueHeisman;
        private GroupBox groupFatigue;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btnPickTeamTextColor;
        private Panel pnlTeamTextColorPreview;
        private Label lblTeamTextColorRaw;
        private TextBox PPGBox;
        private Label label7;
        private Label label9;
        private GroupBox groupBox2;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblMatchUpColorRaw;
        private Panel pnlMatchUpColorPreview;
        private Button btnMatchUpTextColor;
        private GroupBox groupSpeedNerf;
        private NumericUpDown SpeedNerfAmount;
        private CheckBox SpeedNerfBox;
        private Label label15;
    }
}