using System;

namespace BasketballTimer.Services
{
    class TimerService
    {
        public string StartRestartBtnText { get; set; }
        public string PauseResumeBtnText { get; set; }
        public TimeSpan Timer { get; set; }
        public bool EnablePauseBtn { get; set; }
        public bool EnableTimer { get; set; }
        public bool EnableImagesBtn { get; set; }

        public TimerService()
        {
            PauseResumeBtnText = "Pause";
            StartRestartBtnText = "Start";
            Timer = TimeSpan.FromMinutes(12);
            EnablePauseBtn = false;
            EnableTimer = false;
        }

        public void StartRestartTimer()
        {
            if (StartRestartBtnText == "Start")
            {
                EnableTimer = true;
                EnablePauseBtn = true;
                EnableImagesBtn = false;
                StartRestartBtnText = "Restart";
            }
            else
            {
                EnableTimer = false;
                EnablePauseBtn = false;
                EnableImagesBtn = true;
                StartRestartBtnText = "Start";
                Timer = TimeSpan.FromMinutes(12);
                PauseResumeBtnText = "Pause";
            }
        }

        public void PauseResumeTimer()
        {
            if (PauseResumeBtnText == "Pause")
            {
                EnableTimer = false;
                PauseResumeBtnText = "Resume";
            }
            else
            {
                EnableTimer = true;
                PauseResumeBtnText = "Pause";
            }
        }

        public void AddTime()
        {
            Timer = Timer.Add(TimeSpan.FromMinutes(1));
        }

        public void DecreaseTimer()
        {
            Timer = Timer.Subtract(TimeSpan.FromSeconds(1));
        }

        public bool CheckFinalTime()
        {
            return Timer.TotalSeconds == 0;
        }

        public override string ToString()
        {
            return Timer.ToString(@"mm\:ss");
        }
    }
}
