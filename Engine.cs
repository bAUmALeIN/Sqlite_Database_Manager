﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite_Database_Manager
{
    internal class Engine
    {
        public Engine() { 
        

        }

        public Image scaleImage(int width, int height,Image img)
        {
            Bitmap newImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(newImage)) { 
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            graphics.DrawImage(img, 0, 0, width, height);
            return newImage;
            }
        }

        public bool checkIfFormIsOpen(Form form)
        {
            FormMain.logger.WriteLine($"engine.checkIfFormIsOpen | aufruf");
            foreach (Form frm in Application.OpenForms) {
                if ( frm is FormTableInfo) {
                    FormMain.logger.WriteLine($"engine.checkIfFormIsOpen | {frm.ToString()} is type of FormTableInfo");
                    return true;
                }
            
            }
            return false;
        }

    }
}
