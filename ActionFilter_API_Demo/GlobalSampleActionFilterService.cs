namespace ActionFilter_API_Demo
{
    public class GlobalSampleActionFilterService : IGlobalSampleActionFilterService
    {
        public GlobalSampleActionFilterService()
        {
                
        }
        public string GetName(string name)
        {
            return name;
        }
    }
}
