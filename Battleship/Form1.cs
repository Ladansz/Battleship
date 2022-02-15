using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        Board board = new Board();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < board.Rows.Count(); i++)
            {
                for (int j = 0; j < board.Columns.Count(); j++)
                {
                    Label lbl = new Label();
                    lbl.Size = new Size(20, 20);
                    lbl.Location = new Point(i * 20, j * 20);
                    lbl.BackColor = (i + j) % 2 == 0 ? Color.DeepSkyBlue : Color.Aqua;
                    lbl.Click += lbl_Click;
                    panel1.Controls.Add(lbl);
                }
            }
        }
        private void lbl_Click(object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            Point selectedPoint = new Point { X = (lbl.Location.X / 20), Y = (lbl.Location.Y) / 20 };
            Shot shot = new Shot(selectedPoint);
            this.selectedPointTextBox.Text = selectedPoint.ToString();
            ShotStatus status = FireShot(board.Ships, shot);
            DisplayShotResult(status,lbl);    
        }
        
        private void DisplayShotResult(ShotStatus status, Label lbl)
        {
            this.shotStatusTextBox.Text = status.ToString();
            switch (status)
            {
                case ShotStatus.Hit:
                    {
                        lbl.BackColor = Color.Red;
                        lbl.Text = "H";
                    }
                    break;
                case ShotStatus.HitAndSunk:
                    {
                        lbl.BackColor = Color.Red;
                        lbl.Text = "H";
                    }
                    break;
                case ShotStatus.Victory:
                    {
                        lbl.BackColor = Color.Red;
                        lbl.Text = "H";
                        PanelController(status);
                    }
                    break;
                case ShotStatus.Miss:
                    lbl.Text = "M";
                    break;
            }
        }

        public ShotStatus FireShot(List<Ship> ships, Shot shot)
        {
            Shot.Count--;
            foreach (var ship in ships)
            {
                if (ship.Location.Contains(shot.ShotPoint) &&
                    !ship.HitPoints.Contains(shot.ShotPoint))
                {
                    return ShipIsHit(ship, shot);
                }
                else if (ship.HitPoints.Contains(shot.ShotPoint))
                {
                    return ShotStatus.Hit;
                }
            }
            return ShotStatus.Miss;
        }

        private ShotStatus ShipIsHit(Ship ship, Shot shot)
        {
            ship.HitPoints.Add(shot.ShotPoint);
            if (--ship.LifeCount > 0)
            {
                return ShotStatus.Hit;
            }
            else
            {
                return ShipIsSunk(ship);
            }
        }

        private ShotStatus ShipIsSunk(Ship ship)
        {
            ship.Sunk += new Ship.SunkHandler(ShowPlayer);
            ship.IsSinking(ship);
            board.SunkShips.Add(ship);
            if (board.SunkShips.Count == board.Ships.Count)
                return ShotStatus.Victory;
            else
                return ShotStatus.HitAndSunk;
        }

        public void PanelController(ShotStatus status)
        {
           if (status.Equals(ShotStatus.Victory))
           {
              foreach (Control ctrl in panel1.Controls)
              {
                  ctrl.Enabled = false;
              }
           }
        }
        //event handler method
        private void ShowPlayer(Ship ship)
        {
            shipwreckTextBox.Text += ship.Type.ToString() + " ";
        }

        //private void fireButton_Click(object sender, EventArgs e)
        //{
        //    int row = Int16.Parse(rowsComboBox.GetItemText(rowsComboBox.SelectedItem));
        //    int column = Int16.Parse(columnComboBox.GetItemText(columnComboBox.SelectedItem));
        //    Shot shot = new Shot(new Point(row, column));
        //    while(Shot.Count > 0)
        //    {
        //        ShotStatus status = FireShot(board.Ships, shot);
        //    }
        //}
    }
}
