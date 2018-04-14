using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerVisionAPI;
using TranslatorTextAPI;

namespace Gilliland_FinalCSC373
{
    public partial class Form1 : Form
    {
        private int langCode = 2;
        private string[] langCodes = new string[]{"af", "fr", "en-us"};
        private string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\";
            dlg.Filter = "Image files (*.png;*.jpg)|*png;*.jpg|All Files (*.*)|*.*";
            dlg.ShowDialog();
            string selectedFileName = dlg.FileName; //Set the future file name based on selection 
            filePath = selectedFileName;
            pictureBoxMain.ImageLocation = selectedFileName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLangSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            langCode = comboBoxLangSelect.SelectedIndex;
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("You have commited a grevious error");
            }
            else
            {

                string res = "";
                OCR convert = new OCR();
                Translation tr = new Translation();
                Task.Run(async () =>
                {
                    //Wait for the API to respond 
                    res = await convert.ConvertToText(filePath);
                }).Wait();
                textBoxDetected.Text = res;
                textBoxDetected.ReadOnly = true;
                KeyValuePair<string, string> vp = new KeyValuePair<string, string>(res, langCodes[langCode]);
                Task.Run(async () =>
                {
                    res = await tr.TranslateText(vp);
                }).Wait();
                textBoxTranslated.Text = res;
                textBoxTranslated.ReadOnly = true;
            }
        }
    }
}
