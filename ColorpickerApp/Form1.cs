using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ColorpickerApp
{
    public partial class Colorpicker : Form
    {
        public Colorpicker()
        {
            InitializeComponent();
        }

        private void PaletteImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.BMP;*.JPG;*.PNG";
            fileDialog.Title = "Palette Image";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PaletteImageBox.ImageLocation = fileDialog.FileName;
            }
        }

        private void InputImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.BMP;*.JPG;*.PNG";
            fileDialog.Title = "Input Image";
            //fileDialog.Multiselect

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                InputImageBox.ImageLocation = fileDialog.FileName;
            }
        }

        private async void generate_btn_Click(object sender, EventArgs e)
        {
            Image paletteImage = new Image();
            Image inputImage = new Image();
            Image outputImage = new Image();

            try
            {
                paletteImage.SetFilePath(PaletteImageBox.ImageLocation.ToString(), true);
                inputImage.SetFilePath(InputImageBox.ImageLocation.ToString(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an image for the palette and input.", "Colorpicker", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG File|*.PNG";
            saveFileDialog.DefaultExt = "PNG";
            saveFileDialog.Title = "Output Image";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            outputImage.SetFilePath(saveFileDialog.FileName, false);
            OutputPicture.ImageLocation = saveFileDialog.FileName;

            HashSet<Color> palette = new HashSet<Color>();


            Bitmap img = paletteImage.bitmapImage;


            outputImage.imageTable = new Color[inputImage.GetImage().Width, inputImage.GetImage().Height];
            outputImage.SetImage(new Bitmap(inputImage.GetImage().Width, inputImage.GetImage().Height));

            progressLabel.Text = "Starting";
            progressLabel.Refresh();
            paletteImage.GenerateHashSet("Generating color palette");
            progressLabel.Text = "Color palette generated";
            progressLabel.Refresh();
            inputImage.GenerateHashSet("Generating input image palette");
            progressLabel.Text = "Input palette generated";
            progressLabel.Refresh();

            if (paletteImage.palette.Count > inputImage.palette.Count)
            {
                outputImage.ReplaceImage(paletteImage.palette, inputImage.palette, inputImage.GetImage());
                progressLabel.Text = "Image generated";
                progressLabel.Refresh();
            }
            else
            {
                for (int i = 0; i < inputImage.GetImage().Height; i++)
                {
                    for (int j = 0; j < inputImage.GetImage().Width; j++)
                    {
                        Color pixel = inputImage.GetImage().GetPixel(j, i);
                        outputImage.imageTable[j, i] = ClosestMatch(paletteImage.GetHashSet(), pixel);
                    }
                    ReplaceLine($"Replacing pixels", i, inputImage.GetImage().Height);
                }
                ReplaceLine($"Replacing pixels", 1, 1);
                Console.WriteLine();


                for (int i = 0; i < inputImage.GetImage().Height; i++)
                {
                    for (int j = 0; j < inputImage.GetImage().Width; j++)
                    {
                        outputImage.bitmapImage.SetPixel(j, i, outputImage.imageTable[j, i]);
                    }
                    ReplaceLine($"Generating image", i, inputImage.GetImage().Height);
                }
                ReplaceLine($"Generating image", 1, 1);
                Console.WriteLine();
            }

            outputImage.ExportImage();
            progressLabel.Text = $"Saved image as {OutputPicture.ImageLocation}!";
        }

        int FindColorDistance(Color color1, Color color2)
        {
            return Math.Abs(color1.R - color2.R) +
                Math.Abs(color1.G - color2.G) +
                Math.Abs(color1.B - color2.B);
        }

        Color ClosestMatch(HashSet<Color> colorSet, Color color)
        {
            Color[] colorPalette = colorSet.ToArray();
            Color closestMatch = colorPalette[0];
            int smallestDifference = 100000;

            for (int i = 0; i < colorPalette.Length; i++)
            {
                Color toTest = colorPalette[i];
                int difference = FindColorDistance(toTest, color);
                if (smallestDifference > difference)
                {
                    smallestDifference = difference;
                    closestMatch = toTest;
                }

            }
            return closestMatch;
        }

        void ReplaceLine(string message, int done, int total)
        {
            progressLabel.Text = message + $" ({100 * done / total}%)";
            progressLabel.Refresh();
        }

        private void swap_btn_Click(object sender, EventArgs e)
        {
            string buffer = InputImageBox.ImageLocation;
            InputImageBox.ImageLocation = PaletteImageBox.ImageLocation;
            PaletteImageBox.ImageLocation = buffer;
        }
    }
}