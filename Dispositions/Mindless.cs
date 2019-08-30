using System;

namespace NPCTools.Desktop.Dispositions {


    class MindlessDisposition
    {
        /**
        * Mindless Disposition describes the dispositions of creatures
        * with extremely low levels of intellect. This includes slimes,
        * molds, jellyfish, etc.
        */
        public enum Mindless {
            NORMAL,
            DOCILE,
            CAUTIOUS,
            AGGRESSIVE
        }

        public static Mindless getRandomPersonality() {
            Random random = new Random();
            int x = random.Next(1, 98);

            if (x <= 80) return Mindless.NORMAL;
            else if (x <= 90) return Mindless.AGGRESSIVE;
            else if (x <= 95) return Mindless.CAUTIOUS;

            return Mindless.DOCILE;
        }
    }

}
