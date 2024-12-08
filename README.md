# **CustomerWebAPI**

`CustomerWebAPI` is a RESTful API built with ASP.NET Core for managing customers, products, orders, and order details. The API interacts with the `CustomerDemoDB` database to provide endpoints for CRUD operations and data retrieval.

---

## **Features**
- Manage customers, products, orders, and order details.
- Supports basic CRUD (Create, Read, Update, Delete) operations.
- Provides endpoints for querying customer order summaries and other insights.

---

## **Setup Instructions**

### **1. Prerequisites**
- [.NET SDK](https://dotnet.microsoft.com/download) (latest version)
- SQL Server instance with the `CustomerDemoDB` database set up.
- Postman or a similar tool for testing API endpoints.

### **2. Configuration**
1. Open the `appsettings.json` file.
2. Update the connection string to point to your SQL Server instance:
   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=your_server_name;Database=CustomerDemoDB;Trusted_Connection=True;"
       }
   }

### **3. Order Endpoints**

| Method | Endpoint            | Description                          |
|--------|----------------------|--------------------------------------|
| GET    | `/api/Orders`        | Retrieve all orders.                 |
| GET    | `/api/Orders/{id}`   | Retrieve a specific order by ID.     |
| POST   | `/api/Orders`        | Add a new order.                     |
| PUT    | `/api/Orders/{id}`   | Update an existing order by ID.      |
| DELETE | `/api/Orders/{id}`   | Delete an order by ID.               |


### **4. Order Details Endpoints**

| Method | Endpoint                | Description                            |
|--------|--------------------------|----------------------------------------|
| GET    | `/api/OrderDetails`      | Retrieve all order details.            |
| GET    | `/api/OrderDetails/{id}` | Retrieve specific order details by ID. |
| POST   | `/api/OrderDetails`      | Add new order details.                 |
| PUT    | `/api/OrderDetails/{id}` | Update existing order details by ID.   |
| DELETE | `/api/OrderDetails/{id}` | Delete order details by ID.            |
