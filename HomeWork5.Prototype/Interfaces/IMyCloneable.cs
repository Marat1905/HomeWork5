namespace HomeWork5.Prototype.Interfaces
{
    /// <summary>Кастомный интерфейс для клонирования объекта</summary>
    /// <typeparam name="T">Тип класса</typeparam>
    public interface IMyCloneable<T>  where T : class
    {
        /// <summary>Поверхностное клонирование</summary>
        /// <returns>Новый объект, если есть вложенные объекты то они передаются по ссылке</returns>
        T MyClone();

        /// <summary>Глубокое клонирование</summary>
        /// <returns>Новый объект</returns>
        T DeepCopy();
    }
}
