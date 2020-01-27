namespace PrototypePattern
{
    public interface ICloneable<T>
         where T : class

    {
        T Clone();
    }
}
