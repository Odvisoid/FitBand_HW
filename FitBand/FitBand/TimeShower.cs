class TimeShower : ForFuncShow
    {
        public DateTime date = new DateTime();
        public TimeShower()
        {
            date = DateTime.Now;
        }
        public override void Show()
        {
            Console.WriteLine(date);
        }
    }