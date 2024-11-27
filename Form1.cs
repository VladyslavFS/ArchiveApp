using System;
using System.Windows.Forms;

namespace ArchiveApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            try
            {
                string source = txtSource.Text;
                string destination = txtDestination.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(destination))
                {
                    MessageBox.Show("Please specify both source and destination paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ArchiveHelper.Compress(source, destination, string.IsNullOrEmpty(password) ? null : password);
                MessageBox.Show("File compressed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                string source = txtSource.Text;
                string destination = txtDestination.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(destination))
                {
                    MessageBox.Show("Please specify both source and destination paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ArchiveHelper.Decompress(source, destination, string.IsNullOrEmpty(password) ? null : password);
                MessageBox.Show("File decompressed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Invalid password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
