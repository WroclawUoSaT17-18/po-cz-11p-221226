using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace graphics
{
    public partial class Form1 : Form
    {
        Image File;
            
            bool wybieranie = false;
            bool rysuj = false;
            Color maluj_kolor;
         int x, y, lx, ly=0;

         
            Bitmap copy; // tu będzie zapisana kopia
           
           

            Item wybranyItem; // wybrana funkcja z listy Item

        public Form1()
        {
         InitializeComponent();
         Bitmap imgbmp = new Bitmap(PB.Width, PB.Height);
         Graphics graphics = Graphics.FromImage(imgbmp);
    

         PB.Image = imgbmp;


        }
        public enum Item
        { prostokat, elipsa, linia, tekst, pedzel,  gumka, pipeta}

        private void Form1_Load(object sender, EventArgs e)
        {
          
            copy = new Bitmap(PB.Width, PB.Height);

            FontFamily[] czcionki = FontFamily.Families; //wybór czcionek
            foreach (FontFamily font in czcionki)
            {
                toolStripComboBox1.Items.Add(font.GetName(1).ToString());
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }


        private void paleta(object sender, MouseEventArgs e)
        {

        }

        private void paleta_Down(object sender, MouseEventArgs e)
        {
            wybieranie = true;

        }

        private void paleta_Move(object sender, MouseEventArgs e)
        {
            if (wybieranie == true)
            {//zbiera kolor z palety
                Bitmap bmp = (Bitmap)paleta_kolorow.Image.Clone();

                if (e.X > 0 & e.Y > 0 & e.X < paleta_kolorow.Width & e.Y < paleta_kolorow.Height)
                {
                    maluj_kolor = bmp.GetPixel(e.X, e.Y);
                }
                else { wybieranie = false; }

                wybrany_kolor.BackColor = maluj_kolor;
            }
        }

        private void paleta_Up(object sender, MouseEventArgs e)
        {
            wybieranie = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            wybranyItem = Item.prostokat;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.elipsa;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.linia;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.pedzel;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.gumka;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.tekst;
        }



        /*
         Na Mouse_Down                     tworzy się kopia istniejącego obrazu (Bitmap copy)
        
         Na Mouse_Move                     przerysowuje się: imgbmp = copy + narysowana figura 
                                           
                                           oraz PB.Image (przestrzeń robocza programu) = imgbmp
                             
          */
        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            rysuj = false;
            lx = e.X; // położenie kursora przy puszczeniu
            ly = e.Y;
       
           

          
              
            
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            Bitmap imgbmp = copy.Clone() as Bitmap;
            if (rysuj == true)//myszka kliknięta
            {
                
                
               switch (wybranyItem)
                { 
                    
                    case Item.prostokat:
                   {
                       Graphics p = Graphics.FromImage(imgbmp);
                       PB.Image = imgbmp;
                     p.DrawLine(new Pen(new SolidBrush(maluj_kolor)), new Point(x, y), new Point(x, e.Y));
                     p.DrawLine(new Pen(new SolidBrush(maluj_kolor)), new Point(x, y), new Point(e.X, y));
                      p.DrawLine(new Pen(new SolidBrush(maluj_kolor)), new Point(e.X, e.Y), new Point(x, e.Y));
                      p.DrawLine(new Pen(new SolidBrush(maluj_kolor)), new Point(e.X, e.Y), new Point(e.X, y));      
                     p.Dispose();     
                  }
                    break;

                    case Item.elipsa:

                    Graphics el = Graphics.FromImage(imgbmp);
                    PB.Image = imgbmp;
                el.DrawEllipse(new Pen(new SolidBrush(maluj_kolor)), x, y, e.X - x, e.Y - y);
                el.Dispose();
                        


                         break;

                 case Item.pedzel:
                         if (toolStripTextBox1.Text != String.Empty)
                         {
                        Graphics   pd= Graphics.FromImage(PB.Image);

                        
                             pd.FillEllipse(new SolidBrush(maluj_kolor), e.X - x + x, e.Y - y + y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                            copy= PB.Image.Clone() as Bitmap ;
                           
                             pd.Dispose();

                         Graphics   g = PB.CreateGraphics(); 
                             g.FillEllipse(new SolidBrush(maluj_kolor), e.X - x + x, e.Y - y + y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                           
                             g.Dispose();
                   

                         }
                           break;

                    case Item.gumka: 
                           if (toolStripTextBox1.Text != String.Empty)
                           {
                               Graphics gm = Graphics.FromImage(PB.Image);

                               gm.FillRectangle(new SolidBrush(Color.White), e.X - x + x, e.Y - y + y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                               copy = PB.Image.Clone() as Bitmap;

                               gm.Dispose();

                               Graphics g = PB.CreateGraphics();
                               g.FillRectangle(new SolidBrush(Color.White), e.X - x + x, e.Y - y + y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                         
                              g.Dispose();
                           }
                           else
                           {
                               Graphics gm = Graphics.FromImage(PB.Image);

                               gm.FillRectangle(new SolidBrush(Color.White), e.X - x + x, e.Y - y + y,30,30);
                               copy = PB.Image.Clone() as Bitmap;
                               gm.Dispose();

                               Graphics g = PB.CreateGraphics();
                               g.FillRectangle(new SolidBrush(Color.White), e.X - x + x, e.Y - y + y,30,30);
                               g.Dispose();
                           }
                           break;
                    case Item.linia:
                           Graphics ln = Graphics.FromImage(imgbmp);

                  ln.DrawLine(new Pen(new SolidBrush(maluj_kolor)), new Point(x, y), new Point(e.X, e.Y));
                      ln.Dispose();
                      PB.Image = imgbmp;
                break;
                }
                
            }
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            rysuj = true;
            x = e.X; //położenie kursora przy klikaniu
            y = e.Y;
            copy = PB.Image.Clone() as Bitmap;
           
           
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            wybranyItem = Item.pipeta;
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
           ;
            
            if (wybranyItem == Item.pipeta) //nie da się pobrać koloru bezpośrednio, dlatego trzeba zrobić screena
            {                               // robi zrzut ekranu (prostokątna bitmapa będąca kopią przestrzeni rysowania)
                Bitmap bmp = new Bitmap(PB.Width, PB.Height);
                Graphics g = Graphics.FromImage(bmp);
                Rectangle rect = PB.RectangleToScreen(PB.ClientRectangle); 
                g.CopyFromScreen(rect.Location, Point.Empty, PB.Size);
                g.Dispose();

                maluj_kolor = bmp.GetPixel(e.X, e.Y);
                wybrany_kolor.BackColor = maluj_kolor;
            }
            if (wybranyItem == Item.tekst)
            {
                Bitmap imgbmp = copy.Clone() as Bitmap;

                Graphics tk = Graphics.FromImage(imgbmp);

                int xx = e.X;
                int yy = e.Y;


                tk.DrawString(textBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripTextBox1.Text), FontStyle.Regular), new SolidBrush(maluj_kolor), new PointF(e.X - Convert.ToInt32(toolStripTextBox1.Text), e.Y - Convert.ToInt32(toolStripTextBox1.Text)));
              tk.Dispose();
              PB.Image = imgbmp;
        
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                PB.Image = File;

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
           
            
            Bitmap bmp = new Bitmap(PB.Width, PB.Height );
            bmp = PB.Image.Clone() as Bitmap;
              bmp.Save("C:\\Users\\Piotr Wawrocki\\Desktop\\obrazki\\obraz.png");
            }


        }
    }
