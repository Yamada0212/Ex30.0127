using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Student:Person
    {
        public string Number; //番号 
        /// 
        /// </summary>
        /// <param name="bd">誕生日</param>　
        /// <param name="n">名前</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        /// <param name="l">年齢</param>
        /// <param name="id">学籍番号</param>
        public Student(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0, float l = 0,string id="212E007") : base(bd, n, w, h, d, we, l) 
        {
            Number = id;
        }
        public void Outcome()
        {
            Console.WriteLine($"彼の名前は{name}で、学籍番号は{Number}です。");
        }
    }
}
