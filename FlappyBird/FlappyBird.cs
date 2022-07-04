
namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        int gravity = 5;
        int score = 0;
        public FlappyBird()
        {
            InitializeComponent();
            refreshScore();
            pipeDown.Location = new Point(400, new Random().Next(250) - 250);
            pipe.Location = new Point(400, pipeDown.Bottom + 150);
            pipeDown2.Location = new Point(700, new Random().Next(250) - 250);
            pipe2.Location = new Point(700, pipeDown2.Bottom + 150);
            pipeDown3.Location = new Point(1000, new Random().Next(250) - 250);
            pipe3.Location = new Point(1000, pipeDown3.Bottom + 150);
            birdPicture.Location = new Point(birdHitBox.Left - 5,birdHitBox.Top - 5);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            birdHitBox.Top += gravity;
            if (gravity < 5)
            {
                gravity = (int)(gravity / 1.3) + 5;

            }else{
                gravity = 5;
            }
            pipe.Left -= 5;
            pipeDown.Left -= 5;
            pipe2.Left -= 5;
            pipeDown2.Left -= 5;
            pipe3.Left -= 5;
            pipeDown3.Left -= 5;
            if(pipe.Right < -10){
                pipeDown.Location = new Point(800, new Random().Next(250) - 250) ;
                pipe.Location = new Point(800,pipeDown.Bottom + 150) ;
                score++; refreshScore();
            }
            if(pipe2.Right < -10){
                pipeDown2.Location = new Point(800, new Random().Next(250) - 250) ;
                pipe2.Location = new Point(800,pipeDown2.Bottom + 150) ;
                score++; refreshScore();
            }
            if(pipe3.Right < -10){
                pipeDown3.Location = new Point(800, new Random().Next(250) - 250) ;
                pipe3.Location = new Point(800,pipeDown3.Bottom + 150) ;
                score++; refreshScore();
            }
        }

        private void jump(object sender, KeyPressEventArgs e)
        {
            if (gameTimer.Enabled && e.KeyChar == ' ')
            {
                    gravity = -35;
                   birdPicture.Location = new Point(birdHitBox.Left - 5, birdHitBox.Top - 5);
            }

        }
        private void lose(){
            restartButton.Visible = true;
            gameTimer.Stop();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restartButton.Visible = false;
            gameTimer.Start();
            birdHitBox.Location = new Point(50, 150);
            birdPicture.Location = new Point(birdHitBox.Left - 5, birdHitBox.Top - 5);
            pipeDown.Location = new Point(400, new Random().Next(250) - 250);
            pipe.Location = new Point(400, pipeDown.Bottom + 150);
            pipeDown2.Location = new Point(700, new Random().Next(250) - 250);
            pipe2.Location = new Point(700, pipeDown2.Bottom + 150);
            pipeDown3.Location = new Point(1000, new Random().Next(250) - 250);
            pipe3.Location = new Point(1000, pipeDown3.Bottom + 150);
            score = 0;refreshScore();
            Focus();
        }
        private void refreshScore(){
            scoreLabel.Text = "Score:" + score;
        }

        private void checkEvent(object sender, EventArgs e)
        {

            if (birdHitBox.Bounds.IntersectsWith(groundPicture.Bounds)
            || birdHitBox.Top < -10
            || birdHitBox.Bounds.IntersectsWith(pipe.Bounds)
            || birdHitBox.Bounds.IntersectsWith(pipeDown.Bounds)
            || birdHitBox.Bounds.IntersectsWith(pipe2.Bounds)
            || birdHitBox.Bounds.IntersectsWith(pipeDown2.Bounds)
            || birdHitBox.Bounds.IntersectsWith(pipe3.Bounds)
            || birdHitBox.Bounds.IntersectsWith(pipeDown3.Bounds))
            {
                lose();
            }

            birdPicture.Location = new Point(birdHitBox.Left - 5, birdHitBox.Top - 5);
        }

    }
}