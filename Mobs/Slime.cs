using System;

namespace NPCTools.Desktop.Mobs {

    public class Slime {

        private Dispositions.MindlessDisposition.Mindless disposition;

        public Slime() {
            disposition = Dispositions.MindlessDisposition.getRandomPersonality();
        }


        public double getMovementSpeed(int time) {
            return -1 *( Math.Pow(time, 2) + (2 * time));
        }

        public String getDisposition() {
            return disposition.ToString();
        }
    }
}
