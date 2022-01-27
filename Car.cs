using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Car:Thing
    {
        public string Carname;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">社製</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        /// <param name="c">車名</param>
        public Car(string n = null, float w = 0, float h = 0, float d = 0, float we = 0,string c="124スパイダー") : base(n, w, h, d, we) 
        {
            Carname = c;
        }
        public void Outcome() 
        {
            Console.WriteLine($"この車は{name}社製の{Carname}です。");
            Volume();
            Heavy();
        }
    }
}
