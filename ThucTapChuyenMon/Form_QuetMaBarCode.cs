using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace ThucTapChuyenMon
{
    public partial class Form_QuetMaBarCode : Form
    {
        public Form_QuetMaBarCode()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice video;

     
       
        private void Form_QuetMaBarCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
            video = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            video.NewFrame += VideoCaptureDevice_NewFrame;
            video.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    video = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
        //    video.NewFrame += VideoCaptureDevice_NewFrame;
        //    video.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result!=null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = result.ToString();
                    page_banhang bh = new page_banhang();
                    bh.getID(textBox1.Text);
                    bh.Show();
                    this.Hide();
                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void Form_QuetMaBarCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(video!=null)
            {
                if (video.IsRunning)
                    video.Stop();
            }
        }

        
    }
}
