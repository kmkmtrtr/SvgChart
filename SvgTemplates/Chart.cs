
using System;
using System.Text;

namespace SvgReport.SvgTemplates
{
    public partial class Chart
    {
        public Chart()
        {
            this.Frame = new Frame("M 500 80 L 920 500 L 500 920 L 80 500 L 500 80", "#DDD", "2");
        }

        private Point[] points;
        public Point[] Points
        {
            get { return this.points; }
            set
            {
                this.points = value;
                var sb = new StringBuilder();
                sb.Append("M 500 100");
                for (int i = 1; i < value.Length; i++)
                {
                    var x = 500 - Math.Sin(2 * (i) * Math.PI / value.Length) * 400;
                    var y = 500 - Math.Cos(2 * (i) * Math.PI / value.Length) * 400;
                    sb.Append(" L ");
                    sb.Append(x);
                    sb.Append(" ");
                    sb.Append(y);
                }
                sb.Append(" L 500 100");
                this.Frame = new Frame(sb.ToString(), "#DDD", "2");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        private Frame Frame { get; set; }
    }

    public record Point(string Title, double Percentage);

    public record Frame(string Path, string Color, string Width);
}