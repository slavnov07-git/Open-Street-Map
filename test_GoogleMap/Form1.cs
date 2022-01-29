using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Drawing;
using System.Net;
using System.Globalization;
using System.Windows.Forms;
using System.Device.Location;
using System.IO;
using System.Collections.Generic;

namespace test_GoogleMap
{
    public partial class Form1 : Form
    {
        GMapOverlay PositionsForUser = new GMapOverlay("PositionsForUser");
        List<PointLatLng> pointLatLngs = new List<PointLatLng>();
        GMapOverlay gMapOverlay = new GMapOverlay("polygons");
        List<PointLatLng> pointLatLngsOnCity = new List<PointLatLng>();
        List<PointLatLng> pointFindOnCity = new List<PointLatLng>();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnGetMap_Click(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;

            if (MyMapProviders.Text == "Google")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
            }
            if (MyMapProviders.Text == "Yandex")
            {
                gMapControl1.MapProvider = GMapProviders.YandexMap;
            }
            if (MyMapProviders.Text == "Bing")
            {
                gMapControl1.MapProvider = GMapProviders.BingMap;
            }

            gMapControl1.MarkersEnabled = true;
            double longitude = 0;
            double latitude = 0;
            if (textBox1.Text != "")
            {
                longitude = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                latitude = Convert.ToDouble(textBox2.Text);
            }
            
            gMapControl1.Position = new PointLatLng(latitude, longitude);

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 2;
            tBMyZoom.Minimum = gMapControl1.MinZoom;
            tBMyZoom.Maximum = gMapControl1.MaxZoom ;
            tBMyZoom.Value = (int)gMapControl1.Zoom;
            

            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.PolygonsEnabled = true;


        }

        private void btnGetMapOnAdress_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            

            if (MyMapProviders.Text == "Google")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
            }
            if (MyMapProviders.Text == "Yandex")
            {
                gMapControl1.MapProvider = GMapProviders.YandexMap;
            }
            if (MyMapProviders.Text == "Bing")
            {
                gMapControl1.MapProvider = GMapProviders.BingMap;
            }


            gMapControl1.MarkersEnabled = true;

            if(cbCity.Text == "Москва, Московская область")
            {                
                gMapControl1.Position = new PointLatLng(55.755814, 37.617635);                                
            }
            if (cbCity.Text == "Санкт-Петербург, Ленинградская область")
            {
                gMapControl1.Position = new PointLatLng(59.939095, 30.315868);
            }

            //GMapMarker gMapMarker = new GMapMarker(gMapControl1.Position);
            //gMapMarker.IsVisible = true;
            
            
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 10;
            gMapControl1.DragButton = MouseButtons.Left;
            
        }

        private void tBMyZoom_Scroll(object sender, EventArgs e)
        {
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 2;
            tBMyZoom.Minimum = gMapControl1.MinZoom;
            tBMyZoom.Maximum = gMapControl1.MaxZoom;
            gMapControl1.Zoom = tBMyZoom.Value;
        }

        private void GMapDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                gMapControl1.Overlays.Add(PositionsForUser);
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;

                lngTextBox.Text = lng.ToString();
                latTextBox.Text = lat.ToString();

                GMarkerGoogle gMapMarker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue_pushpin);
                PositionsForUser.Markers.Add(gMapMarker);
                pointLatLngs.Add(new PointLatLng(lat, lng));
            }
        }

        private void DeleteMarkers_Click(object sender, EventArgs e)
        {
            PositionsForUser.Markers.Clear();
            lngTextBox.Text = "";
            latTextBox.Text = "";

        }

        //private void GetMyPosition_Click(object sender, EventArgs e)
        //{
        //    bool abort = false;
        //    GeoCoordinate geoCoordinate;
        //    GeoCoordinateWatcher geoCoordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

        //    if(geoCoordinateWatcher.TryStart(false, TimeSpan.FromMilliseconds(3000)))
        //    {
                
        //        DateTime dateTime = DateTime.Now;

        //        while(geoCoordinateWatcher.Status != GeoPositionStatus.Ready && !abort)
        //        {
        //            System.Threading.Thread.Sleep(200);
        //            if(DateTime.Now.Subtract(dateTime).TotalSeconds>5)
        //            {
        //                abort = true;
        //            }
        //        }
        //        geoCoordinate = geoCoordinateWatcher.Position.Location;
        //        latTextBox.Text = geoCoordinate.Latitude.ToString();
        //        lngTextBox.Text = geoCoordinate.Longitude.ToString();

        //        gMapControl1.Position = new PointLatLng(geoCoordinate.Latitude, geoCoordinate.Longitude);
        //        gMapControl1.Zoom = 10;

        //    }
        //}

        private void GetPolygonOnMyMarkers_Click(object sender, EventArgs e)
        {
            if(pointLatLngs !=null)
            {
                GMapPolygon gMapPolygon = new GMapPolygon(pointLatLngs, "myPoligon");
                gMapPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                gMapPolygon.Stroke = new Pen(Color.Red, 1);
                gMapOverlay.Polygons.Add(gMapPolygon);
                gMapControl1.Overlays.Add(gMapOverlay);                
                gMapControl1.Zoom += 1;
                gMapControl1.Zoom -= 1;
                 
            }
        }

        private void SavePolygonOnTxtFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "polygon.txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();

            using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
            {
                foreach (var item in pointLatLngs)
                {
                    streamWriter.WriteLine($"[lng:{item.Lng.ToString()}, lat:{item.Lat.ToString()}]");
                }
            }
           
        }

        private void btnGetMapAndPolygon_Click(object sender, EventArgs e)
        {
            double pointCounts = 1;
            if(tbPointCounts.TextLength != 0)
            {
                pointCounts = double.Parse(tbPointCounts.Text);
            }
            string https = "https://nominatim.openstreetmap.org/search.php?q=" + tbCity.Text + " " + tbPlace.Text + "&format=json&polygon_geojson=1&format=xml";

            while (true)
            {
                string[] coordXY;
                string[] coordX;
                string[] coordY;

                double lot = 0;
                double lan = 0;
                string xml;
                using (var webClient = new WebClient())
                {
                    webClient.Headers.Add("User-Agent", "MyApp");
                    xml = webClient.DownloadString(https);
                }
                var xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(xml);

                if (xmlDoc.GetElementsByTagName("place")[0] != null)
                {
                    foreach (System.Xml.XmlElement el in xmlDoc.DocumentElement.SelectNodes("place"))
                    {
                        //эти берем для отображения города
                        double latitude_xml = double.Parse(el.GetAttribute("lat"), CultureInfo.InvariantCulture);
                        double longitude_xml = double.Parse(el.GetAttribute("lon"), CultureInfo.InvariantCulture);

                        pointLatLngsOnCity.Add(new PointLatLng(latitude_xml, longitude_xml));

                        //прыгаем в нужное место
                        gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
                        gMapControl1.Position = pointLatLngsOnCity[0];
                        gMapControl1.MinZoom = 2;
                        gMapControl1.MaxZoom = 20;
                        gMapControl1.Zoom = 10;
                        gMapControl1.DragButton = MouseButtons.Left;

                        //берем координаты полигона
                        string geojson = el.GetAttribute("geojson");
                        geojson = geojson.Substring(geojson.IndexOf('['));
                        geojson = geojson.Replace("],[", ",");
                        geojson = geojson.Replace("]", "");
                        geojson = geojson.Replace("[", "");
                        geojson = geojson.Replace("{", "");
                        geojson = geojson.Replace("}", "");
                        coordXY = geojson.Split(new char[] { ',' });
                        coordX = new string[(coordXY.Length / 2)];
                        coordY = new string[(coordXY.Length / 2)];

                        for (int i = 0, j = 0; i < coordXY.Length; i += 2, j++)
                        {

                            coordX[j] = coordXY[i];
                            coordY[j] = coordXY[i + 1];

                            //if(i == coordXY.Length-1)
                            //{
                            //    break;
                            //}

                        }
                        if(pointFindOnCity.Count != 0)
                        {
                            pointFindOnCity.Clear();
                        }
                        for (int i = 0; i < coordX.Length; i++)
                        {

                            if (i % pointCounts == 0)
                            {
                                
                                lan = double.Parse(coordX[i].Replace('.', ','));
                                lot = double.Parse(coordY[i].Replace('.', ','));
                                pointFindOnCity.Add(new PointLatLng(lot, lan));
                            }
                            //if(i == coordX.Length-1)
                            //{
                            //    break;
                            //}

                        }
                        if (pointFindOnCity != null)
                        {
                            break;
                        }
                    }

                }
                
                break;
            }
                        

            if (pointFindOnCity != null)
            {
                gMapControl1.Overlays.Clear();
                gMapOverlay.Polygons.Clear();
                gMapControl1.Zoom += 1;
                gMapControl1.Zoom -= 1;

                GMapPolygon gMapPolygon = new GMapPolygon(pointFindOnCity, "myPoligonOnCity");
                gMapPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
                gMapPolygon.Stroke = new Pen(Color.Blue, 1);
                gMapOverlay.Polygons.Add(gMapPolygon);
                gMapControl1.Overlays.Add(gMapOverlay);
                gMapControl1.Zoom += 1;
                gMapControl1.Zoom -= 1;

            }


        }

        private void SaveCityPolygonOnTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "polygon.txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();

            using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
            {
                foreach (var item in pointFindOnCity)
                {
                    streamWriter.WriteLine($"[lng:{item.Lng.ToString()}, lat:{item.Lat.ToString()}]");
                }
            }
        }
        /*
private void GetMapOnCityAndPlace_Click(object sender, EventArgs e)
{
string https = "https://nominatim.openstreetmap.org/search.php?q=" + tbCity.Text + "%2C" + tbPlace.Text + "&polygon_geojson=1&accept-language=tu-RU&format=xml";

while(true)
{
string xml;
using(var webClient = new WebClient())
{
  webClient.Headers.Add("User-Agent", "MyApp");
  xml = webClient.DownloadString(https);
}
var xmlDoc = new System.Xml.XmlDocument();
xmlDoc.LoadXml(xml);

if(xmlDoc.GetElementsByTagName("place")[0] != null)
{
  foreach (System.Xml.XmlElement el in xmlDoc.DocumentElement.SelectNodes("place"))
  {
      double latitude_xml = double.Parse(el.GetAttribute("lat"), CultureInfo.InvariantCulture);
      double longitude_xml = double.Parse(el.GetAttribute("lon"), CultureInfo.InvariantCulture);

      pointLatLngsOnCity.Add(new PointLatLng(latitude_xml, longitude_xml));

  }

}
else
{
  MessageBox.Show(tbPlace.Text + " были загружены");                    

}
break;
}

if(pointLatLngsOnCity.Count>0)
{
gMapControl1.MapProvider = GMapProviders.GoogleMap;
if (MyMapProviders.Text == "Google")
{
  gMapControl1.MapProvider = GMapProviders.GoogleMap;
}
if (MyMapProviders.Text == "Yandex")
{
  gMapControl1.MapProvider = GMapProviders.YandexMap;
}
if (MyMapProviders.Text == "Bing")
{
  gMapControl1.MapProvider = GMapProviders.BingMap;
}

gMapControl1.Position = pointLatLngsOnCity[0];
gMapControl1.Zoom = 10;
}

}

private void btnGetPolygonOnCityAndPlace_Click(object sender, EventArgs e)
{

GMapPolygon gMapPolygonOnCityAndPlace = new GMapPolygon(pointLatLngsOnCity, "myPoligon");

gMapPolygonOnCityAndPlace.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
gMapPolygonOnCityAndPlace.Stroke = new Pen(Color.Red, 1);
gMapOverlay.Polygons.Add(gMapPolygonOnCityAndPlace);
gMapControl1.Overlays.Add(gMapOverlay);
gMapControl1.Zoom += 1;
gMapControl1.Zoom -= 1;
}
*/
    }
        
}
