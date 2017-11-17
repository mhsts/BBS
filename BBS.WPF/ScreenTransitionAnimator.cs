using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System;

namespace BBS.WPF
{
    public class ScreenTransitionAnimator
    {
        private UIElement currentScreen;
        private Grid container;

        public ScreenTransitionAnimator(UIElement initialScreen, Grid container)
        {
            currentScreen = initialScreen;
            this.container = container;
        }

        public void GotoScreen(UIElement targetScreen, Direction direction)
        {
            if (targetScreen == currentScreen)
                return;

            var multiplier = direction == Direction.Forward ? 1 : -1;

            TranslateControlHorizontal(targetScreen, multiplier * container.ActualWidth, 0, direction, null);
            TranslateControlHorizontal(currentScreen, 0, multiplier * -container.ActualWidth, direction, OnAnimationDone);

            targetScreen.Visibility = Visibility.Visible;
            if (targetScreen is IInitView)
            {
                (targetScreen as IInitView).Init();
            }

            currentScreen = targetScreen;
        }

        private void OnAnimationDone(UIElement oldScreen)
        {
            if (oldScreen != currentScreen)
                oldScreen.Visibility = Visibility.Hidden;
        }

        private void TranslateControlHorizontal(UIElement item, double from, double to, Direction direction, Action<UIElement> callback)
        {
            TranslateTransform trans = new TranslateTransform();
            item.RenderTransform = trans;
            
            DoubleAnimation anim = new DoubleAnimation(from, to, TimeSpan.FromSeconds(0.2));            
            anim.Completed += (s, e) => { if (callback != null) callback(item); };
            trans.BeginAnimation(TranslateTransform.XProperty, anim);
        }
    }

    public enum Direction
    {
        Forward,
        Backward
    }
}