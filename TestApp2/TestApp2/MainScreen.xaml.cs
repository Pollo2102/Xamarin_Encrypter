using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainScreen : ContentPage
	{
		public MainScreen ()
		{
			InitializeComponent ();
		}

        private void encryptButton_Clicked (object sender, EventArgs e)
        {
            String tempString = EncryptText(textEntry.Text);

            displayLabel.Text = tempString;
        }

        enum Letters
        {
            d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,a,b,c
        }

        public String EncryptText(String targetText)
        {
            String encryptedString = null;

            for (int i = 0; i < targetText.Length; i++)
            {
                encryptedString += Enum.GetName(typeof(Letters), ((int)targetText[i] % 26));
            }

            return encryptedString;
        }

        public String DecryptText(String targetText)
        {
            String decryptedText = null;


            return decryptedText;
        }
	}
}