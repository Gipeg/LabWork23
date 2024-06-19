namespace LabWorkLibrary
{
    public class Maths
    {
        /// <summary>
        /// 2 в 10 степени
        /// </summary>
        public const int BINARY_FACTOR = 1024;

        /// <summary>
        /// Считает сумму двух элементов
        /// </summary>
        /// <param name="x">Слогаемое 1</param>
        /// <param name="y">Слогаемое 2</param>
        /// <returns>Возвращает сумму двух элементов</returns>
        public static double GetSum(double x, double y) => x + y;

        /// <summary>
        /// Считает разность двух элементов
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитемое</param>
        /// <returns>Возвращает разность двух элементов</returns>
        public static double GetDifference(double x, double y) => x - y;

        /// <summary>
        /// Считает произведение двух элементов
        /// </summary>
        /// <param name="x">Множитель 1</param>
        /// <param name="y">Множитель 2</param>
        /// <returns>Возвращает произведение двух чисел</returns>
        public static double GetProduct(double x, double y) => x * y;

        /// <summary>
        /// Считает частное двух элементов
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <returns>Возвращает произведение двух чисел</returns>
        public static double GetQuotient(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка! Деление на 0. ");
            }
            return x / y;
        }

        /// <summary>
        /// Считает площадь прямоугольника
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>Возвращает площадь прямоугольника</returns>
        public static double GetRectangleArea(double width, double height) => width * height;
    }
}
