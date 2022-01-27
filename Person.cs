using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Person:Animal
    {　
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
        public Person(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0, float l= 0) :base(bd, n, w, h, d, we, l) 
        {

        }
        public int Age(DateTime dateTime)
        {
            int age = 0;
            DateTime today = DateTime.Now;
            age = today.Year - dateTime.Year;

            if (dateTime > today.AddYears(-age))
            {
                age -= 1;
            }
            return age;
        }
    }
}
