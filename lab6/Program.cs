using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
	/////////////////////////////////////////////////
	class Program
    {
        static void Main(string[] args)
        {
		 Console.WriteLine("Kek lol program is working");
        }
    }
	/////////////////////////////////////////////////
	class Engine
	{
		private int engineRPM; //количество оборотов в минуту
		private int capacity; //объем см куб
		private int enginePower; //мощность Л.С.
		private int quantityOfCylinders; //количество цилиндров

		public void init(int engineRPM, int capacity, int enginePower, int quantityOfCylinders)
		{
			this.engineRPM = engineRPM;
			this.capacity = capacity;
			this.enginePower = enginePower;
			this.quantityOfCylinders = quantityOfCylinders;
		}
		public void setEngineRPM(int engineRPM)
		{
			this.engineRPM = engineRPM;
		}
		public void setCapacity(int capacity)
		{
			this.capacity = capacity;
		}
		public void setEnginePower(int enginePower)
		{
			this.enginePower = enginePower;
		}
		public void setQuantityOfCylinders(int quantityOfCylinders)
		{
			this.quantityOfCylinders = quantityOfCylinders;
		}
		public int getEngineRPM()
		{
			return this.engineRPM;
		}
		public int getCapacity()
		{
			return this.capacity;
		}
		public int getEnginePower()
		{
			return this.enginePower;
		}
		public int getQuantityOfCylinders()
		{
			return this.quantityOfCylinders;
		}

	}
	/////////////////////////////////////////////////
}