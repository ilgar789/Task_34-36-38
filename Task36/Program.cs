Random random = new Random();

            // Создаем массив и заполняем его случайными числами
            int[] array = new int[4]; // Можете изменить размер массива по вашему желанию
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            // Выводим массив для проверки
            Console.WriteLine("Массив случайных чисел:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Находим сумму элементов на нечетных позициях
            int oddPositionSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) // Если индекс нечетный
                {
                    oddPositionSum += array[i];
                }
            }

            // Выводим сумму элементов на нечетных позициях
            Console.WriteLine("Сумма элементов на нечетных позициях: " + oddPositionSum);
        