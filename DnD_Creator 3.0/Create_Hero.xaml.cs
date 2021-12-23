using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Create_Hero_.xaml
    /// </summary>
    public partial class Create_Hero : Window
    {
        //  Вкладка Заклинания
        int num = 0;
        string[] images_Url =
        {
            "1.png",
            "2.png",
        };
        //  КОНЕЦ

        public Create_Hero()
        {
            InitializeComponent();
            PageRace.Elements = new List<UIElement>()
            {
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
                new Race_w() {},
            };
        }

        private void Btn_next(object sender, RoutedEventArgs e)
        {
            num++;
            if (num >= images_Url.Length)
                num = 0;

            string path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "NewFolder1\\" + images_Url[num]);
            pic.Source = new BitmapImage(new Uri(path));
        }

        private void Btn_last(object sender, RoutedEventArgs e)
        {
            num--;
            if (num < 0)
                num = images_Url.Length - 1;

            string path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "NewFolder1\\" + images_Url[num]);
            pic.Source = new BitmapImage(new Uri(path));
        }
    }
}
