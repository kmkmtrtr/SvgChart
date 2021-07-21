using System;
using System.IO;
using System.Linq;
using SvgReport.SvgTemplates;

namespace SvgReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "エネルギー", "たんぱく質", "脂質", "コレステロール", "炭水化物", "食塩相当量", "カルシウム", "鉄", "ビタミンA", "ビタミンB1", "ビタミンB2", "ナイアシン", "ビタミンC", "ビタミンD" };
            var rand = new Random();
            var chart = new Chart();
            chart.Points = Enumerable.Range(0, 13).Select((x, i) => new Point(names[i], rand.Next(30, 100))).ToArray();
            File.WriteAllText("chartSample.svg", chart.TransformText());
        }
    }
}
