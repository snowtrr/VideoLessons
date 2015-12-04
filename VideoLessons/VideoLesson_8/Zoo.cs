namespace VideoLesson_8
{
    public class Zoo<T> where T : Animal, new()
    {
        public void MoveAnimal(T animal)
        {
            animal.Move();
        }

        public T GetNewAnimal()
        {
            var animal = new T();
            return animal;
        }
    }
}