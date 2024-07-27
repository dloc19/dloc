using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Luyen_tx1._1
{
    internal class GiaoVien
    {
        private int _id;
        private string _name;
        private double _SoGioDay;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double SoGioDay
        {
            get { return _SoGioDay; }
            set { _SoGioDay = value; }
        }

        public void InThongTin()
        {
            Console.WriteLine("{0}\t {1}\t {2}", this.ID, this.Name, this.SoGioDay);
        }

        public GiaoVien() { }

        public GiaoVien(int id, string name, double sogioday)
        {
            this.ID = id;
            this.Name = name;
            this.SoGioDay = sogioday;
        }
    }
}
