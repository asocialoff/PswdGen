/*                 Copyright [2018-2019] [Asocial]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
 */

using System;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Threading;

/*
 *  by asocial
 *  free for private and commercial use
 *  just make sure to credit me
 */

/* to do :
 * 
 * voir pourquoi la checkbox numbers ne marche pas
 * 
 */

namespace PswdGenerator
{

    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        const int DEFAULT_MIN_PASSWORD_LENGHT = 8;
        const int DEFAULT_MAX_PASSWORD_LENGHT = 16;

        bool forceUpperCase = false;
        bool forceLowerCase = false;
        bool forceSymbol = false;
        bool forceNumber = false;

        int minLowerCase = 2;
        int minUpperCase = 2;
        int minSymbol = 2;

        int minLenght = DEFAULT_MIN_PASSWORD_LENGHT;
        int maxLenght = DEFAULT_MAX_PASSWORD_LENGHT;
        private int minNumber = 2;

        bool nonecheckbox = true;

        private void ForceLC_CheckedChanged(object sender, EventArgs e)
        {
            if(!forceLowerCase)
            {
                forceLowerCase = true;
                nonecheckbox = false;
            }
            else
            {
                forceLowerCase = false;
            }
        }

        private void ForceUC_CheckedChanged(object sender, EventArgs e)
        {
            if (!forceUpperCase)
            {
                nonecheckbox = false;
                forceUpperCase = true;
            }
            else
            {
                forceUpperCase = false;
            }
        }

        private void ForceS_CheckedChanged(object sender, EventArgs e)
        {
            if (!forceSymbol)
            {
                nonecheckbox = false;
                forceSymbol = true;
            }
            else
            {
                forceSymbol = false;
            }
        }

        private void ForceN_CheckedChanged(object sender, EventArgs e)
        {
            if (!forceLowerCase)
            {
                nonecheckbox = false;
                forceNumber = true;
            }
            else
            {
                forceNumber = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int val = 8; // avoid errors with out of range index

            minLenght = val;
            maxLenght = val;

            LenghtLabel.Text = "Lenght : " + trackBar.Value;
            minLenght = trackBar.Value;
            maxLenght = trackBar.Value;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            if (nonecheckbox)
            {
                MessageBox.Show("You should choose at less one case.");
            }
            else
            {
                pswdBox.Text = PswdGen.Generate(minLenght, maxLenght, forceUpperCase, forceLowerCase, forceSymbol, forceNumber, 2, 2, 2, 2);
            } 
        }
    }
}
