using AnomalyDetectorUnivariateApi;
using Azure;
using Azure.AI.AnomalyDetector;

string endpoint = "<YOUR-ENDPOINT>";
string apiKey = "<YOUR-KEY>";

var endpointUri = new Uri(endpoint);
var credential = new AzureKeyCredential(apiKey);

AnomalyDetectorClient client = new AnomalyDetectorClient(endpointUri, credential);

IEnumerable<TimeSeriesPoint> data = SampleData.TimeSeries;

UnivariateDetectionOptions request = new UnivariateDetectionOptions(data)
{
    Granularity = TimeGranularity.Daily
};

var response = await client.DetectUnivariateLastPointAsync(request);

if(response!.Value.IsAnomaly)
    Console.WriteLine("Last time series point has anomaly"); 
else 
    Console.WriteLine("Last time series point has no anomaly");