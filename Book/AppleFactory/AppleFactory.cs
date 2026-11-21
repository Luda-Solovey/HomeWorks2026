using System.Drawing;

namespace AppleFactory
{
    static class AppleFactory
    {
        public static int AppleCount { get; private set; }

        public static int MakeJuice(int appleKillogrames)
        {
            JuiceMaker juiceMaker = new();
            var juiceValue = juiceMaker.Make(appleKillogrames);

            return juiceValue;
        }

        public static int MakePure(int appleKillogrames)
        {
            PureMaker pureMaker = new PureMaker();
            var pureValue = pureMaker.Make(appleKillogrames);
            return pureValue;
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

        private class JuiceMaker
        {
            public  int Model { get; private set; }
            public JuiceMaker()
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

        

    }
}
