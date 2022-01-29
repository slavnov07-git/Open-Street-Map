
namespace test_GoogleMap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGetMap = new System.Windows.Forms.Button();
            this.Adress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SavePolygonOnTxtFile = new System.Windows.Forms.Button();
            this.GetPolygonOnMyMarkers = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.DeleteMarkers = new System.Windows.Forms.Button();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.lngTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyZoom = new System.Windows.Forms.Label();
            this.tBMyZoom = new System.Windows.Forms.TrackBar();
            this.MapProvider = new System.Windows.Forms.Label();
            this.MyMapProviders = new System.Windows.Forms.ComboBox();
            this.GetMapOnAdress = new System.Windows.Forms.Button();
            this.lblPlace = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.btnGetMapAndPolygon = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.SaveCityPolygonOnTxt = new System.Windows.Forms.Button();
            this.lblPointCounts = new System.Windows.Forms.Label();
            this.tbPointCounts = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBMyZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1003, 938);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GMapDoubleClick);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(74, 66);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(54, 13);
            this.lblLongitude.TabIndex = 0;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(77, 100);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(45, 13);
            this.lblLatitude.TabIndex = 1;
            this.lblLatitude.Text = "Latitude";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnGetMap
            // 
            this.btnGetMap.Location = new System.Drawing.Point(221, 149);
            this.btnGetMap.Name = "btnGetMap";
            this.btnGetMap.Size = new System.Drawing.Size(162, 23);
            this.btnGetMap.TabIndex = 4;
            this.btnGetMap.Text = "GetMapOnLongtitude/Latitude";
            this.btnGetMap.UseVisualStyleBackColor = true;
            this.btnGetMap.Click += new System.EventHandler(this.btnGetMap_Click);
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(29, 207);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(39, 13);
            this.Adress.TabIndex = 5;
            this.Adress.Text = "Adress";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbPointCounts);
            this.panel1.Controls.Add(this.lblPointCounts);
            this.panel1.Controls.Add(this.SaveCityPolygonOnTxt);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.btnGetMapAndPolygon);
            this.panel1.Controls.Add(this.tbPlace);
            this.panel1.Controls.Add(this.lblPlace);
            this.panel1.Controls.Add(this.SavePolygonOnTxtFile);
            this.panel1.Controls.Add(this.GetPolygonOnMyMarkers);
            this.panel1.Controls.Add(this.cbCity);
            this.panel1.Controls.Add(this.DeleteMarkers);
            this.panel1.Controls.Add(this.latTextBox);
            this.panel1.Controls.Add(this.lngTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MyZoom);
            this.panel1.Controls.Add(this.tBMyZoom);
            this.panel1.Controls.Add(this.MapProvider);
            this.panel1.Controls.Add(this.MyMapProviders);
            this.panel1.Controls.Add(this.GetMapOnAdress);
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.btnGetMap);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblLatitude);
            this.panel1.Controls.Add(this.lblLongitude);
            this.panel1.Location = new System.Drawing.Point(1095, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 934);
            this.panel1.TabIndex = 1;
            // 
            // SavePolygonOnTxtFile
            // 
            this.SavePolygonOnTxtFile.Location = new System.Drawing.Point(54, 450);
            this.SavePolygonOnTxtFile.Name = "SavePolygonOnTxtFile";
            this.SavePolygonOnTxtFile.Size = new System.Drawing.Size(156, 23);
            this.SavePolygonOnTxtFile.TabIndex = 21;
            this.SavePolygonOnTxtFile.Text = "SavePolygonOnTxtFile";
            this.SavePolygonOnTxtFile.UseVisualStyleBackColor = true;
            this.SavePolygonOnTxtFile.Click += new System.EventHandler(this.SavePolygonOnTxtFile_Click);
            // 
            // GetPolygonOnMyMarkers
            // 
            this.GetPolygonOnMyMarkers.Location = new System.Drawing.Point(54, 396);
            this.GetPolygonOnMyMarkers.Name = "GetPolygonOnMyMarkers";
            this.GetPolygonOnMyMarkers.Size = new System.Drawing.Size(156, 23);
            this.GetPolygonOnMyMarkers.TabIndex = 20;
            this.GetPolygonOnMyMarkers.Text = "GetPolygonOnMyMarkers";
            this.GetPolygonOnMyMarkers.UseVisualStyleBackColor = true;
            this.GetPolygonOnMyMarkers.Click += new System.EventHandler(this.GetPolygonOnMyMarkers_Click);
            // 
            // cbCity
            // 
            this.cbCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Google",
            "Yandex",
            "Bing"});
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Москва, Московская область",
            "Санкт-Петербург, Ленинградская область"});
            this.cbCity.Location = new System.Drawing.Point(80, 204);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(303, 21);
            this.cbCity.TabIndex = 19;
            // 
            // DeleteMarkers
            // 
            this.DeleteMarkers.Location = new System.Drawing.Point(300, 326);
            this.DeleteMarkers.Name = "DeleteMarkers";
            this.DeleteMarkers.Size = new System.Drawing.Size(83, 46);
            this.DeleteMarkers.TabIndex = 17;
            this.DeleteMarkers.Text = "DeleteMarkers";
            this.DeleteMarkers.UseVisualStyleBackColor = true;
            this.DeleteMarkers.Click += new System.EventHandler(this.DeleteMarkers_Click);
            // 
            // latTextBox
            // 
            this.latTextBox.Location = new System.Drawing.Point(97, 352);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(197, 20);
            this.latTextBox.TabIndex = 16;
            // 
            // lngTextBox
            // 
            this.lngTextBox.Location = new System.Drawing.Point(97, 326);
            this.lngTextBox.Name = "lngTextBox";
            this.lngTextBox.Size = new System.Drawing.Size(197, 20);
            this.lngTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "lat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "lng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CoordinateFromMouseDoubleClick";
            // 
            // MyZoom
            // 
            this.MyZoom.AutoSize = true;
            this.MyZoom.Location = new System.Drawing.Point(349, 396);
            this.MyZoom.Name = "MyZoom";
            this.MyZoom.Size = new System.Drawing.Size(34, 13);
            this.MyZoom.TabIndex = 11;
            this.MyZoom.Text = "Zoom";
            // 
            // tBMyZoom
            // 
            this.tBMyZoom.AllowDrop = true;
            this.tBMyZoom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tBMyZoom.Location = new System.Drawing.Point(349, 412);
            this.tBMyZoom.Maximum = 200;
            this.tBMyZoom.Minimum = 5;
            this.tBMyZoom.Name = "tBMyZoom";
            this.tBMyZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBMyZoom.Size = new System.Drawing.Size(45, 324);
            this.tBMyZoom.SmallChange = 5;
            this.tBMyZoom.TabIndex = 10;
            this.tBMyZoom.TickFrequency = 20;
            this.tBMyZoom.Value = 5;
            this.tBMyZoom.Scroll += new System.EventHandler(this.tBMyZoom_Scroll);
            // 
            // MapProvider
            // 
            this.MapProvider.AutoSize = true;
            this.MapProvider.Location = new System.Drawing.Point(45, 18);
            this.MapProvider.Name = "MapProvider";
            this.MapProvider.Size = new System.Drawing.Size(135, 13);
            this.MapProvider.TabIndex = 9;
            this.MapProvider.Text = "MapProvider(default=OSM)";
            // 
            // MyMapProviders
            // 
            this.MyMapProviders.AutoCompleteCustomSource.AddRange(new string[] {
            "Google",
            "Yandex",
            "Bing"});
            this.MyMapProviders.FormattingEnabled = true;
            this.MyMapProviders.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Bing"});
            this.MyMapProviders.Location = new System.Drawing.Point(186, 15);
            this.MyMapProviders.Name = "MyMapProviders";
            this.MyMapProviders.Size = new System.Drawing.Size(197, 21);
            this.MyMapProviders.TabIndex = 8;
            // 
            // GetMapOnAdress
            // 
            this.GetMapOnAdress.Location = new System.Drawing.Point(221, 245);
            this.GetMapOnAdress.Name = "GetMapOnAdress";
            this.GetMapOnAdress.Size = new System.Drawing.Size(162, 23);
            this.GetMapOnAdress.TabIndex = 7;
            this.GetMapOnAdress.Text = "GetMapOnAdress";
            this.GetMapOnAdress.UseVisualStyleBackColor = true;
            this.GetMapOnAdress.Click += new System.EventHandler(this.btnGetMapOnAdress_Click);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(51, 523);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 23;
            this.lblPlace.Text = "Place";
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(97, 520);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(197, 20);
            this.tbPlace.TabIndex = 24;
            // 
            // btnGetMapAndPolygon
            // 
            this.btnGetMapAndPolygon.Location = new System.Drawing.Point(54, 576);
            this.btnGetMapAndPolygon.Name = "btnGetMapAndPolygon";
            this.btnGetMapAndPolygon.Size = new System.Drawing.Size(156, 23);
            this.btnGetMapAndPolygon.TabIndex = 25;
            this.btnGetMapAndPolygon.Text = "GetMapAndPolygon";
            this.btnGetMapAndPolygon.UseVisualStyleBackColor = true;
            this.btnGetMapAndPolygon.Click += new System.EventHandler(this.btnGetMapAndPolygon_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(51, 497);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(97, 490);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(197, 20);
            this.tbCity.TabIndex = 27;
            // 
            // SaveCityPolygonOnTxt
            // 
            this.SaveCityPolygonOnTxt.Location = new System.Drawing.Point(54, 622);
            this.SaveCityPolygonOnTxt.Name = "SaveCityPolygonOnTxt";
            this.SaveCityPolygonOnTxt.Size = new System.Drawing.Size(156, 23);
            this.SaveCityPolygonOnTxt.TabIndex = 28;
            this.SaveCityPolygonOnTxt.Text = "SaveCityPolygonOnTxt";
            this.SaveCityPolygonOnTxt.UseVisualStyleBackColor = true;
            this.SaveCityPolygonOnTxt.Click += new System.EventHandler(this.SaveCityPolygonOnTxt_Click);
            // 
            // lblPointCounts
            // 
            this.lblPointCounts.AutoSize = true;
            this.lblPointCounts.Location = new System.Drawing.Point(51, 551);
            this.lblPointCounts.Name = "lblPointCounts";
            this.lblPointCounts.Size = new System.Drawing.Size(64, 13);
            this.lblPointCounts.TabIndex = 29;
            this.lblPointCounts.Text = "PointCounts";
            // 
            // tbPointCounts
            // 
            this.tbPointCounts.Location = new System.Drawing.Point(123, 548);
            this.tbPointCounts.Name = "tbPointCounts";
            this.tbPointCounts.Size = new System.Drawing.Size(171, 20);
            this.tbPointCounts.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 962);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBMyZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGetMap;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetMapOnAdress;
        private System.Windows.Forms.ComboBox MyMapProviders;
        private System.Windows.Forms.Label MapProvider;
        private System.Windows.Forms.Label MyZoom;
        private System.Windows.Forms.TrackBar tBMyZoom;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox lngTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteMarkers;
       // private System.Windows.Forms.Button GetMyPosition;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button GetPolygonOnMyMarkers;
        private System.Windows.Forms.Button SavePolygonOnTxtFile;
        private System.Windows.Forms.Button btnGetMapAndPolygon;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button SaveCityPolygonOnTxt;
        private System.Windows.Forms.TextBox tbPointCounts;
        private System.Windows.Forms.Label lblPointCounts;
        //private System.Windows.Forms.TextBox tbCity;
        //private System.Windows.Forms.Label lblCity;
        // private System.Windows.Forms.Button GetMapOnCityAndPlace;
        //private System.Windows.Forms.TextBox tbPlace;
        //private System.Windows.Forms.Label lblPlace;
        // private System.Windows.Forms.Button btnGetPolygonOnCityAndPlace;
    }
}

