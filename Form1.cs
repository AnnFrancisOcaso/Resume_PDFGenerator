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
            public string Fullname { get; set; }
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

            string Fullname = jsonfile_resume.Fullname;
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

        }
    }
}
