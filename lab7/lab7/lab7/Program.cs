using System;

namespace lab7
{
	/////////////////////////////////////////////////
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Kek lol program is working");

			Car bmw = new Car();
			bmw.init("BMW X6", 3500000, "BLACK", 0, 0); //инициализируем поля объекта
			bmw.displayDataCar();
			bmw.readCarData();
			bmw.displayDataCar();
			Console.ReadKey();
		}
	}



	///////////////////////////////////////////////
	struct Car
	{
		private String name;
		private int price;
		private String color;
		private int speed;
		private int benzine;

		/*
		 Ref параметры предназначены для данных, которые могут быть изменены, 
		out параметры предназначены для данных, которые являются дополнительным выходом для функции 
		(например, int.TryParse), которые уже используют возвращаемое значение для чего-то.
		 */
		public void getStr(out String str)
        {
			str = "Машина " + name + ", цвет " + color + ", цена " + price;
        }
		public void changeStr(ref String str)
        {
			str = str + "!!!";
        }
		public String secondColor { private set; get; }
		public void init(String name, int price, String color, int speed, int benzine)
		{
			this.name = name;
			this.price = price;
			this.color = color;
			this.secondColor = color;
			this.speed = speed;
			this.benzine = benzine;
			Console.WriteLine("Car initialized!");
		}
		public void readCarData()
		{
			string str = "";
			int number = 0;

			Console.WriteLine("ENTER CAR DATA:");
			//////////////////////////////////////////////////
			Console.Write("\tname:\t");
			this.name = Console.ReadLine();
			///////////////////////////////////////////////
			bool flag = false; //флаг правильности ввода чисел
			while (!flag)
			{
				Console.Write("\tprice:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.price = number;
			//////////////////////////////////////////////

			Console.Write("\tcolor:\t");
			this.color = Console.ReadLine();
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tspeed:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.speed = number;
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tbenzine:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.benzine = number;
			///////////////////////////////////////////////////////



		}
		public void displayDataCar()
		{
			Console.WriteLine("\n\tCAR DATA");
			Console.WriteLine("\t\tName:\t" + this.name.ToLower());
			Console.WriteLine("\t\tPrice:\t" + this.price);
			Console.WriteLine("\t\tColor:\t" + this.color.ToLower());
			Console.WriteLine("\t\tBenzine:\t" + this.benzine);
			Console.WriteLine("\t\tSpeed:\t" + this.speed);

		}
		public void addBenzine(int liters)
		{
			Console.WriteLine(liters + "lit. benzine added!");
			this.benzine += liters;
		}
		public void addSpeed(int speed)
		{
			
			this.speed += speed;
			Console.WriteLine("Car speeded up!");
		
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