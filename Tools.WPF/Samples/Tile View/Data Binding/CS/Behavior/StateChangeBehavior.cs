﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Syncfusion.Windows.Shared;
using System.Windows.Interactivity;
using System.Windows.Controls;

namespace DataBindingDemo
{
    public class StateChangeBehavior : Behavior<Button>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.Click += new RoutedEventHandler(AssociatedObject_Click);
            base.OnAttached();
        }

        void AssociatedObject_Click(object sender, RoutedEventArgs e)
        {
            TileViewItem tileitem = Target.ItemContainerGenerator.ContainerFromIndex(Target.SelectedIndex) as TileViewItem;

            if (tileitem.TileViewItemState == TileViewItemState.Normal)
            {
                tileitem.TileViewItemState = TileViewItemState.Maximized;
            }
            else
            {
                tileitem.TileViewItemState = TileViewItemState.Normal;
            }
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Click -= new RoutedEventHandler(AssociatedObject_Click);
            base.OnDetaching();
        }



        public TileViewControl Target
        {
            get { return (TileViewControl)GetValue(TargetProperty); }
            set { SetValue(TargetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.Register("Target", typeof(TileViewControl), typeof(StateChangeBehavior), new UIPropertyMetadata(null));


    }
}