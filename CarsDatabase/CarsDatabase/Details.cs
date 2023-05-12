namespace CarsDatabase
{
    internal class Details
    {
        string vehicleReg;
        string make;
        string engine;
        string dateReg;
        string rentalPerDay;
        int available;
        string sAvailable;

        public string VehicleReg
        {
            get { return vehicleReg; }
            set { vehicleReg = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string DateReg
        {
            get { return dateReg; }
            set { dateReg = value; }
        }

        public string RentalPerDay
        {
            get { return rentalPerDay; }
            set
            {
                rentalPerDay = value;
            }
        }

        public int Available
        {
            get { return available; }
            set
            {
                if (value == 1)
                {
                    SAvailable = "Yes";
                }
                else if (value == 0)
                {
                    SAvailable = "No";
                }
            }
        }

        public string SAvailable
        {
            get { return sAvailable; }
            set
            {
                sAvailable = value;
            }
        }
    }
}
