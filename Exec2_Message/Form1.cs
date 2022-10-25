using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string now = NowDateTime();
			string greet = Greeting(now);
			string result = Message(now, greet);

			greetLbl.Text = result;
			MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
		}

		private string NowDateTime()
		{
			DateTime dt = DateTime.Now;
			string now = dt.ToString();
			return now;
		}
		private string Greeting(string NowDateTime)
		{
			string greet;
			int hour = DateTime.Now.Hour;
			if (hour > 6 && hour < 12)
			{
				greet = "早安";
				return greet;
			}
			else if(hour < 18)
			{
				greet = "午安";
				return greet;
			}
			else
			{
				greet = "晚安";
				return greet;
			}
			
		}

		private string  Message(string now, string greet)
		{
			string result = string.Empty;
			result = now + "\r\n" + greet;
			return result;
		}
	}
}
