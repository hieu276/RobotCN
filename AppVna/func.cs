class Program
    {
        public class Data
        {
           public int id;
           public float humidity;
           public float temperature;

            public Data(int id, float humidity, float temperature)
            {
                this.id = id;
                this.humidity = humidity;
                this.temperature = temperature;
            }
        }
		
		public static string[] ProcessData(string data)
        {
            return data.Split('|');           
        }
		
		public static string Action(string id, string rate)
		{
			rate = rate.PadLeft(3, '0');
			return id + '|' + rate;
		}
		
        static void Main(string[] args)
        {
            string test = "1|75|27";

            string[] data = ProcessData(test);
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("   "+ data[i] );

            }
            Console.ReadKey();

        }
        
    }