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
using NHM.Wpf.ViewModels.Models;

namespace NHM.Wpf.Windows.Plugins
{
    /// <summary>
    /// Interaction logic for PluginWindow.xaml
    /// </summary>
    public partial class PluginWindow : Window
    {
        public PluginWindow()
        {
            InitializeComponent();
        }

        private void PluginEntry_OnInstallClick(object sender, PluginEventArgs e)
        {
            
        }

        private void PluginEntry_OnDetailsClick(object sender, PluginEventArgs e)
        {
            
        }
    }
}
