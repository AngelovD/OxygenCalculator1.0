using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxygenCalculator
{
    class Apparatus
    {
        private int id;
        private string name;
        private string description;
        private double weight;
        private double volume;
        private double pressure;
        private int workTime;
        private double reserve;


        public Apparatus(int id, string name, string description, double weight, double volume, double pressure, int workTime, double reserve) 
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.volume = volume;
            this.pressure = pressure;
            this.workTime = workTime;
            this.reserve = reserve;
        }

        public Apparatus(string name, string description, double weight, double volume, double pressure, int workTime, double reserve)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.volume = volume;
            this.pressure = pressure;
            this.workTime = workTime;
            this.reserve = reserve;
        }

        public int getID()
        {
            return this.id;
        }
        
        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public double getWeight()
        {
            return this.weight;
        }

        public double getVolume()
        {
            return this.volume;
        }

        public double getPressure()
        {
            return this.pressure;
        }

        public int getWorkTime()
        {
            return this.workTime;
        }

        public double getReserve()
        {
            return this.reserve;
        }

    }
}
