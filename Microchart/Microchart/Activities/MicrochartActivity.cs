using System.Collections.Generic;

using Android.App;
using Android.OS;
using Microcharts;
using Microcharts.Droid;
using SkiaSharp;

namespace Microchart.Activities
{
    [Activity(Label = "MicrochartActivity", MainLauncher = true)]
    public class MicrochartActivity : Activity
    {
        // Sample data
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1943"),
                Label ="January",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("00BFFF"),
                Label = "March",
                ValueLabel = "400"
            },
            new Entry(-100)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "Octobar",
                ValueLabel = "-100"
            },
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.microchart);

            var chartView = FindViewById<ChartView>(Resource.Id.chartView);
            var chartview2 = FindViewById<ChartView>(Resource.Id.Chart2);
            var chartview3 = FindViewById<ChartView>(Resource.Id.Chart3);
            var chartview4 = FindViewById<ChartView>(Resource.Id.Chart4);
            var chartview5 = FindViewById<ChartView>(Resource.Id.Chart5);
            var chartview6 = FindViewById<ChartView>(Resource.Id.Chart6);

            var chart = new RadialGaugeChart() { Entries = entries };
            var chart2 = new LineChart() { Entries = entries };
            var chart3 = new DonutChart() { Entries = entries };
            var chart4 = new PointChart() { Entries = entries };
            var chart5 = new RadarChart() { Entries = entries };
            var chart6 = new BarChart() { Entries = entries };

            chartView.Chart = chart;
            chartview2.Chart = chart2;
            chartview4.Chart = chart3;
            chartview3.Chart = chart4;
            chartview5.Chart = chart5;
            chartview6.Chart = chart6;
        }
    }
}