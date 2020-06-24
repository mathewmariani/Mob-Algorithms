using System;
using Microsoft.Xna.Framework;

namespace MOBAlgorithms.Desktop.Mobs {

    public class Slime {

        private Dispositions.MindlessDisposition.Mindless disposition;
        private DateTime movementTimer = DateTime.Now;
        private Dispositions.FSM brain;

        //Target will be set to player, but if you want a more interesting slime it could target other things
        private Object target = new Object();

        public Slime() {
            disposition = Dispositions.MindlessDisposition.getRandomPersonality();
        }


        public double getMovementSpeed(DateTime time) {
            double x = time.Millisecond - movementTimer.Millisecond;
            if (x > 1500)
                resetMovementTimer();
            return -1 *( Math.Pow(x, 2) + (2 * x));
        }

        public double getJumpSpeed() {
            return 0.0;
        }

        public String getDisposition() {
            return disposition.ToString();
        }

        public void resetMovementTimer() {
            movementTimer = DateTime.Now;
        }
    }
}
