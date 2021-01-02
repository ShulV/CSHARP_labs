using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
	// lab works Shulpov Victor PI-92
	/*
	Реализовать работу автомобиля на примере динамической структуры.
	Поля структуры:
	•	Название (строка)
	•	Цена (целое)
	•	Цвет (строка)
	•	Количество оборотов двигателя в минуту (целое)
	•	Скорость (целое)
	•	Количество бензина (целое)
	Функции:
	•	Инициализация
	•	Установка параметров автомобиля
	•	Вывод данных машины
	•	Запуск двигателя
	•	Остановка двигателя
	•	Добавление скорости
	•	Уменьшить скорость
	*/


	class Program
	{

		static void Main(string[] args)
		{
			//Console.WriteLine("Kek lol program is working");
			String str_in;
			int choice = 1;
			bool flag_in = false;
			while (choice != 0)
			{
				flag_in = false;
				Console.WriteLine(
					"\n\nВведите 1 - ПОКАЗАТЬ 7 ЛАБУ\n" +
					"Введите 2 - ПОКАЗАТЬ 8 ЛАБУ\n" +
					"Введите 3 - ПОКАЗАТЬ 9 ЛАБУ\n" +
					"Введите 4 - ПОКАЗАТЬ 10 ЛАБУ\n" +
					"Введите 5 - ПОКАЗАТЬ 11 ЛАБУ\n" +
					"Введите 6 - ПОКАЗАТЬ 12 ЛАБУ\n" +
					"Введите 0 - ВЫХОД\nваш выбор: ");
				while (!flag_in)
				{
					str_in = Console.ReadLine();
					flag_in = int.TryParse(str_in, out choice);
					if (!flag_in)
					{
						Console.Write("re-enter:");
					}

				}
				if (choice == 0) { break; }
				if (choice == 1)
				{
					Engine engine1 = new Engine(0, 4395, 625, 8);
					Engine engine2 = new Engine(0, 4395, 625, 8);
					Car bmw = new Car("BMW X6", 3500000, "BLACK", 0, 0, engine1); //инициализируем поля объекта
					Car audi = new Car("Audi", 3300000, "BLACK", 0, 0, engine2); //инициализируем поля объекта);
					
					Car[] car = new Car[2];
					
					audi.readCarData();
					car[0] = bmw;
					car[1] = audi;
					car[0].displayDataCar();
					car[1].displayDataCar();
					car[1] = car[1] + 50;
					car[1].displayDataCar();

					Car test_car = car[1];
					Console.WriteLine("test_car.benzine " + test_car.benzine);
					test_car = car[1]++;
					Console.WriteLine("car[1]++ = " + test_car.benzine);
					test_car = ++car[1];
					Console.WriteLine("++car[1] = " + test_car.benzine);
					
					car[1].displayDataCar();
					
					Console.WriteLine("\tВторой цвет: " + car[0].secondColor);
					String str = "";
					car[1].getStr(out str);
					Console.WriteLine("out str=" + str);
					car[1].changeStr(ref str);
					Console.WriteLine("ref str=" + str);
					Console.ReadKey();
				}
				if (choice == 2)
                {
					
					Console.WriteLine("count =" + Car.getCount());
					Car bmw = new Car();
					Console.WriteLine("После создания одного статического объекта Car\ncount =" + Car.getCount() + "\n");
					Car[] bmws = new Car[5];
					for(int i = 0; i < 5; i++)
                    {
						bmws[i] = new Car();
                    }

					Console.WriteLine("После создания массива из 5 статических объектов Car\ncount =" + Car.getCount() +  "\n");
					Console.ReadKey();
				}
				if (choice == 3)
                {
					Console.WriteLine("конструктор 0 парам");
					Car empty_car = new Car();//0 парам
					empty_car.displayDataCar();
					Console.WriteLine("конструктор 1 парам");
					Car some_car = new Car("lada");//один парам
					some_car.displayDataCar();
					Console.WriteLine("конструктор все парам");
					Engine engine1 = new Engine(0, 4395, 625, 8);
					Car bmw = new Car("BMW X6", 3500000, "BLACK", 0, 0, engine1); //много парам
					bmw.displayDataCar();
					Console.WriteLine("\tМассив объектов");
					Car[] car = new Car[3];
					for(int i=0; i < 3; i++)
                    {
						car[i] = new Car("car" + i.ToString());
						car[i].displayDataCar();
                    }

				}
				if (choice == 4)
                {
					Engine engine1 = new Engine(0, 4395, 625, 8);
					Car bmw_x6 = new Car("BMW X6", 3500000, "BLACK", 0, 10, 300, engine1); //много парам
					try
					{
						bmw_x6.startEngine();
						for (int i = 0; i < 10; i++)
						{
							bmw_x6.addSpeed(40);
						}

					}
					catch (NegativeNumberException ex) {
						Console.Write("Поймали исключение NegativeNumberException : слишком большая скорость!\n\tex.Message = " + ex.Message + "\n");
					}
					catch (Exception ex) {
						Console.Write("Поймали исключение Exception : слишком большая скорость!\n\tex.Message = " + ex.Message + "\n");
					}
					
				}
				if (choice == 5)
                {
					const int N = 4, M = 3;
					Car[] car_array = new Car[5];
					for (int i = 0; i < N; i++)
					{
						car_array[i] = new Car("car" + i.ToString());
					}
					/////////////////////////////////////////////////////////////////
					Car[,] car_darray = new Car[N,M];//двумерный (прямоугольный) массив
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < M; j++)
						{
							car_darray[i,j] = new Car("car" +(i * M + j).ToString());
						}

					}
					////////////////////////////////////////////////////////////////////
					Car[][] d_car_array = new Car[N][];//зубчатый массив
					for (int i = 0; i < N; i++)
					{
						d_car_array[i] = new Car[i];
						for (int j = 0; j < i; j++) //матрица не прямоугольная
						{
							d_car_array[i][j] = new Car("car" + i.ToString());
						}

					}
					
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < d_car_array[i].Length; j++)
						{
							d_car_array[i][j] = new Car("car" + i.ToString());
							Console.Write("Car[" + i + "][" + j + ']' + ' ');
						}
						Console.Write('\n');
					}

					//////////////////////////////////////////////////////////
				}
				if (choice == 6)
                {
					TaxiCar taxi_car = new TaxiCar("reno_logan");
					taxi_car.displayDataCar();
					taxi_car.callTaxi("Проспект Ленина 119");
					TaxiCar taxi_car2 = new TaxiCar("Solaris", 777);
					taxi_car2.addBenzine(10, 2);
					taxi_car2.displayDataCar();
					Console.WriteLine("x=" + taxi_car2.x + " y=" + taxi_car2.y);
					taxi_car2.Move(500, 400, 0);//вызов метода абстрактного класса из его наследника
					Console.WriteLine("x=" + taxi_car2.x + " y=" + taxi_car2.y);
					//интерфейс
					Console.WriteLine("\nИНТЕРФЕЙС\n");
					taxi_car2.Beep();
					IBeep i_taxi_vaz = new TaxiCar("ВАЗ");
					i_taxi_vaz.Beep();
					IBeep i_car_vaz = new Car("ВАЗ");
					i_car_vaz.Beep();
					Car car = new Car("car");
					car.Beep();
					//мелкое клонирование
					Console.WriteLine("\nКЛОНИРОВАНИЕ\n");
					Engine engine1 = new Engine(0, 4395, 625, 8);
					Car car1 = new Car("BMW X6", 3500000, "BLACK", 0, 0, engine1);
					Engine engine2 = new Engine(0, 3395, 425, 4);
					Car car2 = new Car("BMW X3", 1500000, "RED", 0, 0, engine2);
					Console.WriteLine("произвели мелкое клонирование");
					car2 = (Car)car1.Clone();
					car2.displayDataCar();
					Console.WriteLine("Данные двигателя car2");
					car2.engine.DisplayEngineData();
					Console.WriteLine("Установили для двигателя car1 EnginePower");
					car1.engine.setEnginePower(100000000);
					Console.WriteLine("Данные двигателя car2 (при мелком клонировании не создали новый объект, который был полем класса)");
					car2.engine.DisplayEngineData();
					//глубокое клонирование
					Engine _engine1 = new Engine(0, 4444, 444, 4);
					TaxiCar _taxi_car1 = new TaxiCar("taxi 4", 4444444, "color 4", 0, 0, 444, _engine1);
					Engine _engine2 = new Engine(0, 2222, 222, 2);
					TaxiCar _taxi_car2 = new TaxiCar("taxi 2", 1500000, "color 2", 0, 0, 222, _engine2);
					Console.WriteLine("произвели глубокое клонирование");
					_taxi_car2 = (TaxiCar)_taxi_car1.Clone();
					_taxi_car2.displayDataCar();
					Console.WriteLine("Данные двигателя _taxi_car2");
					_taxi_car2.engine.DisplayEngineData();
					Console.WriteLine("Установили для двигателя _taxi_car2 EnginePower");
					_taxi_car1.engine.setEnginePower(100000000);
					Console.WriteLine("Данные двигателя _taxi_car2 (при глубоком клонировании создали новый объект, который был полем класса)");
					_taxi_car2.engine.DisplayEngineData();
					Console.WriteLine("Данные двигателя _taxi_car1");
					_taxi_car1.engine.DisplayEngineData();
				}
			}
			
			

			
		}
	}
	/////////////////////////////////////////////////
	class NegativeNumberException : Exception
		{
		//Код ошибки
		private int errorCode;
		//Принимает сообщение с описание ошибки, и код ошибки
		public NegativeNumberException(string aMessage, int aCode)
		: base(aMessage) //Вызываем конструктор базового класса
		{
			errorCode = aCode;
		}
		//Возвращает код ошибки
		public int ErrorCode { get { return errorCode; } }
		
	};
	/////////////////////////////////////////////////
	class Engine
	{
		private int engineRPM; //количество оборотов в минуту
		private int capacity; //объем см куб
		private int enginePower; //мощность Л.С.
		private int quantityOfCylinders; //количество цилиндров
		//конструктор без параметров
		public Engine()
        {
			this.engineRPM = 0;
			this.capacity = 0;
			this.enginePower = 0;
			this.quantityOfCylinders = 0;
		}
		//конструктор с одним параметром
		public Engine(int engineRPM)
		{
			this.engineRPM = engineRPM;
			this.capacity = 0;
			this.enginePower = 0;
			this.quantityOfCylinders = 0;
		}
		//конструктор со всеми параметрами
		public Engine(int engineRPM, int capacity, int enginePower, int quantityOfCylinders)
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

		public void DisplayEngineData()
        {
			Console.WriteLine("\t\tEngineRPM:\t" + getEngineRPM());
			Console.WriteLine("\t\tCapacity:\t" + getCapacity());
			Console.WriteLine("\t\tEngine Power:\t" + getEnginePower());
			Console.WriteLine("\t\tQuanity of cylinders:\t" + getQuantityOfCylinders());
		}

	}
	/////////////////////////////////////////////////
	//абстрактный класс
	abstract class Vehicle
	{
		public int x;
		public int y;
		public System.Drawing.Point getPosition()
		{
			return new System.Drawing.Point(this.x, this.y);
		}
       abstract public void Move(int x, int y, int z);//абстрактный метод, который определяется в наследнике
};
	class Car : Vehicle, IBeep, ICloneable  // интерфейс клонирования
	{
		protected String name;
		protected int price;
		protected String color;
		protected int speed;
		public int benzine;
		public Engine engine;
		protected int max_speed;
		static int count=0;// определение статической переменной-члена класса


		public Car()
        {
			this.name = "";
			this.price = 0;
			this.color = "";
			this.speed = 0;
			this.benzine = 0;
			this.engine = null;
			this.max_speed = 0;
			count++;
			//Console.WriteLine("Car created 0 param!");
		}

		//конструктор с одним параметром
		public Car(String name)
		{
			this.name = name;
			this.price = 0;
			this.color = "";
			this.secondColor = "";
			this.speed = 0;
			this.benzine = 0;
			this.engine = null;
			this.max_speed = 0;
			count++;
			//Console.WriteLine("Car created 1 param!");
		}

		//конструктор со всеми параметрами
		public Car(String name, int price, String color, int speed, int benzine, int max_speed, Engine engine)
		{
			this.name = name;
			this.price = price;
			this.color = color;
			this.secondColor = color;
			this.speed = speed;
			this.benzine = benzine;
			this.engine = engine;
			this.max_speed = max_speed;
			count++;
			//Console.WriteLine("Car created all param!");
		}
		//конструктор с почти всеми параметрами
		public Car(String name, int price, String color, int speed, int benzine, Engine engine)
		{
			this.name = name;
			this.price = price;
			this.color = color;
			this.secondColor = color;
			this.speed = speed;
			this.benzine = benzine;
			this.engine = engine;
			this.max_speed = 0;
			count++;
			//Console.WriteLine("Car created almost all param!");
		}
		public static int getCount()
        {
			return count;
        }
		~Car()
		{
			count--;
		}

		public void Beep()
		{
			Console.WriteLine("Default beep! (Car)");
		}
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
			Console.WriteLine("\t\tName:\t" + this.name.ToLower());
			Console.WriteLine("\t\tPrice:\t" + this.price);
			Console.WriteLine("\t\tColor:\t" + this.color.ToLower());
			//Console.WriteLine("\t\tEngineRPM:\t" + this.engine.getEngineRPM());
			//Console.WriteLine("\t\tCapacity:\t" + this.engine.getCapacity());
			//Console.WriteLine("\t\tEngine Power:\t" + this.engine.getEnginePower());
			//Console.WriteLine("\t\tQuanity of cylinders:\t" + this.engine.getQuantityOfCylinders());
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
				if (this.speed + speed > this.max_speed) { throw new NegativeNumberException("Брошено исключение: Слишком большая скорость!\n", 1); }
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
		//переопределенная функция
        public override void Move(int x, int y, int z)
        {
			this.x += x;
			this.y += y;
        }

        public object Clone()
        {
            return new Car(name,price, color, speed, benzine, max_speed, engine);//перегрузка клонирования
        }



        public static Car operator +(Car car, int benzine) //
		{
			car.benzine += benzine;
			return car;
		}
		public static Car operator ++(Car car) // ++ один префикс и постфикс!
		{
			return new Car{ benzine = car.benzine + 1};
		}

	}
	//интерфейс гудка (подачи звукового сигнала)
	interface IBeep
    {
		public void Beep()
        {
			Console.WriteLine("Default beep!");
        }
    }

	//производный класс
	class TaxiCar : Car {
		private int code_name;
		//вызов конструктора базового класса
		public TaxiCar(String name):base(name) { }
		//перегрузка метода базового класса (с вызовом базового класса)
		public TaxiCar(String name, int code_name):base(name)
		{
			this.code_name = code_name;
		}

		public TaxiCar(String name, int price, String color, int speed, int benzine, int max_speed, Engine engine) : base(name, price, color, speed, benzine, max_speed, engine) { }
		//перегрузка метода базового класса (без вызова базового класса)
		public int addBenzine(int liters, int work_bonus)
		{
			Console.WriteLine(liters + work_bonus + "lit. benzine added!");
			this.benzine += liters + work_bonus;
			return this.benzine;
		}
		public void callTaxi(String address)
		{
			Console.WriteLine("По адресу {0} приехала машина {1}", address, this.name);
		}
		public new void Beep()
		{
			Console.WriteLine("Default beep! (Taxi)");
		}
		//глубокое клонирование
		public new object Clone()
		{
			Engine new_engine = new Engine(engine.getEngineRPM(), engine.getCapacity(), engine.getEnginePower(), engine.getQuantityOfCylinders());
			TaxiCar new_taxi_car =  new TaxiCar(name, price, color, speed, benzine, max_speed, new_engine);//перегрузка клонирования
			return new_taxi_car;
		}
	};
	/////////////////////////////////////////////////
	

}