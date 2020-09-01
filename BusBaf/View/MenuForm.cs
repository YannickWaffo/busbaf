using BusBaf.Model;
using MapWinGIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf.View
{
    public partial class MenuForm : Form
    {
        public Admin administrateur = null;
        int providerid;
        TileProviders providers;
        Shapefile _shape;
        int _idshape;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void gcarte_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.BingMaps;
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            GeoProjection proj = new GeoProjection();
            proj.ImportFromEPSG(3857);

            _shape = new Shapefile();
            _shape.Open(@"E:\POSTE DE TRAVAIL\PROJETS PARTAGES\PROJET DE STAGE\USA_P\usa.shp");

            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            PointIco(@"E:\POSTE DE TRAVAIL\PROJETS PARTAGES\PROJET DE STAGE\ICON");

        }

        private void PointIco(string icopath)
        {
            int index = _shape.Table.FieldIndexByName["cat"];
            var names = new HashSet<string>();
            for (int i=0; i<_shape.Table.NumRows; i++)
            {
                names.Add(_shape.Table.CellValue[index, i].ToString());
            }

            string[] files = Directory.GetFiles(icopath);
            foreach (string file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                if (Path.GetExtension(file).ToLower() == ".png" && names.Contains(name))
                {
                    MapWinGIS.Image img = new MapWinGIS.Image();
                    if(img.Open(file, ImageType.USE_FILE_EXTENSION, true, null))
                    {
                        ShapefileCategory ct = new ShapefileCategory();
                        ct = _shape.Categories.Add(name);

                        ct.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;

                        ct.DrawingOptions.PictureScaleX = 0.8;
                        ct.DrawingOptions.PictureScaleY = 0.8;

                        ct.DrawingOptions.DrawingMode = tkVectorDrawingMode.vdmGDIPlus;

                        _shape.CollisionMode = tkCollisionMode.AllowCollisions;
                        ct.Expression = " [cat]=" + name;
                        ct.DrawingOptions.Picture = img;

                        _shape.DefaultDrawingOptions = ct.DrawingOptions;

                        
                    }
                }

                _shape.Categories.ApplyExpressions();
            }
        }
    }
}
