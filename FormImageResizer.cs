using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResizePicture
{
    public partial class FormImageResizer : Form
    {
        public FormImageResizer()
        {
            InitializeComponent();

            m_RadioBtnPercentage.Checked = true;
            m_RadioBtnPixels.Checked = false;

            m_CheckBoxMaintainRatio.Checked = true;

            m_TxtBoxVertical.Text = "100";
            m_TxtBoxHorizontal.Text = "100";

            m_TxtBoxSuffix.Text = "-Resized";

            m_GroupBoxQuality.Text = string.Format("JPG Quality: {0}%", m_TrackBarQuality.Value);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            m_LabelInfro.Text = "";

            if (m_TxtBoxInput.Text.Length == 0)
            {
                m_LabelInfro.Text = "Input folder is empty!";

                return;
            }

            if (m_TxtBoxOutput.Text.Length == 0)
            {
                m_LabelInfro.Text = "Output folder is empty!";

                return;
            }

            string strInput = m_TxtBoxInput.Text;
            string strOutput = m_TxtBoxOutput.Text;

            if (!Directory.Exists(strInput))
            {
                m_LabelInfro.Text = "Input folder doesn't exist!";

                return;
            }

            if (!Directory.Exists(strOutput))
            {
                m_LabelInfro.Text = "Output folder doesn't exist!";

                return;
            }

            DirectoryInfo foldernfo = new DirectoryInfo(strInput);
            int iPicutreCount = foldernfo.GetFiles().Length;
            if (iPicutreCount == 0)
            {
                m_LabelInfro.Text = "No picture found in the input folder!";

                return;
            }

            if (strInput == strOutput && m_TxtBoxSuffix.Text.Length == 0)
            {
                m_LabelInfro.Text = "Source images can not be overwirtten!";

                return;
            }

            m_ProgressBarResize.Maximum = iPicutreCount;
            m_ProgressBarResize.Value = 0;
            m_ProgressBarResize.Step = 1;

            EncoderParameters encoderParameters = new EncoderParameters();
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, new long[1] { m_TrackBarQuality.Value }); ;

            ImageCodecInfo imagecodecinfoJPG = ImageCodecInfo.GetImageEncoders().Where(ici => ici.FormatDescription.Equals("JPEG")).FirstOrDefault();

            Cursor = Cursors.WaitCursor;

            foreach (FileInfo fileinfo in foldernfo.GetFiles())
            {
                string strInputPathame = fileinfo.FullName;
                string strOutputFilename = fileinfo.Name.TrimEnd(fileinfo.Extension.ToCharArray()) + m_TxtBoxSuffix.Text + fileinfo.Extension;
                string strOutputPathname = Path.Combine(m_TxtBoxOutput.Text, strOutputFilename);

                Image image = Image.FromFile(strInputPathame);

                int iWidth = 0;
                int iHeight = 0;
                if (m_RadioBtnPercentage.Checked)
                {
                    iWidth = image.Width * int.Parse(m_TxtBoxHorizontal.Text) / 100;
                    iHeight = image.Height * int.Parse(m_TxtBoxVertical.Text) / 100;
                }
                else if (m_RadioBtnPixels.Checked)
                {
                    iWidth = int.Parse(m_TxtBoxHorizontal.Text);
                    iHeight = int.Parse(m_TxtBoxVertical.Text);
                }
                else if (m_RadioBtnHalf.Checked)
                {
                    iWidth = image.Width / 2;
                    iHeight = image.Height / 2;
                }
                else if (m_RadioBtnOneThird.Checked)
                {
                    iWidth = image.Width / 3;
                    iHeight = image.Height / 3;
                }
                else if (m_RadioBtnQuarter.Checked)
                {
                    iWidth = image.Width / 4;
                    iHeight = image.Height / 4;
                }
                else if (m_RadioBtnOneFifth.Checked)
                {
                    iWidth = image.Width / 5;
                    iHeight = image.Height / 5;
                }

                if (iWidth == 0 || iHeight == 0)
                {
                    m_LabelInfro.Text = "Image width or height should not be 0!";

                    return;
                }

                Bitmap bitmap = new Bitmap(iWidth, iHeight);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, iWidth, iHeight);
                graphics.Dispose();
 
                if (imagecodecinfoJPG != null)
                {
                    bitmap.Save(strOutputPathname, imagecodecinfoJPG, encoderParameters);
                }
                else
                {
                    bitmap.Save(strOutputPathname, image.RawFormat);
                }

                bitmap.Dispose();

                image.Dispose();

                m_ProgressBarResize.Value++;
            }

            m_LabelInfro.Text =  string.Format("Resizing {0} pictures are done.", iPicutreCount);

            Cursor = Cursors.Default;
        }

        private void BtnInputBrowse_Click(object sender, EventArgs e)
        {
            if (DlgFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                m_TxtBoxInput.Text = DlgFolderBrowser.SelectedPath;
            }
        }

        private void BtnOutputBrowse_Click(object sender, EventArgs e)
        {
            if (DlgFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                m_TxtBoxOutput.Text = DlgFolderBrowser.SelectedPath;
            }
        }

        private void TxtBoxVertical_TextChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxMaintainRatio.Checked)
            {
                m_TxtBoxHorizontal.Text = m_TxtBoxVertical.Text;
            }
        }

        private void TxtBoxHorizontal_TextChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxMaintainRatio.Checked)
            {
                m_TxtBoxVertical.Text = m_TxtBoxHorizontal.Text;
            }
        }

        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                m_LabelInfro.Text = "You can only type a number!";
            }
        }

        private void TrackBarQuality_Scroll(object sender, EventArgs e)
        {
            m_GroupBoxQuality.Text = string.Format("JPG Quality: {0}%", m_TrackBarQuality.Value);
        }
    }
}
