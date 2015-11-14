namespace VideoLesson_4
{
    public class AlexandrFighter : BaseFight
    {
        public override string Ult()
        {
            return "Сотворил редкостную хуйню и рад!";
        }

        public override string Miss(int tryCount)
        {
            var miss = $"{tryCount} раз промахнулся и чет приуныл!";
            return miss;
        }

        public override string ToString()
        {
            return "Боец Александер";
        }
    }
}