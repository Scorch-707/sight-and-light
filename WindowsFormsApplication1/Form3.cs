using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class draft1 : Form
    {
        PointF mouse;
        List<PointF[,]> segment = new List<PointF[,]>();
   
        public draft1()
        {
            InitializeComponent();
            loadSegments();
            this.DoubleBuffered = true;

        }

        public void loadSegments()
        {
            PointF[,] Border = new PointF[4, 2] { 
                 { new PointF { X = 0, Y = 0 },  
                   new PointF { X = 640, Y = 0 }
                 }, 

                 { new PointF { X = 640, Y = 0 }, 
                   new PointF { X = 640, Y = 360 }
                 },
 
                 { new PointF { X = 640, Y = 360 },
                   new PointF { X = 0, Y = 360 }
                 },

                 { new PointF { X = 0, Y = 360 },
                   new PointF { X = 0, Y = 0 }
                 },
             };

            PointF[,] Poly1 = new PointF[4, 2] { 
                 { new PointF { X = 100, Y = 150 },  
                   new PointF { X = 120, Y = 50 }
                 }, 

                 { new PointF { X = 120, Y = 50 }, 
                   new PointF { X = 200, Y = 80 }
                 },
 
                 { new PointF { X = 200, Y = 80 },
                   new PointF { X = 140, Y = 210 }
                 },

                 { new PointF { X = 140, Y = 210 },
                   new PointF { X = 100, Y = 150 }
                 },
             };


            PointF[,] Poly2 = new PointF[3, 2]{
                { new PointF { X = 100, Y = 200 },
                   new PointF { X = 120, Y = 250 }
                },

                { new PointF { X = 120, Y = 250 },
                   new PointF { X = 60, Y = 300 }
                },

                { new PointF { X = 60, Y = 300 },
                   new PointF { X = 100, Y = 200 }
                },
            };

            PointF[,] Poly3 = new PointF[4, 2]{
                { new PointF { X = 200, Y = 260 },
                   new PointF { X = 220, Y = 150 }
                },

                { new PointF { X = 220, Y = 150 },
                   new PointF { X = 300, Y = 200 }
                },

                { new PointF { X = 300, Y = 200 },
                   new PointF { X = 350, Y = 320 }
                },

                { new PointF { X = 350, Y = 320 },
                   new PointF { X = 200, Y = 260 }
                },

            };

            PointF[,] Poly4 = new PointF[3, 2]{
                { new PointF { X = 340, Y = 60 },
                   new PointF { X = 360, Y = 40 }
                },

                { new PointF { X = 360, Y = 40 },
                   new PointF { X = 370, Y = 70 }
                },

                { new PointF { X = 370, Y = 70 },
                   new PointF { X = 340, Y = 60 }
                },

            };

            PointF[,] Poly5 = new PointF[4, 2]{
                { new PointF { X = 450, Y = 190 },
                   new PointF { X = 560, Y = 170 }
                },

                { new PointF { X = 560, Y = 170 },
                   new PointF { X = 540, Y = 270 }
                },

                { new PointF { X = 540, Y = 270 },
                   new PointF { X = 430, Y = 290 }
                },

                { new PointF { X = 430, Y = 290 },
                   new PointF { X = 450, Y = 190 }
                },

            };

            PointF[,] Poly6 = new PointF[3, 2]{
                { new PointF { X = 400, Y = 95 },
                   new PointF { X = 580, Y = 50 }
                },

                { new PointF { X = 580, Y = 50 },
                   new PointF { X = 480, Y = 150 }
                },

                { new PointF { X = 480, Y = 150 },
                   new PointF { X = 400, Y = 95 }
                },

            };

            segment.Add(Border);
            segment.Add(Poly1);
            segment.Add(Poly2);
            segment.Add(Poly3);
            segment.Add(Poly4);
            segment.Add(Poly5);
            segment.Add(Poly6);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            List<PointF> seg = new List<PointF>();
            Tuple<PointF, float> intersect = new Tuple<PointF, float>(new PointF(), new float());
            Tuple<PointF, float> closestIntersect = new Tuple<PointF, float>(new PointF(), new float());
            PointF[,] point;

            for (int ctr = 0; ctr < segment.Count; ctr++)
            {
                point = segment[ctr];
                for (int ctrX = 0; ctrX < point.GetLength(0); ctrX++)
                {
                    //draw segments/polygons 
                    g.DrawLine(Pens.Aqua, point[ctrX, 0], point[ctrX, 1]);
                }
            }

            PointF[] ray = new PointF[2]{
                        new PointF {X = 320, Y = 180},  
                        new PointF(mouse.X, mouse.Y), 
                };

            closestIntersect = null;
            
            closestIntersectsLbl.Text = "Closest Intersects: ";
            for (int ctr = 0; ctr < segment.Count; ctr++)
            {
                point = segment[ctr];
                for (int ctrX = 0; ctrX < point.GetLength(0); ctrX++)
                {
                    seg.Clear();
                    seg.Add(new PointF(point[ctrX, 0].X, point[ctrX, 0].Y));
                    seg.Add(new PointF(point[ctrX, 1].X, point[ctrX, 1].Y));

                    intersect = getIntersection(ray, seg.ToArray());
                    if (intersect == null) continue;

                        if (closestIntersect == null || intersect.Item2 < closestIntersect.Item2)
                        {
                            closestIntersect = intersect;
                            closestIntersectsLbl.Text += "\n" + closestIntersect;
                        }
 
                }
            }

            intersect = closestIntersect;

            SizeF size = new SizeF(5, 5);
            var solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));

            mouseLbl.Text = "Mouse = X: " + mouse.X + ", Y: " + mouse.Y; 
            RectangleF rec = new RectangleF(intersect.Item1, size);
            g.DrawLine(Pens.Black, new PointF(320, 180), intersect.Item1);

            rayLbl.Text = "Rays[0] = X:" + ray[0].X + ", Y:" + ray[0].Y+"\n";
            rayLbl.Text += "Rays[1] = X:" + ray[1].X + ", Y:" + ray[1].Y;

            intersectLbl.Text = "Intersects:\nPointX: " + intersect.Item1.X + "\nPoint Y: " + intersect.Item1.Y + "\nparam: " + intersect.Item2;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = PointToClient(MousePosition);
            this.panel1.Invalidate();
        }

        public Tuple<PointF, float> getIntersection(PointF[] ray, PointF[] segment)
        {
            Tuple<PointF, float> returnset = new Tuple<PointF, float>(new PointF(), new float());
            // RAY in parametric: PointF + Delta*T1
            var r_px = ray[0].X;
            var r_py = ray[0].Y;
            var r_dx = ray[1].X - ray[0].X;
            var r_dy = ray[1].Y - ray[0].Y;
            
          
            r_pxLbl.Text = "r_px: " + r_px;
            r_pyLbl.Text = "r_py: " + r_py;
            r_dxLbl.Text = "r_dx: " + r_dx;
            r_dyLbl.Text = "r_dy: " + r_dy;


            // SEGMENT in parametric: PointF + Delta*T2
            var s_px = segment[0].X;
            var s_py = segment[0].Y;
            var s_dx = segment[1].X - segment[0].X;
            var s_dy = segment[1].Y - segment[0].Y;

            s_pxLbl.Text = "s_px: " + s_px;
            s_pyLbl.Text = "s_py: " + s_py;
            s_dxLbl.Text = "s_dx: " + s_dx;
            s_dyLbl.Text = "s_dy: " + s_dy;
            
            
            //Are they parallel? If so, no intersect

            var r_mag = Math.Sqrt((r_dx * r_dx) + (r_dy * r_dy));
            var s_mag = Math.Sqrt((s_dx * s_dx + s_dy * s_dy));

            r_magLbl.Text = "before sqrt: " + (r_dx * r_dx) + (r_dy * r_dy) + ": r_mag: " + r_mag;
            s_magLbl.Text = "s_mag: " + s_mag;
            
            if (r_dx / r_mag == s_dx / s_mag && r_dy / r_mag == s_dy / s_mag)
            {
                return null;
            }


            var step1 = s_py - r_py;
            var step2 = r_px - s_px;
            var step3 = r_dx * step1;
            var step4 = r_dy * step2;
            var step5 = step3 + step4;
            var step6 = s_dx * r_dy;
            var step7 = s_dy * r_dx;
            var step8 = step6 - step7;
            var step9 = step5 / step8;

            var T2 = step9;
            var T1 = ((s_px + s_dx * T2 - r_px) / r_dx);

            if (T1 < 0)
            {
                return null;
            }
            if (T2 < 0 || T2 > 1)
            {
                return null;
            }

            T1Lbl.Text = "T1: " + T1;
            T2Lbl.Text = "T2: " + T2;

            var Xctr = r_px + r_dx * T1;
            var Yctr = r_py + r_dy * T1;

            XLbl.Text = "X: " + Xctr;
            YLbl.Text = "Y: " + Yctr;
            PointF a = new PointF((float)Xctr, (float)Yctr);

            //Tuple<PointF, double> returnset = new Tuple<PointF, double>(new PointF((int)Math.Ceiling(X), (int)Math.Ceiling(Y)), T1);
            returnset = new Tuple<PointF, float>(a, T1);

            return returnset;
        }
    }
}
