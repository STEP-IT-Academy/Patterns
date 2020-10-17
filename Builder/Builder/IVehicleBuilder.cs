namespace Patterns
{
    /// <summary>
    /// Интерфейс строителя
    /// </summary>
    interface IVehicleBuilder 
    {
        /// <summary>
        /// Установка кузова
        /// </summary>
        void SetBody();

        /// <summary>
        /// Установка двигателя
        /// </summary>
        void SetEngine();

        /// <summary>
        /// Установка колес
        /// </summary>
        void SetWheel();

        /// <summary>
        /// Покарска
        /// </summary>
        void SetColor();

        /// <summary>
        /// Подготовка салона
        /// </summary>
        void SetVehicleInterior();

        /// <summary>
        /// Вывод на консоль результата сборки автомобиля
        /// </summary>
        void ShowResult();
    }
}
