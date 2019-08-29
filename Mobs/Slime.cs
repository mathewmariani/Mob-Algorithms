using System;

namespace NPCTools.Desktop.Mobs {

    public class Slime {

        private Dispositions.MindlessDisposition.Mindless disposition;

        public Slime() {
            disposition = Dispositions.MindlessDisposition.GetRandomPersonality();
        }
    }
}
