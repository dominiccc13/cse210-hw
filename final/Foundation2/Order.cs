using System.Net.Http.Headers;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer) {
        _products = products;
        _customer = customer;
    }

    public double TotalCost() {
        double price = 0;
        double shippingCost = _customer.InUSA() == true ? 5 : 35; 
        foreach (Product product in _products) {
            price += product.CalculatePrice();
        }
        return price + shippingCost;
    }

    public void PackingLabel() {
        System.Console.WriteLine("Packing Label");
        int i = 0;
        foreach (Product product in _products) {
            i++;
            System.Console.WriteLine($"\tItem {i}");
            System.Console.WriteLine($"\t - Name: {product.GetName()}");
            System.Console.WriteLine($"\t - ID: {product.GetID()}");
        }
        System.Console.WriteLine();
    }
    
    public void ShippingLabel() {
        System.Console.WriteLine("Shipping Label");
        System.Console.WriteLine($"\t{this._customer.GetName()}");
        System.Console.WriteLine($"\t{this._customer.GetAddress()}");
        System.Console.WriteLine();
    }
}