using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Worker:Person
    {
        public string Profe;　//職業
    /// <summary>
    /// 
    /// </summary>
    /// <param name="bd">誕生日</param>
    /// <param name="n">職業</param>
    /// <param name="w">幅</param>
    /// <param name="h">高さ</param>
    /// <param name="d">奥行</param>
    /// <param name="we">重さ</param>
    /// <param name="l">年齢</param>
        public Worker(DateTime bd,string n, float w = 0, float h = 0, float d = 0, float we = 0, float l = 0,string job="学生") : base(bd,n, w, h, d, we, l) 
        {
            Profe = job;
        }
        public void Outcome() 
        {
            Console.WriteLine($"彼は{name}歳で、{Profe}です。");
            Heavy();
        }            
    }
}
