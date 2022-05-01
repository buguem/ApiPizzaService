using System;
namespace ApiPizzaService.Entities
{
    public class Order
    {
        public Guid Id {get; init; }

        public string Name{get; init;}
        public string Adresse{get; init;}
        public int Items {get; init;}
        public decimal Price{get;init;}

        public DateTimeOffset CreatedDate{get;init;}


        

    }

}