using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Fish : Animal
    {
        public string Fishname;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">種類</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        /// <param name="l">寿命</param>
        /// <param name="f">淡水魚</param>
        public Fish(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0, float l = 0, string f = "淡水魚") : base(bd, n, w, h, d, we, l)
        {
            Fishname = f;
        }
        public void Outcome()
        {
            Console.WriteLine($"魚の種類は{name}で{Fishname}です。");
            Heavy();
        }
    }
}
