using System;

namespace Ex30._0127
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(new DateTime(2002, 12, 29), "山田凱斗", 70f, 178f, 35f, 60f, 19f);　//学生
            student.Outcome();

            Worker worker = new Worker(new DateTime(2002, 12, 29), "19", 70f, 178f, 35f, 60f, 19f);　//職業
            worker.Outcome();

            Plant plant = new Plant(DateTime.Now, "ヨモギ", 10f, 10f, 10f, 10f, 1f); //植物　
            plant.Outcome();

            Insect insect = new Insect(DateTime.Now, "カブトムシ", 7f, 7f, 7f, 7f, 10f); //昆虫
            insect.Outcome();

            Cat cat = new Cat(new DateTime(2000, 1, 1), "シャム", 20f, 30f, 50f, 60f, 30f); //猫
            cat.Outcome();

            Refrigerator refrigerator = new Refrigerator("三菱", 150f, 200f, 100f, 300f); //冷蔵庫
            refrigerator.Outcome();

            Car car = new Car("ABARTH", 150f, 200f, 300f, 1000f); //車
            car.Outcome();

            Fish fish= new Fish(new DateTime(2000, 1, 1), "鮎", 10f, 10f, 10f, 10f, 10f); //猫
            fish.Outcome();

            Nue nue = new Nue(DateTime.Now, "鵺", 100f, 130f, 200f, 300f, 100f); //鵺
            nue.Outcome();

        }
    }
}
