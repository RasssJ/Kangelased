using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class SuperKangelane : Kangelased
    {
        private static readonly Random random = new Random();
        private double _osavus;

        public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht) {
            _osavus = random.NextDouble();
        }
        

        


        
            
        }
    }

