using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;



namespace JSON_RESUME_TO_PDF
{
    public partial class pdfgenerator : Form
    {
        private readonly string Resumefilepath = @"C:\Users\Phenyang\source\repos\JSON RESUME TO PDF\Resumefile.Json";
        public pdfgenerator()
        {
            InitializeComponent();
        }

        public class Resumefile
        {
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Phone { get; set;}
            public string Address { get; set; }
            public string About { get; set; }
            public string About2 { get; set; }
            public string About3 { get; set; }
            public string JuniorHighSchool { get; set; }
            public string YearGraduated1 { get; set; }
            public string SeniorHighSchool { get; set; }
            public string YearGraduated2 { get; set; }
            public string TertiaryLevel { get; set; }
            public string YearGraduated3 { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
        }

        private void pdfgenerator_Load(object sender, EventArgs e)
        {
            string Jsonfile;
            using (var reader = new StreamReader(Resumefilepath))
            {
                Jsonfile = reader.ReadToEnd();
            }
            var jsonfile_resume = JsonConvert.DeserializeObject <Resumefile>(Jsonfile);

            string Firstname = jsonfile_resume.Firstname;
            string Middlename = jsonfile_resume.Middlename;
            string Surname = jsonfile_resume.Surname;
            string Email = jsonfile_resume.Email;
            string Phone = jsonfile_resume.Phone;
            string Address = jsonfile_resume.Address;

            string About = jsonfile_resume.About;
            string About2 = jsonfile_resume.About2;
            string About3 = jsonfile_resume.About3;

            string JuniorHighSchool = jsonfile_resume.JuniorHighSchool;
            string YearGraduated1 = jsonfile_resume.YearGraduated1;
            string SeniorHighShool = jsonfile_resume.SeniorHighSchool;
            string YearGraduated2 = jsonfile_resume.YearGraduated2;
            string TertiaryLevel = jsonfile_resume.TertiaryLevel;
            string YearGraduated3 = jsonfile_resume.YearGraduated3;

            string Skill1 = jsonfile_resume.Skill1;
            string Skill2 = jsonfile_resume.Skill2;
            string Skill3 = jsonfile_resume.Skill3;
         
          using (SaveFileDialog Savefile = new SaveFileDialog())
            {
                Savefile.InitialDirectory = @"C:\Users\Phenyang\source\repos\JSON RESUME TO PDF";
                Savefile.FileName = Surname + "_" + Firstname + ".pdf";
                Savefile.Filter = "PDF|*.pdf";
                if (Savefile.ShowDialog()== DialogResult.OK)
                {
                    PdfDocument savepdf = new PdfDocument();
                    savepdf.Info.Title = Surname + "_" + Firstname + "Resume";
                    PdfPage page = savepdf.AddPage();

                    XGraphics xgraphics = XGraphics.FromPdfPage(page);
                    //Font size
                    XFont largeFont = new XFont(" ", 18, XFontStyle.Regular);
                    XFont largeFont1 = new XFont(" ", 18, XFontStyle.Bold);
                    XFont mediumFont = new XFont(" ", 16, XFontStyle.Regular);
                    XFont mediumFont1 = new XFont(" ", 16, XFontStyle.Bold);
                    XFont smallFont = new XFont(" ", 12, XFontStyle.Regular);
                    XFont smallFont1 = new XFont(" ", 12, XFontStyle.Bold);

                    //Margin
                    int leftmargin = 25;
                    int leftinitial = 200;
                    int middleinitial = 200;


                    //FullName
                    xgraphics.DrawString(Firstname + " " + Middlename + " " + Surname, largeFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial -120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    //Contacts
                    xgraphics.DrawString("Contact Info", mediumFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 10, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Email, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Phone, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Address, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial +60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //Education History
                    xgraphics.DrawString("Education History", largeFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Tertiary Level", mediumFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 125, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(TertiaryLevel, smallFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial +145, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(YearGraduated3, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Senior High School", mediumFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 180, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(SeniorHighShool, smallFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 200, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(YearGraduated2, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 215, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Junior High School", largeFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 235, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(JuniorHighSchool, smallFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 255, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(YearGraduated1, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 270, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //About
                    xgraphics.DrawString("About", largeFont1, XBrushes.Black, new XRect(leftmargin + 25, middleinitial - 80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(About, smallFont, XBrushes.Black, new XRect(leftmargin + 25, middleinitial -55, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(About2, smallFont, XBrushes.Black, new XRect(leftmargin + 25, middleinitial - 40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(About3, smallFont, XBrushes.Black, new XRect(leftmargin + 25, middleinitial - 25, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //Skills
                    xgraphics.DrawString("Skills", mediumFont1, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 310, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Skill1, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 330, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Skill2, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 345, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Skill3, smallFont, XBrushes.Black, new XRect(leftmargin + 25, leftinitial + 360, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    

                    savepdf.Save(Savefile.FileName);
                    MessageBox.Show("Thank you for using PDF Generator with JSON file!");
                    this.Close();
                }
            }
        }
    }
}
