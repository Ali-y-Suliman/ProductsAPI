# UsersAPI


## Installation and Setup:

1- clone the repo
```bash
git clone https://github.com/Ali-y-Suliman/ProductsAPI.git
```

2- install dotnet ef:
```bash
dotnet tool install --global dotnet-ef
```

3- run dotnet build:
```bash
dotnet build
```

4- create the database:
```bash
dotnet ef database update
```

5- run the project:
```bash
dotnet run
```

**Note**: to run swagger:
```bash
dotnet watch run
```

---

## Usage:

UsersAPI provides the following endpoints:

* POST  /api/Products - Add a new product in the system.

* GET  /api/Products - Get All Products.

* GET  /api/Products/{id} - Get one Product by id.

* PUT  /api/Products/id?id={value} - Update Product.

* Delete  /api/Products/id?id={value} - Delete Product.

### Add Product (POST /api/Products)
Endpoint: /api/Products

Request Body:
```
{
  "id": 1,
  "name": "Apple",
  "category": "Fruit",
  "price": 10.5,
  "stock": 2
}
```

### Update Product (Put /api/Products/id?id={value})
Endpoint: /api/Products/id?id=1

Request Body:
```
{
  "id": 1,
  "name": "Apple",
  "category": "Fruit",
  "price": 10.5,
  "stock": 2
}
```
