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

namespace pejnt
{   
    public partial class Form1 : Form
    {
        bool rysowanie = false;
        bool kwadrat = false;
        bool prostokat = false;
        int? oX = null;
        int? oY = null;
        bool kolo = false;
        bool tekst = false;

        Point pkt1 = new Point();
        Graphics g;

        
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
            pkt1 = new Point(e.X, e.Y);

            rysowanie = true;

            if (textBox_szer.Text.Length > 0)
            {

                if (textBox_wys.Text.Length > 0)


                    if (kwadrat)
                    {
                        SolidBrush q = new SolidBrush(bKolor.ForeColor);
                        g.FillRectangle(q, e.X, e.Y, Convert.ToInt32(textBox_szer.Text), Convert.ToInt32(textBox_szer.Text));
                        rysowanie = false;
                        kwadrat = false;
                    }

                if (prostokat)
                {
                    SolidBrush q = new SolidBrush(bKolor.ForeColor);
                    g.FillRectangle(q, e.X, e.Y, Convert.ToInt32(textBox_szer.Text), Convert.ToInt32(textBox_wys.Text));
                    rysowanie = false;
                    prostokat = false;
                }

                if (kolo)
                {
                    SolidBrush q = new SolidBrush(bKolor.ForeColor);
                    g.FillEllipse(q, e.X, e.Y, Convert.ToInt32(textBox_szer.Text), Convert.ToInt32(textBox_szer.Text));
                    rysowanie = false;
                    kolo = false;
                }
            }

                if (tekst)
                {
                    FontDialog czcionka = new FontDialog();
                    if (czcionka.ShowDialog() == DialogResult.OK)
                    {
                        textBox2.Font = czcionka.Font;
                    }
                    StringFormat xd = new StringFormat();
                    xd.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    SolidBrush s = new SolidBrush(bKolor.ForeColor); ;
                    g.DrawString(textBox2.Text, czcionka.Font, s, pkt1, xd);
                    rysowanie = false;
                    tekst = false;
                }

                
            
           
        } 
        
          


        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            rysowanie = false;
            
            oX = null;
            oY = null;    
        }

       

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
            
            if (rysowanie)
            {       
                    Pen p = new Pen(bKolor.ForeColor, Convert.ToInt32(dGrubosc.Text));
                    g.DrawLine(p, new Point(oX ?? e.X, oY ?? e.Y), new Point(e.X, e.Y));
                    oX = e.X;
                    oY = e.Y;
            }
          
        }

            
        

        private void bKolor_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            if (kolor.ShowDialog() == DialogResult.OK)
            {
                bKolor.ForeColor = kolor.Color;

            }
        }

        private void bWyczysc_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            bKolor.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            if (kolor.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = kolor.Color;
                button1.ForeColor = kolor.Color;
            }
        }

        private void bKolo_Click(object sender, EventArgs e)
        {
            kolo = true;
        }

        private void bProst_Click(object sender, EventArgs e)
        {
            prostokat = true;

        }

        private void bKwadart_Click(object sender, EventArgs e)
        {
            kwadrat = true; 
        }

        private void bTekst_Click(object sender, EventArgs e)
        { 
            tekst = true;
        }

        private void bGumka_Click(object sender, EventArgs e)
        {
            bKolor.ForeColor = Color.White;
        }
    }
}
