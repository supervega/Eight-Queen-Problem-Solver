using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EightQueen
{
    public partial class Form1 : Form
    {
        public static bool[,] bored = new bool[22, 9];
        Graphics g;
        Pen p = new Pen(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }
        public void Print()
        {
            g = panel1.CreateGraphics();
            g.Clear(Color.White);
            int DrawRow = panel1.Size.Height / 8;
            int DrawCol = panel1.Size.Width / 8;
            for (int i = 0; i <= panel1.Size.Height; i += DrawRow)
            {
                g.DrawLine(p, 0, i, panel1.Size.Width, i);
            }
            for (int j = 0; j <= panel1.Size.Width; j += DrawCol)
            {
                g.DrawLine(p, j, 0, j, panel1.Size.Height);
            }
            int DrawC = 0, DrawR = 0;
            int QueensCounter = 1;
            for (int k = 7; k <= 14;k++)
            {
                for (int s = 1; s <= 8;s++) 
                {
                    if (bored[k, s])
                    {
                       DrawC += DrawCol;                        
                    }
                    else
                    {
                        Pen p1=new Pen(Color.Red);
                        g.FillRectangle(p1.Brush, DrawC, DrawR, DrawRow, DrawRow);
                        g.DrawString(QueensCounter.ToString(), new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold), p.Brush, DrawC + DrawCol / 2 - 8, DrawR + DrawRow / 2 - 8);
                        DrawC += DrawCol;
                        QueensCounter++;
                    }
                }
                DrawC = 0;
                DrawR += DrawRow;
            }
        }

        public bool Try(int Row)
        {
            int Col;
            bool b=false;
            for (Col= 7; Col <= 14; Col++)
            {
                if (Safe(Col, Row))
                {
                    bored[Col, Row] = false;
                    if (Row < 8)
                    {
                        b = Try(Row + 1);
                        if (!b)
                            bored[Col, Row] = true;
                    }
                    else
                    {
                        b = true;
                        Print();
                    }
                }
                if (b) break;
            }
            return b;
        }

        public bool Safe(int Col, int Row)
        {
            bool f = true;
            for (int i = 1; i <= Row-1; i++)
            {
                f = f && bored[Col, i];
                f = f && bored[Col + Row - i, i];
                f = f && bored[Col - Row + i, i];
            }
            return f;
        }

        private void Solvebtn_Click(object sender, EventArgs e)
        {
            for (int i = -6;i  <= 15; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    bored[i + 6, j] = true;
                }
            }
            Try(1);
        }
    }
}
