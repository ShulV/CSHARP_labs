/*
 1) Для придуманной вами задачи (Пункт 1 из задания к л/р 2 + пункт 1 из задания к л/р 4) реализовать необходимые классы на языке C#;
2) Продемонстрировать их использование в консольном С# приложении;
3) Продемонстрировать сборку проекта и запуск приложения на платформе Mono под Linux, Mac OS и пр.;
!) Использование GIT обязательно.
Поля класса «машина»:
•	Название
•	Цена
•	Цвет
•	Скорость
•	Количество бензина
•	Двигатель (объект)
Функции:
•	Инициализация
•	Установка параметров автомобиля
•	Вывод данных машины
•	Запуск двигателя
•	Остановка двигателя
•	Добавление скорости
•	Уменьшить скорость
Поля класса «двигатель»:
•	Количество оборотов в минуту
•	Мощность в Л.С.
•	Объем в см куб.
•	Количество цилиндров
Функции:
•	Инициализация
•	Сеттеры и геттеры
*/
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
			//Console.WriteLine("Kek lol program is working");
			Car bmw_x6 = new Car();
			Engine bmw_engine = new Engine();
			bmw_engine.init(0, 4395, 625, 8);
			bmw_x6.init("BMW X6", 3500000, "BLACK", 0, 0, bmw_engine); //инициализируем поля объекта
			bmw_x6.displayDataCar();
			bmw_x6.readCarData();
			bmw_x6.displayDataCar();
			bmw_x6.startEngine(); //пытаемся завести двигатель
			bmw_x6.displayDataCar();
			bmw_x6.addBenzine(10); //добавляем бензин
			bmw_x6.displayDataCar();
			bmw_x6.startEngine(); //снова пытаемся завести двигатель
			bmw_x6.displayDataCar();
			for (int i = 0; i < 4; i++)
			{
				bmw_x6.addSpeed(i * 5); //добавляем скорость
				bmw_x6.displayDataCar();
			}
			for (int i = 0; i < 4; i++)
			{
				bmw_x6.reduceSpeed(i * 5); //убавляем скорость
				bmw_x6.displayDataCar();
			}

			bmw_x6.stopEngine(); //останавливаем двигатель
			bmw_x6.displayDataCar();
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
			Console.Write("\tname:\t");
			this.name = Console.ReadLine();
			///////////////////////////////////////////////
			bool flag = false; //флаг правильности ввода чисел
			while (!flag) {
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
			//////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tengineRPM:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.engine.setEngineRPM(number);
			////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tcapacity:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.engine.setCapacity(number);
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tengine power:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.engine.setEnginePower(number);
			///////////////////////////////////////////////////////
			flag = false;
			while (!flag)
			{
				Console.Write("\tquantity of cylinders:\t");
				str = Console.ReadLine();
				flag = int.TryParse(str, out number);
				if (!flag)
				{
					Console.Write("re-enter:");
				}

			}
			this.engine.setQuantityOfCylinders(number);
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