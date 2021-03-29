using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Splicer;
using Splicer.Timeline;
using Splicer.Renderer;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace CreateOneVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstPath = @"";
            string secondPath = @"";
            string endPath = @"";

            OpenFileDialog firstDialog = new OpenFileDialog();
            firstDialog.Filter = "Video files (*.avi)|*.avi";
            firstDialog.InitialDirectory = "C:\\";
            firstDialog.Title = "Select the first video you want to merge";

            if (firstDialog.ShowDialog() == DialogResult.OK)
            {
                firstPath = firstDialog.FileName;
            }

            OpenFileDialog secondDialog = new OpenFileDialog();
            secondDialog.Filter = "Video files (*.avi)|*.avi";
            secondDialog.Title = "Select the second video you want to merge";

            if (secondDialog.ShowDialog() == DialogResult.OK)
            {
                secondPath = secondDialog.FileName;
            }

            CommonOpenFileDialog pathFinal = new CommonOpenFileDialog();
            pathFinal.IsFolderPicker = true;

            if (pathFinal.ShowDialog() == CommonFileDialogResult.Ok)
            {
                endPath = pathFinal.FileName + "/videoMerged.avi";
            }




            using (ITimeline timeline = new DefaultTimeline()) {
                IGroup group = timeline.AddVideoGroup(32, 1920, 1080);

                var firstVideoClip = group.AddTrack().AddVideo(firstPath);
                var secondVideoClip = group.AddTrack().AddVideo(secondPath, firstVideoClip.Duration);

                using (AviFileRenderer renderer = new AviFileRenderer(timeline, endPath))
                {
                    renderer.Render();
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
