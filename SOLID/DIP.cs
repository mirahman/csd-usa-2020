class Book {
    public void SeeReviews(){}
    public void ReadSample(){}
}

class Shelf {
    public Book book;

    public void Add(Book book){}
    public void CustomizeShelf(){}
}

class DVD {
    public void SeeReviews(){}
    public void WatchSample(){}
}

// DIP Applied 

interface IProduct {
     void SeeReviews();
     void GetSample();
}

class Book : IProduct {
    public void SeeReviews() {}
    public void GetSample() {}
}

class DVD : IProduct {
    public void SeeReviews() {}
    public void GetSample() {}
}

class Shelf {
    public IProduct product;

    public void Add(IProduct product){}
    public void CustomizeShelf(){}
}