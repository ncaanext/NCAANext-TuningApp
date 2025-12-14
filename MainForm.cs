using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {
        //Offset Database is located in Offset.cs file

        private System.Drawing.Color teamTextColor = System.Drawing.Color.White;
        private System.Drawing.Color matchupTextColor = System.Drawing.Color.White;

        private FileStream? fs;
        private long originBase;

        public MainForm()
        {
            InitializeComponent();
            ToggleUI(false);
        }

        private void ToggleUI(bool enabled)
        {
            numPlaysPerGame.Enabled = enabled;
            numAutoBids.Enabled = enabled;
            numStartYear.Enabled = enabled;
            btnPickTeamTextColor.Enabled = enabled;
            btnMatchUpTextColor.Enabled = enabled;
            btnSave.Enabled = enabled;
            groupSpeedNerf.Enabled = enabled;
            groupFatigue.Enabled = enabled;
        }

        //Open File
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "All Files (*.*)|*.*" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            fs?.Dispose();
            fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);

            // Fix: Pass the FileStream (_fs) instead of the file name string to SignatureScanner.TryFind
            if (!SignatureScanner.TryFind(fs, SlusSignature, out originBase))
            {
                MessageBox.Show("SLUS ELF header not found.");
                ToggleUI(false);
                return;
            }

            lblFile.Text = $"{Path.GetFileName(ofd.FileName)} (SLUS @ 0x{originBase:X})";
            LoadValues();
            ToggleUI(true);
        }

        //Load Default Values from File
        private void LoadValues()
        {
            //Plays Per Game Slider
            byte plays = ReadByte(originBase + PlaysPerGameOffset);
            byte autoBids = ReadByte(originBase + AutoBidOffset);

            numPlaysPerGame.Value = Math.Clamp(plays, (byte)80, (byte)120);
            numAutoBids.Value = Math.Clamp(autoBids, (byte)0, (byte)12);

            // Starting Year (read from first offset)
            ushort year = ReadUInt16LE(originBase + StartYearOffsets[0]);
            numStartYear.Value = Math.Clamp((decimal)year, numStartYear.Minimum, numStartYear.Maximum);

            //Fatigue Sliders
            float jv = ReadFloatHighWordOnly(originBase + FatigueJVOffset);
            float v = ReadFloatWordSwapped(originBase + FatigueVarsityOffset);
            float aa = ReadFloatWordSwapped(originBase + FatigueAAOffset);
            float h = ReadFloatWordSwapped(originBase + FatigueHeismanOffset);

            numFatigueJV.Value = (decimal)jv;
            numFatigueVarsity.Value = (decimal)v;
            numFatigueAA.Value = (decimal)aa;
            numFatigueHeisman.Value = (decimal)h;


            //User Team Text Color
            byte r = ReadByte(originBase + UserTeamTextR_Offset);
            byte g = ReadByte(originBase + UserTeamTextG_Offset);
            byte b = ReadByte(originBase + UserTeamTextB_Offset);

            teamTextColor = System.Drawing.Color.FromArgb(r, g, b);
            pnlTeamTextColorPreview.BackColor = teamTextColor;

            lblTeamTextColorRaw.Text = $"RGB: {r},{g},{b} (R:{r:X2} G:{g:X2} B:{b:X2})";

            //Matchup Text Color
            byte r2 = ReadByte(originBase + MatchUpTextR_Offset);
            byte g2 = ReadByte(originBase + MatchUpTextG_Offset);
            byte b2 = ReadByte(originBase + MatchUpTextB_Offset);

            matchupTextColor = System.Drawing.Color.FromArgb(r2, g2, b2);
            pnlMatchUpColorPreview.BackColor = matchupTextColor;

            lblMatchUpColorRaw.Text = $"RGB: {r2},{g2},{b2} (R:{r2:X2} G:{g2:X2} B:{b2:X2})";

            //Speed Nerf Mod
            byte[] SpeedNerf1Loaded = new byte[8];
            for (int i = 0; i < SpeedNerf1Loaded.Length; i++)
            {
                SpeedNerf1Loaded[i] = ReadByte(originBase + SpeedNerfOffset1 + i);
            }

            byte[] SpeedNerf2Loaded = new byte[88];
            for (int i = 0; i < SpeedNerf2Loaded.Length; i++)
            {
                SpeedNerf2Loaded[i] = ReadByte(originBase + SpeedNerfOffset2 + i);
            }

            // Compare array contents instead of references
            if (SpeedNerf1Loaded.SequenceEqual(SpeedNerfUpdate1))
            {
                SpeedNerfBox.Checked = true;
            }
            else
            {
                SpeedNerfBox.Checked = false;
            }
        }

        //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Plays Per Game Sim
            WriteByte(originBase + PlaysPerGameOffset, (byte)numPlaysPerGame.Value);
            WriteByte(originBase + AutoBidOffset, (byte)numAutoBids.Value);

            //Save Starting Year
            ushort year = (ushort)numStartYear.Value;
            ushort yearPlus1 = (ushort)(year + 1);

            foreach (int off in StartYearOffsets)
                WriteUInt16LE(originBase + off, year);

            foreach (int off in StartYearPlus1Offsets)
                WriteUInt16LE(originBase + off, yearPlus1);

            //Save Fatigue Sliders
            WriteFloatHighWordOnly(originBase + FatigueJVOffset, (float)numFatigueJV.Value);
            WriteFloatWordSwapped(originBase + FatigueVarsityOffset, (float)numFatigueVarsity.Value);
            WriteFloatWordSwapped(originBase + FatigueAAOffset, (float)numFatigueAA.Value);
            WriteFloatWordSwapped(originBase + FatigueHeismanOffset, (float)numFatigueHeisman.Value);

            //Save User Text Color
            WriteByte(originBase + UserTeamTextR_Offset, teamTextColor.R);
            WriteByte(originBase + UserTeamTextG_Offset, teamTextColor.G);
            WriteByte(originBase + UserTeamTextB_Offset, teamTextColor.B);


            //Save MatchUp Text Color
            WriteByte(originBase + MatchUpTextR_Offset, matchupTextColor.R);
            WriteByte(originBase + MatchUpTextG_Offset, matchupTextColor.G);
            WriteByte(originBase + MatchUpTextB_Offset, matchupTextColor.B);


            //Speed Nerf Mod
            if (SpeedNerfBox.Checked)
            {
                for (int i = 0; i < SpeedNerfUpdate1.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset1 + i, SpeedNerfUpdate1[i]);
                }
                for (int i = 0; i < SpeedNerfUpdate2.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset2 + i, SpeedNerfUpdate2[i]);
                }

                int speedAmt = Convert.ToInt32(SpeedNerfAmount.Value) * 255 / 100;
                sbyte speedAmtByte = unchecked((sbyte)speedAmt);
                WriteSByte(originBase + SpeedNerfAmtOffset, speedAmtByte);
            }
            else
            {
                for (int i = 0; i < SpeedNerfRevert1.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset1 + i, SpeedNerfRevert1[i]);
                }
                for (int i = 0; i < SpeedNerfRevert2.Length; i++)
                {
                    WriteByte(originBase + SpeedNerfOffset2 + i, SpeedNerfRevert2[i]);
                }
            }


            //Clear Memory
            fs!.Flush();

            MessageBox.Show("Changes Saved.");
        }

        #region Read/Write Data

        private byte ReadByte(long offset)
        {
            fs!.Position = offset;
            return (byte)fs.ReadByte();
        }

        private void WriteByte(long offset, byte value)
        {
            fs!.Position = offset;
            fs.WriteByte(value);
            fs.Flush();
        }

        private sbyte ReadSByte(long offset)
        {
            fs!.Position = offset;
            int b = fs.ReadByte();
            if (b < 0) throw new EndOfStreamException("Unexpected EOF reading SByte.");
            return unchecked((sbyte)b);
        }

        private void WriteSByte(long offset, sbyte value)
        {
            fs!.Position = offset;
            fs.WriteByte(unchecked((byte)value));
            fs.Flush();
        }

        private ushort ReadUInt16LE(long offset)
        {
            fs!.Position = offset;
            int b0 = fs.ReadByte();
            int b1 = fs.ReadByte();
            if (b0 < 0 || b1 < 0) throw new EndOfStreamException("Unexpected EOF reading UInt16.");
            return (ushort)(b0 | (b1 << 8));
        }

        private void WriteUInt16LE(long offset, ushort value)
        {
            fs!.Position = offset;
            fs.WriteByte((byte)(value & 0xFF));        // low
            fs.WriteByte((byte)((value >> 8) & 0xFF)); // high
        }

        /// <summary>
        /// Reads a 32-bit float stored as 16-bit word-swapped: [hiWordLE][loWordLE]
        /// where float bits = (hiWord << 16) | loWord.
        /// </summary>
        private float ReadFloatWordSwapped(long offset)
        {
            ushort hi = ReadUInt16LE(offset);
            ushort lo = ReadUInt16LE(offset + 4);
            uint bits = ((uint)hi << 16) | lo;
            return BitConverter.Int32BitsToSingle((int)bits);
        }

        private void WriteFloatWordSwapped(long offset, float value)
        {
            uint bits = (uint)BitConverter.SingleToInt32Bits(value);
            ushort hi = (ushort)(bits >> 16);
            ushort lo = (ushort)(bits & 0xFFFF);

            WriteUInt16LE(offset, hi);
            WriteUInt16LE(offset + 4, lo);
        }

        /// <summary>
        /// Reads a float where only the high 16 bits are stored (JV case).
        /// low word assumed 0x0000.
        /// </summary>
        private float ReadFloatHighWordOnly(long offset)
        {
            ushort hi = ReadUInt16LE(offset);
            uint bits = ((uint)hi << 16); // lo = 0
            return BitConverter.Int32BitsToSingle((int)bits);
        }

        private void WriteFloatHighWordOnly(long offset, float value)
        {
            uint bits = (uint)BitConverter.SingleToInt32Bits(value);
            ushort hi = (ushort)(bits >> 16);
            WriteUInt16LE(offset, hi);
        }

        #endregion

        #region Color Pickers
        private void btnPickTeamTextColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                Color = teamTextColor
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            teamTextColor = dlg.Color;
            pnlTeamTextColorPreview.BackColor = teamTextColor;

            lblTeamTextColorRaw.Text =
                $"RGB: {teamTextColor.R},{teamTextColor.G},{teamTextColor.B} " +
                $"(R:{teamTextColor.R:X2} G:{teamTextColor.G:X2} B:{teamTextColor.B:X2})";
        }

        private void btnMatchUpTextColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                Color = matchupTextColor
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            matchupTextColor = dlg.Color;
            pnlMatchUpColorPreview.BackColor = matchupTextColor;

            lblTeamTextColorRaw.Text =
                $"RGB: {matchupTextColor.R},{matchupTextColor.G},{matchupTextColor.B} " +
                $"(R:{matchupTextColor.R:X2} G:{matchupTextColor.G:X2} B:{matchupTextColor.B:X2})";
        }

        #endregion

        #region Dynamic Text Boxes

        private void numPlaysPerGame_ValueChanged(object sender, EventArgs e)
        {
            double ppgVal = Convert.ToDouble(numPlaysPerGame.Value);

            int PPG = Convert.ToInt32((-1.6667 * ppgVal) + 290.67);
            PPGBox.Text = PPG.ToString();
        }

        private void SpeedNerfBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedNerfBox.Checked)
            {
                SpeedNerfAmount.Enabled = true;
                SpeedNerfAmount.ReadOnly = false;
                sbyte speedAmt = ReadSByte(originBase + SpeedNerfAmtOffset);
                double speedVal = Convert.ToDouble(speedAmt) / 255.0 * 100.0;

                // Convert signed byte (-128..127) to percentage 0..100 where mapping is application-defined.
                // If stored value is intended as -value relative to 255, normalize accordingly.
                if (speedVal == 0)
                {
                    SpeedNerfAmount.Value = -20;
                }
                else
                {
                    // Example conversion: map signed byte directly to 0..100 range when positive, otherwise set default
                    SpeedNerfAmount.Value = Math.Round((decimal)speedVal, 0);
                }
            }
            else
            {
                SpeedNerfAmount.Enabled = false;
                SpeedNerfAmount.ReadOnly = true;
            }
        }

        #endregion


    }
}