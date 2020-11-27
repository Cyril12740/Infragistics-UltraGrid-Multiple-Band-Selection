using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace TestGrilleEvenement.Data
{
    public class Evenement : IEvenement
    {
        public string Title { get; set; }

        public string Company { get; set; }

        public DateTime DateTime { get; set; }

        //Ne peut pas être récusif => Fait planter le designer (Obliger de créer une classe par niveau)
        public List<SubEvenement> Evenements { get; set; }

        [Browsable(false)]
        public Color Color { get; set; }
    }

    public interface IEvenement
    {
        string Title { get; set; }
        string Company { get; set; }
        DateTime DateTime { get; set; }
        Color Color { get; set; }
    }

    public class SubEvenement : IEvenement
    {
        public string Title { get; set; }

        public string Company { get; set; }

        public DateTime DateTime { get; set; }

        [Browsable(false)]
        public Color Color { get; set; }
    }
}