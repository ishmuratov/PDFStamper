using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PDFStamper
{
    public partial class Form1 : Form
    {
        string originalStampPath = string.Empty;
        StampSettings stampSettings = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (!File.Exists("settings.dat"))
                return;
            stampSettings = LoadFromFile("settings.dat");
            tbX.Text = stampSettings.LocationX.ToString();
            tbY.Text = stampSettings.LocationY.ToString();
            tbRotation.Text = stampSettings.Rotation.ToString();
            tbScale.Text = stampSettings.Scale.ToString();
            if (File.Exists(stampSettings.StampImagePath))
            {
                ResizeStampImage(stampSettings.StampImagePath);
                stampImage.ImageLocation = stampSettings.StampImagePath;
            }
            
        }

        private StampSettings LoadFromFile(string _filePath)
        {
            if (string.IsNullOrWhiteSpace(_filePath) || !File.Exists(_filePath))
            {
                return null;
            }

            try
            {
                using (var fs = new FileInfo(_filePath).Open(FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return formatter.Deserialize(fs) as StampSettings;
                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show($"Ошибка файла {_filePath} : файл повреждён. " + _ex.Message);
            }

            return null;
        }

        private void btLoadStamp_Click(object sender, EventArgs e)
        {
            originalStampPath = GetFileName("Image Files|*.jpg;*.jpeg;*.png;*.bmp");
            stampImage.ImageLocation = originalStampPath;
            SetDefaultSizeImage();
            ResizeStampImage(originalStampPath);
        }

        private string GetFileName(string _filter)
        {
            openFile.Filter = _filter;
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return string.Empty;
            string filename = openFile.FileName;
            return filename;
        }

        private void SetDefaultSizeImage()
        {
            stampImage.Width = 514;
            stampImage.Height = 194;
        }

        private void ResizeStampImage(string _path)
        {
            if (_path == string.Empty)
                return;
            Bitmap bm = new Bitmap(_path);
            if (bm.Height > stampImage.Height)
            {
                int Width = (int)(bm.Width / ((double)bm.Height / stampImage.Height));
                if (Width < stampImage.Width)
                {
                    stampImage.Width = Width;
                }
            }
        }

        private void btStamp_Click(object sender, EventArgs e)
        {
            string pdfFileName = GetFileName("(*.pdf)|*.pdf");
            if (pdfFileName == string.Empty)
                return;

            try
            {
                using (Stream inputPdfStream = new FileStream(pdfFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (Stream outputPdfStream = new FileStream(pdfFileName.Replace(".pdf", "_stamped.pdf"), FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var reader = new PdfReader(inputPdfStream);
                    var stamper = new PdfStamper(reader, outputPdfStream);
                    var pdfContentByte = stamper.GetOverContent(int.Parse(tbPage.Text));
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(stampImage.Image, System.Drawing.Imaging.ImageFormat.Png);
                    image.ScalePercent(int.Parse(tbScale.Text));
                    image.Rotation = int.Parse(tbRotation.Text);
                    image.SetAbsolutePosition(int.Parse(tbX.Text), int.Parse(tbY.Text));
                    pdfContentByte.AddImage(image);
                    stamper.Close();
                }
                System.Diagnostics.Process.Start(pdfFileName.Replace(".pdf", "_stamped.pdf"));
                SaveStampSettings("settings.dat");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОШИБКА: {ex.Message}");
            }
        }

        private void SaveStampSettings(string _filePath)
        {
            StampSettings ss = new StampSettings
            {
                LocationX = int.Parse(tbX.Text),
                LocationY = int.Parse(tbY.Text),
                Rotation = int.Parse(tbRotation.Text),
                Scale = int.Parse(tbScale.Text),
                StampImagePath = originalStampPath
            };

            try
            {
                using (var fs = new FileInfo(_filePath).Create())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fs, ss);
                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show($"Ошибка. Файл {_filePath} не может быть сохранён. " + _ex.Message);
            }

        }

        private Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        {
            Bitmap transparentImage = new Bitmap(bitmap);

            for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
            {
                for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
                {
                    var currentColor = transparentImage.GetPixel(i, j);
                    if (Math.Abs(color.R - currentColor.R) < tolerance &&
                         Math.Abs(color.G - currentColor.G) < tolerance &&
                         Math.Abs(color.B - currentColor.B) < tolerance)
                        transparentImage.SetPixel(i, j, color);
                }
            }

            transparentImage.MakeTransparent(color);
            return transparentImage;
        }

        private void cbTransparency_CheckedChanged(object sender, EventArgs e)
        {
            if (stampImage.Image == null)
                return;
            if (cbTransparency.Checked)
            {
                stampImage.Image = MakeTransparent((Bitmap)stampImage.Image, Color.White, 10);
            }
            else
                stampImage.ImageLocation = originalStampPath;
        }

        private void OnlyDigitals(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
