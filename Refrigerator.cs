using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Refrigerator:Thing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">会社名</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        public Refrigerator(string n = null, float w = 0, float h = 0, float d = 0, float we = 0) : base(n, w, h, d, we) 
        {

        }
        public void Outcome() 
        {
            Console.WriteLine($"冷蔵庫の会社は{name}です。");
            Volume();
            Heavy();
        }
    }
}
