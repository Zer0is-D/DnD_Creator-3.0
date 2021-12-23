using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Creator_3._0
{
    class Char_data
    {
        //  Общие
        public string Name;

        //  Расы
        sbyte[] RaceBonus = new sbyte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

        //  Класс

        //  Параметры
        int Points = 27;
        sbyte[] Stats = new sbyte[6] { 8, 8, 8, 8, 8, 8 };
        sbyte[] CheckStat = new sbyte[6] { 10, 10, 10, 10, 10, 10 };
        sbyte[] CheckStatDown = new sbyte[6] { 7, 7, 7, 7, 7, 7 };
        sbyte[] Bonus = new sbyte[6] { -1, -1, -1, -1, -1, -1 };
        sbyte[] UpCost = new sbyte[6] { 1, 1, 1, 1, 1, 1 };





        //  Мировоззрения

        //  Предыстория

        //  Навыки

        //  Заклинания

        //  Экипировка
        public bool One_handed;
    }
}
