namespace MethotK_Lab_3_ClassLibrary
{
    public class State
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string FlagDescription { get; set; }
        public string Flower { get; set; }
        public string Color { get; set; }
        public string ThreeLargestCities { get; set; }
        public string Capital {  get; set; }
        public double MedianIncome { get; set; }
        public double ComputerRelatedJobsPercent{ get; set; }

        public State(string name, int population, string flagDescription, string flower, string color, string threeLargestCities, string capital, double medianIncome, double computerRelatedJobsPercent)
        {
            Name = name;
            Population = population;
            FlagDescription = flagDescription;
            Flower = flower;
            Color = color;
            ThreeLargestCities = threeLargestCities;
            Capital = capital;
            MedianIncome = medianIncome;
            ComputerRelatedJobsPercent = computerRelatedJobsPercent;
        }
    }
}
