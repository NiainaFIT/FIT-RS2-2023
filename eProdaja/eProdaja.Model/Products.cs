namespace eProdaja.Model
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductTypeId { get; set; }
        public int UnitOfMeasure { get; set; }
        public byte[] Image {  get; set; }
        public byte[] ThumbImage { get; set; }
        public bool? State {  get; set; }
        public string StateMachine {  get; set; }
    }
}
