using System;
using System.Windows.Forms;

namespace FrogWinFormsApp
{
	public partial class MainForm : Form
	{
		private int count = 0;
		public MainForm()
		{
			InitializeComponent();
		}

		private void PictureBox_Click(object sender, EventArgs e)
		{
			count++;
			Swap((PictureBox)sender);
			scoreLabel.Text = count.ToString();
		}

		private void Swap(PictureBox clickedPictureBox) 
		{
			var distance = Math.Abs(clickedPictureBox.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

			if(distance > 2)
			{
				MessageBox.Show("Так нельзя!");
			}
			else
			{
				var location = clickedPictureBox.Location;
				clickedPictureBox.Location = emptyPictureBox.Location;
				emptyPictureBox.Location = location;
			}
			if (EndGame())
			{
				var winForm = new WinForm();
				if (count == 24)
				{
					winForm.winLabel.Text = "Вы прошли за минимум ходов!";
					winForm.ShowDialog();
					

				}
				else
				{
					winForm.winLabel.Text = "Вы победили! Но можно лучше!)";
					winForm.ShowDialog();
					
				}
			}
			
		}

		private bool EndGame()
		{
			if(rightPictureBox1.Location.X < 330 && rightPictureBox2.Location.X < 330 &&
				rightPictureBox3.Location.X < 330 && rightPictureBox4.Location.X < 330 && emptyPictureBox.Location.X == 330)
			{
				return true;
			}
			return false;
		}

		private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Вам необходимо поменять местами лягушек, те кто смотрит влево," +
				" должны стоять в левой стороне. Лягушки могут прыгать на соседнюю свободную кувшинку и перепрыгивать на нее через одну лягушку");


		}

		private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
