namespace VideoLesson_5
{
    public class EugeneFighter : BaseFight
    {
        public override string Ult()
        {
            return "Лунная призма дай мне силу!";
        }

        public override string Miss(int tryCount)
        {
            var miss = $"Ну ептать нахуй, ну как так, ну я уже {tryCount} раз попробовал!";
            return miss;
        }

        public override string ToString()
        {
            return "Боец Юджин";
        }
    }
}