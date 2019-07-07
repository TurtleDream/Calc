using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Calc
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		float a, b;
		int count;

        public MainPage()
        {
            this.InitializeComponent();
			textBoxCalc.Text = "";
        }
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 1;
		}

		private void Btn2_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 2;
		}

		private void Btn3_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 3;
		}

		private void Btn4_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 4;
		}

		private void Btn5_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 5;
		}

		private void Btn6_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 6;
		}

		private void Btn7_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 7;
		}

		private void Btn8_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 8;
		}

		private void Btn9_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 9;
		}

		private void BtnFloat_Click(object sender, RoutedEventArgs e)
		{
			if (!textBoxCalc.Text.Contains(","))
			{
				if(textBoxCalc.Text.Length == 0)
				{
					textBoxCalc.Text = textBoxCalc.Text + '0';
				}
				textBoxCalc.Text = textBoxCalc.Text + ',';
			}
		}

		private void BtnClear_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = "";
		}

		private void BtnPlus_Click(object sender, RoutedEventArgs e)
		{
			if((textBoxCalc.Text.Length != 0) && (textBoxCalc.Text != "-"))
			{
				a = float.Parse(textBoxCalc.Text);
				textBoxCalc.Text = "";
				count = 1;
			}
		}

		private void BtnMinus_Click(object sender, RoutedEventArgs e)
		{
			if (textBoxCalc.Text.Length == 0) textBoxCalc.Text = "-";
			else if (textBoxCalc.Text.Equals("-")) textBoxCalc.Text = "";
			else
			{
				a = float.Parse(textBoxCalc.Text);
				textBoxCalc.Text = "";
				count = 2;
			}
		}

		private void BtnMultiply_Click(object sender, RoutedEventArgs e)
		{
			if((textBoxCalc.Text.Length != 0) && (!textBoxCalc.Text.Equals("-")))
			{
				a = float.Parse(textBoxCalc.Text);
				textBoxCalc.Text = "";
				count = 3;
			}
		}

		private void BtnShare_Click(object sender, RoutedEventArgs e)
		{
			if ((textBoxCalc.Text.Length != 0) && (!textBoxCalc.Text.Equals("-")))
			{
				a = float.Parse(textBoxCalc.Text);
				textBoxCalc.Text = "";
				count = 4;
			}
		}

		private void BtnEqually_Click(object sender, RoutedEventArgs e)
		{
			switch (count)
			{
				case 1:
					b = a + float.Parse(textBoxCalc.Text);
					textBoxCalc.Text = b.ToString();
					break;

				case 2:
					b = a - float.Parse(textBoxCalc.Text);
					textBoxCalc.Text = b.ToString();
					break;
				case 3:
					b = a * float.Parse(textBoxCalc.Text);
					textBoxCalc.Text = b.ToString();
					break;
				case 4:
					b = a / float.Parse(textBoxCalc.Text);
					textBoxCalc.Text = b.ToString();
					break;

				default:
					break;
			}
		}

		private void Btn0_Click(object sender, RoutedEventArgs e)
		{
			textBoxCalc.Text = textBoxCalc.Text + 0;
		}
	}
}
