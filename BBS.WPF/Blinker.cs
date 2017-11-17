using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace BBS.WPF
{
    public static class Blinker
    {
        public static Storyboard PrepareFeedback(Control control, bool longColorFeedback)
        {
            var redBlink = new Storyboard();

            var origColor = ((SolidColorBrush)control.Background).Color;

            var colorAnimation = GetColorAnimation(origColor, Colors.Salmon, longColorFeedback ? 800 : 100);
            redBlink.Children.Add(colorAnimation);
            Storyboard.SetTargetProperty(colorAnimation, new PropertyPath("Background.Color"));
            Storyboard.SetTarget(colorAnimation, control);

            redBlink.Children.Add(GetTranslationAnimation(control));

            var storyboardName = "s" + redBlink.GetHashCode();
            control.Resources.Add(storyboardName, redBlink);

            return redBlink;
        }

        private static DoubleAnimationUsingKeyFrames GetTranslationAnimation(FrameworkElement control)
        {
            var translation = new TranslateTransform();   

            var translationName = "blinkerTranslation" + translation.GetHashCode();
            control.RegisterName(translationName, translation);
            control.RenderTransform = translation;

            var xAnimation = new DoubleAnimationUsingKeyFrames();

            var frame0 = new LinearDoubleKeyFrame(0.0);
            var frame1 = new LinearDoubleKeyFrame(-5.0, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 50)));            
            var frame2 = new LinearDoubleKeyFrame(5.0, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 150)));
            var frame3 = new LinearDoubleKeyFrame(-5.0, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 250)));
            var frame4 = new LinearDoubleKeyFrame(5.0, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 350)));
            var frame5 = new LinearDoubleKeyFrame(0.0, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 400)));

            xAnimation.KeyFrames.Add(frame0);
            xAnimation.KeyFrames.Add(frame1);
            xAnimation.KeyFrames.Add(frame2);
            xAnimation.KeyFrames.Add(frame3);
            xAnimation.KeyFrames.Add(frame4);
            xAnimation.KeyFrames.Add(frame5);

            Storyboard.SetTargetName(xAnimation, translationName);
            Storyboard.SetTargetProperty(xAnimation, new PropertyPath(TranslateTransform.XProperty));

            return xAnimation;
        }

        private static ColorAnimationUsingKeyFrames GetColorAnimation(Color one, Color two, int colorFeedbackLength)
        {
            var colorAnimation = new ColorAnimationUsingKeyFrames();

            var frame0 = new LinearColorKeyFrame(one);

            var frame1 = new LinearColorKeyFrame(two);
            frame1.KeyTime = KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, 50));

            var frame2 = new LinearColorKeyFrame(one);
            frame2.KeyTime = KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0, 0, colorFeedbackLength));

            colorAnimation.KeyFrames.Add(frame0);
            colorAnimation.KeyFrames.Add(frame1);
            colorAnimation.KeyFrames.Add(frame2);

            return colorAnimation;
        }
    }
}
