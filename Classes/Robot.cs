using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CartagenaBuenaventura.Classes
{
    public class Robot
    {
        private Match match;
        private Timer timer;
        public Robot(Match match) 
        { 
            this.match = match;
            this.timer = new Timer();
            timer.Interval = 5 * 1000; // 5 Seconds
            timer.Elapsed += VerifyChanges;
        }

        public void Start() { this.timer.Start(); }

        public void Stop() { this.timer.Stop(); }

        private void VerifyChanges(object sender, ElapsedEventArgs e)
        {
            // Verifying
        }
    }
}
