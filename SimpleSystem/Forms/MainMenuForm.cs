﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace SimpleSystem.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly int ReservationCount = new Reservation().GetAllReservation();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.ShowAllReservation.Text = ReservationCount.ToString();

            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo filterInfo in filterInfoCollection)
            //{
            //    comboBox1.Items.Add(filterInfo.Name);
            //}

            //comboBox1.SelectedIndex = 0;
            //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start();

        }

        //private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    pictureBox1.Image = (Bitmap) eventArgs.Frame.Clone();
        //}

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }
    }
}
