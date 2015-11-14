namespace VideoLesson_4
{
    public class BaseFight
    {
        public virtual string Ult()
        {
            return "Super mega ultra kill";
        }

        public virtual string Miss(int tryCount)
        {
            var miss = $"Missed? Again? I tryed for {tryCount} times";
            return miss;
        }
    }
}