using System;

    class GSMTest
    {
        private Battery battery = new Battery("Some Battery", 345, 23);
        private Display display = new Display(3.2, 16);
        private GSM[] array = new GSM[3];
        public GSM Array
        {
            get;
            set;
        }
        public GSMTest()
        {
            this.array[0] = new GSM("6110", "Nokia", "Pesho", 120, battery, display); //Use GSM's constructor to give array's values
            this.array[1] = new GSM("k510i", "Sony Ericsson", "Iordanka", 30);
            this.array[2] = new GSM("Ace", "Samsung", "Gosho", 230);
        }
        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString()); //Using the GSM's method for printing the information
            }

        }
        public void PrintIPhone()
        {
            Console.WriteLine(GSM.iPhone4S.ToString()); //Using the GSM's method for printing the information and the GSM's static field
        }
    }

