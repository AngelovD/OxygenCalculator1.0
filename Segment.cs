using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxygenCalculator
{
    class Segment
    {
        private int id;
        private string name;
        private int lenght;
        private double entrySpeed;
        private double exitSpeed;
        private double entryOxygen;
        private double exitOxygen;
        private double height;
        private int startPoint;
        private int wetFloor;
        private int obstacles;


        public Segment(int id, string name, int lenght, double entrySpeed, double exitSpeed, double entryOxygen, double exitOxygen, double height, int startPoint, int wetFloor, int obstacles)
        {
            this.id = id;
            this.lenght = lenght;
            this.name = name;
            this.entrySpeed = entrySpeed;
            this.exitSpeed = exitSpeed;
            this.entryOxygen = entryOxygen;
            this.exitOxygen = exitOxygen;
            this.height = height;
            this.startPoint = startPoint;
            this.wetFloor = wetFloor;
            this.obstacles = obstacles;
        }
        public Segment(string name, int lenght, double entrySpeed, double exitSpeed, double entryOxygen, double exitOxygen, double height, int startPoint, int wetFloor, int obstacles)
        {
            this.lenght = lenght;
            this.name = name;
            this.entrySpeed = entrySpeed;
            this.exitSpeed = exitSpeed;
            this.entryOxygen = entryOxygen;
            this.exitOxygen = exitOxygen;
            this.height = height;
            this.startPoint = startPoint;
            this.wetFloor = wetFloor;
            this.obstacles = obstacles;
        }

        public int getID()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getLenght()
        {
            return this.lenght;
        }

        public double getEntrySpeed()
        {
            return this.entrySpeed;
        }

        public double getExitSpeed()
        {
            return this.exitSpeed;
        }
        public double getEntryOxygen()
        {
            return this.entryOxygen;
        }

        public double getExitOxygen()
        {
            return this.exitOxygen;
        }

        public double getHeight()
        {
            return this.height;
        }

        public int getStartPoint()
        {
            return this.startPoint;
        }

        public int getWetFloor()
        {
            return this.wetFloor;
        }

        public int getObstacles()
        {
            return this.obstacles;
        }
    }
}
