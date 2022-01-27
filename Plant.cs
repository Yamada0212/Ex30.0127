using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Plant:Life
    {
        public string plantae;　//植物
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">名前</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        /// <param name="l">寿命</param>
        /// <param name="p">植物の種類</param>
        public Plant(DateTime bd, string n, float w= 0, float h = 0, float d = 0, float we = 0, float l = 0,string p="キク科") : base(bd, n, w, h, d, we, l) 
        {
            plantae = p;
        }
        public void Outcome() 
        {
            Console.WriteLine($"この植物の名前は{name}で,{plantae}の仲間です。");
        }
    }
}
