using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using ZedGraph;

using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace GroundStationGoliathX
{
    public partial class Form1 : Form
    {
        // DENEME_V.1.1.8
        // Serial Comm.
        string Data = string.Empty;
        string[] ports = SerialPort.GetPortNames();

        //Temel başlangıç kordinatları
        //  1
        GraphPane myPane1 = new GraphPane();
        // Grafikte kaç adet Y noktası göstereceğini belirtir 
        RollingPointPairList listPointsOne = new RollingPointPairList(30);
        LineItem myCurveOne;
        //  2 
        GraphPane myPane2 = new GraphPane();
        RollingPointPairList listPointsTwo = new RollingPointPairList(30);
        LineItem myCurveTwo;
        // Z ekseni YAW  , Y ekseni PITCH  , X ekseni ROLL
        double x = 0, y = 0, z = 0;


        public Form1()
        {
            InitializeComponent();

        }
        /*
         * 1. GlControl renk ayarı
         * 2. Timer zaman aralığı
         * 3. Gmap ek özellikleri
         * 4. ZedGraph grafik işleşleri
         * 5. Bağlanmış portları ekleme
         * 6. BaudRate'lerin ayarlanması
         * 
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.DarkGray);//Color.FromArgb(143, 212, 150)
            timer1.Interval = 1000;

            //Gmap harita tanımlama
            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;

            //  Grafik ekleme ve isim değiştirme kısmı  ++ 
            myPane1 = zedGraphControl1.GraphPane;
            myPane2 = zedGraphControl2.GraphPane;

            myPane1.XAxis.Title.Text = "Saniye";
            myPane1.YAxis.Title.Text = "";
            myPane1.Title.Text = "Yükselik";

            myPane2.XAxis.Title.Text = "Saniye";
            myPane2.YAxis.Title.Text = "";
            myPane2.Title.Text = "Basınç";

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

            zedGraphControl2.Invalidate();
            zedGraphControl2.AxisChange();
            zedGraphControl2.Refresh();

            // Grafik Arkaplan rengi ayarı
            myPane1.Chart.Fill.Brush = new SolidBrush(Color.White);
            myPane2.Chart.Fill.Brush = new SolidBrush(Color.White);
            // Butonlarının Başlangıç durumları
            button1.Enabled = false;
            button2.Enabled = false;
            /* bağlanmış portları ekleme */
            foreach (string port in ports)
            {
                cbComPort.Items.Add(port);
                cbComPort.SelectedIndex = 0;

            }
            /* Baudrate'ler */
            cbBaud.Items.Add("2400");
            cbBaud.Items.Add("4800");
            cbBaud.Items.Add("9600");
            cbBaud.Items.Add("19200");
            cbBaud.Items.Add("38400");
            cbBaud.Items.Add("57600");
            cbBaud.Items.Add("115200");
            cbBaud.SelectedIndex = 2;

        }
        private void btnBaglan_Click(object sender, EventArgs e)
        {
   
            if (SeriPort.IsOpen == false)
            {



                try
                {
                    SeriPort.PortName = cbComPort.Text;
                    SeriPort.BaudRate = Convert.ToInt32(cbBaud.Text);
                    SeriPort.Open();
                    btnBaglan.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;

                }
                catch (Exception er)
                {
                    MessageBox.Show("Error:" + er.Message);
                }
            }
            else
            {
                rtbEkran.Text = "seriport already open \n";



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             try
             {

                Data = SeriPort.ReadLine();
                string[] data = Data.Split('#');
                label15.Text = Data;

                // Zaman ayarları Saniye cinsinden
                //********************
                int gorevZamanı = Convert.ToInt32(label10.Text);
                gorevZamanı++;
                label10.Text = gorevZamanı.ToString();

                //rtb ekran verileri burdan yazdırılıyor
                //********************************************************************************************************
                rtbEkran.Text += "Metre:" + data[0] + " Basınç:" + data[1] +"Torr" +" Hız:"+data[7]+"m/s"+" Devir:"+data[8]+" RPM"+" Güç:"+data[9]+"\n";
                
                //********************************************************************************************************

                //********************
                if (data[2].Length == 9 && data[3].Length == 9)
                {

                    char[] charArray = data[2].ToCharArray();
                    char[] charaArray2 = data[3].ToCharArray();
                    charArray[2] = ',';
                    charaArray2[2] = ',';

                    string latitude = new string(charArray);
                    string longitude = new string(charaArray2);

                    //              Gmap kontrol ayarları
                    //****************************************************************************************************
                    double Y;
                    double X;
  


                    X = Convert.ToDouble(latitude);
                    Y = Convert.ToDouble(longitude);
                    gmap.Overlays.Clear();
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(X, Y), GMarkerGoogleType.red_dot);
                    markers.Markers.Add(marker);
                    gmap.Overlays.Add(markers);
                    gmap.Position = new GMap.NET.PointLatLng(X, Y);
                    gmap.MinZoom = 1;
                    gmap.MaxZoom = 20;
                    gmap.Zoom = 8;

                }
                    //      ZED GRAPHS
                    //****************************************************************************************************
                    myPane1 = zedGraphControl1.GraphPane;
                    // 1
                    double xAxis1 = Convert.ToDouble(label10.Text);
                    double yAxis2 = double.Parse(data[0], System.Globalization.CultureInfo.InvariantCulture);
                    listPointsOne.Add(xAxis1, yAxis2);
                    myCurveOne = myPane1.AddCurve(null, listPointsOne, Color.DarkBlue, SymbolType.XCross);
                    // 2
                    myPane2 = zedGraphControl2.GraphPane;
                    double Y_axis_2 = double.Parse(data[1], System.Globalization.CultureInfo.InvariantCulture);
                    listPointsTwo.Add(xAxis1, Y_axis_2);
                    myCurveTwo = myPane2.AddCurve(null, listPointsTwo, Color.Red, SymbolType.XCross);
                    // Grafiği yenilemek için bu alan kullanılır ...
                    zedGraphControl1.Invalidate();
                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();

                    zedGraphControl2.Invalidate();
                    zedGraphControl2.AxisChange();
                    zedGraphControl2.Refresh();
                    //****************************************************************************************************

                    //                  GL Control Pitch,Rool,Yaw
                    //****************************************************************************************************

                    x = Convert.ToDouble(data[4]);
                    y = Convert.ToDouble(data[5]);
                    z = Convert.ToDouble(data[6]);
                    glControl1.Invalidate();

                     //***************************************************************************************************

                //                  Circular Progres Bar ayarlamaları
                //****************************************************************************************************
                guna2CircleProgressBar1.Value = Convert.ToInt32(data[7]);
                label4.Text = "%" + data[7];
                guna2CircleProgressBar2.Value = Convert.ToInt32(data[8]);
                label5.Text = "%" + data[8];
                guna2CircleProgressBar3.Value = Convert.ToInt32(data[9]);
                label11.Text = "%" + data[9];
                //****************************************************************************************************

            }

            catch (Exception X)
            {
                MessageBox.Show("Error:" + X.Message);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SeriPort.Close();
            if (SeriPort.IsOpen == true)
            {
                SeriPort.Close();
                timer1.Enabled = false;
                label17.Text = " 0 ";
                label8.Text = " 0 ";

            }
        }
        // GL kontrol şekil kordinat perspektif ve bakış hizası ayarları
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            float var1 = 1.0f;
            float var2 = var1;
            float radius = 4.5f;
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(40, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            GL.Rotate(x, 1.0, 0.0, 0.0);
            GL.Rotate(z, 0.0, 1.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);


            // gövde
            Silindir(var1, var2, radius, 2f, -0.9f);

            //pervane başlığı
            Silindir(0.01f, var2, 0.5f, 6, 5.1f);


            //üst koni
            Koni(0.01f, 0.01f, radius, 3.5f, 2f, 4.5f);
            Koni(0.01f, 0.01f, 3.5f, 2f, 4.5f, 5.2f);

            //alt koni
            Koni(0.01f, 0.01f, radius, 2.0f, -0.9f, -2.5f);
            Koni(0.01f, 0.01f, 3, 2.0f, -2.9f, -2.5f);
            Koni(0.01f, 0.01f, 3, 3.0f, -2.9f, -3.2f);

            //uzun çubuk
            //Silindir(0.01f, topla, 0.1f, 5,5);
            Pervane(-1.0f, 11.0f, 0.25f, 0.39f);

            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.FromArgb(250, 0, 0));
            GL.Vertex3(-50.0, 0.0, 0.0);
            GL.Vertex3(50.0, 0.0, 0.0);


            GL.Color3(Color.Black);
            GL.Vertex3(0.0, 50.0, 0.0);
            GL.Vertex3(0.0, -50.0, 0.0);

            GL.Color3(Color.FromArgb(0, 0, 250));
            GL.Vertex3(0.0, 0.0, 50.0);
            GL.Vertex3(0.0, 0.0, -50.0);

            GL.End();
            //GraphicsContext.CurrentContext.VSync = true;
            glControl1.SwapBuffers();
        }
        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);//sonradan yazdık
        }
        private void Silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads);
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(1, 1, 1));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(1, 1, 1));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            while (step <= 180)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(1, 1, 1));

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void Koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 90)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 135)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 180)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 225)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 270)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 315)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 360)
                    GL.Color3(1.0, 0.0, 0.0);


                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(1, 1, 1));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(1, 1, 1));


                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void Pervane(float yukseklik, float uzunluk, float kalinlik, float egiklik)
        {
            GL.Begin(BeginMode.Quads);


            GL.Color3(Color.Red);
            GL.Vertex3(15, yukseklik, 6.625);
            GL.Vertex3(15, yukseklik + egiklik, 6.875);
            GL.Vertex3(8, yukseklik + egiklik, 6.875);
            GL.Vertex3(8, yukseklik, 6.625);

            GL.Color3(Color.Red);
            GL.Vertex3(15, yukseklik, -6.625);
            GL.Vertex3(15, yukseklik + egiklik, -6.875);
            GL.Vertex3(8, yukseklik + egiklik, -6.875);
            GL.Vertex3(8, yukseklik, -6.625);

            GL.Color3(Color.Red);
            GL.Vertex3(-15, yukseklik + egiklik, 6.625);
            GL.Vertex3(-15, yukseklik, 6.875);
            GL.Vertex3(-8, yukseklik, 6.875);
            GL.Vertex3(-8, yukseklik + egiklik, 6.625);

            GL.Color3(Color.Red);
            GL.Vertex3(-15, yukseklik + egiklik, -6.625);
            GL.Vertex3(-15, yukseklik, -6.875);
            GL.Vertex3(-8, yukseklik, -6.875);
            GL.Vertex3(-8, yukseklik + egiklik, -6.625);

            //

            GL.Color3(Color.Gray);
            GL.Vertex3(12, yukseklik, 3.5);
            GL.Vertex3(11.75, yukseklik + egiklik, 3.5);
            GL.Vertex3(11.75, yukseklik + egiklik, 10);//+
            GL.Vertex3(12, yukseklik, 10);//-

            GL.Color3(Color.Gray);
            GL.Vertex3(12, yukseklik, -3.5);
            GL.Vertex3(11.75, yukseklik + egiklik, -3.5);
            GL.Vertex3(11.75, yukseklik + egiklik, -10);//+
            GL.Vertex3(12, yukseklik, -10);//-

            GL.Color3(Color.Gray);
            GL.Vertex3(-12, yukseklik + egiklik, 3.5);
            GL.Vertex3(-11.75, yukseklik, 3.5);
            GL.Vertex3(-11.75, yukseklik, 10);
            GL.Vertex3(-12, yukseklik + egiklik, 10);

            GL.Color3(Color.Gray);
            GL.Vertex3(-12, yukseklik + egiklik, -3.5);
            GL.Vertex3(-11.75, yukseklik, -3.5);
            GL.Vertex3(-11.75, yukseklik, -10);
            GL.Vertex3(-12, yukseklik + egiklik, -10);

            GL.End();

            // kollar
            GL.Begin(BeginMode.Quads);

            GL.Color3(Color.Black);
            GL.Vertex3(1, yukseklik, 0);
            GL.Vertex3(11.75f, yukseklik + .6f, -6.625);
            GL.Vertex3(11.25f, yukseklik, -6.625);
            GL.Vertex3(0, yukseklik + .25f, 0);

            GL.Color3(Color.Black);
            GL.Vertex3(-1, yukseklik, 0);
            GL.Vertex3(-11.75f, yukseklik + .6f, -6.625);
            GL.Vertex3(-11.25f, yukseklik, -6.625);
            GL.Vertex3(0, yukseklik + .25f, 0);

            GL.Color3(Color.Black);
            GL.Vertex3(-1, yukseklik, 0);
            GL.Vertex3(-11.75f, yukseklik + 0.6f, 6.625);
            GL.Vertex3(-11.25f, yukseklik, 6.625);
            GL.Vertex3(0, yukseklik + .25f, 0);

            GL.Color3(Color.Black);
            GL.Vertex3(1, yukseklik, 0);
            GL.Vertex3(11.75f, yukseklik + .6f, 6.625);
            GL.Vertex3(11.25f, yukseklik, 6.625);
            GL.Vertex3(0, yukseklik + .25f, 0);

            GL.End();

            //



        }
    }
}
