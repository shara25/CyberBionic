using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Converter.
//  В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и
//  инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//  Converter(double usd, double eur, double rub).
//  Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также
//  программа должна производить конвертацию из указанных валют в гривну.

namespace Ex2
{
    class Converter
    {
        private double usd; // 27.78
        private double eur; // 32.92
        private double rub; // 0.36

        //----------------------------------------Свойства-------------------------------------------------------

        public double Usd
        {
            get
            {
                return usd;
            }

            set
            {
                usd = value;
            }
        }

        public double Eur
        {
            get
            {
                return eur;
            }

            set
            {
                eur = value;
            }
        }

        public double Rub
        {
            get
            {
                return rub;
            }

            set
            {
                rub = value;
            }
        }
        // ---------------------------------------Конструктор------------------------------------------------
      
        public Converter (double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        // ---------------------------------------Методы перевода в гривну------------------------------------------------

        public double ConvertFromUsd(double valueUsd)
        {
            return 27.78 * valueUsd;
        }
        public double ConvertFromEur(double valueEur)
        {
            return 32.92 * valueEur;
        }
        public double ConvertFromRub(double valueRub)
        {
            return 0.36 * valueRub;
        }

        // ---------------------------------------Методы перевода в валюту------------------------------------------------

        public double ConvertToUsd(double valueGrn)
        {
            double remainder = valueGrn % 27.78;
            double sum = valueGrn / 27.78;
            return sum + remainder;
        }
        public double ConvertToEur(double valueGrn)
        {
            double remainder = valueGrn % 32.92;
            double sum = valueGrn / 32.92;
            return sum + remainder;
        }
        public double ConvertToRub(double valueGrn)
        {
            double remainder = valueGrn % 0.36;
            double sum = valueGrn / 0.36;
            return sum + remainder;
        }
    }
}
