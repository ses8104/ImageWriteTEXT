using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ImageToWriteTEXT
{
    public partial class ImageToWriteTEXT : Form
    {
        string _ImgPath = @"C:\Users\esseo\Documents\Visual Studio 2012\Projects\MyMenu1\MyMenu1\bin\Debug\ImageForm.jpg";
        string _XmlPath = @"C:\Users\esseo\Documents\Visual Studio 2012\Projects\MyMenu1\MyMenu1\bin\Debug\ImagePoint.xml";

        public ImageToWriteTEXT()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
 
        private void MyMenu1_Load(object sender, EventArgs e)
        {
            try
            {
                imageForm1.ReadImage(_ImgPath, _XmlPath); //이미지파일, XML파일 읽어온다.
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCreateImage_Click(object sender, EventArgs e)//생성버튼
        {
            try
            {
                imageForm1.WriteImage(_ImgPath); //이미지 파일을 신규로 생성
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
