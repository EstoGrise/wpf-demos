#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace HyperlinkCell.Action
{
    using System.Windows.Controls;
    using System.Windows.Interactivity;

    public class CheckboxUncheckedAction : TargetedTriggerAction<ListBox>
    {
        protected override void Invoke(object parameter)
        {
            this.Target.Items.Clear();
        }
    }
}