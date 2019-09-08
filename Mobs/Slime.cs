using System;

namespace NPCTools.Desktop.Mobs {

    public class Slime {

        private Dispositions.MindlessDisposition.Mindless disposition;
        private DateTime movementTimer = DateTime.Now;

        //private TargetObject target; (Will hold a reference to it's current target

        public Slime() {
            disposition = Dispositions.MindlessDisposition.getRandomPersonality();
        }


        public double getMovementSpeed(DateTime time) {
            double x = time.Millisecond - movementTimer.Millisecond;
            if (x > 1500)
                resetMovementTimer();
            return -1 *( Math.Pow(x, 2) + (2 * x));
        }

        public String getDisposition() {
            return disposition.ToString();
        }

        public void resetMovementTimer() {
            movementTimer = DateTime.Now;
        }
    }
}
