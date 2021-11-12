using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;


namespace skia_sharp
{
    public partial class MainPage : ContentPage
    {
        float xcoordA, ycoordA, radiusA;
        float vxA, vyA;
        float xcoordB, ycoordB, radiusB;
        float vxB, vyB;
        float xcoordC, ycoordC, radiusC;
        float vxC, vyC;
        float xcoordD, ycoordD, radiusD;
        float vxD, vyD;

        public MainPage()
        {
            InitializeComponent();

            xcoordA = 100; ycoordA = 100; radiusA = 20;
            vxA = 10f; vyA = 7f;
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                canvasView.InvalidateSurface();
                return true;

            });

            xcoordB = 50; ycoordB = 50; radiusB = 50;
            vxB = 20f; vyB = 2f;
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                canvasView.InvalidateSurface();
                return true;
            });

            xcoordC = 20; ycoordC = 25; radiusC = 10;
            vxC = 2f; vyC = 20f;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                canvasView.InvalidateSurface();
                return true;
            });

            xcoordD = 100; ycoordD = 100; radiusD = 30;
            vxD = -10f; vyD = 7f;
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                canvasView.InvalidateSurface();
                return true;

            });
        }

        private void CanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.Black);
            SKSize size = canvasView.CanvasSize;

            SKPaint a = new SKPaint();
            a.Color = SKColors.Red;
            canvas.DrawCircle(xcoordA, ycoordA, radiusA, a);
            xcoordA += vxA;
            ycoordA += vyA;
            if ((xcoordA > size.Width - radiusA) || (xcoordA < 0)) vxA = -vxA;
            if ((ycoordA > size.Height - radiusA) || (ycoordA < radiusA)) vyA = -vyA;

            SKPaint b = new SKPaint();
            b.Color = SKColors.IndianRed;
            canvas.DrawCircle(xcoordB, ycoordB, radiusB, b);
            xcoordB += vxB;
            ycoordB += vyB;
            if ((xcoordB > size.Width - radiusB) || (xcoordB < 0)) vxB = -vxB;
            if ((ycoordB > size.Height - radiusB) || (ycoordB < radiusB)) vyB = -vyB;

            SKPaint c = new SKPaint();
            c.Color = SKColors.Blue;
            canvas.DrawCircle(xcoordC, ycoordC, radiusC, c);
            xcoordC += vxC;
            ycoordC += vyC;
            if ((xcoordC > size.Width - radiusC) || (xcoordC < 0)) vxC = -vxC;
            if ((ycoordC > size.Height - radiusC) || (ycoordC < radiusC)) vyC = -vyC;

            SKPaint d = new SKPaint();
            d.Color = SKColors.AliceBlue;
            canvas.DrawCircle(xcoordD, ycoordD, radiusD, d);
            xcoordD += vxD;
            ycoordD += vyD;
            if ((xcoordD > size.Width - radiusD) || (xcoordD < 0)) vxD = -vxD;
            if ((ycoordD > size.Height - radiusD) || (ycoordD < radiusD)) vyD = -vyD;
        }
        

        
    }
}
