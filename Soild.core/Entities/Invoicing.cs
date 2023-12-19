namespace Soild.core.Entities
{
    public class Invoicing
    {
        public int Reception_number { get; set; }
        public string Id { get; set; }

        public DateTime Enter { get; set; }//זמן כניסה
        public DateTime Exiting { get; set; }//זמן יציאה
        public DateTime Date { get; set; }//תאריך
        public double Payment { get; set; }//סך הכל לתשלום
        public DateTime Dwell_time { get; set; }//סך הכל זמן שהייה
        public Status Kind { get; set; }//סוג תשלום

    }
}
