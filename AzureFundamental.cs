namespace web_api;

public class AzureFundamental
{
    public string TopicName { get; set; } = default!;

    public string WeightageInPercentage { get; set; } = default!;
}


public class AzureFundamentalDescription
{
    public  IEnumerable<AzureFundamental> GetCourseList()
    {
        return new List<AzureFundamental>()
        {
            new AzureFundamental()
            {
                TopicName = "Cloud Concepts",
                WeightageInPercentage = "25-30%"
            },
            new AzureFundamental()
            {
                TopicName = "Azure architecture and services",
                WeightageInPercentage = "35-40%"
            },
            new AzureFundamental()
            {
                TopicName = "Azure management and governance",
                WeightageInPercentage = "30-35%"
            }
        };
    }
}