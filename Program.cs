using (EccomerceContext db = new EccomerceContext())
{
    //Inserimento prodotti
    Product product1 = new Product { Name = "Samsung" };
    Product product2 = new Product { Name = "Apple" };
    Product product3 = new Product { Name = "Windows" };
    product1.Description = "Lorem ipsum";
    product2.Description = "Lorem ipsum";
    product3.Description = "Lorem ipsum";
    db.Add(product1);
    db.Add(product2);
    db.Add(product3);
    db.SaveChanges();
}
