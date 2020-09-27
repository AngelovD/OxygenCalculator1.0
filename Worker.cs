using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxygenCalculator
{
    public class Worker
    {
        private int id;
        private string name;
        private double height;
        private double weight;
        private double oxygenConsumption;
        private double speed;
        private double tireRate;
        private int apparatus;
        public Worker(int id,string name, double height, double weight, double oxygenConsumption, double speed, double tireRate, int apparatus)
        {
            this.id = id;
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.oxygenConsumption = oxygenConsumption;
            this.speed = speed;
            this.tireRate = tireRate;
            this.apparatus = apparatus;
        }

        public Worker( string name, double height, double weight, double oxygenConsumption, double speed, double tireRate, int apparatus)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.oxygenConsumption = oxygenConsumption;
            this.speed = speed;
            this.tireRate = tireRate;
            this.apparatus = apparatus;
        }

        public string getName()
        {
            return this.name;
        }

        public int getID()
        {
            return this.id;
        }

        public double getHeight()
        {
            return this.height;
        }

        public double getOxygenConsumption()
        {
            return this.oxygenConsumption;
        }

        public double getSpeed()
        {
            return this.speed;
        }
        public double getTireRate()
        {
            return this.tireRate;
        }
        public double getWeight()
        {
            return this.weight;
        }

        public int getApparatus()
        {
            return this.apparatus;
        }
    }
}
