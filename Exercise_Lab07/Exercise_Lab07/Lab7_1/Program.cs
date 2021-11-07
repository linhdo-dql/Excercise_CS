using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dongvat.AnCo;
using Dongvat.AnThit;
using Dongvat.AnTap;
/// <summary>
/// Tạo ứng dụng c# theo cấu trúc Dongvat {AnCo, AnThit, AnTap}
/// </summary>
namespace Dongvat
{
    class Program
    {
        /// <summary>
        /// Test ứng dụng trên với mỗi loài 1 con.
        /// </summary>
        public static void Test()
        {
            //AnCo
            Bo bo = new Bo(102, "Bún bò Huế", 201);
            bo.name = "Bò sữa";
            Console.WriteLine(bo.ToString());
            //AnThit
            CaSau cs = new CaSau(211, "Lacost", 111);
            Console.WriteLine(cs.ToString());
            //AnTap
            Ga ga = new Ga(001, "KFC", (float) 1.5);
            Console.WriteLine(ga.ToString());
        }



    }
    namespace AnCo
    {
        class Bo
        {
            public int id { get; set; }
            public string name { get; set; }
            public float weight { get; set; }
            public Bo()
            {
            }
            public Bo(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Bo[{id}, {name}, {weight}]";
            }
        }
        class Trau
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public Trau()
            {
            }
            public Trau(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Trau[{id}, {name}, {weight}]";
            }
        }
        class De
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public De()
            {
            }
            public De(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"De[{id}, {name}, {weight}]";
            }
        }
    }
    namespace AnThit
    {
        class CaSau
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public CaSau()
            {
            }
            public CaSau(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"CaSau[{id}, {name}, {weight}]";
            }
        }
        class Ho
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public Ho()
            {
            }
            public Ho(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Ho[{id}, {name}, {weight}]";
            }
        }
        class SuTu
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public SuTu()
            {
            }
            public SuTu(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"SuTu[{id}, {name}, {weight}]";
            }
        }
    }
    namespace AnTap
    {
        class Heo
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public Heo()
            {
            }
            public Heo(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Heo[{id}, {name}, {weight}]";
            }
        }
        class Ga
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public Ga()
            {
            }
            public Ga(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Ga[{id}, {name}, {weight}]";
            }
        }
        class Vit
        {
            int id { get; set; }
            string name { get; set; }
            float weight { get; set; }
            public Vit()
            {
            }
            public Vit(int id, string name, float weight)
            {
                this.id = id;
                this.name = name;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Vit[{id}, {name}, {weight}]";
            }
        }
    }
}
