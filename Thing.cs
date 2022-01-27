using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30._0127
{
    class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public float weight;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">名前</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        public Thing(string n = null, float w = 0, float h = 0, float d = 0, float we = 0)
        {
            this.name = n;
            this.width = w;
            this.height = h;
            this.depth = d;
            this.weight = we;
        }
        public void Volume()
        {
            Console.Write($"体積は{weight * height * depth}cm3。　");
        }
        public void Heavy()
        {
            Console.WriteLine($"重さは{weight}kg。");
        }
    }
}
