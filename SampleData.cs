using Azure.AI.AnomalyDetector;

namespace AnomalyDetectorUnivariateApi
{
    public static class SampleData
    {
        public static IEnumerable<TimeSeriesPoint> TimeSeries 
        { 
            get 
            {
                return new List<TimeSeriesPoint> 
                {
                    new TimeSeriesPoint(10.1f) {Timestamp = new DateTime(2023, 5, 1)},
                    new TimeSeriesPoint(10.9f) {Timestamp = new DateTime(2023, 5, 2)},
                    new TimeSeriesPoint(9.4f) {Timestamp = new DateTime(2023, 5, 3)},
                    new TimeSeriesPoint(10.3f) {Timestamp = new DateTime(2023, 5, 4)},
                    new TimeSeriesPoint(9.2f) {Timestamp = new DateTime(2023, 5, 5)},
                    new TimeSeriesPoint(12.6f) {Timestamp = new DateTime(2023, 5, 6)},
                    new TimeSeriesPoint(9.5f) {Timestamp = new DateTime(2023, 5, 7)},
                    new TimeSeriesPoint(9.0f) {Timestamp = new DateTime(2023, 5, 8)},
                    new TimeSeriesPoint(10.3f) {Timestamp = new DateTime(2023, 5, 9)},
                    new TimeSeriesPoint(10.9f) {Timestamp = new DateTime(2023, 5, 10)},
                    new TimeSeriesPoint(9.8f) {Timestamp = new DateTime(2023, 5, 11)},
                    new TimeSeriesPoint(11.1f) {Timestamp = new DateTime(2023, 5, 12)},
                    new TimeSeriesPoint(10.4f) {Timestamp = new DateTime(2023, 5, 13)},
                    new TimeSeriesPoint(9.1f) {Timestamp = new DateTime(2023, 5, 14)},
                    new TimeSeriesPoint(25.1f) {Timestamp = new DateTime(2023, 5, 15)},
                };
            } 
        }
    }
}