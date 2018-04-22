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
using NLog;
namespace Gilliland_FinalCSC373
{
    public partial class Form1 : Form
    {
        //Default to english
        private int langCode = 2;
        //Array of language codes
        private static string[] langCodes = new string[]{"af", "fr", "en-us"};
        private string filePath = "";
        private static Logger ErrorLogger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On click this function will let the user choose a picture
        /// using the file explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the file dialog on the c drive
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = @"C:\";
                //Limit the options to only image files
                dlg.Filter = "Image files (*.png;*.jpg)|*png;*.jpg|All Files (*.*)|*.*";
                dlg.ShowDialog(); //Provide the user with the specified dialog box
                string selectedFileName = dlg.FileName; //Set the future file name based on selection 
                filePath = selectedFileName; //save the selected file to the class
                pictureBoxMain.ImageLocation = selectedFileName; //Place the selected image in the main window 
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(LogLevel.Info, e); //Log exception 
                MessageBox.Show(ex.Message);
            }
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Provide choices in the drop down menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLangSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //use the static array of language codes with the provided options 
            //These can be found from the form designer properties for this object 
            //Under the data section labeled items
            langCode = comboBoxLangSelect.SelectedIndex;
        }
        /// <summary>
        /// Convert the text from the image to strings
        /// Translate those strings to the desired language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTranslate_Click(object sender, EventArgs e)
        {

            try
            {
                //Define the tools being used for detection and translation 
                string res = "";
                OCR convert = new OCR();
                Translation tr = new Translation();
                Task.Run(async () =>
                {
                    //Wait for the API to respond 
                    res = await convert.ConvertToText(filePath);
                }).Wait();
                textBoxDetected.Text = res; //Display the detected characters 
                textBoxDetected.ReadOnly = true; //lock the text box
                //Define the selected language and detected characters as a pair
                KeyValuePair<string, string> vp = new KeyValuePair<string, string>(res, langCodes[langCode]);
                Task.Run(async () =>
                {
                    //Wait for the translation 
                    res = await tr.TranslateText(vp);
                }).Wait();
                textBoxTranslated.Text = res; //Display the translated text
                textBoxTranslated.ReadOnly = true; //lock the text box
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(LogLevel.Info, e); //Log exception 
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
