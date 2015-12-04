namespace VideoLesson_8
{
    public interface IStudent<out T>
    {
        // Invariant
        T Move(string distance);

        // Covariant
        // int Set(T animal);
    }

    public class Student<T> : IStudent<T>
    {
        public T Move(string animal)
        {
            throw new System.NotImplementedException();
        }
    }
}