using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Life:Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public float lifespan;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        new public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd, string n, float w,float h,float d,float we,float l) : base(n,w,h,d,we)
        {
            this._name = n;
            this._birthDay = bd;
            lifespan = l;
        }
        public void Birthday()
        {
            Console.WriteLine($"誕生日は{birthday.Year}年の{birthday.Month}月{birthday.Day}日です。");
        }
        public void BirthdayConfirmation()
        {
            if (DateTime.Now.Month == _birthDay.Month && DateTime.Now.Day == _birthDay.Day)
            {
                Console.WriteLine("今日は誕生日です。");
            }
        }
        public void LifeSpan()
        {
            Console.WriteLine($"寿命は{lifespan}年くらいです。");
        }
    }
}
