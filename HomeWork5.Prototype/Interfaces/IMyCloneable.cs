namespace HomeWork5.Prototype.Interfaces
{
    public interface IMyCloneable<T>  where T : class
    {
        T MyClone();

        T DeepCopy();
    }
}
