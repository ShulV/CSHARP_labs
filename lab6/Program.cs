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
	class Car
	{
		private String name;
		private int price;
		private String color;
		private int speed;
		private int benzine;
		private Engine engine;
		public void init(String name, int price, String color, int speed, int benzine, Engine engine)
		{
			this.name = name;
			this.price = price;
			this.color = color;
			this.speed = speed;
			this.benzine = benzine;
			this.engine = engine;
			Console.WriteLine("Car initialized!");
		}
		public void readCarData()
		{
			string str = "";
			int number = 0;
			
			Console.WriteLine("ENTER CAR DATA:");
			//////////////////////////////////////////////////
			Console.WriteLine("\tname:\t");
			this.name = Console.ReadLine();
			///////////////////////////////////////////////
			bool flag = false; //флаг правильности ввода чисел
			while (!flag) {
				Console.WriteLine("\tprice:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.price = number;
			//////////////////////////////////////////////

			Console.WriteLine("\tcolor:\t");
			this.color = Console.ReadLine();
			//////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tengineRPM:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.engine.setEngineRPM(number);
			////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tcapacity:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.engine.setCapacity(number);
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tengine power:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.engine.setEnginePower(number);
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tquantity of cylinders:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.engine.setQuantityOfCylinders(number);
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tspeed:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.speed = number;
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.WriteLine("\tbenzine:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.WriteLine("re-enter:");
				}

			}
			this.benzine = number;
			///////////////////////////////////////////////////////



		}
		public void displayDataCar()
		{
				Console.WriteLine("\n\tCAR DATA");
				Console.WriteLine("\t\tName:\t" + this.name);
				Console.WriteLine("\t\tPrice:\t" + this.price);
				Console.WriteLine("\t\tColor:\t" + this.color);
				Console.WriteLine("\t\tEngineRPM:\t" + this.engine.getEngineRPM());
				Console.WriteLine("\t\tCapacity:\t" + this.engine.getCapacity());
				Console.WriteLine("\t\tEngine Power:\t" + this.engine.getEnginePower());
				Console.WriteLine("\t\tQuanity of cylinders:\t" + this.engine.getQuantityOfCylinders());
				Console.WriteLine("\t\tBenzine:\t" + this.benzine);
				Console.WriteLine("\t\tSpeed:\t" + this.speed);

		}
		public void addBenzine(int liters)
		{
			Console.WriteLine(liters + "lit. benzine added!");
			this.benzine += liters;
		}
		public void startEngine()
		{
			if (this.benzine > 0)
			{
				this.engine.setEngineRPM(800);
				Console.WriteLine("Engine started!");
			}
			else
			{
				Console.WriteLine("No benzine. Engine didn't start!");
			}
		}
		public void stopEngine()
		{
			if (this.engine.getEngineRPM() > 0)
			{
				this.engine.setEngineRPM(0);
				Console.WriteLine("Engine stopped!");
			}
			else
			{
				Console.WriteLine("Engine stopped already!");
			}
		}
		public void addSpeed(int speed)
		{
			if (this.engine.getEngineRPM() > 0)
			{
				this.speed += speed;
				Console.WriteLine("Car speeded up!");
			}
			else
			{
				Console.WriteLine("Engine isn't starting. Car didn't speed up!");
			}
		}
		public void reduceSpeed(int speed)
		{
			if (this.speed > 0)
			{
				this.speed -= speed;
				Console.WriteLine("Car speeded down!");
			}
			else
			{
				Console.WriteLine("Car is parking. Car didn't speed down!");
			}
		}
	}
	/////////////////////////////////////////////////
}