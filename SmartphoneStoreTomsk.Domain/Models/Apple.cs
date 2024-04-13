namespace SmartphoneStoreTomsk.Domain.Models
{
    public class Apple
    {
        public const int MAX_LEGHT_MODELAPLLE = 13;
        private Apple(Guid id, string model, string description, decimal price)
        {
            Id = id;
            Model = model;
            Description = description;
            Price = price;

        }
        public Guid Id { get; }
        public string Model { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }
        public int Quantity { get; }

        public static (Apple apple, string Error) Create(Guid id, string model, string description, decimal price)
        {

            var error = string.Empty;
            if (string.IsNullOrEmpty(model))
            {
                error = $"Поле не может быть пустым!!!! ";
            }
            else if (model.Length > MAX_LEGHT_MODELAPLLE)
            {
                error = "Большое количество символов в названии модели!!!! ";
            }
            else
            {
                var apple = new Apple(id, model, description, price);

                return (apple, error);

            }

        }

    } 
}
 

  
