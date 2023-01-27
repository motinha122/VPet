﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static VPet_Simulator.Core.GraphCore;

namespace VPet_Simulator.Windows
{
    /// <summary>
    /// winConsole.xaml 的交互逻辑
    /// </summary>
    public partial class winConsole : Window
    {
        MainWindow mw;
        public winConsole(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            foreach (string v in Enum.GetNames(typeof(GraphType)))
            {
                GraphListBox.Items.Add(v);
            }

        }
        public void DisplayLoop(GraphType graphType)
        {
            mw.Main.Display(graphType, () => DisplayLoop(graphType));
        }
        private void GraphListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (GraphListBox.SelectedItem == null)
                return;
            LabelNowPlay.Content = $"当前正在播放: {GraphListBox.SelectedItem}";
            DisplayLoop((GraphType)Enum.Parse(typeof(GraphType), (string)GraphListBox.SelectedItem));
        }

        private void DisplayListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DisplayListBox.SelectedItem == null)
                return;
            LabelSuccess.Content = $"当前正在运行: {(string)((ListBoxItem)DisplayListBox.SelectedItem).Content}";
            switch ((string)((ListBoxItem)DisplayListBox.SelectedItem).Content)
            {
                case "DisplayNomal":
                    mw.Main.DisplayNomal();
                    break;
                case "DisplayTouchHead":
                    mw.Main.DisplayTouchHead();
                    break;
                case "DisplayBoring":
                    mw.Main.DisplayBoring();
                    break;
                case "DisplaySquat":
                    mw.Main.DisplaySquat();
                    break;
                case "DisplaySquating":
                    mw.Main.DisplaySquating();
                    break;
                case "DisplaySleep":
                    mw.Main.DisplaySleep();
                    break;
                case "DisplaySleeping":
                    mw.Main.DisplaySleeping();
                    break;
                case "DisplaySleepingForce":
                    mw.Main.DisplaySleepingForce();
                    break;
                case "DisplayRaised":
                    mw.Main.DisplayRaised();
                    break;
                case "DisplayFalled_Left":
                    mw.Main.DisplayFalled_Left();
                    break;
                case "DisplayFalled_Right":
                    mw.Main.DisplayFalled_Right();
                    break;
                case "DisplayWalk_Left":
                    mw.Main.DisplayWalk_Left();
                    break;
                case "DisplayWalk_Right":
                    mw.Main.DisplayWalk_Right();
                    break;
                case "DisplayCrawl_Left":
                    mw.Main.DisplayCrawl_Left();
                    break;
                case "DisplayCrawl_Right":
                    mw.Main.DisplayCrawl_Right();
                    break;
                case "DisplayClimb_Left_UP":
                    mw.Main.DisplayClimb_Left_UP();
                    break;
                case "DisplayClimb_Left_DOWN":
                    mw.Main.DisplayClimb_Left_DOWN();
                    break;
                case "DisplayClimb_Right_UP":
                    mw.Main.DisplayClimb_Right_UP();
                    break;
                case "DisplayClimb_Right_DOWN":
                    mw.Main.DisplayClimb_Right_DOWN();
                    break;
                case "DisplayClimb_Top_Right":
                    mw.Main.DisplayClimb_Top_Right();
                    break;
                case "DisplayClimb_Top_Left":
                    mw.Main.DisplayClimb_Top_Left();
                    break;
                case "DisplayFall_Left":
                    mw.Main.DisplayFall_Left();
                    break;
                case "DisplayFall_Right":
                    mw.Main.DisplayFall_Right();
                    break;
            }
        }

        private void Say_Click(object sender, RoutedEventArgs e)
        {
            mw.Main.Say(SayTextBox.Text);
        }
    }
}