using BasketballTimer;
using BasketballTimer.Services;
using System;
using System.Windows.Forms;

namespace BasketballTime
{
    public partial class BasketballScoreboardControl : Form
    {
        private ScoreboardControlService _team1Service;
        private ScoreboardControlService _team2Service;
        private ImageService _imageService;
        private TimerService _timerService;

        public BasketballScoreboardControl()
        {
            InitializeComponent();

            _team1Service = new ScoreboardControlService();
            _team2Service = new ScoreboardControlService(1);
            _imageService = new ImageService();
            _timerService = new TimerService();

            pictureBox1.ImageLocation = _imageService.Images[_team1Service.Index];
            pictureBox2.ImageLocation = _imageService.Images[_team2Service.Index];
            lblTimer.Text = _timerService.ToString();
        }

        private void btnStartRestart_Click(object sender, EventArgs e)
        {
            if (_team1Service.Index == _team2Service.Index)
            {
                MessageBox.Show("Não é possível iniciar o jogo a mesma equipe.");
                return;
            }
            _timerService.StartRestartTimer();
            timer1.Enabled = _timerService.EnableTimer;
            lblTimer.Text = _timerService.ToString();
            RefreshScreenComponents();
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            _timerService.PauseResumeTimer();
            timer1.Enabled = _timerService.EnableTimer;
            btnPauseResume.Text = _timerService.PauseResumeBtnText;
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            _timerService.AddTime();
            lblTimer.Text = _timerService.ToString();
        }

        private void btnLeftT1_Click(object sender, EventArgs e)
        {
            _team1Service.ReduceIndex();
            pictureBox1.ImageLocation = _imageService.Images[_team1Service.Index];
        }

        private void btnRightT1_Click(object sender, EventArgs e)
        {
            _team1Service.AddIndex();
            pictureBox1.ImageLocation = _imageService.Images[_team1Service.Index];
        }

        private void btnAddOneT1_Click(object sender, EventArgs e)
        {
            _team1Service.Score++;
            lblScoreT1.Text = _team1Service.Score.ToString();
        }

        private void btnAddTwoT1_Click(object sender, EventArgs e)
        {
            _team1Service.Score += 2;
            lblScoreT1.Text = _team1Service.Score.ToString();
        }

        private void btnAddThreeT1_Click(object sender, EventArgs e)
        {
            _team1Service.Score += 3;
            lblScoreT1.Text = _team1Service.Score.ToString();
        }

        private void btnDecreaseT1_Click(object sender, EventArgs e)
        {
            _team1Service.ReduceScore();
            lblScoreT1.Text = _team1Service.Score.ToString();
        }

        private void btnAddFoulT1_Click(object sender, EventArgs e)
        {
            _team1Service.Foul++;
            lblFoulT1.Text = _team1Service.Foul.ToString();
        }

        private void btnLeftT2_Click(object sender, EventArgs e)
        {
            _team2Service.ReduceIndex();
            pictureBox2.ImageLocation = _imageService.Images[_team2Service.Index];
        }

        private void btnRightT2_Click(object sender, EventArgs e)
        {
            _team2Service.AddIndex();
            pictureBox2.ImageLocation = _imageService.Images[_team2Service.Index];
        }

        private void btnAddOneT2_Click(object sender, EventArgs e)
        {
            _team2Service.Score++;
            lblScoreT2.Text = _team2Service.Score.ToString();
        }

        private void btnAddTwoT2_Click(object sender, EventArgs e)
        {
            _team2Service.Score += 2;
            lblScoreT2.Text = _team2Service.Score.ToString();
        }

        private void btnAddThreeT2_Click(object sender, EventArgs e)
        {
            _team2Service.Score += 3;
            lblScoreT2.Text = _team2Service.Score.ToString();
        }

        private void btnDecreaseT2_Click(object sender, EventArgs e)
        {
            _team2Service.ReduceScore();
            lblScoreT2.Text = _team2Service.Score.ToString();
        }

        private void btnAddFoulT2_Click(object sender, EventArgs e)
        {
            _team2Service.Foul++;
            lblFoulT2.Text = _team2Service.Foul.ToString();
        }

        public void RefreshScreenComponents()
        {
            btnLeftT1.Enabled = _timerService.EnableImagesBtn;
            btnLeftT2.Enabled = _timerService.EnableImagesBtn;
            btnRightT1.Enabled = _timerService.EnableImagesBtn;
            btnRightT2.Enabled = _timerService.EnableImagesBtn;
            btnStartRestart.Text = _timerService.StartRestartBtnText;
            btnPauseResume.Text = _timerService.PauseResumeBtnText;
            btnPauseResume.Enabled = _timerService.EnablePauseBtn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerService.DecreaseTimer();
            lblTimer.Text = _timerService.ToString();
            if (_timerService.Timer.TotalSeconds == 0)
            {
                timer1.Stop();
                FinalTime finalTime = new FinalTime();
                finalTime.ShowDialog();
                btnStartRestart_Click(null, null);
                _timerService.EnableImagesBtn = false;
                RefreshScreenComponents();
            }
        }
    }
}
