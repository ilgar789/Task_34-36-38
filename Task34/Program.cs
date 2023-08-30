Random random = new Random();

            // Создаем массив и заполняем его случайными трехзначными числами
            int[] array = new int[4]; // Можете изменить размер массива по вашему желанию
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
            }

            // Выводим массив для проверки
            Console.WriteLine("Массив случайных трехзначных чисел:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Подсчитываем количество четных чисел
            int evenCount = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Выводим количество четных чисел
            Console.WriteLine("Количество четных чисел: " + evenCount);