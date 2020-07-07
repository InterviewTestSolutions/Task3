using FileReader.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            var fileReaderBuilder = FileReaderBuilder.UseFilePath(filePathTextBox.Text);

            try
            {
                fileContentsTextBox.Text = fileReaderBuilder.ReadFile();
            }
            catch (ArgumentNullException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (ArgumentException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fileContentsTextBox.Text = string.Empty;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
