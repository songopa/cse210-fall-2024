using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(1, "sneakers", 2, 42000);
        Product product2 = new Product(2, "loafers", 4, 33000);
        Product product3 = new Product(3, "sandals", 6, 18000);
        Product product4 = new Product(4, "trouser", 2, 22000);
        Product product5 = new Product(5, "jeans", 4, 16000);

        Customer customer1 = new Customer("James McLurkin", "Wallpaper & Kingstston", "Idaho", "Utah", "USA");
        Customer customer2 = new Customer("Astra Yohanes", "Police mabatini", "Chilao", "Kilimanjaro", "Tanzania");

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProductToOrder(product1);
        order1.AddProductToOrder(product2);
        order1.AddProductToOrder(product5);
        
        order2.AddProductToOrder(product3);
        order2.AddProductToOrder(product4);
        order2.AddProductToOrder(product1);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            order.DisplayOrderDetails();
        }
        
    }
}