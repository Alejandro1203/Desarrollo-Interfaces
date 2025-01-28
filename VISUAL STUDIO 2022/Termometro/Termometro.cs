using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Termometro.Properties;

namespace Termometro
{
    public partial class Termometro: UserControl
    {

        [Browsable(true)]
        [Category("!Creados")]
        [Description("Invocado al poner el valor maximo de temperatura")]
        public event EventHandler TermometroValueChanged;

        public Termometro()
        {
            InitializeComponent();

            
        }

        public int value
        {
            get
            {
                return valueTemperature.Value;
            }
        }

        public int maxValue
        {
            get{
                return valueTemperature.Maximum;
            }
        }

        public int cachopo
        {
            get
            {
                return valueTemperature.Value;
            }

            set 
            {
                if(value > 0 && value < 6)
                {
                    valueTemperature.Value = value;
                }

                if(value < 1)
                {
                    valueTemperature.Value = 1;
                }

                if (value > 5)
                {
                    valueTemperature.Value = 5;
                }
            }
        }

        private void valueTemperature_ValueChanged(object sender, EventArgs e)
        {
            switch (valueTemperature.Value)
            {
                case 1:
                    imageTemperature.Image = Resources.frozen;
                    break;

                case 2:
                    imageTemperature.Image = Resources.cold;
                    break;

                case 3:
                    imageTemperature.Image = Resources.coldHot;
                    break;

                case 4:
                    imageTemperature.Image = Resources.heat;
                    break;

                case 5:
                    imageTemperature.Image = Resources.abrassive_heat;
                    break;
            }

            if (this.TermometroValueChanged != null)
            {

            TermometroValueChanged(this, new EventArgs());
            }
        }
    }
}