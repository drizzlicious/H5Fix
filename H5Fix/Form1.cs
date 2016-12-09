using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Binarysharp.MemoryManagement;
using System.Diagnostics;
using Binarysharp.MemoryManagement.Helpers;

namespace H5Fix
{
    public partial class Form1: Form
    {

        static IntPtr fovAddress = new IntPtr(0x5934A90);
        static IntPtr fpsAddress = new IntPtr(0x349E970);
        public Form1()
        {
            
            InitializeComponent();
            readCurrentValues();
        }

        private void readCurrentValues()
        {
            using (var sharp = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {
                fovBox.Text = Convert.ToString(sharp[fovAddress].Read<float>());
                FPSBox.Text = Convert.ToString(1000000/sharp[fpsAddress].Read<long>());
            }
        }

        private void setFov_Click(object sender, EventArgs e)
        {
            using (var sharp = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {

                float fov;
                try
                {
                    fov = (float)Convert.ToDouble(fovBox.Text);
                }
                catch (SystemException ex)
                {
                    // this class's error string
                    MessageBox.Show("Invalid FOV value");
                    return;
                }
                
                bool fovValid = float.TryParse(fovBox.Text.ToString(), out fov);

                if (fovValid)
                {
                    
                    sharp[fovAddress].Write<float>(fov);
                }
                else
                {
                    
                }
            }
        }

        private void setFPS_Click(object sender, EventArgs e)
        {
            using (var sharp = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {

                long fps;
                try
                {
                    fps = (long)Convert.ToInt32(FPSBox.Text);
                }
                catch (SystemException ex)
                {
                    // this class's error string
                    MessageBox.Show("Invalid FPS value");
                    return;
                }

                bool fpsValid = long.TryParse(FPSBox.Text.ToString(), out fps);

                if (fpsValid)
                {
                  
                    sharp[fpsAddress].Write<long>(1000000/fps);
                }
                else
                {

                }
            }
        }
    }
}
