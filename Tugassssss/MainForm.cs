using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugassssss{

	public partial class MainForm : Form{
		
		private Graphics objgraphic;
		private bool gambar = false, dragmode = false;
		private int X1, Y1, x, y, X2, Y2;
		private double xy;
		private int loop=0, line=0 ;
		
		public MainForm(){

			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e){
			
			objgraphic = panel1.CreateGraphics();
		}
		
		void Button1Click(object sender, EventArgs e){
			
			line = 1;
		}
		void Button2Click(object sender, EventArgs e){
			
			Environment.Exit(0);
		}
		void Button3Click(object sender, EventArgs e){
			
			this.Refresh();
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
		
		void Panel1Paint(object sender, PaintEventArgs e){
			
			objgraphic = panel1.CreateGraphics();
		}
		
		void Panel1MouseClick(object sender, MouseEventArgs e){
			
			if (gambar == true && dragmode == true){

				x = e.X;
				y = e.Y;
				X2 = e.X - X1;
				Y2 = Y1 - e.Y;

				if (line == 1){
	
					objgraphic.DrawLine(new Pen(Color.Black), X1, Y1, e.X, e.Y);
				}

				else {

					MessageBox.Show("KLICK TOMBOL LINE");
				}
			}
		}
		
		void Panel1MouseDown(object sender, MouseEventArgs e){
			
			if (e.Button == MouseButtons.Left){

				gambar = true;
				loop++;
			}
			
			X1 = e.X;
			Y1 = e.Y;
			dragmode = true;
		}
		
		void Panel1MouseMove(object sender, MouseEventArgs e){
			
			textBox1.Text = Convert.ToString(X2);
			textBox2.Text = Convert.ToString(Y2);
			xy = Math.Sqrt((X2 * X2) + (Y2 * Y2));
			textBox3.Text = Convert.ToString(xy);
		}
		
		void TextBox1TextChanged(object sender, EventArgs e){
		}		
	}
}
