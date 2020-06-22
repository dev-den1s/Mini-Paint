using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//using System.Collections.Generic.List

namespace Project2_Savchenko51908
{
    public partial class FiguryGeometryczne : Form
    {
        const int dsMarginess = 20;
        Graphics dsRysownica;
        dsPunkt[] dsTGF;
        int dsindexTGF;
        int dsN;
        int dsintervalzegara = 1000;
        int dsindexfigur = 0;
        List<dsPunkt> dsLGF = new List<dsPunkt>();
        Point dsPunktStartu = Point.Empty;
        Graphics dsRyswnicaChwilowa;
        Pen dsPioroPomocnicze;
        int check;

        public FiguryGeometryczne()
        {
            InitializeComponent();
            //this.Location = new Point(Screen.PrimaryScreen.Bounds.Left, Screen.PrimaryScreen.Bounds.Top);
            this.Width = 1045;
            this.Height = 533;
            this.StartPosition = FormStartPosition.Manual;
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            //dsRysownica = this.CreateGraphics();////////////////////////////////////////
            // lokalizacja i zwymiarowanie kontrolki PictureBox ​       
            //// ustalenie koloru tła rysownicy i jej obramowania​
            dspbRysownica.BackColor = Color.Beige;
            dspbRysownica.BorderStyle = BorderStyle.Fixed3D;
            dspbRysownica.Image = new Bitmap(dspbRysownica.Width, dspbRysownica.Height);
            ////utworzenie egzemplarza powierzchni graficznej (egzemplarza  rysownicy) ​
            //// na BitMapie przypisanej do  picbRysownica.Image i podstawienie do zmiennej​
            //// referencyjnej Rysownica referencji utworzonego egzemplarza  powierzchni graficznej
            dsRysownica = Graphics.FromImage(dspbRysownica.Image);
            ////podstawienie do zmiennej referencyjnej UchwytFormularza referencji this,​
            ////  czyli referencji utworzonego egzemplarza formularza  
            //UchwytFormularza = this;
            //// domyślne ustawienie parametrów pióra linii toru​
            //dsPioroLiniiToru = new Pen(Color.Black, 2);
            //dsPioroLiniiToru.DashStyle = DashStyle.Solid;
            //// domyślne ustawienie parametrów Pióra linii osi X  oraz Y​
            //dsPioroXY = new Pen(Color.Red, 2);
            //dsPioroXY.DashStyle = DashStyle.Solid;
            //// "końcówki" osi współrzędnych​
            //dsPioroXY.StartCap = LineCap.Flat;
            //dsPioroXY.EndCap = LineCap.ArrowAnchor;
            //AdjustableArrowCap duzeGrotyStralek = new AdjustableArrowCap(3, 5);
            //dsPioroXY.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            //dsPioroXY.CustomEndCap = duzeGrotyStralek;
            dsRyswnicaChwilowa = this.dspbRysownica.CreateGraphics();
            dsPioroPomocnicze = new Pen(Color.Orange, 1);
        }
        public class dsPunkt
        {
            protected const int dsRozmiarPunktu = 20;
            protected int dsX;
            protected int dsY;
            protected int dsGrubosc;
            protected Color dsKolorTla;
            protected Color dsKolorLinii;
            protected DashStyle dsStylLinii;
            protected bool dswidocznosc;

            public dsPunkt(int x, int y)
            {
                dsX = x;
                dsY = y;
                dsGrubosc = dsRozmiarPunktu;
                dsKolorLinii = Color.Black;
                dsKolorTla = Color.White;
                dsStylLinii = DashStyle.Solid;
                dswidocznosc = false;
            }
            public dsPunkt(int x, int y, Color KolorPunktu) : this(x, y)
            {
                dsKolorTla = KolorPunktu;
                dsGrubosc = dsRozmiarPunktu;
                dsKolorLinii = Color.Black;
                dsStylLinii = DashStyle.Solid;
                dswidocznosc = false;
            }
            public dsPunkt(int x, int y, Color KolorPunktu, Color KolorLinii, DashStyle StylLinii, int RozmiarPunktu) : this(x, y, KolorPunktu)
            {
                dsGrubosc = RozmiarPunktu;
                dsKolorLinii = KolorLinii;
                dsStylLinii = StylLinii;
                dswidocznosc = false;
            }
            private void dsUaktualnijXY(int x, int y)
            {
                dsX = x;
                dsY = y;
            }
            private void dsUaktualnijXY(Point NowaLokalizacja)
            {
                dsX = NowaLokalizacja.X;
                dsY = NowaLokalizacja.Y;
            }
            protected void dsUstalStylLinii(DashStyle dsStylLinii)
            {
                this.dsStylLinii = dsStylLinii;
            }
            public void dsUstalAtrybutyGraficzne(Color KolorLinii, DashStyle dsStylLinii, int GruboscLinii, Color KolorTla)
            {
                dsKolorLinii = KolorLinii;
                this.dsStylLinii = dsStylLinii;
                dsGrubosc = GruboscLinii;
                dsKolorTla = KolorTla;
            }
            public virtual void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                SolidBrush dsPedzel = new SolidBrush(this.dsKolorTla);
                PowierzchniaGraficzna.FillEllipse(dsPedzel, this.dsX - this.dsGrubosc / 2, this.dsY - this.dsGrubosc / 2,
                    this.dsGrubosc, this.dsGrubosc);
                this.dswidocznosc = true;
                dsPedzel.Dispose();
            }
            public virtual void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.dswidocznosc == true)
                {
                    SolidBrush dsPedzel = new SolidBrush(Kontrolka.BackColor);
                    PowierzchniaGraficzna.FillEllipse(dsPedzel, this.dsX - this.dsGrubosc / 2, this.dsY - this.dsGrubosc / 2,
                        this.dsGrubosc, this.dsGrubosc);
                    this.dswidocznosc = false;
                    dsPedzel.Dispose();
                }
            }
            public virtual void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y)
            {
                this.dsX = x;
                this.dsY = y;
                dsWykresl(dsRysownica);
            }
            public virtual void dsZmieńAtrybuty(Control dspbRysownica, Graphics dsRysownica, Color KolorLinii, DashStyle dsStylLinii, int GruboscLinii, Color KolorTla)
            {
                dsKolorLinii = KolorLinii;
                this.dsStylLinii = dsStylLinii;
                dsGrubosc = GruboscLinii;
                dsKolorTla = KolorTla;
                dsWykresl(dsRysownica);
            }

        }
        public class dsLinia : dsPunkt
        {
            int dsXk;
            int dsYk;
            public dsLinia(int Xp, int Yp, int dsXk, int dsYk) : base(Xp, Yp)
            {
                this.dsXk = dsXk;
                this.dsYk = dsYk;
            }
            public dsLinia(int Xp, int Yp, int dsXk, int dsYk, Color KolorTla, Color Kolorlinii, DashStyle StylLinii, int grubosclinii) :
                base(Xp, Yp, KolorTla, Kolorlinii, StylLinii, grubosclinii)
            {
                this.dsXk = dsXk;
                this.dsYk = dsYk;
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawLine(dsPioro, this.dsX, this.dsY, this.dsXk, this.dsYk);
                    this.dswidocznosc = true;
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.dswidocznosc == true)
                {
                    using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                    {
                        dsPioro.DashStyle = this.dsStylLinii;
                        PowierzchniaGraficzna.DrawLine(dsPioro, this.dsX, this.dsY, this.dsXk, this.dsYk);
                        this.dswidocznosc = false;
                    }
                }
            }
            public override void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y)
            {
                int dy, dx;
                if (x > dsX)
                    dx = x - dsX;
                else
                    dx = dsX - x;
                if (y > dsY)
                    dy = y - dsY;
                else
                    dy = dsY - y;

                this.dsX = x;
                this.dsY = y;
                dsXk = (dsXk + dx) % dspbRysownica.Width;
                dsYk = (dsYk + dy) % dspbRysownica.Height;

                dsWykresl(dsRysownica);
            }
        }
        public class dsElips : dsPunkt
        {
            protected int dsOsDuza;
            protected int dsOsMala;
            public dsElips(int x, int y, int osduza, int osmala) : base(x, y)
            {
                this.dsOsDuza = osduza;
                this.dsOsMala = osmala;
            }
            public dsElips(int x, int y, int osduza, int osmala, Color KolorTla, Color KolorLinii, DashStyle StylLinii, int grubosclinii) :
                base(x, y, KolorTla, KolorLinii, StylLinii, grubosclinii)
            {
                this.dsOsDuza = osduza;
                this.dsOsMala = osmala;

            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsX - this.dsOsDuza / 2, this.dsY - this.dsOsMala / 2,
                                       this.dsOsDuza, this.dsOsMala);
                    this.dswidocznosc = true;
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.dswidocznosc == true)
                {
                    using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                    {
                        dsPioro.DashStyle = this.dsStylLinii;
                        PowierzchniaGraficzna.DrawEllipse(dsPioro, this.dsX - this.dsOsDuza / 2, this.dsY - this.dsOsMala / 2,
                                                              this.dsOsDuza, this.dsOsMala);
                        this.dswidocznosc = false;
                    }
                }
            }
        }

        public class dsOkrag : dsElips//zdes ja poluchaju nie radius a diametr kruga
        {
            protected int dspromien;
            public dsOkrag(int x, int y, int dspromien) : base(x, y, dspromien, dspromien)
            {
                this.dspromien = dspromien;
            }
            public dsOkrag(int x, int y, int dspromien, Color KolorTla, Color Kolorlinii, DashStyle StylLinii, int grubosclinii) :
                base(x, y, 2 * dspromien, 2 * dspromien, KolorTla, Kolorlinii, StylLinii, grubosclinii)
            {
                this.dspromien = dspromien;
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                base.dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                base.dsWymaz(Kontrolka, PowierzchniaGraficzna);
            }
        }
        public class dsProstokat : dsPunkt //tut poluchaju polovinu otrezkov
        {
            protected int dswidth;
            protected int dsheigth;
            public dsProstokat(int x, int y, int width, int heigth) : base(x, y)
            {
                this.dswidth = width;
                this.dsheigth = heigth;
            }
            public dsProstokat(int x, int y, int width, int heigth, Color KolorTla, Color KolorLinii, DashStyle Styllinii, int grubosc) :
                base(x, y, KolorTla, KolorLinii, Styllinii, grubosc)
            {
                this.dswidth = width;
                this.dsheigth = heigth;
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawRectangle(dsPioro, this.dsX - this.dsheigth, this.dsY - this.dswidth,
                        this.dswidth * 2, this.dsheigth * 2);
                    this.dswidocznosc = true;
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    PowierzchniaGraficzna.DrawRectangle(dsPioro, this.dsX - this.dsheigth, this.dsY - this.dswidth,
                        this.dswidth * 2, this.dsheigth * 2);
                    this.dswidocznosc = false;
                }
            }
        }
        public class dsKwadrat : dsProstokat
        {
            protected int dspromien;
            public dsKwadrat(int x, int y, int promien) : base(x, y, promien, promien)
            {
                this.dspromien = promien;
            }
            public dsKwadrat(int x, int y, int promien, Color KolorTla, Color KolorLinii, DashStyle Styllinii, int grubosc) :
               base(x, y, 2 * promien, 2 * promien, KolorTla, KolorLinii, Styllinii, grubosc)
            {
                this.dspromien = promien;
            }

            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                base.dsWykresl(PowierzchniaGraficzna);
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                base.dsWymaz(Kontrolka, PowierzchniaGraficzna);
            }

        }
        public class dsWielokat : dsPunkt
        {
            protected int dspromien;
            protected int dsstopien;
            protected Point[] dspoint;
            protected double dskatpolozeniapierwszegow;
            public dsWielokat(int dsstopien, int x, int y, int dspromin) : base(x, y)
            {
                this.dspromien = dspromin;
                this.dsstopien = dsstopien;
                this.dskatpolozeniapierwszegow = 0.0;
                dspoint = new Point[dsstopien + 1];
                for (int i = 0; i < dsstopien; i++)
                {
                    dspoint[i] = new Point();
                }
            }
            public dsWielokat(int dsstopien, int x, int y, int dspromin, Color KolorTla, Color KolorLinii, DashStyle Styllinii, int grubosc) :
                base(x, y, KolorTla, KolorLinii, Styllinii, grubosc)
            {
                this.dspromien = dspromin;
                this.dsstopien = dsstopien;
                this.dskatpolozeniapierwszegow = 0.0;
                dspoint = new Point[dsstopien + 1];
                for (int i = 0; i < dsstopien; i++)
                {
                    dspoint[i] = new Point();
                }
            }
            public override void dsWykresl(Graphics PowierzchniaGraficzna)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;
                    double dskatmiedzywierzcholkami = 360.0 / dsstopien;
                    for (int i = 0; i <= dsstopien; i++)
                    {
                        dspoint[i].X = (int)(this.dsX + dspromien * Math.Cos(Math.PI * (dskatpolozeniapierwszegow + i *
                            dskatmiedzywierzcholkami) / 180));
                        dspoint[i].Y = (int)(this.dsY - dspromien * Math.Sin(Math.PI * (dskatpolozeniapierwszegow + i *
                           dskatmiedzywierzcholkami) / 180));
                    }
                    for (int i = 0; i < dsstopien; i++)
                    {
                        PowierzchniaGraficzna.DrawLine(dsPioro,
                            dspoint[i].X,
                            dspoint[i].Y,
                            dspoint[i + 1].X,
                            dspoint[i + 1].Y);
                    }
                    this.dswidocznosc = true;
                }
            }
            public override void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (dswidocznosc)
                {
                    using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                    {
                        dsPioro.DashStyle = this.dsStylLinii;
                        for (int i = 0; i < dsstopien; i++)
                        {
                            PowierzchniaGraficzna.DrawLine(dsPioro,
                                dspoint[i].X,
                                dspoint[i].Y,
                                dspoint[i + 1].X,
                                dspoint[i + 1].Y);
                        }
                        this.dswidocznosc = true;
                    }
                }
            }
        }
        class dsBezjer : dsPunkt
        {        
            protected Point[] dspoint;         
            public dsBezjer( int x, int y, Point[] ds) : base(x, y)
            {        
                dspoint = new Point[4];
                for (int i = 0; i < 4; i++)
                {
                    dspoint[i] = new Point();
                }
                for (int i = 0; i < 4; i++)
                {
                    dspoint[i].X = ds[i].X;
                    dspoint[i].Y = ds[i].Y;
                }
            }
            public dsBezjer(int x, int y, Point[] ds, Color KolorTla, Color KolorLinii, DashStyle Styllinii, int grubosc) :
                base(x, y, KolorTla, KolorLinii, Styllinii, grubosc)
            {
                dspoint = new Point[4];
                for (int i = 0; i < 4; i++)
                {
                    dspoint[i] = new Point();
                }
                for (int i = 0; i < 4; i++)
                {
                    dspoint[i].X = ds[i].X;
                    dspoint[i].Y = ds[i].Y;
                }
            }
            public void dsWykresl(Graphics PowierzchniaGraficzna,Point[]dsp)
            {
                using (Pen dsPioro = new Pen(this.dsKolorLinii, this.dsGrubosc))
                {
                    dsPioro.DashStyle = this.dsStylLinii;                  
                    for (int i = 0; i < 4; i++)
                    {
                        dspoint[i].X = dsp[i].X;
                        dspoint[i].Y = dsp[i].Y;
                    }
                    PowierzchniaGraficzna.DrawBeziers(dsPioro, dsp);
                    this.dswidocznosc = true;
                }
            }
            public void dsWymaz(Control Kontrolka, Graphics PowierzchniaGraficzna, Point[] dsp)
            {
                if (dswidocznosc)
                {
                    using (Pen dsPioro = new Pen(Kontrolka.BackColor, this.dsGrubosc))
                    {
                        dsPioro.DashStyle = this.dsStylLinii;
                        for (int i = 0; i < 4; i++)
                        {
                            PowierzchniaGraficzna.DrawBeziers(dsPioro, dsp);
                        }
                        this.dswidocznosc = true;
                    }
                }
            }
            public override void dsPrzesunDoNowegoXY(Control dspbRysownica, Graphics dsRysownica, int x, int y)
            {
                this.dspoint[0].X = x;
                this.dspoint[0].Y = y;
                dsWykresl(dsRysownica,dspoint);
            }
            public override void dsZmieńAtrybuty(Control dspbRysownica, Graphics dsRysownica, Color KolorLinii, DashStyle dsStylLinii, int GruboscLinii, Color KolorTla)
            {
                base.dsZmieńAtrybuty(dspbRysownica, dsRysownica, KolorLinii, dsStylLinii, GruboscLinii, KolorTla);
            }

        }
        public bool dsPobranieDannych(out int ilosc)
        {
            ilosc = 0;
            if (dschlbFiguryGeometryczne.SelectedItems.Count <= 0)
            {
                errorProvider1.SetError(dschlbFiguryGeometryczne, "ERROR: musisz wybrać figury do wizualizacji!");
                return false;
            }
            else errorProvider1.Dispose();

            if (string.IsNullOrEmpty(dstbN.Text) || !int.TryParse(dstbN.Text, out ilosc) || ilosc < 0)
            {
                if (string.IsNullOrEmpty(dstbN.Text) || ilosc < 0)
                    errorProvider1.SetError(dstbN, "ERROR: musisz wpisać wartość większą od zera!");

                else if (!int.TryParse(dstbN.Text, out ilosc))
                    errorProvider1.SetError(dstbN, "ERROR: w zapisie podanej wartości wystąpił błąd!");

                return false;
            }
            return true;
        }

        private void dsbtnStart_Click(object sender, EventArgs e)
        {
            if (dsPobranieDannych(out dsN) == false)
                return;
            dschlbFiguryGeometryczne.Enabled = false;
            dstbN.Enabled = false;
            dsTGF = new dsPunkt[dsN];
            dsindexTGF = 0;
            CheckedListBox.CheckedItemCollection dsWybraneFigury = dschlbFiguryGeometryczne.CheckedItems;
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            Random dsLos = new Random();
            int dsX;
            int dsY;
            int dsGrubosc;
            Color dsKolorTla;
            Color dsKolorLinii;
            DashStyle dsStylLinii;
            for (int i = 0; i < dsN; i++)
            {
                dsX = dsLos.Next(dsMarginess, dsXmax - dsMarginess);
                dsY = dsLos.Next(dsMarginess, dsYmax - dsMarginess);
                dsKolorLinii = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                dsKolorTla = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                switch (dsLos.Next(1, 6))
                {
                    case 1:
                        dsStylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        dsStylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        dsStylLinii = DashStyle.Solid;
                        break;
                    case 4:
                        dsStylLinii = DashStyle.DashDot;
                        break;
                    case 5:
                        dsStylLinii = DashStyle.DashDotDot;
                        break;
                    default:
                        dsStylLinii = DashStyle.Solid;
                        break;
                }
                dsGrubosc = dsLos.Next(1, 6);
                string dsWylosowanaFigura = dsWybraneFigury[dsLos.Next(dsWybraneFigury.Count)].ToString();
                switch (dsWylosowanaFigura)
                {
                    case "Punkt":
                        dsTGF[dsindexTGF] = new dsPunkt(dsX, dsY, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Linia":
                        int dsXk = dsLos.Next(dsMarginess, dsXmax - dsMarginess);
                        int dsYk = dsLos.Next(dsMarginess, dsYmax - dsMarginess);
                        dsTGF[dsindexTGF] = new dsLinia(dsX, dsY, dsXk, dsYk, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Ellips":
                        int osduza = dsLos.Next(dsMarginess, dsXmax / 4 - dsMarginess);
                        int osmala = dsLos.Next(dsMarginess, dsYmax / 4 - dsMarginess);
                        dsTGF[dsindexTGF] = new dsElips(dsX, dsY, osduza, osmala, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Okrąg":
                        int prom = dsLos.Next(dsMarginess, dsXmax / 4 - dsMarginess);
                        dsTGF[dsindexTGF] = new dsOkrag(dsX, dsY, prom, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Prostokąt":
                        int width = dsLos.Next(dsMarginess, dsXmax / 2 - dsMarginess);
                        int heigth = dsLos.Next(dsMarginess, dsYmax / 2 - dsMarginess);
                        dsTGF[dsindexTGF] = new dsProstokat(dsX, dsY, width, heigth, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Kwadrat":
                        int pr = dsLos.Next(dsMarginess, dsXmax / 2 - dsMarginess);
                        dsTGF[dsindexTGF] = new dsKwadrat(dsX, dsY, pr, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;
                    case "Wielokąt foremny":////////////////////////////////////zdes problemy
                        int dsstop = dsLos.Next(3, 21);
                        int dsprom = dsLos.Next(1, dsYmax / 3);
                        dsTGF[dsindexTGF] = new dsWielokat(dsstop, dsX, dsY, dsprom, dsKolorTla, dsKolorLinii, dsStylLinii, dsGrubosc);
                        dsTGF[dsindexTGF].dsWykresl(dsRysownica);
                        dsindexTGF++;
                        break;


                    default:
                        errorProvider1.SetError(dsbtnStart, $"Error: {dsWylosowanaFigura} nie może być jeszcze wykreślony(a)");
                        return;
                }
            }
            dspbRysownica.Refresh();
            dsbtnStart.Enabled = false;
        }

        private void dsbtnPrzesunFigury_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsTGF.Length > 0)
                    check = dsTGF.Length;
                else
                    throw new Exception();
            }
            catch (Exception exp)
            {
                errorProvider1.SetError(dsbtnPrzesunFigury, "ERROR: Nie ma żadnych figur dla włączenia slajdera!");
                return;
            }
            errorProvider1.Dispose();
            int dsXp, dsYp;
            dsRysownica.Clear(dspbRysownica.BackColor);
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            Random dsLos = new Random();
            for (int i = 0; i < dsTGF.Length; i++)
            {
                dsXp = dsLos.Next(dsMarginess, dsXmax - dsMarginess);
                dsYp = dsLos.Next(dsMarginess, dsYmax - dsMarginess);
                dsTGF[i].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXp, dsYp);
            }
            dspbRysownica.Refresh();
        }

        private void dsbtnslajderOn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsTGF.Length > 0)
                    check = dsTGF.Length;
                else
                    throw new Exception();
            }
            catch (Exception exp){
                errorProvider1.SetError(dsbtnslajderOn, "ERROR: Nie ma żadnych figur dla włączenia slajdera!");
                return;
            }
            errorProvider1.Dispose();
            dsRysownica.Clear(dspbRysownica.BackColor);
            if (dsrbautomat.Checked)
            {
                timer1.Tag = 0;
                dstbpokazfigur.Text = "0";
                timer1.Interval = dsintervalzegara;
                timer1.Enabled = true;
            }
            else
            {
                if (string.IsNullOrEmpty(dstbpokazfigur.Text.Trim()))
                    dstbpokazfigur.Text = "0";
                else
                {
                    if (!int.TryParse(dstbpokazfigur.Text, out dsindexfigur))
                    {
                        errorProvider1.SetError(dstbpokazfigur, "ERROR: błędny zapis!");
                        return;
                    }
                    if ((dsindexfigur < 0) || (dsindexfigur >= (dsTGF.Length)))
                    {
                        errorProvider1.SetError(dstbpokazfigur, "ERROR: numer figury wykracza poza tablicę");
                        return;
                    }
                    errorProvider1.Dispose();
                }
                /////////////////
                dstbpokazfigur.ReadOnly = true;
                int dsXmax = dspbRysownica.Width;
                int dsYmax = dspbRysownica.Height;
                dsTGF[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
                ///
                dsbtnnastepny.Enabled = true;
                dsbtnpoprzedni.Enabled = true;
            }
            dspbRysownica.Refresh();
            dsbtnslajderOn.Enabled = false;
            dsbtnSlajderOff.Enabled = true;
            dsbtngbPokazfigur.Enabled = false;
            //dsbtngbPokazfigur.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dsRysownica.Clear(dspbRysownica.BackColor);
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            dstbpokazfigur.Text = timer1.Tag.ToString();
            dsTGF[(int)timer1.Tag].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
            dspbRysownica.Refresh();
            timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % dsTGF.Length;
        }

        private void dsbtnnastepny_Click(object sender, EventArgs e)
        {
            int dsindexfigury = int.Parse(dstbpokazfigur.Text);
            dsTGF[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
            if (dsindexfigur < (dsTGF.Length - 1))
                dsindexfigur++;
            else
                dsindexfigur = 0;
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            dsTGF[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
            ///
            dstbpokazfigur.Text = dsindexfigur.ToString();
            dspbRysownica.Refresh();
        }

        private void dsbtnpoprzedni_Click(object sender, EventArgs e)
        {
            int dsindexfigury = int.Parse(dstbpokazfigur.Text);
            dsTGF[dsindexfigur].dsWymaz(dspbRysownica, dsRysownica);
            if (dsindexfigur > 0)
                dsindexfigur--;
            else
                dsindexfigur = dsTGF.Length - 1;
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            dsTGF[dsindexfigur].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXmax / 2, dsYmax / 2);
            ///
            dstbpokazfigur.Text = dsindexfigur.ToString();
            dspbRysownica.Refresh();
        }

        private void dsbtnSlajderOff_Click(object sender, EventArgs e)
        {
            dsRysownica.Clear(dspbRysownica.BackColor);
            timer1.Enabled = false;
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            int dsxp, dsyp;
            Random dslos = new Random();
            for (int i = 0; i < dsTGF.Length; i++)
            {
                dsxp = dslos.Next(dsMarginess, dsXmax - dsMarginess);
                dsyp = dslos.Next(dsMarginess, dsYmax - dsMarginess);
                dsTGF[i].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsxp, dsyp);
            }
            dspbRysownica.Refresh();
            dsbtnslajderOn.Enabled = true;
            dsbtnSlajderOff.Enabled = false;
            dsbtnnastepny.Enabled = false;
            dsbtnpoprzedni.Enabled = false;
            dstbpokazfigur.ReadOnly = false;
            dsbtngbPokazfigur.Enabled = true;

        }

        private void dstbpokazfigur_TextChanged(object sender, EventArgs e)
        {
            int dsindexfigury;
            if (!int.TryParse(dstbpokazfigur.Text, out dsindexfigur))
            {
                errorProvider1.SetError(dstbpokazfigur, "ERROR: błędny zapis!");
                return;
            };
            if ((dsindexfigur < 0) || (dsindexfigur >= (dsTGF.Length)))
            {
                errorProvider1.SetError(dstbpokazfigur, "ERROR: numer figury wykracza poza tablicę");
                return;
            }
            errorProvider1.Dispose();
        }

        private void dspbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            dstbX.Text = e.Location.X.ToString();
            dstbY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                dsPunktStartu = e.Location;
            }
        }

        private void dspbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            dstbX.Text = e.Location.X.ToString();
            dstbY.Text = e.Location.Y.ToString();
            int dslewygornyx = (dsPunktStartu.X > e.Location.X) ? e.Location.X : dsPunktStartu.X;
            int dslewygornyy = (dsPunktStartu.Y > e.Location.Y) ? e.Location.Y : dsPunktStartu.Y;
            int dsszer = Math.Abs(dsPunktStartu.X - e.Location.X);
            int dswidth = Math.Abs(dsPunktStartu.Y - e.Location.Y);//wyskosc

            if (e.Button == MouseButtons.Left)
            {
                Pen dsPioro = new Pen(Color.Black, 1);
                int dspromienPunktu = 5;
                if (dsrbPunkt.Checked)
                {
                    dsRysownica.FillEllipse(Brushes.Black, e.Location.X - dspromienPunktu,
                        e.Location.Y - dspromienPunktu,
                        dspromienPunktu * 2,
                        dspromienPunktu * 2);
                    dsLGF.Add(new dsPunkt(dsPunktStartu.X, dsPunktStartu.Y, Color.Black, Color.Black, DashStyle.Solid, 10));
                }
                else if (dsrblinia.Checked)
                {
                    dsRysownica.DrawLine(dsPioro, dsPunktStartu, e.Location);
                    dsLGF.Add(new dsLinia(dsPunktStartu.X, dsPunktStartu.Y, e.Location.X, e.Location.Y, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbelips.Checked)
                {
                    dsRysownica.DrawEllipse(dsPioro, dslewygornyx, dslewygornyy, dsszer, dswidth);                           
                    dsLGF.Add(new dsElips(dslewygornyx, dslewygornyy, dsszer, dswidth, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbokrag.Checked)
                {
                    dsRysownica.DrawEllipse(dsPioro, dslewygornyx, dslewygornyy, dsszer, dsszer);
                    dsLGF.Add(new dsOkrag(dslewygornyx , dslewygornyy, dsszer/2, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbkwadrat.Checked)
                {
                    dsRysownica.DrawRectangle(dsPioro, dslewygornyx, dslewygornyy,
                       dsszer, dsszer);
                    dsLGF.Add(new dsKwadrat(dslewygornyx, dslewygornyy, dsszer/4, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbprostokat.Checked)
                {
                    dsRysownica.DrawRectangle(dsPioro, dslewygornyx, dslewygornyy,
                      dsszer, dswidth);
                    dsLGF.Add(new dsProstokat(dslewygornyx, dslewygornyy, dsszer/2, dswidth/2, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbwielokat.Checked)
                {
                    Random dsLos = new Random();                   
                    int dsstopien = dsLos.Next(3, 21);
                    double dskatmiedzywierzcholkami = 360.0 / dsstopien;
                    Point[] dspoint= new Point[dsstopien + 1];
                    for (int i = 0; i < dsstopien; i++)
                    {
                        dspoint[i] = new Point();
                    }
                    for (int i = 0; i <= dsstopien; i++)
                    {
                        dspoint[i].X = (int)(e.Location.X + dsszer * Math.Cos(Math.PI * (0.0 + i *
                            dskatmiedzywierzcholkami) / 180));
                        dspoint[i].Y = (int)(e.Location.Y - dswidth * Math.Sin(Math.PI * (0.0 + i *
                           dskatmiedzywierzcholkami) / 180));
                    }
                    for (int i = 0; i < dsstopien; i++)
                    {
                        dsRysownica.DrawLine(dsPioro,
                            dspoint[i].X,
                            dspoint[i].Y,
                            dspoint[i + 1].X,
                            dspoint[i + 1].Y);
                    }
                    dsLGF.Add(new dsWielokat(dsstopien, dslewygornyx, dslewygornyy, dsszer, Color.Black, Color.Black, DashStyle.Solid, 1));
                }
                else if (dsrbbez.Checked)//Uzytkownik Wybierz 1 punkt, a 3 zostaną wylosowanę
                {
                    Point[] dsp = new Point[4];
                    Random dsLos = new Random();
                    dsp[0].X = (int)(e.Location.X);
                    dsp[0].Y = (int)(e.Location.Y);
                    for (int i = 1; i < 4; i++)
                        {
                             dsp[i].X = dsLos.Next(dsMarginess, dspbRysownica.Width - dsMarginess);
                             dsp[i].Y = dsLos.Next(dsMarginess, dspbRysownica.Height - dsMarginess); ;
                        }
                        dsRysownica.DrawBeziers(dsPioro, dsp);
                    dsLGF.Add(new dsBezjer(dslewygornyx, dslewygornyy, dsp, Color.Black, Color.Black, DashStyle.Solid, 1));

                }
                /////////////////////////////////////////dopisat
            }
            dspbRysownica.Refresh();
        }

        private void dspbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            dstbX.Text = e.Location.X.ToString();
            dstbY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                int dslewygornyx = (dsPunktStartu.X > e.Location.X) ? e.Location.X : dsPunktStartu.X;
                int dslewygornyy = (dsPunktStartu.Y > e.Location.Y) ? e.Location.Y : dsPunktStartu.Y;
                int dsszer = Math.Abs(dsPunktStartu.X - e.Location.X);
                int dswidth = Math.Abs(dsPunktStartu.Y - e.Location.Y);
                if (dsrbPunkt.Checked) ;
                else if (dsrblinia.Checked)
                    dsRyswnicaChwilowa.DrawLine(dsPioroPomocnicze, dsPunktStartu.X, dsPunktStartu.Y, e.Location.X, e.Location.Y);
                else if (dsrbelips.Checked)
                    dsRyswnicaChwilowa.DrawEllipse(dsPioroPomocnicze, new Rectangle(dslewygornyx, dslewygornyy, dsszer, dswidth));
                else if (dsrbokrag.Checked)
                    dsRyswnicaChwilowa.DrawEllipse(dsPioroPomocnicze, new Rectangle(dslewygornyx, dslewygornyy, dsszer, dsszer));
                else if (dsrbkwadrat.Checked)
                    dsRyswnicaChwilowa.DrawRectangle(dsPioroPomocnicze, new Rectangle(dslewygornyx, dslewygornyy, dsszer, dsszer));
                else if(dsrbprostokat.Checked)
                    dsRyswnicaChwilowa.DrawRectangle(dsPioroPomocnicze, new Rectangle(dslewygornyx, dslewygornyy, dsszer, dswidth));
                else if (dsrbwielokat.Checked)                  
                {
                    Random dsLos = new Random();
                    int dsstopien = dsLos.Next(3, 21);
                    double dskatmiedzywierzcholkami = 360.0 / dsstopien;
                    Point[] dspoint = new Point[dsstopien + 1];
                    for (int i = 0; i < dsstopien; i++)
                    {
                        dspoint[i] = new Point();
                    }
                    for (int i = 0; i <= dsstopien; i++)
                    {
                        dspoint[i].X = (int)(e.Location.X + dsszer * Math.Cos(Math.PI * (0.0 + i *
                            dskatmiedzywierzcholkami) / 180));
                        dspoint[i].Y = (int)(e.Location.Y - dswidth * Math.Sin(Math.PI * (0.0 + i *
                           dskatmiedzywierzcholkami) / 180));
                    }
                    for (int i = 0; i < dsstopien; i++)
                    {
                        dsRyswnicaChwilowa.DrawLine(dsPioroPomocnicze,
                            dspoint[i].X,
                            dspoint[i].Y,
                            dspoint[i + 1].X,
                            dspoint[i + 1].Y);
                    }
                }
                else if (dsrbbez.Checked)
                {

                }

                else
                    MessageBox.Show("Pracuję nad tą figurą: under construction");

                dspbRysownica.Refresh();
            }
        }

        private void dsbtnzmienlokalizacjemysza_Click(object sender, EventArgs e)
        {
            int dsXp, dsYp;
            dsRysownica.Clear(dspbRysownica.BackColor);
            int dsXmax = dspbRysownica.Width;
            int dsYmax = dspbRysownica.Height;
            Random dsLos = new Random();
            for (int i = 0; i < dsLGF.Count; i++)
            {
                dsXp = dsLos.Next(dsMarginess, dsXmax - dsMarginess);
                dsYp = dsLos.Next(dsMarginess, dsYmax - dsMarginess);
                dsLGF[i].dsPrzesunDoNowegoXY(dspbRysownica, dsRysownica, dsXp, dsYp);
            }
            dspbRysownica.Refresh();
        }

        private void dsbtnzmienatrybuty_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsTGF.Length > 0)
                    check = dsTGF.Length;
                else
                    throw new Exception();
            }
            catch (Exception exp)
            {
                errorProvider1.SetError(dsbtnzmienatrybuty, "ERROR: Nie ma żadnych figur dla włączenia slajdera!");
                return;
            }
            errorProvider1.Dispose();
            Color dsKolorLinii, dsKolorTla;
            DashStyle dsStylLinii;
            int dsGrubosc;
            dsRysownica.Clear(dspbRysownica.BackColor);        
            Random dsLos = new Random();
            for (int i = 0; i < dsTGF.Length; i++)
            {
                dsKolorLinii = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                dsKolorTla = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                switch (dsLos.Next(1, 6))
                {
                    case 1:
                        dsStylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        dsStylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        dsStylLinii = DashStyle.Solid;
                        break;
                    case 4:
                        dsStylLinii = DashStyle.DashDot;
                        break;
                    case 5:
                        dsStylLinii = DashStyle.DashDotDot;
                        break;
                    default:
                        dsStylLinii = DashStyle.Solid;
                        break;
                }
                dsGrubosc = dsLos.Next(1, 6);
                dsTGF[i].dsZmieńAtrybuty(dspbRysownica, dsRysownica, dsKolorLinii, dsStylLinii,dsGrubosc,dsKolorTla);
            }
            dspbRysownica.Refresh();
        }

        private void dsbtnzmienatrybutymysz_Click(object sender, EventArgs e)
        {
            Color dsKolorLinii, dsKolorTla;
            DashStyle dsStylLinii;
            int dsGrubosc;
            dsRysownica.Clear(dspbRysownica.BackColor);
            Random dsLos = new Random();
            for (int i = 0; i < dsLGF.Count; i++)
            {
                dsKolorLinii = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                dsKolorTla = Color.FromArgb(dsLos.Next(0, 255), dsLos.Next(0, 255), dsLos.Next(0, 255));
                switch (dsLos.Next(1, 6))
                {
                    case 1:
                        dsStylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        dsStylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        dsStylLinii = DashStyle.Solid;
                        break;
                    case 4:
                        dsStylLinii = DashStyle.DashDot;
                        break;
                    case 5:
                        dsStylLinii = DashStyle.DashDotDot;
                        break;
                    default:
                        dsStylLinii = DashStyle.Solid;
                        break;
                }
                dsGrubosc = dsLos.Next(1, 6);
                dsLGF[i].dsZmieńAtrybuty(dspbRysownica, dsRysownica, dsKolorLinii, dsStylLinii, dsGrubosc, dsKolorTla);
            }
            dspbRysownica.Refresh();
        }

        private void dsbtnwyczysc_Click(object sender, EventArgs e)
        {
            dstbN.Enabled = true;
            dstbN.Clear();
            timer1.Dispose();
            
            dsbtnStart.Enabled = true;
            dschlbFiguryGeometryczne.Enabled = true;
          
            try
            {
                if (dsTGF.Length > 0)
                    dsTGF = new dsPunkt[0];
                else
                    throw new Exception();
            }
            catch (Exception exp)
            {
               /////
            }
            if (dsLGF.Count>0)
            {
                dsLGF.Clear();
            }
           
          
            dsRysownica.Clear(dspbRysownica.BackColor);
            dspbRysownica.Refresh();
        }

        private void dsbtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsTGF.Length > 0)
                    dsTGF = new dsPunkt[0];
                else
                    throw new Exception();
            }
            catch (Exception exp)
            {
                /////
            }
            if (dsLGF.Count > 0)
            {
                dsLGF.Clear();
            }
            dstbX.Clear();
            dstbY.Clear();

            dstbN.Enabled = true;
            dstbN.Clear();
            timer1.Dispose();
            dsbtnStart.Enabled = true;
            dschlbFiguryGeometryczne.Enabled = true;
            timer1.Enabled = false;
            dsbtnslajderOn.Enabled = true;
            dsbtnSlajderOff.Enabled = false;
            dsbtnnastepny.Enabled = false;
            dsbtnpoprzedni.Enabled = false;
            dstbpokazfigur.ReadOnly = false;
            dsbtngbPokazfigur.Enabled = true;
            for (int i = 0; i < 7; i++)
            {
                dschlbFiguryGeometryczne.SetItemChecked(i, false);
            }
            dstbpokazfigur.Clear();
            errorProvider1.Dispose();
            dsRysownica.Clear(dspbRysownica.BackColor);
            dspbRysownica.Refresh();
        }
        private void FiguryGeometryczne_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Pytanie = MessageBox.Show("Czy rzeczywiście chcesz zamknąć ten project ?",
           this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            switch (Pytanie)
            {
                case DialogResult.Yes:

                    break;
                case DialogResult.No:

                    e.Cancel = true;
                    break;
                case DialogResult.Cancel:

                    e.Cancel = true;
                    break;
            }
        }
    }
}
