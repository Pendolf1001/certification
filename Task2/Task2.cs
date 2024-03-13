
// Задача 2:Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine(Akker(3,2));	
	
	


static int Akker(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return Akker(m - 1, 1);
			}
			return Akker(m - 1, Akker(m, n - 1));
		}

	
		