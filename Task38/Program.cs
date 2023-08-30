            // Создаем массив вещественных чисел
            double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 }; // Можете изменить элементы массива по вашему желанию

            // Находим максимальный и минимальный элементы массива
            double max = array[0];
            double min = array[0];
            foreach (double num in array)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            // Находим разницу между максимальным и минимальным элементами
            double difference = max - min;

            // Выводим разницу
            Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
        