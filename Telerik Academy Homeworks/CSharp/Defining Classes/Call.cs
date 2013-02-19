using System;

    class Call
    {
        public DateTime DateTime
        { get; set; }
        public int Duration
        { get; set; }
        public string DailedPhone
        { get; set; }
        public Call(string dailedPhone, int duration)
        {
            this.Duration = duration;
            this.DailedPhone = dailedPhone;
            this.DateTime = DateTime.Now;
        }
        public Call(string dailedPhone, int duration, DateTime date)
        {
            this.Duration = duration;
            this.DailedPhone = dailedPhone;
            this.DateTime = date;
        }
    }

