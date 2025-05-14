using System;
using System.Text.RegularExpressions;

namespace KompleksneChysloApp
{
    public class Kompleksne_chyslo : Strichka
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Kompleksne_chyslo(string input) : base()
        {
            if (IsValid(input))
            {
                Text = input;
                ParseInput(input);
            }
            else
            {
                Text = "0і0";
                Real = 0;
                Imaginary = 0;
            }
        }

        public Kompleksne_chyslo(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
            Text = $"{Real}і{Imaginary}";
        }

        private void ParseInput(string input)
        {
            var parts = input.Split('і');
            Real = double.Parse(parts[0]);
            Imaginary = double.Parse(parts[1]);
        }

        private bool IsValid(string input)
        {
            string pattern = @"^[-+]?\d+(\.\d+)?і[-+]?\d+(\.\d+)?$";
            return Regex.IsMatch(input, pattern);
        }

        public Kompleksne_chyslo Add(Kompleksne_chyslo other)
        {
            return new Kompleksne_chyslo(this.Real + other.Real, this.Imaginary + other.Imaginary);
        }

        public Kompleksne_chyslo Multiply(Kompleksne_chyslo other)
        {
            double real = this.Real * other.Real - this.Imaginary * other.Imaginary;
            double imaginary = this.Real * other.Imaginary + this.Imaginary * other.Real;
            return new Kompleksne_chyslo(real, imaginary);
        }

        public bool EqualsTo(Kompleksne_chyslo other)
        {
            return this.Real == other.Real && this.Imaginary == other.Imaginary;
        }

        public override string ToString()
        {
            return $"{Real}і{Imaginary}";
        }
    }
}



