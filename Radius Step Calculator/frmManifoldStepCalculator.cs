using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manifold_Step_Calculator
{
    public partial class frmManifoldStepCalculator : Form
    {
        public frmManifoldStepCalculator()
        {
            InitializeComponent();
            txtOutput.SelectionTabs = new int[] { 100 };
            chkInc.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius;
            double centerxoffset;
            double centeryoffset;
            double startangle;
            double endangle;
            double a;
            double angleinc;
            double radians;
            double x;
            double y;
            int linecount = 0;
            double lastx = 0.0;
            double lasty = 0.0;
            int d;
            string nfmt; 

            StringBuilder text = new StringBuilder();
            txtOutput.Rtf = String.Empty;
            text.Append(@"{\rtf1\ansi ");

            try
            {
                radius = Convert.ToDouble(txtRadius.Text);
                
                if (radius <= 0.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Radius must be > 0!}";
                    return;
                }

                double nh = Convert.ToDouble(txtNumHoles.Text);

                nh = Math.Round(nh);

                if (nh < 1.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi # Holes must be >= 1!}";
                    return;
                }

                angleinc = 360.0 / nh;
               
                centerxoffset = Convert.ToDouble(txtXOffset.Text);
                centeryoffset = Convert.ToDouble(txtYOffset.Text);

                startangle = Convert.ToDouble(txtStartAngle.Text);

                string tmp = txtFormat.Text;
                bool fmtGood = true;
                for (int i = 0; i < tmp.Length; i++)
                {
                    if (tmp[i] != '0' && tmp[i] != '.') fmtGood = false;
                }
                if (!fmtGood)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Decimal Place Format Error!}";
                    return;
                }
                nfmt = "{0:" + txtFormat.Text + "}";
            }
            catch { return; }

            txtOutput.Text = String.Empty;

            linecount = 0;

            endangle = startangle + 360.0;

            for (a = startangle; a <= endangle; a += angleinc)
            {
                radians = (Math.PI / 180.0) * a;

                d = CheckXYDirectionCW(a);

                x = radius * Math.Sin(radians);
                y = radius * Math.Cos(radians);

                linecount++;                if (linecount == 1) continue;

                if (chkInc.Checked == true)
                {
                    if (lastx == 0.0 && lasty == 0.0)
                        text.Append(@"\b Start X = " + String.Format(nfmt, x + centerxoffset) + @"\tab Start Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                    else
                    {
                        if (d == 0)
                            text.Append("#" + System.Convert.ToString(linecount - 1) + @"\tab\b X = " + String.Format(nfmt, x - lastx) + @"\b0\tab Y = " + String.Format(nfmt, y - lasty));
                        else
                            text.Append("#" + System.Convert.ToString(linecount - 1) + @"\tab X = " + String.Format(nfmt, x - lastx) + @"\tab\b Y = " + String.Format(nfmt, y - lasty) + @"\b0");
                    }
                }
                else
                {
                    if (d == 0)
                        text.Append("#" + System.Convert.ToString(linecount-1) + @"\tab\b X = " + String.Format(nfmt, x + centerxoffset) + @"\b0\tab Y = " + String.Format(nfmt, y + centeryoffset));
                    else
                        text.Append("#" + System.Convert.ToString(linecount-1) + @"\tab X = " + String.Format(nfmt, x + centerxoffset) + @"\tab\b Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                }

                text.Append(@"\line\line");

                lastx = x;
                lasty = y;
                
            }

            text.Append(@"}");
            txtOutput.Rtf = text.ToString();
        }

        private int CheckXYDirectionCW(double angle)
        {
            int d = 0;

            angle = Math.Abs(angle) % 360.0;

            if (angle > 0 && angle <= 90) d = 1;
            if (angle > 90 && angle <= 180) d = 0;
            if (angle > 180 && angle <= 270) d = 1;
            if (angle > 270 && angle <= 360) d = 0;

            return d;
        }
    }
}

