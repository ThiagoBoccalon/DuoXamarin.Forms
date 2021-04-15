using CoreAnimation;
using CoreGraphics;
using System;
using UIKit;

namespace AppDuoXF.iOS.Controls
{
    public class CircularProgressBariOS : UIView
    {
        private CAShapeLayer progressLyr = new CAShapeLayer();
        private CAShapeLayer trackLyr = new CAShapeLayer();

        public CircularProgressBariOS(double width, double height)
        {
            MakeCircularPath(width, height);
        }

        private void MakeCircularPath(double width, double height)
        {
            BackgroundColor = UIColor.Clear;
            Layer.CornerRadius = (nfloat)(width / 2);

            var circlePath = new UIBezierPath();
            circlePath.AddArc(
                center: new CGPoint(x: width / 2, y: height / 2),
                radius: (nfloat)((width - 1.5) / 2),
                startAngle: (nfloat)(-0.5 * Math.PI),
                endAngle: (nfloat)(1.5 * Math.PI),
                clockWise: true
            );

            trackLyr.Path = circlePath.CGPath;
            trackLyr.FillColor = UIColor.Clear.CGColor;
            trackLyr.StrokeColor = UIColor.Blue.CGColor;
            trackLyr.LineWidth = (nfloat)5.0;
            trackLyr.StrokeEnd = (nfloat)1.0;
            Layer.AddSublayer(trackLyr);

            progressLyr.Path = circlePath.CGPath;
            progressLyr.FillColor = UIColor.Clear.CGColor;
            progressLyr.StrokeColor = UIColor.Red.CGColor;
            progressLyr.LineWidth = (nfloat)5.0;
            progressLyr.StrokeEnd = (nfloat)0.2;
            Layer.AddSublayer(progressLyr);
        }
    }
}