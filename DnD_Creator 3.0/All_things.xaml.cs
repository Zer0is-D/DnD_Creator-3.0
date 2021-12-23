using System;
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

namespace DnD_Creator_3._0
{
    /// <summary>
    /// Логика взаимодействия для All_things.xaml
    /// </summary>
    public partial class All_things : Window
    {
        public All_things()
        {
            InitializeComponent();
            Str_tree.Header += "12";
            Dex_tree.Header += "12";
            Con_tree.Header += "12";
            Int_tree.Header += "12";
            Wis_tree.Header += "12";
            Cha_tree.Header += "12";
        }
    }
}
