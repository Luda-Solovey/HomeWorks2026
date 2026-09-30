namespace AppleFactory
{
    public static class AppleFactory
    {
        public static int MakeJuice(int appleKillogrames)
        {
            var model = new JuiceMaker();

            switch (model.Model)
            {
                case 1:
                    var juiceValue = appleKillogrames * 2;
                    return juiceValue;
                case 2:
                    var juiceValue1 = appleKillogrames * 3;
                    return juiceValue1;

                default:
                    var juiceValue2 = appleKillogrames * 4;
                    return juiceValue2;
            }
        }

        public class JuiceMaker
        {
            public int Model { get; private set; }

            JuiceMaker()
            {
                Model = 1;
            }

        }

        private class PureMaker
        {
            public int Model { get; set; }

            public PureMaker()
            {
                Model = 2;
            }
        }
    }
}
