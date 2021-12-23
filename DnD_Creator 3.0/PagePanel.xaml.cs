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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD_Creator_3._0
{
    public partial class PagePanel : UserControl
    {
        private List<UIElement> elements;

        public List<UIElement> Elements
        {
            get => elements;
            set
            {
                elements = value;
                MainPart.Children.Clear();

                panels = new List<StackPanel>();

                for (int i = 0; i < elements.Count; i++)
                {
                    if ((i % 4) == 0)
                    {
                        panels.Add(new StackPanel() { Orientation = Orientation.Horizontal });

                        MainPart.Children.Add(panels[panels.Count - 1]);
                    }

                    panels[panels.Count - 1].Children.Add(elements[i]);
                }
            }
        }

        private List<StackPanel> panels;
        public List<StackPanel> Panels => panels;

        public PagePanel()
        {
            InitializeComponent();
        }

        public PagePanel(List<UIElement> list)
        {
            InitializeComponent();
            Elements = list;
        }
    }
}
