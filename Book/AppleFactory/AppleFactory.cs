namespace AppleFactory
{
    public static class AppleFactory
    {
        public static int MakeJuice(int appleKillogrames)
        {
            var litersOfJuice = new JuiceMaker();
            return litersOfJuice.Make(appleKillogrames);
        }

        public class JuiceMaker
        {
            public int Model { get; private set; }

            JuiceMaker()
            {
                Model = 1;
            }

            public int Make(int appleKillogrames)
            {
                switch (Model)
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
        }

        private class PureMaker
        {
            public int Model { get; private set; }

            public PureMaker()
            {
                Model = 2;
            }

            public int Make(int appleKillogrames)
            {
                switch (Model)
                {
                    case 1:
                        var pureValue = appleKillogrames * 5;
                        return pureValue;
                    case 2:
                        var pureValue1 = appleKillogrames * 6;
                        return pureValue1;
                    default:
                        var pureValue2 = appleKillogrames * 7;
                        return pureValue2;
                }
            }
        }

    }
}
